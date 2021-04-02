---
title: "Register and unregister action for event in Unified Service Desk | MicrosoftDocs"
description: "The topic describes the events that can be registered/unregistered for an action."
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
# Register and unregister action for event in Unified Service Desk
This topic describes the events that can be registered/unregistered for an action.  
  
## UIA events  
 The following UIA events can be registered for an action:  
  
-   Element action events  
  
-   Property change events:  
  
    -   Property change events require monitoring of the property for which the event needs to be raised. Base DDA does not support accepting the extra argument for retrieving the property name.  
  
    -   This is handled as part of data extensibility.  
  
    -   By default, the **PropertyChange** event looks for **NameProperty** and **EnabledProperty**.  
  
-   Global desktop change events (application-level events)  
  
-   Events  
  
## Event names  
 The following event names can be used to subscribe in the register/unregister activities:  
  
-   [AsyncContentLoadedEvent](/dotnet/api/system.windows.automation.automationelementidentifiers.asynccontentloadedevent)  
  
-   [AutomationFocusChangedEvent](/dotnet/api/system.windows.automation.automationelementidentifiers.automationfocuschangedevent)  
  
-   [AutomationPropertyChangedEvent](/dotnet/api/system.windows.automation.automationelementidentifiers.automationpropertychangedevent)  
  
-   [LayoutInvalidatedEvent](/dotnet/api/system.windows.automation.automationelementidentifiers.layoutinvalidatedevent)  
  
-   [MenuClosedEvent](/dotnet/api/system.windows.automation.automationelementidentifiers.menuclosedevent)  
  
-   [MenuOpenedEvent](/dotnet/api/system.windows.automation.automationelementidentifiers.menuopenedevent)  
  
-   [ToolTipClosedEvent](/dotnet/api/system.windows.automation.automationelementidentifiers.tooltipclosedevent)  
  
-   [ToolTipOpenedEvent](/dotnet/api/system.windows.automation.automationelementidentifiers.tooltipopenedevent)  
  
-   [ElementAddedToSelectionEvent](/dotnet/api/system.windows.automation.selectionitempattern.elementaddedtoselectionevent)  
  
-   [ElementRemovedFromSelectionEvent](/dotnet/api/system.windows.automation.selectionitempattern.elementremovedfromselectionevent)  
  
-   [ElementSelectedEvent](/dotnet/api/system.windows.automation.selectionitempattern.elementselectedevent)  
  
-   [InvalidatedEvent](/dotnet/api/system.windows.automation.selectionpattern.invalidatedevent)  
  
-   [InvokedEvent](/dotnet/api/system.windows.automation.invokepattern.invokedevent)  
  
-   [TextChangedEvent](/dotnet/api/system.windows.automation.textpatternidentifiers.textchangedevent)  
  
-   [TextSelectionChangedEvent](/dotnet/api/system.windows.automation.textpatternidentifiers.textselectionchangedevent)  
  
> [!NOTE]
>  For a Windows open/closed event, the parent control should be registered for the event. For menu Items, before registering for the event, the menu item should be visible in the UI. The corresponding `Execute` control needs to be done to make this visible.  For an application main window, the following binding needs to be added: `<UIElement type="ControlType.Window" name="ApplicationMainWindow" />` For the desktop, the following binding needs to be added: `<UIElement StartFromDesktop="True" type="ControlType.Pane" name="Desktop">`  
  
### See also  
 [UIADDA](../unified-service-desk/uiadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]