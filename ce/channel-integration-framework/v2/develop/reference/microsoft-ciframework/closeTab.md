---
title: closeTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 
description: Includes reference information such as description, syntax, and parameters for the closeTab method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# closeTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

 >[!NOTE]  
 > Use this API only when the focused session belongs to the provider or if it is the home or default session.

Closes the specified app tab in the current session.

## Syntax

`Microsoft.CIFramework.closeTab(tabId, correlationId).then(successCallback, errorCallback);`

## Parameters

|  Name            | Type     | Required     | Description |
|------------------|----------|--------------|-------------|
| tabId            | String   | Yes          | Name of the event whose handler needs to be invoked.     |
| correlationId    | GUID     | No           | Used to group all related API calls together for diagnostic telemetry.      |
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
