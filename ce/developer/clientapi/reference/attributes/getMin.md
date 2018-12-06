---
title: "getMin (Client API reference)| MicrosoftDocs"
ms.date: 08/13/2018
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 9a04b52a-2bc7-4572-bd3e-8b9622602092
author: KumarVivek
ms.author: kvivek
manager: annbe
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getMin (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Returns a number indicating the minimum allowed value for an attribute. 

## Attribute types supported

Decimal, integer, double, money

## Syntax

`formContext.getAttribute(arg).getMin()`

## Return Value

**Type**: Number. 

**Description**: The minimum allowed value for the attribute.

