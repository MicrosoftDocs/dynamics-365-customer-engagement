---
title: "addHandler (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes reference information such as description, syntax, and parameters for the addHandler method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0. "
ms.date: 11/30/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# addHandler (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[addHandler-description](includes/addHandler-description.md)]

## Syntax

`Microsoft.CIFramework.addHandler(eventName, handlerFunction);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| eventName | String | Yes | Name of the event for which the handler is set. <br> The supported events are:<br><ul><li><b>onclicktoact:</b> The event is invoked when the outbound communication (ClickToAct) field is enabled.</li> <li><b>onmodechanged:</b> The event is invoked when the panel mode is manually toggled between Minimized (0), Docked (1), and Hidden (2). </li><li><b>onsizechanged:</b> The event is invoked when the panel size is manually changed by dragging. </li><li><b>onpagenavigate:</b> The event is triggered before a navigation event occurs on the main page. </li><li><b>onsendkbarticle: </b> The event is invoked when the user selects the **Send** button on the KB control.</li><li><b>onSessionClosed: </b> The event is invoked when the session is closed. </li><li><b>onSessionSwitched: </b> The event is invoked when the user switches from one session to another.</li></ul> You can also pass custom events in the `eventName` parameter. |
| handlerFunction | Function | Yes | The handler function is invoked when any of the supported events are triggered. |

## Example

The sample code demonstrates setting the addHandler method for the `onmodechanged` event.

```JavaScript
handlerFunction = function(eventData) {
console.log(eventData)
return Promise.resolve();
}

Microsoft.CIFramework.addHandler("onmodechanged", handlerFunction);
```

### See also

[onclicktoact](../events/onclicktoact.md)  
[onmodechanged](../events/onmodechanged.md)  
[onsizechanged](../events/onsizechanged.md)  
[onpagenavigate](../events/onpagenavigate.md)  
[onsendkbarticle](../events/onsendkbarticle.md)  
[onSessionClosed](../events/onsessionclosed.md)  
[onSessionSwitched](../events/onsessionswitched.md)  

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
