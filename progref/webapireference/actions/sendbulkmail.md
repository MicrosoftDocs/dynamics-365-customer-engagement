---
title: "SendBulkMail Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: fddbabec-929d-4513-a280-bb48c10310e0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SendBulkMail Action
[!INCLUDE[./descriptions/sendbulkmail.md](./descriptions/sendbulkmail.md)]

The SendBulkMail action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Sender|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The sender of the email messages.|
|TemplateId|Edm.Guid|false|true|The ID of the email template to use. |
|RegardingType|Edm.String|false|false|The type of the record with which the email messages are associated.|
|RegardingId|Edm.Guid|false|true|The ID of the record with which the email messages are associated.|
|Query|[QueryBase ComplexType](../complextypes/QueryBase.md)|true|true|The query to retrieve the recipients for the email messages.|





[!INCLUDE[./remarks/sendbulkmail.md](./remarks/sendbulkmail.md)]

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