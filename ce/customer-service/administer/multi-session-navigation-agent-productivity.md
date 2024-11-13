---
title: "Enable multisession navigation with customized model-driven apps | MicrosoftDocs"
description: "Use the multisession navigation in Customer Service workspace to help agents work on multiple cases and conversations."
ms.date: 11/13/2024
ms.topic: overview
author: neeranelli
ms.author: nenellim

---

# Multisession navigation and productivity tools

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

The multisession navigation feature within the Dynamics 365 Customer Service workspace helps agents with increased productivity with a browser-like, tabbed experience. Agents can use an existing customized model-driven application to work on multiple cases and conversations. It's a modern, customizable, high-productivity app that allows agents to work on multiple sessions at a time in a single workspace.

This application uses artificial intelligence in productivity tools like Co-pilot to boost productivity. Features such as agent scripts and macros provide the agents with guidance and resources to automate repetitive tasks to achieve a great customer experience.

## Prerequisites

To configure the multisession navigation feature within your Dynamics 365 Customer Service workspace, make sure that the following prerequisites are met.

| **Area** | **Requirements** |
|----------|------------------|
| Licensing | An active subscription to Microsoft Dynamics 365 Customer Service Enterprise in your tenant for each user. |
| Web Browsers | <ul><li>Microsoft Edge is recommended; version 110.0.0000.00 or later</li><li>Google Chrome (latest)</li></ul> |
| Hardware | <ul><li>RAM: A minimum of 4 GB</li><li>Latency: Not more than 150 milliseconds</li><li>Throughput: A minimum of 4 Mbps</li></ul> |
| Permission | A system administrator role or equivalent to modify the custom model driven app. |
| Model-driven app | A customized model-driven app |

Learn more about Customer Service workspace system requirements at [System requirements for Customer Service workspace](../implement/customer-service-workspace-system-requirements.md).

> [!NOTE]
> The same considerations and limitations with Customer Service workspace applies to a customized multisession app. Learn more about the Customer Service workspace at [Get started with Customer Service workspace](../implement/csw-overview.md)

## Enable multisession navigation

Perform the following steps to enable the multisession navigation feature in the Customer Service workspace.

1. In the site map of Customer Service admin center, go to **Workspaces**. 

2. Select **Manage** in **Productivity settings for model-driven apps**.

3. Select the custom model-driven app you want to use and select **Edit**.

:::image type="content" source="../media/custom-model-driven-app.png" alt-text="Select your custom model-driven app in Workspaces":::

> [!NOTE]
> A model driven app with the lock icon indicates that it is part of a managed solution and cannot be edited.

4. Select both **Productivity tools** and **Multisession navigation** features, and then select **Save**.

5. A popup screen appears. Review the custom support app information and select **Confirm**.

You can now validate the features in your custom model-driven app.

### Related information

[Build your first model-driven app ([powerapps-docs/maker/model-driven-apps/build-first-model-driven-app.md](https://github.com/MicrosoftDocs/powerapps-docs/blob/main/powerapps-docs/maker/model-driven-apps/build-first-model-driven-app.md))

