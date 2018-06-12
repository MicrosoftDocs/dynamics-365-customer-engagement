---
title: lookupObjects | Microsoft Docs
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
ms.assetid: d213b401-cfc4-44df-b55c-f040fb6d7072
---

# lookupObjects

[!INCLUDE [lookupobjects-description](includes/lookupobjects-description.md)]


## Syntax

`lookupObjects(lookupOptions)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|lookupOptions|`UtilityApi.LookupOptions`|yes|Options for opening the lookup dialog. The LookupOptions has the following attributes:<br/>- **allowMultiSelect**: `boolean`. Whether the lookup allows more than one item to be selected.<br/>- **defaultEntityType**: `string`. The default entity type.<br/>- **defaultViewId**: `string`. The default view to use.<br/>- **entityTypes**: `string[]`. The entity types to display.<br/>- **viewIds**: `string[]`. The views to be available in the view picker. Only System views are supported (not user views).|

## Return Value

Type: `Promise`


### Related topics

[Utility](../utility.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />
