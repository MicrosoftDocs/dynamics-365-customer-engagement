---
title: "Sample bindings in Unified Service Desk | MicrosoftDocs"
description: "The sample explains sample bindings in Unified Service Desk."
author: mh-jaya
ms.author: v-jmh
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
# Sample bindings in Unified Service Desk
A data-driven adapter uses data, named the bindings, to define the way that it identifies a UI component of a hosted application. The following are some sample bindings:  
  
 `MatchCount`  
  
```xml  
<?xml version="1.0" encoding="utf-16" ?>   
<initstring>  
<interopAssembly>  
  <WorkingDirectory>[Install Directory]\QuickStarts\Sample Applications\StandAloneTestApp\bin\Debug</WorkingDirectory>   
  <URL>[Install Directory]\QuickStarts\Sample Applications\StandAloneTestApp\bin\Debug\Microsoft.Uii.Samples.StandAloneTestApp.exe</URL>   
  <hostInside />   
  </interopAssembly>  
  <global />   
  <optimumSize x="0" y="0" />   
  <minimumSize x="0" y="0" />   
<adapter>  
  <URL>Microsoft.Uii.HostedApplicationToolkit.AutomationHosting</URL>   
  <type>Microsoft.Uii.HostedApplicationToolkit.AutomationHosting.AutomationAdapter</type>   
  </adapter>  
<DataDrivenAdapterBindingsCollection>  
<DataDrivenAdapterBindings>  
  <Type>Microsoft.Uii.HostedApplicationToolkit.DataDrivenAdapter.UIADataDrivenAdapter, Microsoft.Uii.HostedApplicationToolkit.DataDrivenAdapter</Type>   
<Controls>  
<UIElement name="radiobutton3">  
  <UIObject MatchCount="3" />   
  </UIElement>  
<UIElement name="radiobutton2">  
  <UIObject MatchCount="4" />   
  </UIElement>  
<UIElement name="radiobutton1">  
  <UIObject />   
  </UIElement>  
<UIElement name="checkBox1">  
  <UIObject MatchCount="6" />   
  </UIElement>  
<UIElement name="button1">  
<UIElement name="testTextBox">  
  <UIObject MatchCount="1" />   
  </UIElement>  
<UIElement name="TextResult">  
  <UIObject MatchCount="12" />   
  </UIElement>  
  </Controls>  
  </DataDrivenAdapterBindings>  
  </DataDrivenAdapterBindingsCollection>  
<UIElement name="textBoxTabPage1">  
<UIObject MatchCount="2">  
<UIObject MatchCount="1">  
  <UIObject MatchCount="2" />   
  </UIObject>  
  </UIObject>  
  </UIElement>  
  
  </initstring>  
```  
  
 StandAlone  
  
```xml  
<?xml version="1.0" encoding="utf-16" ?>   
<initstring>  
<interopAssembly>  
  <WorkingDirectory>[Install Directory]\Public\QuickStarts\Sample Applications\StandAloneTestApp\bin\Debug</WorkingDirectory>  
<URL>[Install Directory]\QuickStarts\Sample Applications\StandAloneTestApp\bin\Debug\Microsoft.Uii.Samples.StandAloneTestApp.exe</URL>   
  <hostInside />   
  </interopAssembly>  
  <global />   
  <optimumSize x="0" y="0" />   
  <minimumSize x="0" y="0" />   
<adapter>  
  <URL>Microsoft.Uii.HostedApplicationToolkit.AutomationHosting</URL>   
  <type>Microsoft.Uii.HostedApplicationToolkit.AutomationHosting.AutomationAdapter</type>   
  </adapter>  
<DataDrivenAdapterBindingsCollection>  
<DataDrivenAdapterBindings>  
  <Type>Microsoft.Uii.HostedApplicationToolkit.DataDrivenAdapter.UIADataDrivenAdapter, Microsoft.Uii.HostedApplicationToolkit.DataDrivenAdapter</Type>   
<Controls>  
<UIElement name="radiobutton3">  
<UIElement name="radiobutton2">  
<UIObject>  
  <PropertyCondition Name="AutomationId">radioButton2</PropertyCondition>   
  </UIObject>  
  </UIElement>  
<UIElement name="checkBox1">  
<UIObject>  
  <PropertyCondition Name="AutomationId">checkBox1</PropertyCondition>   
  </UIObject>  
  </UIElement>  
<UIElement name="button1">  
<UIObject>  
  <PropertyCondition Name="AutomationId">button1</PropertyCondition>   
  </UIObject>  
  </UIElement>  
<UIElement name="testTextBox">  
<UIObject>  
  <PropertyCondition Name="AutomationId">testTextBox</PropertyCondition>   
  </UIObject>  
  </UIElement>  
<UIElement name="TextResult">  
<UIObject>  
  <PropertyCondition Name="AutomationId">labelResults</PropertyCondition>   
  </UIObject>  
  </UIElement>  
<UIElement name="textBoxTabPage1">  
<UIObject>  
  <PropertyCondition Name="AutomationId">tabControl1</PropertyCondition>   
<UIObject>  
<AndCondition>  
  <PropertyCondition Name="LocalizedControlType">tab item</PropertyCondition>   
  <PropertyCondition Name="Name">Tab Page 1</PropertyCondition>   
  </AndCondition>  
<UIObject>  
  <PropertyCondition Name="AutomationId">textBoxTabPage1</PropertyCondition>   
  </UIObject>  
  </UIObject>  
  </UIObject>  
  </UIElement>  
  </Controls>  
  </DataDrivenAdapterBindings>  
  </DataDrivenAdapterBindingsCollection>  
  </initstring>  
```  
  
### See also  
 [UIADDA](../unified-service-desk/uiadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]