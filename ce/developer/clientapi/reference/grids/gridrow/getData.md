---
title: "getData (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 4d025f92-db16-440c-9f82-e40d71e09862
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# getData (Client API reference)

[!INCLUDE[./includes/getData-description.md](./includes/getData-description.md)]

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

