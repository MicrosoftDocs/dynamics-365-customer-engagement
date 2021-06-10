---
title: "Set managed properties for fields with Dynamics 365 Customer Engagement (on-premises)  | MicrosoftDocs"
description: "Learn how to set managed properties for a field"
ms.custom: 
ms.date: 04/29/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 4ddcfcf3-5604-4b93-a5ee-589d4fb97fa4
caps.latest.revision: 33
ms.author: matp
manager: kvivek
tags: 
---
# Set managed properties for fields

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [View and edit field managed properties](/power-platform/alm/managed-properties-alm#view-and-edit-field-managed-properties)

<a name="BKMK_SettingManagedProperties"></a>   

 Managed properties only apply when you include fields in a managed solution and import the solution into another environment. These settings allow a solution maker to have some control over the level of customization that people who install their managed solution can have when they customize this field. To set managed properties for a field, select **Managed Properties** on the menu bar.  
  
 The **Can be customized** option controls all the other options. If this option is `False`, none of the other settings apply. When it is `True`, you can specify the other customization options.  
  
 If the field is customizable, you set the following options to `True` or `False`.  
  
- **Display name can be modified**  
  
- **Can change requirement level**  
  
- **Can change Additional Properties**  
  
  These options are self-explanatory. If you set all the individual options to `False`, you might as well set **Can be customized** to `False`.  

  ### See also

  [Create and edit fields](../customize/create-edit-fields.md)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]