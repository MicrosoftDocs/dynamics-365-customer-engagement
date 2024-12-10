---
title: getFocusedSession (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0
description: Includes description, syntax, and parameter information for the getFocusedSession method in JavaScript API Reference for Channel Integration Framework 2.0.
ms.date: 05/23/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# getFocusedSession (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

 

[!include[applies-to-v2](../../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../../includes/session-api-omnichannel.md)]

Returns the unique identifier of the session that is in focus, if it belongs to the channel provider else returns null. The session ID is null if the connector attempts to retrieve a focused session created using a different connector.


## Syntax

`Microsoft.CIFramework.getFocusedSession().then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                               |
|-----------------|----------|--------------|-------------------------------------------------------------------------------|
| successCallback | Function | No           | A function to call when the request for setting the panel state is successful |
| errorCallback   | Function | No           | A function to call when the request for setting the panel state fails         |

## Return value

Promise with the value as String

## Example

```javascript
Microsoft.CIFramework.getFocusedSession().then(
function success(result) {
console.log(result);
// perform operations on session id value
},
function (error) {
console.log(error.message);
// handle error conditions
}
);
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
