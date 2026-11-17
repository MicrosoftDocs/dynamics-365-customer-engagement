---
title: Overview of CRM Canvas Designer (preview)
description: Learn how the canvas designer helps you create and customize record pages with components that bring customer information together in Dynamics 365.
ms.date: 11/17/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-cross-app
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: udaykirang
ms.author: udag
ai-usage: ai-assisted
---

# Overview of CRM Canvas Designer (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

In Dynamics 365, use CRM Canvas Designer to build and change record pages called canvases. A canvas is a record page for one table, such as account or contact, made of sections and components. Sellers and customer service representatives see a canvas view when they open a record.  
The canvas designer brings together your data, insights, and a layout that fits how your teams work. Admins and makers customize the canvas and choose who can access it. 

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## How canvases fit together

The canvas designer is part of canvas studio, a tile in the Dynamics 365 AI hub. Canvas studio has two parts:

- **Canvases**: Record pages that users see. Canvases are available for account, contact, opportunity, and case records. You change them, or build your own, in the canvas designer.
- **Insights**: Copilot's understanding of your business. It learns from your Dynamics 365 data and how your business works, and it powers the insights and actions that appear on canvases.  Insights are available for contact and account. Learn more in [insights overview](insights-overview.md)

The canvas designer decides where and how much of that understanding appears on a record page. Your insights setup decides what the insights are.

## Bring customer information together

| Canvas | What your team can review | Reference articles |
|---|---|
| **Account** | Account information, insights, recent activities, a relationship map, and related business records, such as opportunities and cases. | [Use account canvas](use-account-canvas.md) |
| **Contact** | Contact information, insights, notes, recent activities, business involvement, and relationships. | [Use contact canvases](use-contact-canvas.md) |
| **Opportunity** | Key opportunity information, upcoming meetings, and recent activities, and perform actions in one experience
 . | [Use opportunity canvas](../sales/use-opportunity-canvas.md)
| **Case** | Customer and case information that helps service representatives understand the case and work toward resolution in Copilot Service workspace. | [Use case canvases](../customer-service/use/use-case-canvas.md) |
| **Email** | Email information and related customer context to help service representatives respond effectively. | [Use the canvas experience in email](../customer-service/use/use-modern-email.md)|

Components vary by canvas, and your customizations can change what your team sees. For example, an account canvas can bring open opportunities and support cases together so a seller can review service concerns before a customer meeting.

Learn more in [Insights overview](insights-overview.md).

## How each role uses canvases

| Role | How they use it | Reference articles | 
|---|---|---|
| Admin | Turns on canvases in Canvas studio, chooses the apps and people who see them, and sets up insights. Controls organization-wide choices, such as which insights are on and whether insights include duplicate records. |- [Create and publish a canvas in CRM Canvas Designer](configure-canvas.md)<br>- [Manage canvases in CRM Canvas Designer](manage-canvases.md).<br>- [Set up and configure insights](set-up-configure-insights.md)<br>- [Create and manage custom insights](create-manage-custom-insights.md) |
| Seller |Opens the canvas experience when they open a account, contact, or opportunity record. Starts with **What's important now** and then quickly gets an overview of the account, contact, or deal information.   |- [Use the canvas experience for accounts](use-account-canvas.md)<br>- [Use contact canvases](use-contact-canvas.md)<br>- [Use the canvas experience for opportunities](../sales/use-opportunity-canvas.md)<br>- [Account and contact insights in Copilot and agents](insights-in-agents.md) |
| Service representative | Uses the same account and contact canvases as sellers to understand a customer, case and emails canvases to work a case through to resolution. The same account and contact insights can also appear in Service agent. |- [Use the canvas experience for accounts](use-account-canvas.md)<br>- [Use contact canvases](use-contact-canvas.md)<br>- [Use case canvases](../customer-service/use/use-case-canvas.md)<br>- [Use the canvas experience in email](../customer-service/use/use-modern-email.md)<br>- [Account and contact insights in Copilot and agents](insights-in-agents.md) |

## Example: Contact at Contoso

Contoso's sellers want to reach quiet contacts sooner.

**The administrator view.** The maker opens the contact canvas in the canvas designer, which creates Contoso's own copy. They add Contoso's custom *Preferred contact channel* field to the contact information, keep the timeline focused on recent activity, and show three insight cards before **See more**. The admin publishes the canvas to the sales team in Sales Hub.

**The user view.** A user opens a contact and lands on *What's important now*. The **Contact Two-Way Engagement Recency** insight shows how many days have passed since the contact last engaged back, and the card offers a drafted message to re-engage them. The draft is built only from facts in the record, and nothing is sent until the user sends it.

If the admin turned on duplicate detection, insights also include the customer's duplicate records. Nothing is merged or changed.

:::image type="content" source="media/canvas-contact-360.png" alt-text="Screenshot of the contact canvas showing the header, What's important now insight cards, contact information, and the timeline." lightbox="media/canvas-contact-360.png":::

## Related information

[Use context-aware canvases](context-aware-canvases-overview.md)     
[Use the canvas experience for opportunities](../sales/use-opportunity-canvas.md)         

