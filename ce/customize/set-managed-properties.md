---
title: "Set managed properties (Dynamics 365 Customer Engagement) | MicrosoftDocs"
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
ms.assetid: edaa7d4a-a95f-4d66-a9d9-2ad6051332f7
caps.latest.revision: 41
ms.author: "rdubois"
manager: "brycho"
---
# Set managed properties

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

<a name="BKMK_ManagedProperties"></a>   

 Managed properties only apply when you include an entity with a managed solution and import it into another organization. These settings allow a solution developer to have some control over the level of customization that they want to allow people who install their solution to have. To set managed properties for an entity, select the entity and click **Managed Properties** on the menu bar.  
  
 The **Can be customized** option controls all the other options. If this option is `False`, none of the other settings apply. When it is `True`, you can specify the other customization options.  
  
 Entities have more managed properties than any other type of solution component. If the entity is customizable, you can set the following options:  
  
- **Display name can be modified**  
  
- **Can Change Additional Properties**  
  
- **New forms can be created**  
  
- **New charts can be created**  
  
- **New views can be created**  
  
 Except for **Can Change Additional Properties**, these options should be self-explanatory. The **Can Change Additional Properties** property simply means anything not covered by the other options. If you set all the individual options to `False`, you might as well set **Can be customized** to `False`.  