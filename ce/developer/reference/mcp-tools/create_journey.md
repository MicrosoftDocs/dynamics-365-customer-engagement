---
title: Create journey
description: Learn how to use the Create journey capability in Dynamics 365 Customer Insights.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: tovyhnal
ms.author: demazuro
ms.reviewer: demazuro
---

# Create journey

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you have a complete Customer Insights journey definition and want to validate and create the journey in Dataverse.

## What it does

This capability validates the supplied journey JSON, enriches it with Customer Insights metadata, validates the enriched definition, and creates a journey record only when validation succeeds. It returns the created journey ID and validation result. The enriched journey definition and modified properties aren't included in the model-visible response.

Creating the record doesn't publish or start the journey. Review the created journey in Customer Insights before activation.

## Try prompts like

- Create a Customer Insights journey from this complete journey JSON.
- Validate, enrich, and create this one-time journey definition.
- Create this journey after checking that its contract is valid.

## What you'll see in chat

The assistant reports the created journey ID and validation result. If validation fails, no journey record is created and the validation result explains the rejected definition.

## Helpful tips

- Supply a complete journey JSON definition, including its name, trigger, audience, actions, target entity logical names, and other required journey settings.
- Keep contract validation enabled unless a supported integration specifically requires otherwise.
- Review the returned validation result and the created record before publishing or activating the journey.
- Don't repeat a create request after a timeout unless the assistant confirms whether the original request created a record.

## What happens next

Open the created journey in Customer Insights to review its audience, content, schedule, consent settings, and activation readiness.

## Does this change data?

**Yes. This capability creates a Customer Insights journey record.**

The operation isn't idempotent. Repeating the same request can create another journey. It doesn't publish, activate, or send the journey.

## Prerequisites

This tool is available on the Dynamics 365 Customer Insights MCP server. Customer Insights journeys must be provisioned for the selected environment. You need permission to run the journey validation and enrichment APIs and to create journey records. The journey JSON must reference valid environment-specific audience, content, compliance, and related identifiers.

## Tool summary

| Property           | Value                                                                                |
| ------------------ | ------------------------------------------------------------------------------------ |
| User-facing name   | Create Journey                                                                       |
| Internal tool name | `create_journey`                                                                     |
| Purpose            | Validates, enriches, validates again, and creates a Customer Insights journey record |

## Tool behavior

Calls the Customer Insights journey validation API, enriches the accepted definition, validates the enriched definition, and creates the resulting `msdynmkt_journey` record. Validation failures return without creating a record.

## Annotations

| Annotation        | Value   | Meaning                                                                     |
| ----------------- | ------- | --------------------------------------------------------------------------- |
| `readOnlyHint`    | `false` | Creates a journey record.                                                   |
| `destructiveHint` | `false` | Creates a record but doesn't delete or overwrite an existing journey.       |
| `idempotentHint`  | `false` | Repeating a successful request can create another journey.                  |
| `openWorldHint`   | Not set | Uses the default because it calls Customer Insights APIs through Dataverse. |

## Input concepts

| Input                    | Description                                                                             | Required |
| ------------------------ | --------------------------------------------------------------------------------------- | -------- |
| `journeyJson`            | Complete Customer Insights journey definition serialized as JSON.                       | Yes      |
| `shouldValidateContract` | Whether both validation calls should validate the journey contract. Defaults to `true`. | No       |

## Response and UI behavior

This tool returns a text response and isn't backed by an app-in-chat component.

### Response type

Journey creation result.

The response contains the created journey ID and validation result. It doesn't expose the enriched journey JSON or modified-properties payload to the model.

## Routing notes

Use `create_journey` for:

- Validating, enriching, and creating a journey from a complete journey JSON definition.

Don't use `create_journey` when:

- The user wants to check recipient consent—route to `check_consent`.
- The user needs an unsubscribe URL—route to `get_unsubscribe_link`.
- The user wants to publish, activate, pause, or delete an existing journey; this capability doesn't perform those actions.

## Related tools

| Tool                                                | Relationship                                                 |
| --------------------------------------------------- | ------------------------------------------------------------ |
| [`check_consent`](check_consent.md)                 | Checks a recipient's consent before journey communication    |
| [`get_unsubscribe_link`](get_unsubscribe_link.md)   | Generates a compliant unsubscribe link for a journey message |
| [`get_customer_segments`](get_customer_segments.md) | Lists segments that can help identify a journey audience     |

## Data mutation classification

Create-only mutation.

This tool creates one Customer Insights journey record after successful validation and enrichment. It doesn't update, delete, publish, activate, or send an existing journey.
