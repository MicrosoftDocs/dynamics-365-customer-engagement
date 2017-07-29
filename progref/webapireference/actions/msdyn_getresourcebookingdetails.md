---
title: "msdyn_GetResourceBookingDetails Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 05ac82b7-7256-4f77-b0ae-ce3784003914
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_GetResourceBookingDetails Action
[!INCLUDE[./descriptions/msdyn_getresourcebookingdetails.md](./descriptions/msdyn_getresourcebookingdetails.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[bookableresource Entitytype](../entitytypes/bookableresource.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|StartDate|Edm.DateTimeOffset|false|true||
|EndDate|Edm.DateTimeOffset|false|true||
|Timescale|Edm.Int32|false|true||
|SchedulerSettings|Edm.String|true|false||

## Return Type
The msdyn_GetResourceBookingDetails action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[msdyn_GetResourceBookingDetailsResponse ComplexType](../complextypes/msdyn_GetResourceBookingDetailsResponse.md)|false|msdyn_GetResourceBookingDetailsResponse |



[!INCLUDE[./remarks/msdyn_getresourcebookingdetails.md](./remarks/msdyn_getresourcebookingdetails.md)]

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