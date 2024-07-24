---
title: "Forum Access Permission (Adx_communityforumaccesspermission) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Forum Access Permission (Adx_communityforumaccesspermission) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Forum Access Permission (Adx_communityforumaccesspermission) table/entity reference



## Messages

The following table lists the messages for the Forum Access Permission (Adx_communityforumaccesspermission) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_communityforumaccesspermissions(*adx_communityforumaccesspermissionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_communityforumaccesspermissions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_communityforumaccesspermissions(*adx_communityforumaccesspermissionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_communityforumaccesspermissions(*adx_communityforumaccesspermissionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_communityforumaccesspermissions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_communityforumaccesspermissions(*adx_communityforumaccesspermissionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_communityforumaccesspermissions(*adx_communityforumaccesspermissionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_communityforumaccesspermissions(*adx_communityforumaccesspermissionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Forum Access Permission (Adx_communityforumaccesspermission) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forum Access Permission (Adx_communityforumaccesspermission) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forum Access Permission** |
| **DisplayCollectionName** | **Forum Access Permissions** |
| **SchemaName** | `Adx_communityforumaccesspermission` |
| **CollectionSchemaName** | `Adx_communityforumaccesspermissions` |
| **EntitySetName** | `adx_communityforumaccesspermissions`|
| **LogicalName** | `adx_communityforumaccesspermission` |
| **LogicalCollectionName** | `adx_communityforumaccesspermissions` |
| **PrimaryIdAttribute** | `adx_communityforumaccesspermissionid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Adx_communityforumaccesspermissionId](#BKMK_Adx_communityforumaccesspermissionId)
- [adx_forumid](#BKMK_adx_forumid)
- [Adx_name](#BKMK_Adx_name)
- [Adx_right](#BKMK_Adx_right)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_Adx_communityforumaccesspermissionId"></a> Adx_communityforumaccesspermissionId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Forum Access Permission**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_communityforumaccesspermissionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_forumid"></a> adx_forumid

|Property|Value|
|---|---|
|Description|**Shows the forum associated with the forum access permission.**|
|DisplayName|**Forum**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_forumid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_communityforum|

### <a name="BKMK_Adx_name"></a> Adx_name

|Property|Value|
|---|---|
|Description|**Shows the name of the custom entity.**|
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

### <a name="BKMK_Adx_right"></a> Adx_right

|Property|Value|
|---|---|
|Description||
|DisplayName|**Right**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_right`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_communityforumaccesspermission_adx_right`|

#### Adx_right Choices/Options

|Value|Label|
|---|---|
|1|**Grant Change**|
|2|**Restrict Read**|

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
|Description|**Status of the Forum Access Permission**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_communityforumaccesspermission_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Select the forum access permission's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_communityforumaccesspermission_statuscode`|

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
|DisplayName|**Shows Zone Code.**|
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
|Description|**Shows the date and time that the record was created.**|
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
|Description|**Shows the date and time that the record was last updated.**|
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
|Description|**Shows the Yomi name of the owner.**|
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
|Description|**Shows the business unit that owns the record.**|
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

- [adx_communityforum_forumaccesspermission](#BKMK_adx_communityforum_forumaccesspermission)
- [business_unit_adx_communityforumaccesspermission](#BKMK_business_unit_adx_communityforumaccesspermission)
- [lk_adx_communityforumaccesspermission_createdby](#BKMK_lk_adx_communityforumaccesspermission_createdby)
- [lk_adx_communityforumaccesspermission_createdonbehalfby](#BKMK_lk_adx_communityforumaccesspermission_createdonbehalfby)
- [lk_adx_communityforumaccesspermission_modifiedby](#BKMK_lk_adx_communityforumaccesspermission_modifiedby)
- [lk_adx_communityforumaccesspermission_modifiedonbehalfby](#BKMK_lk_adx_communityforumaccesspermission_modifiedonbehalfby)
- [owner_adx_communityforumaccesspermission](#BKMK_owner_adx_communityforumaccesspermission)
- [team_adx_communityforumaccesspermission](#BKMK_team_adx_communityforumaccesspermission)
- [user_adx_communityforumaccesspermission](#BKMK_user_adx_communityforumaccesspermission)

### <a name="BKMK_adx_communityforum_forumaccesspermission"></a> adx_communityforum_forumaccesspermission

One-To-Many Relationship: [adx_communityforum adx_communityforum_forumaccesspermission](adx_communityforum.md#BKMK_adx_communityforum_forumaccesspermission)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforum`|
|ReferencedAttribute|`adx_communityforumid`|
|ReferencingAttribute|`adx_forumid`|
|ReferencingEntityNavigationPropertyName|`adx_forumid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_business_unit_adx_communityforumaccesspermission"></a> business_unit_adx_communityforumaccesspermission

One-To-Many Relationship: [businessunit business_unit_adx_communityforumaccesspermission](businessunit.md#BKMK_business_unit_adx_communityforumaccesspermission)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforumaccesspermission_createdby"></a> lk_adx_communityforumaccesspermission_createdby

One-To-Many Relationship: [systemuser lk_adx_communityforumaccesspermission_createdby](systemuser.md#BKMK_lk_adx_communityforumaccesspermission_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforumaccesspermission_createdonbehalfby"></a> lk_adx_communityforumaccesspermission_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_communityforumaccesspermission_createdonbehalfby](systemuser.md#BKMK_lk_adx_communityforumaccesspermission_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforumaccesspermission_modifiedby"></a> lk_adx_communityforumaccesspermission_modifiedby

One-To-Many Relationship: [systemuser lk_adx_communityforumaccesspermission_modifiedby](systemuser.md#BKMK_lk_adx_communityforumaccesspermission_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforumaccesspermission_modifiedonbehalfby"></a> lk_adx_communityforumaccesspermission_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_communityforumaccesspermission_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_communityforumaccesspermission_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_communityforumaccesspermission"></a> owner_adx_communityforumaccesspermission

One-To-Many Relationship: [owner owner_adx_communityforumaccesspermission](owner.md#BKMK_owner_adx_communityforumaccesspermission)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_communityforumaccesspermission"></a> team_adx_communityforumaccesspermission

One-To-Many Relationship: [team team_adx_communityforumaccesspermission](team.md#BKMK_team_adx_communityforumaccesspermission)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_communityforumaccesspermission"></a> user_adx_communityforumaccesspermission

One-To-Many Relationship: [systemuser user_adx_communityforumaccesspermission](systemuser.md#BKMK_user_adx_communityforumaccesspermission)

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

- [adx_communityforumaccesspermission_ActivityPointers](#BKMK_adx_communityforumaccesspermission_ActivityPointers)
- [adx_communityforumaccesspermission_adx_alertsubscriptions](#BKMK_adx_communityforumaccesspermission_adx_alertsubscriptions)
- [adx_communityforumaccesspermission_adx_inviteredemptions](#BKMK_adx_communityforumaccesspermission_adx_inviteredemptions)
- [adx_communityforumaccesspermission_adx_portalcomments](#BKMK_adx_communityforumaccesspermission_adx_portalcomments)
- [adx_communityforumaccesspermission_Annotations](#BKMK_adx_communityforumaccesspermission_Annotations)
- [adx_communityforumaccesspermission_Appointments](#BKMK_adx_communityforumaccesspermission_Appointments)
- [adx_communityforumaccesspermission_AsyncOperations](#BKMK_adx_communityforumaccesspermission_AsyncOperations)
- [adx_communityforumaccesspermission_BulkDeleteFailures](#BKMK_adx_communityforumaccesspermission_BulkDeleteFailures)
- [adx_communityforumaccesspermission_chats](#BKMK_adx_communityforumaccesspermission_chats)
- [adx_communityforumaccesspermission_DuplicateBaseRecord](#BKMK_adx_communityforumaccesspermission_DuplicateBaseRecord)
- [adx_communityforumaccesspermission_DuplicateMatchingRecord](#BKMK_adx_communityforumaccesspermission_DuplicateMatchingRecord)
- [adx_communityforumaccesspermission_Emails](#BKMK_adx_communityforumaccesspermission_Emails)
- [adx_communityforumaccesspermission_Faxes](#BKMK_adx_communityforumaccesspermission_Faxes)
- [adx_communityforumaccesspermission_Letters](#BKMK_adx_communityforumaccesspermission_Letters)
- [adx_communityforumaccesspermission_li_inmails](#BKMK_adx_communityforumaccesspermission_li_inmails)
- [adx_communityforumaccesspermission_li_messages](#BKMK_adx_communityforumaccesspermission_li_messages)
- [adx_communityforumaccesspermission_li_pointdrivepresentationvieweds](#BKMK_adx_communityforumaccesspermission_li_pointdrivepresentationvieweds)
- [adx_communityforumaccesspermission_MailboxTrackingFolders](#BKMK_adx_communityforumaccesspermission_MailboxTrackingFolders)
- [adx_communityforumaccesspermission_msdyn_bookingalerts](#BKMK_adx_communityforumaccesspermission_msdyn_bookingalerts)
- [adx_communityforumaccesspermission_msdyn_copilottranscripts](#BKMK_adx_communityforumaccesspermission_msdyn_copilottranscripts)
- [adx_communityforumaccesspermission_msdyn_ocliveworkitems](#BKMK_adx_communityforumaccesspermission_msdyn_ocliveworkitems)
- [adx_communityforumaccesspermission_msdyn_ocoutboundmessages](#BKMK_adx_communityforumaccesspermission_msdyn_ocoutboundmessages)
- [adx_communityforumaccesspermission_msdyn_ocsessions](#BKMK_adx_communityforumaccesspermission_msdyn_ocsessions)
- [adx_communityforumaccesspermission_msdyn_ocvoicemails](#BKMK_adx_communityforumaccesspermission_msdyn_ocvoicemails)
- [adx_communityforumaccesspermission_msfp_alerts](#BKMK_adx_communityforumaccesspermission_msfp_alerts)
- [adx_communityforumaccesspermission_msfp_surveyinvites](#BKMK_adx_communityforumaccesspermission_msfp_surveyinvites)
- [adx_communityforumaccesspermission_msfp_surveyresponses](#BKMK_adx_communityforumaccesspermission_msfp_surveyresponses)
- [adx_communityforumaccesspermission_PhoneCalls](#BKMK_adx_communityforumaccesspermission_PhoneCalls)
- [adx_communityforumaccesspermission_PrincipalObjectAttributeAccesses](#BKMK_adx_communityforumaccesspermission_PrincipalObjectAttributeAccesses)
- [adx_communityforumaccesspermission_ProcessSession](#BKMK_adx_communityforumaccesspermission_ProcessSession)
- [adx_communityforumaccesspermission_RecurringAppointmentMasters](#BKMK_adx_communityforumaccesspermission_RecurringAppointmentMasters)
- [adx_communityforumaccesspermission_ServiceAppointments](#BKMK_adx_communityforumaccesspermission_ServiceAppointments)
- [adx_communityforumaccesspermission_SocialActivities](#BKMK_adx_communityforumaccesspermission_SocialActivities)
- [adx_communityforumaccesspermission_SyncErrors](#BKMK_adx_communityforumaccesspermission_SyncErrors)
- [adx_communityforumaccesspermission_Tasks](#BKMK_adx_communityforumaccesspermission_Tasks)

### <a name="BKMK_adx_communityforumaccesspermission_ActivityPointers"></a> adx_communityforumaccesspermission_ActivityPointers

Many-To-One Relationship: [activitypointer adx_communityforumaccesspermission_ActivityPointers](activitypointer.md#BKMK_adx_communityforumaccesspermission_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_adx_alertsubscriptions"></a> adx_communityforumaccesspermission_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription adx_communityforumaccesspermission_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_adx_communityforumaccesspermission_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_adx_inviteredemptions"></a> adx_communityforumaccesspermission_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption adx_communityforumaccesspermission_adx_inviteredemptions](adx_inviteredemption.md#BKMK_adx_communityforumaccesspermission_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_adx_portalcomments"></a> adx_communityforumaccesspermission_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment adx_communityforumaccesspermission_adx_portalcomments](adx_portalcomment.md#BKMK_adx_communityforumaccesspermission_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_Annotations"></a> adx_communityforumaccesspermission_Annotations

Many-To-One Relationship: [annotation adx_communityforumaccesspermission_Annotations](annotation.md#BKMK_adx_communityforumaccesspermission_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_Appointments"></a> adx_communityforumaccesspermission_Appointments

Many-To-One Relationship: [appointment adx_communityforumaccesspermission_Appointments](appointment.md#BKMK_adx_communityforumaccesspermission_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_AsyncOperations"></a> adx_communityforumaccesspermission_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_communityforumaccesspermission_AsyncOperations](asyncoperation.md#BKMK_adx_communityforumaccesspermission_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_BulkDeleteFailures"></a> adx_communityforumaccesspermission_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_communityforumaccesspermission_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_communityforumaccesspermission_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_chats"></a> adx_communityforumaccesspermission_chats

Many-To-One Relationship: [chat adx_communityforumaccesspermission_chats](chat.md#BKMK_adx_communityforumaccesspermission_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_DuplicateBaseRecord"></a> adx_communityforumaccesspermission_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord adx_communityforumaccesspermission_DuplicateBaseRecord](duplicaterecord.md#BKMK_adx_communityforumaccesspermission_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_DuplicateMatchingRecord"></a> adx_communityforumaccesspermission_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord adx_communityforumaccesspermission_DuplicateMatchingRecord](duplicaterecord.md#BKMK_adx_communityforumaccesspermission_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_Emails"></a> adx_communityforumaccesspermission_Emails

Many-To-One Relationship: [email adx_communityforumaccesspermission_Emails](email.md#BKMK_adx_communityforumaccesspermission_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_Faxes"></a> adx_communityforumaccesspermission_Faxes

Many-To-One Relationship: [fax adx_communityforumaccesspermission_Faxes](fax.md#BKMK_adx_communityforumaccesspermission_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_Letters"></a> adx_communityforumaccesspermission_Letters

Many-To-One Relationship: [letter adx_communityforumaccesspermission_Letters](letter.md#BKMK_adx_communityforumaccesspermission_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_li_inmails"></a> adx_communityforumaccesspermission_li_inmails

Many-To-One Relationship: [li_inmail adx_communityforumaccesspermission_li_inmails](li_inmail.md#BKMK_adx_communityforumaccesspermission_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_li_messages"></a> adx_communityforumaccesspermission_li_messages

Many-To-One Relationship: [li_message adx_communityforumaccesspermission_li_messages](li_message.md#BKMK_adx_communityforumaccesspermission_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_li_pointdrivepresentationvieweds"></a> adx_communityforumaccesspermission_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed adx_communityforumaccesspermission_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_adx_communityforumaccesspermission_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_MailboxTrackingFolders"></a> adx_communityforumaccesspermission_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_communityforumaccesspermission_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_communityforumaccesspermission_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_msdyn_bookingalerts"></a> adx_communityforumaccesspermission_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert adx_communityforumaccesspermission_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_adx_communityforumaccesspermission_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_msdyn_copilottranscripts"></a> adx_communityforumaccesspermission_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript adx_communityforumaccesspermission_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_adx_communityforumaccesspermission_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_msdyn_ocliveworkitems"></a> adx_communityforumaccesspermission_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem adx_communityforumaccesspermission_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_adx_communityforumaccesspermission_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_msdyn_ocoutboundmessages"></a> adx_communityforumaccesspermission_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage adx_communityforumaccesspermission_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_adx_communityforumaccesspermission_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_msdyn_ocsessions"></a> adx_communityforumaccesspermission_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession adx_communityforumaccesspermission_msdyn_ocsessions](msdyn_ocsession.md#BKMK_adx_communityforumaccesspermission_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_msdyn_ocvoicemails"></a> adx_communityforumaccesspermission_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail adx_communityforumaccesspermission_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_adx_communityforumaccesspermission_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_msfp_alerts"></a> adx_communityforumaccesspermission_msfp_alerts

Many-To-One Relationship: [msfp_alert adx_communityforumaccesspermission_msfp_alerts](msfp_alert.md#BKMK_adx_communityforumaccesspermission_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_msfp_surveyinvites"></a> adx_communityforumaccesspermission_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite adx_communityforumaccesspermission_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_adx_communityforumaccesspermission_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_msfp_surveyresponses"></a> adx_communityforumaccesspermission_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse adx_communityforumaccesspermission_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_adx_communityforumaccesspermission_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_PhoneCalls"></a> adx_communityforumaccesspermission_PhoneCalls

Many-To-One Relationship: [phonecall adx_communityforumaccesspermission_PhoneCalls](phonecall.md#BKMK_adx_communityforumaccesspermission_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_PrincipalObjectAttributeAccesses"></a> adx_communityforumaccesspermission_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_communityforumaccesspermission_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_communityforumaccesspermission_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_ProcessSession"></a> adx_communityforumaccesspermission_ProcessSession

Many-To-One Relationship: [processsession adx_communityforumaccesspermission_ProcessSession](processsession.md#BKMK_adx_communityforumaccesspermission_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_RecurringAppointmentMasters"></a> adx_communityforumaccesspermission_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster adx_communityforumaccesspermission_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_adx_communityforumaccesspermission_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_ServiceAppointments"></a> adx_communityforumaccesspermission_ServiceAppointments

Many-To-One Relationship: [serviceappointment adx_communityforumaccesspermission_ServiceAppointments](serviceappointment.md#BKMK_adx_communityforumaccesspermission_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_SocialActivities"></a> adx_communityforumaccesspermission_SocialActivities

Many-To-One Relationship: [socialactivity adx_communityforumaccesspermission_SocialActivities](socialactivity.md#BKMK_adx_communityforumaccesspermission_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_SyncErrors"></a> adx_communityforumaccesspermission_SyncErrors

Many-To-One Relationship: [syncerror adx_communityforumaccesspermission_SyncErrors](syncerror.md#BKMK_adx_communityforumaccesspermission_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumaccesspermission_Tasks"></a> adx_communityforumaccesspermission_Tasks

Many-To-One Relationship: [task adx_communityforumaccesspermission_Tasks](task.md#BKMK_adx_communityforumaccesspermission_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumaccesspermission_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_adx_communityforumaccesspermission_webrole"></a> adx_communityforumaccesspermission_webrole

See [adx_webrole adx_communityforumaccesspermission_webrole Many-To-Many Relationship](adx_webrole.md#BKMK_adx_communityforumaccesspermission_webrole)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_communityforumaccesspermission_webrole`|
|IsCustomizable|True|
|SchemaName|`adx_communityforumaccesspermission_webrole`|
|IntersectAttribute|`adx_communityforumaccesspermissionid`|
|NavigationPropertyName|`adx_communityforumaccesspermission_webrole`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100500<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

