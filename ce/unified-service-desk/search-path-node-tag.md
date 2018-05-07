---
title: "Search Path Node Tag in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about Search Path node that describes the search path to identify the control in the Java accessibility tree."
ms.custom: dyn365-USD
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
ms.assetid: 31b95b66-c66b-4b84-b74c-941d18dac910
caps.latest.revision: 5
author: kabala123
ms.author: kabala
manager: sakudes
---
# Search Path Node Tag in Unified Service Desk
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
