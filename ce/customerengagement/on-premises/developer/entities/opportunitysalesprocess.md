---
title: "OpportunitySalesProcess Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the OpportunitySalesProcess entity."
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
# OpportunitySalesProcess Entity Reference

Base entity for process Opportunity Sales Process

**Added by**: Sales Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/opportunitysalesprocesses<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/opportunitysalesprocesses(*businessprocessflowinstanceid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/opportunitysalesprocesses(*businessprocessflowinstanceid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/opportunitysalesprocesses<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/opportunitysalesprocesses(*businessprocessflowinstanceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/opportunitysalesprocesses(*businessprocessflowinstanceid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|OpportunitySalesProcesses|
|DisplayCollectionName|Opportunity Sales Process|
|DisplayName|Opportunity Sales Process|
|EntitySetName|opportunitysalesprocesses|
|IsBPFEntity|True|
|LogicalCollectionName|opportunitysalesprocesses|
|LogicalName|opportunitysalesprocess|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|businessprocessflowinstanceid|
|PrimaryNameAttribute|name|
|SchemaName|OpportunitySalesProcess|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActiveStageId](#BKMK_ActiveStageId)
- [ActiveStageStartedOn](#BKMK_ActiveStageStartedOn)
- [bpf_quoteid](#BKMK_bpf_quoteid)
- [bpf_salesorderid](#BKMK_bpf_salesorderid)
- [BusinessProcessFlowInstanceId](#BKMK_BusinessProcessFlowInstanceId)
- [CompletedOn](#BKMK_CompletedOn)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OpportunityId](#BKMK_OpportunityId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ProcessId](#BKMK_ProcessId)
- [QuoteId](#BKMK_QuoteId)
- [SalesOrderId](#BKMK_SalesOrderId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ActiveStageId"></a> ActiveStageId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the active stage for the Business Process Flow instance.|
|DisplayName|Active Stage|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|activestageid|
|RequiredLevel|None|
|Targets|processstage|
|Type|Lookup|


### <a name="BKMK_ActiveStageStartedOn"></a> ActiveStageStartedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when current active stage is started.|
|DisplayName|Active Stage Started On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|activestagestartedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_bpf_quoteid"></a> bpf_quoteid

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|quote|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|bpf_quoteid|
|RequiredLevel|None|
|Targets|quote|
|Type|Lookup|


### <a name="BKMK_bpf_salesorderid"></a> bpf_salesorderid

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|salesorder|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|bpf_salesorderid|
|RequiredLevel|None|
|Targets|salesorder|
|Type|Lookup|


### <a name="BKMK_BusinessProcessFlowInstanceId"></a> BusinessProcessFlowInstanceId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Opportunity Sales Process bpf entity instances|
|DisplayName|Opportunity Sales Process Instance Id|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|businessprocessflowinstanceid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_CompletedOn"></a> CompletedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when Business Process Flow instance is completed.|
|DisplayName|Completed On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|completedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
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


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Process Name.|
|DisplayName|Process Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|200|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_OpportunityId"></a> OpportunityId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the workflow associated to the Business Process Flow instance.|
|DisplayName|Opportunity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|opportunityid|
|RequiredLevel|None|
|Targets|opportunity|
|Type|Lookup|


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


### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the workflow associated to the Business Process Flow instance.|
|DisplayName|Process|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Targets|workflow|
|Type|Lookup|


### <a name="BKMK_QuoteId"></a> QuoteId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the workflow associated to the Business Process Flow instance.|
|DisplayName|Related Quote|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|quoteid|
|RequiredLevel|None|
|Targets|quote|
|Type|Lookup|


### <a name="BKMK_SalesOrderId"></a> SalesOrderId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the workflow associated to the Business Process Flow instance.|
|DisplayName|Related Sales Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|salesorderid|
|RequiredLevel|None|
|Targets|salesorder|
|Type|Lookup|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the Delve action record is pending, completed, or tracking.|
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



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the delve action record status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Finished|1|
|3|Aborted|1|



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
|Description|Comma delimited string of process stage ids that represent visited stages of the Business Process Flow instance.|
|DisplayName|Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
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

- [ActiveStageIdName](#BKMK_ActiveStageIdName)
- [bpf_quoteidName](#BKMK_bpf_quoteidName)
- [bpf_salesorderidName](#BKMK_bpf_salesorderidName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [Duration](#BKMK_Duration)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OpportunityIdName](#BKMK_OpportunityIdName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [ProcessIdName](#BKMK_ProcessIdName)
- [QuoteIdName](#BKMK_QuoteIdName)
- [SalesOrderIdName](#BKMK_SalesOrderIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ActiveStageIdName"></a> ActiveStageIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|activestageidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_bpf_quoteidName"></a> bpf_quoteidName

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bpf_quoteidname|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_bpf_salesorderidName"></a> bpf_salesorderidName

**Added by**: Project Service Automation Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bpf_salesorderidname|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
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
|Description|Unique identifier of the delegate user who created the record.|
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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_Duration"></a> Duration

|Property|Value|
|--------|-----|
|Description|Duration the business process flow was active.|
|DisplayName|Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|duration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


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
|Description|Unique identifier of the user who modified the record.|
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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
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
|Description|Unique identifier of the delegate user who modified the record.|
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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OpportunityIdName"></a> OpportunityIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|opportunityidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
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


### <a name="BKMK_ProcessIdName"></a> ProcessIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_QuoteIdName"></a> QuoteIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|quoteidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_SalesOrderIdName"></a> SalesOrderIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|salesorderidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
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
|Description|Version Number|
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

- [OpportunitySalesProcess_SyncErrors](#BKMK_OpportunitySalesProcess_SyncErrors)
- [opportunitysalesprocess_AsyncOperations](#BKMK_opportunitysalesprocess_AsyncOperations)
- [lk_opportunitysalesprocess_workflowlogs](#BKMK_lk_opportunitysalesprocess_workflowlogs)
- [opportunitysalesprocess_MailboxTrackingFolders](#BKMK_opportunitysalesprocess_MailboxTrackingFolders)
- [opportunitysalesprocess_ProcessSession](#BKMK_opportunitysalesprocess_ProcessSession)
- [opportunitysalesprocess_BulkDeleteFailures](#BKMK_opportunitysalesprocess_BulkDeleteFailures)
- [opportunitysalesprocess_PrincipalObjectAttributeAccesses](#BKMK_opportunitysalesprocess_PrincipalObjectAttributeAccesses)


### <a name="BKMK_OpportunitySalesProcess_SyncErrors"></a> OpportunitySalesProcess_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [OpportunitySalesProcess_SyncErrors](syncerror.md#BKMK_OpportunitySalesProcess_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|OpportunitySalesProcess_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_opportunitysalesprocess_AsyncOperations"></a> opportunitysalesprocess_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [opportunitysalesprocess_AsyncOperations](asyncoperation.md#BKMK_opportunitysalesprocess_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunitysalesprocess_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_opportunitysalesprocess_workflowlogs"></a> lk_opportunitysalesprocess_workflowlogs

**Added by**: System Solution Solution

Same as workflowlog entity [lk_opportunitysalesprocess_workflowlogs](workflowlog.md#BKMK_lk_opportunitysalesprocess_workflowlogs) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|workflowlog|
|ReferencingAttribute|asyncoperationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|workflowlogs_opportunitysalesprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_opportunitysalesprocess_MailboxTrackingFolders"></a> opportunitysalesprocess_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [opportunitysalesprocess_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_opportunitysalesprocess_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunitysalesprocess_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_opportunitysalesprocess_ProcessSession"></a> opportunitysalesprocess_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [opportunitysalesprocess_ProcessSession](processsession.md#BKMK_opportunitysalesprocess_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunitysalesprocess_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_opportunitysalesprocess_BulkDeleteFailures"></a> opportunitysalesprocess_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [opportunitysalesprocess_BulkDeleteFailures](bulkdeletefailure.md#BKMK_opportunitysalesprocess_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunitysalesprocess_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_opportunitysalesprocess_PrincipalObjectAttributeAccesses"></a> opportunitysalesprocess_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [opportunitysalesprocess_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_opportunitysalesprocess_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunitysalesprocess_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_opportunitysalesprocess_createdby](#BKMK_lk_opportunitysalesprocess_createdby)
- [lk_opportunitysalesprocess_createdonbehalfby](#BKMK_lk_opportunitysalesprocess_createdonbehalfby)
- [lk_opportunitysalesprocess_modifiedby](#BKMK_lk_opportunitysalesprocess_modifiedby)
- [lk_opportunitysalesprocess_modifiedonbehalfby](#BKMK_lk_opportunitysalesprocess_modifiedonbehalfby)
- [organization_opportunitysalesprocess](#BKMK_organization_opportunitysalesprocess)
- [lk_opportunitysalesprocess_activestageid](#BKMK_lk_opportunitysalesprocess_activestageid)
- [lk_opportunitysalesprocess_processid](#BKMK_lk_opportunitysalesprocess_processid)
- [lk_opportunitysalesprocess_opportunityid](#BKMK_lk_opportunitysalesprocess_opportunityid)
- [lk_opportunitysalesprocess_quoteid](#BKMK_lk_opportunitysalesprocess_quoteid)
- [lk_opportunitysalesprocess_salesorderid](#BKMK_lk_opportunitysalesprocess_salesorderid)
- [transactioncurrency_opportunitysalesprocess](#BKMK_transactioncurrency_opportunitysalesprocess)
- [bpf_quote_OpportunitySalesProcess](#BKMK_bpf_quote_OpportunitySalesProcess)
- [bpf_salesorder_OpportunitySalesProcess](#BKMK_bpf_salesorder_OpportunitySalesProcess)


### <a name="BKMK_lk_opportunitysalesprocess_createdby"></a> lk_opportunitysalesprocess_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_opportunitysalesprocess_createdby](systemuser.md#BKMK_lk_opportunitysalesprocess_createdby) One-To-Many relationship.

### <a name="BKMK_lk_opportunitysalesprocess_createdonbehalfby"></a> lk_opportunitysalesprocess_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_opportunitysalesprocess_createdonbehalfby](systemuser.md#BKMK_lk_opportunitysalesprocess_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_opportunitysalesprocess_modifiedby"></a> lk_opportunitysalesprocess_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_opportunitysalesprocess_modifiedby](systemuser.md#BKMK_lk_opportunitysalesprocess_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_opportunitysalesprocess_modifiedonbehalfby"></a> lk_opportunitysalesprocess_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_opportunitysalesprocess_modifiedonbehalfby](systemuser.md#BKMK_lk_opportunitysalesprocess_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_opportunitysalesprocess"></a> organization_opportunitysalesprocess

**Added by**: System Solution Solution

See organization Entity [organization_opportunitysalesprocess](organization.md#BKMK_organization_opportunitysalesprocess) One-To-Many relationship.

### <a name="BKMK_lk_opportunitysalesprocess_activestageid"></a> lk_opportunitysalesprocess_activestageid

**Added by**: System Solution Solution

See processstage Entity [lk_opportunitysalesprocess_activestageid](processstage.md#BKMK_lk_opportunitysalesprocess_activestageid) One-To-Many relationship.

### <a name="BKMK_lk_opportunitysalesprocess_processid"></a> lk_opportunitysalesprocess_processid

**Added by**: System Solution Solution

See workflow Entity [lk_opportunitysalesprocess_processid](workflow.md#BKMK_lk_opportunitysalesprocess_processid) One-To-Many relationship.

### <a name="BKMK_lk_opportunitysalesprocess_opportunityid"></a> lk_opportunitysalesprocess_opportunityid

See opportunity Entity [lk_opportunitysalesprocess_opportunityid](opportunity.md#BKMK_lk_opportunitysalesprocess_opportunityid) One-To-Many relationship.

### <a name="BKMK_lk_opportunitysalesprocess_quoteid"></a> lk_opportunitysalesprocess_quoteid

See quote Entity [lk_opportunitysalesprocess_quoteid](quote.md#BKMK_lk_opportunitysalesprocess_quoteid) One-To-Many relationship.

### <a name="BKMK_lk_opportunitysalesprocess_salesorderid"></a> lk_opportunitysalesprocess_salesorderid

See salesorder Entity [lk_opportunitysalesprocess_salesorderid](salesorder.md#BKMK_lk_opportunitysalesprocess_salesorderid) One-To-Many relationship.

### <a name="BKMK_transactioncurrency_opportunitysalesprocess"></a> transactioncurrency_opportunitysalesprocess

**Added by**: System Solution Solution

See transactioncurrency Entity [transactioncurrency_opportunitysalesprocess](transactioncurrency.md#BKMK_transactioncurrency_opportunitysalesprocess) One-To-Many relationship.

### <a name="BKMK_bpf_quote_OpportunitySalesProcess"></a> bpf_quote_OpportunitySalesProcess

See quote Entity [bpf_quote_OpportunitySalesProcess](quote.md#BKMK_bpf_quote_OpportunitySalesProcess) One-To-Many relationship.

### <a name="BKMK_bpf_salesorder_OpportunitySalesProcess"></a> bpf_salesorder_OpportunitySalesProcess

See salesorder Entity [bpf_salesorder_OpportunitySalesProcess](salesorder.md#BKMK_bpf_salesorder_OpportunitySalesProcess) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.opportunitysalesprocess?text=opportunitysalesprocess EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]