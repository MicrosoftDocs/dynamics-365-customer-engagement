---
title: "Run duplicate detection (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Execute duplicate detection for a specific record, entity type, or during create or update operations."
ms.custom: 
ms.date: 12/15/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 08699dd9-623a-4fee-8b2e-fba850cc2a58
caps.latest.revision: 39
author: phecke
ms.author: pehecke
manager: amyla
search.audienceType: 
  - developer

---
# Run duplicate detection

There are several ways to perform duplicate detection after you enable it and publish the duplicate detection rules.  

<a name="BKMK_RetDupwebapi"></a>

## Retrieve and detect duplicates for a specified record

Detect and retrieve duplicates:

- Before you create an entity
- For an existing entity
- For other entities that correspond to duplicate rules across entities. For example, any Lead entity which matches a contact entity.

### Options:

- Web API: <xref href="Microsoft.Dynamics.CRM.RetrieveDuplicates?text=RetrieveDuplicates Function" />
- Organization Service: <xref:Microsoft.Crm.Sdk.Messages.RetrieveDuplicatesRequest>


### Example: Detect duplicates for a specified record using Web API

The following example shows how to detect duplicates of a specified record using `RetrieveDuplicates` function.

**Request**
```http
GET [Organization URI]/api/data/v9.1/RetrieveDuplicates(BusinessEntity=@p1,MatchingEntityName=@p2,PagingInfo=@p3)?@p1={'@odata.type':'Microsoft.Dynamics.CRM.account','accountid':'0d1156d2-1598-e711-80e8-00155db64062'}&@p2='account'&@p3={'PageNumber':1,'Count':50} HTTP/1.1
If-None-Match: null
OData-Version: 4.0
OData-MaxVersion: 4.0
Content-Type: application/json
Accept: application/json
```
**Response**
```json
HTTP/1.1 200 OK  
Content-Type: application/json; odata.metadata=minimal  
OData-Version: 4.0

{
    "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#accounts",
    "value": [
        <Omitted for brevity: JSON data for any matching accounts including all properties>
    ]
}
```

<a name="BKMK_DupEntwebapi"></a>

## Detect duplicates for an entity type

Submit an asynchronous duplicate detection job that runs in the background. The duplicates are detected according to the published duplicate rules for the entity type. The detected duplicates are stored as `DuplicateRecord` records in Dynamics 365 Customer Engagement (on-premises). 

A maximum of 5000 duplicates are returned by the duplicate detection job.

### Options

- Web API: <xref href="Microsoft.Dynamics.CRM.BulkDetectDuplicates?text=BulkDetectDuplicates Action" />
- Organization Service: <xref:Microsoft.Crm.Sdk.Messages.BulkDetectDuplicatesRequest>

### Example: Detect duplicates for an entity type using the Web API 

The following example shows how to detect duplicates for an entity type by creating an asynchronous job using `BulkDetectDuplicates` action.

**Request**
```http
POST [Organization URI]/api/data/v9.1/BulkDetectDuplicates HTTP/1.1
If-None-Match: null
OData-Version: 4.0
Content-Type: application/json
Accept: application/json
OData-MaxVersion: 4.0

{
    "Query": {
        "@odata.type": "#Microsoft.Dynamics.CRM.QueryExpression",
        "EntityName": "lead"
    },
    "JobName": "jobname1",
    "SendEmailNotification": false,
    "TemplateId": "07B94C1D-C85F-492F-B120-F0A743C540E6",
    "ToRecipients": [],
    "CCRecipients": [],
    "RecurrencePattern": "",
    "RecurrenceStartTime": "2015-07-15T05:30:00Z"
}  
```
**Response**
```json
HTTP/1.1 200 OK  
Content-Type: application/json; odata.metadata=minimal  
OData-Version: 4.0

{
    "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#Microsoft.Dynamics.CRM.BulkDetectDuplicatesResponse",
    "JobId": "efaff068-7598-e711-80e8-00155db64062"
}
```
The above request creates an asynchronous duplicate detection job whose JobID is returned in the response. The JobID returned from the above request can be used to fetch duplicate records in an entity type, as shown in the example below.

**Request**
```http
GET [Organization URI]/api/data/v9.1/asyncoperations(efaff068-7598-e711-80e8-00155db64062)/AsyncOperation_DuplicateBaseRecord
If-None-Match: null
OData-Version: 4.0
OData-MaxVersion: 4.0
Content-Type: application/json
Accept: application/json
```
The FetchXML equivalent of the above request is shown below.

```xml
<fetch>
    <entity name="duplicaterecord">
        <attribute name="owninguser" />
        <attribute name="ownerid" />
        <attribute name="baserecordid" />
        <attribute name="duplicateid" />
        <attribute name="owningbusinessunit" />
        <attribute name="createdon" />
        <attribute name="asyncoperationid" />
        <filter>
            <condition attribute="asyncoperationid" operator="eq" value="efaff068-7598-e711-80e8-00155db64062" />
        </filter>
    </entity>
</fetch>
```

**Response**
```json
HTTP/1.1 200 OK  
Content-Type: application/json; odata.metadata=minimal  
OData-Version: 4.0

{  
   "@odata.context":"[Organization URI]/api/data/v9.1/$metadata#duplicaterecords",
   "value":[  
      {  
         "owninguser":"b3ac4144-6d9a-e711-811c-000d3a75ce72",
         "_ownerid_value":"b3ac4144-6d9a-e711-811c-000d3a75ce72",
         "_baserecordid_value":"3a6fc65b-3f9c-e711-811c-000d3a75ce72",
         "duplicateid":"489a879c-019b-4c28-8539-51ebc850d18f",
         "createdon":"2017-09-19T03:34:25Z",
         "owningbusinessunit":"20a44144-6d9a-e711-811c-000d3a75ce72",
         "_asyncoperationid_value":"efaff068-7598-e711-80e8-00155db64062",
         "_duplicateruleid_value":null,
         "_duplicaterecordid_value":null
      },
      {  
         "owninguser":"b3ac4144-6d9a-e711-811c-000d3a75ce72",
         "_ownerid_value":"b3ac4144-6d9a-e711-811c-000d3a75ce72",
         "_baserecordid_value":"406fc65b-3f9c-e711-811c-000d3a75ce72",
         "duplicateid":"0a4a7dea-1488-4e05-b5eb-c2925ad2925a",
         "createdon":"2017-09-19T03:34:25Z",
         "owningbusinessunit":"20a44144-6d9a-e711-811c-000d3a75ce72",
         "_asyncoperationid_value":"efaff068-7598-e711-80e8-00155db64062",
         "_duplicateruleid_value":null,
         "_duplicaterecordid_value":null
      }
   ]
}
```
The GUID of the base record is stored as `baserecordid` in the `DuplicateRecord` records. `duplicateid`, in the above response is the unique identifier of the duplicate record. `asyncoperationid` is the unique idenitifier of the system job that created that record. And, `ownerid` is the unique identifier of the user or team that owns the duplicate record. See [DuplicateRecord Entity](entities/duplicaterecord.md) for more information.

> [!NOTE]
>  Before creating and executing duplicate detection jobs, make sure that there are appropriate duplicate detection rules in place. Dynamics 365 Customer Engagement includes default duplicate detection rules for accounts, contacts, and leads, but not for other types of records. If you want the system to detect duplicates for other record types, you’ll need to create a new rule. For information on how to create a duplicate detection rule, see [Duplicate detection rules](../admin/set-up-duplicate-detection-rules-keep-data-clean.md).

<a name="BKMK_CRwebapi"></a>

## Detect duplicates during Create and Update operations

By default, duplicate detection is suppressed when you are creating or updating a record using Web API. Use `MSCRM.SuppressDuplicateDetection` header and set its value to `false` while creating or updating a record. Duplicate detection only applies when the organization has duplicate detection enabled, the entity is enabled for duplicate detection, and there are active duplicate detection rules being applied.

See more on how to detect duplicates during Create and Update operation in [Manage duplicate detection during Create and Update operation using Web API](duplicate-detection-create-update.md)

<a name="BKMK_dupdetos"></a>
###  Example: Duplicate detection using the Organization Service

 The following example shows how to pass the duplicate detection option as a part of the `CreateRequest` and `UpdateRequest` messages:  
  
 [!code-csharp[DuplicateDetection#InvokeDuplicateDetectionForCreateAndUpdate1](../snippets/csharp/CRMV8/duplicatedetection/cs/invokeduplicatedetectionforcreateandupdate1.cs#invokeduplicatedetectionforcreateandupdate1)]  
  
### See also  
 [Duplicate Detection](detect-duplicate-data-for-developers.md)   
 [Enable and disable duplicate detection](enable-disable-duplicate-detection.md)   
 [Use Messages (Request and Response Classes) with the Execute Method](/powerapps/developer/data-platform/org-service/use-messages)   
 [Duplicate Detection Messages](duplicate-detection-messages.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]