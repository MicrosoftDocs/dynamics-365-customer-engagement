---
title: "Define ribbon tab display rules (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about defining ribbon tab displays rules."
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
  - ribbon, display tabs
ms.assetid: 08c73aba-26ed-4cf9-aacc-c225140025bc
caps.latest.revision: 17
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Define ribbon tab display rules

Tab display rules control whether a specific tab is displayed for a ribbon or not.  
  
 Unlike other ribbon elements like groups or specific controls, you must explicitly provide a tab display rule for a tab to be displayed in the ribbon. By default, other ribbon elements will always display unless a display rule removes them.  
  
 `<TabDisplayRule>` elements require that the `TabCommand` attribute matches a `<Tab>` `Command` attribute value.  
  
 In the `RibbonDiffXml`, tabs can be defined for specific entities or defined globally. 
 If the tab is defined for an entity, the only valid type of rule is `<EntityRule>`. 
 Because defining a tab in the scope of a particular entity already limits the tab to only that entity, the only valid attributes are `AppliesTo` (`PrimaryEntity` or `SelectedEntity`) and `Context` (`Form`, `HomePageGrid`, `SubGridStandard`, or `SubGridAssociated`).  
  
 When you define a tab display rule globally in the `RibbonDiffXml` for the application ribbons, you can apply both `EntityRule` elements and `<PageRule>` elements.  
  
### See also  
 [Customize commands and the ribbon](customize-commands-ribbon.md)   
 [Define Scaling for Ribbon Elements](define-scaling-ribbon-elements.md)   
 [Pass Parameters to a URL By Using the Ribbon](pass-parameters-url-by-using-ribbon.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]