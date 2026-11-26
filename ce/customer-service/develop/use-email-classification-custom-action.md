---
title: Use the email classification custom action
description: Learn how to use the email classification custom action to classify email records in Dynamics 365 Customer Service.
author: lalexms
ms.author: laalexan
ms.topic: reference
ms.date: 08/21/2026
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
---

# Use the email classification custom action

Use the `msdyn_EmailClassificationCustomAction` Dataverse action to analyze an existing email record and assign one of the active email categories configured for your organization. The action returns the matched category, its Dataverse ID, and an AI-generated explanation so that you can continue with routing, case creation, reporting, or other business logic.

The action updates the **Email category (AI)** and **Classification Status** fields on the email record.

> [!IMPORTANT]
> Don't invoke this action when built-in automatic email classification has already processed the email. Classifying the same email more than once can increase AI consumption, overwrite existing classification results, and cause downstream processes to execute multiple times.

## Prerequisites

- [Email classification](../administer/configure-email-classification.md) is available and enabled in Dynamics 365 Customer Service.
- At least two active email categories are configured.
- [Pay-as-you-go billing](/copilot/microsoft-365/pay-as-you-go/overview) is enabled for the environment.
- The required Copilot, AI agent, and cross-geography permissions are enabled.
- The email record exists in Dataverse.
- The user invoking the action has permissions to read and update the email record and read the email classification configuration.

## Request details

| Property | Value |
|---|---|
| Unique name | `msdyn_EmailClassificationCustomAction` |
| Binding | Global or unbound |
| Method | `POST` |
| Web API URL | `https://<organization-url>/api/data/v9.2/msdyn_EmailClassificationCustomAction` |
| Power Automate operation | Microsoft Dataverse - Perform an unbound action |

## Request parameters

| Parameter | Type | Required | Description |
|---|---|---|---|
| `emailId` | String | Yes | GUID of an existing Dataverse email record. Pass the row ID as text without braces. |
| `doRuleEvaluation` | Boolean | Yes | Determines whether the configured email classification conditions are evaluated. Use `true` to apply the conditions configured by the administrator. Use `false` only when the calling flow checks whether the email meets the required conditions before it calls the action. |
| `isSimulationMode` | Boolean | No | Enables implementation-specific simulation behavior. Use `false` for production classification. |
| `additionalInfo` | String | No | Contains a JSON-encoded subject and body for content-only simulation. Leave this value empty for production classification. |

For production classification, pass the email row ID, set `doRuleEvaluation` to `true`, set `isSimulationMode` to `false`, and leave `additionalInfo` empty.

## Response properties

| Property | Type | Description |
|---|---|---|
| `emailclassificationResponse` | String | JSON-encoded classification result that contains the category, reason, and optional hierarchy details. |
| `matchedCategoryId` | String | GUID of the matched `msdyn_emailclassificationcategory` row. Use this value for deterministic branching and Dataverse lookups. |
| `status` | String | JSON-encoded object that contains an application-level code and message. |

Both `status` and `emailclassificationResponse` contain JSON stored as strings, not native JSON objects. Some prerequisite, skipped, and exception paths can return empty strings. Check that each value isn't empty before parsing it with the Power Automate `json()` expression.

## Call the action from Power Automate

1. Add a Dataverse trigger, or use an earlier flow step that provides the ID of an existing email record.
1. Add the Microsoft Dataverse **Perform an unbound action** step.
1. For **Action name**, select `msdyn_EmailClassificationCustomAction`.
1. Map `emailId` to the email row ID, typically `activityid`.
1. Set `doRuleEvaluation` to `true`, unless the flow applies equivalent eligibility filtering.
1. Set `isSimulationMode` to `false`, and leave `additionalInfo` empty.
1. Confirm that `status` isn't empty, and then parse it as JSON.
1. Continue only when `status.code` is `200` and `matchedCategoryId` isn't empty.
1. Use `matchedCategoryId` for category-based routing or other automation.

To parse the status, use the following expression. Replace `Perform_an_unbound_action` if your action has a different name.

```powerautomate
json(body('Perform_an_unbound_action')?['status'])
```

To parse the classification result, use the following expression:

```powerautomate
json(body('Perform_an_unbound_action')?['emailclassificationResponse'])
```

> [!IMPORTANT]
> The action updates the email row. If the flow is triggered when that row changes, filter the trigger columns or check **Classification Status** before calling the action. Otherwise, the action can retrigger the same flow.

## Request example

```http
POST https://<organization-url>/api/data/v9.2/msdyn_EmailClassificationCustomAction
Accept: application/json
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
```

```json
{
  "emailId": "<email-guid>",
  "doRuleEvaluation": true,
  "isSimulationMode": false
}
```

## Successful response example

```http
HTTP/1.1 200 OK
Content-Type: application/json
```

```json
{
  "@odata.context": "https://<organization-url>/api/data/v9.2/$metadata#Microsoft.Dynamics.CRM.msdyn_EmailClassificationCustomActionResponse",
  "emailclassificationResponse": "{\"index\":1,\"category\":\"Marketing\",\"reason\":\"The email promotes a product or service.\",\"status\":null}",
  "matchedCategoryId": "<category-guid>",
  "status": "{\"code\":200,\"message\":\"Success\"}"
}
```

## Classification response fields

The parsed `emailclassificationResponse` can contain the following fields.

| Field | Description | Usage guidance |
|---|---|---|
| `index` | Zero-based position of the selected category in the AI request. | Don't use this value as a durable identifier. |
| `category` | Name of the selected category. | Use for display. Category names can be edited. |
| `reason` | AI-generated explanation for the selection. | Use for display or diagnostics, not deterministic branching. |
| `selectedPath` | Optional hierarchy path when hierarchical classification is enabled. | Use only when the value is present. |
| `finalCategory` | Optional final hierarchy node selected by the service. | The action uses this value to resolve the Dataverse category. |
| `confidence` | Optional confidence information for hierarchical results. | Don't assume this value is always present. |
| `evidence` | Optional model evidence for hierarchical results. | Don't assume this value is always present. |

## Classification status values

| Value | Label | Description |
|---|---|---|
| `0` | Default | No completed classification outcome is recorded. |
| `1` | Skipped | The email wasn't classified because a required condition wasn't met. |
| `2` | Success | A category was matched and written to the email record. |
| `3` | Failed | The classification attempt encountered an error. |

## Handle action outcomes

A successful Power Automate action step doesn't always mean that classification succeeded. Classification is successful only when:

- The action step succeeds.
- `status` is present.
- The parsed `status.code` value is `200`.
- `matchedCategoryId` isn't empty.

Use the following guidance for other outcomes:

| Scenario | Expected behavior | Recommended flow handling |
|---|---|---|
| An eligibility condition doesn't match. | Response strings can be empty, and Classification Status is **Skipped**. | End the flow normally or use a nonclassified path. |
| A required Copilot or cross-geography permission isn't available. | Response strings can be empty, and Classification Status is **Skipped**. | Log an environment or configuration issue. |
| Fewer than two active categories are configured. | The logical status can be empty, and Classification Status is **Failed**. | Notify an administrator to correct the category configuration. |
| The classification service returns an HTTP error. | `status` contains the service HTTP code and message. | Use controlled retry and escalation policies. |
| No category is returned. | `status.code` is `500`, and the message is `No category returned.` | Log the failure and use a safe fallback. |
| No service response is received. | `status.code` is `500`, and the message is `No response from API.` | Log the failure and use a safe fallback. |
| The email ID is invalid or the calling user lacks a required Dataverse privilege. | The flow step can fail, or logical outputs can be empty. | Use **Configure run after** to capture and log the failure. |

## Related information

- [Configure email classification in Customer Service](../administer/configure-email-classification.md)  
- [Use a flow to perform bound and unbound actions in Dataverse](/power-automate/dataverse/bound-unbound)  
- [Create and use custom APIs in Microsoft Dataverse](/power-apps/developer/data-platform/custom-api)
