---
title: "getFocusedSession (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
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

# getFocusedSession

 

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Returns the unique identifier of the session that is in focus, if it belongs to the channel provider else returns null. 

## Syntax

`Microsoft.CIFramework.getFocusedSession().then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                               |
|-----------------|----------|--------------|-------------------------------------------------------------------------------|
| successCallback | Function | No           | A function to call when the request for setting the panel state is successful |
| errorCallback   | Function | No           | A function to call when the request for setting the panel state fails         |

## Return Value

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
