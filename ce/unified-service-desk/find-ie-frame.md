---
title: "FindIEFrame in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "The topic describes the attributes of <FindIEFrame> that searches for an application by its caption and selects a DOM of the window or a specific frame within a window."
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
ms.assetid: fc973cc7-d4af-4bdb-813a-4204ac46f939
caps.latest.revision: 7
author: kabala123
ms.author: kabala
manager: sakudes
---
# FindIEFrame in Unified Service Desk
`<FindIEFrame>` tag searches for an application by its caption and selects a `DOM` of the window or a specific frame within a window. An example is a pop-up window. This tag can explore the pop-up window regardless of how it stands in relation to the hosted web application. This topic describes the attributes of `<FindIEFrame>`  
  
## \<FindIEFrame> syntax  
 The following code snippet shows how `<FindIEFrame>` is used:  
  
```xml  
<FindIEFrame> [matchtype="equals|startswith|endswith|contains"] [match="n"][relaxProcessIdRestriction="true|false"] >  
text to match against window caption  
</FindIEFrame>  
  
```  
  
## Attributes of \<FindIEFrame>  
 The following table describes the optional attributes of the `<FindIEFrame>` tag.  
  
|Element|Description|  
|-------------|-----------------|  
|`matchtype`|Specifies how the caption should be matched. Possible values are `equals`, `startswith`, `endswith`, or `contains`. Any other value will throw an exception.|  
|`match`|Selects the **nth** frame matching the specification. Default: **1**.|  
|`relaxProcessIdRestriction`|Searches for a matching window/frame within the same process of the hosted application (`False`) or searches over all processes (`True`).|  
  
 The following sample code shows the bindings for the control named `PopupWindowText`. The control is the text in an `HTML` pop-up window; in this case, it is the pop-up window in the **Sample Web Application**.  
  
```xml  
<HtmlElement name="PopupWindowText" type="HtmlElement">  
<FindIEFrame>http://uiiserver1/Microsoft.Cti.Samples.DemoWebApplication/popup1.htm - Windows Internet Explorer</FindIEFrame>  
<ElementMatchPath>/HTML/BODY/P/FONT</ElementMatchPath>  
</HtmlElement>  
  
```  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)
