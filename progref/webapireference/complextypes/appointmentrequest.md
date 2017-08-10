---
title: "AppointmentRequest ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 02a2209d-be59-41ff-b8dc-dae72421c8ef
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AppointmentRequest ComplexType
[!INCLUDE[./descriptions/appointmentrequest.md](./descriptions/appointmentrequest.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ServiceId|Edm.Guid|true|true|The ID of the service to search for.| 
|AnchorOffset|Edm.Int32|true|true|The time offset in minutes, from midnight, when the first occurrence of the appointment can take place.| 
|UserTimeZoneCode|Edm.Int32|true|true|The time zone code of the user who is requesting the appointment.| 
|RecurrenceDuration|Edm.Int32|true|true|The time, in minutes, for which the appointment recurrence is valid. | 
|RecurrenceTimeZoneCode|Edm.Int32|true|true|A value to override the time zone that is specified by the UserTimeZoneCode property. | 
|AppointmentsToIgnore|Collection([AppointmentsToIgnore ComplexType](../complextypes/AppointmentsToIgnore.md))||true|The appointments to ignore in the search for possible appointments.| 
|RequiredResources|Collection([RequiredResource ComplexType](../complextypes/RequiredResource.md))||true|The resources that are needed for this appointment.| 
|SearchWindowStart|Edm.DateTimeOffset|true|true|The date and time to begin the search. | 
|SearchWindowEnd|Edm.DateTimeOffset|true|true| The date and time to end the search. | 
|SearchRecurrenceStart|Edm.DateTimeOffset|true|true|The date and time for the first possible instance of the appointment.| 
|SearchRecurrenceRule|Edm.String|true|false|The recurrence rule for appointment recurrence. | 
|Duration|Edm.Int32|true|true|The appointment duration, in minutes. | 
|Constraints|Collection([ConstraintRelation ComplexType](../complextypes/ConstraintRelation.md))||true|Any additional constraints. | 
|Objectives|Collection([ObjectiveRelation ComplexType](../complextypes/ObjectiveRelation.md))||true|The scheduling strategy that overrides the default constraints.| 
|Direction|[SearchDirection EnumType](../enumtypes/SearchDirection.md)|true|true|The direction of the search. | 
|NumberOfResults|Edm.Int32|true|true|The number of results to be returned from the search request. | 
|Sites|Collection(Edm.Guid)||true|The sites where the requested appointment can take place. | 

## Used by
The following use the AppointmentRequest ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[Search Function](../functions/search.md)|Parameter|[!INCLUDE[../functions/descriptions/search.md](../functions/descriptions/search.md)]|

[!INCLUDE[./remarks/appointmentrequest.md](./remarks/appointmentrequest.md)]

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