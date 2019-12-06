---
title: "Sample: Create, retrieve, update, and delete a chart (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to create, retrieve, update, and delete an organization-owned visualization. "
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 51d4ecad-3c50-4f81-bfff-aa321d62cb2c
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 27
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Create, retrieve, update, and delete a chart

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work with visualizations and dashboards](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/VisualizationsAndDashboards).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create, retrieve, update, and delete an organization-owned visualization. This sample uses the following common methods:  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>  
  
## Example  
 [!code-csharp[VisualizationsAndDashboards#CRUDVisualization](../../snippets/csharp/CRMV8/visualizationsanddashboards/cs/crudvisualization.cs#crudvisualization)]  
  
### See also  
    
 [Actions on Chart](actions-visualizations-charts.md)   
 [Create a Chart](create-visualization-chart.md)   
 [Sample Code for Visualization](sample-code-charts-visualizations.md)   
 [Sample: Retrieve all Charts Attached to an Entity](sample-retrieve-all-charts-attached-entity.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>   
 <xref:Microsoft.Crm.Sdk.Messages.PublishAllXmlRequest>
