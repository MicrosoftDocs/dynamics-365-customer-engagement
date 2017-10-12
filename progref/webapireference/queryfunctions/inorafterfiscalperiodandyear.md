---
title: "InOrAfterFiscalPeriodAndYear Query Function | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5f3965ff-0cd4-41eb-b97a-bfa9d5f789f6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# InOrAfterFiscalPeriodAndYear Function
[!INCLUDE[./descriptions/inorafterfiscalperiodandyear.md](./descriptions/inorafterfiscalperiodandyear.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate. |
|PropertyValue1|Edm.Int64|false|true|The value of the fiscal period. |
|PropertyValue2|Edm.Int64|false|true|The value of the fiscal year. | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.InOrAfterFiscalPeriodAndYear(PropertyName=@p1,PropertyValue1=@p2,PropertyValue2=@p3)&@p1='name'&@p2=42&@p3=42`
 
[!INCLUDE[./remarks/inorafterfiscalperiodandyear.md](./remarks/inorafterfiscalperiodandyear.md)]

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