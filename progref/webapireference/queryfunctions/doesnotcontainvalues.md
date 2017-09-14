---
title: "DoesNotContainValues Query Function | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b7aac425-958e-43e1-9d5b-529c18f34dbd
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# DoesNotContainValues Function
[!INCLUDE[./descriptions/doesnotcontainvalues.md](./descriptions/doesnotcontainvalues.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|TODO: Add description for DoesNotContainValues PropertyName parameter.|
|PropertyValues|Collection(Edm.String)|false|false|TODO: Add description for DoesNotContainValues PropertyValues parameter.| 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.DoesNotContainValues(PropertyName=@p1,PropertyValues=@p2)&@p1='name'&@p2=['value','value']`
 
[!INCLUDE[./remarks/doesnotcontainvalues.md](./remarks/doesnotcontainvalues.md)]

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