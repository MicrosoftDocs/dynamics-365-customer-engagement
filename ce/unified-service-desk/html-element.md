---
title: "HtmlElement in Unified Service Desk | MicrosoftDocs"
description: "The <HTMLElement> element associates a named control to the HTML object specified by the search path. This topic describes the elements of <HTMLElement>."
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
# HtmlElement in Unified Service Desk
The `<HTMLElement>` element associates a named control to the `HTML` object specified by the search path. This topic describes the elements of `<HTMLElement>`.  
  
## \<HTMLElement> syntax  
 The following code snippet shows how \<HTMLElement> is used:  
  
```xml  
<HTMLElement name="control name">  
Search Path Elements  
</HTMLElement>  
```  
  
## Elements of \<HTMLElement>  
 The following table describes the elements of the `<HTMLElement>` tag.  
  
|Element|Description|  
|-------------|-----------------|  
|`FindControl`|Returns `True` if the control can be found on the user interface (UI), otherwise `False`.|  
|`GetControlValue`|Returns the content of the `HTML` object.|  
|`SetControlValue`|Throws an `UnsupportedControlOperation` exception.|  
|`ExecuteControlAction`|Executes a `Click()` command on the control.|  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]