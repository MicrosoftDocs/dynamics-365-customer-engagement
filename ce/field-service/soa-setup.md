---
title: Set up the Scheduling Operations Agent (preview)
description: Learn how to set up the Scheduling Operations Agent for Dynamics 365 Field Service.
ms.date: 03/03/2025
ms.topic: how-to
ms.author: anilmur
author: anilmur
---

# Set up the Scheduling Operations Agent (preview)

The Scheduling Operations Agent is an autonomous agent for a Dynamics 365 app, Before a dispatcher can use the new Scheduling Operations Agent capabilities, an administrator must ensure the environment is up-to-date, billing settings are set up, and feature settings configured.

## Prerequisites

- Your environment  is updated to Field Service version 8.8.124.75 or newer, and Universal Resource Scheduling version 3.12.142.5 or newer.
- Location and map settings are enabled for your environment.

## Set up a pay-as-you-go plan

The Scheduling Operations Agent consumes Microsoft Copilot Studio messages when a user runs it. The number of messages depends on the complexity of the optimized schedule. For licensing information, see the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).

The [Power Platform pay-as-you-go](/power-platform/admin/pay-as-you-go-overview) plan mandates the usage of an Azure subscription the system charges when the agent runs. To [set up pay-as-you-go billing for an environment](/power-platform/admin/pay-as-you-go-set-up?tabs=new), you need an active Azure subscription that you can link to that environment. For more information, see Set up pay-as-you-go.

To keep track of the cost, you can [view usage and billing information](/power-platform/admin/pay-as-you-go-usage-costs).

## Enable the Scheduling Operations Agent

1. Open the Field Service app.
1. Change to the Resources area and go to Scheduling Parameters > Resource Scheduling.
1. Go to the Agents tab and turn on Scheduling Operations Agent (Preview).

:::image type="content" source="media/soa-enable-agent.png" alt-text="Screenshot of the resource scheduling settings that enables the agent.":::

## Set properties for bookable resources

Bookable resources that the agent supports must be of type User, Contact, or Crew. Ensure the following properties are set:

- Start Location and End Location specified to a value other than Location Agnostic
- Display on Schedule Board set to Yes

:::image type="content" source="media/soa-resource-configuration.png" alt-text="Screenshot of a configured bookable resource record.":::

## Create or update optimization method for booking status

The agent needs to know if it can move or delete scheduled or committed bookable resource bookings in favor of unfulfilled requirements that better match the optimization goals. We introduced a new property for booking statues called Optimization Method.

1. Open the Field Service app and go to the Resources area.
1. Select Booking Settings > Booking Statuses. To see all statuses, remove all filters from the view.
1. Set the Optimization Method for each booking status:

    - Optimize: Move or delete bookings with these statuses as necessary to generate an optimal schedule. Typically, bookings with these statuses aren't in progress yet. For example: scheduled or committed.
    - Do Not Move: Preserve the start time of any bookings with these statuses so the agent doesn't change them. This status is the default option for all statuses. For such bookings, the agent only updates the travel if a previous booking is moved or changed.
    - Ignore: Indicate to the agent that it should override any bookings with these statues. It can move or create new bookings on top.

:::image type="content" source="media/soa-booking-status.png" alt-text="Screenshot of a booking status record with a configured optimization method.":::

> [!TIP]
> In addition to the default booking statuses, we recommend that you create a new booking status, such as Locked, with Optimization Method set to Do Not Move. Dispatchers can use that booking status to selectively indicate which bookings to preserve when the agent runs. Also, if you don't adjust the Optimization Method for Committed or Scheduled statuses, then the agent has little flexibility in making changes to an existing schedule.

## Create or update priority values

To help the agent decide which bookings or resource requirements are more important than others, we added the Priority Value field to existing priorities. It accepts numbers between 1 and 100. The agent ignores the Level of Importance field. The higher the number, the higher the priority.

:::image type="content" source="media/soa-priority-value.png" alt-text="Screenshot of a priority record with a numeric priority value.":::

1. Open the Field Service app.
2. Change to the Settings area and select Priorities.
3. Create new Priority records or update existing priorities with Priority Values.  

> [!TIP]
> We recommend using priority values that are clearly distinguishable. For example, 100 for the highest priority emergency work, 75 for high priority work, 50 for moderate priority, and so on. Avoid using values too close to each other to help the agent effectively distinguish priorities.

## Next step

[Run the Scheduling Operations Agent (preview)](soa-run.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
