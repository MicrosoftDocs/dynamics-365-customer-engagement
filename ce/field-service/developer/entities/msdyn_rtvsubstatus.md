---
title: "RTV Substatus (msdyn_rtvsubstatus) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the RTV Substatus (msdyn_rtvsubstatus) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# RTV Substatus (msdyn_rtvsubstatus) table/entity reference

Specify custom RTV substatuses, which can be used to specify the current RTV status more precisely.

## Messages

The following table lists the messages for the RTV Substatus (msdyn_rtvsubstatus) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_rtvsubstatuses(*msdyn_rtvsubstatusid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_rtvsubstatuses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_rtvsubstatuses(*msdyn_rtvsubstatusid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_rtvsubstatuses(*msdyn_rtvsubstatusid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_rtvsubstatuses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_rtvsubstatuses(*msdyn_rtvsubstatusid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_rtvsubstatuses(*msdyn_rtvsubstatusid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_rtvsubstatuses(*msdyn_rtvsubstatusid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the RTV Substatus (msdyn_rtvsubstatus) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the RTV Substatus (msdyn_rtvsubstatus) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **RTV Substatus** |
| **DisplayCollectionName** | **RTV Substatuses** |
| **SchemaName** | `msdyn_rtvsubstatus` |
| **CollectionSchemaName** | `msdyn_rtvsubstatuses` |
| **EntitySetName** | `msdyn_rtvsubstatuses`|
| **LogicalName** | `msdyn_rtvsubstatus` |
| **LogicalCollectionName** | `msdyn_rtvsubstatuses` |
| **PrimaryIdAttribute** | `msdyn_rtvsubstatusid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_DefaultSubStatus](#BKMK_msdyn_DefaultSubStatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_rtvsubstatusId](#BKMK_msdyn_rtvsubstatusId)
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
|Description||
|DisplayName|**Default Substatus**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultsubstatus`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_rtvsubstatus_msdyn_defaultsubstatus`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**RTV Substatus name**|
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

### <a name="BKMK_msdyn_rtvsubstatusId"></a> msdyn_rtvsubstatusId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**RTV Substatus**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_rtvsubstatusid`|
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
|GlobalChoiceName|`msdyn_rtvsystemstatus`|

#### msdyn_SystemStatus Choices/Options

|Value|Label|
|---|---|
|690970000|**Draft**|
|690970001|**Approved**|
|690970002|**Shipped**|
|690970003|**Received**|
|690970004|**Canceled**|

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
|Description|**Status of the RTV Substatus**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_rtvsubstatus_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the RTV Substatus**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_rtvsubstatus_statuscode`|

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

- [business_unit_msdyn_rtvsubstatus](#BKMK_business_unit_msdyn_rtvsubstatus)
- [lk_msdyn_rtvsubstatus_createdby](#BKMK_lk_msdyn_rtvsubstatus_createdby)
- [lk_msdyn_rtvsubstatus_createdonbehalfby](#BKMK_lk_msdyn_rtvsubstatus_createdonbehalfby)
- [lk_msdyn_rtvsubstatus_modifiedby](#BKMK_lk_msdyn_rtvsubstatus_modifiedby)
- [lk_msdyn_rtvsubstatus_modifiedonbehalfby](#BKMK_lk_msdyn_rtvsubstatus_modifiedonbehalfby)
- [owner_msdyn_rtvsubstatus](#BKMK_owner_msdyn_rtvsubstatus)
- [team_msdyn_rtvsubstatus](#BKMK_team_msdyn_rtvsubstatus)
- [user_msdyn_rtvsubstatus](#BKMK_user_msdyn_rtvsubstatus)

### <a name="BKMK_business_unit_msdyn_rtvsubstatus"></a> business_unit_msdyn_rtvsubstatus

One-To-Many Relationship: [businessunit business_unit_msdyn_rtvsubstatus](businessunit.md#BKMK_business_unit_msdyn_rtvsubstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rtvsubstatus_createdby"></a> lk_msdyn_rtvsubstatus_createdby

One-To-Many Relationship: [systemuser lk_msdyn_rtvsubstatus_createdby](systemuser.md#BKMK_lk_msdyn_rtvsubstatus_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rtvsubstatus_createdonbehalfby"></a> lk_msdyn_rtvsubstatus_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_rtvsubstatus_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_rtvsubstatus_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rtvsubstatus_modifiedby"></a> lk_msdyn_rtvsubstatus_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_rtvsubstatus_modifiedby](systemuser.md#BKMK_lk_msdyn_rtvsubstatus_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_rtvsubstatus_modifiedonbehalfby"></a> lk_msdyn_rtvsubstatus_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_rtvsubstatus_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_rtvsubstatus_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_rtvsubstatus"></a> owner_msdyn_rtvsubstatus

One-To-Many Relationship: [owner owner_msdyn_rtvsubstatus](owner.md#BKMK_owner_msdyn_rtvsubstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_rtvsubstatus"></a> team_msdyn_rtvsubstatus

One-To-Many Relationship: [team team_msdyn_rtvsubstatus](team.md#BKMK_team_msdyn_rtvsubstatus)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_rtvsubstatus"></a> user_msdyn_rtvsubstatus

One-To-Many Relationship: [systemuser user_msdyn_rtvsubstatus](systemuser.md#BKMK_user_msdyn_rtvsubstatus)

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

- [msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus](#BKMK_msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus)
- [msdyn_rtvsubstatus_ActivityPointers](#BKMK_msdyn_rtvsubstatus_ActivityPointers)
- [msdyn_rtvsubstatus_adx_inviteredemptions](#BKMK_msdyn_rtvsubstatus_adx_inviteredemptions)
- [msdyn_rtvsubstatus_adx_portalcomments](#BKMK_msdyn_rtvsubstatus_adx_portalcomments)
- [msdyn_rtvsubstatus_Annotations](#BKMK_msdyn_rtvsubstatus_Annotations)
- [msdyn_rtvsubstatus_Appointments](#BKMK_msdyn_rtvsubstatus_Appointments)
- [msdyn_rtvsubstatus_AsyncOperations](#BKMK_msdyn_rtvsubstatus_AsyncOperations)
- [msdyn_rtvsubstatus_BulkDeleteFailures](#BKMK_msdyn_rtvsubstatus_BulkDeleteFailures)
- [msdyn_rtvsubstatus_chats](#BKMK_msdyn_rtvsubstatus_chats)
- [msdyn_rtvsubstatus_connections1](#BKMK_msdyn_rtvsubstatus_connections1)
- [msdyn_rtvsubstatus_connections2](#BKMK_msdyn_rtvsubstatus_connections2)
- [msdyn_rtvsubstatus_DuplicateBaseRecord](#BKMK_msdyn_rtvsubstatus_DuplicateBaseRecord)
- [msdyn_rtvsubstatus_DuplicateMatchingRecord](#BKMK_msdyn_rtvsubstatus_DuplicateMatchingRecord)
- [msdyn_rtvsubstatus_Emails](#BKMK_msdyn_rtvsubstatus_Emails)
- [msdyn_rtvsubstatus_Faxes](#BKMK_msdyn_rtvsubstatus_Faxes)
- [msdyn_rtvsubstatus_Letters](#BKMK_msdyn_rtvsubstatus_Letters)
- [msdyn_rtvsubstatus_MailboxTrackingFolders](#BKMK_msdyn_rtvsubstatus_MailboxTrackingFolders)
- [msdyn_rtvsubstatus_msdyn_bookingalerts](#BKMK_msdyn_rtvsubstatus_msdyn_bookingalerts)
- [msdyn_rtvsubstatus_msdyn_copilottranscripts](#BKMK_msdyn_rtvsubstatus_msdyn_copilottranscripts)
- [msdyn_rtvsubstatus_msdyn_ocliveworkitems](#BKMK_msdyn_rtvsubstatus_msdyn_ocliveworkitems)
- [msdyn_rtvsubstatus_msdyn_ocsessions](#BKMK_msdyn_rtvsubstatus_msdyn_ocsessions)
- [msdyn_rtvsubstatus_msfp_alerts](#BKMK_msdyn_rtvsubstatus_msfp_alerts)
- [msdyn_rtvsubstatus_msfp_surveyinvites](#BKMK_msdyn_rtvsubstatus_msfp_surveyinvites)
- [msdyn_rtvsubstatus_msfp_surveyresponses](#BKMK_msdyn_rtvsubstatus_msfp_surveyresponses)
- [msdyn_rtvsubstatus_PhoneCalls](#BKMK_msdyn_rtvsubstatus_PhoneCalls)
- [msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses)
- [msdyn_rtvsubstatus_ProcessSession](#BKMK_msdyn_rtvsubstatus_ProcessSession)
- [msdyn_rtvsubstatus_RecurringAppointmentMasters](#BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters)
- [msdyn_rtvsubstatus_ServiceAppointments](#BKMK_msdyn_rtvsubstatus_ServiceAppointments)
- [msdyn_rtvsubstatus_SocialActivities](#BKMK_msdyn_rtvsubstatus_SocialActivities)
- [msdyn_rtvsubstatus_SyncErrors](#BKMK_msdyn_rtvsubstatus_SyncErrors)
- [msdyn_rtvsubstatus_Tasks](#BKMK_msdyn_rtvsubstatus_Tasks)

### <a name="BKMK_msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus"></a> msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus

Many-To-One Relationship: [msdyn_rtv msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus](msdyn_rtv.md#BKMK_msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`msdyn_substatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_rtvsubstatus_msdyn_rtv_SubStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Substatus<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_ActivityPointers"></a> msdyn_rtvsubstatus_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_rtvsubstatus_ActivityPointers](activitypointer.md#BKMK_msdyn_rtvsubstatus_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_adx_inviteredemptions"></a> msdyn_rtvsubstatus_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_rtvsubstatus_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_rtvsubstatus_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_adx_portalcomments"></a> msdyn_rtvsubstatus_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_rtvsubstatus_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_rtvsubstatus_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_Annotations"></a> msdyn_rtvsubstatus_Annotations

Many-To-One Relationship: [annotation msdyn_rtvsubstatus_Annotations](annotation.md#BKMK_msdyn_rtvsubstatus_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_Appointments"></a> msdyn_rtvsubstatus_Appointments

Many-To-One Relationship: [appointment msdyn_rtvsubstatus_Appointments](appointment.md#BKMK_msdyn_rtvsubstatus_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_AsyncOperations"></a> msdyn_rtvsubstatus_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_rtvsubstatus_AsyncOperations](asyncoperation.md#BKMK_msdyn_rtvsubstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_BulkDeleteFailures"></a> msdyn_rtvsubstatus_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_rtvsubstatus_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_rtvsubstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_chats"></a> msdyn_rtvsubstatus_chats

Many-To-One Relationship: [chat msdyn_rtvsubstatus_chats](chat.md#BKMK_msdyn_rtvsubstatus_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_connections1"></a> msdyn_rtvsubstatus_connections1

Many-To-One Relationship: [connection msdyn_rtvsubstatus_connections1](connection.md#BKMK_msdyn_rtvsubstatus_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_connections2"></a> msdyn_rtvsubstatus_connections2

Many-To-One Relationship: [connection msdyn_rtvsubstatus_connections2](connection.md#BKMK_msdyn_rtvsubstatus_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_DuplicateBaseRecord"></a> msdyn_rtvsubstatus_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_rtvsubstatus_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_rtvsubstatus_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_DuplicateMatchingRecord"></a> msdyn_rtvsubstatus_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_rtvsubstatus_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_rtvsubstatus_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_Emails"></a> msdyn_rtvsubstatus_Emails

Many-To-One Relationship: [email msdyn_rtvsubstatus_Emails](email.md#BKMK_msdyn_rtvsubstatus_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_Faxes"></a> msdyn_rtvsubstatus_Faxes

Many-To-One Relationship: [fax msdyn_rtvsubstatus_Faxes](fax.md#BKMK_msdyn_rtvsubstatus_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_Letters"></a> msdyn_rtvsubstatus_Letters

Many-To-One Relationship: [letter msdyn_rtvsubstatus_Letters](letter.md#BKMK_msdyn_rtvsubstatus_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_MailboxTrackingFolders"></a> msdyn_rtvsubstatus_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_rtvsubstatus_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_rtvsubstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_msdyn_bookingalerts"></a> msdyn_rtvsubstatus_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_rtvsubstatus_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_rtvsubstatus_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_msdyn_copilottranscripts"></a> msdyn_rtvsubstatus_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_rtvsubstatus_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_rtvsubstatus_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_msdyn_ocliveworkitems"></a> msdyn_rtvsubstatus_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_rtvsubstatus_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_rtvsubstatus_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_msdyn_ocsessions"></a> msdyn_rtvsubstatus_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_rtvsubstatus_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_rtvsubstatus_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_msfp_alerts"></a> msdyn_rtvsubstatus_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_rtvsubstatus_msfp_alerts](msfp_alert.md#BKMK_msdyn_rtvsubstatus_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_msfp_surveyinvites"></a> msdyn_rtvsubstatus_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_rtvsubstatus_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_rtvsubstatus_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_msfp_surveyresponses"></a> msdyn_rtvsubstatus_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_rtvsubstatus_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_rtvsubstatus_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_PhoneCalls"></a> msdyn_rtvsubstatus_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_rtvsubstatus_PhoneCalls](phonecall.md#BKMK_msdyn_rtvsubstatus_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses"></a> msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_ProcessSession"></a> msdyn_rtvsubstatus_ProcessSession

Many-To-One Relationship: [processsession msdyn_rtvsubstatus_ProcessSession](processsession.md#BKMK_msdyn_rtvsubstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters"></a> msdyn_rtvsubstatus_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_rtvsubstatus_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_rtvsubstatus_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_ServiceAppointments"></a> msdyn_rtvsubstatus_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_rtvsubstatus_ServiceAppointments](serviceappointment.md#BKMK_msdyn_rtvsubstatus_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_SocialActivities"></a> msdyn_rtvsubstatus_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_rtvsubstatus_SocialActivities](socialactivity.md#BKMK_msdyn_rtvsubstatus_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_SyncErrors"></a> msdyn_rtvsubstatus_SyncErrors

Many-To-One Relationship: [syncerror msdyn_rtvsubstatus_SyncErrors](syncerror.md#BKMK_msdyn_rtvsubstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_rtvsubstatus_Tasks"></a> msdyn_rtvsubstatus_Tasks

Many-To-One Relationship: [task msdyn_rtvsubstatus_Tasks](task.md#BKMK_msdyn_rtvsubstatus_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_rtvsubstatus_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

