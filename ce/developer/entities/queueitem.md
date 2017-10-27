---
title: "QueueItem Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the QueueItem entity."
ms.date: 10/31/2017
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

## Properties

**DisplayName**: Queue Item<br />
**DisplayCollectionName**: Queue Items<br />
**SchemaName**: QueueItem<br />
**CollectionSchemaName**: QueueItems<br />
**LogicalName**: queueitem<br />
**LogicalCollectionName**: queueitems<br />
**EntitySetName**: queueitems<br />
**PrimaryIdAttribute**: queueitemid<br />
**PrimaryNameAttribute**: title<br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
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

**Description**: Unique identifier of the data import or data migration that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_ObjectId"></a> ObjectId

**Description**: Choose the activity, case, or article assigned to the queue.<br />
**DisplayName**: Object<br />
**LogicalName**: objectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: activitypointer,appointment,bulkoperation,campaignactivity,campaignresponse,email,fax,incident,knowledgearticle,letter,msdyn_agreementbookingdate,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoicesetup,msdyn_approval,msdyn_bookingalert,msdyn_inventoryadjustment,msdyn_inventorytransfer,msdyn_iotalert,msdyn_project,msdyn_projecttask,msdyn_resourcerequest,msdyn_timegroup,msdyn_timegroupdetail,msdyn_workorder,msdyn_workorderincident,msdyn_workorderservice,msdyn_workorderservicetask,phonecall,recurringappointmentmaster,serviceappointment,socialactivity,task


### <a name="BKMK_ObjectIdTypeCode"></a> ObjectIdTypeCode

**Description**: <br />
**DisplayName**: Regarding Object Type<br />
**LogicalName**: objectidtypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_Priority"></a> Priority

**Description**: Priority of the queue item.<br />
**DisplayName**: Priority<br />
**LogicalName**: priority<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_QueueId"></a> QueueId

**Description**: Choose the queue that the item is assigned to.<br />
**DisplayName**: Queue<br />
**LogicalName**: queueid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: queue


### <a name="BKMK_QueueItemId"></a> QueueItemId

**Description**: Unique identifier of the queue item.<br />
**DisplayName**: Queue Item<br />
**LogicalName**: queueitemid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Sender"></a> Sender

**Description**: Sender who created the queue item.<br />
**DisplayName**: From<br />
**LogicalName**: sender<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_State"></a> State

**Description**: Status of the queue item.<br />
**DisplayName**: Status (deprecated)<br />
**LogicalName**: state<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows whether the queue record is active or inactive. Inactive queue records are read-only and can't be edited unless they are reactivated.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_Status"></a> Status

**Description**: Reason for the status of the queue item.<br />
**DisplayName**: Status Reason (deprecated)<br />
**LogicalName**: status<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Select the item's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_ToRecipients"></a> ToRecipients

**Description**: Recipients listed on the To line of the message for email queue items.<br />
**DisplayName**: To<br />
**LogicalName**: torecipients<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 500


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_WorkerId"></a> WorkerId

**Description**: Shows who is working on the queue item.<br />
**DisplayName**: Worked By<br />
**LogicalName**: workerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser,team


### <a name="BKMK_WorkerIdType"></a> WorkerIdType

**Description**: <br />
**DisplayName**: Worker Type<br />
**LogicalName**: workeridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: EntityName<br />

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

**Description**: Shows who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EnteredOn"></a> EnteredOn

**Description**: Shows the date the record was assigned to the queue.<br />
**DisplayName**: Entered Queue<br />
**LogicalName**: enteredon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Shows who last updated the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the queueitem.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ObjectIdName"></a> ObjectIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: objectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

**Description**: Select the type of the queue item, such as activity, case, or appointment.<br />
**DisplayName**: Type<br />
**LogicalName**: objecttypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 112 **Label**: Case
- **Value**: 4200 **Label**: Activity
- **Value**: 4201 **Label**: Appointment
- **Value**: 4202 **Label**: Email
- **Value**: 4204 **Label**: Fax
- **Value**: 4207 **Label**: Letter
- **Value**: 4210 **Label**: Phone Call
- **Value**: 4212 **Label**: Task
- **Value**: 4214 **Label**: Service Activity
- **Value**: 4216 **Label**: Social Activity
- **Value**: 4251 **Label**: Recurring Appointment
- **Value**: 4401 **Label**: Campaign Response
- **Value**: 4402 **Label**: Campaign Activity
- **Value**: 4406 **Label**: Quick Campaign
- **Value**: 9953 **Label**: Knowledge Article
- **Value**: 10007 **Label**: Booking Alert
- **Value**: 10027 **Label**: Time Group
- **Value**: 10028 **Label**: Time Group Detail
- **Value**: 10032 **Label**: Approval
- **Value**: 10069 **Label**: Project
- **Value**: 10074 **Label**: Project Task
- **Value**: 10091 **Label**: Resource Request
- **Value**: 10108 **Label**: Agreement Booking Date
- **Value**: 10113 **Label**: Agreement Booking Setup
- **Value**: 10114 **Label**: Agreement Invoice Date
- **Value**: 10116 **Label**: Agreement Invoice Setup
- **Value**: 10133 **Label**: Inventory Adjustment
- **Value**: 10136 **Label**: Inventory Transfer
- **Value**: 10176 **Label**: Work Order
- **Value**: 10179 **Label**: Work Order Incident
- **Value**: 10182 **Label**: Work Order Service
- **Value**: 10183 **Label**: Work Order Service Task
- **Value**: 10190 **Label**: IoT Alert



### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier of the organization with which the queue item is associated.<br />
**DisplayName**: Organization<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Unique identifier of the user or team who owns the queue item.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier of the business unit that owns the queue item.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user who owns the queue item.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_QueueIdName"></a> QueueIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: queueidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 400


### <a name="BKMK_Title"></a> Title

**Description**: Shows the title or name that describes the queue record. This value is copied from the record that was assigned to the queue.<br />
**DisplayName**: Title<br />
**LogicalName**: title<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 300


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version number of the queue item.<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />


### <a name="BKMK_WorkerIdModifiedOn"></a> WorkerIdModifiedOn

**Description**: Shows the date and time when the queue item was last assigned to a user.<br />
**DisplayName**: Worked On<br />
**LogicalName**: workeridmodifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_WorkerIdName"></a> WorkerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: workeridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_WorkerIdYomiName"></a> WorkerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: workeridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160

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

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_queueitem<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_QueueItem_AsyncOperations"></a> QueueItem_AsyncOperations

Same as asyncoperation entity [QueueItem_AsyncOperations](asyncoperation.md#BKMK_QueueItem_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: QueueItem_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_QueueItem_SyncErrors"></a> QueueItem_SyncErrors

Same as syncerror entity [QueueItem_SyncErrors](syncerror.md#BKMK_QueueItem_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: QueueItem_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_QueueItem_BulkDeleteFailures"></a> QueueItem_BulkDeleteFailures

Same as bulkdeletefailure entity [QueueItem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_QueueItem_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: QueueItem_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_queueitem_principalobjectattributeaccess"></a> queueitem_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [queueitem_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_queueitem_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: queueitem_principalobjectattributeaccess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_QueueItem_ProcessSessions"></a> QueueItem_ProcessSessions

Same as processsession entity [QueueItem_ProcessSessions](processsession.md#BKMK_QueueItem_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: QueueItem_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [msdyn_iotalert_QueueItems](#BKMK_msdyn_iotalert_QueueItems)
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


### <a name="BKMK_msdyn_iotalert_QueueItems"></a> msdyn_iotalert_QueueItems

See msdyn_iotalert Entity [msdyn_iotalert_QueueItems](msdyn_iotalert.md#BKMK_msdyn_iotalert_QueueItems) One-To-Many relationship.

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

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.queueitem?text=queueitem EntityType" />