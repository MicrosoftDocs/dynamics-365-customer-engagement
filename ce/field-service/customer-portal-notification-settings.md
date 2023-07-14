---
title: Set up notifications for the Field Service Portal
description: Configure notifications to keep your customers up to date on their bookings and appointments.
ms.date: 05/03/2023
ms.topic: how-to
author: m-hartmann
ms.author: mhart
search.app:
  - D365CE
  - D365FS
---

# Set up notifications for the Field Service Portal

The portal uses Power Automate flows to trigger notifications for customers. Before we can send notifications, choose which channels to use and configure the flows accordingly. To send text messages, you'll need an SMS provider with a Power Automate connector. For emails, we recommend an Office 365 Outlook account.

> [!CAUTION]
> When enabled, the system sends notifications to contacts of the account associated with bookings. When using real customer data to test this feature, prevent accidental communication by [adding accounts to exclusion lists](create-configure-customer-portal.md#self-scheduling-preview-tab).

## Configure email and SMS connectors in Power Automate

The Customer Portal settings in Field Service link directly to the default Power Automate flows for email and SMS.

1. Access the flows by going to the [Power Apps Maker portal](https://make.powerapps.com) > **Solutions** > **Dynamics 365 Field Service PowerApps Portal – Flow**.
1. Select **Objects** > **Cloud flows** to see the list of flows.

To configure email:

1. Select the *Field Service PowerApps Power Flow Email Notifications* flow, which is turned off by default.
1. Open the flow and configure it.
1. On the flow, select **Save as** and create a copy of the default flow.
1. Open the flow you created and select **Edit**. Authenticate or update the connections and **Save** the flow.
1. Select **Turn on** to enable the flow.

To configure SMS:

1. Select the *Field Service PowerApps Power Flow SMS Notifications* flow, which is turned off by default.
1. On the flow, select **Save as** and create a copy of the default flow.
1. Open the flow you created and select **Edit**. Authenticate or update the connections and **Save** the flow.
1. Select **Turn on** to enable the flow.

## List of notifications

After configuring your portal and enabling notifications, emails and SMS messages will be sent to the customer contact. You can [customize some aspects for the portal](create-configure-customer-portal.md#customize-the-portal-design), which also apply to the notifications.

The portal sends a notification for the following events:

- **Upcoming Booking**: Reminder messages are sent seven days before the scheduled service time. This message includes the scheduled service time and a link to the portal with information about the booking. By default, reminders are sent daily at 10:00 AM UTC for any bookings in the time period. You can change this time by editing the **Create notification items for bookings** flow.

- **Traveling**: Sent when the booking status changes to *Traveling*. This message communicates estimated time of arrival while considering traffic on the planned route. It links to the customer portal where your customer can see more details.

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
