---
title: "QueueItem Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the QueueItem entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# QueueItem Entity Reference

A specific item in a queue, such as a case record or an activity record.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|AddToQueue|<xref href="Microsoft.Dynamics.CRM.AddToQueue?text=AddToQueue Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddToQueueRequest>|
|Create|POST [*org URI*]/api/data/v9.0/queueitems<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/queueitems(*queueitemid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|PickFromQueue|<xref href="Microsoft.Dynamics.CRM.PickFromQueue?text=PickFromQueue Action" />|<xref:Microsoft.Crm.Sdk.Messages.PickFromQueueRequest>|
|ReleaseToQueue|<xref href="Microsoft.Dynamics.CRM.ReleaseToQueue?text=ReleaseToQueue Action" />|<xref:Microsoft.Crm.Sdk.Messages.ReleaseToQueueRequest>|
|RemoveFromQueue|<xref href="Microsoft.Dynamics.CRM.RemoveFromQueue?text=RemoveFromQueue Action" />|<xref:Microsoft.Crm.Sdk.Messages.RemoveFromQueueRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/queueitems(*queueitemid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/queueitems<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RouteTo|<xref href="Microsoft.Dynamics.CRM.RouteTo?text=RouteTo Action" />|<xref:Microsoft.Crm.Sdk.Messages.RouteToRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/queueitems(*queueitemid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/queueitems(*queueitemid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|QueueItems|
|DisplayCollectionName|Queue Items|
|DisplayName|Queue Item|
|EntitySetName|queueitems|
|IsBPFEntity|False|
|LogicalCollectionName|queueitems|
|LogicalName|queueitem|
|OwnershipType|None|
|PrimaryIdAttribute|queueitemid|
|PrimaryNameAttribute|title|
|SchemaName|QueueItem|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [ObjectId](#BKMK_ObjectId)
- [ObjectIdTypeCode](#BKMK_ObjectIdTypeCode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [Priority](#BKMK_Priority)
- [QueueId](#BKMK_QueueId)
- [QueueItemId](#BKMK_QueueItemId)
- [Sender](#BKMK_Sender)
- [State](#BKMK_State)
- [StateCode](#BKMK_StateCode)
- [Status](#BKMK_Status)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [ToRecipients](#BKMK_ToRecipients)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [WorkerId](#BKMK_WorkerId)
- [WorkerIdType](#BKMK_WorkerIdType)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data import or data migration that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ObjectId"></a> ObjectId

|Property|Value|
|--------|-----|
|Description|Choose the activity, case, or article assigned to the queue.|
|DisplayName|Object|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|objectid|
|RequiredLevel|ApplicationRequired|
|Targets|activitypointer,appointment,bulkoperation,campaignactivity,campaignresponse,email,fax,incident,knowledgearticle,letter,msdyn_agreementbookingdate,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoicesetup,msdyn_approval,msdyn_bookingalert,msdyn_inventoryadjustment,msdyn_inventorytransfer,msdyn_iotalert,msdyn_project,msdyn_projecttask,msdyn_resourcerequest,msdyn_timegroup,msdyn_timegroupdetail,msdyn_workorder,msdyn_workorderincident,msdyn_workorderservice,msdyn_workorderservicetask,phonecall,recurringappointmentmaster,serviceappointment,socialactivity,task|
|Type|Lookup|


### <a name="BKMK_ObjectIdTypeCode"></a> ObjectIdTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Regarding Object Type|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|objectidtypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Priority"></a> Priority

|Property|Value|
|--------|-----|
|Description|Priority of the queue item.|
|DisplayName|Priority|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|priority|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_QueueId"></a> QueueId

|Property|Value|
|--------|-----|
|Description|Choose the queue that the item is assigned to.|
|DisplayName|Queue|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|queueid|
|RequiredLevel|ApplicationRequired|
|Targets|queue|
|Type|Lookup|


### <a name="BKMK_QueueItemId"></a> QueueItemId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the queue item.|
|DisplayName|Queue Item|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|queueitemid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_Sender"></a> Sender

|Property|Value|
|--------|-----|
|Description|Sender who created the queue item.|
|DisplayName|From|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sender|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_State"></a> State

|Property|Value|
|--------|-----|
|Description|Status of the queue item.|
|DisplayName|Status (deprecated)|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|state|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the queue record is active or inactive. Inactive queue records are read-only and can't be edited unless they are reactivated.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_Status"></a> Status

|Property|Value|
|--------|-----|
|Description|Reason for the status of the queue item.|
|DisplayName|Status Reason (deprecated)|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|status|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the item's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|SystemRequired|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ToRecipients"></a> ToRecipients

|Property|Value|
|--------|-----|
|Description|Recipients listed on the To line of the message for email queue items.|
|DisplayName|To|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|torecipients|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_WorkerId"></a> WorkerId

|Property|Value|
|--------|-----|
|Description|Shows who is working on the queue item.|
|DisplayName|Worked By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|workerid|
|RequiredLevel|None|
|Targets|systemuser,team|
|Type|Lookup|


### <a name="BKMK_WorkerIdType"></a> WorkerIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Worker Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|workeridtype|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [EnteredOn](#BKMK_EnteredOn)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [ObjectIdName](#BKMK_ObjectIdName)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningUser](#BKMK_OwningUser)
- [QueueIdName](#BKMK_QueueIdName)
- [Title](#BKMK_Title)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)
- [WorkerIdModifiedOn](#BKMK_WorkerIdModifiedOn)
- [WorkerIdName](#BKMK_WorkerIdName)
- [WorkerIdYomiName](#BKMK_WorkerIdYomiName)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EnteredOn"></a> EnteredOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date the record was assigned to the queue.|
|DisplayName|Entered Queue|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|enteredon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the queueitem.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ObjectIdName"></a> ObjectIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|objectidname|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Select the type of the queue item, such as activity, case, or appointment.|
|DisplayName|Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|objecttypecode|
|RequiredLevel|None|
|Type|Picklist|

#### ObjectTypeCode Options

|Value|Label|
|-----|-----|
|112|Case|
|4200|Activity|
|4201|Appointment|
|4202|Email|
|4204|Fax|
|4207|Letter|
|4210|Phone Call|
|4212|Task|
|4214|Service Activity|
|4216|Social Activity|
|4251|Recurring Appointment|
|4401|Campaign Response|
|4402|Campaign Activity|
|4406|Quick Campaign|
|9953|Knowledge Article|
|10007|Booking Alert|
|10027|Time Group|
|10028|Time Group Detail|
|10032|Approval|
|10069|Project|
|10074|Project Task|
|10091|Resource Request|
|10108|Agreement Booking Date|
|10113|Agreement Booking Setup|
|10114|Agreement Invoice Date|
|10116|Agreement Invoice Setup|
|10133|Inventory Adjustment|
|10136|Inventory Transfer|
|10176|Work Order|
|10179|Work Order Incident|
|10182|Work Order Service|
|10183|Work Order Service Task|
|10186|IoT Alert|



### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization with which the queue item is associated.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the queue item.|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|ApplicationRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns the queue item.|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|ApplicationRequired|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who owns the queue item.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|ApplicationRequired|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_QueueIdName"></a> QueueIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|queueidname|
|MaxLength|400|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_Title"></a> Title

|Property|Value|
|--------|-----|
|Description|Shows the title or name that describes the queue record. This value is copied from the record that was assigned to the queue.|
|DisplayName|Title|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|title|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version number of the queue item.|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_WorkerIdModifiedOn"></a> WorkerIdModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the queue item was last assigned to a user.|
|DisplayName|Worked On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|workeridmodifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_WorkerIdName"></a> WorkerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|workeridname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_WorkerIdYomiName"></a> WorkerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|workeridyominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [userentityinstancedata_queueitem](#BKMK_userentityinstancedata_queueitem)
- [QueueItem_AsyncOperations](#BKMK_QueueItem_AsyncOperations)
- [QueueItem_SyncErrors](#BKMK_QueueItem_SyncErrors)
- [QueueItem_BulkDeleteFailures](#BKMK_QueueItem_BulkDeleteFailures)
- [queueitem_principalobjectattributeaccess](#BKMK_queueitem_principalobjectattributeaccess)
- [QueueItem_ProcessSessions](#BKMK_QueueItem_ProcessSessions)


### <a name="BKMK_userentityinstancedata_queueitem"></a> userentityinstancedata_queueitem

Same as userentityinstancedata entity [userentityinstancedata_queueitem](userentityinstancedata.md#BKMK_userentityinstancedata_queueitem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_queueitem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_QueueItem_AsyncOperations"></a> QueueItem_AsyncOperations

Same as asyncoperation entity [QueueItem_AsyncOperations](asyncoperation.md#BKMK_QueueItem_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|QueueItem_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_QueueItem_SyncErrors"></a> QueueItem_SyncErrors

Same as syncerror entity [QueueItem_SyncErrors](syncerror.md#BKMK_QueueItem_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|QueueItem_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_QueueItem_BulkDeleteFailures"></a> QueueItem_BulkDeleteFailures

Same as bulkdeletefailure entity [QueueItem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_QueueItem_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|QueueItem_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_queueitem_principalobjectattributeaccess"></a> queueitem_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [queueitem_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_queueitem_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|queueitem_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_QueueItem_ProcessSessions"></a> QueueItem_ProcessSessions

Same as processsession entity [QueueItem_ProcessSessions](processsession.md#BKMK_QueueItem_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|QueueItem_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [CampaignActivity_QueueItem](#BKMK_CampaignActivity_QueueItem)
- [CampaignResponse_QueueItem](#BKMK_CampaignResponse_QueueItem)
- [BulkOperation_QueueItem](#BKMK_BulkOperation_QueueItem)
- [Incident_QueueItem](#BKMK_Incident_QueueItem)
- [ServiceAppointment_QueueItem](#BKMK_ServiceAppointment_QueueItem)
- [msdyn_bookingalert_QueueItems](#BKMK_msdyn_bookingalert_QueueItems)
- [msdyn_timegroup_QueueItems](#BKMK_msdyn_timegroup_QueueItems)
- [msdyn_timegroupdetail_QueueItems](#BKMK_msdyn_timegroupdetail_QueueItems)
- [msdyn_approval_QueueItems](#BKMK_msdyn_approval_QueueItems)
- [msdyn_project_QueueItems](#BKMK_msdyn_project_QueueItems)
- [msdyn_projecttask_QueueItems](#BKMK_msdyn_projecttask_QueueItems)
- [msdyn_resourcerequest_QueueItems](#BKMK_msdyn_resourcerequest_QueueItems)
- [msdyn_agreementbookingdate_QueueItems](#BKMK_msdyn_agreementbookingdate_QueueItems)
- [msdyn_agreementbookingsetup_QueueItems](#BKMK_msdyn_agreementbookingsetup_QueueItems)
- [msdyn_agreementinvoicedate_QueueItems](#BKMK_msdyn_agreementinvoicedate_QueueItems)
- [msdyn_agreementinvoicesetup_QueueItems](#BKMK_msdyn_agreementinvoicesetup_QueueItems)
- [msdyn_inventoryadjustment_QueueItems](#BKMK_msdyn_inventoryadjustment_QueueItems)
- [msdyn_inventorytransfer_QueueItems](#BKMK_msdyn_inventorytransfer_QueueItems)
- [msdyn_workorder_QueueItems](#BKMK_msdyn_workorder_QueueItems)
- [msdyn_workorderincident_QueueItems](#BKMK_msdyn_workorderincident_QueueItems)
- [msdyn_workorderservice_QueueItems](#BKMK_msdyn_workorderservice_QueueItems)
- [msdyn_workorderservicetask_QueueItems](#BKMK_msdyn_workorderservicetask_QueueItems)
- [msdyn_iotalert_QueueItems](#BKMK_msdyn_iotalert_QueueItems)
- [knowledgearticle_QueueItems](#BKMK_knowledgearticle_QueueItems)
- [lk_queueitem_createdonbehalfby](#BKMK_lk_queueitem_createdonbehalfby)
- [lk_queueitembase_workerid](#BKMK_lk_queueitembase_workerid)
- [ActivityPointer_QueueItem](#BKMK_ActivityPointer_QueueItem)
- [queue_entries](#BKMK_queue_entries)
- [lk_queueitembase_createdby](#BKMK_lk_queueitembase_createdby)
- [organization_queueitems](#BKMK_organization_queueitems)
- [TransactionCurrency_QueueItem](#BKMK_TransactionCurrency_QueueItem)
- [Appointment_QueueItem](#BKMK_Appointment_QueueItem)
- [Fax_QueueItem](#BKMK_Fax_QueueItem)
- [team_queueitembase_workerid](#BKMK_team_queueitembase_workerid)
- [Email_QueueItem](#BKMK_Email_QueueItem)
- [SocialActivity_QueueItem](#BKMK_SocialActivity_QueueItem)
- [lk_queueitem_modifiedonbehalfby](#BKMK_lk_queueitem_modifiedonbehalfby)
- [PhoneCall_QueueItem](#BKMK_PhoneCall_QueueItem)
- [Task_QueueItem](#BKMK_Task_QueueItem)
- [RecurringAppointmentMaster_QueueItem](#BKMK_RecurringAppointmentMaster_QueueItem)
- [Letter_QueueItem](#BKMK_Letter_QueueItem)
- [lk_queueitembase_modifiedby](#BKMK_lk_queueitembase_modifiedby)


### <a name="BKMK_CampaignActivity_QueueItem"></a> CampaignActivity_QueueItem

See campaignactivity Entity [CampaignActivity_QueueItem](campaignactivity.md#BKMK_CampaignActivity_QueueItem) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_QueueItem"></a> CampaignResponse_QueueItem

See campaignresponse Entity [CampaignResponse_QueueItem](campaignresponse.md#BKMK_CampaignResponse_QueueItem) One-To-Many relationship.

### <a name="BKMK_BulkOperation_QueueItem"></a> BulkOperation_QueueItem

See bulkoperation Entity [BulkOperation_QueueItem](bulkoperation.md#BKMK_BulkOperation_QueueItem) One-To-Many relationship.

### <a name="BKMK_Incident_QueueItem"></a> Incident_QueueItem

See incident Entity [Incident_QueueItem](incident.md#BKMK_Incident_QueueItem) One-To-Many relationship.

### <a name="BKMK_ServiceAppointment_QueueItem"></a> ServiceAppointment_QueueItem

See serviceappointment Entity [ServiceAppointment_QueueItem](serviceappointment.md#BKMK_ServiceAppointment_QueueItem) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_QueueItems"></a> msdyn_bookingalert_QueueItems

See msdyn_bookingalert Entity [msdyn_bookingalert_QueueItems](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_QueueItems"></a> msdyn_timegroup_QueueItems

See msdyn_timegroup Entity [msdyn_timegroup_QueueItems](msdyn_timegroup.md#BKMK_msdyn_timegroup_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_QueueItems"></a> msdyn_timegroupdetail_QueueItems

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_QueueItems](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_QueueItems"></a> msdyn_approval_QueueItems

See msdyn_approval Entity [msdyn_approval_QueueItems](msdyn_approval.md#BKMK_msdyn_approval_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_project_QueueItems"></a> msdyn_project_QueueItems

See msdyn_project Entity [msdyn_project_QueueItems](msdyn_project.md#BKMK_msdyn_project_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttask_QueueItems"></a> msdyn_projecttask_QueueItems

See msdyn_projecttask Entity [msdyn_projecttask_QueueItems](msdyn_projecttask.md#BKMK_msdyn_projecttask_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequest_QueueItems"></a> msdyn_resourcerequest_QueueItems

See msdyn_resourcerequest Entity [msdyn_resourcerequest_QueueItems](msdyn_resourcerequest.md#BKMK_msdyn_resourcerequest_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_QueueItems"></a> msdyn_agreementbookingdate_QueueItems

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_QueueItems](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_QueueItems"></a> msdyn_agreementbookingsetup_QueueItems

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_QueueItems](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_QueueItems"></a> msdyn_agreementinvoicedate_QueueItems

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_QueueItems](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_QueueItems"></a> msdyn_agreementinvoicesetup_QueueItems

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_QueueItems](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_QueueItems"></a> msdyn_inventoryadjustment_QueueItems

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_QueueItems](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_QueueItems"></a> msdyn_inventorytransfer_QueueItems

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_QueueItems](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_QueueItems"></a> msdyn_workorder_QueueItems

See msdyn_workorder Entity [msdyn_workorder_QueueItems](msdyn_workorder.md#BKMK_msdyn_workorder_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_QueueItems"></a> msdyn_workorderincident_QueueItems

See msdyn_workorderincident Entity [msdyn_workorderincident_QueueItems](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_QueueItems"></a> msdyn_workorderservice_QueueItems

See msdyn_workorderservice Entity [msdyn_workorderservice_QueueItems](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_QueueItems"></a> msdyn_workorderservicetask_QueueItems

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_QueueItems](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_QueueItems) One-To-Many relationship.

### <a name="BKMK_msdyn_iotalert_QueueItems"></a> msdyn_iotalert_QueueItems

See msdyn_iotalert Entity [msdyn_iotalert_QueueItems](msdyn_iotalert.md#BKMK_msdyn_iotalert_QueueItems) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_QueueItems"></a> knowledgearticle_QueueItems

See knowledgearticle Entity [knowledgearticle_QueueItems](knowledgearticle.md#BKMK_knowledgearticle_QueueItems) One-To-Many relationship.

### <a name="BKMK_lk_queueitem_createdonbehalfby"></a> lk_queueitem_createdonbehalfby

See systemuser Entity [lk_queueitem_createdonbehalfby](systemuser.md#BKMK_lk_queueitem_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_queueitembase_workerid"></a> lk_queueitembase_workerid

See systemuser Entity [lk_queueitembase_workerid](systemuser.md#BKMK_lk_queueitembase_workerid) One-To-Many relationship.

### <a name="BKMK_ActivityPointer_QueueItem"></a> ActivityPointer_QueueItem

See activitypointer Entity [ActivityPointer_QueueItem](activitypointer.md#BKMK_ActivityPointer_QueueItem) One-To-Many relationship.

### <a name="BKMK_queue_entries"></a> queue_entries

See queue Entity [queue_entries](queue.md#BKMK_queue_entries) One-To-Many relationship.

### <a name="BKMK_lk_queueitembase_createdby"></a> lk_queueitembase_createdby

See systemuser Entity [lk_queueitembase_createdby](systemuser.md#BKMK_lk_queueitembase_createdby) One-To-Many relationship.

### <a name="BKMK_organization_queueitems"></a> organization_queueitems

See organization Entity [organization_queueitems](organization.md#BKMK_organization_queueitems) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_QueueItem"></a> TransactionCurrency_QueueItem

See transactioncurrency Entity [TransactionCurrency_QueueItem](transactioncurrency.md#BKMK_TransactionCurrency_QueueItem) One-To-Many relationship.

### <a name="BKMK_Appointment_QueueItem"></a> Appointment_QueueItem

See appointment Entity [Appointment_QueueItem](appointment.md#BKMK_Appointment_QueueItem) One-To-Many relationship.

### <a name="BKMK_Fax_QueueItem"></a> Fax_QueueItem

See fax Entity [Fax_QueueItem](fax.md#BKMK_Fax_QueueItem) One-To-Many relationship.

### <a name="BKMK_team_queueitembase_workerid"></a> team_queueitembase_workerid

See team Entity [team_queueitembase_workerid](team.md#BKMK_team_queueitembase_workerid) One-To-Many relationship.

### <a name="BKMK_Email_QueueItem"></a> Email_QueueItem

See email Entity [Email_QueueItem](email.md#BKMK_Email_QueueItem) One-To-Many relationship.

### <a name="BKMK_SocialActivity_QueueItem"></a> SocialActivity_QueueItem

See socialactivity Entity [SocialActivity_QueueItem](socialactivity.md#BKMK_SocialActivity_QueueItem) One-To-Many relationship.

### <a name="BKMK_lk_queueitem_modifiedonbehalfby"></a> lk_queueitem_modifiedonbehalfby

See systemuser Entity [lk_queueitem_modifiedonbehalfby](systemuser.md#BKMK_lk_queueitem_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_PhoneCall_QueueItem"></a> PhoneCall_QueueItem

See phonecall Entity [PhoneCall_QueueItem](phonecall.md#BKMK_PhoneCall_QueueItem) One-To-Many relationship.

### <a name="BKMK_Task_QueueItem"></a> Task_QueueItem

See task Entity [Task_QueueItem](task.md#BKMK_Task_QueueItem) One-To-Many relationship.

### <a name="BKMK_RecurringAppointmentMaster_QueueItem"></a> RecurringAppointmentMaster_QueueItem

See recurringappointmentmaster Entity [RecurringAppointmentMaster_QueueItem](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_QueueItem) One-To-Many relationship.

### <a name="BKMK_Letter_QueueItem"></a> Letter_QueueItem

See letter Entity [Letter_QueueItem](letter.md#BKMK_Letter_QueueItem) One-To-Many relationship.

### <a name="BKMK_lk_queueitembase_modifiedby"></a> lk_queueitembase_modifiedby

See systemuser Entity [lk_queueitembase_modifiedby](systemuser.md#BKMK_lk_queueitembase_modifiedby) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.queueitem?text=queueitem EntityType" />