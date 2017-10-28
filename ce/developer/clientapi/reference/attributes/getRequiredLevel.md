---
title: "getRequiredLevel (Client API reference)| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: c0b6ea26-2a11-4a49-8ecf-fe700e782bf3
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# getRequiredLevel (Client API reference)

Returns the number of digits allowed to the right of the decimal point. 

## Attribute types supported

All

## Syntax

`formContext.getAttribute(arg).getRequiredLevel()`

## Return Value

**Type**: String. 

**Description**: Returns one of the following values:
- none
- required
- recommended

### Related topic
[setRequiredLevel (Client API reference)](setRequiredLevel.md)
