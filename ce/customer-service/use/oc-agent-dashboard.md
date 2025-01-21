---
title: Omnichannel Agent Dashboard in Dynamics 365 Contact Center
description: Learn about the Omnichannel Agent Dashboard that shows work items for agents who use the Customer Service workspace or Contact Center workspace.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection:
ms.date: 01/21/2025
ms.custom: bap-template
---

# View agent dashboard and agent conversations

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


When you sign in to the Customer Service workspace or Contact Center workspace app, the Omnichannel Agent Dashboard is the default view. You can set any dashboard as the default view by selecting the **Set As Default** option. The dashboard displays the following streams:

- My work items
- Open work items
- Closed work items

 ![Agent dashboard of Omnichannel for Customer Service app.](../media/oceh-oc-mydashboard.png "Screenshot of Agent dashboard in the Customer Service workspace app")

OCStreamcontrol, an out-of-the-box dataset control, displays conversations view for all the three streams. My work items, Open work items, and Closed work items are displayed in a card form format on the Omnichannel Agent dashboard. However, the OCStreamcontrol doesn't work on custom dashboards, and can be used with Omnichannel Agent dashboard only. 

## My work items

In the **My work items** section, you can see the conversations (work items) that you're actively working on. To open the work items in a session, select the ellipsis, and then select the **Open** option.

## Open work items

In the **Open work items** section, you can see the conversations (work items) that are in an open state from all queues in which you're added as member. Select the ellipsis, and then select the **Assign to me** option to assign the work item to yourself. A session starts for the pick action. When you select a work item, you get a notification, and when you accept it, a session starts and the **Active Conversation** or case page loads.

The work item that you pick is moved from the **Open work items** section to the **My work items** section. If you reject the request, then the work item remains in the **Open work items** section.

## Closed work items

In the **Closed work items** section, you can see all the conversations that you closed on the same day. To view a closed work item, select its ellipsis button (**...**), and then select **Open** to view the details.

When you open a record from the **Closed work items** section, you can view the attributes of the closed conversation record. This action won't reopen or reactivate the conversation.

## Sort work items

On the dashboard, you can sort work items by the following categories:

- Modified On
- Work distribution mode (for open work items only)
- Customer
- Work stream
- Created On
- Transfer Count

## View multiple conversations at the same time

You can have multiple conversations open on multiple browsers and view the conversations in a split screen. Viewing multiple conversations side by side improves your ability to serve customer requests without the need to switch between sessions.

For example, when you select an active work item or monitor a conversation, it opens on the same browser. All other browsers remain as-is.

When multiple browsers are open, you see incoming conversation request on all the browsers. However, the browser that you select **Accept** from is the browser that loads that conversation. All other browsers remain as-is, with incoming notifications dismissed. 


For example, for incoming calls, the conversation gets accepted only on one browser and the notification gets dismissed on other browsers. If you want to join the conversation in another browser, you must close the session in the current browser and open the conversation in the other browser.

> [!NOTE]
> - Ensure that you close the persistent chat sessions in all the windows where you have the same chat open. Otherwise, the other windows still allow you to send messages even after you select **End** to end the chat in one chat window.
> - When you accept a voice conversation, your capacity may be impacted in different tabs or windows. To join a voice conversation in a new browser, you must close the session in the current browser and open it in a new browser.


### Related information

[Create a record](oc-create-record.md)  
[Introduction to the agent interface](oc-introduction-agent-interface.md)  
[View communication panel](oc-conversation-control.md)  



[!INCLUDE[footer-include](../../includes/footer-banner.md)]
