---
title: "PhoneCall Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the PhoneCall entity."
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
# PhoneCall Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Activity to track a telephone call.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/phonecalls(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/phonecalls<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/phonecalls(*activityid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/phonecalls(*activityid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/phonecalls<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/phonecalls(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/phonecalls(*activityid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Phone Call<br />
**DisplayCollectionName**: Phone Calls<br />
**SchemaName**: PhoneCall<br />
**CollectionSchemaName**: PhoneCalls<br />
**LogicalName**: phonecall<br />
**LogicalCollectionName**: phonecalls<br />
**EntitySetName**: phonecalls<br />
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
- [Category](#BKMK_Category)
- [Description](#BKMK_Description)
- [DirectionCode](#BKMK_DirectionCode)
- [from](#BKMK_from)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsBilled](#BKMK_IsBilled)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [LeftVoiceMail](#BKMK_LeftVoiceMail)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PhoneNumber](#BKMK_PhoneNumber)
- [PriorityCode](#BKMK_PriorityCode)
- [ProcessId](#BKMK_ProcessId)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledStart](#BKMK_ScheduledStart)
- [ServiceId](#BKMK_ServiceId)
- [SLAId](#BKMK_SLAId)
- [SortDate](#BKMK_SortDate)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [Subcategory](#BKMK_Subcategory)
- [Subject](#BKMK_Subject)
- [SubscriptionId](#BKMK_SubscriptionId)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [to](#BKMK_to)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ActivityAdditionalParams"></a> ActivityAdditionalParams

**Description**: For internal use only.<br />
**DisplayName**: Additional Parameters<br />
**LogicalName**: activityadditionalparams<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 8192


### <a name="BKMK_ActivityId"></a> ActivityId

**Description**: Unique identifier of the phone call activity.<br />
**DisplayName**: Phone Call<br />
**LogicalName**: activityid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

**Description**: Type the number of minutes spent on the phone call. The duration is used in reporting.<br />
**DisplayName**: Duration<br />
**LogicalName**: actualdurationminutes<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_ActualEnd"></a> ActualEnd

**Description**: Enter the actual end date and time of the phone call. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual duration of the phone call.<br />
**DisplayName**: Actual End<br />
**LogicalName**: actualend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ActualStart"></a> ActualStart

**Description**: Enter the actual start date and time for the phone call. By default, it displays the date and time when the activity was created, but can be edited to capture the actual duration of the phone call.<br />
**DisplayName**: Actual Start<br />
**LogicalName**: actualstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_Category"></a> Category

**Description**: Type a category to identify the phone call type, such as lead gathering or customer follow-up, to tie the phone call to a business group or function.<br />
**DisplayName**: Category<br />
**LogicalName**: category<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the phone call, such as the primary message or the products and services discussed.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_DirectionCode"></a> DirectionCode

**Description**: Select the direction of the phone call as incoming or outbound.<br />
**DisplayName**: Direction<br />
**LogicalName**: directioncode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Outgoing
- **FalseOption Value**: 0 **Label**: Incoming

**DefaultValue**: True


### <a name="BKMK_from"></a> from

**Description**: Enter the account, contact, lead, or user who made the phone call.<br />
**DisplayName**: Call From<br />
**LogicalName**: from<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: PartyList<br />
**Targets**: account,contact,lead,systemuser


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


### <a name="BKMK_IsBilled"></a> IsBilled

**Description**: Information which specifies whether the phone call activity was billed as part of resolving a case.<br />
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


### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

**Description**: Indication which specifies if the phone call activity was created by a workflow rule.<br />
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

**Description**: Select whether a voice mail was left for the person.<br />
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


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
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


### <a name="BKMK_PhoneNumber"></a> PhoneNumber

**Description**: Type the phone number.<br />
**DisplayName**: Phone Number<br />
**LogicalName**: phonenumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Phone<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_PriorityCode"></a> PriorityCode

**Description**: Select the priority so that preferred customers or critical issues are handled quickly.<br />
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

**Description**: Shows the ID of the process.<br />
**DisplayName**: Process<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Choose the record that the phone call relates to.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,entitlementtemplate,incident,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

**Description**: Enter the expected due date and time.<br />
**DisplayName**: Due<br />
**LogicalName**: scheduledend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

**Description**: Enter the expected due date and time.<br />
**DisplayName**: Start Date<br />
**LogicalName**: scheduledstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ServiceId"></a> ServiceId

**Description**: Unique identifier for an associated service.<br />
**DisplayName**: Service<br />
**LogicalName**: serviceid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: service


### <a name="BKMK_SLAId"></a> SLAId

**Description**: Choose the service level agreement (SLA) that you want to apply to the Phone Call record.<br />
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

**Description**: Shows the ID of the stage.<br />
**DisplayName**: Process Stage<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows whether the phone call is open, completed, or canceled. Completed and canceled phone calls are read-only and can't be edited.<br />
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



### <a name="BKMK_StatusCode"></a> StatusCode

**Added by**: Activities Solution<br />
**Description**: Select the phone call's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Open **State**: 0
- **Value**: 2 **Label**: Made **State**: 1
- **Value**: 3 **Label**: Canceled **State**: 2
- **Value**: 4 **Label**: Received **State**: 1



### <a name="BKMK_Subcategory"></a> Subcategory

**Description**: Type a subcategory to identify the phone call type and relate the activity to a specific product, sales region, business group, or other function.<br />
**DisplayName**: Sub-Category<br />
**LogicalName**: subcategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Subject"></a> Subject

**Description**: Type a short description about the objective or primary topic of the phone call.<br />
**DisplayName**: Subject<br />
**LogicalName**: subject<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_SubscriptionId"></a> SubscriptionId

**Description**: For internal use only.<br />
**DisplayName**: Subscription<br />
**LogicalName**: subscriptionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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


### <a name="BKMK_to"></a> to

**Description**: Enter the account, contact, lead, or user recipients of the phone call.<br />
**DisplayName**: Call To<br />
**LogicalName**: to<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: PartyList<br />
**Targets**: account,contact,lead,systemuser


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
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
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
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
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [ScheduledDurationMinutes](#BKMK_ScheduledDurationMinutes)
- [ServiceIdName](#BKMK_ServiceIdName)
- [SLAInvokedId](#BKMK_SLAInvokedId)
- [SLAInvokedIdName](#BKMK_SLAInvokedIdName)
- [SLAName](#BKMK_SLAName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ActivityTypeCode"></a> ActivityTypeCode

**Description**: Shows the type of activity.<br />
**DisplayName**: Activity Type<br />
**LogicalName**: activitytypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


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

**DefaultValue**: False


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

**Description**: Shows who last updated the record on behalf of another user.<br />
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

**Description**: Unique identifier of the business unit that owns the phone call activity.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team that owns the phone call activity.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user that owns the phone call activity.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


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
**MaxLength**: 100


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
**MaxLength**: 100


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

**Description**: Scheduled duration of the phone call activity, specified in minutes.<br />
**DisplayName**: Scheduled Duration<br />
**LogicalName**: scheduleddurationminutes<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_ServiceIdName"></a> ServiceIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: serviceidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

**Description**: Last SLA that was applied to this Phone Call. This field is for internal use only.<br />
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

**Description**: Version number of the phone call activity.<br />
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

- [phonecall_campaignresponse](#BKMK_phonecall_campaignresponse)
- [phonecall_PostFollows](#BKMK_phonecall_PostFollows)
- [PhoneCall_AsyncOperations](#BKMK_PhoneCall_AsyncOperations)
- [phonecall_connections2](#BKMK_phonecall_connections2)
- [PhoneCall_SyncErrors](#BKMK_PhoneCall_SyncErrors)
- [PhoneCall_ProcessSessions](#BKMK_PhoneCall_ProcessSessions)
- [PhoneCall_DuplicateMatchingRecord](#BKMK_PhoneCall_DuplicateMatchingRecord)
- [slakpiinstance_phonecall](#BKMK_slakpiinstance_phonecall)
- [PhoneCall_DuplicateBaseRecord](#BKMK_PhoneCall_DuplicateBaseRecord)
- [PhoneCall_Annotation](#BKMK_PhoneCall_Annotation)
- [phonecall_actioncard](#BKMK_phonecall_actioncard)
- [phonecall_connections1](#BKMK_phonecall_connections1)
- [PhoneCall_BulkDeleteFailures](#BKMK_PhoneCall_BulkDeleteFailures)
- [phonecall_activity_parties](#BKMK_phonecall_activity_parties)
- [PhoneCall_QueueItem](#BKMK_PhoneCall_QueueItem)
- [phonecall_principalobjectattributeaccess](#BKMK_phonecall_principalobjectattributeaccess)
- [userentityinstancedata_phonecall](#BKMK_userentityinstancedata_phonecall)


### <a name="BKMK_phonecall_campaignresponse"></a> phonecall_campaignresponse

Same as campaignresponse entity [phonecall_campaignresponse](campaignresponse.md#BKMK_phonecall_campaignresponse) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: originatingactivityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: phonecall_campaignresponse<br />
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


### <a name="BKMK_phonecall_PostFollows"></a> phonecall_PostFollows

Same as postfollow entity [phonecall_PostFollows](postfollow.md#BKMK_phonecall_PostFollows) Many-To-One relationship.

**ReferencingEntity**: postfollow<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: phonecall_PostFollows<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_PhoneCall_AsyncOperations"></a> PhoneCall_AsyncOperations

Same as asyncoperation entity [PhoneCall_AsyncOperations](asyncoperation.md#BKMK_PhoneCall_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: PhoneCall_AsyncOperations<br />
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


### <a name="BKMK_phonecall_connections2"></a> phonecall_connections2

Same as connection entity [phonecall_connections2](connection.md#BKMK_phonecall_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: phonecall_connections2<br />
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


### <a name="BKMK_PhoneCall_SyncErrors"></a> PhoneCall_SyncErrors

Same as syncerror entity [PhoneCall_SyncErrors](syncerror.md#BKMK_PhoneCall_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: PhoneCall_SyncErrors<br />
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


### <a name="BKMK_PhoneCall_ProcessSessions"></a> PhoneCall_ProcessSessions

Same as processsession entity [PhoneCall_ProcessSessions](processsession.md#BKMK_PhoneCall_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: PhoneCall_ProcessSessions<br />
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


### <a name="BKMK_PhoneCall_DuplicateMatchingRecord"></a> PhoneCall_DuplicateMatchingRecord

Same as duplicaterecord entity [PhoneCall_DuplicateMatchingRecord](duplicaterecord.md#BKMK_PhoneCall_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: PhoneCall_DuplicateMatchingRecord<br />
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


### <a name="BKMK_slakpiinstance_phonecall"></a> slakpiinstance_phonecall

Same as slakpiinstance entity [slakpiinstance_phonecall](slakpiinstance.md#BKMK_slakpiinstance_phonecall) Many-To-One relationship.

**ReferencingEntity**: slakpiinstance<br />
**ReferencingAttribute**: regarding<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: slakpiinstance_phonecall<br />
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


### <a name="BKMK_PhoneCall_DuplicateBaseRecord"></a> PhoneCall_DuplicateBaseRecord

Same as duplicaterecord entity [PhoneCall_DuplicateBaseRecord](duplicaterecord.md#BKMK_PhoneCall_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: PhoneCall_DuplicateBaseRecord<br />
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


### <a name="BKMK_PhoneCall_Annotation"></a> PhoneCall_Annotation

Same as annotation entity [PhoneCall_Annotation](annotation.md#BKMK_PhoneCall_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: PhoneCall_Annotation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_phonecall_actioncard"></a> phonecall_actioncard

Same as actioncard entity [phonecall_actioncard](actioncard.md#BKMK_phonecall_actioncard) Many-To-One relationship.

**ReferencingEntity**: actioncard<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: phonecall_actioncard<br />
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
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_phonecall_connections1"></a> phonecall_connections1

Same as connection entity [phonecall_connections1](connection.md#BKMK_phonecall_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: phonecall_connections1<br />
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


### <a name="BKMK_PhoneCall_BulkDeleteFailures"></a> PhoneCall_BulkDeleteFailures

Same as bulkdeletefailure entity [PhoneCall_BulkDeleteFailures](bulkdeletefailure.md#BKMK_PhoneCall_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: PhoneCall_BulkDeleteFailures<br />
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


### <a name="BKMK_phonecall_activity_parties"></a> phonecall_activity_parties

Same as activityparty entity [phonecall_activity_parties](activityparty.md#BKMK_phonecall_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: phonecall_activity_parties<br />
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


### <a name="BKMK_PhoneCall_QueueItem"></a> PhoneCall_QueueItem

Same as queueitem entity [PhoneCall_QueueItem](queueitem.md#BKMK_PhoneCall_QueueItem) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: PhoneCall_QueueItem<br />
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


### <a name="BKMK_phonecall_principalobjectattributeaccess"></a> phonecall_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [phonecall_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_phonecall_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: phonecall_principalobjectattributeaccess<br />
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


### <a name="BKMK_userentityinstancedata_phonecall"></a> userentityinstancedata_phonecall

Same as userentityinstancedata entity [userentityinstancedata_phonecall](userentityinstancedata.md#BKMK_userentityinstancedata_phonecall) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_phonecall<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [Lead_Phonecalls](#BKMK_Lead_Phonecalls)
- [bookableresourcebooking_PhoneCalls](#BKMK_bookableresourcebooking_PhoneCalls)
- [bookableresourcebookingheader_PhoneCalls](#BKMK_bookableresourcebookingheader_PhoneCalls)
- [BulkOperation_Phonecall](#BKMK_BulkOperation_Phonecall)
- [Campaign_Phonecalls](#BKMK_Campaign_Phonecalls)
- [CampaignActivity_Phonecalls](#BKMK_CampaignActivity_Phonecalls)
- [Contract_Phonecalls](#BKMK_Contract_Phonecalls)
- [entitlement_PhoneCalls](#BKMK_entitlement_PhoneCalls)
- [entitlementtemplate_PhoneCalls](#BKMK_entitlementtemplate_PhoneCalls)
- [Incident_Phonecalls](#BKMK_Incident_Phonecalls)
- [site_PhoneCalls](#BKMK_site_PhoneCalls)
- [service_phonecalls](#BKMK_service_phonecalls)
- [Invoice_Phonecalls](#BKMK_Invoice_Phonecalls)
- [Opportunity_Phonecalls](#BKMK_Opportunity_Phonecalls)
- [Quote_Phonecalls](#BKMK_Quote_Phonecalls)
- [SalesOrder_Phonecalls](#BKMK_SalesOrder_Phonecalls)
- [msdyn_postalbum_PhoneCalls](#BKMK_msdyn_postalbum_PhoneCalls)
- [msdyn_bookingalertstatus_PhoneCalls](#BKMK_msdyn_bookingalertstatus_PhoneCalls)
- [msdyn_bookingrule_PhoneCalls](#BKMK_msdyn_bookingrule_PhoneCalls)
- [msdyn_resourceterritory_PhoneCalls](#BKMK_msdyn_resourceterritory_PhoneCalls)
- [msdyn_systemuserschedulersetting_PhoneCalls](#BKMK_msdyn_systemuserschedulersetting_PhoneCalls)
- [msdyn_timegroup_PhoneCalls](#BKMK_msdyn_timegroup_PhoneCalls)
- [msdyn_timegroupdetail_PhoneCalls](#BKMK_msdyn_timegroupdetail_PhoneCalls)
- [msdyn_processnotes_PhoneCalls](#BKMK_msdyn_processnotes_PhoneCalls)
- [msdyn_projectteam_PhoneCalls](#BKMK_msdyn_projectteam_PhoneCalls)
- [msdyn_agreement_PhoneCalls](#BKMK_msdyn_agreement_PhoneCalls)
- [msdyn_agreementbookingdate_PhoneCalls](#BKMK_msdyn_agreementbookingdate_PhoneCalls)
- [msdyn_agreementbookingincident_PhoneCalls](#BKMK_msdyn_agreementbookingincident_PhoneCalls)
- [msdyn_agreementbookingproduct_PhoneCalls](#BKMK_msdyn_agreementbookingproduct_PhoneCalls)
- [msdyn_agreementbookingservice_PhoneCalls](#BKMK_msdyn_agreementbookingservice_PhoneCalls)
- [msdyn_agreementbookingservicetask_PhoneCalls](#BKMK_msdyn_agreementbookingservicetask_PhoneCalls)
- [msdyn_agreementbookingsetup_PhoneCalls](#BKMK_msdyn_agreementbookingsetup_PhoneCalls)
- [msdyn_agreementinvoicedate_PhoneCalls](#BKMK_msdyn_agreementinvoicedate_PhoneCalls)
- [msdyn_agreementinvoiceproduct_PhoneCalls](#BKMK_msdyn_agreementinvoiceproduct_PhoneCalls)
- [msdyn_agreementinvoicesetup_PhoneCalls](#BKMK_msdyn_agreementinvoicesetup_PhoneCalls)
- [msdyn_bookingtimestamp_PhoneCalls](#BKMK_msdyn_bookingtimestamp_PhoneCalls)
- [msdyn_customerasset_PhoneCalls](#BKMK_msdyn_customerasset_PhoneCalls)
- [msdyn_fieldservicesetting_PhoneCalls](#BKMK_msdyn_fieldservicesetting_PhoneCalls)
- [msdyn_incidenttypecharacteristic_PhoneCalls](#BKMK_msdyn_incidenttypecharacteristic_PhoneCalls)
- [msdyn_incidenttypeproduct_PhoneCalls](#BKMK_msdyn_incidenttypeproduct_PhoneCalls)
- [msdyn_incidenttypeservice_PhoneCalls](#BKMK_msdyn_incidenttypeservice_PhoneCalls)
- [msdyn_inventoryadjustment_PhoneCalls](#BKMK_msdyn_inventoryadjustment_PhoneCalls)
- [msdyn_inventoryadjustmentproduct_PhoneCalls](#BKMK_msdyn_inventoryadjustmentproduct_PhoneCalls)
- [msdyn_inventoryjournal_PhoneCalls](#BKMK_msdyn_inventoryjournal_PhoneCalls)
- [msdyn_inventorytransfer_PhoneCalls](#BKMK_msdyn_inventorytransfer_PhoneCalls)
- [msdyn_payment_PhoneCalls](#BKMK_msdyn_payment_PhoneCalls)
- [msdyn_paymentdetail_PhoneCalls](#BKMK_msdyn_paymentdetail_PhoneCalls)
- [msdyn_paymentmethod_PhoneCalls](#BKMK_msdyn_paymentmethod_PhoneCalls)
- [msdyn_paymentterm_PhoneCalls](#BKMK_msdyn_paymentterm_PhoneCalls)
- [msdyn_postalcode_PhoneCalls](#BKMK_msdyn_postalcode_PhoneCalls)
- [msdyn_productinventory_PhoneCalls](#BKMK_msdyn_productinventory_PhoneCalls)
- [msdyn_purchaseorder_PhoneCalls](#BKMK_msdyn_purchaseorder_PhoneCalls)
- [msdyn_purchaseorderbill_PhoneCalls](#BKMK_msdyn_purchaseorderbill_PhoneCalls)
- [msdyn_purchaseorderproduct_PhoneCalls](#BKMK_msdyn_purchaseorderproduct_PhoneCalls)
- [msdyn_purchaseorderreceipt_PhoneCalls](#BKMK_msdyn_purchaseorderreceipt_PhoneCalls)
- [msdyn_purchaseorderreceiptproduct_PhoneCalls](#BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls)
- [msdyn_purchaseordersubstatus_PhoneCalls](#BKMK_msdyn_purchaseordersubstatus_PhoneCalls)
- [msdyn_quotebookingincident_PhoneCalls](#BKMK_msdyn_quotebookingincident_PhoneCalls)
- [msdyn_quotebookingproduct_PhoneCalls](#BKMK_msdyn_quotebookingproduct_PhoneCalls)
- [msdyn_quotebookingservice_PhoneCalls](#BKMK_msdyn_quotebookingservice_PhoneCalls)
- [msdyn_quotebookingservicetask_PhoneCalls](#BKMK_msdyn_quotebookingservicetask_PhoneCalls)
- [msdyn_rma_PhoneCalls](#BKMK_msdyn_rma_PhoneCalls)
- [msdyn_rmaproduct_PhoneCalls](#BKMK_msdyn_rmaproduct_PhoneCalls)
- [msdyn_rmareceipt_PhoneCalls](#BKMK_msdyn_rmareceipt_PhoneCalls)
- [msdyn_rmareceiptproduct_PhoneCalls](#BKMK_msdyn_rmareceiptproduct_PhoneCalls)
- [msdyn_rmasubstatus_PhoneCalls](#BKMK_msdyn_rmasubstatus_PhoneCalls)
- [msdyn_rtv_PhoneCalls](#BKMK_msdyn_rtv_PhoneCalls)
- [msdyn_rtvproduct_PhoneCalls](#BKMK_msdyn_rtvproduct_PhoneCalls)
- [msdyn_rtvsubstatus_PhoneCalls](#BKMK_msdyn_rtvsubstatus_PhoneCalls)
- [msdyn_shipvia_PhoneCalls](#BKMK_msdyn_shipvia_PhoneCalls)
- [msdyn_timeoffrequest_PhoneCalls](#BKMK_msdyn_timeoffrequest_PhoneCalls)
- [msdyn_warehouse_PhoneCalls](#BKMK_msdyn_warehouse_PhoneCalls)
- [msdyn_workorder_PhoneCalls](#BKMK_msdyn_workorder_PhoneCalls)
- [msdyn_workordercharacteristic_PhoneCalls](#BKMK_msdyn_workordercharacteristic_PhoneCalls)
- [msdyn_workorderincident_PhoneCalls](#BKMK_msdyn_workorderincident_PhoneCalls)
- [msdyn_workorderproduct_PhoneCalls](#BKMK_msdyn_workorderproduct_PhoneCalls)
- [msdyn_workorderresourcerestriction_PhoneCalls](#BKMK_msdyn_workorderresourcerestriction_PhoneCalls)
- [msdyn_workorderservice_PhoneCalls](#BKMK_msdyn_workorderservice_PhoneCalls)
- [msdyn_workorderservicetask_PhoneCalls](#BKMK_msdyn_workorderservicetask_PhoneCalls)
- [KnowledgeBaseRecord_PhoneCalls](#BKMK_KnowledgeBaseRecord_PhoneCalls)
- [lk_phonecall_modifiedonbehalfby](#BKMK_lk_phonecall_modifiedonbehalfby)
- [lk_phonecall_createdonbehalfby](#BKMK_lk_phonecall_createdonbehalfby)
- [Account_Phonecalls](#BKMK_Account_Phonecalls)
- [lk_phonecall_modifiedby](#BKMK_lk_phonecall_modifiedby)
- [Contact_Phonecalls](#BKMK_Contact_Phonecalls)
- [manualsla_phonecall](#BKMK_manualsla_phonecall)
- [sla_phonecall](#BKMK_sla_phonecall)
- [KnowledgeArticle_Phonecalls](#BKMK_KnowledgeArticle_Phonecalls)
- [lk_phonecall_createdby](#BKMK_lk_phonecall_createdby)
- [processstage_phonecalls](#BKMK_processstage_phonecalls)
- [user_phonecall](#BKMK_user_phonecall)
- [activity_pointer_phonecall](#BKMK_activity_pointer_phonecall)
- [team_phonecall](#BKMK_team_phonecall)
- [TransactionCurrency_PhoneCall](#BKMK_TransactionCurrency_PhoneCall)
- [business_unit_phone_call_activities](#BKMK_business_unit_phone_call_activities)


### <a name="BKMK_Lead_Phonecalls"></a> Lead_Phonecalls

See lead Entity [Lead_Phonecalls](lead.md#BKMK_Lead_Phonecalls) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_PhoneCalls"></a> bookableresourcebooking_PhoneCalls

See bookableresourcebooking Entity [bookableresourcebooking_PhoneCalls](bookableresourcebooking.md#BKMK_bookableresourcebooking_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_PhoneCalls"></a> bookableresourcebookingheader_PhoneCalls

See bookableresourcebookingheader Entity [bookableresourcebookingheader_PhoneCalls](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_BulkOperation_Phonecall"></a> BulkOperation_Phonecall

See bulkoperation Entity [BulkOperation_Phonecall](bulkoperation.md#BKMK_BulkOperation_Phonecall) One-To-Many relationship.

### <a name="BKMK_Campaign_Phonecalls"></a> Campaign_Phonecalls

See campaign Entity [Campaign_Phonecalls](campaign.md#BKMK_Campaign_Phonecalls) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_Phonecalls"></a> CampaignActivity_Phonecalls

See campaignactivity Entity [CampaignActivity_Phonecalls](campaignactivity.md#BKMK_CampaignActivity_Phonecalls) One-To-Many relationship.

### <a name="BKMK_Contract_Phonecalls"></a> Contract_Phonecalls

See contract Entity [Contract_Phonecalls](contract.md#BKMK_Contract_Phonecalls) One-To-Many relationship.

### <a name="BKMK_entitlement_PhoneCalls"></a> entitlement_PhoneCalls

See entitlement Entity [entitlement_PhoneCalls](entitlement.md#BKMK_entitlement_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_PhoneCalls"></a> entitlementtemplate_PhoneCalls

See entitlementtemplate Entity [entitlementtemplate_PhoneCalls](entitlementtemplate.md#BKMK_entitlementtemplate_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_Incident_Phonecalls"></a> Incident_Phonecalls

See incident Entity [Incident_Phonecalls](incident.md#BKMK_Incident_Phonecalls) One-To-Many relationship.

### <a name="BKMK_site_PhoneCalls"></a> site_PhoneCalls

See site Entity [site_PhoneCalls](site.md#BKMK_site_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_service_phonecalls"></a> service_phonecalls

See service Entity [service_phonecalls](service.md#BKMK_service_phonecalls) One-To-Many relationship.

### <a name="BKMK_Invoice_Phonecalls"></a> Invoice_Phonecalls

See invoice Entity [Invoice_Phonecalls](invoice.md#BKMK_Invoice_Phonecalls) One-To-Many relationship.

### <a name="BKMK_Opportunity_Phonecalls"></a> Opportunity_Phonecalls

See opportunity Entity [Opportunity_Phonecalls](opportunity.md#BKMK_Opportunity_Phonecalls) One-To-Many relationship.

### <a name="BKMK_Quote_Phonecalls"></a> Quote_Phonecalls

See quote Entity [Quote_Phonecalls](quote.md#BKMK_Quote_Phonecalls) One-To-Many relationship.

### <a name="BKMK_SalesOrder_Phonecalls"></a> SalesOrder_Phonecalls

See salesorder Entity [SalesOrder_Phonecalls](salesorder.md#BKMK_SalesOrder_Phonecalls) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_PhoneCalls"></a> msdyn_postalbum_PhoneCalls

See msdyn_postalbum Entity [msdyn_postalbum_PhoneCalls](msdyn_postalbum.md#BKMK_msdyn_postalbum_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_PhoneCalls"></a> msdyn_bookingalertstatus_PhoneCalls

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_PhoneCalls](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_PhoneCalls"></a> msdyn_bookingrule_PhoneCalls

See msdyn_bookingrule Entity [msdyn_bookingrule_PhoneCalls](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_PhoneCalls"></a> msdyn_resourceterritory_PhoneCalls

See msdyn_resourceterritory Entity [msdyn_resourceterritory_PhoneCalls](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_PhoneCalls"></a> msdyn_systemuserschedulersetting_PhoneCalls

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_PhoneCalls](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_PhoneCalls"></a> msdyn_timegroup_PhoneCalls

See msdyn_timegroup Entity [msdyn_timegroup_PhoneCalls](msdyn_timegroup.md#BKMK_msdyn_timegroup_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_PhoneCalls"></a> msdyn_timegroupdetail_PhoneCalls

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_PhoneCalls](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_PhoneCalls"></a> msdyn_processnotes_PhoneCalls

See msdyn_processnotes Entity [msdyn_processnotes_PhoneCalls](msdyn_processnotes.md#BKMK_msdyn_processnotes_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_PhoneCalls"></a> msdyn_projectteam_PhoneCalls

See msdyn_projectteam Entity [msdyn_projectteam_PhoneCalls](msdyn_projectteam.md#BKMK_msdyn_projectteam_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_PhoneCalls"></a> msdyn_agreement_PhoneCalls

See msdyn_agreement Entity [msdyn_agreement_PhoneCalls](msdyn_agreement.md#BKMK_msdyn_agreement_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_PhoneCalls"></a> msdyn_agreementbookingdate_PhoneCalls

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_PhoneCalls](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_PhoneCalls"></a> msdyn_agreementbookingincident_PhoneCalls

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_PhoneCalls](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_PhoneCalls"></a> msdyn_agreementbookingproduct_PhoneCalls

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_PhoneCalls](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_PhoneCalls"></a> msdyn_agreementbookingservice_PhoneCalls

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_PhoneCalls](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_PhoneCalls"></a> msdyn_agreementbookingservicetask_PhoneCalls

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_PhoneCalls](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_PhoneCalls"></a> msdyn_agreementbookingsetup_PhoneCalls

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_PhoneCalls](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_PhoneCalls"></a> msdyn_agreementinvoicedate_PhoneCalls

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_PhoneCalls](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_PhoneCalls"></a> msdyn_agreementinvoiceproduct_PhoneCalls

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_PhoneCalls](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_PhoneCalls"></a> msdyn_agreementinvoicesetup_PhoneCalls

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_PhoneCalls](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_PhoneCalls"></a> msdyn_bookingtimestamp_PhoneCalls

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_PhoneCalls](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_PhoneCalls"></a> msdyn_customerasset_PhoneCalls

See msdyn_customerasset Entity [msdyn_customerasset_PhoneCalls](msdyn_customerasset.md#BKMK_msdyn_customerasset_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_PhoneCalls"></a> msdyn_fieldservicesetting_PhoneCalls

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_PhoneCalls](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_PhoneCalls"></a> msdyn_incidenttypecharacteristic_PhoneCalls

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_PhoneCalls](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_PhoneCalls"></a> msdyn_incidenttypeproduct_PhoneCalls

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_PhoneCalls](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_PhoneCalls"></a> msdyn_incidenttypeservice_PhoneCalls

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_PhoneCalls](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_PhoneCalls"></a> msdyn_inventoryadjustment_PhoneCalls

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_PhoneCalls](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_PhoneCalls"></a> msdyn_inventoryadjustmentproduct_PhoneCalls

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_PhoneCalls](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_PhoneCalls"></a> msdyn_inventoryjournal_PhoneCalls

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_PhoneCalls](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_PhoneCalls"></a> msdyn_inventorytransfer_PhoneCalls

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_PhoneCalls](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_PhoneCalls"></a> msdyn_payment_PhoneCalls

See msdyn_payment Entity [msdyn_payment_PhoneCalls](msdyn_payment.md#BKMK_msdyn_payment_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_PhoneCalls"></a> msdyn_paymentdetail_PhoneCalls

See msdyn_paymentdetail Entity [msdyn_paymentdetail_PhoneCalls](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_PhoneCalls"></a> msdyn_paymentmethod_PhoneCalls

See msdyn_paymentmethod Entity [msdyn_paymentmethod_PhoneCalls](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_PhoneCalls"></a> msdyn_paymentterm_PhoneCalls

See msdyn_paymentterm Entity [msdyn_paymentterm_PhoneCalls](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_PhoneCalls"></a> msdyn_postalcode_PhoneCalls

See msdyn_postalcode Entity [msdyn_postalcode_PhoneCalls](msdyn_postalcode.md#BKMK_msdyn_postalcode_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_PhoneCalls"></a> msdyn_productinventory_PhoneCalls

See msdyn_productinventory Entity [msdyn_productinventory_PhoneCalls](msdyn_productinventory.md#BKMK_msdyn_productinventory_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_PhoneCalls"></a> msdyn_purchaseorder_PhoneCalls

See msdyn_purchaseorder Entity [msdyn_purchaseorder_PhoneCalls](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_PhoneCalls"></a> msdyn_purchaseorderbill_PhoneCalls

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_PhoneCalls](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_PhoneCalls"></a> msdyn_purchaseorderproduct_PhoneCalls

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_PhoneCalls](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_PhoneCalls"></a> msdyn_purchaseorderreceipt_PhoneCalls

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_PhoneCalls](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls"></a> msdyn_purchaseorderreceiptproduct_PhoneCalls

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_PhoneCalls](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_PhoneCalls"></a> msdyn_purchaseordersubstatus_PhoneCalls

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_PhoneCalls](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_PhoneCalls"></a> msdyn_quotebookingincident_PhoneCalls

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_PhoneCalls](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_PhoneCalls"></a> msdyn_quotebookingproduct_PhoneCalls

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_PhoneCalls](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_PhoneCalls"></a> msdyn_quotebookingservice_PhoneCalls

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_PhoneCalls](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_PhoneCalls"></a> msdyn_quotebookingservicetask_PhoneCalls

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_PhoneCalls](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_PhoneCalls"></a> msdyn_rma_PhoneCalls

See msdyn_rma Entity [msdyn_rma_PhoneCalls](msdyn_rma.md#BKMK_msdyn_rma_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_PhoneCalls"></a> msdyn_rmaproduct_PhoneCalls

See msdyn_rmaproduct Entity [msdyn_rmaproduct_PhoneCalls](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_PhoneCalls"></a> msdyn_rmareceipt_PhoneCalls

See msdyn_rmareceipt Entity [msdyn_rmareceipt_PhoneCalls](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_PhoneCalls"></a> msdyn_rmareceiptproduct_PhoneCalls

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_PhoneCalls](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_PhoneCalls"></a> msdyn_rmasubstatus_PhoneCalls

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_PhoneCalls](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_PhoneCalls"></a> msdyn_rtv_PhoneCalls

See msdyn_rtv Entity [msdyn_rtv_PhoneCalls](msdyn_rtv.md#BKMK_msdyn_rtv_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_PhoneCalls"></a> msdyn_rtvproduct_PhoneCalls

See msdyn_rtvproduct Entity [msdyn_rtvproduct_PhoneCalls](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_PhoneCalls"></a> msdyn_rtvsubstatus_PhoneCalls

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_PhoneCalls](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_PhoneCalls"></a> msdyn_shipvia_PhoneCalls

See msdyn_shipvia Entity [msdyn_shipvia_PhoneCalls](msdyn_shipvia.md#BKMK_msdyn_shipvia_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_PhoneCalls"></a> msdyn_timeoffrequest_PhoneCalls

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_PhoneCalls](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_PhoneCalls"></a> msdyn_warehouse_PhoneCalls

See msdyn_warehouse Entity [msdyn_warehouse_PhoneCalls](msdyn_warehouse.md#BKMK_msdyn_warehouse_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_PhoneCalls"></a> msdyn_workorder_PhoneCalls

See msdyn_workorder Entity [msdyn_workorder_PhoneCalls](msdyn_workorder.md#BKMK_msdyn_workorder_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_PhoneCalls"></a> msdyn_workordercharacteristic_PhoneCalls

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_PhoneCalls](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_PhoneCalls"></a> msdyn_workorderincident_PhoneCalls

See msdyn_workorderincident Entity [msdyn_workorderincident_PhoneCalls](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_PhoneCalls"></a> msdyn_workorderproduct_PhoneCalls

See msdyn_workorderproduct Entity [msdyn_workorderproduct_PhoneCalls](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_PhoneCalls"></a> msdyn_workorderresourcerestriction_PhoneCalls

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_PhoneCalls](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_PhoneCalls"></a> msdyn_workorderservice_PhoneCalls

See msdyn_workorderservice Entity [msdyn_workorderservice_PhoneCalls](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_PhoneCalls"></a> msdyn_workorderservicetask_PhoneCalls

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_PhoneCalls](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_PhoneCalls"></a> KnowledgeBaseRecord_PhoneCalls

See knowledgebaserecord Entity [KnowledgeBaseRecord_PhoneCalls](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_PhoneCalls) One-To-Many relationship.

### <a name="BKMK_lk_phonecall_modifiedonbehalfby"></a> lk_phonecall_modifiedonbehalfby

See systemuser Entity [lk_phonecall_modifiedonbehalfby](systemuser.md#BKMK_lk_phonecall_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_phonecall_createdonbehalfby"></a> lk_phonecall_createdonbehalfby

See systemuser Entity [lk_phonecall_createdonbehalfby](systemuser.md#BKMK_lk_phonecall_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_Account_Phonecalls"></a> Account_Phonecalls

See account Entity [Account_Phonecalls](account.md#BKMK_Account_Phonecalls) One-To-Many relationship.

### <a name="BKMK_lk_phonecall_modifiedby"></a> lk_phonecall_modifiedby

See systemuser Entity [lk_phonecall_modifiedby](systemuser.md#BKMK_lk_phonecall_modifiedby) One-To-Many relationship.

### <a name="BKMK_Contact_Phonecalls"></a> Contact_Phonecalls

See contact Entity [Contact_Phonecalls](contact.md#BKMK_Contact_Phonecalls) One-To-Many relationship.

### <a name="BKMK_manualsla_phonecall"></a> manualsla_phonecall

See sla Entity [manualsla_phonecall](sla.md#BKMK_manualsla_phonecall) One-To-Many relationship.

### <a name="BKMK_sla_phonecall"></a> sla_phonecall

See sla Entity [sla_phonecall](sla.md#BKMK_sla_phonecall) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticle_Phonecalls"></a> KnowledgeArticle_Phonecalls

See knowledgearticle Entity [KnowledgeArticle_Phonecalls](knowledgearticle.md#BKMK_KnowledgeArticle_Phonecalls) One-To-Many relationship.

### <a name="BKMK_lk_phonecall_createdby"></a> lk_phonecall_createdby

See systemuser Entity [lk_phonecall_createdby](systemuser.md#BKMK_lk_phonecall_createdby) One-To-Many relationship.

### <a name="BKMK_processstage_phonecalls"></a> processstage_phonecalls

See processstage Entity [processstage_phonecalls](processstage.md#BKMK_processstage_phonecalls) One-To-Many relationship.

### <a name="BKMK_user_phonecall"></a> user_phonecall

See systemuser Entity [user_phonecall](systemuser.md#BKMK_user_phonecall) One-To-Many relationship.

### <a name="BKMK_activity_pointer_phonecall"></a> activity_pointer_phonecall

See activitypointer Entity [activity_pointer_phonecall](activitypointer.md#BKMK_activity_pointer_phonecall) One-To-Many relationship.

### <a name="BKMK_team_phonecall"></a> team_phonecall

See team Entity [team_phonecall](team.md#BKMK_team_phonecall) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_PhoneCall"></a> TransactionCurrency_PhoneCall

See transactioncurrency Entity [TransactionCurrency_PhoneCall](transactioncurrency.md#BKMK_TransactionCurrency_PhoneCall) One-To-Many relationship.

### <a name="BKMK_business_unit_phone_call_activities"></a> business_unit_phone_call_activities

See businessunit Entity [business_unit_phone_call_activities](businessunit.md#BKMK_business_unit_phone_call_activities) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.phonecall?text=phonecall EntityType" />