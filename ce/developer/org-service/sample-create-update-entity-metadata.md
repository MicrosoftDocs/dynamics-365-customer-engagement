---
title: "Sample: Create and update entity metadata (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to create a custom entity by using the CreateEntityRequest message. It also uses the CreateAttributeRequest to add several different types of attributes to the entity."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 237c75a2-cae5-467b-b894-ab0f7572e7f9
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Sample: Create and update entity metadata
This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. [Download the work with entity metadata sample](https://code.msdn.microsoft.com/Samples-of-entities-916efa41). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create a custom entity by using the <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest> message. It also uses the <xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest> to add several different types of attributes to the entity.  
  
## Example  
 [!code-csharp[entities#CreateUpdateEntityMetadata](../../snippets/csharp/CRMV8/entities/cs/createupdateentitymetadata.cs#createupdateentitymetadata)]  
  
### See also  
 [Customize entity metadata](../customize-entity-metadata.md)   
 [Sample: Create a Custom Activity Entity](sample-create-custom-activity-entity.md)   
 [Extend the Metadata Model for Dynamics 365](use-organization-service-metadata.md)   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest>   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesResponse>