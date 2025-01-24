---
title: Installation FAQs
description: Get answers to frequently asked questions about installation.
ms.date: 03/15/2024
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Installation FAQs

This article answers frequently asked questions about installation of Dynamics 365 Sales, Sales premium, and Sales professional.

## Why am I unable to install the Sales Professional app in my environment?

Your environment might be one of the following because of which you're unable to install:  

- Has Dataverse only
- Is a default environment
- Dynamics 365 apps are disabled
- Doesn't have a database  

More information: [Create and manage environments in the Power Platform admin center](/power-platform/admin/create-environment#create-an-environment-and-add-model-driven-apps)

## Why am I unable to access the Sales Professional app after installation?

To access the Sales Professional app, make sure that the app is installed properly. More information: [Install the Sales Professional app](provision-sales-professional-instance.md)  

Also, make sure that you're added to the target environment and the Sales Professional app access security role is assigned to you.

## Why can't I see the What's new functionality in Unified Interface?

This is by design. The What's new functionality is only available in the legacy web client. The equivalent in Unified Interface is to insert the Timeline control (with posts enabled) on the dashboard:

1. In the sales app, go to **Settings** > **Advanced Settings**.  
1. Go to **Customization** > **Customizations** > **Customize the System**.  
1. In the left pane, expand **Tables** and then the entity you want, and select **Forms**.  
    >[!NOTE]
    >If you are using the classic view, under **Components**, expand **Entities**, and then the entity you want, and select **Forms**.  

1. Under **Components** in the solution explorer, select **Dashboards**.

1. Select and open the dashboard to which you want to add the Timeline control.

1. On the toolbar at the top of the page, select **Timeline**.

1. Update the **Timeline Control Properties** as required, and then select **OK**.

1. Save the dashboard, and then publish the customization.

