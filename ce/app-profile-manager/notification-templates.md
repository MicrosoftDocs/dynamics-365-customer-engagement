---
title: "Manage notification templates in Omnichannel Administration app | MicrosoftDocs"
description: "Learn about managing notification templates in Omnichannel Administration app"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/12/2020
ms.service: dynamics-365-customerservice
ms.topic: article
---

# Manage notification settings and templates

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

When a notification is sent to an agent, it displays certain information, such as the customer from who the conversation request is coming, the timeout period after which the notification will disappear, and accept and reject buttons. Each organization has varied business requirements and wants the notifications to show relevant information to the agents.

As an administrator, system integrator, or partner, you can use the out-of-the-box templates for notifications or create your own. A notification template is a combination of notification-related, reusable information. The template is used to configure what information needs to be displayed to the agents and supervisors for an incoming conversation, escalation, transfer, or consult.

> [!Note]
> You must associate the notification templates to a session template.

## Desktop notifications

For optimal functioning of desktop notifications, make sure that you are using the latest supported browsers as specified in the [system requirements](../omnichannel/system-requirements-omnichannel.md).

> [!Note]
>
> The legacy version of Microsoft Edge is not supported for desktop notifications.

### Desktop notifications when the app is in the background

Agents can receive desktop notifications when the Omnichannel for Customer Service app is not in focus. These notifications help ensure that agents won't miss any conversation requests. Some scenarios where the app isn't in focus might include:

- The agent has minimized the app.
- The agent is working in another browser window.
- The agent is working on another tab of the browser.

 > [!div class=mx-imgBorder]
 > ![Desktop notification](../customer-service/media/desktop-notification.png "Desktop notification")

Agents can accept or reject the conversation request by selecting a button on the desktop notification. When an agent accepts the conversation, the Omnichannel for Customer Service app is made active and displayed to the agent, and a session is started.

If the agent selects the notification message body and not a button, the Omnichannel for Customer Service app is made active and the notification is displayed to the agent in the app. Then the agent can choose to accept or reject the conversation by selecting the appropriate button.

You can configure the wait time and the notification is displayed for the agent according to this time, but wait time isn't displayed on the notification. The desktop notification theme is based on the Windows operating system theme and settings.

> [!Note]
>
> - Desktop notifications will not work when the browser is opened in incognito mode or if focus assist is turned on in your Windows 10 operating system.
> - If the native browser notification option is disabled, the notification will be shown in a different user interface.

### Allow a browser to show notifications

To get desktop notifications, agents need to allow their browser (Microsoft Edge or Google Chrome) to show them. When an agent gets a browser notification, they need to select **Allow**. Based on your requirements, you can enable or disable notifications in the browser settings.

Also, as an administrator, you can set the browser notification permission by using group policy.

 > [!div class=mx-imgBorder]
 > ![Allow desktop notifications](../customer-service/media/allow-desktop-notification.png "Allow desktop notifications")

### Notification fields

The fields that are shown in the notification are based on the notification template configuration. To learn more, see [Slug for notification field header](#slugs-for-notification-field-header) and [Create a notification template](#create-a-notification-template).

## Slugs for notification field header

A slug is a replacement parameter that Omnichannel for Customer Service  populates at runtime based on the context variables.

The notification shows certain fields and values, called **Field header** and **Value** respectively.

For example, a customer Kenny Smith initiates a conversation. When the agent sees the notification, it displays **Customer Name** as **Kenny Smith**.

Here, **Field header** is **Customer Name** and the **Value** is **Kenny Smith**.

For the application to identify the name of the customer as **Kenny Smith**, as an administrator, you must configure slugs as the value. The Omnichannel system replaces the slug with the actual value that is extracted based on the context variables.

The application supports the following slugs.

| Slug | Description |
|------------|-----------------------------------|
| `{customerName}` | Name of the customer who initiates the conversation. |
| `{caseId}` | GUID of a case. The case ID is displayed only if a case is linked to the conversation. |
| `{caseTitle}` | Title of the case. The title of the case is displayed only if a case linked to the conversation. |
| `{queueId}` | GUID of a queue. |
| `{visitorLanguage}` | The language in which the customer initiates the conversation. |
| `{visitorDevice}` | The device of the customer who initiates the conversation. |
| `{entityRoutingLogicalName}` | Name of the entity if the notification is for entity records. |
| `{entityRoutingRecordId}` | GUID of the entity record if the notification is for entity records. To learn more, see [Entity records routing](../customer-service/entity-channel.md). |
| `{customerEntityName}` | Name of the entity (contact or account entity) if the customer is authenticated. |
| `{customerRecordId}` | GUID of the entity (contact or account entity) if the customer is authenticated. |
|`{<name of the pre-chat survey question>}` | All the pre-chat survey questions that are configured for a work stream can be used as the slug. The format is same as the question. |

## Manage templates

### Out-of-the-box notification templates

 For the supported channels, Omnichannel for Customer Service provides you with out-of-the-box notification templates that you can use in your environment. When you attach the out-of-the-box notification template, the default settings are used in the notifications. For customers whose record exists in Dynamics 365, the settings in the authenticated template for notifications are used. If the customer details are not available in Dynamics 365, the settings in the unauthenticated template are used for displaying the notifications. For information on what the notifications display for agents, see [notifications for agents](../customer-service/oc-notifications.md).

The out-of-the-box templates are as follows.

| Channel/Entity | Consult | Authenticated | Unauthenticated | Transfer | Other
|---------|--------------------|-----------------------|------------------------|--------------------|--------------------|
| Chat | Chat - consult - default | Chat - incoming authenticated - default | Chat - incoming unauthenticated - default | Chat - transfer - default |
| Custom messaging | Custom messaging - consult - default | Custom messaging - incoming authenticated - default | Custom messaging - incoming unauthenticated - default | Custom messaging - transfer - default |
| Facebook | Facebook - consult - default | Facebook - incoming authenticated - default | Facebook - incoming unauthenticated - default | Facebook - transfer - default |
| LINE | LINE - consult - default | LINE - incoming authenticated - default | LINE - incoming unauthenticated - default | LINE - transfer - default |
| SMS | SMS - consult - default | SMS - incoming authenticated - default | SMS - incoming unauthenticated - default | SMS - transfer - default |
| Microsoft Teams | Teams - consult - default | Teams - incoming authenticated - default | Teams - incoming unauthenticated - default | Teams - transfer - default |
| Twitter | Twitter - consult - default | Twitter - incoming authenticated - default | Twitter - incoming unauthenticated - default | Twitter -  transfer - default |
| WeChat | WeChat - consult - default | WeChat - incoming authenticated - default | WeChat -  incoming unauthenticated - default | WeChat - transfer - default |
| CDS entity |||||Entity record - assign - default |
| Customized ||||| Customized notification template |
| Sentiment ||||| Sentiment threshold alert - supervisor |
|||||||

  > [!Note]
  > You can't customize the out-of-the-box notification templates; instead, you'll need to create your own custom templates.

### Create a notification template

Perform the following steps to create a notification template:

1. Sign in to the Omnichannel Administration app.

2. Select **Notifications** under **Agent Experience** in the sitemap.

3. Select **New** in the **Active Notifications** page.

4. Specify the following in the **New Notification** page.

    | Tab | Name | Value, description | Example |
    |---------|--------------------|-----------------------------------------------|--------------------|
    | General | Name | Specify the name for the notification. This name wouldn't be visible for the agents at the run-time. | Authenticated chat notification |
    | General | Title | Provide a title to the notification that you want the agents to see at the run-time. | Incoming chat  conversation |
    | General | Icon | Select web resource path to add an icon. | /webresources/msdyn_chat_icon_zfp.svg <br><br> **Note:** <br>- This is the default value. You can change the icon as your requirement. <br> - If you enable the **Show desktop notifications** option, and if you use svg icon format, then the svg icon won't be shown in the desktop notifications.  |
    | General |Show timeout| Yes |Set **Yes** to show the timer in the notification, or **No** to hide the timer in the notification for the agents. <br><br> **Note:** <br> - Irrespective of whether you set **Yes** or **No** to show or to hide the timeout value for the agent, the timer runs, and after the timeout duration, the notification disappears. <br> - **Yes** is the default value for the templates when you get the latest release of Omnichannel for Customer Service. <br> - When you upgrade from previous to the latest release of Omnichannel for Customer Service, then existing notification templates will show no value for this field in the user interface. However, the notification templates consider the values as **Yes**, and display the timer to the users at the runtime.<br> - If you enable the **Show desktop notifications** option, then the timer won't be shown in the desktop notifications. |
   | General | Timeout (seconds) | Provide a duration in seconds; after this duration, the notification disappears. | 120. <br><br> **Note:** This is the default value. You can change the duration as per your requirement.
   | General|Auto-assign work items| Set to **Yes** to automatically assign the incoming conversation.| The default value is **No**. <br> **Note:** This setting is in preview. <br> More information: [Enable automatic acceptance of conversations](../customer-service/enable-auto-assign-conversations.md).|
   | General | Accept Button | Specify a text for the accept button. This text appears for the agents to accept a conversation request. | The default value is **Accept** that changes to **Open** when the **Auto-assign work items** value is **Yes**. You can change the text as per your requirement. |
   | General | Reject Button | Set the toggle to yes if you want to show the reject button to agents. <br> After you set the toggle to **Yes**, the default label for the button appears. | Reject <br><br> **Note:** This is the default value. You can change the text as per your requirement. The **Reject Button** is disabled when the **Auto-assign work items** value is **Yes**. |
   | General | Show desktop notifications | Specify whether you want to show notifications to the agents when the Omnichannel for Customer Service app not in focus. | When app is in background <br><br> **Note:** <br> The default value is Never. <br> To learn more, see [Desktop notification when app is in background](#desktop-notifications-when-the-app-is-in-the-background) and [Receive notifications when app is in background](../customer-service/oc-notifications.md#receive-notifications-when-the-app-is-in-the-background). |

    > [!div class=mx-imgBorder] 
    > ![Create notification template](../customer-service/media/notification-template1.png "Create notification template")

5. Select **Save**. The template is saved, and the **Notification Fields** section appears on the page.

6. Select **Add Existing Notification Field** in the **Notification Fields** section. The **Lookup Records** pane appears.

7. Select the search icon in the **Look for Records** box. If no records are available, you will see a message: **No records found. Create a new record.**.

8. Select **New** to create a notification field. A confirm dialog box appears, asking whether you want to leave the page. Select **OK**.

9. Specify the following in the **New Notification Field** page.

    | Tab | Name | Value, description | Example |
    |---------|--------------------|-----------------------------------------------|--------------------|    
    | General | Name | Specify the name for the notification. This name won't be visible to the agents at the runtime. | Name of the customer |
    | General | Field header | Provide a name to the field header. This appears in the notification that agents see at the runtime. | Name |
    | General | Value | Provide a slug value that appears against **Field header** in the notification. <br><br> To learn more, see [Slug for notification field header](#slugs-for-notification-field-header). |{customerName} |

    > [!div class=mx-imgBorder]
    > ![Create notification field](../customer-service/media/notification-field.png "Create notification field")

10. Select the back arrow on the browser to go to the notification template you created. Alternatively, you can select **Notifications** in the sitemap, and then select the template you created.

11. Select **Add Existing Notification Field** in the **Notification Fields** section. The **Lookup Records** pane appears.

12. Select the name of the notification field you created, and then select **Add**. For example, **Name of the customer**.

13. Repeat steps 6 through 12 to add more notification fields.

14. Select **Save**.

After saving the notification, sign in to the Omnichannel for Customer Service app and you can view the notification as per your configuration.

To learn more, see [View notification](../customer-service/oc-notifications.md).

### Edit a notification field

As an administrator, you can edit the value of a notification field header in the grid.

1. Sign in to the Omnichannel Administration app.

2. Select **Notifications** under **Agent Experience** in the sitemap.

3. Select the notification you want to edit on the **Active Notifications** page.

4. Select a notification field you want to edit and then select the record to edit it.

5. Select the save icon in the grid.

### Customize a notification

Let's see a scenario: In the Contoso Pvt Ltd customer service center, every case notification that is shown to an agent needs to have the following:

**Title of the notification**: A new case is assigned.

**Notification fields**:

- **Case priority:** Priority of the case such high or low.
- **Case title:** Title of the case.
- **Device:** Device from which the case was created by the customer.
- **Language:** Language of the customer.

As an administrator, you need to customize the notification template to show the title and notification fields.

#### Step 1: Create a notification template with the following values

| Tab | Name | Value |
|---------|--------------------|-----------------------------------------------|
| General | Name | Customized case notification template |
| General | Title | A new case is assigned |
| General | Icon |The default value is **/webresources/msdyn_chat_icon_zfp.svg**. |
| General |Show timeout| No |
| General | Timeout (seconds) | The default value is **120**. |
|General| Auto-assign work items | The default setting is **No**. |
| General | Accept Button | The default value is **Accept**.|
| General | Reject Button | The default value is **No**. When you set the toggle to **Yes**, the **Reject** label appears.|
| General | Show desktop notifications | The default setting is **Never**. Set to **When app is in background**. |

#### Step 2: Create the notification fields with the following values

| Name | Field header | Value |
|---------|--------------------|-----------------------------------------------|--------------------|    
| Case priority | Case priority | `{$odata.incident.prioritycode.?$filter=incidentid eq '{caseId}'&$select=prioritycode}` |
| Case title | Case title | `{$odata.incident.title.?$filter=incidentid eq '{caseId}'&$select=title}` |
| Device | Device | `{visitorDevice}` |
| Language | Language | `{visitorLanguage}` |

> [!div class=mx-imgBorder] 
> ![Customize notification template](../customer-service/media/customize-notification-template.png "Customize notification template")

#### Step 3: Save the changes

### See also

[Manage session templates](session-templates.md)  
[Manage application tab templates](application-tab-templates.md)  
[Associate templates with work streams](associate-templates.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]