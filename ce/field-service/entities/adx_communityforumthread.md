---
title: "Forum Thread (Adx_communityforumthread) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Forum Thread (Adx_communityforumthread) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Forum Thread (Adx_communityforumthread) table/entity reference



## Messages

The following table lists the messages for the Forum Thread (Adx_communityforumthread) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_communityforumthreads(*adx_communityforumthreadid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_communityforumthreads<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_communityforumthreads(*adx_communityforumthreadid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_communityforumthreads(*adx_communityforumthreadid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_communityforumthreads<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_communityforumthreads(*adx_communityforumthreadid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_communityforumthreads(*adx_communityforumthreadid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_communityforumthreads(*adx_communityforumthreadid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Forum Thread (Adx_communityforumthread) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forum Thread (Adx_communityforumthread) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forum Thread** |
| **DisplayCollectionName** | **Forum Threads** |
| **SchemaName** | `Adx_communityforumthread` |
| **CollectionSchemaName** | `Adx_communityforumthreads` |
| **EntitySetName** | `adx_communityforumthreads`|
| **LogicalName** | `adx_communityforumthread` |
| **LogicalCollectionName** | `adx_communityforumthreads` |
| **PrimaryIdAttribute** | `adx_communityforumthreadid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Adx_communityforumthreadId](#BKMK_Adx_communityforumthreadId)
- [adx_firstpostid](#BKMK_adx_firstpostid)
- [adx_forumid](#BKMK_adx_forumid)
- [Adx_IsAnswered](#BKMK_Adx_IsAnswered)
- [adx_lastpostdate](#BKMK_adx_lastpostdate)
- [adx_lastpostid](#BKMK_adx_lastpostid)
- [adx_Locked](#BKMK_adx_Locked)
- [Adx_name](#BKMK_Adx_name)
- [Adx_PostCount](#BKMK_Adx_PostCount)
- [adx_publishingstateid](#BKMK_adx_publishingstateid)
- [Adx_Sticky](#BKMK_Adx_Sticky)
- [adx_typeid](#BKMK_adx_typeid)
- [Adx_ViewCount](#BKMK_Adx_ViewCount)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_Adx_communityforumthreadId"></a> Adx_communityforumthreadId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Forum Thread**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_communityforumthreadid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_firstpostid"></a> adx_firstpostid

|Property|Value|
|---|---|
|Description|**Shows the forum post associated with the forum thread.**|
|DisplayName|**First Post**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_firstpostid`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|adx_communityforumpost|

### <a name="BKMK_adx_forumid"></a> adx_forumid

|Property|Value|
|---|---|
|Description|**Shows the forum associated with the forum thread.**|
|DisplayName|**Forum**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_forumid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_communityforum|

### <a name="BKMK_Adx_IsAnswered"></a> Adx_IsAnswered

|Property|Value|
|---|---|
|Description||
|DisplayName|**Answered?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_isanswered`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_communityforumthread_adx_isanswered`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_lastpostdate"></a> adx_lastpostdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Post Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_lastpostdate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_adx_lastpostid"></a> adx_lastpostid

|Property|Value|
|---|---|
|Description|**Shows the forum post associated with the forum thread.**|
|DisplayName|**Last Post**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_lastpostid`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|adx_communityforumpost|

### <a name="BKMK_adx_Locked"></a> adx_Locked

|Property|Value|
|---|---|
|Description||
|DisplayName|**Locked**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_locked`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_communityforumthread_adx_locked`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_Adx_PostCount"></a> Adx_PostCount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Post Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_postcount`|
|RequiredLevel|Recommended|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_publishingstateid"></a> adx_publishingstateid

|Property|Value|
|---|---|
|Description|**Shows the publishing state associated with the forum thread.**|
|DisplayName|**Publishing State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_publishingstateid`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|adx_publishingstate|

### <a name="BKMK_Adx_Sticky"></a> Adx_Sticky

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sticky?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_sticky`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_communityforumthread_adx_sticky`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_typeid"></a> adx_typeid

|Property|Value|
|---|---|
|Description|**Shows the forum Thread Type associated with the forum thread.**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_typeid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_forumthreadtype|

### <a name="BKMK_Adx_ViewCount"></a> Adx_ViewCount

|Property|Value|
|---|---|
|Description||
|DisplayName|**View Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_viewcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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
|Description|**Status of the Forum Thread**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_communityforumthread_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Select the forum thread's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_communityforumthread_statuscode`|

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

- [adx_communityforum_communityforumthread](#BKMK_adx_communityforum_communityforumthread)
- [adx_communityforumpost_communityforumthread](#BKMK_adx_communityforumpost_communityforumthread)
- [adx_communityforumthrea_firstpost](#BKMK_adx_communityforumthrea_firstpost)
- [adx_forumthreadtype_communityforumthread](#BKMK_adx_forumthreadtype_communityforumthread)
- [adx_publishingstate_communityforumthread](#BKMK_adx_publishingstate_communityforumthread)
- [business_unit_adx_communityforumthread](#BKMK_business_unit_adx_communityforumthread)
- [lk_adx_communityforumthread_createdby](#BKMK_lk_adx_communityforumthread_createdby)
- [lk_adx_communityforumthread_createdonbehalfby](#BKMK_lk_adx_communityforumthread_createdonbehalfby)
- [lk_adx_communityforumthread_modifiedby](#BKMK_lk_adx_communityforumthread_modifiedby)
- [lk_adx_communityforumthread_modifiedonbehalfby](#BKMK_lk_adx_communityforumthread_modifiedonbehalfby)
- [owner_adx_communityforumthread](#BKMK_owner_adx_communityforumthread)
- [team_adx_communityforumthread](#BKMK_team_adx_communityforumthread)
- [user_adx_communityforumthread](#BKMK_user_adx_communityforumthread)

### <a name="BKMK_adx_communityforum_communityforumthread"></a> adx_communityforum_communityforumthread

One-To-Many Relationship: [adx_communityforum adx_communityforum_communityforumthread](adx_communityforum.md#BKMK_adx_communityforum_communityforumthread)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforum`|
|ReferencedAttribute|`adx_communityforumid`|
|ReferencingAttribute|`adx_forumid`|
|ReferencingEntityNavigationPropertyName|`adx_forumid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_communityforumpost_communityforumthread"></a> adx_communityforumpost_communityforumthread

One-To-Many Relationship: [adx_communityforumpost adx_communityforumpost_communityforumthread](adx_communityforumpost.md#BKMK_adx_communityforumpost_communityforumthread)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumpost`|
|ReferencedAttribute|`adx_communityforumpostid`|
|ReferencingAttribute|`adx_lastpostid`|
|ReferencingEntityNavigationPropertyName|`adx_lastpostid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_communityforumthrea_firstpost"></a> adx_communityforumthrea_firstpost

One-To-Many Relationship: [adx_communityforumpost adx_communityforumthrea_firstpost](adx_communityforumpost.md#BKMK_adx_communityforumthrea_firstpost)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumpost`|
|ReferencedAttribute|`adx_communityforumpostid`|
|ReferencingAttribute|`adx_firstpostid`|
|ReferencingEntityNavigationPropertyName|`adx_firstpostid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_forumthreadtype_communityforumthread"></a> adx_forumthreadtype_communityforumthread

One-To-Many Relationship: [adx_forumthreadtype adx_forumthreadtype_communityforumthread](adx_forumthreadtype.md#BKMK_adx_forumthreadtype_communityforumthread)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_forumthreadtype`|
|ReferencedAttribute|`adx_forumthreadtypeid`|
|ReferencingAttribute|`adx_typeid`|
|ReferencingEntityNavigationPropertyName|`adx_typeid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_publishingstate_communityforumthread"></a> adx_publishingstate_communityforumthread

One-To-Many Relationship: [adx_publishingstate adx_publishingstate_communityforumthread](adx_publishingstate.md#BKMK_adx_publishingstate_communityforumthread)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstate`|
|ReferencedAttribute|`adx_publishingstateid`|
|ReferencingAttribute|`adx_publishingstateid`|
|ReferencingEntityNavigationPropertyName|`adx_publishingstateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_business_unit_adx_communityforumthread"></a> business_unit_adx_communityforumthread

One-To-Many Relationship: [businessunit business_unit_adx_communityforumthread](businessunit.md#BKMK_business_unit_adx_communityforumthread)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforumthread_createdby"></a> lk_adx_communityforumthread_createdby

One-To-Many Relationship: [systemuser lk_adx_communityforumthread_createdby](systemuser.md#BKMK_lk_adx_communityforumthread_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforumthread_createdonbehalfby"></a> lk_adx_communityforumthread_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_communityforumthread_createdonbehalfby](systemuser.md#BKMK_lk_adx_communityforumthread_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforumthread_modifiedby"></a> lk_adx_communityforumthread_modifiedby

One-To-Many Relationship: [systemuser lk_adx_communityforumthread_modifiedby](systemuser.md#BKMK_lk_adx_communityforumthread_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforumthread_modifiedonbehalfby"></a> lk_adx_communityforumthread_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_communityforumthread_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_communityforumthread_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_communityforumthread"></a> owner_adx_communityforumthread

One-To-Many Relationship: [owner owner_adx_communityforumthread](owner.md#BKMK_owner_adx_communityforumthread)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_communityforumthread"></a> team_adx_communityforumthread

One-To-Many Relationship: [team team_adx_communityforumthread](team.md#BKMK_team_adx_communityforumthread)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_communityforumthread"></a> user_adx_communityforumthread

One-To-Many Relationship: [systemuser user_adx_communityforumthread](systemuser.md#BKMK_user_adx_communityforumthread)

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

- [adx_communityforumthread_Annotations](#BKMK_adx_communityforumthread_Annotations)
- [adx_communityforumthread_AsyncOperations](#BKMK_adx_communityforumthread_AsyncOperations)
- [adx_communityforumthread_BulkDeleteFailures](#BKMK_adx_communityforumthread_BulkDeleteFailures)
- [adx_communityforumthread_communityforumaalert](#BKMK_adx_communityforumthread_communityforumaalert)
- [adx_communityforumthread_communityforumpost](#BKMK_adx_communityforumthread_communityforumpost)
- [adx_communityforumthread_DuplicateBaseRecord](#BKMK_adx_communityforumthread_DuplicateBaseRecord)
- [adx_communityforumthread_DuplicateMatchingRecord](#BKMK_adx_communityforumthread_DuplicateMatchingRecord)
- [adx_communityforumthread_forumnotification_fo](#BKMK_adx_communityforumthread_forumnotification_fo)
- [adx_communityforumthread_MailboxTrackingFolders](#BKMK_adx_communityforumthread_MailboxTrackingFolders)
- [adx_communityforumthread_PrincipalObjectAttributeAccesses](#BKMK_adx_communityforumthread_PrincipalObjectAttributeAccesses)
- [adx_communityforumthread_ProcessSession](#BKMK_adx_communityforumthread_ProcessSession)
- [adx_communityforumthread_SyncErrors](#BKMK_adx_communityforumthread_SyncErrors)

### <a name="BKMK_adx_communityforumthread_Annotations"></a> adx_communityforumthread_Annotations

Many-To-One Relationship: [annotation adx_communityforumthread_Annotations](annotation.md#BKMK_adx_communityforumthread_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthread_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthread_AsyncOperations"></a> adx_communityforumthread_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_communityforumthread_AsyncOperations](asyncoperation.md#BKMK_adx_communityforumthread_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthread_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthread_BulkDeleteFailures"></a> adx_communityforumthread_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_communityforumthread_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_communityforumthread_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthread_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthread_communityforumaalert"></a> adx_communityforumthread_communityforumaalert

Many-To-One Relationship: [adx_communityforumalert adx_communityforumthread_communityforumaalert](adx_communityforumalert.md#BKMK_adx_communityforumthread_communityforumaalert)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumalert`|
|ReferencingAttribute|`adx_threadid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthread_communityforumaalert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthread_communityforumpost"></a> adx_communityforumthread_communityforumpost

Many-To-One Relationship: [adx_communityforumpost adx_communityforumthread_communityforumpost](adx_communityforumpost.md#BKMK_adx_communityforumthread_communityforumpost)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumpost`|
|ReferencingAttribute|`adx_forumthreadid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthread_communityforumpost`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthread_DuplicateBaseRecord"></a> adx_communityforumthread_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord adx_communityforumthread_DuplicateBaseRecord](duplicaterecord.md#BKMK_adx_communityforumthread_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthread_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthread_DuplicateMatchingRecord"></a> adx_communityforumthread_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord adx_communityforumthread_DuplicateMatchingRecord](duplicaterecord.md#BKMK_adx_communityforumthread_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthread_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthread_forumnotification_fo"></a> adx_communityforumthread_forumnotification_fo

Many-To-One Relationship: [adx_forumnotification adx_communityforumthread_forumnotification_fo](adx_forumnotification.md#BKMK_adx_communityforumthread_forumnotification_fo)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_forumnotification`|
|ReferencingAttribute|`adx_forumthread`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthread_forumnotification_fo`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthread_MailboxTrackingFolders"></a> adx_communityforumthread_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_communityforumthread_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_communityforumthread_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthread_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthread_PrincipalObjectAttributeAccesses"></a> adx_communityforumthread_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_communityforumthread_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_communityforumthread_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthread_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthread_ProcessSession"></a> adx_communityforumthread_ProcessSession

Many-To-One Relationship: [processsession adx_communityforumthread_ProcessSession](processsession.md#BKMK_adx_communityforumthread_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthread_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthread_SyncErrors"></a> adx_communityforumthread_SyncErrors

Many-To-One Relationship: [syncerror adx_communityforumthread_SyncErrors](syncerror.md#BKMK_adx_communityforumthread_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthread_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [adx_communityforumthread_contact](#BKMK_adx_communityforumthread_contact)
- [adx_communityforumthread_tag](#BKMK_adx_communityforumthread_tag)

### <a name="BKMK_adx_communityforumthread_contact"></a> adx_communityforumthread_contact

See [contact adx_communityforumthread_contact Many-To-Many Relationship](contact.md#BKMK_adx_communityforumthread_contact)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_communityforumthread_contact`|
|IsCustomizable|True|
|SchemaName|`adx_communityforumthread_contact`|
|IntersectAttribute|`adx_communityforumthreadid`|
|NavigationPropertyName|`adx_communityforumthread_contact`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: Discussion Forum Subscriptions<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthread_tag"></a> adx_communityforumthread_tag

See [adx_tag adx_communityforumthread_tag Many-To-Many Relationship](adx_tag.md#BKMK_adx_communityforumthread_tag)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_communityforumthread_tag`|
|IsCustomizable|True|
|SchemaName|`adx_communityforumthread_tag`|
|IntersectAttribute|`adx_communityforumthreadid`|
|NavigationPropertyName|`adx_communityforumthread_tag`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

