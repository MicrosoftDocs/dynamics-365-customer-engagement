---
title: "getAllSessions (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the addHandler method in JavaScript API Reference for Channel Integration Framework 2.0."
ms.date: 07/11/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# getAllSessions (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Returns an array of session identifiers for a provider.

## Syntax

`Microsoft.CIFramework.getAllSessions().then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                   |
|-----------------|----------|--------------|-----------------------------------|
| successCallback | Function | No           | Call when the promise is resolved |
| errorCallback   | Function | No           | Call when the promise is rejected |

## Return value

Promise with the value as array of session IDs, which are created by the provider and still at active state.

## Example

```Javascript
Microsoft.CIFramework.getAllSessions().then(
    function (result) {
        // result will have array of session Ids, which are created by the provider and still at active state.
        console.log(result)
    },
    function (error) {
        // code handling for promise failure
        console.log(error)
    });
```

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
