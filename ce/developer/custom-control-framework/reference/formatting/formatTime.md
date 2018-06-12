---
title: formatTime | Microsoft Docs
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
ms.assetid: 148964b5-106e-4f2e-8038-9086d29dc54f

---

# formatTime

[!INCLUDE [formattime-description](includes/formattime-description.md)]

## Syntax
`formatTime(value: Date, behavior: FormattingApi.DateTimeFieldBehavior)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|value|`Date`|yes|The date to be formatted.|
|behaviour|`FormattingApi.DAteTimeFieldBehaviour`|yes|The behaviour of the datetime object to be formatted.|

## Return Value

Type: `string`


### Related topics

[Formatting](../formatting.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />
