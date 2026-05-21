---
title: Onboard a custom agent to the Recommended Actions Agent
description: Recommended actions is an intelligent capability that shows prioritized actions so sellers focus on the most effective tasks for their opportunities. 
ms.date: 05/19/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Onboard a custom agent to the Recommended Actions Agent

The **Recommended Actions Agent** is a prioritization engine that:

1. **Ingests** raw action cards from multiple upstream agents such as Sales Opportunity Risk Agent, Data Enrichment Agent, and custom agents.
1. **Scores** each action on four dimensions — **Urgency, Impact, Confidence, Effort** (UICE framework, 0–10 each).
1. **Ranks** actions across all agents using a configurable priority formula.
1. **Surfaces** the top 5 actions in the Recommended Actions Agent carousel in Dynamics 365 Sales.

Your agent pushes actions into the Recommended Actions Agent pipeline via a Custom API. Recommended Actions Agent handles everything downstream: prioritization, deduplication, versioning, and UI rendering.

## Integration architecture

### Processing Pipeline

1. **Your agent** detects an actionable insight (for example, a deal risk, a stalled deal, or a missing stakeholder).
1. **Your agent calls** `msdyn_PushActionDataToRecommendedActionAgent` Custom API to push the action.
1. The action is persisted in `msdyn_rawactioncatalogue` (input table).
1. For each action, the **Scoring Engine** (on the CoPilot Service Fabric service `RecommendedActionsAgentServices`):
   - Fetches entity signals from Dataverse.
   - Fetches agent-specific prioritization data from the action catalogue.
   - Calls LLM (via CAPI) to score on UICE dimensions.
   - Applies floor/ceiling.
   - Computes final priority score: `U × 0.30 + I × 0.35 + C × 0.20 − E × 0.15 + PP × 0.05`.
1. Scored action is upserted into `msdyn_prioritizedactioncatalogue` (output table).
1. **Recommended Actions Agent Carousel** fetches scored actions via `msdyn_RAAgent_FetchScoredRecommendedActions` and renders cards.

### Key components

| Component | Location | Description |
|-----------|----------|-------------|
| Input table | `msdyn_rawactioncatalogue` (Dataverse) | Raw actions that upstream agents push |
| Output table | `msdyn_prioritizedactioncatalogue` (Dataverse) | Scored and ranked actions for the UI |
| Agent config | `msdyn_recommendedactionsourceagentconfig` (Dataverse) | Per-agent registration and configuration |
| Run tracking | `msdyn_recommendedactionrundetails` (Dataverse) | Processing state for each action |
| Push API | `msdyn_PushActionDataToRecommendedActionAgent` (Custom API) | Agent → Recommended Actions Agent action push |
| Scoring Engine | `RecommendedActionsAgentServices` (SF microservice) | DTF orchestration + LLM scoring |
| Fetch API | `msdyn_RAAgent_FetchScoredRecommendedActions` (Custom API) | UI → scored actions fetch |
| Solution | `NextBestActionAgent` (Dataverse solution) | Contains all entities, APIs, plugins, FCS |

## Prerequisites

Before onboarding, make sure that the following prerequisites are met:

- **NextBestActionAgent** solution is deployed to the target org.
- **Feature Control Setting** `SalesService.NextBestAction:EnableNBASuggestions` is set to `true`.
- **Feature Control Setting** `SalesService.NextBestAction:EnableRecommendedActionsAgent` is set to `true` (or not explicitly `false`).
- **RecommendedActionsAgentServices** SF microservice is deployed and healthy (CoPilot Service Fabric app).
- Your agent has appropriate **Dataverse security roles** to call the `msdyn_PushActionDataToRecommendedActionAgent` API (requires `prvWritemsdyn_rawactioncatalogue` privilege).
- You have a stable, unique **SourceAgentId** string for your agent (such as `"DealClosingAgent"`, `"SQAAgent"`).

## Step 1: Register your agent (source agent config)

Add the agent to your organization through the agent creation process described in [Add custom agents for recommended actions](../configure-recommended-actions.md#add-custom-agents-for-recommended-actions). During agent creation, select the option to add the agent to the recommended actions framework and provide the necessary information about the agent.  
Register the agent in the `msdyn_recommendedactionsourceagentconfig` table. The Recommended Actions Agent uses this table to recognize and fetch actions from your agent. 
The key field that links your agent to the recommended actions framework is the `msdyn_internalprioritizationinstruction` field in the `msdyn_syncactionexecutionstateapiconfig` table. This field should match the `SourceAgentId` value you use when pushing actions via the API.

Open and update the table as needed to configure the agent's behavior in the recommended actions framework.  

**Request JSON schema:**

```json
{
  "agentName": "YourAgentName",
  "agentType": "CustomAgent",
  "isRecommendedActionAgentEnabled": true,
  "salesAgentProfileId": "<your-sales-agent-profile-guid-or-omit-to-auto-create>",
  "agentImpactMapping": "[\"Risk Mitigation\",\"Deal Velocity\"]",
  "internalPrioritizationInstruction": "{\"signals\":[...]}",
  "syncActionExecutionStateApiConfig": "{\"syncactionuistatusapiname\":\"your_SyncBackCustomApiName\"}",
  "description": "Brief description of your agent"
}
```

> [!IMPORTANT]
> Don't pass `recommendedActionSourceAgentConfigId`. The plugin resolves the target record by looking up an existing config via `salesAgentProfileId`. If no record exists, the plugin creates a new one. If `agentType` is `"CustomAgent"` and no `salesAgentProfileId` is provided, the plugin auto-creates and activates a new `msdyn_salesagentprofile` record.

**Response:** JSON with the upserted record ID and success status.

**Full request fields** (from `UpsertRecommendationAgentConfigRequest.cs`):

| JSON Field | Type | Description |
|-----------|------|-------------|
| `agentName` | string | Maps to `msdyn_agentname` (max 850 chars). Required for new records. |
| `agentType` | string | Agent category. Use `"CustomAgent"` for non-Sales Opportunity Agent agents to auto-create a profile. |
| `isRecommendedActionAgentEnabled` | boolean | Maps to `msdyn_isrecommendedactionagentenabled`. Null = leave unchanged. |
| `salesAgentProfileId` | guid? | Links to `msdyn_salesagentprofile`. Used for record lookup on upsert. |
| `agentImpactMapping` | string | Flat JSON array of principle names (see below). Maps to `msdyn_agentimpactmapping`. |
| `internalPrioritizationInstruction` | string | JSON with `signals` array (see below). Maps to `msdyn_internalprioritizationinstruction`. |
| `syncActionExecutionStateApiConfig` | string | JSON object `{"syncactionuistatusapiname":"..."}`. Maps to `msdyn_syncactionexecutionstateapiconfig`. |
| `sourceAgentUniqueId` | string | Maps to `msdyn_sourceagentuniqueid`. Only written on create, ignored on update. |
| `description` | string | Maps to `msdyn_sourcedescription` (max 1000 chars). |

### Agent impact mapping

Maps your agent's actions to Recommended Actions Agent's prioritization principles. The scoring engine uses this mapping to weight your actions.

**Format:** A **flat JSON array of strings** — each string is a numeric optionset value. For example, if your agent focuses on Risk Reduction (4) and Deal Velocity (2), you can pass:

```json
["4", "2"]    
```

**Available prioritization principles** (from the global optionset `msdyn_RecommendedActionAgent_SalesPrioritizationPrinciples`):

| Optionset Value | Label (use in `agentImpactMapping`) | Code Constant | Description |
|:-:|-----------|----------|-------------|
| — | Org Custom Priorities | `PrincipleOrgCustomPriorities` | Admin-defined overrides — always highest weight |
| 1 | Revenue Generation | `PrincipleRevenueGeneration` | Actions that directly progress late-stage opportunities toward close |
| 2 | Deal Velocity | `PrincipleDealVelocity` | Unblock stalled deals and accelerate progression |
| 3 | Pipeline Generation | `PrinciplePipelineGeneration` | Generate new qualified pipeline (lead qualification, upsell/cross-sell) |
| 4 | Risk Reduction | `PrincipleRiskMitigation` | Address competitor threats, engagement silence, missing stakeholders |
| 5 | Customer Sentiment | `PrincipleCustomerSentiment` | Improve relationship health, respond to negative sentiment |
| 6 | Data Hygiene | `PrincipleDataHygiene` | CRM data quality — only when fields impact forecasting |
| 7 | Stakeholder Coverage | `PrincipleStakeholderCoverage` | Ensure decision-maker engagement, multi-threaded relationships |

You can pass the numeric optionset value and the `ResolvePrincipleDisplayValue()` method resolves it:

- **Numeric** → matched against `OptionSetValue` or `Rank` in the org's `PrioritizationPrinciples` config (from `msdyn_salesagentconfigurationv2`)
- **No match** → raw value passed through as-is

### Internal prioritization instruction

Agent-specific signal metadata that tells the scoring engine how to interpret your agent's prioritization data fields.

**Format:** A JSON object with a top-level `signals` array. Each signal is deserialized into `AgentSignalInstructionConfig` with these fields:

| Field | Type | Description |
|-------|------|-------------|
| `name` | string | Signal identifier - used as the key in the scoring prompt's Signal Reference section |
| `type` | string | Data type: `"string"`, `"number"`, `"boolean"` |
| `source` | string | Descriptive label for where the signal comes from. Not used for routing - `fetch_info.fetch_type` controls the actual fetch mechanism. Typically `"action_data"` for agent-pushed signals. |
| `dimension_influence` | `{dimension: strength}` | Which UICE dimensions this signal affects and how strongly. Keys: `"urgency"`, `"impact"`, `"confidence"`, `"effort"`. Strengths: `"strong"`, `"moderate"`, `"weak"` |
| `interpretation` | string | Natural-language description of what the signal means for scoring - injected into the LLM prompt |
| `reliability` | string | How reliable this signal is: `"high"`, `"medium"`, `"low"` |
| `required` | boolean | Whether the signal must be present for scoring |
| `fetch_info` | object | Controls where and how the signal value is retrieved at scoring time. See [Fetch info](#fetch-info-fetchtype-values) section below. |

<a name="fetch-info-fetchtype-values"></a>
#### Fetch info - `fetch_type` values

The `fetch_type` field inside `fetch_info` determines **how** the scoring engine retrieves the signal value. The following types are supported (from `SignalFetchService.cs`):

| `fetch_type` | What it does | `crm_field` meaning | 
|---|---|---|
|**`action_data`** | Reads the value from the per-action `msdyn_prioritizationdata` JSON. **This is what custom agents should use.** | JSON property key to look up in `msdyn_prioritizationdata`. Falls back to `name` if omitted. | 

> [!NOTE]
> - **For custom agents:** Use `fetch_type: "action_data"` for your agent-specific signals. Agent-level signals from `internalPrioritizationInstruction` **are** merged into the unified signal list via `MergeAgentSignals()` and all fetch types are dispatched. However, there's a **critical limitation**: the merge only copies `FetchType` and `CrmField` from your signal config - it doesn't copy `SourceEntityName`, `TargetEntityName`, `SourceEntityField`, `SelectField`, `AggregationType`, `Derivation`, `FilterField`, `FilterValue`, `JsonPath`, or `ValueType`.
>
> **What this means in practice:**
> - **`action_data` works perfectly** - it only needs `CrmField` (the JSON key in `msdyn_prioritizationdata`)
> - **`entity_field` silently fails** - the engine filters by `s.FetchInfo?.SourceEntityName == actionData.EntityTypeName`, but `SourceEntityName` is null after merge, so the signal is skipped
> - **`linked_entity`**, **`aggregation`**, **`derived_insight`** also fail - they require `TargetEntityName`, `SourceEntityField`, etc. which aren't copied
>
> If you need CRM-fetched signals (entity fields, linked entities, aggregations), configure these at the **org level** in `msdyn_salesagentconfigurationv2` - they're shared across all agents. Your `internalPrioritizationInstruction` should only define `action_data` signals that read from your per-action `msdyn_prioritizationdata` JSON.

#### Examples per `fetch_type`

```json
{
  "signals": [
    {
      "name": "risk_type",
      "type": "string",
      "source": "action_data",
      "dimension_influence": { "urgency": "moderate", "confidence": "weak" },
      "interpretation": "Risk category code assigned by the source agent (e.g. 8 = Missing BANT Info). Used for pre-filter rule matching and prompt context.",
      "reliability": "high",
      "required": false,
      "fetch_info": { "fetch_type": "action_data", "crm_field": "riskType" }
    },
    {
      "name": "risk_label",
      "type": "string",
      "source": "action_data",
      "dimension_influence": { "urgency": "weak", "confidence": "weak" },
      "interpretation": "Human-readable risk name from the source agent (e.g. 'Missing BANT Info', 'Stalled Pipeline'). Useful for prompt context and seller explanation.",
      "reliability": "high",
      "required": false,
      "fetch_info": { "fetch_type": "action_data", "crm_field": "risk" }
    }
  ]
}
```

### How the three configs correlate (signal pipeline)

The three configuration fields form a **three-layer signal pipeline** that feeds the LLM scoring prompt:

| Layer | Scope | Purpose | Example |
|---|---|---|---|
| `agentImpactMapping` | Agent config (per agent) | Defines which principles the agent serves. | `["1", "4"]` |
| `internalPrioritizationInstruction` | Agent config (per agent) | Explains how the LLM should interpret your signals. | `signals[].interpretation`, `dimension_influence` |
| `msdyn_prioritizationdata` | Per action (push API payload) | Carries actual signal values for each action. | `{"riskType":"8","risk":"Missing BANT Info"}` |

**Sales Opportunity Agent example for correlation**

| `internalPrioritizationInstruction` signal | `fetch_info.crm_field` | `msdyn_prioritizationdata` key | Example value |
|---|---|---|---|
| `risk_type` | `"riskType"` | `riskType` | `"8"` |
| `risk_label` | `"risk"` | `risk` | `"Missing BANT Info"` |

So Sales Opportunity Agent's per-action `msdyn_prioritizationdata` JSON looks like:
```json
{"riskType": "8", "risk": "Missing BANT Info"}
```

**To onboard your own agent, follow the same pattern:**

1. Define signals in `internalPrioritizationInstruction` with `fetch_type: "action_data"` and a `crm_field` key.
1. When pushing actions via `msdyn_PushActionDataToRecommendedActionAgent`, set `msdyn_ActionPrioritizationData` to a JSON object using those same keys.
1. If the keys don't match, the signal value is `null` and the LLM treats it as missing.

**How `dimension_influence` affects scoring:**

Each signal's `dimension_influence` is rendered into the prompt's Signal Reference like:

```
**risk_type** (string, source: agent): Risk category code... [urgency(moderate), confidence(weak)] reliability=high
```

The LLM uses these hints as guidance (not hard multipliers) to determine how strongly each signal affects each UICE dimension score.

### Sync action execution state API config

**Format:** A JSON object (not a plain string) specifying the Custom API name that Recommended Actions Agent calls when a seller acts on your card, such as marking it as complete or irrelevant. This API sets the status of the action in the source custom agent.

```json
{
  "syncactionuistatusapiname": "your_SyncBackCustomApiName"
}
```

**Sales Opportunity Agent's actual value:** `{"syncactionuistatusapiname":"msdyn_SyncDealRiskActionFromNba"}`

## Step 2: Push actions via custom API

**API:** `msdyn_PushActionDataToRecommendedActionAgent`

Call this API each time your agent generates or updates an action for a target entity.

### Request parameters

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `msdyn_ActionId` | string | **Yes** | Your agent's unique identifier for this action. Used for deduplication and state sync. Must be deterministic (same action = same ID). Example format: `"DealRisk_{opportunityId}_{riskType}"` |
| `msdyn_SourceAgentId` | string | **Yes** | Your agent's identifier. Must match the `msdyn_agentname` in your agent config record. Example: `"DealClosingAgent"` |
| `msdyn_TargetEntityId` | uniqueidentifier (GUID) | **Yes** | The GUID of the target record (Opportunity, Lead) this action relates to |
| `msdyn_TargetEntityTypeName` | string | **Yes** | Logical name of the target entity. Example: `"opportunity"`, `"lead"` |
| `msdyn_ActionReason` | string | **Yes** | Reason why the action was generated. Used by the scoring engine for principle mapping. Example: `"Competitor Intel mentioned in recent email"` |
| `msdyn_ActionUIPayload` | string | No | JSON payload for card rendering (see [Step 3](#step-3-action-ui-payload-contract)). If omitted, Recommended Actions Agent can't display the card. |
| `msdyn_ActionPrioritizationData` | string | No | JSON with agent-specific data for scoring (see [Step 4](#step-4-prioritization-data-contract)) |
| `msdyn_ActionCTA` | string | No | CTA type string. Example: `"Email"`, `"Review"`, `"Call"` |
| `msdyn_PrioritizationPrinciples` | string | No | JSON array of prioritization principles this specific action maps to (can override agent-level mapping) |

### Response Properties

| Property | Type | Description |
|----------|------|-------------|
| `msdyn_IsSuccess` | boolean | Whether the action was successfully persisted |
| `msdyn_Error` | string | Error message if `IsSuccess` is false |

### Example Call (C# Plugin)

```csharp
var request = new OrganizationRequest("msdyn_PushActionDataToRecommendedActionAgent");
request["msdyn_ActionId"] = $"DealRisk_{opportunityId}_{riskType}";
request["msdyn_SourceAgentId"] = "DealClosingAgent";
request["msdyn_TargetEntityId"] = opportunityId;       // Guid
request["msdyn_TargetEntityTypeName"] = "opportunity";
request["msdyn_ActionReason"] = "Customer has not responded in 14 days, deal is at risk of stalling";
request["msdyn_ActionUIPayload"] = JsonConvert.SerializeObject(new
{
    version = 1.0,
    header = "Follow up with Contoso",
    description = "No customer response in 14 days. Deal may stall without re-engagement.",
    oncardClickActionType = "Navigate",
    oncardClickActionTypeParameters = $"{{\"etn\":\"opportunity\",\"id\":\"{opportunityId}\",\"pagetype\":\"entityrecord\"}}"
});
request["msdyn_ActionPrioritizationData"] = JsonConvert.SerializeObject(new[]
{
    new { signalName = "riskType", value = "14" },
    new { signalName = "risk", value = "low" }
});

var response = orgService.Execute(request);
bool success = (bool)response["msdyn_IsSuccess"];
```

## Step 3: Action UI payload contract

The `msdyn_ActionUIPayload` field contains a JSON payload that controls how your action card appears in the Recommended Actions Agent carousel.

### Schema

```json
{
  "version": 1.0,
  "header": "Follow up with Contoso on pricing proposal",
  "description": "Stakeholder engagement has dropped. The customer expressed interest in the enterprise tier but hasn't responded to the last proposal sent 10 days ago.",
  "oncardClickActionType": "Navigate",
  "oncardClickActionTypeParameters": "{\"etn\":\"opportunity\",\"id\":\"<guid>\",\"pagetype\":\"entityrecord\"}",
  "onctaClickActionType": "Navigate",
  "onctaClickActionTypeParameters": "{\"etn\":\"opportunity\",\"id\":\"<guid>\",\"pagetype\":\"entityrecord\"}"
}
```

| Field | Required | Description |
|-------|----------|-------------|
| `version` | Yes | Schema version. Use `1.0`. |
| `header` | Yes | Card header text — one-line action summary. Maps to `SuggestedActionItem.Title`. |
| `description` | Yes | Card body text — detailed explanation. Maps to `SuggestedActionItem.Description`. |
| `oncardClickActionType` | No | What happens when seller clicks the card. Currently only `"Navigate"` is supported. |
| `oncardClickActionTypeParameters` | No | JSON string with navigation parameters. Must include `etn` (entity type), `id` (GUID), `pagetype`. |
| `onctaClickActionType` | No | What happens when seller clicks the Go to record form option. |
| `onctaClickActionTypeParameters` | No | JSON string with CTA navigation parameters. |

## Step 4: Prioritization Data Contract

The `msdyn_prioritizationdata` field lets you pass agent-specific signals that influence how the UICE scoring engine prioritizes your action.

### Schema

```json
[
  { "signalName": "risk", "value": "low" },
  { "signalName": "riskType", "value": "4" }
]
```

### How this data is used

1. The scoring engine reads these signals alongside entity-level signals (deal value, stage, competitors, and more).
1. Your `msdyn_internalprioritizationinstruction` from the agent config tells the LLM how to interpret each signal.
1. The scoring engine combines signals into the UICE scoring prompt.

## Step 5: Handle action updates (versioning)

When your agent has updated data for a previously pushed action, **create a new record** with the same `msdyn_ActionId` by calling `msdyn_PushActionDataToRecommendedActionAgent` again.

### How versioning works

1. The system creates a new row in `msdyn_rawactioncatalogue` with the same `msdyn_actionid` but a new `msdyn_rawactioncatalogueid`.
1. **Recommended Actions Agent keeps showing the old version** until it processes the new version.

### Invalidating an action 

If an action is no longer valid (for example, the risk was resolved):

- Call `msdyn_RAAgent_RemoveActionsV2` Custom API with the `actionId`.
- This process marks all `msdyn_rawactioncatalogue` records for that action as `Inactive`.
- The card disappears from the carousel.

## Step 6: Bidirectional state sync

1. Recommended Actions Agent to your agent (seller acts in carousel).  
    When a seller marks an action as **Done** or **Dismissed** in the Recommended Actions Agent carousel:

    1. Recommended Actions Agent updates the `msdyn_actionuistatus` in `msdyn_prioritizedactioncatalogue`.
    1. Recommended Actions Agent reads your `msdyn_syncactionexecutionstateapiconfig` from the agent config.
    1. Recommended Actions Agent calls your Custom API with:

        | Parameter | Type | Description |
        |-----------|------|-------------|
        | `actionid` | GUID | The action identifier |
        | `state` | string | `"MarkedDone"` or `"Dismissed"` |

    **You must implement a Custom API** that accepts these two parameters and updates the action state in your own data store.

1. Your agent to Recommended Actions Agent (seller acts in your UI).  
    When a seller acts on an action in **your** UI (for example, marks as mitigated on the custom agent page), sync that state to Recommended Actions Agent:

    **API:** `msdyn_SyncActionExecutionStateFromAgent`

    | Parameter | Type | Required | Description |
    |-----------|------|----------|-------------|
    | `msdyn_ActionId` | string | Yes | The action identifier (same as what you pushed) |
    | `msdyn_ActionState` | integer | Yes | New state - values TBD (mapped to MarkAsDone/Dismissed) |
    | `msdyn_TargetEntityId` | uniqueidentifier | Yes | Target entity GUID |
    | `TargetEntityTypeName` | string | Yes | Target entity logical name |
    | `msdyn_TrackingId` | string | No | Optional tracking/correlation ID |

    This action updates the state in the Recommended Actions Agent output table, hiding it from the carousel.

## Step 7: Testing and validation

After you complete the configuration and implementation, test the end-to-end flow: 

1. Verify agent config.

    ```http
        GET [org-url]/api/data/v9.2/msdyn_recommendedactionsourceagentconfigs
        ?$filter=msdyn_agentname eq 'YourAgentName'
        &$select=msdyn_agentname,msdyn_agentimpactmapping,msdyn_internalprioritizationinstruction,msdyn_syncactionexecutionstateapiconfig
    ```

1. Push a test action.  
    Call `msdyn_PushActionDataToRecommendedActionAgent` with test data and verify:
    - `msdyn_IsSuccess` = `true`
    - A new record appears in `msdyn_rawactioncatalogue` with your action data

1. Trigger scoring.  
Call `msdyn_RAAgent_TriggerRecommendedActionsAgentOrchestration` to trigger an on-demand scoring run (instead of waiting for the 4-hour timer).

1. Verify scored output.

    ```http
        GET [org-url]/api/data/v9.2/msdyn_prioritizedactioncatalogues
        ?$filter=msdyn_actionid eq 'your-action-id'
        &$select=msdyn_actionid,msdyn_actionscore,msdyn_actionuipayload,msdyn_hascrossedceiling,msdyn_hascrossedfloor,msdyn_actionuistatus,msdyn_scoredetails
    ```
    Verify:
    - `msdyn_actionscore` is populated with a value in the 0–10 range.
    - `msdyn_hascrossedfloor` is `false` (action is above floor and shows in carousel).
    - `msdyn_actionuistatus` is `1` (Active).
    - `msdyn_scoredetails` contains the LLM-generated explanation.

1. Verify carousel display.  
Go to an Opportunity form in Dynamics 365 Sales and check the Suggested Actions section. Your scored action appears in the carousel.

1. Verify state sync.

    1. **Recommended Actions Agent → Your Agent:** Dismiss an action in the carousel. Verify your sync-back API is called with `state = "Dismissed"`.
    1. **Your Agent → Recommended Actions Agent:** Mark an action in your UI. Verify the output table record has `msdyn_actionuistatus` updated.

## End-to-end sales opportunity agent example (reference implementation)

Sales Opportunity Agent is the first agent onboarded to Recommended Actions Agent. Its integration serves as the reference implementation.

### Agent configuration values (Sales Opportunity Agent)

| Config Field | Sales Opportunity Agent Value (from `OraDefaults.cs`) |
|--------------|----------|
| `msdyn_agentname` | `"SalesOpportunityAgent"` |
| `msdyn_agentimpactmapping` | `["DealRisk","Deal Velocity"]` |
| `msdyn_syncactionexecutionstateapiconfig` | `{"syncactionuistatusapiname":"msdyn_SyncDealRiskActionFromNba"}` |
| `msdyn_internalprioritizationinstruction` | See [Sales Opportunity Agent's actual production value](#internal-prioritization-instruction) above |

### Action push (Sales Opportunity Agent to Recommended Actions Agent)

When Sales Opportunity Agent research completes and identifies deal risks, `DealRiskToNBAService` pushes each risk as a separate action:

| Push Parameter | Sales Opportunity Agent Value |
|----------------|-----------|
| `msdyn_ActionId` | `"DealRisk_{opportunityId}_{riskType}"` |
| `msdyn_SourceAgentId` | `"DealRiskAgent"` |
| `msdyn_TargetEntityTypeName` | `"opportunity"` |
| `msdyn_ActionReason` | Risk description from research |
| `msdyn_ActionUIPayload` | Card with risk header + description |
| `msdyn_ActionPrioritizationData` | `{"riskType":"8","risk":"Missing BANT Info"}` (example) |

### State sync (Sales Opportunity Agent)

- **Sales Opportunity Agent → Recommended Actions Agent:** When seller marks risk as done on research page → calls `msdyn_SyncActionExecutionStateFromAgent`
- **Recommended Actions Agent → Sales Opportunity Agent:** When seller dismisses card in carousel → Recommended Actions Agent calls `ora_UpdatedActionStateFromRAAgent` (configured in agent config)

## Related information

- [Recommended Actions overview](../recommended-actions-overview.md)  
- [Configure Recommended Actions](../configure-recommended-actions.md)