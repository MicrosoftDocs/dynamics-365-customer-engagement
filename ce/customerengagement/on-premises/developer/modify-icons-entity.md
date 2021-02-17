---
title: "Modify the icons for an entity (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about modifying the icons for an entity."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - modifying icons for entities, types of
  - modifying icons for entities, properties for
  - customizing entity metadata, modifying icons for entities
  - icons, customizing for entities
  - entities, modifying icons for
  - custom icons, modifying for entities
  - modifying icons for entities, default specifications for icons
ms.assetid: 32fbb402-3808-4d9a-b2e3-6acecb4bb62a
caps.latest.revision: 27
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---

# Modify the icons for an entity

When you create a new entity, default icons are provided. You can change the icons of custom entities by creating image Web resources and updating `EntityMetadata` (<xref href="Microsoft.Dynamics.CRM.EntityMetadata?text=EntityMetadata EntityType" /> or <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata> class) properties. Use the specifications in this topic when creating or ordering icons. You will need the icon files before you begin.  

> [!NOTE]
>  When you first associate Web Resources with icons in the application the size of the icons will be checked. If you associate Web Resources programmatically, no size validation occurs. If the Web Resource is later updated with a large size image, no validation occurs.  

 For more information about how to manually update icons, see [Change entity icons](https://go.microsoft.com/fwlink/p/?LinkId=316860).  

## Types of icons  
 The following table liststhe types of entity icons you can update.  


|                                                             Type                                                             |           Specifications           |                            Property                             |
|------------------------------------------------------------------------------------------------------------------------------|------------------------------------|-----------------------------------------------------------------|
|            **Icon in Web application**<br /><br /> Displays when records for this entity are displayed in a grid.            | -   16x16px<br />-   Less than 10k | <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IconSmallName>  |
|                                                  **Icon for Entity Forms**                                                   | -   32x32px<br />-   Less than 10k | <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IconMediumName> |
| This size icon is not used in Dynamics 365 Customer Engagement (on-premises). | -   66x48px<br />-   Less than 10k | <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IconLargeName>  |

 PNG Web resources are recommended because they support transparency and good compression with a better color fidelity than GIF. GIF, JPG, and ICO formats are supported for backwards compatibility when organizations are upgraded from [!INCLUDE[pn_Microsoft_Dynamics_CRM_4.0](../includes/pn-microsoft-dynamics-crm-4-0.md)].  

### See also  
 [Customize Entity Metadata](customize-entity-metadata.md)   
 [Modify Entity Messages](modify-messages-entity.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]