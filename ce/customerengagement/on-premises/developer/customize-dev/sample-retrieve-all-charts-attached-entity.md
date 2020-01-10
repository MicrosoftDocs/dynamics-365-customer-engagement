---
title: "Sample: Retrieve all charts attached to an entity (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to retrieve all the organization-owned visualizations attached to an entity by using the IOrganizationService.QueryBase) method. "
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 4ee28c9c-4d78-47b1-911b-782527bcda45
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 28
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Retrieve all charts attached to an entity

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work with visualizations and dashboards](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/VisualizationsAndDashboards).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to retrieve all the organization-owned visualizations attached to an entity by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method.  
  
## Example  
 [!code-csharp[VisualizationsAndDashboards#RetrieveVisualizationsAttachedToAnEntity](../../snippets/csharp/CRMV8/visualizationsanddashboards/cs/retrievevisualizationsattachedtoanentity.cs#retrievevisualizationsattachedtoanentity)]  
  
### See also  
  
 [Working with Visualizations](view-data-with-visualizations-charts.md)   
 [Sample Code for Visualization](sample-code-charts-visualizations.md)   
 [Sample: Assign a Chart to Another User](sample-assign-chart-another-user.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>
