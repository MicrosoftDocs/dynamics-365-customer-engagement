---
title: "UnderOrEqual Query Function | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c4e4699e-6dc0-4387-9639-5285fd047fc3
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# UnderOrEqual Function
[!INCLUDE[./descriptions/underorequal.md](./descriptions/underorequal.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate.|
|PropertyValue|Edm.String|false|false|The value to compare.| 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.UnderOrEqual(PropertyName=@p1,PropertyValue=@p2)&@p1='name'&@p2='value'`
 
[!INCLUDE[./remarks/underorequal.md](./remarks/underorequal.md)]

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