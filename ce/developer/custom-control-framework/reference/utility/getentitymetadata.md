---
title: getEntityMetadata | Microsoft Docs
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
ms.assetid: 6a334af7-ca5b-449c-b90f-0901824654d2
---

# getEntityMetadata

[!INCLUDE [getentitymetadata-description](includes/getentitymetadata-description.md)]


## Syntax

`getEntityMetadata(entityName, attributes)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|entityName|`string`|yes|The logical name of the entity.|
|attributes|`string[]`|yes|The attributes to get metadata for.
## Return Value

Type: `Promise`


### Related topics

[Utility](../utility.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />
