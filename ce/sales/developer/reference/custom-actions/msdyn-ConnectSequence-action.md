---
title: msdyn_ConnectSequence action for Sequences
description: Learn how to use the msdyn_ConnectSequence action to connect lead, opportunity, or account records to a sequence, review parameters, and send a request now.
ms.date: 07/07/2026 
ms.topic: reference
author: udaykirang
ms.author: udag
ms.reviewer: udag
---

# msdyn_ConnectSequence action for Sequences

Use the msdyn_ConnectSequence action to assign a lead, opportunity, or account record to a sequence quickly and consistently.

## Parameters

|Name |Description |
|-----|-----|
|`RegardingEntityId`|Unique identifier of the entity record that is to be connected to the sequence.|
|`RegardingEntityName`|Logical name of the entity|
|`SequenceId`|Unique identifier of the sequence|

## Example

```json
POST [Organization URI]/api/data/v9.1/msdyn_ConnectSequence

{
    "RegardingEntityId":"11bb11bb-cc22-dd33-ee44-55ff55ff55ff",
    "RegardingEntityName":"lead",
    "SequenceId":"aaaaaaaa-0000-1111-2222-bbbbbbbbbbbb"
}
```

## Related information

[Enable and configure the Sales accelerator](../../../enable-configure-sales-accelerator.md)
