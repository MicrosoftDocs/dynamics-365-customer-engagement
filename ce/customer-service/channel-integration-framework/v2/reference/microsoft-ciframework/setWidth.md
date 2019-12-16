---
title: "setWidth (JavaScript API Reference) for Dynamics 365 Channel Integration Framework | Microsoft Docs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 12/10/2018
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - dyn365-a11y
  - dyn365-developer
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
---

# setWidth (CIF JavaScript API Reference)

[!INCLUDE[setWidth](includes/setWidth-description.md)]

## Syntax

`Microsoft.CIFramework.setWidth(value).then(successCallback, errorCallback);`

## Parameters

| Name   | Type   | Required | Description |
|--------|--------|----------|-------------|
| value           | Number   | Yes      | The width of the panel in pixels. |
| successCallback | Function | No       | A function to call when the panel width is set successfully. |
| errorCallback   | Function | No       | A function to call when the panel width is setting operation fails. |

> [!NOTE]
> If the `value` parameter passed for setWidth is greater than half of screen width, the side panel will collapse. setWidth API should be called with lesser width value to be able to use the side panel.

## Return value

Returns a promise object with a value.
