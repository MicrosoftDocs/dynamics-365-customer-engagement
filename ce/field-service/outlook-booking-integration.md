---
title: Integrate bookings with Outlook calendars
description: Set up Microsoft Online Exchange to integrate with Dynamics 365 Field Service to synchronize bookings.
ms.date: 11/14/2024
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
---

# Integrate bookings with Outlook calendars

Frontline workers can have all their appointments, company meetings, personal events, and bookings in one calendar. Any bookings created in Field Service synchronize with the worker’s mailbox, so they show up as appointments in Outlook. Synchronization occurs every 15 minutes.

The synchronization of bookings into Outlook works only one way. Appointments set up in Outlook don't appear in Field Service.

To enable this feature, an administrator must set up the integration. The appointment appears in the Outlook calendar shortly after the worker is booked. The appointment includes: the work order date, time window, work order number, and location.

## Set up the Exchange integration

Set up user mailboxes to synchronize with Microsoft Exchange Online. Individuals can set up their own mailbox or administrators can set up the user mailboxes for the organization.

> [!NOTE]
> If tasks, contacts, or appointments synchronization has already been set up for a user, bookings from Field Service will start synchronizing automatically. No set up is required.

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

   - Confirm that Server Profile is set to Microsoft Exchange Online, or the Exchange Online server profile created in step 4.
   - Set **Appointments, contacts, and tasks** to **Server-Side Synchronization**.
   - Select **Approve Email** and confirm.
   - Select **Test & Enable Mailbox** and confirm.
   - Select **Save & Close**.

   :::image type="content" source="media/ppac-mailbox-edit.png" alt-text="Screenshot of editing a mailbox through Power Platform admin center.":::

1. To confirm that a mailbox is ready, refresh the mailbox screen and check for a success status.

> [!NOTE]
> This process might take several hours, especially if you turn on mailboxes in bulk.

## Synchronization process

In Field Service, a booking is scheduled for a work order. When synchronization occurs, every 15 minutes, the booking appears in the technician’s Outlook calendar. The appointment includes: the work order date, time window, work order number, and location. The booking has a default priority.

When the booking status or booking time window is updated in Field Service, it triggers an update to Outlook during synchronization. If only the work order is updated in Field Service, Outlook isn’t updated.

The following fields populate the first time the booking is scheduled. Any updates that occur on the work order after this time aren’t reflected in Outlook unless there's a change in the booking status or booking time window.

- Priority
- Location
- Work Order Type
- Primary Incident Type
- Work Order Summary
- Account
- Primary Contact

Bookings synchronize one week in the past and up to two weeks in the future.

:::image type="content" source="media/outlook-exchange-wo.png" alt-text="Screenshot of booking details for a work order in Outlook.":::

If synchronization is disabled, synchronized records aren’t deleted. New records don’t synchronize.

### Limitations

- Only updates to the booking in Field Service are reflected in Outlook. If only the work order is updated in Field Service, Outlook isn’t updated.
- Users can be set up to sync with only one environment at a time.
