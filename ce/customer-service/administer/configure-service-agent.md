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
  
After you enable Service Agent, service representatives can use Copilot to get responses based on relevant service information—such as cases or customer records—without manually searching for the data.
  
Representatives can also access Service Agent directly in the Copilot Service workspace app while working on customer interactions to retrieve relevant service information in-context.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Service Agent language availability

Service Agent is supported in English. Other languages are available but aren't currently supported.

## Enable Service Agent

To enable Service Agent in Customer Service, a Microsoft 365 administrator must first install the Service app in Microsoft 365 Copilot. Service is an app that integrates with Dynamics 365 Customer Service and uses AI to help service representatives work more efficiently. Service integrates with Customer Service and makes Service Agent available to service representatives through Microsoft 365 Copilot and Copilot Service workspace.

### Install Service app

**Prerequisites**

Before you install the Service app, make sure the following requirements are met:

- You must be a Microsoft 365 administrator to install the Service app from the [Microsoft 365 admin center](https://admin.microsoft.com/). Learn more in [How do I find my Microsoft 365 admin?](https://support.microsoft.com/en-us/office/how-do-i-find-my-microsoft-365-admin-59b8e361-dbb6-407f-8ac3-a30889e7b99b).
- Admins must assign the Microsoft 365 Copilot license to each user who can use the app. Specific licensing requirements apply when you use Service. Learn more in the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).

You can install Service in Microsoft 365 Copilot from [Microsoft Marketplace](https://marketplace.microsoft.com/product/WA200006602?tab=Overview).

### Add Microsoft 365 Copilot to Dynamics 365 environment

After the Service app is enabled, the Dynamics 365 organization administrator must add the Microsoft 365 Copilot app to the Dynamics 365 environment. Do the steps in [Add Microsoft 365 Copilot for app users in model-driven apps (preview)](/power-apps/maker/model-driven-apps/add-microsoft-365-copilot).

After these steps are completed, service representatives can use Service Agent in:

- Microsoft 365 Copilot chat
- Copilot Service workspace

## Known limitations

- The app switcher experience doesn't work in Copilot Service workspace.
- If you have both Copilots enabled, two Copilot icons display in the command bar. 

## Related information

[Use Service Agent in Customer Service](../use/use-service-agent.md) 
