---
title: "SendEmailFromTemplate Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 3a389db2-1659-417e-9cc6-57e2875fa109
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SendEmailFromTemplate Action
[!INCLUDE[./descriptions/sendemailfromtemplate.md](./descriptions/sendemailfromtemplate.md)]

The SendEmailFromTemplate action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|TemplateId|Edm.Guid|false|true|ID of the email template to use. |
|Regarding|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The entity record with which the e-mail message is associated.|
|Target|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The recipient the email is sent to. |

## Return Type
The SendEmailFromTemplate action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[email EntityType](../entitytypes/email.md)|false|Contains the response from the SendEmailFromTemplate Action. |

## Entities
Use the SendEmailFromTemplate action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[email Entitytype](../entitytypes/email.md)|[!INCLUDE[../entitytypes/descriptions/email.md](../entitytypes/descriptions/email.md)]|

[!INCLUDE[./remarks/sendemailfromtemplate.md](./remarks/sendemailfromtemplate.md)]

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