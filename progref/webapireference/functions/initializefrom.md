---
title: "InitializeFrom Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ee2a8b1b-0701-46fb-92b1-b044c51db618
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# InitializeFrom Function
[!INCLUDE[./descriptions/initializefrom.md](./descriptions/initializefrom.md)]

The InitializeFrom function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|EntityMoniker|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The record that is the source for initializing.|
|TargetEntityName|Edm.String|false|false|The logical name of the target entity.|
|TargetFieldType|[TargetFieldType EnumType](../enumtypes/TargetFieldType.md)|false|true|The attributes are to be initialized in the initialized instance.|

## Return Type
The InitializeFrom function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|Contains the response from the InitializeFrom function.|



[!INCLUDE[./remarks/initializefrom.md](./remarks/initializefrom.md)]

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