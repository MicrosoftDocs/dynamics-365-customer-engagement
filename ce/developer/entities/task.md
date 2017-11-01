---
title: "Task Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Task entity."
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
# Task Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Generic activity representing work needed to be done.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/tasks(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/tasks<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/tasks(*activityid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/tasks(*activityid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/tasks<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/tasks(*activityid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/tasks(*activityid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Task<br />
**DisplayCollectionName**: Tasks<br />
**SchemaName**: Task<br />
**CollectionSchemaName**: Tasks<br />
**LogicalName**: task<br />
**LogicalCollectionName**: tasks<br />
**EntitySetName**: tasks<br />
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
- [CrmTaskAssignedUniqueId](#BKMK_CrmTaskAssignedUniqueId)
- [Description](#BKMK_Description)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsBilled](#BKMK_IsBilled)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PercentComplete](#BKMK_PercentComplete)
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

**Description**: Unique identifier of the task.<br />
**DisplayName**: Task<br />
**LogicalName**: activityid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

**Description**: Type the number of minutes spent on the task. The duration is used in reporting.<br />
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

**Description**: Enter the actual end date and time of the task. By default, it displays when the activity was completed or canceled.<br />
**DisplayName**: Actual End<br />
**LogicalName**: actualend<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ActualStart"></a> ActualStart

**Description**: Enter the actual start date and time for the task. By default, it displays when the task was created.<br />
**DisplayName**: Actual Start<br />
**LogicalName**: actualstart<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_Category"></a> Category

**Description**: Type a category to identify the task type, such as lead gathering or customer follow up, to tie the task to a business group or function.<br />
**DisplayName**: Category<br />
**LogicalName**: category<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_CrmTaskAssignedUniqueId"></a> CrmTaskAssignedUniqueId

**Description**: Assigned Task Unique Id<br />
**DisplayName**: Assigned Task Unique Id<br />
**LogicalName**: crmtaskassigneduniqueid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the task.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


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

**Description**: Information which specifies whether the task was billed as part of resolving a case.<br />
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

**Description**: Information which specifies if the task was created from a workflow rule.<br />
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


### <a name="BKMK_PercentComplete"></a> PercentComplete

**Description**: Type the percentage complete value for the task to track tasks to completion.<br />
**DisplayName**: Percent Complete<br />
**LogicalName**: percentcomplete<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 100<br />
**MinValue**: 0


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

**Description**: Choose the record that the task relates to.<br />
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
**DisplayName**: Due Date<br />
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

**Description**: Choose the service that is associated with this activity.<br />
**DisplayName**: Service<br />
**LogicalName**: serviceid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: service


### <a name="BKMK_SLAId"></a> SLAId

**Description**: Choose the service level agreement (SLA) that you want to apply to the Task record.<br />
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

**Description**: Shows whether the task is open, completed, or canceled. Completed and canceled tasks are read-only and can't be edited.<br />
**DisplayName**: Activity Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Open **DefaultStatus**: 2 **InvariantName**: Open
- **Value**: 1 **Label**: Completed **DefaultStatus**: 5 **InvariantName**: Completed
- **Value**: 2 **Label**: Canceled **DefaultStatus**: 6 **InvariantName**: Canceled



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Select the task's status.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 2 **Label**: Not Started **State**: 0
- **Value**: 3 **Label**: In Progress **State**: 0
- **Value**: 4 **Label**: Waiting on someone else **State**: 0
- **Value**: 5 **Label**: Completed **State**: 1
- **Value**: 6 **Label**: Canceled **State**: 2
- **Value**: 7 **Label**: Deferred **State**: 0



### <a name="BKMK_Subcategory"></a> Subcategory

**Description**: Type a subcategory to identify the task type and relate the activity to a specific product, sales region, business group, or other function.<br />
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

**Description**: Type a short description about the objective or primary topic of the task.<br />
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

**Description**: Type of activity.<br />
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

**Description**: Shows the record owner's business unit.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team that owns the task.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user that owns the task.<br />
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

**Description**: Scheduled duration of the task, specified in minutes.<br />
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

**Description**: Last SLA that was applied to this Task. This field is for internal use only.<br />
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

**Description**: Version number of the task.<br />
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

- [task_PostFollows](#BKMK_task_PostFollows)
- [Task_SyncErrors](#BKMK_Task_SyncErrors)
- [Task_QueueItem](#BKMK_Task_QueueItem)
- [Task_DuplicateBaseRecord](#BKMK_Task_DuplicateBaseRecord)
- [userentityinstancedata_task](#BKMK_userentityinstancedata_task)
- [task_connections2](#BKMK_task_connections2)
- [Task_DuplicateMatchingRecord](#BKMK_Task_DuplicateMatchingRecord)
- [task_activity_parties](#BKMK_task_activity_parties)
- [Task_ProcessSessions](#BKMK_Task_ProcessSessions)
- [Task_BulkDeleteFailures](#BKMK_Task_BulkDeleteFailures)
- [task_principalobjectattributeaccess](#BKMK_task_principalobjectattributeaccess)
- [task_actioncard](#BKMK_task_actioncard)
- [slakpiinstance_task](#BKMK_slakpiinstance_task)
- [Task_Annotation](#BKMK_Task_Annotation)
- [task_connections1](#BKMK_task_connections1)
- [Task_AsyncOperations](#BKMK_Task_AsyncOperations)


### <a name="BKMK_task_PostFollows"></a> task_PostFollows

Same as postfollow entity [task_PostFollows](postfollow.md#BKMK_task_PostFollows) Many-To-One relationship.

**ReferencingEntity**: postfollow<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: task_PostFollows<br />
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


### <a name="BKMK_Task_SyncErrors"></a> Task_SyncErrors

Same as syncerror entity [Task_SyncErrors](syncerror.md#BKMK_Task_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Task_SyncErrors<br />
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


### <a name="BKMK_Task_QueueItem"></a> Task_QueueItem

Same as queueitem entity [Task_QueueItem](queueitem.md#BKMK_Task_QueueItem) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Task_QueueItem<br />
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


### <a name="BKMK_Task_DuplicateBaseRecord"></a> Task_DuplicateBaseRecord

Same as duplicaterecord entity [Task_DuplicateBaseRecord](duplicaterecord.md#BKMK_Task_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Task_DuplicateBaseRecord<br />
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


### <a name="BKMK_userentityinstancedata_task"></a> userentityinstancedata_task

Same as userentityinstancedata entity [userentityinstancedata_task](userentityinstancedata.md#BKMK_userentityinstancedata_task) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_task<br />
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


### <a name="BKMK_task_connections2"></a> task_connections2

Same as connection entity [task_connections2](connection.md#BKMK_task_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: task_connections2<br />
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


### <a name="BKMK_Task_DuplicateMatchingRecord"></a> Task_DuplicateMatchingRecord

Same as duplicaterecord entity [Task_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Task_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Task_DuplicateMatchingRecord<br />
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


### <a name="BKMK_task_activity_parties"></a> task_activity_parties

Same as activityparty entity [task_activity_parties](activityparty.md#BKMK_task_activity_parties) Many-To-One relationship.

**ReferencingEntity**: activityparty<br />
**ReferencingAttribute**: activityid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: task_activity_parties<br />
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


### <a name="BKMK_Task_ProcessSessions"></a> Task_ProcessSessions

Same as processsession entity [Task_ProcessSessions](processsession.md#BKMK_Task_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Task_ProcessSessions<br />
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


### <a name="BKMK_Task_BulkDeleteFailures"></a> Task_BulkDeleteFailures

Same as bulkdeletefailure entity [Task_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Task_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Task_BulkDeleteFailures<br />
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


### <a name="BKMK_task_principalobjectattributeaccess"></a> task_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [task_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_task_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: task_principalobjectattributeaccess<br />
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


### <a name="BKMK_task_actioncard"></a> task_actioncard

Same as actioncard entity [task_actioncard](actioncard.md#BKMK_task_actioncard) Many-To-One relationship.

**ReferencingEntity**: actioncard<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: task_actioncard<br />
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


### <a name="BKMK_slakpiinstance_task"></a> slakpiinstance_task

Same as slakpiinstance entity [slakpiinstance_task](slakpiinstance.md#BKMK_slakpiinstance_task) Many-To-One relationship.

**ReferencingEntity**: slakpiinstance<br />
**ReferencingAttribute**: regarding<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: slakpiinstance_task<br />
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


### <a name="BKMK_Task_Annotation"></a> Task_Annotation

Same as annotation entity [Task_Annotation](annotation.md#BKMK_Task_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Task_Annotation<br />
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


### <a name="BKMK_task_connections1"></a> task_connections1

Same as connection entity [task_connections1](connection.md#BKMK_task_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: task_connections1<br />
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


### <a name="BKMK_Task_AsyncOperations"></a> Task_AsyncOperations

Same as asyncoperation entity [Task_AsyncOperations](asyncoperation.md#BKMK_Task_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Task_AsyncOperations<br />
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

- [Lead_Tasks](#BKMK_Lead_Tasks)
- [bookableresourcebooking_Tasks](#BKMK_bookableresourcebooking_Tasks)
- [bookableresourcebookingheader_Tasks](#BKMK_bookableresourcebookingheader_Tasks)
- [bulkoperation_Tasks](#BKMK_bulkoperation_Tasks)
- [Campaign_Tasks](#BKMK_Campaign_Tasks)
- [CampaignActivity_Tasks](#BKMK_CampaignActivity_Tasks)
- [Contract_Tasks](#BKMK_Contract_Tasks)
- [entitlement_Tasks](#BKMK_entitlement_Tasks)
- [entitlementtemplate_Tasks](#BKMK_entitlementtemplate_Tasks)
- [Incident_Tasks](#BKMK_Incident_Tasks)
- [site_Tasks](#BKMK_site_Tasks)
- [service_tasks](#BKMK_service_tasks)
- [Invoice_Tasks](#BKMK_Invoice_Tasks)
- [Opportunity_Tasks](#BKMK_Opportunity_Tasks)
- [Quote_Tasks](#BKMK_Quote_Tasks)
- [SalesOrder_Tasks](#BKMK_SalesOrder_Tasks)
- [msdyn_postalbum_Tasks](#BKMK_msdyn_postalbum_Tasks)
- [msdyn_bookingalertstatus_Tasks](#BKMK_msdyn_bookingalertstatus_Tasks)
- [msdyn_bookingrule_Tasks](#BKMK_msdyn_bookingrule_Tasks)
- [msdyn_resourceterritory_Tasks](#BKMK_msdyn_resourceterritory_Tasks)
- [msdyn_systemuserschedulersetting_Tasks](#BKMK_msdyn_systemuserschedulersetting_Tasks)
- [msdyn_timegroup_Tasks](#BKMK_msdyn_timegroup_Tasks)
- [msdyn_timegroupdetail_Tasks](#BKMK_msdyn_timegroupdetail_Tasks)
- [msdyn_processnotes_Tasks](#BKMK_msdyn_processnotes_Tasks)
- [msdyn_projectteam_Tasks](#BKMK_msdyn_projectteam_Tasks)
- [msdyn_agreement_Tasks](#BKMK_msdyn_agreement_Tasks)
- [msdyn_agreementbookingdate_Tasks](#BKMK_msdyn_agreementbookingdate_Tasks)
- [msdyn_agreementbookingincident_Tasks](#BKMK_msdyn_agreementbookingincident_Tasks)
- [msdyn_agreementbookingproduct_Tasks](#BKMK_msdyn_agreementbookingproduct_Tasks)
- [msdyn_agreementbookingservice_Tasks](#BKMK_msdyn_agreementbookingservice_Tasks)
- [msdyn_agreementbookingservicetask_Tasks](#BKMK_msdyn_agreementbookingservicetask_Tasks)
- [msdyn_agreementbookingsetup_Tasks](#BKMK_msdyn_agreementbookingsetup_Tasks)
- [msdyn_agreementinvoicedate_Tasks](#BKMK_msdyn_agreementinvoicedate_Tasks)
- [msdyn_agreementinvoiceproduct_Tasks](#BKMK_msdyn_agreementinvoiceproduct_Tasks)
- [msdyn_agreementinvoicesetup_Tasks](#BKMK_msdyn_agreementinvoicesetup_Tasks)
- [msdyn_bookingtimestamp_Tasks](#BKMK_msdyn_bookingtimestamp_Tasks)
- [msdyn_customerasset_Tasks](#BKMK_msdyn_customerasset_Tasks)
- [msdyn_fieldservicesetting_Tasks](#BKMK_msdyn_fieldservicesetting_Tasks)
- [msdyn_incidenttypecharacteristic_Tasks](#BKMK_msdyn_incidenttypecharacteristic_Tasks)
- [msdyn_incidenttypeproduct_Tasks](#BKMK_msdyn_incidenttypeproduct_Tasks)
- [msdyn_incidenttypeservice_Tasks](#BKMK_msdyn_incidenttypeservice_Tasks)
- [msdyn_inventoryadjustment_Tasks](#BKMK_msdyn_inventoryadjustment_Tasks)
- [msdyn_inventoryadjustmentproduct_Tasks](#BKMK_msdyn_inventoryadjustmentproduct_Tasks)
- [msdyn_inventoryjournal_Tasks](#BKMK_msdyn_inventoryjournal_Tasks)
- [msdyn_inventorytransfer_Tasks](#BKMK_msdyn_inventorytransfer_Tasks)
- [msdyn_payment_Tasks](#BKMK_msdyn_payment_Tasks)
- [msdyn_paymentdetail_Tasks](#BKMK_msdyn_paymentdetail_Tasks)
- [msdyn_paymentmethod_Tasks](#BKMK_msdyn_paymentmethod_Tasks)
- [msdyn_paymentterm_Tasks](#BKMK_msdyn_paymentterm_Tasks)
- [msdyn_postalcode_Tasks](#BKMK_msdyn_postalcode_Tasks)
- [msdyn_productinventory_Tasks](#BKMK_msdyn_productinventory_Tasks)
- [msdyn_purchaseorder_Tasks](#BKMK_msdyn_purchaseorder_Tasks)
- [msdyn_purchaseorderbill_Tasks](#BKMK_msdyn_purchaseorderbill_Tasks)
- [msdyn_purchaseorderproduct_Tasks](#BKMK_msdyn_purchaseorderproduct_Tasks)
- [msdyn_purchaseorderreceipt_Tasks](#BKMK_msdyn_purchaseorderreceipt_Tasks)
- [msdyn_purchaseorderreceiptproduct_Tasks](#BKMK_msdyn_purchaseorderreceiptproduct_Tasks)
- [msdyn_purchaseordersubstatus_Tasks](#BKMK_msdyn_purchaseordersubstatus_Tasks)
- [msdyn_quotebookingincident_Tasks](#BKMK_msdyn_quotebookingincident_Tasks)
- [msdyn_quotebookingproduct_Tasks](#BKMK_msdyn_quotebookingproduct_Tasks)
- [msdyn_quotebookingservice_Tasks](#BKMK_msdyn_quotebookingservice_Tasks)
- [msdyn_quotebookingservicetask_Tasks](#BKMK_msdyn_quotebookingservicetask_Tasks)
- [msdyn_rma_Tasks](#BKMK_msdyn_rma_Tasks)
- [msdyn_rmaproduct_Tasks](#BKMK_msdyn_rmaproduct_Tasks)
- [msdyn_rmareceipt_Tasks](#BKMK_msdyn_rmareceipt_Tasks)
- [msdyn_rmareceiptproduct_Tasks](#BKMK_msdyn_rmareceiptproduct_Tasks)
- [msdyn_rmasubstatus_Tasks](#BKMK_msdyn_rmasubstatus_Tasks)
- [msdyn_rtv_Tasks](#BKMK_msdyn_rtv_Tasks)
- [msdyn_rtvproduct_Tasks](#BKMK_msdyn_rtvproduct_Tasks)
- [msdyn_rtvsubstatus_Tasks](#BKMK_msdyn_rtvsubstatus_Tasks)
- [msdyn_shipvia_Tasks](#BKMK_msdyn_shipvia_Tasks)
- [msdyn_timeoffrequest_Tasks](#BKMK_msdyn_timeoffrequest_Tasks)
- [msdyn_warehouse_Tasks](#BKMK_msdyn_warehouse_Tasks)
- [msdyn_workorder_Tasks](#BKMK_msdyn_workorder_Tasks)
- [msdyn_workordercharacteristic_Tasks](#BKMK_msdyn_workordercharacteristic_Tasks)
- [msdyn_workorderincident_Tasks](#BKMK_msdyn_workorderincident_Tasks)
- [msdyn_workorderproduct_Tasks](#BKMK_msdyn_workorderproduct_Tasks)
- [msdyn_workorderresourcerestriction_Tasks](#BKMK_msdyn_workorderresourcerestriction_Tasks)
- [msdyn_workorderservice_Tasks](#BKMK_msdyn_workorderservice_Tasks)
- [msdyn_workorderservicetask_Tasks](#BKMK_msdyn_workorderservicetask_Tasks)
- [KnowledgeBaseRecord_Tasks](#BKMK_KnowledgeBaseRecord_Tasks)
- [business_unit_task_activities](#BKMK_business_unit_task_activities)
- [TransactionCurrency_Task](#BKMK_TransactionCurrency_Task)
- [lk_task_createdby](#BKMK_lk_task_createdby)
- [user_task](#BKMK_user_task)
- [KnowledgeArticle_Tasks](#BKMK_KnowledgeArticle_Tasks)
- [team_task](#BKMK_team_task)
- [lk_task_createdonbehalfby](#BKMK_lk_task_createdonbehalfby)
- [activity_pointer_task](#BKMK_activity_pointer_task)
- [Account_Tasks](#BKMK_Account_Tasks)
- [Contact_Tasks](#BKMK_Contact_Tasks)
- [lk_task_modifiedby](#BKMK_lk_task_modifiedby)
- [processstage_tasks](#BKMK_processstage_tasks)
- [sla_task](#BKMK_sla_task)
- [manualsla_task](#BKMK_manualsla_task)
- [lk_task_modifiedonbehalfby](#BKMK_lk_task_modifiedonbehalfby)


### <a name="BKMK_Lead_Tasks"></a> Lead_Tasks

See lead Entity [Lead_Tasks](lead.md#BKMK_Lead_Tasks) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_Tasks"></a> bookableresourcebooking_Tasks

See bookableresourcebooking Entity [bookableresourcebooking_Tasks](bookableresourcebooking.md#BKMK_bookableresourcebooking_Tasks) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_Tasks"></a> bookableresourcebookingheader_Tasks

See bookableresourcebookingheader Entity [bookableresourcebookingheader_Tasks](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Tasks) One-To-Many relationship.

### <a name="BKMK_bulkoperation_Tasks"></a> bulkoperation_Tasks

See bulkoperation Entity [bulkoperation_Tasks](bulkoperation.md#BKMK_bulkoperation_Tasks) One-To-Many relationship.

### <a name="BKMK_Campaign_Tasks"></a> Campaign_Tasks

See campaign Entity [Campaign_Tasks](campaign.md#BKMK_Campaign_Tasks) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_Tasks"></a> CampaignActivity_Tasks

See campaignactivity Entity [CampaignActivity_Tasks](campaignactivity.md#BKMK_CampaignActivity_Tasks) One-To-Many relationship.

### <a name="BKMK_Contract_Tasks"></a> Contract_Tasks

See contract Entity [Contract_Tasks](contract.md#BKMK_Contract_Tasks) One-To-Many relationship.

### <a name="BKMK_entitlement_Tasks"></a> entitlement_Tasks

See entitlement Entity [entitlement_Tasks](entitlement.md#BKMK_entitlement_Tasks) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_Tasks"></a> entitlementtemplate_Tasks

See entitlementtemplate Entity [entitlementtemplate_Tasks](entitlementtemplate.md#BKMK_entitlementtemplate_Tasks) One-To-Many relationship.

### <a name="BKMK_Incident_Tasks"></a> Incident_Tasks

See incident Entity [Incident_Tasks](incident.md#BKMK_Incident_Tasks) One-To-Many relationship.

### <a name="BKMK_site_Tasks"></a> site_Tasks

See site Entity [site_Tasks](site.md#BKMK_site_Tasks) One-To-Many relationship.

### <a name="BKMK_service_tasks"></a> service_tasks

See service Entity [service_tasks](service.md#BKMK_service_tasks) One-To-Many relationship.

### <a name="BKMK_Invoice_Tasks"></a> Invoice_Tasks

See invoice Entity [Invoice_Tasks](invoice.md#BKMK_Invoice_Tasks) One-To-Many relationship.

### <a name="BKMK_Opportunity_Tasks"></a> Opportunity_Tasks

See opportunity Entity [Opportunity_Tasks](opportunity.md#BKMK_Opportunity_Tasks) One-To-Many relationship.

### <a name="BKMK_Quote_Tasks"></a> Quote_Tasks

See quote Entity [Quote_Tasks](quote.md#BKMK_Quote_Tasks) One-To-Many relationship.

### <a name="BKMK_SalesOrder_Tasks"></a> SalesOrder_Tasks

See salesorder Entity [SalesOrder_Tasks](salesorder.md#BKMK_SalesOrder_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_Tasks"></a> msdyn_postalbum_Tasks

See msdyn_postalbum Entity [msdyn_postalbum_Tasks](msdyn_postalbum.md#BKMK_msdyn_postalbum_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_Tasks"></a> msdyn_bookingalertstatus_Tasks

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_Tasks](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_Tasks"></a> msdyn_bookingrule_Tasks

See msdyn_bookingrule Entity [msdyn_bookingrule_Tasks](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_Tasks"></a> msdyn_resourceterritory_Tasks

See msdyn_resourceterritory Entity [msdyn_resourceterritory_Tasks](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_Tasks"></a> msdyn_systemuserschedulersetting_Tasks

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_Tasks](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_Tasks"></a> msdyn_timegroup_Tasks

See msdyn_timegroup Entity [msdyn_timegroup_Tasks](msdyn_timegroup.md#BKMK_msdyn_timegroup_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_Tasks"></a> msdyn_timegroupdetail_Tasks

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_Tasks](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_Tasks"></a> msdyn_processnotes_Tasks

See msdyn_processnotes Entity [msdyn_processnotes_Tasks](msdyn_processnotes.md#BKMK_msdyn_processnotes_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_Tasks"></a> msdyn_projectteam_Tasks

See msdyn_projectteam Entity [msdyn_projectteam_Tasks](msdyn_projectteam.md#BKMK_msdyn_projectteam_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_Tasks"></a> msdyn_agreement_Tasks

See msdyn_agreement Entity [msdyn_agreement_Tasks](msdyn_agreement.md#BKMK_msdyn_agreement_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_Tasks"></a> msdyn_agreementbookingdate_Tasks

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_Tasks](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_Tasks"></a> msdyn_agreementbookingincident_Tasks

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_Tasks](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_Tasks"></a> msdyn_agreementbookingproduct_Tasks

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_Tasks](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_Tasks"></a> msdyn_agreementbookingservice_Tasks

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_Tasks](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_Tasks"></a> msdyn_agreementbookingservicetask_Tasks

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_Tasks](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_Tasks"></a> msdyn_agreementbookingsetup_Tasks

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_Tasks](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_Tasks"></a> msdyn_agreementinvoicedate_Tasks

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_Tasks](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_Tasks"></a> msdyn_agreementinvoiceproduct_Tasks

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_Tasks](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_Tasks"></a> msdyn_agreementinvoicesetup_Tasks

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_Tasks](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_Tasks"></a> msdyn_bookingtimestamp_Tasks

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_Tasks](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_Tasks"></a> msdyn_customerasset_Tasks

See msdyn_customerasset Entity [msdyn_customerasset_Tasks](msdyn_customerasset.md#BKMK_msdyn_customerasset_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_Tasks"></a> msdyn_fieldservicesetting_Tasks

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_Tasks](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_Tasks"></a> msdyn_incidenttypecharacteristic_Tasks

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_Tasks](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_Tasks"></a> msdyn_incidenttypeproduct_Tasks

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_Tasks](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_Tasks"></a> msdyn_incidenttypeservice_Tasks

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_Tasks](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_Tasks"></a> msdyn_inventoryadjustment_Tasks

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_Tasks](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Tasks"></a> msdyn_inventoryadjustmentproduct_Tasks

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_Tasks](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_Tasks"></a> msdyn_inventoryjournal_Tasks

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_Tasks](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_Tasks"></a> msdyn_inventorytransfer_Tasks

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_Tasks](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_Tasks"></a> msdyn_payment_Tasks

See msdyn_payment Entity [msdyn_payment_Tasks](msdyn_payment.md#BKMK_msdyn_payment_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_Tasks"></a> msdyn_paymentdetail_Tasks

See msdyn_paymentdetail Entity [msdyn_paymentdetail_Tasks](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_Tasks"></a> msdyn_paymentmethod_Tasks

See msdyn_paymentmethod Entity [msdyn_paymentmethod_Tasks](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_Tasks"></a> msdyn_paymentterm_Tasks

See msdyn_paymentterm Entity [msdyn_paymentterm_Tasks](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_Tasks"></a> msdyn_postalcode_Tasks

See msdyn_postalcode Entity [msdyn_postalcode_Tasks](msdyn_postalcode.md#BKMK_msdyn_postalcode_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_Tasks"></a> msdyn_productinventory_Tasks

See msdyn_productinventory Entity [msdyn_productinventory_Tasks](msdyn_productinventory.md#BKMK_msdyn_productinventory_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_Tasks"></a> msdyn_purchaseorder_Tasks

See msdyn_purchaseorder Entity [msdyn_purchaseorder_Tasks](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_Tasks"></a> msdyn_purchaseorderbill_Tasks

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_Tasks](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_Tasks"></a> msdyn_purchaseorderproduct_Tasks

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_Tasks](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_Tasks"></a> msdyn_purchaseorderreceipt_Tasks

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_Tasks](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Tasks"></a> msdyn_purchaseorderreceiptproduct_Tasks

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_Tasks](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_Tasks"></a> msdyn_purchaseordersubstatus_Tasks

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_Tasks](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_Tasks"></a> msdyn_quotebookingincident_Tasks

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_Tasks](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_Tasks"></a> msdyn_quotebookingproduct_Tasks

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_Tasks](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_Tasks"></a> msdyn_quotebookingservice_Tasks

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_Tasks](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_Tasks"></a> msdyn_quotebookingservicetask_Tasks

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_Tasks](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_Tasks"></a> msdyn_rma_Tasks

See msdyn_rma Entity [msdyn_rma_Tasks](msdyn_rma.md#BKMK_msdyn_rma_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_Tasks"></a> msdyn_rmaproduct_Tasks

See msdyn_rmaproduct Entity [msdyn_rmaproduct_Tasks](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_Tasks"></a> msdyn_rmareceipt_Tasks

See msdyn_rmareceipt Entity [msdyn_rmareceipt_Tasks](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_Tasks"></a> msdyn_rmareceiptproduct_Tasks

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_Tasks](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_Tasks"></a> msdyn_rmasubstatus_Tasks

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_Tasks](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_Tasks"></a> msdyn_rtv_Tasks

See msdyn_rtv Entity [msdyn_rtv_Tasks](msdyn_rtv.md#BKMK_msdyn_rtv_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_Tasks"></a> msdyn_rtvproduct_Tasks

See msdyn_rtvproduct Entity [msdyn_rtvproduct_Tasks](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_Tasks"></a> msdyn_rtvsubstatus_Tasks

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_Tasks](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_Tasks"></a> msdyn_shipvia_Tasks

See msdyn_shipvia Entity [msdyn_shipvia_Tasks](msdyn_shipvia.md#BKMK_msdyn_shipvia_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_Tasks"></a> msdyn_timeoffrequest_Tasks

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_Tasks](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_Tasks"></a> msdyn_warehouse_Tasks

See msdyn_warehouse Entity [msdyn_warehouse_Tasks](msdyn_warehouse.md#BKMK_msdyn_warehouse_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_Tasks"></a> msdyn_workorder_Tasks

See msdyn_workorder Entity [msdyn_workorder_Tasks](msdyn_workorder.md#BKMK_msdyn_workorder_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_Tasks"></a> msdyn_workordercharacteristic_Tasks

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_Tasks](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_Tasks"></a> msdyn_workorderincident_Tasks

See msdyn_workorderincident Entity [msdyn_workorderincident_Tasks](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_Tasks"></a> msdyn_workorderproduct_Tasks

See msdyn_workorderproduct Entity [msdyn_workorderproduct_Tasks](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_Tasks"></a> msdyn_workorderresourcerestriction_Tasks

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_Tasks](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_Tasks"></a> msdyn_workorderservice_Tasks

See msdyn_workorderservice Entity [msdyn_workorderservice_Tasks](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_Tasks"></a> msdyn_workorderservicetask_Tasks

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_Tasks](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Tasks) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_Tasks"></a> KnowledgeBaseRecord_Tasks

See knowledgebaserecord Entity [KnowledgeBaseRecord_Tasks](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_Tasks) One-To-Many relationship.

### <a name="BKMK_business_unit_task_activities"></a> business_unit_task_activities

See businessunit Entity [business_unit_task_activities](businessunit.md#BKMK_business_unit_task_activities) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_Task"></a> TransactionCurrency_Task

See transactioncurrency Entity [TransactionCurrency_Task](transactioncurrency.md#BKMK_TransactionCurrency_Task) One-To-Many relationship.

### <a name="BKMK_lk_task_createdby"></a> lk_task_createdby

See systemuser Entity [lk_task_createdby](systemuser.md#BKMK_lk_task_createdby) One-To-Many relationship.

### <a name="BKMK_user_task"></a> user_task

See systemuser Entity [user_task](systemuser.md#BKMK_user_task) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticle_Tasks"></a> KnowledgeArticle_Tasks

See knowledgearticle Entity [KnowledgeArticle_Tasks](knowledgearticle.md#BKMK_KnowledgeArticle_Tasks) One-To-Many relationship.

### <a name="BKMK_team_task"></a> team_task

See team Entity [team_task](team.md#BKMK_team_task) One-To-Many relationship.

### <a name="BKMK_lk_task_createdonbehalfby"></a> lk_task_createdonbehalfby

See systemuser Entity [lk_task_createdonbehalfby](systemuser.md#BKMK_lk_task_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_activity_pointer_task"></a> activity_pointer_task

See activitypointer Entity [activity_pointer_task](activitypointer.md#BKMK_activity_pointer_task) One-To-Many relationship.

### <a name="BKMK_Account_Tasks"></a> Account_Tasks

See account Entity [Account_Tasks](account.md#BKMK_Account_Tasks) One-To-Many relationship.

### <a name="BKMK_Contact_Tasks"></a> Contact_Tasks

See contact Entity [Contact_Tasks](contact.md#BKMK_Contact_Tasks) One-To-Many relationship.

### <a name="BKMK_lk_task_modifiedby"></a> lk_task_modifiedby

See systemuser Entity [lk_task_modifiedby](systemuser.md#BKMK_lk_task_modifiedby) One-To-Many relationship.

### <a name="BKMK_processstage_tasks"></a> processstage_tasks

See processstage Entity [processstage_tasks](processstage.md#BKMK_processstage_tasks) One-To-Many relationship.

### <a name="BKMK_sla_task"></a> sla_task

See sla Entity [sla_task](sla.md#BKMK_sla_task) One-To-Many relationship.

### <a name="BKMK_manualsla_task"></a> manualsla_task

See sla Entity [manualsla_task](sla.md#BKMK_manualsla_task) One-To-Many relationship.

### <a name="BKMK_lk_task_modifiedonbehalfby"></a> lk_task_modifiedonbehalfby

See systemuser Entity [lk_task_modifiedonbehalfby](systemuser.md#BKMK_lk_task_modifiedonbehalfby) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.task?text=task EntityType" />