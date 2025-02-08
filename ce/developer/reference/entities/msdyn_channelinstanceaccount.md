---
title: "Channel Instance Account (msdyn_ChannelInstanceAccount) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Channel Instance Account (msdyn_ChannelInstanceAccount) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Channel Instance Account (msdyn_ChannelInstanceAccount) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Channel Instance Account (msdyn_ChannelInstanceAccount) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_channelinstanceaccounts(*msdyn_channelinstanceaccountid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_channelinstanceaccounts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_channelinstanceaccounts(*msdyn_channelinstanceaccountid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_channelinstanceaccounts(*msdyn_channelinstanceaccountid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_channelinstanceaccounts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_channelinstanceaccounts(*msdyn_channelinstanceaccountid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_channelinstanceaccounts(*msdyn_channelinstanceaccountid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_channelinstanceaccounts(*msdyn_channelinstanceaccountid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Channel Instance Account (msdyn_ChannelInstanceAccount) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Channel Instance Account** |
| **DisplayCollectionName** | **Channel Instance Accounts** |
| **SchemaName** | `msdyn_ChannelInstanceAccount` |
| **CollectionSchemaName** | `msdyn_ChannelInstanceAccounts` |
| **EntitySetName** | `msdyn_channelinstanceaccounts`|
| **LogicalName** | `msdyn_channelinstanceaccount` |
| **LogicalCollectionName** | `msdyn_channelinstanceaccounts` |
| **PrimaryIdAttribute** | `msdyn_channelinstanceaccountid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ChannelDefinitionId](#BKMK_msdyn_ChannelDefinitionId)
- [msdyn_ChannelInstanceAccountId](#BKMK_msdyn_ChannelInstanceAccountId)
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
|Description|**Lookup to Channel Definition entity record.**|
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
|Description|**Unique identifier for entity instances**|
|DisplayName|**Channel Instance Account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_channelinstanceaccountid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Targets|msdynmkt_byoacschannelinstanceaccount, msdynmkt_infobipchannelinstanceaccount, msdynmkt_linkmobilitychannelinstanceaccount, msdynmkt_mocksmsproviderchannelinstanceaccount, msdynmkt_telesignchannelinstanceaccount, msdynmkt_twiliochannelinstanceaccount, msdynmkt_vibeschannelinstanceaccount, msdyn_defextendedchannelinstanceaccount|

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
|Description|**Status of the Channel Instance Account**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_channelinstanceaccount_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Channel Instance Account**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_channelinstanceaccount_statuscode`|

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

- [business_unit_msdyn_channelinstanceaccount](#BKMK_business_unit_msdyn_channelinstanceaccount)
- [lk_msdyn_channelinstanceaccount_createdby](#BKMK_lk_msdyn_channelinstanceaccount_createdby)
- [lk_msdyn_channelinstanceaccount_createdonbehalfby](#BKMK_lk_msdyn_channelinstanceaccount_createdonbehalfby)
- [lk_msdyn_channelinstanceaccount_modifiedby](#BKMK_lk_msdyn_channelinstanceaccount_modifiedby)
- [lk_msdyn_channelinstanceaccount_modifiedonbehalfby](#BKMK_lk_msdyn_channelinstanceaccount_modifiedonbehalfby)
- [msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_byoacschannelinstanceaccount](#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_byoacschannelinstanceaccount)
- [msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_infobipchannelinstanceaccount](#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_infobipchannelinstanceaccount)
- [msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_linkmobilitychannelinstanceaccount](#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_linkmobilitychannelinstanceaccount)
- [msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount](#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount)
- [msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_telesignchannelinstanceaccount](#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_telesignchannelinstanceaccount)
- [msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_twiliochannelinstanceaccount](#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_twiliochannelinstanceaccount)
- [msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_vibeschannelinstanceaccount](#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_vibeschannelinstanceaccount)
- [msdyn_msdyn_channelinstanceaccount_ChannelDefin](#BKMK_msdyn_msdyn_channelinstanceaccount_ChannelDefin)
- [owner_msdyn_channelinstanceaccount](#BKMK_owner_msdyn_channelinstanceaccount)
- [team_msdyn_channelinstanceaccount](#BKMK_team_msdyn_channelinstanceaccount)
- [user_msdyn_channelinstanceaccount](#BKMK_user_msdyn_channelinstanceaccount)

### <a name="BKMK_business_unit_msdyn_channelinstanceaccount"></a> business_unit_msdyn_channelinstanceaccount

One-To-Many Relationship: [businessunit business_unit_msdyn_channelinstanceaccount](businessunit.md#BKMK_business_unit_msdyn_channelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channelinstanceaccount_createdby"></a> lk_msdyn_channelinstanceaccount_createdby

One-To-Many Relationship: [systemuser lk_msdyn_channelinstanceaccount_createdby](systemuser.md#BKMK_lk_msdyn_channelinstanceaccount_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channelinstanceaccount_createdonbehalfby"></a> lk_msdyn_channelinstanceaccount_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_channelinstanceaccount_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_channelinstanceaccount_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channelinstanceaccount_modifiedby"></a> lk_msdyn_channelinstanceaccount_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_channelinstanceaccount_modifiedby](systemuser.md#BKMK_lk_msdyn_channelinstanceaccount_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_channelinstanceaccount_modifiedonbehalfby"></a> lk_msdyn_channelinstanceaccount_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_channelinstanceaccount_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_channelinstanceaccount_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_byoacschannelinstanceaccount"></a> msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_byoacschannelinstanceaccount

One-To-Many Relationship: [msdynmkt_byoacschannelinstanceaccount msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_byoacschannelinstanceaccount](msdynmkt_byoacschannelinstanceaccount.md#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_byoacschannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_byoacschannelinstanceaccount`|
|ReferencedAttribute|`msdynmkt_byoacschannelinstanceaccountid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_byoacschannelinstanceaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_infobipchannelinstanceaccount"></a> msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_infobipchannelinstanceaccount

One-To-Many Relationship: [msdynmkt_infobipchannelinstanceaccount msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_infobipchannelinstanceaccount](msdynmkt_infobipchannelinstanceaccount.md#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_infobipchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_infobipchannelinstanceaccount`|
|ReferencedAttribute|`msdynmkt_infobipchannelinstanceaccountid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_infobipchannelinstanceaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_linkmobilitychannelinstanceaccount"></a> msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_linkmobilitychannelinstanceaccount

One-To-Many Relationship: [msdynmkt_linkmobilitychannelinstanceaccount msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_linkmobilitychannelinstanceaccount](msdynmkt_linkmobilitychannelinstanceaccount.md#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_linkmobilitychannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_linkmobilitychannelinstanceaccount`|
|ReferencedAttribute|`msdynmkt_linkmobilitychannelinstanceaccountid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_linkmobilitychannelinstanceaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount"></a> msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount

One-To-Many Relationship: [msdynmkt_mocksmsproviderchannelinstanceaccount msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount](msdynmkt_mocksmsproviderchannelinstanceaccount.md#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_mocksmsproviderchannelinstanceaccount`|
|ReferencedAttribute|`msdynmkt_mocksmsproviderchannelinstanceaccountid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_mocksmsproviderchannelinstanceaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_telesignchannelinstanceaccount"></a> msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_telesignchannelinstanceaccount

One-To-Many Relationship: [msdynmkt_telesignchannelinstanceaccount msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_telesignchannelinstanceaccount](msdynmkt_telesignchannelinstanceaccount.md#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_telesignchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_telesignchannelinstanceaccount`|
|ReferencedAttribute|`msdynmkt_telesignchannelinstanceaccountid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_telesignchannelinstanceaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_twiliochannelinstanceaccount"></a> msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_twiliochannelinstanceaccount

One-To-Many Relationship: [msdynmkt_twiliochannelinstanceaccount msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_twiliochannelinstanceaccount](msdynmkt_twiliochannelinstanceaccount.md#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_twiliochannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_twiliochannelinstanceaccount`|
|ReferencedAttribute|`msdynmkt_twiliochannelinstanceaccountid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_twiliochannelinstanceaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_vibeschannelinstanceaccount"></a> msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_vibeschannelinstanceaccount

One-To-Many Relationship: [msdynmkt_vibeschannelinstanceaccount msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_vibeschannelinstanceaccount](msdynmkt_vibeschannelinstanceaccount.md#BKMK_msdyn_ChannelInstanceAccount_extendedentityid_msdynmkt_vibeschannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_vibeschannelinstanceaccount`|
|ReferencedAttribute|`msdynmkt_vibeschannelinstanceaccountid`|
|ReferencingAttribute|`msdyn_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_extendedentityid_msdynmkt_vibeschannelinstanceaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_channelinstanceaccount_ChannelDefin"></a> msdyn_msdyn_channelinstanceaccount_ChannelDefin

One-To-Many Relationship: [msdyn_channeldefinition msdyn_msdyn_channelinstanceaccount_ChannelDefin](msdyn_channeldefinition.md#BKMK_msdyn_msdyn_channelinstanceaccount_ChannelDefin)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channeldefinition`|
|ReferencedAttribute|`msdyn_channeldefinitionid`|
|ReferencingAttribute|`msdyn_channeldefinitionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ChannelDefinitionId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_channelinstanceaccount"></a> owner_msdyn_channelinstanceaccount

One-To-Many Relationship: [owner owner_msdyn_channelinstanceaccount](owner.md#BKMK_owner_msdyn_channelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_channelinstanceaccount"></a> team_msdyn_channelinstanceaccount

One-To-Many Relationship: [team team_msdyn_channelinstanceaccount](team.md#BKMK_team_msdyn_channelinstanceaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_channelinstanceaccount"></a> user_msdyn_channelinstanceaccount

One-To-Many Relationship: [systemuser user_msdyn_channelinstanceaccount](systemuser.md#BKMK_user_msdyn_channelinstanceaccount)

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

- [msdyn_channelinstanceaccount_AsyncOperations](#BKMK_msdyn_channelinstanceaccount_AsyncOperations)
- [msdyn_channelinstanceaccount_BulkDeleteFailures](#BKMK_msdyn_channelinstanceaccount_BulkDeleteFailures)
- [msdyn_channelinstanceaccount_DuplicateBaseRecord](#BKMK_msdyn_channelinstanceaccount_DuplicateBaseRecord)
- [msdyn_channelinstanceaccount_DuplicateMatchingRecord](#BKMK_msdyn_channelinstanceaccount_DuplicateMatchingRecord)
- [msdyn_channelinstanceaccount_MailboxTrackingFolders](#BKMK_msdyn_channelinstanceaccount_MailboxTrackingFolders)
- [msdyn_channelinstanceaccount_PrincipalObjectAttributeAccesses](#BKMK_msdyn_channelinstanceaccount_PrincipalObjectAttributeAccesses)
- [msdyn_channelinstanceaccount_ProcessSession](#BKMK_msdyn_channelinstanceaccount_ProcessSession)
- [msdyn_channelinstanceaccount_SyncErrors](#BKMK_msdyn_channelinstanceaccount_SyncErrors)
- [msdyn_msdyn_channelinstance_ChannelInstanceAcco](#BKMK_msdyn_msdyn_channelinstance_ChannelInstanceAcco)

### <a name="BKMK_msdyn_channelinstanceaccount_AsyncOperations"></a> msdyn_channelinstanceaccount_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_channelinstanceaccount_AsyncOperations](asyncoperation.md#BKMK_msdyn_channelinstanceaccount_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstanceaccount_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstanceaccount_BulkDeleteFailures"></a> msdyn_channelinstanceaccount_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_channelinstanceaccount_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_channelinstanceaccount_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstanceaccount_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstanceaccount_DuplicateBaseRecord"></a> msdyn_channelinstanceaccount_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_channelinstanceaccount_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_channelinstanceaccount_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstanceaccount_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstanceaccount_DuplicateMatchingRecord"></a> msdyn_channelinstanceaccount_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_channelinstanceaccount_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_channelinstanceaccount_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstanceaccount_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstanceaccount_MailboxTrackingFolders"></a> msdyn_channelinstanceaccount_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_channelinstanceaccount_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_channelinstanceaccount_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstanceaccount_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstanceaccount_PrincipalObjectAttributeAccesses"></a> msdyn_channelinstanceaccount_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_channelinstanceaccount_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_channelinstanceaccount_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstanceaccount_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstanceaccount_ProcessSession"></a> msdyn_channelinstanceaccount_ProcessSession

Many-To-One Relationship: [processsession msdyn_channelinstanceaccount_ProcessSession](processsession.md#BKMK_msdyn_channelinstanceaccount_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstanceaccount_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_channelinstanceaccount_SyncErrors"></a> msdyn_channelinstanceaccount_SyncErrors

Many-To-One Relationship: [syncerror msdyn_channelinstanceaccount_SyncErrors](syncerror.md#BKMK_msdyn_channelinstanceaccount_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_channelinstanceaccount_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelinstance_ChannelInstanceAcco"></a> msdyn_msdyn_channelinstance_ChannelInstanceAcco

Many-To-One Relationship: [msdyn_channelinstance msdyn_msdyn_channelinstance_ChannelInstanceAcco](msdyn_channelinstance.md#BKMK_msdyn_msdyn_channelinstance_ChannelInstanceAcco)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstance`|
|ReferencingAttribute|`msdyn_channelinstanceaccountid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstance_ChannelInstanceAcco`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

