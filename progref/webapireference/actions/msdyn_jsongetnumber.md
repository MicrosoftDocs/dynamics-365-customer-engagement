---
title: "msdyn_JsonGetNumber Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 4060ed9c-df26-4a5a-92d4-d6bdf824be98
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_JsonGetNumber Action
[!INCLUDE[./descriptions/msdyn_jsongetnumber.md](./descriptions/msdyn_jsongetnumber.md)]

The msdyn_JsonGetNumber action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Json|Edm.String|true|false|JSON object to examine.|
|PropertyPath|Edm.String|false|false|Property name or path of the value to read.|
|DefaultReturnValue|Edm.Decimal|true|true|Default value to return if specified property not found.|

## Return Type
The msdyn_JsonGetNumber action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[msdyn_JsonGetNumberResponse ComplexType](../complextypes/msdyn_JsonGetNumberResponse.md)|false|NA: Not displayed in the generated document.|



[!INCLUDE[./remarks/msdyn_jsongetnumber.md](./remarks/msdyn_jsongetnumber.md)]

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