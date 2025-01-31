---
title: Uninstall Sales Insights Add-ons
description: Uninstall the Sales Insights Add-ons for Dynamics 365 Sales if you don't want to use it in your organization.
ms.date: 01/31/2025
ms.custom: bap-template
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
---

# Uninstall Sales Insights Add-ons  

You can uninstall the Sales Insights Add-ons for Dynamics 365 Sales if you don't want to use it in your organization. 

## How to uninstall Sales Insights
  
1. In the sales app, go to **Settings** > **Advanced Settings**.  

    :::image type="content" source="media/advanced-settings-option.png" alt-text="Screenshot of the Advanced Settings option on the Settings menu.":::

1. Go to **Customization** > **Customizations** > **Solutions**.  

1. On the **Solutions** page, select each of the following solutions one at a time in the order they're specified, and then select **Delete**.  
    - SalesInsightsAddOn
    - msdynce_RelationshipAssistantAddOn
    - msdyn_connectiongraph

Although you've deleted the solutions, your organization data might still be stored in Azure Data Lake Storage. To completely remove data and reclaim the data storage, contact Dynamics 365 support.  

## What happens to data

After you uninstall Sales Insights, Dynamics 365 won't keep any Sales Insights data for your organization in the storage locations where it's hosted.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Introduction](../sales/intro-admin-guide-sales-insights.md)
