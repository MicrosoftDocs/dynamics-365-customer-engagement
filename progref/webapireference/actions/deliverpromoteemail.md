---
title: "DeliverPromoteEmail Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: e317f518-03de-4119-bc9c-e4b5ec0a6194
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# DeliverPromoteEmail Action
[!INCLUDE[./descriptions/deliverpromoteemail.md](./descriptions/deliverpromoteemail.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[email Entitytype](../entitytypes/email.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|MessageId|Edm.String|false|false|The ID of the email message stored in the email header.  |
|Subject|Edm.String|true|false|The subject line for the email message.  |
|From|Edm.String|false|false|The from address for the email message. |
|To|Edm.String|false|false|The addresses of the recipients of the email message. |
|Cc|Edm.String|false|false|The addresses of the carbon copy (Cc) recipients for the email message. |
|Bcc|Edm.String|false|false|Addresses of the blind carbon copy (Bcc) recipients for the email message.  |
|ReceivedOn|Edm.DateTimeOffset|false|true|The time the message was received on. |
|SubmittedBy|Edm.String|false|false|The email address of the account that is creating the email activity instance. |
|Importance|Edm.String|false|false|The level of importance for the email message.  |
|Body|Edm.String|false|false|The message body for the email.|
|Attachments|Collection([attachment EntityType](../entitytypes/attachment.md))|false|true|Collection of activity mime attachment (email attachment) records to attach to the email message.  |
|ExtraProperties|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true|For internal use only. |

## Return Type
The DeliverPromoteEmail action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[email EntityType](../entitytypes/email.md)|false|Contains the response from the DeliverPromoteEmail Action. |



[!INCLUDE[./remarks/deliverpromoteemail.md](./remarks/deliverpromoteemail.md)]

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