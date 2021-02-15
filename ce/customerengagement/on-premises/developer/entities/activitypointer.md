---
title: "ActivityPointer Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ActivityPointer entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# ActivityPointer Entity Reference

Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/activitypointers(*activityid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/activitypointers<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Rollup|<xref href="Microsoft.Dynamics.CRM.Rollup?text=Rollup Function" />|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ActivityPointers|
|DisplayCollectionName|Activities|
|DisplayName|Activity|
|EntitySetName|activitypointers|
|IsBPFEntity|False|
|LogicalCollectionName|activitypointers|
|LogicalName|activitypointer|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|activityid|
|PrimaryNameAttribute|subject|
|SchemaName|ActivityPointer|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityAdditionalParams](#BKMK_ActivityAdditionalParams)
- [ActivityId](#BKMK_ActivityId)
- [ActualDurationMinutes](#BKMK_ActualDurationMinutes)
- [ActualEnd](#BKMK_ActualEnd)
- [ActualStart](#BKMK_ActualStart)
- [Community](#BKMK_Community)
- [DeliveryPriorityCode](#BKMK_DeliveryPriorityCode)
- [Description](#BKMK_Description)
- [ExchangeItemId](#BKMK_ExchangeItemId)
- [ExchangeWebLink](#BKMK_ExchangeWebLink)
- [IsBilled](#BKMK_IsBilled)
- [IsMapiPrivate](#BKMK_IsMapiPrivate)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LeftVoiceMail](#BKMK_LeftVoiceMail)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [ScheduledDurationMinutes](#BKMK_ScheduledDurationMinutes)
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledStart](#BKMK_ScheduledStart)
- [ServiceId](#BKMK_ServiceId)
- [SLAId](#BKMK_SLAId)
- [SortDate](#BKMK_SortDate)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [Subject](#BKMK_Subject)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ActivityAdditionalParams"></a> ActivityAdditionalParams

|Property|Value|
|--------|-----|
|Description|Additional information provided by the external application as JSON. For internal use only.|
|DisplayName|Activity Additional Parameters|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|activityadditionalparams|
|MaxLength|8192|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ActivityId"></a> ActivityId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the activity.|
|DisplayName|Activity|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|activityid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|--------|-----|
|Description|Actual duration of the activity in minutes.|
|DisplayName|Actual Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualdurationminutes|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ActualEnd"></a> ActualEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Actual end time of the activity.|
|DisplayName|Actual End|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ActualStart"></a> ActualStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Actual start time of the activity.|
|DisplayName|Actual Start|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Community"></a> Community

|Property|Value|
|--------|-----|
|Description|Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.|
|DisplayName|Social Channel|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|community|
|RequiredLevel|None|
|Type|Picklist|

#### Community Options

|Value|Label|
|-----|-----|
|0|Other|
|1|Facebook|
|2|Twitter|



### <a name="BKMK_DeliveryPriorityCode"></a> DeliveryPriorityCode

|Property|Value|
|--------|-----|
|Description|Priority of delivery of the activity to the email server.|
|DisplayName|Delivery Priority|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|deliveryprioritycode|
|RequiredLevel|None|
|Type|Picklist|

#### DeliveryPriorityCode Options

|Value|Label|
|-----|-----|
|0|Low|
|1|Normal|
|2|High|



### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of the activity.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ExchangeItemId"></a> ExchangeItemId

|Property|Value|
|--------|-----|
|Description|The message id of activity which is returned from Exchange Server.|
|DisplayName|Exchange Item ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|exchangeitemid|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeWebLink"></a> ExchangeWebLink

|Property|Value|
|--------|-----|
|Description|Shows the web link of Activity of type email.|
|DisplayName|Exchange WebLink|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|exchangeweblink|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IsBilled"></a> IsBilled

|Property|Value|
|--------|-----|
|Description|Information regarding whether the activity was billed as part of resolving a case.|
|DisplayName|Is Billed|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isbilled|
|RequiredLevel|None|
|Type|Boolean|

#### IsBilled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsMapiPrivate"></a> IsMapiPrivate

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Is Private|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismapiprivate|
|RequiredLevel|None|
|Type|Boolean|

#### IsMapiPrivate Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|--------|-----|
|Description|Information regarding whether the activity was created from a workflow rule.|
|DisplayName|Is Workflow Created|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isworkflowcreated|
|RequiredLevel|None|
|Type|Boolean|

#### IsWorkflowCreated Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Contains the date and time stamp of the last on hold time.|
|DisplayName|Last On Hold Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|lastonholdtime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_LeftVoiceMail"></a> LeftVoiceMail

|Property|Value|
|--------|-----|
|Description|Left the voice mail|
|DisplayName|Left Voice Mail|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|leftvoicemail|
|RequiredLevel|None|
|Type|Boolean|

#### LeftVoiceMail Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the activity.|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|--------|-----|
|Description|Priority of the activity.|
|DisplayName|Priority|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|prioritycode|
|RequiredLevel|None|
|Type|Picklist|

#### PriorityCode Options

|Value|Label|
|-----|-----|
|0|Low|
|1|Normal|
|2|High|



### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Process.|
|DisplayName|Process|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the object with which the activity is associated.|
|DisplayName|Regarding|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,entitlementtemplate,incident,interactionforemail,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_playbookinstance,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site|
|Type|Lookup|


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidyominame|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

|Property|Value|
|--------|-----|
|Description|Scheduled duration of the activity, specified in minutes.|
|DisplayName|Scheduled Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduleddurationminutes|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Scheduled end time of the activity.|
|DisplayName|Due Date|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduledend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Scheduled start time of the activity.|
|DisplayName|Start Date|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|scheduledstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ServiceId"></a> ServiceId

**Added by**: Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of an associated service.|
|DisplayName|Service|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|serviceid|
|RequiredLevel|None|
|Targets|service|
|Type|Lookup|


### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|--------|-----|
|Description|Choose the service level agreement (SLA) that you want to apply to the case record.|
|DisplayName|SLA|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|slaid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_SortDate"></a> SortDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time by which the activities are sorted.|
|DisplayName|Sort Date|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|sortdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Stage.|
|DisplayName|(Deprecated) Process Stage|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the activity.|
|DisplayName|Activity Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Open|1|Open|
|1|Completed|2|Completed|
|2|Canceled|3|Canceled|
|3|Scheduled|4|Scheduled|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the activity.|
|DisplayName|Status Reason|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Open|0|
|2|Completed|1|
|3|Canceled|2|
|4|Scheduled|3|



### <a name="BKMK_Subject"></a> Subject

|Property|Value|
|--------|-----|
|Description|Subject associated with the activity.|
|DisplayName|Subject|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|subject|
|MaxLength|400|
|RequiredLevel|ApplicationRequired|
|Type|String|


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


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the activitypointer.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|(Deprecated) Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


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

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ActivityTypeCode](#BKMK_ActivityTypeCode)
- [allparties](#BKMK_allparties)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [DeliveryLastAttemptedOn](#BKMK_DeliveryLastAttemptedOn)
- [ExchangeRate](#BKMK_ExchangeRate)
- [InstanceTypeCode](#BKMK_InstanceTypeCode)
- [IsRegularActivity](#BKMK_IsRegularActivity)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OnHoldTime](#BKMK_OnHoldTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PostponeActivityProcessingUntil](#BKMK_PostponeActivityProcessingUntil)
- [SenderMailboxId](#BKMK_SenderMailboxId)
- [SenderMailboxIdName](#BKMK_SenderMailboxIdName)
- [SentOn](#BKMK_SentOn)
- [SeriesId](#BKMK_SeriesId)
- [ServiceIdName](#BKMK_ServiceIdName)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ActivityTypeCode"></a> ActivityTypeCode

|Property|Value|
|--------|-----|
|Description|Type of activity.|
|DisplayName|Activity Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|activitytypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_allparties"></a> allparties

|Property|Value|
|--------|-----|
|Description|All activity parties associated with this activity.|
|DisplayName|All Activity Parties|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allparties|
|RequiredLevel|None|
|Targets|account,contact,equipment,lead,queue,systemuser,team|
|Type|PartyList|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the activity.|
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
|Description|Date and time when the activity was created.|
|DisplayName|Date Created|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the activitypointer.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
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


### <a name="BKMK_DeliveryLastAttemptedOn"></a> DeliveryLastAttemptedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the delivery of the activity was last attempted.|
|DisplayName|Date Delivery Last Attempted|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|deliverylastattemptedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the activitypointer with respect to the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_InstanceTypeCode"></a> InstanceTypeCode

|Property|Value|
|--------|-----|
|Description|Type of instance of a recurring series.|
|DisplayName|Recurring Instance Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|instancetypecode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### InstanceTypeCode Options

|Value|Label|
|-----|-----|
|0|Not Recurring|
|1|Recurring Master|
|2|Recurring Instance|
|3|Recurring Exception|
|4|Recurring Future Exception|



### <a name="BKMK_IsRegularActivity"></a> IsRegularActivity

|Property|Value|
|--------|-----|
|Description|Information regarding whether the activity is a regular activity type or event type.|
|DisplayName|Is Regular Activity|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isregularactivity|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsRegularActivity Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of user who last modified the activity.|
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
|Description|Date and time when activity was last modified.|
|DisplayName|Last Updated|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the activitypointer.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
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


### <a name="BKMK_OnHoldTime"></a> OnHoldTime

|Property|Value|
|--------|-----|
|Description|Shows how long, in minutes, that the record was on hold.|
|DisplayName|On Hold Time (Minutes)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|onholdtime|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns the activity.|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier of the team that owns the activity.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user that owns the activity.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_PostponeActivityProcessingUntil"></a> PostponeActivityProcessingUntil

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|For internal use only.|
|DisplayName|Delay activity processing until|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|postponeactivityprocessinguntil|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_SenderMailboxId"></a> SenderMailboxId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the mailbox associated with the sender of the email message.|
|DisplayName|Sender's Mailbox|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sendermailboxid|
|RequiredLevel|None|
|Targets|mailbox|
|Type|Lookup|


### <a name="BKMK_SenderMailboxIdName"></a> SenderMailboxIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sendermailboxidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SentOn"></a> SentOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the activity was sent.|
|DisplayName|Date Sent|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|senton|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_SeriesId"></a> SeriesId

|Property|Value|
|--------|-----|
|Description|Uniqueidentifier specifying the id of recurring series of an instance.|
|DisplayName|Series Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|seriesid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ServiceIdName"></a> ServiceIdName

**Added by**: Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|serviceidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|--------|-----|
|Description|Last SLA that was applied to this case. This field is for internal use only.|
|DisplayName|Last SLA applied|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedid|
|RequiredLevel|None|
|Targets|sla|
|Type|Lookup|


### <a name="BKMK_SLAInvokedIdName"></a> SLAInvokedIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slainvokedidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SLAName"></a> SLAName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slaname|
|MaxLength|100|
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
|Description|Version number of the activity.|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [activity_pointer_BulkOperation](#BKMK_activity_pointer_BulkOperation)
- [activity_pointer_campaignactivity](#BKMK_activity_pointer_campaignactivity)
- [activity_pointer_campaignresponse](#BKMK_activity_pointer_campaignresponse)
- [activity_pointer_BulkOperation_logs](#BKMK_activity_pointer_BulkOperation_logs)
- [CreatedActivity_BulkOperationLogs](#BKMK_CreatedActivity_BulkOperationLogs)
- [activity_campaignresponse](#BKMK_activity_campaignresponse)
- [activity_pointer_incident_resolution](#BKMK_activity_pointer_incident_resolution)
- [activity_pointer_service_appointment](#BKMK_activity_pointer_service_appointment)
- [activity_pointer_opportunity_close](#BKMK_activity_pointer_opportunity_close)
- [activity_pointer_order_close](#BKMK_activity_pointer_order_close)
- [activity_pointer_quote_close](#BKMK_activity_pointer_quote_close)
- [activity_pointer_msdyn_bookingalert](#BKMK_activity_pointer_msdyn_bookingalert)
- [activity_pointer_msdyn_approval](#BKMK_activity_pointer_msdyn_approval)
- [activity_pointer_fax](#BKMK_activity_pointer_fax)
- [activity_pointer_recurrencerule](#BKMK_activity_pointer_recurrencerule)
- [activity_pointer_letter](#BKMK_activity_pointer_letter)
- [activitypointer_connections1](#BKMK_activitypointer_connections1)
- [activity_pointer_phonecall](#BKMK_activity_pointer_phonecall)
- [activity_pointer_email](#BKMK_activity_pointer_email)
- [activitypointer_activity_parties](#BKMK_activitypointer_activity_parties)
- [activity_pointer_activity_mime_attachment](#BKMK_activity_pointer_activity_mime_attachment)
- [activity_pointer_appointment](#BKMK_activity_pointer_appointment)
- [activitypointer_connections2](#BKMK_activitypointer_connections2)
- [slakpiinstance_activitypointer](#BKMK_slakpiinstance_activitypointer)
- [ActivityPointer_QueueItem](#BKMK_ActivityPointer_QueueItem)
- [activity_pointer_task](#BKMK_activity_pointer_task)
- [activity_pointer_socialactivity](#BKMK_activity_pointer_socialactivity)
- [ActivityPointer_AsyncOperations](#BKMK_ActivityPointer_AsyncOperations)
- [ActivityPointer_BulkDeleteFailures](#BKMK_ActivityPointer_BulkDeleteFailures)
- [activity_pointer_recurringappointmentmaster](#BKMK_activity_pointer_recurringappointmentmaster)


### <a name="BKMK_activity_pointer_BulkOperation"></a> activity_pointer_BulkOperation

**Added by**: Marketing Solution

Same as bulkoperation entity [activity_pointer_BulkOperation](bulkoperation.md#BKMK_activity_pointer_BulkOperation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperation|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_BulkOperation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_campaignactivity"></a> activity_pointer_campaignactivity

**Added by**: Marketing Solution

Same as campaignactivity entity [activity_pointer_campaignactivity](campaignactivity.md#BKMK_activity_pointer_campaignactivity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignactivity|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_campaignactivity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_campaignresponse"></a> activity_pointer_campaignresponse

**Added by**: Marketing Solution

Same as campaignresponse entity [activity_pointer_campaignresponse](campaignresponse.md#BKMK_activity_pointer_campaignresponse) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_campaignresponse|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_BulkOperation_logs"></a> activity_pointer_BulkOperation_logs

**Added by**: Marketing Solution

Same as bulkoperationlog entity [activity_pointer_BulkOperation_logs](bulkoperationlog.md#BKMK_activity_pointer_BulkOperation_logs) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperationlog|
|ReferencingAttribute|bulkoperationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_BulkOperation_logs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_CreatedActivity_BulkOperationLogs"></a> CreatedActivity_BulkOperationLogs

**Added by**: Marketing Solution

Same as bulkoperationlog entity [CreatedActivity_BulkOperationLogs](bulkoperationlog.md#BKMK_CreatedActivity_BulkOperationLogs) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperationlog|
|ReferencingAttribute|createdobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|CreatedActivity_BulkOperationLogs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_campaignresponse"></a> activity_campaignresponse

**Added by**: Marketing Solution

Same as campaignresponse entity [activity_campaignresponse](campaignresponse.md#BKMK_activity_campaignresponse) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|originatingactivityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_campaignresponse|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_incident_resolution"></a> activity_pointer_incident_resolution

**Added by**: Service Solution

Same as incidentresolution entity [activity_pointer_incident_resolution](incidentresolution.md#BKMK_activity_pointer_incident_resolution) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_incident_resolution|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_service_appointment"></a> activity_pointer_service_appointment

**Added by**: Service Solution

Same as serviceappointment entity [activity_pointer_service_appointment](serviceappointment.md#BKMK_activity_pointer_service_appointment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_service_appointment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_opportunity_close"></a> activity_pointer_opportunity_close

**Added by**: Sales Solution

Same as opportunityclose entity [activity_pointer_opportunity_close](opportunityclose.md#BKMK_activity_pointer_opportunity_close) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_opportunity_close|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_order_close"></a> activity_pointer_order_close

**Added by**: Sales Solution

Same as orderclose entity [activity_pointer_order_close](orderclose.md#BKMK_activity_pointer_order_close) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_order_close|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_quote_close"></a> activity_pointer_quote_close

**Added by**: Sales Solution

Same as quoteclose entity [activity_pointer_quote_close](quoteclose.md#BKMK_activity_pointer_quote_close) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_quote_close|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_msdyn_bookingalert"></a> activity_pointer_msdyn_bookingalert

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [activity_pointer_msdyn_bookingalert](msdyn_bookingalert.md#BKMK_activity_pointer_msdyn_bookingalert) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|activity_pointer_msdyn_bookingalert|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_msdyn_approval"></a> activity_pointer_msdyn_approval

**Added by**: Active Solution Solution

Same as msdyn_approval entity [activity_pointer_msdyn_approval](msdyn_approval.md#BKMK_activity_pointer_msdyn_approval) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|activity_pointer_msdyn_approval|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_fax"></a> activity_pointer_fax

Same as fax entity [activity_pointer_fax](fax.md#BKMK_activity_pointer_fax) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_fax|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_recurrencerule"></a> activity_pointer_recurrencerule

Same as recurrencerule entity [activity_pointer_recurrencerule](recurrencerule.md#BKMK_activity_pointer_recurrencerule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurrencerule|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_recurrencerule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_activity_pointer_letter"></a> activity_pointer_letter

Same as letter entity [activity_pointer_letter](letter.md#BKMK_activity_pointer_letter) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_letter|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activitypointer_connections1"></a> activitypointer_connections1

Same as connection entity [activitypointer_connections1](connection.md#BKMK_activitypointer_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activitypointer_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_phonecall"></a> activity_pointer_phonecall

Same as phonecall entity [activity_pointer_phonecall](phonecall.md#BKMK_activity_pointer_phonecall) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_phonecall|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_email"></a> activity_pointer_email

Same as email entity [activity_pointer_email](email.md#BKMK_activity_pointer_email) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_email|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activitypointer_activity_parties"></a> activitypointer_activity_parties

Same as activityparty entity [activitypointer_activity_parties](activityparty.md#BKMK_activitypointer_activity_parties) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activitypointer_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_activity_mime_attachment"></a> activity_pointer_activity_mime_attachment

Same as activitymimeattachment entity [activity_pointer_activity_mime_attachment](activitymimeattachment.md#BKMK_activity_pointer_activity_mime_attachment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitymimeattachment|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_activity_mime_attachment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_appointment"></a> activity_pointer_appointment

Same as appointment entity [activity_pointer_appointment](appointment.md#BKMK_activity_pointer_appointment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_appointment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activitypointer_connections2"></a> activitypointer_connections2

Same as connection entity [activitypointer_connections2](connection.md#BKMK_activitypointer_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activitypointer_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_slakpiinstance_activitypointer"></a> slakpiinstance_activitypointer

Same as slakpiinstance entity [slakpiinstance_activitypointer](slakpiinstance.md#BKMK_slakpiinstance_activitypointer) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|slakpiinstance|
|ReferencingAttribute|regarding|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|slakpiinstance_activitypointer|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ActivityPointer_QueueItem"></a> ActivityPointer_QueueItem

Same as queueitem entity [ActivityPointer_QueueItem](queueitem.md#BKMK_ActivityPointer_QueueItem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ActivityPointer_QueueItem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_task"></a> activity_pointer_task

Same as task entity [activity_pointer_task](task.md#BKMK_activity_pointer_task) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_task|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_socialactivity"></a> activity_pointer_socialactivity

Same as socialactivity entity [activity_pointer_socialactivity](socialactivity.md#BKMK_activity_pointer_socialactivity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_socialactivity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ActivityPointer_AsyncOperations"></a> ActivityPointer_AsyncOperations

Same as asyncoperation entity [ActivityPointer_AsyncOperations](asyncoperation.md#BKMK_ActivityPointer_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ActivityPointer_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ActivityPointer_BulkDeleteFailures"></a> ActivityPointer_BulkDeleteFailures

Same as bulkdeletefailure entity [ActivityPointer_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ActivityPointer_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ActivityPointer_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_activity_pointer_recurringappointmentmaster"></a> activity_pointer_recurringappointmentmaster

Same as recurringappointmentmaster entity [activity_pointer_recurringappointmentmaster](recurringappointmentmaster.md#BKMK_activity_pointer_recurringappointmentmaster) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|activity_pointer_recurringappointmentmaster|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [Lead_ActivityPointers](#BKMK_Lead_ActivityPointers)
- [bookableresourcebooking_ActivityPointers](#BKMK_bookableresourcebooking_ActivityPointers)
- [bookableresourcebookingheader_ActivityPointers](#BKMK_bookableresourcebookingheader_ActivityPointers)
- [BulkOperation_ActivityPointers](#BKMK_BulkOperation_ActivityPointers)
- [Campaign_ActivityPointers](#BKMK_Campaign_ActivityPointers)
- [CampaignActivity_ActivityPointers](#BKMK_CampaignActivity_ActivityPointers)
- [Contract_ActivityPointers](#BKMK_Contract_ActivityPointers)
- [entitlement_ActivityPointers](#BKMK_entitlement_ActivityPointers)
- [entitlementtemplate_ActivityPointers](#BKMK_entitlementtemplate_ActivityPointers)
- [Incident_ActivityPointers](#BKMK_Incident_ActivityPointers)
- [site_ActivityPointers](#BKMK_site_ActivityPointers)
- [service_activity_pointers](#BKMK_service_activity_pointers)
- [msdyn_playbookinstance_ActivityPointers](#BKMK_msdyn_playbookinstance_ActivityPointers)
- [Invoice_ActivityPointers](#BKMK_Invoice_ActivityPointers)
- [Opportunity_ActivityPointers](#BKMK_Opportunity_ActivityPointers)
- [Quote_ActivityPointers](#BKMK_Quote_ActivityPointers)
- [SalesOrder_ActivityPointers](#BKMK_SalesOrder_ActivityPointers)
- [msdyn_postalbum_ActivityPointers](#BKMK_msdyn_postalbum_ActivityPointers)
- [msdyn_bookingalertstatus_ActivityPointers](#BKMK_msdyn_bookingalertstatus_ActivityPointers)
- [msdyn_bookingrule_ActivityPointers](#BKMK_msdyn_bookingrule_ActivityPointers)
- [msdyn_resourceterritory_ActivityPointers](#BKMK_msdyn_resourceterritory_ActivityPointers)
- [msdyn_systemuserschedulersetting_ActivityPointers](#BKMK_msdyn_systemuserschedulersetting_ActivityPointers)
- [msdyn_timegroup_ActivityPointers](#BKMK_msdyn_timegroup_ActivityPointers)
- [msdyn_timegroupdetail_ActivityPointers](#BKMK_msdyn_timegroupdetail_ActivityPointers)
- [msdyn_processnotes_ActivityPointers](#BKMK_msdyn_processnotes_ActivityPointers)
- [msdyn_projectteam_ActivityPointers](#BKMK_msdyn_projectteam_ActivityPointers)
- [msdyn_agreement_ActivityPointers](#BKMK_msdyn_agreement_ActivityPointers)
- [msdyn_agreementbookingdate_ActivityPointers](#BKMK_msdyn_agreementbookingdate_ActivityPointers)
- [msdyn_agreementbookingincident_ActivityPointers](#BKMK_msdyn_agreementbookingincident_ActivityPointers)
- [msdyn_agreementbookingproduct_ActivityPointers](#BKMK_msdyn_agreementbookingproduct_ActivityPointers)
- [msdyn_agreementbookingservice_ActivityPointers](#BKMK_msdyn_agreementbookingservice_ActivityPointers)
- [msdyn_agreementbookingservicetask_ActivityPointers](#BKMK_msdyn_agreementbookingservicetask_ActivityPointers)
- [msdyn_agreementbookingsetup_ActivityPointers](#BKMK_msdyn_agreementbookingsetup_ActivityPointers)
- [msdyn_agreementinvoicedate_ActivityPointers](#BKMK_msdyn_agreementinvoicedate_ActivityPointers)
- [msdyn_agreementinvoiceproduct_ActivityPointers](#BKMK_msdyn_agreementinvoiceproduct_ActivityPointers)
- [msdyn_agreementinvoicesetup_ActivityPointers](#BKMK_msdyn_agreementinvoicesetup_ActivityPointers)
- [msdyn_bookingtimestamp_ActivityPointers](#BKMK_msdyn_bookingtimestamp_ActivityPointers)
- [msdyn_customerasset_ActivityPointers](#BKMK_msdyn_customerasset_ActivityPointers)
- [msdyn_fieldservicesetting_ActivityPointers](#BKMK_msdyn_fieldservicesetting_ActivityPointers)
- [msdyn_incidenttypecharacteristic_ActivityPointers](#BKMK_msdyn_incidenttypecharacteristic_ActivityPointers)
- [msdyn_incidenttypeproduct_ActivityPointers](#BKMK_msdyn_incidenttypeproduct_ActivityPointers)
- [msdyn_incidenttypeservice_ActivityPointers](#BKMK_msdyn_incidenttypeservice_ActivityPointers)
- [msdyn_inventoryadjustment_ActivityPointers](#BKMK_msdyn_inventoryadjustment_ActivityPointers)
- [msdyn_inventoryadjustmentproduct_ActivityPointers](#BKMK_msdyn_inventoryadjustmentproduct_ActivityPointers)
- [msdyn_inventoryjournal_ActivityPointers](#BKMK_msdyn_inventoryjournal_ActivityPointers)
- [msdyn_inventorytransfer_ActivityPointers](#BKMK_msdyn_inventorytransfer_ActivityPointers)
- [msdyn_payment_ActivityPointers](#BKMK_msdyn_payment_ActivityPointers)
- [msdyn_paymentdetail_ActivityPointers](#BKMK_msdyn_paymentdetail_ActivityPointers)
- [msdyn_paymentmethod_ActivityPointers](#BKMK_msdyn_paymentmethod_ActivityPointers)
- [msdyn_paymentterm_ActivityPointers](#BKMK_msdyn_paymentterm_ActivityPointers)
- [msdyn_postalcode_ActivityPointers](#BKMK_msdyn_postalcode_ActivityPointers)
- [msdyn_productinventory_ActivityPointers](#BKMK_msdyn_productinventory_ActivityPointers)
- [msdyn_purchaseorder_ActivityPointers](#BKMK_msdyn_purchaseorder_ActivityPointers)
- [msdyn_purchaseorderbill_ActivityPointers](#BKMK_msdyn_purchaseorderbill_ActivityPointers)
- [msdyn_purchaseorderproduct_ActivityPointers](#BKMK_msdyn_purchaseorderproduct_ActivityPointers)
- [msdyn_purchaseorderreceipt_ActivityPointers](#BKMK_msdyn_purchaseorderreceipt_ActivityPointers)
- [msdyn_purchaseorderreceiptproduct_ActivityPointers](#BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers)
- [msdyn_purchaseordersubstatus_ActivityPointers](#BKMK_msdyn_purchaseordersubstatus_ActivityPointers)
- [msdyn_quotebookingincident_ActivityPointers](#BKMK_msdyn_quotebookingincident_ActivityPointers)
- [msdyn_quotebookingproduct_ActivityPointers](#BKMK_msdyn_quotebookingproduct_ActivityPointers)
- [msdyn_quotebookingservice_ActivityPointers](#BKMK_msdyn_quotebookingservice_ActivityPointers)
- [msdyn_quotebookingservicetask_ActivityPointers](#BKMK_msdyn_quotebookingservicetask_ActivityPointers)
- [msdyn_rma_ActivityPointers](#BKMK_msdyn_rma_ActivityPointers)
- [msdyn_rmaproduct_ActivityPointers](#BKMK_msdyn_rmaproduct_ActivityPointers)
- [msdyn_rmareceipt_ActivityPointers](#BKMK_msdyn_rmareceipt_ActivityPointers)
- [msdyn_rmareceiptproduct_ActivityPointers](#BKMK_msdyn_rmareceiptproduct_ActivityPointers)
- [msdyn_rmasubstatus_ActivityPointers](#BKMK_msdyn_rmasubstatus_ActivityPointers)
- [msdyn_rtv_ActivityPointers](#BKMK_msdyn_rtv_ActivityPointers)
- [msdyn_rtvproduct_ActivityPointers](#BKMK_msdyn_rtvproduct_ActivityPointers)
- [msdyn_rtvsubstatus_ActivityPointers](#BKMK_msdyn_rtvsubstatus_ActivityPointers)
- [msdyn_shipvia_ActivityPointers](#BKMK_msdyn_shipvia_ActivityPointers)
- [msdyn_timeoffrequest_ActivityPointers](#BKMK_msdyn_timeoffrequest_ActivityPointers)
- [msdyn_warehouse_ActivityPointers](#BKMK_msdyn_warehouse_ActivityPointers)
- [msdyn_workorder_ActivityPointers](#BKMK_msdyn_workorder_ActivityPointers)
- [msdyn_workordercharacteristic_ActivityPointers](#BKMK_msdyn_workordercharacteristic_ActivityPointers)
- [msdyn_workorderincident_ActivityPointers](#BKMK_msdyn_workorderincident_ActivityPointers)
- [msdyn_workorderproduct_ActivityPointers](#BKMK_msdyn_workorderproduct_ActivityPointers)
- [msdyn_workorderresourcerestriction_ActivityPointers](#BKMK_msdyn_workorderresourcerestriction_ActivityPointers)
- [msdyn_workorderservice_ActivityPointers](#BKMK_msdyn_workorderservice_ActivityPointers)
- [msdyn_workorderservicetask_ActivityPointers](#BKMK_msdyn_workorderservicetask_ActivityPointers)
- [interactionforemail_ActivityPointers](#BKMK_interactionforemail_ActivityPointers)
- [KnowledgeBaseRecord_ActivityPointers](#BKMK_KnowledgeBaseRecord_ActivityPointers)
- [KnowledgeArticle_ActivityPointers](#BKMK_KnowledgeArticle_ActivityPointers)
- [activitypointer_sendermailboxid_mailbox](#BKMK_activitypointer_sendermailboxid_mailbox)
- [lk_activitypointer_createdonbehalfby](#BKMK_lk_activitypointer_createdonbehalfby)
- [Contact_ActivityPointers](#BKMK_Contact_ActivityPointers)
- [lk_activitypointer_modifiedonbehalfby](#BKMK_lk_activitypointer_modifiedonbehalfby)
- [TransactionCurrency_ActivityPointer](#BKMK_TransactionCurrency_ActivityPointer)
- [sla_activitypointer](#BKMK_sla_activitypointer)
- [business_unit_activitypointer](#BKMK_business_unit_activitypointer)
- [Account_ActivityPointers](#BKMK_Account_ActivityPointers)
- [manualsla_activitypointer](#BKMK_manualsla_activitypointer)
- [team_activity](#BKMK_team_activity)
- [lk_activitypointer_modifiedby](#BKMK_lk_activitypointer_modifiedby)
- [lk_activitypointer_createdby](#BKMK_lk_activitypointer_createdby)
- [user_activity](#BKMK_user_activity)


### <a name="BKMK_Lead_ActivityPointers"></a> Lead_ActivityPointers

**Added by**: Lead Management Solution

See lead Entity [Lead_ActivityPointers](lead.md#BKMK_Lead_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_ActivityPointers"></a> bookableresourcebooking_ActivityPointers

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [bookableresourcebooking_ActivityPointers](bookableresourcebooking.md#BKMK_bookableresourcebooking_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_ActivityPointers"></a> bookableresourcebookingheader_ActivityPointers

**Added by**: Scheduling Solution

See bookableresourcebookingheader Entity [bookableresourcebookingheader_ActivityPointers](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_BulkOperation_ActivityPointers"></a> BulkOperation_ActivityPointers

**Added by**: Marketing Solution

See bulkoperation Entity [BulkOperation_ActivityPointers](bulkoperation.md#BKMK_BulkOperation_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_Campaign_ActivityPointers"></a> Campaign_ActivityPointers

**Added by**: Marketing Solution

See campaign Entity [Campaign_ActivityPointers](campaign.md#BKMK_Campaign_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_ActivityPointers"></a> CampaignActivity_ActivityPointers

**Added by**: Marketing Solution

See campaignactivity Entity [CampaignActivity_ActivityPointers](campaignactivity.md#BKMK_CampaignActivity_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_Contract_ActivityPointers"></a> Contract_ActivityPointers

**Added by**: Service Solution

See contract Entity [Contract_ActivityPointers](contract.md#BKMK_Contract_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_entitlement_ActivityPointers"></a> entitlement_ActivityPointers

**Added by**: Service Solution

See entitlement Entity [entitlement_ActivityPointers](entitlement.md#BKMK_entitlement_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_ActivityPointers"></a> entitlementtemplate_ActivityPointers

**Added by**: Service Solution

See entitlementtemplate Entity [entitlementtemplate_ActivityPointers](entitlementtemplate.md#BKMK_entitlementtemplate_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_Incident_ActivityPointers"></a> Incident_ActivityPointers

**Added by**: Service Solution

See incident Entity [Incident_ActivityPointers](incident.md#BKMK_Incident_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_site_ActivityPointers"></a> site_ActivityPointers

**Added by**: Service Solution

See site Entity [site_ActivityPointers](site.md#BKMK_site_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_service_activity_pointers"></a> service_activity_pointers

**Added by**: Service Solution

See service Entity [service_activity_pointers](service.md#BKMK_service_activity_pointers) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_ActivityPointers"></a> msdyn_playbookinstance_ActivityPointers

**Added by**: Playbook Solution

See msdyn_playbookinstance Entity [msdyn_playbookinstance_ActivityPointers](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_Invoice_ActivityPointers"></a> Invoice_ActivityPointers

**Added by**: Sales Solution

See invoice Entity [Invoice_ActivityPointers](invoice.md#BKMK_Invoice_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_Opportunity_ActivityPointers"></a> Opportunity_ActivityPointers

**Added by**: Sales Solution

See opportunity Entity [Opportunity_ActivityPointers](opportunity.md#BKMK_Opportunity_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_Quote_ActivityPointers"></a> Quote_ActivityPointers

**Added by**: Sales Solution

See quote Entity [Quote_ActivityPointers](quote.md#BKMK_Quote_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_SalesOrder_ActivityPointers"></a> SalesOrder_ActivityPointers

**Added by**: Sales Solution

See salesorder Entity [SalesOrder_ActivityPointers](salesorder.md#BKMK_SalesOrder_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_ActivityPointers"></a> msdyn_postalbum_ActivityPointers

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_ActivityPointers](msdyn_postalbum.md#BKMK_msdyn_postalbum_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_ActivityPointers"></a> msdyn_bookingalertstatus_ActivityPointers

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_ActivityPointers](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_ActivityPointers"></a> msdyn_bookingrule_ActivityPointers

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_ActivityPointers](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_ActivityPointers"></a> msdyn_resourceterritory_ActivityPointers

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_ActivityPointers](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_ActivityPointers"></a> msdyn_systemuserschedulersetting_ActivityPointers

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_ActivityPointers](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_ActivityPointers"></a> msdyn_timegroup_ActivityPointers

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_ActivityPointers](msdyn_timegroup.md#BKMK_msdyn_timegroup_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_ActivityPointers"></a> msdyn_timegroupdetail_ActivityPointers

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_ActivityPointers](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_ActivityPointers"></a> msdyn_processnotes_ActivityPointers

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_ActivityPointers](msdyn_processnotes.md#BKMK_msdyn_processnotes_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_ActivityPointers"></a> msdyn_projectteam_ActivityPointers

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_ActivityPointers](msdyn_projectteam.md#BKMK_msdyn_projectteam_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_ActivityPointers"></a> msdyn_agreement_ActivityPointers

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_ActivityPointers](msdyn_agreement.md#BKMK_msdyn_agreement_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_ActivityPointers"></a> msdyn_agreementbookingdate_ActivityPointers

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_ActivityPointers](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_ActivityPointers"></a> msdyn_agreementbookingincident_ActivityPointers

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_ActivityPointers](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_ActivityPointers"></a> msdyn_agreementbookingproduct_ActivityPointers

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_ActivityPointers](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_ActivityPointers"></a> msdyn_agreementbookingservice_ActivityPointers

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_ActivityPointers](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_ActivityPointers"></a> msdyn_agreementbookingservicetask_ActivityPointers

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_ActivityPointers](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_ActivityPointers"></a> msdyn_agreementbookingsetup_ActivityPointers

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_ActivityPointers](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_ActivityPointers"></a> msdyn_agreementinvoicedate_ActivityPointers

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_ActivityPointers](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_ActivityPointers"></a> msdyn_agreementinvoiceproduct_ActivityPointers

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_ActivityPointers](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_ActivityPointers"></a> msdyn_agreementinvoicesetup_ActivityPointers

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_ActivityPointers](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_ActivityPointers"></a> msdyn_bookingtimestamp_ActivityPointers

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_ActivityPointers](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_ActivityPointers"></a> msdyn_customerasset_ActivityPointers

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_ActivityPointers](msdyn_customerasset.md#BKMK_msdyn_customerasset_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_ActivityPointers"></a> msdyn_fieldservicesetting_ActivityPointers

**Added by**: Field Service Solution

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_ActivityPointers](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_ActivityPointers"></a> msdyn_incidenttypecharacteristic_ActivityPointers

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_ActivityPointers](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_ActivityPointers"></a> msdyn_incidenttypeproduct_ActivityPointers

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_ActivityPointers](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_ActivityPointers"></a> msdyn_incidenttypeservice_ActivityPointers

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_ActivityPointers](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_ActivityPointers"></a> msdyn_inventoryadjustment_ActivityPointers

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_ActivityPointers](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_ActivityPointers"></a> msdyn_inventoryadjustmentproduct_ActivityPointers

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_ActivityPointers](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_ActivityPointers"></a> msdyn_inventoryjournal_ActivityPointers

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_ActivityPointers](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_ActivityPointers"></a> msdyn_inventorytransfer_ActivityPointers

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_ActivityPointers](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_ActivityPointers"></a> msdyn_payment_ActivityPointers

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_ActivityPointers](msdyn_payment.md#BKMK_msdyn_payment_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_ActivityPointers"></a> msdyn_paymentdetail_ActivityPointers

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_ActivityPointers](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_ActivityPointers"></a> msdyn_paymentmethod_ActivityPointers

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_ActivityPointers](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_ActivityPointers"></a> msdyn_paymentterm_ActivityPointers

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_ActivityPointers](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_ActivityPointers"></a> msdyn_postalcode_ActivityPointers

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_ActivityPointers](msdyn_postalcode.md#BKMK_msdyn_postalcode_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_ActivityPointers"></a> msdyn_productinventory_ActivityPointers

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_ActivityPointers](msdyn_productinventory.md#BKMK_msdyn_productinventory_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_ActivityPointers"></a> msdyn_purchaseorder_ActivityPointers

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_ActivityPointers](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_ActivityPointers"></a> msdyn_purchaseorderbill_ActivityPointers

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_ActivityPointers](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_ActivityPointers"></a> msdyn_purchaseorderproduct_ActivityPointers

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_ActivityPointers](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_ActivityPointers"></a> msdyn_purchaseorderreceipt_ActivityPointers

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_ActivityPointers](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers"></a> msdyn_purchaseorderreceiptproduct_ActivityPointers

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_ActivityPointers](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_ActivityPointers"></a> msdyn_purchaseordersubstatus_ActivityPointers

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_ActivityPointers](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_ActivityPointers"></a> msdyn_quotebookingincident_ActivityPointers

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_ActivityPointers](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_ActivityPointers"></a> msdyn_quotebookingproduct_ActivityPointers

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_ActivityPointers](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_ActivityPointers"></a> msdyn_quotebookingservice_ActivityPointers

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_ActivityPointers](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_ActivityPointers"></a> msdyn_quotebookingservicetask_ActivityPointers

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_ActivityPointers](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_ActivityPointers"></a> msdyn_rma_ActivityPointers

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_ActivityPointers](msdyn_rma.md#BKMK_msdyn_rma_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_ActivityPointers"></a> msdyn_rmaproduct_ActivityPointers

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_ActivityPointers](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_ActivityPointers"></a> msdyn_rmareceipt_ActivityPointers

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_ActivityPointers](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_ActivityPointers"></a> msdyn_rmareceiptproduct_ActivityPointers

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_ActivityPointers](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_ActivityPointers"></a> msdyn_rmasubstatus_ActivityPointers

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_ActivityPointers](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_ActivityPointers"></a> msdyn_rtv_ActivityPointers

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_ActivityPointers](msdyn_rtv.md#BKMK_msdyn_rtv_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_ActivityPointers"></a> msdyn_rtvproduct_ActivityPointers

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_ActivityPointers](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_ActivityPointers"></a> msdyn_rtvsubstatus_ActivityPointers

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_ActivityPointers](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_ActivityPointers"></a> msdyn_shipvia_ActivityPointers

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_ActivityPointers](msdyn_shipvia.md#BKMK_msdyn_shipvia_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_ActivityPointers"></a> msdyn_timeoffrequest_ActivityPointers

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_ActivityPointers](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_ActivityPointers"></a> msdyn_warehouse_ActivityPointers

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_ActivityPointers](msdyn_warehouse.md#BKMK_msdyn_warehouse_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_ActivityPointers"></a> msdyn_workorder_ActivityPointers

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_ActivityPointers](msdyn_workorder.md#BKMK_msdyn_workorder_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_ActivityPointers"></a> msdyn_workordercharacteristic_ActivityPointers

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_ActivityPointers](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_ActivityPointers"></a> msdyn_workorderincident_ActivityPointers

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_ActivityPointers](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_ActivityPointers"></a> msdyn_workorderproduct_ActivityPointers

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_ActivityPointers](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_ActivityPointers"></a> msdyn_workorderresourcerestriction_ActivityPointers

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_ActivityPointers](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_ActivityPointers"></a> msdyn_workorderservice_ActivityPointers

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_ActivityPointers](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_ActivityPointers"></a> msdyn_workorderservicetask_ActivityPointers

**Added by**: Field Service Solution

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_ActivityPointers](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_interactionforemail_ActivityPointers"></a> interactionforemail_ActivityPointers

See interactionforemail Entity [interactionforemail_ActivityPointers](interactionforemail.md#BKMK_interactionforemail_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_ActivityPointers"></a> KnowledgeBaseRecord_ActivityPointers

See knowledgebaserecord Entity [KnowledgeBaseRecord_ActivityPointers](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticle_ActivityPointers"></a> KnowledgeArticle_ActivityPointers

See knowledgearticle Entity [KnowledgeArticle_ActivityPointers](knowledgearticle.md#BKMK_KnowledgeArticle_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_activitypointer_sendermailboxid_mailbox"></a> activitypointer_sendermailboxid_mailbox

See mailbox Entity [activitypointer_sendermailboxid_mailbox](mailbox.md#BKMK_activitypointer_sendermailboxid_mailbox) One-To-Many relationship.

### <a name="BKMK_lk_activitypointer_createdonbehalfby"></a> lk_activitypointer_createdonbehalfby

See systemuser Entity [lk_activitypointer_createdonbehalfby](systemuser.md#BKMK_lk_activitypointer_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_Contact_ActivityPointers"></a> Contact_ActivityPointers

See contact Entity [Contact_ActivityPointers](contact.md#BKMK_Contact_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_lk_activitypointer_modifiedonbehalfby"></a> lk_activitypointer_modifiedonbehalfby

See systemuser Entity [lk_activitypointer_modifiedonbehalfby](systemuser.md#BKMK_lk_activitypointer_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_ActivityPointer"></a> TransactionCurrency_ActivityPointer

See transactioncurrency Entity [TransactionCurrency_ActivityPointer](transactioncurrency.md#BKMK_TransactionCurrency_ActivityPointer) One-To-Many relationship.

### <a name="BKMK_sla_activitypointer"></a> sla_activitypointer

See sla Entity [sla_activitypointer](sla.md#BKMK_sla_activitypointer) One-To-Many relationship.

### <a name="BKMK_business_unit_activitypointer"></a> business_unit_activitypointer

See businessunit Entity [business_unit_activitypointer](businessunit.md#BKMK_business_unit_activitypointer) One-To-Many relationship.

### <a name="BKMK_Account_ActivityPointers"></a> Account_ActivityPointers

See account Entity [Account_ActivityPointers](account.md#BKMK_Account_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_manualsla_activitypointer"></a> manualsla_activitypointer

See sla Entity [manualsla_activitypointer](sla.md#BKMK_manualsla_activitypointer) One-To-Many relationship.

### <a name="BKMK_team_activity"></a> team_activity

See team Entity [team_activity](team.md#BKMK_team_activity) One-To-Many relationship.

### <a name="BKMK_lk_activitypointer_modifiedby"></a> lk_activitypointer_modifiedby

See systemuser Entity [lk_activitypointer_modifiedby](systemuser.md#BKMK_lk_activitypointer_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_activitypointer_createdby"></a> lk_activitypointer_createdby

See systemuser Entity [lk_activitypointer_createdby](systemuser.md#BKMK_lk_activitypointer_createdby) One-To-Many relationship.

### <a name="BKMK_user_activity"></a> user_activity

See systemuser Entity [user_activity](systemuser.md#BKMK_user_activity) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.activitypointer?text=activitypointer EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]