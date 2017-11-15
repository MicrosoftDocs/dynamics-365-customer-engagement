---
title: "Sample: Detect multiple duplicate records (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to detect and log multiple duplicate records for a specified entity type."
keywords: ""
ms.date: 11/15/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 5c83c1c2-25ef-480b-9195-6eabe9f6c4c7
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 13
topic-status: Drafting
---

# Sample: Detect multiple duplicate records

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. [Download the work with duplicate detections sample](https://code.msdn.microsoft.com/Work-with-duplicate-9c7d6f59).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to detect and log multiple duplicate records for a specified entity type.  
  
## Example  
 [!code-csharp[DuplicateDetection#BulkDetectDuplicates](../../snippets/csharp/CRMV8/duplicatedetection/cs/bulkdetectduplicates.cs#bulkdetectduplicates)]  
  
### See also  
 [Detect Duplicate Data in Dynamics 365](../detect-duplicate-data-for-developers.md)   
 [Enable and disable duplicate detection](../enable-disable-duplicate-detection.md)   
 [Run Duplicate Detection](../run-duplicate-detection.md)   
 <xref:Microsoft.Crm.Sdk.Messages.BulkDetectDuplicatesRequest>  
 [Duplicate detection messages](../duplicate-detection-messages.md)