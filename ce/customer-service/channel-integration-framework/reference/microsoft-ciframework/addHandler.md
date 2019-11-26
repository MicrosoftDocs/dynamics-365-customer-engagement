---
title: "addHandler (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 10/12/2018
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
---

# addHandler (CIF JavaScript API Reference)

[!INCLUDE[addHandler-description](includes/addHandler-description.md)] 

## Syntax

`Microsoft.CIFramework.addHandler(eventName, handlerFunction);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| eventName | string | Yes | Name of the event for which the handler is set. <br>The supported events are as follows:<br><ul><li><b>onclicktoact:</b> The event is invoked when the outbound communication (ClickToAct) enabled field is clicked.</li> <li><b>onmodechanged:</b> The event is invoked when the panel mode is manually toggled between Minimized (0) and Docked (1). </li><li><b>onsizechanged:</b> The event is invoked when the panel size is manually changed by dragging. </li><li><b>onpagenavigate:</b> The event is triggered before a navigation event occurs on the main page </li><li><b>onsendkbarticle: </b> The event is invoked when the user clicks the send button on the KB control.</li></ul>  |
| handlerFunction | Function | Yes | The handler function is invoked when the any of the supported events trigger. |

## Example

<!--
### Example 1: addHandler method for the `onclicktoact` event

The sample code shows addHandler method is set for the `onclicktoact` event.

```JavaScript
function handlerfunction(eventData) {
var eventData = {
  "value": "123456789", 
  "name": "mobilephone",
  "format": "phone",
  "entityLogicalName": "contact"
  }
}

Microsoft.CIFramework.addHandler("onclicktoact", handlerFunction);
```

### Example 2: addHandler method for the `onmodechanged` event

The sample code demonstrates setting addHandler method for the `onmodechanged` event.

```JavaScript
function handlerfunction(eventData) {
var eventData =
  {"value": "0"},
}

Microsoft.CIFramework.addHandler("onmodechanged", handlerFunction);
```

### Example 3: addHandler method for the `onsizechanged` event

The sample code demonstrates setting addHandler method for the `onsizechanged` event.

```JavaScript
function handlerfunction(eventData) {
var eventData =
  {"value": "30"}, 
}

Microsoft.CIFramework.addHandler("onsizechanged", handlerFunction);
```

### Example 4: addHandler method for the `onpagenavigate` event

The sample code demonstrates setting addHandler method for the `onpagenavigate` event.

```JavaScript
function handlerfunction(eventData) {
var eventData =
  {"value": "https://mycrmorg.dynamics.com/<Org>/main.aspx?appid=25ac68f2-9ab5-e811-8149-000d3a43f05f&pagetype=entitylist&etn=contact"}, 
}

Microsoft.CIFramework.addHandler("onpagenavigate", handlerFunction);
```

### Example 5: addHandler method for the `onsendkbarticle` event

The sample code demonstrates setting addHandler method for the `onsendkbarticle` event.

```JavaScript
function handlerfunction(eventData) {
var eventData =
  {"title": "KB Article about phones", 
  "link": "https://how.phones.work.com"}, 
}

Microsoft.CIFramework.addHandler("onsendkbarticle", handlerFunction);
```
-->
The sample code demonstrates setting addHandler method for the `onmodechanged` event.

```JavaScript
handlerFunction = function(eventData) {
console.log(eventData)
return Promise.resolve();
}

Microsoft.CIFramework.addHandler("onmodechanged", handlerFunction);
```

## Related topics

- [onclicktoact](../events/onclicktoact.md)

- [onmodechanged](../events/onmodechanged.md)

- [onpagenavigate](../events/onpagenavigate.md)

- [onsendkbarticle](../events/onsendkbarticle.md)

- [onsizechanged](../events/onsizechanged.md)
