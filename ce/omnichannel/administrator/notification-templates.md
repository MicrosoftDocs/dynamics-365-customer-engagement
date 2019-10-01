---
title: "Manage notification templates in Omnichannel Administrator app | MicrosoftDocs"
description: "Learn about managing notification templates Omnichannel Administrator app"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 08/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: E098ABE0-E5FD-4C65-BF3E-56ACC7F9E416
ms.custom: 
---

# Preview: Manage notification templates

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview

When agents get a notification, the notification displays certain information like from which customer the conversation request is coming, timeout period after which the notification disappears, some buttons like accept and reject. Each organization has varied business requirements and want to show relevant information to the agents in the notification.

The notification templates are introduced to show relevant information to agents. A notification template in Omnichannel for administrator app is a combination of notification related information that is reusable. The template is used to configure what information is displayed to the agents and supervisors for an incoming conversation, escalation, transfer, consult, and so on.

As an administrator, system integrator, or partner, you can use the templates or create new ones to show information that matter most to your business.

You must associate the notification templates to a session template.

## Slug for notification field header

Slug is the replacement parameter that Omnichannel system populates at the run time based on the context variables.

The notification shows certain fields and values, which are called **Field header** and **Value** respectively.

For example, Ian Madera, a customer, initiated a conversation and when the agent sees the notification, it displays **Customer Name** as **Ian Madera**.

Here, **Field header** is **Customer Name** and the **Value** is **Ian Madera**.

For Omnichannel system to identify the name of the customer as **Ian Madera**, as an administrator, you must configure slugs as the value. The Omnichannel system replaces the slug with the actual value that was extracted based on the context variables.

Omnichannel system supports the following slugs.

| Slug | Description |
|------------|-----------------------------------|
| customerName | Name of the customer who initiated the conversation. |
| caseId | Unique Id of a case. The system displays the case Id only if a cased linked to the conversation. |
| caseTitle | Title of the case. The system displays the title of the case only if a cased linked to the conversation. |
| queueId | Unique Id of a queue. |
| visitorLocale | The language of the customer who initiated the conversation. |
| visitorDevice | The device of the customer who initiated the conversation. |
| entityRoutingLogicalName | Name of the entity if the notification is for a entity records. |
| entityRoutingRecordId | Unique Id of the entity record if the notification is for a entity records. To learn more, see [Entity records routing](entity-channel.md). |
| customerEntityName | Name of the entity (contact or account entity) if the customer is authenticated. |
| customerRecordId | Unique Id of t.he entity (contact or account entity) if the customer is authenticated. |
|\<name of the pre-chat survey questions\> | All the pre-chat survey questions that are configured for a workstream will have the slug name as the name of the question. |

## Create a notification template

1.	Sign in to the Omnichannel Administrator app.

2.	Select **Notifications** under **Templates** in the sitemap.

3.	Select **+ New** in the **Active Notifications** page.

4.	Specify the following in the New Application Tabs page.

    | Tab | Name | Value description | Example |
    |---------|--------------------|-----------------------------------------------|--------------------|
    | General | Name | Specify the name for the notification. This name wouldn't be visible for the agents at the run-time. | Authenticated chat notification |
    | General | Title | Provide a title to the notification that you want the agents to see at the run-time. | Incoming chat conversation |
    | General | Icon | Select web resource path to add an icon. | /webresources/msdyn_chat_icon_zfp.svg <br><br> **Note:** This is the default value. You can change the icon as your requirement. |
    | General | Timeout (seconds) | Provide a duration in seconds; after this duration, the notification disappears. | 120. <br><br> **Note:** This is the default value. You can change the duration as per your requirement.
    | General | Accept Button | Specify a text for the accept button. This text appears for the agents to accept a conversation request. | Accept <br><br> **Note:** This is the default value. You can change the text as per your requirement. |
    | General | Reject Button | Set the toggle to yes if you want to show the reject button to agents. <br> After you set the toggle to Yes, the button text box appears. Specify a text for the accept button. This text appears for the agents to accept a conversation request. | Reject <br><br> **Note:** This is the default value. You can change the text as per your requirement. |

5.	Select **Save** to save the notification template. After you save, the **Notification Fields** section appears in the page.

6.	Select **Add Existing Notification Field** in the **Notification Fields** section. The **Lookup Records** pane appears.

7.	Select the search icon in the **Look for Records** box. If there are no records, you see a message – **No records found. Create a new record**.

8.	Select **+ New** to create a new notification field. A confirm dialog appears stating if you want to leave the page. Select **OK**.

9.	Specify the following in the **New Notification Field** page.

    | Tab | Name | Value description | Example |
    |---------|--------------------|-----------------------------------------------|--------------------|    
    | General | Name | Specify the name for the notification. This name wouldn't be visible for the agents at the run-time. | Name of the customer |
    | General | Field header | Provide a name to the field header. This appears in the notification that agents to see at the run-time. | Name |
    | General | Value | Provide a slug value that appears against **Field header** in the notification. <br><br> To learn more, see [Slug for notification field header](#slug-for-notification-field-header). |{customerName} | 
    | General | Priority | Provide a number to assign the priority, which is the order of appearance on the notification. If you give the priority as 4, the field appears as 4th from top. <br> A maximum of four Field headers are shown on a notification. | 1 |

10.	Select the back arrow on the browser to go the notification template you created. Alternatively, you select **Notifications** in the sitemap and then select the template you created.

11.	Select **Add Existing Notification Field** in the **Notification Fields** section. The **Lookup Records** pane appears.

12.	Select the name of the notification field you created, and then select **Add**. For example, **Name of the customer**.

13.	Repeat steps 6 through 12 to add more notification fields.

14.	Select **Save** to save the notification template changes.

## Edit a notification field

As an administrator, you can edit the value of notification field header in the grid.

1.	Sign in to the Omnichannel Administrator app.

2.	Select **Notifications** under **Templates** in the sitemap.

3.	Select the notification you want to edit in the **Active Notifications** page.

4.	Select a notification field you want to edit. Select the record to edit it.

5.	Select the save icon to save the changes.


## See also

- [Manage session templates](session-templates.md)
- [Manage application tab templates](application-tab-templates.md)
- [Associate templates with worksteams](associate-templates.md)
