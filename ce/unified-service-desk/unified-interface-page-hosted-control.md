---
title: "Unified Interface Page hosted control to load a page from a model-driven app | MicrosoftDocs"
description: "Learn about the Unified Interface Page hosted control type to load a URL or page from a model-driven app. When a model-driven app page is loaded within a hosted control of this type, it will automatically scan the page for data from the entity, and automatically populate the replacement parameters."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/12/2020
ms.topic: article
ms.service: dynamics-365-customerservice
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---

# Unified Interface Page (hosted control)

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

Use the Unified Interface Page hosted control type to load a URL or page from Unified Interface apps in model-driven apps. When a model-driven app page is loaded within a hosted control of this type, it automatically scans the page for data from the entity, and automatically populates the replacement parameters.
  
This hosted control type exposes a number of predefined UII actions and events that are unique to the handling of model-driven apps [!INCLUDE[pn-ms-windows-short](../includes/pn-ms-windows-short.md)], including list manipulation action and a find action for displaying a quick search or advanced search page.

## Create a Unified Interface Page hosted control

While you're creating a new hosted control, the fields on the **New Hosted Control** screen will vary based on the type of hosted control you want to create. This section provides information about the specific fields that are unique to the Unified Interface Page hosted control type.

On the **New Hosted Control** screen:

- In the **[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]** area, select **Unified Interface Page** from the **Unified Service Desk Component Type** drop-down list.

- Select **Pre-fetch Data** to load related information for an entity record in the context along with the entity record page, without having to wait for the full entity webpage to load in the client application. The fetched entity information is populated in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] context, thus enabling any hosted control to quickly display relevant entity information in the client application. This can help agents instantly act or kick-start discussions with customers, saving crucial interaction time.

- From the **Allow Multiple Pages** drop-down list, select **No** (default) to replace the model-driven app page that's currently displayed and update the browser history when [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] receives a navigate action call or a page is routed to the tab. Select **Yes** to automatically create a drop-down list when a second URL is called or a window navigation rule directs a page to the tab. This allows the user to quickly search between the model-driven app pages that are attached to this control. Also, when you select **Yes**, an additional field, **Maximum Browsers**, becomes available where you can specify the maximum number of pages to be displayed in the drop-down list.

- In the **Common Properties** area, select the **Application is Global** check box to set the hosted control as global. Global hosted controls can be displayed outside of a customer session. Controls like the agent's dashboard, wall, or search are common uses for global hosted controls. Global hosted controls don't have a session-specific state, so when you change sessions, these same global hosted controls remain. If this check box isn't selected, the hosted control becomes session-based. Session-based controls exist in the context of the customer session. If the user changes to another session, all the pages from the previous session are hidden.

- The **Display Group** field displays the panel where this hosted control will be displayed. **MainPanel** is the most common choice for this hosted control type.

More information: [Create or edit a hosted control](create-edit-hosted-control.md)

## Predefined UII actions

The following are the predefined actions for this hosted control type.

### AssociatedView

This action loads a specific associated view. These views are typically accessed by expanding the entity record name in the nav bar, and selecting the associated entities.

| Parameter         | Description                                                                                                             |
|-------------------|-------------------------------------------------------------------------------------------------------------------------|
| etn               | The name of the entity for which you want to load the list of records of the associated entity.  This is a mandatory parameter.|
| Id                | The ID of the main entity record for which to display the associated entity records.                                    |
| navItemId         | The ID of the navigation item corresponding to the associated entity. More information: [formContext.ui.navigation](/dynamics365/customer-engagement/developer/clientapi/reference/formcontext-ui-navigation)      |
| hideCommandBar    | If this parameter is supplied and False, the page will be displayed along with the model-driven app command bar. |
| hideNavigationBar | If this parameter is supplied and False, the page will be displayed along with the model-driven app navigation bar.     |

### Close

This action is used to close the hosted control. Unlike the **CloseActive** action, if this tab (hosted control) is displaying more than one page, this action will close all the pages displayed in the tab in your agent application.

### CloseActive

This action is used to close the active window within this hosted control. If the active window is the only window displayed in the hosted control, the hosted control itself will be closed. For Unified Interface Page hosted controls that don't allow multiple pages (**Allow Multiple Pages** = No), this action is equivalent to the **Close** action.

### CloseAndPrompt

This action closes the hosted control, but prompts the user to save or abandon their changes before closing.

### Find

Navigate to the quick find list view of the specified entity.

| Parameter|Description|
|-----------------------------------|------------------------------------------|
| *See description* |The data parameter should specify the entity logical name of the quick find list view to display. There are some special case values:<br/>- Use **case** or **incident** to display the quick find list view for cases.<br /> - Use **activities** or **activity** to display the quick find list view for activities.|
| hideNavigationBar | Set to True to hide the navigation bar, otherwise False.|
| hideCommandBar | Set to True to hide the command bar, otherwise False.|

### FireEvent

Fires a user-defined event from this hosted control.

| Parameter | Description                     |
|-----------|---------------------------------|
| name      | The name of the user-defined event. |

All subsequent name/value pairs become the parameters to the event. More information: [Create a user-defined event](/dynamics365/customer-engagement/unified-service-desk/create-user-defined-event)

### GetSelectedIds

This action is used to retrieve the selected IDs from the lists.

| Parameter | Description                                                                  |
|-----------|------------------------------------------------------------------------------|
|   *See description*  | The data parameter should specify the list name to capture the selected IDs from. |

The return value contains a semicolon-delimited list of IDs containing the selected items.

### GetSelectedCount

This action retrieves the number of items that are selected. Use the **GetSelectedIds** action to get the actual list of IDs for the entity.

| Parameter | Description                                                                   |
|-----------|-------------------------------------------------------------------------------|
|   *See description* | The data parameter should specify the list name to retrieve the selected IDs from. |

The return value contains a number representing the quantity of selected items.

### GoHome

This action goes to the initial URL specified for this browser instance.

### GoBack

This action is equivalent to selecting the back button in the browser instance.

### GoForward

This action is equivalent to selecting the forward button in the browser instance.

### MoveToPanel

This action moves a Unified Interface Page hosted control to a different panel at runtime.

| Parameter | Description                                                                                                        |
|-----------|--------------------------------------------------------------------------------------------------------------------|
|   *See description* | The data parameter should specify the target panel name to move the hosted control to (for example, FloatingPanel). |

### Navigate

This action is used to navigate to a model-driven app URL. The App Id for the app that you select from the **Select App Module** window is appended automatically.

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
<td>If this parameter is supplied and True, the inner frame will be displayed without loading the model-driven app command bar.</td>
</tr>
<tr class="odd">
<td>HideNavigationBar</td>
<td>If this parameter is supplied and True, the form will be displayed without loading the model-driven app navigation bar.</td>
</tr>
<tr class="even">
<td>Frame</td>
<td>When frames exist on the page, this parameter specifies the name of the frame to navigate, rather than navigating the main window.</td>
</tr>
<tr class="odd">
<td>postdata</td>
<td>Data that's sent to the server as part of an HTTP POST transaction. A POST transaction is typically used to send data gathered by an HTML page. In Unified Service Desk, this data can be received from any event triggered by using &quot;<a href="https://event/?" class="uri">https://event/?</a>&quot;. Example: [[postdata]+]<br />
<br />
Alternatively, the data can be passed as an encoded string with its header type in the intended format.</td>
</tr>
<tr class="even">
<td>header</td>
<td>A string value that contains additional HTTP headers to send to the server. When the postdata parameter is used in the <b>Navigate</b> action, you should also specify an appropriate value for the header parameter, for example Content-Type:application/x-www-form-urlencoded<br />
<br />
If a Unified Service Desk POST event triggers the <b>Navigate</b> action, the default value of this parameter should be header=[[header]+]<br />
<br />
To add multiple headers, the value of this parameter should be:<br />
<br />
<code>header=$Multiline(</code>headers separated by newline<code>)</code> <br /> 
<br />
Example: <code>header=$Multiline(accessToken;dummyAccessToken==</code><br />
<br />
<code>refreshToken;dummyRefreshToken===)</code></td>
</tr>
</tbody>
</table>

### New\_CRM\_Page

Creates a page for creating a new record of the entity specified, and treats the page as a pop-up window from the specified hosted control. The window navigation rules are evaluated to determine the location where the page to create the entity record will be displayed.

| Parameter   | Description                                                 |
|-------------|-------------------------------------------------------------|
| LogicalName | The logical name of the entity for creating a new instance. |

> [!Note]
> The rest of the parameters should consist of name/value pairs. These are the additional pre-populated values in the form for creating a new record for the specified entity.

### Open\_CRM\_Page

Opens an existing instance of the entity specified and identified by the ID, and treats the page as a pop-up window from the specified hosted control. The window navigation rules are evaluated to determine the location where the pop-up window should be displayed.

| Parameter   | Description                             |
|-------------|-----------------------------------------|
| LogicalName | The logical name of the entity to open. |
| id          | The ID of the entity record to open.    |

### Popup

"Pops up" a URL from the hosted control and runs the window navigation rules against it for routing the pop-up window to the appropriate location.

| Parameter | Description                                                                                                        |
|-----------|--------------------------------------------------------------------------------------------------------------------|
| url       | Routes a pop-up window from this hosted control by using this URL as if it were a pop-up window requested from the displayed control. |
| frame     | The frame from which this pop-up window originated.                                                                        |

### RealignWindow

Displays the hosted control at the specified location on a monitor. You can display hosted controls on up to two monitors. This action is applicable for hosted control instances that are configured to be placed on a USDFloatingPanel or USDFloatingToolPanel panel type.

| Parameter | Description                                                                                                                                                                                                                         |
|-----------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| screen    | Specifies the screen on which to display the hosted control. Valid values are 1 or 2. If you don't specify this parameter, 1 is passed by default.                                                                                  |
| left      | Specifies the position, in percentage, from the left of the screen on the target monitor where the hosted control should be displayed. Valid values are from 0 through 100. If you don't specify this parameter, 0 is passed by default. |
| top       | Specifies the position, in percentage, from the top of the screen on the target monitor where the hosted control should be displayed. Valid values are from 0 through 100. If you don't specify this parameter, 0 is passed by default.  |
| width     | Specifies the width, in percentage, of the hosted control window on the target monitor. Valid values are from 1 through 100. If you don't specify this parameter, 100 is passed by default.                                              |
| height    | Specifies the height, in percentage, of the hosted control window on the target monitor. Valid values are from 1 through 100. If you don't specify this parameter, 100 is passed by default.                                             |

### Refresh

This action refreshes the current page.

### RunScript

This action injects JavaScript into the main frame of the application. You should avoid using Microsoft Dataverse client SDK calls with this action; instead, use the **RunXrmCommand** action.  
  
|Parameter|Description|  
|---------------|-----------------|  
|  *See description* |The data parameter is the JavaScript that will be injected into the form. **Note:** The replacement parameters can be used in the script, and they'll be replaced before the script is executed.|
| Frame | When frames exist on the page, this parameter specifies the name of the frame in which to inject the JavaScript. |

### RunXrmCommand

 This action is used to run JavaScript code that uses the model-driven apps [Client API Reference](/dynamics365/customer-engagement/developer/clientapi/reference) into the Unified Interface Pages (entity forms and grids). 

 You must configure the script as a function of the model-driven apps JavaScript webResource. The function's first parameter is a context parameter (reserved parameter) which can have one of the following values:

 - [FormContext](/dynamics365/customer-engagement/developer/clientapi/clientapi-form-context) on entity form pages
 - [GridContext](/dynamics365/customer-engagement/developer/clientapi/clientapi-grid-context) on entity grid pages
 - **undefined** on other pages
  
|Parameter|Description|  
|---------------|-----------------|
| webResourceName | The name of the web resource in which the JavaScript function you want to execute is present. |
| functionName | The name of the function. |

The other parameters to the function are customer-defined and can be used to pass Unified Service Desk replacement parameters at runtime. This action accepts a list of optional parameters without keys. The list of optional parameters are passed as arguments in the same order from the second position after context replacement at runtime.

#### Example

You want to execute **RunXrmCommand** action to fill the form attributes of a entity form, where the entity form is hosted by a Unified Interface Page type of hosted control. The value you want to fill, from the perspective of [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], is a replacement parameter&mdash;`[[$Context.Key1]]`.

To execute the action, you need to write JavaScript type web resource (say, webResource1), and then write a function in the web resource.

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
'[[$Context.Key1]]'
```

> [!Note]
> In the above example, observe the single quotation marks around the replacement parameter, `[[$Context.Key1]]`. [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] considers only the value of the parameter (not the data type) and passes all the characters in context replaced value to the JavaScript function. You must be cautious and take care of the data type while configuring.

### SetSize

This action explicitly sets the width and height of the hosted control. This is particularly useful when using "auto" in your panel layouts.

| Parameter | Description                       |
|-----------|-----------------------------------|
| width     | The width of the hosted control.  |
| height    | The height of the hosted control. |

### SaveAndClose

This action saves the "dirty" data on the model-driven app form and closes the hosted control.

### SaveAll

This action saves all forms in a hosted control that allows multiple pages to be displayed (**Allow Multiple Pages** = Yes). If the hosted control allows only a single page to be displayed (**Allow Multiple Pages** = No), this is equivalent to the **Save** action.

### Save

This action saves the current Unified Interface Page.

## Predefined events

The following predefined events are associated with this hosted control type.

### ActiveClosed

Occurs when the active hosted control is closed by using the [**CloseActive**](/dynamics365/customer-engagement/unified-service-desk/crm-page-hosted-control#CloseActive) action.  

| Parameter | Description                                                          |
|-----------|----------------------------------------------------------------------|
| url       | The URL that was displayed in the hosted control when it was closed. |

### DataReady

Occurs as soon as the related information for an entity record is loaded in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] context. This event occurs before the **PageReadyFor** event. If the **Pre-Fetch Data** option is selected for the control instance, this event occurs as soon as the entity data is fetched in a separate parallel call to the server and won't wait for the full page to finish loading. The entity data is pre-fetched, and the **DataReady** event is fired for inline navigation as well.

> [!Note]
> For dashboards, web resources, and search pages, the DataReady event isn't fired.

### RefreshRequested

Occurs when refresh is requested on the current page. Refresh can be requested either by pressing the F5 key or calling the Refresh action by the application.

| Parameter | Description                                   |
|-----------|-----------------------------------------------|
| url       | The URL displayed when refresh was requested. |

### Saved

Occurs after a record in the model-driven app page is saved.

| Parameter | Description                                  |
|-----------|----------------------------------------------|
| newId     | The ID assigned to the newly created record. |

### NavigationRequested

Occurs when the navigation happens within Unified Interface apps.

| Parameter | Description                       |
|-----------|-----------------------------------|
| url       | The URL of the page navigated to. |

### PageReady

Occurs when the page has finished loading. On a Unified Interface Page type of hosted control, this event occurs after the data has been saved to the replacement parameter list.

| Parameter | Description                                    |
|-----------|------------------------------------------------|
| url       | The URL of the page that has finished loading. |

> [!Note]
> For dashboards, web resources, and search pages, the DataReady event isn't fired.

### BrowserWindowReady

The **BrowserWindowReady** event is invoked when the browser window is ready within Unified Service Desk client application. Use **BrowserWindowReady** for dashboards and web resources.

### OnClickToAct

The **OnClickToAct** event is invoked when user selects the outbound communication (ClickToAct) field in a form.

You can also write custom controls to raise the Channel Integration Framework ClickToAct window event and pass any eventData in accordance with business requirements.

More information: [onclicktoact](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/events/onclicktoact)

### OnSendKbArticle

The **OnSendKbArticle** event is invoked when the user selects **Send** in the Knowledge Base control. The eventData are the URL and the title of KB article that you need to pass.

More information: [onsendkbarticle](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/events/onsendkbarticle)

> [!Note]
> We recommend that you not use `window.IsUSD` in the model-driven app forms; instead, use [**PageReady**](#pageready)  or other events as listed in this topic.

### See also

[Support for Unified Interface Apps in Unified Service Desk](../unified-service-desk/admin/Support-unified-interfaces-apps-usd.md)  
[Unified Service Desk and Unified Interface Configuration Walkthroughs](../unified-service-desk/unified-service-desk-unified-interface-configuration-walkthroughs.md)  
[Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md)  
[Walkthrough 2: Display an external webpage in your agent application](../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md)   
[Walkthrough 3: Display Unified Interface apps records in your agent application](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md)   
[Walkthrough 4: Display a Unified Interface apps record in a session in your agent application](../unified-service-desk/walkthrough4-unified-interface-display-dynamics-365-record-session-agent-application.md)   
[Walkthrough 5: Display enhanced session information by displaying session name and overview data](../unified-service-desk/walkthrough5-unified-interface-display-enhanced-session-information-displaying-session-name-overview-data.md)   
[Walkthrough 6: Configure the Debugger hosted control in your agent application](../unified-service-desk/walkthrough6-unified-interface-configure-debugger-hosted-control-agent-application.md)  
[Walkthrough 7: Configure agent scripting in your agent application](../unified-service-desk/walkthrough7-unified-interface-configure-agent-scripting-agent-application.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]