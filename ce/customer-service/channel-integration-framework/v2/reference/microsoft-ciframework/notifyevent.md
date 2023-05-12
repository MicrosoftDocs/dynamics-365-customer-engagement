---
title: "notifyEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Get reference information such as syntax and parameters for the notifyEvent (JavaScript API Reference) in Dynamics 365 Channel Integration Framework 2.0."
ms.date: 11/30/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# notifyEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

Displays a notification that can be used to inform the agent about incoming conversations.

## Syntax

`Microsoft.CIFramework.notifyEvent(input, correlationId, cancellationToken).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required     | Description     |
|-----------------|----------|--------------|-----------------|
| input           | JSON object   | Yes          | String      |
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry.  |
| cancellationToken | String    | No        | Is the unique string that's used by the [`cancelEvent`](cancelEvent.md) method to cancel notifications about incoming conversations. |
| successCallback | Function | No           | A function to call when the request is successful. On successful callback, the response object will have the information about whether the customer accepted or rejected the conversation. |
| errorCallback   | Function | No           | A function to call when the request fails.  |

## Callback function details

The following objects are passed into the `successCallback` and `errorCallback` functions.

### successCallback function

Sample JSON object:

```json
{
	"value": {"actionName" : "Accept",
     "responseReason" : "Accept"}
}
```

**Parameters**

| actionName   |  responseReason                    |     Description                            |
|--------------|------------------------------------|--------------------------------------------|
| Accept       | Accept                             | When user accepts the notification  |
| Accept       | AutoAccept                         | The notification is accepted by default via a notification template |
| Reject       | DeclinedByAgent                    | When user rejects the notification |
| Reject       | NotificationQueueLimitExceeded     | The notification is rejected if the limit exceeds ten notifications in the queue |
| Reject       | NotificationQueueTimeLimitExceeded | When a notification in the queue exceeds the configured timeout period |
| Timeout      | DisplayTimeout                     | When user doesn't respond to the notification within the timeout period |

### errorCallback function

Sample JSON object:

```json
{
	"message" : "<error details>",
	"msdyn_name" : "NotifyEvent"
}
```

**Parameters**

| message                          |  Description                            |
|-------------------------------   |-----------------------------------------|
| NotificationTemplateNotFoundError | When the specified template name is not found |
| RejectAfterClientError            | An unknown exception occurred (occurs when the Platform API call fails or some input parameter is missing) |

## Example

```javascript
var canceltoken = "cancellationtoken"+ Math.ceil(Math.random() * 100000 + 100000).toString();

 

var input = {
                templateName: "msdyn_chat_incoming_unauthenticated",
                // unique name of the configured template
                templateParameters: {
                },
// unique random token, to identify the notification during cancelEvent call
                cancellationToken: canceltoken
}
Microsoft.CIFramework.notifyEvent(input).then(
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
