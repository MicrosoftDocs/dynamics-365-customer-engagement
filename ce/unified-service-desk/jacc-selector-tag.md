---
title: "JAccSelector tag in Unified Service Desk | MicrosoftDocs"
description: "Understand how the JAccSelector tag works in Unified Service Desk. Also, find a code snippet that shows how to use the tag."
ms.date: 06/27/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - customizer
  - developer
ms.custom: evergreen
---
# JAccSelector tag in Unified Service Desk
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


[!INCLUDE[footer-include](../includes/footer-banner.md)]
