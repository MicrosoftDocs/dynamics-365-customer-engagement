---
title: "getAllSessions (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
ms.assetid: 4BA28EBF-5731-40E0-B9C6-6D8C557E1E26
author: susikka
ms.author: susikka
manager: shujoshi
---

# getAllSessions

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Returns the array of Session Ids for a given provider.

## Syntax

`Microsoft.CIFramework.getAllSessions().then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                   |
|-----------------|----------|--------------|-----------------------------------|
| successCallback | Function | No           | Call when the promise is resolved |
| errorCallback   | Function | No           | Call when the promise is rejected |

## Return Value

Promise with the value as array of strings.

## Example

Microsoft.CIFramework.getAllSessions().then(
function success(result) {
console.log(result);
// perform operations session ids array
},
function (error) {
console.log(error.message);
// handle error conditions
}
);