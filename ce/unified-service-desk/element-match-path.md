---
title: "ElementMatchPath in Unified Service Desk | MicrosoftDocs"
description: "<ElementMatchPath> tag uses a sequence of HTML tags delimited by forward slashes. This topic describes how <ElementMatchPath> works."
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
# ElementMatchPath in Unified Service Desk
`<ElementMatchPath>` tag uses a sequence of `HTML` tags delimited by forward slashes. This topic describes how `<ElementMatchPath>` works.  
  
## \<ElementMatchPath> syntax  
 The following code snippet shows how `<ElementMatchPath>` is used:  
  
```xml  
<html >  
<head>  
    <title>Sample</title>  
</head>  
<body>  
    <form id="HAT form">  
        <p>HAT</p>  
        <p><input id="CB1" type="checkbox" />Customer Care Framework</p>  
    </form>  
</body>  
</html>  
  
```  
  
 The bindings path for `checkbox` is as follows:  
  
```xml  
<ElementMatchPath>/html/body/form/p[1]/input</ElementMatchPath>  
  
```  
  
 This sequence traces a navigation path from the root of the `DOM` to the target element, the last element in the list. Each successive tag represents the child of the previous parent tag. The `HTML` tags can have an optional, numerical qualifier that takes the form *[n]*, where *n* is an integer. The qualifier `[0]` is the default when none is specified. The qualifier *[1]* represents the second matching sibling at that `DOM` level, and so on. The special qualifier `[-1]` represents the last matching sibling at that `DOM` level regardless of the length of the list. In the above example, the second `<p>` tag in the `<form>` tag is used as the root for the next child node in the `DOM` tree.  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]