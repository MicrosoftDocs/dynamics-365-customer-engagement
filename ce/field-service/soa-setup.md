---
title: Set up the Scheduling Operations Agent (preview)
description: Learn how to set up the Scheduling Operations Agent for Dynamics 365 Field Service.
ms.date: 03/19/2025
ms.topic: how-to
ms.author: anilmur
author: anilmur
---

# Set up the Scheduling Operations Agent (preview)

The Scheduling Operations Agent is an autonomous agent for a Dynamics 365 app, Before a dispatcher can use the new Scheduling Operations Agent capabilities, an administrator must ensure the environment is up-to-date, billing settings are set up, and feature settings configured.

## Prerequisites

- Your environment is updated to Field Service version 8.8.124.75 or newer, and Universal Resource Scheduling version 3.12.142.5 or newer.
- [Location and map settings are enabled](field-service-maps-address-locations.md) for your environment.

## Consumption-based billing model

Scheduling Operations Agent and other Copilot and agent capabilities in Dynamics 365 use consumption-based billing, charging per use. These capabilities use Microsoft Copilot Studio messages for AI interactions and tasks, like retrieving information and responding to prompts. Messages are the billing units that measure usage. The number of messages per event depends on its complexity. Learn more about messages in [Message scenarios](/microsoft-copilot-studio/requirements-messages-management#message-scenarios).  

Learn more about billing and rates in [Power Platform Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=2085130).

### Set up billing model

Dynamics 365 supports two billing models: prepaid capacity and pay-as-you-go. The prepaid capacity model uses Copilot Studio message pack subscriptions, which are a licensing option for Microsoft Copilot Studio that you purchase in advance. The pay-as-you-go model charges for the actual number of messages consumed by agents during the month. Learn more in [Copilot licensing](/microsoft-copilot-studio/billing-licensing).

Both models require that you link your Dynamics 365 environment to a Power Platform environment.

> [!NOTE]
> Both billing models can be used on the Dynamics 365 environment. Prepaid capacity is consumed first.
> Message capacity on the Power Platform environment is consumed by Dynamics 365 environments and other Microsoft services on the tenant.

#### Set up prepaid capacity

Complete these tasks to set up the Dynamics 365 environment for prepaid capacity.

1. Purchase a Copilot message pack subscription using the Microsoft 365 admin center.

   Learn more in [Manage self-service purchases and trials (for users)](/microsoft-365/commerce/subscriptions/manage-self-service-purchases-users) or [Manage self-service purchases and trials (for admins)](/microsoft-365/commerce/subscriptions/manage-self-service-purchases-admins).

1. Assign prepaid capacity to the Power Platform environment using the Power Platform admin center.

   Learn more in [Manage Capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new#manage-capacity).

#### Set up pay-as-you-go

Complete these tasks to set up the Dynamics 365 environment for pay-as-you-go.

1. Set up pay-as-you-go on the Power Platform tenant:

   To set up pay-as-you-go billing, you first need an active Azure subscription. Then, you link the subscription to your Power Platform environment using the [Power Platform admin center](https://admin.powerplatform.microsoft.com/) or within [Power Apps](https://make.powerapps.com/).

   Learn more in [Set up pay-as-you-go](/power-platform/admin/pay-as-you-go-set-up).

### Manage capacity and usage

You can view Copilot Studio message capacity and usage for prepaid capacity and pay-as-you-go in the Power Platform admin center. Learn more in [Manage Copilot Studio messages and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity).

Dynamics 365 regularly checks the available capacity (quota) of Copilot Studio messages. If your organization's quota is low or depleted, users receive in-app notifications about the status and necessary actions. It's important to take timely action on these notifications by reallocating existing capacity or purchasing more capacity.

- For prepaid capacity, use the Power Platform admin center to allocate more capacity to the environment from the total available on the tenant. Learn more in [Manage capacity](/power-platform/admin/manage-copilot-studio-messages-capacity#manage-capacity). If there's no quantity to allocate, purchase more.
- For pay-as-you-go, use Microsoft Cost Management in the Azure portal to view detailed usage and adjust spending limits (budgets) to free up more capacity. Learn more in [View usage and billing information](/power-platform/admin/pay-as-you-go-usage-costs). If there's no quantity to allocate, purchase more.

> [!IMPORTANT]
> When the quota is depleted, the AI capability is unavailable until more capacity is added.

## Enable the Scheduling Operations Agent

1. Open the Field Service app.
1. Change to the **Resources** area and go to **Scheduling Parameters** > **Resource Scheduling**.
1. Go to the **Agents** tab and turn on **Scheduling Operations Agent (Preview)**.

:::image type="content" source="media/soa-enable-agent.png" alt-text="Screenshot of the resource scheduling settings that enables the agent.":::

## Set properties for bookable resources

Bookable resources that the agent supports must be of type *User*, *Contact*, or *Crew*. Ensure the following properties are set:

- **Start Location** and **End Location** specified to a value other than *Location Agnostic*
- **Display on Schedule Board** set to *Yes*

:::image type="content" source="media/soa-resource-configuration.png" alt-text="Screenshot of a configured bookable resource record.":::

## Create or update optimization method for booking status

The agent needs to know if it can move or delete scheduled or committed bookable resource bookings in favor of unfulfilled requirements that better match the optimization goals. We introduced a new property for booking statuses called **Optimization Method**.

1. Open the Field Service app and go to the **Resources** area.
1. Select **Booking Settings** > **Booking Statuses**. To see all statuses, remove all filters from the view.
1. Set the **Optimization Method** for each booking status:

    - *Optimize*: Move or delete bookings with these statuses as necessary to generate an optimal schedule. Typically, bookings with these statuses aren't in progress yet. For example: scheduled or committed.
    - *Do Not Move*: Preserve the start time of any bookings with these statuses so the agent doesn't change them. This status is the default option for all statuses. For such bookings, the agent only updates the travel if a previous booking is moved or changed.
    - *Ignore*: Indicate to the agent that it should override any bookings with these statues. It can move or create new bookings on top.

:::image type="content" source="media/soa-booking-status.png" alt-text="Screenshot of a booking status record with a configured optimization method.":::

> [!TIP]
> In addition to the default booking statuses, we recommend that you create a new booking status, such as Locked, with **Optimization Method** set to *Do Not Move*. Dispatchers can use that booking status to selectively indicate which bookings to preserve when the agent runs. Also, if you don't adjust the **Optimization Method** for **Committed** or **Scheduled** statuses, then the agent has little flexibility in making changes to an existing schedule.

## Create or update priority values

To help the agent decide which bookings or resource requirements are more important than others, we added the **Priority Value** field to existing priorities. It accepts numbers between 1 and 100. The agent ignores the **Level of Importance** field. The higher the number, the higher the priority.

:::image type="content" source="media/soa-priority-value.png" alt-text="Screenshot of a priority record with a numeric priority value.":::

1. Open the Field Service app.
2. Change to the **Settings** area and select **Priorities**.
3. Create new **Priority** records or update existing priorities with **Priority Values**.  

> [!TIP]
> We recommend using priority values that are clearly distinguishable. For example, 100 for the highest priority emergency work, 75 for high priority work, 50 for moderate priority, and so on. Avoid using values too close to each other to help the agent effectively distinguish priorities.

## Next step

[Run the Scheduling Operations Agent (preview)](soa-run.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
