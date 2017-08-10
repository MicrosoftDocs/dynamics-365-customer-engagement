---
title: "EqualUserOrUserHierarchy Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 303ba667-3b8c-4c2c-81b2-d715ee522907
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# EqualUserOrUserHierarchy Function
[!INCLUDE[./descriptions/equaluseroruserhierarchy.md](./descriptions/equaluseroruserhierarchy.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate. | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.EqualUserOrUserHierarchy(PropertyName=@p1)&@p1='name'`
 
[!INCLUDE[./remarks/equaluseroruserhierarchy.md](./remarks/equaluseroruserhierarchy.md)]

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