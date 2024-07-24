---
title: "Event Purchase Attendee (msevtmgt_eventpurchaseattendee) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Event Purchase Attendee (msevtmgt_eventpurchaseattendee) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Event Purchase Attendee (msevtmgt_eventpurchaseattendee) table/entity reference



## Messages

The following table lists the messages for the Event Purchase Attendee (msevtmgt_eventpurchaseattendee) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_eventpurchaseattendees(*msevtmgt_eventpurchaseattendeeid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_eventpurchaseattendees<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_eventpurchaseattendees(*msevtmgt_eventpurchaseattendeeid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_eventpurchaseattendees(*msevtmgt_eventpurchaseattendeeid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_eventpurchaseattendees<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_eventpurchaseattendees(*msevtmgt_eventpurchaseattendeeid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_eventpurchaseattendees(*msevtmgt_eventpurchaseattendeeid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_eventpurchaseattendees(*msevtmgt_eventpurchaseattendeeid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Event Purchase Attendee (msevtmgt_eventpurchaseattendee) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Event Purchase Attendee (msevtmgt_eventpurchaseattendee) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Event Purchase Attendee** |
| **DisplayCollectionName** | **Event Purchase Attendees** |
| **SchemaName** | `msevtmgt_eventpurchaseattendee` |
| **CollectionSchemaName** | `msevtmgt_eventpurchaseattendees` |
| **EntitySetName** | `msevtmgt_eventpurchaseattendees`|
| **LogicalName** | `msevtmgt_eventpurchaseattendee` |
| **LogicalCollectionName** | `msevtmgt_eventpurchaseattendees` |
| **PrimaryIdAttribute** | `msevtmgt_eventpurchaseattendeeid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_AttendeeContactId](#BKMK_msevtmgt_AttendeeContactId)
- [msevtmgt_eventpurchaseattendeeId](#BKMK_msevtmgt_eventpurchaseattendeeId)
- [msevtmgt_eventpurchasecontactid](#BKMK_msevtmgt_eventpurchasecontactid)
- [msevtmgt_EventRegistrationId](#BKMK_msevtmgt_EventRegistrationId)
- [msevtmgt_name](#BKMK_msevtmgt_name)
- [msevtmgt_PurchaseId](#BKMK_msevtmgt_PurchaseId)
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

### <a name="BKMK_msevtmgt_AttendeeContactId"></a> msevtmgt_AttendeeContactId

|Property|Value|
|---|---|
|Description|**The contact that will attend the event**|
|DisplayName|**Attendee contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_attendeecontactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_eventpurchaseattendeeId"></a> msevtmgt_eventpurchaseattendeeId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Event purchase attendee**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventpurchaseattendeeid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_eventpurchasecontactid"></a> msevtmgt_eventpurchasecontactid

|Property|Value|
|---|---|
|Description|**Unique identifier for the event purchase contact associated with the event purchase attendee**|
|DisplayName|**Event purchase contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventpurchasecontactid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_eventpurchasecontact|

### <a name="BKMK_msevtmgt_EventRegistrationId"></a> msevtmgt_EventRegistrationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the event registration associated with the event purchase attendee.**|
|DisplayName|**Event registration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventregistrationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_eventregistration|

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

### <a name="BKMK_msevtmgt_PurchaseId"></a> msevtmgt_PurchaseId

|Property|Value|
|---|---|
|Description|**Unique identifier for the event purchase associated with the event purchase attendee**|
|DisplayName|**Purchase**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_purchaseid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_eventpurchase|

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
|Description|**Status of the event purchase attendee**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_eventpurchaseattendee_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the event purchase attendee**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_eventpurchaseattendee_statuscode`|

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

- [business_unit_msevtmgt_eventpurchaseattendee](#BKMK_business_unit_msevtmgt_eventpurchaseattendee)
- [lk_msevtmgt_eventpurchaseattendee_createdby](#BKMK_lk_msevtmgt_eventpurchaseattendee_createdby)
- [lk_msevtmgt_eventpurchaseattendee_createdonbehalfby](#BKMK_lk_msevtmgt_eventpurchaseattendee_createdonbehalfby)
- [lk_msevtmgt_eventpurchaseattendee_modifiedby](#BKMK_lk_msevtmgt_eventpurchaseattendee_modifiedby)
- [lk_msevtmgt_eventpurchaseattendee_modifiedonbehalfby](#BKMK_lk_msevtmgt_eventpurchaseattendee_modifiedonbehalfby)
- [msevtmgt_contact_msevtmgt_eventpurchaseattendee](#BKMK_msevtmgt_contact_msevtmgt_eventpurchaseattendee)
- [msevtmgt_eventpurchasecontact_eventpurchaseattendee](#BKMK_msevtmgt_eventpurchasecontact_eventpurchaseattendee)
- [msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee](#BKMK_msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee)
- [msevtmgt_msevtmgt_eventpurchase_msevtmgt_eventpurc](#BKMK_msevtmgt_msevtmgt_eventpurchase_msevtmgt_eventpurc)
- [owner_msevtmgt_eventpurchaseattendee](#BKMK_owner_msevtmgt_eventpurchaseattendee)
- [team_msevtmgt_eventpurchaseattendee](#BKMK_team_msevtmgt_eventpurchaseattendee)
- [user_msevtmgt_eventpurchaseattendee](#BKMK_user_msevtmgt_eventpurchaseattendee)

### <a name="BKMK_business_unit_msevtmgt_eventpurchaseattendee"></a> business_unit_msevtmgt_eventpurchaseattendee

One-To-Many Relationship: [businessunit business_unit_msevtmgt_eventpurchaseattendee](businessunit.md#BKMK_business_unit_msevtmgt_eventpurchaseattendee)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventpurchaseattendee_createdby"></a> lk_msevtmgt_eventpurchaseattendee_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventpurchaseattendee_createdby](systemuser.md#BKMK_lk_msevtmgt_eventpurchaseattendee_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventpurchaseattendee_createdonbehalfby"></a> lk_msevtmgt_eventpurchaseattendee_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventpurchaseattendee_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_eventpurchaseattendee_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventpurchaseattendee_modifiedby"></a> lk_msevtmgt_eventpurchaseattendee_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventpurchaseattendee_modifiedby](systemuser.md#BKMK_lk_msevtmgt_eventpurchaseattendee_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventpurchaseattendee_modifiedonbehalfby"></a> lk_msevtmgt_eventpurchaseattendee_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventpurchaseattendee_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_eventpurchaseattendee_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_eventpurchaseattendee"></a> msevtmgt_contact_msevtmgt_eventpurchaseattendee

One-To-Many Relationship: [contact msevtmgt_contact_msevtmgt_eventpurchaseattendee](contact.md#BKMK_msevtmgt_contact_msevtmgt_eventpurchaseattendee)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_attendeecontactid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_AttendeeContactId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_eventpurchasecontact_eventpurchaseattendee"></a> msevtmgt_eventpurchasecontact_eventpurchaseattendee

One-To-Many Relationship: [msevtmgt_eventpurchasecontact msevtmgt_eventpurchasecontact_eventpurchaseattendee](msevtmgt_eventpurchasecontact.md#BKMK_msevtmgt_eventpurchasecontact_eventpurchaseattendee)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchasecontact`|
|ReferencedAttribute|`msevtmgt_eventpurchasecontactid`|
|ReferencingAttribute|`msevtmgt_eventpurchasecontactid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_eventpurchasecontactid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee"></a> msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee

One-To-Many Relationship: [msevtmgt_eventregistration msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee](msevtmgt_eventregistration.md#BKMK_msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventregistration`|
|ReferencedAttribute|`msevtmgt_eventregistrationid`|
|ReferencingAttribute|`msevtmgt_eventregistrationid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_EventRegistrationId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msevtmgt_msevtmgt_eventpurchase_msevtmgt_eventpurc"></a> msevtmgt_msevtmgt_eventpurchase_msevtmgt_eventpurc

One-To-Many Relationship: [msevtmgt_eventpurchase msevtmgt_msevtmgt_eventpurchase_msevtmgt_eventpurc](msevtmgt_eventpurchase.md#BKMK_msevtmgt_msevtmgt_eventpurchase_msevtmgt_eventpurc)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventpurchase`|
|ReferencedAttribute|`msevtmgt_eventpurchaseid`|
|ReferencingAttribute|`msevtmgt_purchaseid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_PurchaseId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msevtmgt_eventpurchaseattendee"></a> owner_msevtmgt_eventpurchaseattendee

One-To-Many Relationship: [owner owner_msevtmgt_eventpurchaseattendee](owner.md#BKMK_owner_msevtmgt_eventpurchaseattendee)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_eventpurchaseattendee"></a> team_msevtmgt_eventpurchaseattendee

One-To-Many Relationship: [team team_msevtmgt_eventpurchaseattendee](team.md#BKMK_team_msevtmgt_eventpurchaseattendee)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_eventpurchaseattendee"></a> user_msevtmgt_eventpurchaseattendee

One-To-Many Relationship: [systemuser user_msevtmgt_eventpurchaseattendee](systemuser.md#BKMK_user_msevtmgt_eventpurchaseattendee)

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

- [msevtmgt_eventpurchaseattendee_ActivityPointers](#BKMK_msevtmgt_eventpurchaseattendee_ActivityPointers)
- [msevtmgt_eventpurchaseattendee_adx_alertsubscriptions](#BKMK_msevtmgt_eventpurchaseattendee_adx_alertsubscriptions)
- [msevtmgt_eventpurchaseattendee_adx_inviteredemptions](#BKMK_msevtmgt_eventpurchaseattendee_adx_inviteredemptions)
- [msevtmgt_eventpurchaseattendee_adx_portalcomments](#BKMK_msevtmgt_eventpurchaseattendee_adx_portalcomments)
- [msevtmgt_eventpurchaseattendee_Annotations](#BKMK_msevtmgt_eventpurchaseattendee_Annotations)
- [msevtmgt_eventpurchaseattendee_Appointments](#BKMK_msevtmgt_eventpurchaseattendee_Appointments)
- [msevtmgt_eventpurchaseattendee_AsyncOperations](#BKMK_msevtmgt_eventpurchaseattendee_AsyncOperations)
- [msevtmgt_eventpurchaseattendee_BulkDeleteFailures](#BKMK_msevtmgt_eventpurchaseattendee_BulkDeleteFailures)
- [msevtmgt_eventpurchaseattendee_chats](#BKMK_msevtmgt_eventpurchaseattendee_chats)
- [msevtmgt_eventpurchaseattendee_Emails](#BKMK_msevtmgt_eventpurchaseattendee_Emails)
- [msevtmgt_eventpurchaseattendee_Faxes](#BKMK_msevtmgt_eventpurchaseattendee_Faxes)
- [msevtmgt_eventpurchaseattendee_Letters](#BKMK_msevtmgt_eventpurchaseattendee_Letters)
- [msevtmgt_eventpurchaseattendee_li_inmails](#BKMK_msevtmgt_eventpurchaseattendee_li_inmails)
- [msevtmgt_eventpurchaseattendee_li_messages](#BKMK_msevtmgt_eventpurchaseattendee_li_messages)
- [msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds)
- [msevtmgt_eventpurchaseattendee_MailboxTrackingFolders](#BKMK_msevtmgt_eventpurchaseattendee_MailboxTrackingFolders)
- [msevtmgt_eventpurchaseattendee_msdyn_bookingalerts](#BKMK_msevtmgt_eventpurchaseattendee_msdyn_bookingalerts)
- [msevtmgt_eventpurchaseattendee_msdyn_copilottranscripts](#BKMK_msevtmgt_eventpurchaseattendee_msdyn_copilottranscripts)
- [msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems](#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems)
- [msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages](#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages)
- [msevtmgt_eventpurchaseattendee_msdyn_ocsessions](#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocsessions)
- [msevtmgt_eventpurchaseattendee_msdyn_ocvoicemails](#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocvoicemails)
- [msevtmgt_eventpurchaseattendee_msfp_alerts](#BKMK_msevtmgt_eventpurchaseattendee_msfp_alerts)
- [msevtmgt_eventpurchaseattendee_msfp_surveyinvites](#BKMK_msevtmgt_eventpurchaseattendee_msfp_surveyinvites)
- [msevtmgt_eventpurchaseattendee_msfp_surveyresponses](#BKMK_msevtmgt_eventpurchaseattendee_msfp_surveyresponses)
- [msevtmgt_eventpurchaseattendee_PhoneCalls](#BKMK_msevtmgt_eventpurchaseattendee_PhoneCalls)
- [msevtmgt_eventpurchaseattendee_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_eventpurchaseattendee_PrincipalObjectAttributeAccesses)
- [msevtmgt_eventpurchaseattendee_ProcessSession](#BKMK_msevtmgt_eventpurchaseattendee_ProcessSession)
- [msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters](#BKMK_msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters)
- [msevtmgt_eventpurchaseattendee_ServiceAppointments](#BKMK_msevtmgt_eventpurchaseattendee_ServiceAppointments)
- [msevtmgt_eventpurchaseattendee_SocialActivities](#BKMK_msevtmgt_eventpurchaseattendee_SocialActivities)
- [msevtmgt_eventpurchaseattendee_SyncErrors](#BKMK_msevtmgt_eventpurchaseattendee_SyncErrors)
- [msevtmgt_eventpurchaseattendee_Tasks](#BKMK_msevtmgt_eventpurchaseattendee_Tasks)
- [msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e](#BKMK_msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e)
- [msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_registrationresponse_eventpurchaseattendee](#BKMK_msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_registrationresponse_eventpurchaseattendee)

### <a name="BKMK_msevtmgt_eventpurchaseattendee_ActivityPointers"></a> msevtmgt_eventpurchaseattendee_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_eventpurchaseattendee_ActivityPointers](activitypointer.md#BKMK_msevtmgt_eventpurchaseattendee_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_adx_alertsubscriptions"></a> msevtmgt_eventpurchaseattendee_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_eventpurchaseattendee_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_eventpurchaseattendee_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_adx_inviteredemptions"></a> msevtmgt_eventpurchaseattendee_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_eventpurchaseattendee_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_eventpurchaseattendee_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_adx_portalcomments"></a> msevtmgt_eventpurchaseattendee_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_eventpurchaseattendee_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_eventpurchaseattendee_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_Annotations"></a> msevtmgt_eventpurchaseattendee_Annotations

Many-To-One Relationship: [annotation msevtmgt_eventpurchaseattendee_Annotations](annotation.md#BKMK_msevtmgt_eventpurchaseattendee_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_Appointments"></a> msevtmgt_eventpurchaseattendee_Appointments

Many-To-One Relationship: [appointment msevtmgt_eventpurchaseattendee_Appointments](appointment.md#BKMK_msevtmgt_eventpurchaseattendee_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_AsyncOperations"></a> msevtmgt_eventpurchaseattendee_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_eventpurchaseattendee_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_eventpurchaseattendee_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_BulkDeleteFailures"></a> msevtmgt_eventpurchaseattendee_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_eventpurchaseattendee_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_eventpurchaseattendee_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_chats"></a> msevtmgt_eventpurchaseattendee_chats

Many-To-One Relationship: [chat msevtmgt_eventpurchaseattendee_chats](chat.md#BKMK_msevtmgt_eventpurchaseattendee_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_Emails"></a> msevtmgt_eventpurchaseattendee_Emails

Many-To-One Relationship: [email msevtmgt_eventpurchaseattendee_Emails](email.md#BKMK_msevtmgt_eventpurchaseattendee_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_Faxes"></a> msevtmgt_eventpurchaseattendee_Faxes

Many-To-One Relationship: [fax msevtmgt_eventpurchaseattendee_Faxes](fax.md#BKMK_msevtmgt_eventpurchaseattendee_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_Letters"></a> msevtmgt_eventpurchaseattendee_Letters

Many-To-One Relationship: [letter msevtmgt_eventpurchaseattendee_Letters](letter.md#BKMK_msevtmgt_eventpurchaseattendee_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_li_inmails"></a> msevtmgt_eventpurchaseattendee_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_eventpurchaseattendee_li_inmails](li_inmail.md#BKMK_msevtmgt_eventpurchaseattendee_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_li_messages"></a> msevtmgt_eventpurchaseattendee_li_messages

Many-To-One Relationship: [li_message msevtmgt_eventpurchaseattendee_li_messages](li_message.md#BKMK_msevtmgt_eventpurchaseattendee_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds"></a> msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_MailboxTrackingFolders"></a> msevtmgt_eventpurchaseattendee_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_eventpurchaseattendee_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_eventpurchaseattendee_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_msdyn_bookingalerts"></a> msevtmgt_eventpurchaseattendee_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_eventpurchaseattendee_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_eventpurchaseattendee_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_msdyn_copilottranscripts"></a> msevtmgt_eventpurchaseattendee_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_eventpurchaseattendee_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_eventpurchaseattendee_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems"></a> msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages"></a> msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocsessions"></a> msevtmgt_eventpurchaseattendee_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_eventpurchaseattendee_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocvoicemails"></a> msevtmgt_eventpurchaseattendee_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_eventpurchaseattendee_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_eventpurchaseattendee_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_msfp_alerts"></a> msevtmgt_eventpurchaseattendee_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_eventpurchaseattendee_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_eventpurchaseattendee_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_msfp_surveyinvites"></a> msevtmgt_eventpurchaseattendee_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_eventpurchaseattendee_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_eventpurchaseattendee_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_msfp_surveyresponses"></a> msevtmgt_eventpurchaseattendee_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_eventpurchaseattendee_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_eventpurchaseattendee_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_PhoneCalls"></a> msevtmgt_eventpurchaseattendee_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_eventpurchaseattendee_PhoneCalls](phonecall.md#BKMK_msevtmgt_eventpurchaseattendee_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_PrincipalObjectAttributeAccesses"></a> msevtmgt_eventpurchaseattendee_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_eventpurchaseattendee_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_eventpurchaseattendee_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_ProcessSession"></a> msevtmgt_eventpurchaseattendee_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_eventpurchaseattendee_ProcessSession](processsession.md#BKMK_msevtmgt_eventpurchaseattendee_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters"></a> msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_ServiceAppointments"></a> msevtmgt_eventpurchaseattendee_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_eventpurchaseattendee_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_eventpurchaseattendee_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_SocialActivities"></a> msevtmgt_eventpurchaseattendee_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_eventpurchaseattendee_SocialActivities](socialactivity.md#BKMK_msevtmgt_eventpurchaseattendee_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_SyncErrors"></a> msevtmgt_eventpurchaseattendee_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_eventpurchaseattendee_SyncErrors](syncerror.md#BKMK_msevtmgt_eventpurchaseattendee_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventpurchaseattendee_Tasks"></a> msevtmgt_eventpurchaseattendee_Tasks

Many-To-One Relationship: [task msevtmgt_eventpurchaseattendee_Tasks](task.md#BKMK_msevtmgt_eventpurchaseattendee_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventpurchaseattendee_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e"></a> msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e

Many-To-One Relationship: [msevtmgt_eventpurchasepass msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e](msevtmgt_eventpurchasepass.md#BKMK_msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchasepass`|
|ReferencingAttribute|`msevtmgt_attendeeid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_e`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_registrationresponse_eventpurchaseattendee"></a> msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_registrationresponse_eventpurchaseattendee

Many-To-One Relationship: [msevtmgt_registrationresponse msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_registrationresponse_eventpurchaseattendee](msevtmgt_registrationresponse.md#BKMK_msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_registrationresponse_eventpurchaseattendee)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_registrationresponse`|
|ReferencingAttribute|`msevtmgt_eventpurchaseattendee`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_eventpurchaseattendee_msevtmgt_registrationresponse_eventpurchaseattendee`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

