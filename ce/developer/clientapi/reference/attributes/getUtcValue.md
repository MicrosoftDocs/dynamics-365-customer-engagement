---
title: "getUtcValue (Client API reference)| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: ebd1526e-d014-41a3-973d-75742b9cfbd3
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getUtcValue (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Returns a UTC-equivalent date and time value of the value stored in a **datetime** type of attribute. UTC stands for Coordinated Universal Time.

## Attribute types supported

datetime

## Syntax

`formContext.getAttribute(arg).getUtcValue()`

## Return Value

**Type**: datetime. 

**Description**: The UTC-equivalent date and time value of the value stored in an attribute.


### Related topic
[setUtcValue (Client API reference)](setUtcValue.md)

