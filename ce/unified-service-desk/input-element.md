---
title: "InputElement in Unified Service Desk | MicrosoftDocs"
description: "The topic describes the elements of <IntputElement>."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# InputElement in Unified Service Desk
`<InputElement>` element associates a named control with an `<input/> HTML` element if the element has one of the following `type=attribute` values: `check box`, `radio`, `text`, `password`, `submit`, `reset`, `hidden`, `image`, or `file`. This topic describes the elements of `<IntputElement>`.  
  
## \<InputElement> syntax  
 The following code snippet shows how `<InputElement>` is used:  
  
```xml  
<InputElement name="control name" type="type">  
Search Path Elements  
</InputElement>  
  
```  
  
## Elements of \<InputElement>  
 The following table describes the elements of the `<InputElement>` tag.  
  
|Element|Description|  
|-------------|-----------------|  
|`FindControl`|Returns `True` if the control can be found on the user interface (UI), otherwise `False`|  
|`GetControlValue`|Returns `True` or `False` (string-valued) when `type="checkbox"` or `type="radio"`. Returns the value of the element for all other types.|  
|`SetControlValue`|Sets to `True` or `False` when `type="checkbox"` or `type="radio"`. Sets the value of the element when `type="text"` or `type="password"` or `type="hidden"`. Throws an `UnsupportedControlOperation` exception for all other types.|  
|`ExecuteControlAction`|Inverts an existing `True` or `False` state when `type="checkbox"`. Sets state to `True` when `type="radio"`. Returns `UnsupportedControlOperation` when `type="text"` or `type="password"` or `type="hidden"`. Issues a `Click()` for all other types.|  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]