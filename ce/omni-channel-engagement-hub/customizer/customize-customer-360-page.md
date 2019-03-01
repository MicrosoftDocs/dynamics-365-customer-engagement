---
title: "Customize the Customer summary form | MicrosoftDocs"
description: "Learn on how to customize the Customer summary form in Omni-channel Engagement Hub as a system customizer."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 03/07/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: b8ce1f5a-54b5-46f3-99a4-d4829fe42e67
ms.custom: 
---
# Customize the Customer summary form

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

You can customize some forms (cards) on the **Customer summary** page by adding or removing the fields. In addition, you can change the position or alignment of forms (cards) by dragging them to meet your requirements. By default, the **Customer summary** page shows the following forms (cards).

## Customer profile

The **Customer profile** form (card) provides details about the customer or account. These details include the name of the customer or account, the category or job, the title, the relationship type, the city, and the preferred channel of engagement. You can customize this form (card) by adding or removing the fields.

## Conversation summary

The **Conversation summary** form (card) fetches details based on the context of the incoming conversation request. You can modify the fields in this form (card), and also, you can change the position of the form (card) on the **Customer summary** page.

This form (card) includes two tabs: **Pre-chat survey** and **Visitor details**. The details on these tabs help you to understand contextual channel-specific information about the conversation with the customer. The **Pre-chat survey** tab shows the conversation details, escalation details, and transfer details.

The **Visitor details** tab provides some information such as the customer is authenticated or not, browser used by the customer for contacting support, an operating system used by the customer, location of the customer, interacting language of the customer, and so on.

If the customer signs in to the portal to initiate a chat with the support, then as an agent, you can see the **Authenticated** field value as **Yes** in the **Visitor details** tab of the **Conversation summary** section. Otherwise, the **Authenticated** field value is shown as **No**.

## Issue snapshot

For an incoming conversation request, the system links an existing case to the conversation and shows it on the **Issue Snapshot** form (card). This form (card) shows information such as the title of the case, the priority, the status of the case, the product, and the owner. You can customize this form (card) by adding or removing the fields.

## Recent cases

This form section displays the recent cases that relate to the customer.

## Recent activities

The **Recent activities** form (card) shows the case-related and customer-related activities in the form of a timeline. You can create quick notes based on your discussion with the customer. You can also filter the timeline by customer activities, case activities, and conversation activities.

> [!div class="nextstepaction"]
> [Next topic: How to modify the position or alignment of the section](how-modify-position-alignment-form-section-customer360.md)

## See also

- [Omni-channel system customizers](omni-channel-engagement-hub-customizer.md)
- [How to modify the section properties of the form](how-modify-section-properties-form-section.md)
- [Add or remove the fields in the form](add-remove-fields-form-section.md)
- [Customize the conversation form](customize-conversation-form.md)
- [Configure agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md)
- [Configure notification (Screen pop) for agents](configure-notification-screen-pop-agents.md)
