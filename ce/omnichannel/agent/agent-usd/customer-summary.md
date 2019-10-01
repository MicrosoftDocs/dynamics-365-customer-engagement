---
title: "View customer summary | MicrosoftDocs"
description: "Customer summary is a form where you can know complete information about the customer with whom you are going to interact."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: d53f1b1f-0361-4334-827c-d299137a9075
ms.custom: 
---
# View customer summary and know everything about customers

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

## Overview of the existing challenges

One of the major challenges that customers face when contacting customer support is providing repetitive information about the issue with the support agent. Also, if the customer wants to review the status of the request raised at a later stage, the customer shares the same information with another support agent to explain the context of the conversation. To avoid this situation, the support agent must access the customer information with details about the product/service, issue, cases history, related cases, location, and so on.

By having this information ready, when customers reach out to contact center, support agents can help reduce the hold time that they spend retrieving customer information, reduce average handling time (AHT), and increase customer satisfaction through faster resolution of the issue.

## What is Customer summary?

**Customer summary** is a page where you can get complete information about a customer when you accept an incoming request from any engagement channel. The default view of the **Customer summary** page provides the following sections:

   - Customer

   - Conversation summary

   - Case

   - Recent cases

   - Timeline

> [!div class=mx-imgBorder]
> ![omnichannel Customer summary page](../../media/oc-usd-customer360-page.png "Omnichannel Customer summary page")

## Customer

The **Customer profile** section provides details about the customer, such as the name of the customer or account, job, title, relationship type, city, category, relationship type, primary contact for the account, and preferred channel for engagement.

> [!div class='mx-imgBorder']
> ![Customer profile section in the customer summary form](../../media/customer-summary-customer-form.PNG "Customer profile section in the customer summary form")

## Conversation summary

The conversation summary section displays tabs with the details that help you understand the information about the conversation with customer. It displays the following tabs:

- Pre-chat
- Journey
- Visitor details
- Additional details (Only if configured and additional context variables available)
 
### Pre-chat

The **Pre-chat survey** tab displays the survey answers against the questions that are requested by your organization, which helps your interaction with the customer.

### Preview: Journey

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

The **Journey** tab displays information on the path (recent operations) the customer took just before initiating a conversation. The information enables the agents to understand why a customer reached out and also to provide a personalized service with fast resolution and improved customer satisfaction. The **Journey** tab displays the information in the reverse chronological order, and is categorized into the following type of actions:

| Action type | Description |
|-------------|-----------------------------------|
| Page visited | The pages visited on the portal (website) along with the timestamp.|
| Phrase searched | The keywords or phrases searched for, along with the timestamp. |
| Knowledge article viewed | The knowledge articles viewed along with the timestamp. |
| Custom action performed | Any other custom actions that are tracked by your organization as per your business requirements are displayed along with the timestamp. |

   > [!div class='mx-imgBorder']
   > ![Journey tab](../../media/customer-summary-journey-tab.png "Journey tab")

> [!div class='mx-imgBorder']
> ![Conversation summary section in the customer summary form](../../media/customer-summary-conversation-summary.PNG "Conversation summary section in the customer summary form")

### Visitor details

The **Visitor details** tab provides some information such as whether the customer is authenticated or not, browser used by the customer for contacting support, operating system used by the customer, location of the customer, interacting language of the customer, and so on.

> [!div class='mx-imgBorder']
> ![Conversation summary section in the customer summary form](../../media/customer-summary-conversation-summary.png "Conversation summary section in the customer summary form")

If the customer signs in to the portal to initiate a chat with the support, then as an agent, you can see the **Authenticated** field value as **Yes** in the **Visitor details** tab of the **Conversation summary** section. Otherwise, the **Authenticated** field value is shown as **No**.

![Authenticated chat shows as Yes in the Visitor details tab of Conversation summary](../../media/conversation-summary-authenticated-chat.PNG "Authenticated chat shows as Yes in the Visitor details tab of Conversation summary") ![Unauthenticated chat shows as No in the Visitor details tab of Conversation summary](../../media/conversation-summary-unauthenticated-chat.PNG "Unauthenticated chat shows as Yes in the Visitor details tab of Conversation summary")

To learn more, see [Create chat authentication settings](../../administrator/create-chat-auth-settings.md).

## Case

For an incoming conversation request, the system links an existing case to the conversation and shows it in the **Issue snapshot** section. This section shows  information such as the title of the case, its priority, its status, the product, and the owner.

> [!div class='mx-imgBorder']
> ![Issue snapshot section in the customer summary form](../../media/customer-summary-issue-snapshot.PNG "Issue snapshot section in the customer summary form")

## Recent cases

This section displays the recent cases that relate to the customer.

> [!div class='mx-imgBorder']
> ![Recent cases section in the customer summary form](../../media/customer-summary-recent-cases.PNG "Recent cases section in the customer summary form")

#### Timeline

This section displays the case- and customer-related activities in the form of a timeline. You can create quick notes based on the discussion with the customer. Also, you can filter the timeline to view it based on Customer activities, Case activities, and Conversation activities.

> [!div class='mx-imgBorder']
> ![Recent activities section in the customer summary form](../../media/customer-summary-recent-activities.PNG "Recent activities section in the customer summary form")

> [!div class="nextstepaction"]
> [Next topic: View communication panel](left-control-panel.md)

## See also

- [Introduction to the agent interface in Omnichannel for Customer Service](introduction-agent-interface.md)
- [View call scripts, take notes, and search knowledge articles](right-control-panel.md)
- [View customer summary for an incoming conversation request](view-customer-summary-incoming-conversation-request.md)
- [Create a record](create-record.md)
- [Search for records](search-record.md)
- [Link and unlink a record](link-unlink-record.md)
- [setContextProvider](../../developer/reference/methods/setContextProvider.md)
