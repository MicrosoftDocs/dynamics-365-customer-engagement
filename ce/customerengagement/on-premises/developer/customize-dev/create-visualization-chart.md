---
title: "Create a visualization (chart) (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The topic shows how to create a chart visualization and a web resource visualization. "
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: a93ac45e-aa61-4a0b-be4c-f63ccc4a2c91
caps.latest.revision: 42
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Create a visualization (chart)

To create a visualization programmatically, you must create a record for the [SavedQueryVisualization Entity](../entities/savedqueryvisualization.md) or [UserQueryVisualization Entity](../entities/userqueryvisualization.md) entity to create an organization-owned or user-owned chart respectively. This topic shows how to create a chart visualization and a web resource visualization.  
  
<a name="Before"></a>   

## Before you create a visualization  

 Before creating a visualization, make sure that you are aware of the following:  
  
- **Type of visualization**: If you want your visualizations to be available across the organization and don’t want to manage the access levels at a more detailed level, you might want to create an organization-owned visualization. However, if you’re concerned about the access privileges and security of your visualization, consider creating a user-owned visualization where you have more control over who can access it.  
  
    > [!NOTE]
    >  Organization-owned visualizations can only be created by those users who have the System Administrator or System Customizer role.  
  
- **Associated Entity**: Visualizations are attached to entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Entities Supported for Visualizations](view-data-with-visualizations-charts.md#SupportedVisualizationEntities). You can attach a chart to a supported entity by using the [SavedQueryVisualization.PrimaryEntityTypeCode](../entities/savedqueryvisualization.md#BKMK_PrimaryEntityTypeCode) or [UserQueryVisualization.PrimaryEntityTypeCode](../entities/userqueryvisualization.md#BKMK_PrimaryEntityTypeCode) attribute.  
  
<a name="CreateChart"></a>   

## Create a chart visualization  

 Charts require you to specify the underlying data for the charts and how the charts will look in the form of *data description* and *presentation description* XML strings. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Specifying Chart Data](understand-charts-underlying-data-chart-representation.md) and [Sample Charts](sample-charts.md).  
  
 For a complete sample on how to create an organization-owned chart, see [Sample: Create, Retrieve, Update, and Delete (CRUD) a Chart](sample-create-retrieve-update-delete-chart.md).  
  
### Create a multi-series chart  

 Multi-series charts map multiple series (vertical) axis values to a single category (horizontal) axis value. The only difference from a single series chart is that these charts have multiple `<measurecollection>` and corresponding `<series>` elements specified in the XML strings. Each `<measurecollection>` element contains a child element called `<measure>` that defines a series (vertical) axis value for the same category (horizontal) value. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Understanding Charts: Underlying Data and Chart Representation](understand-charts-underlying-data-chart-representation.md).  
  
 For a sample multi-series chart and the corresponding data description and presentation descriptions XML strings, see [Multi-Series Chart](sample-charts.md#MultiSeriesChart).  
  
<a name="CreateWRVisualization"></a>   

## Create a web resource visualization  

 Visualizations containing web resources don’t require you to specify the data description and presentation description XML strings. The following sample demonstrates how to create an organization-owned visualization containing a web resource by using the SDK.  
  
```csharp  
SavedQueryVisualization newWebResourceVisualization = new SavedQueryVisualization()  
{  
   Name = "Sample Dashboard Visualization",  
   Description = "Sample organization-owned visualization",  
                           PrimaryEntityTypeCode = Account.EntityLogicalName,  
   WebResourceId = new EntityReference(WebResource.EntityLogicalName, _webResourceId))  
  
};  
_orgOwnedVisualizationId = _serviceProxy.Create(newWebResourceVisualization);  
  
```  
  
 If you want to create a web resource visualization by using the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] web application, you must create an XML file in the following format, and then use **Import Chart** in the ribbon to import the visualization.  
  
```xml  
<visualization>  
  <name>Visualization_Name</name>  
  <description>Description</description>  
  <webresourcename>Name_Of_An_Existing_Web_Resource</webresourcename>  
  <primaryentitytypecode>Entity_Logical_Name</primaryentitytypecode>  
  <isdefault>Value: true or false</isdefault>  
</visualization>  
```  
  
 For example, to create a *Sample Visualization* that displays an existing Web resource called *new_TestWebResource*, and the visualization should be attached to the *account* entity, the XML should look like.  
  
```xml  
<visualization>  
  <name>Sample Visualization</name>  
  <description>Sample Web Resource Visualization.</description>  
  <webresourcename>new_TestWebResource</webresourcename>  
  <primaryentitytypecode>account</primaryentitytypecode>  
  <isdefault>false</isdefault>  
</visualization>  
```  
  
### See also  
 [Charts](view-data-with-visualizations-charts.md)   
 [Specifying Chart Data](understand-charts-underlying-data-chart-representation.md)   
 [Actions on Chart](actions-visualizations-charts.md)   
 [Sample Charts](sample-charts.md)   
 [Data Visualization and Analytics](customize-visualizations-dashboards.md)   
 [Sample: Create, Retrieve, Update, and Delete (CRUD) a Chart](sample-create-retrieve-update-delete-chart.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]