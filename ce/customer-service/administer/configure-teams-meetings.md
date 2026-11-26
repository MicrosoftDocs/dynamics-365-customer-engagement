---
title: Enable Microsoft Teams meetings in Customer Service
description: Learn how to enable Microsoft Teams meeting integration in Dynamics 365 Customer Service and Dynamics 365 Copilot Service workspace.
ms.date: 09/29/2026
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.collection: bap-template
---

# Enable Microsoft Teams meeting integration in Customer Service (preview)

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../../includes/cc-preview-features-no-ms-support.md)]

The Microsoft Teams meeting integration feature allows your Dynamics 365 customer service representatives (service representatives or representatives) to quickly access and update records in Microsoft Teams before, during, and after a meeting with their customers.

By enabling this feature, you can help give representatives and supervisors in your organization a cohesive, seamless experience between Dynamics 365 and Teams. Representatives can use the meetings functionality to more efficiently meet their customers' needs.

## Prerequisites

To enable Teams integration in Customer Service, the following prerequisites must be met.

* You must have a Dynamics 365 Customer Service license for your organization.
* As an administrator, you must configure the ability for representatives in your organization to add and join Teams meetings in the Power Platform admin center. Learn more in [Manage feature settings - Power Platform](/power-platform/admin/settings-features).
* Optional: Configure the ability to sync calendars so that meetings created in Dynamics 365 apps appear on calendars in Microsoft Outlook and Teams. Learn more in [Set up server-side synchronization of email, appointments, contacts, and tasks - Power Platform](/power-platform/admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks).

## Enable Teams meeting integration

Complete the following steps to enable Teams meeting integration.

1. In the site map of Copilot Service admin center or Contact Center admin center, go to **Support experience** > **Collaboration**.
2. In **Meeting integration using Teams (preview)**, select **Manage**.
3. Toggle **Show Dynamics 365 data in Teams meetings (preview)** to **Yes**.
4. Select **Save**.

As mentioned in the prerequisites, the following settings are displayed on the page:

* **Sync calendars**: This optional setting ensures that meetings created in Dynamics 365 are added to Microsoft Outlook and Teams and appear on representative calendars. Learn more in [Set up server-side synchronization of email, appointments, contacts, and tasks - Power Platform](/power-platform/admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks).
* **Add and join meetings**: This required setting ensures that representatives can create and join Microsoft Teams meetings directly from Dynamics 365. Learn more in [Manage feature settings - Power Platform](/power-platform/admin/settings-features).

> [!NOTE]
> The **Record and get insights** setting is only available in Dynamics 365 Sales apps where customers have a premium license.

## Configure record side panel

The side panel helps representatives quickly view and update details of the related record during a Teams meeting. The side panel displays notes, tasks, and activities associated with the record. As an administrator, you can customize the side panel to meet the needs of your representatives. The record side panel supports only Contact, Opportunity, Lead, Account, and Case tables.

> [!NOTE]
>
> * Case is applicable to Customer Service only.
> * The record side panel can be customized by customizing the **In Context Form** of a table. The following table lists the supported and unsupported customizations for the side panel.

| Supported customizations    | Unsupported customizations   |
| --------------------------- | ---------------------------- |
| Define (add or remove) fields in the header.  | Enable, disable, or rearrange tabs. |
| Define (add or remove) fields in the **Key Details** section. | Add custom tabs or sections. |
| Change a field label. | Add sections other than **Key Details**, **Contacts**, **Notes**, **Tasks**, **Collaboration**, and **Recent Opportunities**. |
| Set a field requirement level, such as **Required** or **Optional**. | Add a web resource or subgrid. |
| Set a field to read-only. | Change the format or layout of headers, tabs, sections, or fields. |
|                           | Change certain properties for headers, tabs, sections, or fields. For example, the **available on phone** property can't be changed. |

**To customize the record side panel:**

1. Sign in to Power Apps.
2. Select the environment, and then select **Dataverse** > **Tables**.
3. In the upper-right corner, select the dropdown list, and then select **All**.
4. Search for the required table, and then select it to open it.
5. Go to the **Forms** tab and select the **In Context Form** form.
6. Edit the form to manage the fields that appear in the side panel. By default, all fields in the form are editable. To set a field as read-only, select the field, and then enable the **Read-only** property.

## Enable Teams meetings to be added to your Outlook calendar

To see appointments in Teams, enable mailbox record integration by following these steps.

1. In Dynamics 365, go to **Settings** > **Email Configuration** > **Mailboxes**.
2. Select the mailbox record, and then select **EDIT** on the ribbon.
3. For **Appointments, Contacts, and Tasks**, select **Server-Side Synchronization**.
4. Select the mailbox record, and then select **APPROVE EMAIL** on the ribbon.
5. Select the mailbox record again, and then select **TEST & ENABLE MAILBOX** on the ribbon.
6. Refresh the record until you see **Success** for the status. You can then create an appointment with a Teams meeting, and it will be added to the Teams calendar.

### Related information

[Use Microsoft Teams Meeting integration in Customer Service](../use/use-teams-meetings.md)
