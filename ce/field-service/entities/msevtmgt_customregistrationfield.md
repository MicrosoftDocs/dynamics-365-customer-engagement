---
title: "Custom Registration Field (msevtmgt_customregistrationfield) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Custom Registration Field (msevtmgt_customregistrationfield) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Custom Registration Field (msevtmgt_customregistrationfield) table/entity reference



## Messages

The following table lists the messages for the Custom Registration Field (msevtmgt_customregistrationfield) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_customregistrationfields(*msevtmgt_customregistrationfieldid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_customregistrationfields<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_customregistrationfields(*msevtmgt_customregistrationfieldid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_customregistrationfields(*msevtmgt_customregistrationfieldid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_customregistrationfields<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_customregistrationfields(*msevtmgt_customregistrationfieldid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_customregistrationfields(*msevtmgt_customregistrationfieldid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_customregistrationfields(*msevtmgt_customregistrationfieldid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Custom Registration Field (msevtmgt_customregistrationfield) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Custom Registration Field (msevtmgt_customregistrationfield) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Custom Registration Field** |
| **DisplayCollectionName** | **Custom Registration Fields** |
| **SchemaName** | `msevtmgt_customregistrationfield` |
| **CollectionSchemaName** | `msevtmgt_customregistrationfields` |
| **EntitySetName** | `msevtmgt_customregistrationfields`|
| **LogicalName** | `msevtmgt_customregistrationfield` |
| **LogicalCollectionName** | `msevtmgt_customregistrationfields` |
| **PrimaryIdAttribute** | `msevtmgt_customregistrationfieldid` |
| **PrimaryNameAttribute** |`msevtmgt_text` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_choices](#BKMK_msevtmgt_choices)
- [msevtmgt_customregistrationfieldId](#BKMK_msevtmgt_customregistrationfieldId)
- [msevtmgt_isrequired](#BKMK_msevtmgt_isrequired)
- [msevtmgt_text](#BKMK_msevtmgt_text)
- [msevtmgt_type](#BKMK_msevtmgt_type)
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

### <a name="BKMK_msevtmgt_choices"></a> msevtmgt_choices

|Property|Value|
|---|---|
|Description|**Choices provided for multiple-choice registration fields. Each line represents one choice.**|
|DisplayName|**Choices**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_choices`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msevtmgt_customregistrationfieldId"></a> msevtmgt_customregistrationfieldId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Custom registration field**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_customregistrationfieldid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_isrequired"></a> msevtmgt_isrequired

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_isrequired`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_customregistrationfield_msevtmgt_isrequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_text"></a> msevtmgt_text

|Property|Value|
|---|---|
|Description|**Text for the custom registration field displayed in the registration form.**|
|DisplayName|**Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_text`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|450|

### <a name="BKMK_msevtmgt_type"></a> msevtmgt_type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msevtmgt_customregistrationfieldtype`|

#### msevtmgt_type Choices/Options

|Value|Label|
|---|---|
|100000000|**Simple text**|
|100000001|**Boolean (yes/no)**|
|100000002|**Multiple choice**|
|100000003|**Single choice**|

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
|Description|**Status of the custom registration field**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_customregistrationfield_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the custom registration field**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_customregistrationfield_statuscode`|

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

- [business_unit_msevtmgt_customregistrationfield](#BKMK_business_unit_msevtmgt_customregistrationfield)
- [lk_msevtmgt_customregistrationfield_createdby](#BKMK_lk_msevtmgt_customregistrationfield_createdby)
- [lk_msevtmgt_customregistrationfield_createdonbehalfby](#BKMK_lk_msevtmgt_customregistrationfield_createdonbehalfby)
- [lk_msevtmgt_customregistrationfield_modifiedby](#BKMK_lk_msevtmgt_customregistrationfield_modifiedby)
- [lk_msevtmgt_customregistrationfield_modifiedonbehalfby](#BKMK_lk_msevtmgt_customregistrationfield_modifiedonbehalfby)
- [owner_msevtmgt_customregistrationfield](#BKMK_owner_msevtmgt_customregistrationfield)
- [team_msevtmgt_customregistrationfield](#BKMK_team_msevtmgt_customregistrationfield)
- [user_msevtmgt_customregistrationfield](#BKMK_user_msevtmgt_customregistrationfield)

### <a name="BKMK_business_unit_msevtmgt_customregistrationfield"></a> business_unit_msevtmgt_customregistrationfield

One-To-Many Relationship: [businessunit business_unit_msevtmgt_customregistrationfield](businessunit.md#BKMK_business_unit_msevtmgt_customregistrationfield)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_customregistrationfield_createdby"></a> lk_msevtmgt_customregistrationfield_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_customregistrationfield_createdby](systemuser.md#BKMK_lk_msevtmgt_customregistrationfield_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_customregistrationfield_createdonbehalfby"></a> lk_msevtmgt_customregistrationfield_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_customregistrationfield_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_customregistrationfield_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_customregistrationfield_modifiedby"></a> lk_msevtmgt_customregistrationfield_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_customregistrationfield_modifiedby](systemuser.md#BKMK_lk_msevtmgt_customregistrationfield_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_customregistrationfield_modifiedonbehalfby"></a> lk_msevtmgt_customregistrationfield_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_customregistrationfield_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_customregistrationfield_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_customregistrationfield"></a> owner_msevtmgt_customregistrationfield

One-To-Many Relationship: [owner owner_msevtmgt_customregistrationfield](owner.md#BKMK_owner_msevtmgt_customregistrationfield)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_customregistrationfield"></a> team_msevtmgt_customregistrationfield

One-To-Many Relationship: [team team_msevtmgt_customregistrationfield](team.md#BKMK_team_msevtmgt_customregistrationfield)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_customregistrationfield"></a> user_msevtmgt_customregistrationfield

One-To-Many Relationship: [systemuser user_msevtmgt_customregistrationfield](systemuser.md#BKMK_user_msevtmgt_customregistrationfield)

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

- [msevtmgt_customregistrationfield_AsyncOperations](#BKMK_msevtmgt_customregistrationfield_AsyncOperations)
- [msevtmgt_customregistrationfield_BulkDeleteFailures](#BKMK_msevtmgt_customregistrationfield_BulkDeleteFailures)
- [msevtmgt_customregistrationfield_DuplicateBaseRecord](#BKMK_msevtmgt_customregistrationfield_DuplicateBaseRecord)
- [msevtmgt_customregistrationfield_DuplicateMatchingRecord](#BKMK_msevtmgt_customregistrationfield_DuplicateMatchingRecord)
- [msevtmgt_customregistrationfield_eventcustomregistrationfield](#BKMK_msevtmgt_customregistrationfield_eventcustomregistrationfield)
- [msevtmgt_customregistrationfield_MailboxTrackingFolders](#BKMK_msevtmgt_customregistrationfield_MailboxTrackingFolders)
- [msevtmgt_customregistrationfield_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_customregistrationfield_PrincipalObjectAttributeAccesses)
- [msevtmgt_customregistrationfield_ProcessSession](#BKMK_msevtmgt_customregistrationfield_ProcessSession)
- [msevtmgt_customregistrationfield_SyncErrors](#BKMK_msevtmgt_customregistrationfield_SyncErrors)
- [msevtmgt_msevtmgt_customregistrationfield_msevtmgt_registrationresponse_registrationfield](#BKMK_msevtmgt_msevtmgt_customregistrationfield_msevtmgt_registrationresponse_registrationfield)

### <a name="BKMK_msevtmgt_customregistrationfield_AsyncOperations"></a> msevtmgt_customregistrationfield_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_customregistrationfield_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_customregistrationfield_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_customregistrationfield_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_customregistrationfield_BulkDeleteFailures"></a> msevtmgt_customregistrationfield_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_customregistrationfield_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_customregistrationfield_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_customregistrationfield_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_customregistrationfield_DuplicateBaseRecord"></a> msevtmgt_customregistrationfield_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msevtmgt_customregistrationfield_DuplicateBaseRecord](duplicaterecord.md#BKMK_msevtmgt_customregistrationfield_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_customregistrationfield_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_customregistrationfield_DuplicateMatchingRecord"></a> msevtmgt_customregistrationfield_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msevtmgt_customregistrationfield_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msevtmgt_customregistrationfield_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_customregistrationfield_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_customregistrationfield_eventcustomregistrationfield"></a> msevtmgt_customregistrationfield_eventcustomregistrationfield

Many-To-One Relationship: [msevtmgt_eventcustomregistrationfield msevtmgt_customregistrationfield_eventcustomregistrationfield](msevtmgt_eventcustomregistrationfield.md#BKMK_msevtmgt_customregistrationfield_eventcustomregistrationfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventcustomregistrationfield`|
|ReferencingAttribute|`msevtmgt_customregistrationfield`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_customregistrationfield_eventcustomregistrationfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_customregistrationfield_MailboxTrackingFolders"></a> msevtmgt_customregistrationfield_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_customregistrationfield_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_customregistrationfield_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_customregistrationfield_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_customregistrationfield_PrincipalObjectAttributeAccesses"></a> msevtmgt_customregistrationfield_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_customregistrationfield_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_customregistrationfield_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_customregistrationfield_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_customregistrationfield_ProcessSession"></a> msevtmgt_customregistrationfield_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_customregistrationfield_ProcessSession](processsession.md#BKMK_msevtmgt_customregistrationfield_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_customregistrationfield_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_customregistrationfield_SyncErrors"></a> msevtmgt_customregistrationfield_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_customregistrationfield_SyncErrors](syncerror.md#BKMK_msevtmgt_customregistrationfield_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_customregistrationfield_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_customregistrationfield_msevtmgt_registrationresponse_registrationfield"></a> msevtmgt_msevtmgt_customregistrationfield_msevtmgt_registrationresponse_registrationfield

Many-To-One Relationship: [msevtmgt_registrationresponse msevtmgt_msevtmgt_customregistrationfield_msevtmgt_registrationresponse_registrationfield](msevtmgt_registrationresponse.md#BKMK_msevtmgt_msevtmgt_customregistrationfield_msevtmgt_registrationresponse_registrationfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_registrationresponse`|
|ReferencingAttribute|`msevtmgt_customregistrationfield`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_customregistrationfield_msevtmgt_registrationresponse_registrationfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyncrm_maktformtemp_msevtmgt_customregfield](#BKMK_msdyncrm_maktformtemp_msevtmgt_customregfield)
- [msdyncrm_marketingform_msevtmgt_customregfield](#BKMK_msdyncrm_marketingform_msevtmgt_customregfield)
- [msevtmgt_customregistrationfield_event](#BKMK_msevtmgt_customregistrationfield_event)

### <a name="BKMK_msdyncrm_maktformtemp_msevtmgt_customregfield"></a> msdyncrm_maktformtemp_msevtmgt_customregfield

See [msdyncrm_marketingformtemplate msdyncrm_maktformtemp_msevtmgt_customregfield Many-To-Many Relationship](msdyncrm_marketingformtemplate.md#BKMK_msdyncrm_maktformtemp_msevtmgt_customregfield)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_maktformtemp_msevtmgt_customregfield`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_maktformtemp_msevtmgt_customregfield`|
|IntersectAttribute|`msevtmgt_customregistrationfieldid`|
|NavigationPropertyName|`msdyncrm_maktformtemp_msevtmgt_customregfield`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingform_msevtmgt_customregfield"></a> msdyncrm_marketingform_msevtmgt_customregfield

See [msdyncrm_marketingform msdyncrm_marketingform_msevtmgt_customregfield Many-To-Many Relationship](msdyncrm_marketingform.md#BKMK_msdyncrm_marketingform_msevtmgt_customregfield)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_marketingform_msevtmgt_customregfield`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_marketingform_msevtmgt_customregfield`|
|IntersectAttribute|`msevtmgt_customregistrationfieldid`|
|NavigationPropertyName|`msdyncrm_marketingform_msevtmgt_customregfield`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_customregistrationfield_event"></a> msevtmgt_customregistrationfield_event

See [msevtmgt_event msevtmgt_customregistrationfield_event Many-To-Many Relationship](msevtmgt_event.md#BKMK_msevtmgt_customregistrationfield_event)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_customregistrationfield_event`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_customregistrationfield_event`|
|IntersectAttribute|`msevtmgt_customregistrationfieldid`|
|NavigationPropertyName|`msevtmgt_customregistrationfield_event`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

