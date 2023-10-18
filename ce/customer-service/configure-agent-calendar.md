---
title: Configure the agent calendar view
description: Learn how to enable the agent calendar in Dynamics 365 Customer Service admin center.
author: lalexms
ms.author: laalexan
ms.reviewer: shubjoshi
ms.topic: how-to
ms.date: 10/18/2023
ms.custom: bap-template
---

# Configure the agent calendar view

As an administrator or a supervisor, you can help agents in your organization view their work schedules. The **My Schedule** view in the Dynamics 365 Customer Service workspace app lets agents quickly view their working hours, nonworking hours, breaks, and any scheduled time off. 

The calendar view is a read-only visual that provides daily, weekly, and monthly views of an agent's schedule. It also has an agenda view that provides a list-type view of the agent's schedule. 

## Prerequisites

- You must have **Workforce Management for Customer Service** enabled in your environment.

  To enable Workforce Management, complete the following steps:

  1. Navigate to your environment in [Power Platform admin center (PPAC)](https://admin.powerplatform.microsoft.com/).

     > [!Note]
     > You must have the System Administrator role to make changes to your environment.
   
  1. On the command bar, select **Resources** > **Dynamics 365 apps**. The Dynamics 365 apps page is displayed.
   
  1. Select **Install app**. The **Install Dynamics 365 apps** page is displayed.
   
  1. Scroll down to locate and select **Workforce Management for Customer Service**, and then select **Next**.
   
  1. You must agree to the terms of service, and then select **Install**.
   
  1. Wait until the **Workforce Management for Customer Service** shows as installed on the **Dynamics 365 apps** page.

- To enable the calendar view for agents, you must have at least one of the following roles:

  - System Administrator
  - CSR Manager
  - Omnichannel administrator
  - Omnichannel supervisor

- You must have a third-party adapter configured to import agent bookings from an external system. Without an adapter in place, external bookings can't be surfaced in the agent calendar, and agents can't view their schedules.

## Enable the agent calendar

1. In the Customer Service admin center site map, select **Workforce management**.

1. In the **Agent calendar** section, select **Manage**. The **Agent calendar** page is displayed.

   :::image type="content" source="media/agent-calendar-manage-configuration.png" alt-text="Manage option for enabling the agent calendar view.":::

1. Turn on the **Enable agent calendar** toggle.

1. Select **Save and close**.

## Shift bookings view for supervisors

The shift booking list view lets supervisors view the bookings that are imported from their third-party workforce management system. Using this view, supervisors can access a consolidated list of bookings for all agents in their system. The shift bookings view offers a comprehensive breakdown of each agent’s individual activities, including work hours, time off, lunch breaks, trainings, and more. 

Administrators can utilize this view to verify the proper functioning of the third-party adapter booking sync process.

1. In Customer Service workspace, expand the site map, and then select **Shift Bookings**.
   
1. Select the **All Shift Bookings** view.

   :::image type="content" source="media/agent-calendar-shift-bookings-view.png" alt-text="Agent calendar shift bookings view for supervisors.":::


## Next Steps

[Get started with Customer Service workspace](csw-overview.md)  
[Use the agent calendar view](use-agent-calendar.md)

