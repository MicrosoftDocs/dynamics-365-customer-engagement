---
title: "Forum Post (Adx_communityforumpost) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Forum Post (Adx_communityforumpost) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Forum Post (Adx_communityforumpost) table/entity reference



## Messages

The following table lists the messages for the Forum Post (Adx_communityforumpost) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_communityforumposts(*adx_communityforumpostid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_communityforumposts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_communityforumposts(*adx_communityforumpostid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_communityforumposts(*adx_communityforumpostid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_communityforumposts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_communityforumposts(*adx_communityforumpostid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_communityforumposts(*adx_communityforumpostid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_communityforumposts(*adx_communityforumpostid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Forum Post (Adx_communityforumpost) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forum Post (Adx_communityforumpost) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forum Post** |
| **DisplayCollectionName** | **Forum Posts** |
| **SchemaName** | `Adx_communityforumpost` |
| **CollectionSchemaName** | `Adx_communityforumposts` |
| **EntitySetName** | `adx_communityforumposts`|
| **LogicalName** | `adx_communityforumpost` |
| **LogicalCollectionName** | `adx_communityforumposts` |
| **PrimaryIdAttribute** | `adx_communityforumpostid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_authorid](#BKMK_adx_authorid)
- [Adx_communityforumpostId](#BKMK_Adx_communityforumpostId)
- [Adx_Content](#BKMK_Adx_Content)
- [Adx_Date](#BKMK_Adx_Date)
- [adx_forumthreadid](#BKMK_adx_forumthreadid)
- [Adx_HelpfulVoteCount](#BKMK_Adx_HelpfulVoteCount)
- [Adx_IsAnswer](#BKMK_Adx_IsAnswer)
- [Adx_name](#BKMK_Adx_name)
- [adx_publishingstateid](#BKMK_adx_publishingstateid)
- [adx_regardingid](#BKMK_adx_regardingid)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_authorid"></a> adx_authorid

|Property|Value|
|---|---|
|Description|**Shows the contact associated with the forum post.**|
|DisplayName|**Author**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_authorid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_Adx_communityforumpostId"></a> Adx_communityforumpostId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Forum Post**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_communityforumpostid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_Adx_Content"></a> Adx_Content

|Property|Value|
|---|---|
|Description||
|DisplayName|**Content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_content`|
|RequiredLevel|Recommended|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|65536|

### <a name="BKMK_Adx_Date"></a> Adx_Date

|Property|Value|
|---|---|
|Description||
|DisplayName|**Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_date`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_adx_forumthreadid"></a> adx_forumthreadid

|Property|Value|
|---|---|
|Description|**Shows the Forum Thread associated with the forum post.**|
|DisplayName|**Forum Thread**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_forumthreadid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_communityforumthread|

### <a name="BKMK_Adx_HelpfulVoteCount"></a> Adx_HelpfulVoteCount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Helpful Vote Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_helpfulvotecount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_Adx_IsAnswer"></a> Adx_IsAnswer

|Property|Value|
|---|---|
|Description||
|DisplayName|**Answer?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_isanswer`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_communityforumpost_adx_isanswer`|
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

### <a name="BKMK_adx_publishingstateid"></a> adx_publishingstateid

|Property|Value|
|---|---|
|Description|**Shows the Publishing State associated with the forum post.**|
|DisplayName|**Publishing State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_publishingstateid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_publishingstate|

### <a name="BKMK_adx_regardingid"></a> adx_regardingid

|Property|Value|
|---|---|
|Description|**Shows the forum post associated with the forum post.**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_regardingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_communityforumpost|

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
|Description|**Status of the Forum Post**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_communityforumpost_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Select the forum post's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_communityforumpost_statuscode`|

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

- [adx_communityforumpost_communityforumpost](#BKMK_adx_communityforumpost_communityforumpost-many-to-one)
- [adx_communityforumthread_communityforumpost](#BKMK_adx_communityforumthread_communityforumpost)
- [adx_contact_communityforumpost](#BKMK_adx_contact_communityforumpost)
- [adx_publishingstate_communityforumpost](#BKMK_adx_publishingstate_communityforumpost)
- [business_unit_adx_communityforumpost](#BKMK_business_unit_adx_communityforumpost)
- [lk_adx_communityforumpost_createdby](#BKMK_lk_adx_communityforumpost_createdby)
- [lk_adx_communityforumpost_createdonbehalfby](#BKMK_lk_adx_communityforumpost_createdonbehalfby)
- [lk_adx_communityforumpost_modifiedby](#BKMK_lk_adx_communityforumpost_modifiedby)
- [lk_adx_communityforumpost_modifiedonbehalfby](#BKMK_lk_adx_communityforumpost_modifiedonbehalfby)
- [owner_adx_communityforumpost](#BKMK_owner_adx_communityforumpost)
- [team_adx_communityforumpost](#BKMK_team_adx_communityforumpost)
- [user_adx_communityforumpost](#BKMK_user_adx_communityforumpost)

### <a name="BKMK_adx_communityforumpost_communityforumpost-many-to-one"></a> adx_communityforumpost_communityforumpost

One-To-Many Relationship: [adx_communityforumpost adx_communityforumpost_communityforumpost](#BKMK_adx_communityforumpost_communityforumpost-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumpost`|
|ReferencedAttribute|`adx_communityforumpostid`|
|ReferencingAttribute|`adx_regardingid`|
|ReferencingEntityNavigationPropertyName|`adx_regardingid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_communityforumthread_communityforumpost"></a> adx_communityforumthread_communityforumpost

One-To-Many Relationship: [adx_communityforumthread adx_communityforumthread_communityforumpost](adx_communityforumthread.md#BKMK_adx_communityforumthread_communityforumpost)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_communityforumthread`|
|ReferencedAttribute|`adx_communityforumthreadid`|
|ReferencingAttribute|`adx_forumthreadid`|
|ReferencingEntityNavigationPropertyName|`adx_forumthreadid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_contact_communityforumpost"></a> adx_contact_communityforumpost

One-To-Many Relationship: [contact adx_contact_communityforumpost](contact.md#BKMK_adx_contact_communityforumpost)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`adx_authorid`|
|ReferencingEntityNavigationPropertyName|`adx_authorid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_publishingstate_communityforumpost"></a> adx_publishingstate_communityforumpost

One-To-Many Relationship: [adx_publishingstate adx_publishingstate_communityforumpost](adx_publishingstate.md#BKMK_adx_publishingstate_communityforumpost)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstate`|
|ReferencedAttribute|`adx_publishingstateid`|
|ReferencingAttribute|`adx_publishingstateid`|
|ReferencingEntityNavigationPropertyName|`adx_publishingstateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_business_unit_adx_communityforumpost"></a> business_unit_adx_communityforumpost

One-To-Many Relationship: [businessunit business_unit_adx_communityforumpost](businessunit.md#BKMK_business_unit_adx_communityforumpost)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforumpost_createdby"></a> lk_adx_communityforumpost_createdby

One-To-Many Relationship: [systemuser lk_adx_communityforumpost_createdby](systemuser.md#BKMK_lk_adx_communityforumpost_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforumpost_createdonbehalfby"></a> lk_adx_communityforumpost_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_communityforumpost_createdonbehalfby](systemuser.md#BKMK_lk_adx_communityforumpost_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforumpost_modifiedby"></a> lk_adx_communityforumpost_modifiedby

One-To-Many Relationship: [systemuser lk_adx_communityforumpost_modifiedby](systemuser.md#BKMK_lk_adx_communityforumpost_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_communityforumpost_modifiedonbehalfby"></a> lk_adx_communityforumpost_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_communityforumpost_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_communityforumpost_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_communityforumpost"></a> owner_adx_communityforumpost

One-To-Many Relationship: [owner owner_adx_communityforumpost](owner.md#BKMK_owner_adx_communityforumpost)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_communityforumpost"></a> team_adx_communityforumpost

One-To-Many Relationship: [team team_adx_communityforumpost](team.md#BKMK_team_adx_communityforumpost)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_communityforumpost"></a> user_adx_communityforumpost

One-To-Many Relationship: [systemuser user_adx_communityforumpost](systemuser.md#BKMK_user_adx_communityforumpost)

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

- [adx_communityforum_lastpost](#BKMK_adx_communityforum_lastpost)
- [adx_communityforumpost_Annotations](#BKMK_adx_communityforumpost_Annotations)
- [adx_communityforumpost_AsyncOperations](#BKMK_adx_communityforumpost_AsyncOperations)
- [adx_communityforumpost_BulkDeleteFailures](#BKMK_adx_communityforumpost_BulkDeleteFailures)
- [adx_communityforumpost_communityforumpost](#BKMK_adx_communityforumpost_communityforumpost-one-to-many)
- [adx_communityforumpost_communityforumthread](#BKMK_adx_communityforumpost_communityforumthread)
- [adx_communityforumpost_forumnotification](#BKMK_adx_communityforumpost_forumnotification)
- [adx_communityforumpost_MailboxTrackingFolders](#BKMK_adx_communityforumpost_MailboxTrackingFolders)
- [adx_communityforumpost_PrincipalObjectAttributeAccesses](#BKMK_adx_communityforumpost_PrincipalObjectAttributeAccesses)
- [adx_communityforumpost_ProcessSession](#BKMK_adx_communityforumpost_ProcessSession)
- [adx_communityforumpost_SyncErrors](#BKMK_adx_communityforumpost_SyncErrors)
- [adx_communityforumthrea_firstpost](#BKMK_adx_communityforumthrea_firstpost)

### <a name="BKMK_adx_communityforum_lastpost"></a> adx_communityforum_lastpost

Many-To-One Relationship: [adx_communityforum adx_communityforum_lastpost](adx_communityforum.md#BKMK_adx_communityforum_lastpost)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforum`|
|ReferencingAttribute|`adx_lastpostid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforum_lastpost`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumpost_Annotations"></a> adx_communityforumpost_Annotations

Many-To-One Relationship: [annotation adx_communityforumpost_Annotations](annotation.md#BKMK_adx_communityforumpost_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumpost_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumpost_AsyncOperations"></a> adx_communityforumpost_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_communityforumpost_AsyncOperations](asyncoperation.md#BKMK_adx_communityforumpost_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumpost_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumpost_BulkDeleteFailures"></a> adx_communityforumpost_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_communityforumpost_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_communityforumpost_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumpost_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumpost_communityforumpost-one-to-many"></a> adx_communityforumpost_communityforumpost

Many-To-One Relationship: [adx_communityforumpost adx_communityforumpost_communityforumpost](#BKMK_adx_communityforumpost_communityforumpost-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumpost`|
|ReferencingAttribute|`adx_regardingid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumpost_communityforumpost`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: Responses<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumpost_communityforumthread"></a> adx_communityforumpost_communityforumthread

Many-To-One Relationship: [adx_communityforumthread adx_communityforumpost_communityforumthread](adx_communityforumthread.md#BKMK_adx_communityforumpost_communityforumthread)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumthread`|
|ReferencingAttribute|`adx_lastpostid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumpost_communityforumthread`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumpost_forumnotification"></a> adx_communityforumpost_forumnotification

Many-To-One Relationship: [adx_forumnotification adx_communityforumpost_forumnotification](adx_forumnotification.md#BKMK_adx_communityforumpost_forumnotification)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_forumnotification`|
|ReferencingAttribute|`adx_forumpost`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumpost_forumnotification`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumpost_MailboxTrackingFolders"></a> adx_communityforumpost_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_communityforumpost_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_communityforumpost_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumpost_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumpost_PrincipalObjectAttributeAccesses"></a> adx_communityforumpost_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_communityforumpost_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_communityforumpost_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumpost_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumpost_ProcessSession"></a> adx_communityforumpost_ProcessSession

Many-To-One Relationship: [processsession adx_communityforumpost_ProcessSession](processsession.md#BKMK_adx_communityforumpost_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumpost_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumpost_SyncErrors"></a> adx_communityforumpost_SyncErrors

Many-To-One Relationship: [syncerror adx_communityforumpost_SyncErrors](syncerror.md#BKMK_adx_communityforumpost_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumpost_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_communityforumthrea_firstpost"></a> adx_communityforumthrea_firstpost

Many-To-One Relationship: [adx_communityforumthread adx_communityforumthrea_firstpost](adx_communityforumthread.md#BKMK_adx_communityforumthrea_firstpost)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumthread`|
|ReferencingAttribute|`adx_firstpostid`|
|ReferencedEntityNavigationPropertyName|`adx_communityforumthrea_firstpost`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

