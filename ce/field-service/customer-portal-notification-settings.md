---
title: Enable self-scheduling service appointments in Dynamics 365 Field Service (contains video) | MicrosoftDocs
description: Learn how to allow customers to schedule work orders via a customer portal in Dynamics 365 Field Service
ms.date: 09/07/2021
ms.topic: article
author: Deana-Fuller
ms.author: drfuller
search.app:
  - D365CE
  - D365FS
---

# Set up notifications for the Field Service Portal (preview)

The portal uses Power Automate flows to trigger notifications for customers. Before we can send notifications, choose which channels to use and configure the flows accordingly. To send text messages, you'll need an SMS provider with a Power Automate connector. For emails, we recommend an Office 365 Outlook account.

> [!CAUTION]
> When enabled, the system sends notifications to contacts of the account associated with bookings. When using real customer data to test this feature, prevent accidental communication by [adding accounts to exclusion lists](create-configure-customer-portal.md#self-scheduling-preview-tab).

## Configure email and SMS connectors in Power Automate

The Customer Portal settings in Field Service links directly to the default Power Automate flows for email and SMS.

1. Access the flows by going to the [Power Apps Maker portal](https://make.powerapps.com) > **Solutions** > **Dynamics 365 Field Service PowerApps Portal – Flow**.
1. Select **Objects** > **Cloud flows** to see the list of flows.
1. *Field Service PowerApps Power Flow Email Notifications* and *Field Service PowerApps Power Flow SMS Notifications* flows are off by default. Configure the flows before turning them on.
1. Select and open the flow you want to configure. On the flow, select **Save as** and create a copy of the default flow.
1. Open the flow you just created and select **Edit**. Authenticate or update the connections and **Save** the flow.
1. Then, select **Turn on** to enable the flow.

## List of notifications

After configuring your portal and enabling notifications, emails and SMS messages will be sent to the contact associated to the resulting work orders. You can [customize some aspects for the portal](create-configure-customer-portal.md#customize-the-portal-design), which also apply to the notifications.

The portal sends a notification for the following events:

- **Booking Reminder**: Reminder messages are sent within seven days of the scheduled service time. This message includes the scheduled service time and a link to the portal with information about the booking. By default, reminders are sent daily at 10:00 AM UTC for any bookings in the time period. You can change this time by editing the **Create notification items for bookings** flow. <!--this seems wrong. the flow recurrence is set to 1 hour and I don't see a setting to change the time period (7 days)-->

- **Technician Traveling**: Sent when the booking status is *Traveling*. This message communicates estimated time of arrival while considering traffic on expected route. This message links to your customer portal with a map, so your customer can see progress to your service location.

- **Booking Complete**: Sent when booking status is *Complete*. This message confirms work was completed, along with date and time of completion. 

- **Booking Rescheduled**: Sent when a scheduled service appointment changes by more than 10 minutes from previously scheduled start time.

- **Booking Canceled**: When a scheduled service appointment is canceled.

> [!Note] 
> Service rescheduling and service canceling messages are only sent if a reminder message had previously been sent.

> [!Note]
> The booking confirmation notifications are relavent only to the [self-service scheduling](scheduling-self-customers.md) scenario, and are not avialable with the track my technician functionality.

### Notification settings

Notification settings provide a read-only view of all messages sent to customers. Here you can see which customers have received a message, the type of message, and the state of the message.

> [!div class="mx-imgBorder"]
> ![A list of active notifications in Field Service.](./media/07_FSSettings_notifications.jpg)

> [!div class="mx-imgBorder"]
> ![A detail page for a notification in Field Service.](./media/07a_FSSettings_notifications-details.jpg)

### Booking notification codes

With booking notification codes, Field Service admins can extend, expire, or block access to a portal link that has been shared with a customer.

> [!div class="mx-imgBorder"]
> ![Screenshot of the list of active notifications, along with their codes.](./media/08_FSSettings_BookingNotifications.jpg)

> [!div class="mx-imgBorder"]
> ![Screenshot of notification details in Field Service.](./media/09_FSSettings_BookingNotifications-details.jpg)
