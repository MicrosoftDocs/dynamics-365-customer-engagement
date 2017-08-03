---
title: "SendEmail Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: eb5e5e5e-2a17-4c71-a1b5-bd1dfb7e478a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SendEmail Action
[!INCLUDE[./descriptions/sendemail.md](./descriptions/sendemail.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[email Entitytype](../entitytypes/email.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|IssueSend|Edm.Boolean|false|true|Indicates whether the email is to be sent or marked as sent. |
|TrackingToken|Edm.String|true|false|The token to track the email. |

## Return Type
The SendEmail action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[SendEmailResponse ComplexType](../complextypes/SendEmailResponse.md)|false|Contains the response from the SendEmail Action.|

## Entities
Use the SendEmail action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[fax Entitytype](../entitytypes/fax.md)|[!INCLUDE[../entitytypes/descriptions/fax.md](../entitytypes/descriptions/fax.md)]|
|[template Entitytype](../entitytypes/template.md)|[!INCLUDE[../entitytypes/descriptions/template.md](../entitytypes/descriptions/template.md)]|

[!INCLUDE[./remarks/sendemail.md](./remarks/sendemail.md)]

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