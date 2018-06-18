---
title: Control Element | Microsoft Docs
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
ms.assetid: 4dacd337-c9df-458e-86f3-bfb3ab543ea7
---

# control element

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [control-description](includes/control-description.md)]

## Attributes

|Name|Description|Type|Required|
|--|--|--|--|
|`constructor`|A method for initalizing the object|[!INCLUDE [alphanumerictype-description](includes/alphanumerictype-description.md)]|yes|
|`control-type`|Standard|[!INCLUDE [controltype-description](includes/controltype-description.md)]|no|
|`description-key`||`string`|no|
|`display-name-key`||`string`|yes|
|`namespace`|Defines the object prototype of the control|[!INCLUDE [alphanumerictype-description](includes/alphanumerictype-description.md)]|yes|
|`preview-image`|Image that will be used on the customization screens to show a preview of the controlo to the customizer|`string`|no|
|`version`|Defines the version of the control|`string`|yes|

## Parent Elements

|Element|Description|
|--|--|
|[manifest](manifest.md)|[!INCLUDE [manifest-description](includes/manifest-description.md)]|

## Child Elements

|Element|Description|Occurrences|
|--|--|--|
|[AvailableOn](availableon.md)|[!INCLUDE [availableon-description](includes/availableon-description.md)]|0 or 1|
|[child](child.md)|[!INCLUDE [child-description](includes/child-description.md)]|0 or 1|
|[data-set](data-set.md)|[!INCLUDE [data-set-description](includes/data-set-description.md)]|0 or more|
|[dependencies](dependencies.md)|[!INCLUDE [dependencies-description](includes/dependencies-description.md)]|0 or 1|
|[groups](groups.md)|[!INCLUDE [groups-description](includes/groups-description.md)]|0 or more|
|[modes](modes.md)|[!INCLUDE [modes-description](includes/modes-description.md)]|0 or 1|
|[property](property.md)|[!INCLUDE [property-description](includes/property-description.md)]|0 or more|
|[resources](resources.md)|[!INCLUDE [resources-description](includes/resources-description.md)]|1|
|[type-group](type-group.md)|[!INCLUDE [type-group-description](includes/type-group-description.md)]|0 or more|

### Related topics

[PowerApps Control Framework Manifest Schema Reference](index.md)<br />
[PowerApps Control Framework API Reference](../reference/index.md)<br />
[PowerApps Control Framework Overview](../powerapps-control-framework-overview.md)
