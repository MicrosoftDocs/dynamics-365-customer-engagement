---
title: "Search Path Node tag in Unified Service Desk | MicrosoftDocs"
description: "Learn about Search Path node that describes the search path to identify the control in the Java accessibility tree."
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
# Search Path Node tag in Unified Service Desk
The Search Path node describes the search path to identify the control in the Java accessibility tree. There are four search path elements that can be used to identify the desired UI control.  
  
 The elements are executed in the order in which they are listed in the **Path** node. **Next** and **NextRole** are elements to navigate the Java accessibility tree. `FindWindow` is used to identify the window hosting the Java application. Therefore, `FindWindow` should be the first element in the search list.The following example shows the bindings for the Java control `TestButton`. The control is in the window with the class name `SunAWTFrame` and caption `Input`. It is the first UI element in the application's accessibility tree to match the push button role.  
  
```xml  
<Controls>  
<JAccControl name="TestButton">  
<Path>  
<FindWindow>  
<Class>SunAWTFrame</Class>  
<Caption>Input</Caption>  
</FindWindow>  
<NextRole match="1">push button</NextRole>  
</Path>  
</JAccControl>  
</Controls>  
  
```  
  
### See also  
 [JavaDDA](../unified-service-desk/javadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
