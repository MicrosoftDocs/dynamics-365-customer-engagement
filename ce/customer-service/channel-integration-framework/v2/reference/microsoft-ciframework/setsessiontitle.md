---
title: "setSessionTitle (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Learn about setSessionTitle (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 06/19/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# setSessionTitle (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

 

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

 >[!NOTE]  
 > Use this API only when the focused session is either the home/default session or it belongs to the provider.

Sets the session title, if the session belongs to the channel provider.

## Syntax

`Microsoft.CIFramework.setSessionTitle(input).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                   |
|-----------------|----------|--------------|---------------------------------------------------|
| sessionId       | String   | Yes          | Unique identifier of the session                  |
| title           | String   | Yes          | Session title                                     |
| successCallback | Function | No           | A function to call when the request is successful |
| errorCallback   | Function | No           | A function to call when the request fails         |

## Return Value

None

## Example

```javascript
var input = {
sessionId: "session-id-16",
customer: "John"
};
// setSessionTitle needs two params in input bag.
// 1. sessionId
// 2. slug name which we use in title field of session template record.. In sample, we have given value as "Call from {customer}"
// hence we pass "customer" in the input bag parameter.
Microsoft.CIFramework.setSessionTitle(input);
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
