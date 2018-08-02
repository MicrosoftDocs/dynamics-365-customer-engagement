---
title: "Enable document management for entities (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Document management can be enabled for customizable entities in Dynamics 365. To enable document management for an entity, set the EntityMetadata.IsDocumentManagementEnabled attribute value to true"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ecda2ce2-e4b6-4c8d-838c-f3d70ad9e63f
caps.latest.revision: 25
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Enable document management for entities

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Document management can be enabled for those entities in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement that can be customized. By default, document management is enabled only for the following entities in a new installation of [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]:  
  
- `Account`  
  
- `KbArticle`  
  
- `Lead`  
  
- `Opportunity`  
  
- `Product`  
  
- `Quote`  
  
- `SalesLiterature`  
  
  To enable document management for an entity, set the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsDocumentManagementEnabled> attribute value to **true**. To disable document management for an entity, set the value to **false**.  
  
> [!NOTE]
>  You must have the System Administrator or System Customizer role to enable or disable document management for an entity.  
  
### See also  
 [SharePoint Extensions for Dynamics 365](integrate-sharepoint.md)   
 [Actions on SharePoint Location Records](actions-on-sharepoint-location-records.md)   
 [Sample: Enable SharePoint Integration](sample-enable-document-management-entities.md)
