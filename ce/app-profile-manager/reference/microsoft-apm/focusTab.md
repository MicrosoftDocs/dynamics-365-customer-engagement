---
title: "focusTab (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the focusTab API for the multi-session apps such as Omnichannel for Customer Service and Customer Service workspace."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/12/2020
ms.service: "dynamics-365-customerservice"
ms.topic: reference
---

# focusTab

Sets the focus on a tab in the current session.

## Syntax

`Microsoft.Apm.focusTab(tabId).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                      |
|-----------------|----------|--------------|------------------------------------------------------|
| tabId           | String   | Yes          | Unique identifier of the tab that has to be focused. |
| successCallback | Function | No           | A function to call when a record is retrieved.       |
| errorCallback   | Function | No           | A function to call when the operation fails.         |


## Return Value

None

## Example

```JavaScript
Microsoft.Apm.focusTab("tab-id-8").then(
function(result) {
return Promise.resolve(result);
},
function(error) {
return Promise.reject(error)
};
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]