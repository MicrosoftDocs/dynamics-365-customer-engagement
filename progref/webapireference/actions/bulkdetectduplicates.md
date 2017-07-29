---
title: "BulkDetectDuplicates Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 73e65b5f-f964-4b50-a759-b11ce05111b8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# BulkDetectDuplicates Action
[!INCLUDE[./descriptions/bulkdetectduplicates.md](./descriptions/bulkdetectduplicates.md)]

The BulkDetectDuplicates action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Query|[QueryBase ComplexType](../complextypes/QueryBase.md)|true|true|The query criteria for detecting multiple duplicate records|
|JobName|Edm.String|false|false|The name of the asynchronous system job that detects and logs multiple duplicate records. |
|SendEmailNotification|Edm.Boolean|false|true|Indicates whether an email notification is sent after the asynchronous system job that detects multiple duplicate records finishes running. |
|TemplateId|Edm.Guid|false|true|The ID of the template (email template) that is used for the email notification. |
|ToRecipients|Collection([activityparty EntityType](../entitytypes/activityparty.md))|false|true|An array of IDs for the system users (users) who are listed in the “To” box (recipients) of the email notification. |
|CCRecipients|Collection([activityparty EntityType](../entitytypes/activityparty.md))|false|true|An array of IDs for the system users (users) who are listed in the Cc box of the email notification. |
|RecurrencePattern|Edm.String|false|false|The recurrence pattern for the asynchronous system job that detects multiple duplicate records. |
|RecurrenceStartTime|Edm.DateTimeOffset|false|true|The start date and time of an asynchronous system job that detects and logs multiple duplicate records.  |

## Return Type
The BulkDetectDuplicates action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[BulkDetectDuplicatesResponse ComplexType](../complextypes/BulkDetectDuplicatesResponse.md)|false|Contains the response from the BulkDetectDuplicates Action|



[!INCLUDE[./remarks/bulkdetectduplicates.md](./remarks/bulkdetectduplicates.md)]

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