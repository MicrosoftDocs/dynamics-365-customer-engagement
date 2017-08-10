---
title: "OlderThanXMonths Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2df68763-ab18-4736-a3b7-9edb9db6beb9
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# OlderThanXMonths Function
[!INCLUDE[./descriptions/olderthanxmonths.md](./descriptions/olderthanxmonths.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate.|
|PropertyValue|Edm.Int64|false|true|The value to compare.| 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.OlderThanXMonths(PropertyName=@p1,PropertyValue=@p2)&@p1='name'&@p2=42`
 
[!INCLUDE[./remarks/olderthanxmonths.md](./remarks/olderthanxmonths.md)]

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