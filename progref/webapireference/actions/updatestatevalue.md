---
title: "UpdateStateValue Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 4359ccba-f373-41f5-a859-8d278c0b34c8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# UpdateStateValue Action
[!INCLUDE[./descriptions/updatestatevalue.md](./descriptions/updatestatevalue.md)]

The UpdateStateValue action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OptionSetName|Edm.String|true|false|For internal use only. |
|AttributeLogicalName|Edm.String|true|false|The logical name of the attribute.  |
|EntityLogicalName|Edm.String|true|false|The name of the entity that has this statecode attribute.  |
|Value|Edm.Int32|false|true|The statecode attribute options to update.  |
|Label|[Label ComplexType](../complextypes/Label.md)|true|true|The display label for this statecode option that is specified by the Value property.  |
|Description|[Label ComplexType](../complextypes/Label.md)|true|true|The description label for the statecode option that is specified in the Value property.  |
|MergeLabels|Edm.Boolean|false|true|Indicates whether to merge the current label with any existing labels that are already specified for this attribute.|
|DefaultStatusCode|Edm.Int32|true|true|The default value for the statuscode (status reason) attribute when this statecode value is set.  |





[!INCLUDE[./remarks/updatestatevalue.md](./remarks/updatestatevalue.md)]

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