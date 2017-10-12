---
title: "Between Query Function | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 891e9dfc-c322-4004-8ea5-00eaaf245cc0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Between Function
[!INCLUDE[./descriptions/between.md](./descriptions/between.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate.|
|PropertyValues|Collection(Edm.String)|false|false|The values to comapre | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.Between(PropertyName=@p1,PropertyValues=@p2)&@p1='name'&@p2=['value','value']`
 
[!INCLUDE[./remarks/between.md](./remarks/between.md)]

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