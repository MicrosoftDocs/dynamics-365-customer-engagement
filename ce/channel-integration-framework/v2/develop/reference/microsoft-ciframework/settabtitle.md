---
title: setTabTitle (JavaScript API Reference) for Channel Integration Framework 2.0 
description: Learn about setTabTitle (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# setTabTitle (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

Sets the title of the tab, if:
- The focused session belongs to the channel provider or if it is either the home or default session.
- The tab belongs to the session in focus.

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
