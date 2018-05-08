---
title: "JAccControl Tag in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "<JAccControl> associates a named control to the Java accessibility element that is specified in the search path. This topic describes the elements of <AccControl> tag."
ms.custom:
  - dyn365-USD
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: e6b76e86-3b62-4e34-9d3e-03abf30bad4f
caps.latest.revision: 5
author: kabala123
ms.author: kabala
manager: sakudes
---
# JAccControl Tag in Unified Service Desk
`<JAccControl>` associates a named control to the Java accessibility element that is specified in the search path. This topic describes the elements of `<AccControl>` tag.  
  
## \<JAccControl> syntax  
 The following code snippet shows how `<JAccControl>` tag is used:  
  
```xml  
<JAccControl name="control name">  
<Path>  
...      
</Path>  
</JAccControl>  
  
```  
  
## Elements of \<JAccControl>  
 The following table describes the elements of the `<JAccControl>` tag.  
  
|Element|Description|  
|-------------|-----------------|  
|`FindControl`|Returns `True` if the control is found on the UI, otherwise **False**.|  
|`GetControlValue`|Returns the content of the control.|  
|`SetControlValue`|Sets the content of the control; some controls might not be able to change their content.|  
|`ExecuteControlAction`|Executes the default command for this control, depending on the Java accessibility integration.|  
  
> [!NOTE]
>  Use this control type for all elements that are not a tree or a selection element, such as a list.  
  
### See also  
 [JavaDDA](../unified-service-desk/javadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)
