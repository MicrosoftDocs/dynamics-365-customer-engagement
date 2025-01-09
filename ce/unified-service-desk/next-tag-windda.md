---
title: "Next tag (WinDDA) in Unified Service Desk | MicrosoftDocs"
description: "Learn how the Next tag (WinDDA) works in Unified Service Desk. Also find a code snippet that shows how to use the tag."
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
# Next tag (WinDDA) in Unified Service Desk
`<Next/>` tag can include an optional `match` attribute and an optional `offset` attribute. The `match` attribute has a default value of `"1"`, and the offset attribute has a default value of `"0"`. Each `<Next/>` element retrieves the next level of the [IAccessible](https://msdn.microsoft.com/library/accessibility.iaccessible\(v=vs.110\).aspx) hierarchy and scans it for a match between the inner text and the `Name` of each `IAccessible` node. This topic describes the attributes of the `Next` tag.  
  
## Attributes of \<Next>  
  
- `Match` – Returns the nth matching attribute.  
  
- `Offset` – Returns the nth attribute after the matching attribute.  
  
- `Culture` – Uses the `culture` tag.  
  
  The `match="2"` attribute specifies how many times a text match has to occur for the criteria to be satisfied. When this number is reached, the `offset` attribute can be used to select an `IAccessible` node adjacent to the node that was successfully matched. The offset value wraps around, so it is not possible to reference outside of the child `IAccessible` array. The culture tag allows you to search for language-specific attributes as shown in the following example:  
  
```xml  
<AccControl name="closeButton">  
<Path>  
<Next culture="en-us">Close</Next>  
<Next culture="de-de">Beenden</Next>  
<Next culture="fr-fr">Fermer</Next>  
</Path>  
</AccControl>  
  
```  
  
 The following sample searches for the control that is two positions after the fourth control with the caption `Name`.  
  
```xml  
<AccControl name="NameBox">  
<Path>  
<Next match="4", offset="4">Name</Next>  
</Path>  
</AccControl>  
  
```  
  
### See also  
 [Win DDA](../unified-service-desk/windda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
