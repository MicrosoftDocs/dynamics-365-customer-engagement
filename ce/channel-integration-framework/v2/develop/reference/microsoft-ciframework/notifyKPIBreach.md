---
title: notifyKpiBreach (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 
description: Learn about notifyKpiBreach (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# notifyKpiBreach (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

This method is used to indicate a KPI breach. When this API is invoked, an exclamation sign appears on the icon of the session whose unique identifier is passed, indicating that a KPI breach has occurred.

To reset the KPI breach indication, invoke this API with the value of `shouldReset` parameter set as `false`.

![Notify KPI Breach.](../../../../media/notifyKPIBreach.png "Notify KPI Breach")
<br>

## Syntax

`Microsoft.CIFramework.notifyKpiBreach(sessionId, shouldReset, details).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                                                                  |
|-----------------|----------|--------------|------------------------------------------------------------------------------------------------------------------|
| sessionId           | String   | Yes    | Unique identifier of the session.                            |
| shouldReset | Boolean | No     |  A flag to reset the KPI breach indication. The default value is `false`. |
| details   | String | No           | Details about the KPI breach.             |
| successCallback| Function | No | A function to call when the request is successful. |
| errorCallback | Function | No | A function to call when the request fails. |

## Return value

None

## Example

```javascript
Microsoft.CIFramework.notifyKpiBreach(sessionId, shouldReset, details).then(
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

[notifyNewActivity API](notifyNewActivity.md)


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
