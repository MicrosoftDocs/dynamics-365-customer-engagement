---
title: Control access to Copilot in Dynamics 365 Sales
description: Learn how to control access to Copilot in Dynamics 365 Sales to manage who can use AI features and improve sales productivity.
ms.date: 03/10/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
ms.custom: bap-template
---

# Control access to Copilot in Dynamics 365 Sales

Your organization can control who can use Copilot in Dynamics 365 Sales at the environment, Entra group, and app levels. All these settings are turned on by default. The levels of control are as follows:

1. **Tenant-level control for model-driven apps**: The Power Platform administrator specifies which environments or environment groups can use Copilot chat in model-driven apps. This setting determines the default behavior for all model-driven apps, including Dynamics 365 Sales. Configure this setting in the Power Platform admin center from **Copilot** > **Settings** > **Chat agent in Model-Driven Apps**.


1. **Tenant-level control for Copilot in Dynamics 365 Sales**: The Power Platform administrator specifies which environments or environment groups can use Copilot capabilities in Dynamics 365 Sales. Configure this setting in the Power Platform admin center from **Copilot** > **Settings** > **Dynamics 365 Sales** > **Copilot**.
1. **Entra group-level control**: The Power Platform administrator specifies which Entra groups within the tenant can use Copilot across all model-driven apps. Configure this setting in the Power Platform admin center from **Copilot** > **Settings** > **Control who can use AI features in model-driven apps**. By default, all users in the environment can use Copilot in Dynamics 365 Sales unless restricted by this setting. Ensure that seller users who need access to Copilot in Dynamics 365 Sales are included in the allowed Entra groups.
1. **App-level control**: The administrator of the Sales Hub app specifies whether to enable Copilot in the Dynamics 365 Sales and other sales apps. Configure this setting in the Sales Hub app from **App Settings** > **Copilot**. If the tenant-level controls are turned off, the Copilot settings page is disabled.


## Related information

- [Turn on and set up Copilot in Dynamics 365 Sales](enable-setup-copilot.md)
- 