---
title: "Letter Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Letter entity."
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
# Letter Entity Reference

Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/letters(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/letters<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/letters(*activityid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/letters(*activityid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/letters<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/letters(*activityid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/letters(*activityid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Letters|
|DisplayCollectionName|Letters|
|DisplayName|Letter|
|EntitySetName|letters|
|IsBPFEntity|False|
|LogicalCollectionName|letters|
|LogicalName|letter|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|activityid|
|PrimaryNameAttribute|subject|
|SchemaName|Letter|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityId](#BKMK_ActivityId)
- [ActualDurationMinutes](#BKMK_ActualDurationMinutes)
- [ActualEnd](#BKMK_ActualEnd)
- [ActualStart](#BKMK_ActualStart)
- [Address](#BKMK_Address)
- [bcc](#BKMK_bcc)
- [Category](#BKMK_Category)
- [cc](#BKMK_cc)
- [Description](#BKMK_Description)
- [DirectionCode](#BKMK_DirectionCode)
- [from](#BKMK_from)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsBilled](#BKMK_IsBilled)
- [IsWorkflowCreated](#BKMK_IsWorkflowCreated)
- [LastOnHoldTime](#BKMK_LastOnHoldTime)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
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


### <a name="BKMK_ActivityId"></a> ActivityId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the letter activity.|
|DisplayName|Letter|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|activityid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ActualDurationMinutes"></a> ActualDurationMinutes

|Property|Value|
|--------|-----|
|Description|Type the number of minutes spent creating and sending the letter. The duration is used in reporting.|
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
|Description|Enter the actual end date and time of the letter. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual time to create and send the letter.|
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
|Description|Enter the actual start date and time for the letter. By default, it displays the date and time when the activity was created, but can be edited to capture the actual time to create and send the letter.|
|DisplayName|Actual Start|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|actualstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Address"></a> Address

|Property|Value|
|--------|-----|
|Description|Type the complete recipient address for the letter to ensure timely delivery.|
|DisplayName|Address|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_bcc"></a> bcc

|Property|Value|
|--------|-----|
|Description|Enter the recipients that are included in the letter distribution, but are not displayed to other recipients.|
|DisplayName|Bcc|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|bcc|
|RequiredLevel|None|
|Targets|account,contact,lead,systemuser|
|Type|PartyList|


### <a name="BKMK_Category"></a> Category

|Property|Value|
|--------|-----|
|Description|Type a category to identify the letter type, such as sales offer or past due notice, to tie the letter to a business group or function.|
|DisplayName|Category|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|category|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_cc"></a> cc

|Property|Value|
|--------|-----|
|Description|Enter the recipients that should be copied on the letter.|
|DisplayName|Cc|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|cc|
|RequiredLevel|None|
|Targets|account,contact,lead,systemuser|
|Type|PartyList|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type the letter body or additional information to describe the letter, such as the primary message or the products and services described.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DirectionCode"></a> DirectionCode

|Property|Value|
|--------|-----|
|Description|Select the direction of the letter as incoming or outbound.|
|DisplayName|Direction|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|directioncode|
|RequiredLevel|None|
|Type|Boolean|

#### DirectionCode Options

|Value|Label|
|-----|-----|
|1|Outgoing|
|0|Incoming|

**DefaultValue**: True



### <a name="BKMK_from"></a> from

|Property|Value|
|--------|-----|
|Description|Enter the account, contact, lead, or user who sent the letter.|
|DisplayName|From|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|from|
|RequiredLevel|None|
|Targets|account,contact,lead,systemuser|
|Type|PartyList|


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
|Description|Shows whether the letter activity was billed as part of resolving a case.|
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
|Description|Shows whether the letter activity was created by a workflow rule.|
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
|Description|Choose the record that the letter relates to.|
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
|Description|Unique identifier for an associated service.|
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
|Description|Choose the service level agreement (SLA) that you want to apply to the Letter record.|
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
|Description|Shows whether the letter is open, completed, or canceled. Completed and canceled letters are read-only and can't be edited.|
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
|1|Completed|4|Completed|
|2|Canceled|5|Canceled|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the letter's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Open|0|
|2|Draft|0|
|3|Received|1|
|4|Sent|1|
|5|Canceled|2|



### <a name="BKMK_Subcategory"></a> Subcategory

|Property|Value|
|--------|-----|
|Description|Type a subcategory to identify the letter type and relate the activity to a specific product, sales region, business group, or other function.|
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
|Description|Type a short description about the objective or primary topic of the letter.|
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


### <a name="BKMK_to"></a> to

|Property|Value|
|--------|-----|
|Description|Enter the account, contact, lead, or user recipients for the letter.|
|DisplayName|To|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|to|
|RequiredLevel|None|
|Targets|account,contact,lead,systemuser|
|Type|PartyList|


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
|Description|Shows the type of activity.|
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
|Description|Shows whether the activity is a regular activity type or event type.|
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
|Description|Unique identifier of the business unit that owns the letter activity.|
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
|Description|Unique identifier of the team that owns the letter activity.|
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
|Description|Unique identifier of the user that owns the letter activity.|
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
|Description|Scheduled duration of the letter activity, specified in minutes.|
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
|Description|Last SLA that was applied to this Letter. This field is for internal use only.|
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
|Description|Version number of the letter.|
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

- [letter_campaignresponse](#BKMK_letter_campaignresponse)
- [Letter_DuplicateBaseRecord](#BKMK_Letter_DuplicateBaseRecord)
- [Letter_BulkDeleteFailures](#BKMK_Letter_BulkDeleteFailures)
- [letter_connections1](#BKMK_letter_connections1)
- [slakpiinstance_letter](#BKMK_slakpiinstance_letter)
- [Letter_AsyncOperations](#BKMK_Letter_AsyncOperations)
- [Letter_Annotation](#BKMK_Letter_Annotation)
- [letter_actioncard](#BKMK_letter_actioncard)
- [letter_principalobjectattributeaccess](#BKMK_letter_principalobjectattributeaccess)
- [Letter_ProcessSessions](#BKMK_Letter_ProcessSessions)
- [Letter_DuplicateMatchingRecord](#BKMK_Letter_DuplicateMatchingRecord)
- [Letter_SyncErrors](#BKMK_Letter_SyncErrors)
- [letter_activity_parties](#BKMK_letter_activity_parties)
- [Letter_QueueItem](#BKMK_Letter_QueueItem)
- [letter_connections2](#BKMK_letter_connections2)


### <a name="BKMK_letter_campaignresponse"></a> letter_campaignresponse

**Added by**: Marketing Solution

Same as campaignresponse entity [letter_campaignresponse](campaignresponse.md#BKMK_letter_campaignresponse) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|originatingactivityid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|letter_campaignresponse|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Letter_DuplicateBaseRecord"></a> Letter_DuplicateBaseRecord

Same as duplicaterecord entity [Letter_DuplicateBaseRecord](duplicaterecord.md#BKMK_Letter_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Letter_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Letter_BulkDeleteFailures"></a> Letter_BulkDeleteFailures

Same as bulkdeletefailure entity [Letter_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Letter_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Letter_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_letter_connections1"></a> letter_connections1

Same as connection entity [letter_connections1](connection.md#BKMK_letter_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|letter_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_slakpiinstance_letter"></a> slakpiinstance_letter

Same as slakpiinstance entity [slakpiinstance_letter](slakpiinstance.md#BKMK_slakpiinstance_letter) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|slakpiinstance|
|ReferencingAttribute|regarding|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|slakpiinstance_letter|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Letter_AsyncOperations"></a> Letter_AsyncOperations

Same as asyncoperation entity [Letter_AsyncOperations](asyncoperation.md#BKMK_Letter_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Letter_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Letter_Annotation"></a> Letter_Annotation

Same as annotation entity [Letter_Annotation](annotation.md#BKMK_Letter_Annotation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Letter_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_letter_actioncard"></a> letter_actioncard

Same as actioncard entity [letter_actioncard](actioncard.md#BKMK_letter_actioncard) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|letter_actioncard|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_letter_principalobjectattributeaccess"></a> letter_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [letter_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_letter_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|letter_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Letter_ProcessSessions"></a> Letter_ProcessSessions

Same as processsession entity [Letter_ProcessSessions](processsession.md#BKMK_Letter_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Letter_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Letter_DuplicateMatchingRecord"></a> Letter_DuplicateMatchingRecord

Same as duplicaterecord entity [Letter_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Letter_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Letter_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Letter_SyncErrors"></a> Letter_SyncErrors

Same as syncerror entity [Letter_SyncErrors](syncerror.md#BKMK_Letter_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Letter_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_letter_activity_parties"></a> letter_activity_parties

Same as activityparty entity [letter_activity_parties](activityparty.md#BKMK_letter_activity_parties) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|activityid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|letter_activity_parties|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Letter_QueueItem"></a> Letter_QueueItem

Same as queueitem entity [Letter_QueueItem](queueitem.md#BKMK_Letter_QueueItem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Letter_QueueItem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_letter_connections2"></a> letter_connections2

Same as connection entity [letter_connections2](connection.md#BKMK_letter_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|letter_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [Lead_Letters](#BKMK_Lead_Letters)
- [bookableresourcebooking_Letters](#BKMK_bookableresourcebooking_Letters)
- [bookableresourcebookingheader_Letters](#BKMK_bookableresourcebookingheader_Letters)
- [BulkOperation_Letter](#BKMK_BulkOperation_Letter)
- [Campaign_Letters](#BKMK_Campaign_Letters)
- [CampaignActivity_Letters](#BKMK_CampaignActivity_Letters)
- [Contract_Letters](#BKMK_Contract_Letters)
- [entitlement_Letters](#BKMK_entitlement_Letters)
- [entitlementtemplate_Letters](#BKMK_entitlementtemplate_Letters)
- [Incident_Letters](#BKMK_Incident_Letters)
- [site_Letters](#BKMK_site_Letters)
- [service_letters](#BKMK_service_letters)
- [msdyn_playbookinstance_Letters](#BKMK_msdyn_playbookinstance_Letters)
- [Invoice_Letters](#BKMK_Invoice_Letters)
- [Opportunity_Letters](#BKMK_Opportunity_Letters)
- [Quote_Letters](#BKMK_Quote_Letters)
- [SalesOrder_Letters](#BKMK_SalesOrder_Letters)
- [msdyn_postalbum_Letters](#BKMK_msdyn_postalbum_Letters)
- [msdyn_bookingalertstatus_Letters](#BKMK_msdyn_bookingalertstatus_Letters)
- [msdyn_bookingrule_Letters](#BKMK_msdyn_bookingrule_Letters)
- [msdyn_resourceterritory_Letters](#BKMK_msdyn_resourceterritory_Letters)
- [msdyn_systemuserschedulersetting_Letters](#BKMK_msdyn_systemuserschedulersetting_Letters)
- [msdyn_timegroup_Letters](#BKMK_msdyn_timegroup_Letters)
- [msdyn_timegroupdetail_Letters](#BKMK_msdyn_timegroupdetail_Letters)
- [msdyn_processnotes_Letters](#BKMK_msdyn_processnotes_Letters)
- [msdyn_projectteam_Letters](#BKMK_msdyn_projectteam_Letters)
- [msdyn_agreement_Letters](#BKMK_msdyn_agreement_Letters)
- [msdyn_agreementbookingdate_Letters](#BKMK_msdyn_agreementbookingdate_Letters)
- [msdyn_agreementbookingincident_Letters](#BKMK_msdyn_agreementbookingincident_Letters)
- [msdyn_agreementbookingproduct_Letters](#BKMK_msdyn_agreementbookingproduct_Letters)
- [msdyn_agreementbookingservice_Letters](#BKMK_msdyn_agreementbookingservice_Letters)
- [msdyn_agreementbookingservicetask_Letters](#BKMK_msdyn_agreementbookingservicetask_Letters)
- [msdyn_agreementbookingsetup_Letters](#BKMK_msdyn_agreementbookingsetup_Letters)
- [msdyn_agreementinvoicedate_Letters](#BKMK_msdyn_agreementinvoicedate_Letters)
- [msdyn_agreementinvoiceproduct_Letters](#BKMK_msdyn_agreementinvoiceproduct_Letters)
- [msdyn_agreementinvoicesetup_Letters](#BKMK_msdyn_agreementinvoicesetup_Letters)
- [msdyn_bookingtimestamp_Letters](#BKMK_msdyn_bookingtimestamp_Letters)
- [msdyn_customerasset_Letters](#BKMK_msdyn_customerasset_Letters)
- [msdyn_fieldservicesetting_Letters](#BKMK_msdyn_fieldservicesetting_Letters)
- [msdyn_incidenttypecharacteristic_Letters](#BKMK_msdyn_incidenttypecharacteristic_Letters)
- [msdyn_incidenttypeproduct_Letters](#BKMK_msdyn_incidenttypeproduct_Letters)
- [msdyn_incidenttypeservice_Letters](#BKMK_msdyn_incidenttypeservice_Letters)
- [msdyn_inventoryadjustment_Letters](#BKMK_msdyn_inventoryadjustment_Letters)
- [msdyn_inventoryadjustmentproduct_Letters](#BKMK_msdyn_inventoryadjustmentproduct_Letters)
- [msdyn_inventoryjournal_Letters](#BKMK_msdyn_inventoryjournal_Letters)
- [msdyn_inventorytransfer_Letters](#BKMK_msdyn_inventorytransfer_Letters)
- [msdyn_payment_Letters](#BKMK_msdyn_payment_Letters)
- [msdyn_paymentdetail_Letters](#BKMK_msdyn_paymentdetail_Letters)
- [msdyn_paymentmethod_Letters](#BKMK_msdyn_paymentmethod_Letters)
- [msdyn_paymentterm_Letters](#BKMK_msdyn_paymentterm_Letters)
- [msdyn_postalcode_Letters](#BKMK_msdyn_postalcode_Letters)
- [msdyn_productinventory_Letters](#BKMK_msdyn_productinventory_Letters)
- [msdyn_purchaseorder_Letters](#BKMK_msdyn_purchaseorder_Letters)
- [msdyn_purchaseorderbill_Letters](#BKMK_msdyn_purchaseorderbill_Letters)
- [msdyn_purchaseorderproduct_Letters](#BKMK_msdyn_purchaseorderproduct_Letters)
- [msdyn_purchaseorderreceipt_Letters](#BKMK_msdyn_purchaseorderreceipt_Letters)
- [msdyn_purchaseorderreceiptproduct_Letters](#BKMK_msdyn_purchaseorderreceiptproduct_Letters)
- [msdyn_purchaseordersubstatus_Letters](#BKMK_msdyn_purchaseordersubstatus_Letters)
- [msdyn_quotebookingincident_Letters](#BKMK_msdyn_quotebookingincident_Letters)
- [msdyn_quotebookingproduct_Letters](#BKMK_msdyn_quotebookingproduct_Letters)
- [msdyn_quotebookingservice_Letters](#BKMK_msdyn_quotebookingservice_Letters)
- [msdyn_quotebookingservicetask_Letters](#BKMK_msdyn_quotebookingservicetask_Letters)
- [msdyn_rma_Letters](#BKMK_msdyn_rma_Letters)
- [msdyn_rmaproduct_Letters](#BKMK_msdyn_rmaproduct_Letters)
- [msdyn_rmareceipt_Letters](#BKMK_msdyn_rmareceipt_Letters)
- [msdyn_rmareceiptproduct_Letters](#BKMK_msdyn_rmareceiptproduct_Letters)
- [msdyn_rmasubstatus_Letters](#BKMK_msdyn_rmasubstatus_Letters)
- [msdyn_rtv_Letters](#BKMK_msdyn_rtv_Letters)
- [msdyn_rtvproduct_Letters](#BKMK_msdyn_rtvproduct_Letters)
- [msdyn_rtvsubstatus_Letters](#BKMK_msdyn_rtvsubstatus_Letters)
- [msdyn_shipvia_Letters](#BKMK_msdyn_shipvia_Letters)
- [msdyn_timeoffrequest_Letters](#BKMK_msdyn_timeoffrequest_Letters)
- [msdyn_warehouse_Letters](#BKMK_msdyn_warehouse_Letters)
- [msdyn_workorder_Letters](#BKMK_msdyn_workorder_Letters)
- [msdyn_workordercharacteristic_Letters](#BKMK_msdyn_workordercharacteristic_Letters)
- [msdyn_workorderincident_Letters](#BKMK_msdyn_workorderincident_Letters)
- [msdyn_workorderproduct_Letters](#BKMK_msdyn_workorderproduct_Letters)
- [msdyn_workorderresourcerestriction_Letters](#BKMK_msdyn_workorderresourcerestriction_Letters)
- [msdyn_workorderservice_Letters](#BKMK_msdyn_workorderservice_Letters)
- [msdyn_workorderservicetask_Letters](#BKMK_msdyn_workorderservicetask_Letters)
- [KnowledgeBaseRecord_Letters](#BKMK_KnowledgeBaseRecord_Letters)
- [Contact_Letters](#BKMK_Contact_Letters)
- [sla_letter](#BKMK_sla_letter)
- [activity_pointer_letter](#BKMK_activity_pointer_letter)
- [team_letter](#BKMK_team_letter)
- [processstage_letters](#BKMK_processstage_letters)
- [user_letter](#BKMK_user_letter)
- [KnowledgeArticle_Letters](#BKMK_KnowledgeArticle_Letters)
- [lk_letter_createdby](#BKMK_lk_letter_createdby)
- [TransactionCurrency_Letter](#BKMK_TransactionCurrency_Letter)
- [lk_letter_modifiedby](#BKMK_lk_letter_modifiedby)
- [Account_Letters](#BKMK_Account_Letters)
- [lk_letter_createdonbehalfby](#BKMK_lk_letter_createdonbehalfby)
- [business_unit_letter_activities](#BKMK_business_unit_letter_activities)
- [manualsla_letter](#BKMK_manualsla_letter)
- [lk_letter_modifiedonbehalfby](#BKMK_lk_letter_modifiedonbehalfby)


### <a name="BKMK_Lead_Letters"></a> Lead_Letters

**Added by**: Lead Management Solution

See lead Entity [Lead_Letters](lead.md#BKMK_Lead_Letters) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_Letters"></a> bookableresourcebooking_Letters

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [bookableresourcebooking_Letters](bookableresourcebooking.md#BKMK_bookableresourcebooking_Letters) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_Letters"></a> bookableresourcebookingheader_Letters

**Added by**: Scheduling Solution

See bookableresourcebookingheader Entity [bookableresourcebookingheader_Letters](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Letters) One-To-Many relationship.

### <a name="BKMK_BulkOperation_Letter"></a> BulkOperation_Letter

**Added by**: Marketing Solution

See bulkoperation Entity [BulkOperation_Letter](bulkoperation.md#BKMK_BulkOperation_Letter) One-To-Many relationship.

### <a name="BKMK_Campaign_Letters"></a> Campaign_Letters

**Added by**: Marketing Solution

See campaign Entity [Campaign_Letters](campaign.md#BKMK_Campaign_Letters) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_Letters"></a> CampaignActivity_Letters

**Added by**: Marketing Solution

See campaignactivity Entity [CampaignActivity_Letters](campaignactivity.md#BKMK_CampaignActivity_Letters) One-To-Many relationship.

### <a name="BKMK_Contract_Letters"></a> Contract_Letters

**Added by**: Service Solution

See contract Entity [Contract_Letters](contract.md#BKMK_Contract_Letters) One-To-Many relationship.

### <a name="BKMK_entitlement_Letters"></a> entitlement_Letters

**Added by**: Service Solution

See entitlement Entity [entitlement_Letters](entitlement.md#BKMK_entitlement_Letters) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_Letters"></a> entitlementtemplate_Letters

**Added by**: Service Solution

See entitlementtemplate Entity [entitlementtemplate_Letters](entitlementtemplate.md#BKMK_entitlementtemplate_Letters) One-To-Many relationship.

### <a name="BKMK_Incident_Letters"></a> Incident_Letters

**Added by**: Service Solution

See incident Entity [Incident_Letters](incident.md#BKMK_Incident_Letters) One-To-Many relationship.

### <a name="BKMK_site_Letters"></a> site_Letters

**Added by**: Service Solution

See site Entity [site_Letters](site.md#BKMK_site_Letters) One-To-Many relationship.

### <a name="BKMK_service_letters"></a> service_letters

**Added by**: Service Solution

See service Entity [service_letters](service.md#BKMK_service_letters) One-To-Many relationship.

### <a name="BKMK_msdyn_playbookinstance_Letters"></a> msdyn_playbookinstance_Letters

**Added by**: Playbook Solution

See msdyn_playbookinstance Entity [msdyn_playbookinstance_Letters](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_Letters) One-To-Many relationship.

### <a name="BKMK_Invoice_Letters"></a> Invoice_Letters

**Added by**: Sales Solution

See invoice Entity [Invoice_Letters](invoice.md#BKMK_Invoice_Letters) One-To-Many relationship.

### <a name="BKMK_Opportunity_Letters"></a> Opportunity_Letters

**Added by**: Sales Solution

See opportunity Entity [Opportunity_Letters](opportunity.md#BKMK_Opportunity_Letters) One-To-Many relationship.

### <a name="BKMK_Quote_Letters"></a> Quote_Letters

**Added by**: Sales Solution

See quote Entity [Quote_Letters](quote.md#BKMK_Quote_Letters) One-To-Many relationship.

### <a name="BKMK_SalesOrder_Letters"></a> SalesOrder_Letters

**Added by**: Sales Solution

See salesorder Entity [SalesOrder_Letters](salesorder.md#BKMK_SalesOrder_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_Letters"></a> msdyn_postalbum_Letters

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_Letters](msdyn_postalbum.md#BKMK_msdyn_postalbum_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_Letters"></a> msdyn_bookingalertstatus_Letters

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_Letters](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_Letters"></a> msdyn_bookingrule_Letters

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_Letters](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_Letters"></a> msdyn_resourceterritory_Letters

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_Letters](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_Letters"></a> msdyn_systemuserschedulersetting_Letters

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_Letters](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_Letters"></a> msdyn_timegroup_Letters

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_Letters](msdyn_timegroup.md#BKMK_msdyn_timegroup_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_Letters"></a> msdyn_timegroupdetail_Letters

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_Letters](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_Letters"></a> msdyn_processnotes_Letters

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_Letters](msdyn_processnotes.md#BKMK_msdyn_processnotes_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_Letters"></a> msdyn_projectteam_Letters

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_Letters](msdyn_projectteam.md#BKMK_msdyn_projectteam_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_Letters"></a> msdyn_agreement_Letters

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_Letters](msdyn_agreement.md#BKMK_msdyn_agreement_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_Letters"></a> msdyn_agreementbookingdate_Letters

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_Letters](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_Letters"></a> msdyn_agreementbookingincident_Letters

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_Letters](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_Letters"></a> msdyn_agreementbookingproduct_Letters

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_Letters](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_Letters"></a> msdyn_agreementbookingservice_Letters

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_Letters](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_Letters"></a> msdyn_agreementbookingservicetask_Letters

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_Letters](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_Letters"></a> msdyn_agreementbookingsetup_Letters

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_Letters](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_Letters"></a> msdyn_agreementinvoicedate_Letters

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_Letters](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_Letters"></a> msdyn_agreementinvoiceproduct_Letters

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_Letters](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_Letters"></a> msdyn_agreementinvoicesetup_Letters

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_Letters](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_Letters"></a> msdyn_bookingtimestamp_Letters

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_Letters](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_Letters"></a> msdyn_customerasset_Letters

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_Letters](msdyn_customerasset.md#BKMK_msdyn_customerasset_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_Letters"></a> msdyn_fieldservicesetting_Letters

**Added by**: Field Service Solution

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_Letters](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_Letters"></a> msdyn_incidenttypecharacteristic_Letters

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_Letters](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_Letters"></a> msdyn_incidenttypeproduct_Letters

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_Letters](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_Letters"></a> msdyn_incidenttypeservice_Letters

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_Letters](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_Letters"></a> msdyn_inventoryadjustment_Letters

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_Letters](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Letters"></a> msdyn_inventoryadjustmentproduct_Letters

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_Letters](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_Letters"></a> msdyn_inventoryjournal_Letters

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_Letters](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_Letters"></a> msdyn_inventorytransfer_Letters

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_Letters](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_Letters"></a> msdyn_payment_Letters

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_Letters](msdyn_payment.md#BKMK_msdyn_payment_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_Letters"></a> msdyn_paymentdetail_Letters

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_Letters](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_Letters"></a> msdyn_paymentmethod_Letters

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_Letters](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_Letters"></a> msdyn_paymentterm_Letters

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_Letters](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_Letters"></a> msdyn_postalcode_Letters

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_Letters](msdyn_postalcode.md#BKMK_msdyn_postalcode_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_Letters"></a> msdyn_productinventory_Letters

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_Letters](msdyn_productinventory.md#BKMK_msdyn_productinventory_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_Letters"></a> msdyn_purchaseorder_Letters

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_Letters](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_Letters"></a> msdyn_purchaseorderbill_Letters

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_Letters](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_Letters"></a> msdyn_purchaseorderproduct_Letters

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_Letters](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_Letters"></a> msdyn_purchaseorderreceipt_Letters

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_Letters](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Letters"></a> msdyn_purchaseorderreceiptproduct_Letters

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_Letters](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_Letters"></a> msdyn_purchaseordersubstatus_Letters

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_Letters](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_Letters"></a> msdyn_quotebookingincident_Letters

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_Letters](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_Letters"></a> msdyn_quotebookingproduct_Letters

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_Letters](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_Letters"></a> msdyn_quotebookingservice_Letters

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_Letters](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_Letters"></a> msdyn_quotebookingservicetask_Letters

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_Letters](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_Letters"></a> msdyn_rma_Letters

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_Letters](msdyn_rma.md#BKMK_msdyn_rma_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_Letters"></a> msdyn_rmaproduct_Letters

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_Letters](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_Letters"></a> msdyn_rmareceipt_Letters

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_Letters](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_Letters"></a> msdyn_rmareceiptproduct_Letters

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_Letters](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_Letters"></a> msdyn_rmasubstatus_Letters

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_Letters](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_Letters"></a> msdyn_rtv_Letters

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_Letters](msdyn_rtv.md#BKMK_msdyn_rtv_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_Letters"></a> msdyn_rtvproduct_Letters

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_Letters](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_Letters"></a> msdyn_rtvsubstatus_Letters

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_Letters](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_Letters"></a> msdyn_shipvia_Letters

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_Letters](msdyn_shipvia.md#BKMK_msdyn_shipvia_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_Letters"></a> msdyn_timeoffrequest_Letters

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_Letters](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_Letters"></a> msdyn_warehouse_Letters

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_Letters](msdyn_warehouse.md#BKMK_msdyn_warehouse_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_Letters"></a> msdyn_workorder_Letters

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_Letters](msdyn_workorder.md#BKMK_msdyn_workorder_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_Letters"></a> msdyn_workordercharacteristic_Letters

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_Letters](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_Letters"></a> msdyn_workorderincident_Letters

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_Letters](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_Letters"></a> msdyn_workorderproduct_Letters

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_Letters](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_Letters"></a> msdyn_workorderresourcerestriction_Letters

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_Letters](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_Letters"></a> msdyn_workorderservice_Letters

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_Letters](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Letters) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_Letters"></a> msdyn_workorderservicetask_Letters

**Added by**: Field Service Solution

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_Letters](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Letters) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_Letters"></a> KnowledgeBaseRecord_Letters

See knowledgebaserecord Entity [KnowledgeBaseRecord_Letters](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_Letters) One-To-Many relationship.

### <a name="BKMK_Contact_Letters"></a> Contact_Letters

See contact Entity [Contact_Letters](contact.md#BKMK_Contact_Letters) One-To-Many relationship.

### <a name="BKMK_sla_letter"></a> sla_letter

See sla Entity [sla_letter](sla.md#BKMK_sla_letter) One-To-Many relationship.

### <a name="BKMK_activity_pointer_letter"></a> activity_pointer_letter

See activitypointer Entity [activity_pointer_letter](activitypointer.md#BKMK_activity_pointer_letter) One-To-Many relationship.

### <a name="BKMK_team_letter"></a> team_letter

See team Entity [team_letter](team.md#BKMK_team_letter) One-To-Many relationship.

### <a name="BKMK_processstage_letters"></a> processstage_letters

See processstage Entity [processstage_letters](processstage.md#BKMK_processstage_letters) One-To-Many relationship.

### <a name="BKMK_user_letter"></a> user_letter

See systemuser Entity [user_letter](systemuser.md#BKMK_user_letter) One-To-Many relationship.

### <a name="BKMK_KnowledgeArticle_Letters"></a> KnowledgeArticle_Letters

See knowledgearticle Entity [KnowledgeArticle_Letters](knowledgearticle.md#BKMK_KnowledgeArticle_Letters) One-To-Many relationship.

### <a name="BKMK_lk_letter_createdby"></a> lk_letter_createdby

See systemuser Entity [lk_letter_createdby](systemuser.md#BKMK_lk_letter_createdby) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_Letter"></a> TransactionCurrency_Letter

See transactioncurrency Entity [TransactionCurrency_Letter](transactioncurrency.md#BKMK_TransactionCurrency_Letter) One-To-Many relationship.

### <a name="BKMK_lk_letter_modifiedby"></a> lk_letter_modifiedby

See systemuser Entity [lk_letter_modifiedby](systemuser.md#BKMK_lk_letter_modifiedby) One-To-Many relationship.

### <a name="BKMK_Account_Letters"></a> Account_Letters

See account Entity [Account_Letters](account.md#BKMK_Account_Letters) One-To-Many relationship.

### <a name="BKMK_lk_letter_createdonbehalfby"></a> lk_letter_createdonbehalfby

See systemuser Entity [lk_letter_createdonbehalfby](systemuser.md#BKMK_lk_letter_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_business_unit_letter_activities"></a> business_unit_letter_activities

See businessunit Entity [business_unit_letter_activities](businessunit.md#BKMK_business_unit_letter_activities) One-To-Many relationship.

### <a name="BKMK_manualsla_letter"></a> manualsla_letter

See sla Entity [manualsla_letter](sla.md#BKMK_manualsla_letter) One-To-Many relationship.

### <a name="BKMK_lk_letter_modifiedonbehalfby"></a> lk_letter_modifiedonbehalfby

See systemuser Entity [lk_letter_modifiedonbehalfby](systemuser.md#BKMK_lk_letter_modifiedonbehalfby) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.letter?text=letter EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]