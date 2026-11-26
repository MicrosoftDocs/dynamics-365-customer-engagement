---
title: "UIA Pattern List in Unified Service Desk | MicrosoftDocs"
description: "Use this article to get a list of UI automation patterns, such as InvokePatternIdentifiers.Pattern, used in Unified Service Desk."
ms.date: 06/27/2024
ms.topic: overview
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - customizer
  - developer
---
# UIA Pattern List in Unified Service Desk
This article lists the UIA patterns.  
  
1. [InvokePatternIdentifiers.Pattern](/dotnet/api/system.windows.automation.invokepatternidentifiers.pattern)  
  
2. [TogglePatternIdentifiers.Pattern](/dotnet/api/system.windows.automation.transformpatternidentifiers.pattern)  
  
3. [ExpandCollapsePatternIdentifiers.Pattern](/dotnet/api/system.windows.automation.expandcollapsepatternidentifiers.pattern)  
  
4. [SelectionItemPatternIdentifiers.Pattern](/dotnet/api/system.windows.automation.selectionitempatternidentifiers.pattern)  
  
5. [TextPatternIdentifiers.Pattern](/dotnet/api/system.windows.automation.tablepatternidentifiers.pattern)  
  
6. [ScrollPatternIdentifiers.Pattern](/dotnet/api/system.windows.automation.scrollpatternidentifiers.pattern)  
  
7. [RangeValuePatternIdentifiers.Pattern](/dotnet/api/system.windows.automation.rangevaluepatternidentifiers.pattern)  
  
8. [TogglePatternIdentifiers.Pattern](/dotnet/api/system.windows.automation.transformpatternidentifiers.pattern)  
  
9. [ValuePatternIdentifiers.Pattern](/dotnet/api/system.windows.automation.valuepatternidentifiers.pattern)  
  
   DDA can be extended to add a new pattern.  
  
> [!NOTE]
>  When UIADDA is used with any application, UIA requires that the application is in focus before any interaction can occur with the application. This means that any automation requires that a Focus activity occur before any interaction with controls can take place, including registering for an event. If there's subsequent interaction with controls on another application, that application must be brought into focus. `Dynamic positioning` must be used instead of `set parent` when using the UIADDA with non-WPF applications. If an application is hosted outside, focus isn't required.  
  
### See also  
 [UIADDA](../unified-service-desk/uiadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
