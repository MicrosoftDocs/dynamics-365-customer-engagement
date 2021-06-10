---
title: "msdyn_upgradeversion Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_upgradeversion entity."
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
# msdyn_upgradeversion Entity Reference

Information about upgrading from one release to the next release

**Added by**: Solution Upgrade Infrastructure Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_upgradeversions<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_upgradeversions(*msdyn_upgradeversionid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_upgradeversions(*msdyn_upgradeversionid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_upgradeversions<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_upgradeversions(*msdyn_upgradeversionid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_upgradeversions(*msdyn_upgradeversionid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_upgradeversions|
|DisplayCollectionName|Upgrade Versions|
|DisplayName|Upgrade Version|
|EntitySetName|msdyn_upgradeversions|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_upgradeversions|
|LogicalName|msdyn_upgradeversion|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_upgradeversionid|
|PrimaryNameAttribute|msdyn_summary|
|SchemaName|msdyn_upgradeversion|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Finished](#BKMK_msdyn_Finished)
- [msdyn_StartingVersion](#BKMK_msdyn_StartingVersion)
- [msdyn_Status](#BKMK_msdyn_Status)
- [msdyn_summary](#BKMK_msdyn_summary)
- [msdyn_TargetVersion](#BKMK_msdyn_TargetVersion)
- [msdyn_UpgradeRun](#BKMK_msdyn_UpgradeRun)
- [msdyn_upgradeversionId](#BKMK_msdyn_upgradeversionId)
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


### <a name="BKMK_msdyn_Finished"></a> msdyn_Finished

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date/time when a single-version upgrade finished|
|DisplayName|Finished|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_finished|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_StartingVersion"></a> msdyn_StartingVersion

|Property|Value|
|--------|-----|
|Description|Version that was installed before a single-version upgrade|
|DisplayName|StartingVersion|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_startingversion|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_Status"></a> msdyn_Status

|Property|Value|
|--------|-----|
|Description|Status/outcome of a single-version upgrade|
|DisplayName|Upgrade Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_status|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_Status Options

|Value|Label|
|-----|-----|
|100000000|Started|
|100000001|Success|
|100000002|Failure|



### <a name="BKMK_msdyn_summary"></a> msdyn_summary

|Property|Value|
|--------|-----|
|Description|Summary of a single-version upgrade|
|DisplayName|Summary|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_summary|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_TargetVersion"></a> msdyn_TargetVersion

|Property|Value|
|--------|-----|
|Description|Version that will be achieved by a single-version upgrade|
|DisplayName|TargetVersion|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_targetversion|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_UpgradeRun"></a> msdyn_UpgradeRun

|Property|Value|
|--------|-----|
|Description|Package deployer run that invoked a single-version upgrade|
|DisplayName|UpgradeRun|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_upgraderun|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_upgraderun|
|Type|Lookup|


### <a name="BKMK_msdyn_upgradeversionId"></a> msdyn_upgradeversionId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|UpgradeVersion|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_upgradeversionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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
|Description|Status of the UpgradeVersion|
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
|Description|Reason for the status of the UpgradeVersion|
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
- [msdyn_UpgradeRunName](#BKMK_msdyn_UpgradeRunName)
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
|DisplayName|Started|
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


### <a name="BKMK_msdyn_UpgradeRunName"></a> msdyn_UpgradeRunName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_upgraderunname|
|MaxLength|4000|
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

- [msdyn_upgradeversion_SyncErrors](#BKMK_msdyn_upgradeversion_SyncErrors)
- [msdyn_upgradeversion_AsyncOperations](#BKMK_msdyn_upgradeversion_AsyncOperations)
- [msdyn_upgradeversion_MailboxTrackingFolders](#BKMK_msdyn_upgradeversion_MailboxTrackingFolders)
- [msdyn_upgradeversion_ProcessSession](#BKMK_msdyn_upgradeversion_ProcessSession)
- [msdyn_upgradeversion_BulkDeleteFailures](#BKMK_msdyn_upgradeversion_BulkDeleteFailures)
- [msdyn_upgradeversion_PrincipalObjectAttributeAccesses](#BKMK_msdyn_upgradeversion_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion](#BKMK_msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion)


### <a name="BKMK_msdyn_upgradeversion_SyncErrors"></a> msdyn_upgradeversion_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_upgradeversion_SyncErrors](syncerror.md#BKMK_msdyn_upgradeversion_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_upgradeversion_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_upgradeversion_AsyncOperations"></a> msdyn_upgradeversion_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_upgradeversion_AsyncOperations](asyncoperation.md#BKMK_msdyn_upgradeversion_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_upgradeversion_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_upgradeversion_MailboxTrackingFolders"></a> msdyn_upgradeversion_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_upgradeversion_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_upgradeversion_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_upgradeversion_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_upgradeversion_ProcessSession"></a> msdyn_upgradeversion_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_upgradeversion_ProcessSession](processsession.md#BKMK_msdyn_upgradeversion_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_upgradeversion_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_upgradeversion_BulkDeleteFailures"></a> msdyn_upgradeversion_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_upgradeversion_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_upgradeversion_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_upgradeversion_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_upgradeversion_PrincipalObjectAttributeAccesses"></a> msdyn_upgradeversion_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_upgradeversion_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_upgradeversion_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_upgradeversion_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion"></a> msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion

Same as msdyn_upgradestep entity [msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion](msdyn_upgradestep.md#BKMK_msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_upgradestep|
|ReferencingAttribute|msdyn_upgradeversion|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_upgradeversion_createdby](#BKMK_lk_msdyn_upgradeversion_createdby)
- [lk_msdyn_upgradeversion_createdonbehalfby](#BKMK_lk_msdyn_upgradeversion_createdonbehalfby)
- [lk_msdyn_upgradeversion_modifiedby](#BKMK_lk_msdyn_upgradeversion_modifiedby)
- [lk_msdyn_upgradeversion_modifiedonbehalfby](#BKMK_lk_msdyn_upgradeversion_modifiedonbehalfby)
- [organization_msdyn_upgradeversion](#BKMK_organization_msdyn_upgradeversion)
- [msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun](#BKMK_msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun)


### <a name="BKMK_lk_msdyn_upgradeversion_createdby"></a> lk_msdyn_upgradeversion_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_upgradeversion_createdby](systemuser.md#BKMK_lk_msdyn_upgradeversion_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_upgradeversion_createdonbehalfby"></a> lk_msdyn_upgradeversion_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_upgradeversion_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_upgradeversion_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_upgradeversion_modifiedby"></a> lk_msdyn_upgradeversion_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_upgradeversion_modifiedby](systemuser.md#BKMK_lk_msdyn_upgradeversion_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_upgradeversion_modifiedonbehalfby"></a> lk_msdyn_upgradeversion_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_upgradeversion_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_upgradeversion_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_upgradeversion"></a> organization_msdyn_upgradeversion

**Added by**: System Solution Solution

See organization Entity [organization_msdyn_upgradeversion](organization.md#BKMK_organization_msdyn_upgradeversion) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun"></a> msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun

See msdyn_upgraderun Entity [msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun](msdyn_upgraderun.md#BKMK_msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_upgradeversion?text=msdyn_upgradeversion EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]