---
title: "Delete custom entities with Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn how to delete a custom entity"
ms.custom: 
ms.date: 12/03/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: e6ed6324-16ae-4c2b-b9a0-2422f54ccafb
caps.latest.revision: 41
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Delete custom entities

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Delete an entity](/powerapps/maker/common-data-service/data-platform-delete-entity)

<a name="BKMK_DeleteCustomEntities"></a>   
  
 As someone with the system administrator security role, you can delete custom entities that aren’t part of a managed solution.  
  
> [!IMPORTANT]
>  When you delete a custom entity, the database tables that store data for that entity are deleted and all data they contain is lost. Any associated records that have a parental relationship to the custom entity are also deleted. For more information about parental relationships, see [Create and edit entity relationships](../customize/create-edit-entity-relationships.md).  
  
 Before you can delete a custom entity, you must remove any dependencies that exist in other solution components. For example, if another entity has a lookup field on a form that uses this custom entity, you must first remove that field from the form before you can delete the custom entity. This also applies to views defined for other entities that include a reference to this entity. If you try to delete the entity and any dependencies are discovered, the deletion won’t be allowed. Select **Show Dependencies** on the menu bar to help identify any dependencies that you have to remove before the entity can be deleted.  
  
 The only way to recover data from an entity that was deleted is to restore the database from a point before the entity was deleted. 
 
### See also
[Create or edit an entity](create-edit-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]