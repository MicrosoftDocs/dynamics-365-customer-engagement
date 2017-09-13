---
title: "RetrieveExchangeAppointments Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 747fc686-5f8e-4e69-a706-97d697637a4f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveExchangeAppointments Function
[!INCLUDE[./descriptions/retrieveexchangeappointments.md](./descriptions/retrieveexchangeappointments.md)]

The RetrieveExchangeAppointments function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|StartDate|Edm.DateTimeOffset|false|true|The start date of the range in UTC.|
|EndDate|Edm.DateTimeOffset|false|true|The end date of the range in UTC.|

## Return Type
The RetrieveExchangeAppointments function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|A collection of Exchange appointments for the user within the date range specified.|



[!INCLUDE[./remarks/retrieveexchangeappointments.md](./remarks/retrieveexchangeappointments.md)]

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