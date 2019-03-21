---
title: "Sample: Rollup records related to a specific record (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "The sample demonstrates how to roll up opportunities by the parent account. "
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
  - related records sample, rolling up
  - rolling up records sample
ms.assetid: 59c8a58c-1add-4c29-915f-8aa0ae07f30c
caps.latest.revision: 16
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Rollup records related to a specific record

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the Business Management samples](https://code.msdn.microsoft.com/Business-Management-Samples-6a482e62).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to roll up opportunities by the parent account.  
  
## Example  
 [!code-csharp[BusinessManagement#RollupByObject](../snippets/csharp/CRMV8/businessmanagement/cs/rollupbyobject.cs#rollupbyobject)]  
  
### See also  
 [Introduction to Entities in Dynamics 365 for Customer Engagement apps](introduction-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.RollupRequest>   
 [Sample: Set and retrieve entity images](sample-set-retrieve-entity-images.md)
