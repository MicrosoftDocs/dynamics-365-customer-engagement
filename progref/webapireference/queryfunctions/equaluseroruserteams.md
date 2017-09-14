---
title: "EqualUserOrUserTeams Query Function | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 747aea8e-f9a9-4b5f-bad6-54f568ec4dc8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# EqualUserOrUserTeams Function
[!INCLUDE[./descriptions/equaluseroruserteams.md](./descriptions/equaluseroruserteams.md)]  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|PropertyName|Edm.String|false|false|The name of the property to evaluate.| 


## Syntax example
`?$filter=Microsoft.Dynamics.CRM.EqualUserOrUserTeams(PropertyName=@p1)&@p1='name'`
 
[!INCLUDE[./remarks/equaluseroruserteams.md](./remarks/equaluseroruserteams.md)]

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