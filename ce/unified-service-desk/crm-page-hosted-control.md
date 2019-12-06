---
title: "CRM Page (Hosted Control) | MicrosoftDocs"
description: "Learn about the CRM Page hosted control type to load a URL or page from the model-driven app. When a model-driven apps page is loaded within a hosted control of this type, it will automatically scan the page for data from the entity, and automatically populate the replacement parameters."
ms.custom: 
  - dyn365-USD
ms.date: 08/23/2017
ms.service: 
  - dynamics-365-customerservice
ms.topic: article
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# CRM Page (Hosted Control)
Use the **CRM Page** hosted control type to load a URL or page from model-driven apps. When a model-driven apps page is loaded within a hosted control of this type, it will automatically scan the page for data from the entity, and automatically populate the replacement parameters.  

 This hosted control type exposes a number of predefined UII actions and events that are unique to handling of windows including list manipulation actions, and a find action for displaying a quick search or advanced search page  

<a name="Create"></a>
## Create a CRM Page hosted control
 While creating a new hosted control, the fields in the **New Hosted Control** screen vary based on the type of hosted control you want to create. This section provides information about the specific fields that are unique to the **CRM Page** hosted control type. For detailed information about creating a hosted control, see [Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md).

 ![CRM page hosted control](../unified-service-desk/media/crm-itpro-usd-crmpagehostedcontrol.PNG "CRM page hosted control")  

 In the **New Hosted Control** screen:

- Under **Unified Service Desk** area, select **CRM Page** from the **USD Component Type** drop-down list.

- Select **Pre-fetch Data** to load related information for an entity record in the context along with the entity record page without having to wait for the full entity web page to load in the client application. The fetched entity
  information is populated in the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] context thus enabling any hosted control to quickly display relevant entity information on the client
  application. This could help agents instantly act or kick start discussion with
  customers, and save crucial interaction time.

- From the **Allow Multiple Pages** drop-down list, select **No** (default) to replace the model-driven apps page that is currently displayed, and update the browser history when [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] receives a navigate action call or a page is routed to the tab. Select **Yes** to automatically create a drop-down list when a second URL is called or a window navigation rule directs a page to the tab. This will allow the user to quickly search between the model-driven apps page that are attached to this control. Also, when you select **Yes**, an additional field, **Maximum Browsers**, becomes available where you can specify the maximum number of pages to be displayed in the drop-down list.  

- The **Hosting Type** drop-down list specifies how you want this control to be hosted. You can choose **IE Process** (default) or **Internal WPF** . For more information, see [Select a hosting method for hosted controls](../unified-service-desk/select-hosting-method-controls.md).

- Under the **Common Properties** area, select the **Application is Global** check box to set the hosted control as global. Global hosted controls can be displayed outside of a customer session. Controls like the agents’ dashboard, wall or search are common uses for global hosted controls. Global hosted controls do not have session-specific state so when you change sessions, these same global hosted controls remain. If the check box is not selected, the hosted control becomes session based. Session-based controls exist in the context of the customer session. If the user changes to another session, all the session pages from the previous session are hidden.

- The **Display Group** field displays the panel where this hosted control will be displayed. **MainPanel** is the most common for this hosted control type. For information about various panels available in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], see [Panels, panel types, and panel layouts in Unified Service Desk](../unified-service-desk/panels-panel-types-panel-layouts.md).

  For information about other **General** fields, see [Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md).

<a name="actions"></a>
## Predefined UII actions
 These are the predefined actions for this hosted control type.

### AssociatedView  
 This action loads a specific associated view of model-driven apps. These views are typically accessed by clicking down arrow next to an entity record name in the nav bar, and selecting the associated entities.  


|  Parameter  |                                                 Description                                                  |
|-------------|--------------------------------------------------------------------------------------------------------------|
| navItemName |                        The associated entity that you want to display. Example: Cases                        |
|     Id      |             The ID of the main entity record for which to display the associated entity records.             |
|   tabset    | The area in model-driven apps. Examples: areaSales or areaService. |

 For more information about using this action, see step 5 in [Walkthrough 7: Configure agent scripting in your agent application](../unified-service-desk/walkthrough-configure-agent-scripting-agent-application.md).

<a name="Close"></a>
### Close
 This action is used to close the hosted control. Unlike the **CloseActive** action, if this tab (hosted control) is displaying more than one page, it will close all the pages displayed in the tab in your agent application.

<a name="CloseActive"></a>
### CloseActive
 This action is used to close the active window within this hosted control. If the active window is the only window displayed in the hosted control, the hosted control itself will be closed. For **CRM Page** type of hosted controls that do not allow multiple pages (**Allow Multiple Pages** = No), this action is equivalent to the **Close** action.

### CloseAndPrompt
 This action closes the hosted control, but prompts the user to save or abandon the changes before closing.

### DisableToolbarButton
 This action disables the specified toolbar button on the toolbar in your agent application.

|Parameter|Description|
|---------------|-----------------|
||Name of the toolbar button to disable.|

### EnableToolbarButton
 This action enables the specified toolbar button on the toolbar in your agent application.

|Parameter|Description|
|---------------|-----------------|
||Name of the toolbar button to enable.|

### Find
 Navigate to the quick find list view of the specified entity.

|Parameter|Description|
|---------------|-----------------|
||The data parameter should specify the entity logical name of the quick find list view to display. There are some special case values:<br /><br /> -   Use **case** or **incident** to display the quick find list view for cases.<br />-   Use **advfind** to display the advanced find view.<br />-   Use **activities** or **activity** to display the quick find list view for activities.|

### FireEvent
 Fires a user-defined event from this hosted control.

|Parameter|Description|
|---------------|-----------------|
|name|Name of the user-defined event.|

 All subsequent name=value pairs become the parameters to the event. For more information about creating a user-defined event, see [Create a user-defined event](../unified-service-desk/create-user-defined-event.md).

### GetSelectedIds
 This action is used to retrieve the selected IDs from the lists.

|Parameter|Description|
|---------------|-----------------|
||The data parameter should specify the list name to capture the selected IDs.|

 The return value contains a semi-colon delimited list of IDs containing the selected items.

### GetSelectedCount
 This action retrieves the number of items that are selected. Use the **GetSelectedIds** action to get the actual list of IDs for the entity.

|Parameter|Description|
|---------------|-----------------|
||The data parameter should specify the list name to retrieve the selected IDs.|

 The return value contains a number represented the quantity of selected items.

### GoHome
 This action goes to the initial URL specified for this browser instance.

### GoBack
 This action is equivalent to clicking the back button on the browser instance.

### GoForward
 This action is equivalent to clicking the forward button on the browser instance.

### LoadArea  
 This action loads a specific area from model-driven apps. This is equivalent to selecting an area in the navigation pane (such as Sales, Service, and Marketing). The only parameter is the name of the area to click. For example: **areaService**.  

|Parameter|Description|
|---------------|-----------------|
|frame|The name of the frame to affect. If no name is specified, it will automatically target the first frame found on the page.|

### LookupInfo  
 Displays the Common Data Service platform lookup information dialog box to allow you to select an entity from a list.  

|Parameter|Description|  
|---------------|-----------------|  
|AllowFilterOff|“0” or “1” to allow the user to turn off the filtering|  
|DefaultType|The Logical Name of the default display. This should be one of the numeric values specified in the objecttypes parameter.|  
|DefaultViewId|“0” or “1” to show the default view|  
|DisableQuickFind|“0” or “1” to show the quick find field|  
|DisableViewPicker|“0” or “1” to show the view selector|  
|LookupStyle|Single or Multiple|  
|ShowNewButton|“0” or “1” to show new button|  
|ShowPropButton|“0” or “1” to show properties button|  
|Browse|“0” or “1” whether to use browsing mode. The following is with this set to “1”.|  
|Currentid|The Guid for the current value|  
|objecttypes|List of object types to display. Example: “1,2” to display accounts and contacts.|  

<a name="MoveToPanel"></a>
### MoveToPanel
 This action moves a CRM Page  hosted control to a different panel at runtime.

|Parameter|Description|
|---------------|-----------------|
||The data parameter should specify the target panel name to move the hosted control to. For example: `FloatingPanel`.|

### Navigate  
 This action is used to navigate to a model-driven app url.  


|     Parameter     |                                                                                                                                                                                                                                       Description                                                                                                                                                                                                                                        |
|-------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|        url        |                                                                                                                                                                                                                  The URL to navigate to. This is a mandatory parameter.                                                                                                                                                                                                                  |
|      Noscan       |                                                                                                                                                                                           If this parameter is supplied and **True**, the data parameters will not be captured from the page.                                                                                                                                                                                            |
|  HideCommandBar   |                                                                                                                                                        If this parameter is supplied and **True**, the inner frame will be displayed without loading the model-driven apps command bar.                                                                                                                                                        |
| HideNavigationBar |                                                                                                                                                          If this parameter is supplied and **True**, the form will be displayed without loading the model-driven apps navigation bar.                                                                                                                                                          |
|       Frame       |                                                                                                                                                                          When frames exist on the page, this parameter would specify the name of the frame to navigate, rather than navigating the main window.                                                                                                                                                                          |
|     postdata      |                Data that is sent to the server as part of an HTTPPOST transaction. A POST transaction is typically used to send data gathered by an HTML page. In [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], this data can be received from any event triggered using "<http://event/?>". Example: `[[postdata]+]`<br /><br /> Alternatively, the data can be passed as an encoded string with its header type in the intended format.                 |
|      header       | A string value that contains additional HTTP headers to send to the server. When the `postdata` parameter is used in the `Navigate` action, you should also specify an appropriate value for the `header` parameter. Example: `Content-Type:application/x-www-form-urlencoded`<br /><br /> If a [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]POST event triggers the `Navigate` action, the default value of this parameter should be `header=[[header]+]` |

### New_CRM_Page  
 Creates a page for creating a new record of the entity specified, and treats the page as a popup from the specified hosted control. The window navigation rules are evaluated to determine the location where the page to create the entity record is displayed.  

|Parameter|Description|
|---------------|-----------------|
|LogicalName|The logical name of the entity for creating a new instance.|

> [!NOTE]
>  The rest of the parameters should consist of name=value pairs. These are the additional pre-populated values in the form for creating a new record for the specified entity. For more information about using this action, see step 4 in [Walkthrough 7: Configure agent scripting in your agent application](../unified-service-desk/walkthrough-configure-agent-scripting-agent-application.md).

### Open_CRM_Page
 Opens an existing instance of the entity specified and identified by the ID, and treats the page as a popup from the specified hosted control. The window navigation rules are evaluated to determine the location where the popup should be displayed.

|Parameter|Description|
|---------------|-----------------|
|LogicalName|The logical name of the entity to open.|
|id|The ID of the entity record to open.|

### Popup
 Pops up a URL from the hosted control and runs the window navigation rules against it for routing the popup to the appropriate location.

|Parameter|Description|
|---------------|-----------------|
|url|Routes a popup from this hosted control using this URL as if it were a popup requested from the displayed control.|
|frame|The frame from which this popup originated.|

<a name="RealignWindow"></a>
### RealignWindow
[!INCLUDE[cc_RealignWindow_Action](../includes/cc-realignwindow-action.md)]

### Refresh
 This action refreshes the current page.

### ReRoute
 This action takes the currently displayed URL, and sends it through the window navigation rules from the current hosted control as a popup.

### RunScript  
 This action injects JavaScript into the main frame of the application. You should avoid using the Common Data Service platform client SDK calls with this action; instead, use the **RunXrmCommand** action.  

|Parameter|Description|
|---------------|-----------------|
||The data parameter is the JavaScript that will be injected into the form. **Note:**  The replacement parameters can be used in the script, and they will be replaced before the script is executed.|

<a name="RunXrmCommand"></a>   
### RunXrmCommand  
 This action is used to inject the Common Data Service platform SDK JavaScript into the model-driven apps form.  

|Parameter|Description|
|---------------|-----------------|
||The data parameter is the JavaScript that will be injected into the form. **Note:**  The replacement parameters can be used in the script, and they will be replaced before the script is executed.|

<a name="SetSize"></a>
### SetSize
 This action explicitly sets the width and height of the hosted control. This is particularly useful when using "auto" in your panel layouts.

|Parameter|Description|
|---------------|-----------------|
|width|The width of the hosted control.|
|height|The height of the hosted control.|

### SaveAndClose  
 This action saves the dirty data on the model-driven apps form, and closes the hosted control.  

<a name="SaveAll"></a>
### SaveAll
 This action saves all forms in hosted control that allows multiple pages to be displayed (**Allow Multiple Pages** = Yes). If the hosted control allows only a single page to be displayed (**Allow Multiple Pages** = No), this is equivalent to the **Save** action.

### Save
 This action saves the current CRM Page.

### ToggleRibbon
 This action collapses or expands the ribbon. If you hide the ribbon in the **Navigate** action, it will not be displayed and this action does not work. This action will work only when the ribbon was initially loaded.

### ToggleNavigation  
 This action collapses or expands the navigation pane on the left panel of the model-driven apps window. The navigation must contain a navigation panel for this action to work.  

<a name="events"></a>
## Predefined events
 The following predefined events are associated with this hosted control type.

### ActiveClosed
 Occurs when the active hosted control is closed using the [CloseActive](../unified-service-desk/crm-page-hosted-control.md#CloseActive) action.

|Parameter|Description|
|---------------|-----------------|
|url|The URL that was displayed in the hosted control when it was closed.|

### BrowserDocumentComplete
 Occurs when the page has finished loading. On a **CRM Page** type of hosted control, this event occurs after the data has been saved to the replacement parameter list. This event occurs only once, even though multiple frames will have individually fired their **BrowserDocumentComplete** events.

|Parameter|Description|
|---------------|-----------------|
|url|The URL of the page that has finished loading.|

### DataReady
Occurs as soon as the related information for an entity
record is loaded in the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] context. This event occurs before the **BrowserDocumentComplete** event. If the **Pre-Fetch Data** option is selected for the control instance then this event occurs as
soon as the entity data is fetched in a separate parallel call to the server and
will not wait for the full page to finish loading. The entity data is pre-fetched
and the **DataReady** event is fired for inline navigations as well.

### PageLoadComplete
 Occurs any time when a frame has completed loading. This event can occur multiple times per page load when an iFrame or frame is used on the page. This event corresponds to the individual **BrowserDocumentComplete** events in code.

|Parameter|Description|
|---------------|-----------------|
|frame|The name of the frame that finished loading, if available.|
|url|The URL of the frame that finished loading.|

### PopupRouted
 Occurs after a popup has been routed by the system.

|Parameter|Description|
|---------------|-----------------|
|url|The URL of the popup that was routed.|

### RefreshRequested
 Occurs when refresh is requested on the current page. Refresh can be requested either by pressing the F5 key or calling the Refresh action by the application.

|Parameter|Description|
|---------------|-----------------|
|url|The URL displayed when refresh was requested.|

### Saved  
 Occurs after a record in the model-driven apps page is saved.  

|Parameter|Description|
|---------------|-----------------|
|newId|The ID assigned to the newly created record.|

### See also  
 [CRM Dialog (Hosted Control)](../unified-service-desk/crm-dialog-hosted-control.md)   
 [UII actions](../unified-service-desk/uii-actions.md)   
 [Events](../unified-service-desk/events.md)   
 [Walkthrough 3: Display records in your agent application](../unified-service-desk/walkthrough-3-display-microsoft-dynamics-365-records-in-your-agent-application.md)   
 [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)   
 [Administration Guide for Unified Service Desk](http://go.microsoft.com/fwlink/p/?LinkID=394402)
