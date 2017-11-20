---
title: "Sample: Dump attribute metadata to a file (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to write out all the attribute metadata to an XML file. It uses the RetrieveAllEntitiesRequest message."
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: f2321671-f4dc-4abd-ac50-edddfa170fd2
author: JimDaly
ms.author: jdaly
manager: jdaly
---

# Sample: Dump attribute metadata to a file

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the sample: [Work with attribute metadata](https://code.msdn.microsoft.com/Samples-of-attributes-1c0f93e7).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to write out all the attribute metadata to an XML file. It uses the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest> message.  
  
 The following sample creates a new file at \Entities\bin\Debug\AllAttributeDesc.xml. You can open this file in [!INCLUDE[pn_MS_Excel_Full](../../includes/pn-ms-excel-full.md)] to see a tabular report. You can easily look up information such as which attributes can be specified in a create, retrieve, or update operation. This information can also be found in the “*EntityName* Entity Attribute Metadata” topic for each entity.  
  
## Example  
 [!code-csharp[Attributes#DumpAttributeInfo](../../snippets/csharp/CRMV8/attributes/cs/dumpattributeinfo.cs#dumpattributeinfo)]  
  
### See also  
 [Customize entity attribute metadata](../customize-entity-attribute-metadata.md)   
 [Sample: Dump attribute picklist metadata to a file](sample-dump-attribute-picklist-metadata-file.md)   
 [Extend the Metadata Model for Dynamics 365](use-organization-service-metadata.md)   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest>   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesResponse>