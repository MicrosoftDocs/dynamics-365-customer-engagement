---
title: "Work Order Characteristic (Deprecated) (msdyn_workordercharacteristic) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Work Order Characteristic (Deprecated) (msdyn_workordercharacteristic) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Work Order Characteristic (Deprecated) (msdyn_workordercharacteristic) table/entity reference

This entity is deprecated.

## Messages

The following table lists the messages for the Work Order Characteristic (Deprecated) (msdyn_workordercharacteristic) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_workordercharacteristics(*msdyn_workordercharacteristicid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_workordercharacteristics<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_workordercharacteristics(*msdyn_workordercharacteristicid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_workordercharacteristics(*msdyn_workordercharacteristicid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_workordercharacteristics<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_workordercharacteristics(*msdyn_workordercharacteristicid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_workordercharacteristics(*msdyn_workordercharacteristicid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_workordercharacteristics(*msdyn_workordercharacteristicid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Work Order Characteristic (Deprecated) (msdyn_workordercharacteristic) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Work Order Characteristic (Deprecated) (msdyn_workordercharacteristic) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Work Order Characteristic (Deprecated)** |
| **DisplayCollectionName** | **Work Order Characteristics (Deprecated)** |
| **SchemaName** | `msdyn_workordercharacteristic` |
| **CollectionSchemaName** | `msdyn_workordercharacteristics` |
| **EntitySetName** | `msdyn_workordercharacteristics`|
| **LogicalName** | `msdyn_workordercharacteristic` |
| **LogicalCollectionName** | `msdyn_workordercharacteristics` |
| **PrimaryIdAttribute** | `msdyn_workordercharacteristicid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Characteristic](#BKMK_msdyn_Characteristic)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_RatingValue](#BKMK_msdyn_RatingValue)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [msdyn_workordercharacteristicId](#BKMK_msdyn_workordercharacteristicId)
- [msdyn_WorkOrderIncident](#BKMK_msdyn_WorkOrderIncident)
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

### <a name="BKMK_msdyn_Characteristic"></a> msdyn_Characteristic

|Property|Value|
|---|---|
|Description|**Specify the characteristic required for this work order and incident.**|
|DisplayName|**Characteristic**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_characteristic`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|characteristic|

### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Internal Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internalflags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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

### <a name="BKMK_msdyn_RatingValue"></a> msdyn_RatingValue

|Property|Value|
|---|---|
|Description|**Specify the rating value required for this work order and incident.**|
|DisplayName|**Rating Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ratingvalue`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|ratingvalue|

### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorder`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_workorder|

### <a name="BKMK_msdyn_workordercharacteristicId"></a> msdyn_workordercharacteristicId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Work Order Characteristic**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_workordercharacteristicid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_WorkOrderIncident"></a> msdyn_WorkOrderIncident

|Property|Value|
|---|---|
|Description|**Incident related to this Skill Type**|
|DisplayName|**Work Order Incident**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderincident`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|msdyn_workorderincident|

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
|Description|**Status of the Work Order Characteristic**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_workordercharacteristic_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Work Order Characteristic**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_workordercharacteristic_statuscode`|

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

- [business_unit_msdyn_workordercharacteristic](#BKMK_business_unit_msdyn_workordercharacteristic)
- [lk_msdyn_workordercharacteristic_createdby](#BKMK_lk_msdyn_workordercharacteristic_createdby)
- [lk_msdyn_workordercharacteristic_createdonbehalfby](#BKMK_lk_msdyn_workordercharacteristic_createdonbehalfby)
- [lk_msdyn_workordercharacteristic_modifiedby](#BKMK_lk_msdyn_workordercharacteristic_modifiedby)
- [lk_msdyn_workordercharacteristic_modifiedonbehalfby](#BKMK_lk_msdyn_workordercharacteristic_modifiedonbehalfby)
- [msdyn_characteristic_msdyn_workordercharacteristic_Characteristic](#BKMK_msdyn_characteristic_msdyn_workordercharacteristic_Characteristic)
- [msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder)
- [msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident)
- [msdyn_ratingvalue_msdyn_workordercharacteristic_RatingValue](#BKMK_msdyn_ratingvalue_msdyn_workordercharacteristic_RatingValue)
- [owner_msdyn_workordercharacteristic](#BKMK_owner_msdyn_workordercharacteristic)
- [team_msdyn_workordercharacteristic](#BKMK_team_msdyn_workordercharacteristic)
- [user_msdyn_workordercharacteristic](#BKMK_user_msdyn_workordercharacteristic)

### <a name="BKMK_business_unit_msdyn_workordercharacteristic"></a> business_unit_msdyn_workordercharacteristic

One-To-Many Relationship: [businessunit business_unit_msdyn_workordercharacteristic](businessunit.md#BKMK_business_unit_msdyn_workordercharacteristic)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workordercharacteristic_createdby"></a> lk_msdyn_workordercharacteristic_createdby

One-To-Many Relationship: [systemuser lk_msdyn_workordercharacteristic_createdby](systemuser.md#BKMK_lk_msdyn_workordercharacteristic_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workordercharacteristic_createdonbehalfby"></a> lk_msdyn_workordercharacteristic_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_workordercharacteristic_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workordercharacteristic_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workordercharacteristic_modifiedby"></a> lk_msdyn_workordercharacteristic_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_workordercharacteristic_modifiedby](systemuser.md#BKMK_lk_msdyn_workordercharacteristic_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workordercharacteristic_modifiedonbehalfby"></a> lk_msdyn_workordercharacteristic_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_workordercharacteristic_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workordercharacteristic_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_characteristic_msdyn_workordercharacteristic_Characteristic"></a> msdyn_characteristic_msdyn_workordercharacteristic_Characteristic

One-To-Many Relationship: [characteristic msdyn_characteristic_msdyn_workordercharacteristic_Characteristic](characteristic.md#BKMK_msdyn_characteristic_msdyn_workordercharacteristic_Characteristic)

|Property|Value|
|---|---|
|ReferencedEntity|`characteristic`|
|ReferencedAttribute|`characteristicid`|
|ReferencingAttribute|`msdyn_characteristic`|
|ReferencingEntityNavigationPropertyName|`msdyn_characteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder

One-To-Many Relationship: [msdyn_workorder msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workordercharacteristic_WorkOrder)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident

One-To-Many Relationship: [msdyn_workorderincident msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident](msdyn_workorderincident.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`msdyn_workorderincident`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ratingvalue_msdyn_workordercharacteristic_RatingValue"></a> msdyn_ratingvalue_msdyn_workordercharacteristic_RatingValue

One-To-Many Relationship: [ratingvalue msdyn_ratingvalue_msdyn_workordercharacteristic_RatingValue](ratingvalue.md#BKMK_msdyn_ratingvalue_msdyn_workordercharacteristic_RatingValue)

|Property|Value|
|---|---|
|ReferencedEntity|`ratingvalue`|
|ReferencedAttribute|`ratingvalueid`|
|ReferencingAttribute|`msdyn_ratingvalue`|
|ReferencingEntityNavigationPropertyName|`msdyn_ratingvalue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_workordercharacteristic"></a> owner_msdyn_workordercharacteristic

One-To-Many Relationship: [owner owner_msdyn_workordercharacteristic](owner.md#BKMK_owner_msdyn_workordercharacteristic)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_workordercharacteristic"></a> team_msdyn_workordercharacteristic

One-To-Many Relationship: [team team_msdyn_workordercharacteristic](team.md#BKMK_team_msdyn_workordercharacteristic)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_workordercharacteristic"></a> user_msdyn_workordercharacteristic

One-To-Many Relationship: [systemuser user_msdyn_workordercharacteristic](systemuser.md#BKMK_user_msdyn_workordercharacteristic)

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

- [msdyn_workordercharacteristic_ActivityPointers](#BKMK_msdyn_workordercharacteristic_ActivityPointers)
- [msdyn_workordercharacteristic_adx_inviteredemptions](#BKMK_msdyn_workordercharacteristic_adx_inviteredemptions)
- [msdyn_workordercharacteristic_adx_portalcomments](#BKMK_msdyn_workordercharacteristic_adx_portalcomments)
- [msdyn_workordercharacteristic_Annotations](#BKMK_msdyn_workordercharacteristic_Annotations)
- [msdyn_workordercharacteristic_Appointments](#BKMK_msdyn_workordercharacteristic_Appointments)
- [msdyn_workordercharacteristic_AsyncOperations](#BKMK_msdyn_workordercharacteristic_AsyncOperations)
- [msdyn_workordercharacteristic_BulkDeleteFailures](#BKMK_msdyn_workordercharacteristic_BulkDeleteFailures)
- [msdyn_workordercharacteristic_chats](#BKMK_msdyn_workordercharacteristic_chats)
- [msdyn_workordercharacteristic_connections1](#BKMK_msdyn_workordercharacteristic_connections1)
- [msdyn_workordercharacteristic_connections2](#BKMK_msdyn_workordercharacteristic_connections2)
- [msdyn_workordercharacteristic_DuplicateBaseRecord](#BKMK_msdyn_workordercharacteristic_DuplicateBaseRecord)
- [msdyn_workordercharacteristic_DuplicateMatchingRecord](#BKMK_msdyn_workordercharacteristic_DuplicateMatchingRecord)
- [msdyn_workordercharacteristic_Emails](#BKMK_msdyn_workordercharacteristic_Emails)
- [msdyn_workordercharacteristic_Faxes](#BKMK_msdyn_workordercharacteristic_Faxes)
- [msdyn_workordercharacteristic_Letters](#BKMK_msdyn_workordercharacteristic_Letters)
- [msdyn_workordercharacteristic_MailboxTrackingFolders](#BKMK_msdyn_workordercharacteristic_MailboxTrackingFolders)
- [msdyn_workordercharacteristic_msdyn_bookingalerts](#BKMK_msdyn_workordercharacteristic_msdyn_bookingalerts)
- [msdyn_workordercharacteristic_msdyn_copilottranscripts](#BKMK_msdyn_workordercharacteristic_msdyn_copilottranscripts)
- [msdyn_workordercharacteristic_msdyn_ocliveworkitems](#BKMK_msdyn_workordercharacteristic_msdyn_ocliveworkitems)
- [msdyn_workordercharacteristic_msdyn_ocsessions](#BKMK_msdyn_workordercharacteristic_msdyn_ocsessions)
- [msdyn_workordercharacteristic_msfp_alerts](#BKMK_msdyn_workordercharacteristic_msfp_alerts)
- [msdyn_workordercharacteristic_msfp_surveyinvites](#BKMK_msdyn_workordercharacteristic_msfp_surveyinvites)
- [msdyn_workordercharacteristic_msfp_surveyresponses](#BKMK_msdyn_workordercharacteristic_msfp_surveyresponses)
- [msdyn_workordercharacteristic_PhoneCalls](#BKMK_msdyn_workordercharacteristic_PhoneCalls)
- [msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses)
- [msdyn_workordercharacteristic_ProcessSession](#BKMK_msdyn_workordercharacteristic_ProcessSession)
- [msdyn_workordercharacteristic_RecurringAppointmentMasters](#BKMK_msdyn_workordercharacteristic_RecurringAppointmentMasters)
- [msdyn_workordercharacteristic_ServiceAppointments](#BKMK_msdyn_workordercharacteristic_ServiceAppointments)
- [msdyn_workordercharacteristic_SocialActivities](#BKMK_msdyn_workordercharacteristic_SocialActivities)
- [msdyn_workordercharacteristic_SyncErrors](#BKMK_msdyn_workordercharacteristic_SyncErrors)
- [msdyn_workordercharacteristic_Tasks](#BKMK_msdyn_workordercharacteristic_Tasks)

### <a name="BKMK_msdyn_workordercharacteristic_ActivityPointers"></a> msdyn_workordercharacteristic_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_workordercharacteristic_ActivityPointers](activitypointer.md#BKMK_msdyn_workordercharacteristic_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_adx_inviteredemptions"></a> msdyn_workordercharacteristic_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_workordercharacteristic_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_workordercharacteristic_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_adx_portalcomments"></a> msdyn_workordercharacteristic_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_workordercharacteristic_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_workordercharacteristic_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_Annotations"></a> msdyn_workordercharacteristic_Annotations

Many-To-One Relationship: [annotation msdyn_workordercharacteristic_Annotations](annotation.md#BKMK_msdyn_workordercharacteristic_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_Appointments"></a> msdyn_workordercharacteristic_Appointments

Many-To-One Relationship: [appointment msdyn_workordercharacteristic_Appointments](appointment.md#BKMK_msdyn_workordercharacteristic_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_AsyncOperations"></a> msdyn_workordercharacteristic_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_workordercharacteristic_AsyncOperations](asyncoperation.md#BKMK_msdyn_workordercharacteristic_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_BulkDeleteFailures"></a> msdyn_workordercharacteristic_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_workordercharacteristic_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workordercharacteristic_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_chats"></a> msdyn_workordercharacteristic_chats

Many-To-One Relationship: [chat msdyn_workordercharacteristic_chats](chat.md#BKMK_msdyn_workordercharacteristic_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_connections1"></a> msdyn_workordercharacteristic_connections1

Many-To-One Relationship: [connection msdyn_workordercharacteristic_connections1](connection.md#BKMK_msdyn_workordercharacteristic_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_connections2"></a> msdyn_workordercharacteristic_connections2

Many-To-One Relationship: [connection msdyn_workordercharacteristic_connections2](connection.md#BKMK_msdyn_workordercharacteristic_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_DuplicateBaseRecord"></a> msdyn_workordercharacteristic_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_workordercharacteristic_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workordercharacteristic_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_DuplicateMatchingRecord"></a> msdyn_workordercharacteristic_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_workordercharacteristic_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workordercharacteristic_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_Emails"></a> msdyn_workordercharacteristic_Emails

Many-To-One Relationship: [email msdyn_workordercharacteristic_Emails](email.md#BKMK_msdyn_workordercharacteristic_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_Faxes"></a> msdyn_workordercharacteristic_Faxes

Many-To-One Relationship: [fax msdyn_workordercharacteristic_Faxes](fax.md#BKMK_msdyn_workordercharacteristic_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_Letters"></a> msdyn_workordercharacteristic_Letters

Many-To-One Relationship: [letter msdyn_workordercharacteristic_Letters](letter.md#BKMK_msdyn_workordercharacteristic_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_MailboxTrackingFolders"></a> msdyn_workordercharacteristic_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_workordercharacteristic_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workordercharacteristic_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_msdyn_bookingalerts"></a> msdyn_workordercharacteristic_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_workordercharacteristic_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workordercharacteristic_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_msdyn_copilottranscripts"></a> msdyn_workordercharacteristic_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_workordercharacteristic_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_workordercharacteristic_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_msdyn_ocliveworkitems"></a> msdyn_workordercharacteristic_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_workordercharacteristic_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_workordercharacteristic_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_msdyn_ocsessions"></a> msdyn_workordercharacteristic_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_workordercharacteristic_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_workordercharacteristic_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_msfp_alerts"></a> msdyn_workordercharacteristic_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_workordercharacteristic_msfp_alerts](msfp_alert.md#BKMK_msdyn_workordercharacteristic_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_msfp_surveyinvites"></a> msdyn_workordercharacteristic_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_workordercharacteristic_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_workordercharacteristic_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_msfp_surveyresponses"></a> msdyn_workordercharacteristic_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_workordercharacteristic_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_workordercharacteristic_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_PhoneCalls"></a> msdyn_workordercharacteristic_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_workordercharacteristic_PhoneCalls](phonecall.md#BKMK_msdyn_workordercharacteristic_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses"></a> msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_ProcessSession"></a> msdyn_workordercharacteristic_ProcessSession

Many-To-One Relationship: [processsession msdyn_workordercharacteristic_ProcessSession](processsession.md#BKMK_msdyn_workordercharacteristic_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_RecurringAppointmentMasters"></a> msdyn_workordercharacteristic_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_workordercharacteristic_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workordercharacteristic_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_ServiceAppointments"></a> msdyn_workordercharacteristic_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_workordercharacteristic_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workordercharacteristic_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_SocialActivities"></a> msdyn_workordercharacteristic_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_workordercharacteristic_SocialActivities](socialactivity.md#BKMK_msdyn_workordercharacteristic_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_SyncErrors"></a> msdyn_workordercharacteristic_SyncErrors

Many-To-One Relationship: [syncerror msdyn_workordercharacteristic_SyncErrors](syncerror.md#BKMK_msdyn_workordercharacteristic_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workordercharacteristic_Tasks"></a> msdyn_workordercharacteristic_Tasks

Many-To-One Relationship: [task msdyn_workordercharacteristic_Tasks](task.md#BKMK_msdyn_workordercharacteristic_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workordercharacteristic_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

