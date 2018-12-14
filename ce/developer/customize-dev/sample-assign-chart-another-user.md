---
title: "Sample: Assign a chart to another user | MicrosoftDocs"
description: ""
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
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

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the sample: [Work with visualizations and dashboards](https://code.msdn.microsoft.com/Samples-of-visualizations-027f7480). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to assign a user-owned visualization to another user using the <xref:Microsoft.Crm.Sdk.Messages.AssignRequest> message.  
  
## Example  
 [!code-csharp[VisualizationsAndDashboards#AssignVisualizationToUser](../../snippets/csharp/CRMV8/visualizationsanddashboards/cs/assignvisualizationtouser.cs#assignvisualizationtouser)]  
  
### See also  
 [Sample: CrmServiceHelper Class](../org-service/helper-code-serverconnection-class.md)   
 [Working with Visualizations](view-data-with-visualizations-charts.md)   
 [Sample Code for Visualization](sample-code-charts-visualizations.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AssignRequest>
