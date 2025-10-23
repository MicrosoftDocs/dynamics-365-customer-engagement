---
title: "Outbound Configuration (msdyn_ocoutboundconfiguration) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Outbound Configuration (msdyn_ocoutboundconfiguration) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Outbound Configuration (msdyn_ocoutboundconfiguration) table/entity reference (Microsoft Dynamics 365 Customer Service)

Stores the Omnichannel outbound messaging configuration settings.

## Messages

The following table lists the messages for the Outbound Configuration (msdyn_ocoutboundconfiguration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocoutboundconfigurationes(*msdyn_ocoutboundconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocoutboundconfigurationes<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocoutboundconfigurationes(*msdyn_ocoutboundconfigurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocoutboundconfigurationes(*msdyn_ocoutboundconfigurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocoutboundconfigurationes<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocoutboundconfigurationes(*msdyn_ocoutboundconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocoutboundconfigurationes(*msdyn_ocoutboundconfigurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocoutboundconfigurationes(*msdyn_ocoutboundconfigurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Outbound Configuration (msdyn_ocoutboundconfiguration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Outbound Configuration** |
| **DisplayCollectionName** | **Outbound Configurations** |
| **SchemaName** | `msdyn_ocoutboundconfiguration` |
| **CollectionSchemaName** | `msdyn_ocoutboundconfigurations` |
| **EntitySetName** | `msdyn_ocoutboundconfigurationes`|
| **LogicalName** | `msdyn_ocoutboundconfiguration` |
| **LogicalCollectionName** | `msdyn_ocoutboundconfigurations` |
| **PrimaryIdAttribute** | `msdyn_ocoutboundconfigurationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_channel](#BKMK_msdyn_channel)
- [msdyn_channeldisplayname](#BKMK_msdyn_channeldisplayname)
- [msdyn_channelid](#BKMK_msdyn_channelid)
- [msdyn_defaultlocale](#BKMK_msdyn_defaultlocale)
- [msdyn_displayoutboundconfigurationid](#BKMK_msdyn_displayoutboundconfigurationid)
- [msdyn_enablemessagelogging](#BKMK_msdyn_enablemessagelogging)
- [msdyn_liveworkstreamid](#BKMK_msdyn_liveworkstreamid)
- [msdyn_messagetemplate](#BKMK_msdyn_messagetemplate)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocoutboundconfigurationId](#BKMK_msdyn_ocoutboundconfigurationId)
- [msdyn_ocscope](#BKMK_msdyn_ocscope)
- [msdyn_secondarychanneldisplayname](#BKMK_msdyn_secondarychanneldisplayname)
- [msdyn_secondarychannelid](#BKMK_msdyn_secondarychannelid)
- [msdyn_showinactivities](#BKMK_msdyn_showinactivities)
- [msdyn_type](#BKMK_msdyn_type)
- [msdyn_usecustomerpreference](#BKMK_msdyn_usecustomerpreference)
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

### <a name="BKMK_msdyn_channel"></a> msdyn_channel

|Property|Value|
|---|---|
|Description|**Channel type**|
|DisplayName|**Channel type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channel`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_streamsource`|

#### msdyn_channel Choices/Options

|Value|Label|
|---|---|
|19241000|**Microsoft Teams**|
|192300000|**WhatsApp**|
|192310000|**LINE**|
|192320000|**WeChat**|
|192330000|**Facebook**|
|192340000|**SMS**|
|192350000|**Entity Records**|
|192350001|**Twitter**|
|192350002|**Custom**|
|192360000|**Live chat**|
|192370000|**Voice**|
|192380000|**Video**|
|192390000|**Co-browse**|
|192400000|**Screen sharing**|
|192440000|**Voice call**|
|192450000|**Apple Messages for Business**|
|192450001|**Google's Business Messages**|

### <a name="BKMK_msdyn_channeldisplayname"></a> msdyn_channeldisplayname

|Property|Value|
|---|---|
|Description|**User-friendly description of the selected channel.**|
|DisplayName|**Channel Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channeldisplayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_channelid"></a> msdyn_channelid

|Property|Value|
|---|---|
|Description|**Unique Identifier for Channel associated with the channel selected**|
|DisplayName|**Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_channelid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_defaultlocale"></a> msdyn_defaultlocale

|Property|Value|
|---|---|
|Description|**Deprecated - This language will be used if there’s no customer preferred language or message template in customer's language.**|
|DisplayName|**Deprecated - Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultlocale`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_oclanguage|

### <a name="BKMK_msdyn_displayoutboundconfigurationid"></a> msdyn_displayoutboundconfigurationid

|Property|Value|
|---|---|
|Description|**Configuration ID**|
|DisplayName|**Configuration ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayoutboundconfigurationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_enablemessagelogging"></a> msdyn_enablemessagelogging

|Property|Value|
|---|---|
|Description|**Enable Message Logging**|
|DisplayName|**Enable Message Logging**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablemessagelogging`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocoutboundconfiguration_msdyn_enablemessagelogging`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_liveworkstreamid"></a> msdyn_liveworkstreamid

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Stream associated with Outbound Configuration**|
|DisplayName|**Work Stream (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_liveworkstreamid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_liveworkstream|

### <a name="BKMK_msdyn_messagetemplate"></a> msdyn_messagetemplate

|Property|Value|
|---|---|
|Description|**Message template**|
|DisplayName|**Message template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_messagetemplate`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_ocsystemmessage|

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

### <a name="BKMK_msdyn_ocoutboundconfigurationId"></a> msdyn_ocoutboundconfigurationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Outbound Configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocoutboundconfigurationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ocscope"></a> msdyn_ocscope

|Property|Value|
|---|---|
|Description|**Scope of the outbound configuration**|
|DisplayName|**Scope (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocscope`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|837500000|
|GlobalChoiceName|`msdyn_scope`|

#### msdyn_ocscope Choices/Options

|Value|Label|
|---|---|
|837500000|**Global**|
|837500001|**Workstream**|

### <a name="BKMK_msdyn_secondarychanneldisplayname"></a> msdyn_secondarychanneldisplayname

|Property|Value|
|---|---|
|Description|**User-friendly description of the selected secondary channel.**|
|DisplayName|**Secondary Channel Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_secondarychanneldisplayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_secondarychannelid"></a> msdyn_secondarychannelid

|Property|Value|
|---|---|
|Description|**Secondary identifier associated with the channel selected.**|
|DisplayName|**Secondary Channel ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_secondarychannelid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_showinactivities"></a> msdyn_showinactivities

|Property|Value|
|---|---|
|Description|**If this is turned on, outbound activity record will be created in CRM.**|
|DisplayName|**Show in timeline**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_showinactivities`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocoutboundconfiguration_msdyn_showinactivities`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_type"></a> msdyn_type

|Property|Value|
|---|---|
|Description|**Conversation record**|
|DisplayName|**Conversation record**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdyn_messagetype`|

#### msdyn_type Choices/Options

|Value|Label|
|---|---|
|100000000|**Create conversation when customer responds**|
|100000001|**Create conversation on send**|

### <a name="BKMK_msdyn_usecustomerpreference"></a> msdyn_usecustomerpreference

|Property|Value|
|---|---|
|Description|**Use Customer Preferred channel**|
|DisplayName|**Use Customer Preferred channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_usecustomerpreference`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocoutboundconfiguration_msdyn_usecustomerpreference`|
|DefaultValue|False|
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
|Description|**Status of the Outbound Configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocoutboundconfiguration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Outbound Configuration**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocoutboundconfiguration_statuscode`|

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

- [business_unit_msdyn_ocoutboundconfiguration](#BKMK_business_unit_msdyn_ocoutboundconfiguration)
- [lk_msdyn_ocoutboundconfiguration_createdby](#BKMK_lk_msdyn_ocoutboundconfiguration_createdby)
- [lk_msdyn_ocoutboundconfiguration_createdonbehalfby](#BKMK_lk_msdyn_ocoutboundconfiguration_createdonbehalfby)
- [lk_msdyn_ocoutboundconfiguration_modifiedby](#BKMK_lk_msdyn_ocoutboundconfiguration_modifiedby)
- [lk_msdyn_ocoutboundconfiguration_modifiedonbehalfby](#BKMK_lk_msdyn_ocoutboundconfiguration_modifiedonbehalfby)
- [msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale)
- [msdyn_msdyn_ocoutboundconfiguration_msdyn_liveworkstream](#BKMK_msdyn_msdyn_ocoutboundconfiguration_msdyn_liveworkstream)
- [msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate](#BKMK_msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate)
- [owner_msdyn_ocoutboundconfiguration](#BKMK_owner_msdyn_ocoutboundconfiguration)
- [team_msdyn_ocoutboundconfiguration](#BKMK_team_msdyn_ocoutboundconfiguration)
- [user_msdyn_ocoutboundconfiguration](#BKMK_user_msdyn_ocoutboundconfiguration)

### <a name="BKMK_business_unit_msdyn_ocoutboundconfiguration"></a> business_unit_msdyn_ocoutboundconfiguration

One-To-Many Relationship: [businessunit business_unit_msdyn_ocoutboundconfiguration](businessunit.md#BKMK_business_unit_msdyn_ocoutboundconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocoutboundconfiguration_createdby"></a> lk_msdyn_ocoutboundconfiguration_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocoutboundconfiguration_createdby](systemuser.md#BKMK_lk_msdyn_ocoutboundconfiguration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocoutboundconfiguration_createdonbehalfby"></a> lk_msdyn_ocoutboundconfiguration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocoutboundconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocoutboundconfiguration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocoutboundconfiguration_modifiedby"></a> lk_msdyn_ocoutboundconfiguration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocoutboundconfiguration_modifiedby](systemuser.md#BKMK_lk_msdyn_ocoutboundconfiguration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocoutboundconfiguration_modifiedonbehalfby"></a> lk_msdyn_ocoutboundconfiguration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocoutboundconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocoutboundconfiguration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale"></a> msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale

One-To-Many Relationship: [msdyn_oclanguage msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale](msdyn_oclanguage.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclanguage`|
|ReferencedAttribute|`msdyn_oclanguageid`|
|ReferencingAttribute|`msdyn_defaultlocale`|
|ReferencingEntityNavigationPropertyName|`msdyn_defaultlocale`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocoutboundconfiguration_msdyn_liveworkstream"></a> msdyn_msdyn_ocoutboundconfiguration_msdyn_liveworkstream

One-To-Many Relationship: [msdyn_liveworkstream msdyn_msdyn_ocoutboundconfiguration_msdyn_liveworkstream](msdyn_liveworkstream.md#BKMK_msdyn_msdyn_ocoutboundconfiguration_msdyn_liveworkstream)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_liveworkstreamid`|
|ReferencingEntityNavigationPropertyName|`msdyn_liveworkstreamid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate"></a> msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate

One-To-Many Relationship: [msdyn_ocsystemmessage msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate](msdyn_ocsystemmessage.md#BKMK_msdyn_msdyn_ocsystemmessage_msdyn_ocoutboundconfiguration_messagetemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsystemmessage`|
|ReferencedAttribute|`msdyn_ocsystemmessageid`|
|ReferencingAttribute|`msdyn_messagetemplate`|
|ReferencingEntityNavigationPropertyName|`msdyn_messagetemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocoutboundconfiguration"></a> owner_msdyn_ocoutboundconfiguration

One-To-Many Relationship: [owner owner_msdyn_ocoutboundconfiguration](owner.md#BKMK_owner_msdyn_ocoutboundconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocoutboundconfiguration"></a> team_msdyn_ocoutboundconfiguration

One-To-Many Relationship: [team team_msdyn_ocoutboundconfiguration](team.md#BKMK_team_msdyn_ocoutboundconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocoutboundconfiguration"></a> user_msdyn_ocoutboundconfiguration

One-To-Many Relationship: [systemuser user_msdyn_ocoutboundconfiguration](systemuser.md#BKMK_user_msdyn_ocoutboundconfiguration)

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

- [msdyn_ocoutboundconfiguration_AsyncOperations](#BKMK_msdyn_ocoutboundconfiguration_AsyncOperations)
- [msdyn_ocoutboundconfiguration_BulkDeleteFailures](#BKMK_msdyn_ocoutboundconfiguration_BulkDeleteFailures)
- [msdyn_ocoutboundconfiguration_DuplicateBaseRecord](#BKMK_msdyn_ocoutboundconfiguration_DuplicateBaseRecord)
- [msdyn_ocoutboundconfiguration_DuplicateMatchingRecord](#BKMK_msdyn_ocoutboundconfiguration_DuplicateMatchingRecord)
- [msdyn_ocoutboundconfiguration_MailboxTrackingFolders](#BKMK_msdyn_ocoutboundconfiguration_MailboxTrackingFolders)
- [msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses)
- [msdyn_ocoutboundconfiguration_ProcessSession](#BKMK_msdyn_ocoutboundconfiguration_ProcessSession)
- [msdyn_ocoutboundconfiguration_SyncErrors](#BKMK_msdyn_ocoutboundconfiguration_SyncErrors)
- [msdyn_ocoutboundmessage_msdyn_ocoutbound](#BKMK_msdyn_ocoutboundmessage_msdyn_ocoutbound)

### <a name="BKMK_msdyn_ocoutboundconfiguration_AsyncOperations"></a> msdyn_ocoutboundconfiguration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocoutboundconfiguration_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocoutboundconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundconfiguration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundconfiguration_BulkDeleteFailures"></a> msdyn_ocoutboundconfiguration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocoutboundconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocoutboundconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundconfiguration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundconfiguration_DuplicateBaseRecord"></a> msdyn_ocoutboundconfiguration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocoutboundconfiguration_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocoutboundconfiguration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundconfiguration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundconfiguration_DuplicateMatchingRecord"></a> msdyn_ocoutboundconfiguration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocoutboundconfiguration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocoutboundconfiguration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundconfiguration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundconfiguration_MailboxTrackingFolders"></a> msdyn_ocoutboundconfiguration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocoutboundconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocoutboundconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundconfiguration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses"></a> msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundconfiguration_ProcessSession"></a> msdyn_ocoutboundconfiguration_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocoutboundconfiguration_ProcessSession](processsession.md#BKMK_msdyn_ocoutboundconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundconfiguration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundconfiguration_SyncErrors"></a> msdyn_ocoutboundconfiguration_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocoutboundconfiguration_SyncErrors](syncerror.md#BKMK_msdyn_ocoutboundconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundconfiguration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_msdyn_ocoutbound"></a> msdyn_ocoutboundmessage_msdyn_ocoutbound

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_msdyn_ocoutbound](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_msdyn_ocoutbound)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`msdyn_ocoutboundconfiguration`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_msdyn_ocoutbound`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

