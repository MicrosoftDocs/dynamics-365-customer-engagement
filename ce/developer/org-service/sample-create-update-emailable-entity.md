---
title: "Sample: Create and update an emailable entity (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to create an entity that can be used in the To field of an email activity. It uses the CreateEntityRequest message. "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a3954fc9-6b40-4b7d-ba6e-51c50e004723
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Create and update an emailable entity

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the sample: [Work with entity metadata](https://code.msdn.microsoft.com/Samples-of-entities-916efa41).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create an entity that can be used in the **To** field of an email activity. It uses the <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest> message.  
  
## Example  
 [!code-csharp[entities#CreateUpdateEmailableEntity](../../snippets/csharp/CRMV8/entities/cs/createupdateemailableentity.cs#createupdateemailableentity)]  
  
### See also  
 [Extend the Metadata Model for Dynamics 365](use-organization-service-metadata.md)   
 [Customize entity metadata](../customize-entity-metadata.md)   
 [Sample: Dump Entity Metadata to a File](sample-dump-entity-metadata-file.md)   
 [Create and Update an Emailable Entity](create-update-entity-emailed.md)
