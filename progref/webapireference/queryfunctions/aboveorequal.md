---
title: "AboveOrEqual Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 228deec3-c1c1-4c1e-b757-570c63c78099
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AboveOrEqual Function
[!INCLUDE[./descriptions/aboveorequal.md](./descriptions/aboveorequal.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate |
|PropertyValue|Edm.String|false|false|The value to compare. | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.AboveOrEqual(PropertyName=@p1,PropertyValue=@p2)&@p1='name'&@p2='value'`
 
[!INCLUDE[./remarks/aboveorequal.md](./remarks/aboveorequal.md)]

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