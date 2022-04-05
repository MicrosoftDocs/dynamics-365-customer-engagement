---
title: "closeTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes reference information such as description, syntax, and parameter for the closeTab method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 04/07/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# closeTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

Closes the specified app tab in the current session.

## Syntax

`Microsoft.CIFramework.closeTab(tabId, correlationId).then(successCallback, errorCallback);`

## Parameters

|  Name            | Type     | Required     | Description |
|------------------|----------|--------------|-------------|
| tabId            | String   | Yes          | JSON input      |
| correlationId    | GUID     | No           | JSON input      |
| successCallback  | Function | No           | A function to call when a record is retrieved. |
| errorCallback    | Function | No           | A function to call when the operation fails.  |

## Return value

None

## Example

```javascript
Microsoft.CIFramework.closeTab(tabId, correlationId).then(
function(result) {
return Promise.resolve(result);
},
function(error) {
return Promise.reject(error)
});
```

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
