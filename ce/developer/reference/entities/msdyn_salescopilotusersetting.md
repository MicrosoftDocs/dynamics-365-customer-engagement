---
title: "Sales Copilot User Setting (msdyn_salescopilotusersetting) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Sales Copilot User Setting (msdyn_salescopilotusersetting) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sales Copilot User Setting (msdyn_salescopilotusersetting) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Sales Copilot User Setting (msdyn_salescopilotusersetting) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_salescopilotusersettings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /msdyn_salescopilotusersettings(*msdyn_salescopilotusersettingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_salescopilotusersettings(*msdyn_salescopilotusersettingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_salescopilotusersettings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_salescopilotusersettings(*msdyn_salescopilotusersettingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /msdyn_salescopilotusersettings(*msdyn_salescopilotusersettingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sales Copilot User Setting (msdyn_salescopilotusersetting) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sales Copilot User Setting** |
| **DisplayCollectionName** | **Sales Copilot User Settings** |
| **SchemaName** | `msdyn_salescopilotusersetting` |
| **CollectionSchemaName** | `msdyn_salescopilotusersettings` |
| **EntitySetName** | `msdyn_salescopilotusersettings`|
| **LogicalName** | `msdyn_salescopilotusersetting` |
| **LogicalCollectionName** | `msdyn_salescopilotusersettings` |
| **PrimaryIdAttribute** | `msdyn_salescopilotusersettingid` |
| **PrimaryNameAttribute** |`msdyn_userid` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_exchangeconsentgiven](#BKMK_msdyn_exchangeconsentgiven)
- [msdyn_nbaskillconsentgiven](#BKMK_msdyn_nbaskillconsentgiven)
- [msdyn_nbaskillinfradetails](#BKMK_msdyn_nbaskillinfradetails)
- [msdyn_nbaskillinfrastatus](#BKMK_msdyn_nbaskillinfrastatus)
- [msdyn_nbaskillinfrastatuslastverifiedon](#BKMK_msdyn_nbaskillinfrastatuslastverifiedon)
- [msdyn_salescopilotusersettingId](#BKMK_msdyn_salescopilotusersettingId)
- [msdyn_userid](#BKMK_msdyn_userid)
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

### <a name="BKMK_msdyn_exchangeconsentgiven"></a> msdyn_exchangeconsentgiven

|Property|Value|
|---|---|
|Description||
|DisplayName|**Exchange Consent Given**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_exchangeconsentgiven`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_salescopilotusersetting_msdyn_exchangeconsentgiven`|

#### msdyn_exchangeconsentgiven Choices/Options

|Value|Label|
|---|---|
|0|**None**|
|1|**Yes**|
|2|**No**|

### <a name="BKMK_msdyn_nbaskillconsentgiven"></a> msdyn_nbaskillconsentgiven

|Property|Value|
|---|---|
|Description||
|DisplayName|**NBA Skill Consent Given**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nbaskillconsentgiven`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_salescopilotusersetting_msdyn_nbaskillconsentgiven`|

#### msdyn_nbaskillconsentgiven Choices/Options

|Value|Label|
|---|---|
|0|**None**|
|1|**Yes**|
|2|**No**|

### <a name="BKMK_msdyn_nbaskillinfradetails"></a> msdyn_nbaskillinfradetails

|Property|Value|
|---|---|
|Description|**NBA Skill Infra Details**|
|DisplayName|**NBA Skill Infra Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nbaskillinfradetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_nbaskillinfrastatus"></a> msdyn_nbaskillinfrastatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**NBA Skill Infrastructure status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nbaskillinfrastatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_salescopilotusersetting_msdyn_nbaskillinfrastatus`|

#### msdyn_nbaskillinfrastatus Choices/Options

|Value|Label|
|---|---|
|0|**None**|
|1|**Active**|
|2|**Error**|

### <a name="BKMK_msdyn_nbaskillinfrastatuslastverifiedon"></a> msdyn_nbaskillinfrastatuslastverifiedon

|Property|Value|
|---|---|
|Description|**NBA Skill Infra Status Last Checked On**|
|DisplayName|**NBA Skill Infra Status Last Checked On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nbaskillinfrastatuslastverifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_salescopilotusersettingId"></a> msdyn_salescopilotusersettingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Sales Copilot User Setting**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_salescopilotusersettingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_userid"></a> msdyn_userid

|Property|Value|
|---|---|
|Description|**Unique user id**|
|DisplayName|**User Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_userid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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
|Description|**Status of the Sales Copilot User Setting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salescopilotusersetting_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Sales Copilot User Setting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salescopilotusersetting_statuscode`|

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

- [lk_msdyn_salescopilotusersetting_createdby](#BKMK_lk_msdyn_salescopilotusersetting_createdby)
- [lk_msdyn_salescopilotusersetting_createdonbehalfby](#BKMK_lk_msdyn_salescopilotusersetting_createdonbehalfby)
- [lk_msdyn_salescopilotusersetting_modifiedby](#BKMK_lk_msdyn_salescopilotusersetting_modifiedby)
- [lk_msdyn_salescopilotusersetting_modifiedonbehalfby](#BKMK_lk_msdyn_salescopilotusersetting_modifiedonbehalfby)

### <a name="BKMK_lk_msdyn_salescopilotusersetting_createdby"></a> lk_msdyn_salescopilotusersetting_createdby

One-To-Many Relationship: [systemuser lk_msdyn_salescopilotusersetting_createdby](systemuser.md#BKMK_lk_msdyn_salescopilotusersetting_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salescopilotusersetting_createdonbehalfby"></a> lk_msdyn_salescopilotusersetting_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salescopilotusersetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_salescopilotusersetting_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salescopilotusersetting_modifiedby"></a> lk_msdyn_salescopilotusersetting_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_salescopilotusersetting_modifiedby](systemuser.md#BKMK_lk_msdyn_salescopilotusersetting_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salescopilotusersetting_modifiedonbehalfby"></a> lk_msdyn_salescopilotusersetting_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salescopilotusersetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_salescopilotusersetting_modifiedonbehalfby)

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

- [msdyn_salescopilotusersetting_AsyncOperations](#BKMK_msdyn_salescopilotusersetting_AsyncOperations)
- [msdyn_salescopilotusersetting_BulkDeleteFailures](#BKMK_msdyn_salescopilotusersetting_BulkDeleteFailures)
- [msdyn_salescopilotusersetting_DuplicateBaseRecord](#BKMK_msdyn_salescopilotusersetting_DuplicateBaseRecord)
- [msdyn_salescopilotusersetting_DuplicateMatchingRecord](#BKMK_msdyn_salescopilotusersetting_DuplicateMatchingRecord)
- [msdyn_salescopilotusersetting_MailboxTrackingFolders](#BKMK_msdyn_salescopilotusersetting_MailboxTrackingFolders)
- [msdyn_salescopilotusersetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_salescopilotusersetting_PrincipalObjectAttributeAccesses)
- [msdyn_salescopilotusersetting_ProcessSession](#BKMK_msdyn_salescopilotusersetting_ProcessSession)
- [msdyn_salescopilotusersetting_SyncErrors](#BKMK_msdyn_salescopilotusersetting_SyncErrors)

### <a name="BKMK_msdyn_salescopilotusersetting_AsyncOperations"></a> msdyn_salescopilotusersetting_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_salescopilotusersetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_salescopilotusersetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotusersetting_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotusersetting_BulkDeleteFailures"></a> msdyn_salescopilotusersetting_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_salescopilotusersetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_salescopilotusersetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotusersetting_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotusersetting_DuplicateBaseRecord"></a> msdyn_salescopilotusersetting_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_salescopilotusersetting_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_salescopilotusersetting_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotusersetting_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotusersetting_DuplicateMatchingRecord"></a> msdyn_salescopilotusersetting_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_salescopilotusersetting_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_salescopilotusersetting_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotusersetting_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotusersetting_MailboxTrackingFolders"></a> msdyn_salescopilotusersetting_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_salescopilotusersetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_salescopilotusersetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotusersetting_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotusersetting_PrincipalObjectAttributeAccesses"></a> msdyn_salescopilotusersetting_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_salescopilotusersetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_salescopilotusersetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotusersetting_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotusersetting_ProcessSession"></a> msdyn_salescopilotusersetting_ProcessSession

Many-To-One Relationship: [processsession msdyn_salescopilotusersetting_ProcessSession](processsession.md#BKMK_msdyn_salescopilotusersetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotusersetting_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salescopilotusersetting_SyncErrors"></a> msdyn_salescopilotusersetting_SyncErrors

Many-To-One Relationship: [syncerror msdyn_salescopilotusersetting_SyncErrors](syncerror.md#BKMK_msdyn_salescopilotusersetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salescopilotusersetting_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

