---
title: "EqualUserId Query Function | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2ee94601-7e1d-4761-8887-02730bca9860
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# EqualUserId Function
[!INCLUDE[./descriptions/equaluserid.md](./descriptions/equaluserid.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate.  | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.EqualUserId(PropertyName=@p1)&@p1='name'`
 
[!INCLUDE[./remarks/equaluserid.md](./remarks/equaluserid.md)]

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