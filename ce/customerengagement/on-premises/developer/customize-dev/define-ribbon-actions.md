---
title: "Define ribbon actions (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about defining the actions to be performed by a command bar or ribbon control in a <CommandDefinition> element together with rules that control whether the control is enabled or visible in the ribbon. "
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
  - ribbon, control actions
ms.assetid: 350e6c40-d277-4aba-9619-5e007a67e477
caps.latest.revision: 21
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Define ribbon actions

Define the actions to be performed by a command bar or ribbon control in a `<CommandDefinition>` element together with rules that control whether the control is enabled or visible in the ribbon.  
  
 A Ribbon control can perform two types actions and may include multiple actions:  
  
- **JavaScript Functions**: A `<JavaScriptFunction>` element references a function defined in a Script Web resource.  
  
- **Open a URL**: The ribbon opens a URL using the value from an Address attribute in the `<Url>` element. Additional parameters can pass information about how what querystring parameters are passed and the mode in which the window opens.  
  
     You have several options to pass parameters to a URL using the ribbon. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Passing Parameters to a URL using the Ribbon](pass-parameters-url-by-using-ribbon.md)  
  
### Passing parameters to ribbon actions  
 Use the following elements to define data to pass to your custom action:  
  
 `<BoolParameter>`  
[!INCLUDE[ribbon_element_BoolParameter](../../includes/ribbon-element-boolparameter.md)]
  
 `<CrmParameter>`  
 [!INCLUDE[ribbon_element_CrmParameter](../../includes/ribbon-element-crmparameter.md)] [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Pass Microsoft Dynamics 365 Customer Engagement data from a page as a parameter to Ribbon Actions](pass-dynamics-365-data-page-parameter-ribbon-actions.md)  
  
 `<DecimalParameter>`  
 [!INCLUDE[ribbon_element_DecimalParameter](../../includes/ribbon-element-decimalparameter.md)]
  
 `<IntParameter>`  
 [!INCLUDE[ribbon_element_IntParameter](../../includes/ribbon-element-intparameter.md)]
  
 `<StringParameter>`  
 [!INCLUDE[ribbon_element_StringParameter](../../includes/ribbon-element-stringparameter.md)]
  
 When parameters are passed to a `<Url>` element they are passed as a query string. Therefore, they must include a name value to represent the ”key” in the query string key/value pair.  
  
 Parameters passed to a `<JavaScriptFunction>` do not require a name but they must be included in the order expected by the function and be of the correct data type.  
  
### See also  
 [Customize commands and the ribbon](customize-commands-ribbon.md)   
 [Define Ribbon Display Rules](define-ribbon-display-rules.md)   
 [Pass Microsoft Dynamics 365 Customer Engagement data from a page as a parameter to Ribbon Actions](pass-dynamics-365-data-page-parameter-ribbon-actions.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]