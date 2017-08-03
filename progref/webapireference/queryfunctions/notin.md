---
title: "NotIn Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e9a1a0d5-a975-45b3-8129-d6d739070553
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# NotIn Function
[!INCLUDE[./descriptions/notin.md](./descriptions/notin.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate.|
|PropertyValues|Collection(Edm.String)|false|false|The values to compare.| 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.NotIn(PropertyName=@p1,PropertyValues=@p2)&@p1='name'&@p2=['value','value']`
 
[!INCLUDE[./remarks/notin.md](./remarks/notin.md)]

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