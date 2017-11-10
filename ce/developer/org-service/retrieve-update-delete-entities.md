---
title: "Retrieve, update, and delete entities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn how to retrieve, update, and delete an entity by using the custom entity."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 67571a52-57bf-4872-add5-11f76d3b5adc
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Retrieve, update, and delete entities

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This topic shows how to retrieve, update, and delete an entity by using the custom `Bank Account` entity created in [Create a Custom Entity](create-custom-entity.md).  
  
<a name="BKMK_RetrieveAndUpdateEntity"></a>   
## Retrieve and update an entity  
 The following sample retrieves an entity by using the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityRequest> message. It then updates the entity to disable mail merge by setting the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsMailMergeEnabled> property to `false`, and sets <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest.HasNotes> to `true` in the <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest> to specify that the entity should include a relationship to the `Annotation` entity so that the entity can display notes.  
  
 [!code-csharp[Entities#CreateUpdateEntityMetadata9](../../snippets/csharp/CRMV8/entities/cs/createupdateentitymetadata9.cs#createupdateentitymetadata9)]  
  
<a name="BKMK_DeleteCustomEntity"></a>   
## Delete a custom entity  
 The following sample uses the <xref:Microsoft.Xrm.Sdk.Messages.DeleteEntityRequest> message to delete the entity with the logical name specified by the `_customEntityName` variable.  
  
 [!code-csharp[Entities#CreateUpdateEntityMetadata10](../../snippets/csharp/CRMV8/entities/cs/createupdateentitymetadata10.cs#createupdateentitymetadata10)]  
  
### See also  
 [Use the IOrganizationService Sample and Helper Code](use-sample-helper-code.md)   
 [Customize entity metadata](../customize-entity-metadata.md)   
 [Create and update an entity than can be emailed](create-update-entity-emailed.md)   
 [Create a Custom Entity](create-custom-entity.md)
