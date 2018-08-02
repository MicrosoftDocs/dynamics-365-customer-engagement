---
title: "TextAreaElement in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about using TextAreaElement in Unified Service Desk used to associate a named control with a text area element on the HTML page."
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
ms.assetid: eccf015f-836a-4f4d-8fe7-01ff2405d6c5
caps.latest.revision: 7
author: kabala123
ms.author: kabala
manager: sakudes
---
# TextAreaElement in Unified Service Desk
`<TextAreaElement>` element associates a named control with a text area element on the `HTML` page. This topic describes the elements of `<TextAreaElement>`.  
  
## \<TextAreaElement> syntax  
 The following code snippet shows how `<TextAreaElement>` is used.  
  
```xml  
<TextAreaElement name="name goes here">  
Search Path Elements  
</TextAreaElement>  
  
```  
  
## Elements of \<TextAreaElement>  
 The following table describes the elements of the `<TextAreaElement>` tag:  
  
|Element|Description|  
|-------------|-----------------|  
|`FindControl`|Returns `True` if the control can be found on the user interface (UI), otherwise `False`.|  
|`GetControlValue`|Returns the value of the text area element.|  
|`SetControlValue`|Sets the value of a text area element.|  
|`ExecuteControlAction`|Throws an `UnsupportedControlOperation` exception.|  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)
