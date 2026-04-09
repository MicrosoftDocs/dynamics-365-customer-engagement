---
title: Integrate Field Service bookings with Outlook calendars
description: Set up Microsoft Online Exchange to integrate with Dynamics 365 Field Service to synchronize bookings.
ms.date: 12/09/2025
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
---

# Integrate bookings with Outlook calendars

Frontline workers can have all their appointments, company meetings, personal events, and bookings in one calendar. Any bookings created against a work order synchronize with the worker’s mailbox, so they show up as appointments in Microsoft Outlook. Synchronization occurs within 15 minutes.

The synchronization of bookings into Outlook works only one way. Events set up in Outlook don't appear in Field Service as bookings. Data flows from Dataverse into Exchange, potentially crossing geographic boundaries.

## Set up the Exchange integration

Set up user mailboxes to synchronize with Microsoft Exchange Online. If tasks, contacts, or appointments synchronization are already set up for a user, bookings from Field Service start synchronizing automatically. No other setup is required. Learn more about [tasks, contacts, and appointments synchronization](/power-platform/admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks).

### Prerequisites

- You have a Dynamics 365 System Admin role.
- You have an Exchange admin role for your tenant *or* the delegated mailbox approver role in Dynamics 365.
- The Exchange server and the Field Service application must be in the same tenant.

### Set up the integration

1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com/).

1. Select **Manage** > **Environments** and select your environment.

1. Select **Settings** > **Email** > **Server profiles**.

1. Verify the Microsoft Exchange Online server profile is **Active** and the **Authentication Type** is set to **Server-to-Server Authentication**. If the Exchange Online server profile doesn’t exist, [create it](/power-platform/admin/connect-exchange-online#create-an-email-server-profile-for-exchange-online).

1. Go back to **Email** and select **Mailboxes**.

1. Edit each user and perform the following steps.

   - Confirm that **Server Profile** is set to **Microsoft Exchange Online**, or the Exchange Online server profile created in step 4.
   - Set **Appointments, Contacts, and Tasks** to **Server-Side Synchronization**.
   - In the command bar, select **Approve Email** and confirm.
   - Select **Test & Enable Mailbox** and confirm.
   - Select **Save & Close**.

   :::image type="content" source="media/power-platform-mailbox-edit.png" alt-text="Screenshot of editing a mailbox through Power Platform admin center.":::

1. To confirm that a mailbox is ready, refresh the mailbox screen and check for a success status.

> [!NOTE]
> This process might take several hours, especially if you turn on mailboxes in bulk.

## Booking synchronization

Bookings synchronize one week in the past and up to two weeks in the future. If synchronization is disabled, synchronized records aren’t deleted and new records don't synchronize.

### Create and edit bookings

When a booking is scheduled for a work order, it appears in the technician’s Outlook calendar after synchronization occurs, every 10 to 15 minutes. A link is created. The appointment includes: the work order date, time window, work order number, and location. The appointment has a default priority.

A change to the booking time window or location in Field Service triggers an update to Outlook during synchronization. If only the work order is updated in Field Service, Outlook isn’t updated.

The following fields populate the first time the booking is scheduled. Any updates that occur on the work order after this time aren’t reflected in Outlook unless there's a change to the booking time window or location.

- Priority
- Location
- Work Order Type
- Primary Incident Type
- Work Order Summary
- Account
- Primary Contact

:::image type="content" source="media/outlook-exchange-work-order.png" alt-text="Screenshot of booking details for a work order in Outlook.":::

### Cancel bookings

By default, appointments that are canceled in Field Service don't sync to Exchange as **Canceled**. To change this setting, turn on *SSSPropagateAppointmentCancellationsToExchange* in [OrgDBOrgSettings](/power-platform/admin/orgdborgsettings). When this setting is enabled, canceling an appointment in Field Service cancels the meeting in Exchange, which sends the cancellation to attendees.

### Delete bookings

When a booking is deleted in Field Service and synced with Exchange, the appointment is deleted in Exchange only if all the following conditions are met:

- The Outlook appointment remains tagged "Tracked to Dynamics."
- The booked resource remains the appointment organizer.
- The appointment is in the future.
- The appointment wasn't [logically deleted](/power-platform/admin/sync-logic#ignore-logically-deleted-items-during-sync).

If all these conditions aren't met, the appointment still exists in Exchange, but it's unlinked. Learn more: [Synchronization logic for appointments, contacts, and tasks](/power-platform/admin/sync-logic#syncing-canceled-and-deleted-appointments-from-dynamics-365-to-exchange).  

### Limitations

- Updates to the booking are required to reflect changes to the work order in Outlook.
- Users can be set up to sync with only one environment at a time.
- Only bookings tied to a work order synchronize.
- Bookings synchronize one week in the past and up to two weeks in the future. The system view that controls this behavior is uneditable and appears with warnings. If you would like the ability to change what fields get synced and the window of bookings that sync, submit an idea on our [Dynamics 365 Field Service ideas form](https://experience.dynamics.com/ideas/categories/list/?category=a2fa5aca-3f2d-e811-813c-e0071b6ad011&forum=bee3d862-df65-e811-a95d-000d3a1be7ad).

## Troubleshooting

For privilege errors, go to:

- [PrivilegeDenied error occurs when using Server-Side Synchronization](/previous-versions/troubleshoot/dynamics/crm/privilegedenied-error-when-using-server-side-sync)
- [Privilege or permission error for Outlook](/troubleshoot/power-platform/dataverse/d365-app-outlook/privilege-error-occurs-when-using-dynamics-365-app-for-outlook#more-information)

### Bookings scheduled more than two weeks in advance don't synchronize in Outlook Exchange

Bookings scheduled more than two weeks in advance in Field Service don't synchronize in Outlook.

#### Symptoms

Bookings that were originally created and scheduled more than two weeks in advance don't synchronize automatically when the booking enters the two-week window. This is a known limitation.

#### Resolution

To make sure synchronization for these bookings occurs, [update any field in the booking record](#booking-synchronization) within the two-week window. For example, update the time window or resource assignment. Updates to fields in related entities don't trigger synchronization.

### Duplicate bookings appear in Outlook Exchange

Duplicate bookings appear in Outlook.

#### Symptoms

The Outlook integration is a built-in solution that synchronizes bookings with Outlook calendars. Customers who use a custom solution to synchronize bookings between Field Service and Exchange might see duplicate booking entries in Outlook.

#### Resolution

Either disable the custom synchronization solution and use the built-in Field Service solution, or [create a support case](/power-platform/admin/get-help-support) to request Microsoft to disable the built-in Field Service solution for specific environments.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
