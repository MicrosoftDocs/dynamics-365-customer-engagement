---
title: "BulkOperationLog entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the BulkOperationLog entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# BulkOperationLog entity reference

Log used to track bulk operation execution, successes, and failures.

**Added by**: Marketing Solution


## Messages

|Message|SDK class or method|
|-|-|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|BulkOperationLogs|
|DisplayCollectionName|Bulk Operation Logs|
|DisplayName|Bulk Operation Log|
|EntitySetName|bulkoperationlogs|
|IsBPFEntity|False|
|LogicalCollectionName|bulkoperationlogs|
|LogicalName|bulkoperationlog|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|bulkoperationlogid|
|PrimaryNameAttribute|name|
|SchemaName|BulkOperationLog|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AdditionalInfo](#BKMK_AdditionalInfo)
- [BulkOperationId](#BKMK_BulkOperationId)
- [BulkOperationIdType](#BKMK_BulkOperationIdType)
- [BulkOperationLogId](#BKMK_BulkOperationLogId)
- [CreatedObjectId](#BKMK_CreatedObjectId)
- [CreatedObjectIdTypeCode](#BKMK_CreatedObjectIdTypeCode)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdTypeCode](#BKMK_RegardingObjectIdTypeCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_AdditionalInfo"></a> AdditionalInfo

|Property|Value|
|--------|-----|
|Description|Shows the data value at which an error occurred during the quick campaign.|
|DisplayName|Failed on Line|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|additionalinfo|
|MaxLength|100000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_BulkOperationId"></a> BulkOperationId

|Property|Value|
|--------|-----|
|Description|Shows the quick campaign record that the log applies to. This information is used to relate log data to the parent quick campaign.|
|DisplayName|Bulk Operation Number|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|bulkoperationid|
|RequiredLevel|SystemRequired|
|Targets|bulkoperation|
|Type|Lookup|


### <a name="BKMK_BulkOperationIdType"></a> BulkOperationIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bulkoperationidtype|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_BulkOperationLogId"></a> BulkOperationLogId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the bulk operation log.|
|DisplayName|Bulk Operation Log Number|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|bulkoperationlogid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_CreatedObjectId"></a> CreatedObjectId

|Property|Value|
|--------|-----|
|Description|Choose the activity or other item created by the bulk operation.|
|DisplayName|Created Object|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|createdobjectid|
|RequiredLevel|None|
|Targets|account,activitypointer,contact,lead,opportunity|
|Type|Lookup|


### <a name="BKMK_CreatedObjectIdTypeCode"></a> CreatedObjectIdTypeCode

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|createdobjectidtypecode|
|RequiredLevel|None|
|Type|EntityName|


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
|Description|name|
|DisplayName|name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
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


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the account, contact, lead, or list that the bulk operation log item applies to.|
|DisplayName|Customers Excluded|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjectid|
|RequiredLevel|ApplicationRequired|
|Targets|account,contact,lead|
|Type|Lookup|


### <a name="BKMK_RegardingObjectIdTypeCode"></a> RegardingObjectIdTypeCode

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|regardingobjectidtypecode|
|RequiredLevel|None|
|Type|EntityName|


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

- [BulkOperationIdName](#BKMK_BulkOperationIdName)
- [BulkOperationIdYomiName](#BKMK_BulkOperationIdYomiName)
- [CreatedObjectIdName](#BKMK_CreatedObjectIdName)
- [CreatedObjectIdYomiName](#BKMK_CreatedObjectIdYomiName)
- [ErrorNumber](#BKMK_ErrorNumber)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_BulkOperationIdName"></a> BulkOperationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bulkoperationidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BulkOperationIdYomiName"></a> BulkOperationIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bulkoperationidyominame|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedObjectIdName"></a> CreatedObjectIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdobjectidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedObjectIdYomiName"></a> CreatedObjectIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdobjectidyominame|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ErrorNumber"></a> ErrorNumber

|Property|Value|
|--------|-----|
|Description|Shows the error code that is used to troubleshoot issues in the bulk operation.|
|DisplayName|Reason Id|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|errornumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|ApplicationRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
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
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets||
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
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
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|ApplicationRequired|
|Targets||
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

- [bulkoperationlog_SyncErrors](#BKMK_bulkoperationlog_SyncErrors)
- [BulkOperationLog_AsyncOperations](#BKMK_BulkOperationLog_AsyncOperations)
- [bulkoperationlog_MailboxTrackingFolders](#BKMK_bulkoperationlog_MailboxTrackingFolders)
- [BulkOperationLog_BulkDeleteFailures](#BKMK_BulkOperationLog_BulkDeleteFailures)
- [bulkoperationlog_PrincipalObjectAttributeAccesses](#BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses)


### <a name="BKMK_bulkoperationlog_SyncErrors"></a> bulkoperationlog_SyncErrors

**Added by**: System Solution Solution

Same as the [bulkoperationlog_SyncErrors](syncerror.md#BKMK_bulkoperationlog_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bulkoperationlog_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BulkOperationLog_AsyncOperations"></a> BulkOperationLog_AsyncOperations

**Added by**: System Solution Solution

Same as the [BulkOperationLog_AsyncOperations](asyncoperation.md#BKMK_BulkOperationLog_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|BulkOperationLog_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bulkoperationlog_MailboxTrackingFolders"></a> bulkoperationlog_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as the [bulkoperationlog_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bulkoperationlog_MailboxTrackingFolders) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bulkoperationlog_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BulkOperationLog_BulkDeleteFailures"></a> BulkOperationLog_BulkDeleteFailures

**Added by**: System Solution Solution

Same as the [BulkOperationLog_BulkDeleteFailures](bulkdeletefailure.md#BKMK_BulkOperationLog_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|BulkOperationLog_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses"></a> bulkoperationlog_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as the [bulkoperationlog_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bulkoperationlog_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [user_bulkoperationlog](#BKMK_user_bulkoperationlog)
- [team_bulkoperationlog](#BKMK_team_bulkoperationlog)
- [CreatedAccount_BulkOperationLogs2](#BKMK_CreatedAccount_BulkOperationLogs2)
- [SourceAccount_BulkOperationLogs](#BKMK_SourceAccount_BulkOperationLogs)
- [activity_pointer_BulkOperation_logs](#BKMK_activity_pointer_BulkOperation_logs)
- [CreatedActivity_BulkOperationLogs](#BKMK_CreatedActivity_BulkOperationLogs)
- [BulkOperation_logs](#BKMK_BulkOperation_logs)
- [CreatedContact_BulkOperationLogs](#BKMK_CreatedContact_BulkOperationLogs)
- [SourceContact_BulkOperationLogs](#BKMK_SourceContact_BulkOperationLogs)
- [CreatedLead_BulkOperationLogs](#BKMK_CreatedLead_BulkOperationLogs)
- [SourceLead_BulkOperationLogs](#BKMK_SourceLead_BulkOperationLogs)
- [CreatedOpportunity_BulkOperationLogs](#BKMK_CreatedOpportunity_BulkOperationLogs)


### <a name="BKMK_user_bulkoperationlog"></a> user_bulkoperationlog

**Added by**: System Solution Solution

See the [user_bulkoperationlog](systemuser.md#BKMK_user_bulkoperationlog) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_team_bulkoperationlog"></a> team_bulkoperationlog

**Added by**: System Solution Solution

See the [team_bulkoperationlog](team.md#BKMK_team_bulkoperationlog) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_CreatedAccount_BulkOperationLogs2"></a> CreatedAccount_BulkOperationLogs2

**Added by**: System Solution Solution

See the [CreatedAccount_BulkOperationLogs2](account.md#BKMK_CreatedAccount_BulkOperationLogs2) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_SourceAccount_BulkOperationLogs"></a> SourceAccount_BulkOperationLogs

**Added by**: System Solution Solution

See the [SourceAccount_BulkOperationLogs](account.md#BKMK_SourceAccount_BulkOperationLogs) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_activity_pointer_BulkOperation_logs"></a> activity_pointer_BulkOperation_logs

**Added by**: System Solution Solution

See the [activity_pointer_BulkOperation_logs](activitypointer.md#BKMK_activity_pointer_BulkOperation_logs) one-to-many relationship for the [activitypointer](activitypointer.md) entity.

### <a name="BKMK_CreatedActivity_BulkOperationLogs"></a> CreatedActivity_BulkOperationLogs

**Added by**: System Solution Solution

See the [CreatedActivity_BulkOperationLogs](activitypointer.md#BKMK_CreatedActivity_BulkOperationLogs) one-to-many relationship for the [activitypointer](activitypointer.md) entity.

### <a name="BKMK_BulkOperation_logs"></a> BulkOperation_logs

See the [BulkOperation_logs](bulkoperation.md#BKMK_BulkOperation_logs) one-to-many relationship for the [bulkoperation](bulkoperation.md) entity.

### <a name="BKMK_CreatedContact_BulkOperationLogs"></a> CreatedContact_BulkOperationLogs

**Added by**: System Solution Solution

See the [CreatedContact_BulkOperationLogs](contact.md#BKMK_CreatedContact_BulkOperationLogs) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_SourceContact_BulkOperationLogs"></a> SourceContact_BulkOperationLogs

**Added by**: System Solution Solution

See the [SourceContact_BulkOperationLogs](contact.md#BKMK_SourceContact_BulkOperationLogs) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_CreatedLead_BulkOperationLogs"></a> CreatedLead_BulkOperationLogs

**Added by**: Lead Management Solution

See the [CreatedLead_BulkOperationLogs](lead.md#BKMK_CreatedLead_BulkOperationLogs) one-to-many relationship for the [lead](lead.md) entity.

### <a name="BKMK_SourceLead_BulkOperationLogs"></a> SourceLead_BulkOperationLogs

**Added by**: Lead Management Solution

See the [SourceLead_BulkOperationLogs](lead.md#BKMK_SourceLead_BulkOperationLogs) one-to-many relationship for the [lead](lead.md) entity.

### <a name="BKMK_CreatedOpportunity_BulkOperationLogs"></a> CreatedOpportunity_BulkOperationLogs

**Added by**: Sales Solution

See the [CreatedOpportunity_BulkOperationLogs](opportunity.md#BKMK_CreatedOpportunity_BulkOperationLogs) one-to-many relationship for the [opportunity](opportunity.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
