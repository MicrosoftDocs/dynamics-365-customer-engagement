---
title: "msdyn_ConnectSequence Action | MicrosoftDocs"
description: "How to assigns a lead and opportunity entity record to a sequence."
ms.date: 05/11/2020

ms.custom: 
ms.topic: article
author: udaykirang
ms.author: udag
---

# msdyn_ConnectSequence Action

This action is used to assign a lead and opportunity entity record to a sequence.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System customizer <br>  More information: [Predefined security roles for Sales](../security-roles-for-sales.md)|


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
    "RegardingEntityId":"03468c60-6d5b-ea11-a811-000d3a54419d",
    "RegardingEntityName":"lead",
    "SequenceId":"BCEC0282-7A58-EA11-A811-000D3A54419D"
}
```

## See also

[Enable and configure the Sales accelerator](../enable-configure-sales-accelerator.md)
