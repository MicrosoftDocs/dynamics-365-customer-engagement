---
title: "Resource Pay Type (msdyn_resourcepaytype) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Resource Pay Type (msdyn_resourcepaytype) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Resource Pay Type (msdyn_resourcepaytype) table/entity reference

Pay Types of resources hourly rate to calculate the resource cost

## Messages

The following table lists the messages for the Resource Pay Type (msdyn_resourcepaytype) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_resourcepaytypes(*msdyn_resourcepaytypeid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_resourcepaytypes<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_resourcepaytypes(*msdyn_resourcepaytypeid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_resourcepaytypes(*msdyn_resourcepaytypeid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_resourcepaytypes<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_resourcepaytypes(*msdyn_resourcepaytypeid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_resourcepaytypes(*msdyn_resourcepaytypeid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_resourcepaytypes(*msdyn_resourcepaytypeid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Resource Pay Type (msdyn_resourcepaytype) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Resource Pay Type (msdyn_resourcepaytype) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Resource Pay Type** |
| **DisplayCollectionName** | **Resource Pay Types** |
| **SchemaName** | `msdyn_resourcepaytype` |
| **CollectionSchemaName** | `msdyn_resourcepaytypes` |
| **EntitySetName** | `msdyn_resourcepaytypes`|
| **LogicalName** | `msdyn_resourcepaytype` |
| **LogicalCollectionName** | `msdyn_resourcepaytypes` |
| **PrimaryIdAttribute** | `msdyn_resourcepaytypeid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_HourlyMarkup](#BKMK_msdyn_HourlyMarkup)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_resourcepaytypeId](#BKMK_msdyn_resourcepaytypeId)
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
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_HourlyMarkup"></a> msdyn_HourlyMarkup

|Property|Value|
|---|---|
|Description|**Enter the markup percentage on the resource hourly cost. Use a value greater than 100% to mark it up and a value less than 100% to mark it down.**|
|DisplayName|**Hourly Markup %**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hourlymarkup`|
|RequiredLevel|ApplicationRequired|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the resource pay type name.**|
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
|MaxLength|200|

### <a name="BKMK_msdyn_resourcepaytypeId"></a> msdyn_resourcepaytypeId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Resource Pay Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_resourcepaytypeid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time that the record was migrated.**|
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
|Description|**Status of the Resource Pay Type**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_resourcepaytype_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Resource Pay Type**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_resourcepaytype_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
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

- [business_unit_msdyn_resourcepaytype](#BKMK_business_unit_msdyn_resourcepaytype)
- [lk_msdyn_resourcepaytype_createdby](#BKMK_lk_msdyn_resourcepaytype_createdby)
- [lk_msdyn_resourcepaytype_createdonbehalfby](#BKMK_lk_msdyn_resourcepaytype_createdonbehalfby)
- [lk_msdyn_resourcepaytype_modifiedby](#BKMK_lk_msdyn_resourcepaytype_modifiedby)
- [lk_msdyn_resourcepaytype_modifiedonbehalfby](#BKMK_lk_msdyn_resourcepaytype_modifiedonbehalfby)
- [owner_msdyn_resourcepaytype](#BKMK_owner_msdyn_resourcepaytype)
- [team_msdyn_resourcepaytype](#BKMK_team_msdyn_resourcepaytype)
- [user_msdyn_resourcepaytype](#BKMK_user_msdyn_resourcepaytype)

### <a name="BKMK_business_unit_msdyn_resourcepaytype"></a> business_unit_msdyn_resourcepaytype

One-To-Many Relationship: [businessunit business_unit_msdyn_resourcepaytype](businessunit.md#BKMK_business_unit_msdyn_resourcepaytype)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_resourcepaytype_createdby"></a> lk_msdyn_resourcepaytype_createdby

One-To-Many Relationship: [systemuser lk_msdyn_resourcepaytype_createdby](systemuser.md#BKMK_lk_msdyn_resourcepaytype_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_resourcepaytype_createdonbehalfby"></a> lk_msdyn_resourcepaytype_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_resourcepaytype_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_resourcepaytype_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_resourcepaytype_modifiedby"></a> lk_msdyn_resourcepaytype_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_resourcepaytype_modifiedby](systemuser.md#BKMK_lk_msdyn_resourcepaytype_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_resourcepaytype_modifiedonbehalfby"></a> lk_msdyn_resourcepaytype_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_resourcepaytype_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_resourcepaytype_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_resourcepaytype"></a> owner_msdyn_resourcepaytype

One-To-Many Relationship: [owner owner_msdyn_resourcepaytype](owner.md#BKMK_owner_msdyn_resourcepaytype)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_resourcepaytype"></a> team_msdyn_resourcepaytype

One-To-Many Relationship: [team team_msdyn_resourcepaytype](team.md#BKMK_team_msdyn_resourcepaytype)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_resourcepaytype"></a> user_msdyn_resourcepaytype

One-To-Many Relationship: [systemuser user_msdyn_resourcepaytype](systemuser.md#BKMK_user_msdyn_resourcepaytype)

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

- [msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType)
- [msdyn_resourcepaytype_Annotations](#BKMK_msdyn_resourcepaytype_Annotations)
- [msdyn_resourcepaytype_AsyncOperations](#BKMK_msdyn_resourcepaytype_AsyncOperations)
- [msdyn_resourcepaytype_BulkDeleteFailures](#BKMK_msdyn_resourcepaytype_BulkDeleteFailures)
- [msdyn_resourcepaytype_MailboxTrackingFolders](#BKMK_msdyn_resourcepaytype_MailboxTrackingFolders)
- [msdyn_resourcepaytype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcepaytype_PrincipalObjectAttributeAccesses)
- [msdyn_resourcepaytype_ProcessSession](#BKMK_msdyn_resourcepaytype_ProcessSession)
- [msdyn_resourcepaytype_SyncErrors](#BKMK_msdyn_resourcepaytype_SyncErrors)

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType"></a> msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType

Many-To-One Relationship: [msdyn_bookingjournal msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType](msdyn_bookingjournal.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingjournal`|
|ReferencingAttribute|`msdyn_paytype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_resourcepaytype_msdyn_bookingjournal_PayType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType

Many-To-One Relationship: [msdyn_fieldservicesetting msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType](msdyn_fieldservicesetting.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`msdyn_breakpaytype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType

Many-To-One Relationship: [msdyn_fieldservicesetting msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType](msdyn_fieldservicesetting.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`msdyn_businessclosurepaytype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType

Many-To-One Relationship: [msdyn_fieldservicesetting msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType](msdyn_fieldservicesetting.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`msdyn_overtimepaytype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType

Many-To-One Relationship: [msdyn_fieldservicesetting msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType](msdyn_fieldservicesetting.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`msdyn_travelpaytype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType

Many-To-One Relationship: [msdyn_fieldservicesetting msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType](msdyn_fieldservicesetting.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`msdyn_workpaytype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_resourcepaytype_Annotations"></a> msdyn_resourcepaytype_Annotations

Many-To-One Relationship: [annotation msdyn_resourcepaytype_Annotations](annotation.md#BKMK_msdyn_resourcepaytype_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_resourcepaytype_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_resourcepaytype_AsyncOperations"></a> msdyn_resourcepaytype_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_resourcepaytype_AsyncOperations](asyncoperation.md#BKMK_msdyn_resourcepaytype_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_resourcepaytype_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_resourcepaytype_BulkDeleteFailures"></a> msdyn_resourcepaytype_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_resourcepaytype_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_resourcepaytype_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_resourcepaytype_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_resourcepaytype_MailboxTrackingFolders"></a> msdyn_resourcepaytype_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_resourcepaytype_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_resourcepaytype_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_resourcepaytype_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_resourcepaytype_PrincipalObjectAttributeAccesses"></a> msdyn_resourcepaytype_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_resourcepaytype_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_resourcepaytype_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_resourcepaytype_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_resourcepaytype_ProcessSession"></a> msdyn_resourcepaytype_ProcessSession

Many-To-One Relationship: [processsession msdyn_resourcepaytype_ProcessSession](processsession.md#BKMK_msdyn_resourcepaytype_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_resourcepaytype_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_resourcepaytype_SyncErrors"></a> msdyn_resourcepaytype_SyncErrors

Many-To-One Relationship: [syncerror msdyn_resourcepaytype_SyncErrors](syncerror.md#BKMK_msdyn_resourcepaytype_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_resourcepaytype_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

