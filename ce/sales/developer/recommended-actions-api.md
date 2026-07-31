---
title: Integrate custom agents with Recommended Actions Agent
description: Recommended Actions Agent integration for Dynamics 365 Sales lets custom agents push scored insights to the seller carousel. Learn the architecture and contracts.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.date: 07/31/2026
ms.service: dynamics-365-sales
ms.custom: bap-template
ms.topic: install-set-up-deploy
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Integrate custom agents with Recommended Actions Agent

The Recommended Actions Agent in Dynamics 365 Sales surfaces prioritized recommendations for opportunities. It provides a shared scoring pipeline, data contracts, and bidirectional state synchronization so that any custom agent can surface recommendations alongside first-party agents.

This article describes the architecture, key components, data contracts, and integration flow used when a custom agent integrates with the Recommended Actions Agent. It provides the foundational knowledge required for implementing an integration.

## Prerequisites

- **NextBestActionAgent** solution deployed to the target organization. For more information, see [Import an agent into a target environment](../import-export-agent-solutions.md).
- Seller has appropriate **Dataverse security roles** as described in [Permissions required for custom security roles](../configure-recommended-actions.md#permissions-required-for-custom-security-roles).
- A stable, unique **SourceAgentId** string for the custom agent. For more information, see [Add custom agents for recommended actions](../configure-recommended-actions.md#add-custom-agents-for-recommended-actions).
- The following permissions are required to push recommended actions:

  | Table | Required privileges | Scope |
  |-------|---------------------|-------|
  | msdyn_rawactioncatalogue | Read, Write, Append, and AppendTo | Global |
  | msdyn_prioritizedactioncatalogue | Read, Write, Append, and AppendTo | Global |
  | msdyn_recommendedactionsourceagentconfig | Read | Global |
  | msdyn_salesagentprofile | Read | Global |

## Integration architecture

The Recommended Actions Agent integration uses a processing pipeline that ingests raw actions from source agents, scores them by using [a UICE (Urgency, Impact, Confidence, Effort) scoring engine](../next-best-actions-to-manage-opportunities.md#how-action-ranking-works), and surfaces the prioritized results in the seller carousel.

The processing pipeline works as follows:

1. **The custom agent** detects an actionable insight (for example, a deal risk, a stalled deal, or a missing stakeholder).
1. **The custom agent calls** the `msdyn_PushActionDataToRecommendedActionAgent` custom API to push the action.
1. The action is stored in `msdyn_rawactioncatalogue` (input table).
1. For each action, the **Scoring Engine**:
   - Fetches entity signals from Dataverse.
   - Fetches agent-specific prioritization data from the action catalogue.
   - Calls the LLM to score the action on UICE (Urgency, Impact, Confidence, Effort) dimensions.
   - Applies floor and ceiling rules.
   - Computes the final priority score by using `GetRecommendedActionAgentResponse`.
1. The scored action is inserted into `msdyn_prioritizedactioncatalogue` (output table).
1. The **Recommended Actions Agent Carousel** fetches scored actions and renders cards.

## Key components

The integration relies on the following Dataverse tables and APIs.

| Component | Location | Description |
|-----------|----------|-------------|
| Input table | msdyn_rawactioncatalogue (Dataverse) | Raw actions that custom agents push |
| Output table | msdyn_prioritizedactioncatalogue (Dataverse) | Scored and ranked actions for the UI |
| Agent config | msdyn_recommendedactionsourceagentconfig (Dataverse) | Per-agent registration and configuration |
| Push API | msdyn_PushActionDataToRecommendedActionAgent (Custom API) | Agent → Recommended Actions Agent action push |

## Agent registration

Register custom agents with the Recommended Actions Agent so the platform recognizes and fetches their actions. For more information about registering agents, see [Add custom agents for recommended actions](../configure-recommended-actions.md#add-custom-agents-for-recommended-actions).

When you register an agent, it creates an entry in `msdyn_recommendedactionsourceagentconfig`. The unique **SourceAgentId** identifies the entry for the custom agent.

## Agent configuration

The `msdyn_recommendedactionsourceagentconfig` table holds per-agent configuration that governs how the Recommended Actions Agent interprets an agent's actions. The two most important fields to populate are `msdyn_internalprioritizationinstruction` and `msdyn_syncactionexecutionstateapiconfig`.

You can apply configuration either by manually updating the table record or by calling the custom API `UpsertRecommendationAgentConfigRequest`.

### UpsertRecommendationAgentConfigRequest schema

The following example shows the available configuration fields in the schema. 

```json
{
  "agentName": "YourAgentName",
  "agentType": "CustomAgent",
  "isRecommendedActionAgentEnabled": true,
  "salesAgentProfileId": "<SourceAgentId that was configured>",
  "agentImpactMapping": "[]",
  "internalPrioritizationInstruction": "{\"signals\":[...]}",
  "syncActionExecutionStateApiConfig": "{\"syncactionuistatusapiname\":\"your_SyncBackCustomApiName\"}",
  "description": "Brief description of your agent"
}
```

| JSON Field | Type | Description |
|---|---|---|
| agentName | string | Maps to msdyn_agentname (max 850 chars). Required for new records. |
| agentType | string | Agent category. Use "CustomAgent" for non-Sales Opportunity Agent agents to auto-create a profile. |
| isRecommendedActionAgentEnabled | boolean | Maps to msdyn_isrecommendedactionagentenabled. Null = leave unchanged. |
| salesAgentProfileId | guid? | Links to msdyn_salesagentprofile. Used for record lookup on upsert. |
| agentImpactMapping | string | Flat JSON array of principle names. Maps to msdyn_agentimpactmapping. |
| internalPrioritizationInstruction | string | JSON with signals array. Maps to msdyn_internalprioritizationinstruction. |
| syncActionExecutionStateApiConfig | string | JSON object `{"syncactionuistatusapiname":"..."}`. Maps to msdyn_syncactionexecutionstateapiconfig. |
| sourceAgentUniqueId | string | Maps to msdyn_sourceagentuniqueid. |
| description | string | Maps to msdyn_sourcedescription (max 1000 chars). |

### Internal prioritization instruction

The internal prioritization instruction contains agent-specific signal metadata that tells the scoring engine how to interpret an agent's prioritization data fields. It's a JSON object with a top-level `signals` array. Each signal is deserialized into `AgentSignalInstructionConfig` with the following fields:

| Field | Type | Description |
|---|---|---|
| name | string | Signal identifier — used as the key in the scoring prompt's Signal Reference section |
| type | string | Data type: "string", "number", "boolean" |
| source | string | Descriptive label for where the signal comes from. Not used for routing — `fetch_info.fetch_type` controls the actual fetch mechanism. Typically "action_data" for agent-pushed signals. |
| dimension_influence | {dimension: strength} | Which UICE dimensions this signal affects and how strongly. Keys: "urgency", "impact", "confidence", "effort". Strengths: "strong", "moderate", "weak" |
| interpretation | string | Natural-language description of what the signal means for scoring — injected into the LLM prompt |
| reliability | string | How reliable this signal is: "high", "medium", "low" |
| required | boolean | Whether the signal must be present for scoring |
| fetch_info | object | Controls where and how the signal value is retrieved at scoring time. |

Example signals block:

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

### Sync action execution state API config

The sync action execution state API config is a JSON object that specifies the custom API name the Recommended Actions Agent calls when a seller acts on a card (for example, marks it as complete or irrelevant). This API sets the status of the action in the source custom agent.

```json
{
  "syncactionuistatusapiname": "your_SyncBackCustomApiName"
}
```

## Action push contract

Custom agents push actions by using the `msdyn_PushActionDataToRecommendedActionAgent` custom API. The API is called each time the agent generates or updates an action for a target entity.

### Request parameters

| Parameter | Type | Required | Description |
|---|---|---|---|
| msdyn_ActionId | string | Yes | Agent's unique identifier for this action. Used for deduplication and state sync. Must be deterministic (same action = same ID). Example format: `DealRisk_{opportunityId}_{riskType}` |
| msdyn_SourceAgentId | string | Yes | Agent's identifier. Must match the msdyn_agentname in the agent config record. Example: "DealClosingAgent" |
| msdyn_TargetEntityId | uniqueidentifier (GUID) | Yes | GUID of the target record (Opportunity, Lead) this action relates to |
| msdyn_TargetEntityTypeName | string | Yes | Logical name of the target entity. Example: "opportunity", "lead" |
| msdyn_ActionReason | string | Yes | Reason why the action was generated. Used by the scoring engine for principle mapping. |
| msdyn_ActionUIPayload | string | No | JSON payload for card rendering. If omitted, the Recommended Actions Agent can't display the card. |
| msdyn_ActionPrioritizationData | string | No | JSON with agent-specific data for scoring |
| msdyn_ActionCTA | string | No | CTA type string. Example: "Email", "Review", "Call" |
| msdyn_PrioritizationPrinciples | string | No | JSON array of prioritization principles this specific action maps to (can override agent-level mapping) |

### Example: C# plugin call

```csharp
var request = new OrganizationRequest("msdyn_PushActionDataToRecommendedActionAgent")
{
    ["msdyn_ActionId"] = $"DealRisk_{opportunityId}_{riskType}",
    ["msdyn_SourceAgentId"] = "DealClosingAgent",
    ["msdyn_TargetEntityId"] = opportunityId, // Guid
    ["msdyn_TargetEntityTypeName"] = "opportunity",
    ["msdyn_ActionReason"] = "Customer has not responded in 14 days, deal is at risk of stalling",

    ["msdyn_ActionUIPayload"] = JsonConvert.SerializeObject(new
    {
        version = "1.0",
        payload = new
        {
            header = "Follow up with Contoso",
            description = "No customer response in 14 days. Deal may stall without re-engagement.",
            oncardClickActionType = "Navigate",
            oncardClickActionTypeParameters =
                "{etn=\"opportunity\", id=\"aaaaaaaa-0000-1111-2222-bbbbbbbbbbbb\", pagetype=\"entityrecord\"}"
        }
    }),

    ["msdyn_ActionPrioritizationData"] = JsonConvert.SerializeObject(new
    {
        riskType = "14",
        risk = "low"
    })
};

var response = orgService.Execute(request);

bool success = (bool)response["msdyn_IsSuccess"];
```

## Action UI payload contract

The `msdyn_ActionUIPayload` field contains a JSON payload that controls how an action card appears in the Recommended Actions Agent carousel.

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

## Prioritization data contract

The `msdyn_prioritizationdata` field lets an agent pass agent-specific signals that influence how the UICE scoring engine prioritizes an action.

```json
[
  { "signalName": "risk", "value": "low" },
  { "signalName": "riskType", "value": "4" }
]
```

The scoring engine reads these signals alongside entity-level signals (deal value, stage, competitors, and so on). The `msdyn_internalprioritizationinstruction` in the agent config tells the LLM how to interpret each signal, and the scoring engine combines all signals into the UICE scoring prompt.

## Action versioning and invalidation

When an agent updates data for a previously pushed action, it creates a new record with the same `msdyn_ActionId` by calling `msdyn_PushActionDataToRecommendedActionAgent` again. The system creates a new row in `msdyn_rawactioncatalogue` with the same `msdyn_actionid` but a new `msdyn_rawactioncatalogueid`. The Recommended Actions Agent keeps showing the old version until it processes the new one.

To invalidate an action (for example, when a risk is resolved), the agent calls the `msdyn_RAAgent_RemoveActionsV2` custom API with the `actionId`. This action marks all `msdyn_rawactioncatalogue` records for that action as inactive, and the card disappears from the carousel.

## Bidirectional state synchronization

Action state synchronizes in both the Recommended Actions Agent carousel and your custom agent to ensure that sellers see consistent information regardless of where they act on an action.  
**Recommended Actions Agent → custom agent (seller acts in the carousel):** When a seller marks an action as **Done** or **Dismissed** in the carousel:

1. Recommended Actions Agent updates the `msdyn_actionuistatus` in `msdyn_prioritizedactioncatalogue`.
1. Recommended Actions Agent reads the `msdyn_syncactionexecutionstateapiconfig` from the agent config.
1. Recommended Actions Agent calls the agent's custom API with:

| Parameter | Type | Description |
|---|---|---|
| actionid | GUID | The action identifier |
| state | string | "MarkedDone" or "Dismissed" |

The agent must implement a custom API that accepts these two parameters and updates the action state in its own data store.

**Custom agent → Recommended Actions Agent (seller acts in the agent's UI):** When a seller acts on an action in the agent's own UI (for example, marks it as mitigated on a custom agent page), the agent syncs that state to the Recommended Actions Agent by calling `msdyn_SyncActionExecutionStateFromAgent`. This action updates the state in the Recommended Actions Agent output table, hiding it from the carousel.

| Parameter | Type | Required | Description |
|---|---|---|---|
| msdyn_ActionId | string | Yes | The action identifier (same as what was pushed) |
| msdyn_ActionState | integer | Yes | New state — values (mapped to MarkAsDone/Dismissed) |
| msdyn_TargetEntityId | uniqueidentifier | Yes | Target entity GUID |
| TargetEntityTypeName | string | Yes | Target entity logical name |
| msdyn_TrackingId | string | No | Optional tracking/correlation ID |


## Testing and validation

After configuration and implementation, validate the end-to-end flow by performing the following checks.

Verify agent configuration:

```http
GET [org-url]/api/data/v9.2/msdyn_recommendedactionsourceagentconfigs
?$filter=msdyn_agentname eq 'YourAgentName'
&$select=msdyn_agentname,msdyn_agentimpactmapping,msdyn_internalprioritizationinstruction,msdyn_syncactionexecutionstateapiconfig
```

Push a test action by calling `msdyn_PushActionDataToRecommendedActionAgent` and verify that `msdyn_IsSuccess` is true and a new record appears in `msdyn_rawactioncatalogue`.

Trigger scoring on demand by calling `msdyn_RAAgent_TriggerRecommendedActionsAgentOrchestration` (instead of waiting for the 4-hour timer).

Verify scored output:

```http
    GET [org-url]/api/data/v9.2/msdyn_prioritizedactioncatalogues
    ?$filter=msdyn_actionid eq 'your-action-id'
    &$select=msdyn_actionid,msdyn_actionscore,msdyn_actionuipayload,msdyn_hascrossedceiling,msdyn_hascrossedfloor,msdyn_actionuistatus,msdyn_scoredetails
```

Expected values:

- `msdyn_actionscore` is populated with a value in the 0–10 range.
- `msdyn_hascrossedfloor` is false (action is above the floor and shows in the carousel).
- `msdyn_actionuistatus` is 1 (Active).
- `msdyn_scoredetails` contains the LLM-generated explanation.

Verify carousel display by opening an Opportunity form in Dynamics 365 Sales and checking the Suggested Actions section. Verify state sync by dismissing an action in the carousel (the sync-back API should be called with `state = "Dismissed"`) and by marking an action in the agent UI (the output table record should reflect the updated `msdyn_actionuistatus`).

## Example: Sales Opportunity Agent

Sales Opportunity Agent is the first agent onboarded to the Recommended Actions Agent, and its integration serves as the reference implementation.

Agent configuration values:

| Config Field | Sales Opportunity Agent value (from OraDefaults.cs) |
|---|---|
| msdyn_agentname | "SalesOpportunityAgent" |
| msdyn_agentimpactmapping | ["DealRisk","Deal Velocity"] |
| msdyn_syncactionexecutionstateapiconfig | `{"syncactionuistatusapiname":"msdyn_SyncDealRiskActionFromNba"}` |
| msdyn_internalprioritizationinstruction | See the Sales Opportunity Agent's [production value](#internal-prioritization-instruction) |

When Sales Opportunity Agent research completes and identifies deal risks, `DealRiskToNBAService` pushes each risk as a separate action:

| Push parameter | Sales Opportunity Agent value |
|---|---|
| msdyn_ActionId | `DealRisk_{opportunityId}_{riskType}` |
| msdyn_SourceAgentId | "DealRiskAgent" |
| msdyn_TargetEntityTypeName | "opportunity" |
| msdyn_ActionReason | Risk description from research |
| msdyn_ActionUIPayload | Card with risk header + description |
| msdyn_ActionPrioritizationData | `{"riskType":"8","risk":"Missing BANT Info"}` (example) |

State sync behavior:

- **Sales Opportunity Agent → Recommended Actions Agent:** When a seller marks a risk as done on the research page, the agent calls `msdyn_SyncActionExecutionStateFromAgent`.
- **Recommended Actions Agent → Sales Opportunity Agent:** When a seller dismisses a card in the carousel, the Recommended Actions Agent calls `ora_UpdatedActionStateFromRAAgent` (configured in the agent config).
 
## Related information

- [Configure Recommended Actions agent](../configure-recommended-actions.md)
- [Recommended actions overview](../recommended-actions-overview.md)

