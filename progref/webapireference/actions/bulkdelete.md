---
title: "BulkDelete Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: bae1666e-bfbf-492d-8285-8616930acc85
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# BulkDelete Action
[!INCLUDE[./descriptions/bulkdelete.md](./descriptions/bulkdelete.md)]

The BulkDelete action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|QuerySet|Collection([QueryExpression ComplexType](../complextypes/QueryExpression.md))||true|An array of queries for a bulk delete job |
|JobName|Edm.String|false|false|The name of an asynchronous bulk delete job |
|SendEmailNotification|Edm.Boolean|false|true|Indicates whether an email notification is sent after the bulk delete job has finished running|
|ToRecipients|Collection([activityparty EntityType](../entitytypes/activityparty.md))|false|true|An array of IDs for the system users (users) who are listed in the To box of an email notification.|
|CCRecipients|Collection([activityparty EntityType](../entitytypes/activityparty.md))|false|true|An array of IDs for the system users (users) who are listed in the Cc box of the email notification.|
|RecurrencePattern|Edm.String|false|false|The recurrence pattern for the bulk delete job|
|StartDateTime|Edm.DateTimeOffset|false|true|The start date and time to run a bulk delete job|
|SourceImportId|Edm.Guid|true|true|The ID of the data import job|
|RunNow|Edm.Boolean|true|true|TODO: BulkDelete Action RunNow Parameter Description |

## Return Type
The BulkDelete action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[BulkDeleteResponse ComplexType](../complextypes/BulkDeleteResponse.md)|false|Contains the response from the BulkDelete Action.|



[!INCLUDE[./remarks/bulkdelete.md](./remarks/bulkdelete.md)]

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