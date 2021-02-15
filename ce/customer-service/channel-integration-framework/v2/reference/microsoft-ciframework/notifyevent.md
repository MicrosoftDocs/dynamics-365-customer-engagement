---
title: "notifyEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
description: "Learn about notifyEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 02/10/2021
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# notifyEvent

 

Displays a notification that can be used to inform agent about an incoming conversation.

## Syntax

`Microsoft.CIFramework.notifyEvent(input, correlationId).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                                                                  |
|-----------------|----------|--------------|------------------------------------------------------------------------------------------------------------------|
| input           | String   | Yes          | JSON input                                                                                                       |
| successCallback | Function | No           | On success callback, response object will have the information about whether customer selected Accept or Reject. |
| errorCallback   | Function | No           | A function to call when the operation fails.                                                                     |

## Callback functions details

The following objects are passed into successCallback and errorCallback functions.

### successCallback function

Sample JSON object:

```json
{
	"value": {"actionName" : "Accept",

     "responseReason" : "Accept"}
}
```

**Parameters**

| **actionName**    |  **responseResponse value**         |     **Description**        |
|--------------|------------------------------------|--------------------------------------------|
| Accept   |Accept    |When user accepts the notification  |
| Accept   |AutoAccept |The notification is accepted by default via a notification template |
|Reject    |DeclinedByAgent |When user rejects the notification |
|Reject    |NotificationQueueLimitExceeded|The notification is rejected if the limit exceeds ten notifications in the queue |
|Reject   |NotificationQueueTimeLimitExceeded |When a notification in the queue exceeds the configured timeout period |
|Timeout   |DisplayTimeout |When user doesn't respond to the notification within the timeout period |

### errorCallback function

Sample JSON object:

```json
{
	"message" : "<error details>",

	"msdyn_name" : "NotifyEvent"
}
```

**Parameters**

| **message**    |  **Description**         |
|-------------------------------|-----------------------------------------|
|NotificationTemplateNotFoundError |When the specified template name is not found |
|RejectAfterClientError |An unknown exception occurred (occurs when the Platform API call fails or some input parameter is missing) |

## Example

```javascript
var input = {
	templateName: "msdyn_chat_incoming_unauthenticated",
	// unique name of the configured template
	templateParameters: {
	}
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
