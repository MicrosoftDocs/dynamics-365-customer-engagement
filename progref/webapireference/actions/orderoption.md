---
title: "OrderOption Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 2c45b0b9-e98b-472f-a124-0e69b4f27e07
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# OrderOption Action
[!INCLUDE[./descriptions/orderoption.md](./descriptions/orderoption.md)]

The OrderOption action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OptionSetName|Edm.String|true|false|The name of the global option set you want to edit options for. |
|AttributeLogicalName|Edm.String|true|false| Logical name of the PicklistAttributeMetadata attribute. |
|EntityLogicalName|Edm.String|true|false|Logical name of the entity. |
|Values|Collection(Edm.Int32)|false|true|The array of option values in the wanted order.  |
|SolutionUniqueName|Edm.String|true|false|Unique name of the solution.|





[!INCLUDE[./remarks/orderoption.md](./remarks/orderoption.md)]

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