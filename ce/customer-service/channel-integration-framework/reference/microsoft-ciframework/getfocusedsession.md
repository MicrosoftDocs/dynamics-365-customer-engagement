---
title: "getFocusedSession (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
ms.assetid: AF2B5888-33A5-4383-B075-54E66003A661
author: susikka
ms.author: susikka
manager: shujoshi
---

# getFocusedSession

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

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