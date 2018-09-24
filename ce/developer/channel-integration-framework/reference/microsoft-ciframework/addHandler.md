---
title: "addHandler (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | MicrosoftDocs"
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
ms.assetid: 45EF1DC8-3A7C-4566-A132-BFBC05A07CC1
author: kabala123
ms.author: kabala
manager: shujoshi
---

# addHandler (CIF JavaScript API Reference)

[!INCLUDE[addHandler-description](includes/addHandler-description.md)] 

## Syntax

`Microsoft.CIFramework.addHandler(eventName, handlerFunction).then(successCallback, errorCallback);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| eventName | string | Yes | Name of the event for which the handler is set. <br>The supported events are as follows:<br><ul><li><b>onclicktoact:</b> The event is invoked when the outbound communication (ClickToAct) enabled field is clicked.</li> <li><b>onmodechanged:</b> The event is invoked when the panel mode is manually toggled between Minimized (0) and Docked (1). </li><li><b>onsizechanged:</b>The event is invoked when the panel size is manually changed by dragging </li><li><b>onpagenavigate:</b>The event is triggered before a navigation event occurs on the main page </li></ul>  |
| handlerFunction | Function | Yes | The handler function is invoked when the any of the supported events trigger. |
| successCallback | Function | No | A function to call when the request is successful. |
| errorCallback | Function | No | A function to call when the request fails. |

## Return Value

On success, returns a promise object containing the attributes specified earlier in the description of the **successCallback** parameter.
