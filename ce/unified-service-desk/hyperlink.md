---
title: "HyperLink in Unified Service Desk | MicrosoftDocs"
ms.custom: dyn365-USD
ms.date: 08/23/2017
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 9fcb4f35-b9ef-412d-a62e-c4dc3f2e65cb
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
descrition: 
  - The <HyperLink> element does not define an element on the web application's user interface (UI)
  - but it allows navigating to a specified URL. This element does not use the DOM tree to navigate. It only takes the <Url> tag to specify the target URL.
---
# HyperLink in Unified Service Desk
The `<HyperLink>` element does not define an element on the web application's user interface (UI), but it allows navigating to a specified URL. This element does not use the `DOM` tree to navigate. It only takes the `<Url>` tag to specify the target URL, as shown in the following example:  
  
```xml  
<HyperLink name="control name">  
<Url>http://www.urlgoeshere.org</Url>  
</HyperLink>  
  
```  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)
