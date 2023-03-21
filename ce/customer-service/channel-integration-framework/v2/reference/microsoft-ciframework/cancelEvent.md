---
title: "cancelEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Get reference information such as syntax and parameters for the cancelEvent (JavaScript API Reference) in Dynamics 365 Channel Integration Framework 2.0."
ms.date: 04/04/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# cancelEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

Cancels the notification about incoming conversations based on the cancellation token.

## Syntax

`Microsoft.CIFramework.cancelEvent(cancellationToken, correlationId).then(successCallback, errorCallback);`

## Parameters

| Name            | Type      | Required     | Description     |
|-----------------|---------- |--------------|-----------------|
| cancellationToken| String   | Yes          | Unique string that was provided in the [`notifyEvent`](notifyevent.md) method to display notifications about incoming conversations.      |
| correlationId    | GUID     | No           | Used to group all related API calls together for diagnostic telemetry.   |
| successCallback  | Function | No | A function to call when the request is successful. On successful callback, the response object will contain the cancellation token.|
| errorCallback    | Function | No           | A function to call when the request fails.  |

## Callback function details

The following objects are passed into the `successCallback` and `errorCallback` functions.

### successCallback function

Returns the cancellation token.

### errorCallback function

Sample JSON object:

```json
{
	"message" : "<error details>",
	"msdyn_name" : "CancelEvent"
}
```

**Parameters**

| message                    |  Description                            |
|--------------------------  |-----------------------------------------|
| RejectAfterClientError     | An unknown exception occurred (occurs when the Platform API call fails or some input parameter is missing) |

## Example

```javascript
// Trying to cancel a notification, use the same cancelToken passed during creation of notification in notifyEvent
Microsoft.CIFramework.cancelEvent(CancelToken).then(
                function success(result) {
                                console.log(result);
                                // Perform operations
                },
                function (error) {
                                console.log(error.message);
                                // Handle error conditions
                }
);
```

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
