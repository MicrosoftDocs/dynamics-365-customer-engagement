---
title: "SelectElement in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about SelectElement in Unified Service Desk to search for a named control on the HTML page."
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
ms.assetid: 6a5148e9-871e-41d1-8f70-b11175b1c42c
caps.latest.revision: 7
author: kabala123
ms.author: kabala
manager: sakudes
---
# SelectElement in Unified Service Desk
`<SelectElement>` element searches for a named control on an `HTML` page, and returns or reverses its value. This topic describes the elements of `<SelectElement>`  
  
## \<SelectElement> syntax  
 The following code snippet shows how `<SelectElement>` is used:  
  
```xml  
<SelectElement name="control name">  
Search Path Elements  
</SelectElement>  
  
```  
  
## Elements of \<SelectElement>  
 The following table describes the elements of the `<SelectElement>` tag.  
  
|Element|Description|  
|-------------|-----------------|  
|`FindControl`|Returns `True` or `False` depending on whether the control can be found on the user interface (UI).|  
|`GetControlValue`|Returns the selected item(s), as a comma-separated list.|  
|`SetControlValue`|Inverts the selection status of the first matching item in the list. This clears the entire selection when the provided set text is empty.|  
|`ExecuteControlAction`|For single-selection modes, this inverts the selection status of the current selection. For multi-selection modes, it adds the next unselected item to the current selection|  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)
