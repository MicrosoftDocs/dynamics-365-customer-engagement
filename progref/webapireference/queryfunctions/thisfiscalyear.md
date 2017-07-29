---
title: "ThisFiscalYear Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 455ca384-9ec9-434f-aa8d-cd6ecfd0c070
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ThisFiscalYear Function
[!INCLUDE[./descriptions/thisfiscalyear.md](./descriptions/thisfiscalyear.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate.| 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.ThisFiscalYear(PropertyName=@p1)&@p1='name'`
 
[!INCLUDE[./remarks/thisfiscalyear.md](./remarks/thisfiscalyear.md)]

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