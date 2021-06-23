---
title: "msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d entity."
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
# msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d Entity Reference

Base entity for process Invoice Process

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470ds<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470ds(*businessprocessflowinstanceid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470ds(*businessprocessflowinstanceid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470ds<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470ds(*businessprocessflowinstanceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470ds(*businessprocessflowinstanceid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470ds|
|DisplayCollectionName|Invoice Process|
|DisplayName|Invoice Process|
|EntitySetName|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470ds|
|IsBPFEntity|True|
|LogicalCollectionName|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470ds|
|LogicalName|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|businessprocessflowinstanceid|
|PrimaryNameAttribute|bpf_name|
|SchemaName|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActiveStageId](#BKMK_ActiveStageId)
- [ActiveStageStartedOn](#BKMK_ActiveStageStartedOn)
- [bpf_invoiceid](#BKMK_bpf_invoiceid)
- [bpf_name](#BKMK_bpf_name)
- [BusinessProcessFlowInstanceId](#BKMK_BusinessProcessFlowInstanceId)
- [CompletedOn](#BKMK_CompletedOn)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ProcessId](#BKMK_ProcessId)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ActiveStageId"></a> ActiveStageId

**Added by**: Active Solution Solution

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
|Description|Date and time when current active stage is started|
|DisplayName|Active Stage Started On|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|activestagestartedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_bpf_invoiceid"></a> bpf_invoiceid

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Invoice|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|bpf_invoiceid|
|RequiredLevel|None|
|Targets|invoice|
|Type|Lookup|


### <a name="BKMK_bpf_name"></a> bpf_name

|Property|Value|
|--------|-----|
|Description|Description|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|bpf_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_BusinessProcessFlowInstanceId"></a> BusinessProcessFlowInstanceId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Invoice Process|
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

**Added by**: Active Solution Solution

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


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Invoice Process|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Invoice Process|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

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


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Added by**: Active Solution Solution

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
- [bpf_Duration](#BKMK_bpf_Duration)
- [bpf_invoiceidName](#BKMK_bpf_invoiceidName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [ProcessIdName](#BKMK_ProcessIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ActiveStageIdName"></a> ActiveStageIdName

**Added by**: Active Solution Solution

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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_bpf_Duration"></a> bpf_Duration

|Property|Value|
|--------|-----|
|Description|Duration of Business Process Flow|
|DisplayName|Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|bpf_duration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_bpf_invoiceidName"></a> bpf_invoiceidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bpf_invoiceidname|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|None|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

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

- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors](syncerror.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations](asyncoperation.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs

**Added by**: System Solution Solution

Same as workflowlog entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs](workflowlog.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|workflowlog|
|ReferencingAttribute|asyncoperationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession](processsession.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdby](#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdby)
- [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby](#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby)
- [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedby](#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedby)
- [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby](#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby)
- [organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d](#BKMK_organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d)
- [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid](#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid)
- [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid](#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid)
- [bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d](#BKMK_bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d)


### <a name="BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdby"></a> lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdby](systemuser.md#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby"></a> lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedby"></a> lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedby](systemuser.md#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby"></a> lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d"></a> organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d

**Added by**: System Solution Solution

See organization Entity [organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d](organization.md#BKMK_organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid"></a> lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid

**Added by**: System Solution Solution

See processstage Entity [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid](processstage.md#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid"></a> lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid

**Added by**: System Solution Solution

See workflow Entity [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid](workflow.md#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid) One-To-Many relationship.

### <a name="BKMK_bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d"></a> bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d

**Added by**: Sales Solution

See invoice Entity [bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d](invoice.md#BKMK_bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d?text=msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]