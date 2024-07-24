---
title: "Purchase Order SubStatus (msdyn_purchaseordersubstatus) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Purchase Order SubStatus (msdyn_purchaseordersubstatus) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Purchase Order SubStatus (msdyn_purchaseordersubstatus) table/entity reference

Specify custom PO Substatuses, which can be used to specify the current PO status more precisely.

## Messages

The following table lists the messages for the Purchase Order SubStatus (msdyn_purchaseordersubstatus) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_purchaseordersubstatuses(*msdyn_purchaseordersubstatusid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_purchaseordersubstatuses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_purchaseordersubstatuses(*msdyn_purchaseordersubstatusid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_purchaseordersubstatuses(*msdyn_purchaseordersubstatusid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_purchaseordersubstatuses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_purchaseordersubstatuses(*msdyn_purchaseordersubstatusid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_purchaseordersubstatuses(*msdyn_purchaseordersubstatusid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_purchaseordersubstatuses(*msdyn_purchaseordersubstatusid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Purchase Order SubStatus (msdyn_purchaseordersubstatus) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Purchase Order SubStatus (msdyn_purchaseordersubstatus) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Purchase Order SubStatus** |
| **DisplayCollectionName** | **Purchase Order Substatuses** |
| **SchemaName** | `msdyn_purchaseordersubstatus` |
| **CollectionSchemaName** | `msdyn_purchaseordersubstatuses` |
| **EntitySetName** | `msdyn_purchaseordersubstatuses`|
| **LogicalName** | `msdyn_purchaseordersubstatus` |
| **LogicalCollectionName** | `msdyn_purchaseordersubstatuses` |
| **PrimaryIdAttribute** | `msdyn_purchaseordersubstatusid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_DefaultSubStatus](#BKMK_msdyn_DefaultSubStatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_purchaseordersubstatusId](#BKMK_msdyn_purchaseordersubstatusId)
- [msdyn_SystemStatus](#BKMK_msdyn_SystemStatus)
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

### <a name="BKMK_msdyn_DefaultSubStatus"></a> msdyn_DefaultSubStatus

|Property|Value|
|---|---|
|Description|**Specify whether this status should be the default Substatus for this status type**|
|DisplayName|**Default Substatus**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultsubstatus`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_purchaseordersubstatus_msdyn_defaultsubstatus`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Purchase Order Substatus name**|
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
|MaxLength|100|

### <a name="BKMK_msdyn_purchaseordersubstatusId"></a> msdyn_purchaseordersubstatusId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Purchase Order Substatus**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_purchaseordersubstatusid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

|Property|Value|
|---|---|
|Description|**Specify the system status.**|
|DisplayName|**System Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_systemstatus`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_posystemstatus`|

#### msdyn_SystemStatus Choices/Options

|Value|Label|
|---|---|
|690970000|**Draft**|
|690970001|**Submitted**|
|690970002|**Canceled**|
|690970003|**Products Received**|
|690970004|**Billed**|

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
|Description|**Status of the Purchase Order Substatus**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_purchaseordersubstatus_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Purchase Order Substatus**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_purchaseordersubstatus_statuscode`|

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

- [business_unit_msdyn_purchaseordersubstatus](#BKMK_business_unit_msdyn_purchaseordersubstatus)
- [lk_msdyn_purchaseordersubstatus_createdby](#BKMK_lk_msdyn_purchaseordersubstatus_createdby)
- [lk_msdyn_purchaseordersubstatus_createdonbehalfby](#BKMK_lk_msdyn_purchaseordersubstatus_createdonbehalfby)
- [lk_msdyn_purchaseordersubstatus_modifiedby](#BKMK_lk_msdyn_purchaseordersubstatus_modifiedby)
- [lk_msdyn_purchaseordersubstatus_modifiedonbehalfby](#BKMK_lk_msdyn_purchaseordersubstatus_modifiedonbehalfby)
- [owner_msdyn_purchaseordersubstatus](#BKMK_owner_msdyn_purchaseordersubstatus)
- [team_msdyn_purchaseordersubstatus](#BKMK_team_msdyn_purchaseordersubstatus)
- [user_msdyn_purchaseordersubstatus](#BKMK_user_msdyn_purchaseordersubstatus)

### <a name="BKMK_business_unit_msdyn_purchaseordersubstatus"></a> business_unit_msdyn_purchaseordersubstatus

One-To-Many Relationship: [businessunit business_unit_msdyn_purchaseordersubstatus](businessunit.md#BKMK_business_unit_msdyn_purchaseordersubstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_purchaseordersubstatus_createdby"></a> lk_msdyn_purchaseordersubstatus_createdby

One-To-Many Relationship: [systemuser lk_msdyn_purchaseordersubstatus_createdby](systemuser.md#BKMK_lk_msdyn_purchaseordersubstatus_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_purchaseordersubstatus_createdonbehalfby"></a> lk_msdyn_purchaseordersubstatus_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_purchaseordersubstatus_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseordersubstatus_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_purchaseordersubstatus_modifiedby"></a> lk_msdyn_purchaseordersubstatus_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_purchaseordersubstatus_modifiedby](systemuser.md#BKMK_lk_msdyn_purchaseordersubstatus_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_purchaseordersubstatus_modifiedonbehalfby"></a> lk_msdyn_purchaseordersubstatus_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_purchaseordersubstatus_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_purchaseordersubstatus_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_purchaseordersubstatus"></a> owner_msdyn_purchaseordersubstatus

One-To-Many Relationship: [owner owner_msdyn_purchaseordersubstatus](owner.md#BKMK_owner_msdyn_purchaseordersubstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_purchaseordersubstatus"></a> team_msdyn_purchaseordersubstatus

One-To-Many Relationship: [team team_msdyn_purchaseordersubstatus](team.md#BKMK_team_msdyn_purchaseordersubstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_purchaseordersubstatus"></a> user_msdyn_purchaseordersubstatus

One-To-Many Relationship: [systemuser user_msdyn_purchaseordersubstatus](systemuser.md#BKMK_user_msdyn_purchaseordersubstatus)

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

- [msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus](#BKMK_msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus)
- [msdyn_purchaseordersubstatus_ActivityPointers](#BKMK_msdyn_purchaseordersubstatus_ActivityPointers)
- [msdyn_purchaseordersubstatus_adx_alertsubscriptions](#BKMK_msdyn_purchaseordersubstatus_adx_alertsubscriptions)
- [msdyn_purchaseordersubstatus_adx_inviteredemptions](#BKMK_msdyn_purchaseordersubstatus_adx_inviteredemptions)
- [msdyn_purchaseordersubstatus_adx_portalcomments](#BKMK_msdyn_purchaseordersubstatus_adx_portalcomments)
- [msdyn_purchaseordersubstatus_Annotations](#BKMK_msdyn_purchaseordersubstatus_Annotations)
- [msdyn_purchaseordersubstatus_Appointments](#BKMK_msdyn_purchaseordersubstatus_Appointments)
- [msdyn_purchaseordersubstatus_AsyncOperations](#BKMK_msdyn_purchaseordersubstatus_AsyncOperations)
- [msdyn_purchaseordersubstatus_BulkDeleteFailures](#BKMK_msdyn_purchaseordersubstatus_BulkDeleteFailures)
- [msdyn_purchaseordersubstatus_chats](#BKMK_msdyn_purchaseordersubstatus_chats)
- [msdyn_purchaseordersubstatus_connections1](#BKMK_msdyn_purchaseordersubstatus_connections1)
- [msdyn_purchaseordersubstatus_connections2](#BKMK_msdyn_purchaseordersubstatus_connections2)
- [msdyn_purchaseordersubstatus_DuplicateBaseRecord](#BKMK_msdyn_purchaseordersubstatus_DuplicateBaseRecord)
- [msdyn_purchaseordersubstatus_DuplicateMatchingRecord](#BKMK_msdyn_purchaseordersubstatus_DuplicateMatchingRecord)
- [msdyn_purchaseordersubstatus_Emails](#BKMK_msdyn_purchaseordersubstatus_Emails)
- [msdyn_purchaseordersubstatus_Faxes](#BKMK_msdyn_purchaseordersubstatus_Faxes)
- [msdyn_purchaseordersubstatus_Letters](#BKMK_msdyn_purchaseordersubstatus_Letters)
- [msdyn_purchaseordersubstatus_li_inmails](#BKMK_msdyn_purchaseordersubstatus_li_inmails)
- [msdyn_purchaseordersubstatus_li_messages](#BKMK_msdyn_purchaseordersubstatus_li_messages)
- [msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds](#BKMK_msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds)
- [msdyn_purchaseordersubstatus_MailboxTrackingFolders](#BKMK_msdyn_purchaseordersubstatus_MailboxTrackingFolders)
- [msdyn_purchaseordersubstatus_msdyn_bookingalerts](#BKMK_msdyn_purchaseordersubstatus_msdyn_bookingalerts)
- [msdyn_purchaseordersubstatus_msdyn_copilottranscripts](#BKMK_msdyn_purchaseordersubstatus_msdyn_copilottranscripts)
- [msdyn_purchaseordersubstatus_msdyn_ocliveworkitems](#BKMK_msdyn_purchaseordersubstatus_msdyn_ocliveworkitems)
- [msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages](#BKMK_msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages)
- [msdyn_purchaseordersubstatus_msdyn_ocsessions](#BKMK_msdyn_purchaseordersubstatus_msdyn_ocsessions)
- [msdyn_purchaseordersubstatus_msdyn_ocvoicemails](#BKMK_msdyn_purchaseordersubstatus_msdyn_ocvoicemails)
- [msdyn_purchaseordersubstatus_msfp_alerts](#BKMK_msdyn_purchaseordersubstatus_msfp_alerts)
- [msdyn_purchaseordersubstatus_msfp_surveyinvites](#BKMK_msdyn_purchaseordersubstatus_msfp_surveyinvites)
- [msdyn_purchaseordersubstatus_msfp_surveyresponses](#BKMK_msdyn_purchaseordersubstatus_msfp_surveyresponses)
- [msdyn_purchaseordersubstatus_PhoneCalls](#BKMK_msdyn_purchaseordersubstatus_PhoneCalls)
- [msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseordersubstatus_ProcessSession](#BKMK_msdyn_purchaseordersubstatus_ProcessSession)
- [msdyn_purchaseordersubstatus_RecurringAppointmentMasters](#BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters)
- [msdyn_purchaseordersubstatus_ServiceAppointments](#BKMK_msdyn_purchaseordersubstatus_ServiceAppointments)
- [msdyn_purchaseordersubstatus_SocialActivities](#BKMK_msdyn_purchaseordersubstatus_SocialActivities)
- [msdyn_purchaseordersubstatus_SyncErrors](#BKMK_msdyn_purchaseordersubstatus_SyncErrors)
- [msdyn_purchaseordersubstatus_Tasks](#BKMK_msdyn_purchaseordersubstatus_Tasks)

### <a name="BKMK_msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus"></a> msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus

Many-To-One Relationship: [msdyn_purchaseorder msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`msdyn_substatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_purchaseordersubstatus_msdyn_purchaseorder_SubStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_ActivityPointers"></a> msdyn_purchaseordersubstatus_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_purchaseordersubstatus_ActivityPointers](activitypointer.md#BKMK_msdyn_purchaseordersubstatus_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_adx_alertsubscriptions"></a> msdyn_purchaseordersubstatus_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msdyn_purchaseordersubstatus_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msdyn_purchaseordersubstatus_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_adx_inviteredemptions"></a> msdyn_purchaseordersubstatus_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_purchaseordersubstatus_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_purchaseordersubstatus_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_adx_portalcomments"></a> msdyn_purchaseordersubstatus_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_purchaseordersubstatus_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_purchaseordersubstatus_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Annotations"></a> msdyn_purchaseordersubstatus_Annotations

Many-To-One Relationship: [annotation msdyn_purchaseordersubstatus_Annotations](annotation.md#BKMK_msdyn_purchaseordersubstatus_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Appointments"></a> msdyn_purchaseordersubstatus_Appointments

Many-To-One Relationship: [appointment msdyn_purchaseordersubstatus_Appointments](appointment.md#BKMK_msdyn_purchaseordersubstatus_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_AsyncOperations"></a> msdyn_purchaseordersubstatus_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_purchaseordersubstatus_AsyncOperations](asyncoperation.md#BKMK_msdyn_purchaseordersubstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_BulkDeleteFailures"></a> msdyn_purchaseordersubstatus_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_purchaseordersubstatus_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_purchaseordersubstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_chats"></a> msdyn_purchaseordersubstatus_chats

Many-To-One Relationship: [chat msdyn_purchaseordersubstatus_chats](chat.md#BKMK_msdyn_purchaseordersubstatus_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_connections1"></a> msdyn_purchaseordersubstatus_connections1

Many-To-One Relationship: [connection msdyn_purchaseordersubstatus_connections1](connection.md#BKMK_msdyn_purchaseordersubstatus_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_connections2"></a> msdyn_purchaseordersubstatus_connections2

Many-To-One Relationship: [connection msdyn_purchaseordersubstatus_connections2](connection.md#BKMK_msdyn_purchaseordersubstatus_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_DuplicateBaseRecord"></a> msdyn_purchaseordersubstatus_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_purchaseordersubstatus_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_purchaseordersubstatus_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_DuplicateMatchingRecord"></a> msdyn_purchaseordersubstatus_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_purchaseordersubstatus_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_purchaseordersubstatus_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Emails"></a> msdyn_purchaseordersubstatus_Emails

Many-To-One Relationship: [email msdyn_purchaseordersubstatus_Emails](email.md#BKMK_msdyn_purchaseordersubstatus_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Faxes"></a> msdyn_purchaseordersubstatus_Faxes

Many-To-One Relationship: [fax msdyn_purchaseordersubstatus_Faxes](fax.md#BKMK_msdyn_purchaseordersubstatus_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Letters"></a> msdyn_purchaseordersubstatus_Letters

Many-To-One Relationship: [letter msdyn_purchaseordersubstatus_Letters](letter.md#BKMK_msdyn_purchaseordersubstatus_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_li_inmails"></a> msdyn_purchaseordersubstatus_li_inmails

Many-To-One Relationship: [li_inmail msdyn_purchaseordersubstatus_li_inmails](li_inmail.md#BKMK_msdyn_purchaseordersubstatus_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_li_messages"></a> msdyn_purchaseordersubstatus_li_messages

Many-To-One Relationship: [li_message msdyn_purchaseordersubstatus_li_messages](li_message.md#BKMK_msdyn_purchaseordersubstatus_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds"></a> msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_MailboxTrackingFolders"></a> msdyn_purchaseordersubstatus_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_purchaseordersubstatus_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_purchaseordersubstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msdyn_bookingalerts"></a> msdyn_purchaseordersubstatus_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_purchaseordersubstatus_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_purchaseordersubstatus_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msdyn_copilottranscripts"></a> msdyn_purchaseordersubstatus_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_purchaseordersubstatus_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_purchaseordersubstatus_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msdyn_ocliveworkitems"></a> msdyn_purchaseordersubstatus_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_purchaseordersubstatus_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_purchaseordersubstatus_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages"></a> msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msdyn_ocsessions"></a> msdyn_purchaseordersubstatus_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_purchaseordersubstatus_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_purchaseordersubstatus_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msdyn_ocvoicemails"></a> msdyn_purchaseordersubstatus_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_purchaseordersubstatus_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyn_purchaseordersubstatus_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msfp_alerts"></a> msdyn_purchaseordersubstatus_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_purchaseordersubstatus_msfp_alerts](msfp_alert.md#BKMK_msdyn_purchaseordersubstatus_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msfp_surveyinvites"></a> msdyn_purchaseordersubstatus_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_purchaseordersubstatus_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_purchaseordersubstatus_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_msfp_surveyresponses"></a> msdyn_purchaseordersubstatus_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_purchaseordersubstatus_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_purchaseordersubstatus_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_PhoneCalls"></a> msdyn_purchaseordersubstatus_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_purchaseordersubstatus_PhoneCalls](phonecall.md#BKMK_msdyn_purchaseordersubstatus_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_ProcessSession"></a> msdyn_purchaseordersubstatus_ProcessSession

Many-To-One Relationship: [processsession msdyn_purchaseordersubstatus_ProcessSession](processsession.md#BKMK_msdyn_purchaseordersubstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters"></a> msdyn_purchaseordersubstatus_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_purchaseordersubstatus_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_purchaseordersubstatus_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_ServiceAppointments"></a> msdyn_purchaseordersubstatus_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_purchaseordersubstatus_ServiceAppointments](serviceappointment.md#BKMK_msdyn_purchaseordersubstatus_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_SocialActivities"></a> msdyn_purchaseordersubstatus_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_purchaseordersubstatus_SocialActivities](socialactivity.md#BKMK_msdyn_purchaseordersubstatus_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_SyncErrors"></a> msdyn_purchaseordersubstatus_SyncErrors

Many-To-One Relationship: [syncerror msdyn_purchaseordersubstatus_SyncErrors](syncerror.md#BKMK_msdyn_purchaseordersubstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_purchaseordersubstatus_Tasks"></a> msdyn_purchaseordersubstatus_Tasks

Many-To-One Relationship: [task msdyn_purchaseordersubstatus_Tasks](task.md#BKMK_msdyn_purchaseordersubstatus_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_purchaseordersubstatus_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

