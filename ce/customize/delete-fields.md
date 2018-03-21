---
title: "Delete fields (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "rdubois-msft"
ms.assetid: 578ac950-da16-4ec6-a0a4-25f3aaa3b96e
caps.latest.revision: 33
ms.author: "rdubois"
manager: "brycho"
tags: 
---
# Delete fields

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

<a name="BKMK_DeletingFields"></a>   
 
 As someone with the system administrator security role, you can delete any custom fields that aren’t part of a managed solution. When you delete fields, any data stored in the fields is lost. The only way to recover data from a field that was deleted is to restore the database from a point before the field was deleted.  
  
 Before you can delete a custom entity, you must remove any dependencies that may exist in other solution components. Open the field and use the **Show Dependencies** button in the menu bar to view any **Dependent Components**. For example, if the field is used in a form or view, you must first, remove references to the field in those solution components.  
  
 If you delete a lookup field, the 1:N entity relationship for it will automatically be deleted.  