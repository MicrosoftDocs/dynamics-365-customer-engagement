---
title: "setClickToAct (JavaScript API Reference) for Channel Integration Framework (CIF) | Microsoft Docs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 05/14/2019
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
---

# setClickToAct (CIF JavaScript API Reference)

[!INCLUDE[setClickToAct](includes/setClickToAct-description.md)]

## Syntax

`Microsoft.CIFramework.setClickToAct(value).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required | Description                                       |
|-----------------|----------|----------|---------------------------------------------------|
| Value           | Boolean  | Yes      | Sets the value to enable or disable ClickToAct.   |
| successCallback | Function | No       | A function to call when the request is successful |
| errorCallback   | Function | No       | A function to call when the request fails         |

## Return value

**Type:** Null
