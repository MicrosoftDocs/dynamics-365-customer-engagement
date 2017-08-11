---
title: "CalculateRollupField Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5bcc6551-47aa-45d3-8225-9453326206f3
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CalculateRollupField Function
[!INCLUDE[./descriptions/calculaterollupfield.md](./descriptions/calculaterollupfield.md)]

The CalculateRollupField function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|A reference to the entity containing the rollup attribute to calculate.|
|FieldName|Edm.String|false|false|The logical name of the attribute to calculate.  |

## Return Type
The CalculateRollupField function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|Contains the response from the CalculateRollupField function.|



[!INCLUDE[./remarks/calculaterollupfield.md](./remarks/calculaterollupfield.md)]

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