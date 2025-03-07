---
title: Configure the agent calendar view
description: Learn how to enable the agent calendar in  your contact center.
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.date: 03/03/2025
ms.custom: bap-template
---

# Configure the agent calendar view

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

As an administrator or a supervisor, you can help customer service representatives (service representatives or representatives) in your organization view their work schedules. The **My Schedule** view in the Customer Service workspace app lets service representatives quickly view their working hours, nonworking hours, breaks, and any scheduled time off.

The calendar view is a read-only visual that provides daily, weekly, and monthly views of a representative's schedule. It also has an agenda view that provides a list-type view of the representative's schedule.

> [!Note]
> The agent calendar view isn't supported in the Government Community Cloud (GCC) or sovereign clouds.

## Prerequisites

- You must have [Workforce Management for Customer Service](#enable-workforce-management) enabled in your environment.

- To enable the calendar view for representatives, you must have at least one of the following roles:

  - System Administrator
  - CSR Manager
  - Omnichannel administrator
  - Omnichannel supervisor

- You must have a third-party adapter configured to import representative bookings from an external system. Without an adapter in place, external bookings can't be surfaced in the agent calendar, and representatives can't view their schedules.

## Enable the agent calendar

1. In the Customer Service admin center site map, select **Workforce management**.

1. In the **Agent calendar** section, select **Manage**. The **Agent calendar** page is displayed.

1. Turn on the **Enable agent calendar** toggle.

1. Select **Save and close**.

## Shift bookings view for supervisors

The shift booking list view lets supervisors view the bookings that are imported from their third-party workforce management system. Supervisors can use this view to access a consolidated list of bookings for all representatives in their system. The shift bookings view offers a comprehensive breakdown of each representative’s individual activities, including work hours, time off, lunch breaks, trainings, and more. 

Administrators can utilize this view to verify the proper functioning of the third-party adapter booking sync process.

1. In Customer Service workspace, expand the site map, and then select **Shift Bookings**.
   
1. Select the **All Shift Bookings** view.

   :::image type="content" source="../media/agent-calendar-shift-bookings-view.png" alt-text="Agent calendar shift bookings view for supervisors.":::

## Enable workforce management

To enable Workforce Management, complete the following steps:

1. Navigate to your environment in [Power Platform admin center](https://admin.powerplatform.microsoft.com/).

     > [!Note]
     > You must have the System Administrator role to make changes to your environment.
   
1. On the command bar, select **Resources** > **Dynamics 365 apps**. The Dynamics 365 apps page is displayed.
   
1. Select **Install app**. The **Install Dynamics 365 apps** page is displayed.
   
1. Scroll down to locate and select **Workforce Management for Customer Service**, and then select **Next**.
   
1. You must agree to the terms of service, and then select **Install**.
   
1. Wait until the **Workforce Management for Customer Service** shows as installed on the **Dynamics 365 apps** page.

## Next Steps

[Get started with Customer Service workspace](../implement/csw-overview.md)  
[Use the agent calendar view](../use/use-agent-calendar.md)

