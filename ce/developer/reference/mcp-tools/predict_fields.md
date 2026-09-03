---
title: Predict case fields
description: Learn how to use the Predict case fields capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Predict case fields

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want the AI to suggest values for case fields, such as priority, case type, or subject, based on what the case is about.

## What it does

The assistant reads the case context, its title and description, the latest email and the latest conversation on the case, and any extra details you provide, and predicts values for the fields you ask about. For each field it returns the suggested value along with a short reason. It then offers to apply the suggestions for you. If you don't name any fields, it asks you which fields you'd like predicted.

If it doesn't have what it needs—it can't tell which case you mean, the fields you named aren't real case fields, or there's no background information on the case at all—it asks you to clarify instead of guessing.

This is a suggestion tool. It doesn't change the case on its own. You stay in control of whether the predicted values are written.

## Try prompts like

- What should the priority be on CAS-01010-A0A0A0?
- Predict the case type and subject for this case.
- Suggest values for priority and origin on this ticket.
- What category does this case belong to?
- Recommend a priority for this case.
- Fill in the missing fields for this case.

## What you'll see in chat

The assistant shows a text response listing each requested field with the predicted value and a brief rationale. If it can't confidently predict a field, it tells you why. When at least one value is predicted, it offers to apply the changes. If it's missing something it needs—the case, the fields, or any background—it asks you a clarifying question first.

## Helpful tips

- The more complete the case is (a clear description and a recent customer email), the better the predictions.
- Ask about the specific fields you care about, for example "priority and case type", to keep the answer focused. If you don't name any fields, it asks which fields you'd like predicted.
- You can add context in your request, such as a quoted customer message, to ground the prediction.
- Nothing is saved until you confirm. To apply a suggestion, just say "apply the priority" or "update the case with these values."

> [!TIP]
> Pair this with your triage flow: "summarize this case" then "predict the priority and case type" to classify a new case quickly.

## What happens next

After reviewing the predictions, you can apply them with prompts like:

- Update the case with the suggested priority.
- Set the case type to the predicted value.
- Apply all of these.

Applying a direct case field uses the `update_case` tool, which writes the change immediately when called. A predicted field on a related record (a dotted path such as `incident_customer_contacts.firstname`) is applied through that record's own update tool instead. Either way, the assistant confirms with you before invoking it.

## Does this change data?

**No, predicting fields doesn't change data.**

The predictions are read-only. Applying a prediction uses a separate tool that writes the change when called—`update_case` for a direct case field, or the related record's own update tool for a dotted related-record field; the assistant confirms with you before invoking it.

## Prerequisites

This tool requires the following:

- AI features for the organization to be enabled, including pay-as-you-go billing where applicable. When AI prediction features are turned off, the tool returns no predicted values and explains that predictions are unavailable.

Learn more in [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features).

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Predict case fields |
| Internal tool name | `predict_fields` |
| Purpose | Predicts values for caller-requested fields—direct case attributes or a related record's field through a dotted path—from case context, with reasoning, and suggests applying them through the appropriate update tool |

## Tool behavior

Predicts values for the requested case fields based on the case context. Wraps the Dataverse `msdyn_PredictUserRequestedFields` unbound action. The server assembles the prediction context from the case title and description, the latest email on the case, the latest conversation on the case, and any caller-supplied context, then maps friendly field names (such as "priority") to their Dataverse logical names. Before calling the action it validates the three request components—the target case, the requested fields (direct case attributes are checked against live case field metadata; a dotted related-record path is validated for well-formedness instead), and the assembled context—and asks the user to clarify if the case can't be found, no fields were named, a requested field isn't a real case field (or is a malformed path), or no background is available. The tool is read-only: it returns predictions with reasoning and offers to apply them through the appropriate update tool—`update_case` for a direct case field, or the related record's own update tool when the field is a dotted related-record path—but never writes anything itself.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool reads case context and generates predictions without modifying data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | `true` | Predictions are generated by an AI model, so repeated calls can return different values. |

## Input concepts

### Case identifier

| Input | Description | Required |
|---|---|---|
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (for example, CAS-01010-A0A0A0). At least one is required. When `caseNumber` is provided, the server resolves it to a GUID. | Yes |

### Fields to predict

| Input | Description | Required |
|---|---|---|
| `fields` | The case fields to predict, as the user named them (for example `priority`, `case type`, `subject`). The server maps friendly names to Dataverse logical names; raw logical names also work. Fields on a related record use a dotted path—the relationship or lookup, then the field (for example `incident_customer_contacts.firstname` to predict the linked contact's first name). Omit and the tool asks you which fields to predict. | No |

### Additional context

| Input | Description | Required |
|---|---|---|
| `context` | Optional extra text lifted from the user's request (for example a quoted customer message) to ground the predictions. The case description, latest email, and latest conversation are always included automatically. | No |

## Response and UI behavior

### Response type

Text-only

Returns a text response listing each requested field with its predicted value and reasoning. Fields that can't be predicted are reported with the reason. No interactive component is rendered.

## Routing notes

Use `predict_fields` when:

- The user asks to "predict", "suggest", "recommend", or "what should the priority/type/… be" for a specific case.
- The user wants AI-suggested values for one or more case fields.

Don't use `predict_fields` when:

- **Writing values to the case**—route to `update_case`.
- **AI prose summary**—route to `summarize_case`.

## Related tools

| Tool | Relationship |
|---|---|
| [`update_case`](update_case.md) | Applies a predicted **direct case field** to the case (the suggested follow-up). A predicted related-record field applies through that record's own update tool instead. |
| [`summarize_case`](summarize_case.md) | AI prose summary of the case |
| [`get_case_highlights`](get_case_highlights.md) | Activity digest and triage signals |

## Data mutation classification

Read-only entry point with downstream mutation potential.

The prediction itself doesn't change data. The user may apply a predicted value through an update tool—`update_case` for a direct case field, or the related record's own update tool for a dotted related-record field—which changes data and confirms first.
