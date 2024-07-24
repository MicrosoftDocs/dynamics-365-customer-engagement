---
title: "Event Team Member (msevtmgt_EventTeamMember) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Event Team Member (msevtmgt_EventTeamMember) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Event Team Member (msevtmgt_EventTeamMember) table/entity reference



## Messages

The following table lists the messages for the Event Team Member (msevtmgt_EventTeamMember) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_eventteammembers(*msevtmgt_eventteammemberid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_eventteammembers<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_eventteammembers(*msevtmgt_eventteammemberid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_eventteammembers(*msevtmgt_eventteammemberid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_eventteammembers<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_eventteammembers(*msevtmgt_eventteammemberid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_eventteammembers(*msevtmgt_eventteammemberid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_eventteammembers(*msevtmgt_eventteammemberid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Event Team Member (msevtmgt_EventTeamMember) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Event Team Member (msevtmgt_EventTeamMember) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Event Team Member** |
| **DisplayCollectionName** | **Event Team Members** |
| **SchemaName** | `msevtmgt_EventTeamMember` |
| **CollectionSchemaName** | `msevtmgt_EventTeamMembers` |
| **EntitySetName** | `msevtmgt_eventteammembers`|
| **LogicalName** | `msevtmgt_eventteammember` |
| **LogicalCollectionName** | `msevtmgt_eventteammembers` |
| **PrimaryIdAttribute** | `msevtmgt_eventteammemberid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_Company](#BKMK_msevtmgt_Company)
- [msevtmgt_Contact](#BKMK_msevtmgt_Contact)
- [msevtmgt_Description](#BKMK_msevtmgt_Description)
- [msevtmgt_Email](#BKMK_msevtmgt_Email)
- [msevtmgt_EventTeamMemberId](#BKMK_msevtmgt_EventTeamMemberId)
- [msevtmgt_MemberType](#BKMK_msevtmgt_MemberType)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_Phone](#BKMK_msevtmgt_Phone)
- [msevtmgt_Role](#BKMK_msevtmgt_Role)
- [msevtmgt_User](#BKMK_msevtmgt_User)
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
|Description|**The sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_Company"></a> msevtmgt_Company

|Property|Value|
|---|---|
|Description||
|DisplayName|**Company**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_company`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Contact"></a> msevtmgt_Contact

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_contact`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_Description"></a> msevtmgt_Description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_Email"></a> msevtmgt_Email

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_email`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_EventTeamMemberId"></a> msevtmgt_EventTeamMemberId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Event team member**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventteammemberid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_MemberType"></a> msevtmgt_MemberType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Member type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_membertype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_membertype`|

#### msevtmgt_MemberType Choices/Options

|Value|Label|
|---|---|
|100000000|**Internal team member**|
|100000001|**External team member**|

### <a name="BKMK_msevtmgt_Name"></a> msevtmgt_Name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Phone"></a> msevtmgt_Phone

|Property|Value|
|---|---|
|Description||
|DisplayName|**Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_phone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Role"></a> msevtmgt_Role

|Property|Value|
|---|---|
|Description||
|DisplayName|**Role**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_role`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_memberrole`|

#### msevtmgt_Role Choices/Options

|Value|Label|
|---|---|
|100000000|**Venue management**|
|100000001|**Session Management**|
|100000002|**Speaker management**|
|100000003|**Registration management**|
|100000004|**Security management**|
|100000005|**Accommodation management**|
|100000006|**Marketing/event promotion**|
|100000007|**Sponsorship management**|
|100000008|**Catering management**|
|100000009|**Equipment management**|

### <a name="BKMK_msevtmgt_User"></a> msevtmgt_User

|Property|Value|
|---|---|
|Description||
|DisplayName|**User**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_user`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was migrated**|
|DisplayName|**Record created on**|
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
|Description|**Owner ID**|
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
|Description|**Status of the event team member**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_eventteammember_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the event team member**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_eventteammember_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time zone rule version number**|
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
|Description|**The time zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time zone code**|
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
|Description|**Unique identifier of the user who created the record**|
|DisplayName|**Created by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was created**|
|DisplayName|**Created on**|
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
|Description|**Unique identifier of the delegate user who created the record**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record**|
|DisplayName|**Modified by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was modified**|
|DisplayName|**Modified on**|
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
|Description|**Unique identifier of the delegate user who modified the record**|
|DisplayName|**Modified by (delegate)**|
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
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record**|
|DisplayName|**Owning team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record**|
|DisplayName|**Owning user**|
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

- [business_unit_msevtmgt_eventteammember](#BKMK_business_unit_msevtmgt_eventteammember)
- [lk_msevtmgt_eventteammember_createdby](#BKMK_lk_msevtmgt_eventteammember_createdby)
- [lk_msevtmgt_eventteammember_createdonbehalfby](#BKMK_lk_msevtmgt_eventteammember_createdonbehalfby)
- [lk_msevtmgt_eventteammember_modifiedby](#BKMK_lk_msevtmgt_eventteammember_modifiedby)
- [lk_msevtmgt_eventteammember_modifiedonbehalfby](#BKMK_lk_msevtmgt_eventteammember_modifiedonbehalfby)
- [msevtmgt_contact_msevtmgt_eventteammember_Contact](#BKMK_msevtmgt_contact_msevtmgt_eventteammember_Contact)
- [msevtmgt_systemuser_msevtmgt_eventteammember_User](#BKMK_msevtmgt_systemuser_msevtmgt_eventteammember_User)
- [owner_msevtmgt_eventteammember](#BKMK_owner_msevtmgt_eventteammember)
- [team_msevtmgt_eventteammember](#BKMK_team_msevtmgt_eventteammember)
- [user_msevtmgt_eventteammember](#BKMK_user_msevtmgt_eventteammember)

### <a name="BKMK_business_unit_msevtmgt_eventteammember"></a> business_unit_msevtmgt_eventteammember

One-To-Many Relationship: [businessunit business_unit_msevtmgt_eventteammember](businessunit.md#BKMK_business_unit_msevtmgt_eventteammember)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventteammember_createdby"></a> lk_msevtmgt_eventteammember_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventteammember_createdby](systemuser.md#BKMK_lk_msevtmgt_eventteammember_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventteammember_createdonbehalfby"></a> lk_msevtmgt_eventteammember_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventteammember_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_eventteammember_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventteammember_modifiedby"></a> lk_msevtmgt_eventteammember_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventteammember_modifiedby](systemuser.md#BKMK_lk_msevtmgt_eventteammember_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventteammember_modifiedonbehalfby"></a> lk_msevtmgt_eventteammember_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventteammember_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_eventteammember_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_eventteammember_Contact"></a> msevtmgt_contact_msevtmgt_eventteammember_Contact

One-To-Many Relationship: [contact msevtmgt_contact_msevtmgt_eventteammember_Contact](contact.md#BKMK_msevtmgt_contact_msevtmgt_eventteammember_Contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_contact`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_Contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_systemuser_msevtmgt_eventteammember_User"></a> msevtmgt_systemuser_msevtmgt_eventteammember_User

One-To-Many Relationship: [systemuser msevtmgt_systemuser_msevtmgt_eventteammember_User](systemuser.md#BKMK_msevtmgt_systemuser_msevtmgt_eventteammember_User)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msevtmgt_user`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_User`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_eventteammember"></a> owner_msevtmgt_eventteammember

One-To-Many Relationship: [owner owner_msevtmgt_eventteammember](owner.md#BKMK_owner_msevtmgt_eventteammember)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_eventteammember"></a> team_msevtmgt_eventteammember

One-To-Many Relationship: [team team_msevtmgt_eventteammember](team.md#BKMK_team_msevtmgt_eventteammember)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_eventteammember"></a> user_msevtmgt_eventteammember

One-To-Many Relationship: [systemuser user_msevtmgt_eventteammember](systemuser.md#BKMK_user_msevtmgt_eventteammember)

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

- [msevtmgt_eventteammember_AsyncOperations](#BKMK_msevtmgt_eventteammember_AsyncOperations)
- [msevtmgt_eventteammember_BulkDeleteFailures](#BKMK_msevtmgt_eventteammember_BulkDeleteFailures)
- [msevtmgt_eventteammember_hotelroomreservation](#BKMK_msevtmgt_eventteammember_hotelroomreservation)
- [msevtmgt_eventteammember_MailboxTrackingFolders](#BKMK_msevtmgt_eventteammember_MailboxTrackingFolders)
- [msevtmgt_EventTeamMember_msevtmgt_Session_Producer](#BKMK_msevtmgt_EventTeamMember_msevtmgt_Session_Producer)
- [msevtmgt_eventteammember_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_eventteammember_PrincipalObjectAttributeAccesses)
- [msevtmgt_eventteammember_ProcessSession](#BKMK_msevtmgt_eventteammember_ProcessSession)
- [msevtmgt_eventteammember_SyncErrors](#BKMK_msevtmgt_eventteammember_SyncErrors)
- [msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer](#BKMK_msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer)

### <a name="BKMK_msevtmgt_eventteammember_AsyncOperations"></a> msevtmgt_eventteammember_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_eventteammember_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_eventteammember_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventteammember_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventteammember_BulkDeleteFailures"></a> msevtmgt_eventteammember_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_eventteammember_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_eventteammember_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventteammember_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventteammember_hotelroomreservation"></a> msevtmgt_eventteammember_hotelroomreservation

Many-To-One Relationship: [msevtmgt_hotelroomreservation msevtmgt_eventteammember_hotelroomreservation](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_eventteammember_hotelroomreservation)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotelroomreservation`|
|ReferencingAttribute|`msevtmgt_eventteammemberid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventteammember_hotelroomreservation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventteammember_MailboxTrackingFolders"></a> msevtmgt_eventteammember_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_eventteammember_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_eventteammember_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventteammember_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_EventTeamMember_msevtmgt_Session_Producer"></a> msevtmgt_EventTeamMember_msevtmgt_Session_Producer

Many-To-One Relationship: [msevtmgt_session msevtmgt_EventTeamMember_msevtmgt_Session_Producer](msevtmgt_session.md#BKMK_msevtmgt_EventTeamMember_msevtmgt_Session_Producer)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_session`|
|ReferencingAttribute|`msevtmgt_producer`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_EventTeamMember_msevtmgt_Session_Producer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventteammember_PrincipalObjectAttributeAccesses"></a> msevtmgt_eventteammember_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_eventteammember_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_eventteammember_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventteammember_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventteammember_ProcessSession"></a> msevtmgt_eventteammember_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_eventteammember_ProcessSession](processsession.md#BKMK_msevtmgt_eventteammember_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventteammember_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventteammember_SyncErrors"></a> msevtmgt_eventteammember_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_eventteammember_SyncErrors](syncerror.md#BKMK_msevtmgt_eventteammember_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventteammember_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer"></a> msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer

Many-To-One Relationship: [msevtmgt_event msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer](msevtmgt_event.md#BKMK_msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`msevtmgt_producer`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msevtmgt_msevtmgt_event_msevtmgt_eventteammember](#BKMK_msevtmgt_msevtmgt_event_msevtmgt_eventteammember)
- [msevtmgt_msevtmgt_session_msevtmgt_teammember](#BKMK_msevtmgt_msevtmgt_session_msevtmgt_teammember)

### <a name="BKMK_msevtmgt_msevtmgt_event_msevtmgt_eventteammember"></a> msevtmgt_msevtmgt_event_msevtmgt_eventteammember

See [msevtmgt_event msevtmgt_msevtmgt_event_msevtmgt_eventteammember Many-To-Many Relationship](msevtmgt_event.md#BKMK_msevtmgt_msevtmgt_event_msevtmgt_eventteammember)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_msevtmgt_event_msevtmgt_eventteammember`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_msevtmgt_event_msevtmgt_eventteammember`|
|IntersectAttribute|`msevtmgt_eventteammemberid`|
|NavigationPropertyName|`msevtmgt_msevtmgt_event_msevtmgt_eventteammember`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_session_msevtmgt_teammember"></a> msevtmgt_msevtmgt_session_msevtmgt_teammember

See [msevtmgt_session msevtmgt_msevtmgt_session_msevtmgt_teammember Many-To-Many Relationship](msevtmgt_session.md#BKMK_msevtmgt_msevtmgt_session_msevtmgt_teammember)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_msevtmgt_session_msevtmgt_teammember`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_msevtmgt_session_msevtmgt_teammember`|
|IntersectAttribute|`msevtmgt_eventteammemberid`|
|NavigationPropertyName|`msevtmgt_msevtmgt_session_msevtmgt_teammember`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

