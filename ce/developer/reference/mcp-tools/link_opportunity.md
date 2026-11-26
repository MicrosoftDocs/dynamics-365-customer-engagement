---
title: Link opportunity
description: Learn how to use the Link opportunity capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Link opportunity

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs to connect an opportunity to account or contact relationship work.

## What it does

The assistant links one Dynamics 365 Sales opportunity to either an account or a contact. Account links set the opportunity customer account. Contact links create or update an opportunity role relationship for that contact.

## Try prompts like

- Link this opportunity to the Northpeak Manufacturing account plan
- Add Marcus Bell as a contact role on the E5 Rollout opportunity
- Connect this renewal opportunity to the account relationship work
- Track this contact against the opportunity as the economic buyer

## What you'll see in chat

The assistant displays a text response directly in chat. There is no interactive app-in-chat component for this capability.

## Helpful tips

- Resolve ambiguous opportunity, account, and contact names before calling tools that require identifiers.
- Use `get_stakeholder` to review current opportunity or account stakeholders before adding more relationship context.
- Use `update_stakeholder` when you need to add or change connection-backed stakeholder roles.

## What happens next

After the response appears, you can continue with prompts like:

- Show stakeholders on this opportunity
- Draft a follow-up email to this contact
- Add a note to the account
- Schedule a relationship review meeting

## Does this change data?

**Yes, link_opportunity changes Dynamics 365 Sales data.**

For account links, the tool updates the opportunity customer account. For contact links, it creates or updates an opportunity role relationship.

## Prerequisites

This tool requires access to Dynamics 365 Sales opportunities. Contact opportunity-role links also require access to contact and relationship role data for the selected environment.

## Tool summary

| Property           | Value                                                         |
| ------------------ | ------------------------------------------------------------- |
| User-facing name   | Link Opportunity                                              |
| Internal tool name | `link_opportunity`                                            |
| Purpose            | links an opportunity to account or contact relationship work. |

## Tool behavior

The tool writes relationship data in Dataverse and returns a text-only response with structured content for agent orchestration.

## Annotations

| Annotation        | Value   | Meaning                                                                            |
| ----------------- | ------- | ---------------------------------------------------------------------------------- |
| `readOnlyHint`    | `false` | This tool modifies data.                                                           |
| `destructiveHint` | `false` | This tool does not delete records.                                                 |
| `idempotentHint` | `false` | The contact path checks for an existing role and then inserts; that sequence isn't atomic, so repeats aren't automatically safe to replay. |
| `openWorldHint`   | Not set | Uses default (queries Dataverse).                                                  |

## Input concepts

### Opportunity relationship context

| Input                | Description                                                                                      | Required |
| -------------------- | ------------------------------------------------------------------------------------------------ | -------- |
| `opportunityId`      | Resolved opportunity GUID to link.                                                               | Yes      |
| `entityLogicalName`  | Target type: `account` or `contact`.                                                             | Yes      |
| `targetRecordId`     | Resolved account or contact GUID to link to the opportunity.                                     | Yes      |
| `relationshipRoleId` | Contact links only — relationship role GUID for the contact's role on the deal. Rejected for account links. | No |
| `description` | Contact links only — description for the contact opportunity role. Rejected for account links. | No |

## Response and UI behavior

This tool returns a text-only response with no app-in-chat component.

### Response type

Text narrative

The response includes structured content with the opportunity id, target record, link type, the `outcome` of the call (`created`, `updated`, or `unchanged`), whether the link already existed, and the opportunity-role id when available.

### Repeat calls

Linking the same contact to the same opportunity twice does not create a duplicate role — the tool finds the existing row and updates it, or reports `unchanged` when you supply no new values. Because the check-then-write is not atomic, two *simultaneous* identical calls could still both insert, so the tool is not marked idempotent for automatic retry.

The account path behaves differently: it sets `opportunity.customerid`, so a repeat call with the same account simply rewrites the same value, and a call with a *different* account **repoints the opportunity to that account** rather than adding a second one. An opportunity has exactly one customer account.

## Routing notes

Use `link_opportunity` when the user asks to connect, link, or track an opportunity against account or contact relationship work. Don't use it to link competitors; use `link_competitor_to_opportunity` for competitor associations.

## Related tools

| Tool                                                                  | Relationship                                              |
| --------------------------------------------------------------------- | --------------------------------------------------------- |
| [`get_stakeholder`](get_stakeholder.md)                               | Lists stakeholders connected to an opportunity or account |
| [`update_stakeholder`](update_stakeholder.md)                         | Adds or updates stakeholder connection roles              |
| [`link_competitor_to_opportunity`](link_competitor_to_opportunity.md) | Links competitors to opportunities                        |

## Data mutation classification

Write, non-destructive.
