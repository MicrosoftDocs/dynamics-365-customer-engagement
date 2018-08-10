---
title: Popup | Microsoft Docs
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
ms.assetid: b0af1803-ae3a-41c2-a8a5-b15970bd6f96
---


# Popup

<!-- IPopupProps  -->

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [popup-description](includes/popup-description.md)]



## closeOnOutsideClick

Indicates whether popup close on an outside mouse click.

**Type**: `boolean`


## content

Static DOM element to be inserted.

**Type**: [HTMLElement](https://developer.mozilla.org/docs/Web/API/HTMLElement)

## id

The id to be set to the anchor control if any.

**Type**: `string`


## name

The name of the Popup. Used like a reference to open Popups.

**Type**: `string`


## popupToOpen

The name of Popup which should be opened.

**Type**: `string`


### Remarks
Should be defined ONLY in a Root Popup. To open nested Popups, should be provided string like `rootName.nestedName.[allOtherNestedNames]`. To close Popups, should be provided empty string. This property will be automatically propagated to children.


## type
<!-- PopupType -->
The type of Popup

**Type**: `enum`

The `type` value is an enum with the following possible values

|Value|Member|
|--|--|
|1|Root|
|2|Nested|

### Remarks
Should be only one `Root` Popup for each set of Popups.

### Related topics

[PowerApps Control Framework API Reference](index.md)<br />
[PowerApps Control Framework Overview](../powerapps-control-framework-overview.md)
