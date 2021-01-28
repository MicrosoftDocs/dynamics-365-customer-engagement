---
title: "setSessionTitle (JavaScript API Reference) for Dynamics 365 Channel Integration Framework version 2.0 | Microsoft Docs"
description: ""
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 11/02/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# setSessionTitle

 

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

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
