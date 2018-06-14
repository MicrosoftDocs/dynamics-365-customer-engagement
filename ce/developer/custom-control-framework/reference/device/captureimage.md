---
title: CaptureImage | Microsoft Docs
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
ms.assetid: 1d9c0063-add2-4002-acab-1be07ca1f6b6
---

# captureImage

[!INCLUDE [cc_applies_to_update_9_0_0](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/captureimage-description.md](./includes/captureimage-description.md)]

## Syntax

`captureImage(options)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|`options`|`object`|no|Options for capturing image.|


## Return Value

Type: `Promise<FileObject>`

See [Promise](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Promise) and [File](https://developer.mozilla.org/docs/Web/API/File)

## Remarks

The `options` parameter object has the following properties:

|Name|Type|Description|
| ---|----|-----------|
|`allowEdit`|`boolean`|Indicates whether to edit the image before saving|
|`height`|`number`|Height of the image to capture|
|`preferFrontCamera`|`boolean`|Indicates whether to capture image using the front camera ofthe device|
|`quality`|`number`|Quality of the image file in percentage|
|`width`|`number`|Width of the image to capture|

### Related topics

[Device](../device.md)<br />
[PowerApps Control Framework API Reference](../index.md)<br />
[PowerApps Control Framework Overview](../../powerapps-control-framework-overview.md)<br />
