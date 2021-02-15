---
title: "Register and unregister action for event in Unified Service Desk | MicrosoftDocs"
description: "The topic describes the events that can be registered/unregistered for an action."
author: v-sailab
ms.author: v-sailab
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
  
-   [AsyncContentLoadedEvent](https://msdn.microsoft.com/library/vstudio/system.windows.automation.automationelementidentifiers.asynccontentloadedevent.aspx)  
  
-   [AutomationFocusChangedEvent](https://msdn.microsoft.com/library/vstudio/system.windows.automation.automationelementidentifiers.automationfocuschangedevent.aspx)  
  
-   [AutomationPropertyChangedEvent](https://msdn.microsoft.com/library/vstudio/system.windows.automation.automationelementidentifiers.automationpropertychangedevent.aspx)  
  
-   [LayoutInvalidatedEvent](https://msdn.microsoft.com/library/vstudio/system.windows.automation.automationelementidentifiers.layoutinvalidatedevent.aspx)  
  
-   [MenuClosedEvent](https://msdn.microsoft.com/library/vstudio/system.windows.automation.automationelementidentifiers.menuclosedevent.aspx)  
  
-   [MenuOpenedEvent](https://msdn.microsoft.com/library/vstudio/system.windows.automation.automationelementidentifiers.menuopenedevent.aspx)  
  
-   [ToolTipClosedEvent](https://msdn.microsoft.com/library/vstudio/system.windows.automation.automationelementidentifiers.tooltipclosedevent.aspx)  
  
-   [ToolTipOpenedEvent](https://msdn.microsoft.com/library/vstudio/system.windows.automation.automationelementidentifiers.tooltipopenedevent.aspx)  
  
-   [ElementAddedToSelectionEvent](https://msdn.microsoft.com/library/vstudio/system.windows.automation.selectionitempattern.elementaddedtoselectionevent.aspx)  
  
-   [ElementRemovedFromSelectionEvent](https://msdn.microsoft.com/library/vstudio/system.windows.automation.selectionitempattern.elementremovedfromselectionevent.aspx)  
  
-   [ElementSelectedEvent](https://msdn.microsoft.com/library/vstudio/system.windows.automation.selectionitempattern.elementselectedevent.aspx)  
  
-   [InvalidatedEvent](https://msdn.microsoft.com/library/system.windows.automation.selectionpattern.invalidatedevent.aspx)  
  
-   [InvokedEvent](https://msdn.microsoft.com/library/vstudio/system.windows.automation.invokepattern.invokedevent.aspx)  
  
-   [TextChangedEvent](https://msdn.microsoft.com/library/system.windows.automation.textpatternidentifiers.textchangedevent.aspx)  
  
-   [TextSelectionChangedEvent](https://msdn.microsoft.com/library/system.windows.automation.textpatternidentifiers.textselectionchangedevent.aspx)  
  
> [!NOTE]
>  For a Windows open/closed event, the parent control should be registered for the event. For menu Items, before registering for the event, the menu item should be visible in the UI. The corresponding `Execute` control needs to be done to make this visible.  For an application main window, the following binding needs to be added: `<UIElement type="ControlType.Window" name="ApplicationMainWindow" />` For the desktop, the following binding needs to be added: `<UIElement StartFromDesktop="True" type="ControlType.Pane" name="Desktop">`  
  
### See also  
 [UIADDA](../unified-service-desk/uiadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]