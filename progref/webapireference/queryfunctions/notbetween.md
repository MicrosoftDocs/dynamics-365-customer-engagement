---
title: "NotBetween Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3b639404-9ee2-4c29-82b1-18d7cd87280b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# NotBetween Function
[!INCLUDE[./descriptions/notbetween.md](./descriptions/notbetween.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate. |
|PropertyValues|Collection(Edm.String)|false|false|The values to compare. | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.NotBetween(PropertyName=@p1,PropertyValues=@p2)&@p1='name'&@p2=['value','value']`
 
[!INCLUDE[./remarks/notbetween.md](./remarks/notbetween.md)]

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