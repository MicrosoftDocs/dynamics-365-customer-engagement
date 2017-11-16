---
title: "Sample: Enable duplicate detection and retrieve duplicates (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrating how to enable duplicate detection and retrieve duplicate records based on active duplicate detection rules."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "detecting duplicate data in Microsoft Dynamics CRM, sample for enabling duplicate detection and retrieving duplicates"
  - "duplicate detection, sample for enabling duplicate detection and retrieving duplicates"
  - "enabling duplicate detection and retrieving duplicates sample"
  - "sample for enabling duplicate detection and retrieving duplicates"
ms.assetid: f3c2e3c0-5d17-43d8-a614-d772ae1c747e
caps.latest.revision: 14
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Enable duplicate detection and retrieve duplicates

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the sample: [With duplicate detections](https://code.msdn.microsoft.com/Work-with-duplicate-9c7d6f59).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to enable duplicate detection and retrieve duplicate records.  
  
## Example  
 [!code-csharp[DuplicateDetection#EnableDuplicateDetectionAndRetrieveDuplicates](../snippets/csharp/CRMV8/duplicatedetection/cs/enableduplicatedetectionandretrieveduplicates.cs#enableduplicatedetectionandretrieveduplicates)]  
  
### See also  
 [Detect Duplicate Data in Dynamics 365](detect-duplicate-data-for-developers.md)   
 [Enable and disable duplicate detection](enable-disable-duplicate-detection.md)   
 [Run Duplicate Detection](run-duplicate-detection.md)   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveDuplicatesRequest>   
 [Sample: Invoke Duplicate Detection For Creating and Updating Records](sample-use-duplicate-detection-when-creating-and-updating-records.md)
