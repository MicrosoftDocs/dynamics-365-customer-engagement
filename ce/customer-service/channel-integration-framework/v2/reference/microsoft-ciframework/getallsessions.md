---
title: "getAllSessions (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
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

# getAllSessions

 

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Returns the array of Session Ids for a given provider.

## Syntax

`Microsoft.CIFramework.getAllSessions().then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                   |
|-----------------|----------|--------------|-----------------------------------|
| successCallback | Function | No           | Call when the promise is resolved |
| errorCallback   | Function | No           | Call when the promise is rejected |

## Return Value

Promise with the value as array of strings.


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]