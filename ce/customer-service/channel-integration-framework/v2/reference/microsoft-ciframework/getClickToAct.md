---
title: "getClickToAct (JavaScript API Reference) for Channel Integration Framework (CIF) | Microsoft Docs"
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

# getClickToAct (CIF JavaScript API Reference)

[!INCLUDE[getClickToAct](includes/getClickToAct-description.md)]

## Syntax

`Microsoft.CIFramework.getClickToAct(value).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required | Description                                       |
|-----------------|----------|----------|---------------------------------------------------|
| successCallback | Function | No       | A function to call when the request is successful |
| errorCallback   | Function | No       | A function to call when the request fails         |

## Return value

**Type:** Boolean

**Description:** Returns Promise object with the value. True if the **ClickToAct** is enabled; false otherwise.
