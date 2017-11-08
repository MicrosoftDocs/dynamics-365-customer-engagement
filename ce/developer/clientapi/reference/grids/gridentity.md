---
title: "GridEntity (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 6d7ea64c-c08f-4e26-bfc7-00d25ada8205
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# GridEntity (Client API reference)

GridEntity is returned by the [GridRowData](gridrowdata.md).[getEntity](gridrowdata/getEntity.md) method or by directly accessing the [GridRowData](gridrowdata.md).**entity** object. Use the GridEntity methods to access data about the specific records in the rows.

GridEntity also supports the **attributes** collection that provides methods of working with a collection of attributes for an entity in the editable grid. Each attribute ([GridAttribute](gridattribute.md)) represents the data in the cell of an editable grid, and contains a reference to all the cells associated with the attribute. See [Collections (Client API reference)](../collections.md) for information on the methods available to access data in a collection.

## Methods

|Name|Description|
|--|--|

### Related topics

[GridAttribute](gridattribute.md)


