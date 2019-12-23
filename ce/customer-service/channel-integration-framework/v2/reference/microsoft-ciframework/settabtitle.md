---
title: "setTabTitle (JavaScript API Reference) for Channel Integration Framework (CIF) version 2.0 | Microsoft Docs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 12/31/2019
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# setTabTitle

[!include[cc-beta-prerelease-disclaimer](../../../../../includes/cc-beta-prerelease-disclaimer.md)]

Sets the title of the tab, if the focused session belongs to the channel provider and if the tab belongs to the session in focus.

## Syntax

`Microsoft.CIFramework.setTabTitle(tabId, input).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                                                                                          |
|-----------------|----------|--------------|------------------------------------------------------------------------------------------------------------------------------------------|
| tabId           | String   | Yes          | Unique identifier of the tab                                                                                                             |
| input           | Json     | Yes          | JSON containing the title of the tab.<br />The input object is similar in structure and format to the input object passed to **createTab** and **createSession** methods.            |
| successCallback | Function | No           | A function to call when a record is retrieved. A Promise object with the retrieved properties and values will be passed to the function. |
| errorCallback   | Function | No           | A function to call when the operation fails.                                                                                             |

## Return Value

Promise with the value as String

## Example

```javascript
Microsoft.CIFramework.setTabTitle("tab-id-2", input).then(
function success(result) {
console.log(result);
// Perform operations upon record retrieval and opening
},
function (error) {
console.log(error.message);
// Handle error conditions
}
);
```
