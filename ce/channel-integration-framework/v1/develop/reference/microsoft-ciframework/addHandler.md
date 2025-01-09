---
title: addHandler (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 1.0 
description: Includes reference information such as description, syntax, and parameters for the addHandler method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 1.0. 
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# addHandler (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 1.0

[!INCLUDE[addHandler-description](Includes/addHandler-description.md)]

## Syntax

`Microsoft.CIFramework.addHandler(eventName, handlerFunction);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| eventName | String | Yes | Name of the event for which the handler is set. <br>The supported events are as follows:<br><ul><li><b>onclicktoact:</b> The event is invoked when the outbound communication (ClickToAct) field is enabled.</li> <li><b>onmodechanged:</b> The event is invoked when the panel mode is manually toggled between Minimized (0) and Docked (1). </li><li><b>onsizechanged:</b> The event is invoked when the panel size is manually changed by dragging. </li><li><b>onpagenavigate:</b> The event is triggered before a navigation event occurs on the main page. </li><li><b>onsendkbarticle: </b> The event is invoked when the user selects the **Send** button on the KB control.</li></ul> You can also pass custom events in the `eventName` parameter. |
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

### Related information

[onclicktoact](../../../../v2/develop/reference/events/onclicktoact.md)  
[onmodechanged](../../../../v2/develop/reference/events/onmodechanged.md)  
[onsizechanged](../../../../v2/develop/reference/events/onsizechanged.md)  
[onpagenavigate](../../../../v2/develop/reference/events/onpagenavigate.md)  
[onsendkbarticle](../../../../v2/develop/reference/events/onsendkbarticle.md)  

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
