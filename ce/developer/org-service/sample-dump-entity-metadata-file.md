---
title: "Sample: Dump entity metadata to a file (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to write out all the entity metadata to an XML file. It uses the RetrieveAllEntitiesRequest message. "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0a0247f3-3a59-42d1-b865-54d0f34e4aad
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Dump entity metadata to a file

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. [Download the work with entity metadata sample](https://code.msdn.microsoft.com/Samples-of-entities-916efa41).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to write out all the entity metadata to an XML file. It uses the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest> message.  
  
 The following sample creates a new file at \Entities\bin\Debug\EntityInfo.xml. You can open this file in [!INCLUDE[pn_MS_Excel_Full](../../includes/pn-ms-excel-full.md)] to see a tabular report. You may need this information to discover the entity type code for a custom entity for use in reports.  
  
## Example  
 [!code-csharp[entities#DumpEntityInfo](../../snippets/csharp/CRMV8/entities/cs/dumpentityinfo.cs#dumpentityinfo)]  
  
### See also  
 [Customize Entity Metadata](../customize-entity-metadata.md)   
 [Sample: Dump Entity Privilege Information to a File](sample-dump-entity-privilege-information-file.md)   
 [Extend the Metadata Model for Dynamics 365](use-organization-service-metadata.md)   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest>   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesResponse>