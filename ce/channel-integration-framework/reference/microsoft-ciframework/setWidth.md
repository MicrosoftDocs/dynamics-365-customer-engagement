---
title: "setWidth (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | Microsoft Docs"
description: ""
keywords: ""
ms.date: 10/01/2018
ms.service:
  - "dynamics-365-cross-app"
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 3B05CB86-5C50-4EED-A33E-86A0B46A1D33
author: kabala123
ms.author: kabala
manager: shujoshi
---

# setWidth (CIF JavaScript API Reference)

[!INCLUDE[setWidth](includes/setWidth-description.md)]

## Syntax

`Microsoft.CIFramework.setWidth(value).then(successCallback, errorCallback);`

## Parameters

| Name   | Type   | Required | Description |
|--------|--------|----------|-------------|
| value           | Number   | Yes      | Width of the panel in pixel |
| successCallback | Function | No       | A function to call when the panel width is set successfully |
| errorCallback   | Function | No       | A function to call when the panel width is setting operation fails |

## Return value

Returns a promise object with a value.