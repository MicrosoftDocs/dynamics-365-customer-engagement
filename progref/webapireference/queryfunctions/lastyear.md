---
title: "LastYear Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a9a76d1d-7380-4ec8-a709-7f9f859daa7d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# LastYear Function
[!INCLUDE[./descriptions/lastyear.md](./descriptions/lastyear.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate. | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.LastYear(PropertyName=@p1)&@p1='name'`
 
[!INCLUDE[./remarks/lastyear.md](./remarks/lastyear.md)]

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