---
title: "getMode (JavaScript API Reference) for Channel Integration Framework (CIF) | Microsoft Docs"
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

# getMode (CIF JavaScript API Reference)

[!INCLUDE[getMode](includes/getMode-description.md)]

## Syntax

`Microsoft.CIFramework.getMode(value).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required | Description |
|-----------------|----------|----------|-------------|
| successCallback | Function | No       | A function to call when the request for the current state of the panel is successful. |
| errorCallback   | Function | No       | A function to call when the request for the current state of the panel fails.         |

## Return value

**Type:** String

**Description:** Returns Promise object with the value (current state of the panel). Returns 0 for minimized mode and 1 for docked mode.
