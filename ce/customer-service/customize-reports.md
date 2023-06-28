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
---

# Customize visual display

Dynamics 365 Customer Service provides out-of-the-box analytics reports that help you visualize key performance indicators (KPIs) and trends for standard contact center workflows. You can use an embedded Power BI editor to customize the out-of-the-box reports to meet your organization's needs:

- Reveal out-of-the-box metrics that may be more relevant to your organization.
- Modify how the data is displayed; for example, change a tabular view to a graphic that displays the trend over time.
- Add new pivots and pages; for example, create a pivot or page that's dedicated to a specific queue with queue-level metrics.
- Rearrange out-of-the-box report layouts and change themes.

You can customize Customer Service historical, Omnichannel historical, and Omnichannel real-time analytics reports in Customer Service workspace. You can't customize unified routing and knowledge analytics reports.

## Prerequisites

To edit analytics reports, users must have the **Analytics Report Author** role. [Assign roles to users](add-users-assign-roles.md#assign-roles-to-users).

## Customize the display of analytics reports

1. In Customer Service workspace, open the **Omnichannel real-time analytics**, **Omnichannel historical analytics**, or **Customer Service historical analytics** report.

1. Select **Edit report** to open the embedded Power BI editor.

    :::image type="content" source="media/visual-edit-report.png" alt-text="Screenshot of the Omnichannel real-time analytics report page, with Edit report highlighted.":::

1. Use the following panes to customize the report:

   - **Visualizations**: Select the visualizations you want in your report. You can delete a currently displayed visualization and add the one you prefer. For example, you can show **Incoming conversations over time** as a table instead of the default bar chart.

      :::image type="content" source="media/visual-incoming-conversations.png" alt-text="Screenshot of adding a table visualization to a report in the embedded Power BI editor.":::

   - **Data**: Select the KPIs, measures, dimensions, and attributes you want to show in your report. The list includes all the metrics that are available for use, not just the ones that are displayed in the out-of-the-box reports. For example, you can use the **Participation Mode** metric in **FactSessionParticipant** to count the number of times a subject matter expert accepted a consult request. [Understand the out-of-the-box data model](#understand-the-out-of-the-box-data-model).

      :::image type="content" source="media/visual-sessionpart-mode.png" alt-text="Screenshot of the list of metrics available in a report.":::

1. When you're done selecting the customizations you want for your report, select **Save** and then **Publish**.

After you publish the report, all customizations become visible to all users in your organization.

To revert all your changes to the original report settings, select **Edit report** > **Checkout default report** > **Reset**.

   > [!IMPORTANT]
   > If you select **Reset**, any customizations you've made are permanently removed.

To continue editing the report after you've published it, select **Resume editing**.

> [!NOTE]
> Don't add more than 20 metrics or tiles to a report because it affects the report's performance. If you need more metrics, consider creating more pages and provide links to the extra pages from the existing pages.

## Understand the out-of-the-box data model

The out-of-the-box data model consists of *facts* and *dimensions*. Facts represent the data you want to analyze. Dimensions represent the attributes of the data that you want to break down to explore further.

Fact tables organize key KPIs logically. For example, **FactConversation** has conversation metrics like **Average handle time**, while **FactAgent** has **Agent metrics**.  

You can use facts and dimensions to visualize data according to your organizational requirements. If you'd like to understand how average handle time varies by queue, create a visualization like a bar chart, and divide the fact **FactConversation** > **Average Handle Time** by the dimension **DimQueue** > **Queue Name**.

### Future data model updates

If you've customized your reports and Microsoft changes the default data model for a report, the data model updates don't overwrite your customizations. However, if the naming conventions in the Power BI embedded editing experience change, those changes are reflected in the respective list. You may need to reselect the metric with the new name. [Learn more about data models and report mappings for historical analytics reports in Customer Service](oob-data-models.md#data-models-and-report-mappings-for-historical-analytics-reports-in-customer-service).

### See also

[Introduction to Customer Service Insights](introduction-customer-service-analytics.md)  
[Configure Customer Service analytics and insights](configure-customer-service-analytics-insights-csh.md)  
[Configure Customer Service Analytics dashboards in Power BI](configure-customer-service-analytics-dashboard.md)  
[Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)
