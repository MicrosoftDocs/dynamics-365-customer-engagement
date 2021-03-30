---
title: "What's new in Unified Service Desk for developers and customizers | MicrosoftDocs"
description: "Learn about the new features for developers and customizers in Unified Service Desk."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 02/04/2021
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

# What's new in Unified Service Desk for developers and customizers

::: moniker range="dynamics-usd-4.1"

##  What's new in Unified Service Desk 4.1.1.1433

This release supports the Dynamics 365 model-driven apps deployed in Switzerland region.

##  What's new in [!INCLUDE[pn-unified-service-desk-4-1](../includes/pn-unified-service-desk-4-1.md)]

### Use Chrome Process hosting type to host web applications in Unified Service Desk

Use Chrome Process to host web applications in Unified Service Desk client application. The Chrome Process is based on **CefSharp**, an open source framework, which uses the chromium core that powers many modern browsers.

The advantages of using the Chrome process hosting method are as follows:

- Chrome Process is available on different Windows OS versions.
- Chrome Process is highly reliable.
- Easy configurations to host the applications in Unified Service Desk.
- Switch easily from one browser to another for your entire organization.
- Chrome Process pooling feature that reuses the chrome processes and mimics inline navigation provides enhanced performance and memory optimizations.

More information: [Use Chrome Process to host web applications in Unified Service Desk](chrome-process.md)

### Integrate channel using Channel Integration Framework

Bring your channel providers and integrate them with Unified Service Desk client application using Channel Integration Framework.

If your organization wants to use the cloud-based channel that you have developed using the [Channel Integration Framework](https://docs.microsoft.com/dynamics365/customer-service/channel-integration-framework/channel-integration-framework), you can integrate the same channel in Unified Service Desk with minimal configuration experience. In turn, this eliminates the need for developing multiple channels. 

The User Interface Integration (UII) framework provides a hosted control - **Channel Integration Framework** - for you to host the channel provider within Unified Service Desk client application.

More information: [Integrate channel using Channel Integration Framework](integrate-channel-provider-channel-integration-framework.md)

### Stack notification in Unified Service Desk

You can configure stack notifications in Unified Service Desk to display popup notification messages to your customer service agents that contains general information, customer or process-related information that the agent can act on.
This facilitates simultaneous toast notifications in a multi-session environment. 

Two new parameters are introduced: **stack** and **stackHeight**, for which you can set the values to show the notifications in a stack with a certain height.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Stack Notifications](configure-notifications-unified-service-desk.md#stack-notifications) and [Popup Notification Hosted Control](popup-notification-hosted-control.md)

### Switch between local sessions, and between local and global sessions

When you are working on a case (local session) and want to review your Dashboard (global session) or another case (local session), you can easily switch from the case to Dashboard or another case, without affecting your session timer. That is, when you switch from local session, your session timer doesn't count until you switch back to the session. This helps in efficiently measure the agents' productivity.

Using **SwitchSession** action, you can now switch between local sessions. Also, you can switch sessions between local and global by passing the global session ID retrieved from the context using the replacement parameter.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [SwitchSession Action](session-tabs-hosted-control.md#switchsession)

::: moniker-end

::: moniker range="dynamics-usd-4"

## What's new in [!INCLUDE[pn-unified-service-desk-4-0](../includes/pn-unified-service-desk-4-0.md)]

This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] for developers and system customizers. 

### General Availability: Support for Unified Interface apps in Unified Service Desk

With the release of [!include[pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)], we've introduced a new user experience -[Unified Interface](/dynamics365/customer-engagement/admin/about-unified-interface), which uses responsive web design principles to provide an optimal viewing and interaction experience for any screen size, device, or orientation.  [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] supports the apps built using Unified Interface framework. That is, you can load a URL or page from model-driven app, which is built based on the Unified Interface framework.

A new hosted control type called **Unified Interface Page** is introduced, which you need to set as **USD Component Type** while creating a hosted control to use a URL or page from the model-driven apps.

The experience of the supportability is that the Unified Interface Page hosted control type exposes number of predefined UII actions and events that are unique to handling of model-driven app windows built using Unified Interface framework including list manipulation actions, and a find action for displaying a quick search or advanced search page.

## Preview features

### Stack notification in Unified Service Desk

You can configure stack notifications in Unified Service Desk to display popup notification messages to your customer service agents that contains general information or some customer or process-related information that the agent can act on.
This facilitates simultaneous toast notifications in a multi-session environment. 

Two new parameters are introduced: **stack** and **stackHeight**, for which you can set the values to show the notifications in a stack with a certain height.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Stack Notifications](configure-notifications-unified-service-desk.md#stack-notifications) and [Popup Notification Hosted Control](popup-notification-hosted-control.md)

### Switch between local sessions, and between local and global sessions

When you are working on a case (local session) and want to review your Dashboard (global session) or another case (local session), you can easily switch from the case to Dashboard or another case, without affecting your session timer. That is, when you switch from local session, your session timer will not be counted until you switch back to the session. This helps in efficiently measure the agents' productivity.

Using **SwitchSession** action, you can now switch between local sessions. Also, you can switch sessions between local and global by passing the global session ID retrieved from the context using the replacement parameter.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [SwitchSession Action](session-tabs-hosted-control.md#switchsession)

::: moniker-end

::: moniker range="dynamics-usd-3"

<a name="WhatsNew33"></a>   

## What's new in [!INCLUDE [pn-unified-service-desk-3-3](../includes/pn-unified-service-desk-3-3.md)]

Developers and customizers will be able to use the following new features in the [!INCLUDE [pn-unified-service-desk-3-3](../includes/pn-unified-service-desk-3-3.md)] release.

### Videos

See the video to know [What's New in Unified Service Desk 3.3](https://go.microsoft.com/fwlink/?linkid=2008774).

### Public Preview Feature: Support for Unified Interface Apps in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]

With this release, [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] supports the apps built using Unified Interface framework. That is, you can load a URL or page from model-driven app, which is built based on the Unified Interface framework.

The experience of the supportability is that the Unified Interface Page hosted control type exposes number of predefined UII actions and events that are unique to handling of model-driven app windows built using Unified Interface framework including list manipulation actions, and a find action for displaying a quick search or advanced search page. 

A new hosted control type called **Unified Interface Page** is introduced, which you need to set as **USD Component Type** while creating a hosted control to use URL or page from the model-driven app. 

When you sign in to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], you can see an app module selection window that is introduced as part of the Unified Interface supportability. You need to select a Unified Interface app from the list and experience the app in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].

### Custom Styles field  in Toolbar

You can now customize the toolbar in Unified Service Desk using the custom styles field in the Toolbar configuration window.  The Custom Styles field supports Extensible Application Markup Language (XAML) that defines <xref:System.Windows.ResourceDictionary> of <xref:System.Windows.Style> and <xref:System.Windows.Media.Brush> resources.
 
The resources in the dictionary refers to other resources that are available on Unified Service Desk client application. Loading and parsing the XAML string is performed at runtime to create <xref:System.Windows.ResourceDictionary> and merge the resources of the toolbar control with the <xref:System.Windows.ResourceDictionary>. In addition, the <xref:System.Windows.ResourceDictionary> can have styles for button types inside a toolbar. Using the styles, you can customize the toolbars and buttons.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure toolbars in your application](../unified-service-desk/configure-toolbars-application.md) and [Toolbars in Unified Service Desk](../unified-service-desk/toolbars-unified-service-desk.md)

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

- Toolbar buttons now support keyboard shortcuts, which can be defined while
  creating a toolbar button. This lets agents execute actions configured
  against the toolbar button from anywhere in the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] client
  without having to click it. Shortcut keys for a toolbar button work only if
  the visible and enable conditions for the button, ancestor buttons (if any),
  and the toolbar itself evaluate to true. More information: [Toolbars in Unified Service Desk](toolbars-unified-service-desk.md)

- [Notifications](configure-notifications-unified-service-desk.md) in
  [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] now support keyboard shortcuts. Use the default
  keyboard shortcut Alt+1 to set your focus on a notification. If there are
  multiple notifications displayed, you can press Alt+1 repeatedly to cycle
  through all the active notifications on your screen. To change the keyboard
  shortcut keys for notifications, use the new **PopupNavigationShortcut** UII
  option to specify the shortcut keys of your choice.

- Earlier, the keyboard shortcut used to cyclically traverse through all the
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

::: moniker-end

### See also  
 [What’s New in Unified Service Desk for administrators](admin/whats-new-unified-service-desk-administrators.md)   
 


[!INCLUDE[footer-include](../includes/footer-banner.md)]