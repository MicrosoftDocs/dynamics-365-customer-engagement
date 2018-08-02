---
title: "View data with visualizations (charts) (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Visualizations let you see your business data graphically. A visualization is attached to an entity in Dynamics 365 Customer Engagement. You can attach multiple visualizations to an entity, however, only one visualization can be displayed at a time along-side a grid. You can view multiple visualizations at the same time by using a dashboard."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "charts"
ms.assetid: c2e420e0-66e6-4317-b203-8a0710d0d3f4
caps.latest.revision: 49
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# View data with visualizations (charts)

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Visualizations let you see your business data graphically. A visualization is attached to an entity in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement. You can attach multiple visualizations to an entity, however, only one visualization can be displayed at a time along-side a grid. You can view multiple visualizations at the same time by using a dashboard. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Analyze Data with Dashboards](analyze-data-with-dashboards.md)  
  
 You can use a chart or a web resource as a visualization in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. For charts, you can use the chart designer in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. However, to use a web resource in a visualization, you must either use the SDK or import a custom visualization XML into [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Sample: Create, Retrieve, Update, and Delete a Chart](sample-create-retrieve-update-delete-chart.md)  
  
<a name="VisualizationTypes"></a>   
## Visualization ownership  
 In [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)], there are two types of visualization ownership: organization-owned and user-owned.  
  
- An organization-owned visualization is owned by an organization, and cannot be assigned or shared. The `SavedQueryVisualization` entity represents the organization-owned visualization. These visualizations are solution-aware entities in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. Whenever you update a saved query visualization, you must publish the changes for the updates to be available across the organization by using the <xref:Microsoft.Crm.Sdk.Messages.PublishAllXmlRequest> message. This entity is referred to as a *System Chart* in the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] web application.  
  
- A user-owned visualization is owned by an individual user, and can be assigned and shared with other users and teams. The `UserQueryVisualization` entity represents the user-owned visualization. This entity is referred to as a *User Chart* in the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] web application, and is displayed under **My Charts** in the chart drop-down list.  
  
  A user query visualization is not associated with a user query (view), despite the entity name. The view aspect of this entity is used only for setting the filter criteria.  
  
<a name="Charts"></a>   
## Chart visualizations  
 Charts let you see summaries of grid data. The charts are built by using the [!INCLUDE[pn_microsoftchart](../../includes/pn-microsoftchart.md)]. For more information about [!INCLUDE[pn_ms_chart_controls_short](../../includes/pn-ms-chart-controls-short.md)], see [Download: Chart Controls for .NET Framework](http://go.microsoft.com/fwlink/p/?LinkId=128852).  
  
 These charts are integrated with the grids in the web application. When you apply a filter (query) to the data in a grid, the filter is applied to the chart also, and the chart is updated accordingly. Similarly, when you perform drill-down operations on a chart, the grid data is updated automatically.  
  
 A chart attached to an entity is available for all the views for the entity. A chart displays data according to the currently selected (or displayed) view of an entity. A chart can display data from both a saved query (organization-owned view) and a user query (user-owned view).  
  
 Charts display data for only those saved queries (organization-owned views) that use FetchXML (`SavedQuery.FetchXml` attribute) to filter the records. If a saved query uses the query API (`SavedQuery.QueryAPI` attribute) to filter the records, the chart will not appear for that saved query. This limitation is not applicable for user queries (user-owned views) because the user query entity does not use the `QueryAPI` attribute to filter the records.  
  
 For more information about how to work with charts, see [Understanding Charts: Underlying Data and Chart Representation](understand-charts-underlying-data-chart-representation.md).  
  
<a name="ChartTypes"></a>   
### Chart types in Microsoft chart controls  
 [!INCLUDE[pn_ms_chart_controls_short](../../includes/pn-ms-chart-controls-short.md)] is used to build charts in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. [!INCLUDE[pn_ms_chart_controls_short](../../includes/pn-ms-chart-controls-short.md)] enable you to create various chart types such as column, bar, area, stacked, line, bubble, and pie.  
  
 The following chart types are supported out-of-box in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]: *Column*, *Area*, *Bar*, *Line*, *Pie*, and *Funnel*. However, you can extend the functionality by creating other supported [!INCLUDE[pn_ms_chart_controls_short](../../includes/pn-ms-chart-controls-short.md)] chart types such as multi-series, stacked, and 100% stacked (comparison) charts by specifying appropriate content in the data description and presentation description XML strings for a chart. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Specifying Chart Data](understand-charts-underlying-data-chart-representation.md)  
  
<a name="WebResources"></a>   
## Web resource visualizations  
 Web resources are virtual files that are stored in the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] database and may be retrieved using a unique URL address. You can display an existing web resource as a visualization, and display it in the **Charts** area in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] together with other charts for an entity. For more information about web resources, see [Web Resources for Microsoft Dynamics 365](../web-resources.md).  
  
 You can use the following types of web resources in a visualization: [WWebpage (HTML) web resources](../webpage-html-web-resources.md) and [Image (JPG, PNG, GIF, ICO) Web Resources](../image-web-resources.md). For more information about how to create a visualization with a web resource, see [Create a Web Resource Visualization](create-visualization-chart.md#CreateWRVisualization).  
  
<a name="SupportedVisualizationEntities"></a>   
## Entities supported for visualizations  
 You can create and attach visualizations to only those entities in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] that support the new ribbon interface. This is because all of the chart controls are only present in the ribbon interface of [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Custom entities are also supported for visualizations. You can turn off the visualization support for custom entities if you want to. However, you cannot disable visualization support for the default entities.  
  
 The following lists the default entities that are supported for visualizations.  
  
 Account  
ActivityPointer  
Appointment  
BulkOperation  
Campaign  
CampaignActivity  
CampaignResponse  
Competitor  
Connection  
Contact  
Contract  
Email  
Entitlement  
EntitlementChannel  
EntitlementTemplateChannel  
Fax  
Goal  
GoalRollupQuery  
Incident  
Invoice  
InvoiceDetail  
KbArticle  
Lead  
Letter  
List  
Mailbox  
Metric  
Opportunity  
OpportunityProduct  
PhoneCall  
Position  
PriceLevel  
Product  
ProductAssociation  
ProductSubstitute  
QueueItem  
Quote  
QuoteDetail  
RecurringAppointmentMaster  
Report  
SalesLiterature  
SalesOrder  
SalesOrderDetail  
Service  
ServiceAppointment  
SLAKPIInstance  
SocialActivity  
SocialProfile  
SystemUser  
Task  
Team  
Territory  
UoMSchedule  
  
### See also  
 [Chart and Analyze Data in Microsoft Dynamics 365 "5"](customize-visualizations-dashboards.md)   
 [Specifying Chart Data](understand-charts-underlying-data-chart-representation.md)   
 [Actions on Chart](actions-visualizations-charts.md)   
 [Create a Chart](create-visualization-chart.md)   
 [Sample Charts](sample-charts.md)   
 [Sample Code for Charts](sample-code-charts-visualizations.md)   
 [SavedQueryVisualization Entity](../entities/savedqueryvisualization.md)   
 [UserQueryVisualization Entity](../entities/userqueryvisualization.md)
 [Download: Chart Controls for .NET Framework Language Pack](http://www.microsoft.com/downloads/details.aspx?FamilyId=581FF4E3-749F-4454-A5E3-DE4C463143BD&displaylang=en)   
 [Download: Chart Controls Add-on for Visual Studio](http://www.microsoft.com/downloads/details.aspx?FamilyId=1D69CE13-E1E5-4315-825C-F14D33A303E9&displaylang=en)   
 [Download: Chart Controls for .NET Framework Documentation](http://go.microsoft.com/fwlink/p/?LinkId=128301)   
 [Samples Environment for Microsoft Chart Controls](http://code.msdn.microsoft.com/mschart)   
 [Chart Controls Forum](http://go.microsoft.com/fwlink/p/?LinkId=128713)