---
title: "UIA Pattern List in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about UIA patterns in Unified Service Desk."
ms.custom:
  - dyn365-USD
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
ms.assetid: a07d78ff-f017-4538-bede-fe722975f434
caps.latest.revision: 7
author: kabala123
ms.author: kabala
manager: sakudes
---
# UIA Pattern List in Unified Service Desk
This topic lists the UIA patterns.  
  
1.  [InvokePatternIdentifiers.Pattern](https://msdn.microsoft.com/library/vstudio/system.windows.automation.invokepatternidentifiers.pattern.aspx)  
  
2.  [TogglePatternIdentifiers.Pattern](https://msdn.microsoft.com/library/vstudio/system.windows.automation.transformpatternidentifiers.pattern.aspx)  
  
3.  [ExpandCollapsePatternIdentifiers.Pattern](https://msdn.microsoft.com/library/vstudio/system.windows.automation.expandcollapsepatternidentifiers.pattern.aspx)  
  
4.  [SelectionItemPatternIdentifiers.Pattern](https://msdn.microsoft.com/library/vstudio/system.windows.automation.selectionitempatternidentifiers.pattern.aspx)  
  
5.  [TextPatternIdentifiers.Pattern](https://msdn.microsoft.com/library/vstudio/system.windows.automation.tablepatternidentifiers.pattern.aspx)  
  
6.  [ScrollPatternIdentifiers.Pattern](https://msdn.microsoft.com/library/vstudio/system.windows.automation.scrollpatternidentifiers.pattern.aspx)  
  
7.  [RangeValuePatternIdentifiers.Pattern](https://msdn.microsoft.com/library/vstudio/system.windows.automation.rangevaluepatternidentifiers.pattern.aspx)  
  
8.  [TogglePatternIdentifiers.Pattern](https://msdn.microsoft.com/library/vstudio/system.windows.automation.transformpatternidentifiers.pattern.aspx)  
  
9. [ValuePatternIdentifiers.Pattern](https://msdn.microsoft.com/library/vstudio/system.windows.automation.valuepatternidentifiers.pattern.aspx)  
  
 DDA can be extended to add a new pattern.  
  
> [!NOTE]
>  When UIADDA is used with any application, UIA requires that the application be in focus before any interaction can occur with the application. This means that any automation will require that a Focus activity occur before any interaction with controls can take place, including registering for an event. If there is subsequent interaction with controls on another application, that application must be brought into focus.  `Dynamic positioning` must be used instead of `set parent` when using the UIADDA with non-WPF applications.  If an application is hosted outside, focus is not required.  
  
### See also  
 [UIADDA](../unified-service-desk/uiadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)
