---
title: "msdyn_RegisterCustomEntity Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: a65d1b32-e772-4f9a-aead-b2f6b00b1f8c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_RegisterCustomEntity Action
[!INCLUDE[./descriptions/msdyn_registercustomentity.md](./descriptions/msdyn_registercustomentity.md)]

The msdyn_RegisterCustomEntity action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|EntityIds|Edm.String|false|false|Comma separated entity record GUIDs.|
|EntityLogicalName|Edm.String|false|false|Name of the entity to register.|
|DeviceIds|Edm.String|true|false|[Optional] Comma separated, user friendly device IDs to use.|
|Names|Edm.String|true|false|[Optional] Comma separated names to give to the IoT devices if they need to be created.|





[!INCLUDE[./remarks/msdyn_registercustomentity.md](./remarks/msdyn_registercustomentity.md)]

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