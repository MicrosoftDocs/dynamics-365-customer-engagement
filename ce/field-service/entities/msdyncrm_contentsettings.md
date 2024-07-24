---
title: "Content settings (msdyncrm_contentsettings) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Content settings (msdyncrm_contentsettings) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Content settings (msdyncrm_contentsettings) table/entity reference



## Messages

The following table lists the messages for the Content settings (msdyncrm_contentsettings) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_contentsettingss(*msdyncrm_contentsettingsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_contentsettingss<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_contentsettingss(*msdyncrm_contentsettingsid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_contentsettingss(*msdyncrm_contentsettingsid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_contentsettingss<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_contentsettingss(*msdyncrm_contentsettingsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_contentsettingss(*msdyncrm_contentsettingsid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_contentsettingss(*msdyncrm_contentsettingsid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Content settings (msdyncrm_contentsettings) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Content settings (msdyncrm_contentsettings) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Content settings** |
| **DisplayCollectionName** | **Content settings** |
| **SchemaName** | `msdyncrm_contentsettings` |
| **CollectionSchemaName** | `msdyncrm_contentsettingses` |
| **EntitySetName** | `msdyncrm_contentsettingss`|
| **LogicalName** | `msdyncrm_contentsettings` |
| **LogicalCollectionName** | `msdyncrm_contentsettingses` |
| **PrimaryIdAttribute** | `msdyncrm_contentsettingsid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_AddressLine2](#BKMK_msdyncrm_AddressLine2)
- [msdyncrm_AddressMain](#BKMK_msdyncrm_AddressMain)
- [msdyncrm_contentsettingsId](#BKMK_msdyncrm_contentsettingsId)
- [msdyncrm_Default](#BKMK_msdyncrm_Default)
- [msdyncrm_FacebookUrl](#BKMK_msdyncrm_FacebookUrl)
- [msdyncrm_ForwardToAFriend](#BKMK_msdyncrm_ForwardToAFriend)
- [msdyncrm_GooglePlusUrl](#BKMK_msdyncrm_GooglePlusUrl)
- [msdyncrm_InstagramUrl](#BKMK_msdyncrm_InstagramUrl)
- [msdyncrm_isbusinessunitdefault](#BKMK_msdyncrm_isbusinessunitdefault)
- [msdyncrm_LinkedInUrl](#BKMK_msdyncrm_LinkedInUrl)
- [msdyncrm_MediumUrl](#BKMK_msdyncrm_MediumUrl)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_SkypeUrl](#BKMK_msdyncrm_SkypeUrl)
- [msdyncrm_SubscriptionCenter](#BKMK_msdyncrm_SubscriptionCenter)
- [msdyncrm_TwitterUrl](#BKMK_msdyncrm_TwitterUrl)
- [msdyncrm_YoutubeUrl](#BKMK_msdyncrm_YoutubeUrl)
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
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_AddressLine2"></a> msdyncrm_AddressLine2

|Property|Value|
|---|---|
|Description||
|DisplayName|**Address Line 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_addressline2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_AddressMain"></a> msdyncrm_AddressMain

|Property|Value|
|---|---|
|Description||
|DisplayName|**Address main**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_addressmain`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_contentsettingsId"></a> msdyncrm_contentsettingsId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Content settings**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contentsettingsid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_Default"></a> msdyncrm_Default

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_default`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_contentsettings_msdyncrm_default`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_FacebookUrl"></a> msdyncrm_FacebookUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Facebook URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_facebookurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_ForwardToAFriend"></a> msdyncrm_ForwardToAFriend

|Property|Value|
|---|---|
|Description||
|DisplayName|**Forward to a friend**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_forwardtoafriend`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_GooglePlusUrl"></a> msdyncrm_GooglePlusUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Google Plus URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_googleplusurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_InstagramUrl"></a> msdyncrm_InstagramUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Instagram URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_instagramurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_isbusinessunitdefault"></a> msdyncrm_isbusinessunitdefault

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default for owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_isbusinessunitdefault`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_contentsettings_msdyncrm_isbusinessunitdefault`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_LinkedInUrl"></a> msdyncrm_LinkedInUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**LinkedIn URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_MediumUrl"></a> msdyncrm_MediumUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Medium URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_mediumurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
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

### <a name="BKMK_msdyncrm_SkypeUrl"></a> msdyncrm_SkypeUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Skype URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_skypeurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_SubscriptionCenter"></a> msdyncrm_SubscriptionCenter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Subscription center**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_subscriptioncenter`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2100|

### <a name="BKMK_msdyncrm_TwitterUrl"></a> msdyncrm_TwitterUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Twitter URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_twitterurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_YoutubeUrl"></a> msdyncrm_YoutubeUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**YouTube URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_youtubeurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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
|Description|**Status of the content settings**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_contentsettings_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350000<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 192350004<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Content settings status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_contentsettings_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|192350000|Label: **Draft**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350000" tostatusid="192350006" /><allowedtransition sourcestatusid="192350000" tostatusid="192350004" /><allowedtransition sourcestatusid="192350000" tostatusid="192350001" /></allowedtransitions>`|
|192350001|Label: **Live**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350001" tostatusid="192350007" /><allowedtransition sourcestatusid="192350001" tostatusid="192350002" /><allowedtransition sourcestatusid="192350001" tostatusid="192350006" /><allowedtransition sourcestatusid="192350001" tostatusid="192350003" /><allowedtransition sourcestatusid="192350001" tostatusid="192350005" /></allowedtransitions>`|
|192350002|Label: **Stopped**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350002" tostatusid="192350004" /><allowedtransition sourcestatusid="192350002" tostatusid="192350006" /><allowedtransition sourcestatusid="192350002" tostatusid="192350001" /></allowedtransitions>`|
|192350003|Label: **Live, editable**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350003" tostatusid="192350001" /><allowedtransition sourcestatusid="192350003" tostatusid="192350006" /></allowedtransitions>`|
|192350004|Label: **Expired**<br />State:1<br />TransitionData: None|
|192350005|Label: **Error**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350005" tostatusid="192350006" /><allowedtransition sourcestatusid="192350005" tostatusid="192350007" /><allowedtransition sourcestatusid="192350005" tostatusid="192350001" /><allowedtransition sourcestatusid="192350005" tostatusid="192350002" /></allowedtransitions>`|
|192350006|Label: **Going live**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350006" tostatusid="192350001" /><allowedtransition sourcestatusid="192350006" tostatusid="192350005" /></allowedtransitions>`|
|192350007|Label: **Stopping**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350007" tostatusid="192350002" /><allowedtransition sourcestatusid="192350007" tostatusid="192350005" /></allowedtransitions>`|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time-zone rule version number**|
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
|Description|**Time-zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time-zone code**|
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
|Description|**Indicates the business unit that owns this.**|
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
|Description|**Indicates the team that owns this.**|
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

- [business_unit_msdyncrm_contentsettings](#BKMK_business_unit_msdyncrm_contentsettings)
- [lk_msdyncrm_contentsettings_createdby](#BKMK_lk_msdyncrm_contentsettings_createdby)
- [lk_msdyncrm_contentsettings_createdonbehalfby](#BKMK_lk_msdyncrm_contentsettings_createdonbehalfby)
- [lk_msdyncrm_contentsettings_modifiedby](#BKMK_lk_msdyncrm_contentsettings_modifiedby)
- [lk_msdyncrm_contentsettings_modifiedonbehalfby](#BKMK_lk_msdyncrm_contentsettings_modifiedonbehalfby)
- [owner_msdyncrm_contentsettings](#BKMK_owner_msdyncrm_contentsettings)
- [team_msdyncrm_contentsettings](#BKMK_team_msdyncrm_contentsettings)
- [user_msdyncrm_contentsettings](#BKMK_user_msdyncrm_contentsettings)

### <a name="BKMK_business_unit_msdyncrm_contentsettings"></a> business_unit_msdyncrm_contentsettings

One-To-Many Relationship: [businessunit business_unit_msdyncrm_contentsettings](businessunit.md#BKMK_business_unit_msdyncrm_contentsettings)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_contentsettings_createdby"></a> lk_msdyncrm_contentsettings_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_contentsettings_createdby](systemuser.md#BKMK_lk_msdyncrm_contentsettings_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_contentsettings_createdonbehalfby"></a> lk_msdyncrm_contentsettings_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_contentsettings_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_contentsettings_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_contentsettings_modifiedby"></a> lk_msdyncrm_contentsettings_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_contentsettings_modifiedby](systemuser.md#BKMK_lk_msdyncrm_contentsettings_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_contentsettings_modifiedonbehalfby"></a> lk_msdyncrm_contentsettings_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_contentsettings_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_contentsettings_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_contentsettings"></a> owner_msdyncrm_contentsettings

One-To-Many Relationship: [owner owner_msdyncrm_contentsettings](owner.md#BKMK_owner_msdyncrm_contentsettings)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_contentsettings"></a> team_msdyncrm_contentsettings

One-To-Many Relationship: [team team_msdyncrm_contentsettings](team.md#BKMK_team_msdyncrm_contentsettings)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_contentsettings"></a> user_msdyncrm_contentsettings

One-To-Many Relationship: [systemuser user_msdyncrm_contentsettings](systemuser.md#BKMK_user_msdyncrm_contentsettings)

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

- [msdyncrm_contentsettings_ActivityPointers](#BKMK_msdyncrm_contentsettings_ActivityPointers)
- [msdyncrm_contentsettings_adx_alertsubscriptions](#BKMK_msdyncrm_contentsettings_adx_alertsubscriptions)
- [msdyncrm_contentsettings_adx_inviteredemptions](#BKMK_msdyncrm_contentsettings_adx_inviteredemptions)
- [msdyncrm_contentsettings_adx_portalcomments](#BKMK_msdyncrm_contentsettings_adx_portalcomments)
- [msdyncrm_contentsettings_Annotations](#BKMK_msdyncrm_contentsettings_Annotations)
- [msdyncrm_contentsettings_Appointments](#BKMK_msdyncrm_contentsettings_Appointments)
- [msdyncrm_contentsettings_AsyncOperations](#BKMK_msdyncrm_contentsettings_AsyncOperations)
- [msdyncrm_contentsettings_BulkDeleteFailures](#BKMK_msdyncrm_contentsettings_BulkDeleteFailures)
- [msdyncrm_contentsettings_chats](#BKMK_msdyncrm_contentsettings_chats)
- [msdyncrm_contentsettings_connections1](#BKMK_msdyncrm_contentsettings_connections1)
- [msdyncrm_contentsettings_connections2](#BKMK_msdyncrm_contentsettings_connections2)
- [msdyncrm_contentsettings_DuplicateBaseRecord](#BKMK_msdyncrm_contentsettings_DuplicateBaseRecord)
- [msdyncrm_contentsettings_DuplicateMatchingRecord](#BKMK_msdyncrm_contentsettings_DuplicateMatchingRecord)
- [msdyncrm_contentsettings_Emails](#BKMK_msdyncrm_contentsettings_Emails)
- [msdyncrm_contentsettings_Faxes](#BKMK_msdyncrm_contentsettings_Faxes)
- [msdyncrm_contentsettings_Feedback](#BKMK_msdyncrm_contentsettings_Feedback)
- [msdyncrm_contentsettings_Letters](#BKMK_msdyncrm_contentsettings_Letters)
- [msdyncrm_contentsettings_li_inmails](#BKMK_msdyncrm_contentsettings_li_inmails)
- [msdyncrm_contentsettings_li_messages](#BKMK_msdyncrm_contentsettings_li_messages)
- [msdyncrm_contentsettings_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_contentsettings_li_pointdrivepresentationvieweds)
- [msdyncrm_contentsettings_MailboxTrackingFolders](#BKMK_msdyncrm_contentsettings_MailboxTrackingFolders)
- [msdyncrm_contentsettings_msdyn_bookingalerts](#BKMK_msdyncrm_contentsettings_msdyn_bookingalerts)
- [msdyncrm_contentsettings_msdyn_copilottranscripts](#BKMK_msdyncrm_contentsettings_msdyn_copilottranscripts)
- [msdyncrm_contentsettings_msdyn_ocliveworkitems](#BKMK_msdyncrm_contentsettings_msdyn_ocliveworkitems)
- [msdyncrm_contentsettings_msdyn_ocoutboundmessages](#BKMK_msdyncrm_contentsettings_msdyn_ocoutboundmessages)
- [msdyncrm_contentsettings_msdyn_ocsessions](#BKMK_msdyncrm_contentsettings_msdyn_ocsessions)
- [msdyncrm_contentsettings_msdyn_ocvoicemails](#BKMK_msdyncrm_contentsettings_msdyn_ocvoicemails)
- [msdyncrm_contentsettings_msfp_alerts](#BKMK_msdyncrm_contentsettings_msfp_alerts)
- [msdyncrm_contentsettings_msfp_surveyinvites](#BKMK_msdyncrm_contentsettings_msfp_surveyinvites)
- [msdyncrm_contentsettings_msfp_surveyresponses](#BKMK_msdyncrm_contentsettings_msfp_surveyresponses)
- [msdyncrm_contentsettings_PhoneCalls](#BKMK_msdyncrm_contentsettings_PhoneCalls)
- [msdyncrm_contentsettings_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_contentsettings_PrincipalObjectAttributeAccesses)
- [msdyncrm_contentsettings_ProcessSession](#BKMK_msdyncrm_contentsettings_ProcessSession)
- [msdyncrm_contentsettings_RecurringAppointmentMasters](#BKMK_msdyncrm_contentsettings_RecurringAppointmentMasters)
- [msdyncrm_contentsettings_ServiceAppointments](#BKMK_msdyncrm_contentsettings_ServiceAppointments)
- [msdyncrm_contentsettings_SocialActivities](#BKMK_msdyncrm_contentsettings_SocialActivities)
- [msdyncrm_contentsettings_SyncErrors](#BKMK_msdyncrm_contentsettings_SyncErrors)
- [msdyncrm_contentsettings_Tasks](#BKMK_msdyncrm_contentsettings_Tasks)
- [msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid](#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid)
- [msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings](#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings)
- [msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings](#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings)
- [msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid](#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid)
- [msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings](#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings)

### <a name="BKMK_msdyncrm_contentsettings_ActivityPointers"></a> msdyncrm_contentsettings_ActivityPointers

Many-To-One Relationship: [activitypointer msdyncrm_contentsettings_ActivityPointers](activitypointer.md#BKMK_msdyncrm_contentsettings_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_adx_alertsubscriptions"></a> msdyncrm_contentsettings_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msdyncrm_contentsettings_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msdyncrm_contentsettings_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_adx_inviteredemptions"></a> msdyncrm_contentsettings_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyncrm_contentsettings_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyncrm_contentsettings_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_adx_portalcomments"></a> msdyncrm_contentsettings_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyncrm_contentsettings_adx_portalcomments](adx_portalcomment.md#BKMK_msdyncrm_contentsettings_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_Annotations"></a> msdyncrm_contentsettings_Annotations

Many-To-One Relationship: [annotation msdyncrm_contentsettings_Annotations](annotation.md#BKMK_msdyncrm_contentsettings_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_Appointments"></a> msdyncrm_contentsettings_Appointments

Many-To-One Relationship: [appointment msdyncrm_contentsettings_Appointments](appointment.md#BKMK_msdyncrm_contentsettings_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_AsyncOperations"></a> msdyncrm_contentsettings_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_contentsettings_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_contentsettings_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_BulkDeleteFailures"></a> msdyncrm_contentsettings_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_contentsettings_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_contentsettings_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_chats"></a> msdyncrm_contentsettings_chats

Many-To-One Relationship: [chat msdyncrm_contentsettings_chats](chat.md#BKMK_msdyncrm_contentsettings_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_connections1"></a> msdyncrm_contentsettings_connections1

Many-To-One Relationship: [connection msdyncrm_contentsettings_connections1](connection.md#BKMK_msdyncrm_contentsettings_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_connections2"></a> msdyncrm_contentsettings_connections2

Many-To-One Relationship: [connection msdyncrm_contentsettings_connections2](connection.md#BKMK_msdyncrm_contentsettings_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_DuplicateBaseRecord"></a> msdyncrm_contentsettings_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_contentsettings_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_contentsettings_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_DuplicateMatchingRecord"></a> msdyncrm_contentsettings_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_contentsettings_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_contentsettings_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_Emails"></a> msdyncrm_contentsettings_Emails

Many-To-One Relationship: [email msdyncrm_contentsettings_Emails](email.md#BKMK_msdyncrm_contentsettings_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_Faxes"></a> msdyncrm_contentsettings_Faxes

Many-To-One Relationship: [fax msdyncrm_contentsettings_Faxes](fax.md#BKMK_msdyncrm_contentsettings_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_Feedback"></a> msdyncrm_contentsettings_Feedback

Many-To-One Relationship: [feedback msdyncrm_contentsettings_Feedback](feedback.md#BKMK_msdyncrm_contentsettings_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_Letters"></a> msdyncrm_contentsettings_Letters

Many-To-One Relationship: [letter msdyncrm_contentsettings_Letters](letter.md#BKMK_msdyncrm_contentsettings_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_li_inmails"></a> msdyncrm_contentsettings_li_inmails

Many-To-One Relationship: [li_inmail msdyncrm_contentsettings_li_inmails](li_inmail.md#BKMK_msdyncrm_contentsettings_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_li_messages"></a> msdyncrm_contentsettings_li_messages

Many-To-One Relationship: [li_message msdyncrm_contentsettings_li_messages](li_message.md#BKMK_msdyncrm_contentsettings_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_li_pointdrivepresentationvieweds"></a> msdyncrm_contentsettings_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msdyncrm_contentsettings_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msdyncrm_contentsettings_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_MailboxTrackingFolders"></a> msdyncrm_contentsettings_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_contentsettings_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_contentsettings_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_msdyn_bookingalerts"></a> msdyncrm_contentsettings_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyncrm_contentsettings_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyncrm_contentsettings_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_msdyn_copilottranscripts"></a> msdyncrm_contentsettings_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyncrm_contentsettings_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyncrm_contentsettings_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_msdyn_ocliveworkitems"></a> msdyncrm_contentsettings_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyncrm_contentsettings_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyncrm_contentsettings_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_msdyn_ocoutboundmessages"></a> msdyncrm_contentsettings_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyncrm_contentsettings_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyncrm_contentsettings_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_msdyn_ocsessions"></a> msdyncrm_contentsettings_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyncrm_contentsettings_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyncrm_contentsettings_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_msdyn_ocvoicemails"></a> msdyncrm_contentsettings_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyncrm_contentsettings_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyncrm_contentsettings_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_msfp_alerts"></a> msdyncrm_contentsettings_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyncrm_contentsettings_msfp_alerts](msfp_alert.md#BKMK_msdyncrm_contentsettings_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_msfp_surveyinvites"></a> msdyncrm_contentsettings_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyncrm_contentsettings_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyncrm_contentsettings_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_msfp_surveyresponses"></a> msdyncrm_contentsettings_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyncrm_contentsettings_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyncrm_contentsettings_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_PhoneCalls"></a> msdyncrm_contentsettings_PhoneCalls

Many-To-One Relationship: [phonecall msdyncrm_contentsettings_PhoneCalls](phonecall.md#BKMK_msdyncrm_contentsettings_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_PrincipalObjectAttributeAccesses"></a> msdyncrm_contentsettings_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_contentsettings_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_contentsettings_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_ProcessSession"></a> msdyncrm_contentsettings_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_contentsettings_ProcessSession](processsession.md#BKMK_msdyncrm_contentsettings_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_RecurringAppointmentMasters"></a> msdyncrm_contentsettings_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyncrm_contentsettings_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyncrm_contentsettings_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_ServiceAppointments"></a> msdyncrm_contentsettings_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyncrm_contentsettings_ServiceAppointments](serviceappointment.md#BKMK_msdyncrm_contentsettings_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_SocialActivities"></a> msdyncrm_contentsettings_SocialActivities

Many-To-One Relationship: [socialactivity msdyncrm_contentsettings_SocialActivities](socialactivity.md#BKMK_msdyncrm_contentsettings_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_SyncErrors"></a> msdyncrm_contentsettings_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_contentsettings_SyncErrors](syncerror.md#BKMK_msdyncrm_contentsettings_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contentsettings_Tasks"></a> msdyncrm_contentsettings_Tasks

Many-To-One Relationship: [task msdyncrm_contentsettings_Tasks](task.md#BKMK_msdyncrm_contentsettings_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contentsettings_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid"></a> msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid

Many-To-One Relationship: [msdyncrm_customerjourney msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid](msdyncrm_customerjourney.md#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourney`|
|ReferencingAttribute|`msdyncrm_contentsettingsid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_contentsettings_msdyncrm_customerjourney_contentsettingsid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings"></a> msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings

Many-To-One Relationship: [msdyncrm_defaultmarketingsetting msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings](msdyncrm_defaultmarketingsetting.md#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_defaultmarketingsetting`|
|ReferencingAttribute|`msdyncrm_defaultcntntsettings`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings"></a> msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings

Many-To-One Relationship: [msdyncrm_defaultmarketingsetting msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings](msdyncrm_defaultmarketingsetting.md#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_defaultmarketingsetting`|
|ReferencingAttribute|`msdyncrm_doubleoptincontentsettings`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid"></a> msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid

Many-To-One Relationship: [msdyncrm_marketingemailtestsend msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailtestsend`|
|ReferencingAttribute|`msdyncrm_testcontentsettingsid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingemailtestsend_testcontentsettingsid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings"></a> msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings

Many-To-One Relationship: [msdyncrm_marketingform msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings](msdyncrm_marketingform.md#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingform`|
|ReferencingAttribute|`msdyncrm_doubleoptincontentsettings`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_contentsettings_msdyncrm_marketingform_doubleoptincontentsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

