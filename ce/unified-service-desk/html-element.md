---
title: "HtmlElement in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "The <HTMLElement> element associates a named control to the HTML object specified by the search path. This topic describes the elements of <HTMLElement>."
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
ms.assetid: 72a912d3-c16d-4e38-9367-bc2722ac0fa6
caps.latest.revision: 7
author: kabala123
ms.author: kabala
manager: sakudes
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
