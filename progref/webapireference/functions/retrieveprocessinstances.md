---
title: "RetrieveProcessInstances Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 60e84a61-a987-4eab-bd70-fe41b8038c29
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveProcessInstances Function
[!INCLUDE[./descriptions/retrieveprocessinstances.md](./descriptions/retrieveprocessinstances.md)]

The RetrieveProcessInstances function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|EntityId|Edm.Guid|false|true|Id of the entity record for which you want to retrieve all the business process flow instances across all business process flow definitions. |
|EntityLogicalName|Edm.String|false|false|Logical name of the entity for which you want to retrieve all the business process flow instances across all business process flow definitions.|

## Return Type
The RetrieveProcessInstances function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|Contains the response from the RetrieveProcessInstances Function.|



[!INCLUDE[./remarks/retrieveprocessinstances.md](./remarks/retrieveprocessinstances.md)]

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