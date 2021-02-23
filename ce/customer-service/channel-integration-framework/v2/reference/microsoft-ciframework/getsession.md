---
title: "getSession (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
description: ""
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 01/23/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# getSession

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Returns an object containing the unique identifier of the session, unique identifier of the conversation, context and the value of isFocused parameter, in case the session belongs to the channel provider.

## Syntax

`Microsoft.CIFramework.getSession(sessionId).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                 |
|-----------------|----------|--------------|-----------------------------------------------------------------|
| sessionId       | String   | Yes          | Id of the current session                                       |
| successCallback | Function | No           | Call when the request for the current width value is successful |
| errorCallback   | Function | No           | Call when the request for the current width value fails         |

## Return Value

Object containing session Id, conversation Id, context and isFocused parameter

## Example

```javascript
Microsoft.CIFramework.getSession("session-id-1").then(
    function success(result) {
        console.log(result);
        // perform operations on session info
    },
    function (error) {
        console.log(error.message);
        // handle error conditions
    }
);
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]