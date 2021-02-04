---
title: "notifyEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
description: ""
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 02/04/2021
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
| Accept   |Accept    |User accepts the notification  |
| Accept   |AutoAccept|The notification template is set for auto-acceptance, and the auto-acceptance successful|
|Reject    |DeclinedByAgent|The user rejected the notification|
|Timeout   |DisplayTimeout|The user did not respond to the notification within the timeout period|
|Reject    |NotificationQueueLimitExceeded|There is a limit of 10? notifications that can be queued at one time. If a notification is raised when the queue is already full, the notification is rejected with this reason|
|Timeout   |NotificationQueueTimeLimitExceeded|The notification was queued up and the configured timeout value for the notification template has been reached|

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
|NotificationTemplateNotFoundError|The templateName specified could not be found|
|NotificationTemplateResolverNotFoundError|The notification has some slugs (or other items) that failed to resolve|
|RejectAfterClientError|An unknown exception occurred |

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
