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

As an administrator or a supervisor, you can help agents in your organization view their work schedules. The **My Schedule** view in the Dynamics 365 Customer Service workspace app lets agents quickly view their working hours, nonworking hours, breaks, and any scheduled time off. The calendar view is a read-only visual that provides daily, weekly and monthly views of an agent's schedule. It also has an agenda view that provides a list-type view of the agent's schedule. 

## Prerequisites

You must have **Workforce Management for Customer Service** enabled in your environment. To enable Workforce Management for your environment, follow the steps below:

- Navigate to your environment in [Power Platform admin center (PPAC)](https://admin.powerplatform.microsoft.com/). You must have an administrator role in order to make changes to your environment.
- On the environment page, click on **Resources** > **Dynamics 365 apps**. The **Resources** button is located on the top menu bar.
- On the Dynamics 365 apps page, click on **Install app**. The **Install Dynamics 365 apps** flyout will appear.
- In the flyout, scroll down all the way to the bottom, and select **Workforce Management for Customer Service**. Click on **Next**.
- Agree to the terms of service and click on **Install**.
- Wait until the **Workforce Management for Customer Service** is marked as installed on the Dynamics 365 apps page.

To enable the calendar view for agents, you must have at least one of the following roles:

- System Administrator
- CSR Manager
- Omnichannel administrator
- Omnichannel supervisor

You must also have a third-party adapter configured to import agent bookings from an external system. Without an adapter in place, external bookings can't be surfaced in the agent calendar, and agents can't view their schedules.

## Enable the agent calendar

1. In the Customer Service admin center sitemap, select **Workforce management**.

1. In the **Agent calendar** section, select **Manage**. The **Agent calendar** page is displayed.

   :::image type="content" source="media/agent-calendar-manage-configuration.png" alt-text="Manage option for enabling the agent calendar view.":::

1. Turn on the **Enable agent calendar** toggle.

1. Select **Save and close**.


## Next Steps

[Get started with Customer Service workspace](csw-overview.md)  
[Use the agent calendar view](use-agent-calendar.md)

