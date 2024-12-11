---
title: Manage notification templates using representative experience profiles
description: Learn how to manage notification templates in Dynamics 365 Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# Manage notification templates in Dynamics 365 Channel Integration Framework 2.0


When customer service representatives (service representatives or representatives) get a notification, the notification displays certain information such as which customer the conversation request is coming from, the timeout period after which the notification disappears, and buttons such as Accept and Reject. Each organization has its own business requirements and wants to show representatives relevant information in the notification.

The notification templates are introduced to show relevant information to representatives. A notification template is a combination of notification-related information that is reusable. The template is used to configure what information is displayed to representatives and supervisors for an incoming conversation, escalation, transfer, consult, and so on.

As an administrator, system integrator, or partner, you can use the templates or create new ones to show information that matters most to your business.

You must associate the notification templates with a session template.

### Desktop notifications when the app is in the background

Representatives can receive desktop notifications when the model-driven app isn't in focus. These notifications help ensure that representatives don't miss any notification. Some scenarios where the app isn't in focus might include: 

- The representative minimized the app.
- The representative is working in another browser window.
- The representative is working on another tab of the browser.

 > [!div class=mx-imgBorder]
 > ![Desktop notification.](../../media/desktop-notification.png "Desktop notification")

Representatives can accept or reject the notification by selecting a button on the desktop notification. When the representative accepts the notification, the model-driven app is made active and displayed to the representative, and a session is started.

If a representative selects the notification message body and not a button, the model-driven app is made active and the notification is displayed to the representative in the app. Then the representative can choose to accept or reject the notification by selecting the appropriate button.

You can configure the wait time and the notification is displayed for the representative according to this time, but wait time isn't displayed on the notification. The desktop notification theme is based on the Windows operating system theme and settings.

> [!Note]
> If the native browser notification option is disabled, the notification will be shown in a different user interface.

#### Allow a browser to show notifications

To get desktop notifications, representatives need to allow their browser (Microsoft Edge or Google Chrome) to show them. When a representative gets a browser notification, they need to select **Allow**.

Also, as an administrator, you can set the browser notification permission by using group policy.

 > [!div class=mx-imgBorder]
 > ![Allow desktop notifications.](../../media/allow-desktop-notification.png "Allow desktop notifications")

## Create a notification template

To create or manage a notification template, go to **Workspaces** in **Agent Experience**. For more information, see [Manage templates](../../../customer-service/administer/notification-templates.md#manage-templates).

##Related information

[App experience profile overview](../../../customer-service/administer/overview.md)  
[Manage session templates](session-templates-cif.md)  
[Manage application tab templates](application-tab-templates-cif.md)  
[Use automation dictionary to pass data parameter keys](automation-dictionary-keys-cif.md)  
[Associate templates with workstreams](associate-templates-cif.md)  

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
