---
title: "InFiscalPeriodAndYear Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3d943fea-c89e-4cb9-993a-e0f7516c6aa5
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# InFiscalPeriodAndYear Function
[!INCLUDE[./descriptions/infiscalperiodandyear.md](./descriptions/infiscalperiodandyear.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate. |
|PropertyValue1|Edm.Int64|false|true|The value of the fiscal period. |
|PropertyValue2|Edm.Int64|false|true|The value of the fiscal year. | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.InFiscalPeriodAndYear(PropertyName=@p1,PropertyValue1=@p2,PropertyValue2=@p3)&@p1='name'&@p2=42&@p3=42`
 
[!INCLUDE[./remarks/infiscalperiodandyear.md](./remarks/infiscalperiodandyear.md)]

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