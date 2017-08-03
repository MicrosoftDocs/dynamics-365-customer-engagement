---
title: "msdyn_GetSummaryBookings Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 9cce94e2-388d-444e-b6ae-8c4698eb8fb9
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_GetSummaryBookings Action
[!INCLUDE[./descriptions/msdyn_getsummarybookings.md](./descriptions/msdyn_getsummarybookings.md)]

The msdyn_GetSummaryBookings action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ResourceIds|Edm.String|false|false||
|StartDate|Edm.DateTimeOffset|false|true||
|EndDate|Edm.DateTimeOffset|false|true||
|TimeZoneCode|Edm.Int32|true|true||
|Timescale|Edm.Int32|false|true||

## Return Type
The msdyn_GetSummaryBookings action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[msdyn_GetSummaryBookingsResponse ComplexType](../complextypes/msdyn_GetSummaryBookingsResponse.md)|false|msdyn_GetSummaryBookingsResponse|



[!INCLUDE[./remarks/msdyn_getsummarybookings.md](./remarks/msdyn_getsummarybookings.md)]

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