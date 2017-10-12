---
title: "msdyn_BookingResource Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: c3f22e97-826b-4554-beda-af89e0cd5e8c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_BookingResource Action
[!INCLUDE[./descriptions/msdyn_bookingresource.md](./descriptions/msdyn_bookingresource.md)]

The msdyn_BookingResource action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|NewStartDateTime|Edm.DateTimeOffset|true|true||
|NewResourceId|Edm.String|true|false||
|ResourceId|Edm.String|false|false||
|RequirementId|Edm.String|true|false||
|Work|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true||
|BookingStatusId|Edm.String|false|false||
|BookingMethod|Edm.Int32|false|true||
|BookingType|Edm.Int32|false|true||
|Schedules|Edm.String|false|false||
|Timeframe|Edm.Int32|false|true||
|Hours|Edm.Decimal|true|true||
|Percentage|Edm.Decimal|true|true||
|DistributeMethod|Edm.Int32|true|true||
|DefaultBookingHeader|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true||
|DefaultBookingDetail|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true||
|ReloadStartDate|Edm.DateTimeOffset|true|true||
|ReloadEndDate|Edm.DateTimeOffset|true|true||
|ReloadDetailBookings|Edm.Boolean|true|true||
|TimeZoneCode|Edm.Int32|true|true|TODO: Add description for msdyn_BookingResource TimeZoneCode parameter.|
|SchedulerSettings|Edm.String|true|false||
|PreventPartialFulfillment|Edm.Boolean|true|true||

## Return Type
The msdyn_BookingResource action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[msdyn_BookingResourceResponse ComplexType](../complextypes/msdyn_BookingResourceResponse.md)|false|msdyn_BookingResourceResponse|



[!INCLUDE[./remarks/msdyn_bookingresource.md](./remarks/msdyn_bookingresource.md)]

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