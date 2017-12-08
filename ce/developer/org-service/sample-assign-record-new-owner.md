---
title: "Sample: Assign a record to a new owner (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to assign an account to another user by using the AssignRequest message"
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: b8a256a4-e858-44bc-aff7-26b4d670fc61
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords:
  - "samples for early-bound classes, assigning records to new owners sample"
  - "assigning records to new owners sample, early-bound class samples"
  - "early-bound class samples, assigning records to new owners sample"
  - "sample for assigning records to new owners"
topic-status: Drafting
---

# Sample: Assign a record to a new owner

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the Sample: [Work with early bound entity classes in code](https://code.msdn.microsoft.com/Work-with-early-bound-6914f6e7).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
 This sample code requires that you have administrator rights to create a new user. [!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]  
  
## Example  
 This sample shows how to assign an account to another user by using the <xref:Microsoft.Crm.Sdk.Messages.AssignRequest> message.  
  
 [!code-csharp[StrongTypes#Assign](../../snippets/csharp/CRMV8/strongtypes/cs/assign.cs#assign)]  
  
### See also  
 [Use the Early Bound Entity Classes in Code](use-early-bound-entity-classes-code.md)   
 [Sample: Serialize and Deserialize an Entity Instance](sample-serialize-deserialize-entity-instance.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AssignRequest>   
 [Assign](../introduction-entities.md#assign)   
 [Entity ownership](../introduction-entities.md#entity-ownership)   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 [Sample: CrmServiceHelper Class](helper-code-serverconnection-class.md)
