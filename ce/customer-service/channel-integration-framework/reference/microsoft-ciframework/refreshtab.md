---
title: "refreshTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 09/30/2019
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# refreshTab

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

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
};
```
