---
title: "notifyNewActivity (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
description: ""
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 04/03/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# notifyNewActivity

This method is used to indicate the number of new activities in a session that is currently not in focus. The indicator is automatically removed when the user switches to the session. 

![Notify new activity](../../../media/notifyNewActivity.PNG "Notify new activity")
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

### See also

[notifyKpiBreach API](notifyKPIBreach.md)


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]