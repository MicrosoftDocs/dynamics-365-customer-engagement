---
title: "Custom messaging account (msdyn_ocbotchannelregistration) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Custom messaging account (msdyn_ocbotchannelregistration) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Custom messaging account (msdyn_ocbotchannelregistration) table/entity reference

Bot channel registration used for channel integration

## Messages

The following table lists the messages for the Custom messaging account (msdyn_ocbotchannelregistration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocbotchannelregistrations(*msdyn_ocbotchannelregistrationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_ocbotchannelregistrations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocbotchannelregistrations(*msdyn_ocbotchannelregistrationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdyn_RetrieveCustomMessagingApplicationSecret`<br />Event: True |**msdyn_RetrieveCustomMessagingApplicationSecret action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocbotchannelregistrations(*msdyn_ocbotchannelregistrationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocbotchannelregistrations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocbotchannelregistrations(*msdyn_ocbotchannelregistrationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocbotchannelregistrations(*msdyn_ocbotchannelregistrationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocbotchannelregistrations(*msdyn_ocbotchannelregistrationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Custom messaging account (msdyn_ocbotchannelregistration) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Custom messaging account (msdyn_ocbotchannelregistration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Custom messaging account** |
| **DisplayCollectionName** | **Custom messaging accounts** |
| **SchemaName** | `msdyn_ocbotchannelregistration` |
| **CollectionSchemaName** | `msdyn_ocbotchannelregistrations` |
| **EntitySetName** | `msdyn_ocbotchannelregistrations`|
| **LogicalName** | `msdyn_ocbotchannelregistration` |
| **LogicalCollectionName** | `msdyn_ocbotchannelregistrations` |
| **PrimaryIdAttribute** | `msdyn_ocbotchannelregistrationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_communicationprovidersettingid](#BKMK_msdyn_communicationprovidersettingid)
- [msdyn_iscustommessagingbcr](#BKMK_msdyn_iscustommessagingbcr)
- [msdyn_iscustommessagingcreated](#BKMK_msdyn_iscustommessagingcreated)
- [msdyn_lastvalidateddate](#BKMK_msdyn_lastvalidateddate)
- [msdyn_messagingendpoint](#BKMK_msdyn_messagingendpoint)
- [msdyn_msappid](#BKMK_msdyn_msappid)
- [msdyn_msappsecret](#BKMK_msdyn_msappsecret)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocbotchannelregistrationId](#BKMK_msdyn_ocbotchannelregistrationId)
- [msdyn_ocfbapplicationid](#BKMK_msdyn_ocfbapplicationid)
- [msdyn_ocgbmagentaccount](#BKMK_msdyn_ocgbmagentaccount)
- [msdyn_ocgbmpartneraccount](#BKMK_msdyn_ocgbmpartneraccount)
- [msdyn_oclinechannelconfigid](#BKMK_msdyn_oclinechannelconfigid)
- [msdyn_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfigid)
- [msdyn_securemsappsecret](#BKMK_msdyn_securemsappsecret)
- [msdyn_validationstatus](#BKMK_msdyn_validationstatus)
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

### <a name="BKMK_msdyn_communicationprovidersettingid"></a> msdyn_communicationprovidersettingid

|Property|Value|
|---|---|
|Description|**Unique identifier for Communication Provider Setting associated with Bot Channel Registration.**|
|DisplayName|**Communication provider setting id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_communicationprovidersettingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_occommunicationprovidersetting|

### <a name="BKMK_msdyn_iscustommessagingbcr"></a> msdyn_iscustommessagingbcr

|Property|Value|
|---|---|
|Description|**Flag to indicate if BCR entity is related to Custom Messaging**|
|DisplayName|**Is Custom Messaging BCR**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iscustommessagingbcr`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocbotchannelregistration_msdyn_iscustommessagingbcr`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_iscustommessagingcreated"></a> msdyn_iscustommessagingcreated

|Property|Value|
|---|---|
|Description|**Flag to indicate if the record is newly created**|
|DisplayName|**Is Custom Messaging Created**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iscustommessagingcreated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocbotchannelregistration_msdyn_iscustommessagingcreated`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_lastvalidateddate"></a> msdyn_lastvalidateddate

|Property|Value|
|---|---|
|Description|**Microsoft app Id and secret last validated date.**|
|DisplayName|**Last validated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastvalidateddate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_messagingendpoint"></a> msdyn_messagingendpoint

|Property|Value|
|---|---|
|Description|**Messaging Endpoint (URL)**|
|DisplayName|**Messaging Endpoint (URL)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_messagingendpoint`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_msappid"></a> msdyn_msappid

|Property|Value|
|---|---|
|Description|**MS Application ID for the BCR**|
|DisplayName|**MS Application Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_msappid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_msappsecret"></a> msdyn_msappsecret

|Property|Value|
|---|---|
|Description|**Bot channel registration client secret**|
|DisplayName|**Client secret**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_msappsecret`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msdyn_ocbotchannelregistrationId"></a> msdyn_ocbotchannelregistrationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Bot Channel Registration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocbotchannelregistrationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ocfbapplicationid"></a> msdyn_ocfbapplicationid

|Property|Value|
|---|---|
|Description|**Related Facebook application**|
|DisplayName|**Facebook application**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfbapplicationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocfbapplication|

### <a name="BKMK_msdyn_ocgbmagentaccount"></a> msdyn_ocgbmagentaccount

|Property|Value|
|---|---|
|Description|**Google's Business Messages agent account id for the BCR**|
|DisplayName|**Google's Business Messages agent account id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocgbmagentaccount`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocgooglebusinessmessagesagentaccount|

### <a name="BKMK_msdyn_ocgbmpartneraccount"></a> msdyn_ocgbmpartneraccount

|Property|Value|
|---|---|
|Description|**Google's Business Messages partner account id of the BCR**|
|DisplayName|**Google's Business Messages partner account id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocgbmpartneraccount`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocgooglebusinessmessagespartneraccount|

### <a name="BKMK_msdyn_oclinechannelconfigid"></a> msdyn_oclinechannelconfigid

|Property|Value|
|---|---|
|Description|**Related Line Channel**|
|DisplayName|**Line Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_oclinechannelconfigid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_oclinechannelconfig|

### <a name="BKMK_msdyn_octeamschannelconfigid"></a> msdyn_octeamschannelconfigid

|Property|Value|
|---|---|
|Description|**Related Teams Channel**|
|DisplayName|**Teams Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_octeamschannelconfigid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_octeamschannelconfig|

### <a name="BKMK_msdyn_securemsappsecret"></a> msdyn_securemsappsecret

|Property|Value|
|---|---|
|Description|**Bot channel registration secure client secret**|
|DisplayName|**Secure Client secret**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_securemsappsecret`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_validationstatus"></a> msdyn_validationstatus

|Property|Value|
|---|---|
|Description|**Microsoft app ID and secert Validation status**|
|DisplayName|**Validation status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validationstatus`|
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
|Description|**Status of the Bot Channel Registration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocbotchannelregistration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Bot Channel Registration**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocbotchannelregistration_statuscode`|

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

- [business_unit_msdyn_ocbotchannelregistration](#BKMK_business_unit_msdyn_ocbotchannelregistration)
- [lk_msdyn_ocbotchannelregistration_createdby](#BKMK_lk_msdyn_ocbotchannelregistration_createdby)
- [lk_msdyn_ocbotchannelregistration_createdonbehalfby](#BKMK_lk_msdyn_ocbotchannelregistration_createdonbehalfby)
- [lk_msdyn_ocbotchannelregistration_modifiedby](#BKMK_lk_msdyn_ocbotchannelregistration_modifiedby)
- [lk_msdyn_ocbotchannelregistration_modifiedonbehalfby](#BKMK_lk_msdyn_ocbotchannelregistration_modifiedonbehalfby)
- [msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider](#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider)
- [msdyn_msdyn_ocfbapplication_msdyn_ocbotchannelregistration](#BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocbotchannelregistration)
- [msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount](#BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount)
- [msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount](#BKMK_msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount)
- [msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid](#BKMK_msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid)
- [msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid)
- [owner_msdyn_ocbotchannelregistration](#BKMK_owner_msdyn_ocbotchannelregistration)
- [team_msdyn_ocbotchannelregistration](#BKMK_team_msdyn_ocbotchannelregistration)
- [user_msdyn_ocbotchannelregistration](#BKMK_user_msdyn_ocbotchannelregistration)

### <a name="BKMK_business_unit_msdyn_ocbotchannelregistration"></a> business_unit_msdyn_ocbotchannelregistration

One-To-Many Relationship: [businessunit business_unit_msdyn_ocbotchannelregistration](businessunit.md#BKMK_business_unit_msdyn_ocbotchannelregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocbotchannelregistration_createdby"></a> lk_msdyn_ocbotchannelregistration_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocbotchannelregistration_createdby](systemuser.md#BKMK_lk_msdyn_ocbotchannelregistration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocbotchannelregistration_createdonbehalfby"></a> lk_msdyn_ocbotchannelregistration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocbotchannelregistration_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocbotchannelregistration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocbotchannelregistration_modifiedby"></a> lk_msdyn_ocbotchannelregistration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocbotchannelregistration_modifiedby](systemuser.md#BKMK_lk_msdyn_ocbotchannelregistration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocbotchannelregistration_modifiedonbehalfby"></a> lk_msdyn_ocbotchannelregistration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocbotchannelregistration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocbotchannelregistration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider"></a> msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider

One-To-Many Relationship: [msdyn_occommunicationprovidersetting msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider](msdyn_occommunicationprovidersetting.md#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersetting`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingid`|
|ReferencingAttribute|`msdyn_communicationprovidersettingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_communicationprovidersettingid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocbotchannelregistration"></a> msdyn_msdyn_ocfbapplication_msdyn_ocbotchannelregistration

One-To-Many Relationship: [msdyn_ocfbapplication msdyn_msdyn_ocfbapplication_msdyn_ocbotchannelregistration](msdyn_ocfbapplication.md#BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocbotchannelregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbapplication`|
|ReferencedAttribute|`msdyn_ocfbapplicationid`|
|ReferencingAttribute|`msdyn_ocfbapplicationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocfbapplicationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount"></a> msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagespartneraccount msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount](msdyn_ocgooglebusinessmessagespartneraccount.md#BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagespartneraccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagespartneraccountid`|
|ReferencingAttribute|`msdyn_ocgbmpartneraccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocgbmpartneraccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount"></a> msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagesagentaccount msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount](msdyn_ocgooglebusinessmessagesagentaccount.md#BKMK_msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagesagentaccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagesagentaccountid`|
|ReferencingAttribute|`msdyn_ocgbmagentaccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocgbmagentaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid"></a> msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid

One-To-Many Relationship: [msdyn_oclinechannelconfig msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid](msdyn_oclinechannelconfig.md#BKMK_msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclinechannelconfig`|
|ReferencedAttribute|`msdyn_oclinechannelconfigid`|
|ReferencingAttribute|`msdyn_oclinechannelconfigid`|
|ReferencingEntityNavigationPropertyName|`msdyn_oclinechannelconfigid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid"></a> msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid

One-To-Many Relationship: [msdyn_octeamschannelconfig msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid](msdyn_octeamschannelconfig.md#BKMK_msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octeamschannelconfig`|
|ReferencedAttribute|`msdyn_octeamschannelconfigid`|
|ReferencingAttribute|`msdyn_octeamschannelconfigid`|
|ReferencingEntityNavigationPropertyName|`msdyn_octeamschannelconfigid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocbotchannelregistration"></a> owner_msdyn_ocbotchannelregistration

One-To-Many Relationship: [owner owner_msdyn_ocbotchannelregistration](owner.md#BKMK_owner_msdyn_ocbotchannelregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocbotchannelregistration"></a> team_msdyn_ocbotchannelregistration

One-To-Many Relationship: [team team_msdyn_ocbotchannelregistration](team.md#BKMK_team_msdyn_ocbotchannelregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocbotchannelregistration"></a> user_msdyn_ocbotchannelregistration

One-To-Many Relationship: [systemuser user_msdyn_ocbotchannelregistration](systemuser.md#BKMK_user_msdyn_ocbotchannelregistration)

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

- [msdyn_msdyn_ocbotchannelregistration_msdyn_ocbotchannelregistrationsecret_ocbotchannelregistrationid](#BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_ocbotchannelregistrationsecret_ocbotchannelregistrationid)
- [msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration](#BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration)
- [msdyn_ocbotchannelregistration_AsyncOperations](#BKMK_msdyn_ocbotchannelregistration_AsyncOperations)
- [msdyn_ocbotchannelregistration_BulkDeleteFailures](#BKMK_msdyn_ocbotchannelregistration_BulkDeleteFailures)
- [msdyn_ocbotchannelregistration_DuplicateBaseRecord](#BKMK_msdyn_ocbotchannelregistration_DuplicateBaseRecord)
- [msdyn_ocbotchannelregistration_DuplicateMatchingRecord](#BKMK_msdyn_ocbotchannelregistration_DuplicateMatchingRecord)
- [msdyn_ocbotchannelregistration_MailboxTrackingFolders](#BKMK_msdyn_ocbotchannelregistration_MailboxTrackingFolders)
- [msdyn_ocbotchannelregistration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocbotchannelregistration_PrincipalObjectAttributeAccesses)
- [msdyn_ocbotchannelregistration_ProcessSession](#BKMK_msdyn_ocbotchannelregistration_ProcessSession)
- [msdyn_ocbotchannelregistration_SyncErrors](#BKMK_msdyn_ocbotchannelregistration_SyncErrors)

### <a name="BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_ocbotchannelregistrationsecret_ocbotchannelregistrationid"></a> msdyn_msdyn_ocbotchannelregistration_msdyn_ocbotchannelregistrationsecret_ocbotchannelregistrationid

Many-To-One Relationship: [msdyn_ocbotchannelregistrationsecret msdyn_msdyn_ocbotchannelregistration_msdyn_ocbotchannelregistrationsecret_ocbotchannelregistrationid](msdyn_ocbotchannelregistrationsecret.md#BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_ocbotchannelregistrationsecret_ocbotchannelregistrationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocbotchannelregistrationsecret`|
|ReferencingAttribute|`msdyn_ocbotchannelregistrationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocbotchannelregistration_msdyn_ocbotchannelregistrationsecret_ocbotchannelregistrationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration"></a> msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration

Many-To-One Relationship: [msdyn_occustommessagingchannel msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration](msdyn_occustommessagingchannel.md#BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occustommessagingchannel`|
|ReferencingAttribute|`msdyn_custombotchannelregistration`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocbotchannelregistration_AsyncOperations"></a> msdyn_ocbotchannelregistration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocbotchannelregistration_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocbotchannelregistration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocbotchannelregistration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocbotchannelregistration_BulkDeleteFailures"></a> msdyn_ocbotchannelregistration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocbotchannelregistration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocbotchannelregistration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocbotchannelregistration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocbotchannelregistration_DuplicateBaseRecord"></a> msdyn_ocbotchannelregistration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocbotchannelregistration_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocbotchannelregistration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocbotchannelregistration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocbotchannelregistration_DuplicateMatchingRecord"></a> msdyn_ocbotchannelregistration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocbotchannelregistration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocbotchannelregistration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocbotchannelregistration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocbotchannelregistration_MailboxTrackingFolders"></a> msdyn_ocbotchannelregistration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocbotchannelregistration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocbotchannelregistration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocbotchannelregistration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocbotchannelregistration_PrincipalObjectAttributeAccesses"></a> msdyn_ocbotchannelregistration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocbotchannelregistration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocbotchannelregistration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocbotchannelregistration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocbotchannelregistration_ProcessSession"></a> msdyn_ocbotchannelregistration_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocbotchannelregistration_ProcessSession](processsession.md#BKMK_msdyn_ocbotchannelregistration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocbotchannelregistration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocbotchannelregistration_SyncErrors"></a> msdyn_ocbotchannelregistration_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocbotchannelregistration_SyncErrors](syncerror.md#BKMK_msdyn_ocbotchannelregistration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocbotchannelregistration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

