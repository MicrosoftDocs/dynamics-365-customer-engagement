---
title: "Swarm (msdyn_swarm) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Swarm (msdyn_swarm) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Swarm (msdyn_swarm) table/entity reference (Microsoft Dynamics 365)

Tracks the list of swarms created by agents to resolve the customer issues

## Messages

The following table lists the messages for the Swarm (msdyn_swarm) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_swarms(*msdyn_swarmid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_swarms<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_swarms(*msdyn_swarmid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_swarms(*msdyn_swarmid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_swarms<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_swarms(*msdyn_swarmid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_swarms(*msdyn_swarmid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_swarms(*msdyn_swarmid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Swarm (msdyn_swarm) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Swarm** |
| **DisplayCollectionName** | **Swarms** |
| **SchemaName** | `msdyn_swarm` |
| **CollectionSchemaName** | `msdyn_swarms` |
| **EntitySetName** | `msdyn_swarms`|
| **LogicalName** | `msdyn_swarm` |
| **LogicalCollectionName** | `msdyn_swarms` |
| **PrimaryIdAttribute** | `msdyn_swarmid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_resolution](#BKMK_msdyn_resolution)
- [msdyn_skillsmodifiedon](#BKMK_msdyn_skillsmodifiedon)
- [msdyn_swarmId](#BKMK_msdyn_swarmId)
- [msdyn_swarmrelatedrecordid](#BKMK_msdyn_swarmrelatedrecordid)
- [msdyn_swarmrelatedrecordidIdType](#BKMK_msdyn_swarmrelatedrecordidIdType)
- [msdyn_swarmtemplateid](#BKMK_msdyn_swarmtemplateid)
- [msdyn_teamsconversationid](#BKMK_msdyn_teamsconversationid)
- [msdyn_title](#BKMK_msdyn_title)
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

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Swarm description elaborating the issue**|
|DisplayName|**Steps already tried**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50000|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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
|MaxLength|500|

### <a name="BKMK_msdyn_resolution"></a> msdyn_resolution

|Property|Value|
|---|---|
|Description|**Steps taken to resolve the swarm**|
|DisplayName|**Resolution**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resolution`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msdyn_skillsmodifiedon"></a> msdyn_skillsmodifiedon

|Property|Value|
|---|---|
|Description|**Date and time when the skills were modified.**|
|DisplayName|**Skills modified on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_skillsmodifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_swarmId"></a> msdyn_swarmId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Swarm**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_swarmid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_swarmrelatedrecordid"></a> msdyn_swarmrelatedrecordid

|Property|Value|
|---|---|
|Description|**Lookup to the swarm related record**|
|DisplayName|**Swarm related record**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_swarmrelatedrecordid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|account, incident|

### <a name="BKMK_msdyn_swarmrelatedrecordidIdType"></a> msdyn_swarmrelatedrecordidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_swarmrelatedrecordididtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_swarmtemplateid"></a> msdyn_swarmtemplateid

|Property|Value|
|---|---|
|Description|**Lookup to the swarm template record**|
|DisplayName|**Swarm template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_swarmtemplateid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_swarmtemplate|

### <a name="BKMK_msdyn_teamsconversationid"></a> msdyn_teamsconversationid

|Property|Value|
|---|---|
|Description|**Identifier of the Teams group chat that is created to work on the swarm**|
|DisplayName|**Teams conversation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_teamsconversationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_title"></a> msdyn_title

|Property|Value|
|---|---|
|Description|**Title of the swarm**|
|DisplayName|**Swarm request**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_title`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

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
|Description|**Status of the Swarm**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_swarm_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350000<br />InvariantName: `Active`|
|1|Label: **Resolved**<br />DefaultStatus: 192350001<br />InvariantName: `Resolved`|
|2|Label: **Cancelled**<br />DefaultStatus: 192350002<br />InvariantName: `Cancelled`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Swarm**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|ApplicationRequired|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_swarm_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|192350000|Label: **Active**<br />State:0<br />TransitionData: None|
|192350001|Label: **Resolved**<br />State:1<br />TransitionData: None|
|192350002|Label: **Case resolved**<br />State:2<br />TransitionData: None|
|192350003|Label: **No one joined**<br />State:2<br />TransitionData: None|
|192350004|Label: **Duplicate swarm**<br />State:2<br />TransitionData: None|
|192350005|Label: **System resolved**<br />State:1<br />TransitionData: None|
|192350006|Label: **System cancelled**<br />State:2<br />TransitionData: None|

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

- [business_unit_msdyn_swarm](#BKMK_business_unit_msdyn_swarm)
- [lk_msdyn_swarm_createdby](#BKMK_lk_msdyn_swarm_createdby)
- [lk_msdyn_swarm_createdonbehalfby](#BKMK_lk_msdyn_swarm_createdonbehalfby)
- [lk_msdyn_swarm_modifiedby](#BKMK_lk_msdyn_swarm_modifiedby)
- [lk_msdyn_swarm_modifiedonbehalfby](#BKMK_lk_msdyn_swarm_modifiedonbehalfby)
- [msdyn_msdyn_swarmtemplate_msdyn_swarm_swarmtemplateid](#BKMK_msdyn_msdyn_swarmtemplate_msdyn_swarm_swarmtemplateid)
- [msdyn_swarm_account](#BKMK_msdyn_swarm_account)
- [msdyn_swarm_incident](#BKMK_msdyn_swarm_incident)
- [owner_msdyn_swarm](#BKMK_owner_msdyn_swarm)
- [team_msdyn_swarm](#BKMK_team_msdyn_swarm)
- [user_msdyn_swarm](#BKMK_user_msdyn_swarm)

### <a name="BKMK_business_unit_msdyn_swarm"></a> business_unit_msdyn_swarm

One-To-Many Relationship: [businessunit business_unit_msdyn_swarm](businessunit.md#BKMK_business_unit_msdyn_swarm)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_swarm_createdby"></a> lk_msdyn_swarm_createdby

One-To-Many Relationship: [systemuser lk_msdyn_swarm_createdby](systemuser.md#BKMK_lk_msdyn_swarm_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_swarm_createdonbehalfby"></a> lk_msdyn_swarm_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_swarm_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_swarm_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_swarm_modifiedby"></a> lk_msdyn_swarm_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_swarm_modifiedby](systemuser.md#BKMK_lk_msdyn_swarm_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_swarm_modifiedonbehalfby"></a> lk_msdyn_swarm_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_swarm_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_swarm_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_swarmtemplate_msdyn_swarm_swarmtemplateid"></a> msdyn_msdyn_swarmtemplate_msdyn_swarm_swarmtemplateid

One-To-Many Relationship: [msdyn_swarmtemplate msdyn_msdyn_swarmtemplate_msdyn_swarm_swarmtemplateid](msdyn_swarmtemplate.md#BKMK_msdyn_msdyn_swarmtemplate_msdyn_swarm_swarmtemplateid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarmtemplate`|
|ReferencedAttribute|`msdyn_swarmtemplateid`|
|ReferencingAttribute|`msdyn_swarmtemplateid`|
|ReferencingEntityNavigationPropertyName|`msdyn_swarmtemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_swarm_account"></a> msdyn_swarm_account

One-To-Many Relationship: [account msdyn_swarm_account](account.md#BKMK_msdyn_swarm_account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_swarmrelatedrecordid`|
|ReferencingEntityNavigationPropertyName|`msdyn_swarmrelatedrecordid_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_swarm_incident"></a> msdyn_swarm_incident

One-To-Many Relationship: [incident msdyn_swarm_incident](incident.md#BKMK_msdyn_swarm_incident)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_swarmrelatedrecordid`|
|ReferencingEntityNavigationPropertyName|`msdyn_swarmrelatedrecordid_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_swarm"></a> owner_msdyn_swarm

One-To-Many Relationship: [owner owner_msdyn_swarm](owner.md#BKMK_owner_msdyn_swarm)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_swarm"></a> team_msdyn_swarm

One-To-Many Relationship: [team team_msdyn_swarm](team.md#BKMK_team_msdyn_swarm)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_swarm"></a> user_msdyn_swarm

One-To-Many Relationship: [systemuser user_msdyn_swarm](systemuser.md#BKMK_user_msdyn_swarm)

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

- [msdyn_msdyn_swarm_msdyn_swarmparticipant_swarmid](#BKMK_msdyn_msdyn_swarm_msdyn_swarmparticipant_swarmid)
- [msdyn_msdyn_swarm_msdyn_swarmskill_swarmid](#BKMK_msdyn_msdyn_swarm_msdyn_swarmskill_swarmid)
- [msdyn_swarm_ActivityPointers](#BKMK_msdyn_swarm_ActivityPointers)
- [msdyn_swarm_adx_inviteredemptions](#BKMK_msdyn_swarm_adx_inviteredemptions)
- [msdyn_swarm_adx_portalcomments](#BKMK_msdyn_swarm_adx_portalcomments)
- [msdyn_swarm_Annotations](#BKMK_msdyn_swarm_Annotations)
- [msdyn_swarm_Appointments](#BKMK_msdyn_swarm_Appointments)
- [msdyn_swarm_AsyncOperations](#BKMK_msdyn_swarm_AsyncOperations)
- [msdyn_swarm_BulkDeleteFailures](#BKMK_msdyn_swarm_BulkDeleteFailures)
- [msdyn_swarm_chats](#BKMK_msdyn_swarm_chats)
- [msdyn_swarm_DuplicateBaseRecord](#BKMK_msdyn_swarm_DuplicateBaseRecord)
- [msdyn_swarm_DuplicateMatchingRecord](#BKMK_msdyn_swarm_DuplicateMatchingRecord)
- [msdyn_swarm_Emails](#BKMK_msdyn_swarm_Emails)
- [msdyn_swarm_Faxes](#BKMK_msdyn_swarm_Faxes)
- [msdyn_swarm_Letters](#BKMK_msdyn_swarm_Letters)
- [msdyn_swarm_MailboxTrackingFolders](#BKMK_msdyn_swarm_MailboxTrackingFolders)
- [msdyn_swarm_msdyn_copilottranscripts](#BKMK_msdyn_swarm_msdyn_copilottranscripts)
- [msdyn_swarm_msdyn_ocliveworkitems](#BKMK_msdyn_swarm_msdyn_ocliveworkitems)
- [msdyn_swarm_msdyn_ocsessions](#BKMK_msdyn_swarm_msdyn_ocsessions)
- [msdyn_swarm_msfp_alerts](#BKMK_msdyn_swarm_msfp_alerts)
- [msdyn_swarm_msfp_surveyinvites](#BKMK_msdyn_swarm_msfp_surveyinvites)
- [msdyn_swarm_msfp_surveyresponses](#BKMK_msdyn_swarm_msfp_surveyresponses)
- [msdyn_swarm_PhoneCalls](#BKMK_msdyn_swarm_PhoneCalls)
- [msdyn_swarm_PostFollows](#BKMK_msdyn_swarm_PostFollows)
- [msdyn_swarm_PostRegardings](#BKMK_msdyn_swarm_PostRegardings)
- [msdyn_swarm_Posts](#BKMK_msdyn_swarm_Posts)
- [msdyn_swarm_PrincipalObjectAttributeAccesses](#BKMK_msdyn_swarm_PrincipalObjectAttributeAccesses)
- [msdyn_swarm_ProcessSession](#BKMK_msdyn_swarm_ProcessSession)
- [msdyn_swarm_RecurringAppointmentMasters](#BKMK_msdyn_swarm_RecurringAppointmentMasters)
- [msdyn_swarm_ServiceAppointments](#BKMK_msdyn_swarm_ServiceAppointments)
- [msdyn_swarm_SocialActivities](#BKMK_msdyn_swarm_SocialActivities)
- [msdyn_swarm_SyncErrors](#BKMK_msdyn_swarm_SyncErrors)
- [msdyn_swarm_Tasks](#BKMK_msdyn_swarm_Tasks)

### <a name="BKMK_msdyn_msdyn_swarm_msdyn_swarmparticipant_swarmid"></a> msdyn_msdyn_swarm_msdyn_swarmparticipant_swarmid

Many-To-One Relationship: [msdyn_swarmparticipant msdyn_msdyn_swarm_msdyn_swarmparticipant_swarmid](msdyn_swarmparticipant.md#BKMK_msdyn_msdyn_swarm_msdyn_swarmparticipant_swarmid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmparticipant`|
|ReferencingAttribute|`msdyn_swarmid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_swarm_msdyn_swarmparticipant_swarmid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_swarm_msdyn_swarmskill_swarmid"></a> msdyn_msdyn_swarm_msdyn_swarmskill_swarmid

Many-To-One Relationship: [msdyn_swarmskill msdyn_msdyn_swarm_msdyn_swarmskill_swarmid](msdyn_swarmskill.md#BKMK_msdyn_msdyn_swarm_msdyn_swarmskill_swarmid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmskill`|
|ReferencingAttribute|`msdyn_swarmid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_swarm_msdyn_swarmskill_swarmid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_ActivityPointers"></a> msdyn_swarm_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_swarm_ActivityPointers](activitypointer.md#BKMK_msdyn_swarm_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_adx_inviteredemptions"></a> msdyn_swarm_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_swarm_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_swarm_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_adx_portalcomments"></a> msdyn_swarm_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_swarm_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_swarm_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_Annotations"></a> msdyn_swarm_Annotations

Many-To-One Relationship: [annotation msdyn_swarm_Annotations](annotation.md#BKMK_msdyn_swarm_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_Appointments"></a> msdyn_swarm_Appointments

Many-To-One Relationship: [appointment msdyn_swarm_Appointments](appointment.md#BKMK_msdyn_swarm_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_AsyncOperations"></a> msdyn_swarm_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_swarm_AsyncOperations](asyncoperation.md#BKMK_msdyn_swarm_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_BulkDeleteFailures"></a> msdyn_swarm_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_swarm_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_swarm_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_chats"></a> msdyn_swarm_chats

Many-To-One Relationship: [chat msdyn_swarm_chats](chat.md#BKMK_msdyn_swarm_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_DuplicateBaseRecord"></a> msdyn_swarm_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_swarm_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_swarm_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_DuplicateMatchingRecord"></a> msdyn_swarm_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_swarm_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_swarm_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_Emails"></a> msdyn_swarm_Emails

Many-To-One Relationship: [email msdyn_swarm_Emails](email.md#BKMK_msdyn_swarm_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_Faxes"></a> msdyn_swarm_Faxes

Many-To-One Relationship: [fax msdyn_swarm_Faxes](fax.md#BKMK_msdyn_swarm_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_Letters"></a> msdyn_swarm_Letters

Many-To-One Relationship: [letter msdyn_swarm_Letters](letter.md#BKMK_msdyn_swarm_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_MailboxTrackingFolders"></a> msdyn_swarm_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_swarm_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_swarm_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_msdyn_copilottranscripts"></a> msdyn_swarm_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_swarm_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_swarm_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_msdyn_ocliveworkitems"></a> msdyn_swarm_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_swarm_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_swarm_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_msdyn_ocsessions"></a> msdyn_swarm_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_swarm_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_swarm_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_msfp_alerts"></a> msdyn_swarm_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_swarm_msfp_alerts](msfp_alert.md#BKMK_msdyn_swarm_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_msfp_surveyinvites"></a> msdyn_swarm_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_swarm_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_swarm_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_msfp_surveyresponses"></a> msdyn_swarm_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_swarm_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_swarm_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_PhoneCalls"></a> msdyn_swarm_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_swarm_PhoneCalls](phonecall.md#BKMK_msdyn_swarm_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_PostFollows"></a> msdyn_swarm_PostFollows

Many-To-One Relationship: [postfollow msdyn_swarm_PostFollows](postfollow.md#BKMK_msdyn_swarm_PostFollows)

|Property|Value|
|---|---|
|ReferencingEntity|`postfollow`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_PostFollows`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_PostRegardings"></a> msdyn_swarm_PostRegardings

Many-To-One Relationship: [postregarding msdyn_swarm_PostRegardings](postregarding.md#BKMK_msdyn_swarm_PostRegardings)

|Property|Value|
|---|---|
|ReferencingEntity|`postregarding`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_PostRegardings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_Posts"></a> msdyn_swarm_Posts

Many-To-One Relationship: [post msdyn_swarm_Posts](post.md#BKMK_msdyn_swarm_Posts)

|Property|Value|
|---|---|
|ReferencingEntity|`post`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_Posts`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_PrincipalObjectAttributeAccesses"></a> msdyn_swarm_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_swarm_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_swarm_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_ProcessSession"></a> msdyn_swarm_ProcessSession

Many-To-One Relationship: [processsession msdyn_swarm_ProcessSession](processsession.md#BKMK_msdyn_swarm_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_RecurringAppointmentMasters"></a> msdyn_swarm_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_swarm_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_swarm_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_ServiceAppointments"></a> msdyn_swarm_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_swarm_ServiceAppointments](serviceappointment.md#BKMK_msdyn_swarm_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_SocialActivities"></a> msdyn_swarm_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_swarm_SocialActivities](socialactivity.md#BKMK_msdyn_swarm_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_SyncErrors"></a> msdyn_swarm_SyncErrors

Many-To-One Relationship: [syncerror msdyn_swarm_SyncErrors](syncerror.md#BKMK_msdyn_swarm_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_Tasks"></a> msdyn_swarm_Tasks

Many-To-One Relationship: [task msdyn_swarm_Tasks](task.md#BKMK_msdyn_swarm_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

