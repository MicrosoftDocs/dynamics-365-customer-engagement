---
title: "notifyKPIBreach (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
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

# notifyKPIBreach

[!include[cc-beta-prerelease-disclaimer](../../../../../includes/cc-beta-prerelease-disclaimer.md)]

This method is used to indicate a KPI breach. Using this API, a red circle appears on the display image of the contact when a KPI breach has occurred.

## Syntax

`Microsoft.CIFramework.notifyKPIBreach(sessionId, shouldReset, details).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                                                                                  |
|-----------------|----------|--------------|------------------------------------------------------------------------------------------------------------------|
| sessionId           | String   | Yes    | Unique identifier of the session.                            |
| shouldReset | Boolean | No     | Flag to reset KPI breach indication. The default value is `false`. |
| details   | String | No           | Details about the KPI breach.             |
| successCallback| Function | No | A function to call when the request is successful. |
| errorCallback | Function | No | A function to call when the request fails. |

## Return value

None

## Example

```javascript
Microsoft.CIFramework.notifyKPIBreach(sessionId, shouldReset, details).then(
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
## See also

[notifyNewActivity API](notifyNewActivity.md)