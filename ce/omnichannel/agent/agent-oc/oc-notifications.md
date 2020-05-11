---
title: "Notifications for agents working in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about notifications and their types. Agents will see notifications and screen pops in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 05/11/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# View notifications

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

A notification is a visual alert that appears each time you get a chat or SMS conversation request from a customer. When you get a notification, you see the details about the customer with whom you're going to interact. When you accept the request, a session is started, and you can view the contextual information of the customer and case in the customer summary page.

Some of the scenarios where you might receive notifications:

- Incoming chat conversation

- Incoming SMS conversation

- Conversation (work item) assignment

- Conversation transfer

- Conversation escalation

- Conversation escalation from a bot

## Receive notifications when the app is in the background

You'll receive desktop notifications when the Omnichannel for Dynamics 365 Customer Service app isn't in focus. The desktop notification helps ensure that you won't miss any conversation requests. Some scenarios where the app isn't in focus might include: 

- You've minimized the app.
- You're working in another browser window.
- You're working on another tab of the browser.

 > [!div class=mx-imgBorder]
 > ![Desktop notification](../../media/oceh/desktop-notification.png "Desktop notification")

You can accept or reject the conversation request by selecting a button on the desktop notification. When you accept the conversation request, the Omnichannel for Customer Service app is made active and displayed to you, and a session is started.

If you select the notification message body and not a button, the Omnichannel for Customer Service app is made active and the notification is displayed to you in the app. Then you can choose to accept or reject the conversation by selecting the appropriate button.

The wait time that's configured by your administrator applies to the desktop notification, but doesn't display the wait time on the desktop notification. 

That is, your administrator has configured the wait time as 90 seconds and set the **Show Timeout** field to **No**. Now, when you get a notification, the wait time won't be displayed on the notification. However, you've 90 seconds to take action.

The desktop notification theme is based on the Windows operating system theme and settings.

### Allow your browser to show notifications

To get desktop notifications, you need to allow your browser (Microsoft Edge or Google Chrome) to show notifications. When you get a browser notification, you need to select **Allow**.

 > [!div class=mx-imgBorder]
 > ![Allow desktop notification](../../media/oceh/allow-desktop-notification.png "Allow desktop notification")

## Types of notifications

There are two types of notifications:

- **Toast notifications:** A toast notification or floating notification is a notification message type where you receive information in a dialog, which disappears after a stipulated time. This type notifications appear for conversation (work item) assignments, conversation escalations, and conversation transfer scenarios and so on. 

- **Alert notifications:** An alert notification is a type of notification where a dialog appears with actionable buttons. When you select the **Accept** button, a screen pops up with Customer summary details. You need to take an action within the stipulated time and the notification disappears when the time is up.

## Incoming chat notification

You receive a notification for an incoming chat request. When you accept the chat request, you'll see a details about the customer in the Customer summary page. A simultaneous session starts, and a chat window expands so you can exchange messages with the customer.

 > [!div class=mx-imgBorder]
 > ![Incoming chat notification](../../media/oceh/chat-notification-request.png "Incoming chat notification")  

The details you'll see for a chat channel are as configured by your administrator.

## Incoming SMS notification

You receive a notification for a SMS conversation request. When you accept the SMS request, a session is started, and the communication panel appears where you can exchange messages with the customer.

Identification of a customer happens based on the **Mobile Phone** field present in the Contact record in Dynamics 365 Customer Service. That is, if the incoming SMS conversation is from a phone whose number is present in the mobile phone field of a Contact record, the conversation automatically links to the contact record.

 > [!div class=mx-imgBorder]
 > ![Incoming SMS notification](../../media/oceh/sms-notification-request.png "Incoming SMS notification") 

The details you'll see for a SMS channel are as configured by your administrator.

### See also

[View customer summary and know everything about customers](oc-customer-summary.md)   
[View communication panel](oc-conversation-control.md)  
[Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md)  
[Manage presence status](oc-manage-presence-status.md)  
[Search for and share knowledge articles](oc-search-knowledge-articles.md)  
[Take notes specific to conversation](oc-take-notes.md)  
[View customer summary for an incoming conversation request](oc-view-customer-summary-incoming-conversation-request.md)  
