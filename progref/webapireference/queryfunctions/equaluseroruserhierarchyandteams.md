---
title: "EqualUserOrUserHierarchyAndTeams Query Function | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3234e028-f7b8-474f-b6b0-911815278d2c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# EqualUserOrUserHierarchyAndTeams Function
[!INCLUDE[./descriptions/equaluseroruserhierarchyandteams.md](./descriptions/equaluseroruserhierarchyandteams.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate. | 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.EqualUserOrUserHierarchyAndTeams(PropertyName=@p1)&@p1='name'`
 
[!INCLUDE[./remarks/equaluseroruserhierarchyandteams.md](./remarks/equaluseroruserhierarchyandteams.md)]

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