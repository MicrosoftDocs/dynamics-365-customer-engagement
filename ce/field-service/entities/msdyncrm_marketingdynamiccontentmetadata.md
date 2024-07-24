---
title: "Dynamic-content metadata (msdyncrm_marketingdynamiccontentmetadata) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Dynamic-content metadata (msdyncrm_marketingdynamiccontentmetadata) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Dynamic-content metadata (msdyncrm_marketingdynamiccontentmetadata) table/entity reference



## Messages

The following table lists the messages for the Dynamic-content metadata (msdyncrm_marketingdynamiccontentmetadata) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_marketingdynamiccontentmetadatas(*msdyncrm_marketingdynamiccontentmetadataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_marketingdynamiccontentmetadatas<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingdynamiccontentmetadatas(*msdyncrm_marketingdynamiccontentmetadataid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingdynamiccontentmetadatas(*msdyncrm_marketingdynamiccontentmetadataid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingdynamiccontentmetadatas<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingdynamiccontentmetadatas(*msdyncrm_marketingdynamiccontentmetadataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingdynamiccontentmetadatas(*msdyncrm_marketingdynamiccontentmetadataid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingdynamiccontentmetadatas(*msdyncrm_marketingdynamiccontentmetadataid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Dynamic-content metadata (msdyncrm_marketingdynamiccontentmetadata) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Dynamic-content metadata (msdyncrm_marketingdynamiccontentmetadata) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Dynamic-content metadata** |
| **DisplayCollectionName** | **Marketing dynamic-content metadata** |
| **SchemaName** | `msdyncrm_marketingdynamiccontentmetadata` |
| **CollectionSchemaName** | `msdyncrm_marketingdynamiccontentmetadatas` |
| **EntitySetName** | `msdyncrm_marketingdynamiccontentmetadatas`|
| **LogicalName** | `msdyncrm_marketingdynamiccontentmetadata` |
| **LogicalCollectionName** | `msdyncrm_marketingdynamiccontentmetadatas` |
| **PrimaryIdAttribute** | `msdyncrm_marketingdynamiccontentmetadataid` |
| **PrimaryNameAttribute** |`msdyncrm_value` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_marketingdynamiccontentmetadataId](#BKMK_msdyncrm_marketingdynamiccontentmetadataId)
- [msdyncrm_value](#BKMK_msdyncrm_value)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadataId"></a> msdyncrm_marketingdynamiccontentmetadataId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Dynamic-content metadata**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingdynamiccontentmetadataid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_value"></a> msdyncrm_value

|Property|Value|
|---|---|
|Description|**The value of the custom entity**|
|DisplayName|**Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_value`|
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
|Description|**Date and time that the record was migrated**|
|DisplayName|**Record created on**|
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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner ID**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the marketing dynamic-content metadata**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingdynamiccontentmetadata_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Dynamic-content metadata status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingdynamiccontentmetadata_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time-zone rule version number**|
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
|Description|**Time-zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time-zone code**|
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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who created this.**|
|DisplayName|**Created by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created**|
|DisplayName|**Created on**|
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
|Description|**Indicates the person who created this for another person.**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who modified this.**|
|DisplayName|**Modified by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified**|
|DisplayName|**Modified on**|
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
|Description|**Indicates the person who modified this for another person.**|
|DisplayName|**Modified by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Indicates the business unit that owns this.**|
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Indicates the team that owns this.**|
|DisplayName|**Owning team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Indicates the team that owns this.**|
|DisplayName|**Owning user**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
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

- [business_unit_msdyncrm_marketingdynamiccontentmetadata](#BKMK_business_unit_msdyncrm_marketingdynamiccontentmetadata)
- [lk_msdyncrm_marketingdynamiccontentmetadata_createdby](#BKMK_lk_msdyncrm_marketingdynamiccontentmetadata_createdby)
- [lk_msdyncrm_marketingdynamiccontentmetadata_createdonbehalfby](#BKMK_lk_msdyncrm_marketingdynamiccontentmetadata_createdonbehalfby)
- [lk_msdyncrm_marketingdynamiccontentmetadata_modifiedby](#BKMK_lk_msdyncrm_marketingdynamiccontentmetadata_modifiedby)
- [lk_msdyncrm_marketingdynamiccontentmetadata_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingdynamiccontentmetadata_modifiedonbehalfby)
- [owner_msdyncrm_marketingdynamiccontentmetadata](#BKMK_owner_msdyncrm_marketingdynamiccontentmetadata)
- [team_msdyncrm_marketingdynamiccontentmetadata](#BKMK_team_msdyncrm_marketingdynamiccontentmetadata)
- [user_msdyncrm_marketingdynamiccontentmetadata](#BKMK_user_msdyncrm_marketingdynamiccontentmetadata)

### <a name="BKMK_business_unit_msdyncrm_marketingdynamiccontentmetadata"></a> business_unit_msdyncrm_marketingdynamiccontentmetadata

One-To-Many Relationship: [businessunit business_unit_msdyncrm_marketingdynamiccontentmetadata](businessunit.md#BKMK_business_unit_msdyncrm_marketingdynamiccontentmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingdynamiccontentmetadata_createdby"></a> lk_msdyncrm_marketingdynamiccontentmetadata_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingdynamiccontentmetadata_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingdynamiccontentmetadata_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingdynamiccontentmetadata_createdonbehalfby"></a> lk_msdyncrm_marketingdynamiccontentmetadata_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingdynamiccontentmetadata_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingdynamiccontentmetadata_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingdynamiccontentmetadata_modifiedby"></a> lk_msdyncrm_marketingdynamiccontentmetadata_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingdynamiccontentmetadata_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingdynamiccontentmetadata_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingdynamiccontentmetadata_modifiedonbehalfby"></a> lk_msdyncrm_marketingdynamiccontentmetadata_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingdynamiccontentmetadata_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingdynamiccontentmetadata_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_marketingdynamiccontentmetadata"></a> owner_msdyncrm_marketingdynamiccontentmetadata

One-To-Many Relationship: [owner owner_msdyncrm_marketingdynamiccontentmetadata](owner.md#BKMK_owner_msdyncrm_marketingdynamiccontentmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_marketingdynamiccontentmetadata"></a> team_msdyncrm_marketingdynamiccontentmetadata

One-To-Many Relationship: [team team_msdyncrm_marketingdynamiccontentmetadata](team.md#BKMK_team_msdyncrm_marketingdynamiccontentmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_marketingdynamiccontentmetadata"></a> user_msdyncrm_marketingdynamiccontentmetadata

One-To-Many Relationship: [systemuser user_msdyncrm_marketingdynamiccontentmetadata](systemuser.md#BKMK_user_msdyncrm_marketingdynamiccontentmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyncrm_marketingdynamiccontentmetadata_ActivityPointers](#BKMK_msdyncrm_marketingdynamiccontentmetadata_ActivityPointers)
- [msdyncrm_marketingdynamiccontentmetadata_adx_alertsubscriptions](#BKMK_msdyncrm_marketingdynamiccontentmetadata_adx_alertsubscriptions)
- [msdyncrm_marketingdynamiccontentmetadata_adx_inviteredemptions](#BKMK_msdyncrm_marketingdynamiccontentmetadata_adx_inviteredemptions)
- [msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments](#BKMK_msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments)
- [msdyncrm_marketingdynamiccontentmetadata_Annotations](#BKMK_msdyncrm_marketingdynamiccontentmetadata_Annotations)
- [msdyncrm_marketingdynamiccontentmetadata_Appointments](#BKMK_msdyncrm_marketingdynamiccontentmetadata_Appointments)
- [msdyncrm_marketingdynamiccontentmetadata_AsyncOperations](#BKMK_msdyncrm_marketingdynamiccontentmetadata_AsyncOperations)
- [msdyncrm_marketingdynamiccontentmetadata_BulkDeleteFailures](#BKMK_msdyncrm_marketingdynamiccontentmetadata_BulkDeleteFailures)
- [msdyncrm_marketingdynamiccontentmetadata_chats](#BKMK_msdyncrm_marketingdynamiccontentmetadata_chats)
- [msdyncrm_marketingdynamiccontentmetadata_connections1](#BKMK_msdyncrm_marketingdynamiccontentmetadata_connections1)
- [msdyncrm_marketingdynamiccontentmetadata_connections2](#BKMK_msdyncrm_marketingdynamiccontentmetadata_connections2)
- [msdyncrm_marketingdynamiccontentmetadata_DuplicateBaseRecord](#BKMK_msdyncrm_marketingdynamiccontentmetadata_DuplicateBaseRecord)
- [msdyncrm_marketingdynamiccontentmetadata_DuplicateMatchingRecord](#BKMK_msdyncrm_marketingdynamiccontentmetadata_DuplicateMatchingRecord)
- [msdyncrm_marketingdynamiccontentmetadata_Emails](#BKMK_msdyncrm_marketingdynamiccontentmetadata_Emails)
- [msdyncrm_marketingdynamiccontentmetadata_Faxes](#BKMK_msdyncrm_marketingdynamiccontentmetadata_Faxes)
- [msdyncrm_marketingdynamiccontentmetadata_Feedback](#BKMK_msdyncrm_marketingdynamiccontentmetadata_Feedback)
- [msdyncrm_marketingdynamiccontentmetadata_Letters](#BKMK_msdyncrm_marketingdynamiccontentmetadata_Letters)
- [msdyncrm_marketingdynamiccontentmetadata_li_inmails](#BKMK_msdyncrm_marketingdynamiccontentmetadata_li_inmails)
- [msdyncrm_marketingdynamiccontentmetadata_li_messages](#BKMK_msdyncrm_marketingdynamiccontentmetadata_li_messages)
- [msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds)
- [msdyncrm_marketingdynamiccontentmetadata_MailboxTrackingFolders](#BKMK_msdyncrm_marketingdynamiccontentmetadata_MailboxTrackingFolders)
- [msdyncrm_marketingdynamiccontentmetadata_msdyn_bookingalerts](#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_bookingalerts)
- [msdyncrm_marketingdynamiccontentmetadata_msdyn_copilottranscripts](#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_copilottranscripts)
- [msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems](#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems)
- [msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages](#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages)
- [msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions](#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions)
- [msdyncrm_marketingdynamiccontentmetadata_msdyn_ocvoicemails](#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocvoicemails)
- [msdyncrm_marketingdynamiccontentmetadata_msfp_alerts](#BKMK_msdyncrm_marketingdynamiccontentmetadata_msfp_alerts)
- [msdyncrm_marketingdynamiccontentmetadata_msfp_surveyinvites](#BKMK_msdyncrm_marketingdynamiccontentmetadata_msfp_surveyinvites)
- [msdyncrm_marketingdynamiccontentmetadata_msfp_surveyresponses](#BKMK_msdyncrm_marketingdynamiccontentmetadata_msfp_surveyresponses)
- [msdyncrm_marketingdynamiccontentmetadata_PhoneCalls](#BKMK_msdyncrm_marketingdynamiccontentmetadata_PhoneCalls)
- [msdyncrm_marketingdynamiccontentmetadata_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingdynamiccontentmetadata_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingdynamiccontentmetadata_ProcessSession](#BKMK_msdyncrm_marketingdynamiccontentmetadata_ProcessSession)
- [msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters](#BKMK_msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters)
- [msdyncrm_marketingdynamiccontentmetadata_ServiceAppointments](#BKMK_msdyncrm_marketingdynamiccontentmetadata_ServiceAppointments)
- [msdyncrm_marketingdynamiccontentmetadata_SocialActivities](#BKMK_msdyncrm_marketingdynamiccontentmetadata_SocialActivities)
- [msdyncrm_marketingdynamiccontentmetadata_SyncErrors](#BKMK_msdyncrm_marketingdynamiccontentmetadata_SyncErrors)
- [msdyncrm_marketingdynamiccontentmetadata_Tasks](#BKMK_msdyncrm_marketingdynamiccontentmetadata_Tasks)

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_ActivityPointers"></a> msdyncrm_marketingdynamiccontentmetadata_ActivityPointers

Many-To-One Relationship: [activitypointer msdyncrm_marketingdynamiccontentmetadata_ActivityPointers](activitypointer.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_adx_alertsubscriptions"></a> msdyncrm_marketingdynamiccontentmetadata_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msdyncrm_marketingdynamiccontentmetadata_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_adx_inviteredemptions"></a> msdyncrm_marketingdynamiccontentmetadata_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyncrm_marketingdynamiccontentmetadata_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments"></a> msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments](adx_portalcomment.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_Annotations"></a> msdyncrm_marketingdynamiccontentmetadata_Annotations

Many-To-One Relationship: [annotation msdyncrm_marketingdynamiccontentmetadata_Annotations](annotation.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_Appointments"></a> msdyncrm_marketingdynamiccontentmetadata_Appointments

Many-To-One Relationship: [appointment msdyncrm_marketingdynamiccontentmetadata_Appointments](appointment.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_AsyncOperations"></a> msdyncrm_marketingdynamiccontentmetadata_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingdynamiccontentmetadata_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_BulkDeleteFailures"></a> msdyncrm_marketingdynamiccontentmetadata_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingdynamiccontentmetadata_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_chats"></a> msdyncrm_marketingdynamiccontentmetadata_chats

Many-To-One Relationship: [chat msdyncrm_marketingdynamiccontentmetadata_chats](chat.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_connections1"></a> msdyncrm_marketingdynamiccontentmetadata_connections1

Many-To-One Relationship: [connection msdyncrm_marketingdynamiccontentmetadata_connections1](connection.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_connections2"></a> msdyncrm_marketingdynamiccontentmetadata_connections2

Many-To-One Relationship: [connection msdyncrm_marketingdynamiccontentmetadata_connections2](connection.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_DuplicateBaseRecord"></a> msdyncrm_marketingdynamiccontentmetadata_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_marketingdynamiccontentmetadata_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_DuplicateMatchingRecord"></a> msdyncrm_marketingdynamiccontentmetadata_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_marketingdynamiccontentmetadata_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_Emails"></a> msdyncrm_marketingdynamiccontentmetadata_Emails

Many-To-One Relationship: [email msdyncrm_marketingdynamiccontentmetadata_Emails](email.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_Faxes"></a> msdyncrm_marketingdynamiccontentmetadata_Faxes

Many-To-One Relationship: [fax msdyncrm_marketingdynamiccontentmetadata_Faxes](fax.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_Feedback"></a> msdyncrm_marketingdynamiccontentmetadata_Feedback

Many-To-One Relationship: [feedback msdyncrm_marketingdynamiccontentmetadata_Feedback](feedback.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_Letters"></a> msdyncrm_marketingdynamiccontentmetadata_Letters

Many-To-One Relationship: [letter msdyncrm_marketingdynamiccontentmetadata_Letters](letter.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_li_inmails"></a> msdyncrm_marketingdynamiccontentmetadata_li_inmails

Many-To-One Relationship: [li_inmail msdyncrm_marketingdynamiccontentmetadata_li_inmails](li_inmail.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_li_messages"></a> msdyncrm_marketingdynamiccontentmetadata_li_messages

Many-To-One Relationship: [li_message msdyncrm_marketingdynamiccontentmetadata_li_messages](li_message.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds"></a> msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_MailboxTrackingFolders"></a> msdyncrm_marketingdynamiccontentmetadata_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingdynamiccontentmetadata_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_bookingalerts"></a> msdyncrm_marketingdynamiccontentmetadata_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyncrm_marketingdynamiccontentmetadata_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_copilottranscripts"></a> msdyncrm_marketingdynamiccontentmetadata_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyncrm_marketingdynamiccontentmetadata_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems"></a> msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages"></a> msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions"></a> msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocvoicemails"></a> msdyncrm_marketingdynamiccontentmetadata_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyncrm_marketingdynamiccontentmetadata_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_msfp_alerts"></a> msdyncrm_marketingdynamiccontentmetadata_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyncrm_marketingdynamiccontentmetadata_msfp_alerts](msfp_alert.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_msfp_surveyinvites"></a> msdyncrm_marketingdynamiccontentmetadata_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyncrm_marketingdynamiccontentmetadata_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_msfp_surveyresponses"></a> msdyncrm_marketingdynamiccontentmetadata_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyncrm_marketingdynamiccontentmetadata_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_PhoneCalls"></a> msdyncrm_marketingdynamiccontentmetadata_PhoneCalls

Many-To-One Relationship: [phonecall msdyncrm_marketingdynamiccontentmetadata_PhoneCalls](phonecall.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingdynamiccontentmetadata_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingdynamiccontentmetadata_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_ProcessSession"></a> msdyncrm_marketingdynamiccontentmetadata_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingdynamiccontentmetadata_ProcessSession](processsession.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters"></a> msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_ServiceAppointments"></a> msdyncrm_marketingdynamiccontentmetadata_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyncrm_marketingdynamiccontentmetadata_ServiceAppointments](serviceappointment.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_SocialActivities"></a> msdyncrm_marketingdynamiccontentmetadata_SocialActivities

Many-To-One Relationship: [socialactivity msdyncrm_marketingdynamiccontentmetadata_SocialActivities](socialactivity.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_SyncErrors"></a> msdyncrm_marketingdynamiccontentmetadata_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingdynamiccontentmetadata_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_Tasks"></a> msdyncrm_marketingdynamiccontentmetadata_Tasks

Many-To-One Relationship: [task msdyncrm_marketingdynamiccontentmetadata_Tasks](task.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingdynamiccontentmetadata_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

