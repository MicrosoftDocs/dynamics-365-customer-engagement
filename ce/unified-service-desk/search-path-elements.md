---
title: "Search Path Elements in Unified Service Desk | MicrosoftDocs"
description: "Learn about Search Path Elements in Unified Service Desk."
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
# Search Path Elements in Unified Service Desk
Web applications and web pages can contain frames. The frames can have associated controls. You can also configure data-driven adapter (DDA) controls for frame-based controls. For example, you might need to access the `HTML` form controls inside a frame. To do this, you would search a specific frame within a window for specific data. You can include that search in the WebDDA itself.  
  
## Search path elements  
 The WebDDA defines three elements that can be used in the search path for a given control:  
  
- [AttributeMatchPath](../unified-service-desk/attribute-match-path.md)  
  
- [ElementMatchPath](../unified-service-desk/element-match-path.md)  
  
- [FindIEFrame](../unified-service-desk/find-ie-frame.md)  
  
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


[!INCLUDE[footer-include](../includes/footer-banner.md)]