---
title: "Social media account (msdyncrm_socialpostingconfiguration) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Social media account (msdyncrm_socialpostingconfiguration) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Social media account (msdyncrm_socialpostingconfiguration) table/entity reference

Configuration for social posting channels

## Messages

The following table lists the messages for the Social media account (msdyncrm_socialpostingconfiguration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_socialpostingconfigurations(*msdyncrm_socialpostingconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_socialpostingconfigurations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_socialpostingconfigurations(*msdyncrm_socialpostingconfigurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_socialpostingconfigurations(*msdyncrm_socialpostingconfigurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_socialpostingconfigurations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_socialpostingconfigurations(*msdyncrm_socialpostingconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_socialpostingconfigurations(*msdyncrm_socialpostingconfigurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_socialpostingconfigurations(*msdyncrm_socialpostingconfigurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Social media account (msdyncrm_socialpostingconfiguration) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Social media account (msdyncrm_socialpostingconfiguration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Social media account** |
| **DisplayCollectionName** | **Social media accounts** |
| **SchemaName** | `msdyncrm_socialpostingconfiguration` |
| **CollectionSchemaName** | `msdyncrm_socialpostingconfigurations` |
| **EntitySetName** | `msdyncrm_socialpostingconfigurations`|
| **LogicalName** | `msdyncrm_socialpostingconfiguration` |
| **LogicalCollectionName** | `msdyncrm_socialpostingconfigurations` |
| **PrimaryIdAttribute** | `msdyncrm_socialpostingconfigurationid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_connectstatus](#BKMK_msdyncrm_connectstatus)
- [msdyncrm_consent](#BKMK_msdyncrm_consent)
- [msdyncrm_consentneeded](#BKMK_msdyncrm_consentneeded)
- [msdyncrm_consenttext](#BKMK_msdyncrm_consenttext)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_networkid](#BKMK_msdyncrm_networkid)
- [msdyncrm_networkname](#BKMK_msdyncrm_networkname)
- [msdyncrm_Privacypolicy](#BKMK_msdyncrm_Privacypolicy)
- [msdyncrm_SocialChannel](#BKMK_msdyncrm_SocialChannel)
- [msdyncrm_socialpostingconfigurationId](#BKMK_msdyncrm_socialpostingconfigurationId)
- [msdyncrm_Termsofservice](#BKMK_msdyncrm_Termsofservice)
- [msdyncrm_TokenType](#BKMK_msdyncrm_TokenType)
- [msdyncrm_UserAccountDisabled](#BKMK_msdyncrm_UserAccountDisabled)
- [msdyncrm_UserName](#BKMK_msdyncrm_UserName)
- [msdyncrm_validationdate](#BKMK_msdyncrm_validationdate)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_connectstatus"></a> msdyncrm_connectstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Connect status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_connectstatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_consent"></a> msdyncrm_consent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Consent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_consent`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_socialpostingconfiguration_msdyncrm_consent`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_consentneeded"></a> msdyncrm_consentneeded

|Property|Value|
|---|---|
|Description||
|DisplayName|**Consent needed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_consentneeded`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_socialpostingconfiguration_msdyncrm_consentneeded`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_consenttext"></a> msdyncrm_consenttext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Consent text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_consenttext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the social post**|
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
|MaxLength|100|

### <a name="BKMK_msdyncrm_networkid"></a> msdyncrm_networkid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Id of the user on the social network**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_networkid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_networkname"></a> msdyncrm_networkname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Name of the user on the social network**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_networkname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_Privacypolicy"></a> msdyncrm_Privacypolicy

|Property|Value|
|---|---|
|Description||
|DisplayName|**Privacy policy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_privacypolicy`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_SocialChannel"></a> msdyncrm_SocialChannel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Social channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_socialchannel`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_socialpostingconfiguration_msdyncrm_socialchannel`|

#### msdyncrm_SocialChannel Choices/Options

|Value|Label|
|---|---|
|270100000|**Twitter**|
|270100001|**Facebook**|
|270100002|**LinkedIn**|
|270100003|**Instagram**|

### <a name="BKMK_msdyncrm_socialpostingconfigurationId"></a> msdyncrm_socialpostingconfigurationId

|Property|Value|
|---|---|
|Description|**Unique identifier for this entity**|
|DisplayName|**Social media account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_socialpostingconfigurationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_Termsofservice"></a> msdyncrm_Termsofservice

|Property|Value|
|---|---|
|Description||
|DisplayName|**Terms of service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_termsofservice`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_TokenType"></a> msdyncrm_TokenType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Token type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_tokentype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_socialpostingconfiguration_msdyncrm_tokentype`|

#### msdyncrm_TokenType Choices/Options

|Value|Label|
|---|---|
|270100000|**User**|
|270100001|**Page**|

### <a name="BKMK_msdyncrm_UserAccountDisabled"></a> msdyncrm_UserAccountDisabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**User account disabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_useraccountdisabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_socialpostingconfiguration_msdyncrm_useraccountdisabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_UserName"></a> msdyncrm_UserName

|Property|Value|
|---|---|
|Description||
|DisplayName|**User name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_username`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_validationdate"></a> msdyncrm_validationdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Valid until**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_validationdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated**|
|DisplayName|**Record created on**|
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
|Description|**Owner ID**|
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
|Description|**Status of the social media account**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_socialpostingconfiguration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the social media account**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_socialpostingconfiguration_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time zone rule version number**|
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
|Description|**Time zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time zone code**|
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
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyncrm_expirydate](#BKMK_msdyncrm_expirydate)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who created this.**|
|DisplayName|**Created by**|
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
|DisplayName|**Created on**|
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
|Description|**Indicates the person who created this for another person.**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who modified this.**|
|DisplayName|**Modified by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified**|
|DisplayName|**Modified on**|
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
|Description|**Indicates the person who modified this for another person.**|
|DisplayName|**Modified by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_expirydate"></a> msdyncrm_expirydate

|Property|Value|
|---|---|
|Description|**Expiration date for social media account**|
|DisplayName|**Expiry date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_expirydate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|1|

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
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Indicates the team that owns this.**|
|DisplayName|**Owning team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Indicates the person who owns this.**|
|DisplayName|**Owning user**|
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

- [business_unit_msdyncrm_socialpostingconfiguration](#BKMK_business_unit_msdyncrm_socialpostingconfiguration)
- [lk_msdyncrm_socialpostingconfiguration_createdby](#BKMK_lk_msdyncrm_socialpostingconfiguration_createdby)
- [lk_msdyncrm_socialpostingconfiguration_createdonbehalfby](#BKMK_lk_msdyncrm_socialpostingconfiguration_createdonbehalfby)
- [lk_msdyncrm_socialpostingconfiguration_modifiedby](#BKMK_lk_msdyncrm_socialpostingconfiguration_modifiedby)
- [lk_msdyncrm_socialpostingconfiguration_modifiedonbehalfby](#BKMK_lk_msdyncrm_socialpostingconfiguration_modifiedonbehalfby)
- [owner_msdyncrm_socialpostingconfiguration](#BKMK_owner_msdyncrm_socialpostingconfiguration)
- [team_msdyncrm_socialpostingconfiguration](#BKMK_team_msdyncrm_socialpostingconfiguration)
- [user_msdyncrm_socialpostingconfiguration](#BKMK_user_msdyncrm_socialpostingconfiguration)

### <a name="BKMK_business_unit_msdyncrm_socialpostingconfiguration"></a> business_unit_msdyncrm_socialpostingconfiguration

One-To-Many Relationship: [businessunit business_unit_msdyncrm_socialpostingconfiguration](businessunit.md#BKMK_business_unit_msdyncrm_socialpostingconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_socialpostingconfiguration_createdby"></a> lk_msdyncrm_socialpostingconfiguration_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_socialpostingconfiguration_createdby](systemuser.md#BKMK_lk_msdyncrm_socialpostingconfiguration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_socialpostingconfiguration_createdonbehalfby"></a> lk_msdyncrm_socialpostingconfiguration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_socialpostingconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_socialpostingconfiguration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_socialpostingconfiguration_modifiedby"></a> lk_msdyncrm_socialpostingconfiguration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_socialpostingconfiguration_modifiedby](systemuser.md#BKMK_lk_msdyncrm_socialpostingconfiguration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_socialpostingconfiguration_modifiedonbehalfby"></a> lk_msdyncrm_socialpostingconfiguration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_socialpostingconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_socialpostingconfiguration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_socialpostingconfiguration"></a> owner_msdyncrm_socialpostingconfiguration

One-To-Many Relationship: [owner owner_msdyncrm_socialpostingconfiguration](owner.md#BKMK_owner_msdyncrm_socialpostingconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_socialpostingconfiguration"></a> team_msdyncrm_socialpostingconfiguration

One-To-Many Relationship: [team team_msdyncrm_socialpostingconfiguration](team.md#BKMK_team_msdyncrm_socialpostingconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_socialpostingconfiguration"></a> user_msdyncrm_socialpostingconfiguration

One-To-Many Relationship: [systemuser user_msdyncrm_socialpostingconfiguration](systemuser.md#BKMK_user_msdyncrm_socialpostingconfiguration)

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

- [msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration](#BKMK_msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration)
- [msdyncrm_socialpostingconfiguration_AsyncOperations](#BKMK_msdyncrm_socialpostingconfiguration_AsyncOperations)
- [msdyncrm_socialpostingconfiguration_BulkDeleteFailures](#BKMK_msdyncrm_socialpostingconfiguration_BulkDeleteFailures)
- [msdyncrm_socialpostingconfiguration_DuplicateBaseRecord](#BKMK_msdyncrm_socialpostingconfiguration_DuplicateBaseRecord)
- [msdyncrm_socialpostingconfiguration_DuplicateMatchingRecord](#BKMK_msdyncrm_socialpostingconfiguration_DuplicateMatchingRecord)
- [msdyncrm_socialpostingconfiguration_MailboxTrackingFolders](#BKMK_msdyncrm_socialpostingconfiguration_MailboxTrackingFolders)
- [msdyncrm_socialpostingconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_socialpostingconfiguration_PrincipalObjectAttributeAccesses)
- [msdyncrm_socialpostingconfiguration_ProcessSession](#BKMK_msdyncrm_socialpostingconfiguration_ProcessSession)
- [msdyncrm_socialpostingconfiguration_SyncErrors](#BKMK_msdyncrm_socialpostingconfiguration_SyncErrors)

### <a name="BKMK_msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration"></a> msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration

Many-To-One Relationship: [msdyncrm_socialpost msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration](msdyncrm_socialpost.md#BKMK_msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_socialpost`|
|ReferencingAttribute|`msdyncrm_socialconfiguration`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_socialpostingconfiguration_msdyncrm_socialpost_socialconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpostingconfiguration_AsyncOperations"></a> msdyncrm_socialpostingconfiguration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_socialpostingconfiguration_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_socialpostingconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpostingconfiguration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpostingconfiguration_BulkDeleteFailures"></a> msdyncrm_socialpostingconfiguration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_socialpostingconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_socialpostingconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpostingconfiguration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpostingconfiguration_DuplicateBaseRecord"></a> msdyncrm_socialpostingconfiguration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_socialpostingconfiguration_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_socialpostingconfiguration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpostingconfiguration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpostingconfiguration_DuplicateMatchingRecord"></a> msdyncrm_socialpostingconfiguration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_socialpostingconfiguration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_socialpostingconfiguration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpostingconfiguration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpostingconfiguration_MailboxTrackingFolders"></a> msdyncrm_socialpostingconfiguration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_socialpostingconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_socialpostingconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpostingconfiguration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpostingconfiguration_PrincipalObjectAttributeAccesses"></a> msdyncrm_socialpostingconfiguration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_socialpostingconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_socialpostingconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpostingconfiguration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpostingconfiguration_ProcessSession"></a> msdyncrm_socialpostingconfiguration_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_socialpostingconfiguration_ProcessSession](processsession.md#BKMK_msdyncrm_socialpostingconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpostingconfiguration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_socialpostingconfiguration_SyncErrors"></a> msdyncrm_socialpostingconfiguration_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_socialpostingconfiguration_SyncErrors](syncerror.md#BKMK_msdyncrm_socialpostingconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_socialpostingconfiguration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

