---
title: Migrate from Omnichannel for Customer Service agent app to Customer Service workspace
description: Migration guide for Omnichannel for Dynamics 365 Customer Service to Customer Service workspace.
author: lalexms
ms.author: laalexan
ms.reviewer: shujoshi
ms-service: dynamics-365
ms.topic: how-to
ms.date: 08/17/2023
ms.custom: bap-template
---

# Migrate from Omnichannel for Customer Service agent app to Customer Service workspace

This article contains configuration information for migrating from the Omnichannel for Customer Service agent-facing app to Customer Service workspace. The Omnichannel for Customer Service agent-facing app was deprecated on April 1, 2023.

## Prerequisites

To make configuration changes to Customer Service workspace, you must have one of the following roles:
- System Administrator
- System Customizer

## Customize the Customer Service workspace app

The following sections walk through the customizations for the Customer Service workspace app to help you migrate from the Omnichannel for Customer Service agent-facing app.

> [!NOTE]
> If you've customized the Omnichannel for Customer Service app in other ways beyond the customizations discussed in this article, you'll need to manually make those same customizations in Customer Service workspace.

Before migration, open the app designer if you want to identify the differences between the Omnichannel for Customer Service and Customer Service workspace apps.
1. Sign in to [Power Apps](https://make.powerapps.com/?cds-app-module-designer.isCustomPageEnabled=true&oneCdsDesigner.enableCustomCanvasPage=true) and select **Apps** from site map. 
2. Select **Customer Service workspace** and then select **Edit** to open the modern app designer.

The following table lists the components in Omnichannel for Customer Service that need to be configured in Customer Service workspace.

| Category | Component to configure in Customer Service workspace |
| ------------ | ------------- |
|Entities      |<li>Feedback</li> <li>Goal</li><li>Phone to Case Process</li> <li>Social activity</li>|
|Views         |<li>Views from the four entities (Feeback, Goal, Phone to Case Process, and Social activity)</li> <li>Omnichannel for Customer Service has all the views selected but Customer Service workspace has selected views only. Include all the views from Account, Case, and Contact entity in the Customer Service workspace app.</li>|
|Forms         |<li>Forms from the four entities ((Feeback, Goal, Phone to Case Process, and Social activity)</li><li>Account - Account for Interactive experience (default), TimelineWallControl - Case - Main </li><li> Case: Case for Interactive experience (default), TimelineWallControl - Case - Main</li><li>Contact - Contact for Interactive experience</li>|
|Dashboards    |<li>Omnichannel Agent dashboard</li><li>Omnichannel Ongoing Conversations dashboard</li>|
|Business Process Flow   |<li>Phone to Case Process</li><li>Users</li>   |
|Site map       |<li>Routing diagnostics</li> |

### Add pages in Customer Service workspace

Perform the steps in [Add pages to your app](/power-apps/maker/model-driven-apps/create-a-model-driven-app#add-pages-to-your-app) to add pages in Customer Service workspace.

>[!NOTE]  
> Select **Show in navigation** if you want the selected table to appear on site map.

### Set a form as the default form

You can set a form as the default form using the form order configuration or when a user sets the default form as a personalization setting. The default form order is set at in the table instead of the app. Therefore, there can be one form order per table.

Perform the steps in [Set the form order](/power-apps/maker/model-driven-apps/assign-form-order#set-the-form-order) to set a form as the default form.

### Add or remove entities in the Customer Service workspace site map

1. In [Power Apps](https://make.powerapps.com/?cds-app-module-designer.isCustomPageEnabled=true&oneCdsDesigner.enableCustomCanvasPage=true), open the Customer Service workspace app menu, and select **Edit** to open the modern app designer.
1. Under **Pages**, you'll see two sections:
   - **Navigation** - It has the entities which appear on the site map of Customer Service workspace.
   Hover over the entity you want to remove, select ellipsis (...), and then select **Remove from navigation**.
   - **All other pages** - It has the entities which are available in the app but don't appear on the site map of Customer Service workspace.
   Hover over the entity you want to add, select ellipsis (...), and then select **Add to navigation**.
1. Select **Save and Publish**.

### Add or remove the dashboard in Customer Service workspace

1. In [Power Apps](https://make.powerapps.com/?cds-app-module-designer.isCustomPageEnabled=true&oneCdsDesigner.enableCustomCanvasPage=true), open the Customer Service workspace app menu, and select **Edit** to open the modern app designer.
1. From **Pages**, select **New** buttton.
1. Select **Dashboard**, and then select **Next**.
1. Compare the components with the Omnichannel for Customer Service site map, and add or remove components as needed.
1. Select **Show in navigation** if you want the selected table to appear on site map.
1. Select **Save and Publish**.

### Customize the environment in Customer Service workspace

1. To customize the environment, perform the steps in [Add an app to a solution](/power-apps/maker/model-driven-apps/distribute-model-driven-app#add-an-app-to-a-solution).
1. Publish the customization and export the solution.

### Add the Phone to Case business process flow in Customer Service workspace

1. Sign in to [Power Apps](https://make.powerapps.com/?cds-app-module-designer.isCustomPageEnabled=true&oneCdsDesigner.enableCustomCanvasPage=true).
1. Select **Solutions** in the site map, and then open the solution that contains the existing model-driven app for Customer Service workspace.
1. Select the Customer Service workspace menu, and then select **Edit** to open the modern app designer.
1. Complete the steps in [Add or edit model-driven app components in the Power Apps app designer](/power-apps/maker/model-driven-apps/add-edit-app-components) to add the **Phone to Case Process** flow.
1. Compare the components with the Customer Service workspace app site map, and add or remove components as needed.
1. Select **Save and Publish**.

### See also

[Omnichannel for Customer Service app deprecation and migration FAQ](migrate-oc-faq.md)<br>
[Get started with Customer Service workspace](csw-overview.md)<br>
[Overview of the productivity pane](csw-productivity-pane.md)
