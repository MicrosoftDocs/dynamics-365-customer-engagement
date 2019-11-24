---
title: "Sample: Create a reciprocal connection role (early bound) (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample code demonstrates how to create the reciprocal connection roles."
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
  - creating reciprocal connection roles, sample
  - sample for creating reciprocal connection roles
ms.assetid: 768e2422-e725-4de4-85c9-17dff24ee69c
caps.latest.revision: 18
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Create a reciprocal connection role (early bound)

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the Business Management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create the reciprocal connection roles. It creates a connection role for an account and a connection role for a contact, and then makes them reciprocal by associating them with each other.  
  
## Example  
 [!code-csharp[BusinessManagement#CreateReciprocalConnectionRole](../snippets/csharp/CRMV8/businessmanagement/cs/createreciprocalconnectionrole.cs#createreciprocalconnectionrole)]  
  
### See also  
 [Sample Code for Connection Entities](sample-code-connection-entities.md)   
 [Connection Entities](connection-entities.md)   
 [Sample: Update a Connection Role (Early Bound)](sample-update-connection-role-early-bound.md)
