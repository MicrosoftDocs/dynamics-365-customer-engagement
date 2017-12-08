---
title: "Sample: Create and update records with related records (early bound) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to create and update a record and related records in one call by using the IOrganizationService.Entity) and IOrganizationService. Entity) methods"
keywords: ""
ms.date: 12/12/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 72eeafd8-8dd5-40af-9e3d-575534d60f61
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - "sample for creating and updating records with related records (early bound)"
  - "early-bound class samples, creating and updating records with related records (early bound) sample"
  - "creating and updating records with related records (early bound) sample, early-bound class samples"
  - "samples for early-bound classes, creating and updating records with related records (early bound) sample"
caps.latest.revision: 21
topic-status: Drafting
---

# Sample: Create and update records with related records (early bound)

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the Sample: [Work with early bound entity classes in code](https://code.msdn.microsoft.com/Work-with-early-bound-6914f6e7).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create and update a record and related records in one call by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> and<xref:Microsoft.Xrm.Sdk.IOrganizationService>. <xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> methods.  
  
## Example  
 [!code-csharp[Strongtypes#CompoundCreateUpdate](../../snippets/csharp/CRMV8/strongtypes/cs/compoundcreateupdate.cs#compoundcreateupdate)]  
  
### See also  
 [Use the Early Bound Entity Classes in Code](use-early-bound-entity-classes-code.md)   
 [Sample: Assign a Record to a New Owner](sample-assign-record-new-owner.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>
