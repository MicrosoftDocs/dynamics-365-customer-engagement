---
title: "Sample: Query metadata and detect changes (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to use the classes and methods in the Query and Metadata namespaces to query for specific items of metadata and then track changes to the organization metadata. "
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 1df1931b-51a2-4992-9985-cb6da7605ed5
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 21
topic-status: Drafting
---

# Sample: Query metadata and detect changes

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the sample: [Query metadata and detect changes](https://code.msdn.microsoft.com/Sample-for-query-metadata-98848365).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to use the classes and methods in the <xref:Microsoft.Xrm.Sdk.Metadata.Query> and <xref:Microsoft.Xrm.Sdk.Metadata> namespaces to query for specific items of metadata and then track changes to the organization metadata.  
  
## Example  
 This sample creates an in-memory cache of all option-set option labels for certain entities. Then, a custom entity that contains OptionSet attributes is added and the cache of option-set option labels is updated. Then a single option is added to one of the custom OptionSet attributes and the cache is updated to add it. Finally, the custom entity is deleted and the cache of option-set option labels is again updated to reflect this change.  
  
 The sample will display output similar to the following when it is complete.  
  
-   463 option labels for 5 entities added to the cache.  
  
-   ClientVersionStamp: 296297!10/22/2012 21:41:57  
  
-   Adding a custom entity named sample_SampleEntityForMetadataQuery with a custom optionset attribute named : sample_ExampleOptionSet  
  
-   8 option labels for 1 entities were added to the cache.  
  
-   471 Option Labels cached  
  
-   No Option Labels removed.  
  
-   ClientVersionStamp: 296646!10/22/2012 21:42:06  
  
-   Adding an additional option to the sample_ExampleOptionSet attribute options.  
  
-   1 option labels for 1 entities were added to the cache.  
  
-   472 Option Labels cached  
  
-   No Option Labels removed.  
  
-   ClientVersionStamp: 296649!10/22/2012 21:42:16  
  
-   Current Options: 472  
  
-   Deleting the sample_SampleEntityForMetadataQuery custom entity  
  
-   No option labels were added to the cache.  
  
-   9 Option Labels removed  
  
-   463 Total Option Labels currently cached  
  
-   ClientVersionStamp: 297079!10/22/2012 21:42:34  
  
 [!code-csharp[MetadataQuery#MetadataQuery](../../snippets/csharp/CRMV8/metadataquery/cs/metadataquery.cs#metadataquery)]  
  
### See also  
 [Retrieve and detect changes to metadata](../retrieve-detect-changes-metadata.md)
