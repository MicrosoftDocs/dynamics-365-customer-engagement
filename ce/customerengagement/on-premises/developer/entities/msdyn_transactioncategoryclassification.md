---
title: "msdyn_transactioncategoryclassification Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_transactioncategoryclassification entity."
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
# msdyn_transactioncategoryclassification Entity Reference

Entity used to associate a category broadly as time, expense or material.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_transactioncategoryclassifications<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_transactioncategoryclassifications(*msdyn_transactioncategoryclassificationid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_transactioncategoryclassifications(*msdyn_transactioncategoryclassificationid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_transactioncategoryclassifications<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_transactioncategoryclassifications(*msdyn_transactioncategoryclassificationid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_transactioncategoryclassifications(*msdyn_transactioncategoryclassificationid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_transactioncategoryclassifications|
|DisplayCollectionName|Transaction Category Classifications|
|DisplayName|Transaction Category Classification|
|EntitySetName|msdyn_transactioncategoryclassifications|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_transactioncategoryclassifications|
|LogicalName|msdyn_transactioncategoryclassification|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_transactioncategoryclassificationid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_transactioncategoryclassification|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_transactioncategory](#BKMK_msdyn_transactioncategory)
- [msdyn_transactioncategoryclassificationId](#BKMK_msdyn_transactioncategoryclassificationId)
- [msdyn_transactionclassification](#BKMK_msdyn_transactionclassification)
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


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|The name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_transactioncategory"></a> msdyn_transactioncategory

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Transaction Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategory|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_transactioncategory|
|Type|Lookup|


### <a name="BKMK_msdyn_transactioncategoryclassificationId"></a> msdyn_transactioncategoryclassificationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Transaction Category Classification|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_transactioncategoryclassificationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_transactionclassification"></a> msdyn_transactionclassification

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Transaction Classification|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactionclassification|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_transactionclassification Options

|Value|Label|
|-----|-----|
|192350000|Time|
|192350001|Expense|
|192350002|Material|
|192350003|Milestone|
|192350004|Fee|
|690970000|Commission|
|690970001|Additional|
|690970002|Tax|



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
|Description|Status of the Transaction Category Classification|
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
|Description|Reason for the status of the Transaction Category Classification|
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
- [msdyn_transactioncategoryName](#BKMK_msdyn_transactioncategoryName)
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


### <a name="BKMK_msdyn_transactioncategoryName"></a> msdyn_transactioncategoryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategoryname|
|MaxLength|100|
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

- [msdyn_transactioncategoryclassification_SyncErrors](#BKMK_msdyn_transactioncategoryclassification_SyncErrors)
- [msdyn_transactioncategoryclassification_DuplicateMatchingRecord](#BKMK_msdyn_transactioncategoryclassification_DuplicateMatchingRecord)
- [msdyn_transactioncategoryclassification_DuplicateBaseRecord](#BKMK_msdyn_transactioncategoryclassification_DuplicateBaseRecord)
- [msdyn_transactioncategoryclassification_AsyncOperations](#BKMK_msdyn_transactioncategoryclassification_AsyncOperations)
- [msdyn_transactioncategoryclassification_MailboxTrackingFolders](#BKMK_msdyn_transactioncategoryclassification_MailboxTrackingFolders)
- [msdyn_transactioncategoryclassification_ProcessSession](#BKMK_msdyn_transactioncategoryclassification_ProcessSession)
- [msdyn_transactioncategoryclassification_BulkDeleteFailures](#BKMK_msdyn_transactioncategoryclassification_BulkDeleteFailures)
- [msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses)
- [msdyn_transactioncategoryclassification_Annotations](#BKMK_msdyn_transactioncategoryclassification_Annotations)


### <a name="BKMK_msdyn_transactioncategoryclassification_SyncErrors"></a> msdyn_transactioncategoryclassification_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_transactioncategoryclassification_SyncErrors](syncerror.md#BKMK_msdyn_transactioncategoryclassification_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategoryclassification_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategoryclassification_DuplicateMatchingRecord"></a> msdyn_transactioncategoryclassification_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_transactioncategoryclassification_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_transactioncategoryclassification_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategoryclassification_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategoryclassification_DuplicateBaseRecord"></a> msdyn_transactioncategoryclassification_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_transactioncategoryclassification_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_transactioncategoryclassification_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategoryclassification_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategoryclassification_AsyncOperations"></a> msdyn_transactioncategoryclassification_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_transactioncategoryclassification_AsyncOperations](asyncoperation.md#BKMK_msdyn_transactioncategoryclassification_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategoryclassification_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategoryclassification_MailboxTrackingFolders"></a> msdyn_transactioncategoryclassification_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_transactioncategoryclassification_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_transactioncategoryclassification_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategoryclassification_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategoryclassification_ProcessSession"></a> msdyn_transactioncategoryclassification_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_transactioncategoryclassification_ProcessSession](processsession.md#BKMK_msdyn_transactioncategoryclassification_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategoryclassification_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategoryclassification_BulkDeleteFailures"></a> msdyn_transactioncategoryclassification_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_transactioncategoryclassification_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_transactioncategoryclassification_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategoryclassification_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses"></a> msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategoryclassification_Annotations"></a> msdyn_transactioncategoryclassification_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_transactioncategoryclassification_Annotations](annotation.md#BKMK_msdyn_transactioncategoryclassification_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategoryclassification_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_transactioncategoryclassification_createdby](#BKMK_lk_msdyn_transactioncategoryclassification_createdby)
- [lk_msdyn_transactioncategoryclassification_createdonbehalfby](#BKMK_lk_msdyn_transactioncategoryclassification_createdonbehalfby)
- [lk_msdyn_transactioncategoryclassification_modifiedby](#BKMK_lk_msdyn_transactioncategoryclassification_modifiedby)
- [lk_msdyn_transactioncategoryclassification_modifiedonbehalfby](#BKMK_lk_msdyn_transactioncategoryclassification_modifiedonbehalfby)
- [organization_msdyn_transactioncategoryclassification](#BKMK_organization_msdyn_transactioncategoryclassification)
- [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory)


### <a name="BKMK_lk_msdyn_transactioncategoryclassification_createdby"></a> lk_msdyn_transactioncategoryclassification_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_transactioncategoryclassification_createdby](systemuser.md#BKMK_lk_msdyn_transactioncategoryclassification_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_transactioncategoryclassification_createdonbehalfby"></a> lk_msdyn_transactioncategoryclassification_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_transactioncategoryclassification_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_transactioncategoryclassification_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_transactioncategoryclassification_modifiedby"></a> lk_msdyn_transactioncategoryclassification_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_transactioncategoryclassification_modifiedby](systemuser.md#BKMK_lk_msdyn_transactioncategoryclassification_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_transactioncategoryclassification_modifiedonbehalfby"></a> lk_msdyn_transactioncategoryclassification_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_transactioncategoryclassification_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_transactioncategoryclassification_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_transactioncategoryclassification"></a> organization_msdyn_transactioncategoryclassification

**Added by**: System Solution Solution

See organization Entity [organization_msdyn_transactioncategoryclassification](organization.md#BKMK_organization_msdyn_transactioncategoryclassification) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory"></a> msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_transactioncategoryclassification?text=msdyn_transactioncategoryclassification EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]