---
title: "Sample: Initialize a record from an existing record (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to use the IOrganizationService.InitializeFromRequest message to create new records from an existing record"
keywords: 
ms.date: 12/15/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 1d0d6df3-e905-4b63-beaa-3f72f73bfa17
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: "pehecke"
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Initialize a record from an existing record

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the Sample: [Work with early bound entity classes in code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/EarlyBound). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
-   [Full Sample – C#](sample-initialize-record-existing-record.md#full_C)  
  
## Demonstrates  
 This sample shows how to use the<xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Crm.Sdk.Messages.InitializeFromRequest> message to create new records from an existing record.  
  
## Example  
 [!code-csharp[StrongTypes#InitializeFrom1](../../snippets/csharp/CRMV8/strongtypes/cs/initializefrom1.cs#initializefrom1)]  
  
<a name="full_C"></a>   
## Full Sample – C#  
 [!code-csharp[StrongTypes#InitializeFrom](../../snippets/csharp/CRMV8/strongtypes/cs/initializefrom.cs#initializefrom)]  
  
### See also  
 [Use the Early Bound Entity Classes in Code](use-early-bound-entity-classes-code.md)   
 [Sample: Retrieve license information](sample-retrieve-license-information.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages.InitializeFromRequest>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*>
