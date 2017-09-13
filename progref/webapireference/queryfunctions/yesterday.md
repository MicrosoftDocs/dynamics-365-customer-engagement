---
title: "Yesterday Query Function | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 58c8aa4a-c3db-47d6-a8cf-4e43d26370eb
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Yesterday Function
[!INCLUDE[./descriptions/yesterday.md](./descriptions/yesterday.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate. | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.Yesterday(PropertyName=@p1)&@p1='name'`
 
[!INCLUDE[./remarks/yesterday.md](./remarks/yesterday.md)]

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