---
title: "Entity Configuration (msdyn_entityconfiguration) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Entity Configuration (msdyn_entityconfiguration) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Entity Configuration (msdyn_entityconfiguration) table/entity reference

Enables records for an entity type to act as geofences or tracking points.

## Messages

The following table lists the messages for the Entity Configuration (msdyn_entityconfiguration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_entityconfigurations(*msdyn_entityconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_entityconfigurations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_entityconfigurations(*msdyn_entityconfigurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_entityconfigurations(*msdyn_entityconfigurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_entityconfigurations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_entityconfigurations(*msdyn_entityconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_entityconfigurations(*msdyn_entityconfigurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_entityconfigurations(*msdyn_entityconfigurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Entity Configuration (msdyn_entityconfiguration) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Entity Configuration (msdyn_entityconfiguration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Entity Configuration** |
| **DisplayCollectionName** | **Entity Configurations** |
| **SchemaName** | `msdyn_entityconfiguration` |
| **CollectionSchemaName** | `msdyn_entityconfigurations` |
| **EntitySetName** | `msdyn_entityconfigurations`|
| **LogicalName** | `msdyn_entityconfiguration` |
| **LogicalCollectionName** | `msdyn_entityconfigurations` |
| **PrimaryIdAttribute** | `msdyn_entityconfigurationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_CopyGeoDataFromURS](#BKMK_msdyn_CopyGeoDataFromURS)
- [msdyn_DateFilter1FieldName](#BKMK_msdyn_DateFilter1FieldName)
- [msdyn_DateFilter1LastXDay](#BKMK_msdyn_DateFilter1LastXDay)
- [msdyn_DateFilter1NextXDay](#BKMK_msdyn_DateFilter1NextXDay)
- [msdyn_DateFilter2FieldName](#BKMK_msdyn_DateFilter2FieldName)
- [msdyn_DateFilter2LastXDay](#BKMK_msdyn_DateFilter2LastXDay)
- [msdyn_DateFilter2NextXDay](#BKMK_msdyn_DateFilter2NextXDay)
- [msdyn_EnabledAs](#BKMK_msdyn_EnabledAs)
- [msdyn_EnableTriggerFilters](#BKMK_msdyn_EnableTriggerFilters)
- [msdyn_Entity](#BKMK_msdyn_Entity)
- [msdyn_entityconfigurationId](#BKMK_msdyn_entityconfigurationId)
- [msdyn_EntityPrimaryKey](#BKMK_msdyn_EntityPrimaryKey)
- [msdyn_LatitudeFieldName](#BKMK_msdyn_LatitudeFieldName)
- [msdyn_LongitudeFieldName](#BKMK_msdyn_LongitudeFieldName)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Radius](#BKMK_msdyn_Radius)
- [msdyn_RelationshipFieldName](#BKMK_msdyn_RelationshipFieldName)
- [msdyn_timestampfieldname](#BKMK_msdyn_timestampfieldname)
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

### <a name="BKMK_msdyn_CopyGeoDataFromURS"></a> msdyn_CopyGeoDataFromURS

|Property|Value|
|---|---|
|Description|**Copy newly introduced coordinates into bookable resource table.**|
|DisplayName|**Copy Geo Data From URS**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_copygeodatafromurs`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_entityconfiguration_msdyn_copygeodatafromurs`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DateFilter1FieldName"></a> msdyn_DateFilter1FieldName

|Property|Value|
|---|---|
|Description|**Schematic name of the first date field for the configured entity.**|
|DisplayName|**First Date Filter Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datefilter1fieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyn_DateFilter1LastXDay"></a> msdyn_DateFilter1LastXDay

|Property|Value|
|---|---|
|Description||
|DisplayName|**First Date Last Days Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datefilter1lastxday`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|365|
|MinValue|0|

### <a name="BKMK_msdyn_DateFilter1NextXDay"></a> msdyn_DateFilter1NextXDay

|Property|Value|
|---|---|
|Description||
|DisplayName|**First Date Next Days Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datefilter1nextxday`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|365|
|MinValue|0|

### <a name="BKMK_msdyn_DateFilter2FieldName"></a> msdyn_DateFilter2FieldName

|Property|Value|
|---|---|
|Description|**Schematic name of the second date field for the configured entity.**|
|DisplayName|**Second Date Filter Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datefilter2fieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyn_DateFilter2LastXDay"></a> msdyn_DateFilter2LastXDay

|Property|Value|
|---|---|
|Description||
|DisplayName|**Second Date Last Days Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datefilter2lastxday`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|365|
|MinValue|0|

### <a name="BKMK_msdyn_DateFilter2NextXDay"></a> msdyn_DateFilter2NextXDay

|Property|Value|
|---|---|
|Description||
|DisplayName|**Second Date Next Days Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datefilter2nextxday`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|365|
|MinValue|0|

### <a name="BKMK_msdyn_EnabledAs"></a> msdyn_EnabledAs

|Property|Value|
|---|---|
|Description|**Enables the entity's records to either represent geofences or be geotracked for entry and exit of geofences.**|
|DisplayName|**Enabled As**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enabledas`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_entityconfiguration_msdyn_enabledas`|

#### msdyn_EnabledAs Choices/Options

|Value|Label|
|---|---|
|192350000|**Geofence**|
|192350001|**Geotracked**|

### <a name="BKMK_msdyn_EnableTriggerFilters"></a> msdyn_EnableTriggerFilters

|Property|Value|
|---|---|
|Description|**Enable Trigger Filters**|
|DisplayName|**Enable Trigger Filters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enabletriggerfilters`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_entityconfiguration_msdyn_enabletriggerfilters`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Entity"></a> msdyn_Entity

|Property|Value|
|---|---|
|Description|**The entity that is configured as either a geofence or to be geotracked.**|
|DisplayName|**Entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entity`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyn_entityconfigurationId"></a> msdyn_entityconfigurationId

|Property|Value|
|---|---|
|Description|**Unique identifier of the entity configuration record.**|
|DisplayName|**Entity Configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_entityconfigurationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_EntityPrimaryKey"></a> msdyn_EntityPrimaryKey

|Property|Value|
|---|---|
|Description|**Name of the configured entity's primary key field.**|
|DisplayName|**Entity Primary Key Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityprimarykey`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_LatitudeFieldName"></a> msdyn_LatitudeFieldName

|Property|Value|
|---|---|
|Description|**Schematic name of the latitude field for the configured entity.**|
|DisplayName|**Latitude Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_latitudefieldname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyn_LongitudeFieldName"></a> msdyn_LongitudeFieldName

|Property|Value|
|---|---|
|Description|**Schematic name of the longitude field for the configured entity.**|
|DisplayName|**Longitude Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_longitudefieldname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the entity configuration record.**|
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

### <a name="BKMK_msdyn_Radius"></a> msdyn_Radius

|Property|Value|
|---|---|
|Description|**Default radius for Geofences created for the configured entity type.**|
|DisplayName|**Default Radius**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_radius`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|5|

### <a name="BKMK_msdyn_RelationshipFieldName"></a> msdyn_RelationshipFieldName

|Property|Value|
|---|---|
|Description|**Name of the relationship field for the configured entity.**|
|DisplayName|**Relationship Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relationshipfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_timestampfieldname"></a> msdyn_timestampfieldname

|Property|Value|
|---|---|
|Description|**Schematic name of the timestamp field for the configured entity.**|
|DisplayName|**Timestamp Field Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timestampfieldname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

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
|Description|**Status of the Entity Configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_entityconfiguration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Entity Configuration**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_entityconfiguration_statuscode`|

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

- [business_unit_msdyn_entityconfiguration](#BKMK_business_unit_msdyn_entityconfiguration)
- [lk_msdyn_entityconfiguration_createdby](#BKMK_lk_msdyn_entityconfiguration_createdby)
- [lk_msdyn_entityconfiguration_createdonbehalfby](#BKMK_lk_msdyn_entityconfiguration_createdonbehalfby)
- [lk_msdyn_entityconfiguration_modifiedby](#BKMK_lk_msdyn_entityconfiguration_modifiedby)
- [lk_msdyn_entityconfiguration_modifiedonbehalfby](#BKMK_lk_msdyn_entityconfiguration_modifiedonbehalfby)
- [owner_msdyn_entityconfiguration](#BKMK_owner_msdyn_entityconfiguration)
- [team_msdyn_entityconfiguration](#BKMK_team_msdyn_entityconfiguration)
- [user_msdyn_entityconfiguration](#BKMK_user_msdyn_entityconfiguration)

### <a name="BKMK_business_unit_msdyn_entityconfiguration"></a> business_unit_msdyn_entityconfiguration

One-To-Many Relationship: [businessunit business_unit_msdyn_entityconfiguration](businessunit.md#BKMK_business_unit_msdyn_entityconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_entityconfiguration_createdby"></a> lk_msdyn_entityconfiguration_createdby

One-To-Many Relationship: [systemuser lk_msdyn_entityconfiguration_createdby](systemuser.md#BKMK_lk_msdyn_entityconfiguration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_entityconfiguration_createdonbehalfby"></a> lk_msdyn_entityconfiguration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_entityconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_entityconfiguration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_entityconfiguration_modifiedby"></a> lk_msdyn_entityconfiguration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_entityconfiguration_modifiedby](systemuser.md#BKMK_lk_msdyn_entityconfiguration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_entityconfiguration_modifiedonbehalfby"></a> lk_msdyn_entityconfiguration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_entityconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_entityconfiguration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_entityconfiguration"></a> owner_msdyn_entityconfiguration

One-To-Many Relationship: [owner owner_msdyn_entityconfiguration](owner.md#BKMK_owner_msdyn_entityconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_entityconfiguration"></a> team_msdyn_entityconfiguration

One-To-Many Relationship: [team team_msdyn_entityconfiguration](team.md#BKMK_team_msdyn_entityconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_entityconfiguration"></a> user_msdyn_entityconfiguration

One-To-Many Relationship: [systemuser user_msdyn_entityconfiguration](systemuser.md#BKMK_user_msdyn_entityconfiguration)

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

- [msdyn_entityconfiguration_AsyncOperations](#BKMK_msdyn_entityconfiguration_AsyncOperations)
- [msdyn_entityconfiguration_BulkDeleteFailures](#BKMK_msdyn_entityconfiguration_BulkDeleteFailures)
- [msdyn_entityconfiguration_DuplicateBaseRecord](#BKMK_msdyn_entityconfiguration_DuplicateBaseRecord)
- [msdyn_entityconfiguration_DuplicateMatchingRecord](#BKMK_msdyn_entityconfiguration_DuplicateMatchingRecord)
- [msdyn_entityconfiguration_MailboxTrackingFolders](#BKMK_msdyn_entityconfiguration_MailboxTrackingFolders)
- [msdyn_entityconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_entityconfiguration_PrincipalObjectAttributeAccesses)
- [msdyn_entityconfiguration_ProcessSession](#BKMK_msdyn_entityconfiguration_ProcessSession)
- [msdyn_entityconfiguration_SyncErrors](#BKMK_msdyn_entityconfiguration_SyncErrors)

### <a name="BKMK_msdyn_entityconfiguration_AsyncOperations"></a> msdyn_entityconfiguration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_entityconfiguration_AsyncOperations](asyncoperation.md#BKMK_msdyn_entityconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_entityconfiguration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_entityconfiguration_BulkDeleteFailures"></a> msdyn_entityconfiguration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_entityconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_entityconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_entityconfiguration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_entityconfiguration_DuplicateBaseRecord"></a> msdyn_entityconfiguration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_entityconfiguration_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_entityconfiguration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_entityconfiguration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_entityconfiguration_DuplicateMatchingRecord"></a> msdyn_entityconfiguration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_entityconfiguration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_entityconfiguration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_entityconfiguration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_entityconfiguration_MailboxTrackingFolders"></a> msdyn_entityconfiguration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_entityconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_entityconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_entityconfiguration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_entityconfiguration_PrincipalObjectAttributeAccesses"></a> msdyn_entityconfiguration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_entityconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_entityconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_entityconfiguration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_entityconfiguration_ProcessSession"></a> msdyn_entityconfiguration_ProcessSession

Many-To-One Relationship: [processsession msdyn_entityconfiguration_ProcessSession](processsession.md#BKMK_msdyn_entityconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_entityconfiguration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_entityconfiguration_SyncErrors"></a> msdyn_entityconfiguration_SyncErrors

Many-To-One Relationship: [syncerror msdyn_entityconfiguration_SyncErrors](syncerror.md#BKMK_msdyn_entityconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_entityconfiguration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

