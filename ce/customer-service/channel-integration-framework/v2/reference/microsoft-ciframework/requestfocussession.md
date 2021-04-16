---
title: "requestFocusSession (JavaScript API Reference) for Dynamics 365 Channel Integration Framework version 2.0 | MicrosoftDocs"
description: "Know about requestFocusSession (JavaScript API Reference) for Dynamics 365 Channel Integration Framework version 2.0."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 03/03/2021
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-a11y
  - dyn365-developer
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
---

# requestFocusSession

 

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Shows a notification indicator on the session whose Session Id is passed as a parameter, if the session belongs to the channel provider. The notification indicator draws the user's attention to switch between sessions.

## Syntax

`Microsoft.CIFramework.requestFocusSession(sessionId, correlationId).(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                        |
|-----------------|----------|--------------|------------------------------------------------------------------------|
| sessionId       | String   | Yes          | Unique identifier of the current session                               |
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry. |
| successCallback | Function | No           | A function to call when the request is successful                      |
| errorCallback   | Function | No           | A function to call when the request fails                              |

## Return Value

None

## Example

```javascript
Microsoft.CIFramework.requestFocusSession("session-id-1", correlationId).then(
    function (result) {
        return Promise.resolve(result);
    },
    function (error) {
        return Promise.reject(error)
};
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]