---
title: Integrate bookings with Outlook calendars
description: Set up Microsoft Online Exchange to integrate with Dynamics 365 Field Service to synchronize bookings.
ms.date: 09/25/2024
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
---

# Integrate bookings with Outlook calendars

Frontline workers can have all their appointments, company meetings, personal events, and bookings in one calendar. Any bookings created in Field Service syncs with the worker’s mailbox so they show up as appointments in Outlook. Synching occurs every 10 minutes. Appointments set up in Outlook don't appear in Field Service.

To enable this feature, an administrator must set up the integration. The appointment appears in the Outlook calendar shortly after the worker is booked. The appointment includes: the work order date, time window, work order number, and location.

## Set up the Exchange integration

1. Sign in to [Power Platform admin center](https://admin.powerplatform.microsoft.com/).
1. Select **Environments** and select your environment.
1. Select **Settings** > **Email** > **Server profiles**.
1. Verify the Microsoft Exchange Online server profile is **Active** and the **Authentication Type** is set to Server-to-Server Authentication.
1. Go back to Email and select Mailboxes.
1. Edit each user and perform the following steps.

   :::image type="content" source="media/ppac-mailbox-edit.png" alt-text="Screenshot of editing a mailbox through Power Platform admin center.":::

   - Set **Appointments, contacts, and tasks** to **Server-Side Synchronization**.
   - Select **Approve Email** and confirm.
   - Select **Test & Enable Mailbox** and confirm.
   - Select **Save & Close**.
