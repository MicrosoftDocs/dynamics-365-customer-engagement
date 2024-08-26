---
title: "Resource Restriction (Deprecated) (msdyn_workorderresourcerestriction) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Resource Restriction (Deprecated) (msdyn_workorderresourcerestriction) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Resource Restriction (Deprecated) (msdyn_workorderresourcerestriction) table/entity reference

This entity is deprecated.

## Messages

The following table lists the messages for the Resource Restriction (Deprecated) (msdyn_workorderresourcerestriction) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_workorderresourcerestrictions(*msdyn_workorderresourcerestrictionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_workorderresourcerestrictions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_workorderresourcerestrictions(*msdyn_workorderresourcerestrictionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_workorderresourcerestrictions(*msdyn_workorderresourcerestrictionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_workorderresourcerestrictions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_workorderresourcerestrictions(*msdyn_workorderresourcerestrictionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_workorderresourcerestrictions(*msdyn_workorderresourcerestrictionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_workorderresourcerestrictions(*msdyn_workorderresourcerestrictionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Resource Restriction (Deprecated) (msdyn_workorderresourcerestriction) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Resource Restriction (Deprecated) (msdyn_workorderresourcerestriction) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Resource Restriction (Deprecated)** |
| **DisplayCollectionName** | **Resource Restrictions (Deprecated)** |
| **SchemaName** | `msdyn_workorderresourcerestriction` |
| **CollectionSchemaName** | `msdyn_workorderresourcerestrictions` |
| **EntitySetName** | `msdyn_workorderresourcerestrictions`|
| **LogicalName** | `msdyn_workorderresourcerestriction` |
| **LogicalCollectionName** | `msdyn_workorderresourcerestrictions` |
| **PrimaryIdAttribute** | `msdyn_workorderresourcerestrictionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Account](#BKMK_msdyn_Account)
- [msdyn_Cascade](#BKMK_msdyn_Cascade)
- [msdyn_ExpirationDate](#BKMK_msdyn_ExpirationDate)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Resource](#BKMK_msdyn_Resource)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [msdyn_workorderresourcerestrictionId](#BKMK_msdyn_workorderresourcerestrictionId)
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

### <a name="BKMK_msdyn_Account"></a> msdyn_Account

|Property|Value|
|---|---|
|Description||
|DisplayName|**Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_account`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_Cascade"></a> msdyn_Cascade

|Property|Value|
|---|---|
|Description||
|DisplayName|**Cascade**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cascade`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_workorderresourcerestriction_msdyn_cascade`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_ExpirationDate"></a> msdyn_ExpirationDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Expiration Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_expirationdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Resource"></a> msdyn_Resource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Resource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resource`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|bookableresource|

### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorder`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorder|

### <a name="BKMK_msdyn_workorderresourcerestrictionId"></a> msdyn_workorderresourcerestrictionId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Resource Restriction**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderresourcerestrictionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the Work Order Resource Restriction**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_workorderresourcerestriction_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Work Order Resource Restriction**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_workorderresourcerestriction_statuscode`|

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

- [business_unit_msdyn_workorderresourcerestriction](#BKMK_business_unit_msdyn_workorderresourcerestriction)
- [lk_msdyn_workorderresourcerestriction_createdby](#BKMK_lk_msdyn_workorderresourcerestriction_createdby)
- [lk_msdyn_workorderresourcerestriction_createdonbehalfby](#BKMK_lk_msdyn_workorderresourcerestriction_createdonbehalfby)
- [lk_msdyn_workorderresourcerestriction_modifiedby](#BKMK_lk_msdyn_workorderresourcerestriction_modifiedby)
- [lk_msdyn_workorderresourcerestriction_modifiedonbehalfby](#BKMK_lk_msdyn_workorderresourcerestriction_modifiedonbehalfby)
- [msdyn_account_msdyn_workorderresourcerestriction_Account](#BKMK_msdyn_account_msdyn_workorderresourcerestriction_Account)
- [msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource](#BKMK_msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource)
- [msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder)
- [owner_msdyn_workorderresourcerestriction](#BKMK_owner_msdyn_workorderresourcerestriction)
- [team_msdyn_workorderresourcerestriction](#BKMK_team_msdyn_workorderresourcerestriction)
- [user_msdyn_workorderresourcerestriction](#BKMK_user_msdyn_workorderresourcerestriction)

### <a name="BKMK_business_unit_msdyn_workorderresourcerestriction"></a> business_unit_msdyn_workorderresourcerestriction

One-To-Many Relationship: [businessunit business_unit_msdyn_workorderresourcerestriction](businessunit.md#BKMK_business_unit_msdyn_workorderresourcerestriction)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderresourcerestriction_createdby"></a> lk_msdyn_workorderresourcerestriction_createdby

One-To-Many Relationship: [systemuser lk_msdyn_workorderresourcerestriction_createdby](systemuser.md#BKMK_lk_msdyn_workorderresourcerestriction_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderresourcerestriction_createdonbehalfby"></a> lk_msdyn_workorderresourcerestriction_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_workorderresourcerestriction_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderresourcerestriction_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderresourcerestriction_modifiedby"></a> lk_msdyn_workorderresourcerestriction_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_workorderresourcerestriction_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderresourcerestriction_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderresourcerestriction_modifiedonbehalfby"></a> lk_msdyn_workorderresourcerestriction_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_workorderresourcerestriction_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderresourcerestriction_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_account_msdyn_workorderresourcerestriction_Account"></a> msdyn_account_msdyn_workorderresourcerestriction_Account

One-To-Many Relationship: [account msdyn_account_msdyn_workorderresourcerestriction_Account](account.md#BKMK_msdyn_account_msdyn_workorderresourcerestriction_Account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_account`|
|ReferencingEntityNavigationPropertyName|`msdyn_Account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource"></a> msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource

One-To-Many Relationship: [bookableresource msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`msdyn_resource`|
|ReferencingEntityNavigationPropertyName|`msdyn_resource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder

One-To-Many Relationship: [msdyn_workorder msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderresourcerestriction_WorkOrder)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_workorderresourcerestriction"></a> owner_msdyn_workorderresourcerestriction

One-To-Many Relationship: [owner owner_msdyn_workorderresourcerestriction](owner.md#BKMK_owner_msdyn_workorderresourcerestriction)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_workorderresourcerestriction"></a> team_msdyn_workorderresourcerestriction

One-To-Many Relationship: [team team_msdyn_workorderresourcerestriction](team.md#BKMK_team_msdyn_workorderresourcerestriction)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_workorderresourcerestriction"></a> user_msdyn_workorderresourcerestriction

One-To-Many Relationship: [systemuser user_msdyn_workorderresourcerestriction](systemuser.md#BKMK_user_msdyn_workorderresourcerestriction)

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

- [msdyn_workorderresourcerestriction_ActivityPointers](#BKMK_msdyn_workorderresourcerestriction_ActivityPointers)
- [msdyn_workorderresourcerestriction_adx_inviteredemptions](#BKMK_msdyn_workorderresourcerestriction_adx_inviteredemptions)
- [msdyn_workorderresourcerestriction_adx_portalcomments](#BKMK_msdyn_workorderresourcerestriction_adx_portalcomments)
- [msdyn_workorderresourcerestriction_Annotations](#BKMK_msdyn_workorderresourcerestriction_Annotations)
- [msdyn_workorderresourcerestriction_Appointments](#BKMK_msdyn_workorderresourcerestriction_Appointments)
- [msdyn_workorderresourcerestriction_AsyncOperations](#BKMK_msdyn_workorderresourcerestriction_AsyncOperations)
- [msdyn_workorderresourcerestriction_BulkDeleteFailures](#BKMK_msdyn_workorderresourcerestriction_BulkDeleteFailures)
- [msdyn_workorderresourcerestriction_chats](#BKMK_msdyn_workorderresourcerestriction_chats)
- [msdyn_workorderresourcerestriction_connections1](#BKMK_msdyn_workorderresourcerestriction_connections1)
- [msdyn_workorderresourcerestriction_connections2](#BKMK_msdyn_workorderresourcerestriction_connections2)
- [msdyn_workorderresourcerestriction_DuplicateBaseRecord](#BKMK_msdyn_workorderresourcerestriction_DuplicateBaseRecord)
- [msdyn_workorderresourcerestriction_DuplicateMatchingRecord](#BKMK_msdyn_workorderresourcerestriction_DuplicateMatchingRecord)
- [msdyn_workorderresourcerestriction_Emails](#BKMK_msdyn_workorderresourcerestriction_Emails)
- [msdyn_workorderresourcerestriction_Faxes](#BKMK_msdyn_workorderresourcerestriction_Faxes)
- [msdyn_workorderresourcerestriction_Letters](#BKMK_msdyn_workorderresourcerestriction_Letters)
- [msdyn_workorderresourcerestriction_MailboxTrackingFolders](#BKMK_msdyn_workorderresourcerestriction_MailboxTrackingFolders)
- [msdyn_workorderresourcerestriction_msdyn_bookingalerts](#BKMK_msdyn_workorderresourcerestriction_msdyn_bookingalerts)
- [msdyn_workorderresourcerestriction_msdyn_copilottranscripts](#BKMK_msdyn_workorderresourcerestriction_msdyn_copilottranscripts)
- [msdyn_workorderresourcerestriction_msdyn_ocliveworkitems](#BKMK_msdyn_workorderresourcerestriction_msdyn_ocliveworkitems)
- [msdyn_workorderresourcerestriction_msdyn_ocsessions](#BKMK_msdyn_workorderresourcerestriction_msdyn_ocsessions)
- [msdyn_workorderresourcerestriction_msfp_alerts](#BKMK_msdyn_workorderresourcerestriction_msfp_alerts)
- [msdyn_workorderresourcerestriction_msfp_surveyinvites](#BKMK_msdyn_workorderresourcerestriction_msfp_surveyinvites)
- [msdyn_workorderresourcerestriction_msfp_surveyresponses](#BKMK_msdyn_workorderresourcerestriction_msfp_surveyresponses)
- [msdyn_workorderresourcerestriction_PhoneCalls](#BKMK_msdyn_workorderresourcerestriction_PhoneCalls)
- [msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses)
- [msdyn_workorderresourcerestriction_ProcessSession](#BKMK_msdyn_workorderresourcerestriction_ProcessSession)
- [msdyn_workorderresourcerestriction_RecurringAppointmentMasters](#BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters)
- [msdyn_workorderresourcerestriction_ServiceAppointments](#BKMK_msdyn_workorderresourcerestriction_ServiceAppointments)
- [msdyn_workorderresourcerestriction_SocialActivities](#BKMK_msdyn_workorderresourcerestriction_SocialActivities)
- [msdyn_workorderresourcerestriction_SyncErrors](#BKMK_msdyn_workorderresourcerestriction_SyncErrors)
- [msdyn_workorderresourcerestriction_Tasks](#BKMK_msdyn_workorderresourcerestriction_Tasks)

### <a name="BKMK_msdyn_workorderresourcerestriction_ActivityPointers"></a> msdyn_workorderresourcerestriction_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_workorderresourcerestriction_ActivityPointers](activitypointer.md#BKMK_msdyn_workorderresourcerestriction_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_adx_inviteredemptions"></a> msdyn_workorderresourcerestriction_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_workorderresourcerestriction_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_workorderresourcerestriction_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_adx_portalcomments"></a> msdyn_workorderresourcerestriction_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_workorderresourcerestriction_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_workorderresourcerestriction_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Annotations"></a> msdyn_workorderresourcerestriction_Annotations

Many-To-One Relationship: [annotation msdyn_workorderresourcerestriction_Annotations](annotation.md#BKMK_msdyn_workorderresourcerestriction_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Appointments"></a> msdyn_workorderresourcerestriction_Appointments

Many-To-One Relationship: [appointment msdyn_workorderresourcerestriction_Appointments](appointment.md#BKMK_msdyn_workorderresourcerestriction_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_AsyncOperations"></a> msdyn_workorderresourcerestriction_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_workorderresourcerestriction_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderresourcerestriction_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_BulkDeleteFailures"></a> msdyn_workorderresourcerestriction_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_workorderresourcerestriction_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderresourcerestriction_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_chats"></a> msdyn_workorderresourcerestriction_chats

Many-To-One Relationship: [chat msdyn_workorderresourcerestriction_chats](chat.md#BKMK_msdyn_workorderresourcerestriction_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_connections1"></a> msdyn_workorderresourcerestriction_connections1

Many-To-One Relationship: [connection msdyn_workorderresourcerestriction_connections1](connection.md#BKMK_msdyn_workorderresourcerestriction_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_connections2"></a> msdyn_workorderresourcerestriction_connections2

Many-To-One Relationship: [connection msdyn_workorderresourcerestriction_connections2](connection.md#BKMK_msdyn_workorderresourcerestriction_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_DuplicateBaseRecord"></a> msdyn_workorderresourcerestriction_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_workorderresourcerestriction_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workorderresourcerestriction_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_DuplicateMatchingRecord"></a> msdyn_workorderresourcerestriction_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_workorderresourcerestriction_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workorderresourcerestriction_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Emails"></a> msdyn_workorderresourcerestriction_Emails

Many-To-One Relationship: [email msdyn_workorderresourcerestriction_Emails](email.md#BKMK_msdyn_workorderresourcerestriction_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Faxes"></a> msdyn_workorderresourcerestriction_Faxes

Many-To-One Relationship: [fax msdyn_workorderresourcerestriction_Faxes](fax.md#BKMK_msdyn_workorderresourcerestriction_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Letters"></a> msdyn_workorderresourcerestriction_Letters

Many-To-One Relationship: [letter msdyn_workorderresourcerestriction_Letters](letter.md#BKMK_msdyn_workorderresourcerestriction_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_MailboxTrackingFolders"></a> msdyn_workorderresourcerestriction_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_workorderresourcerestriction_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderresourcerestriction_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msdyn_bookingalerts"></a> msdyn_workorderresourcerestriction_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_workorderresourcerestriction_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorderresourcerestriction_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msdyn_copilottranscripts"></a> msdyn_workorderresourcerestriction_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_workorderresourcerestriction_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_workorderresourcerestriction_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msdyn_ocliveworkitems"></a> msdyn_workorderresourcerestriction_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_workorderresourcerestriction_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_workorderresourcerestriction_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msdyn_ocsessions"></a> msdyn_workorderresourcerestriction_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_workorderresourcerestriction_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_workorderresourcerestriction_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msfp_alerts"></a> msdyn_workorderresourcerestriction_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_workorderresourcerestriction_msfp_alerts](msfp_alert.md#BKMK_msdyn_workorderresourcerestriction_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msfp_surveyinvites"></a> msdyn_workorderresourcerestriction_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_workorderresourcerestriction_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_workorderresourcerestriction_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_msfp_surveyresponses"></a> msdyn_workorderresourcerestriction_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_workorderresourcerestriction_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_workorderresourcerestriction_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_PhoneCalls"></a> msdyn_workorderresourcerestriction_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_workorderresourcerestriction_PhoneCalls](phonecall.md#BKMK_msdyn_workorderresourcerestriction_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses"></a> msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_ProcessSession"></a> msdyn_workorderresourcerestriction_ProcessSession

Many-To-One Relationship: [processsession msdyn_workorderresourcerestriction_ProcessSession](processsession.md#BKMK_msdyn_workorderresourcerestriction_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters"></a> msdyn_workorderresourcerestriction_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_workorderresourcerestriction_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorderresourcerestriction_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_ServiceAppointments"></a> msdyn_workorderresourcerestriction_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_workorderresourcerestriction_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorderresourcerestriction_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_SocialActivities"></a> msdyn_workorderresourcerestriction_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_workorderresourcerestriction_SocialActivities](socialactivity.md#BKMK_msdyn_workorderresourcerestriction_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_SyncErrors"></a> msdyn_workorderresourcerestriction_SyncErrors

Many-To-One Relationship: [syncerror msdyn_workorderresourcerestriction_SyncErrors](syncerror.md#BKMK_msdyn_workorderresourcerestriction_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderresourcerestriction_Tasks"></a> msdyn_workorderresourcerestriction_Tasks

Many-To-One Relationship: [task msdyn_workorderresourcerestriction_Tasks](task.md#BKMK_msdyn_workorderresourcerestriction_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderresourcerestriction_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

