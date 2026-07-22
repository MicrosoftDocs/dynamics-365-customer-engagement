---
title: "Channel Instance (msdyn_ChannelInstance) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Channel Instance (msdyn_ChannelInstance) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Channel Instance (msdyn_ChannelInstance) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Channel Instance (msdyn_ChannelInstance) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_channelinstances(*msdyn_channelinstanceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_channelinstances<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_channelinstances(*msdyn_channelinstanceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_channelinstances(*msdyn_channelinstanceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_channelinstances<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_channelinstances(*msdyn_channelinstanceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_channelinstances(*msdyn_channelinstanceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_channelinstances(*msdyn_channelinstanceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Channel Instance (msdyn_ChannelInstance) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Channel Instance** |
| **DisplayCollectionName** | **Channel Instances** |
| **SchemaName** | `msdyn_ChannelInstance` |
| **CollectionSchemaName** | `msdyn_ChannelInstances` |
| **EntitySetName** | `msdyn_channelinstances`|
| **LogicalName** | `msdyn_channelinstance` |
| **LogicalCollectionName** | `msdyn_channelinstances` |
| **PrimaryIdAttribute** | `msdyn_channelinstanceid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ChannelDefinitionId](#BKMK_msdyn_ChannelDefinitionId)
- [msdyn_ChannelInstanceAccountId](#BKMK_msdyn_ChannelInstanceAccountId)
- [msdyn_ChannelInstanceId](#BKMK_msdyn_ChannelInstanceId)
- [msdyn_ConsumingApplicationId](#BKMK_msdyn_ConsumingApplicationId)
- [msdyn_ContactPoint](#BKMK_msdyn_ContactPoint)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_extendedentityId](#BKMK_msdyn_extendedentityId)
- [msdyn_extendedentityIdType](#BKMK_msdyn_extendedentityIdType)
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

### <a name="BKMK_msdyn_ChannelDefinitionId"></a> msdyn_ChannelDefinitionId

|Property|Value|
|---|---|
|Description|**Reference to Channel Definition of this Channel Instance**|
|DisplayName|**Channel Definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channeldefinitionid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_channeldefinition|

### <a name="BKMK_msdyn_ChannelInstanceAccountId"></a> msdyn_ChannelInstanceAccountId

|Property|Value|
|---|---|
|Description|**Lookup to Channel Instance Account**|
|DisplayName|**Channel Instance Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channelinstanceaccountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_channelinstanceaccount|

### <a name="BKMK_msdyn_ChannelInstanceId"></a> msdyn_ChannelInstanceId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Channel Instance**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_channelinstanceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ConsumingApplicationId"></a> msdyn_ConsumingApplicationId

|Property|Value|
|---|---|
|Description|**Consuming Applications using channel extensibility**|
|DisplayName|**Consuming Applications**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_consumingapplicationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_consumingapplication|

### <a name="BKMK_msdyn_ContactPoint"></a> msdyn_ContactPoint

|Property|Value|
|---|---|
|Description|**Channel contact point, eg. social handle**|
|DisplayName|**Contact Point**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_contactpoint`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_extendedentityId"></a> msdyn_extendedentityId

|Property|Value|
|---|---|
|Description|**LookUp for Extended Entities brought in by custom channels.**|
|DisplayName|**Extended Entity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_extendedentityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_byoacschannelinstance, msdynmkt_infobipchannelinstance, msdynmkt_linkmobilitychannelinstance, msdynmkt_mocksmsproviderchannelinstance, msdynmkt_telesignchannelinstance, msdynmkt_twiliochannelinstance, msdynmkt_vibeschannelinstance, msdyn_defextendedchannelinstance|

### <a name="BKMK_msdyn_extendedentityIdType"></a> msdyn_extendedentityIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_extendedentityidtype`|
|RequiredLevel|None|
|Type|EntityName|

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
|Description|**Status of the Channel Instance**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_channelinstance_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Channel Instance**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_channelinstance_statuscode`|

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

- [business_unit_msdyn_channelinstance](#BKMK_business_unit_msdyn_channelinstance)
- [lk_msdyn_channelinstance_createdby](#BKMK_lk_msdyn_channelinstance_createdby)
- [lk_msdyn_channelinstance_createdonbehalfby](#BKMK_lk_msdyn_channelinstance_createdonbehalfby)
- [lk_msdyn_channelinstance_modifiedby](#BKMK_lk_msdyn_channelinstance_modifiedby)
- [lk_msdyn_channelinstance_modifiedonbehalfby](#BKMK_lk_msdyn_channelinstance_modifiedonbehalfby)
- [msdyn_ChannelInstance_extendedentityid_msdynmkt_byoacschannelinstance](#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_byoacschannelinstance)
- [msdyn_ChannelInstance_extendedentityid_msdynmkt_infobipchannelinstance](#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_infobipchannelinstance)
- [msdyn_ChannelInstance_extendedentityid_msdynmkt_linkmobilitychannelinstance](#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_linkmobilitychannelinstance)
- [msdyn_ChannelInstance_extendedentityid_msdynmkt_mocksmsproviderchannelinstance](#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_mocksmsproviderchannelinstance)
- [msdyn_ChannelInstance_extendedentityid_msdynmkt_telesignchannelinstance](#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_telesignchannelinstance)
- [msdyn_ChannelInstance_extendedentityid_msdynmkt_twiliochannelinstance](#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_twiliochannelinstance)
- [msdyn_ChannelInstance_extendedentityid_msdynmkt_vibeschannelinstance](#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_vibeschannelinstance)
- [msdyn_msdyn_channelinstance_ChannelDefinition_m](#BKMK_msdyn_msdyn_channelinstance_ChannelDefinition_m)
- [msdyn_msdyn_channelinstance_ChannelInstanceAcco](#BKMK_msdyn_msdyn_channelinstance_ChannelInstanceAcco)
- [msdyn_msdyn_channelinstance_ConsumingApplication_msdyn_a](#BKMK_msdyn_msdyn_channelinstance_ConsumingApplication_msdyn_a)
- [owner_msdyn_channelinstance](#BKMK_owner_msdyn_channelinstance)
- [team_msdyn_channelinstance](#BKMK_team_msdyn_channelinstance)
- [user_msdyn_channelinstance](#BKMK_user_msdyn_channelinstance)

### <a name="BKMK_business_unit_msdyn_channelinstance"></a> business_unit_msdyn_channelinstance

One-To-Many Relationship: [businessunit business_unit_msdyn_channelinstance](businessunit.md#BKMK_business_unit_msdyn_channelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channelinstance_createdby"></a> lk_msdyn_channelinstance_createdby

One-To-Many Relationship: [systemuser lk_msdyn_channelinstance_createdby](systemuser.md#BKMK_lk_msdyn_channelinstance_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channelinstance_createdonbehalfby"></a> lk_msdyn_channelinstance_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_channelinstance_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_channelinstance_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channelinstance_modifiedby"></a> lk_msdyn_channelinstance_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_channelinstance_modifiedby](systemuser.md#BKMK_lk_msdyn_channelinstance_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channelinstance_modifiedonbehalfby"></a> lk_msdyn_channelinstance_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_channelinstance_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_channelinstance_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_byoacschannelinstance"></a> msdyn_ChannelInstance_extendedentityid_msdynmkt_byoacschannelinstance

One-To-Many Relationship: [msdynmkt_byoacschannelinstance msdyn_ChannelInstance_extendedentityid_msdynmkt_byoacschannelinstance](msdynmkt_byoacschannelinstance.md#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_byoacschannelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_byoacschannelinstance`|
|ReferencedAttribute|`msdynmkt_byoacschannelinstanceid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_byoacschannelinstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_infobipchannelinstance"></a> msdyn_ChannelInstance_extendedentityid_msdynmkt_infobipchannelinstance

One-To-Many Relationship: [msdynmkt_infobipchannelinstance msdyn_ChannelInstance_extendedentityid_msdynmkt_infobipchannelinstance](msdynmkt_infobipchannelinstance.md#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_infobipchannelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_infobipchannelinstance`|
|ReferencedAttribute|`msdynmkt_infobipchannelinstanceid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_infobipchannelinstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_linkmobilitychannelinstance"></a> msdyn_ChannelInstance_extendedentityid_msdynmkt_linkmobilitychannelinstance

One-To-Many Relationship: [msdynmkt_linkmobilitychannelinstance msdyn_ChannelInstance_extendedentityid_msdynmkt_linkmobilitychannelinstance](msdynmkt_linkmobilitychannelinstance.md#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_linkmobilitychannelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_linkmobilitychannelinstance`|
|ReferencedAttribute|`msdynmkt_linkmobilitychannelinstanceid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_linkmobilitychannelinstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_mocksmsproviderchannelinstance"></a> msdyn_ChannelInstance_extendedentityid_msdynmkt_mocksmsproviderchannelinstance

One-To-Many Relationship: [msdynmkt_mocksmsproviderchannelinstance msdyn_ChannelInstance_extendedentityid_msdynmkt_mocksmsproviderchannelinstance](msdynmkt_mocksmsproviderchannelinstance.md#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_mocksmsproviderchannelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_mocksmsproviderchannelinstance`|
|ReferencedAttribute|`msdynmkt_mocksmsproviderchannelinstanceid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_mocksmsproviderchannelinstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_telesignchannelinstance"></a> msdyn_ChannelInstance_extendedentityid_msdynmkt_telesignchannelinstance

One-To-Many Relationship: [msdynmkt_telesignchannelinstance msdyn_ChannelInstance_extendedentityid_msdynmkt_telesignchannelinstance](msdynmkt_telesignchannelinstance.md#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_telesignchannelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_telesignchannelinstance`|
|ReferencedAttribute|`msdynmkt_telesignchannelinstanceid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_telesignchannelinstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_twiliochannelinstance"></a> msdyn_ChannelInstance_extendedentityid_msdynmkt_twiliochannelinstance

One-To-Many Relationship: [msdynmkt_twiliochannelinstance msdyn_ChannelInstance_extendedentityid_msdynmkt_twiliochannelinstance](msdynmkt_twiliochannelinstance.md#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_twiliochannelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_twiliochannelinstance`|
|ReferencedAttribute|`msdynmkt_twiliochannelinstanceid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_twiliochannelinstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_vibeschannelinstance"></a> msdyn_ChannelInstance_extendedentityid_msdynmkt_vibeschannelinstance

One-To-Many Relationship: [msdynmkt_vibeschannelinstance msdyn_ChannelInstance_extendedentityid_msdynmkt_vibeschannelinstance](msdynmkt_vibeschannelinstance.md#BKMK_msdyn_ChannelInstance_extendedentityid_msdynmkt_vibeschannelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_vibeschannelinstance`|
|ReferencedAttribute|`msdynmkt_vibeschannelinstanceid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_vibeschannelinstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_channelinstance_ChannelDefinition_m"></a> msdyn_msdyn_channelinstance_ChannelDefinition_m

One-To-Many Relationship: [msdyn_channeldefinition msdyn_msdyn_channelinstance_ChannelDefinition_m](msdyn_channeldefinition.md#BKMK_msdyn_msdyn_channelinstance_ChannelDefinition_m)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channeldefinition`|
|ReferencedAttribute|`msdyn_channeldefinitionid`|
|ReferencingAttribute|`msdyn_channeldefinitionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ChannelDefinitionId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_channelinstance_ChannelInstanceAcco"></a> msdyn_msdyn_channelinstance_ChannelInstanceAcco

One-To-Many Relationship: [msdyn_channelinstanceaccount msdyn_msdyn_channelinstance_ChannelInstanceAcco](msdyn_channelinstanceaccount.md#BKMK_msdyn_msdyn_channelinstance_ChannelInstanceAcco)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channelinstanceaccount`|
|ReferencedAttribute|`msdyn_channelinstanceaccountid`|
|ReferencingAttribute|`msdyn_channelinstanceaccountid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ChannelInstanceAccountId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_channelinstance_ConsumingApplication_msdyn_a"></a> msdyn_msdyn_channelinstance_ConsumingApplication_msdyn_a

One-To-Many Relationship: [msdyn_consumingapplication msdyn_msdyn_channelinstance_ConsumingApplication_msdyn_a](msdyn_consumingapplication.md#BKMK_msdyn_msdyn_channelinstance_ConsumingApplication_msdyn_a)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_consumingapplication`|
|ReferencedAttribute|`msdyn_consumingapplicationid`|
|ReferencingAttribute|`msdyn_consumingapplicationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ConsumingApplicationId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_channelinstance"></a> owner_msdyn_channelinstance

One-To-Many Relationship: [owner owner_msdyn_channelinstance](owner.md#BKMK_owner_msdyn_channelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_channelinstance"></a> team_msdyn_channelinstance

One-To-Many Relationship: [team team_msdyn_channelinstance](team.md#BKMK_team_msdyn_channelinstance)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_channelinstance"></a> user_msdyn_channelinstance

One-To-Many Relationship: [systemuser user_msdyn_channelinstance](systemuser.md#BKMK_user_msdyn_channelinstance)

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

- [msdyn_channelinstance_AsyncOperations](#BKMK_msdyn_channelinstance_AsyncOperations)
- [msdyn_channelinstance_BulkDeleteFailures](#BKMK_msdyn_channelinstance_BulkDeleteFailures)
- [msdyn_channelinstance_DuplicateBaseRecord](#BKMK_msdyn_channelinstance_DuplicateBaseRecord)
- [msdyn_channelinstance_DuplicateMatchingRecord](#BKMK_msdyn_channelinstance_DuplicateMatchingRecord)
- [msdyn_channelinstance_MailboxTrackingFolders](#BKMK_msdyn_channelinstance_MailboxTrackingFolders)
- [msdyn_channelinstance_PrincipalObjectAttributeAccesses](#BKMK_msdyn_channelinstance_PrincipalObjectAttributeAccesses)
- [msdyn_channelinstance_ProcessSession](#BKMK_msdyn_channelinstance_ProcessSession)
- [msdyn_channelinstance_SyncErrors](#BKMK_msdyn_channelinstance_SyncErrors)
- [msdyn_msdyn_liveworkitem_msdyn_channelinstance](#BKMK_msdyn_msdyn_liveworkitem_msdyn_channelinstance)
- [msdyn_msdyn_ocsession_msdyn_channelinstance](#BKMK_msdyn_msdyn_ocsession_msdyn_channelinstance)
- [msdyn_msdyn_transcript_msdyn_channelinstance](#BKMK_msdyn_msdyn_transcript_msdyn_channelinstance)

### <a name="BKMK_msdyn_channelinstance_AsyncOperations"></a> msdyn_channelinstance_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_channelinstance_AsyncOperations](asyncoperation.md#BKMK_msdyn_channelinstance_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstance_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstance_BulkDeleteFailures"></a> msdyn_channelinstance_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_channelinstance_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_channelinstance_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstance_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstance_DuplicateBaseRecord"></a> msdyn_channelinstance_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_channelinstance_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_channelinstance_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstance_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstance_DuplicateMatchingRecord"></a> msdyn_channelinstance_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_channelinstance_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_channelinstance_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstance_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstance_MailboxTrackingFolders"></a> msdyn_channelinstance_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_channelinstance_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_channelinstance_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstance_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstance_PrincipalObjectAttributeAccesses"></a> msdyn_channelinstance_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_channelinstance_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_channelinstance_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstance_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstance_ProcessSession"></a> msdyn_channelinstance_ProcessSession

Many-To-One Relationship: [processsession msdyn_channelinstance_ProcessSession](processsession.md#BKMK_msdyn_channelinstance_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstance_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstance_SyncErrors"></a> msdyn_channelinstance_SyncErrors

Many-To-One Relationship: [syncerror msdyn_channelinstance_SyncErrors](syncerror.md#BKMK_msdyn_channelinstance_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstance_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_liveworkitem_msdyn_channelinstance"></a> msdyn_msdyn_liveworkitem_msdyn_channelinstance

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_msdyn_liveworkitem_msdyn_channelinstance](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_liveworkitem_msdyn_channelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_channelinstanceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_liveworkitem_msdyn_channelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocsession_msdyn_channelinstance"></a> msdyn_msdyn_ocsession_msdyn_channelinstance

Many-To-One Relationship: [msdyn_ocsession msdyn_msdyn_ocsession_msdyn_channelinstance](msdyn_ocsession.md#BKMK_msdyn_msdyn_ocsession_msdyn_channelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`msdyn_channelinstanceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocsession_msdyn_channelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_transcript_msdyn_channelinstance"></a> msdyn_msdyn_transcript_msdyn_channelinstance

Many-To-One Relationship: [msdyn_transcript msdyn_msdyn_transcript_msdyn_channelinstance](msdyn_transcript.md#BKMK_msdyn_msdyn_transcript_msdyn_channelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`msdyn_channelinstanceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_transcript_msdyn_channelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

