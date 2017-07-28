---
title: "UpdateOptionValue Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: c8bbcc8b-378e-44dc-b194-d363f5efec43
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# UpdateOptionValue Action
[!INCLUDE[./descriptions/updateoptionvalue.md](./descriptions/updateoptionvalue.md)]

The UpdateOptionValue action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OptionSetName|Edm.String|true|false|The name of the global option set.  |
|AttributeLogicalName|Edm.String|true|false|The name of the attribute when updating a local option set in a picklist attribute. |
|EntityLogicalName|Edm.String|true|false| The logical name of the entity when updating the local option set in a picklist attribute.|
|Value|Edm.Int32|false|true|The value for the option. |
|Label|[Label ComplexType](../complextypes/Label.md)|true|true| The label for the option.  |
|Description|[Label ComplexType](../complextypes/Label.md)|true|true|Description for the option.  |
|MergeLabels|Edm.Boolean|false|true|Indicates whether to keep text defined for languages not included in the Label.  |
|ParentValues|Collection(Edm.Int32)||true|TODO: Add description for UpdateOptionValue ParentValues parameter.|
|SolutionUniqueName|Edm.String|true|false|The name of the unmanaged solution that this global option set should be associated with. |





[!INCLUDE[./remarks/updateoptionvalue.md](./remarks/updateoptionvalue.md)]

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