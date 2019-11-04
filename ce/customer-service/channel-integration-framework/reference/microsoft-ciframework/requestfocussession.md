---
title: "requestFocusSession (JavaScript API Reference) for Dynamics 365 Channel Integration Framework | MicrosoftDocs"
description: ""
keywords: 
ms.date: 09/30/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - dyn365-a11y
  - dyn365-developer
ms.topic: reference
applies_to:
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: C5086080-D84D-4DC8-893E-38945F2B3C26
author: susikka
ms.author: susikka
manager: shujoshi
---

# requestFocusSession

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Sets the focus on the session whose Session Id is passed as a parameter, if the session belongs to the channel provider.

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