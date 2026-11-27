---
title: Manage consumption-based billing and capacity
description: Learn how to set up and manage consumption-based billing for AI-driven capabilities in Dynamics 365.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 11/26/2026
ms.custom: bap-template
ai-usage: ai-assisted
---

# Manage consumption-based billing and capacity

Set up consumption-based billing and manage capacity and usage for Copilot and agent capabilities in Dynamics 365.

## Set up consumption-based billing

Selected Copilot and agent capabilities in Dynamics 365 use consumption-based billing, which charges per use. These capabilities use Copilot Credits for AI interactions and tasks, such as retrieving information and responding to prompts. Messages are the billing units that measure usage. The number of messages per event depends on its complexity. Learn more in [Message scenarios](/microsoft-copilot-studio/requirements-messages-management#message-scenarios).

Learn more about billing and rates in [Power Platform Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=2085130).

### Set up billing model

Dynamics 365 supports two billing models: prepaid capacity and pay-as-you-go. For prepaid capacity, you purchase Copilot Studio message pack subscriptions in advance. Pay-as-you-go charges for the number of messages agents consume during the month. Learn more in [Copilot Studio licensing](/microsoft-copilot-studio/billing-licensing).

Both models require that you link your Dynamics 365 environment to a Power Platform environment.

> [!NOTE]
> You can use both billing models in the same Dynamics 365 environment. Prepaid capacity is consumed first.
> Dynamics 365 environments and other Microsoft services in the tenant consume message capacity from the Power Platform environment.

### Set up prepaid capacity

Complete these tasks to set up prepaid capacity for your Dynamics 365 environment:

1. Purchase a Copilot message pack subscription using the Microsoft 365 admin center.
1. Assign prepaid capacity to the Power Platform environment using the Power Platform admin center.

   Learn more in [Manage capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new#manage-capacity).


### Set up pay-as-you-go

To set up pay-as-you-go billing, you need an active Azure subscription. Link the subscription to your Power Platform environment in the [Power Platform admin center](https://admin.powerplatform.microsoft.com/) or [Power Apps](https://make.powerapps.com/).

Learn more in [Set up pay-as-you-go](/power-platform/admin/pay-as-you-go-set-up).

## Manage capacity and usage

You can view Copilot Studio message capacity and usage for prepaid capacity and pay-as-you-go in the Power Platform admin center. Learn more in [Manage Copilot Credits and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity).

Dynamics 365 regularly checks your available Copilot Credits capacity (quota). If your organization's quota is low or depleted, users receive in-app notifications with the status and required actions. Respond to these notifications by reallocating existing capacity or purchasing more capacity.

- For prepaid capacity, use the Power Platform admin center to allocate more of the tenant's available capacity to the environment. Learn more in [Manage capacity](/power-platform/admin/manage-copilot-studio-messages-capacity#manage-capacity). If no capacity is available to allocate, purchase more.
- For pay-as-you-go, use Microsoft Cost Management in the Azure portal to view detailed usage and adjust spending limits (budgets) to free up more capacity. Learn more in [View usage and billing information](/power-platform/admin/pay-as-you-go-usage-costs). If there's no quantity to allocate, purchase more.

> [!IMPORTANT]
> When the quota is depleted, the AI capability is unavailable until more capacity is added.

## Related information

- [Assign licenses and manage access to Copilot Studio](/microsoft-copilot-studio/requirements-licensing?tabs=web)  
- [Copilot Studio licensing](/microsoft-copilot-studio/billing-licensing)  
- [Control how agents are shared](/microsoft-copilot-studio/admin-sharing-controls-limits)  
- [Orchestrate agent behavior with generative AI](/microsoft-copilot-studio/advanced-generative-actions)  
- [Work with Power Platform environments in Copilot Studio](/microsoft-copilot-studio/environments-first-run-experience)  
- [Pay-as-you-go plan](/power-platform/admin/pay-as-you-go-overview)
