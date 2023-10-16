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

### Calendar view

   :::image type="content" source="media/my-schedule-calendar-view.png" alt-text="Calendar view of an agent's schedule.":::

## Prerequisites

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

