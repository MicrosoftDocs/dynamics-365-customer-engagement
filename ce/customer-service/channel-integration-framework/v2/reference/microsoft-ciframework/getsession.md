---
title: "getSession (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 09/30/2019
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# getSession

[!include[cc-beta-prerelease-disclaimer](../../../../../includes/cc-beta-prerelease-disclaimer.md)]

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Returns an object containing the unique identifier of the session, context and the value of isFocused parameter, in case the session belongs to the channel provider.

## Syntax

`Microsoft.CIFramework.getSession(sessionId).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                 |
|-----------------|----------|--------------|-----------------------------------------------------------------|
| sessionId       | String   | Yes          | Id of the current session                                       |
| successCallback | Function | No           | Call when the request for the current width value is successful |
| errorCallback   | Function | No           | Call when the request for the current width value fails         |

## Return Value

Object containing session Id, context and isFocused parameter

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
