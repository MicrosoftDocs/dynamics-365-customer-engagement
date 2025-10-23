---
title: "Collab Space Team Association (msdyn_collabspaceteamassociation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Collab Space Team Association (msdyn_collabspaceteamassociation) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Collab Space Team Association (msdyn_collabspaceteamassociation) table/entity reference (Microsoft Dynamics 365)

Collab Space Team Association

## Messages

The following table lists the messages for the Collab Space Team Association (msdyn_collabspaceteamassociation) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_collabspaceteamassociations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /msdyn_collabspaceteamassociations(*msdyn_collabspaceteamassociationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_collabspaceteamassociations(*msdyn_collabspaceteamassociationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_collabspaceteamassociations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_collabspaceteamassociations(*msdyn_collabspaceteamassociationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /msdyn_collabspaceteamassociations(*msdyn_collabspaceteamassociationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Collab Space Team Association (msdyn_collabspaceteamassociation) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Collab Space Team Association** |
| **DisplayCollectionName** | **Collab Space Team Associations** |
| **SchemaName** | `msdyn_collabspaceteamassociation` |
| **CollectionSchemaName** | `msdyn_collabspaceteamassociations` |
| **EntitySetName** | `msdyn_collabspaceteamassociations`|
| **LogicalName** | `msdyn_collabspaceteamassociation` |
| **LogicalCollectionName** | `msdyn_collabspaceteamassociations` |
| **PrimaryIdAttribute** | `msdyn_collabspaceteamassociationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_collabspaceteamassociationId](#BKMK_msdyn_collabspaceteamassociationId)
- [msdyn_crmrecordid](#BKMK_msdyn_crmrecordid)
- [msdyn_crmrecordtype](#BKMK_msdyn_crmrecordtype)
- [msdyn_crmtype](#BKMK_msdyn_crmtype)
- [msdyn_data](#BKMK_msdyn_data)
- [msdyn_dataversion](#BKMK_msdyn_dataversion)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_producttype](#BKMK_msdyn_producttype)
- [msdyn_teamid](#BKMK_msdyn_teamid)
- [msdyn_teamweburl](#BKMK_msdyn_teamweburl)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_collabspaceteamassociationId"></a> msdyn_collabspaceteamassociationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Collab Space Team Association**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_collabspaceteamassociationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_crmrecordid"></a> msdyn_crmrecordid

|Property|Value|
|---|---|
|Description||
|DisplayName|**CRM Record Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_crmrecordid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_crmrecordtype"></a> msdyn_crmrecordtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**CRM record Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_crmrecordtype`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_crmtype"></a> msdyn_crmtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**CRM Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_crmtype`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_data"></a> msdyn_data

|Property|Value|
|---|---|
|Description||
|DisplayName|**Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_data`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_dataversion"></a> msdyn_dataversion

|Property|Value|
|---|---|
|Description||
|DisplayName|**Data Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dataversion`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_producttype"></a> msdyn_producttype

|Property|Value|
|---|---|
|Description|**Identifier to track the association of this record with a Copilot product type**|
|DisplayName|**Product Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_producttype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|10000|
|GlobalChoiceName|`msdyn_vivacopilottype`|

#### msdyn_producttype Choices/Options

|Value|Label|
|---|---|
|10000|**Copilot for Sales**|
|10001|**Copilot for Service**|
|11000|**Shared**|

### <a name="BKMK_msdyn_teamid"></a> msdyn_teamid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Team ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_teamid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_teamweburl"></a> msdyn_teamweburl

|Property|Value|
|---|---|
|Description|**Team Web URL**|
|DisplayName|**Team Web URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_teamweburl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
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
|Description|**Status of the Collab Space Team Association**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_collabspaceteamassociation_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Collab Space Team Association**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_collabspaceteamassociation_statuscode`|

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
|Description|**Time zone code that was in use when the record was created.**|
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
|Description|**Unique identifier of the user who created the record.**|
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
|Description|**Date and time when the record was created.**|
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
|Description|**Unique identifier of the delegate user who created the record.**|
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
|Description|**Unique identifier of the user who modified the record.**|
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
|Description|**Date and time when the record was modified.**|
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
|Description|**Unique identifier of the delegate user who modified the record.**|
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

- [lk_msdyn_collabspaceteamassociation_createdby](#BKMK_lk_msdyn_collabspaceteamassociation_createdby)
- [lk_msdyn_collabspaceteamassociation_createdonbehalfby](#BKMK_lk_msdyn_collabspaceteamassociation_createdonbehalfby)
- [lk_msdyn_collabspaceteamassociation_modifiedby](#BKMK_lk_msdyn_collabspaceteamassociation_modifiedby)
- [lk_msdyn_collabspaceteamassociation_modifiedonbehalfby](#BKMK_lk_msdyn_collabspaceteamassociation_modifiedonbehalfby)

### <a name="BKMK_lk_msdyn_collabspaceteamassociation_createdby"></a> lk_msdyn_collabspaceteamassociation_createdby

One-To-Many Relationship: [systemuser lk_msdyn_collabspaceteamassociation_createdby](systemuser.md#BKMK_lk_msdyn_collabspaceteamassociation_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_collabspaceteamassociation_createdonbehalfby"></a> lk_msdyn_collabspaceteamassociation_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_collabspaceteamassociation_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_collabspaceteamassociation_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_collabspaceteamassociation_modifiedby"></a> lk_msdyn_collabspaceteamassociation_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_collabspaceteamassociation_modifiedby](systemuser.md#BKMK_lk_msdyn_collabspaceteamassociation_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_collabspaceteamassociation_modifiedonbehalfby"></a> lk_msdyn_collabspaceteamassociation_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_collabspaceteamassociation_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_collabspaceteamassociation_modifiedonbehalfby)

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

- [msdyn_collabspaceteamassociation_AsyncOperations](#BKMK_msdyn_collabspaceteamassociation_AsyncOperations)
- [msdyn_collabspaceteamassociation_BulkDeleteFailures](#BKMK_msdyn_collabspaceteamassociation_BulkDeleteFailures)
- [msdyn_collabspaceteamassociation_DuplicateBaseRecord](#BKMK_msdyn_collabspaceteamassociation_DuplicateBaseRecord)
- [msdyn_collabspaceteamassociation_DuplicateMatchingRecord](#BKMK_msdyn_collabspaceteamassociation_DuplicateMatchingRecord)
- [msdyn_collabspaceteamassociation_MailboxTrackingFolders](#BKMK_msdyn_collabspaceteamassociation_MailboxTrackingFolders)
- [msdyn_collabspaceteamassociation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_collabspaceteamassociation_PrincipalObjectAttributeAccesses)
- [msdyn_collabspaceteamassociation_ProcessSession](#BKMK_msdyn_collabspaceteamassociation_ProcessSession)
- [msdyn_collabspaceteamassociation_SyncErrors](#BKMK_msdyn_collabspaceteamassociation_SyncErrors)

### <a name="BKMK_msdyn_collabspaceteamassociation_AsyncOperations"></a> msdyn_collabspaceteamassociation_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_collabspaceteamassociation_AsyncOperations](asyncoperation.md#BKMK_msdyn_collabspaceteamassociation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_collabspaceteamassociation_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_collabspaceteamassociation_BulkDeleteFailures"></a> msdyn_collabspaceteamassociation_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_collabspaceteamassociation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_collabspaceteamassociation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_collabspaceteamassociation_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_collabspaceteamassociation_DuplicateBaseRecord"></a> msdyn_collabspaceteamassociation_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_collabspaceteamassociation_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_collabspaceteamassociation_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_collabspaceteamassociation_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_collabspaceteamassociation_DuplicateMatchingRecord"></a> msdyn_collabspaceteamassociation_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_collabspaceteamassociation_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_collabspaceteamassociation_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_collabspaceteamassociation_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_collabspaceteamassociation_MailboxTrackingFolders"></a> msdyn_collabspaceteamassociation_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_collabspaceteamassociation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_collabspaceteamassociation_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_collabspaceteamassociation_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_collabspaceteamassociation_PrincipalObjectAttributeAccesses"></a> msdyn_collabspaceteamassociation_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_collabspaceteamassociation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_collabspaceteamassociation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_collabspaceteamassociation_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_collabspaceteamassociation_ProcessSession"></a> msdyn_collabspaceteamassociation_ProcessSession

Many-To-One Relationship: [processsession msdyn_collabspaceteamassociation_ProcessSession](processsession.md#BKMK_msdyn_collabspaceteamassociation_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_collabspaceteamassociation_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_collabspaceteamassociation_SyncErrors"></a> msdyn_collabspaceteamassociation_SyncErrors

Many-To-One Relationship: [syncerror msdyn_collabspaceteamassociation_SyncErrors](syncerror.md#BKMK_msdyn_collabspaceteamassociation_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_collabspaceteamassociation_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

