---
title: "Create and update an entity to send email activities to records | MicrosoftDocs"
description: "Learn about creating an entity that contains an email address you can use to send email activities to records for that entity."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: bc1ae819-61c1-4a44-8f38-a6240975b111
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Create and update an entity to send email activities to records

You can create an entity that contains an email address you can use to send email activities to records for that entity.  
  
 The following sample creates a custom entity and sets the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsActivityParty> property to `true`. It also creates a <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata> attribute using <xref:Microsoft.Xrm.Sdk.Metadata.StringFormatName>.`Email` to provide an email address to use.  
  
 Even if you add other <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata> attributes formatted as an email address, only the first one specified is used.  
  
 [!code-csharp[Entities#CreateUpdateEmailableEntity1](../../snippets/csharp/CRMV8/entities/cs/createupdateemailableentity1.cs#createupdateemailableentity1)]  
  
 [!code-vb[EntitiesVB#CreateUpdateEmailableEntity1](../../snippets/visualbasic/CRMV8/entitiesvb/vb/createupdateemailableentity1.vb#createupdateemailableentity1)]  
  
### See Also

 [Use the IOrganizationService Sample and Helper Code](use-sample-helper-code.md)   
 [Customize entity metadata](../customize-entity-metadata.md)   
 [Which Entities are Customizable?](../which-entities-are-customizable.md)   
 [Create a custom entity](create-custom-entity.md)   
 [Retrieve, update, and delete entities](retrieve-update-delete-entities.md)   
 [Create a custom activity entity](create-custom-activity-entity.md)   
 [Change Entity Icons](../modify-icons-entity.md)   
 [Change Entity Messages](../modify-messages-entity.md)   
 [Sample: Create and update an emailable entity](sample-create-update-emailable-entity.md)