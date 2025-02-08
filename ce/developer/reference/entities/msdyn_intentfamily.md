---
title: "Line of Business (msdyn_intentfamily) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Line of Business (msdyn_intentfamily) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Line of Business (msdyn_intentfamily) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Line of Business (msdyn_intentfamily) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_intentfamilies(*msdyn_intentfamilyid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_intentfamilies<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_intentfamilies(*msdyn_intentfamilyid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_intentfamilies(*msdyn_intentfamilyid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_intentfamilies<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_intentfamilies(*msdyn_intentfamilyid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_intentfamilies(*msdyn_intentfamilyid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_intentfamilies(*msdyn_intentfamilyid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Line of Business (msdyn_intentfamily) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Line of Business** |
| **DisplayCollectionName** | **Lines of Business** |
| **SchemaName** | `msdyn_intentfamily` |
| **CollectionSchemaName** | `msdyn_intentfamilies` |
| **EntitySetName** | `msdyn_intentfamilies`|
| **LogicalName** | `msdyn_intentfamily` |
| **LogicalCollectionName** | `msdyn_intentfamilies` |
| **PrimaryIdAttribute** | `msdyn_intentfamilyid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_defaultusergroup](#BKMK_msdyn_defaultusergroup)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_intentbasedroutingenabled](#BKMK_msdyn_intentbasedroutingenabled)
- [msdyn_intentfamilyId](#BKMK_msdyn_intentfamilyId)
- [msdyn_isdefault](#BKMK_msdyn_isdefault)
- [msdyn_isenabled](#BKMK_msdyn_isenabled)
- [msdyn_Name](#BKMK_msdyn_Name)
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

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdyn_defaultusergroup"></a> msdyn_defaultusergroup

|Property|Value|
|---|---|
|Description|**Default user group to be used when no agent group is identified**|
|DisplayName|**Default User Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultusergroup`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agentgroup|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Description of the LoB**|
|DisplayName|**description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_intentbasedroutingenabled"></a> msdyn_intentbasedroutingenabled

|Property|Value|
|---|---|
|Description|**Is Intent Based Routing Enabled for Intentfamily**|
|DisplayName|**Is Intent Based Routing Enabled for Intentfamily**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentbasedroutingenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_intentfamily_msdyn_intentbasedroutingenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_intentfamilyId"></a> msdyn_intentfamilyId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**intentfamilyid**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_intentfamilyid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_isdefault"></a> msdyn_isdefault

|Property|Value|
|---|---|
|Description||
|DisplayName|**isdefault**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isdefault`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_intentfamily_msdyn_isdefault`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isenabled"></a> msdyn_isenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**isenabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isenabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_intentfamily_msdyn_isenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|1000|

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
|Description|**Status of the intentfamily**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_intentfamily_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the intentfamily**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_intentfamily_statuscode`|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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
|RequiredLevel|SystemRequired|
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

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [business_unit_msdyn_intentfamily](#BKMK_business_unit_msdyn_intentfamily)
- [lk_msdyn_intentfamily_createdby](#BKMK_lk_msdyn_intentfamily_createdby)
- [lk_msdyn_intentfamily_createdonbehalfby](#BKMK_lk_msdyn_intentfamily_createdonbehalfby)
- [lk_msdyn_intentfamily_modifiedby](#BKMK_lk_msdyn_intentfamily_modifiedby)
- [lk_msdyn_intentfamily_modifiedonbehalfby](#BKMK_lk_msdyn_intentfamily_modifiedonbehalfby)
- [msdyn_intentfamily_msdyn_defaultusergroup_msdyn_agentgroup](#BKMK_msdyn_intentfamily_msdyn_defaultusergroup_msdyn_agentgroup)
- [owner_msdyn_intentfamily](#BKMK_owner_msdyn_intentfamily)
- [team_msdyn_intentfamily](#BKMK_team_msdyn_intentfamily)
- [user_msdyn_intentfamily](#BKMK_user_msdyn_intentfamily)

### <a name="BKMK_business_unit_msdyn_intentfamily"></a> business_unit_msdyn_intentfamily

One-To-Many Relationship: [businessunit business_unit_msdyn_intentfamily](businessunit.md#BKMK_business_unit_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentfamily_createdby"></a> lk_msdyn_intentfamily_createdby

One-To-Many Relationship: [systemuser lk_msdyn_intentfamily_createdby](systemuser.md#BKMK_lk_msdyn_intentfamily_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentfamily_createdonbehalfby"></a> lk_msdyn_intentfamily_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentfamily_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_intentfamily_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentfamily_modifiedby"></a> lk_msdyn_intentfamily_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_intentfamily_modifiedby](systemuser.md#BKMK_lk_msdyn_intentfamily_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentfamily_modifiedonbehalfby"></a> lk_msdyn_intentfamily_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentfamily_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_intentfamily_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_intentfamily_msdyn_defaultusergroup_msdyn_agentgroup"></a> msdyn_intentfamily_msdyn_defaultusergroup_msdyn_agentgroup

One-To-Many Relationship: [msdyn_agentgroup msdyn_intentfamily_msdyn_defaultusergroup_msdyn_agentgroup](msdyn_agentgroup.md#BKMK_msdyn_intentfamily_msdyn_defaultusergroup_msdyn_agentgroup)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agentgroup`|
|ReferencedAttribute|`msdyn_agentgroupid`|
|ReferencingAttribute|`msdyn_defaultusergroup`|
|ReferencingEntityNavigationPropertyName|`msdyn_defaultusergroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_intentfamily"></a> owner_msdyn_intentfamily

One-To-Many Relationship: [owner owner_msdyn_intentfamily](owner.md#BKMK_owner_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_intentfamily"></a> team_msdyn_intentfamily

One-To-Many Relationship: [team team_msdyn_intentfamily](team.md#BKMK_team_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_intentfamily"></a> user_msdyn_intentfamily

One-To-Many Relationship: [systemuser user_msdyn_intentfamily](systemuser.md#BKMK_user_msdyn_intentfamily)

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

- [msdyn_agentgroup_intentfamilyid_msdyn_intentfamily](#BKMK_msdyn_agentgroup_intentfamilyid_msdyn_intentfamily)
- [msdyn_intent_intentfamilyid_msdyn_intentfamily](#BKMK_msdyn_intent_intentfamilyid_msdyn_intentfamily)
- [msdyn_intentattribute_intentfamilyid_msdyn_intentfamily](#BKMK_msdyn_intentattribute_intentfamilyid_msdyn_intentfamily)
- [msdyn_intentattributeset_intentfamilyid_msdyn_intentfamily](#BKMK_msdyn_intentattributeset_intentfamilyid_msdyn_intentfamily)
- [msdyn_intentconfig_intentfamilyid_msdyn_intentfamily](#BKMK_msdyn_intentconfig_intentfamilyid_msdyn_intentfamily)
- [msdyn_intententity_intentfamilyid_msdyn_intentfamily](#BKMK_msdyn_intententity_intentfamilyid_msdyn_intentfamily)
- [msdyn_intentfamily_AsyncOperations](#BKMK_msdyn_intentfamily_AsyncOperations)
- [msdyn_intentfamily_BulkDeleteFailures](#BKMK_msdyn_intentfamily_BulkDeleteFailures)
- [msdyn_intentfamily_DuplicateBaseRecord](#BKMK_msdyn_intentfamily_DuplicateBaseRecord)
- [msdyn_intentfamily_DuplicateMatchingRecord](#BKMK_msdyn_intentfamily_DuplicateMatchingRecord)
- [msdyn_intentfamily_MailboxTrackingFolders](#BKMK_msdyn_intentfamily_MailboxTrackingFolders)
- [msdyn_intentfamily_PrincipalObjectAttributeAccesses](#BKMK_msdyn_intentfamily_PrincipalObjectAttributeAccesses)
- [msdyn_intentfamily_ProcessSession](#BKMK_msdyn_intentfamily_ProcessSession)
- [msdyn_intentfamily_SyncErrors](#BKMK_msdyn_intentfamily_SyncErrors)
- [msdyn_intentgroupcondition_msdyn_intentfamily_msdyn_intentfamily](#BKMK_msdyn_intentgroupcondition_msdyn_intentfamily_msdyn_intentfamily)
- [msdyn_intentsolutionmap_intentfamilyid_msdyn_intentfamily](#BKMK_msdyn_intentsolutionmap_intentfamilyid_msdyn_intentfamily)
- [msdyn_liveworkstream_intentfamilyid_msdyn_intentfamily](#BKMK_msdyn_liveworkstream_intentfamilyid_msdyn_intentfamily)
- [msdyn_msdyn_ocliveworkitem_msdyn_intentfamily_activeintentfamilyid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_intentfamily_activeintentfamilyid)
- [Queue_intentfamilyid_msdyn_intentfamily](#BKMK_Queue_intentfamilyid_msdyn_intentfamily)

### <a name="BKMK_msdyn_agentgroup_intentfamilyid_msdyn_intentfamily"></a> msdyn_agentgroup_intentfamilyid_msdyn_intentfamily

Many-To-One Relationship: [msdyn_agentgroup msdyn_agentgroup_intentfamilyid_msdyn_intentfamily](msdyn_agentgroup.md#BKMK_msdyn_agentgroup_intentfamilyid_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgroup`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentgroup_intentfamilyid_msdyn_intentfamily`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intent_intentfamilyid_msdyn_intentfamily"></a> msdyn_intent_intentfamilyid_msdyn_intentfamily

Many-To-One Relationship: [msdyn_intent msdyn_intent_intentfamilyid_msdyn_intentfamily](msdyn_intent.md#BKMK_msdyn_intent_intentfamilyid_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intent`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intent_intentfamilyid_msdyn_intentfamily`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentattribute_intentfamilyid_msdyn_intentfamily"></a> msdyn_intentattribute_intentfamilyid_msdyn_intentfamily

Many-To-One Relationship: [msdyn_intentattribute msdyn_intentattribute_intentfamilyid_msdyn_intentfamily](msdyn_intentattribute.md#BKMK_msdyn_intentattribute_intentfamilyid_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentattribute`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentattribute_intentfamilyid_msdyn_intentfamily`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentattributeset_intentfamilyid_msdyn_intentfamily"></a> msdyn_intentattributeset_intentfamilyid_msdyn_intentfamily

Many-To-One Relationship: [msdyn_intentattributeset msdyn_intentattributeset_intentfamilyid_msdyn_intentfamily](msdyn_intentattributeset.md#BKMK_msdyn_intentattributeset_intentfamilyid_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentattributeset`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentattributeset_intentfamilyid_msdyn_intentfamily`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentconfig_intentfamilyid_msdyn_intentfamily"></a> msdyn_intentconfig_intentfamilyid_msdyn_intentfamily

Many-To-One Relationship: [msdyn_intentconfig msdyn_intentconfig_intentfamilyid_msdyn_intentfamily](msdyn_intentconfig.md#BKMK_msdyn_intentconfig_intentfamilyid_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentconfig`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentconfig_intentfamilyid_msdyn_intentfamily`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intententity_intentfamilyid_msdyn_intentfamily"></a> msdyn_intententity_intentfamilyid_msdyn_intentfamily

Many-To-One Relationship: [msdyn_intententity msdyn_intententity_intentfamilyid_msdyn_intentfamily](msdyn_intententity.md#BKMK_msdyn_intententity_intentfamilyid_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intententity`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intententity_intentfamilyid_msdyn_intentfamily`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_AsyncOperations"></a> msdyn_intentfamily_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_intentfamily_AsyncOperations](asyncoperation.md#BKMK_msdyn_intentfamily_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_BulkDeleteFailures"></a> msdyn_intentfamily_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_intentfamily_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_intentfamily_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_DuplicateBaseRecord"></a> msdyn_intentfamily_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_intentfamily_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_intentfamily_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_DuplicateMatchingRecord"></a> msdyn_intentfamily_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_intentfamily_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_intentfamily_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_MailboxTrackingFolders"></a> msdyn_intentfamily_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_intentfamily_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_intentfamily_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_PrincipalObjectAttributeAccesses"></a> msdyn_intentfamily_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_intentfamily_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_intentfamily_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_ProcessSession"></a> msdyn_intentfamily_ProcessSession

Many-To-One Relationship: [processsession msdyn_intentfamily_ProcessSession](processsession.md#BKMK_msdyn_intentfamily_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_SyncErrors"></a> msdyn_intentfamily_SyncErrors

Many-To-One Relationship: [syncerror msdyn_intentfamily_SyncErrors](syncerror.md#BKMK_msdyn_intentfamily_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentgroupcondition_msdyn_intentfamily_msdyn_intentfamily"></a> msdyn_intentgroupcondition_msdyn_intentfamily_msdyn_intentfamily

Many-To-One Relationship: [msdyn_intentgroupcondition msdyn_intentgroupcondition_msdyn_intentfamily_msdyn_intentfamily](msdyn_intentgroupcondition.md#BKMK_msdyn_intentgroupcondition_msdyn_intentfamily_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentgroupcondition`|
|ReferencingAttribute|`msdyn_intentfamily`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentgroupcondition_msdyn_intentfamily_msdyn_intentfamily`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentsolutionmap_intentfamilyid_msdyn_intentfamily"></a> msdyn_intentsolutionmap_intentfamilyid_msdyn_intentfamily

Many-To-One Relationship: [msdyn_intentsolutionmap msdyn_intentsolutionmap_intentfamilyid_msdyn_intentfamily](msdyn_intentsolutionmap.md#BKMK_msdyn_intentsolutionmap_intentfamilyid_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentsolutionmap`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentsolutionmap_intentfamilyid_msdyn_intentfamily`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_liveworkstream_intentfamilyid_msdyn_intentfamily"></a> msdyn_liveworkstream_intentfamilyid_msdyn_intentfamily

Many-To-One Relationship: [msdyn_liveworkstream msdyn_liveworkstream_intentfamilyid_msdyn_intentfamily](msdyn_liveworkstream.md#BKMK_msdyn_liveworkstream_intentfamilyid_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkstream`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_liveworkstream_intentfamilyid_msdyn_intentfamily`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_intentfamily_activeintentfamilyid"></a> msdyn_msdyn_ocliveworkitem_msdyn_intentfamily_activeintentfamilyid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_intentfamily_activeintentfamilyid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_intentfamily_activeintentfamilyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_activeintentfamilyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_intentfamily_activeintentfamilyid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Queue_intentfamilyid_msdyn_intentfamily"></a> Queue_intentfamilyid_msdyn_intentfamily

Many-To-One Relationship: [queue Queue_intentfamilyid_msdyn_intentfamily](queue.md#BKMK_Queue_intentfamilyid_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`queue`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencedEntityNavigationPropertyName|`Queue_intentfamilyid_msdyn_intentfamily`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

