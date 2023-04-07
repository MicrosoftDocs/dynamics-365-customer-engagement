---
title: "HyperLink in Unified Service Desk | MicrosoftDocs"
description: "Understand how the <HyperLink> element works in Unified Service Desk. Also included is an example that shows how to use the element."
ms.date: 08/23/2017
ms.topic: article
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - customizer
  - developer
ms.custom: 
  - dyn365-USD
---
# HyperLink in Unified Service Desk
The `<HyperLink>` element does not define an element on the web application's user interface (UI), but it allows navigating to a specified URL. This element does not use the `DOM` tree to navigate. It only takes the `<Url>` tag to specify the target URL, as shown in the following example:  
  
```xml  
<HyperLink name="control name">  
<Url>https://www.urlgoeshere.org</Url>  
</HyperLink>  
  
```  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
