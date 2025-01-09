---
title: "NextRole tag in Unified Service Desk | MicrosoftDocs"
description: "Learn how the NextRole tag works in Unified Service Desk. Also find a code snippet that shows how to use the tag."
ms.date: 06/27/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - customizer
  - developer
ms.custom: evergreen
---
# NextRole tag in Unified Service Desk
The `<NextRole>` tag functions like the `<Next>` tag, but it applies to the accessibility role of the control. The attributes of the tag are same as the `<Next>` tag. The following sample finds a control one position after the second control with a push button role.  
  
```xml  
<JAccControl name="TestButton">  
<Path>  
<NextRole match="2"offset="1">push button</NextRole>  
</Path>  
</JAccControl>  
  
```  
  
### See also  
 [JavaDDA](../unified-service-desk/javadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
