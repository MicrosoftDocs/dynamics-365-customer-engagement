---
title: "Sample: Dump entity privilege information to a file (Dynamics 365 Customer Engagement SDK) | MicrosoftDocs"
description: "This sample shows how to extract entity privilege information into a file using the organization service."
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 22c60ceb-a0d4-460f-a3ce-d8541cf2da21
author: JimDaly
ms.author: jdaly
manager: jdaly
---

# Sample: Dump entity privilege information to a file

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. [Download the work with entity metadata sample](https://code.msdn.microsoft.com/Samples-of-entities-916efa41).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to write entity privilege information to an XML file, which will be located at \Entities\bin\Debug\EntityPrivileges.xml. It uses the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest> message.  
  
## Example  
 [!code-csharp[entities#DumpEntityInfo](../../snippets/csharp/CRMV8/entities/cs/dumpentityinfo.cs#dumpentityinfo)]  
  
### See also  
 [Customize Entity Metadata](../customize-entity-metadata.md)   
 [Extend the Metadata Model for Dynamics 365](use-organization-service-metadata.md)   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest>   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesResponse>
