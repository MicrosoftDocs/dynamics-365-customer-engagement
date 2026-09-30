---
title: Enable Service Agent in Microsoft Copilot
description: Learn how to enable Service Agent in Microsoft Copilot for Dynamics 365 Customer Service so representatives can get responses about cases and customer records without searching manually.
ms.date: 09/30/2026
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
---

# Enable Service Agent in Microsoft Copilot

Service Agent extends Microsoft Copilot with customer service-specific capabilities. It retrieves, summarizes, and works with customer service information, such as cases, customer records, and recent interactions, when customer service representatives (representatives) ask questions or request assistance.

After you enable Service Agent, representatives can use Microsoft Copilot to access relevant customer service information without manually searching for the data. They can also use Service Agent in Copilot Service workspace to access service information while working on customer interactions.

## What gets enabled

Service Agent integrates Microsoft Copilot with Dynamics 365 Customer Service. After you enable Service Agent, representatives can use Microsoft Copilot and Copilot Service workspace to access relevant customer service information.

> [!IMPORTANT]
> When you connect to other services, you might incur costs and data might be sent outside the Dynamics 365 compliance boundary and processed according to the applicable service terms and data handling policies. It's your responsibility to manage whether your data flows outside of your organization’s compliance and geographic boundaries and any related implications.

## Enable Service Agent

A Microsoft 365 administrator manages installation and assignment of the Service app. A Dynamics 365 administrator adds Microsoft Copilot to the Customer Service environment for the in-app experience. These are separate tasks: installing the Service app doesn't configure the environment or grant users access to Customer Service records.

The Service app integrates with Customer Service and uses AI to help representatives work more efficiently.

> [!NOTE]
> After installation, you can configure the tools that representatives can use. Tool availability can depend on the Service Agent configuration and the Dataverse security privileges assigned to representatives. You can also extend Service Agent with Microsoft Copilot Studio agents and Model Context Protocol (MCP) tools, where supported.

### Install Service app

Before you install the Service app, check whether it is already installed and assigned to the intended users. The app is automatically installed if a license for Customer Service is assigned in your tenant. For installation requirements, administrator role assignment, deployment, availability, and removal, see [Manage the Service app in the Microsoft 365 admin center](../use/manage-service-app.md).

Add Microsoft Copilot to the Customer Service environment for the in-app experience. Complete the steps in [Add Microsoft Copilot for app users in model-driven apps](/power-apps/maker/model-driven-apps/add-microsoft-365-copilot).

After setup is complete, representatives can ask Microsoft Copilot questions about cases, customers, and interactions, and receive contextual responses powered by Service Agent.

## Related information

[Use Service Agent in Customer Service](../use/use-service-agent.md)  
