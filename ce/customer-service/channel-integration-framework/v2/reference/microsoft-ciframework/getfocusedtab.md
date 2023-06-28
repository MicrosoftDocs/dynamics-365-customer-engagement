---
title: "getFocusedTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the getFocusedTab method in JavaScript API Reference for Channel Integration Framework 2.0."
ms.date: 03/10/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# getFocusedTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

Returns the focused tab's identifier in a focused session, if the session belongs to the channel provider.

## Syntax

`Microsoft.CIFramework.getFocusedTab().then(successCallback,errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                 |
|-----------------|----------|--------------|-------------------------------------------------|
| successCallback | Function | No           | A function to call when the operation succeeds. |
| errorCallback   | Function | No           | A function to call when the operation fails.    |

## Return value

Promise with the value as String

## Example

```javascript
Microsoft.CIFramework.getFocusedTab().then(
function success(result) {
console.log(result);
// perform operations on tab id value
},
function (error) {
console.log(error.message);
// handle error conditions
}
);
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
