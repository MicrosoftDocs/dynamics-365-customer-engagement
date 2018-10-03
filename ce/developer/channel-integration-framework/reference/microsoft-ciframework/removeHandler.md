---
title: "removeHandler (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 10/01/2018
ms.service:
  - "dynamics-365-cross-app"
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: ECD8D03B-B16F-467F-9370-BB574F3E4F9D
author: kabala123
ms.author: kabala
manager: shujoshi
---

# remove (CIF JavaScript API Reference)

> [!Important]
> [!INCLUDE[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)] 

[!INCLUDE[removeHandler-description](includes/removeHandler-description.md)] 

## Syntax

`Microsoft.CIFramework.removeHandler(eventName, handlerFunction).then(successCallback, errorCallback);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| eventName | string | Yes | Name of the event for which the handler is set. <br>The supported events are as follows:<br><ul><li><b>onclicktoact:</b> The event is invoked when the outbound communication (ClickToAct) enabled filed is clicked.</li> <li><b>onmodechanged:</b> The event is invoked when the panel mode is manually toggled between Minimized (0) and Docked (1). </li><li><b>onsizechanged:</b>The event is invoked when the panel size is manually changed by dragging </li><li><b>onpagenavigate:</b>The event is triggered before a navigation event occurs on the main page </li><li><b>onsendkbarticle: </b> The event is invoked when the user clicks the send button on the KB control.</li></ul>  |
| handlerFunction | Function | Yes | The handler function is invoked when the any of the supported events trigger. |
| successCallback | Function | No | A function to call when the request is successful. |
| errorCallback | Function | No | A function to call when the request fails. |

## Return Value

On success, returns a promise object containing the attributes specified earlier in the description of the **successCallback** parameter.


## Examples

### Example 1: removeHandler method for the `onclicktoact` event

The sample code demonstrates setting removeHandler method for the `onclicktoact` event.

```JavaScript
function handlerfunction(eventData) {
var eventData = {
  "value": "123456789", 
  "name": "mobilephone",
  "format": "phone",
  "entityLogicalName": "contact"
}

Microsoft.CIFramework.removeHandler("onclicktoact", handlerFunction).then (
  function success (result){
  console.log(success);
          //the event is invoked
        },
        function (error) {
          console.log(error);
          //handle error conditions
        }
    );
  }
```

### Example 2: removeHandler method for the `onmodechanged` event

The sample code demonstrates setting removeHandler method for the `onmodechanged` event.

```JavaScript
function handlerfunction(eventData) {
var eventData = {
  {"value": "0"}, 
}

Microsoft.CIFramework.removeHandler("onmodechanged", handlerFunction).then (
  function success (result){
  console.log(success);
          //the event is invoked
        },
        function (error) {
          console.log(error);
          //handle error conditions
        }
    );
  }
```

### Example 3: removeHandler method for the `onsizechanged` event

The sample code demonstrates setting removeHandler method for the `onsizechanged` event.

```JavaScript
function handlerfunction(eventData) {
var eventData = {
  {"value": "30"}, 
}

Microsoft.CIFramework.removeHandler("onsizechanged", handlerFunction).then (
  function success (result){
  console.log(success);
          //the event is invoked
        },
        function (error) {
          console.log(error);
          //handle error conditions
        }
    );
  }
```

### Example 4: removeHandler method for the `onpagenavigate` event

The sample code demonstrates setting removeHandler method for the `onpagenavigate` event.

```JavaScript
function handlerfunction(eventData) {
var eventData = {
  {"value": "https://mycrmorg.dynamics.com/<Org>/main.aspx?appid=25ac68f2-9ab5-e811-8149-000d3a43f05f&pagetype=entitylist&etn=contact"}, 
}

Microsoft.CIFramework.removeHandler("onpagenavigate", handlerFunction).then (
  function success (result){
  console.log(success);
          //the event is invoked
        },
        function (error) {
          console.log(error);
          //handle error conditions
        }
    );
  }
```

### Example 5: removeHandler method for the `onsendkbarticle` event

The sample code demonstrates setting removeHandler method for the `onsendkbarticle` event.

```JavaScript
function handlerfunction(eventData) {
var eventData = {
  {"title": "KB Article about phones", 
  "link": "https://how.phones.work.com", 
}

Microsoft.CIFramework.removeHandler("onsendkbarticle", handlerFunction).then (
  function success (result){
  console.log(success);
          //the event is invoked
        },
        function (error) {
          console.log(error);
          //handle error conditions
        }
    );
  }
```

## Related topics

- [onclicktoact](../events/onclicktoact.md)

- [onmodechanged](../events/onmodechanged.md)

- [onpagenavigate](../events/onpagenavigate.md)

- [onsendkbarticle](../events/onsendkbarticle.md)

- [onsizechanged](../events/onsizechanged.md)