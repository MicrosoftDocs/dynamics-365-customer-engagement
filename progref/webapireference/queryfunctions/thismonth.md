---
title: "ThisMonth Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ef356522-5d2e-4a44-a361-7ed03b9be5ba
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ThisMonth Function
[!INCLUDE[./descriptions/thismonth.md](./descriptions/thismonth.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.ThisMonth(PropertyName=@p1)&@p1='name'`
 
[!INCLUDE[./remarks/thismonth.md](./remarks/thismonth.md)]

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