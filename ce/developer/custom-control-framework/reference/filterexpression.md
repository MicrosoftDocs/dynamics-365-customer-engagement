---
title: FilterExpression | Microsoft Docs
description: 
keywords:
ms.author: nabuthuk
manager: jdaly
ms.date: 06/4/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 19ad54b8-e044-4f07-a18e-b00d26b75832
---

# FilterExpression

<!-- IExposedFilterExpression -->

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [filterexpression-description](includes/filterexpression-description.md)]

## conditions

The set of conditions associated with this filter.

**Type**: [ConditionExpression](conditionexpression.md)[]

## filterOperator

The operator used to combine conditions in this filter.

**Type**: `enum`

The `filterOperator` value is an enum with the following possible values

|Value|Member|
|--|--|
|0|And|
|1|Or|

## filters

Any child filters that should be evaluated after evaluating this filter.

**Type**: [FilterExpression](filterexpression.md)[]<br />



### Related topics

[PowerApps Control Framework API Reference](index.md)<br />
[PowerApps Control Framework Overview](../powerapps-control-framework-overview.md)
