---
title: Enable Service Agent in Microsoft 365 Copilot (preview)
description: Learn how to enable Service Agent in Microsoft 365 Copilot for Dynamics 365 Customer Service so customer service representatives can use Copilot to get responses on case and customer records without manually searching for information.
ms.date: 04/07/2026
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
---

# Enable Service Agent in Microsoft 365 Copilot (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Service Agent extends Microsoft 365 Copilot with customer service-specific capabilities. It enables Microsoft 365 Copilot to retrieve and reason over customer service data, such as cases, customer records, and recent interactions, when customer service representatives (service representatives, representatives) ask Copilot questions or request assistance.
  
When you enable Service Agent, service representatives can use Copilot to get responses based on relevant service information—such as cases or customer records—without manually searching for the data.
  
Representatives can also access Service Agent directly in the Copilot Service workspace app while working on customer interactions to retrieve relevant service information in-context.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Service Agent language availability

Service Agent is currently supported in English only. Other languages might appear in the interface but aren’t supported.

## Enable Service Agent

To enable Service Agent in Dynamics 365 Customer Service, a Microsoft 365 administrator must install the Service app in Microsoft 365 Copilot. The Service app integrates with Customer Service and uses AI to help service representatives work more efficiently. Once installed, Service Agent becomes available to representatives through Microsoft 365 Copilot and the Copilot Service workspace app.

### Install Service app

Installing the Service app makes Service Agent capabilities available within Copilot and establishes a connection between Copilot and your Customer Service environment.

**Prerequisites**

Before you install the Service app, make sure the following requirements are met:

- You must be a Microsoft 365 administrator to install the Service app from the [Microsoft 365 admin center](https://admin.microsoft.com/). Learn more in [How do I find my Microsoft 365 admin?](https://support.microsoft.com/en-us/office/how-do-i-find-my-microsoft-365-admin-59b8e361-dbb6-407f-8ac3-a30889e7b99b).
- Admins must assign the Microsoft 365 Copilot license to each user who can use the app. Specific licensing requirements apply when you use Service. Learn more in the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).

To install the Service app, do the following steps:

1. Go to [Microsoft Marketplace](https://marketplace.microsoft.com/product/WA200006602?tab=Overview).
1. Select **Get it now.**
1. Complete the installation wizard.

### Add Microsoft 365 Copilot to Customer Service environment

After the Service app is enabled, the Dynamics 365 organization administrator must add Copilot to the Customer Service environment. Do the steps in [Add Microsoft 365 Copilot for app users in model-driven apps (preview)](/power-apps/maker/model-driven-apps/add-microsoft-365-copilot).

After setup is complete, representatives can ask Microsoft 365 Copilot questions about cases, customers, and interactions, and receive contextual responses powered by Service Agent.

## Known limitations

The following limitations apply in the current preview:

- The app-switcher experience isn't available in Copilot Service workspace.
- If you enabled Service Agent in Customer Service and Microsoft 365 Copilot, two Copilot icons display in the upper-right pane. 

## Related information

[Use Service Agent in Customer Service](../use/use-service-agent.md) 
