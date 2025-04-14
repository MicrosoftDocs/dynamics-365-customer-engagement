---
title: "Metadata Entity Relationship (msdynmkt_metadataentityrelationship) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Metadata Entity Relationship (msdynmkt_metadataentityrelationship) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Metadata Entity Relationship (msdynmkt_metadataentityrelationship) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Metadata Entity Relationship (msdynmkt_metadataentityrelationship) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_metadataentityrelationships(*msdynmkt_metadataentityrelationshipid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdynmkt_metadataentityrelationships<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_metadataentityrelationships(*msdynmkt_metadataentityrelationshipid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_metadataentityrelationships(*msdynmkt_metadataentityrelationshipid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_metadataentityrelationships<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_metadataentityrelationships(*msdynmkt_metadataentityrelationshipid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_metadataentityrelationships(*msdynmkt_metadataentityrelationshipid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_metadataentityrelationships(*msdynmkt_metadataentityrelationshipid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Metadata Entity Relationship (msdynmkt_metadataentityrelationship) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Metadata Entity Relationship** |
| **DisplayCollectionName** | **Metadata Entity Relationships** |
| **SchemaName** | `msdynmkt_metadataentityrelationship` |
| **CollectionSchemaName** | `msdynmkt_metadataentityrelationships` |
| **EntitySetName** | `msdynmkt_metadataentityrelationships`|
| **LogicalName** | `msdynmkt_metadataentityrelationship` |
| **LogicalCollectionName** | `msdynmkt_metadataentityrelationships` |
| **PrimaryIdAttribute** | `msdynmkt_metadataentityrelationshipid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_hastomanyrelationship](#BKMK_msdynmkt_hastomanyrelationship)
- [msdynmkt_hastoonerelationship](#BKMK_msdynmkt_hastoonerelationship)
- [msdynmkt_metadataentityrelationshipId](#BKMK_msdynmkt_metadataentityrelationshipId)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_primaryentity](#BKMK_msdynmkt_primaryentity)
- [msdynmkt_relatedentity](#BKMK_msdynmkt_relatedentity)
- [msdynmkt_sourcetype](#BKMK_msdynmkt_sourcetype)
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

### <a name="BKMK_msdynmkt_hastomanyrelationship"></a> msdynmkt_hastomanyrelationship

|Property|Value|
|---|---|
|Description||
|DisplayName|**Has To Many Relationship**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_hastomanyrelationship`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_metadataentityrelationship_msdynmkt_hastomanyrelationship`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_hastoonerelationship"></a> msdynmkt_hastoonerelationship

|Property|Value|
|---|---|
|Description||
|DisplayName|**Has To One Relationship**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_hastoonerelationship`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_metadataentityrelationship_msdynmkt_hastoonerelationship`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_metadataentityrelationshipId"></a> msdynmkt_metadataentityrelationshipId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Metadata Entity Relationship**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_metadataentityrelationshipid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_primaryentity"></a> msdynmkt_primaryentity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Primary Entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_primaryentity`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_relatedentity"></a> msdynmkt_relatedentity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Related Entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_relatedentity`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_sourcetype"></a> msdynmkt_sourcetype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourcetype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_metadataentityrelationship_msdynmkt_sourcetype`|

#### msdynmkt_sourcetype Choices/Options

|Value|Label|
|---|---|
|534120000|**Dataverse Table**|
|534120001|**CJO Interaction Event**|
|534120002|**CJO Business Event**|
|534120003|**CJO Custom Event**|
|534120004|**Legal**|
|534120005|**External**|

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
|Description|**Status of the Metadata Entity Relationship**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_metadataentityrelationship_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Metadata Entity Relationship**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_metadataentityrelationship_statuscode`|

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

- [business_unit_msdynmkt_metadataentityrelationship](#BKMK_business_unit_msdynmkt_metadataentityrelationship)
- [lk_msdynmkt_metadataentityrelationship_createdby](#BKMK_lk_msdynmkt_metadataentityrelationship_createdby)
- [lk_msdynmkt_metadataentityrelationship_createdonbehalfby](#BKMK_lk_msdynmkt_metadataentityrelationship_createdonbehalfby)
- [lk_msdynmkt_metadataentityrelationship_modifiedby](#BKMK_lk_msdynmkt_metadataentityrelationship_modifiedby)
- [lk_msdynmkt_metadataentityrelationship_modifiedonbehalfby](#BKMK_lk_msdynmkt_metadataentityrelationship_modifiedonbehalfby)
- [owner_msdynmkt_metadataentityrelationship](#BKMK_owner_msdynmkt_metadataentityrelationship)
- [team_msdynmkt_metadataentityrelationship](#BKMK_team_msdynmkt_metadataentityrelationship)
- [user_msdynmkt_metadataentityrelationship](#BKMK_user_msdynmkt_metadataentityrelationship)

### <a name="BKMK_business_unit_msdynmkt_metadataentityrelationship"></a> business_unit_msdynmkt_metadataentityrelationship

One-To-Many Relationship: [businessunit business_unit_msdynmkt_metadataentityrelationship](businessunit.md#BKMK_business_unit_msdynmkt_metadataentityrelationship)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_metadataentityrelationship_createdby"></a> lk_msdynmkt_metadataentityrelationship_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_metadataentityrelationship_createdby](systemuser.md#BKMK_lk_msdynmkt_metadataentityrelationship_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_metadataentityrelationship_createdonbehalfby"></a> lk_msdynmkt_metadataentityrelationship_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_metadataentityrelationship_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_metadataentityrelationship_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_metadataentityrelationship_modifiedby"></a> lk_msdynmkt_metadataentityrelationship_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_metadataentityrelationship_modifiedby](systemuser.md#BKMK_lk_msdynmkt_metadataentityrelationship_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_metadataentityrelationship_modifiedonbehalfby"></a> lk_msdynmkt_metadataentityrelationship_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_metadataentityrelationship_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_metadataentityrelationship_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_metadataentityrelationship"></a> owner_msdynmkt_metadataentityrelationship

One-To-Many Relationship: [owner owner_msdynmkt_metadataentityrelationship](owner.md#BKMK_owner_msdynmkt_metadataentityrelationship)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_metadataentityrelationship"></a> team_msdynmkt_metadataentityrelationship

One-To-Many Relationship: [team team_msdynmkt_metadataentityrelationship](team.md#BKMK_team_msdynmkt_metadataentityrelationship)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_metadataentityrelationship"></a> user_msdynmkt_metadataentityrelationship

One-To-Many Relationship: [systemuser user_msdynmkt_metadataentityrelationship](systemuser.md#BKMK_user_msdynmkt_metadataentityrelationship)

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

- [msdynmkt_metadataentityrelationship_AsyncOperations](#BKMK_msdynmkt_metadataentityrelationship_AsyncOperations)
- [msdynmkt_metadataentityrelationship_BulkDeleteFailures](#BKMK_msdynmkt_metadataentityrelationship_BulkDeleteFailures)
- [msdynmkt_metadataentityrelationship_DuplicateBaseRecord](#BKMK_msdynmkt_metadataentityrelationship_DuplicateBaseRecord)
- [msdynmkt_metadataentityrelationship_DuplicateMatchingRecord](#BKMK_msdynmkt_metadataentityrelationship_DuplicateMatchingRecord)
- [msdynmkt_metadataentityrelationship_MailboxTrackingFolders](#BKMK_msdynmkt_metadataentityrelationship_MailboxTrackingFolders)
- [msdynmkt_metadataentityrelationship_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_metadataentityrelationship_PrincipalObjectAttributeAccesses)
- [msdynmkt_metadataentityrelationship_ProcessSession](#BKMK_msdynmkt_metadataentityrelationship_ProcessSession)
- [msdynmkt_metadataentityrelationship_SyncErrors](#BKMK_msdynmkt_metadataentityrelationship_SyncErrors)

### <a name="BKMK_msdynmkt_metadataentityrelationship_AsyncOperations"></a> msdynmkt_metadataentityrelationship_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_metadataentityrelationship_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_metadataentityrelationship_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataentityrelationship_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataentityrelationship_BulkDeleteFailures"></a> msdynmkt_metadataentityrelationship_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_metadataentityrelationship_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_metadataentityrelationship_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataentityrelationship_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataentityrelationship_DuplicateBaseRecord"></a> msdynmkt_metadataentityrelationship_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_metadataentityrelationship_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_metadataentityrelationship_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataentityrelationship_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataentityrelationship_DuplicateMatchingRecord"></a> msdynmkt_metadataentityrelationship_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_metadataentityrelationship_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_metadataentityrelationship_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataentityrelationship_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataentityrelationship_MailboxTrackingFolders"></a> msdynmkt_metadataentityrelationship_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_metadataentityrelationship_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_metadataentityrelationship_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataentityrelationship_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataentityrelationship_PrincipalObjectAttributeAccesses"></a> msdynmkt_metadataentityrelationship_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_metadataentityrelationship_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_metadataentityrelationship_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataentityrelationship_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataentityrelationship_ProcessSession"></a> msdynmkt_metadataentityrelationship_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_metadataentityrelationship_ProcessSession](processsession.md#BKMK_msdynmkt_metadataentityrelationship_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataentityrelationship_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_metadataentityrelationship_SyncErrors"></a> msdynmkt_metadataentityrelationship_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_metadataentityrelationship_SyncErrors](syncerror.md#BKMK_msdynmkt_metadataentityrelationship_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_metadataentityrelationship_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

