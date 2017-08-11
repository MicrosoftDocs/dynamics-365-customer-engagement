---
title: "SetReportRelated Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 86b76269-e26f-404b-b23c-1edecee76ee8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SetReportRelated Action
[!INCLUDE[./descriptions/setreportrelated.md](./descriptions/setreportrelated.md)]

The SetReportRelated action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ReportId|Edm.Guid|false|true|The ID of the report. |
|Entities|Collection(Edm.Int32)|false|true|An array of entity type codes for the related entities |
|Categories|Collection(Edm.Int32)|false|true|An array of report category codes. |
|Visibility|Collection(Edm.Int32)|false|true|An array of report visibility codes. |



## Entities
Use the SetReportRelated action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[report Entitytype](../entitytypes/report.md)|[!INCLUDE[../entitytypes/descriptions/report.md](../entitytypes/descriptions/report.md)]|

[!INCLUDE[./remarks/setreportrelated.md](./remarks/setreportrelated.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />