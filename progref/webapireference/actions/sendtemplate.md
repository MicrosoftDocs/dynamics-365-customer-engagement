---
title: "SendTemplate Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 77fa6b67-fd7f-48d8-bf73-f02f18e0eca7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SendTemplate Action
[!INCLUDE[./descriptions/sendtemplate.md](./descriptions/sendtemplate.md)]

The SendTemplate action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|TemplateId|Edm.Guid|false|true|The ID of the template.|
|Sender|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The sender of the email. |
|Recipients|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|true|The list of recipients for the email. |
|Regarding|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The record the email is regarding. |
|DeliveryPriorityCode|Edm.Int32|true|true|The delivery priority code for the email. |



## Entities
Use the SendTemplate action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[email Entitytype](../entitytypes/email.md)|[!INCLUDE[../entitytypes/descriptions/email.md](../entitytypes/descriptions/email.md)]|
|[fax Entitytype](../entitytypes/fax.md)|[!INCLUDE[../entitytypes/descriptions/fax.md](../entitytypes/descriptions/fax.md)]|
|[template Entitytype](../entitytypes/template.md)|[!INCLUDE[../entitytypes/descriptions/template.md](../entitytypes/descriptions/template.md)]|

[!INCLUDE[./remarks/sendtemplate.md](./remarks/sendtemplate.md)]

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