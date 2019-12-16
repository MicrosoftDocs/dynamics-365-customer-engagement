---
title: "getWidth (JavaScript API Reference) for Channel Integration Framework (CIF) | Microsoft Docs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 12/10/2018
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
---

# getWidth (CIF JavaScript API Reference)

[!INCLUDE[getWidth](includes/getWidth-description.md)]

## Syntax

`Microsoft.CIFramework.getWidth(value).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required | Description |
|-----------------|----------|----------|-------------|
| successCallback | Function | No       | A function to call when the request for the current width value is successful. |
| errorCallback   | Function | No       | A function to call when the request for the current width value fails. |

## Return value

**Type:** Number

**Description:** Returns a promise object the value (width of the panel in pixels).
