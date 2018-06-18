---
title: DataSet Element | Microsoft Docs
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
ms.assetid: 9ffe8930-b290-4252-98d4-a1195b00205f
---

# data-set element

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [data-set-description](includes/data-set-description.md)]

## Attributes

|Name|Description|Type|Required|
|--|--|--|--|
|`description-key`|Placeholder description data-set.description-key|`string`|no|
|`display-name-key`|Placeholder description data-set.display-name-key|`string`|yes|
|`editable`|Placeholder description data-set.editable|`boolean`|no|
|`max-occurs`|Placeholder description data-set.max-occurs|`string`|no|
|`name`|Name of the grid|`string`|yes|

## Parent Elements

|Element|Description|
|--|--|
|[control](control.md)|[!INCLUDE [control-description](includes/control-description.md)]|
|[group](group.md)|[!INCLUDE [group-description](includes/group-description.md)]|

## Child Elements

|Element|Description|Occurrences|
|--|--|--|
|[doc](manifest.md)|[!INCLUDE [doc-description](includes/doc-description.md)]|0 or more|
|[property-set](property-set.md)|[!INCLUDE [property-set-description](includes/property-set-description.md)]|0 or more|

### Related topics

[PowerApps Control Framework Manifest Schema Reference](index.md)<br />
[PowerApps Control Framework API Reference](../reference/index.md)<br />
[PowerApps Control Framework Overview](../custom-control-framework-overview.md)
