---
title: "CheckPromoteEmail Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0b7b1355-2da3-47ac-976d-5e694a1b81b2
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CheckPromoteEmail Function
[!INCLUDE[./descriptions/checkpromoteemail.md](./descriptions/checkpromoteemail.md)]

The CheckPromoteEmail function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|MessageId|Edm.String|false|false|The message ID that is contained in the email header.  |
|Subject|Edm.String|true|false|The subject of the message.  |
|DirectionCode|Edm.Int32|true|true|The direction of a mail checked for promotion for uniqueness.|

## Return Type
The CheckPromoteEmail function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[CheckPromoteEmailResponse ComplexType](../complextypes/CheckPromoteEmailResponse.md)|false|Contains the response from CheckPromoteEmail function.|

## Entities
Use the CheckPromoteEmail function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[email Entitytype](../entitytypes/email.md)|[!INCLUDE[../entitytypes/descriptions/email.md](../entitytypes/descriptions/email.md)]|

[!INCLUDE[./remarks/checkpromoteemail.md](./remarks/checkpromoteemail.md)]

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