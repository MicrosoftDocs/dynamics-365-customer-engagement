---
title: Set up the Scheduling Operations Agent (preview)
description: Learn how to set up the Scheduling Operations Agent in Dynamics 365 Field Service for your dispatchers.
ms.date: 03/26/2025
ms.topic: how-to
ms.author: anilmur
author: anilmur
---

# Set up the Scheduling Operations Agent (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The Scheduling Operations Agent is an autonomous agent for Dynamics 365 Field Service that considers existing bookings and requirements when a dispatcher adjusts a technician's schedule. Before dispatchers can use the agent, an administrator must set it up in your environment.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

- Your environment is updated to Field Service version 8.8.133.214 or newer and Universal Resource Scheduling version 3.12.149.15 or newer.
- [Location and map settings](field-service-maps-address-locations.md) are turned on for your environment.
- You have an administrator role in the Dynamics 365 Field Service app.

## Set up the billing model

Scheduling Operations Agent and other Copilot and agent capabilities in Dynamics 365 use Microsoft Copilot Studio messages for AI interactions and tasks like retrieving information and responding to prompts. The number of messages per event depends on the event's complexity. Learn more in [Message scenarios](/microsoft-copilot-studio/requirements-messages-management#message-scenarios).  

These capabilities use consumption-based billing, charging per use, and messages are the billing units that measure usage. Learn more about billing and rates in [Power Platform Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=2085130).

Dynamics 365 supports two billing models: prepaid capacity and pay-as-you-go. The prepaid capacity model uses Copilot Studio message pack subscriptions, which are a licensing option for Microsoft Copilot Studio that you purchase in advance. The pay-as-you-go model charges for the actual number of messages that agents consume during the month. Learn more in [Copilot licensing](/microsoft-copilot-studio/billing-licensing).

You can use both billing models in the same environment. Prepaid capacity is consumed first. Both models require that you link your Dynamics 365 environment to a Power Platform environment.

### Set up prepaid capacity billing

1. In the Microsoft 365 admin center, purchase a Copilot message pack subscription. Learn more in [Manage self-service purchases and trials (for users)](/microsoft-365/commerce/subscriptions/manage-self-service-purchases-users) or [Manage self-service purchases and trials (for admins)](/microsoft-365/commerce/subscriptions/manage-self-service-purchases-admins).

1. In the Power Platform admin center, assign prepaid capacity to the Power Platform environment. Learn more in [Manage capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new#manage-capacity).

### Set up pay-as-you-go billing

To set up pay-as-you-go billing, you first need an active Azure subscription. Then you link the subscription to your Power Platform environment using the [Power Platform admin center](https://admin.powerplatform.microsoft.com/) or in [Power Apps](https://make.powerapps.com/). Learn more in [Set up pay-as-you-go](/power-platform/admin/pay-as-you-go-set-up).

### Manage capacity and usage

You can view Copilot Studio message capacity and usage for both prepaid capacity and pay-as-you-go billing in the Power Platform admin center. Learn more in [Manage Copilot Studio messages and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity).

Dynamics 365 regularly checks the available capacity, or quota, of Copilot Studio messages. If your organization's quota is low or depleted, users receive in-app notifications about the capacity status and necessary actions. It's important to take timely action on these notifications and either reallocate existing capacity or purchase more.

- For prepaid capacity, use the Power Platform admin center to allocate more capacity to the environment from the total available on the tenant. If no capacity is available, purchase more. Learn more in [Manage capacity](/power-platform/admin/manage-copilot-studio-messages-capacity#manage-capacity).

- For pay-as-you-go, use Microsoft Cost Management in the Azure portal to view detailed usage and adjust spending limits, or budgets, to free up more capacity. If no capacity is available, purchase more. Learn more in [View usage and billing information](/power-platform/admin/pay-as-you-go-usage-costs).

> [!IMPORTANT]
> When the quota is depleted, AI capabilities are unavailable until more capacity is added. Tenant admins can [review the message consumption of agents](/microsoft-copilot-studio/requirements-messages-management#view-message-consumption) in the Power Platform admin center. Learn more in [Message scenarios](/microsoft-copilot-studio/requirements-messages-management#message-scenarios).

## Turn on the Scheduling Operations Agent

1. Open the Field Service app.
1. Change to the **Resources** area and go to **Scheduling Parameters** > **Resource Scheduling**.
1. Go to the **Agents** tab and turn on **Scheduling Operations Agent (Preview)**.

:::image type="content" source="media/soa-enable-agent.png" alt-text="Screenshot of the Scheduling Operations Agent toggle in Dynamics 365 Field Service Resource Scheduling settings.":::

## Set properties for bookable resources

Bookable resources that the agent supports must be of type *User*, *Contact*, or *Crew*. Set the following properties for each bookable resource that you want the agent to consider:

- **Start Location** and **End Location** must be a value other than **Location Agnostic**.
- **Display on schedule board** must be **Yes**.

:::image type="content" source="media/soa-resource-configuration.png" alt-text="Screenshot of a configured bookable resource record in Dynamics 365 Field Service.":::

## Select an optimization method for booking statuses

**Optimization Method** is a new property of booking statuses that tells the agent whether it can move or delete scheduled or committed bookings in favor of unfulfilled requirements that better match the optimization goals.

1. Open the Field Service app and go to the **Resources** area.

1. Select **Booking Settings** > **Booking Statuses**. To show all statuses, remove all filters from the view.

1. For each booking status, set the **Optimization Method** property to one of the following values:

    - **Optimize**: The agent may move or delete bookings with this status to generate an optimal schedule. This method is typically used for bookings that aren't in progress yet; for example, statuses of *Scheduled* or *Committed*.

    - **Do Not Move**: The agent must preserve the estimated arrival time of bookings with this status. It only updates the travel time if a previous booking is moved or changed. That's typically the case when a technician is already traveling to a booking or has started or completed the work. You can also use this optimization method in situations where a specific arrival time was committed to a customer. *Do Not Move* is the default behavior if **Optimization Method** isn't set.

    - **Ignore**: The agent may override bookings with this status and move or create new bookings on top of them. This method is typically used for bookings with a status of *Canceled*.

    :::image type="content" source="media/soa-booking-status.png" alt-text="Screenshot of a booking status record with a configured optimization method in Dynamics 365 Field Service booking statuses settings.":::

> [!TIP]
> In addition to using the default booking statuses, we recommend that you create a booking status such as *Locked* with **Optimization Method** set to *Do Not Move*. Dispatchers can use that booking status to selectively indicate which bookings to preserve when the agent runs.
>
> If you don't set the **Optimization Method** for *Committed* or *Scheduled* statuses, then the agent has little flexibility in making changes to a schedule.

## Set priority values

**Priority Value** is a new property of priorities that helps the agent decide which bookings or resource requirements are more important than others. It accepts numbers between 1 and 100. The higher the number, the higher the priority. For example, a high-priority booking with a **Priority Value** of 75 takes precedence over a high-priority booking with a **Priority Value** of 50. The agent ignores the **Level of Importance** field.

1. Open the Field Service app and go to the **Settings** area.
2. Select **Priorities**.
3. For each priority that you want the agent to consider, set a **Priority Value**.  

    :::image type="content" source="media/soa-priority-value.png" alt-text="Screenshot of a priority record with a configured priority value in Dynamics 365 Field Service priorities settings.":::

> [!TIP]
> We recommend setting priority values that are clearly distinguishable, such as 100 for the highest-priority emergency work, 75 for high-priority work, 50 for moderate-priority work, and so on. The agent might not effectively distinguish values that are too close to each other.

## Next step

[Run the Scheduling Operations Agent (preview)](soa-run.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
