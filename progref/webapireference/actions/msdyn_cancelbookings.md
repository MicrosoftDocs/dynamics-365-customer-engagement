---
title: "msdyn_CancelBookings Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 7ecf727b-0010-4b44-b9e5-e0175ea4aff6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_CancelBookings Action
[!INCLUDE[./descriptions/msdyn_cancelbookings.md](./descriptions/msdyn_cancelbookings.md)]

The msdyn_CancelBookings action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ReloadStartDate|Edm.DateTimeOffset|true|true||
|ReloadEndDate|Edm.DateTimeOffset|true|true||
|Timescale|Edm.Int32|false|true||
|BookingCancelContext|Edm.String|false|false||
|TimeZoneCode|Edm.Int32|true|true||
|SchedulerSettings|Edm.String|true|false||

## Return Type
The msdyn_CancelBookings action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[msdyn_CancelBookingsResponse ComplexType](../complextypes/msdyn_CancelBookingsResponse.md)|false|msdyn_CancelBookingsResponse|



[!INCLUDE[./remarks/msdyn_cancelbookings.md](./remarks/msdyn_cancelbookings.md)]

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