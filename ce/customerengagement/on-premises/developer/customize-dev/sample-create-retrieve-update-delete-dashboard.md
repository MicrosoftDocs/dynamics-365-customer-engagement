---
title: "Sample: Create, retrieve, update, and delete a dashboard (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to create, retrieve, update, and delete an organization-owned dashboard. As part of updating the dashboard, it’s set to be the default dashboard for the organization."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: eac23f38-e682-40b8-aa6a-b8145ebf7764
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 25
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Create, retrieve, update, and delete a dashboard

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work visualizations and dashboards](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/VisualizationsAndDashboards).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create, retrieve, update, and delete an organization-owned dashboard. As part of updating the dashboard, it’s set to be the default dashboard for the organization. This sample uses the following common methods:  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>  
  
## Example  
 [!code-csharp[VisualizationsAndDashboards#CRUDDashboards](../../snippets/csharp/CRMV8/visualizationsanddashboards/cs/cruddashboards.cs#cruddashboards)]  
  
### See also  
 [Analyze Data with Dashboards](analyze-data-with-dashboards.md)   
 [Sample: Assign a User-Owned Dashboard to Another User](sample-assign-user-owned-dashboard-another-user.md)   
 [Actions on Dashboard](actions-dashboards.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 