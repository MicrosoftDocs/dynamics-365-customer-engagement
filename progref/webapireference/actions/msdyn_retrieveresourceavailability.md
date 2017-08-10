---
title: "msdyn_RetrieveResourceAvailability Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: ad15a081-3b92-4eb7-abba-c22a83a12db4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_RetrieveResourceAvailability Action
[!INCLUDE[./descriptions/msdyn_retrieveresourceavailability.md](./descriptions/msdyn_retrieveresourceavailability.md)]

The msdyn_RetrieveResourceAvailability action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|WorkOrder|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true||
|RealTimeMode|Edm.Boolean|false|true||
|Duration|Edm.Int32|false|true||
|IgnoreDuration|Edm.Boolean|false|true||
|IgnoreTravelTime|Edm.Boolean|false|true||
|AllowOverlapping|Edm.Boolean|false|true||
|Radius|Edm.Int32|false|true||
|StartTime|Edm.DateTimeOffset|false|true||
|EndTime|Edm.DateTimeOffset|false|true||
|TimeGroup|[msdyn_timegroup EntityType](../entitytypes/msdyn_timegroup.md)|true|true||
|Characteristics|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))||true||
|Territories|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))||true||
|ResourceTypes|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))||true||
|Resources|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))||true||
|RestrictedResources|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))||true||
|Latitude|Edm.Double|true|true||
|Longitude|Edm.Double|true|true||
|Categories|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))||true||
|OrganizationalUnits|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))||true||
|Teams|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))||true||
|BusinessUnits|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))||true||

## Return Type
The msdyn_RetrieveResourceAvailability action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false||



[!INCLUDE[./remarks/msdyn_retrieveresourceavailability.md](./remarks/msdyn_retrieveresourceavailability.md)]

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