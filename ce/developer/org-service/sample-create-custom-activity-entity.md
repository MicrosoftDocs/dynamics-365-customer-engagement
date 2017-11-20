---
title: "Sample: Create a custom activity entity (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to create a custom activity entity. It uses the CreateEntityRequest message and sets the EntityMetadata.IsActivity property to true."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d227f8b1-65c7-4d08-9fdc-6162c3f0bdbb
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Create a custom activity entity

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the sample: [Work with entity metadata](https://code.msdn.microsoft.com/Samples-of-entities-916efa41).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create a custom activity entity. It uses the <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest> message and sets the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsActivity> property to `true`.  
  
## Example  
 [!code-csharp[entities#CreateCustomActivityEntity](../../snippets/csharp/CRMV8/entities/cs/createcustomactivityentity.cs#createcustomactivityentity)]  
  
### See also  
 [Extend the Metadata Model for Dynamics 365](use-organization-service-metadata.md)   
 [Create a Custom Activity Entity](create-custom-activity-entity.md)   
 [Customize entity metadata](../customize-entity-metadata.md)   
 [Sample: Create and Update an Emailable Entity](sample-create-update-emailable-entity.md)   
 <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest>