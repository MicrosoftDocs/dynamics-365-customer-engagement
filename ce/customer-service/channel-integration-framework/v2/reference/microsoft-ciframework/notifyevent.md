---
title: "notifyEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
description: ""
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 01/18/2021
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

| **Name**    |  **Response**                                                  |
|--------------|----------------------------------------------------------------|
|actionName    | Accept, Reject, or Timeout|
|responseReason | Accept, AutoAccept, Cancelled, DeclinedByAgent, DisplayTimeout, NotificationQueueLimitExceeded, NotificationQueueTimeLimitExceeded, NotificationTemplateNotFoundError, NotificationTemplateResolverNotFoundError, RejectAfterClientError, RejectAfterTimeoutNonPlatformTimer    |

### errorCallback function

Sample JSON object:

```json
{
	"message" : "<error details>",

	"msdyn_name" : "NotifyEvent"
}
```

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
