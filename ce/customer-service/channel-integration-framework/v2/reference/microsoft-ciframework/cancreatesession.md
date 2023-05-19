---
title: "canCreateSession (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the canCreateSession method in JavaScript API Reference for Channel Integration Framework 2.0."
ms.date: 12/31/2019
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# canCreateSession (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

 

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Allows you to check if a new session can be created.

## Syntax

`Microsoft.CIFramework.canCreateSession().then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                                      |
|-----------------|----------|--------------|--------------------------------------------------------------------------------------|
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry                |
| successCallback | Function | No           | A function to call when the request for the current state of the panel is successful |
| errorCallback   | Function | No           | A function to call when the request for the current state of the panel fails         |

## Return value

Promise with the value as Boolean.

## Example

```javascript
Microsoft.CIFramework.canCreateSession(correlationId).then(
    function(result) {
        return Promise.resolve(result);
    },
    function(error) {
        return Promise.reject(error);
    });
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
