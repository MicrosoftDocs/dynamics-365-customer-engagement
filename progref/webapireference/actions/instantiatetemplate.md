---
title: "InstantiateTemplate Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 04c8d886-e4ce-495e-b085-743e3a4cf69b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# InstantiateTemplate Action
[!INCLUDE[./descriptions/instantiatetemplate.md](./descriptions/instantiatetemplate.md)]

The InstantiateTemplate action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|TemplateId|Edm.Guid|false|true|ID of the template. |
|ObjectType|Edm.String|false|false|Type of object.|
|ObjectId|Edm.Guid|false|true|ID of the object. |

## Return Type
The InstantiateTemplate action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|Contains the response from InstantiateTemplate Action. |

## Entities
Use the InstantiateTemplate action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[template Entitytype](../entitytypes/template.md)|[!INCLUDE[../entitytypes/descriptions/template.md](../entitytypes/descriptions/template.md)]|

[!INCLUDE[./remarks/instantiatetemplate.md](./remarks/instantiatetemplate.md)]

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