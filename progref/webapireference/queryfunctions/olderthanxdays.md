---
title: "OlderThanXDays Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b8013e5d-56ea-459e-9c6f-fe853465949c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# OlderThanXDays Function
[!INCLUDE[./descriptions/olderthanxdays.md](./descriptions/olderthanxdays.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate. |
|PropertyValue|Edm.Int64|false|true|The value to compare. | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.OlderThanXDays(PropertyName=@p1,PropertyValue=@p2)&@p1='name'&@p2=42`
 
[!INCLUDE[./remarks/olderthanxdays.md](./remarks/olderthanxdays.md)]

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