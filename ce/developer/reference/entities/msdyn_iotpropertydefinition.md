---
title: "IoT Property Definition (msdyn_iotpropertydefinition) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the IoT Property Definition (msdyn_iotpropertydefinition) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# IoT Property Definition (msdyn_iotpropertydefinition) table/entity reference (Microsoft Dynamics 365)

Defines a device property or a parameter that can be used for one or more command definitions.

## Messages

The following table lists the messages for the IoT Property Definition (msdyn_iotpropertydefinition) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_iotpropertydefinitions(*msdyn_iotpropertydefinitionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_iotpropertydefinitions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_iotpropertydefinitions(*msdyn_iotpropertydefinitionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_iotpropertydefinitions(*msdyn_iotpropertydefinitionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_iotpropertydefinitions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_iotpropertydefinitions(*msdyn_iotpropertydefinitionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_iotpropertydefinitions(*msdyn_iotpropertydefinitionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_iotpropertydefinitions(*msdyn_iotpropertydefinitionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the IoT Property Definition (msdyn_iotpropertydefinition) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **IoT Property Definition** |
| **DisplayCollectionName** | **IoT Property Definitions** |
| **SchemaName** | `msdyn_iotpropertydefinition` |
| **CollectionSchemaName** | `msdyn_iotpropertydefinitions` |
| **EntitySetName** | `msdyn_iotpropertydefinitions`|
| **LogicalName** | `msdyn_iotpropertydefinition` |
| **LogicalCollectionName** | `msdyn_iotpropertydefinitions` |
| **PrimaryIdAttribute** | `msdyn_iotpropertydefinitionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AdditionalProperties](#BKMK_msdyn_AdditionalProperties)
- [msdyn_Editable](#BKMK_msdyn_Editable)
- [msdyn_iotpropertydefinitionId](#BKMK_msdyn_iotpropertydefinitionId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ParentProperty](#BKMK_msdyn_ParentProperty)
- [msdyn_Type](#BKMK_msdyn_Type)
- [msdyn_unit](#BKMK_msdyn_unit)
- [msdyn_Visible](#BKMK_msdyn_Visible)
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
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_AdditionalProperties"></a> msdyn_AdditionalProperties

|Property|Value|
|---|---|
|Description||
|DisplayName|**Additional Properties**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_additionalproperties`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_Editable"></a> msdyn_Editable

|Property|Value|
|---|---|
|Description||
|DisplayName|**Editable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_editable`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_iotpropertydefinition_msdyn_editable`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_iotpropertydefinitionId"></a> msdyn_iotpropertydefinitionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**IoT Property Definition**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_iotpropertydefinitionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msdyn_ParentProperty"></a> msdyn_ParentProperty

|Property|Value|
|---|---|
|Description|**Refers to the parent property when building a nested property.**|
|DisplayName|**Parent Property**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentproperty`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotpropertydefinition|

### <a name="BKMK_msdyn_Type"></a> msdyn_Type

|Property|Value|
|---|---|
|Description|**The data type of the parameter.**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_iotpropertydefinition_msdyn_type`|

#### msdyn_Type Choices/Options

|Value|Label|
|---|---|
|192350000|**String**|
|192350001|**Object**|
|192350002|**Date and Time**|
|192350003|**Boolean**|
|192350004|**Whole Number**|
|192350005|**Decimal Number**|

### <a name="BKMK_msdyn_unit"></a> msdyn_unit

|Property|Value|
|---|---|
|Description|**Unit String for property definition**|
|DisplayName|**Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unit`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Visible"></a> msdyn_Visible

|Property|Value|
|---|---|
|Description||
|DisplayName|**Visible**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_visible`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_iotpropertydefinition_msdyn_visible`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
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
|Description|**Status of the IoT Property Definition**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iotpropertydefinition_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the IoT Property Definition**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iotpropertydefinition_statuscode`|

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
|Description|**Time zone code that was in use when the record was created.**|
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
|Description|**Date and time when the record was created.**|
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
|Description|**Unique identifier of the delegate user who created the record.**|
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
|Description|**Date and time when the record was modified.**|
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
|Description|**Unique identifier of the delegate user who modified the record.**|
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

- [business_unit_msdyn_iotpropertydefinition](#BKMK_business_unit_msdyn_iotpropertydefinition)
- [lk_msdyn_iotpropertydefinition_createdby](#BKMK_lk_msdyn_iotpropertydefinition_createdby)
- [lk_msdyn_iotpropertydefinition_createdonbehalfby](#BKMK_lk_msdyn_iotpropertydefinition_createdonbehalfby)
- [lk_msdyn_iotpropertydefinition_modifiedby](#BKMK_lk_msdyn_iotpropertydefinition_modifiedby)
- [lk_msdyn_iotpropertydefinition_modifiedonbehalfby](#BKMK_lk_msdyn_iotpropertydefinition_modifiedonbehalfby)
- [msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter](#BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter-many-to-one)
- [owner_msdyn_iotpropertydefinition](#BKMK_owner_msdyn_iotpropertydefinition)
- [team_msdyn_iotpropertydefinition](#BKMK_team_msdyn_iotpropertydefinition)
- [user_msdyn_iotpropertydefinition](#BKMK_user_msdyn_iotpropertydefinition)

### <a name="BKMK_business_unit_msdyn_iotpropertydefinition"></a> business_unit_msdyn_iotpropertydefinition

One-To-Many Relationship: [businessunit business_unit_msdyn_iotpropertydefinition](businessunit.md#BKMK_business_unit_msdyn_iotpropertydefinition)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotpropertydefinition_createdby"></a> lk_msdyn_iotpropertydefinition_createdby

One-To-Many Relationship: [systemuser lk_msdyn_iotpropertydefinition_createdby](systemuser.md#BKMK_lk_msdyn_iotpropertydefinition_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotpropertydefinition_createdonbehalfby"></a> lk_msdyn_iotpropertydefinition_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iotpropertydefinition_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_iotpropertydefinition_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotpropertydefinition_modifiedby"></a> lk_msdyn_iotpropertydefinition_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_iotpropertydefinition_modifiedby](systemuser.md#BKMK_lk_msdyn_iotpropertydefinition_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotpropertydefinition_modifiedonbehalfby"></a> lk_msdyn_iotpropertydefinition_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iotpropertydefinition_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_iotpropertydefinition_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter-many-to-one"></a> msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter

One-To-Many Relationship: [msdyn_iotpropertydefinition msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter](#BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotpropertydefinition`|
|ReferencedAttribute|`msdyn_iotpropertydefinitionid`|
|ReferencingAttribute|`msdyn_parentproperty`|
|ReferencingEntityNavigationPropertyName|`msdyn_ParentProperty`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_iotpropertydefinition"></a> owner_msdyn_iotpropertydefinition

One-To-Many Relationship: [owner owner_msdyn_iotpropertydefinition](owner.md#BKMK_owner_msdyn_iotpropertydefinition)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_iotpropertydefinition"></a> team_msdyn_iotpropertydefinition

One-To-Many Relationship: [team team_msdyn_iotpropertydefinition](team.md#BKMK_team_msdyn_iotpropertydefinition)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_iotpropertydefinition"></a> user_msdyn_iotpropertydefinition

One-To-Many Relationship: [systemuser user_msdyn_iotpropertydefinition](systemuser.md#BKMK_user_msdyn_iotpropertydefinition)

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

- [msdyn_iotdevicevisualizationconfiguration_measurement](#BKMK_msdyn_iotdevicevisualizationconfiguration_measurement)
- [msdyn_iotpropertydefinition_AsyncOperations](#BKMK_msdyn_iotpropertydefinition_AsyncOperations)
- [msdyn_iotpropertydefinition_BulkDeleteFailures](#BKMK_msdyn_iotpropertydefinition_BulkDeleteFailures)
- [msdyn_iotpropertydefinition_DuplicateBaseRecord](#BKMK_msdyn_iotpropertydefinition_DuplicateBaseRecord)
- [msdyn_iotpropertydefinition_DuplicateMatchingRecord](#BKMK_msdyn_iotpropertydefinition_DuplicateMatchingRecord)
- [msdyn_iotpropertydefinition_MailboxTrackingFolders](#BKMK_msdyn_iotpropertydefinition_MailboxTrackingFolders)
- [msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses)
- [msdyn_iotpropertydefinition_ProcessSession](#BKMK_msdyn_iotpropertydefinition_ProcessSession)
- [msdyn_iotpropertydefinition_SyncErrors](#BKMK_msdyn_iotpropertydefinition_SyncErrors)
- [msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property](#BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property)
- [msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter](#BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter-one-to-many)

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_measurement"></a> msdyn_iotdevicevisualizationconfiguration_measurement

Many-To-One Relationship: [msdyn_iotdevicevisualizationconfiguration msdyn_iotdevicevisualizationconfiguration_measurement](msdyn_iotdevicevisualizationconfiguration.md#BKMK_msdyn_iotdevicevisualizationconfiguration_measurement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicevisualizationconfiguration`|
|ReferencingAttribute|`msdyn_measurement`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicevisualizationconfiguration_measurement`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotpropertydefinition_AsyncOperations"></a> msdyn_iotpropertydefinition_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_iotpropertydefinition_AsyncOperations](asyncoperation.md#BKMK_msdyn_iotpropertydefinition_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotpropertydefinition_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotpropertydefinition_BulkDeleteFailures"></a> msdyn_iotpropertydefinition_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_iotpropertydefinition_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_iotpropertydefinition_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotpropertydefinition_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotpropertydefinition_DuplicateBaseRecord"></a> msdyn_iotpropertydefinition_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_iotpropertydefinition_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_iotpropertydefinition_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotpropertydefinition_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotpropertydefinition_DuplicateMatchingRecord"></a> msdyn_iotpropertydefinition_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_iotpropertydefinition_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_iotpropertydefinition_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotpropertydefinition_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotpropertydefinition_MailboxTrackingFolders"></a> msdyn_iotpropertydefinition_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_iotpropertydefinition_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_iotpropertydefinition_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotpropertydefinition_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses"></a> msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotpropertydefinition_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotpropertydefinition_ProcessSession"></a> msdyn_iotpropertydefinition_ProcessSession

Many-To-One Relationship: [processsession msdyn_iotpropertydefinition_ProcessSession](processsession.md#BKMK_msdyn_iotpropertydefinition_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotpropertydefinition_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotpropertydefinition_SyncErrors"></a> msdyn_iotpropertydefinition_SyncErrors

Many-To-One Relationship: [syncerror msdyn_iotpropertydefinition_SyncErrors](syncerror.md#BKMK_msdyn_iotpropertydefinition_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotpropertydefinition_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property"></a> msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property

Many-To-One Relationship: [msdyn_iotdeviceproperty msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property](msdyn_iotdeviceproperty.md#BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdeviceproperty`|
|ReferencingAttribute|`msdyn_property`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_iotpropertydefinition_msdyn_iotdeviceproperty_Property`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter-one-to-many"></a> msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter

Many-To-One Relationship: [msdyn_iotpropertydefinition msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter](#BKMK_msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotpropertydefinition`|
|ReferencingAttribute|`msdyn_parentproperty`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_iotpropertydefinition_msdyn_iotpropertydefinition_ParentParameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_iotdevicecommandparameters"></a> msdyn_iotdevicecommandparameters

See [msdyn_iotdevicecommanddefinition msdyn_iotdevicecommandparameters Many-To-Many Relationship](msdyn_iotdevicecommanddefinition.md#BKMK_msdyn_iotdevicecommandparameters)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_iotdevicecommandparameters`|
|IsCustomizable|True|
|SchemaName|`msdyn_iotdevicecommandparameters`|
|IntersectAttribute|`msdyn_iotpropertydefinitionid`|
|NavigationPropertyName|`msdyn_iotdevicecommandparameters`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

