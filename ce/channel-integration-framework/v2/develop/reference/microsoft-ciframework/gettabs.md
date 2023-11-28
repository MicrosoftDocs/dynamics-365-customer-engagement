---
title: "getTabs (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the getTabs method in JavaScript API Reference for Channel Integration Framework 2.0."
ms.date: 11/02/2020
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# getTabs (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0


Returns an array of tab Ids associated with template name or template tags for tabs in the session in focus, if the session belongs to the channel provider.

## Syntax

`Microsoft.CIFramework.getTabs(tabtemplatename, tags, correlationId).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                       |
|-----------------|----------|--------------|-----------------------------------------------------------------------|
| Unique Name     | String   | No           | Unique Name of the application tab template                           |
| tags            | String   | No           | Tags associated with the application tab                              |
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry |
| successCallback | Function | No           | A function to call when the request is successful                     |
| errorCallback   | Function | No           | A function to call when the request fails                             |

## Return value

Promise with the value as Array of strings

## Example

```javascript
Microsoft.CIFramework.getTabs("tabtemplatename", correlationId).then(
function(result) {
return Promise.resolve(result);
},
function(error) {
return Promise.reject(error)
});
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
