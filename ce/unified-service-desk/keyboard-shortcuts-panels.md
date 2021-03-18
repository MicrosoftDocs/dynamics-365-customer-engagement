---
title: "Keyboard shortcuts for panels in Unified Service Desk | MicrosoftDocs"
description: "Learn about the keyboard shortcuts for panels in Unified Service Desk"
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-a11y
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Keyboard shortcuts for panels in Unified Service Desk
[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] now lets you cycle through all the active panels using a predefined keyboard shortcut and also define keyboard shortcuts to directly access individual panels in the panel layout.  
  
  
  
<a name="traverse"></a>   

## Keyboard shortcut to traverse through panels  

 Use the Ctrl+0 (default) keyboard shortcut to cyclically traverse through all the active panels in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client. To change the default shortcut key, use the **PanelNavigationShortcut** UII option to specify shortcut keys of your choice. More information: [Manage Options for Unified Service Desk](admin/manage-options-unified-service-desk.md)  
  
 Some key points to consider while using the shortcut key to traverse through panels are:  
  
-   The standard order of traversal is left to right and top to bottom.  
  
-   You cannot traverse to any visible panel that has no actionable control inside it.  
  
-   You cannot traverse to any hidden panels on the layout, like the ones inside a collapsed expander panel.  
  
-   You cannot traverse to a panel that has the `Focusable` attribute set to `False`.  
  
<a name="assign"></a>   

## Assign keyboard shortcut to panel  

 Assigning keyboard shortcuts to panels in a [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] panel layout helps customer service agents *directly* navigate to a panel in the client application by using keyboard. You can assign keyboard shortcut to a panel in a custom panel layout by using the `USD:PanelNavigation.KeyboardShortcut` attribute in the panel element definition of the panel layout XAML.  
  
 You must also set the `Focusable` attribute to `True` in the panel element definition for which you are defining the shortcut. Otherwise, you won't be able to access the panel using the assigned keyboard shortcut even after defining it in the panel layout XAML.  
  
 The following example demonstrates how to assign the Ctrl+8 keyboard shortcut to the right panel in your [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] custom panel layout XAML definition:  
  
```xaml  
<USD:USDTabPanel x:Name="RightPanel"  
                 AutomationProperties.Name="Right Panel"  
                 Grid.Row="0"  
                 USD:PanelNavigation.KeyboardShortcut="Ctrl+8"  
                 Focusable="True"/>  
```  
  
> [!NOTE]
>  The standard panel layout in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides pre-configured keyboard shortcuts for the panels, and the  keyboard shortcuts range from Ctrl+1 to Ctrl+9. For information about the standard panel layout and its XAML definition with keyboard shortcuts assigned to different panels, see [Panel layouts in Unified Service Desk](../unified-service-desk/panels-panel-types-panel-layouts.md#PanelLayouts)  
  
<a name="considerations"></a>   
## Things to consider while using keyboard shortcut for panel  
 Any key combination that is used by [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] (for example Ctrl+S) or general Windows operations (such as Ctrl+C, Ctrl+V) can cause conflicts with keyboard shortcuts that you assign to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] panels.  
  
 Therefore, as a developer or customizer, the foremost thing is to identify and assign  keyboard shortcuts to panels that do not conflict with [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] or Windows. Also, ensure that you do not assign duplicate keyboard shortcut to panels that conflict within [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. In case of a duplicate keyboard shortcut, [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] will set the keyboard shortcut  for the panel as the active shortcut key that was registered earlier during the execution sequence. Further, information about duplicate shortcut key is logged in the `UnifiedSeviceDesk.log` file (typically available at `c:\Users\<UserName>\AppData\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk\<Version>`), which can be used by developers and customizers to resolve the duplicate keyboard shortcut issue in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] configuration.  
  
 Even after assigning non-conflicting keyboard shortcuts to your panels, the shortcut will not work if the current focus is on a control in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client that is hosted as a [IE Process](../unified-service-desk/ie-process.md) control because the focus is in a different process. However, this issue is not applicable to controls hosted using the [Internal WPF](../unified-service-desk/internal-wpf.md) control.  
  
 The workaround is to inform your [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client users, if you use the `IE Process` hosting for your controls, to use the CTRL+UP ARROW keyboard shortcut to move the focus from a `IE Process` hosted control to the main window *before* using the desired panel keyboard shortcut key to ensure that [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] honors the shortcut.  
  
### See also  
 [Panels, panel types, and panel layouts in Unified Service Desk](../unified-service-desk/panels-panel-types-panel-layouts.md)   
 [Create a custom panel layout](../unified-service-desk/create-custom-panel-layout.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]