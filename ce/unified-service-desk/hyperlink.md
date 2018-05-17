---
title: "HyperLink in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
descrition: "The <HyperLink> element does not define an element on the web application's user interface (UI), but it allows navigating to a specified URL. This element does not use the DOM tree to navigate. It only takes the <Url> tag to specify the target URL."
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
ms.assetid: 9fcb4f35-b9ef-412d-a62e-c4dc3f2e65cb
caps.latest.revision: 7
author: kabala123
ms.author: kabala
manager: sakudes
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
