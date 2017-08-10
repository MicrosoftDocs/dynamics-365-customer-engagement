---
title: "ContainValues Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9faa92c0-5ca5-41bf-8976-f4a3842b2087
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ContainValues Function
[!INCLUDE[./descriptions/containvalues.md](./descriptions/containvalues.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|TODO: Add description for ContainValues PropertyName parameter.|
|PropertyValues|Collection(Edm.String)|false|false|TODO: Add description for ContainValues PropertyValues parameter.| 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.ContainValues(PropertyName=@p1,PropertyValues=@p2)&@p1='name'&@p2=['value','value']`
 
[!INCLUDE[./remarks/containvalues.md](./remarks/containvalues.md)]

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