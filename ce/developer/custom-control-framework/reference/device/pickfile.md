---
title: PickFile | Microsoft Docs
description: 
keywords:
ms.author: nabuthuk
manager: 
ms.date: 06/4/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: aae27c64-33c4-47f1-b833-4c04161c01e2
---


# pickFile

[!INCLUDE [cc_applies_to_update_9_0_0](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/pickfile-description.md](./includes/pickfile-description.md)]

## Syntax

`pickFile(options)`


## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|`options`|`object`|no|Placeholder description: pickFile.options|

## Return Value

Type: `Promise<File[]>`

See [Promise](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Promise) and [File](https://developer.mozilla.org/docs/Web/API/File)

## Remarks

The `options` parameter object has the following properties:

|Name|Type|Description|
|--|--|--|
|`accept`|`string`|Image file types to select. Valid values are "audio", "video", or "image"|
|`allowMultipleFiles`|`boolean`|Indicates whether to allow selecting multiple files|
|`maximumAllowedFileSize`|`number`|Maximum size of the files(s) to be selected|

### Related topics

[Device](../device.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />
