---
title: "Customize analytics reports in Customer Service | MicrosoftDocs"
description: "Learn how to enable users in your organization to be able to customize analytics reports in Dynamics 366 Customer Service."
ms.date: 04/18/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
---

# Visual customization of historical analytics reports in Customer Service

Dynamics 365 Customer Service provides out-of-box reporting capabilities, including industry-standard metrics that are critical for every support organization. These reports are designed to help supervisors in your organization to better understand and manage agent performance.

The nature of your business may require that you customize these standard reports based on your organization's needs. You can edit out-of-box reports in the following ways:

- Rearrange out-of-box report layouts and change themes.
- Modify the visual look of the data, such as to display a metric trend over time versus a tabular view.
- Create visuals using metrics in the data model that aren't directly exposed in the out-of-box reports.

> [!Note]
> Visual customization of historical analytics reports is currently available for Customer Service Workspace, Customer Service Hub, and Omnichannel for Customer Service. It is not available for unified Routing or knowledge management analytical reports.


## Grant user privileges to edit analytics reports

To be able to edit analytics reports, users must have the **Analytics Report Author** role. For information about assigning user roles, go to [Assign roles to users](/add-users-assign-roles#assign-roles-to-users).

## Customize the visual display of your analytics reports

1. Open the **Omnichannel historical analytics** or **Customer Service historical analytics** report in Customer Service workspace.
   
1. Select **Edit report**. The Power BI embedded editing experience is displayed.

   > [!div class="mx-imgBorder"] 
   > ![Select Edit report.](media/edit-report.png "Select Edit report to open the Power BI report authoring experience.")

   The following panes open on the right-hand side of the page:

   - **Visualiations**: Displays a list of options you can use to create different visual views in your report. Choose which visuals you want in your report by deleting a currently displayed visual and then adding the visual you prefer by dragging and dropping it from **Visualizations** list to the area where you want it to display in your report. For example, if you wanted to change the background color of your reports, you would select **Page background**, and then select the color you want from the **Themes color** palette.

     > [!div class="mx-imgBorder"] 
     > ![Visualization pane.](media/customize-visualization.png "Customize report display on the Visualizations pane")

   - **Fields**: Displays a list of KPIs, measures, dimensions, and attributes you can represent in your report. For example, if you wanted to track average handle time more closely, you could select **Avg handle time** from the list in the **Fields** pane, and then drag and drop it in the **Fields** section of the **Visualizations** pane.

     > [!div class="mx-imgBorder"] 
     > ![Drag and drop metrics from the Fields pane.](media/customize-visualization-field.png "Drag and drop metrics to change display")
 
 
1. When you're done selecting the customizations you want for your report, select **Save** and then **Publish**. Once you publish the report, all customizations become visible to all users in your organization. 

1. (Optional) To continue editing the report after you've published it, select **Resume editing**. The **Visualizations** and **Fields** panes are reopened. You can further customize your report, and then save and publish it again.

1. If at some point you want to revert all of your changes to the original report settings, you can do so by selecting **Edit report** > **Checkout default report** > **Reset**. 
   > [!IMPORTANT]
   > Selecting **Reset** will permanently remove any customizations you've made.

### Future data model updates

In a scenario where you have customized your reports and then Microsoft makes updates to the default data model for a report, the customizations you've made for your reports will not be overwritten by the updates to the data model. However, if there is a change to the naming conventions in the Power BI embedded editing experience, those changes will be reflected in the respective list and may require that you reselect the metric with the new name.

## Customer service manager analytics

|Entities |Attributes|	Description |
|----------|------------------|---------------|
|DimDate	|Date time	|Date time. The type is Date/Time. |
|DimDate	|Day | Day name. Example: "Fri". |
|DimDate	|Year	| Year number. Example: "2021". |
|DimDate	|Week	| Week number. Example: "1". |
|DimDate	|Month	| Month name. Example: "Apr 2021"|
|DimDate	|Quarter	| Quarter name. Example: "Q1". |
|DimDate	|Hour	| Hour. Example: "01:00", "01:30" |
|FactCase	|Incident id	|Incident id, Primary key. Type: Guid.|
|FactCase	|Case number	|Case number value. |
|FactCase	|Queue id	|Queue id. Foreign key to DimQueue. |
|FactCase	|Owner system user id	|Owner system user id. Foreign key to DimSystemUser. |
|FactCase	|Case url	|URL for case. |
|FactCase	|Case property id |	Foreign key to DimCaseProperty. |
|FactCase	|Topic id	|Topic id. Foreign key to DimTopic. |
|FactCase	|Case title	|Case title. |
|FactCase	|Created on	|Date created on. |
|FactCase	|Incoming cases	|Incoming cases count.|
|FactCase	|Total cases	|Total case count. |
|FactCase	|Resolved cases	|Case count when case status is resolved. |
|FactCase	|Active cases	|Case count when case status is active. |
|FactCase	|Canceled cases	|Case count when case status is cancelled. |
|FactCase	|Escalated cases	|Case count when case is escalated. |
|FactCase	|Escalated rate	|Rate that escalated cases devide by total cases. |
|FactCase	|Case volume	|Total case count per topic devide by total cases. |
|FactCase	|Case volume change	|Total case count link relative ratio for the same date range filter.|
|FactCase	|Avg. resolve time (hrs|	Avg. time for case handle time. |
|FactCase |	Avg. case age (days)	|Avg. case age
|FactCase	|First response - SLA %	|Total cases when first response sent is false divided by total cases. |
|FactCase	|Avg. CSAT |	Avg. CSAT score. |
|FactCase	|CSAT |mpact	| Change ratio for the CSAT.|
|FactCase	| Avg. survey sentiment	|Avg. survey sentiment. |
|FactCase |	Survey sentiment impact |	Change ratio for the sentiment. |
|DimQueue |	Queue	|Queue name.|
|DimQueue	|Queue id	|Queue ID. Primary key. Type: Guid. |
|DimSystemUser	|Agent	|Name of the agent. |
|DimSystemUser	|System user id |System user ID. | 
|DimCaseProperty	|Case status	|Case status value, Example: Active, Cancelled, Resolved. |
|DimCaseProperty	|Case priority	|Case priority value, Example: Low, High, Normal. |
|DimCaseProperty	|Channel	|Case channel, |
|DimCaseProperty	|Case age	| Description for case age, Example: 4-7 Days, <1 Day, 1-3 Days|
|DimCaseProperty	|Case property id	|Case property ID. Primary key. |
|DimTopic	|Topic	|Topic name. |
|DimTopic	|Topic id	|Topic ID. Primary key. Type: Guid. |
|DimTimeZone	|Time zone	|Time zone code. Example: GMT +01:00 |





