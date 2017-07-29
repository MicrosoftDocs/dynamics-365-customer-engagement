---
title: "InFiscalYear Query Function | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4807d462-ebc9-4fc4-b549-81bd66272f06
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# InFiscalYear Function
[!INCLUDE[./descriptions/infiscalyear.md](./descriptions/infiscalyear.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate.|
|PropertyValue|Edm.Int64|false|true|The value of the fiscal year. | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.InFiscalYear(PropertyName=@p1,PropertyValue=@p2)&@p1='name'&@p2=42`
 
[!INCLUDE[./remarks/infiscalyear.md](./remarks/infiscalyear.md)]

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