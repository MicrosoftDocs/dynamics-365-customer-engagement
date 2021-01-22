---
title: "canCreateSession (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
description: ""
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 12/31/2019
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# canCreateSession

 

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Allows you to check if a new session can be created.

### Syntax

`Microsoft.CIFramework.canCreateSession().then(successCallback, errorCallback);`

**Parameters**

| **Name**        | **Type** | **Required** | **Description**                                                                      |
|-----------------|----------|--------------|--------------------------------------------------------------------------------------|
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry                |
| successCallback | Function | No           | A function to call when the request for the current state of the panel is successful |
| errorCallback   | Function | No           | A function to call when the request for the current state of the panel fails         |

**Return Value**

Promise with the value as Boolean.

**Example**

```javascript
Microsoft.CIFramework.canCreateSession(correlationId).then(
    function(result) {
        return Promise.resolve(result);
    },
    function(error) {
        return Promise.reject(error);
    });
```
