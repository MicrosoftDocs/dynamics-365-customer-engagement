---
title: "CTI Desktop Manager (Hosted Control) | MicrosoftDocs"
description: "Learn about using the CTI Desktop Manager hosted control type to plug in a computer telephony integration (CTI) adapter into Unified Service Desk to handle screen popping, call routing, softphone control, and other CTI functionalities."
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
# CTI Desktop Manager (Hosted Control)

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

Use the **CTI Desktop Manager** hosted control type to plug in a computer telephony integration (CTI) adapter into [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to handle screen popping, call routing, softphone control, and other CTI functionalities.  

<a name="Create"></a>   
## Create a CTI Desktop Manager hosted control  
 For information about creating a CTI Desktop Manager and configuring the corresponding hosted control, see [Create a CTI Desktop Manager](../unified-service-desk/create-cti-desktop-manager.md).  

<a name="Actions"></a>   
## Predefined UII actions  
 These are the predefined actions for this hosted control type.  

<a name="Close"></a>   
### Close  
 This action is used to close the hosted control. Unlike the **CloseActive** action, if this tab (hosted control) is displaying more than one page, it will close all the pages displayed in the tab in your agent application.  

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

### GoBack  
 This action is equivalent to clicking the back button on the browser instance.  

### GoForward  
 This action is equivalent to clicking the forward button on the browser instance.  

### GoHome  
 This action goes to the initial URL specified for this browser instance.  

### LoadArea  
 This action loads a specific area from the model-driven apps. This is equivalent to selecting an area in the navigation pane (such as Sales, Service, and Marketing). The only parameter is the name of the area to click. For example: **areaService**.  

|Parameter|Description|  
|---------------|-----------------|  
|frame|The name of the frame to affect. If no name is specified, it will automatically target the first frame found on the page.|  

<a name="MoveToPanel"></a>   
### MoveToPanel  
 This action is used to move hosted controls between panels at runtime.  

|Parameter|Description|  
|---------------|-----------------|  
|app|Name of the hosted control to be moved.|  
|panel|Target panel for the hosted control.|  

### Navigate  
 This action is used to navigate to the model-driven apps url.  


|     Parameter     |                                                                                                                                                                                                                                       Description                                                                                                                                                                                                                                        |
|-------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|        url        |                                                                                                                                                                                                                  The URL to navigate to. This is a mandatory parameter.                                                                                                                                                                                                                  |
|      Noscan       |                                                                                                                                                                                           If this parameter is supplied and **True**, the data parameters will not be captured from the page.                                                                                                                                                                                            |
|  HideCommandBar   |                                                                                                                                                        If this parameter is supplied and **True**, the inner frame will be displayed without loading the model-driven apps command bar.                                                                                                                                                        |
| HideNavigationBar |                                                                                                                                                          If this parameter is supplied and **True**, the form will be displayed without loading the model-driven apps navigation bar.                                                                                                                                                          |
|       Frame       |                                                                                                                                                                          When frames exist on the page, this parameter would specify the name of the frame to navigate, rather than navigating the main window.                                                                                                                                                                          |
|     postdata      |                Data that is sent to the server as part of an HTTPPOST transaction. A POST transaction is typically used to send data gathered by an HTML page. In [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], this data can be received from any event triggered using "<https://event/?>". Example: `[[postdata]+]`<br /><br /> Alternatively, the data can be passed as an encoded string with its header type in the intended format.                 |
|      header       | A string value that contains additional HTTP headers to send to the server. When the `postdata` parameter is used in the `Navigate` action, you should also specify an appropriate value for the `header` parameter. Example: `Content-Type:application/x-www-form-urlencoded`<br /><br /> If a [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]POST event triggers the `Navigate` action, the default value of this parameter should be `header=[[header]+]` |

### New_CRM_Page  
 Creates a page for creating a new the model-driven apps record of the entity specified, and treats the page as a popup from the specified hosted control. The window navigation rules are evaluated to determine the location where the page to create the entity record is displayed.  

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

### ReRoute  
 This action takes the currently displayed URL, and sends it through the window navigation rules from the current hosted control as a popup.  

### RunScript  
 This action injects JavaScript into the main frame of the application. You should avoid using Microsoft Dataverse client SDK calls with this action; instead, use the **RunXrmCommand** action.  

|Parameter|Description|  
|---------------|-----------------|  
||The data parameter is the JavaScript that will be injected into the form. **Note:**  The replacement parameters can be used in the script, and they will be replaced before the script is executed.|  

<a name="RunXrmCommand"></a>   
### RunXrmCommand  
 This action is used to inject Dataverse SDK JavaScript into the model-driven apps form.  

|Parameter|Description|  
|---------------|-----------------|  
||The data parameter is the JavaScript that will be injected into the form. **Note:**  The replacement parameters can be used in the script, and they will be replaced before the script is executed.|  

### Save  
 This action saves the current page.  

<a name="SaveAll"></a>   
### SaveAll  
 This action saves all forms in hosted control that allows multiple pages to be displayed (**Allow Multiple Pages** = Yes). If the hosted control allows only a single page to be displayed (**Allow Multiple Pages** = No), this is equivalent to the **Save** action.  

### SaveAndClose  
 This action saves the dirty data on the model-driven apps form, and closes the hosted control.  

<a name="SetSize"></a>   
### SetSize  
 This action explicitly sets the width and height of the hosted control. This is particularly useful when using "auto" in your panel layouts.  

|Parameter|Description|  
|---------------|-----------------|  
|width|The width of the hosted control.|  
|height|The height of the hosted control.|  

### ToggleNavigation  
 This action collapses or expands the navigation pane on the left panel of the model-driven apps window. The navigation must contain a navigation panel for this action to work.  

### ToggleRibbon  
 This action collapses or expands the ribbon. If you hide the ribbon in the **Navigate** action, it will not be displayed and this action does not work. This action will work only when the ribbon was initially loaded.  

### WaitForComplete  
 This action can be used to block the processing until the URL finishes loading.  

> [!NOTE]
>  Some web pages, particularly the model-driven apps pages, have multiple frames. This action waits for only the main frame to complete.  

|Parameter|Description|  
|---------------|-----------------|  
|Milliseconds|Optional parameter to indicate how long, in milliseconds, to wait to timeout.|  

<a name="Events"></a>   
## Predefined events  
 These are the predefined events for this hosted control type.  

### BrowserDocumentComplete  
 Occurs when the page has finished loading.  

|Parameter|Description|  
|---------------|-----------------|  
|url|The URL of the page that has finished loading.|  

### FrameLoadComplete  
 Occurs any time when a frame has completed loading. This event can occur multiple times per page load when an iFrame or frame is used on the page. This event corresponds to the individual `BrowserDocumentComplete` events in code.  

|Parameter|Description|  
|---------------|-----------------|  
|frame|The name of the frame that finished loading.|  
|url|The URL of the frame that finished loading.|  

### PopupRouted  
 Occurs after a popup has been routed by the system.  

|Parameter|Description|  
|---------------|-----------------|  
|url|The URL of the popup that was routed.|  

### See also  
 [Integrate with CTI systems using CTI adapters](../unified-service-desk/integrate-cti-systems-cti-adapters.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]