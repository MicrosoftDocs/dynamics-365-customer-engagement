---
title: "Agent Capacity Profile Unit (msdyn_agentcapacityprofileunit) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Agent Capacity Profile Unit (msdyn_agentcapacityprofileunit) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Agent Capacity Profile Unit (msdyn_agentcapacityprofileunit) table/entity reference (Microsoft Dynamics 365)

Agent Capacity Profile Units holds agent’s available capacity for each capacity profile associated.

## Messages

The following table lists the messages for the Agent Capacity Profile Unit (msdyn_agentcapacityprofileunit) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_agentcapacityprofileunits(*msdyn_agentcapacityprofileunitid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_agentcapacityprofileunits<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_agentcapacityprofileunits(*msdyn_agentcapacityprofileunitid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_agentcapacityprofileunits(*msdyn_agentcapacityprofileunitid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_agentcapacityprofileunits<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_agentcapacityprofileunits(*msdyn_agentcapacityprofileunitid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_agentcapacityprofileunits(*msdyn_agentcapacityprofileunitid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_agentcapacityprofileunits(*msdyn_agentcapacityprofileunitid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Agent Capacity Profile Unit (msdyn_agentcapacityprofileunit) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Agent Capacity Profile Unit** |
| **DisplayCollectionName** | **Agent Capacity Profile Units** |
| **SchemaName** | `msdyn_agentcapacityprofileunit` |
| **CollectionSchemaName** | `msdyn_agentcapacityprofileunits` |
| **EntitySetName** | `msdyn_agentcapacityprofileunits`|
| **LogicalName** | `msdyn_agentcapacityprofileunit` |
| **LogicalCollectionName** | `msdyn_agentcapacityprofileunits` |
| **PrimaryIdAttribute** | `msdyn_agentcapacityprofileunitid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_agentcapacityprofileunitId](#BKMK_msdyn_agentcapacityprofileunitId)
- [msdyn_agentid](#BKMK_msdyn_agentid)
- [msdyn_availablecapacityprofileunits](#BKMK_msdyn_availablecapacityprofileunits)
- [msdyn_capacityprofileid](#BKMK_msdyn_capacityprofileid)
- [msdyn_consumedcapacityprofileunits](#BKMK_msdyn_consumedcapacityprofileunits)
- [msdyn_defaultmaxunits](#BKMK_msdyn_defaultmaxunits)
- [msdyn_isforceassignedprofile](#BKMK_msdyn_isforceassignedprofile)
- [msdyn_name](#BKMK_msdyn_name)
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

### <a name="BKMK_msdyn_agentcapacityprofileunitId"></a> msdyn_agentcapacityprofileunitId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Agent Capacity Profile Unit**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_agentcapacityprofileunitid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_agentid"></a> msdyn_agentid

|Property|Value|
|---|---|
|Description|**Lookup to SystemUser entity**|
|DisplayName|**Agent Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_availablecapacityprofileunits"></a> msdyn_availablecapacityprofileunits

|Property|Value|
|---|---|
|Description|**Available Capacity Profile Units**|
|DisplayName|**Available Capacity Profile Units**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_availablecapacityprofileunits`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_capacityprofileid"></a> msdyn_capacityprofileid

|Property|Value|
|---|---|
|Description|**Lookup to Capacity Profile entity**|
|DisplayName|**Capacity Profile Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_capacityprofileid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_capacityprofile|

### <a name="BKMK_msdyn_consumedcapacityprofileunits"></a> msdyn_consumedcapacityprofileunits

|Property|Value|
|---|---|
|Description|**Consumed Capacity Profile Units**|
|DisplayName|**Consumed Capacity Profile Units**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_consumedcapacityprofileunits`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_defaultmaxunits"></a> msdyn_defaultmaxunits

|Property|Value|
|---|---|
|Description|**Default Max Capacity Profile Units Configured for the Capacity profile**|
|DisplayName|**Default Max Capacity Profile Units Configured for the Capacity profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultmaxunits`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_isforceassignedprofile"></a> msdyn_isforceassignedprofile

|Property|Value|
|---|---|
|Description|**Indicates if this capacity profile is force assigned profile**|
|DisplayName|**Is Force Assigned Profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isforceassignedprofile`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentstatus_msdyn_isforceassignedprofile`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|Description|**Status of the Agent Capacity Profile Unit**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agentcapacityprofileunit_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Agent Capacity Profile Unit**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agentcapacityprofileunit_statuscode`|

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

- [business_unit_msdyn_agentcapacityprofileunit](#BKMK_business_unit_msdyn_agentcapacityprofileunit)
- [lk_msdyn_agentcapacityprofileunit_createdby](#BKMK_lk_msdyn_agentcapacityprofileunit_createdby)
- [lk_msdyn_agentcapacityprofileunit_createdonbehalfby](#BKMK_lk_msdyn_agentcapacityprofileunit_createdonbehalfby)
- [lk_msdyn_agentcapacityprofileunit_modifiedby](#BKMK_lk_msdyn_agentcapacityprofileunit_modifiedby)
- [lk_msdyn_agentcapacityprofileunit_modifiedonbehalfby](#BKMK_lk_msdyn_agentcapacityprofileunit_modifiedonbehalfby)
- [msdyn_capacityprofile_msdyn_agentcapacityprofileunit_capacityprofileid](#BKMK_msdyn_capacityprofile_msdyn_agentcapacityprofileunit_capacityprofileid)
- [msdyn_systemuser_msdyn_agentcapacityprofileunit_agentid](#BKMK_msdyn_systemuser_msdyn_agentcapacityprofileunit_agentid)
- [owner_msdyn_agentcapacityprofileunit](#BKMK_owner_msdyn_agentcapacityprofileunit)
- [team_msdyn_agentcapacityprofileunit](#BKMK_team_msdyn_agentcapacityprofileunit)
- [user_msdyn_agentcapacityprofileunit](#BKMK_user_msdyn_agentcapacityprofileunit)

### <a name="BKMK_business_unit_msdyn_agentcapacityprofileunit"></a> business_unit_msdyn_agentcapacityprofileunit

One-To-Many Relationship: [businessunit business_unit_msdyn_agentcapacityprofileunit](businessunit.md#BKMK_business_unit_msdyn_agentcapacityprofileunit)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentcapacityprofileunit_createdby"></a> lk_msdyn_agentcapacityprofileunit_createdby

One-To-Many Relationship: [systemuser lk_msdyn_agentcapacityprofileunit_createdby](systemuser.md#BKMK_lk_msdyn_agentcapacityprofileunit_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentcapacityprofileunit_createdonbehalfby"></a> lk_msdyn_agentcapacityprofileunit_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agentcapacityprofileunit_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agentcapacityprofileunit_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentcapacityprofileunit_modifiedby"></a> lk_msdyn_agentcapacityprofileunit_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_agentcapacityprofileunit_modifiedby](systemuser.md#BKMK_lk_msdyn_agentcapacityprofileunit_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentcapacityprofileunit_modifiedonbehalfby"></a> lk_msdyn_agentcapacityprofileunit_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agentcapacityprofileunit_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agentcapacityprofileunit_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_capacityprofile_msdyn_agentcapacityprofileunit_capacityprofileid"></a> msdyn_capacityprofile_msdyn_agentcapacityprofileunit_capacityprofileid

One-To-Many Relationship: [msdyn_capacityprofile msdyn_capacityprofile_msdyn_agentcapacityprofileunit_capacityprofileid](msdyn_capacityprofile.md#BKMK_msdyn_capacityprofile_msdyn_agentcapacityprofileunit_capacityprofileid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_capacityprofile`|
|ReferencedAttribute|`msdyn_capacityprofileid`|
|ReferencingAttribute|`msdyn_capacityprofileid`|
|ReferencingEntityNavigationPropertyName|`msdyn_capacityprofileid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_agentcapacityprofileunit_agentid"></a> msdyn_systemuser_msdyn_agentcapacityprofileunit_agentid

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_agentcapacityprofileunit_agentid](systemuser.md#BKMK_msdyn_systemuser_msdyn_agentcapacityprofileunit_agentid)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_agentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_agentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_agentcapacityprofileunit"></a> owner_msdyn_agentcapacityprofileunit

One-To-Many Relationship: [owner owner_msdyn_agentcapacityprofileunit](owner.md#BKMK_owner_msdyn_agentcapacityprofileunit)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_agentcapacityprofileunit"></a> team_msdyn_agentcapacityprofileunit

One-To-Many Relationship: [team team_msdyn_agentcapacityprofileunit](team.md#BKMK_team_msdyn_agentcapacityprofileunit)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_agentcapacityprofileunit"></a> user_msdyn_agentcapacityprofileunit

One-To-Many Relationship: [systemuser user_msdyn_agentcapacityprofileunit](systemuser.md#BKMK_user_msdyn_agentcapacityprofileunit)

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

- [msdyn_agentcapacityprofileunit_AsyncOperations](#BKMK_msdyn_agentcapacityprofileunit_AsyncOperations)
- [msdyn_agentcapacityprofileunit_BulkDeleteFailures](#BKMK_msdyn_agentcapacityprofileunit_BulkDeleteFailures)
- [msdyn_agentcapacityprofileunit_DuplicateBaseRecord](#BKMK_msdyn_agentcapacityprofileunit_DuplicateBaseRecord)
- [msdyn_agentcapacityprofileunit_DuplicateMatchingRecord](#BKMK_msdyn_agentcapacityprofileunit_DuplicateMatchingRecord)
- [msdyn_agentcapacityprofileunit_MailboxTrackingFolders](#BKMK_msdyn_agentcapacityprofileunit_MailboxTrackingFolders)
- [msdyn_agentcapacityprofileunit_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agentcapacityprofileunit_PrincipalObjectAttributeAccesses)
- [msdyn_agentcapacityprofileunit_ProcessSession](#BKMK_msdyn_agentcapacityprofileunit_ProcessSession)
- [msdyn_agentcapacityprofileunit_SyncErrors](#BKMK_msdyn_agentcapacityprofileunit_SyncErrors)

### <a name="BKMK_msdyn_agentcapacityprofileunit_AsyncOperations"></a> msdyn_agentcapacityprofileunit_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_agentcapacityprofileunit_AsyncOperations](asyncoperation.md#BKMK_msdyn_agentcapacityprofileunit_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityprofileunit_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityprofileunit_BulkDeleteFailures"></a> msdyn_agentcapacityprofileunit_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_agentcapacityprofileunit_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agentcapacityprofileunit_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityprofileunit_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityprofileunit_DuplicateBaseRecord"></a> msdyn_agentcapacityprofileunit_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_agentcapacityprofileunit_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agentcapacityprofileunit_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityprofileunit_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityprofileunit_DuplicateMatchingRecord"></a> msdyn_agentcapacityprofileunit_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_agentcapacityprofileunit_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agentcapacityprofileunit_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityprofileunit_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityprofileunit_MailboxTrackingFolders"></a> msdyn_agentcapacityprofileunit_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_agentcapacityprofileunit_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agentcapacityprofileunit_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityprofileunit_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityprofileunit_PrincipalObjectAttributeAccesses"></a> msdyn_agentcapacityprofileunit_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_agentcapacityprofileunit_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agentcapacityprofileunit_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityprofileunit_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityprofileunit_ProcessSession"></a> msdyn_agentcapacityprofileunit_ProcessSession

Many-To-One Relationship: [processsession msdyn_agentcapacityprofileunit_ProcessSession](processsession.md#BKMK_msdyn_agentcapacityprofileunit_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityprofileunit_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityprofileunit_SyncErrors"></a> msdyn_agentcapacityprofileunit_SyncErrors

Many-To-One Relationship: [syncerror msdyn_agentcapacityprofileunit_SyncErrors](syncerror.md#BKMK_msdyn_agentcapacityprofileunit_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityprofileunit_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

