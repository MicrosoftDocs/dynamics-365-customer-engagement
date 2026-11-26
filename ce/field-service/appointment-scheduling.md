---
title: Show appointments on the schedule board
description: Learn how to show appointments on the schedule board with resource scheduling in Field Service so dispatchers can view availability and schedule work more effectively.
ms.date: 06/19/2026
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

# Show appointments on the schedule board

Use the schedule board to show [Dynamics 365 appointments](/dynamics365/customer-engagement/web-api/appointment) alongside bookings so dispatchers can see availability during scheduling. When you enable appointments for your organization and resources, you can view them on the schedule board. This article also explains the different ways to create appointments.

## Enable appointments for your organization

Enable appointment scheduling for all resources in your organization.

1. Open the **Resource Scheduling** application.

1. Change to the **Settings** area and go to **Administration** > **Scheduling Parameters**.

1. Set **Include Appointments** to **Yes**.

1. Confirm your change and select **Save & Close**.

## Enable appointments for a resource

When you enable appointments in the environment, you can change the setting for individual resources.

1. In the **Resource Scheduling** application, select **Resources**.

1. Open a bookable resource, select the **Scheduling** tab, and set **Include Appointments** to **Yes**.

   :::image type="content" source="media/Appointment04-ResourceLevelConfiguration.png" alt-text="Screenshot of the Include Appointments setting on the Scheduling tab for a bookable resource.":::

## Create an appointment

You can create Dataverse appointments in several ways. For example, you can create appointments:

- In [Dynamics 365 Customer Service Hub using Activities](/dynamics365/customer-service/customer-service-hub-user-guide-basics#understand-activities)
- In [Dynamics 365 Sales Professional using Activities](/dynamics365/sales-professional/manage-activities)
- In Outlook by using [server-side synchronization](/power-platform/admin/server-side-synchronization) and the [tracked to Dynamics 365](/power-platform/admin/use-outlook-category-track-appointments-emails) category so the appointment appears as a Dataverse appointment record.

## View appointments on the schedule board

Appointments on the schedule board are read-only.

- You can't move them.
- They appear for all required attendees and the owner if they're bookable resources.
- You can view more details by hovering over an appointment.

Appointments marked *Private* in Outlook and synced to Dynamics 365 don't show their subject on the schedule board.

### Customize appointment colors on the schedule board

The schedule board uses colors defined in [Dataverse appointment](/dynamics365/customer-engagement/web-api/appointment) metadata. To change the appointment colors that show on the schedule board, change the **Color** of each **StatusCode**.

> [!NOTE]  
> Customizing appointment tooltips on the schedule board isn't supported.

### Hide canceled appointments on the schedule board

1. On the Schedule Board, select **Scheduler settings**.

1. Turn off **Show canceled**. Canceled bookings and appointments no longer display.

## Automatically schedule around appointments

[Resource Scheduling Optimization](rso-overview.md) respects appointments when a planned optimization schedule runs, and for ad-hoc optimizations from the schedule board. The system considers appointments with statuses *Busy* and *Completed* as unavailable for scheduling operations.

Automated and assisted scheduling operations consider appointments as location-agnostic. If an appointment has related bookings, the system hides those bookings and doesn't consider them for scheduling operations.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
