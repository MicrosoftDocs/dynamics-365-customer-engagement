---
title: "Event Purchase Pass (msevtmgt_eventpurchasepass) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Event Purchase Pass (msevtmgt_eventpurchasepass) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Event Purchase Pass (msevtmgt_eventpurchasepass) table/entity reference

Passes included in the purchase

## Messages

The following table lists the messages for the Event Purchase Pass (msevtmgt_eventpurchasepass) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_eventpurchasepasses(*msevtmgt_eventpurchasepassid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_eventpurchasepasses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_eventpurchasepasses(*msevtmgt_eventpurchasepassid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_eventpurchasepasses(*msevtmgt_eventpurchasepassid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_eventpurchasepasses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_eventpurchasepasses(*msevtmgt_eventpurchasepassid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_eventpurchasepasses(*msevtmgt_eventpurchasepassid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_eventpurchasepasses(*msevtmgt_eventpurchasepassid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Event Purchase Pass (msevtmgt_eventpurchasepass) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Event Purchase Pass (msevtmgt_eventpurchasepass) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Event Purchase Pass** |
| **DisplayCollectionName** | **Event Purchase Passes** |
| **SchemaName** | `msevtmgt_eventpurchasepass` |
| **CollectionSchemaName** | `msevtmgt_eventpurchasepasses` |
| **EntitySetName** | `msevtmgt_eventpurchasepasses`|
| **LogicalName** | `msevtmgt_eventpurchasepass` |
| **LogicalCollectionName** | `msevtmgt_eventpurchasepasses` |
| **PrimaryIdAttribute** | `msevtmgt_eventpurchasepassid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_AttendeeId](#BKMK_msevtmgt_AttendeeId)
- [msevtmgt_AttendeePassId](#BKMK_msevtmgt_AttendeePassId)
- [msevtmgt_eventpurchasepassId](#BKMK_msevtmgt_eventpurchasepassId)
- [msevtmgt_name](#BKMK_msevtmgt_name)
- [msevtmgt_passid](#BKMK_msevtmgt_passid)
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

### <a name="BKMK_msevtmgt_AttendeeId"></a> msevtmgt_AttendeeId

|Property|Value|
|---|---|
|Description|**The attendee, passes are meant for**|
|DisplayName|**Attendee**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_attendeeid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_eventpurchaseattendee|

### <a name="BKMK_msevtmgt_AttendeePassId"></a> msevtmgt_AttendeePassId

|Property|Value|
|---|---|
|Description|**Unique identifier for the attendee pass associated with the event purchase pass**|
|DisplayName|**Attendee pass**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_attendeepassid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_attendeepass|

### <a name="BKMK_msevtmgt_eventpurchasepassId"></a> msevtmgt_eventpurchasepassId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Event purchase pass**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventpurchasepassid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_name"></a> msevtmgt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_passid"></a> msevtmgt_passid

|Property|Value|
|---|---|
|Description|**The purchased pass**|
|DisplayName|**Pass**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_passid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_pass|

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
|Description|**Status of the event purchase pass**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_eventpurchasepass_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the event purchase pass**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_eventpurchasepass_statuscode`|

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

- [business_unit_msevtmgt_eventpurchasepass](#BKMK_business_unit_msevtmgt_eventpurchasepass)
- [lk_msevtmgt_eventpurchasepass_createdby](#BKMK_lk_msevtmgt_eventpurchasepass_createdby)
- [lk_msevtmgt_eventpurchasepass_createdonbehalfby](#BKMK_lk_msevtmgt_eventpurchasepass_createdonbehalfby)
- [lk_msevtmgt_eventpurchasepass_modifiedby](#BKMK_lk_msevtmgt_eventpurchasepass_modifiedby)
- [lk_msevtmgt_eventpurchasepass_modifiedonbehalfby](#BKMK_lk_msevtmgt_eventpurchasepass_modifiedonbehalfby)
- [msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch](#BKMK_msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch)
- [msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e](#BKMK_msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e)
- [msevtmgt_pass_msevtmgt_eventpurchasepass_Pass](#BKMK_msevtmgt_pass_msevtmgt_eventpurchasepass_Pass)
- [owner_msevtmgt_eventpurchasepass](#BKMK_owner_msevtmgt_eventpurchasepass)
- [team_msevtmgt_eventpurchasepass](#BKMK_team_msevtmgt_eventpurchasepass)
- [user_msevtmgt_eventpurchasepass](#BKMK_user_msevtmgt_eventpurchasepass)

### <a name="BKMK_business_unit_msevtmgt_eventpurchasepass"></a> business_unit_msevtmgt_eventpurchasepass

One-To-Many Relationship: [businessunit business_unit_msevtmgt_eventpurchasepass](businessunit.md#BKMK_business_unit_msevtmgt_eventpurchasepass)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventpurchasepass_createdby"></a> lk_msevtmgt_eventpurchasepass_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventpurchasepass_createdby](systemuser.md#BKMK_lk_msevtmgt_eventpurchasepass_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventpurchasepass_createdonbehalfby"></a> lk_msevtmgt_eventpurchasepass_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventpurchasepass_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_eventpurchasepass_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventpurchasepass_modifiedby"></a> lk_msevtmgt_eventpurchasepass_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventpurchasepass_modifiedby](systemuser.md#BKMK_lk_msevtmgt_eventpurchasepass_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventpurchasepass_modifiedonbehalfby"></a> lk_msevtmgt_eventpurchasepass_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventpurchasepass_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_eventpurchasepass_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch"></a> msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch

One-To-Many Relationship: [msevtmgt_attendeepass msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch](msevtmgt_attendeepass.md#BKMK_msevtmgt_msevtmgt_attendeepass_msevtmgt_eventpurch)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_attendeepass`|
|ReferencedAttribute|`msevtmgt_attendeepassid`|
|ReferencingAttribute|`msevtmgt_attendeepassid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_AttendeePassId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e"></a> msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e

One-To-Many Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencedAttribute|`msevtmgt_eventpurchaseattendeeid`|
|ReferencingAttribute|`msevtmgt_attendeeid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_AttendeeId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_pass_msevtmgt_eventpurchasepass_Pass"></a> msevtmgt_pass_msevtmgt_eventpurchasepass_Pass

One-To-Many Relationship: [msevtmgt_pass msevtmgt_pass_msevtmgt_eventpurchasepass_Pass](msevtmgt_pass.md#BKMK_msevtmgt_pass_msevtmgt_eventpurchasepass_Pass)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_pass`|
|ReferencedAttribute|`msevtmgt_passid`|
|ReferencingAttribute|`msevtmgt_passid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_passid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_eventpurchasepass"></a> owner_msevtmgt_eventpurchasepass

One-To-Many Relationship: [owner owner_msevtmgt_eventpurchasepass](owner.md#BKMK_owner_msevtmgt_eventpurchasepass)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_eventpurchasepass"></a> team_msevtmgt_eventpurchasepass

One-To-Many Relationship: [team team_msevtmgt_eventpurchasepass](team.md#BKMK_team_msevtmgt_eventpurchasepass)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_eventpurchasepass"></a> user_msevtmgt_eventpurchasepass

One-To-Many Relationship: [systemuser user_msevtmgt_eventpurchasepass](systemuser.md#BKMK_user_msevtmgt_eventpurchasepass)

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

- [msevtmgt_eventpurchasepass_ActivityPointers](#BKMK_msevtmgt_eventpurchasepass_ActivityPointers)
- [msevtmgt_eventpurchasepass_adx_alertsubscriptions](#BKMK_msevtmgt_eventpurchasepass_adx_alertsubscriptions)
- [msevtmgt_eventpurchasepass_adx_inviteredemptions](#BKMK_msevtmgt_eventpurchasepass_adx_inviteredemptions)
- [msevtmgt_eventpurchasepass_adx_portalcomments](#BKMK_msevtmgt_eventpurchasepass_adx_portalcomments)
- [msevtmgt_eventpurchasepass_Annotations](#BKMK_msevtmgt_eventpurchasepass_Annotations)
- [msevtmgt_eventpurchasepass_Appointments](#BKMK_msevtmgt_eventpurchasepass_Appointments)
- [msevtmgt_eventpurchasepass_AsyncOperations](#BKMK_msevtmgt_eventpurchasepass_AsyncOperations)
- [msevtmgt_eventpurchasepass_BulkDeleteFailures](#BKMK_msevtmgt_eventpurchasepass_BulkDeleteFailures)
- [msevtmgt_eventpurchasepass_chats](#BKMK_msevtmgt_eventpurchasepass_chats)
- [msevtmgt_eventpurchasepass_Emails](#BKMK_msevtmgt_eventpurchasepass_Emails)
- [msevtmgt_eventpurchasepass_Faxes](#BKMK_msevtmgt_eventpurchasepass_Faxes)
- [msevtmgt_eventpurchasepass_Letters](#BKMK_msevtmgt_eventpurchasepass_Letters)
- [msevtmgt_eventpurchasepass_li_inmails](#BKMK_msevtmgt_eventpurchasepass_li_inmails)
- [msevtmgt_eventpurchasepass_li_messages](#BKMK_msevtmgt_eventpurchasepass_li_messages)
- [msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds)
- [msevtmgt_eventpurchasepass_MailboxTrackingFolders](#BKMK_msevtmgt_eventpurchasepass_MailboxTrackingFolders)
- [msevtmgt_eventpurchasepass_msdyn_bookingalerts](#BKMK_msevtmgt_eventpurchasepass_msdyn_bookingalerts)
- [msevtmgt_eventpurchasepass_msdyn_copilottranscripts](#BKMK_msevtmgt_eventpurchasepass_msdyn_copilottranscripts)
- [msevtmgt_eventpurchasepass_msdyn_ocliveworkitems](#BKMK_msevtmgt_eventpurchasepass_msdyn_ocliveworkitems)
- [msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages](#BKMK_msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages)
- [msevtmgt_eventpurchasepass_msdyn_ocsessions](#BKMK_msevtmgt_eventpurchasepass_msdyn_ocsessions)
- [msevtmgt_eventpurchasepass_msdyn_ocvoicemails](#BKMK_msevtmgt_eventpurchasepass_msdyn_ocvoicemails)
- [msevtmgt_eventpurchasepass_msfp_alerts](#BKMK_msevtmgt_eventpurchasepass_msfp_alerts)
- [msevtmgt_eventpurchasepass_msfp_surveyinvites](#BKMK_msevtmgt_eventpurchasepass_msfp_surveyinvites)
- [msevtmgt_eventpurchasepass_msfp_surveyresponses](#BKMK_msevtmgt_eventpurchasepass_msfp_surveyresponses)
- [msevtmgt_eventpurchasepass_PhoneCalls](#BKMK_msevtmgt_eventpurchasepass_PhoneCalls)
- [msevtmgt_eventpurchasepass_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_eventpurchasepass_PrincipalObjectAttributeAccesses)
- [msevtmgt_eventpurchasepass_ProcessSession](#BKMK_msevtmgt_eventpurchasepass_ProcessSession)
- [msevtmgt_eventpurchasepass_RecurringAppointmentMasters](#BKMK_msevtmgt_eventpurchasepass_RecurringAppointmentMasters)
- [msevtmgt_eventpurchasepass_ServiceAppointments](#BKMK_msevtmgt_eventpurchasepass_ServiceAppointments)
- [msevtmgt_eventpurchasepass_SocialActivities](#BKMK_msevtmgt_eventpurchasepass_SocialActivities)
- [msevtmgt_eventpurchasepass_SyncErrors](#BKMK_msevtmgt_eventpurchasepass_SyncErrors)
- [msevtmgt_eventpurchasepass_Tasks](#BKMK_msevtmgt_eventpurchasepass_Tasks)

### <a name="BKMK_msevtmgt_eventpurchasepass_ActivityPointers"></a> msevtmgt_eventpurchasepass_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_eventpurchasepass_ActivityPointers](activitypointer.md#BKMK_msevtmgt_eventpurchasepass_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_adx_alertsubscriptions"></a> msevtmgt_eventpurchasepass_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_eventpurchasepass_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_eventpurchasepass_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_adx_inviteredemptions"></a> msevtmgt_eventpurchasepass_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_eventpurchasepass_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_eventpurchasepass_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_adx_portalcomments"></a> msevtmgt_eventpurchasepass_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_eventpurchasepass_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_eventpurchasepass_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_Annotations"></a> msevtmgt_eventpurchasepass_Annotations

Many-To-One Relationship: [annotation msevtmgt_eventpurchasepass_Annotations](annotation.md#BKMK_msevtmgt_eventpurchasepass_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_Appointments"></a> msevtmgt_eventpurchasepass_Appointments

Many-To-One Relationship: [appointment msevtmgt_eventpurchasepass_Appointments](appointment.md#BKMK_msevtmgt_eventpurchasepass_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_AsyncOperations"></a> msevtmgt_eventpurchasepass_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_eventpurchasepass_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_eventpurchasepass_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_BulkDeleteFailures"></a> msevtmgt_eventpurchasepass_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_eventpurchasepass_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_eventpurchasepass_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_chats"></a> msevtmgt_eventpurchasepass_chats

Many-To-One Relationship: [chat msevtmgt_eventpurchasepass_chats](chat.md#BKMK_msevtmgt_eventpurchasepass_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_Emails"></a> msevtmgt_eventpurchasepass_Emails

Many-To-One Relationship: [email msevtmgt_eventpurchasepass_Emails](email.md#BKMK_msevtmgt_eventpurchasepass_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_Faxes"></a> msevtmgt_eventpurchasepass_Faxes

Many-To-One Relationship: [fax msevtmgt_eventpurchasepass_Faxes](fax.md#BKMK_msevtmgt_eventpurchasepass_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_Letters"></a> msevtmgt_eventpurchasepass_Letters

Many-To-One Relationship: [letter msevtmgt_eventpurchasepass_Letters](letter.md#BKMK_msevtmgt_eventpurchasepass_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_li_inmails"></a> msevtmgt_eventpurchasepass_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_eventpurchasepass_li_inmails](li_inmail.md#BKMK_msevtmgt_eventpurchasepass_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_li_messages"></a> msevtmgt_eventpurchasepass_li_messages

Many-To-One Relationship: [li_message msevtmgt_eventpurchasepass_li_messages](li_message.md#BKMK_msevtmgt_eventpurchasepass_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds"></a> msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_MailboxTrackingFolders"></a> msevtmgt_eventpurchasepass_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_eventpurchasepass_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_eventpurchasepass_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_msdyn_bookingalerts"></a> msevtmgt_eventpurchasepass_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_eventpurchasepass_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_eventpurchasepass_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_msdyn_copilottranscripts"></a> msevtmgt_eventpurchasepass_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_eventpurchasepass_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_eventpurchasepass_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_msdyn_ocliveworkitems"></a> msevtmgt_eventpurchasepass_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_eventpurchasepass_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_eventpurchasepass_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages"></a> msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_msdyn_ocsessions"></a> msevtmgt_eventpurchasepass_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_eventpurchasepass_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_eventpurchasepass_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_msdyn_ocvoicemails"></a> msevtmgt_eventpurchasepass_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_eventpurchasepass_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_eventpurchasepass_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_msfp_alerts"></a> msevtmgt_eventpurchasepass_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_eventpurchasepass_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_eventpurchasepass_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_msfp_surveyinvites"></a> msevtmgt_eventpurchasepass_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_eventpurchasepass_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_eventpurchasepass_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_msfp_surveyresponses"></a> msevtmgt_eventpurchasepass_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_eventpurchasepass_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_eventpurchasepass_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_PhoneCalls"></a> msevtmgt_eventpurchasepass_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_eventpurchasepass_PhoneCalls](phonecall.md#BKMK_msevtmgt_eventpurchasepass_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_PrincipalObjectAttributeAccesses"></a> msevtmgt_eventpurchasepass_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_eventpurchasepass_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_eventpurchasepass_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_ProcessSession"></a> msevtmgt_eventpurchasepass_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_eventpurchasepass_ProcessSession](processsession.md#BKMK_msevtmgt_eventpurchasepass_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_RecurringAppointmentMasters"></a> msevtmgt_eventpurchasepass_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_eventpurchasepass_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_eventpurchasepass_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_ServiceAppointments"></a> msevtmgt_eventpurchasepass_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_eventpurchasepass_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_eventpurchasepass_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_SocialActivities"></a> msevtmgt_eventpurchasepass_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_eventpurchasepass_SocialActivities](socialactivity.md#BKMK_msevtmgt_eventpurchasepass_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_SyncErrors"></a> msevtmgt_eventpurchasepass_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_eventpurchasepass_SyncErrors](syncerror.md#BKMK_msevtmgt_eventpurchasepass_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchasepass_Tasks"></a> msevtmgt_eventpurchasepass_Tasks

Many-To-One Relationship: [task msevtmgt_eventpurchasepass_Tasks](task.md#BKMK_msevtmgt_eventpurchasepass_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchasepass_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

