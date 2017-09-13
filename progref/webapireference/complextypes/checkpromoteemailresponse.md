---
title: "CheckPromoteEmailResponse ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 022d84d1-8302-4e80-8fa0-94e1f4fd3c2a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CheckPromoteEmailResponse ComplexType
[!INCLUDE[./descriptions/checkpromoteemailresponse.md](./descriptions/checkpromoteemailresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ShouldPromote|Edm.Boolean|true|true|Whether the message should be promoted to Microsoft Dynamics 365. | 
|ReasonCode|Edm.Int32|true|true|The reason for the result in the ShouldDeliver property.| 

## Used by
The following use the CheckPromoteEmailResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[CheckPromoteEmail Function](../functions/checkpromoteemail.md)|ReturnType|[!INCLUDE[../functions/descriptions/checkpromoteemail.md](../functions/descriptions/checkpromoteemail.md)]|

[!INCLUDE[./remarks/checkpromoteemailresponse.md](./remarks/checkpromoteemailresponse.md)]

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