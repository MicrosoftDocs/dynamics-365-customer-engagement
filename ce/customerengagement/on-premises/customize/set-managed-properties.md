---
title: "Set managed properties with Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn how to set managed properties of an entity"
ms.custom: 
ms.date: 04/30/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: edaa7d4a-a95f-4d66-a9d9-2ad6051332f7
caps.latest.revision: 41
ms.author: "matp"
manager: "kvivek"
---
# Set managed properties overview
<a name="BKMK_ManagedProperties"></a>   



 Managed properties only apply when you include an entity with a managed solution and import it into another environment. These settings allow a solution maker to have some control over the level of customization that they want to allow people who install their solution to have. To set managed properties for an entity, select the entity and select **Managed Properties** on the menu bar.  
  
 The **Can be customized** option controls all the other options. If this option is `False`, none of the other settings apply. When it is `True`, you can specify the other customization options.  
  
 Entities have more managed properties than any other type of solution component. If the entity is customizable, you can set the following options:  
  
- **Display name can be modified**  
  
- **Can Change Additional Properties**  
  
- **New forms can be created**  
  
- **New charts can be created**  
  
- **New views can be created**  
  
  Except for **Can Change Additional Properties**, these options should be self-explanatory. The **Can Change Additional Properties** property simply means anything not covered by the other options. If you set all the individual options to `False`, you might as well set **Can be customized** to `False`.  

  ### See also
  [Entities, metadata, and the metadata browser](create-edit-metadata.md)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]