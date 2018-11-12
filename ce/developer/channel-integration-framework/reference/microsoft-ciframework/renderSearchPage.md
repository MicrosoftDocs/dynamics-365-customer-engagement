---
title: "renderSearchPage (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | MicrosoftDocs"
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
ms.assetid: ECD8D03B-B16F-467F-9370-BB574F3E4F9D
author: susikka
ms.author: susikka
manager: shujoshi
---
# renderSearchPage (CIF JavaScript API Reference)

[!INCLUDE[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)] 

[!INCLUDE[renderSearchPage-description](includes/renderSearchPage-description.md)] 

## Syntax

`Microsoft.CIFramework.renderSearchPage(entityName, searchString).then(successCallback, errorCallback);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| entityName | String | Yes | Name of the entity that is to be queried.  |
| searchString | String | Yes | String to search among the attributes of the entity records. |
| successCallback | Function | No | A function to call when the request is successful. |
| errorCallback | Function | No | A function to call when the request fails. |

## Return Value

On success, returns a promise object containing the attributes specified earlier in the description of the **successCallback** parameter.
