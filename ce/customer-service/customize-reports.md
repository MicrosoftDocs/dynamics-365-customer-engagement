---
title: Customize visual display
description: Learn how to customize out-of-the-box reports in Dynamics 365 Customer Service using the Power BI embedded editing experience.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.service: dynamics-365
ms.topic: how-to
ms.date: 04/06/2023
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

Dynamics 365 Customer Service provides out-of-the-box analytics reports, which helps you visualize KPIs and trends to cover standard contact center workflows. With visual customization, you can edit the out-of-the-box reports to support your organizational needs.

Use visual customization to:

- Leverage additional out-of-the-box metrics that may be relevant to your organization, through the Power BI embedded editing experience. The data model that supports the out-of-the-box reports also provides you with additional metrics which may not be directly exposed in the reports.
- Modify the visual look of the data. For example, you can have a graphic that displays the trend of a metric over time rather than a tabular view of the metric.
- Add new pivots and add new pages. For example, you can create a new pivot or page dedicated to a specific queue with queue level metrics.
- Rearrange out-of-the-box report layouts and change themes.

> [!Note]
> Visual customization of Omnichannel historical, Customer Service historical, and Omnichannel real-time analytics reports is currently available for Customer Service Workspace. It isn't available for unified routing and knowledge analytics reports.

## Grant user privileges to edit analytics reports

To be able to edit analytics reports, users must have the **Analytics Report Author** role. For information about assigning user roles, go to [Assign roles to users](add-users-assign-roles.md#assign-roles-to-users).

## Customize the visual display of your analytics reports

1. Open the **Omnichannel real-time analytics**, **Omnichannel historical analytics**, or **Customer Service historical analytics** report in Customer Service workspace.
   
1. Select **Edit report**.

    :::image type="content" source="media/visual-edit-report.png" alt-text="Select Edit report to open the Power BI editing experience":::
   

   The following panes open on the right-hand side of the page:

   - **Visualizations**: Displays a list of options you can use to create different visual views in your report. Choose which visuals you want in your report by deleting a currently displayed visual and then adding the visual you prefer. For example, if you want to show **Incoming conversations over time** as a table instead of the bar chart, you can change your visual from the **Visualizations** pane.

      :::image type="content" source="media/visual-incoming-conversations.png" alt-text="Customize report display on the Visualizations pane":::

   - **Data**: Displays a list of KPIs, measures, dimensions, and attributes you can represent in your report. This also has the KPIs that are available for use, beyond the ones displayed on the out-of-the-box reports. For example, **Participation Mode** in **FactSessionParticipant**, is a fact that allows you to build metrics to count the number of times a subject-matter expert accepted a consult request. More information: [Understand out-of-the-box data model](#understand-out-of-the-box-data-model)

      :::image type="content" source="media/visual-sessionpart-mode.png" alt-text="Drag and drop metrics to change display":::
    
1. When you're done selecting the customizations you want for your report, select **Save** and then **Publish**. Once you publish the report, all customizations become visible to all users in your organization.

1. If at some point you want to revert all your changes to the original report settings, you can do so by selecting **Edit report** > **Checkout default report** > **Reset**.
   > [!IMPORTANT]
   > Selecting **Reset** will permanently remove any customizations you've made.

To continue editing the report after you've published it, select **Resume editing**. The **Visualizations** and **Fields** panes reopen. You can further customize your report, and then save and publish it again.

## Understand out-of-the-box data model

The out-of-the-box data model consists of facts and dimension tables. Facts represent the data you want to analyze, while dimensions represent the attributes of the data that you want to break down to explore further.

Fact tables organize key KPIs logically. For example, **FactConversation** has conversation metrics like **Average handle time**, while **FactAgent** has **Agent metrics**.  

You can use facts and dimensions to visualize data, according to your organizational requirements. If you would like to understand how average handle time varies by queue, you can create a new visualization like a bar chart, and have **Average Handle Time** fact in **FactConversation** further divided by the dimension **Queue Name** in **DimQueue**.

### Future data model updates

In a scenario in which you've customized your reports and then Microsoft makes updates to the default data model for a report, the customizations you've made for your reports won't be overwritten by the updates to the data model. However, if there's a change to the naming conventions in the Power BI embedded editing experience, those changes will be reflected in the respective list and may require that you reselect the metric with the new name. For more information on data model and report mapping, see: [Data models and report mappings for historical analytics reports in Customer Service](oob-data-models.md#data-models-and-report-mappings-for-historical-analytics-reports-in-customer-service).

> [!NOTE]
> Make sure that you don't add more than 20 metrics (or tiles) to a report as it affects performance. If you need additional metrics, consider creating additional pages and provide references to the additional pages from the existing report pages.

### See also

[Introduction to Customer Service Insights](introduction-customer-service-analytics.md) <br>
[Configure Customer Service analytics and insights](configure-customer-service-analytics-insights-csh.md) <br>
[Configure Customer Service Analytics dashboards in Power BI](configure-customer-service-analytics-dashboard.md) <br>
[Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)
