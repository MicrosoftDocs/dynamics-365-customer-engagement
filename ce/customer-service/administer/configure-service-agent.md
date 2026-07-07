---
title: Enable Service Agent in Microsoft 365 Copilot
description: Learn how to enable Service Agent in Microsoft 365 Copilot for Dynamics 365 Customer Service so representatives can get responses about cases and customer records without searching manually.
ms.date: 07/07/2026
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
---

# Enable Service Agent in Microsoft 365 Copilot

Service Agent extends Microsoft 365 Copilot with customer service-specific capabilities. It retrieves and reasons over customer service data—such as cases, customer records, and recent interactions—when customer service representatives (representatives) ask questions or request assistance.

After you enable Service Agent, representatives get responses based on relevant service information without manually searching for the data. They can use Service Agent in Microsoft 365 Copilot, and also directly in the Copilot Service workspace app to retrieve service information in-context while working on customer interactions.

> [!IMPORTANT]
> When you connect to other services, you might incur costs and data might be sent outside the Dynamics 365 compliance boundary and processed according to the applicable service terms and data handling policies. It's your responsibility to manage whether your data flows outside of your organization’s compliance and geographic boundaries and any related implications.

## Enable Service Agent

Enabling Service Agent requires actions from both a Microsoft 365 administrator and a Dynamics 365 administrator:

- A Microsoft 365 administrator installs the Service app in Microsoft 365 Copilot.
- A Dynamics 365 administrator adds Microsoft 365 Copilot to the Customer Service environment.

The Service app integrates with Customer Service and uses AI to help representatives work more efficiently.

### Install Service app

Installing the Service app connects Service Agent to your Customer Service environment and makes its capabilities available in Copilot.

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

After the Service app is enabled, the Dynamics 365 organization administrator must add Copilot to the Customer Service environment. Complete the steps in [Add Microsoft 365 Copilot for app users in model-driven apps](/power-apps/maker/model-driven-apps/add-microsoft-365-copilot).

After setup is complete, representatives can ask Microsoft 365 Copilot questions about cases, customers, and interactions, and receive contextual responses powered by Service Agent.

## Related information

[Use Service Agent in Customer Service](../use/use-service-agent.md)
