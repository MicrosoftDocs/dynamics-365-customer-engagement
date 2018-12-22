---
title: "Sample: Create, retrieve, update, and delete a dialog (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "The sample shows how to create, retrieve, update, and delete a dialog process using the methods IOrganizationService.Entity, IOrganizationService.ColumnSet, and IOrganizationService. Guid."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 6bebfba9-833f-4e46-88e4-d1b5fa6b5962
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Create, retrieve, update, and delete a dialog

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement. See the complete sample here [Sample: Create, retrieve, update, and delete a dialog](https://msdn.microsoft.com/library/gg334435.aspx)

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create, retrieve, update, and delete a dialog process using these methods:  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>  
  
-  <xref:Microsoft.Xrm.Sdk.IOrganizationService>. <xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>  
  
## Example  
 [!code-csharp[Dialogs#CRUDDialog](../snippets/csharp/CRMV8/dialogs/cs/cruddialog.cs#cruddialog)]  
  
### See also  
 [Use Dialogs in Dynamics 365 for Customer Engagement apps](use-dialogs-guided-processes.md)   
 [Sample: Create a Workflow in Code](sample-create-workflow-code.md)   
 [Sample Code for Processes](sample-code-processes.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>
