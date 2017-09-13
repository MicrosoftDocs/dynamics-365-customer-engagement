---
title: "msdyn_BookingResourceRequirement Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: b7708062-9e60-4352-ac19-7e1ac0d40971
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_BookingResourceRequirement Action
[!INCLUDE[./descriptions/msdyn_bookingresourcerequirement.md](./descriptions/msdyn_bookingresourcerequirement.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[msdyn_resourcerequirement Entitytype](../entitytypes/msdyn_resourcerequirement.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ResourceId|Edm.String|false|false||
|BookingStatusId|Edm.String|false|false||
|BookingMethod|Edm.Int32|false|true||
|BookingType|Edm.Int32|false|true||
|StartDateTime|Edm.DateTimeOffset|false|true||
|EndDateTime|Edm.DateTimeOffset|false|true||
|Timeframe|Edm.Int32|true|true||
|Hours|Edm.Int32|true|true||
|Percentage|Edm.Int32|true|true||

## Return Type
The msdyn_BookingResourceRequirement action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[msdyn_BookingResourceRequirementResponse ComplexType](../complextypes/msdyn_BookingResourceRequirementResponse.md)|false|msdyn_BookingResourceRequirementResponse|



[!INCLUDE[./remarks/msdyn_bookingresourcerequirement.md](./remarks/msdyn_bookingresourcerequirement.md)]

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