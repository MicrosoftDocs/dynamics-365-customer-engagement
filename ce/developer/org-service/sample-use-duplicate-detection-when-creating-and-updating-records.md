---
title: "Sample: Use duplicate detection when creating and updating records (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrating how to detect duplicate records when when creating and updating entity records."
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
  - "running duplicate detection to create and update records sample"
  - "duplicate detection, sample for invoking duplicate detection to create and update records"
  - "detecting duplicate data in Microsoft Dynamics CRM, sample for invoking duplicate detection to create and update records"
  - "sample for running duplicate detection to create and update records"
  - "sample for invoking duplicate detection to create and update records"
  - "invoking duplicate detection to create and update records sample"
ms.assetid: 99e3570c-39d6-46a2-9574-e8dedc99fd65
caps.latest.revision: 14
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Use duplicate detection when creating and updating records

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. [Download the work with duplicate detections sample](https://code.msdn.microsoft.com/Work-with-duplicate-9c7d6f59).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to invoke duplicate detection for creating and updating entity records.  
  
## Example  
 [!code-csharp[DuplicateDetection#InvokeDuplicateDetectionForCreateAndUpdate](../../snippets/csharp/CRMV8/duplicatedetection/cs/invokeduplicatedetectionforcreateandupdate.cs#invokeduplicatedetectionforcreateandupdate)]  
  
### See also  
 [Detect Duplicate Data in Dynamics 365](../detect-duplicate-data-for-developers.md)   
 [Run Duplicate Detection](../run-duplicate-detection.md)   
 [Use Messages (Request and Response Classes) with the Execute Method](use-messages-request-response-classes-execute-method.md)   
 [Pass Optional Parameters in Messages](use-messages-request-response-classes-execute-method.md#bkmk_optional_params)   
 [Sample: Detect Multiple Duplicate Records](../sample-detect-multiple-duplicate-records.md)  
 [Duplicate detection messages](../duplicate-detection-messages.md)
