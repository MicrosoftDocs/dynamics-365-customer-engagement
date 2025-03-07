---
title: Migrate from the Omnichannel for Customer Service agent app to Customer Service workspace
description: Learn how to migrate to Dynamics 365 Customer Service workspace from removed or deprecated apps.
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms-service: dynamics-365
ms.topic: how-to
ms.date: 10/29/2024
ms.custom: bap-template
---

# Migrate to Customer Service workspace from deprecated or removed apps

This article contains information about how to migrate to Customer Service workspace from the following two apps:

- [Omnichannel for Customer Service agent-facing app](migrate-to-csw.md#migrate-to-customer-service-workspace-from-the-omnichannel-for-customer-service-agent-facing-app)
- [Customer Service Hub](migrate-to-csw.md#migrate-to-customer-service-workspace-from-customer-service-hub)

## Prerequisites

To make configuration changes to Customer Service workspace, you must have one of the following roles:
- System Administrator
- System Customizer

## Migrate to Customer Service workspace from the Omnichannel for Customer Service agent-facing app

The Omnichannel for Customer Service agent-facing app was deprecated on April 1, 2023. This section walks through the steps on how to migrate from Omnichannel for Customer Service to Customer Service workspace.

### Customize the Customer Service workspace app

The following sections walk through the customizations for the Customer Service workspace app to help you migrate from the Omnichannel for Customer Service agent-facing app.

> [!NOTE]
> If you've customized the Omnichannel for Customer Service app in other ways beyond the customizations discussed in this article, you'll need to manually make those same customizations in Customer Service workspace.

Before you migrate, open the app designer if you want to identify the differences between the Omnichannel for Customer Service and Customer Service workspace apps.
1. Sign in to [Power Apps](https://make.powerapps.com/) and select **Apps** from site map. 
2. Select **Customer Service workspace** and then select **Edit** to open the modern app designer.

The following table lists the components in Omnichannel for Customer Service that need to be configured in Customer Service workspace.

| Category | Component to configure in Customer Service workspace |
| ------------ | ------------- |
|Entities      |<li>Feedback</li> <li>Goal</li><li>Phone to Case Process</li> <li>Social activity</li>|
|Views         |<li>Views from the four entities (Feeback, Goal, Phone to Case Process, and Social activity)</li> <li>Omnichannel for Customer Service has all the views selected but Customer Service workspace has selected views only. Include all the views from Account, Case, and Contact entity in the Customer Service workspace app.</li>|
|Forms         |<li>Forms from the four entities (Feeback, Goal, Phone to Case Process, and Social activity)</li><li>Account - Account for Interactive experience (default), TimelineWallControl - Case - Main </li><li> Case: Case for Interactive experience (default), TimelineWallControl - Case - Main</li><li>Contact - Contact for Interactive experience</li>|
|Dashboards    |<li>Omnichannel Agent dashboard</li><li>Omnichannel Ongoing Conversations dashboard</li>|
|Business Process Flow   |<li>Phone to Case Process</li><li>Users</li>   |
|Site map       |<li>Routing diagnostics</li> |

### Add pages in Customer Service workspace

Perform the steps in [Add pages to your app](/power-apps/maker/model-driven-apps/create-a-model-driven-app#add-pages-to-your-app) to add pages in Customer Service workspace.

>[!NOTE]  
> Select **Show in navigation** if you want the selected table to appear on the site map.

### Set a form as the default form

You can set a form as the default form using the form order configuration or when a user sets the default form as a personalization setting. The default form order is set at in the table instead of the app. Therefore, there can be one form order per table.

Perform the steps in [Set the form order](/power-apps/maker/model-driven-apps/assign-form-order#set-the-form-order) to set a form as the default form.

### Add or remove entities in the Customer Service workspace site map

1. In [Power Apps](https://make.powerapps.com/), open the Customer Service workspace app menu, and select **Edit** to open the modern app designer.
1. Under **Pages**, you see the following sections:
   - **Navigation** has the entities, which appear on the site map of Customer Service workspace.    Hover over the entity you want to remove, select ellipsis (...), and then select **Remove from navigation**.
   - **All other pages** has the entities, which are available in the app but don't appear on the site map of Customer Service workspace. Hover over the entity you want to add, select ellipsis (...), and then select **Add to navigation**.
1. Select **Save and Publish**.

### Add or remove the dashboard in Customer Service workspace

1. In [Power Apps](https://make.powerapps.com/), open the Customer Service workspace app menu, and select **Edit** to open the modern app designer.
1. From **Pages**, select **New**.
1. Select **Dashboard**, and then select **Next**.
1. Compare the components with the Omnichannel for Customer Service site map, and add or remove components as needed.
1. Select **Show in navigation** if you want the selected table to appear on the site map.
1. Select **Save and Publish**.

### Customize the environment in Customer Service workspace

1. To customize the environment, perform the steps in [Add an app to a solution](/power-apps/maker/model-driven-apps/distribute-model-driven-app#add-an-app-to-a-solution).
1. Publish the customization and export the solution.

### Add the Phone to Case business process flow in Customer Service workspace

1. Sign in to [Power Apps](https://make.powerapps.com/).
1. Select **Solutions** in the site map, and then open the solution that contains the existing model-driven app for Customer Service workspace.
1. Select the Customer Service workspace menu, and then select **Edit** to open the modern app designer.
1. Complete the steps in [Add or edit model-driven app components in the Power Apps app designer](/power-apps/maker/model-driven-apps/add-edit-app-components) to add the **Phone to Case Process** flow.
1. Compare the components with the Customer Service workspace app site map, and add or remove components as needed.
1. Select **Save and Publish**.

## Migrate to Customer Service workspace from Customer Service Hub

As of February 2025, the Customer Service Hub won't be available for new organizations with Enterprise licenses. We continue to support the application for all existing organizations and for new customers with license types other than Enterprise (for example, Customer Service Professional licenses).

### Customize the Customer Service workspace app

The following sections walk through the customizations for the Customer Service workspace app to help you migrate from Customer Service Hub.

  > [!NOTE]
  > If you customized the Customer Service Hub app in other ways beyond the customizations discussed in this article, you need to manually make those same customizations in Customer Service workspace.

Before you migrate, open the app designer if you want to identify the differences between the Customer Service Hub and Customer Service workspace apps.

1.	Sign in to [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), and then select **Apps** from site map.
1.	Select **Customer Service workspace**, and then select **Edit** to open the modern app designer.

The following table lists the components in Customer Service Hub that you need to configure in Customer Service workspace.

| Category | Component to configure in Customer Service workspace |
|----------|-------------------------------------|
| Dashboards | 1. Select **New** > **Dashboard**, and then select **Next**.<br> 2. Select the missing dashboard you want to include in the Customer Service workspace app. |
| Views | 1. Select the table with missing views on the left side. For example, **Accounts view**. <br> 2. On the right side, select the views that aren't in the app yet, and then select **Add** to include them in the Customer Service workspace app. |
| Forms | 1. Select the table with missing forms on the left side. For example, **Cases form**.<br> 2. On the right side, select the forms that aren't in the app yet, and then select **Add** to include them in the Customer Service workspace app. |
| Business Process Flow | 1. In the left sidebar, select **Automation**.<br> 2. Select the business process flows that aren't in the app, and then select **Add** to include them in the Customer Service workspace app sitemap. |
| Links | 1. Select **New** > **URL**, and then select **Next**.<br> 2. Add the links you want to include in the Customer Service workspace app sitemap. |

### Add pages in Customer Service workspace

To add pages in Customer Service workspace, complete the steps in [Add pages to your app](/power-apps/maker/model-driven-apps/create-a-model-driven-app#add-pages-to-your-app).

> [!NOTE]
> Select **Show in navigation** if you want the selected table to appear on the site map.

### Set a form as the default form

You can set a form as the default form using the form order configuration or when a user sets the default form as a personalization setting. The default form order is set in the table instead of the app. Therefore, there can be one form order per table.

To set a form as a default form, complete the steps in [Set the form order](/power-apps/maker/model-driven-apps/assign-form-order#set-the-form-order).

### Add or remove entities in the Customer Service workspace site map

1. In [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), open the Customer Service workspace app menu, and then select **Edit** to open the modern app designer.
1. In **Pages**, the following sections display:

   - **Navigation**: This section has the entities that appear on the site map of Customer Service workspace. Hover on the entity you wan to remove, select the ellipsis, and then select **Remove from navigation**.
   - **All other pages**: This section has the entities that are available in the Customer Service workspace app but don't appear on the site map. Hover on the entity you want to add, select the ellipsis next to it, and then select **Add to navigation**.
     
1. Select **Save and Publish.**

> [!NOTE]
> While Microsoft xRM framework APIs are available, they now follow the pattern of multisession. You might want to revisit these customizations. For more information, refer to [Overview of the Customer Service workspace application for Dynamics 365 Customer Service](../implement/csw-overview.md)

### Add or remove the dashboard in Customer Service workspace

1. In [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), open the Customer Service workspace app menu, and then select **Edit** to open the modern app designer.
1. In **Pages**, select **New**.
1. Select **Dashboard**, and then select **Next**.
1. Compare the components with the Customer Service Hub site map, and then add or remove components as needed.
1. Select **Show in navigation** if you want the selected table to appear on the site map.
1. Select **Save and Publish**.

### Customize the environment in Customer Service workspace

1. To customize the environment, perform the steps in [Add an app to a solution](/power-apps/maker/model-driven-apps/distribute-model-driven-app#add-an-app-to-a-solution).
1. Publish the customization and export the solution.


### Related information

[Omnichannel for Customer Service app deprecation and migration FAQ](migrate-oc-faq.md)<br>
[Customer Service Hub app removal and migration FAQ](faq-csh-removal.md)<br>
[Get started with Customer Service workspace](../implement/csw-overview.md)<br>
[Overview of the productivity pane](../use/csw-productivity-pane.md)
