---
title: "SendFax Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 69a12bd1-be03-407b-8263-0de2488cd4eb
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SendFax Action
[!INCLUDE[./descriptions/sendfax.md](./descriptions/sendfax.md)]

The SendFax action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|FaxId|Edm.Guid|false|true|The fax ID. |
|IssueSend|Edm.Boolean|false|true|Indicates whether to send the e-mail, or to just record it as sent. |



## Entities
Use the SendFax action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[email Entitytype](../entitytypes/email.md)|[!INCLUDE[../entitytypes/descriptions/email.md](../entitytypes/descriptions/email.md)]|
|[fax Entitytype](../entitytypes/fax.md)|[!INCLUDE[../entitytypes/descriptions/fax.md](../entitytypes/descriptions/fax.md)]|
|[template Entitytype](../entitytypes/template.md)|[!INCLUDE[../entitytypes/descriptions/template.md](../entitytypes/descriptions/template.md)]|

[!INCLUDE[./remarks/sendfax.md](./remarks/sendfax.md)]

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