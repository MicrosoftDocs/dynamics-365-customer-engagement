---
title: "getMode (JavaScript API Reference) for Channel Integration Framework (CIF) | Microsoft Docs"
description: ""
keywords: ""
ms.date: 12/10/2018
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
ms.assetid: D215CEFC-286E-4AEF-9EDA-D6E1D7C7FD41
author: susikka
ms.author: susikka
manager: shujoshi
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
