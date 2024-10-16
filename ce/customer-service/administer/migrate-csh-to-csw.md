---
title: Migrate from Customer Service Hub to Customer Service workspace
description: Learn how to migrate from Dynamics 365 Customer Service Hub to Customer Service workspace.
ms.date: 10/15/2024
ms.topic: how-to
author: lalexms
ms.author: laalexan
search.audienceType: 
  - admin
ms.custom: 
  - dyn365-admin
  - bap-template
---

# Migrate from Customer Service Hub to Customer Service workspace

This article contains configuration information for migrating from the Customer Service Hub app to Customer Service workspace. As of February 2025, the Customer Service Hub won't be available for new organizations with Enterprise licenses. We continue to support the application for all existing organizations and for new customers with license types other than Enterprise (for example, Customer Service Professional licenses).

## Prerequisites

To make configuration changes to Customer Service workspace, you must have one of the following roles:

- System Administrator
- System Customizer

## Customize the Customer Service workspace app

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

## Add pages in Customer Service workspace

To add pages in Customer Service workspace, complete the steps in [Add pages to your app](/power-apps/maker/model-driven-apps/create-a-model-driven-app#add-pages-to-your-app).

> [!NOTE]
> Select **Show in navigation** if you want the selected table to appear on the site map.

## Set a form as the default form

You can set a form as the default form using the form order configuration or when a user sets the default form as a personalization setting. The default form order is set in the table instead of the app. Therefore, there can be one form order per table.

To set a form as a default form, complete the steps in [Set the form order](/power-apps/maker/model-driven-apps/assign-form-order#set-the-form-order).

## Add or remove entities in the Customer Service workspace site map

1. In [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), open the Customer Service workspace app menu, and then select **Edit** to open the modern app designer.
1. In **Pages**, the following sections display:

   - **Navigation**: This section has the entities that appear on the site map of Customer Service workspace. Hover on the entity you wan to remove, select the ellipsis, and then select **Remove from navigation**.
   - **All other pages**: This section has the entities that are available in the Customer Service workspace app but don't appear on the site map. Hover on the entity you want to add, select the ellipsis next to it, and then select **Add to navigation**.
     
1. Select **Save and Publish.**

> [!NOTE]
> While Microsoft xRM framework APIs are available, they now follow the pattern of multisession. You might want to revisit these customizations. For more information, refer to [Overview of the Customer Service workspace application for Dynamics 365 Customer Service](../implement/csw-overview.md)

## Add or remove the dashboard in Customer Service workspace

1. In [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), open the Customer Service workspace app menu, and then select **Edit** to open the modern app designer.
1. In **Pages**, select **New**.
1. Select **Dashboard**, and then select **Next**.
1. Compare the components with the Customer Service Hub site map, and then add or remove components as needed.
1. Select **Show in navigation** if you want the selected table to appear on the site map.
1. Select **Save and Publish**.

## Customize the environment in Customer Service workspace

1. To customize the environment, perform the steps in [Add an app to a solution](/power-apps/maker/model-driven-apps/distribute-model-driven-app#add-an-app-to-a-solution).
1. Publish the customization and export the solution.

### Related information
[Customer Service Hub app removal and migration FAQ](faq-csh-removal.md)  
[Get started with Customer Service workspace](../implement/csw-overview.md)  
[Overview of the productivity pane](../use/csw-productivity-pane.md)
