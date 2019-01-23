---
title: "Sample: Query connections by a record (early bound) (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to query connections for a particular record after creating connections between a contact and two accounts."
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
  - sample for querying connections for a particular record
  - querying connections for a particular record, sample
ms.assetid: b1155815-cab2-459f-b363-2b337dcfb453
caps.latest.revision: 14
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Query connections by a record (early bound)

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the Business Management samples](https://code.msdn.microsoft.com/Business-Management-Samples-6a482e62).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to query connections for a particular record. It creates connections between a contact and two accounts, and then searches for the contact’s connections.  
  
## Example  
 [!code-csharp[BusinessManagement#QueryConnections](../snippets/csharp/CRMV8/businessmanagement/cs/queryconnections.cs#queryconnections)]  
  
### See also  
 [Sample Code for Connection Entities](sample-code-connection-entities.md)   
 [Connection Entities](connection-entities.md)
