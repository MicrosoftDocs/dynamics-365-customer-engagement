---
title: Get unsubscribe link
description: Learn how to use the Get unsubscribe link capability in Dynamics 365 Customer Insights.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: PetrJantac
ms.author: demazuro
ms.reviewer: demazuro
---

# Get unsubscribe link

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you need a compliant unsubscribe link to embed in a message or share with a recipient.

## What it does

This capability generates a Customer Insights unsubscribe link for a specific recipient and message context. Pass the target entity and its type, the purpose, the compliance settings, the message template, and the recipient's contact point; the assistant returns the unsubscribe link. You can request a one-click (RFC 8058) unsubscribe link when the message requires one.

Generating the link doesn't change a recipient's consent—it produces the URL a recipient uses to opt out themselves.

## Try prompts like

- Get the one-click unsubscribe link for this message.
- Generate the unsubscribe link for this message template and contact.
- I need the compliant one-click unsubscribe URL for this recipient and message template.
- Create an unsubscribe link for this contact and marketing purpose.
- Give me the opt-out link to embed in this message.

## What you'll see in chat

The assistant replies with the generated unsubscribe link for the recipient and message context—the one-click variant when you request it. The link lets the recipient opt out; it doesn't change their consent until they use it.

## Helpful tips

- Provide the required values: target entity and type, purpose, compliance settings, message template, and contact point.
- Request the one-click option when the message needs an RFC 8058 one-click unsubscribe header link.
- To confirm a recipient's current opt-in state before sending, check consent first.

## What happens next

You can follow up with prompts like:

- Is this contact opted in to marketing emails for this purpose?
- Show me everything Customer Insights knows about this customer.
- Which segments is this customer in?

## Does this change data?

**No, generating an unsubscribe link doesn't change data.**

This capability generates a link but never changes a contact's opt-in state. Consent only changes if and when the recipient uses the link to opt out.

## Prerequisites

This tool is available on the Dynamics 365 Customer Insights MCP server. See the availability note at the top of this page for details. Customer Insights marketing (real-time journeys compliance) must be configured for your environment, you need the purpose, compliance settings, and message template identifiers, and you need permission to run the unsubscribe-link compliance API.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Get Unsubscribe Link |
| Internal tool name | `get_unsubscribe_link` |
| Purpose | Generates a compliant Customer Insights unsubscribe link for a recipient and message |

## Tool behavior

Generates a Customer Insights unsubscribe link for a recipient and message context (the `msdynmkt_getunsubscribelink` Custom API). Pass the target entity and its type, the purpose, compliance settings, message template, and contact point; the tool returns the unsubscribe link payload verbatim, optionally as a one-click (RFC 8058) link. Generating the link never changes a contact's opt-in state.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | Read-only; this tool generates a link but doesn't modify data or change consent. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (calls the Customer Insights compliance API through Dataverse). |

## Input concepts

### Recipient and message

| Input | Description | Required |
|---|---|---|
| `entityId` | The target entity ID (GUID), such as the contact or lead. | Yes |
| `entityType` | The target entity's logical name, such as `contact`. | Yes |
| `contactPoint` | The recipient's contact point, such as an email address. | Yes |
| `messageTemplateId` | The message template ID (GUID) the link is generated for. | Yes |

### Compliance context

| Input | Description | Required |
|---|---|---|
| `purposeId` | The consent purpose ID (GUID). | Yes |
| `complianceSettingsId` | The compliance settings ID (GUID). | Yes |
| `topicId` | An optional consent topic ID (GUID). | No |
| `owningBusinessUnitId` | An optional owning business unit ID (GUID). | No |

### Link options

| Input | Description | Required |
|---|---|---|
| `oneClickUnsubscribeLink` | Set to request a one-click (RFC 8058) unsubscribe link. | No |
| `sourceApplication` | An optional source application identifier. | No |
| `sourceMessageEntityName` | An optional source message entity logical name. | No |

## Response and UI behavior

This tool returns a text response.

This MCP tool is not backed by an app-in-chat component.

### Response type

Unsubscribe link.

The response returns the generated unsubscribe link for the recipient and message context, as a one-click link when requested.

## Routing notes

Use `get_unsubscribe_link` for:

- Producing a compliant unsubscribe URL to embed in a message or share with a recipient.

Don't use `get_unsubscribe_link` when:

- The user wants to confirm current opt-in state—route to `check_consent`.
- The user wants a customer's profile, segments, or measures—route to the matching Customer Insights reader.

## Related tools

| Tool | Relationship |
|---|---|
| [`check_consent`](check_consent.md) | Confirms a recipient's current opt-in state |
| [`get_customer_details`](get_customer_details.md) | Returns the full Customer 360 for a resolved customer |
| [`find_customer`](find_customer.md) | Finds a customer by name |

## Data mutation classification

Read-only.

This tool generates an unsubscribe link but never changes a contact's opt-in state or any other record. Consent changes only if the recipient uses the link to opt out.
