---
title: "DeleteOptionValue Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 83f7dc1f-0352-4a30-b274-0b49597214bd
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# DeleteOptionValue Action
[!INCLUDE[./descriptions/deleteoptionvalue.md](./descriptions/deleteoptionvalue.md)]

The DeleteOptionValue action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OptionSetName|Edm.String|true|false|The name of the option set that contains the value.  |
|AttributeLogicalName|Edm.String|true|false|The logical name of the attribute from which to delete the option value.  |
|EntityLogicalName|Edm.String|true|false|The logical name of the entity. |
|Value|Edm.Int32|false|true| The value of the option to delete.|
|SolutionUniqueName|Edm.String|true|false|The solution name associated with this option value.  |





[!INCLUDE[./remarks/deleteoptionvalue.md](./remarks/deleteoptionvalue.md)]

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