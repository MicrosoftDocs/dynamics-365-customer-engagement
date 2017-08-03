---
title: "RetrieveFilteredForms Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7ce46556-cc95-4307-b22f-c7d65a77391e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveFilteredForms Function
[!INCLUDE[./descriptions/retrievefilteredforms.md](./descriptions/retrievefilteredforms.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[systemform Entitytype](../entitytypes/systemform.md)|collection|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|EntityLogicalName|Edm.String|false|false|The logical name for the entity |
|FormType|Edm.Int32|false|true|The type of form. |
|User|[systemuser EntityType](../entitytypes/systemuser.md)|false|true|The specified user. |

## Return Type
The RetrieveFilteredForms function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([systemform EntityType](../entitytypes/systemform.md))|false|Contains the response from the RetrieveFilteredForms Function.|



[!INCLUDE[./remarks/retrievefilteredforms.md](./remarks/retrievefilteredforms.md)]

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