---
title: "Waitlist Item (msevtmgt_waitlistitem) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Waitlist Item (msevtmgt_waitlistitem) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Waitlist Item (msevtmgt_waitlistitem) table/entity reference



## Messages

The following table lists the messages for the Waitlist Item (msevtmgt_waitlistitem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_waitlistitems(*msevtmgt_waitlistitemid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_waitlistitems<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_waitlistitems(*msevtmgt_waitlistitemid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_waitlistitems(*msevtmgt_waitlistitemid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_waitlistitems<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_waitlistitems(*msevtmgt_waitlistitemid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_waitlistitems(*msevtmgt_waitlistitemid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_waitlistitems(*msevtmgt_waitlistitemid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Waitlist Item (msevtmgt_waitlistitem) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Waitlist Item (msevtmgt_waitlistitem) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Waitlist Item** |
| **DisplayCollectionName** | **Waitlist Items** |
| **SchemaName** | `msevtmgt_waitlistitem` |
| **CollectionSchemaName** | `msevtmgt_waitlistitems` |
| **EntitySetName** | `msevtmgt_waitlistitems`|
| **LogicalName** | `msevtmgt_waitlistitem` |
| **LogicalCollectionName** | `msevtmgt_waitlistitems` |
| **PrimaryIdAttribute** | `msevtmgt_waitlistitemid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_addedby](#BKMK_msevtmgt_addedby)
- [msevtmgt_autoregister](#BKMK_msevtmgt_autoregister)
- [msevtmgt_contact](#BKMK_msevtmgt_contact)
- [msevtmgt_event](#BKMK_msevtmgt_event)
- [msevtmgt_invited](#BKMK_msevtmgt_invited)
- [msevtmgt_name](#BKMK_msevtmgt_name)
- [msevtmgt_pregeneratedregistrationid](#BKMK_msevtmgt_pregeneratedregistrationid)
- [msevtmgt_reserved](#BKMK_msevtmgt_reserved)
- [msevtmgt_session](#BKMK_msevtmgt_session)
- [msevtmgt_waitlistitemId](#BKMK_msevtmgt_waitlistitemId)
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

### <a name="BKMK_msevtmgt_addedby"></a> msevtmgt_addedby

|Property|Value|
|---|---|
|Description|**A lookup to the contact who created this waitlist item**|
|DisplayName|**Added by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_addedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_autoregister"></a> msevtmgt_autoregister

|Property|Value|
|---|---|
|Description||
|DisplayName|**Automatically register**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_autoregister`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_waitlistitem_msevtmgt_autoregister`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_contact"></a> msevtmgt_contact

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_contact`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_event"></a> msevtmgt_event

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_event`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_event|

### <a name="BKMK_msevtmgt_invited"></a> msevtmgt_invited

|Property|Value|
|---|---|
|Description||
|DisplayName|**Invited**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_invited`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_waitlistitem_msevtmgt_invited`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_name"></a> msevtmgt_name

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

### <a name="BKMK_msevtmgt_pregeneratedregistrationid"></a> msevtmgt_pregeneratedregistrationid

|Property|Value|
|---|---|
|Description|**Pregenerated Registration Id**|
|DisplayName|**Pregenerated Registration Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_pregeneratedregistrationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_reserved"></a> msevtmgt_reserved

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reserved**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_reserved`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_waitlistitem_msevtmgt_reserved`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_session"></a> msevtmgt_session

|Property|Value|
|---|---|
|Description|**Unique identifier for the session associated with the waitlist item.**|
|DisplayName|**Session**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_session`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_session|

### <a name="BKMK_msevtmgt_waitlistitemId"></a> msevtmgt_waitlistitemId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Waitlist item**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_waitlistitemid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the waitlist item**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_waitlistitem_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the waitlist item**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_waitlistitem_statuscode`|

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

- [business_unit_msevtmgt_waitlistitem](#BKMK_business_unit_msevtmgt_waitlistitem)
- [lk_msevtmgt_waitlistitem_createdby](#BKMK_lk_msevtmgt_waitlistitem_createdby)
- [lk_msevtmgt_waitlistitem_createdonbehalfby](#BKMK_lk_msevtmgt_waitlistitem_createdonbehalfby)
- [lk_msevtmgt_waitlistitem_modifiedby](#BKMK_lk_msevtmgt_waitlistitem_modifiedby)
- [lk_msevtmgt_waitlistitem_modifiedonbehalfby](#BKMK_lk_msevtmgt_waitlistitem_modifiedonbehalfby)
- [msevtmgt_contact_waitlistitem](#BKMK_msevtmgt_contact_waitlistitem)
- [msevtmgt_contact_waitlistitem_addedby](#BKMK_msevtmgt_contact_waitlistitem_addedby)
- [msevtmgt_event_waitlistitem](#BKMK_msevtmgt_event_waitlistitem)
- [msevtmgt_session_waitlistitem](#BKMK_msevtmgt_session_waitlistitem)
- [owner_msevtmgt_waitlistitem](#BKMK_owner_msevtmgt_waitlistitem)
- [team_msevtmgt_waitlistitem](#BKMK_team_msevtmgt_waitlistitem)
- [user_msevtmgt_waitlistitem](#BKMK_user_msevtmgt_waitlistitem)

### <a name="BKMK_business_unit_msevtmgt_waitlistitem"></a> business_unit_msevtmgt_waitlistitem

One-To-Many Relationship: [businessunit business_unit_msevtmgt_waitlistitem](businessunit.md#BKMK_business_unit_msevtmgt_waitlistitem)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_waitlistitem_createdby"></a> lk_msevtmgt_waitlistitem_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_waitlistitem_createdby](systemuser.md#BKMK_lk_msevtmgt_waitlistitem_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_waitlistitem_createdonbehalfby"></a> lk_msevtmgt_waitlistitem_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_waitlistitem_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_waitlistitem_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_waitlistitem_modifiedby"></a> lk_msevtmgt_waitlistitem_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_waitlistitem_modifiedby](systemuser.md#BKMK_lk_msevtmgt_waitlistitem_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_waitlistitem_modifiedonbehalfby"></a> lk_msevtmgt_waitlistitem_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_waitlistitem_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_waitlistitem_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_waitlistitem"></a> msevtmgt_contact_waitlistitem

One-To-Many Relationship: [contact msevtmgt_contact_waitlistitem](contact.md#BKMK_msevtmgt_contact_waitlistitem)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_contact`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_waitlistitem_addedby"></a> msevtmgt_contact_waitlistitem_addedby

One-To-Many Relationship: [contact msevtmgt_contact_waitlistitem_addedby](contact.md#BKMK_msevtmgt_contact_waitlistitem_addedby)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_addedby`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_addedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_event_waitlistitem"></a> msevtmgt_event_waitlistitem

One-To-Many Relationship: [msevtmgt_event msevtmgt_event_waitlistitem](msevtmgt_event.md#BKMK_msevtmgt_event_waitlistitem)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_event`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_session_waitlistitem"></a> msevtmgt_session_waitlistitem

One-To-Many Relationship: [msevtmgt_session msevtmgt_session_waitlistitem](msevtmgt_session.md#BKMK_msevtmgt_session_waitlistitem)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_session`|
|ReferencedAttribute|`msevtmgt_sessionid`|
|ReferencingAttribute|`msevtmgt_session`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_session`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_waitlistitem"></a> owner_msevtmgt_waitlistitem

One-To-Many Relationship: [owner owner_msevtmgt_waitlistitem](owner.md#BKMK_owner_msevtmgt_waitlistitem)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_waitlistitem"></a> team_msevtmgt_waitlistitem

One-To-Many Relationship: [team team_msevtmgt_waitlistitem](team.md#BKMK_team_msevtmgt_waitlistitem)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_waitlistitem"></a> user_msevtmgt_waitlistitem

One-To-Many Relationship: [systemuser user_msevtmgt_waitlistitem](systemuser.md#BKMK_user_msevtmgt_waitlistitem)

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

- [msevtmgt_msevtmgt_waitlistitem_msevtmgt_registrationresponse_waitlistItem](#BKMK_msevtmgt_msevtmgt_waitlistitem_msevtmgt_registrationresponse_waitlistItem)
- [msevtmgt_waitlistitem_AsyncOperations](#BKMK_msevtmgt_waitlistitem_AsyncOperations)
- [msevtmgt_waitlistitem_BulkDeleteFailures](#BKMK_msevtmgt_waitlistitem_BulkDeleteFailures)
- [msevtmgt_waitlistitem_MailboxTrackingFolders](#BKMK_msevtmgt_waitlistitem_MailboxTrackingFolders)
- [msevtmgt_waitlistitem_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_waitlistitem_PrincipalObjectAttributeAccesses)
- [msevtmgt_waitlistitem_ProcessSession](#BKMK_msevtmgt_waitlistitem_ProcessSession)
- [msevtmgt_waitlistitem_SyncErrors](#BKMK_msevtmgt_waitlistitem_SyncErrors)

### <a name="BKMK_msevtmgt_msevtmgt_waitlistitem_msevtmgt_registrationresponse_waitlistItem"></a> msevtmgt_msevtmgt_waitlistitem_msevtmgt_registrationresponse_waitlistItem

Many-To-One Relationship: [msevtmgt_registrationresponse msevtmgt_msevtmgt_waitlistitem_msevtmgt_registrationresponse_waitlistItem](msevtmgt_registrationresponse.md#BKMK_msevtmgt_msevtmgt_waitlistitem_msevtmgt_registrationresponse_waitlistItem)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_registrationresponse`|
|ReferencingAttribute|`msevtmgt_waitlistitem`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_waitlistitem_msevtmgt_registrationresponse_waitlistItem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_waitlistitem_AsyncOperations"></a> msevtmgt_waitlistitem_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_waitlistitem_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_waitlistitem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_waitlistitem_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_waitlistitem_BulkDeleteFailures"></a> msevtmgt_waitlistitem_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_waitlistitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_waitlistitem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_waitlistitem_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_waitlistitem_MailboxTrackingFolders"></a> msevtmgt_waitlistitem_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_waitlistitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_waitlistitem_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_waitlistitem_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_waitlistitem_PrincipalObjectAttributeAccesses"></a> msevtmgt_waitlistitem_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_waitlistitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_waitlistitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_waitlistitem_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_waitlistitem_ProcessSession"></a> msevtmgt_waitlistitem_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_waitlistitem_ProcessSession](processsession.md#BKMK_msevtmgt_waitlistitem_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_waitlistitem_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_waitlistitem_SyncErrors"></a> msevtmgt_waitlistitem_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_waitlistitem_SyncErrors](syncerror.md#BKMK_msevtmgt_waitlistitem_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_waitlistitem_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

