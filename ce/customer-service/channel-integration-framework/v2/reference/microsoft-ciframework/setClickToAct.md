---
title: "setClickToAct (JavaScript API Reference) for Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Learn about setClickToAct (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 11/17/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# setClickToAct (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[setClickToAct](includes/setClickToAct-description.md)]

## Syntax

`Microsoft.CIFramework.setClickToAct(value).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required | Description                                       |
|-----------------|----------|----------|---------------------------------------------------|
| value           | Boolean  | Yes      | Sets the value to enable or disable ClickToAct.   |
| successCallback | Function | No       | A function to call when the request is successful. |
| errorCallback   | Function | No       | A function to call when the request fails.         |

## Return value

A Promise object with a null value if the request is successful. The API returns an error if the request fails.



[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
