---
title: "updateConversation (JavaScript API Reference) for Dynamics 365 Channel Integration Framework version 2.0 | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 01/23/2020
ms.topic: reference
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---
# updateConversation

[!include[cc-beta-prerelease-disclaimer](../../../../../includes/cc-beta-prerelease-disclaimer.md)]

## Syntax

`Microsoft.CIFramework.updateConversation(id, data, correlationId).then(successCallback, errorCallback)`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `id` | String(GUID) | Yes | Unique identifier of the conversation returned by `Microsoft.CIFramework.getSession` API.|
| `data` | Object | Yes | A JSON object containing key-value pairs, where key is the property of the entity and value is the value of the property you want to update in [msdyn_ocliveworkitem](https://docs.microsoft.com/en-us/dynamics365/omnichannel/developer/reference/entities/msdyn_ocliveworkitem) entity.|

## Example

```javascript

```