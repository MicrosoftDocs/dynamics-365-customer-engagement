---
title: "setTabTitle (JavaScript API Reference) for Channel Integration Framework (CIF) version 2.0 | Microsoft Docs"
description: ""
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 03/06/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# setTabTitle

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
var input = {
               title: "newTitle"
            }

Microsoft.CIFramework.setTabTitle("tab-id-2", input).then(
    function success(result) {
        console.log(result);
        // Perform operations upon record retrieval and opening
    },
    function(error) {
        console.log(error.message);
        // Handle error conditions
    }
);
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]