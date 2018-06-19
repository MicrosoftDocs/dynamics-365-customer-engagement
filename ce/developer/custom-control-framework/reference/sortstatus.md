---
title: SortStatus | Microsoft Docs
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
ms.assetid: 09f6d0a7-a95a-421e-a413-281d1d0d0e19
---

# Sort

<!-- IDataSetExposedColumnSortStatus  -->

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [sort-description](includes/sortstatus-description.md)]


## name

The name of the column

**Type**: `string`

## sortDirection

<!-- ColumnSortDirection  -->
The current sort direction for the column.

**Type**: `enum`

The `sortDirection` value is an enum with the following possible values

|Value|Member|
|--|--|
|-1|None|
|0|Ascending|
|1|Descending|

### Related topics

[PowerApps Control Framework API Reference](index.md)<br />
[PowerApps Control Framework Overview](../powerapps-control-framework-overview.md)
