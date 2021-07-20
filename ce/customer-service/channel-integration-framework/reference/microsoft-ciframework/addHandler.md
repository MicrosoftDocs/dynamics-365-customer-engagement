---
title: "addHandler (JavaScript API Reference) for Channel Integration Framework 1.0| MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the addHandler method in JavaScript API Reference for Channel Integration Framework 1.0. "
ms.date: 10/12/2018
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# addHandler (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 1.0

[!INCLUDE[addHandler-description](includes/addHandler-description.md)] 

## Syntax

`Microsoft.CIFramework.addHandler(eventName, handlerFunction);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| eventName | string | Yes | Name of the event for which the handler is set. <br>The supported events are as follows:<br><ul><li><b>onclicktoact:</b> The event is invoked when the outbound communication (ClickToAct) enabled field is clicked.</li> <li><b>onmodechanged:</b> The event is invoked when the panel mode is manually toggled between Minimized (0) and Docked (1). </li><li><b>onsizechanged:</b> The event is invoked when the panel size is manually changed by dragging. </li><li><b>onpagenavigate:</b> The event is triggered before a navigation event occurs on the main page </li><li><b>onsendkbarticle: </b> The event is invoked when the user clicks the send button on the KB control.</li></ul>  |
| handlerFunction | Function | Yes | The handler function is invoked when the any of the supported events trigger. |

## Example

The sample code demonstrates setting addHandler method for the `onmodechanged` event.

```JavaScript
handlerFunction = function(eventData) {
console.log(eventData)
return Promise.resolve();
}

Microsoft.CIFramework.addHandler("onmodechanged", handlerFunction);
```

## Related topics

[onclicktoact](../events/onclicktoact.md)

[onmodechanged](../events/onmodechanged.md)

[onpagenavigate](../events/onpagenavigate.md)

[onsendkbarticle](../events/onsendkbarticle.md)

[onsizechanged](../events/onsizechanged.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
