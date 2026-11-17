---
title: Use context-aware canvases (preview)
description: Learn how context-aware canvases bring together customer, sales, service, and activity data to help you understand records and take action.
ms.date: 11/17/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Use context-aware canvases (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

A context-aware canvas is a Dynamics 365 record page that brings together the information you need to understand a customer or business situation. Instead of reviewing related tables one at a time, you can see important details, activities, relationships, insights, and actions in one experience.

Your administrator chooses which canvases are available, what each canvas contains, and which business data insights can use. Your canvas might differ from the examples in this article.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## What insights add

Insights help a canvas interpret a record in the context of your organization's data and business processes. Depending on the canvas, it can use:

- Fields from the record that you opened.
- Related account, contact, opportunity, lead, or case records.
- Activities such as emails, meetings, and phone calls.
- Organization-specific definitions and instructions configured by your administrator.
- AI-generated insights and actions supported by the canvas.

Insights don't change your records. It uses the data that you already have permission to access.

## Example uses

| When you open | A context-aware canvas can help you |
|---|---|
| An account | Review important contacts, open deals, support issues, recent engagement, and customer risks. Learn more in [Use the canvas experience for accounts](use-account-canvas.md) |
| A contact | Understand the person's role, account relationships, communication history, and recent engagement. Learn more in [Use the canvas experience for contacts](use-contact-canvas.md)     |
| An opportunity | Review deal details, stakeholders, recent activities, competitors, and risks that might affect the close date. Learn more in [Use the canvas experience for opportunities](../sales/use-opportunity-canvas.md) |
| A case | Understand the customer, priority, service history, recent activities, and the next action needed to move the case toward resolution. Learn more in [Use the canvas experience for cases](../customer-service/use/use-case-canvas.md) |
| An email | Understand the conversation in relation to the customer, opportunity, lead, or case that the email concerns. Email information might appear within another record's canvas rather than in a separate email canvas. Learn more in [Use the modern email experience](../customer-service/use/use-modern-email.md) |

The available canvas types and features depend on your Dynamics 365 app, release, and administrator configuration.

## Supported canvases

The following tables support the context-aware canvas experience:

- Account
- Contact
- Opportunity
- Case
- Email

## Work with a canvas

When you open a supported record:

1. Review the header for key record information.
1. Review the insights or **What's important now** section, if your canvas includes it.
1. Check when an insight was calculated and review its supporting information.
1. Use the timeline to understand recent emails, meetings, calls, and notes.
1. Review related records and relationships for additional context.
1. Review the content of any available action before continuing. For example, an email draft isn't sent until you send it.

Your canvas might also let you edit supported fields directly. Fields and commands that aren't available on the canvas remain available on the classic form.

## How permissions affect the canvas

The canvas respects Dynamics 365 and Dataverse security:

- You see only records and fields that you have permission to access.
- An insight might differ between users who have access to different records.
- Related data that you can't access isn't included in your canvas or insight.
- Insights don't grant new access to data.

For example, a sales manager who can access opportunities across a business unit might see broader account pipeline context than a seller who can access only their own opportunities.

## Why your canvas might look different

Your administrator can:

- Choose which canvases are available in each app.
- Choose who sees a canvas.
- Add, remove, or reorder canvas components.
- Add standard or custom tables for insights to use.
- Define business terms and processes that influence supported insights.
- Turn individual insights on or off.

If a colleague sees a different canvas or insight, you might be using different apps, have different permissions, or belong to a different canvas audience.

## If expected context is missing

If you don't see an expected canvas, insight, or related record:

1. Confirm that you opened the record in the correct Dynamics 365 app.
1. Check whether you can open the related record directly.
1. Refresh the record if the information recently changed.
1. Ask your administrator whether the canvas, table, or insight is enabled for you.

An insight might take time to reflect newly added data because insights and the semantic model refresh information periodically.

## Related information

- [Insights overview for administrators](insights-overview.md)
- [Use the canvas experience for opportunities](../sales/use-opportunity-canvas.md)
- [Work with accounts and contacts](../sales/accounts-contacts.md)
- [Copilot overview](../sales/copilot-overview.md)
