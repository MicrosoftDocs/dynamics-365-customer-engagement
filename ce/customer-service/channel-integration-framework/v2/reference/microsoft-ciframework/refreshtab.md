---
title: "refreshTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Learn about refreshTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 11/02/2020
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# refreshTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

 

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
