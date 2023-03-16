---
title: Customize visual display
description: Learn how to customize out-of-the-box reports in Dynamics 365 Customer Service using the Power BI embedded editing experience.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.service: dynamics-365
ms.topic: how-to
ms.date: 03/16/2023
ms.custom: 
  - dyn365-customerservice
  - bap-template
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
---

# Customize visual display

Dynamics 365 Customer Service provides out-of-box analytics reports. Depending on your organizational requirements, you can customize the visualization of these out-of-the-box historical and real-time analytics reports. For example, you can add **Avg. conversation sentiment** field to your reports to track customer sentiment.

You can customize these out-of-box reports in the following ways:

- Create visuals using metrics in the data model that aren't directly exposed in the out-of-box reports, through the Power BI embedded editing experience.
- Rearrange out-of-box report layouts and change themes.
- Add new pivots and add new reports.
- Modify the visual look of the data. For example, you can have a graphic that displays the trend of a metric over time rather than a tabular view of the metric.

> [!Note]
> Visual customization of historical and real-time analytics reports is currently available for Customer Service Workspace, Customer Service Hub, and Omnichannel for Customer Service. It isn't available for unified routing and knowledge analytics reports.

## Grant user privileges to edit analytics reports

To be able to edit analytics reports, users must have the **Analytics Report Author** role. For information about assigning user roles, go to [Assign roles to users](add-users-assign-roles.md#assign-roles-to-users).

## Customize the visual display of your analytics reports

1. Open the **Omnichannel real-time analytics** or **Customer Service historical analytics** report in Customer Service workspace.
   
1. Select **Edit report**.

    :::image type="content" source="media/visual-edit-report.png" alt-text="Select Edit report to open the Power BI editing experience":::
   

   The following panes open on the right-hand side of the page:

   - **Visualizations**: Displays a list of options you can use to create different visual views in your report. Choose which visuals you want in your report by deleting a currently displayed visual and then adding the visual you prefer. For example, if you want to change the background color of your reports, you would select **Canvas background**, and then select the color you want.

      :::image type="content" source="media/visual-canvas-background.png" alt-text="Customize report display on the Visualizations pane":::

   - **Data**: Displays a list of KPIs, measures, dimensions, and attributes you can represent in your report. For example, if you want to track presence status, you could select **PresenceStatus** from the list in the **Data** pane, and then drag and drop it in the fields of the **Visualizations** pane.

      :::image type="content" source="media/visual-presence-status.png" alt-text="Drag and drop metrics to change display":::
  
1. When you're done selecting the customizations you want for your report, select **Save** and then **Publish**. Once you publish the report, all customizations become visible to all users in your organization. 

1. If at some point you want to revert all of your changes to the original report settings, you can do so by selecting **Edit report** > **Checkout default report** > **Reset**. 
   > [!IMPORTANT]
   > Selecting **Reset** will permanently remove any customizations you've made.

To continue editing the report after you've published it, select **Resume editing**. The **Visualizations** and **Fields** panes are reopened. You can further customize your report, and then save and publish it again.

Make sure that you don't more than 20 metrics (or tiles) to a report as it affects performance. If you need to add a lot of additional metrics, create additional pages and reference the additional pages on the existing report pages.

### Future data model updates

In a scenario in which you've customized your reports and then Microsoft makes updates to the default data model for a report, the customizations you've made for your reports won't be overwritten by the updates to the data model. However, if there's a change to the naming conventions in the Power BI embedded editing experience, those changes will be reflected in the respective list and may require that you reselect the metric with the new name. For more information on data model and report mapping, see: [Data models and report mappings for historical analytics reports in Customer Service](oob-data-models.md#data-models-and-report-mappings-for-historical-analytics-reports-in-customer-service).


### See also

[Introduction to Customer Service Insights](introduction-customer-service-analytics.md) <br>
[Configure Customer Service analytics and insights](configure-customer-service-analytics-insights-csh.md) <br>
[Configure Customer Service Analytics dashboards in Power BI](configure-customer-service-analytics-dashboard.md) <br>
[Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)
