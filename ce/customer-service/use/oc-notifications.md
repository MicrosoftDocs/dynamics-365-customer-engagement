---
title: View notifications in Customer Service
description: Learn about notifications and their types. Agents will see notifications and screen pops in Customer Service apps.
ms.date: 03/15/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:10/16/2023
---

# View notifications

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

> [!Note]
> Case information is applicable to Customer Service only.

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

A notification is a visual alert that appears each time you get a chat or an SMS conversation request from a customer. When you get the notification, you see the details about the customer with whom you're going to interact. When you accept the request, a session is started, and you can view the contextual information of the customer and case on the **Active Conversation** page.

Here are some scenarios where you might receive notifications:

- Case assignment if record routing is configured using workstreams for unified routing
- Incoming chat conversation
- Incoming SMS conversation
- Conversation (work item) assignment
- Conversation transfer
- Conversation escalation
- Conversation escalation from a bot

## Receive notifications when the app is in the background

Agents can receive notification alerts on their desktop always or only when the Customer Service workspace or Contact Center workspace isn't in focus. These notifications help ensure that agents won't miss any conversation requests. Some scenarios where the app isn't in focus might include:

- The agent has minimized the app.
- The agent is working in another browser window.
- The agent is working on another tab of the browser.
- The agent is using two screens, and is on the screen that doesn't have either the Customer Service workspace or Contact Center workspace app.

> [!Note]
> - The **Always** option for **Show Desktop Notifications** is in preview. To use this feature, it must be turned on and the license terms must be accepted. [What are Preview features and how do I enable them?](/power-platform/admin/what-are-preview-features-how-do-i-enable-them).
> - Desktop notifications aren't supported in the embedded experience.
 
 > [!div class=mx-imgBorder]
 > ![Desktop notification.](../media/desktop-notification.png "Desktop notification")

You can accept or reject the conversation request by selecting a button on the desktop notification. When you accept the conversation request, the app is made active and displayed to you, and a session is started.

If you select the notification message body and not a button, the app is made active, and the notification is displayed to you in the app. Then you can choose to accept or reject the conversation by selecting the appropriate button.

The wait time that's configured by your administrator applies to the desktop notification but doesn't display on it.

That is, your administrator has configured the wait time as 90 seconds and set the **Show Timeout** field to **No**. Now, when you get a notification, the wait time won't be displayed on the notification. However, you have 90 seconds to take action. Learn more at [Manage notification templates and settings](../administer/notification-templates.md).

> [!NOTE]
> The desktop notification theme is based on the Windows operating system theme and settings.

### Allow your browser to show notifications

To get desktop notifications, you need to allow your browser to show notifications. When you get a browser notification, select **Allow**.

> [!Note]
> Desktop notifications aren't supported in the embedded experience.

 > [!div class=mx-imgBorder]
 > ![Allow desktop notification.](../media/allow-desktop-notification.png "Allow desktop notification")

## Types of notifications

There are two types of notifications:

- **Toast notifications:** Also known as a floating notification, is a notification message type where you receive information in a dialog that disappears after a stipulated time. This type of notification appears for conversation (work item) assignments, conversation escalations, and conversation transfer scenarios.

- **Alert notifications:** A type of notification where a dialog appears with action buttons. When you select **Accept**, a screen pops up with the active conversation details. You need to take an action within the stipulated time, and the notification disappears when the time is up.

Based on your organization's configurations, you can't reject conversations. The application performs one of the following actions when an incoming notification appears:

- Creates a work item and assigns it to you automatically. 
- Automatically accepts the conversation and opens a new session.

## Incoming voice call notifications

You'll receive a voice call notification for an incoming call request after an intelligent bot processes the call. Learn more about how the call is processed and the call controls that are available to you at [Use agent dashboard and call controls in the voice channel](/dynamics365/contact-center/use/voice-channel-agent-experience).

## Incoming chat notifications

You receive a notification for an incoming chat request. When you accept the chat request, you'll see details about the customer in the **Active Conversation** page. A simultaneous session starts, and a chat window expands so you can exchange messages with the customer.

 > [!div class=mx-imgBorder]
 > ![Incoming chat notification.](../media/chat-notification-request.png "Incoming chat notification")  

The details you'll see for a chat channel are as configured by your administrator.

## Case assignment notification

> [!Note]
> Case information is applicable to Customer Service only.

If record routing is configured using unified routing and notifications are enabled, then when a case is assigned to you, you'll receive a notification with the open item option. You can't reject the assignment, and irrespective of the notification timeout, the case will be assigned to you.

  > ![Case assignment notification.](../media/case-assignment-notification.png "Case assignment notification")

## Incoming SMS notification

When you receive a notification for an SMS conversation request and you accept the SMS request, a session starts, and the communication panel appears in which you can exchange messages with the customer.

The customer is identified based on the **Mobile Phone** field information stored in the Contact record in Dynamics 365 Customer Service. That is, if the incoming SMS conversation is from a phone number stored in the mobile phone field of a Contact record, the conversation is automatically linked to the record.

 > [!div class=mx-imgBorder]
 > ![Incoming SMS notification.](../media/sms-notification-request.png "Incoming SMS notification")

The details you see for an SMS channel are as configured by your administrator.

## Missed notifications

> [!IMPORTANT]
>
> - The alert is displayed only when the missed notifications feature is enabled by your administrator.
> - Missed notification alerts are not supported in Omnichannel for Customer Service on Unified Service Desk.

When you don't respond to an incoming conversation notification, you'll see an alert at the top of your dashboard and your presence status will be set to inactive. You can respond to the alert or change your status. Your presence will be reset to the status that was last defined by the system. You won't be assigned new tasks until your presence is reset to a state in which you can be assigned tasks, which is based on the allowed presence set in the workstream. Your supervisor can also reset your presence.

 > [!div class=mx-imgBorder]
 > ![Missed notification alert.](../media/agent-missed-notification.png "Missed notification alert")

## Notification time-out and rerouting of conversations

When you don't respond to an incoming conversation notification, the notification gets timed out based on the time-out setting configured by your administrator in the [notification template](../administer/notification-templates.md#step-1-create-a-notification-template-with-the-following-values) and is rerouted.

Sometimes, you might see that conversations have been assigned to you without notifications showing up. This can happen when the notifications are sent by the system but they aren't seen because you closed the browser, navigated away from the app page, or lost network connectivity before the notifications could be displayed. In such a case, while the system might take a few seconds to mark you as unavailable, it assigns the conversations to you. The conversation is rerouted eight minutes after the timeout has expired.

## Maximum session limit notifications

> [!Note]
> Maximum session limit reached notification isn't supported in the embedded experience.

When you already have 10 sessions open, which is the maximum multi-session limit, and a new work item comes in, you'll see an alert at the top of your dashboard and your presence status will be automatically set to **Do not disturb**. You won't be assigned new tasks until your presence is reset to a state in which you can be assigned tasks, which is based on the allowed presence set in the workstream. Your supervisor can also reset your presence.

:::image type="content" source="../media/maximum-session-limit-notification.png" alt-text="Maximum session limit reached notification":::

## Agent reject notifications

> [!IMPORTANT]
>
> - This alert is displayed only when the agent reject feature is enabled by your administrator.
> - Agent reject notification alerts aren't supported in Omnichannel for Customer Service on Unified Service Desk.

When you reject a work item notification, you'll see an alert at the top of your dashboard and your presence status will be set to **Do not disturb**. You can respond to the alert or change your status. Your presence will be reset to the status that was last defined by the system. You won't be assigned new tasks until your presence is reset to a state in which you can be assigned tasks, which is based on the allowed presence set in the workstream. Your supervisor can also reset your presence.

:::image type="content" source="../media/agent-reject-notification-message.png" alt-text="Agent reject notification":::

### Related information

[View customer information on Active Conversation form](oc-customer-summary.md)  
[View communication panel](oc-conversation-control.md)  
[Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md)  
[Manage presence status](oc-manage-presence-status.md)  
[Search for and share knowledge articles](../oc-search-knowledge-articles.md)  
[Take notes specific to conversation](oc-take-notes.md)  
[View active conversations for an incoming conversation request](oc-view-customer-summary-incoming-conversation-request.md)  
[Manage notification templates and settings](../administer/notification-templates.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
