---
title: "Suggestion Principal Object Access (msdyn_suggestionprincipalobjectaccess) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Suggestion Principal Object Access (msdyn_suggestionprincipalobjectaccess) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Suggestion Principal Object Access (msdyn_suggestionprincipalobjectaccess) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Suggestion Principal Object Access (msdyn_suggestionprincipalobjectaccess) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_suggestionprincipalobjectaccesses(*msdyn_suggestionprincipalobjectaccessid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_suggestionprincipalobjectaccesses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_suggestionprincipalobjectaccesses(*msdyn_suggestionprincipalobjectaccessid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_suggestionprincipalobjectaccesses(*msdyn_suggestionprincipalobjectaccessid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_suggestionprincipalobjectaccesses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_suggestionprincipalobjectaccesses(*msdyn_suggestionprincipalobjectaccessid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_suggestionprincipalobjectaccesses(*msdyn_suggestionprincipalobjectaccessid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_suggestionprincipalobjectaccesses(*msdyn_suggestionprincipalobjectaccessid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Suggestion Principal Object Access (msdyn_suggestionprincipalobjectaccess) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Suggestion Principal Object Access** |
| **DisplayCollectionName** | **suggestionprincipalobjectaccesses** |
| **SchemaName** | `msdyn_suggestionprincipalobjectaccess` |
| **CollectionSchemaName** | `msdyn_suggestionprincipalobjectaccesses` |
| **EntitySetName** | `msdyn_suggestionprincipalobjectaccesses`|
| **LogicalName** | `msdyn_suggestionprincipalobjectaccess` |
| **LogicalCollectionName** | `msdyn_suggestionprincipalobjectaccesses` |
| **PrimaryIdAttribute** | `msdyn_suggestionprincipalobjectaccessid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_accessrightsmask](#BKMK_msdyn_accessrightsmask)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_principalid](#BKMK_msdyn_principalid)
- [msdyn_principalidIdType](#BKMK_msdyn_principalidIdType)
- [msdyn_salessuggestionid](#BKMK_msdyn_salessuggestionid)
- [msdyn_suggestionprincipalobjectaccessId](#BKMK_msdyn_suggestionprincipalobjectaccessId)
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

### <a name="BKMK_msdyn_accessrightsmask"></a> msdyn_accessrightsmask

|Property|Value|
|---|---|
|Description||
|DisplayName|**accessrightsmask**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_accessrightsmask`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|2|
|GlobalChoiceName|`msdyn_suggestionprincipalobjectaccess_msdyn_accessrightsmask`|

#### msdyn_accessrightsmask Choices/Options

|Value|Label|
|---|---|
|1|**Primary**|
|2|**Secondary**|

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

### <a name="BKMK_msdyn_principalid"></a> msdyn_principalid

|Property|Value|
|---|---|
|Description||
|DisplayName|**principalid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_principalid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_principalidIdType"></a> msdyn_principalidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_principalididtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_salessuggestionid"></a> msdyn_salessuggestionid

|Property|Value|
|---|---|
|Description||
|DisplayName|**salessuggestionid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salessuggestionid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_salessuggestion|

### <a name="BKMK_msdyn_suggestionprincipalobjectaccessId"></a> msdyn_suggestionprincipalobjectaccessId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Suggestion Principal Object Access**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestionprincipalobjectaccessid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the Suggestion Principal Object Access**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_suggestionprincipalobjectaccess_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Suggestion Principal Object Access**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_suggestionprincipalobjectaccess_statuscode`|

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

- [business_unit_msdyn_suggestionprincipalobjectaccess](#BKMK_business_unit_msdyn_suggestionprincipalobjectaccess)
- [lk_msdyn_suggestionprincipalobjectaccess_createdby](#BKMK_lk_msdyn_suggestionprincipalobjectaccess_createdby)
- [lk_msdyn_suggestionprincipalobjectaccess_createdonbehalfby](#BKMK_lk_msdyn_suggestionprincipalobjectaccess_createdonbehalfby)
- [lk_msdyn_suggestionprincipalobjectaccess_modifiedby](#BKMK_lk_msdyn_suggestionprincipalobjectaccess_modifiedby)
- [lk_msdyn_suggestionprincipalobjectaccess_modifiedonbehalfby](#BKMK_lk_msdyn_suggestionprincipalobjectaccess_modifiedonbehalfby)
- [msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid](#BKMK_msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid)
- [msdyn_systemuser_suggestionprincipalobjectaccess_principalid](#BKMK_msdyn_systemuser_suggestionprincipalobjectaccess_principalid)
- [owner_msdyn_suggestionprincipalobjectaccess](#BKMK_owner_msdyn_suggestionprincipalobjectaccess)
- [team_msdyn_suggestionprincipalobjectaccess](#BKMK_team_msdyn_suggestionprincipalobjectaccess)
- [user_msdyn_suggestionprincipalobjectaccess](#BKMK_user_msdyn_suggestionprincipalobjectaccess)

### <a name="BKMK_business_unit_msdyn_suggestionprincipalobjectaccess"></a> business_unit_msdyn_suggestionprincipalobjectaccess

One-To-Many Relationship: [businessunit business_unit_msdyn_suggestionprincipalobjectaccess](businessunit.md#BKMK_business_unit_msdyn_suggestionprincipalobjectaccess)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_suggestionprincipalobjectaccess_createdby"></a> lk_msdyn_suggestionprincipalobjectaccess_createdby

One-To-Many Relationship: [systemuser lk_msdyn_suggestionprincipalobjectaccess_createdby](systemuser.md#BKMK_lk_msdyn_suggestionprincipalobjectaccess_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_suggestionprincipalobjectaccess_createdonbehalfby"></a> lk_msdyn_suggestionprincipalobjectaccess_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_suggestionprincipalobjectaccess_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_suggestionprincipalobjectaccess_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_suggestionprincipalobjectaccess_modifiedby"></a> lk_msdyn_suggestionprincipalobjectaccess_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_suggestionprincipalobjectaccess_modifiedby](systemuser.md#BKMK_lk_msdyn_suggestionprincipalobjectaccess_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_suggestionprincipalobjectaccess_modifiedonbehalfby"></a> lk_msdyn_suggestionprincipalobjectaccess_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_suggestionprincipalobjectaccess_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_suggestionprincipalobjectaccess_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid"></a> msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`msdyn_salessuggestionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_salessuggestionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_suggestionprincipalobjectaccess_principalid"></a> msdyn_systemuser_suggestionprincipalobjectaccess_principalid

One-To-Many Relationship: [systemuser msdyn_systemuser_suggestionprincipalobjectaccess_principalid](systemuser.md#BKMK_msdyn_systemuser_suggestionprincipalobjectaccess_principalid)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_principalid`|
|ReferencingEntityNavigationPropertyName|`msdyn_principalid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_suggestionprincipalobjectaccess"></a> owner_msdyn_suggestionprincipalobjectaccess

One-To-Many Relationship: [owner owner_msdyn_suggestionprincipalobjectaccess](owner.md#BKMK_owner_msdyn_suggestionprincipalobjectaccess)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_suggestionprincipalobjectaccess"></a> team_msdyn_suggestionprincipalobjectaccess

One-To-Many Relationship: [team team_msdyn_suggestionprincipalobjectaccess](team.md#BKMK_team_msdyn_suggestionprincipalobjectaccess)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_suggestionprincipalobjectaccess"></a> user_msdyn_suggestionprincipalobjectaccess

One-To-Many Relationship: [systemuser user_msdyn_suggestionprincipalobjectaccess](systemuser.md#BKMK_user_msdyn_suggestionprincipalobjectaccess)

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

- [msdyn_suggestionprincipalobjectaccess_AsyncOperations](#BKMK_msdyn_suggestionprincipalobjectaccess_AsyncOperations)
- [msdyn_suggestionprincipalobjectaccess_BulkDeleteFailures](#BKMK_msdyn_suggestionprincipalobjectaccess_BulkDeleteFailures)
- [msdyn_suggestionprincipalobjectaccess_connections1](#BKMK_msdyn_suggestionprincipalobjectaccess_connections1)
- [msdyn_suggestionprincipalobjectaccess_connections2](#BKMK_msdyn_suggestionprincipalobjectaccess_connections2)
- [msdyn_suggestionprincipalobjectaccess_MailboxTrackingFolders](#BKMK_msdyn_suggestionprincipalobjectaccess_MailboxTrackingFolders)
- [msdyn_suggestionprincipalobjectaccess_PrincipalObjectAttributeAccesses](#BKMK_msdyn_suggestionprincipalobjectaccess_PrincipalObjectAttributeAccesses)
- [msdyn_suggestionprincipalobjectaccess_ProcessSession](#BKMK_msdyn_suggestionprincipalobjectaccess_ProcessSession)
- [msdyn_suggestionprincipalobjectaccess_SyncErrors](#BKMK_msdyn_suggestionprincipalobjectaccess_SyncErrors)

### <a name="BKMK_msdyn_suggestionprincipalobjectaccess_AsyncOperations"></a> msdyn_suggestionprincipalobjectaccess_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_suggestionprincipalobjectaccess_AsyncOperations](asyncoperation.md#BKMK_msdyn_suggestionprincipalobjectaccess_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionprincipalobjectaccess_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionprincipalobjectaccess_BulkDeleteFailures"></a> msdyn_suggestionprincipalobjectaccess_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_suggestionprincipalobjectaccess_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_suggestionprincipalobjectaccess_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionprincipalobjectaccess_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionprincipalobjectaccess_connections1"></a> msdyn_suggestionprincipalobjectaccess_connections1

Many-To-One Relationship: [connection msdyn_suggestionprincipalobjectaccess_connections1](connection.md#BKMK_msdyn_suggestionprincipalobjectaccess_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionprincipalobjectaccess_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionprincipalobjectaccess_connections2"></a> msdyn_suggestionprincipalobjectaccess_connections2

Many-To-One Relationship: [connection msdyn_suggestionprincipalobjectaccess_connections2](connection.md#BKMK_msdyn_suggestionprincipalobjectaccess_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionprincipalobjectaccess_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionprincipalobjectaccess_MailboxTrackingFolders"></a> msdyn_suggestionprincipalobjectaccess_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_suggestionprincipalobjectaccess_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_suggestionprincipalobjectaccess_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionprincipalobjectaccess_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionprincipalobjectaccess_PrincipalObjectAttributeAccesses"></a> msdyn_suggestionprincipalobjectaccess_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_suggestionprincipalobjectaccess_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_suggestionprincipalobjectaccess_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionprincipalobjectaccess_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionprincipalobjectaccess_ProcessSession"></a> msdyn_suggestionprincipalobjectaccess_ProcessSession

Many-To-One Relationship: [processsession msdyn_suggestionprincipalobjectaccess_ProcessSession](processsession.md#BKMK_msdyn_suggestionprincipalobjectaccess_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionprincipalobjectaccess_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_suggestionprincipalobjectaccess_SyncErrors"></a> msdyn_suggestionprincipalobjectaccess_SyncErrors

Many-To-One Relationship: [syncerror msdyn_suggestionprincipalobjectaccess_SyncErrors](syncerror.md#BKMK_msdyn_suggestionprincipalobjectaccess_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_suggestionprincipalobjectaccess_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

