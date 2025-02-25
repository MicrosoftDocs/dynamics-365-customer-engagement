---
title: Integrate Field Service bookings with Outlook calendars
description: Set up Microsoft Online Exchange to integrate with Dynamics 365 Field Service to synchronize bookings.
ms.date: 02/25/2025
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
---

# Integrate bookings with Outlook calendars

Frontline workers can have all their appointments, company meetings, personal events, and bookings in one calendar. Any bookings created against a work order synchronize with the worker’s mailbox, so they show up as appointments in Microsoft Outlook. Synchronization occurs every 15 minutes. The appointment includes: the work order date, time window, work order number, and location.

The synchronization of bookings into Outlook works only one way. Events set up in Outlook won't appear in Field Service as bookings.

## Set up the Exchange integration

Set up user mailboxes to synchronize with Microsoft Exchange Online.

> [!NOTE]
> If tasks, contacts, or appointments synchronization has already been set up for a user, bookings from Field Service start synchronizing automatically. No other set up is required.

### Prerequisites

- You have an Exchange admin role for your tenant and a Dynamics 365 System Admin role *or* the delegated mailbox approver role in Dynamics 365.
- The Exchange server and the Field Service application must be in the same tenant.

### Set up the integration

1. Sign in to [Power Platform admin center](https://admin.powerplatform.microsoft.com/).

1. Select **Environments** and select your environment.

1. Select **Settings** > **Email** > **Server profiles**.

1. Verify the Microsoft Exchange Online server profile is **Active** and the **Authentication Type** is set to **Server-to-Server Authentication**. If the Exchange Online server profile doesn’t exist, [create it](/power-platform/admin/connect-exchange-online#create-an-email-server-profile-for-exchange-online).

1. Go back to **Email** and select **Mailboxes**.

1. Edit each user and perform the following steps.

   - Confirm that **Server Profile** is set to **Microsoft Exchange Online**, or the Exchange Online server profile created in step 4.
   - Set **Appointments, contacts, and tasks** to **Server-Side Synchronization**.
   - In the command bar, select **Approve Email** and confirm.
   - Select **Test & Enable Mailbox** and confirm.
   - Select **Save & Close**.

   :::image type="content" source="media/ppac-mailbox-edit.png" alt-text="Screenshot of editing a mailbox through Power Platform admin center.":::

1. To confirm that a mailbox is ready, refresh the mailbox screen and check for a success status.

> [!NOTE]
> This process might take several hours, especially if you turn on mailboxes in bulk.

## Booking synchronization

Bookings synchronize one week in the past and up to two weeks in the future. If synchronization is disabled, synchronized records aren’t deleted. New records won’t synchronize.

### Create and edit bookings

When a booking is scheduled for a work order, it appears in the technician’s Outlook calendar after synchronization occurs, every 10 to 15 minutes. The booking has a default priority.

A change to the booking time window or location in Field Service triggers an update to Outlook during synchronization. If only the work order is updated in Field Service, Outlook isn’t updated.

The following fields populate the first time the booking is scheduled. Any updates that occur on the work order after this time aren’t reflected in Outlook unless there's a change in the booking time window or location.

- Priority
- Location
- Work Order Type
- Primary Incident Type
- Work Order Summary
- Account
- Primary Contact

:::image type="content" source="media/outlook-exchange-wo.png" alt-text="Screenshot of booking details for a work order in Outlook.":::

### Cancel bookings

By default, appointments that are canceled in Field Service don't sync to Exchange as **Canceled**. To change this behavior, turn on *SSSPropagateAppointmentCancellationsToExchange* in [OrgDBOrgSettings](/power-platform/admin/orgdborgsettings). When this setting is enabled, canceling an appointment in Field Service cancels the meeting in Exchange, which sends the cancellation to attendees.

### Delete bookings

When a booking is deleted in Field Service and synced with Exchange, the appointment is deleted in Exchange only if all the following conditions are met:

- The appointment is linked (the appointment was created as a booking in Field Service).
- The syncing user is the appointment organizer.
- The appointment is in the future.
- The appointment hasn't been [logically deleted](/power-platform/admin/sync-logic#ignore-logically-deleted-items-during-sync).

If all these conditions aren't met, the appointment still exists in Exchange, but it's unlinked. For more information, go to [Synchronization logic for appointments, contacts, and tasks](/power-platform/admin/sync-logic#syncing-canceled-and-deleted-appointments-from-dynamics-365-to-exchange).  

### Limitations

- Only updates to the booking in Field Service are reflected in Outlook. If only the work order is updated in Field Service, Outlook isn’t updated.
- Updates only to the work order won’t be reflected in Outlook until the booking is changed.
- Users can be set up to sync with only one environment at a time.
- Only bookings tied to a work order will synchronize.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
