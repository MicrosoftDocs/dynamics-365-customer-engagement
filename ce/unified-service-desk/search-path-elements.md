---
title: "Search Path Elements in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about Search Path Elements in Unified Service Desk."
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
ms.assetid: 6b9e70b9-20a1-430c-9cf0-bb8ca7b2480d
caps.latest.revision: 7
author: kabala123
ms.author: kabala
manager: sakudes
---
# Search Path Elements in Unified Service Desk
Web applications and web pages can contain frames. The frames can have associated controls. You can also configure data-driven adapter (DDA) controls for frame-based controls. For example, you might need to access the `HTML` form controls inside a frame. To do this, you would search a specific frame within a window for specific data. You can include that search in the WebDDA itself.  
  
## Search path elements  
 The WebDDA defines three elements that can be used in the search path for a given control:  
  
-   [AttributeMatchPath](../unified-service-desk/attribute-match-path.md)  
  
-   [ElementMatchPath](../unified-service-desk/element-match-path.md)  
  
-   [FindIEFrame](../unified-service-desk/find-ie-frame.md)  
  
 A control's search path can contain multiple elements. They will be executed in the order in that they are listed in the search path. For example, the following control description first looks for an [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] window described with the `<FindIEFrame/>` element, and then it uses the `<ElementMatchPath/>` element to identify the desired control within this [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] window.  
  
```xml  
<HtmlElement name="Popup Text1" type="HtmlElement">  
<FindIEFrame matchtype="endswith">Popup - Windows Internet Explorer</FindIEFrame>  
<ElementMatchPath>/HTML/BODY/P/FONT</ElementMatchPath>  
</HtmlElement>  
  
```  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)
