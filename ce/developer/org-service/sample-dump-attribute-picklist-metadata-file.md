---
title: "Sample: Dump attribute picklist metadata to a file (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to write out all the attribute metadata to an XML file. It uses the RetrieveAllEntitiesRequest message."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0cfa185c-1845-40b4-8293-ffa540b6053c
caps.latest.revision: 16
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Dump attribute picklist metadata to a file

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. [Download the work with attribute metadata sample](https://code.msdn.microsoft.com/Samples-of-attributes-1c0f93e7).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to write out all the entity metadata to an XML file. It uses the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest> message.  
  
 The following sample creates a new file at \Entities\bin\Debug\AttributePicklistValues.xml. You can open this file in [!INCLUDE[pn_MS_Excel_Full](../../includes/pn-ms-excel-full.md)] to see a tabular report. This is useful to look up the valid values for each picklist. This information can also be found in the “*EntityName* Entity OptionSet Attribute Metadata” topic for each entity.  
  
## Example  
 [!code-csharp[Attributes#DumpPicklistInfo](../../snippets/csharp/CRMV8/attributes/cs/dumppicklistinfo.cs#dumppicklistinfo)]  
  
### See also  
 [Customize entity metadata](../customize-entity-metadata.md)   
 [Extend the Metadata Model for Dynamics 365](use-organization-service-metadata.md)   
 [Customize Entity Attribute Metadata](../customize-entity-attribute-metadata.md)   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest>   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesResponse>