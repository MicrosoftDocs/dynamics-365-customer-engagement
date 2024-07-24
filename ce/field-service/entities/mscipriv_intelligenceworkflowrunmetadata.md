---
title: "IntelligenceWorkflowRunMetadata (mscipriv_intelligenceworkflowrunmetadata) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the IntelligenceWorkflowRunMetadata (mscipriv_intelligenceworkflowrunmetadata) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# IntelligenceWorkflowRunMetadata (mscipriv_intelligenceworkflowrunmetadata) table/entity reference

IntelligenceWorkflowRunMetadata

## Messages

The following table lists the messages for the IntelligenceWorkflowRunMetadata (mscipriv_intelligenceworkflowrunmetadata) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /mscipriv_intelligenceworkflowrunmetadatas(*mscipriv_intelligenceworkflowrunmetadataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /mscipriv_intelligenceworkflowrunmetadatas<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /mscipriv_intelligenceworkflowrunmetadatas(*mscipriv_intelligenceworkflowrunmetadataid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /mscipriv_intelligenceworkflowrunmetadatas(*mscipriv_intelligenceworkflowrunmetadataid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /mscipriv_intelligenceworkflowrunmetadatas<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /mscipriv_intelligenceworkflowrunmetadatas(*mscipriv_intelligenceworkflowrunmetadataid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /mscipriv_intelligenceworkflowrunmetadatas(*mscipriv_intelligenceworkflowrunmetadataid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /mscipriv_intelligenceworkflowrunmetadatas(*mscipriv_intelligenceworkflowrunmetadataid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the IntelligenceWorkflowRunMetadata (mscipriv_intelligenceworkflowrunmetadata) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the IntelligenceWorkflowRunMetadata (mscipriv_intelligenceworkflowrunmetadata) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **IntelligenceWorkflowRunMetadata** |
| **DisplayCollectionName** | **IntelligenceWorkflowRunMetadatas** |
| **SchemaName** | `mscipriv_intelligenceworkflowrunmetadata` |
| **CollectionSchemaName** | `mscipriv_intelligenceworkflowrunmetadatas` |
| **EntitySetName** | `mscipriv_intelligenceworkflowrunmetadatas`|
| **LogicalName** | `mscipriv_intelligenceworkflowrunmetadata` |
| **LogicalCollectionName** | `mscipriv_intelligenceworkflowrunmetadatas` |
| **PrimaryIdAttribute** | `mscipriv_intelligenceworkflowrunmetadataid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [mscipriv_intelligenceworkflowrunmetadataId](#BKMK_mscipriv_intelligenceworkflowrunmetadataId)
- [mscipriv_payload1](#BKMK_mscipriv_payload1)
- [mscipriv_payload2](#BKMK_mscipriv_payload2)
- [msdyn_isdeleted](#BKMK_msdyn_isdeleted)
- [msdyn_ishistoryentry](#BKMK_msdyn_ishistoryentry)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_partitionkey](#BKMK_msdyn_partitionkey)
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
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_mscipriv_intelligenceworkflowrunmetadataId"></a> mscipriv_intelligenceworkflowrunmetadataId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**IntelligenceWorkflowRunMetadata**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`mscipriv_intelligenceworkflowrunmetadataid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_mscipriv_payload1"></a> mscipriv_payload1

|Property|Value|
|---|---|
|Description|**Payload1**|
|DisplayName|**Payload1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`mscipriv_payload1`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_mscipriv_payload2"></a> mscipriv_payload2

|Property|Value|
|---|---|
|Description|**Payload2**|
|DisplayName|**Payload2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`mscipriv_payload2`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_isdeleted"></a> msdyn_isdeleted

|Property|Value|
|---|---|
|Description||
|DisplayName|**IsDeleted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isdeleted`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`mscipriv_intelligenceworkflowrunmetadata_msdyn_isdeleted`|
|DefaultValue|False|
|True Label|true|
|False Label|false|

### <a name="BKMK_msdyn_ishistoryentry"></a> msdyn_ishistoryentry

|Property|Value|
|---|---|
|Description|**IsHistoryEntry**|
|DisplayName|**IsHistoryEntry**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ishistoryentry`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`mscipriv_intelligenceworkflowrunmetadata_msdyn_ishistoryentry`|
|DefaultValue|False|
|True Label|true|
|False Label|false|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Name**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_partitionkey"></a> msdyn_partitionkey

|Property|Value|
|---|---|
|Description|**PartitionKey**|
|DisplayName|**PartitionKey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_partitionkey`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
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
|Description|**Status of the IntelligenceWorkflowRunMetadata**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`mscipriv_intelligenceworkflowrunmetadata_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the IntelligenceWorkflowRunMetadata**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`mscipriv_intelligenceworkflowrunmetadata_statuscode`|

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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
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

- [business_unit_mscipriv_intelligenceworkflowrunmetadata](#BKMK_business_unit_mscipriv_intelligenceworkflowrunmetadata)
- [lk_mscipriv_intelligenceworkflowrunmetadata_createdby](#BKMK_lk_mscipriv_intelligenceworkflowrunmetadata_createdby)
- [lk_mscipriv_intelligenceworkflowrunmetadata_createdonbehalfby](#BKMK_lk_mscipriv_intelligenceworkflowrunmetadata_createdonbehalfby)
- [lk_mscipriv_intelligenceworkflowrunmetadata_modifiedby](#BKMK_lk_mscipriv_intelligenceworkflowrunmetadata_modifiedby)
- [lk_mscipriv_intelligenceworkflowrunmetadata_modifiedonbehalfby](#BKMK_lk_mscipriv_intelligenceworkflowrunmetadata_modifiedonbehalfby)
- [owner_mscipriv_intelligenceworkflowrunmetadata](#BKMK_owner_mscipriv_intelligenceworkflowrunmetadata)
- [team_mscipriv_intelligenceworkflowrunmetadata](#BKMK_team_mscipriv_intelligenceworkflowrunmetadata)
- [user_mscipriv_intelligenceworkflowrunmetadata](#BKMK_user_mscipriv_intelligenceworkflowrunmetadata)

### <a name="BKMK_business_unit_mscipriv_intelligenceworkflowrunmetadata"></a> business_unit_mscipriv_intelligenceworkflowrunmetadata

One-To-Many Relationship: [businessunit business_unit_mscipriv_intelligenceworkflowrunmetadata](businessunit.md#BKMK_business_unit_mscipriv_intelligenceworkflowrunmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_mscipriv_intelligenceworkflowrunmetadata_createdby"></a> lk_mscipriv_intelligenceworkflowrunmetadata_createdby

One-To-Many Relationship: [systemuser lk_mscipriv_intelligenceworkflowrunmetadata_createdby](systemuser.md#BKMK_lk_mscipriv_intelligenceworkflowrunmetadata_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_mscipriv_intelligenceworkflowrunmetadata_createdonbehalfby"></a> lk_mscipriv_intelligenceworkflowrunmetadata_createdonbehalfby

One-To-Many Relationship: [systemuser lk_mscipriv_intelligenceworkflowrunmetadata_createdonbehalfby](systemuser.md#BKMK_lk_mscipriv_intelligenceworkflowrunmetadata_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_mscipriv_intelligenceworkflowrunmetadata_modifiedby"></a> lk_mscipriv_intelligenceworkflowrunmetadata_modifiedby

One-To-Many Relationship: [systemuser lk_mscipriv_intelligenceworkflowrunmetadata_modifiedby](systemuser.md#BKMK_lk_mscipriv_intelligenceworkflowrunmetadata_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_mscipriv_intelligenceworkflowrunmetadata_modifiedonbehalfby"></a> lk_mscipriv_intelligenceworkflowrunmetadata_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_mscipriv_intelligenceworkflowrunmetadata_modifiedonbehalfby](systemuser.md#BKMK_lk_mscipriv_intelligenceworkflowrunmetadata_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_mscipriv_intelligenceworkflowrunmetadata"></a> owner_mscipriv_intelligenceworkflowrunmetadata

One-To-Many Relationship: [owner owner_mscipriv_intelligenceworkflowrunmetadata](owner.md#BKMK_owner_mscipriv_intelligenceworkflowrunmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_mscipriv_intelligenceworkflowrunmetadata"></a> team_mscipriv_intelligenceworkflowrunmetadata

One-To-Many Relationship: [team team_mscipriv_intelligenceworkflowrunmetadata](team.md#BKMK_team_mscipriv_intelligenceworkflowrunmetadata)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_mscipriv_intelligenceworkflowrunmetadata"></a> user_mscipriv_intelligenceworkflowrunmetadata

One-To-Many Relationship: [systemuser user_mscipriv_intelligenceworkflowrunmetadata](systemuser.md#BKMK_user_mscipriv_intelligenceworkflowrunmetadata)

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

- [mscipriv_intelligenceworkflowrunmetadata_AsyncOperations](#BKMK_mscipriv_intelligenceworkflowrunmetadata_AsyncOperations)
- [mscipriv_intelligenceworkflowrunmetadata_BulkDeleteFailures](#BKMK_mscipriv_intelligenceworkflowrunmetadata_BulkDeleteFailures)
- [mscipriv_intelligenceworkflowrunmetadata_MailboxTrackingFolders](#BKMK_mscipriv_intelligenceworkflowrunmetadata_MailboxTrackingFolders)
- [mscipriv_intelligenceworkflowrunmetadata_PrincipalObjectAttributeAccesses](#BKMK_mscipriv_intelligenceworkflowrunmetadata_PrincipalObjectAttributeAccesses)
- [mscipriv_intelligenceworkflowrunmetadata_ProcessSession](#BKMK_mscipriv_intelligenceworkflowrunmetadata_ProcessSession)
- [mscipriv_intelligenceworkflowrunmetadata_SyncErrors](#BKMK_mscipriv_intelligenceworkflowrunmetadata_SyncErrors)

### <a name="BKMK_mscipriv_intelligenceworkflowrunmetadata_AsyncOperations"></a> mscipriv_intelligenceworkflowrunmetadata_AsyncOperations

Many-To-One Relationship: [asyncoperation mscipriv_intelligenceworkflowrunmetadata_AsyncOperations](asyncoperation.md#BKMK_mscipriv_intelligenceworkflowrunmetadata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mscipriv_intelligenceworkflowrunmetadata_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mscipriv_intelligenceworkflowrunmetadata_BulkDeleteFailures"></a> mscipriv_intelligenceworkflowrunmetadata_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure mscipriv_intelligenceworkflowrunmetadata_BulkDeleteFailures](bulkdeletefailure.md#BKMK_mscipriv_intelligenceworkflowrunmetadata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mscipriv_intelligenceworkflowrunmetadata_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mscipriv_intelligenceworkflowrunmetadata_MailboxTrackingFolders"></a> mscipriv_intelligenceworkflowrunmetadata_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder mscipriv_intelligenceworkflowrunmetadata_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_mscipriv_intelligenceworkflowrunmetadata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mscipriv_intelligenceworkflowrunmetadata_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mscipriv_intelligenceworkflowrunmetadata_PrincipalObjectAttributeAccesses"></a> mscipriv_intelligenceworkflowrunmetadata_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess mscipriv_intelligenceworkflowrunmetadata_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_mscipriv_intelligenceworkflowrunmetadata_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`mscipriv_intelligenceworkflowrunmetadata_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mscipriv_intelligenceworkflowrunmetadata_ProcessSession"></a> mscipriv_intelligenceworkflowrunmetadata_ProcessSession

Many-To-One Relationship: [processsession mscipriv_intelligenceworkflowrunmetadata_ProcessSession](processsession.md#BKMK_mscipriv_intelligenceworkflowrunmetadata_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mscipriv_intelligenceworkflowrunmetadata_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mscipriv_intelligenceworkflowrunmetadata_SyncErrors"></a> mscipriv_intelligenceworkflowrunmetadata_SyncErrors

Many-To-One Relationship: [syncerror mscipriv_intelligenceworkflowrunmetadata_SyncErrors](syncerror.md#BKMK_mscipriv_intelligenceworkflowrunmetadata_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mscipriv_intelligenceworkflowrunmetadata_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

