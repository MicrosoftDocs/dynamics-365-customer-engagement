---
title: "What's new in Unified Service Desk for developers and customizers | MicrosoftDocs"
description: "Learn about the new features for developers and customizers in Unified Service Desk."
ms.custom: ""
ms.date: 04/24/2018
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 1c6da924-cfef-4cbf-a6d5-63af8f1a640d
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# What's new in Unified Service Desk for developers and customizers
This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] for developers and system customizers.

<a name="WhatsNew33"></a>   
## What's new in [!INCLUDE [pn-unified-service-desk-3-3](../includes/pn-unified-service-desk-3-3.md)]  
 
Developers and customizers will be able to use the following new features in the [!INCLUDE [pn-unified-service-desk-3-3](../includes/pn-unified-service-desk-3-3.md)] release.

### Public Preview Feature: Support for Unified Interface Apps in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]

With this release, [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] supports the apps built using Unified Interface framework. That is, you can load a URL or page from Dynamics 365, which is built based on the Unified Interface framework.

The experience of the supportability is that the Unified Interface Page hosted control type exposes number of predefined UII actions and events that are unique to handling of Dynamics 365 windows built using Unified Interface framework including list manipulation actions, and a find action for displaying a quick search or advanced search page. 

A new hosted control type called **Unified Interface Page** is introduced, which you need to set as **USD Component Type** while creating a hosted control to use URL or page from [!include[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]. 

When you sign in to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], you can see an app module selection window that is introduced as part of the Unified Interface supportability. You need to select a Unified Interface app from the list and experience the app in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].

### Custom Styles field  in Toolbar

You can now customize the toolbar in Unified Service Desk using the custom styles field in the Toolbar configuration window.  The Custom Styles field supports Extensible Application Markup Language (XAML) that defines <xref:System.Windows.ResourceDictionary> of <xref:System.Windows.Style> and <xref:System.Windows.Media.Brush> resources.
 
The resources in the dictionary refers to other resources that are available on Unified Service Desk client application. Loading and parsing the XAML string is performed at runtime to create <xref:System.Windows.ResourceDictionary> and merge the resources of the toolbar control with the <xref:System.Windows.ResourceDictionary>. In addition, the <xref:System.Windows.ResourceDictionary> can have styles for button types inside a toolbar. Using the styles, you can customize the toolbars and buttons.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure toolbars in your application](../unified-service-desk/configure-toolbars-application.md) and [Toolbars in Unified Service Desk](../unified-service-desk/toolbars-unified-service-desk.md)

<a name="WhatsNew32"></a>   
## What's new in [!INCLUDE [pn-unified-service-desk-3-2](../includes/pn-unified-service-desk-3-2.md)] 

There are no developer/customizer-specific changes in this release. For a list of new features in this release, see [New feature information for administrators](admin/whats-new-unified-service-desk-administrators.md)

<a name="WhatsNew31"></a>   
## What's new in [!INCLUDE [pn-unified-service-desk-3-1](../includes/pn-unified-service-desk-3-1.md)] 

There are no developer/customizer-specific changes in this release. For a list of new features in this release, see [New feature information for administrators](admin/whats-new-unified-service-desk-administrators.md)


<a name="WhatsNew3"></a>   
## What's new in [!INCLUDE [pn-unified-service-desk-3-0](../includes/pn-unified-service-desk-3-0.md)]  
 
Developers and customizers will be able to use the following new features in the [!INCLUDE [pn-unified-service-desk-3-0](../includes/pn-unified-service-desk-3-0.md)] release.

### Display customer data faster to your agents by pre-fetching entity data from Customer Engagement

[!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] now lets you load related information for an entity record
in the context along with the entity record page without having to wait for the
full entity web page to load in the client application. The fetched entity
information is populated in the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] context thus enabling any
hosted control to quickly display relevant entity information on the client
application. Use the new **Pre-Fetch Data** check box while configuring a **CRM Page** type of hosted control. 

Also, a new event called **DataReady** is added to the **CRM Page** type of hosted control
to help you perform actions as soon as the related information for an entity
record is loaded in the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] context. 

More information: [CRM Page (Hosted Control)](crm-page-hosted-control.md)


### Asynchronously create entity records to prevent execution blocking

The **CreateEntity** action on the Global Manager hosted control synchronously creates an entity
record on the main thread, and [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] has to wait for the
**CreateEntity** action to complete before proceeding with the next task. This leads
to [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] becoming unresponsive until the action is completed, which might not be desirable in some cases.

In this release, we are introducing a new data parameter, **RunAsync**, for the
**CreateEntity** action that you can use to set the action to run asynchronously so that [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] is not blocked and remains
responsive during the action execution.

More information: [CreateEntity](global-manager-hosted-control.md#createentity) action

### Keyboard shortcuts for toolbar buttons, notifications, and panel navigation

-   Toolbar buttons now support keyboard shortcuts, which can be defined while
    creating a toolbar button. This lets agents execute actions configured
    against the toolbar button from anywhere in the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] client
    without having to click it. Shortcut keys for a toolbar button work only if
    the visible and enable conditions for the button, ancestor buttons (if any),
    and the toolbar itself evaluate to true. More information: [Toolbars in Unified Service Desk](toolbars-unified-service-desk.md)

-   [Notifications](configure-notifications-unified-service-desk.md) in
    [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] now support keyboard shortcuts. Use the default
    keyboard shortcut Alt+1 to set your focus on a notification. If there are
    multiple notifications displayed, you can press Alt+1 repeatedly to cycle
    through all the active notifications on your screen. To change the keyboard
    shortcut keys for notifications, use the new **PopupNavigationShortcut** UII
    option to specify the shortcut keys of your choice.

-   Earlier, the keyboard shortcut used to cyclically traverse through all the
    active panels, Ctrl+0, couldn’t be changed to use any other key combination.
    Now, you can specify shortcut keys of your choice to cyclically traverse
    through all the active panels using the new UII option called
    **PanelNavigationShortcut**. More information: [Keyboard shortcuts for panels](keyboard-shortcuts-panels.md)

### Debugger control enhancements

The Debugger control has been enhanced to offer the following new capabilities
to help developers and customizers in debugging and troubleshooting custom code
and configuration changes more easily:

-   **Sort data**: Sort data in columns of the **Action Calls** tab to display
    data in ascending or descending order in a column. You can also reset all
    the sorted column data to return to the default data displayed in the
    **Action Calls** tab by selecting the **Reset the sorted columns** icon.

-   **Replay action calls**: Quickly rerun an action call by right-clicking the
    action call record in the **Action Calls** tab, and selecting **Replay**
    from the shortcut menu. You can also choose to edit the data parameters for
    an action call and then rerun it by right-clicking the action call in the
    **Action Calls** tab, and selecting **Edit** from the shortcut menu. This
    will load the action call definition in the **Direct Action** tab where you
    modify the required information, and then rerun it.

-   **Replay events**: Quickly rerun an event by right-clicking the event record
    in the **Action Calls** tab, and selecting **Replay** from the shortcut
    menu. Unlike action calls, you cannot edit an event, and rerun it.

-   **Direct Action tab enhancements**: Clear information from all the fields in
    the **Direct Action** tab by selecting the **Clear** icon.

-   **Enhancements for replacement parameters:** In the **Data Parameters** tab,
    you can now add a replacement parameter along with its value, copy a
    replacement parameter’s value, and edit a replacement parameter’s value
    using the new icons.

### Configure JAWS screen reader support

[!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] now supports [!INCLUDE[pn-jaws](../includes/pn-jaws.md)] (Job Access With Speech) version 18 for
Windows screen reader for speech output in the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] client. All
the controls that are part of the [!INCLUDE[pn-ms-dyn-365](../includes/pn-ms-dyn-365.md)] Web Client package are [!INCLUDE[pn-jaws](../includes/pn-jaws.md)]
compliant.
For the custom controls that you develop as part of the solution package, you need to define the necessary properties to make the controls JAWS compliant.

You can configure [!INCLUDE[pn-jaws](../includes/pn-jaws.md)] screen reader support for controls that are focusable.
By design of the product, the tab position does not focus the non-focusable controls. Hence,
[!INCLUDE[pn-jaws](../includes/pn-jaws.md)] does not read controls that are non focusable, such as text block, image, and labels. However,
as a workaround, you can create the non-focusable control as a user control
(wrap it with \<UserControl\>) to support [!INCLUDE[pn-jaws](../includes/pn-jaws.md)] screen reader.

Also, [!INCLUDE[pn-jaws](../includes/pn-jaws.md)] screen reader doesn’t support reading button tooltip text. But, you can create [!INCLUDE[pn-jaws](../includes/pn-jaws.md)] custom scripts and use  in [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] to enable [!INCLUDE[pn-jaws](../includes/pn-jaws.md)] screen reader to read tooltip text.

More information: [Configure JAWS screen reader support](configure-jaws-screen-reader-support.md)

### See also  
 [What’s New in Unified Service Desk for administrators](admin/whats-new-unified-service-desk-administrators.md)   
 
