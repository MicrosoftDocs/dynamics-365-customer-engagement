---
title: "Create a custom activity entity (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to create a custom activity entity."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2016"
  - "Dynamics CRM Online"
ms.assetid: 56e37fe0-182e-4021-a0b1-b32cba93d49e
caps.latest.revision: 13
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Create a custom activity entity

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This topic contains a sample that shows how to create a custom activity entity.  
  
 The following sample creates a custom entity and sets the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsActivity> property to `true`. All activities must have a <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest.PrimaryAttribute><xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.SchemaName> set to `Subject` so that it corresponds to the common `ActivityPointer`.`Subject` attribute used by all activities.  
  
 [!code-csharp[Entities#CreateCustomActivityEntity1](../../snippets/csharp/CRMV8/entities/cs/createcustomactivityentity1.cs#createcustomactivityentity1)]  
  
### See Also  

 <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest>  
 [Use the sample and helper code](use-sample-helper-code.md)   
 [Custom activities](../custom-activities.md)   
 [Customize entity metadata](../customize-entity-metadata.md)   
 [Modify Entity Icons](../modify-icons-entity.md)   
 [Modify Entity Messages](../modify-messages-entity.md)   
 [Sample: Create a custom activity](../sample-create-custom-activity.md)