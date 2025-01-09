---
title: "Next tag (JavaDDA) in Unified Service Desk | MicrosoftDocs"
description: "Learn how the Next tag (JavaDDA) works in Unified Service Desk. Also find a code snippet that shows how to use the tag."
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
# Next tag (JavaDDA) in Unified Service Desk
You can use the `<Next>` element to set the search pointer to the next UI element with the matching caption. If you use `<Next/>`, the search navigates to the next node within the tree. The `<Next/>` tag navigates down the tree branches, not among siblings within one node of the tree. To navigate within the tree node, use the `match` and `offset` attributes. This topic describes the attributes of `<Next>` tag.  
  
## Attributes of \<Next> tag  
 The following table describes the attributes of the `<Next>` tag.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Match`|**Nth** element|  
|`Offset`|**Nth** element after the one that matched.|  
|`Culture`|Use culture|  
  
 The following sample binding searches for the `Close` button in an application for three different cultures: English, German, and French:  
  
```xml  
<Controls>  
<JAccControl name="CloseButton">  
<Path>  
<FindWindow>  
<Class>SunAWTFrame</Class>  
</FindWindow>  
<Next culture="en-us">Close</Next>  
<Next culture="de-de">Beenden</Next>  
<Next culture="fr-fr">Fermer</Next>  
</Path>  
</JAccControl>  
</Controls>  
  
```  
  
 By using the attributes `match` and `offset`, you can navigate the accessibility tree for nodes with the same name (using `match`) or without an identifier (using `offset`). The following sample selects the second accessibility tree entry after the forth entry with the caption `Name`.  
  
```xml  
<JAccControl name="TestButton">  
<Path>  
<Next match="4", offset="2" >Name</Next>  
</Path>  
</JAccControl>  
  
```  
  
> [!NOTE]
>  The `<Next/>` and `<NextName/>` tags have the same function. When specifying your bindings, use the `<Next>` tag to be forward compatible.  
  
### See also  
 [JavaDDA](../unified-service-desk/javadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
