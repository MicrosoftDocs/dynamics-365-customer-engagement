---
title: "Define custom actions to modify the ribbon (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about defining custom actions to modify the ribbon."
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
  - ribbon, hide ribbon elements
  - ribbon, change ribbon elements
  - ribbon, add ribbon elements
ms.assetid: f074df11-da5c-4efe-bbf2-a965f50bf3a9
caps.latest.revision: 18
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Define custom actions to modify the ribbon

The default, an application command bar or ribbon is defined by [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] metadata. This default data can’t be changed, but you can include definitions of specific actions that will override the default ribbon.  
  
## Types of custom actions  
 There are two types of custom actions for ribbons:  
  
- `<CustomAction>`: [!INCLUDE[ribbon_element_CustomAction](../../includes/ribbon-element-customaction.md)]  
  
- `<HideCustomAction>` : [!INCLUDE[ribbon_element_HideCustomAction](../../includes/ribbon-element-hidecustomaction.md)]  
  
### Custom actions  
 A custom action is a statement of how you want to change the default ribbon definition. It is evaluated and applied to the ribbon at runtime. To set the context for a custom action, you must include information about the location of the items that you want to change. Use the `Location` attribute to specify where your change applies.  
  
 When you add a new ribbon element, you refer to the containing element, for example, an existing tab or group. You then include the suffix `._children` to indicate that this custom action will add something to an existing item.  
  
 When you change the definition of an existing item, the `Location` value will match the ID of that item.  
  
 You must also specify a unique identifier for the custom action. Use the **Id** attribute to set this value. We strongly recommend that you use a naming convention that will guarantee a unique value. For consistency and readability, we recommend that you use a period to separate consistent components. The first item in your naming convention should be something related to your solutions publisher or solution, for example, `Contoso.contact.form.CustomButton.CustomAction`.  
  
> [!TIP]
>  Consistently applying your `Id` attribute naming conventions will greatly enhance your productivity while editing RibbonDiffXml.  
  
 Based on the location information that you provide, the `Sequence` attribute value determines the order in which to render items. If you want a custom control to appear between two existing controls, you must select a sequence value that is in between the sequence values of the existing items.  
  
### Hide custom actions  
 A `<HideCustomAction>` is a statement that you use when you want to remove an existing ribbon element so that it is not rendered. This does not hide the ribbon element, it actually removes the ribbon element at runtime so that it doesn’t exist in the ribbon.  
  
> [!NOTE]
>  Because the `HideCustomAction` element removes a specified node from the ribbon, removing ribbon elements in this manner may not be the best option for every situation.  
> 
> - If you want to remove a button that is associated with a specific privilege, you should adjust the privileges for the entity in the security roles in your implementation. This will allow the default ribbon display and enables rules to hide or disable ribbon elements from users who do not have the necessary privileges to perform those actions.  
>   -   If you want to replace an existing ribbon element with a custom ribbon element, you can overwrite that element by specifying a `CustomAction.Location` value identical to the existing element.  
  
 The **HideActionId** element provides a unique ID for the action. For consistency and readability, you should follow the same naming convention described for `<CustomAction>` elements. The **Location** attribute must match the Id of the ribbon element you want to remove.  
  
### See also  
 [Customize commands and the ribbon](customize-commands-ribbon.md)   
 [Pass Microsoft Dynamics 365 Customer Engagement data from a page as a parameter to Ribbon Actions](pass-dynamics-365-data-page-parameter-ribbon-actions.md)   
 [Define Scaling for Ribbon Elements](define-scaling-ribbon-elements.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]