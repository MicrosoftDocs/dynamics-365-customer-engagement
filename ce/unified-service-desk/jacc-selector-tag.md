---
title: "JAccSelector Tag in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "The topic describes the elements of <JAccSelector>."
ms.custom: dyn365-USD
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
ms.assetid: 95bd8843-e924-4709-b4aa-86dbdb985b03
caps.latest.revision: 5
author: kabala123
ms.author: kabala
manager: sakudes
---
# JAccSelector Tag in Unified Service Desk
`<JAccSelector>` associates a named control to the [!INCLUDE[pn_Java](../includes/pn-java.md)] accessibility element that is specified in the search path. You can use this control type for all selection elements such as lists boxes or lists in combo boxes. This topic describes the elements of `<JAccSelector>`  
  
## \<JAccSelector> syntax  
  
```xml  
<JAccSelector name="control name">  
<Path>  
...      
</Path>  
</JAccSelector>  
  
```  
  
## Elements of \<JAccSelector>  
 The following table describes the elements of the `<JAccSelector>` tag:  
  
|Element|Description|  
|-------------|-----------------|  
|`FindControl`|Returns `True` or `False` depending on whether the control is found on the UI.|  
|`GetControlValue`|Returns the name of the selected item(s); multiple items are separated by comma.|  
|`SetControlValue`|Sets the selection in the list; multiple items are separated by comma.|  
|`ExecuteControlAction`|Toggles the current selection.|  
  
> [!NOTE]
>  Some combo boxes are set to editable, which enables user to enter any text in the input field. For such combo boxes, you must use the `<JAccControl>` tag in the bindings for the input box to set the value.  
  
### See also  
 [JavaDDA](../unified-service-desk/javadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)
