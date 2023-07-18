---
title: "setSessionTitle (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Learn about setSessionTitle (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 07/18/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# setSessionTitle (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0



 >[!NOTE]
 > - This content applies to Dynamics 365 Channel Integration Framework version 2.0 only.
 > - Session management APIs allow you to integrate multisession experiences in Omnichannel for Customer Service app only.
 > - Use this API only when the focused session belongs to the provider or if it is either the home or default session.

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
