---
title: "ValidateSavedQuery Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: c7c1082c-f7c0-4c0f-b13b-02f699833b19
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ValidateSavedQuery Action
[!INCLUDE[./descriptions/validatesavedquery.md](./descriptions/validatesavedquery.md)]

The ValidateSavedQuery action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|FetchXml|Edm.String|false|false| The FetchXML query string to be validated|
|QueryType|Edm.Int32|false|true|The type of the query. |



## Entities
Use the ValidateSavedQuery action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[appointment Entitytype](../entitytypes/appointment.md)|[!INCLUDE[../entitytypes/descriptions/appointment.md](../entitytypes/descriptions/appointment.md)]|
|[savedquery Entitytype](../entitytypes/savedquery.md)|[!INCLUDE[../entitytypes/descriptions/savedquery.md](../entitytypes/descriptions/savedquery.md)]|
|[serviceappointment Entitytype](../entitytypes/serviceappointment.md)|[!INCLUDE[../entitytypes/descriptions/serviceappointment.md](../entitytypes/descriptions/serviceappointment.md)]|

[!INCLUDE[./remarks/validatesavedquery.md](./remarks/validatesavedquery.md)]

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