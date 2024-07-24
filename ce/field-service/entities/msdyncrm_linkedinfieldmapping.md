---
title: "Field mapping (msdyncrm_linkedinfieldmapping) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Field mapping (msdyncrm_linkedinfieldmapping) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Field mapping (msdyncrm_linkedinfieldmapping) table/entity reference

Individual question on a LinkedIn form

## Messages

The following table lists the messages for the Field mapping (msdyncrm_linkedinfieldmapping) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_linkedinfieldmappings(*msdyncrm_linkedinfieldmappingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_linkedinfieldmappings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_linkedinfieldmappings(*msdyncrm_linkedinfieldmappingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_linkedinfieldmappings(*msdyncrm_linkedinfieldmappingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_linkedinfieldmappings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_linkedinfieldmappings(*msdyncrm_linkedinfieldmappingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_linkedinfieldmappings(*msdyncrm_linkedinfieldmappingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_linkedinfieldmappings(*msdyncrm_linkedinfieldmappingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Field mapping (msdyncrm_linkedinfieldmapping) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Field mapping (msdyncrm_linkedinfieldmapping) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Field mapping** |
| **DisplayCollectionName** | **Field mappings** |
| **SchemaName** | `msdyncrm_linkedinfieldmapping` |
| **CollectionSchemaName** | `msdyncrm_linkedinfieldmappings` |
| **EntitySetName** | `msdyncrm_linkedinfieldmappings`|
| **LogicalName** | `msdyncrm_linkedinfieldmapping` |
| **LogicalCollectionName** | `msdyncrm_linkedinfieldmappings` |
| **PrimaryIdAttribute** | `msdyncrm_linkedinfieldmappingid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_leadfield](#BKMK_msdyncrm_leadfield)
- [msdyncrm_leadfieldlookup](#BKMK_msdyncrm_leadfieldlookup)
- [msdyncrm_linkedinfieldmappingId](#BKMK_msdyncrm_linkedinfieldmappingId)
- [msdyncrm_LinkedInPredefinedField](#BKMK_msdyncrm_LinkedInPredefinedField)
- [msdyncrm_name](#BKMK_msdyncrm_name)
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

### <a name="BKMK_msdyncrm_leadfield"></a> msdyncrm_leadfield

|Property|Value|
|---|---|
|Description|**Dynamics 365 field the LinkedIn field maps to**|
|DisplayName|**Lead field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadfield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_leadfieldlookup"></a> msdyncrm_leadfieldlookup

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead Field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadfieldlookup`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_leadentityfield|

### <a name="BKMK_msdyncrm_linkedinfieldmappingId"></a> msdyncrm_linkedinfieldmappingId

|Property|Value|
|---|---|
|Description|**Unique identifier for this entity**|
|DisplayName|**Field mapping**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinfieldmappingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_LinkedInPredefinedField"></a> msdyncrm_LinkedInPredefinedField

|Property|Value|
|---|---|
|Description|**LinkedIn predefined field this question maps to**|
|DisplayName|**LinkedIn Predefined Field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinpredefinedfield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**Name of the LinkedIn form question**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|800|

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
|Description|**Status of the Field mapping**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_linkedinfieldmapping_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Field mapping**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_linkedinfieldmapping_statuscode`|

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
|Description|**Indicates the person who created this**|
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
|Description|**Date and time when the record was created**|
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
|Description|**Indicates the person who created this for another person**|
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
|Description|**Indicates the person who modified this**|
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
|Description|**Indicates the person who modified this for another person**|
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
|Description|**Indicates the business unit that owns this**|
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
|Description|**Indicates which team owns this**|
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
|Description|**Indicates the person who owns this**|
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

- [business_unit_msdyncrm_linkedinfieldmapping](#BKMK_business_unit_msdyncrm_linkedinfieldmapping)
- [lk_msdyncrm_linkedinfieldmapping_createdby](#BKMK_lk_msdyncrm_linkedinfieldmapping_createdby)
- [lk_msdyncrm_linkedinfieldmapping_createdonbehalfby](#BKMK_lk_msdyncrm_linkedinfieldmapping_createdonbehalfby)
- [lk_msdyncrm_linkedinfieldmapping_modifiedby](#BKMK_lk_msdyncrm_linkedinfieldmapping_modifiedby)
- [lk_msdyncrm_linkedinfieldmapping_modifiedonbehalfby](#BKMK_lk_msdyncrm_linkedinfieldmapping_modifiedonbehalfby)
- [msdyncrm_msdyncrm_leadentityfield_msdyncrm_linkedinfieldmapping_leadfieldlookup](#BKMK_msdyncrm_msdyncrm_leadentityfield_msdyncrm_linkedinfieldmapping_leadfieldlookup)
- [owner_msdyncrm_linkedinfieldmapping](#BKMK_owner_msdyncrm_linkedinfieldmapping)
- [team_msdyncrm_linkedinfieldmapping](#BKMK_team_msdyncrm_linkedinfieldmapping)
- [user_msdyncrm_linkedinfieldmapping](#BKMK_user_msdyncrm_linkedinfieldmapping)

### <a name="BKMK_business_unit_msdyncrm_linkedinfieldmapping"></a> business_unit_msdyncrm_linkedinfieldmapping

One-To-Many Relationship: [businessunit business_unit_msdyncrm_linkedinfieldmapping](businessunit.md#BKMK_business_unit_msdyncrm_linkedinfieldmapping)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinfieldmapping_createdby"></a> lk_msdyncrm_linkedinfieldmapping_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinfieldmapping_createdby](systemuser.md#BKMK_lk_msdyncrm_linkedinfieldmapping_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinfieldmapping_createdonbehalfby"></a> lk_msdyncrm_linkedinfieldmapping_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinfieldmapping_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_linkedinfieldmapping_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinfieldmapping_modifiedby"></a> lk_msdyncrm_linkedinfieldmapping_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinfieldmapping_modifiedby](systemuser.md#BKMK_lk_msdyncrm_linkedinfieldmapping_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinfieldmapping_modifiedonbehalfby"></a> lk_msdyncrm_linkedinfieldmapping_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinfieldmapping_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_linkedinfieldmapping_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_leadentityfield_msdyncrm_linkedinfieldmapping_leadfieldlookup"></a> msdyncrm_msdyncrm_leadentityfield_msdyncrm_linkedinfieldmapping_leadfieldlookup

One-To-Many Relationship: [msdyncrm_leadentityfield msdyncrm_msdyncrm_leadentityfield_msdyncrm_linkedinfieldmapping_leadfieldlookup](msdyncrm_leadentityfield.md#BKMK_msdyncrm_msdyncrm_leadentityfield_msdyncrm_linkedinfieldmapping_leadfieldlookup)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadentityfield`|
|ReferencedAttribute|`msdyncrm_leadentityfieldid`|
|ReferencingAttribute|`msdyncrm_leadfieldlookup`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_leadfieldlookup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_linkedinfieldmapping"></a> owner_msdyncrm_linkedinfieldmapping

One-To-Many Relationship: [owner owner_msdyncrm_linkedinfieldmapping](owner.md#BKMK_owner_msdyncrm_linkedinfieldmapping)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_linkedinfieldmapping"></a> team_msdyncrm_linkedinfieldmapping

One-To-Many Relationship: [team team_msdyncrm_linkedinfieldmapping](team.md#BKMK_team_msdyncrm_linkedinfieldmapping)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_linkedinfieldmapping"></a> user_msdyncrm_linkedinfieldmapping

One-To-Many Relationship: [systemuser user_msdyncrm_linkedinfieldmapping](systemuser.md#BKMK_user_msdyncrm_linkedinfieldmapping)

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

- [msdyncrm_linkedinfieldmapping_ActivityPointers](#BKMK_msdyncrm_linkedinfieldmapping_ActivityPointers)
- [msdyncrm_linkedinfieldmapping_adx_alertsubscriptions](#BKMK_msdyncrm_linkedinfieldmapping_adx_alertsubscriptions)
- [msdyncrm_linkedinfieldmapping_adx_inviteredemptions](#BKMK_msdyncrm_linkedinfieldmapping_adx_inviteredemptions)
- [msdyncrm_linkedinfieldmapping_adx_portalcomments](#BKMK_msdyncrm_linkedinfieldmapping_adx_portalcomments)
- [msdyncrm_linkedinfieldmapping_Annotations](#BKMK_msdyncrm_linkedinfieldmapping_Annotations)
- [msdyncrm_linkedinfieldmapping_Appointments](#BKMK_msdyncrm_linkedinfieldmapping_Appointments)
- [msdyncrm_linkedinfieldmapping_AsyncOperations](#BKMK_msdyncrm_linkedinfieldmapping_AsyncOperations)
- [msdyncrm_linkedinfieldmapping_BulkDeleteFailures](#BKMK_msdyncrm_linkedinfieldmapping_BulkDeleteFailures)
- [msdyncrm_linkedinfieldmapping_chats](#BKMK_msdyncrm_linkedinfieldmapping_chats)
- [msdyncrm_linkedinfieldmapping_connections1](#BKMK_msdyncrm_linkedinfieldmapping_connections1)
- [msdyncrm_linkedinfieldmapping_connections2](#BKMK_msdyncrm_linkedinfieldmapping_connections2)
- [msdyncrm_linkedinfieldmapping_DuplicateBaseRecord](#BKMK_msdyncrm_linkedinfieldmapping_DuplicateBaseRecord)
- [msdyncrm_linkedinfieldmapping_DuplicateMatchingRecord](#BKMK_msdyncrm_linkedinfieldmapping_DuplicateMatchingRecord)
- [msdyncrm_linkedinfieldmapping_Emails](#BKMK_msdyncrm_linkedinfieldmapping_Emails)
- [msdyncrm_linkedinfieldmapping_Faxes](#BKMK_msdyncrm_linkedinfieldmapping_Faxes)
- [msdyncrm_linkedinfieldmapping_Feedback](#BKMK_msdyncrm_linkedinfieldmapping_Feedback)
- [msdyncrm_linkedinfieldmapping_Letters](#BKMK_msdyncrm_linkedinfieldmapping_Letters)
- [msdyncrm_linkedinfieldmapping_li_inmails](#BKMK_msdyncrm_linkedinfieldmapping_li_inmails)
- [msdyncrm_linkedinfieldmapping_li_messages](#BKMK_msdyncrm_linkedinfieldmapping_li_messages)
- [msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinfieldmapping_MailboxTrackingFolders](#BKMK_msdyncrm_linkedinfieldmapping_MailboxTrackingFolders)
- [msdyncrm_linkedinfieldmapping_msdyn_bookingalerts](#BKMK_msdyncrm_linkedinfieldmapping_msdyn_bookingalerts)
- [msdyncrm_linkedinfieldmapping_msdyn_copilottranscripts](#BKMK_msdyncrm_linkedinfieldmapping_msdyn_copilottranscripts)
- [msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems)
- [msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinfieldmapping_msdyn_ocsessions](#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocsessions)
- [msdyncrm_linkedinfieldmapping_msdyn_ocvoicemails](#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocvoicemails)
- [msdyncrm_linkedinfieldmapping_msfp_alerts](#BKMK_msdyncrm_linkedinfieldmapping_msfp_alerts)
- [msdyncrm_linkedinfieldmapping_msfp_surveyinvites](#BKMK_msdyncrm_linkedinfieldmapping_msfp_surveyinvites)
- [msdyncrm_linkedinfieldmapping_msfp_surveyresponses](#BKMK_msdyncrm_linkedinfieldmapping_msfp_surveyresponses)
- [msdyncrm_linkedinfieldmapping_PhoneCalls](#BKMK_msdyncrm_linkedinfieldmapping_PhoneCalls)
- [msdyncrm_linkedinfieldmapping_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_linkedinfieldmapping_PrincipalObjectAttributeAccesses)
- [msdyncrm_linkedinfieldmapping_ProcessSession](#BKMK_msdyncrm_linkedinfieldmapping_ProcessSession)
- [msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters)
- [msdyncrm_linkedinfieldmapping_ServiceAppointments](#BKMK_msdyncrm_linkedinfieldmapping_ServiceAppointments)
- [msdyncrm_linkedinfieldmapping_SocialActivities](#BKMK_msdyncrm_linkedinfieldmapping_SocialActivities)
- [msdyncrm_linkedinfieldmapping_SyncErrors](#BKMK_msdyncrm_linkedinfieldmapping_SyncErrors)
- [msdyncrm_linkedinfieldmapping_Tasks](#BKMK_msdyncrm_linkedinfieldmapping_Tasks)
- [msdyncrm_msdyncrm_linkedinfieldmapping_msdyncrm_linkedinformquestion_LinkedInPredefinedField](#BKMK_msdyncrm_msdyncrm_linkedinfieldmapping_msdyncrm_linkedinformquestion_LinkedInPredefinedField)

### <a name="BKMK_msdyncrm_linkedinfieldmapping_ActivityPointers"></a> msdyncrm_linkedinfieldmapping_ActivityPointers

Many-To-One Relationship: [activitypointer msdyncrm_linkedinfieldmapping_ActivityPointers](activitypointer.md#BKMK_msdyncrm_linkedinfieldmapping_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_adx_alertsubscriptions"></a> msdyncrm_linkedinfieldmapping_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msdyncrm_linkedinfieldmapping_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msdyncrm_linkedinfieldmapping_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_adx_inviteredemptions"></a> msdyncrm_linkedinfieldmapping_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyncrm_linkedinfieldmapping_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyncrm_linkedinfieldmapping_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_adx_portalcomments"></a> msdyncrm_linkedinfieldmapping_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyncrm_linkedinfieldmapping_adx_portalcomments](adx_portalcomment.md#BKMK_msdyncrm_linkedinfieldmapping_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_Annotations"></a> msdyncrm_linkedinfieldmapping_Annotations

Many-To-One Relationship: [annotation msdyncrm_linkedinfieldmapping_Annotations](annotation.md#BKMK_msdyncrm_linkedinfieldmapping_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_Appointments"></a> msdyncrm_linkedinfieldmapping_Appointments

Many-To-One Relationship: [appointment msdyncrm_linkedinfieldmapping_Appointments](appointment.md#BKMK_msdyncrm_linkedinfieldmapping_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_AsyncOperations"></a> msdyncrm_linkedinfieldmapping_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_linkedinfieldmapping_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_linkedinfieldmapping_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_BulkDeleteFailures"></a> msdyncrm_linkedinfieldmapping_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_linkedinfieldmapping_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_linkedinfieldmapping_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_chats"></a> msdyncrm_linkedinfieldmapping_chats

Many-To-One Relationship: [chat msdyncrm_linkedinfieldmapping_chats](chat.md#BKMK_msdyncrm_linkedinfieldmapping_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_connections1"></a> msdyncrm_linkedinfieldmapping_connections1

Many-To-One Relationship: [connection msdyncrm_linkedinfieldmapping_connections1](connection.md#BKMK_msdyncrm_linkedinfieldmapping_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_connections2"></a> msdyncrm_linkedinfieldmapping_connections2

Many-To-One Relationship: [connection msdyncrm_linkedinfieldmapping_connections2](connection.md#BKMK_msdyncrm_linkedinfieldmapping_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_DuplicateBaseRecord"></a> msdyncrm_linkedinfieldmapping_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_linkedinfieldmapping_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_linkedinfieldmapping_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_DuplicateMatchingRecord"></a> msdyncrm_linkedinfieldmapping_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_linkedinfieldmapping_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_linkedinfieldmapping_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_Emails"></a> msdyncrm_linkedinfieldmapping_Emails

Many-To-One Relationship: [email msdyncrm_linkedinfieldmapping_Emails](email.md#BKMK_msdyncrm_linkedinfieldmapping_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_Faxes"></a> msdyncrm_linkedinfieldmapping_Faxes

Many-To-One Relationship: [fax msdyncrm_linkedinfieldmapping_Faxes](fax.md#BKMK_msdyncrm_linkedinfieldmapping_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_Feedback"></a> msdyncrm_linkedinfieldmapping_Feedback

Many-To-One Relationship: [feedback msdyncrm_linkedinfieldmapping_Feedback](feedback.md#BKMK_msdyncrm_linkedinfieldmapping_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_Letters"></a> msdyncrm_linkedinfieldmapping_Letters

Many-To-One Relationship: [letter msdyncrm_linkedinfieldmapping_Letters](letter.md#BKMK_msdyncrm_linkedinfieldmapping_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_li_inmails"></a> msdyncrm_linkedinfieldmapping_li_inmails

Many-To-One Relationship: [li_inmail msdyncrm_linkedinfieldmapping_li_inmails](li_inmail.md#BKMK_msdyncrm_linkedinfieldmapping_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_li_messages"></a> msdyncrm_linkedinfieldmapping_li_messages

Many-To-One Relationship: [li_message msdyncrm_linkedinfieldmapping_li_messages](li_message.md#BKMK_msdyncrm_linkedinfieldmapping_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_MailboxTrackingFolders"></a> msdyncrm_linkedinfieldmapping_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_linkedinfieldmapping_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_linkedinfieldmapping_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_msdyn_bookingalerts"></a> msdyncrm_linkedinfieldmapping_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyncrm_linkedinfieldmapping_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyncrm_linkedinfieldmapping_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_msdyn_copilottranscripts"></a> msdyncrm_linkedinfieldmapping_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyncrm_linkedinfieldmapping_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyncrm_linkedinfieldmapping_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems"></a> msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocsessions"></a> msdyncrm_linkedinfieldmapping_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyncrm_linkedinfieldmapping_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocvoicemails"></a> msdyncrm_linkedinfieldmapping_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyncrm_linkedinfieldmapping_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyncrm_linkedinfieldmapping_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_msfp_alerts"></a> msdyncrm_linkedinfieldmapping_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyncrm_linkedinfieldmapping_msfp_alerts](msfp_alert.md#BKMK_msdyncrm_linkedinfieldmapping_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_msfp_surveyinvites"></a> msdyncrm_linkedinfieldmapping_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyncrm_linkedinfieldmapping_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyncrm_linkedinfieldmapping_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_msfp_surveyresponses"></a> msdyncrm_linkedinfieldmapping_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyncrm_linkedinfieldmapping_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyncrm_linkedinfieldmapping_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_PhoneCalls"></a> msdyncrm_linkedinfieldmapping_PhoneCalls

Many-To-One Relationship: [phonecall msdyncrm_linkedinfieldmapping_PhoneCalls](phonecall.md#BKMK_msdyncrm_linkedinfieldmapping_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_PrincipalObjectAttributeAccesses"></a> msdyncrm_linkedinfieldmapping_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_linkedinfieldmapping_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_linkedinfieldmapping_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_ProcessSession"></a> msdyncrm_linkedinfieldmapping_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_linkedinfieldmapping_ProcessSession](processsession.md#BKMK_msdyncrm_linkedinfieldmapping_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters"></a> msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_ServiceAppointments"></a> msdyncrm_linkedinfieldmapping_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyncrm_linkedinfieldmapping_ServiceAppointments](serviceappointment.md#BKMK_msdyncrm_linkedinfieldmapping_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_SocialActivities"></a> msdyncrm_linkedinfieldmapping_SocialActivities

Many-To-One Relationship: [socialactivity msdyncrm_linkedinfieldmapping_SocialActivities](socialactivity.md#BKMK_msdyncrm_linkedinfieldmapping_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_SyncErrors"></a> msdyncrm_linkedinfieldmapping_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_linkedinfieldmapping_SyncErrors](syncerror.md#BKMK_msdyncrm_linkedinfieldmapping_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_Tasks"></a> msdyncrm_linkedinfieldmapping_Tasks

Many-To-One Relationship: [task msdyncrm_linkedinfieldmapping_Tasks](task.md#BKMK_msdyncrm_linkedinfieldmapping_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinfieldmapping_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedinfieldmapping_msdyncrm_linkedinformquestion_LinkedInPredefinedField"></a> msdyncrm_msdyncrm_linkedinfieldmapping_msdyncrm_linkedinformquestion_LinkedInPredefinedField

Many-To-One Relationship: [msdyncrm_linkedinformquestion msdyncrm_msdyncrm_linkedinfieldmapping_msdyncrm_linkedinformquestion_LinkedInPredefinedField](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_msdyncrm_linkedinfieldmapping_msdyncrm_linkedinformquestion_LinkedInPredefinedField)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformquestion`|
|ReferencingAttribute|`msdyncrm_linkedinpredefinedfield`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_linkedinfieldmapping_msdyncrm_linkedinformquestion_LinkedInPredefinedField`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyncrm_msdyncrm_linkedinlms_fieldmapping"></a> msdyncrm_msdyncrm_linkedinlms_fieldmapping

See [msdyncrm_linkedinleadmatchingstrategy msdyncrm_msdyncrm_linkedinlms_fieldmapping Many-To-Many Relationship](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_msdyncrm_linkedinlms_fieldmapping)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_msdyncrm_linkedinlms_fieldmapping`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_msdyncrm_linkedinlms_fieldmapping`|
|IntersectAttribute|`msdyncrm_linkedinfieldmappingid`|
|NavigationPropertyName|`msdyncrm_msdyncrm_linkedinlms_fieldmapping`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Fields<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

