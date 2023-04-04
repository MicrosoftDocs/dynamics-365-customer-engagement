---
title: Show appointments on the schedule board
description: Learn how to include appointments with resource scheduling in Dynamics 365 Field Service.
ms.date: 02/23/2023
ms.topic: how-to
author: clearab
ms.author: anclear
search.app: 
  - D365CE
  - D365FS
---

# Show appointments on the schedule board

Organizations often use appointments in Dynamics 365 applications. Typical examples are a salesperson using appointments to meet with potential customers or a customer service rep creating a service appointment to help a customer with an issue. Other examples may include organizations creating appointments because of integrations with other systems.

You can use the schedule board to show [Dynamics 365 Appointments](/dynamics365/customer-engagement/web-api/appointment) alongside bookings. Include appointments on the schedule board and during the scheduling process so dispatchers see the availability.

## Environment setting

This setting will enable appointment scheduling for all resources in your organization.

1. Go to **Resource Scheduling** > **Settings** > **Administration** > **Scheduling Parameters** and set **Include Appointments** to *Yes*.

> [!div class="mx-imgBorder"]
> ![Screenshot of organization level setting.](./media/Appointment01-OrgLevelConfiguration.png)

1. In the dialog box, select **Got it. Let’s enable.** Then **Save & Close**.

## Resource setting

After enabling appointments on the environment-level, you can change the setting for individual resources.

Open a bookable resource form and update the value for **Include Appointments**.

> [!div class="mx-imgBorder"]
> ![Screenshot of resource level setting.](./media/Appointment04-ResourceLevelConfiguration.png)

## Create an appointment

There are several ways to create Dataverse appointments. For example:

- [Dynamics 365 Customer Service Hub, using Activities](/dynamics365/customer-service/customer-service-hub-user-guide-basics#understand-activities)
- [Dynamics 365 Sales Professional to manage tasks, appointments, email, or phone calls](/dynamics365/sales-professional/manage-activities)
- In Outlook, using [server-side synchronization](/power-platform/admin/server-side-synchronization) and the [Tracked to Dynamics 365](/power-platform/admin/use-outlook-category-track-appointments-emails) category so it appears as a Dataverse appointment record.

## View appointments on the schedule board

Appointments on the schedule board are read-only and you can't move them. They show for all required attendees and the owner, if they're bookable resources. Hover over an appointment to see more details. You can also open the legend to see the colors for the appointment status.

> [!NOTE]
> Appointments that are marked *Private* in Outlook and synced to Dynamics 365 won't show their subject on the schedule board.

### Customize appointment colors on the schedule board

The schedule board uses colors defined in [Dataverse appointment](/dynamics365/customer-engagement/web-api/appointment) metadata. Customizing the **Color** of each **StatusCode** will change the appointment colors that show on the schedule board.  

### Hide canceled appointments on the schedule board

The [**Show canceled** setting in **Board view settings**](schedule-board-tab-settings.md) controls the visibility of canceled bookings and appointments.

## Automatically schedule around appointments

[Resource Scheduling Optimization](rso-overview.md) respects appointments when a planned optimization schedule runs, and for ad-hoc optimizations from the schedule board. The system considers appointments with statuses *Busy* and *Completed* as unavailable for scheduling operations.

Automated and assisted scheduling operations consider appointments as location-agnostic. If an appointment had related bookings, the system hides those bookings and won't consider them for scheduling operations.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
