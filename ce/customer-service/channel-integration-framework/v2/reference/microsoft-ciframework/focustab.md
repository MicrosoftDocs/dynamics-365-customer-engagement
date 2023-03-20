---
title: "focusTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the focusTab method in JavaScript API Reference for Channel Integration Framework 2.0."
ms.date: 11/02/2020
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# focusTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0


Sets the focus on a tab, if the focused session belongs to the channel provider and if the tab belongs to the session in focus.

## Syntax

`Microsoft.CIFramework.focusTab(tabId, correlationId).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                |
|-----------------|----------|--------------|------------------------------------------------|
| tabId           | String   | Yes          | Unique identifier of the tab                   |
| successCallback | Function | No           | A function to call when a record is retrieved. |
| errorCallback   | Function | No           | A function to call when the operation fails.   |

## Return Value

None

## Example

```javascript
Microsoft.CIFramework.focusTab(tabId, correlationId).then(
function(result) {
return Promise.resolve(result);
},
function(error) {
return Promise.reject(error)
});
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
