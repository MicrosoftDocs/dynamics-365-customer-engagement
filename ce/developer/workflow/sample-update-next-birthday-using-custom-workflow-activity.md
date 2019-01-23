---
title: "Sample: Update next birthday using a custom workflow activity (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates workflow activity returns the next birthday. Use this in a workflow that sends a birthday greeting to a customer. "
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 1cff83b0-1f7b-4ddb-a2af-b85f9f785529
caps.latest.revision: 21
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Update next birthday using a custom workflow activity

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the complete sample here [Custom workflow activities sample](https://code.msdn.microsoft.com/Custom-Workflow-Activities-eee57285). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
 The following custom field must exist for this custom workflow activity to work:  
  
-   Contact.new_nextbirthday  
  
## Demonstrates  
 The following sample workflow activity returns the next birthday. Use this in a workflow that sends a birthday greeting to a customer.  
  
## Example  
 [!code-csharp[customworkflowactivities#ReleaseISVActivities](../../snippets/csharp/CRMV8/customworkflowactivities/cs/releaseisvactivities.cs#releaseisvactivities)]  
  
### See also  
 [Custom Workflow Activities (Workflow Assemblies)](../custom-workflow-activities-workflow-assemblies.md)   
 [Sample: Calculate a Credit Score with a Custom Workflow Activity](sample-calculate-credit-score-custom-workflow-activity.md)   
 [Add Metadata to a Custom Workflow Activity](add-metadata-custom-workflow-activity.md)   
 <xref:Microsoft.Xrm.Sdk.Workflow.IWorkflowContext>
