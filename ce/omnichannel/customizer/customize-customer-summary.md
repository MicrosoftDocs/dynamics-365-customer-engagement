---
title: "Customize the Customer summary form | MicrosoftDocs"
description: "Learn on how to customize the Customer summary form in Omnichannel for Customer Service as a system customizer."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 07/01/2019
ms.service: 
  - dynamics-365-customerservice
ms.topic: article
---
# Customize the Customer summary form overview

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

You can customize some quick view forms on the **Customer summary** page by navigating to the entity quick view forms. By default, the **Customer summary** page shows the following sections.

## Customer profile

The **Customer profile** section provides details about the customer or account. These details include the name of the customer or account, the category or job, the title, the relationship type, the city, and the preferred channel of engagement. You can modify the quick view forms in this section by navigating to respective entity forms. To learn more, see [Customize quick view forms](customize-quick-view-form.md).

## Conversation summary

The **Conversation summary** section fetches details based on the context of the incoming conversation request.

This section includes **Pre-chat survey** and **Visitor details**. The details on these tabs help you to understand contextual channel-specific information about the conversation with the customer. The **Pre-chat survey** tab shows responses from the customer on the pre-chat questions. 

The **Visitor details** tab provides some information such as the customer is authenticated or not, browser used by the customer for contacting support, an operating system used by the customer, location of the customer, interacting language of the customer, and so on. In addition, conversation and transfer details.

If the customer signs in to the portal to initiate a chat with the support, then as an agent, you can see the **Authenticated** field value as **Yes** in the **Visitor details** tab of the **Conversation summary** section. Otherwise, the **Authenticated** field value is shown as **No**.

## Issue snapshot

For an incoming conversation request, the system links an existing case to the conversation and shows it on the **Issue Snapshot** section. This section shows information such as the title of the case, the priority, the status of the case, the product, and the owner. You can modify the quick view forms in this section by navigating to respective entity forms. To learn more, see [Customize quick view forms](customize-quick-view-form.md).

## Recent cases

This form section displays the recent cases that relate to the customer. You can modify the quick view forms in this section by navigating to respective entity forms. To learn more, see [Customize quick view forms](customize-quick-view-form.md).

## Timeline

This section displays case- and customer-related activities in the form of a timeline. You can create quick notes based on the discussion with the customer. Use the **Linked records** field to switch the timeline based on the Case, Contact, or Account record linked to the conversation.

> [!div class="nextstepaction"]
> [Next topic: Customize quick view forms](customize-quick-view-form.md)

## See also

- [Omnichannel  system customizers](omnichannel-customizer.md)
- [Customize the conversation form](customize-session-form.md)
- [Configure agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md)
- [Configure notification for agents](configure-notification-screen-pop-agents.md)
