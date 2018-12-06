---
title: "Sample: Validate record state and set the state of the record (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "The sample demonstrates how to validate a change of state of an entity and set a state of an entity."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
helpviewer_keywords: 
  - setting record states sample
  - validating record states sample
  - record states, sample for validating and setting
ms.assetid: 6b2f00ca-dbac-47d8-ab4a-0be52b72f05d
caps.latest.revision: 15
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Validate record state and set the state of the record

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Business Management samples](https://code.msdn.microsoft.com/Business-Management-Samples-6a482e62) 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to validate a change of state of an entity and set a state of an entity.  
  
## Example  
 [!code-csharp[BusinessManagement#ValidateAndSetState](../snippets/csharp/CRMV8/businessmanagement/cs/validateandsetstate.cs#validateandsetstate)]  
  
### See also  
 [Introduction to Entities in Dynamics 365 for Customer Engagement apps](introduction-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>   
 [Sample: Rollup records related to a specific record](sample-rollup-records-related-specific-record.md)
