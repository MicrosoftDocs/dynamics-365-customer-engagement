---
title: "getEntity (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 1672c213-d315-48fb-b49c-47cc19d23c28
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# getEntity (Client API reference)

[!INCLUDE[./includes/getEntity-description.md](./includes/getEntity-description.md)]

## Grid types supported

Editable and Read-only grids

## Syntax

```
var myRows = gridContext.getGrid().getRows();
var myRow = myRows.get(arg);
myRow.getData();
```

## Return Value

**Type**: [GridRowData](../gridrowdata.md)

## Remarks

To get the `gridContext`, see [Getting the grid context](../../grids.md#bkmk_gridcontext). 

