---
title: "notifyKpiBreach (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
description: ""
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 04/01/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# notifyKpiBreach

This method is used to indicate a KPI breach. When this API is invoked, an exclamation sign appears on the icon of the session whose unique identifier is passed, indicating that a KPI breach has occurred.

To reset the KPI breach indication, invoke this API with the value of `shouldReset` parameter set as `false`.

![Notify KPI Breach](../../../media/notifyKPIBreach.PNG "Notify KPI Breach")
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
### See also

[notifyNewActivity API](notifyNewActivity.md)
