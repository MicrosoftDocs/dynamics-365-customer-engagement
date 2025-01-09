---
title: "Outlook category Tracked to Dynamics 365 for Customer Engagement (on-premises)"
description: "Learn how to track emails, appointments, and tasks with the Tracked to Dynamics 365 special Outlook category, and get answers to frequently asked questions."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 8.x
ms.assetid: e1c00214-52a0-48b1-824f-8c613772752f
caps.latest.revision: 36
author: Mattp123
ms.author: matp
search.audienceType: 
  - admin

---
# Use the Tracked to Dynamics 365 Outlook category to track emails, appointments, and tasks

Server-side synchronization allows tracking of emails, appointments and tasks in Outlook with a [special category](https://support.office.com/article/video-set-an-email-flag-reminder-or-color-a894348d-b308-4185-840f-aff63063d076?ui=en-US&rs=en-US&ad=US) **Tracked to Dynamics 365**. Assigning this category to an email, appointment or a task in Outlook syncs the item to Dynamics 365 Customer Engagement (on-premises). Similarly, removing the category from a tracked email, appointment or task untracks it from Customer Engagement (on-premises).

You can also select multiple items and assign the **Tracked to Dynamics 365** Outlook category to them thereby tracking all of them to Dynamics 365 for Customer Engagement. Quickly identify tracked items by observing the presence of this category in your Inbox and other folders.

## Configure category-based tracking through an OrgDBOrgSetting

As of Customer Engagement (on-premises) version 9.1.0.4039 or higher, category tracking is on by default.

> [!TIP]
> To determine your version, sign in to [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps, and in the upper-right side of the screen, select the **Settings** button ![User profile Settings button.](media/user-profile-settings-button.gif) > **About**.  

## Use category to track Outlook items
Once the **Tracked to Dynamics 365** category is available in Outlook, you can use it to track the following Outlook items.

## Email
Track an email by assigning it the **Tracked to Dynamics 365** category. The category assignment can be seen immediately in Outlook. At this time, the email is marked for tracking. server-side synchronization will sync the email to Customer Engagement (on-premises) within 15 minutes, based on the email synchronization setting.

If an email is tracked and is categorized as **Tracked to Dynamics**, removing the category will untrack the email. However, the corresponding Customer Engagement (on-premises) email activity record is not deleted.

> [!NOTE]
> You can set up a rule in Outlook to assign or remove a category. See [Manage email messages by using rules](https://support.office.com/article/manage-email-messages-by-using-rules-c24f5dea-9465-4df4-ad17-a50704d66c59?ui=en-US&rs=en-US&ad=US).

## Appointment
You can track an appointment by assigning it the **Tracked to Dynamics 365** category. The appointment will be tracked and synced to Customer Engagement (on-premises) based on server-side synchronization rules.

If an appointment is tracked and is categorized as **Tracked to Dynamics**, removing the category will untrack the appointment. However, the corresponding Customer Engagement (on-premises) appointment activity record is not deleted.

## Task
> [!NOTE]
> Assignment of tasks to people that is captured in Outlook will not be synced to Customer Engagement (on-premises).

## Use category-based tracking with App for Outlook
If you have Dynamics 365 App for Outlook, you can use category-based tracking with App for Outlook.

The following table lists different scenarios of tracking.


|Action  |Result  |
|---------|---------|
|Assign the **Tracked to Dynamics 365** category to an email/appointment     |Server-side synchronization will sync email/appointment within 15 minutes. Loading App for Outlook on that item will display the tracked status.         |
|Track an email/appointment using App for Outlook     |Email/Appointment is tracked. The **Tracked to Dynamics 365** category is assigned immediately.         |
|Removal of the **Tracked to Dynamics 365** category on an email/appointment     |Server-side synchronization will untrack the item in about 15 minutes. Loading App for Outlook on that email will display the tracked status. The activity record is not deleted from Customer Engagement (on-premises).         |
|Untrack an email/appointment using App for Outlook     |Email/Appointment is untracked and **Tracked to Dynamics 365** category is removed.         |

## Delegate users
If you [allow someone else to manage your email and calendar](https://support.office.com/article/Allow-someone-else-to-manage-your-mail-and-calendar-41C40C04-3BD1-4D22-963A-28EAFEC25926) by providing them delegate access, the delegate can access your categories in Outlook, if the delegate has Editor permissions.

If your mailbox has the **Tracked to Dynamics 365** category, the delegate can track your emails and appointments by assigning the **Tracked to Dynamics 365** category.

## Category-based tracking with Dynamics 365 for Outlook
Category-based tracking is not supported with Dynamics 365 for Outlook. We recommend that you do not enable OrgDBOrgSetting **TrackCategorizedItems** on a Customer Engagement (on-premises) organization set up to use Dynamics 365 for Outlook.

## Disable category-based tracking
You can disable category-based tracking for the Customer Engagement (on-premises) organization by disabling OrgDBOrgSetting **TrackCategorizedItems**.

> [!NOTE]
> If you disable OrgDBOrgSetting **TrackCategorizedItems**, the **Tracked to Dynamics 365** category is soft-deleted, with the category assignment retained in Outlook. If you delete the category from the master list, it will be deleted permanently.

## FAQ
**Can I track my Outlook contacts by assigning the Tracked to Dynamics 365 category?**<br />
No, category-based tracking is not supported for Outlook contacts.

**What happens if I rename the Tracked to Dynamics 365 category?**<br />
If you rename the category, server-side synchronization will continue to identify the category by its ID and it will be used to track and untrack Outlook items.

**What happens if I delete the Tracked to Dynamics 365 category?**<br />
If you delete the category, server-side synchronization will recreate it on the Exchange server in about 15 minutes.

**When I turn on OrgDBOrgSetting TrackCategorizedItems for the first time, will my previously tracked items be assigned the Tracked to Dynamics 365 apps category?**<br />
No, server-side synchronization will not go back in time to assign the category to already tracked items.

**If I assign the Tracked to Dynamics 365 category to an Outlook conversation thread, what happens?**<br />
If you categorize a conversation thread as **Tracked to Dynamics 365**, all the emails in that thread are assigned the category and hence will be tracked.

**Can I assign Tracked to Dynamics 365 category to recurring appointments?**<br />
If you categorize a recurring appointment as **Tracked to Dynamics 365**, all the individual instances of the appointment are assigned the category and will be tracked.

**What happens when a Track of email fails?**<br/>
By default, failed auto tracked emails will be retried in a new synchronization cycle – approximately every 15 minutes. Retries will be done up to 5 times. If the retries fail after 5 attempts, the email will be assigned the category **Tracked to Dynamics 365 (Undeliverable)** and no further retries will occur. Auto tracked emails which fail with the following errors will be retried:

- Promotion of emails fail due to a plugin configured in the customer environment
- Promotion of emails fail because of timeouts from either Customer Engagement or Microsoft Exchange
- An email is rejected with InvalidSender or because of some unknown decisions

After 5 retries, if the failure to promote the email was due to a plugin error, try fixing the plugin. Then, assign the **Track to Dynamics 365** category to manually track the undelivered emails to get them tracked in Customer Engagement. 

**How do I remove category-based tracking through OrgDBOrgSetting?** <br/>
To disable the special **Tracked to Dynamics 365** Outlook category, you need to enable the OrgDBOrgSetting in your Customer Engagement (on-premises) organization. Customer Engagement (on-premises) provides the OrgDBOrgSettings tool that gives administrators the ability to implement specific updates that were previously reserved for registry implementations.

1. Follow the instructions [in this article](https://support.microsoft.com/help/2691237/orgdborgsettings-tool-for-microsoft-dynamics-crm) for steps to extract the tool.
2. After extracting the tool, disable the OrgDBOrgSetting **TrackCategorizedItems**.
3. Disabling the OrgDBOrgSetting will remove the category **Tracked to Dynamics 365** on all Exchange mailboxes of the Customer Engagement (on-premises) organization which have server-side synchronization enabled in about 15 minutes.

You can also use [this tool](https://github.com/seanmcne/OrgDbOrgSettings/releases/) to edit the OrgDBOrgSetting **TrackCategorizedItems**.

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
