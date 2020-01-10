---
title: "getEnvironment (JavaScript API Reference) for Channel Integration Framework (CIF) | Microsoft Docs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 10/12/2018
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
---

# getEnvironment (CIF JavaScript API Reference)

[!INCLUDE[getEnvironment](includes/getEnvironment-description.md)]

## Syntax

`Microsoft.CIFramework.getEnvironment().then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required | Description |
|-----------------|----------|----------|-------------|
| successCallback | Function | No       | A function to call when the request for environment details are successful |
| errorCallback   | Function | No       | A function to call when the request for the environment fails              |

## Return value

**Type:** String

**Description:** Returns a promise object containing string with the available details of the current Unified Interface page. The details include: * 'appid', 'pagetype', 'record-id' (if available), 'clientUrl', 'appUrl' 'orgLcid', 'orgUniqueName', 'userId', 'userLcid', and 'username'.
