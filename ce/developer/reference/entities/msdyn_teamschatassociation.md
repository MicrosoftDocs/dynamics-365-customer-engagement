---
title: "Microsoft Teams chat association entity (msdyn_teamschatassociation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Microsoft Teams chat association entity (msdyn_teamschatassociation) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Microsoft Teams chat association entity (msdyn_teamschatassociation) table/entity reference (Microsoft Dynamics 365)

For internal use only. Entity which stores association data of Dynamics 365 records with Microsoft Teams chat

## Messages

The following table lists the messages for the Microsoft Teams chat association entity (msdyn_teamschatassociation) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_teamschatassociations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /msdyn_teamschatassociations(*msdyn_teamschatassociationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_teamschatassociations(*msdyn_teamschatassociationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_teamschatassociations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_teamschatassociations(*msdyn_teamschatassociationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /msdyn_teamschatassociations(*msdyn_teamschatassociationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Microsoft Teams chat association entity (msdyn_teamschatassociation) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Microsoft Teams chat association entity** |
| **DisplayCollectionName** | **Microsoft Teams chat association entities** |
| **SchemaName** | `msdyn_teamschatassociation` |
| **CollectionSchemaName** | `msdyn_teamschatassociations` |
| **EntitySetName** | `msdyn_teamschatassociations`|
| **LogicalName** | `msdyn_teamschatassociation` |
| **LogicalCollectionName** | `msdyn_teamschatassociations` |
| **PrimaryIdAttribute** | `msdyn_teamschatassociationid` |
| **PrimaryNameAttribute** |`msdyn_teamschatassociationname` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_entityrecordstate](#BKMK_msdyn_entityrecordstate)
- [msdyn_regardingobjectid](#BKMK_msdyn_regardingobjectid)
- [msdyn_regardingobjectname](#BKMK_msdyn_regardingobjectname)
- [msdyn_teamschatassociationId](#BKMK_msdyn_teamschatassociationId)
- [msdyn_teamschatassociationname](#BKMK_msdyn_teamschatassociationname)
- [msdyn_teamschatid](#BKMK_msdyn_teamschatid)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**For internal use only. Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_entityrecordstate"></a> msdyn_entityrecordstate

|Property|Value|
|---|---|
|Description|**For internal use only. State of the msdyn_teamschatassociation**|
|DisplayName|**Entity Record's state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityrecordstate`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_teamschatassociation_msdyn_entityrecordstate`|

#### msdyn_entityrecordstate Choices/Options

|Value|Label|
|---|---|
|0|**Associate**|
|1|**Disassociate**|

### <a name="BKMK_msdyn_regardingobjectid"></a> msdyn_regardingobjectid

|Property|Value|
|---|---|
|Description|**For internal use only. Regarding Object Id**|
|DisplayName|**Regarding Object Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingobjectid`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_regardingobjectname"></a> msdyn_regardingobjectname

|Property|Value|
|---|---|
|Description|**For internal use only. Regarding Object Type Name**|
|DisplayName|**Regarding Object Type Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingobjectname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_teamschatassociationId"></a> msdyn_teamschatassociationId

|Property|Value|
|---|---|
|Description|**For internal use only. Unique identifier for entity instances**|
|DisplayName|**Teams chat association Identifier**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_teamschatassociationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_teamschatassociationname"></a> msdyn_teamschatassociationname

|Property|Value|
|---|---|
|Description|**For internal use only. The name of the custom entity.**|
|DisplayName|**Teams Chat Association name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_teamschatassociationname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_teamschatid"></a> msdyn_teamschatid

|Property|Value|
|---|---|
|Description|**For internal use only. Teams Chat Id**|
|DisplayName|**Teams Chat Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_teamschatid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**For internal use only. Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**For internal use only. Status of the msdyn_teamschatassociation**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_teamschatassociation_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**For internal use only. Reason for the status of the msdyn_teamschatassociation**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_teamschatassociation_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**For internal use only. Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**For internal use only. Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**For internal use only. Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**For internal use only. Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**For internal use only. Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**For internal use only. Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [lk_msdyn_teamschatassociation_createdby](#BKMK_lk_msdyn_teamschatassociation_createdby)
- [lk_msdyn_teamschatassociation_createdonbehalfby](#BKMK_lk_msdyn_teamschatassociation_createdonbehalfby)
- [lk_msdyn_teamschatassociation_modifiedby](#BKMK_lk_msdyn_teamschatassociation_modifiedby)
- [lk_msdyn_teamschatassociation_modifiedonbehalfby](#BKMK_lk_msdyn_teamschatassociation_modifiedonbehalfby)

### <a name="BKMK_lk_msdyn_teamschatassociation_createdby"></a> lk_msdyn_teamschatassociation_createdby

One-To-Many Relationship: [systemuser lk_msdyn_teamschatassociation_createdby](systemuser.md#BKMK_lk_msdyn_teamschatassociation_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_teamschatassociation_createdonbehalfby"></a> lk_msdyn_teamschatassociation_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_teamschatassociation_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_teamschatassociation_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_teamschatassociation_modifiedby"></a> lk_msdyn_teamschatassociation_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_teamschatassociation_modifiedby](systemuser.md#BKMK_lk_msdyn_teamschatassociation_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_teamschatassociation_modifiedonbehalfby"></a> lk_msdyn_teamschatassociation_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_teamschatassociation_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_teamschatassociation_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_teamschatassociation_AsyncOperations](#BKMK_msdyn_teamschatassociation_AsyncOperations)
- [msdyn_teamschatassociation_BulkDeleteFailures](#BKMK_msdyn_teamschatassociation_BulkDeleteFailures)
- [msdyn_teamschatassociation_MailboxTrackingFolders](#BKMK_msdyn_teamschatassociation_MailboxTrackingFolders)
- [msdyn_teamschatassociation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_teamschatassociation_PrincipalObjectAttributeAccesses)
- [msdyn_teamschatassociation_ProcessSession](#BKMK_msdyn_teamschatassociation_ProcessSession)
- [msdyn_teamschatassociation_SyncErrors](#BKMK_msdyn_teamschatassociation_SyncErrors)

### <a name="BKMK_msdyn_teamschatassociation_AsyncOperations"></a> msdyn_teamschatassociation_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_teamschatassociation_AsyncOperations](asyncoperation.md#BKMK_msdyn_teamschatassociation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamschatassociation_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamschatassociation_BulkDeleteFailures"></a> msdyn_teamschatassociation_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_teamschatassociation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_teamschatassociation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamschatassociation_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamschatassociation_MailboxTrackingFolders"></a> msdyn_teamschatassociation_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_teamschatassociation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_teamschatassociation_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamschatassociation_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamschatassociation_PrincipalObjectAttributeAccesses"></a> msdyn_teamschatassociation_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_teamschatassociation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_teamschatassociation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamschatassociation_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamschatassociation_ProcessSession"></a> msdyn_teamschatassociation_ProcessSession

Many-To-One Relationship: [processsession msdyn_teamschatassociation_ProcessSession](processsession.md#BKMK_msdyn_teamschatassociation_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamschatassociation_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_teamschatassociation_SyncErrors"></a> msdyn_teamschatassociation_SyncErrors

Many-To-One Relationship: [syncerror msdyn_teamschatassociation_SyncErrors](syncerror.md#BKMK_msdyn_teamschatassociation_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_teamschatassociation_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

