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

1. **Ingests** raw action cards from multiple upstream agents such as Sales Opportunity Risk Agent, Data Enrichment Agent, and custom agents
1. **Scores** each action on four dimensions — **Urgency, Impact, Confidence, Effort** (UICE framework, 0–10 each)
1. **Ranks** actions across all agents using a configurable priority formula
1. **Surfaces** the top 5 actions in the Recommended Actions Agent carousel in Dynamics 365 Sales

Your agent pushes actions into the Recommended Actions Agent pipeline via a Custom API. Recommended Actions Agent handles everything downstream: prioritization, deduplication, versioning, and UI rendering.

## Integration architecture

### Processing Pipeline

1. **Your agent** detects an actionable insight (for example, a deal risk, a stalled deal, or a missing stakeholder)
1. **Your agent calls** `msdyn_PushActionDataToRecommendedActionAgent` Custom API to push the action
1. The action is persisted in `msdyn_rawactioncatalogue` (input table)
1. **Recommended Actions Agent DTF Orchestrator** (runs every ~4 hours, triggered by CRM or on-demand) picks up unprocessed actions
1. For each action, the **Scoring Engine** (on the CoPilot Service Fabric service `RecommendedActionsAgentServices`):
   - Fetches entity signals (deal value, stage, competitors, etc.) from Dataverse
   - Fetches agent-specific prioritization data from the action record
   - Calls LLM (via CAPI) to score on UICE dimensions
   - Applies floor/ceiling rules
   - Computes final priority score: `U × 0.30 + I × 0.35 + C × 0.20 − E × 0.15 + PP × 0.05`
1. Scored action is upserted into `msdyn_prioritizedactioncatalogue` (output table)
1. **Recommended Actions Agent Carousel** fetches scored actions via `msdyn_RAAgent_FetchScoredRecommendedActions` and renders cards

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

- **NextBestActionAgent solution** is deployed to the target org.
- **Feature Control Setting** `SalesService.NextBestAction:EnableNBASuggestions` is set to `true`.
- **Feature Control Setting** `SalesService.NextBestAction:EnableRecommendedActionsAgent` is set to `true` (or not explicitly `false`).
- **RecommendedActionsAgentServices** SF microservice is deployed and healthy (CoPilot Service Fabric app).
- Your agent has appropriate **Dataverse security roles** to call the `msdyn_PushActionDataToRecommendedActionAgent` API (requires `prvWritemsdyn_rawactioncatalogue` privilege).
- You have a stable, unique **SourceAgentId** string for your agent (such as `"DealClosingAgent"`, `"SQAAgent"`).

## Step 1: Register your agent (source agent config)

Register your agent by calling `msdyn_RAAgent_UpsertRecommendationAgentConfig`. Don't create records directly - the API handles upsert logic, record lookup, and Sales Opportunity Agent-specific defaulting.

### Via custom API

**API:** `msdyn_RAAgent_UpsertRecommendationAgentConfig`

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `msdyn_RequestJson` | string (JSON) | Yes | JSON payload with agent config fields |

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
| `isRecommendedActionAgentEnabled` | bool? | Maps to `msdyn_isrecommendedactionagentenabled`. Null = leave unchanged. |
| `salesAgentProfileId` | guid? | Links to `msdyn_salesagentprofile`. Used for record lookup on upsert. |
| `agentImpactMapping` | string | Flat JSON array of principle names (see below). Maps to `msdyn_agentimpactmapping`. |
| `internalPrioritizationInstruction` | string | JSON with `signals` array (see below). Maps to `msdyn_internalprioritizationinstruction`. |
| `syncActionExecutionStateApiConfig` | string | JSON object `{"syncactionuistatusapiname":"..."}`. Maps to `msdyn_syncactionexecutionstateapiconfig`. |
| `agentType` | string | Agent category. Use `"CustomAgent"` for non-Sales Opportunity Agent agents to auto-create a profile. |
| `sourceAgentUniqueId` | string | Maps to `msdyn_sourceagentuniqueid`. Only written on create, ignored on update. |
| `description` | string | Maps to `msdyn_sourcedescription` (max 1000 chars). |

### Sales Opportunity Agent vs. Non-Sales Opportunity Agent behavior

The upsert plugin uses **agent-specific defaulting** for Sales Opportunity Agent (when `agentName` = `"Sales Opportunity Agent"`):

- On **create**, if `agentImpactMapping`, `internalPrioritizationInstruction`, or `syncActionExecutionStateApiConfig` are omitted or null, the plugin automatically applies Sales Opportunity Agent defaults from `OraDefaults.cs`.
- On **update**, omitted fields remain unchanged (preserving the current Dataverse value).
- A JSON null in the request is treated the same as an omitted key - you **can't** clear Sales Opportunity Agent-owned fields by sending null.

For **non-Sales Opportunity Agent agents** (the `default` switch branch):

- Explicit values (including null) are forwarded directly to the Dataverse column.
- Sending a JSON null **clears** the field - this action is intentional so custom agents can reset fields.

### Agent impact mapping

Maps your agent's actions to Recommended Actions Agent's prioritization principles. The scoring engine uses this mapping to weight your actions.

**Format:** A **flat JSON array of strings** — each string is a prioritization principle name (or numeric optionset value). The code parses this as `List<string>`, supporting both `["name1","name2"]` and `"name1,name2"` (comma-separated) formats.

```json
["DealRisk", "Deal Velocity"]
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

You can pass **either** the label string or the numeric optionset value. The `ResolvePrincipleDisplayValue()` method resolves both:

- **Numeric** → matched against `OptionSetValue` or `Rank` in the org's `PrioritizationPrinciples` config (from `msdyn_salesagentconfigurationv2`)
- **String** → case-insensitive match against `Name` in the principles list
- **No match** → raw value passed through as-is

**Recommendation:** Use display name strings (for example, `[4, 2, "custom principle"]`) — they're human-readable and won't break if the admin reorders principles.

> [!IMPORTANT]
> The optionset label is `"Risk Reduction"` (value 4), but the code constant is `PrincipleRiskMitigation` with value `"Risk Mitigation"`. Use the optionset label (`"Risk Reduction"`) for forward compatibility.

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

| `fetch_type` | What it does | `crm_field` meaning | CRM query? |
|---|---|---|---|
| **`action_data`** | Reads the value from the per-action `msdyn_prioritizationdata` JSON. **This is what custom agents should use.** | JSON property key to look up in `msdyn_prioritizationdata`. Falls back to `name` if omitted. | No - reads from the action record's JSON, no Dataverse query needed |
| **`entity_field`** | Fetches a column directly from the target entity (for example, `estimatedvalue` from `opportunity`). | Dataverse column logical name on the target entity (for example, `estimatedvalue`, `estimatedclosedate`). | Yes - single `QueryExpression` with `TopCount=1` on the target entity |
| **`linked_entity`** | Fetches a column from a related entity via a LEFT OUTER JOIN (for example, account name from the parent account). | Column logical name on the linked entity. Also requires `source_entity_field`, `target_entity_name`, `target_entity_field`. | Yes - added as a LEFT OUTER JOIN to the entity_field query (single round-trip) |
| **`aggregation`** | Runs an aggregation query on a related entity (for example, count of competitors, sum of activities). | Column to aggregate. Also requires `target_entity_name`, `aggregation_type`. | Yes - separate `FetchXML` aggregation query |
| **`custom_signal`** | Handled by `CustomSignalFetchService` - BPF stage, competitor associations, and other complex multi-step queries. | Depends on the custom handler. | Yes - custom Dataverse queries |
| **`derived_insight`** | Reads from `msdyn_recommendedactionderivedinsight` entity (see Step 8). | JSON property key inside the `msdyn_derivedinsightvalue` JSON column. | Yes - `Top(1)` query on derived insights table |
| **`derived`** | Post-processing derivation (for example, `days_until_date` converts a date field to days until close). | References another signal's value. Also requires `derivation` field. | No - computed from already-fetched signals |

> [!NOTE]
> - **For custom agents:** Use `fetch_type: "action_data"` for your agent-specific signals. Agent-level signals from `internalPrioritizationInstruction` **are** merged into the unified signal list via `MergeAgentSignals()` and all fetch types are dispatched. However, there's a **critical limitation**: the merge only copies `FetchType` and `CrmField` from your signal config - it doesn't copy `SourceEntityName`, `TargetEntityName`, `SourceEntityField`, `SelectField`, `AggregationType`, `Derivation`, `FilterField`, `FilterValue`, `JsonPath`, or `ValueType`.
>
> **What this means in practice:**
> - **`action_data` works perfectly** - it only needs `CrmField` (the JSON key in `msdyn_prioritizationdata`)
> - **`entity_field` silently fails** - the engine filters by `s.FetchInfo?.SourceEntityName == actionData.EntityTypeName` (line 72), but `SourceEntityName` is null after merge, so the signal is skipped
> - **`linked_entity`**, **`aggregation`**, **`derived_insight`** also fail - they require `TargetEntityName`, `SourceEntityField`, etc. which aren't copied
>
> If you need CRM-fetched signals (entity fields, linked entities, aggregations), configure these at the **org level** in `msdyn_salesagentconfigurationv2` - they're shared across all agents. Your `internalPrioritizationInstruction` should only define `action_data` signals that read from your per-action `msdyn_prioritizationdata` JSON.

#### `SignalFetchInfo` - All available fields

The `fetch_info` object supports the following fields (from `SignalFetchInfo` model class). Different `fetch_type` values use different subsets:

| Field | JSON key | Used by | Description |
|-------|----------|---------|-------------|
| `FetchType` | `fetch_type` | All | [The fetch strategy](#fetch-info-fetchtype-values) |
| `SelectField` | `select_field` | `entity_field`, `linked_entity`, `aggregation` | The Dataverse column to read or aggregate |
| `CrmField` | `crm_field` | `action_data`, alias for `select_field` | JSON key in `msdyn_prioritizationdata` (for `action_data`), or alias for `select_field` (normalized on load) |
| `SourceEntityName` | `source_entity_name` | `entity_field` | Base entity logical name (for example, `"opportunity"`) |
| `CrmEntity` | `crm_entity` | alias | Alias for `source_entity_name` (or `target_entity_name` for linked/aggregation) |
| `SourceEntityField` | `source_entity_field` | `linked_entity` | FK column on the base entity used for the JOIN (for example, `"accountid"`) |
| `LinkedVia` | `linked_via` | alias | Alias for `source_entity_field` |
| `TargetEntityName` | `target_entity_name` | `linked_entity`, `aggregation` | Related entity logical name (for example, `"account"`, `"connection"`) |
| `TargetEntityField` | `target_entity_field` | `linked_entity` | PK column on the related entity (defaults to `{target_entity_name}id`) |
| `RelationshipName` | `relationshipname` | `linked_entity` | Alias for the LEFT OUTER JOIN (defaults to auto-generated) |
| `AggregationType` | `aggregation_type` | `aggregation` | `"count"`, `"exists_role"`, `"max_days_since"`, `"list"`, `"concat"` |
| `Filter` | `filter` | `aggregation` | `{ "field": "...", "op": "eq|not_null", "value": ... }` - filters rows before aggregation |
| `Derivation` | `derivation` | `entity_field` (post-process) | `"days_until_date"`, `"days_since_date"`, `"normalize_0_to_1"`, `"format_currency"` |
| `ValueType` | `value_type` | `entity_field` | `"both"` to return `{"code": int, "name": "label"}` for OptionSet fields |
| `JsonPath` | `json_path` | `derived_insight` | Dotted path to extract from `msdyn_derivedinsightvalue` JSON |

#### Examples per `fetch_type`

All examples below are verified against `SignalFetchServiceTests.cs`.

**1. `entity_field` — Read a column from the target entity**

```json
{
  "name": "deal_value",
  "type": "number",
  "source": "crm",
  "fetch_info": {
    "fetch_type": "entity_field",
    "source_entity_name": "opportunity",
    "select_field": "estimatedvalue"
  }
}
```
Result: `500000.0` (Money values are extracted as `double`)

```json
{
  "name": "stage",
  "type": "string",
  "source": "crm",
  "fetch_info": {
    "fetch_type": "entity_field",
    "source_entity_name": "opportunity",
    "select_field": "salesstagecode"
  }
}
```

Result: `"Propose"` (OptionSet values return the formatted label by default)

To get **both** the numeric code and the label, set `"value_type": "both"`:

```json
{
  "name": "stage",
  "type": "string",
  "source": "crm",
  "fetch_info": {
    "fetch_type": "entity_field",
    "source_entity_name": "opportunity",
    "select_field": "salesstagecode",
    "value_type": "both"
  }
}
```

Result: `{"code": 3, "name": "Propose"}`

To **derive** days remaining from a date field (post-processing):

```json
{
  "name": "close_date_days",
  "type": "number",
  "source": "crm",
  "fetch_info": {
    "fetch_type": "entity_field",
    "source_entity_name": "opportunity",
    "select_field": "estimatedclosedate",
    "derivation": "days_until_date"
  }
}
```

Result: `30` (positive = future), `-5` (negative = overdue)

Other derivations: `"days_since_date"` (for example, days since last modified), `"normalize_0_to_1"` (divides by 100 if > 1), `"format_currency"` (parses `"$500,000"` → `500000.0`)

**2. `linked_entity` — Read a column from a related entity (LEFT OUTER JOIN)**

```json
{
  "name": "account_size",
  "type": "string",
  "source": "crm",
  "fetch_info": {
    "fetch_type": "linked_entity",
    "target_entity_name": "account",
    "source_entity_field": "accountid",
    "target_entity_field": "accountid",
    "relationshipname": "accountid",
    "select_field": "customersizecode"
  }
}
```

Result: `"Large"` (OptionSet → formatted label)

```json
{
  "name": "account_revenue",
  "type": "number",
  "source": "crm",
  "fetch_info": {
    "fetch_type": "linked_entity",
    "target_entity_name": "account",
    "source_entity_field": "accountid",
    "target_entity_field": "accountid",
    "relationshipname": "accountid",
    "select_field": "revenue"
  }
}
```

Result: `1000000.0` (Money → double)

> [!NOTE]
> The engine fetches `entity_field` and `linked_entity` signals in a **single Dataverse round-trip**. It builds one `QueryExpression` with LEFT OUTER JOINs for all linked entities.

**3. `aggregation` — Aggregate over related entity records**

Count of products on the opportunity:

```json
{
  "name": "product_count",
  "type": "number",
  "source": "crm",
  "fetch_info": {
    "fetch_type": "aggregation",
    "target_entity_name": "opportunityproduct",
    "aggregation_type": "count"
  }
}
```

Result: `2`

Count with filter (outbound emails only):

```json
{
  "name": "outbound_emails",
  "type": "number",
  "source": "crm",
  "fetch_info": {
    "fetch_type": "aggregation",
    "target_entity_name": "email",
    "aggregation_type": "count",
    "filter": { "field": "directioncode", "op": "eq", "value": true }
  }
}
```

Result: `1`

Check if a decision maker connection exists:

```json
{
  "name": "has_decision_maker",
  "type": "boolean",
  "source": "crm",
  "fetch_info": {
    "fetch_type": "aggregation",
    "target_entity_name": "connection",
    "aggregation_type": "exists_role"
  }
}
```

Result: `true` (if any connection has role containing "Decision" or "Maker")

Days since most recent email:

```json
{
  "name": "last_email_days",
  "type": "number",
  "source": "crm",
  "fetch_info": {
    "fetch_type": "aggregation",
    "target_entity_name": "email",
    "aggregation_type": "max_days_since",
    "select_field": "createdon"
  }
}
```

Result: `5` (days since the most recent email's `createdon`)

List of distinct products:

```json
{
  "name": "products",
  "type": "string",
  "source": "crm",
  "fetch_info": {
    "fetch_type": "aggregation",
    "target_entity_name": "opportunityproduct",
    "aggregation_type": "list",
    "select_field": "productid"
  }
}
```

Result: `["Product A", "Product B"]`

**4. `action_data` — Read from per-action `msdyn_prioritizationdata` JSON (no CRM query)**

```json
{
  "name": "risk_type",
  "type": "string",
  "source": "action_data",
  "fetch_info": { "fetch_type": "action_data", "crm_field": "riskType" }
}
```

Result: reads `riskType` key from `msdyn_prioritizationdata` JSON → for example, `"8"`

If `crm_field` is omitted, falls back to the signal `name` as the JSON key.

**5. `derived_insight` — Read from `msdyn_recommendedactionderivedinsight` entity**

```json
{
  "name": "customer_sentiment",
  "type": "string",
  "source": "derived_insight",
  "fetch_info": {
    "fetch_type": "derived_insight",
    "source_entity_name": "msdyn_recommendedactionderivedinsight",
    "json_path": "Sentiment"
  }
}
```

Result: reads from `msdyn_derivedinsightvalue` JSON column → for example, `"positive"`

**6. `custom_signal` — Complex multi-step queries (BPF stage, competitors)**

```json
{
  "name": "bpf_stage",
  "type": "string",
  "source": "crm",
  "fetch_info": { "fetch_type": "custom_signal" }
}
```

Handled by `CustomSignalFetchService` — uses specialized Dataverse queries for BPF stages, competitor associations, and other complex scenarios.

#### How the scoring engine fetches `entity_field` and `linked_entity` signals

These signals are typically **org-level signals** that the admin configures in `msdyn_salesagentconfigurationv2`. While the scoring engine technically merges agent-level signals with these fetch types through `MergeAgentSignals()`, **it only copies `FetchType` and `CrmField`**. The engine drops the other required fields (`SourceEntityName`, `TargetEntityName`, `SelectField`, and more), which causes the signals to be silently skipped. To use these fetch types, define them at the org level.

The scoring engine builds a **single `QueryExpression`** per action:

```
QueryExpression("opportunity")
  .ColumnSet = ["estimatedvalue", "estimatedclosedate", "_parentaccountid_value", ...]
  .Criteria = opportunityid == {targetEntityId}
  .AddLink("account", "_parentaccountid_value", "accountid", LeftOuterJoin)
    .Columns = ["name", "revenue", ...]
  .TopCount = 1
```

This query fetches the opportunity's own fields and the parent account's fields in **one Dataverse round-trip**. The `crm_field` in `fetch_info` for these signals refers to the actual Dataverse column logical name, such as `estimatedvalue` or `name`.

**Example: Sales Opportunity Agent's production value** (from `OraDefaults.cs`):

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

| Layer | Scope | Purpose | Prompt mapping | Example |
|---|---|---|---|---|
| `agentImpactMapping` | Agent config (per agent) | Defines which principles the agent serves. | Injected into prompt section 2 (Agent Impact Profiles). | `["Risk Reduction", "Deal Velocity"]` |
| `internalPrioritizationInstruction` | Agent config (per agent) | Explains how the LLM should interpret your signals. | Injected into prompt section 5 (Signal Reference). | `signals[].interpretation`, `dimension_influence` |
| `msdyn_prioritizationdata` | Per action (push API payload) | Carries actual signal values for each action. | Injected into prompt section 8 (Signals JSON). | `{"riskType":"8","risk":"Missing BANT Info"}` |

`fetch_info.crm_field` must match keys in `msdyn_prioritizationdata` so signal values resolve correctly.

**Critical linkage: `fetch_info.crm_field` → `msdyn_prioritizationdata` JSON keys**

The `ExtractActionDataSignals()` method in `SignalFetchService.cs` extracts per-action signal values by looking up JSON property keys in your `msdyn_prioritizationdata`:

```csharp
var jsonKey = sig.FetchInfo?.CrmField ?? sig.Name;  // falls back to signal name if crm_field is null
var token = prioritizationJson[jsonKey];             // looks up in your PrioritizationData JSON
```

**Sales Opportunity Agent example of the correlation:**

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
1. If the keys don't match, the signal value is `null` and the LLM treats it as missing (logged as `"action_data signal '{name}' not found in PrioritizationData"`).

**How `dimension_influence` affects scoring:**

Each signal's `dimension_influence` is rendered into the prompt's Signal Reference like:

```
- **risk_type** (string, source: agent): Risk category code... [urgency(moderate), confidence(weak)] reliability=high
```

The LLM uses these hints as guidance (not hard multipliers) to determine how strongly each signal affects each UICE dimension score.

### Sync action execution state API config

**Format:** A JSON object (not a plain string) specifying the Custom API name that Recommended Actions Agent calls when a seller acts on your card:

```json
{
  "syncactionuistatusapiname": "your_SyncBackCustomApiName"
}
```

**Sales Opportunity Agent's actual value:** `{"syncactionuistatusapiname":"msdyn_SyncDealRiskActionFromNba"}`

## Step 2 — Push actions via custom API

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
| `msdyn_ActionUIPayload` | string | No | JSON payload for card rendering (see Step 3). If omitted, Recommended Actions Agent can't display the card. |
| `msdyn_ActionPrioritizationData` | string | No | JSON with agent-specific data for scoring (see Step 4) |
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
    new { signalName = "dca_silence_days", value = "14" },
    new { signalName = "dca_deal_health", value = "low" }
});

var response = orgService.Execute(request);
bool success = (bool)response["msdyn_IsSuccess"];
```

## Step 3 — Action UI payload contract

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
| `onctaClickActionType` | No | What happens when seller clicks the CTA button. |
| `onctaClickActionTypeParameters` | No | JSON string with CTA navigation parameters. |

### How the UI consumes this data

The `msdyn_RAAgent_FetchScoredRecommendedActions` plugin reads the `msdyn_actionuipayload` from the scored output table (`msdyn_prioritizedactioncatalogue`) and maps it to `SuggestedActionItem`:

| UI Payload Field | SuggestedActionItem Field | Notes |
|------------------|--------------------------|-------|
| `header` | `Title` | Card header text |
| `description` | `Description` | Card body text |
| (computed) | `SuggestedActionOnClickURL` | Built from `RecordType` + `RecordId`: `/main.aspx?pagetype=entityrecord&etn={type}&id={id}` |
| (from scoring) | `PrioritizationHeader` | `"Important"` if action crossed ceiling, else null |
| (from scoring) | `PrioritizationTitle` | LLM-generated score explanation |
| (from scoring) | `PrioritizationDescription` | LLM-generated impact description |

## Step 4 — Prioritization Data Contract

The `msdyn_prioritizationdata` field lets you pass agent-specific signals that influence how the UICE scoring engine prioritizes your action.

### Schema

```json
[
  { "signalName": "dca_deal_health", "value": "low" },
  { "signalName": "dca_silence_days", "value": "14" },
  { "signalName": "dca_blockers_count", "value": "3" }
]
```

### How this data is used

1. The scoring engine reads these signals alongside entity-level signals (deal value, stage, competitors, and more).
1. Your `msdyn_internalprioritizationinstruction` from the agent config tells the LLM how to interpret each signal.
1. The scoring engine combines signals into the UICE scoring prompt.

**Signal interpretation mapping (from your agent config):**

| Your Prioritization Data | Agent Config Instruction | Scoring Effect |
|--------------------------|--------------------------|----------------|
| `dca_deal_health: low` | "Low = at risk, raises urgency, lowers confidence" | Urgency ↑, Confidence ↓ |
| `dca_silence_days: 14` | "Higher value = longer silence, raises urgency" | Urgency ↑ |

### Entity-level signals (fetched automatically by Recommended Actions Agent)

Recommended Actions Agent also fetches these signals from Dataverse for each target entity. Your agent doesn't need to provide these signals:

| Signal | Entity | Field | Effect |
|--------|--------|-------|--------|
| `deal_value` | opportunity | `estimatedvalue` | Higher → higher impact |
| `stage` | opportunity | (custom logic) | Later stage → higher urgency and impact |
| `close_date_days` | opportunity | `estimatedclosedate` | <7 days → critical urgency |
| `competitors_in_record` | opportunity | (custom logic) | Non-empty → raises urgency |
| `email_competitor_mentions` | opportunity | via `msdyn_opportunityrankermapping` | Non-empty → raises urgency |

## Step 5 — Handle action updates (versioning)

When your agent has updated data for a previously pushed action, **create a new record** with the same `msdyn_ActionId` by calling `msdyn_PushActionDataToRecommendedActionAgent` again.

### How versioning works

1. The system creates a new row in `msdyn_rawactioncatalogue` with the same `msdyn_actionid` but a new `msdyn_rawactioncatalogueid`.
1. **Recommended Actions Agent keeps showing the old version** until it processes the new version.
1. When Recommended Actions Agent picks up the new version for scoring, it:
   - Marks older unprocessed versions as `Skipped` (status = 3).
   - Scores only the newest version.
   - **Updates** the existing output record in `msdyn_prioritizedactioncatalogue` (same record, updated score and payload).

### Invalidating an action

If an action is no longer valid (for example, the risk was resolved):

- Call `msdyn_RAAgent_RemoveActions` Custom API with the `actionId`.
- This process marks all `msdyn_rawactioncatalogue` records for that action as `Inactive`.
- The output table record is also marked `Inactive`.
- The card disappears from the carousel.

### Status lifecycle

**Input Table (`msdyn_rawactioncatalogue`):**

| Status Value | State | Label | Purpose |
|:---:|:---:|---|---|
| 1 | Active | Active | Default - newly created or unprocessed actions |
| 2 | Active | Obsolete | A newer version of this action exists |
| 3 | Active | Skipped | Skipped by Recommended Actions Agent processor (newer version available) |
| 4 | Inactive | Error | Malformed data (for example, invalid JSON) |
| 5 | Inactive | Removed | Explicitly removed or deleted |

## Step 6 — Bidirectional state sync

### 6a. Recommended Actions Agent to your agent (seller acts in carousel)

When a seller marks an action as **Done** or **Dismissed** in the Recommended Actions Agent carousel:

1. Recommended Actions Agent updates the `msdyn_actionuistatus` in `msdyn_prioritizedactioncatalogue`.
1. Recommended Actions Agent reads your `msdyn_syncactionexecutionstateapiconfig` from the agent config.
1. Recommended Actions Agent calls your Custom API with:

    | Parameter | Type | Description |
    |-----------|------|-------------|
    | `actionid` | GUID | The action identifier |
    | `state` | string | `"MarkedDone"` or `"Dismissed"` |

**You must implement a Custom API** that accepts these two parameters and updates the action state in your own data store.

**Example:** Sales Opportunity Agent uses `ora_UpdatedActionStateFromRAAgent` which updates the risk state on the research page.

### 6b. Your agent to Recommended Actions Agent (seller acts in your UI)

When a seller acts on an action in **your** UI (for example, marks a risk as mitigated on the research page), sync that state to Recommended Actions Agent:

**API:** `msdyn_SyncActionExecutionStateFromAgent`

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `msdyn_ActionId` | string | Yes | The action identifier (same as what you pushed) |
| `msdyn_ActionState` | integer | Yes | New state - values TBD (mapped to MarkAsDone/Dismissed) |
| `msdyn_TargetEntityId` | uniqueidentifier | Yes | Target entity GUID |
| `TargetEntityTypeName` | string | Yes | Target entity logical name |
| `msdyn_TrackingId` | string | No | Optional tracking/correlation ID |

This action updates the state in the Recommended Actions Agent output table, hiding it from the carousel.

## Step 7 - Feature control settings

### Platform-Level FCS (in `SalesService.NextBestAction` namespace)

| FCS Key | Type | Default | Description |
|---------|------|---------|-------------|
| `EnableNBASuggestions` | Boolean | `true` | Master switch - if false, Recommended Actions Agent carousel is hidden and all integration is disabled |
| `EnableNBARetrieveMultiplePlugin` | Boolean | `true` | Controls retrieve multiple plugin behavior |
| `EnableRecommendedActionsAgent` | Boolean | `false` | Controls whether the scoring engine processes actions |

### Per-agent toggle

Each agent configuration has an `isRecommendedActionAgentEnabled` flag (set through `msdyn_RAAgent_UpsertRecommendationAgentConfig`). Admins can use this flag as the per-profile control and toggle it in the AI config UI.

**Toggle hierarchy:**

```
FCS EnableNBASuggestions = false  →  Everything disabled (platform kill switch)
FCS EnableNBASuggestions = true   →  Check per-agent toggle:
  isRecommendedActionAgentEnabled = false  →  Agent integration disabled
  isRecommendedActionAgentEnabled = true   →  Agent actions processed by Recommended Actions Agent
```

## Step 8 — (Optional) Derived insights integration

If your agent produces entity-level insights, such as customer sentiment or deal health scores, that Recommended Actions Agent should use as additional scoring signals, persist them to `msdyn_recommendedactionderivedinsight`.

### Entity: `msdyn_recommendedactionderivedinsight`

| Field | Type | Description |
|-------|------|-------------|
| `msdyn_name` | nvarchar(100) | Primary name (auto-populated) |
| `msdyn_entitytype` | nvarchar(100) | Target entity type: `"opportunity"`, `"lead"` |
| `msdyn_regardingobjectid` | polymorphic lookup | Lookup to Opportunity or Lead record |
| `msdyn_derivedinsightvalue` | ntext (JSON) | `{"Sentiment":"positive","Confidence":"Medium"}` |
| `msdyn_derivedinsightsource` | picklist | `Email` (100000000), `Meeting` (100000001), `Notes` (100000002), `Entity` (100000003) |
| `msdyn_conversationid` | nvarchar(450) | Associated conversation ID |

### How Recommended Actions Agent uses derived insights

The scoring engine reads derived insights for a target entity to enrich the signal set used in UICE scoring. For example, if your agent persists a `CustomerSentiment` insight, the scorer incorporates it alongside standard entity signals.

## Step 9 — Office Customer Voice feedback configuration

The Recommended Actions Agent carousel supports OCV (Office Customer Voice) feedback dialogs. Feedback configuration is API-driven - the `msdyn_RAAgent_FetchScoredRecommendedActions` response includes a `feedbackConfig` property.

If your agent requires custom feedback options, extend `FeedbackOptionsFactory.CreateDefault()` in the `NextBestActionAgentPlugins` project. For the full configuration schema, see `docs/NBA/ocv-feedback-onboarding-guide.md`.

The default config provides:
- **Upvote:** "What did you like?" - Correct prioritization, Relevant action suggestion, and more.
- **Downvote:** "What went wrong?" - Wrong prioritization, Wrong action suggestion, and more.

## Step 10 — Testing and validation

### 10a. Verify agent config

```http
GET [org-url]/api/data/v9.2/msdyn_recommendedactionsourceagentconfigs
  ?$filter=msdyn_agentname eq 'YourAgentName'
  &$select=msdyn_agentname,msdyn_agentimpactmapping,msdyn_internalprioritizationinstruction,msdyn_syncactionexecutionstateapiconfig
```

### 10b. Push a test action

Call `msdyn_PushActionDataToRecommendedActionAgent` with test data and verify:

- `msdyn_IsSuccess` = `true`
- A new record appears in `msdyn_rawactioncatalogue` with your action data

### 10c. Trigger scoring

Call `msdyn_RAAgent_TriggerRecommendedActionsAgentOrchestration` to trigger an on-demand scoring run (instead of waiting for the 4-hour timer).

### 10d. Verify scored output

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

### 10e. Verify carousel display

Go to an Opportunity form in Dynamics 365 Sales and check the Suggested Actions section. Your scored action appears in the carousel.

### 10f. Verify state sync

1. **Recommended Actions Agent → Your Agent:** Dismiss an action in the carousel. Verify your sync-back API is called with `state = "Dismissed"`.
1. **Your Agent → Recommended Actions Agent:** Mark an action in your UI. Verify the output table record has `msdyn_actionuistatus` updated.

---

## Entity reference

All entity definitions are in `solutions/NextBestActionAgent/Solution/Entities/` as `Entity.xml` files. These files are the **authoritative source**. Docs might lag behind.

### msdyn_rawactioncatalogue (Input table)

| Field | Type | Max Length | Required | Notes |
|-------|------|-----------|----------|-------|
| `msdyn_rawactioncatalogueid` | primarykey | — | System | Auto-generated GUID |
| `msdyn_actionid` | nvarchar | 850 | **Required** | Your action's unique ID. Used as dedup key. |
| `msdyn_actionreason` | ntext | 1048576 | None | Reason for the action |
| `msdyn_actionuipayload` | ntext | 1000000000 | None | JSON for card rendering |
| `msdyn_prioritizationdata` | ntext | 1048576 | None | JSON with agent-specific scoring signals |
| `msdyn_targetentityid` | lookup (polymorphic) | — | None | Lookup to Opportunity or Lead |

### msdyn_recommendedactionsourceagentconfig (Agent config)

| Field | Type | Max Length | Required | Notes |
|-------|------|-----------|----------|-------|
| `msdyn_recommendedactionsourceagentconfigid` | primarykey | — | System | Auto-generated GUID |
| `msdyn_agentname` | nvarchar | 850 | PrimaryName | Agent display name (searchable) |
| `msdyn_agentimpactmapping` | nvarchar | 1000 | None | JSON array of prioritization principle mappings |
| `msdyn_internalprioritizationinstruction` | ntext | 1048576 | None | JSON with signal interpretation metadata |
| `msdyn_syncactionexecutionstateapiconfig` | nvarchar | — | None | Name of your sync-back Custom API |
| Ownership | OrgOwned | — | — | Organization-level entity |

### msdyn_prioritizedactioncatalogue (Output table)

| Field | Type | Notes |
|-------|------|-------|
| `msdyn_prioritizedactioncatalogueid` | primary key | Auto-generated |
| `msdyn_actionid` | string | Matches input `msdyn_actionid` |
| `msdyn_actionscore` | double | UICE priority score |
| `msdyn_actionuipayload` | string | Copied from input (latest version) |
| `msdyn_scoredetails` | string | JSON: `{Explanation, Citations, CeilingExplanation, actionImpact}` |
| `msdyn_hascrossedceiling` | boolean | Whether action is above ceiling threshold |
| `msdyn_hascrossedfloor` | boolean | Whether action is below floor (false = above floor = shown) |
| `msdyn_actionuistatus` | optionset | `1-Active`, `2-MarkAsDone`, `3-Dismissed` |
| `msdyn_targetentity` | polymorphic lookup | Opportunity/Lead |
| Ownership | UserOwned | — |

## Custom API Reference

All Custom API definitions are in `solutions/NextBestActionAgent/Solution/customapis/`. These files are the **authoritative source**.

### msdyn_PushActionDataToRecommendedActionAgent

| Parameter | Direction | Type | Required |
|-----------|-----------|------|----------|
| `msdyn_ActionId` | Request | string | Yes |
| `msdyn_SourceAgentId` | Request | string | Yes |
| `msdyn_TargetEntityId` | Request | uniqueidentifier | Yes |
| `msdyn_TargetEntityTypeName` | Request | string | Yes |
| `msdyn_ActionReason` | Request | string | Yes |
| `msdyn_ActionUIPayload` | Request | string | No |
| `msdyn_ActionPrioritizationData` | Request | string | No |
| `msdyn_ActionCTA` | Request | string | No |
| `msdyn_PrioritizationPrinciples` | Request | string | No |
| `msdyn_IsSuccess` | Response | boolean | — |
| `msdyn_Error` | Response | string | — |

Privilege required: `prvWritemsdyn_rawactioncatalogue`

### msdyn_SyncActionExecutionStateFromAgent

| Parameter | Direction | Type | Required |
|-----------|-----------|------|----------|
| `msdyn_ActionId` | Request | string | Yes |
| `msdyn_ActionState` | Request | integer | Yes |
| `msdyn_TargetEntityId` | Request | uniqueidentifier | Yes |
| `TargetEntityTypeName` | Request | string | Yes |
| `msdyn_TrackingId` | Request | string | No |

Privilege required: `prvReadmsdyn_prioritizedactioncatalogue`

### msdyn_RAAgent_UpdateRecommendedActionExecutionState

| Parameter | Direction | Type | Required |
|-----------|-----------|------|----------|
| `msdyn_actionid` | Request | string | Yes |
| `msdyn_operationtype` | Request | integer | Yes |
| `msdyn_response` | Response | string | — |

> [!NOTE]
> This is a **private** API (isprivate=1) - used internally by the Recommended Actions Agent UI.

### msdyn_RAAgent_UpsertRecommendationAgentConfig

| Parameter | Direction | Type | Required |
|-----------|-----------|------|----------|
| `msdyn_RequestJson` | Request | string | Yes |
| `msdyn_ResponseJson` | Response | string | — |

### msdyn_RAAgent_FetchScoredRecommendedActions

No input parameters. Returns all active, above-floor scored actions.

| Parameter | Direction | Type |
|-----------|-----------|------|
| `msdyn_response` | Response | string (JSON) |


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

### State sync (Sales Opportunity Agent)

- **Sales Opportunity Agent → Recommended Actions Agent:** When seller marks risk as done on research page → calls `msdyn_SyncActionExecutionStateFromAgent`
- **Recommended Actions Agent → Sales Opportunity Agent:** When seller dismisses card in carousel → Recommended Actions Agent calls `ora_UpdatedActionStateFromRAAgent` (configured in agent config)

### Feature toggle (Sales Opportunity Agent)

- Admin toggle in **Sales Opportunity Agent → General → Connected Agents** section
- Per-agent-profile control - enterprise vs SMB configs can have independent toggles

## Related information

- [Recommended Actions overview](../recommended-actions-overview.md)  
- [Configure Recommended Actions](../configure-recommended-actions.md)