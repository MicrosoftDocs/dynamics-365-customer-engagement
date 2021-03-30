---
title: "WebDDA Events in Unified Service Desk | MicrosoftDocs"
description: "Learn about using Web data-driven adapter (WebDDA) events that can be used in automations in Unified Service Desk."
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
# WebDDA Events
The Web data-driven adapter (WebDDA) provides a set of events that can be used in automations. The events can be divided in page events and control events. They map to the same event names used in the DOM. For more information about the events see [Events](https://msdn.microsoft.com/library/aa768400.aspx)  
  
 When registering Action for page events the control parameter in the `RegisterActionForEvent`(For more information, see [Automate hosted applications using HAT automation activities](../unified-service-desk/automate-hosted-applications-using-hat-automation-activities.md)) activity is ignored. For control events the `ControlName` parameter must contain the control name that is specified in the bindings.  
  
 Some of the events also provide additional data about the event. This data can be accessed via the `GetActionData` activity. (For more information, see [Automate hosted applications using HAT automation activities](../unified-service-desk/automate-hosted-applications-using-hat-automation-activities.md)) The following example shows the format they’re provided in.  
  
```xml  
<EventArgs[flags] [frame] [headers ] [navigationcontext] [postdata] [url] [urlcontext] [cancel] [type] [key][button]>  
  
```  
  
 The arguments provide additional options for the events:  
  
|Argument|Description|  
|--------------|-----------------|  
|`flags`|A constant or a value that specifies a combination of the values defined by the `BrowserNavConstants` enumeration.|  
|`frame`|A case-sensitive string expression that evaluates to the name of the frame to display the resource. It is `NULL`, if no named frame is targeted for the resource.|  
|`headers`|A string that contains additional HTTP headers to send to the server. These headers are added to the web browser. This parameter is ignored if the URL isn’t an HTTP URL.|  
|`navigationcontext`|Flags used when opening a new window. These values are used to decide if a pop-up window should be displayed.|  
|`postdata`|Data that is sent to the server as part of an HTTPPOST transaction. A POST transaction is typically used to send data gathered by an HTML form. If this parameter doesn’t specify any post data, this method issues an HTTP`GET` transaction. This parameter is ignored if the URL is not an HTTP URL.|  
|`url`|URL of the page to that the event was navigated to.|  
|`urlcontext`|URL of the page that is opening the new window. This parameter is a part of web browser’s `NewWindow` event.|  
|`cancel`|Page creation was canceled (`True`) or was finished (`False`).|  
|`type`|Event type, is usually the same as the event itself.|  
|`key`|Mouse button that was clicked at the event (1=left, 2=right, and so on).|  
|`button`|Code of the button that was pressed (for example, the Enter key code is 13).|  
  
<a name="BKMK_Control"></a>   
## Control Events  
 Control events are the events associated with a control.  
  
 The following table lists the control events that are available with the respective parameters:  
  
|||  
|-|-|  
|`Element`|`Description`|  
|BeforeNavigate|`flags`, `frame`, `headers`, `navigationcontext`, `postdata`, `url`|  
|onblur|type|  
|onchange|type|  
|onclick|type, button|  
|ondblclick|type, button|  
|onfocus|type|  
|onkeydown|type, key|  
|onmousedown|type, button|  
|onreset|type|  
|onsubmit|type|  
  
<a name="BKMK_pageevents"></a>   
## Page Events  
 When registering actions for page events, the control parameter in the `RegisterActionForEvent` activity is ignored. (For more information, see [Automate hosted applications using HAT automation activities](../unified-service-desk/automate-hosted-applications-using-hat-automation-activities.md))  
  
 The following table lists the page events that are available with the respective parameters:  
  
|||  
|-|-|  
|**Element**|**Description**|  
|BeforeNavigate|`flags`, `frame`, `headers`, `navigationcontext`, `postdata`, `url`|  
|BeforeNewWindow|`flags`, `url`, `urlcontext`|  
|DocumentCompleted|`Notification`, `flag`, `url`|  
|DownloadStarted|`Notification`, `flag`, `url`|  
|DownloadCompleted|`Notification`, `flag`, `url`|  
|NewWindow2|`Cancel`|  
|NewWindow3|`flags`, `url`, `urlcontext`, `cancel`|  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]