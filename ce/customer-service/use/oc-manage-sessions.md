---
title: Manage sessions in the workspace app
description: Learn how to start and manage sessions using the session panel in Customer Service workspace.
ms.date: 12/13/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---

# Manage sessions in the workspace app

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

As a customer service representative (service representative or representative), you can switch between sessions without losing context of the conversation and customer details. You can handle multiple sessions simultaneously (while preserving customer context) and improve productivity.

When a session starts:

- The presence status is updated as per the configuration set by your administrator.
- The Communication panel is displayed so that you can interact and exchange messages with the customer.
- The **Active Conversation** page is loaded with the details of customer such as contact or account name, case, and conversation summary.

## Start a session

As a representative, you can start the sessions in two ways:

- Manually start a session
- Automatically start a session using the incoming notification
 
When you start a session from a notification request that is a chat or SMS channel, the presence status is updated as per the configuration set for you by your administrator. In addition, the communication panel is displayed so you can communicate with the customer.

### Manually start a session using the gestures

#### Contact and Case session

Use a combination of keyboard and mouse-click gesture to start a session. You can press **Shift** and select the work item to open a case or contact session. You can also select the **Open** option from the Omnichannel Agent Dashboard to start a case or contact session.

#### Channel session

You can start a session on a channel manually from the Omnichannel Agent Dashboard. Select **More options** (**...**) and select **Open** or **Pick** to start the session. The **Open** option is available for **My work items** and **Closed work items** streams. The **Pick** option is available in **Open work items** streams.

:::image type="content" source="../media/oc-open-work-item-my-work-items.png" alt-text="Screenshot of My work items.":::

### Automatically start a session using the incoming notification

When you select **Accept** on an incoming conversation request, a session starts, and the **Active Conversation** page opens.

 > [!div class=mx-imgBorder]
 > ![Session start.](../media/oceh-session-start.png "Session start")

## Work on multiple customer sessions

As a representative, when you are working on a case, you get an incoming conversation request, and you accept the request. This starts a new session, and the **Active Conversation** page is loaded with context of the session. You can access features, such as knowledge search, email templates, and any Line-of-Business applications made available in the application tab panel site map. You can open these applications using the gestures and the options in the communication panel. To learn more, see [Manually start a session using the gestures](#manually-start-a-session-using-the-gestures) and [View communication panel](oc-conversation-control.md).

When you switch sessions, unsaved changes are not lost and you can continue to work on them.

For example, you are working on a case by entering the title of the case and not yet saved the form. Now, you get a notification about the incoming conversation and you accept the request, which leads to starting of a new session. Again, you can switch back to case session and the data entered is present for you to continue.

## Persistent chat for service representatives

If your organization has chosen persistent chat as the mode of conversation, you should make sure of the following: 

- You shouldn't end the conversation; instead, you should close the conversation so that it is moved into a waiting state, which is typically 28 days or the value that is configured in the workstream.

- You must confirm with the customer that their issue is resolved, and then end the session by selecting **End**. After you end the chat, the chat history will not be shown when the customer comes back; a fresh chat session is initiated instead.

## Close a session

You can close any session manually by selecting the **X** button next to the session title. When you hover the cursor on a session, you'll see the **X** button, and if you select the button, a confirmation dialog is shown to you.

## Mode of the session panel

By default, the session panel is in expanded mode. Use the burger icon to toggle between expand or collapse mode.
At all times, the **Home** session is anchored and you can't close it. The Home session shows the default dashboard set for you by your administrator.

## Title of the session

By default, the title of the session is the name of the customer, account, or title of the case. For an unauthenticated conversation request, the title appears as visitor with a number. For example, **Visitor 1**.
    
For an authenticated chat, the contact name, account, or title of the case is displayed.

## Session sentiment alert and unread message count

- **Sentiment alert**

    When you are working on multiple customer sessions, there may be a scenario where a customer may not be happy. Since you are working simultaneously on multiple sessions, and if that session is not focused, you need a way to identify the sentiment of that session. 

    Session sentiment displays an alert to you when the sentiment reaches the threshold value as set by your administrator. For example, your administrator has set the threshold as **Slightly negative**. So, when the sentiment reaches **Slightly negative**, you can see an alert in the session panel on the session icon. An exclamation icon is displayed on top of the session icon to indicate that the requires your attention. When you hover the cursor on the session icon, you can see a tooltip, which displays a message in the following format: 
    
    **\<session title>. Urgent attention is needed in your conversation.**

    Example 1: **Visitor 7. Urgent attention is needed in your conversation.**

    Example 2: **Kenny Smith. Urgent attention is needed in your conversation.**


- **Unread message count**

    When you're working on multiple customer sessions, there may be a scenario where you may receive many messages across different sessions. Since you are working simultaneously on multiple sessions, and if that session is focused, you need a way to identify the number of messages you received for a particular session. 

    A count of unread messages is displayed on the session icon in the session panel. If the number of messages is 10 or more, then a plus icon (+) is displayed.

    When you hover the cursor on the session icon, you'll see a tooltip that displays a message in the following format: 
    
    **\<session title>. \<X> new updates in your conversation**
    
    **X** - count of unread messages

    Example 1: **Visitor 7. 5 new updates in your conversation.**

    Example 2: **Kenny Smith. 5 new updates in your conversation.**

    When you select a session with unread messages, the session is in focus and the unread message count disappears from the session icon.

### Related information

- [Manage applications](oc-manage-applications.md)
- [Understand conversation states](oc-conversation-state.md)
- [View communication panel](oc-conversation-control.md)
- [View agent dashboard and conversations (work items)](oc-agent-dashboard.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
