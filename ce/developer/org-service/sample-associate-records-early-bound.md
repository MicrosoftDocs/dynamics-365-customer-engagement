---
title: "Sample: Associate records (early bound) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to associate a contact with three account records using the IOrganizationService.EntityReferenceCollection) method. It also shows how to use the IOrganizationService.EntityReferenceCollection) method"
keywords: ""
ms.date: 12/12/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 6e711355-6041-4db9-9932-375a8e8705df
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords:
  - "sample for associating records (early bound)"
  - "associating records (early bound) sample, early-bound class samples"
  - "early-bound class samples, associating records (early bound) sample"
  - "samples for early-bound classes, associating records (early bound) sample"
topic-status: Drafting
---

# Sample: Associate records (early bound)

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the Sample: [Work with early bound entity classes in code](https://code.msdn.microsoft.com/Work-with-early-bound-6914f6e7).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
 [Full Sample – C#](sample-associate-records-early-bound.md#full_C)  
  
## Demonstrates  
 This sample shows how to associate a contact with three account records using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*> method. It also shows how to use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*> method.  
  
## Example  
 [!code-csharp[StrongTypes#AssociateDisassociate1](../../snippets/csharp/CRMV8/strongtypes/cs/associatedisassociate1.cs#associatedisassociate1)]  
  
<a name="full_C"></a>   
## Full Sample – C#  
 [!code-csharp[StrongTypes#AssociateDisassociate](../../snippets/csharp/CRMV8/strongtypes/cs/associatedisassociate.cs#associatedisassociate)]  
  
### See also  
 [Use the Early Bound Entity Classes in Code](use-early-bound-entity-classes-code.md)   
 [Sample: Create and Update Records With Related Records (Early Bound)](sample-create-update-records-related-records-early-bound.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Xrm.Sdk.Messages.AssociateRequest>   
 <xref:Microsoft.Xrm.Sdk.Messages.DisassociateRequest>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*>
