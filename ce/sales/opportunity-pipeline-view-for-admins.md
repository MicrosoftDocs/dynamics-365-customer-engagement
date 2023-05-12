---
title: Configure the opportunity pipeline view
description: The opportunity pipeline view helps sellers visualize their pipeline and manage opportunities better.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 05/02/2023
ms.custom: bap-template 
---
# Configure the opportunity pipeline view

The opportunity pipeline view (formerly known as deal manager) helps your sellers visualize opportunities in their pipeline, and prioritize and manage them effectively. More information: [Use the opportunity pipeline view](use-opportunity-pipeline-view.md)

If you've previously configured the deal manager workspace, review [this FAQ](faq-sales.yml#are-there-any-differences-between-the-opportunity-pipeline-view-and-the-deal-manager-workspace) to understand what has changed.


## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Video: Opportunity pipeline view 

Watch this short video to know how the opportunity pipeline view helps sellers be more productive and efficient.  

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RWONpe]

## Set pipeline view as the default opportunities view

By default, the **Read-only Grid view** is set as the default view for opportunities. As an administrator, you can set the **Opportunities pipeline view** as the default, so sellers don't have to switch to it each time they access their opportunities list.  

1. From the Sales Hub app, select **Settings** > **Advanced Settings**.

1. From the **Settings** menu, select **Customizations** > **Customize the system**.
1. From the Power Apps Default Solution page, select **Entities** > **Opportunity**.
1. Select the **Controls** tab and select **Pipeline view** for web, phone, and tablet. If you don't see the **Pipeline view** in the **Control** list, select **Add Control**. From the **Add Control** dialog, select **Pipeline view** and then select **Add**.

   :::image type="content" source="media/pipeline-set-as-default.png" alt-text="Screenshot of the Controls tab with the Pipeline view set as default for web, phone, and tablet."::: 

1. Save the changes and select **Publish**.  
    The opportunities pipeline view is now set as the default view for opportunities.
1. From the Sales Hub sitemap, select **Opportunities** to verify that the pipeline view is set as the default view.
    :::image type="content" source="media/deal-manager-overview-v1-small.png" alt-text="Screenshot of the opportunity pipeline view.":::

## Customize charts

The charts in the pipeline view help sellers visualize their pipeline better. As an administrator, you can customize various elements in the bubble chart, such as the data on the x-axis and y-axis, the size and color of the bubble, the sort order for the legend, and tooltips. Similarly, you can customize elements in the funnel chart, such as the field used for segmentation, the aggregate function used, and so on.  


### Customize the bubble chart

1. In the Sales Hub app, select **App Settings** from the **Change area**.

1. Under **General Settings**, select **Opportunity pipeline view**.
1. In the Manage charts section, edit **Deal tracker**.
1. Customize the following elements:
    - **Horizontal (x) axis**  
      Select any field of type DateTime. For example, you can choose to plot the chart based on delivered date instead of closed date.  
    - **Vertical (y) axis**  
      Select any numerical field to plot on the vertical axis.
    - **Segment by**  
        Select how you want to distinguish the bubbles by using different color codes. For example, select **Pipeline Phase** to distinguish the bubbles based on the different phases of the pipeline, such as identify, qualify, or propose.
    - **Size**  
        Select a numerical field to indicate the size of the bubble.
    - **Sort legend**  
        Select how you want to sort the legends displayed on the chart. Legends indicate the color used for each segment. For example, if you select **Opportunity grade** as the segment, the legends will be sorted based on the chronological order of the grades.
    - **Tooltips**  
        Select the details that you want users to see displayed as tooltips when they hover over each bubble.  

1. Save the changes and select **Publish**. 
1. [Open the opportunity pipeline view](use-opportunity-pipeline-view.md#open-the-opportunity-pipeline-view) to verify whether the changes took effect.

### Customize the funnel chart

1. In the Sales Hub app, select **App Settings** from the **Change area**.

1. Under **General Settings**, select **Opportunity pipeline view**.
1. In the **Manage charts** section, edit **Sales funnel**. The following screenshot illustrates the parts of the funnel chart that you can customize:
    :::image type="content" source="media/funnel-chart-customization.png" alt-text="Screenshot of the funnel chart and its elements that can be customized.":::

1. Customize the following elements:
    - **Segment by**  
      Select the field for segmenting the funnel chart. For example, you can choose to segment the funnel by forecast category. **Default:** Pipeline phase  
    - **Values**  
      Select the field to be used for sizing the bars in the funnel. **Default:** Est. revenue  
    - **Aggregation**  
        Select the aggregate function to use for the **Values** field. This height of the bar is determined by this field. The aggregate value is displayed when you hover over a segment in the funnel chart. 
    - **Sort legend**  
        Specify how you want to sort the segments. For example, selecting Finish to start for a funnel chart segmented by pipeline phase will display the funnel from the last phase to first phase, that is from Close to Qualify. 
   
1. Save the changes and select **Publish**. 
1. [Open the opportunity pipeline view](use-opportunity-pipeline-view.md#open-the-opportunity-pipeline-view) to verify whether the changes took effect.

## Customize the editable grid

The grid in the Opportunity pipeline view is implemented using the Power Apps editable grid control. The grid can be customized as well as personalized. As an administrator, you can customize the grid to include columns and filters that are applicable for the entire sales organization. Sellers can [personalize their view](personalize-pipeline-view.md#what-can-you-personalize) to include columns and filters that they would like to view.  

> [!NOTE]
> If you have previously customized the editable grid in the deal manager using JavaScript, you will need to redo those customizations for the editable grid in the pipeline view. 

To customize the editable grid, see the [Power Apps documentation](/power-apps/developer/component-framework/customize-editable-grid-control). For information on grid events, see [Events in forms and grids in model-driven apps](/power-apps/developer/model-driven-apps/clientapi/events-forms-grids).  


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Where is the deal manager workspace?](faq-sales.yml#where-is-the-deal-manager-workspace)  
[Manage opportunities using pipeline view](use-opportunity-pipeline-view.md)  
[Column-level security to control access](/power-platform/admin/field-level-security)