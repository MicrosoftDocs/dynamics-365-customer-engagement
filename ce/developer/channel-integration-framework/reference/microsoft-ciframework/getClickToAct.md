---
title: "getClickToAct (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | Microsoft Docs"
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
ms.assetid: 0E6DEBBB-F946-4DF4-B453-FD7720E5D581
author: kabala123
ms.author: kabala
manager: shujoshi
---

# getClickToAct (CIF JavaScript API Reference)

> [!Important]
> [!INCLUDE[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)] 

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