---
title: "msdyn_wallsavedquery Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_wallsavedquery entity."
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
# msdyn_wallsavedquery Entity Reference

Contains information regarding which views are available for users to display on their personal walls. Only an administrator can specify the views that users can choose from to display on their personal walls.

**Added by**: Activity Feeds Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_wallsavedqueries<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_wallsavedqueries<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_wallsavedqueries|
|DisplayCollectionName|Wall Views|
|DisplayName|Wall View|
|EntitySetName|msdyn_wallsavedqueries|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_wallsavedqueries|
|LogicalName|msdyn_wallsavedquery|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_wallsavedqueryid|
|PrimaryNameAttribute|msdyn_entityname|
|SchemaName|msdyn_wallsavedquery|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_entitydisplayname](#BKMK_msdyn_entitydisplayname)
- [msdyn_entityname](#BKMK_msdyn_entityname)
- [msdyn_IsVirtual](#BKMK_msdyn_IsVirtual)
- [msdyn_IsVisible](#BKMK_msdyn_IsVisible)
- [msdyn_isvisiblebit](#BKMK_msdyn_isvisiblebit)
- [msdyn_otc](#BKMK_msdyn_otc)
- [msdyn_postconfigurationid](#BKMK_msdyn_postconfigurationid)
- [msdyn_SavedQueryId](#BKMK_msdyn_SavedQueryId)
- [msdyn_savedqueryname](#BKMK_msdyn_savedqueryname)
- [msdyn_wallsavedqueryId](#BKMK_msdyn_wallsavedqueryId)
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


### <a name="BKMK_msdyn_entitydisplayname"></a> msdyn_entitydisplayname

|Property|Value|
|--------|-----|
|Description|Type of entity to which the corresponding views belong|
|DisplayName|Entity Display Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_entitydisplayname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_entityname"></a> msdyn_entityname

|Property|Value|
|--------|-----|
|Description|Name of the entity to which the corresponding views belong.|
|DisplayName|Entity Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_entityname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_IsVirtual"></a> msdyn_IsVirtual

|Property|Value|
|--------|-----|
|Description|Information that indicates whether the entity is virtual, that is whether, it is generated by a plug-in, and no corresponding entity instance exists.|
|DisplayName|Is Virtual|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isvirtual|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_IsVirtual Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_IsVisible"></a> msdyn_IsVisible

|Property|Value|
|--------|-----|
|Description|Indicates that corresponding system view should be displayed on personal wall|
|DisplayName|Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isvisible|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_IsVisible Options

|Value|Label|
|-----|-----|
|1|Shown|
|0|Hidden|

**DefaultValue**: False



### <a name="BKMK_msdyn_isvisiblebit"></a> msdyn_isvisiblebit

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Is Visible bit|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isvisiblebit|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_otc"></a> msdyn_otc

|Property|Value|
|--------|-----|
|Description|Type of entity to which the corresponding views belong.|
|DisplayName|Entity Type|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_otc|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_postconfigurationid"></a> msdyn_postconfigurationid

|Property|Value|
|--------|-----|
|Description|Unique identifier for Post Configuration associated with Wall View.|
|DisplayName|Post Entity Id|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_postconfigurationid|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_postconfig|
|Type|Lookup|


### <a name="BKMK_msdyn_SavedQueryId"></a> msdyn_SavedQueryId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the view that should be displayed on the personal wall for all users.|
|DisplayName|View Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_savedqueryid|
|MaxLength|50|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_savedqueryname"></a> msdyn_savedqueryname

|Property|Value|
|--------|-----|
|Description|Name of the corresponding view.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_savedqueryname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_wallsavedqueryId"></a> msdyn_wallsavedqueryId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Wall View|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_wallsavedqueryid|
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
|Description|Status of the Wall View|
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
|Description|Reason for the status of the Wall View|
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
- [msdyn_postconfigurationidName](#BKMK_msdyn_postconfigurationidName)
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


### <a name="BKMK_msdyn_postconfigurationidName"></a> msdyn_postconfigurationidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_postconfigurationidname|
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

- [msdyn_wallsavedquery_SyncErrors](#BKMK_msdyn_wallsavedquery_SyncErrors)
- [msdyn_wallsavedquery_AsyncOperations](#BKMK_msdyn_wallsavedquery_AsyncOperations)
- [msdyn_wallsavedquery_MailboxTrackingFolders](#BKMK_msdyn_wallsavedquery_MailboxTrackingFolders)
- [msdyn_wallsavedquery_ProcessSession](#BKMK_msdyn_wallsavedquery_ProcessSession)
- [msdyn_wallsavedquery_BulkDeleteFailures](#BKMK_msdyn_wallsavedquery_BulkDeleteFailures)
- [msdyn_wallsavedquery_PrincipalObjectAttributeAccesses](#BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses)
- [msdyn_wallsavedquery_wallsavedqueryusersettings](#BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings)


### <a name="BKMK_msdyn_wallsavedquery_SyncErrors"></a> msdyn_wallsavedquery_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_wallsavedquery_SyncErrors](syncerror.md#BKMK_msdyn_wallsavedquery_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_wallsavedquery_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_wallsavedquery_AsyncOperations"></a> msdyn_wallsavedquery_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_wallsavedquery_AsyncOperations](asyncoperation.md#BKMK_msdyn_wallsavedquery_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_wallsavedquery_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_wallsavedquery_MailboxTrackingFolders"></a> msdyn_wallsavedquery_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_wallsavedquery_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_wallsavedquery_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_wallsavedquery_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_wallsavedquery_ProcessSession"></a> msdyn_wallsavedquery_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_wallsavedquery_ProcessSession](processsession.md#BKMK_msdyn_wallsavedquery_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_wallsavedquery_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_wallsavedquery_BulkDeleteFailures"></a> msdyn_wallsavedquery_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_wallsavedquery_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_wallsavedquery_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_wallsavedquery_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses"></a> msdyn_wallsavedquery_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_wallsavedquery_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_wallsavedquery_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings"></a> msdyn_wallsavedquery_wallsavedqueryusersettings

Same as msdyn_wallsavedqueryusersettings entity [msdyn_wallsavedquery_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_wallsavedqueryusersettings|
|ReferencingAttribute|msdyn_wallsavedqueryid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_wallsavedquery_wallsavedqueryusersettings|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_wallsavedquery_createdby](#BKMK_lk_msdyn_wallsavedquery_createdby)
- [lk_msdyn_wallsavedquery_createdonbehalfby](#BKMK_lk_msdyn_wallsavedquery_createdonbehalfby)
- [lk_msdyn_wallsavedquery_modifiedby](#BKMK_lk_msdyn_wallsavedquery_modifiedby)
- [lk_msdyn_wallsavedquery_modifiedonbehalfby](#BKMK_lk_msdyn_wallsavedquery_modifiedonbehalfby)
- [organization_msdyn_wallsavedquery](#BKMK_organization_msdyn_wallsavedquery)
- [msdyn_postconfig_wallsavedquery](#BKMK_msdyn_postconfig_wallsavedquery)


### <a name="BKMK_lk_msdyn_wallsavedquery_createdby"></a> lk_msdyn_wallsavedquery_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_wallsavedquery_createdby](systemuser.md#BKMK_lk_msdyn_wallsavedquery_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_wallsavedquery_createdonbehalfby"></a> lk_msdyn_wallsavedquery_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_wallsavedquery_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_wallsavedquery_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_wallsavedquery_modifiedby"></a> lk_msdyn_wallsavedquery_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_wallsavedquery_modifiedby](systemuser.md#BKMK_lk_msdyn_wallsavedquery_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_wallsavedquery_modifiedonbehalfby"></a> lk_msdyn_wallsavedquery_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_wallsavedquery_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_wallsavedquery_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_wallsavedquery"></a> organization_msdyn_wallsavedquery

**Added by**: System Solution Solution

See organization Entity [organization_msdyn_wallsavedquery](organization.md#BKMK_organization_msdyn_wallsavedquery) One-To-Many relationship.

### <a name="BKMK_msdyn_postconfig_wallsavedquery"></a> msdyn_postconfig_wallsavedquery

See msdyn_postconfig Entity [msdyn_postconfig_wallsavedquery](msdyn_postconfig.md#BKMK_msdyn_postconfig_wallsavedquery) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_wallsavedquery?text=msdyn_wallsavedquery EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]