---
title: Configure the opportunity pipeline view (preview)
description: The opportunity pipeline view helps sellers visualize their pipeline and manage opportunities better.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 01/18/2023
ms.custom: bap-template 
---
# Preview: Configure the opportunity pipeline view

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The opportunity pipeline view (formerly knows as deal manager) helps your sellers visualize the opportunities in their pipeline, and prioritize and manage them effectively. More information: [Preview: Use the opportunity pipeline view](use-opportunity-pipeline-view.md)


## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Video: Opportunity pipeline view (Preview)

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

Watch this short video to know how the opportunity pipeline view helps sellers be more productive and efficient.  

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RWONpe]

## Set pipeline view as the default opportunities view

By default, the **Read-only Grid view** is set as the default view for opportunities. As an administrator, you can set the **Opportunities pipeline view** as the default, so sellers don't have to switch to it each time they access their opportunities list.  
 
1. From the Sales Hub app, select **Settings** > **Advanced Settings**.

1. From the **Settings** menu, select **Customizations** > **Customize the system**.
1. From the Power Apps Default Solution page, select **Entities** > **Opportunity**.
1. Select the **Controls** tab and select **Pipeline view** for web, phone, and tablet.
   :::image type="content" source="media/pipeline-set-as-default.png" alt-text="Screenshot of the Controls tab with the Pipeline view set as default for web, phone, and tablet."::: 
1. Save the changes and select **Publish**.
    The opportunities pipeline view is now set as the default view for opportunities.
1. From the Sales Hub sitemap, select **Opportunities** to verify that the pipeline view is set as the default view.
    :::image type="content" source="media/deal-manager-overview-v1-small.png" alt-text="Screenshot of the opportunity pipeline view.":::

## Customize the editable grid

The grid in the Opportunity pipeline view is implemented using the Power Apps editable grid control. The grid can be customized as well as personalized. As an administrator, you can customize the grid to include columns and filters that are applicable for the entire sales organization. Sellers can personalize their view to include columns and filters that they would like to view. 

To customize the editable grid, see the [Power Apps documentation](/power-apps/developer/component-framework/customize-editable-grid-control).



[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]