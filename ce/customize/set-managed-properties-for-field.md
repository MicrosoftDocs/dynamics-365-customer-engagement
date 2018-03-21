---
title: "Set managed properties for fields (Dynamics 365 Customer Engagement) | MicrosoftDocs"
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
ms.assetid: 4ddcfcf3-5604-4b93-a5ee-589d4fb97fa4
caps.latest.revision: 33
ms.author: "rdubois"
manager: "brycho"
tags: 
---
# Set managed properties for fields

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

<a name="BKMK_SettingManagedProperties"></a>   

 Managed properties only apply when you include fields in a managed solution and import the solution into another organization. These settings allow a solution developer to have some control over the level of customization that people who install their managed solution can have when they customize this field. To set managed properties for a field, click **Managed Properties** on the menu bar.  
  
 The **Can be customized** option controls all the other options. If this option is `False`, none of the other settings apply. When it is `True`, you can specify the other customization options.  
  
 If the field is customizable, you set the following options to `True` or `False`.  
  
- **Display name can be modified**  
  
- **Can change requirement level**  
  
- **Can change Additional Properties**  
  
 These options are self-explanatory. If you set all the individual options to `False`, you might as well set **Can be customized** to `False`.  