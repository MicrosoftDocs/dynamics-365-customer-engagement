---
title: Validate email
description: Learn how to validate a real-time marketing email with Dynamics 365 Customer Insights.
ms.date: 09/01/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: tovyhnal
ms.author: tovyhnal
ms.reviewer: tovyhnal
---

# Validate email

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to preflight an existing real-time marketing email before publishing or sending it.

## What it does

The capability sends the Email Channel validation request to the same `msdynmkt_ValidateEmail` Custom API used by the Customer Insights email editor. It checks the email content, personalization placeholders, conditional content, compliance context, and other validation surfaces supported by the installed Email Channel version. It returns the validation findings without changing the email.

## Try prompts like

- Validate this real-time marketing email before I publish it.
- Preflight this email and show me its content and placeholder validation errors.
- Check whether this Customer Insights email is ready to send.

Provide the serialized Email Channel validation request. The request must identify the existing email through its `messageId` and include the content and context to validate.

## What you'll see in chat

The assistant confirms that validation completed and returns the parsed message and placeholder findings in structured content. Each finding can include its namespace, code, severity, and message. The assistant doesn't copy email content or recipient addresses into its narration.

## Helpful tips

- Use the validation-request shape produced by the Customer Insights email editor or Email Channel integration.
- Include the current email content and placeholder definitions; validation only covers what the request supplies.
- Resolve error-severity findings before publishing or sending. Review warnings and informational findings in context.

## What happens next

After reviewing the result, correct the email in Customer Insights and validate it again. Check recipient consent separately before sending.

## Does this change data?

**No.** The capability validates the supplied state and doesn't update the email.

## Prerequisites

- The Email Channel solution and `msdynmkt_ValidateEmail` Custom API must be installed in the selected environment.
- The request must contain the GUID of an existing `msdynmkt_email` record.
- The caller must have read access to that email. Dataverse and the Custom API enforce record-level access.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Validate Email |
| Internal tool name | `validate_email` |
| Purpose | Validates an existing real-time marketing email before publication or send |

## Tool behavior

The tool validates the request envelope, verifies that `messageId` is a GUID, and calls the installed Email Channel Custom API. It returns the Custom API's parsed validation result without interpreting, suppressing, or fabricating findings.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | The tool doesn't modify the email. |
| `destructiveHint` | Not set | Not applicable to a read-only tool. |
| `idempotentHint` | Not set | Not applicable to a read-only tool. |
| `openWorldHint` | Not set | Uses the default because it calls a Dataverse Custom API. |

## Input concepts

| Input | Description | Required |
|---|---|---|
| `validateRequest` | Serialized Email Channel validation-request JSON containing `messageId`, message content parts, placeholders, and validation context. Maximum 1,048,576 UTF-8 bytes. | Yes |

## Response and UI behavior

This tool returns a text response with structured validation data. It isn't backed by an app-in-chat component.

### Response type

Email validation result containing message and placeholder result groups.

## Routing notes

Use `validate_email` when the user wants validation findings for an existing Customer Insights marketing email. Don't use it to check recipient consent, generate an unsubscribe link, draft content, send an email, or create a journey.

## Related tools

| Tool | Relationship |
|---|---|
| [`check_consent`](check_consent.md) | Checks whether a recipient can receive a marketing message |
| [`get_unsubscribe_link`](get_unsubscribe_link.md) | Generates a compliant unsubscribe link |
| `create_journey` | Creates a journey after its journey JSON has been validated |

## Data mutation classification

Read-only. The tool validates supplied email state and doesn't update the email or another Dataverse record.
