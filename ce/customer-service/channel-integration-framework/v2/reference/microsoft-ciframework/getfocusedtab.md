---
title: "getFocusedTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
description: ""
ms.date: 12/31/2019
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# getFocusedTab 

 

Returns the focused tab's tabId in focused session, if the session belongs to the provider.

## Syntax

`Microsoft.CIFramework.getFocusedTab().then(successCallback,errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                 |
|-----------------|----------|--------------|-------------------------------------------------|
| successCallback | Function | No           | A function to call when the operation succeeds. |
| errorCallback   | Function | No           | A function to call when the operation fails.    |

## Returns

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
