---
title: Set up notifications for the Field Service Portal (preview)
description: Configure notifications to keep your customers up to date on their bookings and appointments.
ms.date: 03/05/2023
ms.topic: how-to
author: m-hartmann
ms.author: mhart
search.app:
  - D365CE
  - D365FS
---

# Set up notifications for the Field Service Portal (preview)

> [!IMPORTANT]
> [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions. Preview features aren't meant for production use and are subject to a separate [supplemental terms of use](https://go.microsoft.com/fwlink/p/?LinkId=511446).

The portal uses Power Automate flows to trigger notifications for customers. Before we can send notifications, choose which channels to use and configure the flows accordingly. To send text messages, you'll need an SMS provider with a Power Automate connector. For emails, we recommend an Office 365 Outlook account.

> [!CAUTION]
> When enabled, the system sends notifications to contacts of the account associated with bookings. When using real customer data to test this feature, prevent accidental communication by [adding accounts to exclusion lists](create-configure-customer-portal.md#self-scheduling-preview-tab).

## Configure email and SMS connectors in Power Automate

The Customer Portal settings in Field Service links directly to the default Power Automate flows for email and SMS.

<!--TODO: can't repro these steps as I don't have flow quota in my trial env -->

1. Access the flows by going to the [Power Apps Maker portal](https://make.powerapps.com) > **Solutions** > **Dynamics 365 Field Service PowerApps Portal – Flow**.
1. Select **Objects** > **Cloud flows** to see the list of flows.
1. *Field Service PowerApps Power Flow Email Notifications* and *Field Service PowerApps Power Flow SMS Notifications* flows are off by default. Configure the flows before turning them on.
1. Select and open the flow you want to configure. On the flow, select **Save as** and create a copy of the default flow.
1. Open the flow you just created and select **Edit**. Authenticate or update the connections and **Save** the flow.
1. Then, select **Turn on** to enable the flow.

## Manually send an invite to a contact

Before customers can use the Field Service portal, make sure you [configured the portal settings](create-configure-customer-portal.md) and enabled notifications.

On a Field Service contact record, you can manually generate a portal invite code by selecting **Create Invitation**. Additionally, you need to assign the **Web Api Users** web role to the user before they can access the portal.

To set the required role:

1. On the the contact record, select **Related** > **Web Roles**.
1. Select **Add Existing Web Role** and choose the **Web API User** role.
1. Select **Add** and save the changes.

## List of notifications

After configuring your portal and enabling notifications, emails and SMS messages will be sent to the contact associated to the resulting work orders. You can [customize some aspects for the portal](create-configure-customer-portal.md#customize-the-portal-design), which also apply to the notifications.

The portal sends a notification for the following events:
<!--TODO: this seems wrong. the flow recurrence is set to 1 hour and I don't see a setting to change the time period (7 days)-->
- **Upcoming Booking**: Reminder messages are sent seven days before the scheduled service time. This message includes the scheduled service time and a link to the portal with information about the booking. By default, reminders are sent daily at 10:00 AM UTC for any bookings in the time period. You can change this time by editing the **Create notification items for bookings** flow.

- **Traveling**: Sent when the booking status changes to *Traveling*. This message communicates estimated time of arrival while considering traffic on the planned route. It links to the customer portal where your customer can see additional details.

- **Booking Completed**: Sent when booking status changes to *Complete*. This message confirms work was completed, along with date and time of completion.

- **Booking Rescheduled**: Sent if a booking reminder was sent and the scheduled start time changes by more than 10 minutes.

- **Booking Canceled**: Sent if a booking reminder was sent and a scheduled service appointment is canceled.

## View sent notifications

Notification settings provide a read-only view of all messages sent to customers. Find out which customers have received a message, the type of message, and the state of the message.

In Field Service, go to the **Settings** area. Under **Customer Portal**, select **Notifications** to view the list.

> [!div class="mx-imgBorder"]
> ![A list of active notifications in Field Service.](./media/07_FSSettings_notifications.jpg)

## Configure booking notification codes

With booking notification codes, Field Service admins can extend, expire, or block access to a portal link that has been shared with a customer.

In Field Service, go to the **Settings** area. Under **Customer Portal**, select **Booking Notification Codes** to create and manage codes.

<!-- TODO: I don't understand how that works and can't repro notifications. I would need to create a share code first, then map this to a booking notification code. Why do this manually? Please provide details for this section. -->

> [!div class="mx-imgBorder"]
> ![Screenshot of the list of active notifications, along with their codes.](./media/08_FSSettings_BookingNotifications.jpg)

> [!div class="mx-imgBorder"]
> ![Screenshot of notification details in Field Service.](./media/09_FSSettings_BookingNotifications-details.jpg)

## Advanced user notifications

<!-- TODO: do we need to keep that info? please review and update steps if so.-->
1. ### While testing, I deleted and and readded my contact to an account but I don't receive an new self-scheduling invite email. Why not? 

A contact with a matching email will only receive the portal invite once, even if the contact is deleted and readded to the system. You can work around this with the following steps:

1. Go to **Portal Management** app in the Power Apps admin center.
1. Open the newly created contact record.
1. On the command bar, select **Create Invitation**.
1. From the newly created invitation record, copy the *Invite code*.
1. Go to the **Web Roles** tab and select **Add existing web role**.
1. Select the *Web Api Users* web role.
1. Send the invite code and the portal link to desired email contact.
 
From the portal side: 

1. Open your self-scheduling portal and go to the signin screen. 
2. Select **Redeem invitation**.
3. Use the invite code to create a portal account.



### I tried to reset my password in the Field Service customer portal and never received an email. Why not?

<!--TODO: Is this still needed? Should work out of the box imho. please share steps/solution name to edit business process flow in Power Apps portal. Following this procedure in legacy advanced settings opens a power apps UI and I can't repro it-->

Make sure you have the correct process enabled for this functionality.

https://learn.microsoft.com/en-us/power-automate/create-business-process-flow

1. Go to **Field Service** > **Settings** > **Processes**.
2. Search for **Send Password Reset to Contact**.
3. Open the process to edit. Scroll down and select **View Properties**.
4. Edit the **From** field to a user&mdash;most likely the same account you use to send notifications for the scheduling experience&mdash; and then select **Save and Close**.
5. Go to **Settings** > **Email Configuration** > **Mailboxes**. 
6. Select the user you set in step 4, select **Approve Email**, and then select **Test & Enable Mailbox**.

> [!div class="mx-imgBorder"]
> ![Field Service process edit page, showing the "Send Password Reset to Contact" process.](./media/SS-Process-sendemail.PNG)
