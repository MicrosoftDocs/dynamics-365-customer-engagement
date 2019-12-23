---
title: "Sample: Assign a chart to another user | MicrosoftDocs"
description: ""
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0225d979-0e34-44b5-814c-a5dcb14d6fd9
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 24
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Assign a chart to another user

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work with visualizations and dashboards](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/VisualizationsAndDashboards). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to assign a user-owned visualization to another user using the <xref:Microsoft.Crm.Sdk.Messages.AssignRequest> message.  
  
## Example  
 [!code-csharp[VisualizationsAndDashboards#AssignVisualizationToUser](../../snippets/csharp/CRMV8/visualizationsanddashboards/cs/assignvisualizationtouser.cs#assignvisualizationtouser)]  
  
### See also     
 [Working with Visualizations](view-data-with-visualizations-charts.md)   
 [Sample Code for Visualization](sample-code-charts-visualizations.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AssignRequest>
