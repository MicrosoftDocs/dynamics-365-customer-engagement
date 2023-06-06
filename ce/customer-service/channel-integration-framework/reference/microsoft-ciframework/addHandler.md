---
title: "addHandler (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 1.0 | MicrosoftDocs"
description: "Includes reference information such as description, syntax, and parameters for the addHandler method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 1.0. "
ms.date: 06/01/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
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
| eventName | String | Yes | Name of the event for which the handler is set. <br>The supported events are as follows:<br><ul><li><b>onclicktoact:</b> The event is invoked when the outbound communication (ClickToAct) field is enabled.</li> <li><b>onmodechanged:</b> The event is invoked when the panel mode is manually toggled between Minimized (0) and Docked (1). </li><li><b>onsizechanged:</b> The event is invoked when the panel size is manually changed by dragging. </li><li><b>onpagenavigate:</b> The event is triggered before a navigation event occurs on the main page. </li><li><b>onsendkbarticle: </b> The event is invoked when the user selects the **Send** button on the KB control.</li></ul> You can also pass custom events in the `eventName` parameter. |
| handlerFunction | Function | Yes | The handler function is invoked when any of the supported events are triggered. |

## Example

The sample code demonstrates setting the addHandler method for the `onModeChanged` event.

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
[onSizeChanged](../events/onsizechanged.md)  
[onPageNavigate](../events/onpagenavigate.md)  
[onSendKBArticle](../events/onsendkbarticle.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
