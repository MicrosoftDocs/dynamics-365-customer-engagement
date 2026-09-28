---
title: Enable Service Agent in Microsoft 365 Copilot
description: Learn how to enable Service Agent in Microsoft 365 Copilot for Dynamics 365 Customer Service so representatives can get responses about cases and customer records without searching manually.
ms.date: 09/26/2026
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
---

# Enable Service Agent in Microsoft 365 Copilot

Service Agent extends Microsoft 365 Copilot with customer service-specific capabilities. It can retrieve, summarize, and work with customer service information—such as cases, customer records, and recent interactions—when customer service representatives (representatives) ask questions or request assistance.

After you enable Service Agent, representatives can use Microsoft 365 Copilot to access relevant customer service information without manually searching for the data. They can also use Service Agent in Copilot Service workspace to access service information while working on customer interactions.

## What gets enabled

Service Agent integrates Microsoft 365 Copilot with Dynamics 365 Customer Service. After you enable Service Agent, representatives can use Microsoft 365 Copilot and Copilot Service workspace to access relevant customer service information.

> [!IMPORTANT]
> When you connect to other services, you might incur costs and data might be sent outside the Dynamics 365 compliance boundary and processed according to the applicable service terms and data handling policies. It's your responsibility to manage whether your data flows outside of your organization’s compliance and geographic boundaries and any related implications.

## Enable Service Agent

To make Service Agent available to representatives, a Microsoft 365 administrator installs the Service app, and an administrator who manages the Dynamics 365 Customer Service environment enables Microsoft 365 Copilot for the Customer Service environment or applicable model-driven apps.

The Service app integrates with Customer Service and uses AI to help representatives work more efficiently.

> [!NOTE]
> After installation, you can configure which tools representatives can use. Tool availability can depend on the Service Agent configuration and the Dataverse security privileges assigned to representatives. You can also extend Service Agent with Microsoft Copilot Studio agents and Model Context Protocol (MCP) tools, where supported.

### Install Service app

Installing the Service app makes Service Agent available in Microsoft 365 Copilot. You must also enable Microsoft 365 Copilot for the applicable Customer Service environment or model-driven app.

**Prerequisites**

Before you install the Service app, make sure the following requirements are met:

- You must be a Microsoft 365 administrator to install the Service app from the [Microsoft 365 admin center](https://admin.microsoft.com/). Learn more in [How do I find my Microsoft 365 admin?](https://support.microsoft.com/en-us/office/how-do-i-find-my-microsoft-365-admin-59b8e361-dbb6-407f-8ac3-a30889e7b99b).
- Specific licensing requirements apply when you use Service. Learn more in the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).

To install the Service app, do the following steps:

1. Go to [Microsoft Marketplace](https://marketplace.microsoft.com/product/WA200006602?tab=Overview).
   > [!NOTE]
   > If the Service app doesn't appear, go to [Microsoft Marketplace](https://marketplace.microsoft.com), search for "Service", and then select the Service app from the search results.
1. Select **Get it now**.
1. Complete the installation wizard.

### Add Microsoft 365 Copilot to your Customer Service environment

After the Service app is installed, an administrator who manages the Dynamics 365 Customer Service environment must enable Microsoft 365 Copilot for the environment or applicable model-driven apps. Complete the steps in [Add Microsoft 365 Copilot for app users in model-driven apps](/power-apps/maker/model-driven-apps/add-microsoft-365-copilot).

When setup is complete, representatives can use Microsoft 365 Copilot to ask questions about cases, customers, and interactions. They can access relevant customer service information through Service Agent.

## Related information

[Use Service Agent in Customer Service](../use/use-service-agent.md)
