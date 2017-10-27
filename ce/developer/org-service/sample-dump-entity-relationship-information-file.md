---
title: "Sample: Dump entity relationship information to a file (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to write out all the entity relationship metadata to an XML file. It uses the RetrieveAllEntitiesRequest message. "
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 41d4f199-7004-4458-a39a-5f9025550932
author: JimDaly
ms.author: jdaly
manager: jdaly
---

# Sample: Dump entity relationship information to a file
This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. [Download the work with entity relationships sample](https://code.msdn.microsoft.com/Samples-of-entity-218db099).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to write out all the entity relationship metadata to an XML file. It uses the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest> message.  
  
 The following sample creates a new file at \Relationships\bin\Debug\RelationshipInfo.xml. You can open this file in [!INCLUDE[pn_MS_Excel_Full](../../includes/pn-ms-excel-full.md)] to see a tabular report. You may need this information to discover the entity type code for a custom entity for use in reports.  
  
## Example  
 [!code-csharp[entities#DumpEntityInfo](../../snippets/csharp/CRMV8/entities/cs/dumpentityinfo.cs#dumpentityinfo)]  
  
### See also  
 [Customize Entity Relationship Metadata](../customize-entity-relationship-metadata.md)   
 [Extend the Metadata Model for Dynamics 365](use-organization-service-metadata.md)   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest>   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesResponse>
