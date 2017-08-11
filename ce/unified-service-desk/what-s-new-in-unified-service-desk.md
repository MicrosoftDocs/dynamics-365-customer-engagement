---
title: "What&#39;s new in Unified Service Desk for developers | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-08-01"
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
caps.latest.revision: 49
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# What&#39;s new in Unified Service Desk for developers
This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] for system customizers and developers.  
  
<a name="WhatsNew3"></a>   
## What's new in Unified Service Desk 3.0  
 
Developers and customizers will be able to use the following new features in the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] 3.0 release.

### Display customer data faster to your agents by pre-fetching entity data from [!INCLUDE[pn-ms-dyn-365](../includes/pn-ms-dyn-365.md)] Customer Enagement

[!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] now lets you load related information for an entity record
in the context along with the entity record page without having to wait for the
full entity web page to load in the client application. The fetched entity
information is populated in the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] context thus enabling any
hosted control to quickly display relevant entity information on the client
application. This could help agents instantly act or kick start discussion with
customers, and save crucial interaction time.

To pre-fetch entity data in [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)], select the **Pre-Fetch Data**
check box while configuring a **CRM Page** type of hosted control. Also, a new
event called **DataReady** is added to the **CRM Page** type of hosted control
to help you perform actions as soon as the related information for an entity
record is loaded in the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] context. This **DataReady** event
is guaranteed to be fired before the **BrowserDocumentComplete** event and if
**Pre-Fetch Data** attribute is checked for the control, then it is fired as
soon as the entity data is fetched in a separate parallel call to the server and
will not wait for the full page to finish loading The entity data is pre-fetched
and **DataReady** event is fired for inline navigations as well.

### Asynchronously create entity records to prevent execution blocking

The
[CreateEntity](global-manager-hosted-control.md#createentity)
action on the Global Manager hosted control synchronously creates an entity
record on the main thread, and [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] has to wait for the
CreateEntity action to complete before proceeding with the next task. This leads
to [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] becoming unresponsive until the action is completed,
which might not be desirable in some cases.

In this release, we are introducing a new data parameter, **RunAsync**, for the
**CreateEntity** action that you can use to set the action to run asynchronously
(RunAsync=true) so that [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] is not blocked and remains
responsive during the action execution.

**Note**: The associated sub-action calls and subsequent action calls for the
**CreateEntity** action do not wait for the asynchronous create operation to
complete. So, you must ensure that if you are running the **CreateEntity**
action asynchronously, the sub-action calls that depend on the created record
are configured to execute only when the target record is complete. This can be
achieved using the **ExecuteOnDataAvailable** action on the Global Manager
hosted control. For more information, see the **CreateEntity** action.

### Keyboard shortcuts for toolbar buttons, notifications, and panel navigation

-   Toolbar buttons now support keyboard shortcuts, which can be defined while
    creating a toolbar button. This lets agents execute actions configured
    against the toolbar button from anywhere in the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] client
    without having to click it. Shortcut keys for a toolbar button work only if
    the visible and enable conditions for the button, ancestor buttons (if any),
    and the toolbar itself evaluate to true.

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
    **PanelNavigationShortcut**.

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

You can configure [!INCLUDE[pn-jaws](../includes/pn-jaws.md)] screen reader support for controls that are focusable.
[!INCLUDE[pn-jaws](../includes/pn-jaws.md)] does not support controls that are non focusable, such as a label. However,
as a workaround, you can create the non-focusable control as a user control
(wrap it with \<UserControl\>) to support [!INCLUDE[pn-jaws](../includes/pn-jaws.md)] screen reader.

Also, [!INCLUDE[pn-jaws](../includes/pn-jaws.md)] screen reader doesn’t support reading button tooltip text. But, you
can use custom scripts in [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] to enable [!INCLUDE[pn-jaws](../includes/pn-jaws.md)] screen reader to
read tooltip text.
  
  
### See also  
 [What’s New in Unified Service Desk for administrators](whats-new-unified-service-desk-administrators.md)   
 
