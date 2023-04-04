---
title: "Composite DDA | MicrosoftDocs"
description: "Learn about the composite data-driven adapter. Also, included is a sample code that shows a binding collection of data-driven adapters."
ms.date: 08/23/2017
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
ms.custom: 
  - dyn365-USD
---
# Composite DDA
The composite data-driven adapter is an extension of the DDA architecture introduced with [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)]. It was built to address the issue where you can assign only one DDA type to an application. In some cases, an application might need different technologies provided by different data-driven adapters to access the required functionality. An example for this could be a Java applet in a web application. You can use the composite DDA in these scenarios.  
  
## Composite DDA bindings  
 The composite DDA bindings are similar to the other data-driven adapters. The bindings are simply added to a `<DataDrivenAdapterBindingsCollection>` collection, which supports adding bindings of different types. The following sample shows a binding collection of three data-driven adapters. However, you can add only one collection per application.  
  
```xml  
<DataDrivenAdapterBindingsCollection>  
   <Type>DDAType1, DDAAssembly</Type>   
   <Controls>  
    …  
   </Controls>  
</DataDrivenAdapterBindings>  
  
<DataDrivenAdapterBindings prefix="dda1">  
   <Type>DDAType2, DDAAssembly</Type>   
   <Controls>  
   …  
   </Controls>  
   </DataDrivenAdapterBindings>  
<DataDrivenAdapterBindings prefix="dda2">  
   <Type>DDAType3, DDAAssembly</Type>   
   <Controls>  
   …  
   </Controls>  
</DataDrivenAdapterBindings>  
</DataDrivenAdapterBindingsCollection>  
  
```  
  
 Each of the `<DataDrivenAdapterBindings>` tags can have an optional parameter prefix. This allows using the same control name in different binding sections. If prefix is defined, all controls in this DDA will have this prefix attached to their control name.  
  
> [!NOTE]
>  Every DDA binding should always be called with its respective prefix. For example, if the `DDAType2` and `DDAType3` have a control defined with the name `Button1`, the control names used in the automation are `dda1Button1` and `dda2Button1`.  
> 
> [!NOTE]
>  If the webpage contains a [!INCLUDE[pn_ms_ActiveX_short](../includes/pn-ms-activex-short.md)] control or [!INCLUDE[pn_Java](../includes/pn-java.md)] Applet, the web application default action does not wait for the [!INCLUDE[pn_ms_ActiveX_short](../includes/pn-ms-activex-short.md)] control or [!INCLUDE[pn_Java](../includes/pn-java.md)] Applet to load.  
  
### See also  
 [Use Data Driven Adapters](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
