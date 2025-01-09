---
title: notifyNewActivity (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 
description: Learn about notifyNewActivity (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# notifyNewActivity (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

This method is used to indicate the number of new activities in a session that is currently not in focus. The indicator is automatically removed when the user switches to the session. 

![Unread Message.](../../../../media/unreadmessage.png "Unread Message")
<br>

> [!NOTE]
> This API is not compatible with [requestFocusSession](requestfocussession.md) API and should not be used together with it.

## Syntax

`Microsoft.CIFramework.notifyNewActivity(sessionId, count).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                                                                  |
|-----------------|----------|--------------|------------------------------------------------------------------------------------------------------------------|
| sessionId           | String   | Yes    | Unique identifier of the session.                            |
| count | Number | Yes     | A number indicating the count of new activities in the session since the last time the session was in focus.<br />The API call fails if negative numbers are passed in this parameter. |
| successCallback| Function | No | A function to call when the request is successful. |
| errorCallback | Function | No | A function to call when the request fails. |

## Return value

None

## Example

```javascript
Microsoft.CIFramework.notifyNewActivity(sessionId, count).then(
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

### Related information

[notifyKpiBreach API](notifyKPIBreach.md)


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
