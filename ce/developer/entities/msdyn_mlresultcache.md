---
title: "msdyn_mlresultcache Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_mlresultcache entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_mlresultcache Entity Reference

Cache for scored work items per resource that are returned from Azure Machine Learning.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_mlresultcaches<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_mlresultcaches(*msdyn_mlresultcacheid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_mlresultcaches(*msdyn_mlresultcacheid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_mlresultcaches<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_mlresultcaches(*msdyn_mlresultcacheid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_mlresultcaches(*msdyn_mlresultcacheid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_mlresultcaches|
|DisplayCollectionName|Result Caches|
|DisplayName|Result Cache|
|EntitySetName|msdyn_mlresultcaches|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_mlresultcaches|
|LogicalName|msdyn_mlresultcache|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_mlresultcacheid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_mlresultcache|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_data](#BKMK_msdyn_data)
- [msdyn_Entitydescription](#BKMK_msdyn_Entitydescription)
- [msdyn_Expiration](#BKMK_msdyn_Expiration)
- [msdyn_mlresultcacheId](#BKMK_msdyn_mlresultcacheId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PartNumber](#BKMK_msdyn_PartNumber)
- [msdyn_userid](#BKMK_msdyn_userid)
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


### <a name="BKMK_msdyn_data"></a> msdyn_data

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Data|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_data|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_Entitydescription"></a> msdyn_Entitydescription

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Entity description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_entitydescription|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Expiration"></a> msdyn_Expiration

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description||
|DisplayName|Expiration|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_expiration|
|RequiredLevel|Recommended|
|Type|DateTime|


### <a name="BKMK_msdyn_mlresultcacheId"></a> msdyn_mlresultcacheId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Result Cache|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_mlresultcacheid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_PartNumber"></a> msdyn_PartNumber

|Property|Value|
|--------|-----|
|Description|If cache is large, then this will have a numeric value corresponding to the part of the cache.|
|DisplayName|Part Number|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_partnumber|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_userid"></a> msdyn_userid

|Property|Value|
|--------|-----|
|Description||
|DisplayName|User id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_userid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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
|Description|Status of the Result Cache|
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
|Description|Reason for the status of the Result Cache|
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
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [VersionNumber](#BKMK_VersionNumber)


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


### <a name="BKMK_OrganizationId"></a> OrganizationId

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

- [msdyn_mlresultcache_SyncErrors](#BKMK_msdyn_mlresultcache_SyncErrors)
- [msdyn_mlresultcache_AsyncOperations](#BKMK_msdyn_mlresultcache_AsyncOperations)
- [msdyn_mlresultcache_MailboxTrackingFolders](#BKMK_msdyn_mlresultcache_MailboxTrackingFolders)
- [msdyn_mlresultcache_UserEntityInstanceDatas](#BKMK_msdyn_mlresultcache_UserEntityInstanceDatas)
- [msdyn_mlresultcache_ProcessSession](#BKMK_msdyn_mlresultcache_ProcessSession)
- [msdyn_mlresultcache_BulkDeleteFailures](#BKMK_msdyn_mlresultcache_BulkDeleteFailures)
- [msdyn_mlresultcache_PrincipalObjectAttributeAccesses](#BKMK_msdyn_mlresultcache_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_mlresultcache_SyncErrors"></a> msdyn_mlresultcache_SyncErrors

Same as syncerror entity [msdyn_mlresultcache_SyncErrors](syncerror.md#BKMK_msdyn_mlresultcache_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_mlresultcache_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_mlresultcache_AsyncOperations"></a> msdyn_mlresultcache_AsyncOperations

Same as asyncoperation entity [msdyn_mlresultcache_AsyncOperations](asyncoperation.md#BKMK_msdyn_mlresultcache_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_mlresultcache_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_mlresultcache_MailboxTrackingFolders"></a> msdyn_mlresultcache_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_mlresultcache_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_mlresultcache_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_mlresultcache_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_mlresultcache_UserEntityInstanceDatas"></a> msdyn_mlresultcache_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_mlresultcache_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_mlresultcache_UserEntityInstanceDatas) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_mlresultcache_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_mlresultcache_ProcessSession"></a> msdyn_mlresultcache_ProcessSession

Same as processsession entity [msdyn_mlresultcache_ProcessSession](processsession.md#BKMK_msdyn_mlresultcache_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_mlresultcache_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_mlresultcache_BulkDeleteFailures"></a> msdyn_mlresultcache_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_mlresultcache_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_mlresultcache_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_mlresultcache_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_mlresultcache_PrincipalObjectAttributeAccesses"></a> msdyn_mlresultcache_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_mlresultcache_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_mlresultcache_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_mlresultcache_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_mlresultcache_createdby](#BKMK_lk_msdyn_mlresultcache_createdby)
- [lk_msdyn_mlresultcache_createdonbehalfby](#BKMK_lk_msdyn_mlresultcache_createdonbehalfby)
- [lk_msdyn_mlresultcache_modifiedby](#BKMK_lk_msdyn_mlresultcache_modifiedby)
- [lk_msdyn_mlresultcache_modifiedonbehalfby](#BKMK_lk_msdyn_mlresultcache_modifiedonbehalfby)
- [organization_msdyn_mlresultcache](#BKMK_organization_msdyn_mlresultcache)


### <a name="BKMK_lk_msdyn_mlresultcache_createdby"></a> lk_msdyn_mlresultcache_createdby

See systemuser Entity [lk_msdyn_mlresultcache_createdby](systemuser.md#BKMK_lk_msdyn_mlresultcache_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_mlresultcache_createdonbehalfby"></a> lk_msdyn_mlresultcache_createdonbehalfby

See systemuser Entity [lk_msdyn_mlresultcache_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_mlresultcache_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_mlresultcache_modifiedby"></a> lk_msdyn_mlresultcache_modifiedby

See systemuser Entity [lk_msdyn_mlresultcache_modifiedby](systemuser.md#BKMK_lk_msdyn_mlresultcache_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_mlresultcache_modifiedonbehalfby"></a> lk_msdyn_mlresultcache_modifiedonbehalfby

See systemuser Entity [lk_msdyn_mlresultcache_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_mlresultcache_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_mlresultcache"></a> organization_msdyn_mlresultcache

See organization Entity [organization_msdyn_mlresultcache](organization.md#BKMK_organization_msdyn_mlresultcache) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_mlresultcache?text=msdyn_mlresultcache EntityType" />