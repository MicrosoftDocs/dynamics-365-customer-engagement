---
title: "JAccTree tag in Unified Service Desk | MicrosoftDocs"
description: "Understand how the JAccTree tag works in Unified Service Desk. Also, find a code snippet that shows how to use the tag."
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
# JAccTree tag in Unified Service Desk
The `JAccTree` associates a named control to the Java accessibility tree element that is specified in the search path. This topic describes the elements of `<JAccTree>`  
  
## \<JAccTree> syntax  
 The following code snippet shows the syntax of `<JAccTree>`  
  
```xml  
<JAccTree name="control name">  
<Path>  
       ...      
</Path>  
</JAccTree>  
  
```  
  
## Elements of \<JAccTree>  
 The following table describes the elements of the `<JAccTree>` tag.  
  
|Element|Description|  
|-------------|-----------------|  
|`FindControl`|Returns `True` or `False` depending on whether the control is found on the UI.|  
|`GetControlValue`|Returns the content of the control.|  
|`SetControlValue`|Sets the content of the control.|  
|`ExecuteControlAction`|Toggles the tree node state – expands or collapses it.|  
  
### See also  
 [JavaDDA](../unified-service-desk/javadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
