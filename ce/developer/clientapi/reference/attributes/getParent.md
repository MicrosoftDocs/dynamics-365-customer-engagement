---
title: "getParent (Client API reference)| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 6d77db1b-18b4-410f-b91b-d2b65b369946
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getParent (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Returns the `formContext.data.entity` object that is the parent to all attributes. 

## Attribute types supported

All

## Syntax

`formContext.getAttribute(arg).getParent()`

## Return Value

**Type**: `formContext.data.entity` object. 

**Description**: The parent object.

