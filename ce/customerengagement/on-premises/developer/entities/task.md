---
title: "Task Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Task entity."
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
# Task Entity Reference

Generic activity representing work needed to be done.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/tasks(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/tasks<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/tasks(*activityid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/tasks(*activityid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/tasks<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/tasks(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/tasks(*activityid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Tasks|
|DisplayCollectionName|Tasks|
|DisplayName|Task|
|EntitySetName|tasks|
|IsBPFEntity|False|
|LogicalCollectionName|tasks|
|LogicalName|task|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|activityid|
|PrimaryNameAttribute|subject|
|SchemaName|Task|

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

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Additional Parameters|
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
|Description|Unique identifier of the task.|
|DisplayName|Task|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|activityid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|--------|-----|
|Description|Type the number of minutes spent on the task. The duration is used in reporting.|
|DisplayName|Duration|
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
|Description|Enter the actual end date and time of the task. By default, it displays when the activity was completed or canceled.|
|DisplayName|Actual End|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ActualStart"></a> ActualStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the actual start date and time for the task. By default, it displays when the task was created.|
|DisplayName|Actual Start|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Category"></a> Category

|Property|Value|
|--------|-----|
|Description|Type a category to identify the task type, such as lead gathering or customer follow up, to tie the task to a business group or function.|
|DisplayName|Category|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|category|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CrmTaskAssignedUniqueId"></a> CrmTaskAssignedUniqueId

|Property|Value|
|--------|-----|
|Description|Assigned Task Unique Id|
|DisplayName|Assigned Task Unique Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|crmtaskassigneduniqueid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the task.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


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


### <a name="BKMK_IsBilled"></a> IsBilled

|Property|Value|
|--------|-----|
|Description|Information which specifies whether the task was billed as part of resolving a case.|
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



### <a name="BKMK_IsWorkflowCreated"></a> IsWorkflowCreated

|Property|Value|
|--------|-----|
|Description|Information which specifies if the task was created from a workflow rule.|
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


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
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
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_PercentComplete"></a> PercentComplete

|Property|Value|
|--------|-----|
|Description|Type the percentage complete value for the task to track tasks to completion.|
|DisplayName|Percent Complete|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|percentcomplete|
|MaxValue|100|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_PriorityCode"></a> PriorityCode

|Property|Value|
|--------|-----|
|Description|Select the priority so that preferred customers or critical issues are handled quickly.|
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
|Description|Shows the ID of the process.|
|DisplayName|Process|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the record that the task relates to.|
|DisplayName|Regarding|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,entitlementtemplate,incident,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_playbookinstance,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site|
|Type|Lookup|


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


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the expected due date and time.|
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
|Description|Enter the expected due date and time.|
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
|Description|Choose the service that is associated with this activity.|
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
|Description|Choose the service level agreement (SLA) that you want to apply to the Task record.|
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
|Description|Shows the ID of the stage.|
|DisplayName|(Deprecated) Process Stage|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the task is open, completed, or canceled. Completed and canceled tasks are read-only and can't be edited.|
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
|0|Open|2|Open|
|1|Completed|5|Completed|
|2|Canceled|6|Canceled|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the task's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|2|Not Started|0|
|3|In Progress|0|
|4|Waiting on someone else|0|
|5|Completed|1|
|6|Canceled|2|
|7|Deferred|0|



### <a name="BKMK_Subcategory"></a> Subcategory

|Property|Value|
|--------|-----|
|Description|Type a subcategory to identify the task type and relate the activity to a specific product, sales region, business group, or other function.|
|DisplayName|Sub-Category|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|subcategory|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Subject"></a> Subject

|Property|Value|
|--------|-----|
|Description|Type a short description about the objective or primary topic of the task.|
|DisplayName|Subject|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|subject|
|MaxLength|200|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_SubscriptionId"></a> SubscriptionId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Subscription|
|IsValidForForm|False|
|IsValidForRead|False|
|IsValidForUpdate|False|
|LogicalName|subscriptionid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


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
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
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

|Property|Value|
|--------|-----|
|Description|Type of activity.|
|DisplayName|Activity Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|activitytypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


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

**DefaultValue**: False



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
|Description|Shows who last updated the record on behalf of another user.|
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
|Description|Shows the record owner's business unit.|
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
|Description|Unique identifier of the team that owns the task.|
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
|Description|Unique identifier of the user that owns the task.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
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
|MaxLength|100|
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
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ScheduledDurationMinutes"></a> ScheduledDurationMinutes

|Property|Value|
|--------|-----|
|Description|Scheduled duration of the task, specified in minutes.|
|DisplayName|Scheduled Duration|
|Format|Duration|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|scheduleddurationminutes|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


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
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SLAInvokedId"></a> SLAInvokedId

|Property|Value|
|--------|-----|
|Description|Last SLA that was applied to this Task. This field is for internal use only.|
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
|Description|Version number of the task.|
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

- [task_PostFollows](#BKMK_task_PostFollows)
- [Task_SyncErrors](#BKMK_Task_SyncErrors)
- [Task_QueueItem](#BKMK_Task_QueueItem)
- [Task_DuplicateBaseRecord](#BKMK_Task_DuplicateBaseRecord)
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

|Property|Value|
|--------|-----|
|ReferencingEntity|postfollow|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|task_PostFollows|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Task_SyncErrors"></a> Task_SyncErrors

Same as syncerror entity [Task_SyncErrors](syncerror.md#BKMK_Task_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Task_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Task_QueueItem"></a> Task_QueueItem

Same as queueitem entity [Task_QueueItem](queueitem.md#BKMK_Task_QueueItem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Task_QueueItem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Task_DuplicateBaseRecord"></a> Task_DuplicateBaseRecord

Same as duplicaterecord entity [Task_DuplicateBaseRecord](duplicaterecord.md#BKMK_Task_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Task_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_task_connections2"></a> task_connections2

Same as connection entity [task_connections2](connection.md#BKMK_task_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|task_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Task_DuplicateMatchingRecord"></a> Task_DuplicateMatchingRecord

Same as duplicaterecord entity [Task_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Task_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Task_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_task_activity_parties"></a> task_activity_parties

Same as activityparty entity [task_activity_parties](activityparty.md#BKMK_task_activity_parties) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|task_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Task_ProcessSessions"></a> Task_ProcessSessions

Same as processsession entity [Task_ProcessSessions](processsession.md#BKMK_Task_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Task_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Task_BulkDeleteFailures"></a> Task_BulkDeleteFailures

Same as bulkdeletefailure entity [Task_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Task_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Task_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_task_principalobjectattributeaccess"></a> task_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [task_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_task_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|task_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_task_actioncard"></a> task_actioncard

Same as actioncard entity [task_actioncard](actioncard.md#BKMK_task_actioncard) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|task_actioncard|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_slakpiinstance_task"></a> slakpiinstance_task

Same as slakpiinstance entity [slakpiinstance_task](slakpiinstance.md#BKMK_slakpiinstance_task) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|slakpiinstance|
|ReferencingAttribute|regarding|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|slakpiinstance_task|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Task_Annotation"></a> Task_Annotation

Same as annotation entity [Task_Annotation](annotation.md#BKMK_Task_Annotation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Task_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_task_connections1"></a> task_connections1

Same as connection entity [task_connections1](connection.md#BKMK_task_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|task_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Task_AsyncOperations"></a> Task_AsyncOperations

Same as asyncoperation entity [Task_AsyncOperations](asyncoperation.md#BKMK_Task_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Task_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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
- [msdyn_playbookinstance_Tasks](#BKMK_msdyn_playbookinstance_Tasks)
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

**Added by**: Lead Management Solution

See lead Entity [Lead_Tasks](lead.md#BKMK_Lead_Tasks) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_Tasks"></a> bookableresourcebooking_Tasks

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [bookableresourcebooking_Tasks](bookableresourcebooking.md#BKMK_bookableresourcebooking_Tasks) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_Tasks"></a> bookableresourcebookingheader_Tasks

**Added by**: Scheduling Solution

See bookableresourcebookingheader Entity [bookableresourcebookingheader_Tasks](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Tasks) One-To-Many relationship.

### <a name="BKMK_bulkoperation_Tasks"></a> bulkoperation_Tasks

**Added by**: Marketing Solution

See bulkoperation Entity [bulkoperation_Tasks](bulkoperation.md#BKMK_bulkoperation_Tasks) One-To-Many relationship.

### <a name="BKMK_Campaign_Tasks"></a> Campaign_Tasks

**Added by**: Marketing Solution

See campaign Entity [Campaign_Tasks](campaign.md#BKMK_Campaign_Tasks) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_Tasks"></a> CampaignActivity_Tasks

**Added by**: Marketing Solution

See campaignactivity Entity [CampaignActivity_Tasks](campaignactivity.md#BKMK_CampaignActivity_Tasks) One-To-Many relationship.

### <a name="BKMK_Contract_Tasks"></a> Contract_Tasks

**Added by**: Service Solution

See contract Entity [Contract_Tasks](contract.md#BKMK_Contract_Tasks) One-To-Many relationship.

### <a name="BKMK_entitlement_Tasks"></a> entitlement_Tasks

**Added by**: Service Solution

See entitlement Entity [entitlement_Tasks](entitlement.md#BKMK_entitlement_Tasks) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_Tasks"></a> entitlementtemplate_Tasks

**Added by**: Service Solution

See entitlementtemplate Entity [entitlementtemplate_Tasks](entitlementtemplate.md#BKMK_entitlementtemplate_Tasks) One-To-Many relationship.

### <a name="BKMK_Incident_Tasks"></a> Incident_Tasks

**Added by**: Service Solution

See incident Entity [Incident_Tasks](incident.md#BKMK_Incident_Tasks) One-To-Many relationship.

### <a name="BKMK_site_Tasks"></a> site_Tasks

**Added by**: Service Solution

See site Entity [site_Tasks](site.md#BKMK_site_Tasks) One-To-Many relationship.

### <a name="BKMK_service_tasks"></a> service_tasks

**Added by**: Service Solution

See service Entity [service_tasks](service.md#BKMK_service_tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_Tasks"></a> msdyn_playbookinstance_Tasks

**Added by**: Playbook Solution

See msdyn_playbookinstance Entity [msdyn_playbookinstance_Tasks](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_Tasks) One-To-Many relationship.

### <a name="BKMK_Invoice_Tasks"></a> Invoice_Tasks

**Added by**: Sales Solution

See invoice Entity [Invoice_Tasks](invoice.md#BKMK_Invoice_Tasks) One-To-Many relationship.

### <a name="BKMK_Opportunity_Tasks"></a> Opportunity_Tasks

**Added by**: Sales Solution

See opportunity Entity [Opportunity_Tasks](opportunity.md#BKMK_Opportunity_Tasks) One-To-Many relationship.

### <a name="BKMK_Quote_Tasks"></a> Quote_Tasks

**Added by**: Sales Solution

See quote Entity [Quote_Tasks](quote.md#BKMK_Quote_Tasks) One-To-Many relationship.

### <a name="BKMK_SalesOrder_Tasks"></a> SalesOrder_Tasks

**Added by**: Sales Solution

See salesorder Entity [SalesOrder_Tasks](salesorder.md#BKMK_SalesOrder_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_Tasks"></a> msdyn_postalbum_Tasks

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_Tasks](msdyn_postalbum.md#BKMK_msdyn_postalbum_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_Tasks"></a> msdyn_bookingalertstatus_Tasks

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_Tasks](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_Tasks"></a> msdyn_bookingrule_Tasks

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_Tasks](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_Tasks"></a> msdyn_resourceterritory_Tasks

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_Tasks](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_Tasks"></a> msdyn_systemuserschedulersetting_Tasks

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_Tasks](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_Tasks"></a> msdyn_timegroup_Tasks

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_Tasks](msdyn_timegroup.md#BKMK_msdyn_timegroup_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_Tasks"></a> msdyn_timegroupdetail_Tasks

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_Tasks](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_Tasks"></a> msdyn_processnotes_Tasks

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_Tasks](msdyn_processnotes.md#BKMK_msdyn_processnotes_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_Tasks"></a> msdyn_projectteam_Tasks

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_Tasks](msdyn_projectteam.md#BKMK_msdyn_projectteam_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_Tasks"></a> msdyn_agreement_Tasks

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_Tasks](msdyn_agreement.md#BKMK_msdyn_agreement_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_Tasks"></a> msdyn_agreementbookingdate_Tasks

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_Tasks](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_Tasks"></a> msdyn_agreementbookingincident_Tasks

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_Tasks](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_Tasks"></a> msdyn_agreementbookingproduct_Tasks

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_Tasks](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_Tasks"></a> msdyn_agreementbookingservice_Tasks

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_Tasks](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_Tasks"></a> msdyn_agreementbookingservicetask_Tasks

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_Tasks](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_Tasks"></a> msdyn_agreementbookingsetup_Tasks

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_Tasks](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_Tasks"></a> msdyn_agreementinvoicedate_Tasks

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_Tasks](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_Tasks"></a> msdyn_agreementinvoiceproduct_Tasks

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_Tasks](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_Tasks"></a> msdyn_agreementinvoicesetup_Tasks

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_Tasks](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_Tasks"></a> msdyn_bookingtimestamp_Tasks

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_Tasks](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_Tasks"></a> msdyn_customerasset_Tasks

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_Tasks](msdyn_customerasset.md#BKMK_msdyn_customerasset_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_Tasks"></a> msdyn_fieldservicesetting_Tasks

**Added by**: Field Service Solution

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_Tasks](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_Tasks"></a> msdyn_incidenttypecharacteristic_Tasks

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_Tasks](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_Tasks"></a> msdyn_incidenttypeproduct_Tasks

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_Tasks](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_Tasks"></a> msdyn_incidenttypeservice_Tasks

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_Tasks](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_Tasks"></a> msdyn_inventoryadjustment_Tasks

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_Tasks](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Tasks"></a> msdyn_inventoryadjustmentproduct_Tasks

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_Tasks](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_Tasks"></a> msdyn_inventoryjournal_Tasks

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_Tasks](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_Tasks"></a> msdyn_inventorytransfer_Tasks

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_Tasks](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_Tasks"></a> msdyn_payment_Tasks

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_Tasks](msdyn_payment.md#BKMK_msdyn_payment_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_Tasks"></a> msdyn_paymentdetail_Tasks

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_Tasks](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_Tasks"></a> msdyn_paymentmethod_Tasks

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_Tasks](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_Tasks"></a> msdyn_paymentterm_Tasks

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_Tasks](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_Tasks"></a> msdyn_postalcode_Tasks

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_Tasks](msdyn_postalcode.md#BKMK_msdyn_postalcode_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_Tasks"></a> msdyn_productinventory_Tasks

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_Tasks](msdyn_productinventory.md#BKMK_msdyn_productinventory_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_Tasks"></a> msdyn_purchaseorder_Tasks

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_Tasks](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_Tasks"></a> msdyn_purchaseorderbill_Tasks

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_Tasks](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_Tasks"></a> msdyn_purchaseorderproduct_Tasks

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_Tasks](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_Tasks"></a> msdyn_purchaseorderreceipt_Tasks

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_Tasks](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Tasks"></a> msdyn_purchaseorderreceiptproduct_Tasks

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_Tasks](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_Tasks"></a> msdyn_purchaseordersubstatus_Tasks

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_Tasks](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_Tasks"></a> msdyn_quotebookingincident_Tasks

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_Tasks](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_Tasks"></a> msdyn_quotebookingproduct_Tasks

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_Tasks](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_Tasks"></a> msdyn_quotebookingservice_Tasks

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_Tasks](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_Tasks"></a> msdyn_quotebookingservicetask_Tasks

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_Tasks](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_Tasks"></a> msdyn_rma_Tasks

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_Tasks](msdyn_rma.md#BKMK_msdyn_rma_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_Tasks"></a> msdyn_rmaproduct_Tasks

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_Tasks](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_Tasks"></a> msdyn_rmareceipt_Tasks

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_Tasks](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_Tasks"></a> msdyn_rmareceiptproduct_Tasks

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_Tasks](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_Tasks"></a> msdyn_rmasubstatus_Tasks

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_Tasks](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_Tasks"></a> msdyn_rtv_Tasks

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_Tasks](msdyn_rtv.md#BKMK_msdyn_rtv_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_Tasks"></a> msdyn_rtvproduct_Tasks

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_Tasks](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_Tasks"></a> msdyn_rtvsubstatus_Tasks

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_Tasks](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_Tasks"></a> msdyn_shipvia_Tasks

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_Tasks](msdyn_shipvia.md#BKMK_msdyn_shipvia_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_Tasks"></a> msdyn_timeoffrequest_Tasks

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_Tasks](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_Tasks"></a> msdyn_warehouse_Tasks

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_Tasks](msdyn_warehouse.md#BKMK_msdyn_warehouse_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_Tasks"></a> msdyn_workorder_Tasks

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_Tasks](msdyn_workorder.md#BKMK_msdyn_workorder_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_Tasks"></a> msdyn_workordercharacteristic_Tasks

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_Tasks](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_Tasks"></a> msdyn_workorderincident_Tasks

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_Tasks](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_Tasks"></a> msdyn_workorderproduct_Tasks

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_Tasks](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_Tasks"></a> msdyn_workorderresourcerestriction_Tasks

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_Tasks](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_Tasks"></a> msdyn_workorderservice_Tasks

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_Tasks](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Tasks) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_Tasks"></a> msdyn_workorderservicetask_Tasks

**Added by**: Field Service Solution

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

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.task?text=task EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]