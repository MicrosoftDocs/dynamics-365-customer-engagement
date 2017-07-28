---
title: "CloseIncident Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 315acd25-65f0-4018-b7a2-d404ac784de8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CloseIncident Action
[!INCLUDE[./descriptions/closeincident.md](./descriptions/closeincident.md)]

The CloseIncident action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|IncidentResolution|[incidentresolution EntityType](../entitytypes/incidentresolution.md)|false|true|Incident resolution (case resolution) that is associated with the incident (case) to be closed.|
|Status|Edm.Int32|false|true|Status of the incident. |



## Entities
Use the CloseIncident action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[incident Entitytype](../entitytypes/incident.md)|[!INCLUDE[../entitytypes/descriptions/incident.md](../entitytypes/descriptions/incident.md)]|
|[quote Entitytype](../entitytypes/quote.md)|[!INCLUDE[../entitytypes/descriptions/quote.md](../entitytypes/descriptions/quote.md)]|

[!INCLUDE[./remarks/closeincident.md](./remarks/closeincident.md)]

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