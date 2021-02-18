---
title: "refreshTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework version 2.0 | MicrosoftDocs"
description: ""
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 11/02/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# refreshTab

 

Refreshes the tab.

## Syntax

`Microsoft.CIFramework.refreshTab(tabId, correlationId).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                       |
|-----------------|----------|--------------|-----------------------------------------------------------------------|
| tabId           | String   | Yes          | Unique identifier of the tab                                          |
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry |
| successCallback | Function | No           | A function to call when a record is retrieved.                        |
| errorCallback   | Function | No           | A function to call when the operation fails.                          |

## Return Value

None

## Example

```javascript
Microsoft.CIFramework.refreshTab(tabId, correlationId).then(
    function(result) {
        // perform operations
    },
    function(error) {
        return Promise.reject(error)
});
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]