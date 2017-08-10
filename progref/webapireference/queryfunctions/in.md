---
title: "In Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3ea57aee-abd0-4e65-8331-64337cadf9b0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# In Function
[!INCLUDE[./descriptions/in.md](./descriptions/in.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate. |
|PropertyValues|Collection(Edm.String)|false|false|The list of values to compare.| 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.In(PropertyName=@p1,PropertyValues=@p2)&@p1='name'&@p2=['value','value']`
 
[!INCLUDE[./remarks/in.md](./remarks/in.md)]

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