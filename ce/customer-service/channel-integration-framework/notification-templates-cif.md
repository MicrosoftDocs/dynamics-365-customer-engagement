---
title: "Manage notification templates in the Channel Integration Framework app | MicrosoftDocs"
description: "Learn about managing notification templates in the Channel Integration Framework app"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/15/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 64B58892-6A6D-43C2-95E5-B75D847F6E56
ms.custom: 
---

# Preview: Manage notification templates

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview

When agents get a notification, the notification displays certain information like from which customer the conversation request is coming, timeout period after which the notification disappears, some buttons like accept and reject. Each organization has varied business requirements and want to show relevant information to the agents in the notification.

The notification templates are introduced to show relevant information to agents. A notification template in the Channel Integration Framework app is a combination of notification related information that is reusable. The template is used to configure what information is displayed to the agents and supervisors for an incoming conversation, escalation, transfer, consult, and so on.

As an administrator, system integrator, or partner, you can use the templates or create new ones to show information that matter most to your business.

You must associate the notification templates to a session template.

## Create a notification template

1.	Sign in to the Channel Integration Framework app.

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
    | General | Value | Provide a slug value that appears against **Field header** in the notification. <br><br> To learn more, see [Supported formats to pass parameters values](parameter-values-cif.md). |`{customerName}` | 

10.	Select the back arrow on the browser to go the notification template you created. Alternatively, you select **Notifications** in the sitemap and then select the template you created.

11.	Select **Add Existing Notification Field** in the **Notification Fields** section. The **Lookup Records** pane appears.

12.	Select the name of the notification field you created, and then select **Add**. For example, **Name of the customer**.

13.	Repeat steps 6 through 12 to add more notification fields.

14.	Select **Save** to save the notification template changes.

## Edit a notification field

As an administrator, you can edit the value of notification field header in the grid.

1.	Sign in to the Channel Integration Framework app.

2.	Select **Notifications** under **Templates** in the sitemap.

3.	Select the notification you want to edit in the **Active Notifications** page.

4.	Select a notification field you want to edit. Select the record to edit it.

5.	Select the save icon to save the changes.


## See also

- [Manage session templates](session-templates-cif.md)
- [Manage application tab templates](application-tab-templates-cif.md)
- [Pass parameters values](parameter-values-cif.md)
- [Associate templates with workstreams](associate-templates-cif.md)
