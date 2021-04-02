---
title: "Manage notification templates in Dynamics 365 Channel Integration Framework version 2.0| MicrosoftDocs"
description: "Learn about managing notification templates in Dynamics 365 Channel Integration Framework version 2.0"
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/03/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Manage notification templates

## Overview

When agents get a notification, the notification displays certain information such as which customer the conversation request is coming from, the timeout period after which the notification disappears, and buttons such as Accept and Reject. Each organization has its own business requirements and wants to show agents relevant information in the notification.

The notification templates are introduced to show relevant information to agents. A notification template in Dynamics 365 Channel Integration Framework is a combination of notification-related information that is reusable. The template is used to configure what information is displayed to agents and supervisors for an incoming conversation, escalation, transfer, consult, and so on.

As an administrator, system integrator, or partner, you can use the templates or create new ones to show information that matters most to your business.

You must associate the notification templates with a session template.

### Desktop notifications when the app is in the background

Agents can receive desktop notifications when the model-driven app is not in focus. These notifications help ensure that agents won't miss any notification. Some scenarios where the app isn't in focus might include: 

- The agent has minimized the app.
- The agent is working in another browser window.
- The agent is working on another tab of the browser.

 > [!div class=mx-imgBorder]
 > ![Desktop notification](../media/desktop-notification.png "Desktop notification")

Agents can accept or reject the notification by selecting a button on the desktop notification. When the agent accepts the notification, the model-driven app is made active and displayed to the agent, and a session is started.

If an agent selects the notification message body and not a button, the model-driven app is made active and the notification is displayed to the agent in the app. Then the agent can choose to accept or reject the notification by selecting the appropriate button.

You can configure the wait time and the notification is displayed for the agent according to this time, but wait time isn't displayed on the notification. The desktop notification theme is based on the Windows operating system theme and settings.

> [!Note]
> If the native browser notification option is disabled, the notification will be shown in a different user interface.

#### Allow a browser to show notifications

To get desktop notifications, agents need to allow their browser (Microsoft Edge or Google Chrome) to show them. When an agent gets a browser notification, they need to select **Allow**.

Also, as an administrator, you can set the browser notification permission by using group policy.

 > [!div class=mx-imgBorder]
 > ![Allow desktop notifications](../media/allow-desktop-notification.png "Allow desktop notifications")

## Create a notification template

1.	Sign in to the Dynamics 365 Channel Integration Framework app.

2.	Select **Notifications** under **Templates** in the sitemap.

3.	Select **+ New** on the **Active Notifications** page.

4.	Specify the following on the **New Notification Template** page.

    | Tab | Name | Value description | Example |
    |---------|--------------------|-----------------------------------------------|--------------------|
    | General | Name | Specify the name for the notification. This name won't be visible to agents at runtime. | Authenticated chat notification |
    | General | Title | Provide a title to the notification that you want agents to see at runtime. | Incoming chat conversation |
    | General | Icon | Select a web resource path to add an icon. | /webresources/msdyn_chat_icon_zfp.svg <br><br> **Note:** This is the default value. You can change the icon as per your requirement. |
    | General |Show timeout| Yes |Set **Yes** to show the timer in the notification, or **No** to hide the timer in the notification for the agents. <br><br> **Note:** <br> - Irrespective of whether you set **Yes** or **No** to show or to hide the timeout value for the agent, the timer runs, and after the timeout duration, the notification disappears. <br> - **Yes** is the default value. |
    | General | Timeout (seconds) | Provide a duration in seconds; after this duration, the notification disappears. | 120 <br><br> **Note:** This is the default value. You can change the duration as per your requirement.|
    | General | Auto-assign work items | Set to **Yes** to automatically assign the incoming conversation. | The default value is **No**.</li><li>Use the auto-assign setting only if you have the related routing and assignment logic configured.</li></ul> |
    | General | Accept Button | Specify a text for the Accept button. This text appears for the agents to accept a conversation request. | Accept <br><br> **Note:** This is the default value. You can change the text as per your requirement. |
    | General | Reject Button | Set the toggle to **Yes** if you want to show the Reject button to agents. <br> After you set the toggle to Yes, the button text box appears. Specify a text for the Reject button. This text appears for the agents to reject a conversation request. | Reject <br><br> **Note:** This is the default value. You can change the text as per your requirement. |
    | General | Show desktop notifications | Specify whether you want to show notifications to the agents when the model-driven app not in focus. | When app is in background <br><br> **Note:** <br>- **Never** is the default value. <br> To learn more, see [Desktop notification when app is in background](#desktop-notifications-when-the-app-is-in-the-background). |

    ![Create a notification template](../media/create-notification-template.png "Create a notification template")

5.	Select **Save** to save the notification template. After you save, the **Notification Fields** section appears in the page.

6.	Select **Add Existing Notification Field** in the **Notification Fields** section. The **Lookup Records** pane appears.

7.	Select the **Search** icon in the **Look for Records** box. If there are no records, you see a message: **No records found. Create a new record.**

8.	Select **New** to create a new notification field. A confirm dialog box appears, asking whether you want to leave the page. Select **OK**.

9.	Specify the following in the **New Notification Field** page.

    | Tab | Name | Value description | Example |
    |---------|--------------------|-----------------------------------------------|--------------------|    
    | General | Name | Specify the name for the notification. This name won't be visible for agents at runtime. | Name of the customer |
    | General | Field header | Provide a name for the field header. This appears in the notification that agents to see at runtime. | Name |
    | General | Value | Provide a slug value that appears against **Field header** in the notification. <br><br> To learn more, see [Supported formats to use automation dictionary to pass data parameter keys](automation-dictionary-keys-cif.md). |`{customerName}` | 

10.	Select the back arrow on the browser to go to the notification template you created. Alternatively, you can select **Notifications** in the sitemap and then select the template you created.

11.	Select **Add Existing Notification Field** in the **Notification Fields** section. The **Lookup Records** pane appears.

12.	Select the name of the notification field you created, and then select **Add**. For example, **Name of the customer**.

13.	Repeat steps 6 through 12 to add more notification fields.

14.	Select **Save** to save the notification template changes.

## Edit a notification field

As an administrator, you can edit the value of a notification field header in the grid.

1.	Sign in to the Dynamics 365 Channel Integration Framework app.

2.	Select **Notifications** under **Templates** in the sitemap.

3.	Select the notification you want to edit on the **Active Notifications** page.

4.	Select a notification field you want to edit. Select the record to edit it.

5.	Select the **Save** icon to save the grid.

## See also

[Manage session templates](session-templates-cif.md)

[Manage application tab templates](application-tab-templates-cif.md)

[Use automation dictionary to pass data parameter keys](automation-dictionary-keys-cif.md)

[Associate templates with workstreams](associate-templates-cif.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]