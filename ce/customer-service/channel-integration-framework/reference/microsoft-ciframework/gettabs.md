---
title: "getTabs (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
ms.assetid: BC651867-D05D-4F4F-AD90-DBDF16FF4BC3
author: susikka
ms.author: susikka
manager: shujoshi
---

# getTabs

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

Returns an array of tab Ids associated with template name or template tags for tabs in the session in focus, if the session belongs to the channel provider.

## Syntax

`Microsoft.CIFramework.getTabs(name, tags, correlationId).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                       |
|-----------------|----------|--------------|-----------------------------------------------------------------------|
| Name            | String   | Yes          | Name of the application tab template                                  |
| tags            | String   | No           | Tags associated with the application tab                              |
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry |
| successCallback | Function | No           | A function to call when the request is successful                     |
| errorCallback   | Function | No           | A function to call when the request fails                             |

## Return Value

Promise with the value as Array of strings

## Example

```javascript
Microsoft.CIFramework.getTabs("tabtemplatename”, correlationId).then(
function(result) {
return Promise.resolve(result);
},
function(error) {
return Promise.reject(error)
});
```