---
title: "AlternateKey (msdynci_alternatekey) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the AlternateKey (msdynci_alternatekey) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# AlternateKey (msdynci_alternatekey) table/entity reference



## Messages

The following table lists the messages for the AlternateKey (msdynci_alternatekey) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynci_alternatekeys(*msdynci_alternatekeyid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynci_alternatekeys<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynci_alternatekeys(*msdynci_alternatekeyid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdynci_alternatekeys(*msdynci_alternatekeyid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynci_alternatekeys<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `Update`<br />Event: True |`PATCH` /msdynci_alternatekeys(*msdynci_alternatekeyid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdynci_alternatekeys(*msdynci_alternatekeyid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the AlternateKey (msdynci_alternatekey) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the AlternateKey (msdynci_alternatekey) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **AlternateKey** |
| **DisplayCollectionName** | **AlternateKey** |
| **SchemaName** | `msdynci_alternatekey` |
| **CollectionSchemaName** | `msdynci_alternatekeies` |
| **EntitySetName** | `msdynci_alternatekeys`|
| **LogicalName** | `msdynci_alternatekey` |
| **LogicalCollectionName** | `msdynci_alternatekeies` |
| **PrimaryIdAttribute** | `msdynci_alternatekeyid` |
| **PrimaryNameAttribute** |`msdynci_identifier` |
| **TableType** | `Elastic` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynci_alternatekeyId](#BKMK_msdynci_alternatekeyId)
- [msdynci_alternatevalue](#BKMK_msdynci_alternatevalue)
- [msdynci_customerid](#BKMK_msdynci_customerid)
- [msdynci_datasourcename](#BKMK_msdynci_datasourcename)
- [msdynci_entityname](#BKMK_msdynci_entityname)
- [msdynci_identifier](#BKMK_msdynci_identifier)
- [msdynci_keyring](#BKMK_msdynci_keyring)
- [msdynci_lookupfield_customer](#BKMK_msdynci_lookupfield_customer)
- [msdynci_lookupfield_customerPId](#BKMK_msdynci_lookupfield_customerPId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PartitionId](#BKMK_PartitionId)
- [TTLInSeconds](#BKMK_TTLInSeconds)

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

### <a name="BKMK_msdynci_alternatekeyId"></a> msdynci_alternatekeyId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**AlternateKey**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynci_alternatekeyid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynci_alternatevalue"></a> msdynci_alternatevalue

|Property|Value|
|---|---|
|Description|**AlternateValue**|
|DisplayName|**AlternateValue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_alternatevalue`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynci_customerid"></a> msdynci_customerid

|Property|Value|
|---|---|
|Description|**CustomerId**|
|DisplayName|**CustomerId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_customerid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_datasourcename"></a> msdynci_datasourcename

|Property|Value|
|---|---|
|Description|**DataSourceName**|
|DisplayName|**DataSourceName**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_datasourcename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynci_entityname"></a> msdynci_entityname

|Property|Value|
|---|---|
|Description|**EntityName**|
|DisplayName|**EntityName**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_entityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynci_identifier"></a> msdynci_identifier

|Property|Value|
|---|---|
|Description|**Identifier**|
|DisplayName|**Identifier**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_identifier`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynci_keyring"></a> msdynci_keyring

|Property|Value|
|---|---|
|Description|**KeyRing**|
|DisplayName|**KeyRing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_keyring`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynci_lookupfield_customer"></a> msdynci_lookupfield_customer

|Property|Value|
|---|---|
|Description||
|DisplayName|**msdynci_lookupfield_customer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_lookupfield_customer`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynci_customerprofile|

### <a name="BKMK_msdynci_lookupfield_customerPId"></a> msdynci_lookupfield_customerPId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynci_lookupfield_customerpid`|
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

### <a name="BKMK_PartitionId"></a> PartitionId

|Property|Value|
|---|---|
|Description|**Logical partition id. A logical partition consists of a set of records with same partition id.**|
|DisplayName|**Partition Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`partitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TTLInSeconds"></a> TTLInSeconds

|Property|Value|
|---|---|
|Description|**Time to live in seconds.**|
|DisplayName|**Time to live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ttlinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|


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
|RequiredLevel|SystemRequired|
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

- [business_unit_msdynci_alternatekey](#BKMK_business_unit_msdynci_alternatekey)
- [lk_msdynci_alternatekey_createdby](#BKMK_lk_msdynci_alternatekey_createdby)
- [lk_msdynci_alternatekey_createdonbehalfby](#BKMK_lk_msdynci_alternatekey_createdonbehalfby)
- [lk_msdynci_alternatekey_modifiedby](#BKMK_lk_msdynci_alternatekey_modifiedby)
- [lk_msdynci_alternatekey_modifiedonbehalfby](#BKMK_lk_msdynci_alternatekey_modifiedonbehalfby)
- [msdynci_customer_alternatekey](#BKMK_msdynci_customer_alternatekey)
- [owner_msdynci_alternatekey](#BKMK_owner_msdynci_alternatekey)
- [team_msdynci_alternatekey](#BKMK_team_msdynci_alternatekey)
- [user_msdynci_alternatekey](#BKMK_user_msdynci_alternatekey)

### <a name="BKMK_business_unit_msdynci_alternatekey"></a> business_unit_msdynci_alternatekey

One-To-Many Relationship: [businessunit business_unit_msdynci_alternatekey](businessunit.md#BKMK_business_unit_msdynci_alternatekey)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynci_alternatekey_createdby"></a> lk_msdynci_alternatekey_createdby

One-To-Many Relationship: [systemuser lk_msdynci_alternatekey_createdby](systemuser.md#BKMK_lk_msdynci_alternatekey_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynci_alternatekey_createdonbehalfby"></a> lk_msdynci_alternatekey_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynci_alternatekey_createdonbehalfby](systemuser.md#BKMK_lk_msdynci_alternatekey_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynci_alternatekey_modifiedby"></a> lk_msdynci_alternatekey_modifiedby

One-To-Many Relationship: [systemuser lk_msdynci_alternatekey_modifiedby](systemuser.md#BKMK_lk_msdynci_alternatekey_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynci_alternatekey_modifiedonbehalfby"></a> lk_msdynci_alternatekey_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynci_alternatekey_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynci_alternatekey_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynci_customer_alternatekey"></a> msdynci_customer_alternatekey

One-To-Many Relationship: [msdynci_customerprofile msdynci_customer_alternatekey](msdynci_customerprofile.md#BKMK_msdynci_customer_alternatekey)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynci_customerprofile`|
|ReferencedAttribute|`msdynci_customerprofileid`|
|ReferencingAttribute|`msdynci_lookupfield_customer`|
|ReferencingEntityNavigationPropertyName|`msdynci_lookupfield_customer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynci_alternatekey"></a> owner_msdynci_alternatekey

One-To-Many Relationship: [owner owner_msdynci_alternatekey](owner.md#BKMK_owner_msdynci_alternatekey)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynci_alternatekey"></a> team_msdynci_alternatekey

One-To-Many Relationship: [team team_msdynci_alternatekey](team.md#BKMK_team_msdynci_alternatekey)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynci_alternatekey"></a> user_msdynci_alternatekey

One-To-Many Relationship: [systemuser user_msdynci_alternatekey](systemuser.md#BKMK_user_msdynci_alternatekey)

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

- [msdynci_alternatekey_personalizationcookieref](#BKMK_msdynci_alternatekey_personalizationcookieref)
- [msdynci_PersonalizationAction_AlternateKe](#BKMK_msdynci_PersonalizationAction_AlternateKe)
- [msdynci_PersonalizationUser_AlternateKeyR](#BKMK_msdynci_PersonalizationUser_AlternateKeyR)
- [msdynci_PersonalizationView_AlternateKeyR](#BKMK_msdynci_PersonalizationView_AlternateKeyR)

### <a name="BKMK_msdynci_alternatekey_personalizationcookieref"></a> msdynci_alternatekey_personalizationcookieref

Many-To-One Relationship: [msdynci_personalizationcookie msdynci_alternatekey_personalizationcookieref](msdynci_personalizationcookie.md#BKMK_msdynci_alternatekey_personalizationcookieref)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_personalizationcookie`|
|ReferencingAttribute|`msdynci_lookupfield_alternatekey`|
|ReferencedEntityNavigationPropertyName|`msdynci_alternatekey_personalizationcookieref`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynci_PersonalizationAction_AlternateKe"></a> msdynci_PersonalizationAction_AlternateKe

Many-To-One Relationship: [msdynci_personalizationaction msdynci_PersonalizationAction_AlternateKe](msdynci_personalizationaction.md#BKMK_msdynci_PersonalizationAction_AlternateKe)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_personalizationaction`|
|ReferencingAttribute|`msdynci_alternatekeyreference`|
|ReferencedEntityNavigationPropertyName|`msdynci_PersonalizationAction_AlternateKe`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynci_PersonalizationUser_AlternateKeyR"></a> msdynci_PersonalizationUser_AlternateKeyR

Many-To-One Relationship: [msdynci_personalizationuser msdynci_PersonalizationUser_AlternateKeyR](msdynci_personalizationuser.md#BKMK_msdynci_PersonalizationUser_AlternateKeyR)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_personalizationuser`|
|ReferencingAttribute|`msdynci_alternatekeyreference`|
|ReferencedEntityNavigationPropertyName|`msdynci_PersonalizationUser_AlternateKeyR`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynci_PersonalizationView_AlternateKeyR"></a> msdynci_PersonalizationView_AlternateKeyR

Many-To-One Relationship: [msdynci_personalizationview msdynci_PersonalizationView_AlternateKeyR](msdynci_personalizationview.md#BKMK_msdynci_PersonalizationView_AlternateKeyR)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_personalizationview`|
|ReferencingAttribute|`msdynci_alternatekeyreference`|
|ReferencedEntityNavigationPropertyName|`msdynci_PersonalizationView_AlternateKeyR`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

