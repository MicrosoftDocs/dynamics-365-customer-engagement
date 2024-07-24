---
title: "UnifiedActivity (msdynci_unifiedactivity) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the UnifiedActivity (msdynci_unifiedactivity) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# UnifiedActivity (msdynci_unifiedactivity) table/entity reference



## Messages

The following table lists the messages for the UnifiedActivity (msdynci_unifiedactivity) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynci_unifiedactivities(*msdynci_unifiedactivityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynci_unifiedactivities<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynci_unifiedactivities(*msdynci_unifiedactivityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdynci_unifiedactivities(*msdynci_unifiedactivityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynci_unifiedactivities<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `Update`<br />Event: True |`PATCH` /msdynci_unifiedactivities(*msdynci_unifiedactivityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdynci_unifiedactivities(*msdynci_unifiedactivityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the UnifiedActivity (msdynci_unifiedactivity) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the UnifiedActivity (msdynci_unifiedactivity) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **UnifiedActivity** |
| **DisplayCollectionName** | **UnifiedActivity** |
| **SchemaName** | `msdynci_unifiedactivity` |
| **CollectionSchemaName** | `msdynci_unifiedactivities` |
| **EntitySetName** | `msdynci_unifiedactivities`|
| **LogicalName** | `msdynci_unifiedactivity` |
| **LogicalCollectionName** | `msdynci_unifiedactivities` |
| **PrimaryIdAttribute** | `msdynci_unifiedactivityid` |
| **PrimaryNameAttribute** |`msdynci_activityid` |
| **TableType** | `Elastic` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynci_activityforeignkey](#BKMK_msdynci_activityforeignkey)
- [msdynci_activityid](#BKMK_msdynci_activityid)
- [msdynci_activityname](#BKMK_msdynci_activityname)
- [msdynci_activitytime](#BKMK_msdynci_activitytime)
- [msdynci_activitytype](#BKMK_msdynci_activitytype)
- [msdynci_activitytypedisplay](#BKMK_msdynci_activitytypedisplay)
- [msdynci_actualactivityid](#BKMK_msdynci_actualactivityid)
- [msdynci_customerid](#BKMK_msdynci_customerid)
- [msdynci_entityname](#BKMK_msdynci_entityname)
- [msdynci_externalurl](#BKMK_msdynci_externalurl)
- [msdynci_lookupfield_customer](#BKMK_msdynci_lookupfield_customer)
- [msdynci_lookupfield_customerPId](#BKMK_msdynci_lookupfield_customerPId)
- [msdynci_rangeindex](#BKMK_msdynci_rangeindex)
- [msdynci_semanticdata](#BKMK_msdynci_semanticdata)
- [msdynci_title](#BKMK_msdynci_title)
- [msdynci_unifiedactivityId](#BKMK_msdynci_unifiedactivityId)
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

### <a name="BKMK_msdynci_activityforeignkey"></a> msdynci_activityforeignkey

|Property|Value|
|---|---|
|Description|**ActivityForeignKey**|
|DisplayName|**ActivityForeignKey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_activityforeignkey`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_activityid"></a> msdynci_activityid

|Property|Value|
|---|---|
|Description|**ActivityId**|
|DisplayName|**ActivityId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_activityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_activityname"></a> msdynci_activityname

|Property|Value|
|---|---|
|Description|**ActivityName**|
|DisplayName|**ActivityName**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_activityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynci_activitytime"></a> msdynci_activitytime

|Property|Value|
|---|---|
|Description|**ActivityTime**|
|DisplayName|**ActivityTime**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_activitytime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdynci_activitytype"></a> msdynci_activitytype

|Property|Value|
|---|---|
|Description|**ActivityType**|
|DisplayName|**ActivityType**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_activitytype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynci_activitytypedisplay"></a> msdynci_activitytypedisplay

|Property|Value|
|---|---|
|Description|**ActivityTypeDisplay**|
|DisplayName|**ActivityTypeDisplay**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_activitytypedisplay`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynci_actualactivityid"></a> msdynci_actualactivityid

|Property|Value|
|---|---|
|Description|**ActualActivityId**|
|DisplayName|**ActualActivityId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_actualactivityid`|
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

### <a name="BKMK_msdynci_externalurl"></a> msdynci_externalurl

|Property|Value|
|---|---|
|Description|**ExternalUrl**|
|DisplayName|**ExternalUrl**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_externalurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

### <a name="BKMK_msdynci_rangeindex"></a> msdynci_rangeindex

|Property|Value|
|---|---|
|Description|**RangeIndex**|
|DisplayName|**RangeIndex**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_rangeindex`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynci_semanticdata"></a> msdynci_semanticdata

|Property|Value|
|---|---|
|Description|**SemanticData**|
|DisplayName|**SemanticData**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_semanticdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynci_title"></a> msdynci_title

|Property|Value|
|---|---|
|Description|**Title**|
|DisplayName|**Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_title`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynci_unifiedactivityId"></a> msdynci_unifiedactivityId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**UnifiedActivity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynci_unifiedactivityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

- [business_unit_msdynci_unifiedactivity](#BKMK_business_unit_msdynci_unifiedactivity)
- [lk_msdynci_unifiedactivity_createdby](#BKMK_lk_msdynci_unifiedactivity_createdby)
- [lk_msdynci_unifiedactivity_createdonbehalfby](#BKMK_lk_msdynci_unifiedactivity_createdonbehalfby)
- [lk_msdynci_unifiedactivity_modifiedby](#BKMK_lk_msdynci_unifiedactivity_modifiedby)
- [lk_msdynci_unifiedactivity_modifiedonbehalfby](#BKMK_lk_msdynci_unifiedactivity_modifiedonbehalfby)
- [msdynci_customer_unifiedactivity](#BKMK_msdynci_customer_unifiedactivity)
- [owner_msdynci_unifiedactivity](#BKMK_owner_msdynci_unifiedactivity)
- [team_msdynci_unifiedactivity](#BKMK_team_msdynci_unifiedactivity)
- [user_msdynci_unifiedactivity](#BKMK_user_msdynci_unifiedactivity)

### <a name="BKMK_business_unit_msdynci_unifiedactivity"></a> business_unit_msdynci_unifiedactivity

One-To-Many Relationship: [businessunit business_unit_msdynci_unifiedactivity](businessunit.md#BKMK_business_unit_msdynci_unifiedactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynci_unifiedactivity_createdby"></a> lk_msdynci_unifiedactivity_createdby

One-To-Many Relationship: [systemuser lk_msdynci_unifiedactivity_createdby](systemuser.md#BKMK_lk_msdynci_unifiedactivity_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynci_unifiedactivity_createdonbehalfby"></a> lk_msdynci_unifiedactivity_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynci_unifiedactivity_createdonbehalfby](systemuser.md#BKMK_lk_msdynci_unifiedactivity_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynci_unifiedactivity_modifiedby"></a> lk_msdynci_unifiedactivity_modifiedby

One-To-Many Relationship: [systemuser lk_msdynci_unifiedactivity_modifiedby](systemuser.md#BKMK_lk_msdynci_unifiedactivity_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynci_unifiedactivity_modifiedonbehalfby"></a> lk_msdynci_unifiedactivity_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynci_unifiedactivity_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynci_unifiedactivity_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynci_customer_unifiedactivity"></a> msdynci_customer_unifiedactivity

One-To-Many Relationship: [msdynci_customerprofile msdynci_customer_unifiedactivity](msdynci_customerprofile.md#BKMK_msdynci_customer_unifiedactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynci_customerprofile`|
|ReferencedAttribute|`msdynci_customerprofileid`|
|ReferencingAttribute|`msdynci_lookupfield_customer`|
|ReferencingEntityNavigationPropertyName|`msdynci_lookupfield_customer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynci_unifiedactivity"></a> owner_msdynci_unifiedactivity

One-To-Many Relationship: [owner owner_msdynci_unifiedactivity](owner.md#BKMK_owner_msdynci_unifiedactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynci_unifiedactivity"></a> team_msdynci_unifiedactivity

One-To-Many Relationship: [team team_msdynci_unifiedactivity](team.md#BKMK_team_msdynci_unifiedactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynci_unifiedactivity"></a> user_msdynci_unifiedactivity

One-To-Many Relationship: [systemuser user_msdynci_unifiedactivity](systemuser.md#BKMK_user_msdynci_unifiedactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

