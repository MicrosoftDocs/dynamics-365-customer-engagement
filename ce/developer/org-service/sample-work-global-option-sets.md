---
title: "Sample: Work with global option sets (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2016"
  - "Dynamics CRM Online"
ms.assetid: 348e0bc9-ddde-4bbe-a0aa-968d0d6b0ac2
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Work with global option sets

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work with global option sets](https://code.msdn.microsoft.com/Samples-of-option-set-37c4b418). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to perform the following actions with global option sets:  
  
-   Create, retrieve, or update a global option set.  
  
-   Create a <xref:Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata> attribute using a global option set.  
  
-   Insert or update an option item.  
  
-   Re-order option items.  
  
-   Retrieve all global option sets.  
  
## Example  
 [!code-csharp[optionsets#WorkwithGlobalOptionSets](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets.cs#workwithglobaloptionsets)]  
  
### See also  
 [Extend the Metadata Model for Dynamics 365](use-organization-service-metadata.md)   
 [Customize Global Option Sets in Dynamics 365](customize-global-option-sets.md)   
 [Sample: Dump global option set information to a file](sample-dump-global-option-set-information-file.md)   
 [Global Option Set Messages](customize-global-option-sets.md#messages)