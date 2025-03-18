---
title: JAccControl tag in Unified Service Desk 
description: Understand how the JAccControl tag works in Unified Service Desk. Also, find a code snippet that shows how to use the tag.
ms.date: 06/27/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - customizer
  - developer
ms.custom: evergreen
---
# JAccControl tag in Unified Service Desk
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


[!INCLUDE[footer-include](../includes/footer-banner.md)]
