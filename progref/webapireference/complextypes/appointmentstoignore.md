---
title: "AppointmentsToIgnore ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7e1c2725-17a0-44bf-a849-6c6a7140ddf9
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AppointmentsToIgnore ComplexType
[!INCLUDE[./descriptions/appointmentstoignore.md](./descriptions/appointmentstoignore.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Appointments|Collection(Edm.Guid)||true|An array of IDs of appointments to ignore.| 
|ResourceId|Edm.Guid|true|true|The resource for which appointments are to be ignored. | 

## Used by
The following use the AppointmentsToIgnore ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[AppointmentRequest ComplexType](../complextypes/appointmentrequest.md)|Property|[!INCLUDE[../complextypes/descriptions/appointmentrequest.md](../complextypes/descriptions/appointmentrequest.md)]|

[!INCLUDE[./remarks/appointmentstoignore.md](./remarks/appointmentstoignore.md)]

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