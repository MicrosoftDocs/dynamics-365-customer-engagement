---
title: "notifyEvent (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
ms.assetid: 7B5FC441-8020-45CB-8318-1466D3B0FD9A
author: susikka
ms.author: susikka
manager: shujoshi
---

# notifyEvent

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

Displays a notification that can be used to inform agent about an incoming conversation.

## Syntax

`Microsoft.CIFramework.notifyEvent(input, correlationId).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                                                                  |
|-----------------|----------|--------------|------------------------------------------------------------------------------------------------------------------|
| input           | String   | Yes          | JSON input                                                                                                       |
| successCallback | Function | No           | On success callback, response object will have the information about whether customer selected Accept or Reject. |
| errorCallback   | Function | No           | A function to call when the operation fails.                                                                     |

## Return value

None

## Example

```javascript
var input = {
	templateName: "IncomingCallNotification",
	templateParameters: {
		number: "+1-123-4560-000"
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