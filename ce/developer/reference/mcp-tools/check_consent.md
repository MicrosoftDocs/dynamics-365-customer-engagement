---
title: Check consent
description: Learn how to use the Check consent capability in Dynamics 365 Customer Insights.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: PetrJantac
ms.author: demazuro
ms.reviewer: demazuro
---

# Check consent

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to confirm whether a recipient has opted in before sending or recommending a marketing message.

## What it does

This capability checks a recipient's Customer Insights marketing consent for a specific channel, purpose, and topic. Pass the channel type, the purpose and topic, the contact point being checked (such as an email address), the owning business unit, and the compliance settings. The assistant returns the compliance service's consent decision—including whether consent is given and the reason—for exactly that combination.

Check consent before you send or recommend a message. This capability reads the current opt-in state; it never changes a recipient's consent.

## Try prompts like

- Is this contact opted in to marketing emails for this purpose?
- Check the marketing email consent for this contact and purpose.
- Before we send, confirm this contact's consent state for the email channel, purpose, and topic.
- Has this recipient consented to SMS for this topic?
- Can we email this contact for this marketing purpose?

## What you'll see in chat

The assistant replies with the compliance service's consent decision for the requested channel, purpose, and topic—whether consent is given and the reason. It reflects the current opt-in state and doesn't change it.

## Helpful tips

- Provide all six required values: channel type, purpose, topic, contact point, owning business unit, and compliance settings.
- Check consent right before sending—consent state can change over time.
- To give a recipient a compliant way to opt out, generate an unsubscribe link.

## What happens next

You can follow up with prompts like:

- Get the one-click unsubscribe link for this message and contact.
- Show me everything Customer Insights knows about this customer.
- Which segments is this customer in?

## Does this change data?

**No, checking consent doesn't change data.**

This capability reads the recipient's current consent decision from the compliance service. It never changes a contact's opt-in state or any other record.

## Prerequisites

This tool is available on the Dynamics 365 Customer Insights MCP server. See the availability note at the top of this page for details. Customer Insights marketing (real-time journeys compliance) must be configured for your environment, you need the purpose, topic, owning business unit, and compliance settings identifiers for the check, and you need permission to run the consent compliance API.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Check Consent |
| Internal tool name | `check_consent` |
| Purpose | Checks a recipient's Customer Insights marketing consent for a channel, purpose, and topic |

## Tool behavior

Checks Customer Insights marketing consent for a contact point on a channel and purpose (the `msdynmkt_checkconsent` Custom API). Pass the channel type, purpose, topic, contact point, owning business unit, and compliance settings; the tool returns the compliance service's consent decision verbatim. It reads consent state and never changes a contact's opt-in status.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | Read-only; this tool doesn't modify data or change consent. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (calls the Customer Insights compliance API through Dataverse). |

## Input concepts

### Channel and consent context

| Input | Description | Required |
|---|---|---|
| `channelType` | The channel to check, such as `Email` or `SMS`. | Yes |
| `purposeId` | The consent purpose ID (GUID). | Yes |
| `topicId` | The consent topic ID (GUID). | Yes |

### Recipient and compliance

| Input | Description | Required |
|---|---|---|
| `contactPoint` | The contact point being checked, such as an email address or phone number. | Yes |
| `owningBusinessUnitId` | The owning business unit ID (GUID). | Yes |
| `complianceSettingsId` | The compliance settings ID (GUID). | Yes |

## Response and UI behavior

This tool returns a text response.

This MCP tool is not backed by an app-in-chat component.

### Response type

Consent decision.

The response returns the compliance service's decision for the requested channel, purpose, and topic—including whether consent is given and the reason.

## Routing notes

Use `check_consent` for:

- Confirming whether a recipient has opted in on a channel for a purpose and topic before sending a marketing message.

Don't use `check_consent` when:

- The user needs an unsubscribe URL to embed or share—route to `get_unsubscribe_link`.
- The user wants a customer's profile, segments, or measures—route to the matching Customer Insights reader.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_unsubscribe_link`](get_unsubscribe_link.md) | Generates a compliant unsubscribe link for a recipient |
| [`get_customer_details`](get_customer_details.md) | Returns the full Customer 360 for a resolved customer |
| [`get_customer_segments`](get_customer_segments.md) | Lists the segments a customer belongs to |

## Data mutation classification

Read-only.

This tool reads the recipient's consent decision from the compliance service and never changes a contact's opt-in state or any other record.
