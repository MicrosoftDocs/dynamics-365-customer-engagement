---
title: "Delete fields | MicrosoftDocs"
description: "Learn how to delete fields"
ms.date: 11/03/2018
ms.service: crm-online
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 578ac950-da16-4ec6-a0a4-25f3aaa3b96e
caps.latest.revision: 33
ms.author: matp
manager: kvivek
tags: 
search.audienceType: 
  - customizer

---
# Delete fields

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Delete fields in Power Apps](/powerapps/maker/common-data-service/delete-fields)

<a name="BKMK_DeletingFields"></a>   
 
 As someone with the system administrator security role, you can delete any custom fields that aren’t part of a managed solution. When you delete a field, any data stored in the field is lost. The only way to recover data from a field that was deleted is to restore the database from a point before the field was deleted.  
  
 Before you can delete a custom field, you must remove any dependencies that may exist in other solution components. Open the field and use the **Show Dependencies** button in the menu bar to view any **Dependent Components**. For example, if the field is used in a form or view, you must first, remove references to the field in those solution components.  
  
 If you delete a lookup field, the 1:N entity relationship for it will automatically be deleted.  

 ### See also

 [Delete custom entities](delete-custom-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]