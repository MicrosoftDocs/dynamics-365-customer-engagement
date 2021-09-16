---
title: "addHandler (JavaScript API Reference) for Channel Integration Framework 1.0 | MicrosoftDocs"
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
| eventName | String | Yes | Name of the event for which the handler is set. <br>The supported events are as follows:<br><ul><li><b>onClickToAct:</b> The event is invoked when the outbound communication (ClickToAct) enabled field is clicked.</li> <li><b>onModeChanged:</b> The event is invoked when the panel mode is manually toggled between Minimized (0) and Docked (1). </li><li><b>onSizeChanged:</b> The event is invoked when the panel size is manually changed by dragging. </li><li><b>onPageNavigate:</b> The event is triggered before a navigation event occurs on the main page </li><li><b>onSendKBArticle: </b> The event is invoked when the user clicks the send button on the KB control.</li></ul>  |
| handlerFunction | Function | Yes | The handler function is invoked when the any of the supported events trigger. |

## Example

The sample code demonstrates setting addHandler method for the `onModeChanged` event.

```JavaScript
handlerFunction = function(eventData) {
console.log(eventData)
return Promise.resolve();
}

Microsoft.CIFramework.addHandler("onmodechanged", handlerFunction);
```

### See also

[onClickToAct](../events/onclicktoact.md)

[onModeChanged](../events/onmodechanged.md)

[onPageNavigate](../events/onpagenavigate.md)

[onSendKBArticle](../events/onsendkbarticle.md)

[onSizeChanged](../events/onsizechanged.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
