---
title: "Content Access Level (adx_contentaccesslevel) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Content Access Level (adx_contentaccesslevel) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Content Access Level (adx_contentaccesslevel) table/entity reference



## Messages

The following table lists the messages for the Content Access Level (adx_contentaccesslevel) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_contentaccesslevels(*adx_contentaccesslevelid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_contentaccesslevels<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_contentaccesslevels(*adx_contentaccesslevelid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_contentaccesslevels(*adx_contentaccesslevelid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_contentaccesslevels<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_contentaccesslevels(*adx_contentaccesslevelid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_contentaccesslevels(*adx_contentaccesslevelid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_contentaccesslevels(*adx_contentaccesslevelid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Content Access Level (adx_contentaccesslevel) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Content Access Level (adx_contentaccesslevel) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Content Access Level** |
| **DisplayCollectionName** | **Content Access Levels** |
| **SchemaName** | `adx_contentaccesslevel` |
| **CollectionSchemaName** | `adx_contentaccesslevels` |
| **EntitySetName** | `adx_contentaccesslevels`|
| **LogicalName** | `adx_contentaccesslevel` |
| **LogicalCollectionName** | `adx_contentaccesslevels` |
| **PrimaryIdAttribute** | `adx_contentaccesslevelid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_contentaccesslevelId](#BKMK_adx_contentaccesslevelId)
- [adx_DefaultAccessLevel](#BKMK_adx_DefaultAccessLevel)
- [adx_Description](#BKMK_adx_Description)
- [adx_name](#BKMK_adx_name)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_contentaccesslevelId"></a> adx_contentaccesslevelId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Content Access Level**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_contentaccesslevelid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_DefaultAccessLevel"></a> adx_DefaultAccessLevel

|Property|Value|
|---|---|
|Description|**Shows the CAL is Default Access Level**|
|DisplayName|**Default Access Level**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_defaultaccesslevel`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_contentaccesslevel_adx_defaultaccesslevel`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_Description"></a> adx_Description

|Property|Value|
|---|---|
|Description|**A brief description about the CAL**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_adx_name"></a> adx_name

|Property|Value|
|---|---|
|Description|**Shows the name of the CAL**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the Content Access Level**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_contentaccesslevel_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Content Access Level**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_contentaccesslevel_statuscode`|

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

- [business_unit_adx_contentaccesslevel](#BKMK_business_unit_adx_contentaccesslevel)
- [lk_adx_contentaccesslevel_createdby](#BKMK_lk_adx_contentaccesslevel_createdby)
- [lk_adx_contentaccesslevel_createdonbehalfby](#BKMK_lk_adx_contentaccesslevel_createdonbehalfby)
- [lk_adx_contentaccesslevel_modifiedby](#BKMK_lk_adx_contentaccesslevel_modifiedby)
- [lk_adx_contentaccesslevel_modifiedonbehalfby](#BKMK_lk_adx_contentaccesslevel_modifiedonbehalfby)
- [owner_adx_contentaccesslevel](#BKMK_owner_adx_contentaccesslevel)
- [team_adx_contentaccesslevel](#BKMK_team_adx_contentaccesslevel)
- [user_adx_contentaccesslevel](#BKMK_user_adx_contentaccesslevel)

### <a name="BKMK_business_unit_adx_contentaccesslevel"></a> business_unit_adx_contentaccesslevel

One-To-Many Relationship: [businessunit business_unit_adx_contentaccesslevel](businessunit.md#BKMK_business_unit_adx_contentaccesslevel)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_contentaccesslevel_createdby"></a> lk_adx_contentaccesslevel_createdby

One-To-Many Relationship: [systemuser lk_adx_contentaccesslevel_createdby](systemuser.md#BKMK_lk_adx_contentaccesslevel_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_contentaccesslevel_createdonbehalfby"></a> lk_adx_contentaccesslevel_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_contentaccesslevel_createdonbehalfby](systemuser.md#BKMK_lk_adx_contentaccesslevel_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_contentaccesslevel_modifiedby"></a> lk_adx_contentaccesslevel_modifiedby

One-To-Many Relationship: [systemuser lk_adx_contentaccesslevel_modifiedby](systemuser.md#BKMK_lk_adx_contentaccesslevel_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_contentaccesslevel_modifiedonbehalfby"></a> lk_adx_contentaccesslevel_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_contentaccesslevel_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_contentaccesslevel_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_contentaccesslevel"></a> owner_adx_contentaccesslevel

One-To-Many Relationship: [owner owner_adx_contentaccesslevel](owner.md#BKMK_owner_adx_contentaccesslevel)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_contentaccesslevel"></a> team_adx_contentaccesslevel

One-To-Many Relationship: [team team_adx_contentaccesslevel](team.md#BKMK_team_adx_contentaccesslevel)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_contentaccesslevel"></a> user_adx_contentaccesslevel

One-To-Many Relationship: [systemuser user_adx_contentaccesslevel](systemuser.md#BKMK_user_adx_contentaccesslevel)

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

- [adx_contentaccesslevel_ActivityPointers](#BKMK_adx_contentaccesslevel_ActivityPointers)
- [adx_contentaccesslevel_adx_alertsubscriptions](#BKMK_adx_contentaccesslevel_adx_alertsubscriptions)
- [adx_contentaccesslevel_adx_inviteredemptions](#BKMK_adx_contentaccesslevel_adx_inviteredemptions)
- [adx_contentaccesslevel_adx_portalcomments](#BKMK_adx_contentaccesslevel_adx_portalcomments)
- [adx_contentaccesslevel_Annotations](#BKMK_adx_contentaccesslevel_Annotations)
- [adx_contentaccesslevel_Appointments](#BKMK_adx_contentaccesslevel_Appointments)
- [adx_contentaccesslevel_AsyncOperations](#BKMK_adx_contentaccesslevel_AsyncOperations)
- [adx_contentaccesslevel_BulkDeleteFailures](#BKMK_adx_contentaccesslevel_BulkDeleteFailures)
- [adx_contentaccesslevel_chats](#BKMK_adx_contentaccesslevel_chats)
- [adx_contentaccesslevel_connections1](#BKMK_adx_contentaccesslevel_connections1)
- [adx_contentaccesslevel_connections2](#BKMK_adx_contentaccesslevel_connections2)
- [adx_contentaccesslevel_DuplicateBaseRecord](#BKMK_adx_contentaccesslevel_DuplicateBaseRecord)
- [adx_contentaccesslevel_DuplicateMatchingRecord](#BKMK_adx_contentaccesslevel_DuplicateMatchingRecord)
- [adx_contentaccesslevel_Emails](#BKMK_adx_contentaccesslevel_Emails)
- [adx_contentaccesslevel_Faxes](#BKMK_adx_contentaccesslevel_Faxes)
- [adx_contentaccesslevel_Letters](#BKMK_adx_contentaccesslevel_Letters)
- [adx_contentaccesslevel_li_inmails](#BKMK_adx_contentaccesslevel_li_inmails)
- [adx_contentaccesslevel_li_messages](#BKMK_adx_contentaccesslevel_li_messages)
- [adx_contentaccesslevel_li_pointdrivepresentationvieweds](#BKMK_adx_contentaccesslevel_li_pointdrivepresentationvieweds)
- [adx_contentaccesslevel_MailboxTrackingFolders](#BKMK_adx_contentaccesslevel_MailboxTrackingFolders)
- [adx_contentaccesslevel_msdyn_bookingalerts](#BKMK_adx_contentaccesslevel_msdyn_bookingalerts)
- [adx_contentaccesslevel_msdyn_copilottranscripts](#BKMK_adx_contentaccesslevel_msdyn_copilottranscripts)
- [adx_contentaccesslevel_msdyn_ocliveworkitems](#BKMK_adx_contentaccesslevel_msdyn_ocliveworkitems)
- [adx_contentaccesslevel_msdyn_ocoutboundmessages](#BKMK_adx_contentaccesslevel_msdyn_ocoutboundmessages)
- [adx_contentaccesslevel_msdyn_ocsessions](#BKMK_adx_contentaccesslevel_msdyn_ocsessions)
- [adx_contentaccesslevel_msdyn_ocvoicemails](#BKMK_adx_contentaccesslevel_msdyn_ocvoicemails)
- [adx_contentaccesslevel_msfp_alerts](#BKMK_adx_contentaccesslevel_msfp_alerts)
- [adx_contentaccesslevel_msfp_surveyinvites](#BKMK_adx_contentaccesslevel_msfp_surveyinvites)
- [adx_contentaccesslevel_msfp_surveyresponses](#BKMK_adx_contentaccesslevel_msfp_surveyresponses)
- [adx_contentaccesslevel_PhoneCalls](#BKMK_adx_contentaccesslevel_PhoneCalls)
- [adx_contentaccesslevel_PrincipalObjectAttributeAccesses](#BKMK_adx_contentaccesslevel_PrincipalObjectAttributeAccesses)
- [adx_contentaccesslevel_ProcessSession](#BKMK_adx_contentaccesslevel_ProcessSession)
- [adx_contentaccesslevel_RecurringAppointmentMasters](#BKMK_adx_contentaccesslevel_RecurringAppointmentMasters)
- [adx_contentaccesslevel_ServiceAppointments](#BKMK_adx_contentaccesslevel_ServiceAppointments)
- [adx_contentaccesslevel_SocialActivities](#BKMK_adx_contentaccesslevel_SocialActivities)
- [adx_contentaccesslevel_SyncErrors](#BKMK_adx_contentaccesslevel_SyncErrors)
- [adx_contentaccesslevel_Tasks](#BKMK_adx_contentaccesslevel_Tasks)

### <a name="BKMK_adx_contentaccesslevel_ActivityPointers"></a> adx_contentaccesslevel_ActivityPointers

Many-To-One Relationship: [activitypointer adx_contentaccesslevel_ActivityPointers](activitypointer.md#BKMK_adx_contentaccesslevel_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_adx_alertsubscriptions"></a> adx_contentaccesslevel_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription adx_contentaccesslevel_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_adx_contentaccesslevel_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_adx_inviteredemptions"></a> adx_contentaccesslevel_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption adx_contentaccesslevel_adx_inviteredemptions](adx_inviteredemption.md#BKMK_adx_contentaccesslevel_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_adx_portalcomments"></a> adx_contentaccesslevel_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment adx_contentaccesslevel_adx_portalcomments](adx_portalcomment.md#BKMK_adx_contentaccesslevel_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_Annotations"></a> adx_contentaccesslevel_Annotations

Many-To-One Relationship: [annotation adx_contentaccesslevel_Annotations](annotation.md#BKMK_adx_contentaccesslevel_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_Appointments"></a> adx_contentaccesslevel_Appointments

Many-To-One Relationship: [appointment adx_contentaccesslevel_Appointments](appointment.md#BKMK_adx_contentaccesslevel_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_AsyncOperations"></a> adx_contentaccesslevel_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_contentaccesslevel_AsyncOperations](asyncoperation.md#BKMK_adx_contentaccesslevel_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_BulkDeleteFailures"></a> adx_contentaccesslevel_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_contentaccesslevel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_contentaccesslevel_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_chats"></a> adx_contentaccesslevel_chats

Many-To-One Relationship: [chat adx_contentaccesslevel_chats](chat.md#BKMK_adx_contentaccesslevel_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_connections1"></a> adx_contentaccesslevel_connections1

Many-To-One Relationship: [connection adx_contentaccesslevel_connections1](connection.md#BKMK_adx_contentaccesslevel_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_connections2"></a> adx_contentaccesslevel_connections2

Many-To-One Relationship: [connection adx_contentaccesslevel_connections2](connection.md#BKMK_adx_contentaccesslevel_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_DuplicateBaseRecord"></a> adx_contentaccesslevel_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord adx_contentaccesslevel_DuplicateBaseRecord](duplicaterecord.md#BKMK_adx_contentaccesslevel_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_DuplicateMatchingRecord"></a> adx_contentaccesslevel_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord adx_contentaccesslevel_DuplicateMatchingRecord](duplicaterecord.md#BKMK_adx_contentaccesslevel_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_Emails"></a> adx_contentaccesslevel_Emails

Many-To-One Relationship: [email adx_contentaccesslevel_Emails](email.md#BKMK_adx_contentaccesslevel_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_Faxes"></a> adx_contentaccesslevel_Faxes

Many-To-One Relationship: [fax adx_contentaccesslevel_Faxes](fax.md#BKMK_adx_contentaccesslevel_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_Letters"></a> adx_contentaccesslevel_Letters

Many-To-One Relationship: [letter adx_contentaccesslevel_Letters](letter.md#BKMK_adx_contentaccesslevel_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_li_inmails"></a> adx_contentaccesslevel_li_inmails

Many-To-One Relationship: [li_inmail adx_contentaccesslevel_li_inmails](li_inmail.md#BKMK_adx_contentaccesslevel_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_li_messages"></a> adx_contentaccesslevel_li_messages

Many-To-One Relationship: [li_message adx_contentaccesslevel_li_messages](li_message.md#BKMK_adx_contentaccesslevel_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_li_pointdrivepresentationvieweds"></a> adx_contentaccesslevel_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed adx_contentaccesslevel_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_adx_contentaccesslevel_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_MailboxTrackingFolders"></a> adx_contentaccesslevel_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_contentaccesslevel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_contentaccesslevel_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_msdyn_bookingalerts"></a> adx_contentaccesslevel_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert adx_contentaccesslevel_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_adx_contentaccesslevel_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_msdyn_copilottranscripts"></a> adx_contentaccesslevel_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript adx_contentaccesslevel_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_adx_contentaccesslevel_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_msdyn_ocliveworkitems"></a> adx_contentaccesslevel_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem adx_contentaccesslevel_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_adx_contentaccesslevel_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_msdyn_ocoutboundmessages"></a> adx_contentaccesslevel_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage adx_contentaccesslevel_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_adx_contentaccesslevel_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_msdyn_ocsessions"></a> adx_contentaccesslevel_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession adx_contentaccesslevel_msdyn_ocsessions](msdyn_ocsession.md#BKMK_adx_contentaccesslevel_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_msdyn_ocvoicemails"></a> adx_contentaccesslevel_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail adx_contentaccesslevel_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_adx_contentaccesslevel_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_msfp_alerts"></a> adx_contentaccesslevel_msfp_alerts

Many-To-One Relationship: [msfp_alert adx_contentaccesslevel_msfp_alerts](msfp_alert.md#BKMK_adx_contentaccesslevel_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_msfp_surveyinvites"></a> adx_contentaccesslevel_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite adx_contentaccesslevel_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_adx_contentaccesslevel_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_msfp_surveyresponses"></a> adx_contentaccesslevel_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse adx_contentaccesslevel_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_adx_contentaccesslevel_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_PhoneCalls"></a> adx_contentaccesslevel_PhoneCalls

Many-To-One Relationship: [phonecall adx_contentaccesslevel_PhoneCalls](phonecall.md#BKMK_adx_contentaccesslevel_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_PrincipalObjectAttributeAccesses"></a> adx_contentaccesslevel_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_contentaccesslevel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_contentaccesslevel_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_ProcessSession"></a> adx_contentaccesslevel_ProcessSession

Many-To-One Relationship: [processsession adx_contentaccesslevel_ProcessSession](processsession.md#BKMK_adx_contentaccesslevel_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_RecurringAppointmentMasters"></a> adx_contentaccesslevel_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster adx_contentaccesslevel_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_adx_contentaccesslevel_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_ServiceAppointments"></a> adx_contentaccesslevel_ServiceAppointments

Many-To-One Relationship: [serviceappointment adx_contentaccesslevel_ServiceAppointments](serviceappointment.md#BKMK_adx_contentaccesslevel_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_SocialActivities"></a> adx_contentaccesslevel_SocialActivities

Many-To-One Relationship: [socialactivity adx_contentaccesslevel_SocialActivities](socialactivity.md#BKMK_adx_contentaccesslevel_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_SyncErrors"></a> adx_contentaccesslevel_SyncErrors

Many-To-One Relationship: [syncerror adx_contentaccesslevel_SyncErrors](syncerror.md#BKMK_adx_contentaccesslevel_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contentaccesslevel_Tasks"></a> adx_contentaccesslevel_Tasks

Many-To-One Relationship: [task adx_contentaccesslevel_Tasks](task.md#BKMK_adx_contentaccesslevel_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_contentaccesslevel_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [adx_AccountContentAccessLevel](#BKMK_adx_AccountContentAccessLevel)
- [adx_ContactContentAccessLevel](#BKMK_adx_ContactContentAccessLevel)
- [adx_KnowledgeArticleContentAccessLevel](#BKMK_adx_KnowledgeArticleContentAccessLevel)
- [adx_WebRoleContentAccessLevel](#BKMK_adx_WebRoleContentAccessLevel)

### <a name="BKMK_adx_AccountContentAccessLevel"></a> adx_AccountContentAccessLevel

See [account adx_AccountContentAccessLevel Many-To-Many Relationship](account.md#BKMK_adx_AccountContentAccessLevel)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_accountcontentaccesslevel`|
|IsCustomizable|True|
|SchemaName|`adx_AccountContentAccessLevel`|
|IntersectAttribute|`adx_contentaccesslevelid`|
|NavigationPropertyName|`adx_AccountContentAccessLevel`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_ContactContentAccessLevel"></a> adx_ContactContentAccessLevel

See [contact adx_ContactContentAccessLevel Many-To-Many Relationship](contact.md#BKMK_adx_ContactContentAccessLevel)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_contactcontentaccesslevel`|
|IsCustomizable|True|
|SchemaName|`adx_ContactContentAccessLevel`|
|IntersectAttribute|`adx_contentaccesslevelid`|
|NavigationPropertyName|`adx_ContactContentAccessLevel`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_KnowledgeArticleContentAccessLevel"></a> adx_KnowledgeArticleContentAccessLevel

See [knowledgearticle adx_KnowledgeArticleContentAccessLevel Many-To-Many Relationship](knowledgearticle.md#BKMK_adx_KnowledgeArticleContentAccessLevel)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_knowledgearticlecontentaccesslevel`|
|IsCustomizable|True|
|SchemaName|`adx_KnowledgeArticleContentAccessLevel`|
|IntersectAttribute|`adx_contentaccesslevelid`|
|NavigationPropertyName|`adx_KnowledgeArticleContentAccessLevel`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_WebRoleContentAccessLevel"></a> adx_WebRoleContentAccessLevel

See [adx_webrole adx_WebRoleContentAccessLevel Many-To-Many Relationship](adx_webrole.md#BKMK_adx_WebRoleContentAccessLevel)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_webrolecontentaccesslevel`|
|IsCustomizable|True|
|SchemaName|`adx_WebRoleContentAccessLevel`|
|IntersectAttribute|`adx_contentaccesslevelid`|
|NavigationPropertyName|`adx_WebRoleContentAccessLevel`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

