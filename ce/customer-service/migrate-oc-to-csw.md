---
title: "Omnichannel for Customer Service migration guide | MicrosoftDocs"
description: "Migration guide for Omnichannel for Dynamics 365 Customer Service to Customer Service workspace"
ms.date: 01/11/2023
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.reviewer: nenellim
---

# Migrate from Omnichannel for Customer Service to Customer Service workspace

This article contains configuration information for migrating from the Omnichannel for Customer Service app to the Customer Service Workspace app. If you've configured Omnichannel for Customer Service using Customer Service admin center, most of those configurations apply to both apps. For some components, however, you'll need to manually apply the customizations in Customer Service workspace to be able to use them.

The following table lists the components in Omnichannel for Customer Service that need to be configured in Customer Service workspace.

|Category   |Component to configure in Customer Service workspace |
|---------------|-------------------------------|
|Entities      |<li>Feeback</li> <li>Goal</li><li>Phone to Case Process</li> <li>Social activity</li>|                    |
|Views         |<li>Views from the four missing entities</li> <li>Omnichannel for Customer Service has all of the views selected but Customer Service workspace only has selected views. Include all the views from Account, Case, and Contact entity in the Customer Service workspace app.</li>|
|Forms         |<li>Forms from the four missing entities</li><li>Account - Account for Interactive experience (default), TimelineWallControl - Case - Main </li><li> Case: Case for Interactive experience (default), TimelineWallControl - Case - Main</li><li>Contact - Contact for Interactive experience</li>|                       |
|Dashboards    |<li>Omnichannel Agent dashboard</li><li>Omnichannel Ongoing Conversations dashboard</li>| 
|Business Process Flow   |<li>Phone to Case Process</li><li>Users</li>   |                       |
|Site map       |<li>Routing diagnostic</li> |

## Customize the Customer Service workspace app 

The following sections walk through the customizations for the Customer Service workspace app to help you migrate from Omnichannel for Customer Service.

> [!Note]
> If you've customized Omnichannel for Customer Service in other ways beyond the customizations discussed in this article, you'll need to manually make those same customizations to Customer Service workspace.

### Add entities, forms, views, and chart in Customer Service workspace:

1. Sign in to [Power Apps](https://make.powerapps.com/?cds-app-module-designer.isCustomPageEnabled=true&oneCdsDesigner.enableCustomCanvasPage=true).
1. Select **Solutions** in the site map, and then open the solution that contains the existing model-driven app for Customer Service workspace.
1. Open the Customer Service workspace app menu, and then select **Edit** to open the modern app designer.
1. Turn on the toggles for the following components:
   - **Entity**: Feedback, Goal, Phone to Case Process, Social Activity
   - **Form**: Account for Interactive experience, Case for Interactive experience, TimelineWallControl - Case - Main, Contact for Interactive experience
   - **View**: Turn on the toggle for **Include all views in the app** to include all missing views to include Account, Case, and Contact views in Customer Service workspace.
   :::image type="content" source="media/csw-include-all-views.png" alt-text="Include all views setting for configuring Customer Service workspace.":::
1. Complete the steps in [Add or remove forms, views, or charts](/power-apps/maker/model-driven-apps/create-add-remove-forms-views-dashboards).
1. Select **Publish**. Any other changes that you've made to the Customer Service workspace app are also saved.
1. Select **Play** to run the Customer Service workspace app in a new browser tab.
1. To close the app designer and return to the solution, select **Back**.

### Set a form as the default form

You can set a form as the default form using the form order configuration or when a user sets the default form as a personalization setting. The default form order is set at in the table instead of the app. Therefore, there can be one form order per table.
1. Sign in to [Power Apps](https://make.powerapps.com/?cds-app-module-designer.isCustomPageEnabled=true&oneCdsDesigner.enableCustomCanvasPage=true).
1. Select **Dataverse**, and then go to the required table.
1. Select the **Forms** tab, select the ellipsis (...), and then select **Form settings**. In the Omnichannel for Customer Service app, for the **Account** table, the **Account for Interactive experience** is the default form. In Customer Service workspace, **Account for Multisession experience** is the default form, so you'll need to change it to **Account for Interactive experience**.
  :::image type="content" source="media/table-form-settings.png" alt-text="View of the table form settings.":::
1. In the form settings dialog, select **Form order**, and then in **Choose a form set**, select the form type.
1. Order the table by dragging and dropping the entities. Make sure that **Account for Interactive experience** is listed first.
   :::image type="content" source="media/form-order-for-table.png" alt-text="Set the form order for the table.":::
1. Select **Save and Publish**.

### Add or remove site map entities in Customer Service workspace

1. Sign in to [Power Apps](https://make.powerapps.com/?cds-app-module-designer.isCustomPageEnabled=true&oneCdsDesigner.enableCustomCanvasPage=true).
1. Select **Solutions** in the site map, and then open the solution that contains the existing model-driven app for Customer Service workspace.
1. Select the Customer Service workspace menu, and then select **Edit** to open the modern app designer.
1. Complete the steps in [Open an existing model-driven app using modern app designer](/power-apps/maker/model-driven-apps/add-page-to-model-app#open-an-existing-model-driven-app-using-modern-app-designer) to add the site map entities for **Routing diagnostic** and **Social Profiles**.
1. Compare the entities with the Customer Service workspace app site map, and add or remove components as needed.
1. Select **Save and Publish**.

### Add or remove the dashboard in Customer Service workspace

1. Sign in to [Power Apps](https://make.powerapps.com/?cds-app-module-designer.isCustomPageEnabled=true&oneCdsDesigner.enableCustomCanvasPage=true).
1. Select **Solutions** in the site map, and then open the solution that contains the existing model-driven app for Customer Service workspace.
1. Select the Customer Service workspace menu, and then select **Edit** to open the modern app designer.
1. Complete the steps in [Create or edit a Power BI embedded system dashboard](/power-apps/maker/model-driven-apps/create-edit-powerbi-embedded-page).
1. Compare the components with the Customer Service workspace app site map, and add or remove components as needed.
1. Select **Save and Publish**.

### Add the Phone to Case business process flow in Customer Service workspace
1. Sign in to [Power Apps](https://make.powerapps.com/?cds-app-module-designer.isCustomPageEnabled=true&oneCdsDesigner.enableCustomCanvasPage=true).
1. Select **Solutions** in the site map, and then open the solution that contains the existing model-driven app for Customer Service workspace.
1. Select the Customer Service workspace menu, and then select **Edit** to open the modern app designer.
1. Complete the steps in [Add or edit model-driven app components in the Power Apps app designer](/power-apps/maker/model-driven-apps/add-edit-app-components) to add the **Phone to Case Process** flow.
1. Compare the components with the Customer Service workspace app site map, and add or remove components as needed.
1. Select **Save and Publish**.
