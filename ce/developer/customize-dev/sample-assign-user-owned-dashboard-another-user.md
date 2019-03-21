---
title: "Sample: Assign a user-owned dashboard to another user (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to assign a user-owned dashboard to another user by using the AssignRequest message. Because you can’t delete a user-owned dashboard that is assigned to another user, this sample shows how to use impersonation to delete the user-owned dashboard. "
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 3c88b87d-e178-41ac-bd44-f7aa790677b9
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 22
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Assign a user-owned dashboard to another user

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the sample: [Work with visualizations and dashboards](https://code.msdn.microsoft.com/Samples-of-visualizations-027f7480).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to assign a user-owned dashboard to another user by using the <xref:Microsoft.Crm.Sdk.Messages.AssignRequest> message. Because you can’t delete a user-owned dashboard that is assigned to another user, this sample shows how to use impersonation to delete the user-owned dashboard.  
  
## Example  
 [!code-csharp[VisualizationsAndDashboards#AssignDashboardToUser](../../snippets/csharp/CRMV8/visualizationsanddashboards/cs/assigndashboardtouser.cs#assigndashboardtouser)]  
  
### See also  
 [Actions on Dashboard](actions-dashboards.md)   
 [Assign](../introduction-entities.md#Assign)   
 <xref:Microsoft.Crm.Sdk.Messages.AssignRequest>
