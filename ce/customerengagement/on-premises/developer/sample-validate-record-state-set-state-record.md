---
title: "Sample: Validate record state and set the state of the record (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample demonstrates how to validate a change of state of an entity and set a state of an entity."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
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

This sample code is for Dynamics 365 Customer Engagement (on-premises) and Common Data Service. Download the complete sample from [Business Management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement) 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to validate a change of state of an entity and set a state of an entity.  
  
## Example  
 [!code-csharp[BusinessManagement#ValidateAndSetState](../snippets/csharp/CRMV8/businessmanagement/cs/validateandsetstate.cs#validateandsetstate)]  
  
### See also  
 [Introduction to Entities in Dynamics 365 Customer Engagement (on-premises)](introduction-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>   
 [Sample: Rollup records related to a specific record](sample-rollup-records-related-specific-record.md)
