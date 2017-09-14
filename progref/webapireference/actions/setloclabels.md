---
title: "SetLocLabels Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 5599ed8b-06be-464b-a386-42df3adc8f89
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SetLocLabels Action
[!INCLUDE[./descriptions/setloclabels.md](./descriptions/setloclabels.md)]

The SetLocLabels action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|EntityMoniker|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The entity. |
|AttributeName|Edm.String|false|false|The attribute name. |
|Labels|Collection([LocalizedLabel ComplexType](../complextypes/LocalizedLabel.md))||true|The labels to set.|





[!INCLUDE[./remarks/setloclabels.md](./remarks/setloclabels.md)]

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