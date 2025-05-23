---
title: "Change custom entity icons in Dynamics 365 Customer Engagement (on-premises)"
description: "Custom entities are automatically assigned the same default icon. To help users differentiate between entities, follow these steps to change the icons."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: how-to
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: 477f9792-8207-49ef-8968-45274b5355a8
caps.latest.revision: 19
ms.author: matp
tags: 
  - Links to topic not migrated
search.audienceType: 
  - customizer

---
# Change the icon for a custom entity

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Change model-driven app custom entity icons](/powerapps/maker/model-driven-apps/change-custom-entity-icons)

When you create a custom entity, it is automatically assigned a default icon, and all custom entities by default use the same icon. If your organization has several custom entities, it can be helpful to change the icon associated with one or more custom entities to help users differentiate them.  
  
> [!NOTE]
>  You can’t modify the icons assigned to system entities.  
  
 You can upload two types of entity icons for each custom entity:  
  
- **Icon in web application**. This icon should be:  
  
    -   16 x 16 pixels in size.  
  
    -   In .gif, .png, or .jpg format.  
  
    -   No larger than 10 kilobytes.  
  
- **Icon for entity forms**. This icon should be:  
  
    -   32 x 32 pixels in size.  
  
    -   16 colors.  
  
    -   In .ico format.  
  
    -   No larger than 10 kilobytes.  
  
  
1. Open solution explorer, expand **Entities** if necessary, select the custom entity you want to update the icon for, and then on the command bar, select **Update Icons**.  
  
2. In the **Select New Icons** dialog box, under **Icon in Web application** or **Icon for Entity Forms**, to the right of **New Icon**, select the **Browse** button ![Lookup button.](../customize/media/lookup-button-4.gif "Lookup button"), select the appropriate image file, and then select **OK**.  
  
3. On the command bar, on the **File** menu, select **Save**.  
  
4. When your customizations are complete, publish them:  
  
   - To publish customizations for only the component that you are currently editing, in the Navigation Pane, select the entity you have been working on, and then select **Publish**.  
  
   - To publish customizations for all unpublished components at one time, in the Navigation Pane, select **Entities**, and then on the command bar, select **Publish All Customizations**.  
  
     New icons might not display in the app until you close and reopen the it.  
  
> [!NOTE]
>  Publishing customizations can interfere with normal system operation. We recommend you schedule publishing when it’s least disruptive to users.  
  
## Community tools

**Iconator** is a tool that XrmToolbox community developed for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] change-custom-entity-icons. Please see the [Developer tools](../developer/developer-tools.md) topic for community developed tools.

> [!NOTE]
> The community tools are not a product of [!include[pn_microsoft_dynamics](../includes/pn-microsoft-dynamics.md)] and does not extend support to the community tools. 
> If you have questions pertaining to the tool, please contact the publisher. More Information: [XrmToolBox](https://www.xrmtoolbox.com).

### See also  
 [Create and edit entities](../customize/create-edit-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
