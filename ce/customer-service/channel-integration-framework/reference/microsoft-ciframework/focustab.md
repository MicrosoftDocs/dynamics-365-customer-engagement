---
title: "focusTab (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
ms.assetid: CFD3A25B-77CB-4954-B8FC-F8B3A7BC29E7
author: susikka
ms.author: susikka
manager: shujoshi
---

# focusTab

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

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
};
```