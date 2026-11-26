---
title: Qualify lead
description: Learn how to use the Qualify lead capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-sales
ms.custom: mcp-enabled-namespaces=sales
author: ladirohit
ms.author: ladirohit
ms.reviewer: tmanchanda
---

# Qualify lead

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller confirms that a lead should be qualified into sales records or disqualified as junk, duplicate, or no-fit.

## What it does

The assistant updates the Dynamics 365 Sales lead lifecycle. For a qualified lead, it invokes QualifyLead and can create the related opportunity, account, and contact records according to the supplied flags. For a disqualified lead, it updates the lead state and status reason.

## Try prompts like

- Qualify this lead and create an opportunity
- Convert this lead without creating a new account
- Disqualify this junk lead
- Mark this lead as not a fit

## What you'll see in chat

Because this capability changes data, the host first shows its native write-confirmation card, which previews the pending qualification or disqualification. After you select **Confirm**, the assistant displays a text response confirming whether the lead was qualified or disqualified. The tool itself doesn't render a custom app-in-chat component.

## Helpful tips

- Confirm with the seller before changing the lead lifecycle state.
- Use `get_lead_summary` first when the seller asks whether the lead looks promising.
- Provide create flags when qualification should or shouldn't create account, contact, or opportunity records.

## What happens next

- Open the qualified opportunity
- Draft follow-up email
- Update the business process flow stage
- Review the lead summary

## Does this change data?

**Yes, this can change data.**

## Prerequisites

This tool requires permission to read and write leads in the selected Dynamics 365 environment. Creating related account, contact, or opportunity records also requires the corresponding Dataverse permissions.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Qualify lead |
| Internal tool name | `qualify_lead` |
| Purpose | Qualify or disqualify a lead after seller confirmation. |

## Tool behavior

For qualified leads, the tool invokes the Dynamics 365 QualifyLead action and passes the requested create flags. For disqualified leads, the tool updates the lead state and status reason. It doesn't update ordinary lead fields or move business process flow stages.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | It changes lifecycle state but doesn't delete the record. |
| `idempotentHint` | `false` | Repeating qualification isn't a safe no-op. |

## Input concepts

| Input | Description | Required |
|---|---|---|
| `leadId` | Dataverse GUID of the open lead to qualify or disqualify. | Yes |
| `outcome` | `qualified` or `disqualified`. Defaults to `qualified`. | No |
| `createAccount` | For qualified leads, whether to create an account. | No |
| `createContact` | For qualified leads, whether to create a contact. | No |
| `createOpportunity` | For qualified leads, whether to create an opportunity. Defaults to false unless the seller asks to create or convert into an opportunity. | No |
| `opportunityCustomerId` | Optional account or contact GUID for the opportunity customer. | No |
| `opportunityCustomerType` | `account` or `contact`; required when `opportunityCustomerId` is supplied. | No |
| `opportunityCurrencyId` | Optional transaction currency GUID for the created opportunity. | No |
| `sourceCampaignId` | Optional source campaign GUID to carry into qualification. | No |
| `suppressDuplicateDetection` | Whether to suppress duplicate detection during qualification. | No |
| `statusCode` | Optional status reason override. Defaults to 3 for qualified and 7 for disqualified. | No |

## Response and UI behavior

### Response type

Text-only

The tool doesn't render a custom app-in-chat component. Because it modifies data, the host displays its native write-confirmation card to preview the change before you select **Confirm**.

## Routing notes

Use `qualify_lead` when the seller confirms a lead should be qualified, converted, disqualified, or removed from active leads because it is junk, duplicate, or no-fit. Don't use `qualify_lead` for read-only lead research (use `get_lead_summary`), ordinary field updates (use `update_entity_record`), or BPF movement (use `update_bpf_stage`).

## Related tools

| Tool | Relationship |
|---|---|
| [`get_lead_summary`](get_lead_summary.md) | Reviews the lead before qualification. |
| [`update_entity_record`](update_entity_record.md) | Updates ordinary lead fields. |
| [`update_bpf_stage`](update_bpf_stage.md) | Moves a business process flow stage. |

## Data mutation classification

Write / mutation.
