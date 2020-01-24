---
title: "notifyNewActivity (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 01/20/2019
ms.topic: reference
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# notifyNewActivity

[!include[cc-beta-prerelease-disclaimer](../../../../../includes/cc-beta-prerelease-disclaimer.md)]

This method is used to update the number of new activities in a particular session.

![Notify new activity](../../../media/notifyNewActivity.PNG "Notify new activity")
<br>

## Syntax

`Microsoft.CIFramework.notifyNewActivity(sessionId, count).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                                                                  |
|-----------------|----------|--------------|------------------------------------------------------------------------------------------------------------------|
| sessionId           | String   | Yes    | Unique identifier of the session.                            |
| count | Number | Yes     | A number indicating the count of new activities in the session since the last time the session was in focus. |
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

[notifyKPIBreach API](notifyKPIBreach.md)