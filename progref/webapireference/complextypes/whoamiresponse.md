---
title: "WhoAmIResponse ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d68a4c97-47b6-45dc-8550-5a521bb7d33d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# WhoAmIResponse ComplexType
[!INCLUDE[./descriptions/whoamiresponse.md](./descriptions/whoamiresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|BusinessUnitId|Edm.Guid|true|true|ID of the business to which the logged on user belongs. | 
|UserId|Edm.Guid|true|true|ID of the user who is logged on.| 
|OrganizationId|Edm.Guid|true|true|ID of the organization that the user belongs to. | 

## Used by
The following use the WhoAmIResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[WhoAmI Function](../functions/whoami.md)|ReturnType|[!INCLUDE[../functions/descriptions/whoami.md](../functions/descriptions/whoami.md)]|

[!INCLUDE[./remarks/whoamiresponse.md](./remarks/whoamiresponse.md)]

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