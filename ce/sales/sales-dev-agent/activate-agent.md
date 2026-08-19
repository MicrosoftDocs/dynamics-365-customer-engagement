---
title: Activate Sales Development agent
description: Learn how to activate the Sales Development agent in Microsoft 365, which automates outreach and prospect management in Microsoft Teams.
ms.date: 08/19/2026
ms.topic: overview
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Activate Sales Development agent

The Sales Development agent automates outreach and prospect management in Microsoft Teams. It uses AI to help sales teams scale prospecting while still delivering personalized communication.

## Licensing and Frontier prerequisites

Before you can use the Sales Development agent, make sure these prerequisites are met:

- You have the required subscriptions and licenses for Microsoft 365, Microsoft 365 Copilot, and Microsoft Teams.
- Copilot Frontier is enabled in the Microsoft 365 admin center: **Copilot** > **Settings** > **Copilot Frontier**.
- All users who create agent instances are enabled for Frontier features. As an administrator, you can still control which Frontier agents users can access.

## Enable Agent 365 public preview

> [!NOTE]
> You must have the Global Administrator role in Microsoft Entra ID to enable the Agent 365 public preview. 

1. In the Microsoft 365 admin center, go to **Agent** > **Overview** > **Try now**.
1. Purchase the $0 Agent 365 SKU, which includes licenses for 25 agent instances. When prompted, select the **Microsoft 365 Frontier for Autopilots** plan.
1. Go to **Billing** > **Licenses** and verify that 25 licenses are available.

## Activate Sales Development agent

> [!NOTE]
> You must have either the AI Administrator or Global Administrator role in the Microsoft 365 admin center.

1. In the Microsoft 365 admin center, go to **Agents** > **All Agents**.

1. Search for **Sales Development (Frontier)**, and then select **Activate**.

1. Choose the users or groups that can create Sales Development agent instances.

    > [!NOTE]
    > All users can see the Sales Development agent in the Agent Store, but only users with explicit access can activate an instance.

1. Apply a policy template that allows agent instance creation, and then complete the remaining activation steps.

    > [!NOTE]
    > You can use a default template or create a custom template. Microsoft Teams is required for Sales Development agent and must be included in the template, either as a bundled license in the AI Teammate license or as a standalone license (for example, Microsoft Teams EEA).

## Create a Sales Development agent instance for another user

> [!NOTE]
> You must have either the AI Administrator or Global Administrator role in the Microsoft 365 admin center.

1. In the Microsoft 365 admin center, go to **Agents** > **All Agents**.
1. Select **Sales Development (Frontier)**.
1. Select **Add instance**.
1. Create the agent identity by entering a unique name and email alias, and then select the person who will manage this instance.
1. Select **Add instance** to complete setup.

    > [!NOTE]
    > During setup, you might be able to choose a different email domain. After the agent is created, an IT admin can update the username, email alias, and domain in Microsoft Entra or the Microsoft 365 admin center.

    The system then creates a dedicated agent identity and provisions a Teams account, Exchange mailbox, OneDrive, and SharePoint resources. The designated agent manager is notified when the agent is ready to use.

    > [!NOTE]
    > Provisioning typically takes about 5 minutes, but it can take longer.
