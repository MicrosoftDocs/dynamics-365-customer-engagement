---
title: "JavaDDA Events in Unified Service Desk | MicrosoftDocs"
description: "Learn about JavaDDA and the set of events available to trigger automation executions in the Hosted Application Toolkit (HAT)."
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
# JavaDDA Events in Unified Service Desk
[!INCLUDE[pn_Java](../includes/pn-java.md)] data-driven adapter (JavaDDA) provides a set of events to trigger automation executions in the [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)]. The events correspond to the events in the [!INCLUDE[pn_Java](../includes/pn-java.md)] runtime. All events are bound to the controls on the user interface (UI). To register for the event, the control must be present in the UI. Use the `FindControl` activity to see if the control exists. This topic describes the [!INCLUDE[pn_Java](../includes/pn-java.md)]DDA events.  
  
## JavaDDA events  
 The following table lists the events available in the [!INCLUDE[pn_Java](../includes/pn-java.md)]DDA:  
  
|Event |Description|  
|------|-----------------|  
|`CheckBoxSelected`|Invoked when the check box is selected (marker set).|  
|`CheckBoxCleared`|Invoked when the check box is cleared (marker not set).|  
|`RadioButtonSelected`|Invoked when the radio button is selected.|  
|`RadioButtonCleared`|Invoked when the radio button is cleared.|  
|`ButtonPressed`|Invoked when the button is pressed (versus a click, which is press-release).|  
|`ButtonReleased`|Invoked when the button is released.|  
|`GotFocus`|The event is raised when the control gets the focus.|  
|`LostFocus`|The event is raised when the control loses the focus.|  
|`MenuSelected`|Invoked when the menu item is selected.|  
|`MenuDeSelected`|Invoked when the menu item is unselected.|  
|`MenuCanceled`|Invoked when the menu selection is canceled.|  
|`TreeNodeCollapsed`|Invoked when the tree node is collapsed.|  
|`TreeNodeExpanded`|Invoked when the tree node is expanded.|  
  
> [!NOTE]
>  When multiple instances of the same external [!INCLUDE[pn_Java](../includes/pn-java.md)] applications are hosted outside of the agent desktop, such as when the [!INCLUDE[pn_Java](../includes/pn-java.md)] application is a session application, [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] can’t distinguish between instances unless the bindings have been authored in such a way that controls can be distinguished between the two instances. With typical `Win32` applications, this is done by limiting to a particular process ID, but this isn’t possible with [!INCLUDE[pn_Java](../includes/pn-java.md)] applications, and greater care must be taken in authoring the binding.  
  
### See also  
 [JavaDDA](../unified-service-desk/javadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
