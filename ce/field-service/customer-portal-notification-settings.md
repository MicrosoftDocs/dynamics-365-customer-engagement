---
title: Set up notifications for the Field Service portal
description: Learn how to set up notifications to keep your customers current on their bookings and appointments.
ms.date: 10/16/2025
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
ms.reviewer: puneetsingh
search.app:
  - D365CE
  - D365FS
---

# Set up notifications for the Field Service portal

The portal uses Power Automate flows to trigger notifications. Before sending notifications, select the channels to use and configure the flows accordingly. To send text messages, set up an SMS provider with a Power Automate connector. For emails, use an Office 365 Outlook account.

> [!IMPORTANT]
> When enabled, the system sends notifications to contacts of the account associated with bookings. To prevent accidental communication when testing with real customer data, [add accounts to **Excluded Accounts**](create-configure-customer-portal.md#configure-the-customer-portal-settings).

## Configure email and SMS connectors in Power Automate

The Customer Portal settings in Field Service connect directly to the default Power Automate flows for email and SMS.

1. Sign in to [Power Apps](https://make.powerapps.com), and then select **Solutions** > your Dynamics 365 Field Service solution.
1. Select **Objects** > **Cloud flows** to see the list of flows.

To configure email:

1. Select the *Field Service PowerApps Portal Flow Email Notifications* flow, which is turned off by default.
1. On the flow, select **Save as**, and create a copy of the default flow.
1. Open the flow you created, and then select **Edit**. Authenticate or update the connections, and then **Save** the flow.
1. Select **Turn on** to enable the flow.

To configure SMS:

1. Select the *Field Service PowerApps Power Flow SMS Notifications* flow, which is turned off by default.
1. In the flow, select **Save as**, and create a copy of the default flow.
1. Open the flow you created, and then select **Edit**. Authenticate or update the connections, and then select **Save**.
1. Select **Turn on** to enable the flow.

## List of notifications

When you configure your portal and enable notifications, the system sends emails and SMS messages to the customer contact. You can [customize some aspects of the portal](create-configure-customer-portal.md#customize-the-portal-design), and these customizations also apply to the notifications.  

The portal sends a notification for the following events:

- **Upcoming Booking**: Reminder messages are sent seven days before the scheduled service time. The message includes the scheduled service time and a link to the portal with booking details. By default, reminders are sent daily at 10:00 AM UTC for bookings during that period. You can change this time by editing the **Create notification items for bookings** flow.

- **Traveling**: This message is sent when the booking status changes to *Traveling*. It provides the estimated time of arrival based on traffic on the planned route and links to the customer portal for more details.

- **Booking Completed**: This message is sent when the booking status changes to *Complete*. It confirms the work is completed and includes the date and time of completion.

- **Booking Rescheduled**: This message is sent if a booking reminder is sent and the scheduled start time changes by more than 10 minutes.

- **Booking Canceled**: This message is sent if a booking reminder is sent and a scheduled service appointment is canceled.

## View sent notifications

Notification settings provide a read-only view of all messages sent to customers. You see which customers received a message, the type of message sent, and its current status.

In Field Service, go to the **Settings** area. Under **Customer Portal**, select **Notifications** to view the list.

:::image type="content" source="./media/07_FSSettings_notifications.jpg" alt-text="Screenshot of a list of active notifications in Field Service.":::

## Configure booking notification codes

Field Service admins use booking notification codes to extend, expire, or block access to a portal link shared with a customer.

In Field Service, go to the **Settings** area. Under **Customer Portal**, select **Booking Notification Codes** to create and manage codes.

[!INCLUDE [footer-include](../includes/footer-banner.md)]
