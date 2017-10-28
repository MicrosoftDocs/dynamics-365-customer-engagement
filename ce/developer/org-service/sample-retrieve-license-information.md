---
title: "Sample: Retrieve license information (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to use the IDeploymentService.RetrieveDeploymentLicenseTypeRequest message and the IOrganizationService.RetrieveLicenseInfoRequest message to retrieve information about licenses"
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 7c8bd1ce-59e0-4884-b7bf-e809d7fd0b75
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 15
topic-status: Drafting
---

# Sample: Retrieve license information
This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. [Download the Sample: Retrieve license information (early bound)](https://code.msdn.microsoft.com/Retrieve-license-d4580914).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
 [Full Sample – C#](sample-initialize-record-existing-record.md#full_C)  
  
## Demonstrates  
 This sample shows how to use the <xref:Microsoft.Xrm.Sdk.Deployment.IDeploymentService>.<xref:Microsoft.Crm.Sdk.Messages.RetrieveDeploymentLicenseTypeRequest> message and the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Crm.Sdk.Messages.RetrieveLicenseInfoRequest> message to retrieve information about licenses.  
  
## Example  
 [!code-csharp[StrongTypes#License1](../../snippets/csharp/CRMV8/strongtypes/cs/license1.cs#license1)]  
  
<a name="full_C"></a>   
## Full Sample – C#  
 [!code-csharp[StrongTypes#License](../../snippets/csharp/CRMV8/strongtypes/cs/license.cs#license)]  
  
### See also  
 [Use the Early Bound Entity Classes in Code](use-early-bound-entity-classes-code.md)   
 <xref:Microsoft.Xrm.Sdk.Deployment.IDeploymentService>   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveDeploymentLicenseTypeRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveLicenseInfoRequest>