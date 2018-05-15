---
title: "Edit an entity in PowerApps | MicrosoftDocs"
description: "Learn the different ways that an entity can be edited"
ms.custom: ""
ms.date: 05/15/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
  - "powerapps"
author: "Mattp123"
ms.assetid: 8b00780c-74f0-4e3a-b570-b9289d0d5383
caps.latest.revision: 41
ms.author: "matp"
manager: "kvivek"
---
# Edit an entity

You can edit any custom entity that you create. System entities or managed custom entities may have limitations about changes you can make.  
  
 System entities are any entities that are included with your environment. Managed custom entities are entities that have been added to the system by importing a managed solution. The degree to which you can edit these entities is determined by the managed properties set for each entity. Any properties that can’t be edited will be disabled. To view the [Set managed properties overview](../model-driven-apps/set-managed-properties.md) for an entity selected in the solution explorer, select **Managed Properties** on the menu bar.  
  
> [!NOTE]
>  You must publish customizations after you save changes to an existing entity. More information: [Publishing customizations](../model-driven-apps/getting-started-customization.md#publishing-customizations) 
  
 When you edit entities you can make the following metadata changes:  
  
- **Edit the entity fields**. More information:  [Create and edit fields (attributes)](create-edit-fields.md)
  
- **Edit the entity relationships**. More information:  [Create and edit relationships between entities](create-edit-entity-relationships.md)
  
 You can also make changes to records that support the entity:  
  
- **Forms**. More information:  [Create and design forms](../model-driven-apps/create-design-forms.md)
  
- **Business Rules**. More information: [Create business rules and recommendations to apply logic in a form](../model-driven-apps/create-business-rules-recommendations-apply-logic-form.md)

- **Business Process Flows**. More information: [Business process flows overview](../model-driven-apps/business-process-flows-overview.md)
  
 For your custom entities you can change the **Areas that display this entity**, but for system entities or managed custom entities you will find that the options are disabled.  
  
<a name="BKMK_ChangeEntityName"></a> 
  
## Change the name of an entity  

 Use the **Display Name** and **Plural Name** properties to change the name of the entity in the application. However, the name of many system entities may also be used in other text in the application. To locate and change text where this name was used, see [Edit system entity messages](edit-system-entity-messages.md)
  
<a name="BKMK_ChangeEntityIcon"></a>   

## Change the icons used for custom entities  

 By default, all custom entities in the web application have the same icons. You can create image web resources for the icons you want for your custom entities and set them using the **Update Icons** button on the toolbar. There are two sizes of icons:  
  
- **Icon in Web Application** This icon should be 16x16 pixels.  
  
- **Icon for Entity Forms** This icon should be 32x32 pixels.  
  
 Both icons should be no larger than 10 KB. PNG format files with transparent backgrounds are recommended. More information:  [Change icons for custom entities](../model-driven-apps/change-custom-entity-icons.md).  
  
> [!NOTE]
> Dynamics 365 for tablets and Dynamics 365 for phones don’t display custom icons for custom entities.  
  
<a name="BKMK_EnableOptions"></a>  
 
## Entity options that can only be enabled  

 The following table lists the options that you can enable for an entity, but after these items are enabled, they can’t be disabled:  

[!INCLUDE [cc_entity-set-once-options-table](../../includes/cc_entity-set-once-options-table.md)] 
  
<a name="BKMK_EnableDisableOptions"></a>  
 
## Enable or disable entity options  

 The following table lists the entity options that you can enable or disable at any time.  

[!INCLUDE [cc_entity-changeable-options-table](../../includes/cc_entity-changeable-options-table.md)] 

### See also

[Create an entity](create-entities.md)<br />
[Tutorial: Create an entity in Solution Explorer](create-entity-solution-explorer.md)
