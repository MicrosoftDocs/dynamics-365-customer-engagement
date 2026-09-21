---
title: "Channel instance secret (msdyn_channelinstancesecret) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Channel instance secret (msdyn_channelinstancesecret) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# Channel instance secret (msdyn_channelinstancesecret) table/entity reference (Microsoft Dynamics 365 Field Service)



## Messages

The following table lists the messages for the Channel instance secret (msdyn_channelinstancesecret) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_channelinstancesecrets(*msdyn_channelinstancesecretid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_channelinstancesecrets<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_channelinstancesecrets(*msdyn_channelinstancesecretid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_channelinstancesecrets(*msdyn_channelinstancesecretid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_channelinstancesecrets<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_channelinstancesecrets(*msdyn_channelinstancesecretid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_channelinstancesecrets(*msdyn_channelinstancesecretid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_channelinstancesecrets(*msdyn_channelinstancesecretid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Channel instance secret (msdyn_channelinstancesecret) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Channel instance secret** |
| **DisplayCollectionName** | **channelinstancesecrets** |
| **SchemaName** | `msdyn_channelinstancesecret` |
| **CollectionSchemaName** | `msdyn_channelinstancesecrets` |
| **EntitySetName** | `msdyn_channelinstancesecrets`|
| **LogicalName** | `msdyn_channelinstancesecret` |
| **LogicalCollectionName** | `msdyn_channelinstancesecrets` |
| **PrimaryIdAttribute** | `msdyn_channelinstancesecretid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_channelinstancesecretId](#BKMK_msdyn_channelinstancesecretId)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_SecretValue](#BKMK_msdyn_SecretValue)
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

### <a name="BKMK_msdyn_channelinstancesecretId"></a> msdyn_channelinstancesecretId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Channel instance secret**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_channelinstancesecretid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msdyn_SecretValue"></a> msdyn_SecretValue

|Property|Value|
|---|---|
|Description|**Secret value of the Omnichannel Secret**|
|DisplayName|**Secret Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_secretvalue`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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
|Description|**Status of the Channel instance secret**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_channelinstancesecret_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Channel instance secret**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_channelinstancesecret_statuscode`|

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

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_channelinstancesecret_msdyn_livechatconfig_translationproviderapikey](#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_livechatconfig_translationproviderapikey)
- [msdyn_msdyn_channelinstancesecret_msdyn_msdyn_azurenotificationhub_connectionstring](#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_msdyn_azurenotificationhub_connectionstring)
- [msdyn_msdyn_channelinstancesecret_msdyn_ocapplebusinessaccount_translationproviderapikey](#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocapplebusinessaccount_translationproviderapikey)
- [msdyn_msdyn_channelinstancesecret_msdyn_occustommessagingchannel_translationproviderapikey](#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_occustommessagingchannel_translationproviderapikey)
- [msdyn_msdyn_channelinstancesecret_msdyn_ocfbpage_translationproviderapikey](#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocfbpage_translationproviderapikey)
- [msdyn_msdyn_channelinstancesecret_msdyn_oclinechannelconfig_translationproviderapikey](#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_oclinechannelconfig_translationproviderapikey)
- [msdyn_msdyn_channelinstancesecret_msdyn_ocsmschannelsetting_translationproviderapikey](#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocsmschannelsetting_translationproviderapikey)
- [msdyn_msdyn_channelinstancesecret_msdyn_octeamschannelconfig_translationproviderapikey](#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_octeamschannelconfig_translationproviderapikey)
- [msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelaccount_provideracsconnectionstring](#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelaccount_provideracsconnectionstring)
- [msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelnumber_translationproviderapikey](#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelnumber_translationproviderapikey)

### <a name="BKMK_msdyn_msdyn_channelinstancesecret_msdyn_livechatconfig_translationproviderapikey"></a> msdyn_msdyn_channelinstancesecret_msdyn_livechatconfig_translationproviderapikey

Many-To-One Relationship: [msdyn_livechatconfig msdyn_msdyn_channelinstancesecret_msdyn_livechatconfig_translationproviderapikey](msdyn_livechatconfig.md#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_livechatconfig_translationproviderapikey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatconfig`|
|ReferencingAttribute|`msdyn_translationproviderapikeyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstancesecret_msdyn_livechatconfig_translationproviderapikey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelinstancesecret_msdyn_msdyn_azurenotificationhub_connectionstring"></a> msdyn_msdyn_channelinstancesecret_msdyn_msdyn_azurenotificationhub_connectionstring

Many-To-One Relationship: [msdyn_azurenotificationhub msdyn_msdyn_channelinstancesecret_msdyn_msdyn_azurenotificationhub_connectionstring](msdyn_azurenotificationhub.md#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_msdyn_azurenotificationhub_connectionstring)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_azurenotificationhub`|
|ReferencingAttribute|`msdyn_connectionstringid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstancesecret_msdyn_msdyn_azurenotificationhub_connectionstring`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocapplebusinessaccount_translationproviderapikey"></a> msdyn_msdyn_channelinstancesecret_msdyn_ocapplebusinessaccount_translationproviderapikey

Many-To-One Relationship: [msdyn_ocapplebusinessaccount msdyn_msdyn_channelinstancesecret_msdyn_ocapplebusinessaccount_translationproviderapikey](msdyn_ocapplebusinessaccount.md#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocapplebusinessaccount_translationproviderapikey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplebusinessaccount`|
|ReferencingAttribute|`msdyn_translationproviderapikeyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstancesecret_msdyn_ocapplebusinessaccount_translationproviderapikey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelinstancesecret_msdyn_occustommessagingchannel_translationproviderapikey"></a> msdyn_msdyn_channelinstancesecret_msdyn_occustommessagingchannel_translationproviderapikey

Many-To-One Relationship: [msdyn_occustommessagingchannel msdyn_msdyn_channelinstancesecret_msdyn_occustommessagingchannel_translationproviderapikey](msdyn_occustommessagingchannel.md#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_occustommessagingchannel_translationproviderapikey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occustommessagingchannel`|
|ReferencingAttribute|`msdyn_translationproviderapikeyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstancesecret_msdyn_occustommessagingchannel_translationproviderapikey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocfbpage_translationproviderapikey"></a> msdyn_msdyn_channelinstancesecret_msdyn_ocfbpage_translationproviderapikey

Many-To-One Relationship: [msdyn_ocfbpage msdyn_msdyn_channelinstancesecret_msdyn_ocfbpage_translationproviderapikey](msdyn_ocfbpage.md#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocfbpage_translationproviderapikey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocfbpage`|
|ReferencingAttribute|`msdyn_translationproviderapikeyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstancesecret_msdyn_ocfbpage_translationproviderapikey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelinstancesecret_msdyn_oclinechannelconfig_translationproviderapikey"></a> msdyn_msdyn_channelinstancesecret_msdyn_oclinechannelconfig_translationproviderapikey

Many-To-One Relationship: [msdyn_oclinechannelconfig msdyn_msdyn_channelinstancesecret_msdyn_oclinechannelconfig_translationproviderapikey](msdyn_oclinechannelconfig.md#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_oclinechannelconfig_translationproviderapikey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oclinechannelconfig`|
|ReferencingAttribute|`msdyn_translationproviderapikeyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstancesecret_msdyn_oclinechannelconfig_translationproviderapikey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocsmschannelsetting_translationproviderapikey"></a> msdyn_msdyn_channelinstancesecret_msdyn_ocsmschannelsetting_translationproviderapikey

Many-To-One Relationship: [msdyn_ocsmschannelsetting msdyn_msdyn_channelinstancesecret_msdyn_ocsmschannelsetting_translationproviderapikey](msdyn_ocsmschannelsetting.md#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocsmschannelsetting_translationproviderapikey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsmschannelsetting`|
|ReferencingAttribute|`msdyn_translationproviderapikeyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstancesecret_msdyn_ocsmschannelsetting_translationproviderapikey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelinstancesecret_msdyn_octeamschannelconfig_translationproviderapikey"></a> msdyn_msdyn_channelinstancesecret_msdyn_octeamschannelconfig_translationproviderapikey

Many-To-One Relationship: [msdyn_octeamschannelconfig msdyn_msdyn_channelinstancesecret_msdyn_octeamschannelconfig_translationproviderapikey](msdyn_octeamschannelconfig.md#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_octeamschannelconfig_translationproviderapikey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octeamschannelconfig`|
|ReferencingAttribute|`msdyn_translationproviderapikeyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstancesecret_msdyn_octeamschannelconfig_translationproviderapikey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelaccount_provideracsconnectionstring"></a> msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelaccount_provideracsconnectionstring

Many-To-One Relationship: [msdyn_ocwhatsappchannelaccount msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelaccount_provideracsconnectionstring](msdyn_ocwhatsappchannelaccount.md#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelaccount_provideracsconnectionstring)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwhatsappchannelaccount`|
|ReferencingAttribute|`msdyn_provideracsconnectionstringid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelaccount_provideracsconnectionstring`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelnumber_translationproviderapikey"></a> msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelnumber_translationproviderapikey

Many-To-One Relationship: [msdyn_ocwhatsappchannelnumber msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelnumber_translationproviderapikey](msdyn_ocwhatsappchannelnumber.md#BKMK_msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelnumber_translationproviderapikey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwhatsappchannelnumber`|
|ReferencingAttribute|`msdyn_translationproviderapikeyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_channelinstancesecret_msdyn_ocwhatsappchannelnumber_translationproviderapikey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

