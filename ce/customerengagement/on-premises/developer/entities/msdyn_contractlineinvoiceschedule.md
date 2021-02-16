---
title: "msdyn_contractlineinvoiceschedule Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_contractlineinvoiceschedule entity."
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
# msdyn_contractlineinvoiceschedule Entity Reference

List of dates that shows when invoicing for this customer should be run. This list is used by the invoice creation job.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_contractlineinvoiceschedules<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_contractlineinvoiceschedules(*msdyn_contractlineinvoicescheduleid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_contractlineinvoiceschedules(*msdyn_contractlineinvoicescheduleid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_contractlineinvoiceschedules<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_contractlineinvoiceschedules(*msdyn_contractlineinvoicescheduleid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_contractlineinvoiceschedules(*msdyn_contractlineinvoicescheduleid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_contractlineinvoiceschedules|
|DisplayCollectionName|Project Contract Line Invoice Schedules|
|DisplayName|Project Contract Line Invoice Schedule|
|EntitySetName|msdyn_contractlineinvoiceschedules|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_contractlineinvoiceschedules|
|LogicalName|msdyn_contractlineinvoiceschedule|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_contractlineinvoicescheduleid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_contractlineinvoiceschedule|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ContractLine](#BKMK_msdyn_ContractLine)
- [msdyn_ContractLineId](#BKMK_msdyn_ContractLineId)
- [msdyn_contractlineinvoicescheduleId](#BKMK_msdyn_contractlineinvoicescheduleId)
- [msdyn_ContractLineScheduleOfValue](#BKMK_msdyn_ContractLineScheduleOfValue)
- [msdyn_Invoice](#BKMK_msdyn_Invoice)
- [msdyn_InvoiceRunDate](#BKMK_msdyn_InvoiceRunDate)
- [msdyn_InvoiceRunStatus](#BKMK_msdyn_InvoiceRunStatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_transactioncutoffdate](#BKMK_msdyn_transactioncutoffdate)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


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


### <a name="BKMK_msdyn_ContractLine"></a> msdyn_ContractLine

|Property|Value|
|--------|-----|
|Description|(Deprecated) Shows the associated project contract line for this invoice schedule.|
|DisplayName|(Deprecated) Project Contract Line|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contractline|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ContractLineId"></a> msdyn_ContractLineId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Project Contract Line associated with Project Contract Line Invoice Schedule.|
|DisplayName|Project Contract Line|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contractlineid|
|RequiredLevel|None|
|Targets|salesorderdetail|
|Type|Lookup|


### <a name="BKMK_msdyn_contractlineinvoicescheduleId"></a> msdyn_contractlineinvoicescheduleId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Project Contract Line Invoice Schedule|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_contractlineinvoicescheduleid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_ContractLineScheduleOfValue"></a> msdyn_ContractLineScheduleOfValue

|Property|Value|
|--------|-----|
|Description|Select the billing milestone for a project contract line.|
|DisplayName|Project Contract Line Milestone|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contractlinescheduleofvalue|
|RequiredLevel|None|
|Targets|msdyn_contractlinescheduleofvalue|
|Type|Lookup|


### <a name="BKMK_msdyn_Invoice"></a> msdyn_Invoice

|Property|Value|
|--------|-----|
|Description|Select the Invoice associated with Project contract line invoice schedule.|
|DisplayName|Invoice|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoice|
|RequiredLevel|None|
|Targets|invoice|
|Type|Lookup|


### <a name="BKMK_msdyn_InvoiceRunDate"></a> msdyn_InvoiceRunDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date on which invoice should get created|
|DisplayName|Invoice Run Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicerundate|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_msdyn_InvoiceRunStatus"></a> msdyn_InvoiceRunStatus

|Property|Value|
|--------|-----|
|Description|Select the invoice status, for example, Not Run, Run Successful, or Run Failed.|
|DisplayName|Invoice Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicerunstatus|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_InvoiceRunStatus Options

|Value|Label|
|-----|-----|
|192350000|Not Run|
|192350001|Run Successful|
|192350002|Run Failed|



### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Type the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_transactioncutoffdate"></a> msdyn_transactioncutoffdate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date before or on which the transaction will be picked for invoicing by the invoice creation job.|
|DisplayName|Transaction Cut Off Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncutoffdate|
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


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the project contract line invoice schedule|
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
|Description|Reason for the status of the project contract line invoice schedule|
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
- [msdyn_ContractLineIdName](#BKMK_msdyn_ContractLineIdName)
- [msdyn_ContractLineScheduleOfValueName](#BKMK_msdyn_ContractLineScheduleOfValueName)
- [msdyn_InvoiceName](#BKMK_msdyn_InvoiceName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [VersionNumber](#BKMK_VersionNumber)


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


### <a name="BKMK_msdyn_ContractLineIdName"></a> msdyn_ContractLineIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_contractlineidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ContractLineScheduleOfValueName"></a> msdyn_ContractLineScheduleOfValueName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_contractlinescheduleofvaluename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_InvoiceName"></a> msdyn_InvoiceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_invoicename|
|MaxLength|300|
|RequiredLevel|None|
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

- [msdyn_contractlineinvoiceschedule_SyncErrors](#BKMK_msdyn_contractlineinvoiceschedule_SyncErrors)
- [msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord](#BKMK_msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord)
- [msdyn_contractlineinvoiceschedule_DuplicateBaseRecord](#BKMK_msdyn_contractlineinvoiceschedule_DuplicateBaseRecord)
- [msdyn_contractlineinvoiceschedule_AsyncOperations](#BKMK_msdyn_contractlineinvoiceschedule_AsyncOperations)
- [msdyn_contractlineinvoiceschedule_MailboxTrackingFolders](#BKMK_msdyn_contractlineinvoiceschedule_MailboxTrackingFolders)
- [msdyn_contractlineinvoiceschedule_ProcessSession](#BKMK_msdyn_contractlineinvoiceschedule_ProcessSession)
- [msdyn_contractlineinvoiceschedule_BulkDeleteFailures](#BKMK_msdyn_contractlineinvoiceschedule_BulkDeleteFailures)
- [msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses](#BKMK_msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_contractlineinvoiceschedule_SyncErrors"></a> msdyn_contractlineinvoiceschedule_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_contractlineinvoiceschedule_SyncErrors](syncerror.md#BKMK_msdyn_contractlineinvoiceschedule_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlineinvoiceschedule_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord"></a> msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlineinvoiceschedule_DuplicateBaseRecord"></a> msdyn_contractlineinvoiceschedule_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_contractlineinvoiceschedule_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_contractlineinvoiceschedule_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlineinvoiceschedule_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlineinvoiceschedule_AsyncOperations"></a> msdyn_contractlineinvoiceschedule_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_contractlineinvoiceschedule_AsyncOperations](asyncoperation.md#BKMK_msdyn_contractlineinvoiceschedule_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlineinvoiceschedule_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlineinvoiceschedule_MailboxTrackingFolders"></a> msdyn_contractlineinvoiceschedule_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_contractlineinvoiceschedule_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_contractlineinvoiceschedule_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlineinvoiceschedule_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlineinvoiceschedule_ProcessSession"></a> msdyn_contractlineinvoiceschedule_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_contractlineinvoiceschedule_ProcessSession](processsession.md#BKMK_msdyn_contractlineinvoiceschedule_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlineinvoiceschedule_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlineinvoiceschedule_BulkDeleteFailures"></a> msdyn_contractlineinvoiceschedule_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_contractlineinvoiceschedule_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_contractlineinvoiceschedule_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlineinvoiceschedule_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses"></a> msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_contractlineinvoiceschedule_createdby](#BKMK_lk_msdyn_contractlineinvoiceschedule_createdby)
- [lk_msdyn_contractlineinvoiceschedule_createdonbehalfby](#BKMK_lk_msdyn_contractlineinvoiceschedule_createdonbehalfby)
- [lk_msdyn_contractlineinvoiceschedule_modifiedby](#BKMK_lk_msdyn_contractlineinvoiceschedule_modifiedby)
- [lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby](#BKMK_lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby)
- [organization_msdyn_contractlineinvoiceschedule](#BKMK_organization_msdyn_contractlineinvoiceschedule)
- [msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule](#BKMK_msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule)
- [msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice](#BKMK_msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice)
- [msdyn_salesorderdetail_msdyn_contractlineinvoic](#BKMK_msdyn_salesorderdetail_msdyn_contractlineinvoic)


### <a name="BKMK_lk_msdyn_contractlineinvoiceschedule_createdby"></a> lk_msdyn_contractlineinvoiceschedule_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_contractlineinvoiceschedule_createdby](systemuser.md#BKMK_lk_msdyn_contractlineinvoiceschedule_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_contractlineinvoiceschedule_createdonbehalfby"></a> lk_msdyn_contractlineinvoiceschedule_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_contractlineinvoiceschedule_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_contractlineinvoiceschedule_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_contractlineinvoiceschedule_modifiedby"></a> lk_msdyn_contractlineinvoiceschedule_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_contractlineinvoiceschedule_modifiedby](systemuser.md#BKMK_lk_msdyn_contractlineinvoiceschedule_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby"></a> lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_contractlineinvoiceschedule"></a> organization_msdyn_contractlineinvoiceschedule

**Added by**: System Solution Solution

See organization Entity [organization_msdyn_contractlineinvoiceschedule](organization.md#BKMK_organization_msdyn_contractlineinvoiceschedule) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule"></a> msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule

See msdyn_contractlinescheduleofvalue Entity [msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule](msdyn_contractlinescheduleofvalue.md#BKMK_msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule) One-To-Many relationship.

### <a name="BKMK_msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice"></a> msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice

**Added by**: Sales Solution

See invoice Entity [msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice](invoice.md#BKMK_msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice) One-To-Many relationship.

### <a name="BKMK_msdyn_salesorderdetail_msdyn_contractlineinvoic"></a> msdyn_salesorderdetail_msdyn_contractlineinvoic

**Added by**: Sales Solution

See salesorderdetail Entity [msdyn_salesorderdetail_msdyn_contractlineinvoic](salesorderdetail.md#BKMK_msdyn_salesorderdetail_msdyn_contractlineinvoic) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_contractlineinvoiceschedule?text=msdyn_contractlineinvoiceschedule EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]