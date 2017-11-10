---
title: "ActivityPointer Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ActivityPointer entity."
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
# ActivityPointer Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/activitypointers(*activityid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/activitypointers<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Rollup|<xref href="Microsoft.Dynamics.CRM.Rollup?text=Rollup Function" />|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|

## Properties

**DisplayName**: Activity<br />
**DisplayCollectionName**: Activities<br />
**SchemaName**: ActivityPointer<br />
**CollectionSchemaName**: ActivityPointers<br />
**LogicalName**: activitypointer<br />
**LogicalCollectionName**: activitypointers<br />
**EntitySetName**: activitypointers<br />
**PrimaryIdAttribute**: activityid<br />
**PrimaryNameAttribute**: subject<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
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

**Description**: Additional information provided by the external application as JSON. For internal use only.<br />
**DisplayName**: Activity Additional Parameters<br />
**LogicalName**: activityadditionalparams<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 8192


### <a name="BKMK_ActivityId"></a> ActivityId

**Description**: Unique identifier of the activity.<br />
**DisplayName**: Activity<br />
**LogicalName**: activityid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

**Description**: Actual duration of the activity in minutes.<br />
**DisplayName**: Actual Duration<br />
**LogicalName**: actualdurationminutes<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_ActualEnd"></a> ActualEnd

**Description**: Actual end time of the activity.<br />
**DisplayName**: Actual End<br />
**LogicalName**: actualend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ActualStart"></a> ActualStart

**Description**: Actual start time of the activity.<br />
**DisplayName**: Actual Start<br />
**LogicalName**: actualstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_Community"></a> Community

**Description**: Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.<br />
**DisplayName**: Social Channel<br />
**LogicalName**: community<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Other
- **Value**: 1 **Label**: Facebook
- **Value**: 2 **Label**: Twitter



### <a name="BKMK_DeliveryPriorityCode"></a> DeliveryPriorityCode

**Description**: Priority of delivery of the activity to the email server.<br />
**DisplayName**: Delivery Priority<br />
**LogicalName**: deliveryprioritycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Low
- **Value**: 1 **Label**: Normal
- **Value**: 2 **Label**: High



### <a name="BKMK_Description"></a> Description

**Description**: Description of the activity.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_ExchangeItemId"></a> ExchangeItemId

**Description**: The message id of activity which is returned from Exchange Server.<br />
**DisplayName**: Exchange Item ID<br />
**LogicalName**: exchangeitemid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_ExchangeWebLink"></a> ExchangeWebLink

**Description**: Shows the web link of Activity of type email.<br />
**DisplayName**: Exchange WebLink<br />
**LogicalName**: exchangeweblink<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


### <a name="BKMK_IsBilled"></a> IsBilled

**Description**: Information regarding whether the activity was billed as part of resolving a case.<br />
**DisplayName**: Is Billed<br />
**LogicalName**: isbilled<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsMapiPrivate"></a> IsMapiPrivate

**Description**: For internal use only.<br />
**DisplayName**: Is Private<br />
**LogicalName**: ismapiprivate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

**Description**: Information regarding whether the activity was created from a workflow rule.<br />
**DisplayName**: Is Workflow Created<br />
**LogicalName**: isworkflowcreated<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_LastOnHoldTime"></a> LastOnHoldTime

**Description**: Contains the date and time stamp of the last on hold time.<br />
**DisplayName**: Last On Hold Time<br />
**LogicalName**: lastonholdtime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_LeftVoiceMail"></a> LeftVoiceMail

**Description**: Left the voice mail<br />
**DisplayName**: Left Voice Mail<br />
**LogicalName**: leftvoicemail<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Unique identifier of the user or team who owns the activity.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_PriorityCode"></a> PriorityCode

**Description**: Priority of the activity.<br />
**DisplayName**: Priority<br />
**LogicalName**: prioritycode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Low
- **Value**: 1 **Label**: Normal
- **Value**: 2 **Label**: High



### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Unique identifier of the Process.<br />
**DisplayName**: Process<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Unique identifier of the object with which the activity is associated.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,entitlementtemplate,incident,interactionforemail,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 400


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 400


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

**Description**: Scheduled duration of the activity, specified in minutes.<br />
**DisplayName**: Scheduled Duration<br />
**LogicalName**: scheduleddurationminutes<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

**Description**: Scheduled end time of the activity.<br />
**DisplayName**: Due Date<br />
**LogicalName**: scheduledend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

**Description**: Scheduled start time of the activity.<br />
**DisplayName**: Start Date<br />
**LogicalName**: scheduledstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ServiceId"></a> ServiceId

**Description**: Unique identifier of an associated service.<br />
**DisplayName**: Service<br />
**LogicalName**: serviceid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: service


### <a name="BKMK_SLAId"></a> SLAId

**Description**: Choose the service level agreement (SLA) that you want to apply to the case record.<br />
**DisplayName**: SLA<br />
**LogicalName**: slaid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: sla


### <a name="BKMK_SortDate"></a> SortDate

**Description**: Shows the date and time by which the activities are sorted.<br />
**DisplayName**: Sort Date<br />
**LogicalName**: sortdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_StageId"></a> StageId

**Description**: Unique identifier of the Stage.<br />
**DisplayName**: Process Stage<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Status of the activity.<br />
**DisplayName**: Activity Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Open **DefaultStatus**: 1 **InvariantName**: Open
- **Value**: 1 **Label**: Completed **DefaultStatus**: 2 **InvariantName**: Completed
- **Value**: 2 **Label**: Canceled **DefaultStatus**: 3 **InvariantName**: Canceled
- **Value**: 3 **Label**: Scheduled **DefaultStatus**: 4 **InvariantName**: Scheduled



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Reason for the status of the activity.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Open **State**: 0
- **Value**: 2 **Label**: Completed **State**: 1
- **Value**: 3 **Label**: Canceled **State**: 2
- **Value**: 4 **Label**: Scheduled **State**: 3



### <a name="BKMK_Subject"></a> Subject

**Description**: Subject associated with the activity.<br />
**DisplayName**: Subject<br />
**LogicalName**: subject<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Unique identifier of the currency associated with the activitypointer.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Description**: For internal use only.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


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

**Description**: Type of activity.<br />
**DisplayName**: Activity Type<br />
**LogicalName**: activitytypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_allparties"></a> allparties

**Description**: All activity parties associated with this activity.<br />
**DisplayName**: All Activity Parties<br />
**LogicalName**: allparties<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: PartyList<br />
**Targets**: account,contact,equipment,lead,queue,systemuser,team


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the activity.<br />
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

**Description**: Date and time when the activity was created.<br />
**DisplayName**: Date Created<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the activitypointer.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
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


### <a name="BKMK_DeliveryLastAttemptedOn"></a> DeliveryLastAttemptedOn

**Description**: Date and time when the delivery of the activity was last attempted.<br />
**DisplayName**: Date Delivery Last Attempted<br />
**LogicalName**: deliverylastattemptedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Exchange rate for the currency associated with the activitypointer with respect to the base currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_InstanceTypeCode"></a> InstanceTypeCode

**Description**: Type of instance of a recurring series.<br />
**DisplayName**: Recurring Instance Type<br />
**LogicalName**: instancetypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Not Recurring
- **Value**: 1 **Label**: Recurring Master
- **Value**: 2 **Label**: Recurring Instance
- **Value**: 3 **Label**: Recurring Exception
- **Value**: 4 **Label**: Recurring Future Exception



### <a name="BKMK_IsRegularActivity"></a> IsRegularActivity

**Description**: Information regarding whether the activity is a regular activity type or event type.<br />
**DisplayName**: Is Regular Activity<br />
**LogicalName**: isregularactivity<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of user who last modified the activity.<br />
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

**Description**: Date and time when activity was last modified.<br />
**DisplayName**: Last Updated<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the activitypointer.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
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


### <a name="BKMK_OnHoldTime"></a> OnHoldTime

**Description**: Shows how long, in minutes, that the record was on hold.<br />
**DisplayName**: On Hold Time (Minutes)<br />
**LogicalName**: onholdtime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier of the business unit that owns the activity.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team that owns the activity.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user that owns the activity.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_PostponeActivityProcessingUntil"></a> PostponeActivityProcessingUntil

**Description**: For internal use only.<br />
**DisplayName**: Delay activity processing until<br />
**LogicalName**: postponeactivityprocessinguntil<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_SenderMailboxId"></a> SenderMailboxId

**Description**: Unique identifier of the mailbox associated with the sender of the email message.<br />
**DisplayName**: Sender's Mailbox<br />
**LogicalName**: sendermailboxid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: mailbox


### <a name="BKMK_SenderMailboxIdName"></a> SenderMailboxIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: sendermailboxidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SentOn"></a> SentOn

**Description**: Date and time when the activity was sent.<br />
**DisplayName**: Date Sent<br />
**LogicalName**: senton<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_SeriesId"></a> SeriesId

**Description**: Uniqueidentifier specifying the id of recurring series of an instance.<br />
**DisplayName**: Series Id<br />
**LogicalName**: seriesid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ServiceIdName"></a> ServiceIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: serviceidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

**Description**: Last SLA that was applied to this case. This field is for internal use only.<br />
**DisplayName**: Last SLA applied<br />
**LogicalName**: slainvokedid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: sla


### <a name="BKMK_SLAInvokedIdName"></a> SLAInvokedIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: slainvokedidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SLAName"></a> SLAName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: slaname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

**Description**: Version number of the activity.<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [activity_pointer_BulkOperation](#BKMK_activity_pointer_BulkOperation)
- [activity_pointer_campaignactivity](#BKMK_activity_pointer_campaignactivity)
- [activity_pointer_campaignresponse](#BKMK_activity_pointer_campaignresponse)
- [activity_pointer_BulkOperation_logs](#BKMK_activity_pointer_BulkOperation_logs)
- [CreatedActivity_BulkOperationLogs](#BKMK_CreatedActivity_BulkOperationLogs)
- [ActivityPointer_CampaignActivityItems](#BKMK_ActivityPointer_CampaignActivityItems)
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

Same as bulkoperation entity [activity_pointer_BulkOperation](bulkoperation.md#BKMK_activity_pointer_BulkOperation) Many-To-One relationship.

**ReferencingEntity**: bulkoperation<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_BulkOperation<br />
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


### <a name="BKMK_activity_pointer_campaignactivity"></a> activity_pointer_campaignactivity

Same as campaignactivity entity [activity_pointer_campaignactivity](campaignactivity.md#BKMK_activity_pointer_campaignactivity) Many-To-One relationship.

**ReferencingEntity**: campaignactivity<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_campaignactivity<br />
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


### <a name="BKMK_activity_pointer_campaignresponse"></a> activity_pointer_campaignresponse

Same as campaignresponse entity [activity_pointer_campaignresponse](campaignresponse.md#BKMK_activity_pointer_campaignresponse) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_campaignresponse<br />
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


### <a name="BKMK_activity_pointer_BulkOperation_logs"></a> activity_pointer_BulkOperation_logs

Same as bulkoperationlog entity [activity_pointer_BulkOperation_logs](bulkoperationlog.md#BKMK_activity_pointer_BulkOperation_logs) Many-To-One relationship.

**ReferencingEntity**: bulkoperationlog<br />
**ReferencingAttribute**: bulkoperationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_BulkOperation_logs<br />
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


### <a name="BKMK_CreatedActivity_BulkOperationLogs"></a> CreatedActivity_BulkOperationLogs

Same as bulkoperationlog entity [CreatedActivity_BulkOperationLogs](bulkoperationlog.md#BKMK_CreatedActivity_BulkOperationLogs) Many-To-One relationship.

**ReferencingEntity**: bulkoperationlog<br />
**ReferencingAttribute**: createdobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: CreatedActivity_BulkOperationLogs<br />
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


### <a name="BKMK_ActivityPointer_CampaignActivityItems"></a> ActivityPointer_CampaignActivityItems

Same as campaignactivityitem entity [ActivityPointer_CampaignActivityItems](campaignactivityitem.md#BKMK_ActivityPointer_CampaignActivityItems) Many-To-One relationship.

**ReferencingEntity**: campaignactivityitem<br />
**ReferencingAttribute**: campaignactivityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ActivityPointer_CampaignActivityItems<br />
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


### <a name="BKMK_activity_campaignresponse"></a> activity_campaignresponse

Same as campaignresponse entity [activity_campaignresponse](campaignresponse.md#BKMK_activity_campaignresponse) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: originatingactivityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_campaignresponse<br />
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


### <a name="BKMK_activity_pointer_incident_resolution"></a> activity_pointer_incident_resolution

Same as incidentresolution entity [activity_pointer_incident_resolution](incidentresolution.md#BKMK_activity_pointer_incident_resolution) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_incident_resolution<br />
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


### <a name="BKMK_activity_pointer_service_appointment"></a> activity_pointer_service_appointment

Same as serviceappointment entity [activity_pointer_service_appointment](serviceappointment.md#BKMK_activity_pointer_service_appointment) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_service_appointment<br />
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


### <a name="BKMK_activity_pointer_opportunity_close"></a> activity_pointer_opportunity_close

Same as opportunityclose entity [activity_pointer_opportunity_close](opportunityclose.md#BKMK_activity_pointer_opportunity_close) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_opportunity_close<br />
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


### <a name="BKMK_activity_pointer_order_close"></a> activity_pointer_order_close

Same as orderclose entity [activity_pointer_order_close](orderclose.md#BKMK_activity_pointer_order_close) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_order_close<br />
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


### <a name="BKMK_activity_pointer_quote_close"></a> activity_pointer_quote_close

Same as quoteclose entity [activity_pointer_quote_close](quoteclose.md#BKMK_activity_pointer_quote_close) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_quote_close<br />
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


### <a name="BKMK_activity_pointer_msdyn_bookingalert"></a> activity_pointer_msdyn_bookingalert

Same as msdyn_bookingalert entity [activity_pointer_msdyn_bookingalert](msdyn_bookingalert.md#BKMK_activity_pointer_msdyn_bookingalert) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_msdyn_bookingalert<br />
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


### <a name="BKMK_activity_pointer_msdyn_approval"></a> activity_pointer_msdyn_approval

Same as msdyn_approval entity [activity_pointer_msdyn_approval](msdyn_approval.md#BKMK_activity_pointer_msdyn_approval) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_msdyn_approval<br />
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


### <a name="BKMK_activity_pointer_fax"></a> activity_pointer_fax

Same as fax entity [activity_pointer_fax](fax.md#BKMK_activity_pointer_fax) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_fax<br />
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


### <a name="BKMK_activity_pointer_recurrencerule"></a> activity_pointer_recurrencerule

Same as recurrencerule entity [activity_pointer_recurrencerule](recurrencerule.md#BKMK_activity_pointer_recurrencerule) Many-To-One relationship.

**ReferencingEntity**: recurrencerule<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_recurrencerule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_activity_pointer_letter"></a> activity_pointer_letter

Same as letter entity [activity_pointer_letter](letter.md#BKMK_activity_pointer_letter) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_letter<br />
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


### <a name="BKMK_activitypointer_connections1"></a> activitypointer_connections1

Same as connection entity [activitypointer_connections1](connection.md#BKMK_activitypointer_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activitypointer_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_activity_pointer_phonecall"></a> activity_pointer_phonecall

Same as phonecall entity [activity_pointer_phonecall](phonecall.md#BKMK_activity_pointer_phonecall) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_phonecall<br />
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


### <a name="BKMK_activity_pointer_email"></a> activity_pointer_email

Same as email entity [activity_pointer_email](email.md#BKMK_activity_pointer_email) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_email<br />
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


### <a name="BKMK_activitypointer_activity_parties"></a> activitypointer_activity_parties

Same as activityparty entity [activitypointer_activity_parties](activityparty.md#BKMK_activitypointer_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activitypointer_activity_parties<br />
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


### <a name="BKMK_activity_pointer_activity_mime_attachment"></a> activity_pointer_activity_mime_attachment

Same as activitymimeattachment entity [activity_pointer_activity_mime_attachment](activitymimeattachment.md#BKMK_activity_pointer_activity_mime_attachment) Many-To-One relationship.

**ReferencingEntity**: activitymimeattachment<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_activity_mime_attachment<br />
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


### <a name="BKMK_activity_pointer_appointment"></a> activity_pointer_appointment

Same as appointment entity [activity_pointer_appointment](appointment.md#BKMK_activity_pointer_appointment) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_appointment<br />
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


### <a name="BKMK_activitypointer_connections2"></a> activitypointer_connections2

Same as connection entity [activitypointer_connections2](connection.md#BKMK_activitypointer_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activitypointer_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_slakpiinstance_activitypointer"></a> slakpiinstance_activitypointer

Same as slakpiinstance entity [slakpiinstance_activitypointer](slakpiinstance.md#BKMK_slakpiinstance_activitypointer) Many-To-One relationship.

**ReferencingEntity**: slakpiinstance<br />
**ReferencingAttribute**: regarding<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: slakpiinstance_activitypointer<br />
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


### <a name="BKMK_ActivityPointer_QueueItem"></a> ActivityPointer_QueueItem

Same as queueitem entity [ActivityPointer_QueueItem](queueitem.md#BKMK_ActivityPointer_QueueItem) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ActivityPointer_QueueItem<br />
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


### <a name="BKMK_activity_pointer_task"></a> activity_pointer_task

Same as task entity [activity_pointer_task](task.md#BKMK_activity_pointer_task) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_task<br />
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


### <a name="BKMK_activity_pointer_socialactivity"></a> activity_pointer_socialactivity

Same as socialactivity entity [activity_pointer_socialactivity](socialactivity.md#BKMK_activity_pointer_socialactivity) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_socialactivity<br />
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


### <a name="BKMK_ActivityPointer_AsyncOperations"></a> ActivityPointer_AsyncOperations

Same as asyncoperation entity [ActivityPointer_AsyncOperations](asyncoperation.md#BKMK_ActivityPointer_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ActivityPointer_AsyncOperations<br />
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


### <a name="BKMK_ActivityPointer_BulkDeleteFailures"></a> ActivityPointer_BulkDeleteFailures

Same as bulkdeletefailure entity [ActivityPointer_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ActivityPointer_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ActivityPointer_BulkDeleteFailures<br />
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


### <a name="BKMK_activity_pointer_recurringappointmentmaster"></a> activity_pointer_recurringappointmentmaster

Same as recurringappointmentmaster entity [activity_pointer_recurringappointmentmaster](recurringappointmentmaster.md#BKMK_activity_pointer_recurringappointmentmaster) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: activity_pointer_recurringappointmentmaster<br />
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

See lead Entity [Lead_ActivityPointers](lead.md#BKMK_Lead_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_ActivityPointers"></a> bookableresourcebooking_ActivityPointers

See bookableresourcebooking Entity [bookableresourcebooking_ActivityPointers](bookableresourcebooking.md#BKMK_bookableresourcebooking_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_ActivityPointers"></a> bookableresourcebookingheader_ActivityPointers

See bookableresourcebookingheader Entity [bookableresourcebookingheader_ActivityPointers](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_BulkOperation_ActivityPointers"></a> BulkOperation_ActivityPointers

See bulkoperation Entity [BulkOperation_ActivityPointers](bulkoperation.md#BKMK_BulkOperation_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_Campaign_ActivityPointers"></a> Campaign_ActivityPointers

See campaign Entity [Campaign_ActivityPointers](campaign.md#BKMK_Campaign_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_ActivityPointers"></a> CampaignActivity_ActivityPointers

See campaignactivity Entity [CampaignActivity_ActivityPointers](campaignactivity.md#BKMK_CampaignActivity_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_Contract_ActivityPointers"></a> Contract_ActivityPointers

See contract Entity [Contract_ActivityPointers](contract.md#BKMK_Contract_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_entitlement_ActivityPointers"></a> entitlement_ActivityPointers

See entitlement Entity [entitlement_ActivityPointers](entitlement.md#BKMK_entitlement_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_ActivityPointers"></a> entitlementtemplate_ActivityPointers

See entitlementtemplate Entity [entitlementtemplate_ActivityPointers](entitlementtemplate.md#BKMK_entitlementtemplate_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_Incident_ActivityPointers"></a> Incident_ActivityPointers

See incident Entity [Incident_ActivityPointers](incident.md#BKMK_Incident_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_site_ActivityPointers"></a> site_ActivityPointers

See site Entity [site_ActivityPointers](site.md#BKMK_site_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_service_activity_pointers"></a> service_activity_pointers

See service Entity [service_activity_pointers](service.md#BKMK_service_activity_pointers) One-To-Many relationship.

### <a name="BKMK_Invoice_ActivityPointers"></a> Invoice_ActivityPointers

See invoice Entity [Invoice_ActivityPointers](invoice.md#BKMK_Invoice_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_Opportunity_ActivityPointers"></a> Opportunity_ActivityPointers

See opportunity Entity [Opportunity_ActivityPointers](opportunity.md#BKMK_Opportunity_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_Quote_ActivityPointers"></a> Quote_ActivityPointers

See quote Entity [Quote_ActivityPointers](quote.md#BKMK_Quote_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_SalesOrder_ActivityPointers"></a> SalesOrder_ActivityPointers

See salesorder Entity [SalesOrder_ActivityPointers](salesorder.md#BKMK_SalesOrder_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_ActivityPointers"></a> msdyn_postalbum_ActivityPointers

See msdyn_postalbum Entity [msdyn_postalbum_ActivityPointers](msdyn_postalbum.md#BKMK_msdyn_postalbum_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_ActivityPointers"></a> msdyn_bookingalertstatus_ActivityPointers

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_ActivityPointers](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_ActivityPointers"></a> msdyn_bookingrule_ActivityPointers

See msdyn_bookingrule Entity [msdyn_bookingrule_ActivityPointers](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_ActivityPointers"></a> msdyn_resourceterritory_ActivityPointers

See msdyn_resourceterritory Entity [msdyn_resourceterritory_ActivityPointers](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_ActivityPointers"></a> msdyn_systemuserschedulersetting_ActivityPointers

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_ActivityPointers](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_ActivityPointers"></a> msdyn_timegroup_ActivityPointers

See msdyn_timegroup Entity [msdyn_timegroup_ActivityPointers](msdyn_timegroup.md#BKMK_msdyn_timegroup_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_ActivityPointers"></a> msdyn_timegroupdetail_ActivityPointers

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_ActivityPointers](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_ActivityPointers"></a> msdyn_processnotes_ActivityPointers

See msdyn_processnotes Entity [msdyn_processnotes_ActivityPointers](msdyn_processnotes.md#BKMK_msdyn_processnotes_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_ActivityPointers"></a> msdyn_projectteam_ActivityPointers

See msdyn_projectteam Entity [msdyn_projectteam_ActivityPointers](msdyn_projectteam.md#BKMK_msdyn_projectteam_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_ActivityPointers"></a> msdyn_agreement_ActivityPointers

See msdyn_agreement Entity [msdyn_agreement_ActivityPointers](msdyn_agreement.md#BKMK_msdyn_agreement_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_ActivityPointers"></a> msdyn_agreementbookingdate_ActivityPointers

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_ActivityPointers](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_ActivityPointers"></a> msdyn_agreementbookingincident_ActivityPointers

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_ActivityPointers](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_ActivityPointers"></a> msdyn_agreementbookingproduct_ActivityPointers

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_ActivityPointers](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_ActivityPointers"></a> msdyn_agreementbookingservice_ActivityPointers

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_ActivityPointers](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_ActivityPointers"></a> msdyn_agreementbookingservicetask_ActivityPointers

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_ActivityPointers](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_ActivityPointers"></a> msdyn_agreementbookingsetup_ActivityPointers

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_ActivityPointers](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_ActivityPointers"></a> msdyn_agreementinvoicedate_ActivityPointers

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_ActivityPointers](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_ActivityPointers"></a> msdyn_agreementinvoiceproduct_ActivityPointers

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_ActivityPointers](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_ActivityPointers"></a> msdyn_agreementinvoicesetup_ActivityPointers

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_ActivityPointers](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_ActivityPointers"></a> msdyn_bookingtimestamp_ActivityPointers

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_ActivityPointers](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_ActivityPointers"></a> msdyn_customerasset_ActivityPointers

See msdyn_customerasset Entity [msdyn_customerasset_ActivityPointers](msdyn_customerasset.md#BKMK_msdyn_customerasset_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_ActivityPointers"></a> msdyn_fieldservicesetting_ActivityPointers

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_ActivityPointers](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_ActivityPointers"></a> msdyn_incidenttypecharacteristic_ActivityPointers

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_ActivityPointers](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_ActivityPointers"></a> msdyn_incidenttypeproduct_ActivityPointers

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_ActivityPointers](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_ActivityPointers"></a> msdyn_incidenttypeservice_ActivityPointers

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_ActivityPointers](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_ActivityPointers"></a> msdyn_inventoryadjustment_ActivityPointers

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_ActivityPointers](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_ActivityPointers"></a> msdyn_inventoryadjustmentproduct_ActivityPointers

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_ActivityPointers](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_ActivityPointers"></a> msdyn_inventoryjournal_ActivityPointers

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_ActivityPointers](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_ActivityPointers"></a> msdyn_inventorytransfer_ActivityPointers

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_ActivityPointers](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_ActivityPointers"></a> msdyn_payment_ActivityPointers

See msdyn_payment Entity [msdyn_payment_ActivityPointers](msdyn_payment.md#BKMK_msdyn_payment_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_ActivityPointers"></a> msdyn_paymentdetail_ActivityPointers

See msdyn_paymentdetail Entity [msdyn_paymentdetail_ActivityPointers](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_ActivityPointers"></a> msdyn_paymentmethod_ActivityPointers

See msdyn_paymentmethod Entity [msdyn_paymentmethod_ActivityPointers](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_ActivityPointers"></a> msdyn_paymentterm_ActivityPointers

See msdyn_paymentterm Entity [msdyn_paymentterm_ActivityPointers](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_ActivityPointers"></a> msdyn_postalcode_ActivityPointers

See msdyn_postalcode Entity [msdyn_postalcode_ActivityPointers](msdyn_postalcode.md#BKMK_msdyn_postalcode_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_ActivityPointers"></a> msdyn_productinventory_ActivityPointers

See msdyn_productinventory Entity [msdyn_productinventory_ActivityPointers](msdyn_productinventory.md#BKMK_msdyn_productinventory_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_ActivityPointers"></a> msdyn_purchaseorder_ActivityPointers

See msdyn_purchaseorder Entity [msdyn_purchaseorder_ActivityPointers](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_ActivityPointers"></a> msdyn_purchaseorderbill_ActivityPointers

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_ActivityPointers](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_ActivityPointers"></a> msdyn_purchaseorderproduct_ActivityPointers

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_ActivityPointers](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_ActivityPointers"></a> msdyn_purchaseorderreceipt_ActivityPointers

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_ActivityPointers](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers"></a> msdyn_purchaseorderreceiptproduct_ActivityPointers

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_ActivityPointers](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_ActivityPointers"></a> msdyn_purchaseordersubstatus_ActivityPointers

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_ActivityPointers](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_ActivityPointers"></a> msdyn_quotebookingincident_ActivityPointers

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_ActivityPointers](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_ActivityPointers"></a> msdyn_quotebookingproduct_ActivityPointers

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_ActivityPointers](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_ActivityPointers"></a> msdyn_quotebookingservice_ActivityPointers

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_ActivityPointers](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_ActivityPointers"></a> msdyn_quotebookingservicetask_ActivityPointers

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_ActivityPointers](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_ActivityPointers"></a> msdyn_rma_ActivityPointers

See msdyn_rma Entity [msdyn_rma_ActivityPointers](msdyn_rma.md#BKMK_msdyn_rma_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_ActivityPointers"></a> msdyn_rmaproduct_ActivityPointers

See msdyn_rmaproduct Entity [msdyn_rmaproduct_ActivityPointers](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_ActivityPointers"></a> msdyn_rmareceipt_ActivityPointers

See msdyn_rmareceipt Entity [msdyn_rmareceipt_ActivityPointers](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_ActivityPointers"></a> msdyn_rmareceiptproduct_ActivityPointers

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_ActivityPointers](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_ActivityPointers"></a> msdyn_rmasubstatus_ActivityPointers

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_ActivityPointers](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_ActivityPointers"></a> msdyn_rtv_ActivityPointers

See msdyn_rtv Entity [msdyn_rtv_ActivityPointers](msdyn_rtv.md#BKMK_msdyn_rtv_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_ActivityPointers"></a> msdyn_rtvproduct_ActivityPointers

See msdyn_rtvproduct Entity [msdyn_rtvproduct_ActivityPointers](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_ActivityPointers"></a> msdyn_rtvsubstatus_ActivityPointers

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_ActivityPointers](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_ActivityPointers"></a> msdyn_shipvia_ActivityPointers

See msdyn_shipvia Entity [msdyn_shipvia_ActivityPointers](msdyn_shipvia.md#BKMK_msdyn_shipvia_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_ActivityPointers"></a> msdyn_timeoffrequest_ActivityPointers

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_ActivityPointers](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_ActivityPointers"></a> msdyn_warehouse_ActivityPointers

See msdyn_warehouse Entity [msdyn_warehouse_ActivityPointers](msdyn_warehouse.md#BKMK_msdyn_warehouse_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_ActivityPointers"></a> msdyn_workorder_ActivityPointers

See msdyn_workorder Entity [msdyn_workorder_ActivityPointers](msdyn_workorder.md#BKMK_msdyn_workorder_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_ActivityPointers"></a> msdyn_workordercharacteristic_ActivityPointers

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_ActivityPointers](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_ActivityPointers"></a> msdyn_workorderincident_ActivityPointers

See msdyn_workorderincident Entity [msdyn_workorderincident_ActivityPointers](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_ActivityPointers"></a> msdyn_workorderproduct_ActivityPointers

See msdyn_workorderproduct Entity [msdyn_workorderproduct_ActivityPointers](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_ActivityPointers"></a> msdyn_workorderresourcerestriction_ActivityPointers

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_ActivityPointers](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_ActivityPointers"></a> msdyn_workorderservice_ActivityPointers

See msdyn_workorderservice Entity [msdyn_workorderservice_ActivityPointers](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_ActivityPointers) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_ActivityPointers"></a> msdyn_workorderservicetask_ActivityPointers

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

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.activitypointer?text=activitypointer EntityType" />