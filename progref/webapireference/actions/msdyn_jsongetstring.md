---
title: "msdyn_JsonGetString Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: cafdd8c4-d596-4446-af2d-fc671dc8372e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_JsonGetString Action
[!INCLUDE[./descriptions/msdyn_jsongetstring.md](./descriptions/msdyn_jsongetstring.md)]

The msdyn_JsonGetString action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Json|Edm.String|true|false|JSON object to examine.|
|PropertyPath|Edm.String|false|false|Property name or path of the value to read.|
|DefaultReturnValue|Edm.String|true|false|Default value to return if specified property not found.|

## Return Type
The msdyn_JsonGetString action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[msdyn_JsonGetStringResponse ComplexType](../complextypes/msdyn_JsonGetStringResponse.md)|false|NA: Not displayed in the generated document.|



[!INCLUDE[./remarks/msdyn_jsongetstring.md](./remarks/msdyn_jsongetstring.md)]

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