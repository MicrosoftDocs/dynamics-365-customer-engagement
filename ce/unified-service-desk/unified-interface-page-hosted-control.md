---
title: "Analyze best practices in Unified Service Desk (Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about the the Unified Interface Page hosted control type to load a URL or page from Dynamics 365. When a Dynamics 365 page is loaded within a hosted control of this type, it will automatically scan the page for data from the entity, and automatically populate the replacement parameters."
ms.custom: ""
ms.date: 04/24/2018
ms.service: "usd"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 3AEB8475-FCBE-4526-8000-CF06CED9586C
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---

# Preview feature: Unified Interface Page (Hosted Control)
Use the **Unified Interface Page** hosted control type to load a URL or page from Unified Interface Apps in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. When a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] page is loaded within a hosted control of this type, it will automatically scan the page for data from the entity, and automatically populate the replacement parameters.
  
 This hosted control type exposes a number of predefined UII actions and events that are unique to handling of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] [!INCLUDE[pn-ms-windows-short](../includes/pn-ms-windows-short.md)] including list manipulation actions, and a find action for displaying a quick search or advanced search page

## Create a Unified Interface Page hosted control

While creating a new hosted control, the fields in the New Hosted Control screen vary based on the type of hosted control you want to create. This section provides information about the specific fields that are unique to the Unified Interface Page hosted control type.

In the New Hosted Control screen:

-   Under **[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]** area, select **Unified Interface Page** from the **USD Component Type** drop-down list.

-   Select **Pre-fetch Data** to load related information for an entity record in the context along with the entity record page without having to wait for the full entity web page to load in the client application. The fetched entity information is populated in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] context thus enabling any hosted control to quickly display relevant entity information on the client application. This could help agents instantly act or kick start discussion with customers, and save crucial interaction time.

-   From the **Allow Multiple Pages** drop-down list, select **No** (default) to replace the Dynamics 365 page that is currently displayed, and update the browser history when [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] receives a navigate action call or a page is routed to the tab. Select **Yes** to automatically create a drop-down list when a second URL is called or a window navigation rule directs a page to the tab. This allows the user to quickly search between the Dynamics 365 pages that are attached to this control. Also, when you select **Yes**, an additional field, **Maximum Browsers**, becomes available where you can specify the maximum number of pages to be displayed in the drop-down list.

-   Under the **Common Properties** area, select the **Application is Global** check box to set the hosted control as global. Global hosted controls can be displayed outside of a customer session. Controls like the agents’ dashboard, wall or search are common uses for global hosted controls. Global hosted controls do not have session-specific state so when you change sessions, these same global hosted controls remain. If the check box is not selected, the hosted control becomes session based. Session-based controls exist in the context of the customer session. If the user changes to another session, all the session pages from the previous session are hidden.

-   The **Display Group** field displays the panel where this hosted control will be displayed. **MainPanel** is the most common for this hosted control type.

For information about other **General** fields, see Create or edit a hosted control.

# Predefined UII actions

These are the predefined actions for this hosted control type.

## AssociatedView

This action loads a specific associated view of Dynamics 365. These views are typically accessed by clicking down arrow next to an entity record name in the nav bar, and selecting the associated entities.

| Parameter         | Description                                                                                                             |
|-------------------|-------------------------------------------------------------------------------------------------------------------------|
| navItemName       | The associated entity that you want to display. Example: Cases                                                          |
| Id                | The ID of the main entity record for which to display the associated entity records.                                    |
| navItemId         | The area in Dynamics 365. Examples: areaSales or areaService.                                                           |
| etn               |                                                                                                                         |
| hideCommandBar    | If this parameter is supplied and True, the inner frame will be displayed without loading the Dynamics 365 command bar. |
| hideNavigationBar | If this parameter is supplied and True, the form will be displayed without loading the Dynamics 365 navigation bar.     |

### 

## Close

This action is used to close the hosted control. Unlike the **CloseActive** action, if this tab (hosted control) is displaying more than one page, it will close all the pages displayed in the tab in your agent application.

## CloseActive

This action is used to close the active window within this hosted control. If the active window is the only window displayed in the hosted control, the hosted control itself will be closed. For **Unified Interface Page** type of hosted controls that do not allow multiple pages (**Allow Multiple Pages** = No), this action is equivalent to the **Close** action.

## CloseAndPrompt

This action closes the hosted control, but prompts the user to save or abandon the changes before closing.

## DisableToolbarButton

This action disables the specified toolbar button on the toolbar in your agent application.

| Parameter | Description                            |
|-----------|----------------------------------------|
|           | Name of the toolbar button to disable. |

## EnableToolbarButton

This action enables the specified toolbar button on the toolbar in your agent application.

| Parameter | Description                           |
|-----------|---------------------------------------|
|           | Name of the toolbar button to enable. |

## Find

Navigate to the quick find list view of the specified entity.

<table>
<thead>
<tr class="header">
<th><strong>Parameter</strong></th>
<th><strong>Description</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td></td>
<td>The data parameter should specify the entity logical name of the quick find list view to display. There are some special case values:<br />
- Use <strong>case</strong> or <strong>incident</strong> to display the quick find list view for cases.<br />
- Use <strong>advfind</strong> to display the advanced find view.<br />
- Use <strong>activities</strong> or <strong>activity</strong> to display the quick find list view for activities.</td>
</tr>
</tbody>
</table>

## FireEvent

Fires a user-defined event from this hosted control.

| Parameter | Description                     |
|-----------|---------------------------------|
| name      | Name of the user-defined event. |

All subsequent name=value pairs become the parameters to the event. For more information about creating a user-defined event, see [Create a user-defined event](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/create-user-defined-event).  

## GetSelectedIds

This action is used to retrieve the selected IDs from the lists.

| Parameter | Description                                                                  |
|-----------|------------------------------------------------------------------------------|
|           | The data parameter should specify the list name to capture the selected IDs. |

The return value contains a semi-colon delimited list of IDs containing the selected items.

## GetSelectedCount

This action retrieves the number of items that are selected. Use the **GetSelectedIds** action to get the actual list of IDs for the entity.

| Parameter | Description                                                                   |
|-----------|-------------------------------------------------------------------------------|
|           | The data parameter should specify the list name to retrieve the selected IDs. |

The return value contains a number represented the quantity of selected items.

## GoHome

This action goes to the initial URL specified for this browser instance.

## GoBack

This action is equivalent to clicking the back button on the browser instance.

## GoForward

This action is equivalent to clicking the forward button on the browser instance.

## LoadArea

This action loads a specific area from Dynamics 365. This is equivalent to selecting an area in the navigation pane (such as Sales, Service, and Marketing). The only parameter is the name of the area to click. For example: **areaService**.

| ## Parameter | Description                                                                                                               |
|--------------|---------------------------------------------------------------------------------------------------------------------------|
| frame        | The name of the frame to affect. If no name is specified, it will automatically target the first frame found on the page. |

## LookupInfo

Displays a Dynamics 365 lookup information dialog box to allow you to select an entity from a list.

| Parameter         | Description                                                                                                                  |
|-------------------|------------------------------------------------------------------------------------------------------------------------------|
| AllowFilterOff    | “0” or “1” to allow the user to turn off the filtering                                                                       |
| DefaultType       | The Logical Name of the default display. This should be one of the numeric values specified in the objecttypes parameter.    |
| DefaultViewId     | “0” or “1” to show the default view                                                                                          |
| DisableQuickFind  | “0” or “1” to show the quick find field                                                                                      |
| DisableViewPicker | “0” or “1” to show the view selector                                                                                         |
| LookupStyle       | Single or Multiple                                                                                                           |
| ShowNewButton     | “0” or “1” to show new button                                                                                                |
| ShowPropButton    | “0” or “1” to show properties button                                                                                         |
| Browse            | “0” or “1” whether to use browsing mode. The following is with this set to “1”.                                              |
| Currentid         | The Guid for the current value                                                                                               |
| objecttypes       | List of object types to display. These are the etc types from Dynamics 365. Example: “1,2” to display accounts and contacts. |

## MoveToPanel

This action moves a Unified Interface Page hosted control to a different panel at runtime.

| Parameter | Description                                                                                                        |
|-----------|--------------------------------------------------------------------------------------------------------------------|
|           | The data parameter should specify the target panel name to move the hosted control to. For example: FloatingPanel. |

## Navigate

This action is used to navigate to a Dynamics 365 url.

<table>
<thead>
<tr class="header">
<th>Parameter</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>url</td>
<td>The URL to navigate to. This is a mandatory parameter.</td>
</tr>
<tr class="even">
<td>HideCommandBar</td>
<td>If this parameter is supplied and True, the inner frame will be displayed without loading the Dynamics 365 command bar.</td>
</tr>
<tr class="odd">
<td>HideNavigationBar</td>
<td>If this parameter is supplied and True, the form will be displayed without loading the Dynamics 365 navigation bar.</td>
</tr>
<tr class="even">
<td>Frame</td>
<td>When frames exist on the page, this parameter would specify the name of the frame to navigate, rather than navigating the main window.</td>
</tr>
<tr class="odd">
<td>postdata</td>
<td>Data that is sent to the server as part of an HTTPPOST transaction. A POST transaction is typically used to send data gathered by an HTML page. In [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], this data can be received from any event triggered using &quot;<a href="http://event/?" class="uri">http://event/?</a>&quot;. Example: [[postdata]+]<br />
<br />
Alternatively, the data can be passed as an encoded string with its header type in the intended format.</td>
</tr>
<tr class="even">
<td>header</td>
<td>A string value that contains additional HTTP headers to send to the server. When the postdata parameter is used in the Navigate action, you should also specify an appropriate value for the header parameter. Example: Content-Type:application/x-www-form-urlencoded<br />
<br />
If a [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]POST event triggers the Navigate action, the default value of this parameter should be header=[[header]+]</td>
</tr>
</tbody>
</table>

## New\_CRM\_Page

Creates a page for creating a new Dynamics 365 record of the entity specified, and treats the page as a popup from the specified hosted control. The window navigation rules are evaluated to determine the location where the page to create the entity record is displayed.

| Parameter   | Description                                                 |
|-------------|-------------------------------------------------------------|
| LogicalName | The logical name of the entity for creating a new instance. |

Note

The rest of the parameters should consist of name=value pairs. These are the additional pre-populated values in the form for creating a new record for the specified entity. For more information about using this action, see step 4 in [Walkthrough 7: Configure agent scripting in your agent application](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/walkthrough-configure-agent-scripting-agent-application).  

## Open\_CRM\_Page

Opens an existing instance of the entity specified and identified by the ID, and treats the page as a popup from the specified hosted control. The window navigation rules are evaluated to determine the location where the popup should be displayed.

| Parameter   | Description                             |
|-------------|-----------------------------------------|
| LogicalName | The logical name of the entity to open. |
| id          | The ID of the entity record to open.    |

### Popup

Pops up a URL from the hosted control and runs the window navigation rules against it for routing the popup to the appropriate location.

| Parameter | Description                                                                                                        |
|-----------|--------------------------------------------------------------------------------------------------------------------|
| url       | Routes a popup from this hosted control using this URL as if it were a popup requested from the displayed control. |
| frame     | The frame from which this popup originated.                                                                        |

## RealignWindow

Displays the hosted control at the specified location on a monitor. You can display hosted control on up to two monitors. This action is applicable for hosted control instances that are configured to be placed on a USDFloatingPanel or USDFloatingToolPanel panel type.

| Parameter | Description                                                                                                                                                                                                                         |
|-----------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| screen    | Specifies the screen on which to display the hosted control. Valid values are 1 or 2. If you don’t specify this parameter, 1 is passed by default.                                                                                  |
| left      | Specifies the position, in percentage, from the left of the screen on the target monitor where the hosted control should be displayed. Valid values are 0 through 100. If you don’t specify this parameter, 0 is passed by default. |
| top       | Specifies the position, in percentage, from the top of the screen on the target monitor where the hosted control should be displayed. Valid values are 0 through 100. If you don’t specify this parameter, 0 is passed by default.  |
| width     | Specifies the width, in percentage, of the hosted control window on the target monitor. Valid values are 1 through 100. If you don’t specify this parameter, 100 is passed by default.                                              |
| height    | Specifies the height, in percentage, of the hosted control window on the target monitor. Valid values are 1 through 100. If you don’t specify this parameter, 100 is passed by default.                                             |

### Refresh

This action refreshes the current page.

## ReRoute

This action takes the currently displayed URL, and sends it through the window navigation rules from the current hosted control as a popup.

## RunScript  
 This action injects JavaScript into the main frame of the application. You should avoid using [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] client SDK calls with this action; instead, use the **RunXrmCommand** action.  
  
|Parameter|Description|  
|---------------|-----------------|  
||The data parameter is the JavaScript that will be injected into the form. **Note:**  The replacement parameters can be used in the script, and they will be replaced before the script is executed.|  

  
## RunXrmCommand  
 This action is used to inject [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] SDK JavaScript into the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Unified Interface Pages (entity forms and grids).  

 You must configure the script as a function of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] SDK JavaScript webResource. The function's first parameter is a context parameter (reserved parameter) which may have one of the following:

 - [FormContext](../developer/clientapi/clientapi-form-context.md) on entity form pages
 - [GridContext](../developer/clientapi/clientapi-grid-context.md) on entity grid pages
 - undefined on other pages
  
|Parameter|Description|  
|---------------|-----------------|  
||The data parameter is the JavaScript that will be injected into the entity form or grid.<br> **Note:**  The replacement parameters can be used in the script, and they will be replaced before the script is executed.|
| webResourceName | Name of the web resource in which the JavaScript function you want to execute is present. |
| functionName | Name of the function. |

This action accepts a list of optional parameters without values. The list of optional parameters are passed as arguments in the same order at runtime. 

#### Example

You want to execute **RunXrmCommand** action to fill the form attributes of a entity form, where the entity form is hosted by Unified Interface type of hosted control. The value you want to fill in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]'s perspective  is a replacement parameter - `[[$Context.Key1]]`.

In order to execute the action, you need to write JavaScript type web resource, and then write a function in the web resource.

```JavaScript
function fillAttributeValue(context, attrValue)
{
context.getAttribute(<attributeName>).setValue(attrValue);
}   
```

You need to configure the data in the action call as follows:

```
webResourceName = webResource1
functionName = fillAttributeValue
‘[[$Context.Key1]]’
```
> [!Note]
> In the above example, observe the quotes around the replacement parameter - `[[$Context.Key1]]`. [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] considers only the value of the parameter (not the data type) and passes the value to the JavaScript function. You must be cautious of the data type while configuring.

## SetSize

This action explicitly sets the width and height of the hosted control. This is particularly useful when using "auto" in your panel layouts.

| Parameter | Description                       |
|-----------|-----------------------------------|
| width     | The width of the hosted control.  |
| height    | The height of the hosted control. |

## SaveAndClose

This action saves the dirty data on the Dynamics 365 form, and closes the hosted control.

## SaveAll

This action saves all forms in hosted control that allows multiple pages to be displayed (**Allow Multiple Pages** = Yes). If the hosted control allows only a single page to be displayed (**Allow Multiple Pages** = No), this is equivalent to the **Save** action.

## Save

This action saves the current Unified Interface Page.

# Predefined events

The following predefined events are associated with this hosted control type.

## ActiveClosed

Occurs when the active hosted control is closed using the [CloseActive](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/crm-page-hosted-control#CloseActive) action.  

| Parameter | Description                                                          |
|-----------|----------------------------------------------------------------------|
| url       | The URL that was displayed in the hosted control when it was closed. |

## DataReady

Occurs as soon as the related information for an entity record is loaded in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] context. This event occurs before the **PageReadyFor** event. If the **Pre-Fetch Data** option is selected for the control instance then this event occurs as soon as the entity data is fetched in a separate parallel call to the server and will not wait for the full page to finish loading. The entity data is pre-fetched and the **DataReady** event is fired for inline navigations as well.

## RefreshRequested

Occurs when refresh is requested on the current page. Refresh can be requested either by pressing the F5 key or calling the Refresh action by the application.

| Parameter | Description                                   |
|-----------|-----------------------------------------------|
| url       | The URL displayed when refresh was requested. |

## Saved

Occurs after a record in the Dynamics 365 page is saved.

| Parameter | Description                                  |
|-----------|----------------------------------------------|
| newId     | The ID assigned to the newly created record. |

## NavigationRequested

Occurs when the navigation happens within Unified Interface apps

| Parameter | Description                       |
|-----------|-----------------------------------|
| url       | The URL of the page navigated to. |

## PageReady

Occurs when the page has finished loading. On a Unified Interface Page type of hosted control, this event occurs after the data has been saved to the replacement parameter list.

| Parameter | Description                                    |
|-----------|------------------------------------------------|
| url       | The URL of the page that has finished loading. |

## See also

 [Support for Unified Interface Apps in Unified Service Desk](../unified-service-desk/Support-unified-interfaces-apps-usd.md)
 [Unified Service Desk and Unified Interface Configuration Walkthroughs](../unified-service-desk/unified-service-desk-unified-interface-configuration-walkthroughs.md)
 [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md) 
 [Walkthrough 2: Display an external webpage in your agent application](../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md)   
 [Walkthrough 3: Display Microsoft Dynamics 365 Unified Interface app records in your agent application](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md)   
 [Walkthrough 4: Display a Microsoft Dynamics 365 Unified Interface app record in a session in your agent application](../unified-service-desk/walkthrough4-unified-interface-display-dynamics-365-record-session-agent-application.md)   
 [Walkthrough 5: Display enhanced session information by displaying session name and overview data](../unified-service-desk/walkthrough5-unified-interface-display-enhanced-session-information-displaying-session-name-overview-data.md)   
 [Walkthrough 6: Configure the Debugger hosted control in your agent application](../unified-service-desk/walkthrough6-unified-interface-configure-debugger-hosted-control-agent-application.md)
 [Walkthrough 7: Configure agent scripting in your agent application](../unified-service-desk/walkthrough7-unified-interface-configure-agent-scripting-agent-application.md)   
