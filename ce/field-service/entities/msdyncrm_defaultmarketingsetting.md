---
title: "Default settings (msdyncrm_defaultmarketingsetting) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Default settings (msdyncrm_defaultmarketingsetting) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Default settings (msdyncrm_defaultmarketingsetting) table/entity reference

Default settings

## Messages

The following table lists the messages for the Default settings (msdyncrm_defaultmarketingsetting) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_defaultmarketingsettings(*msdyncrm_defaultmarketingsettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_defaultmarketingsettings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_defaultmarketingsettings(*msdyncrm_defaultmarketingsettingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_defaultmarketingsettings(*msdyncrm_defaultmarketingsettingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_defaultmarketingsettings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_defaultmarketingsettings(*msdyncrm_defaultmarketingsettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_defaultmarketingsettings(*msdyncrm_defaultmarketingsettingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_defaultmarketingsettings(*msdyncrm_defaultmarketingsettingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Default settings (msdyncrm_defaultmarketingsetting) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Default settings (msdyncrm_defaultmarketingsetting) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Default settings** |
| **DisplayCollectionName** | **Default settings** |
| **SchemaName** | `msdyncrm_defaultmarketingsetting` |
| **CollectionSchemaName** | `msdyncrm_defaultmarketingsettings` |
| **EntitySetName** | `msdyncrm_defaultmarketingsettings`|
| **LogicalName** | `msdyncrm_defaultmarketingsetting` |
| **LogicalCollectionName** | `msdyncrm_defaultmarketingsettings` |
| **PrimaryIdAttribute** | `msdyncrm_defaultmarketingsettingid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_bypassemaildeduplication](#BKMK_msdyncrm_bypassemaildeduplication)
- [msdyncrm_consentconfirmationmessage](#BKMK_msdyncrm_consentconfirmationmessage)
- [msdyncrm_Default](#BKMK_msdyncrm_Default)
- [msdyncrm_DefaultCntntSettings](#BKMK_msdyncrm_DefaultCntntSettings)
- [msdyncrm_defaultemailfromemail](#BKMK_msdyncrm_defaultemailfromemail)
- [msdyncrm_defaultemailfromname](#BKMK_msdyncrm_defaultemailfromname)
- [msdyncrm_defaultmarketingsettingId](#BKMK_msdyncrm_defaultmarketingsettingId)
- [msdyncrm_defaultmarketingthankyoupage](#BKMK_msdyncrm_defaultmarketingthankyoupage)
- [msdyncrm_defaultmarketingthankyoupagedoi](#BKMK_msdyncrm_defaultmarketingthankyoupagedoi)
- [msdyncrm_defaultmarketingthankyouurl](#BKMK_msdyncrm_defaultmarketingthankyouurl)
- [msdyncrm_defaultmarketingthankyouurldoi](#BKMK_msdyncrm_defaultmarketingthankyouurldoi)
- [msdyncrm_DefaultSetupDomain](#BKMK_msdyncrm_DefaultSetupDomain)
- [msdyncrm_DefaultTestContact](#BKMK_msdyncrm_DefaultTestContact)
- [msdyncrm_defaulttimezone](#BKMK_msdyncrm_defaulttimezone)
- [msdyncrm_doubleoptincontentsettings](#BKMK_msdyncrm_doubleoptincontentsettings)
- [msdyncrm_enabledoubleoptin](#BKMK_msdyncrm_enabledoubleoptin)
- [msdyncrm_EnableLitmusIntegration](#BKMK_msdyncrm_EnableLitmusIntegration)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_subscriptionoptinmessage](#BKMK_msdyncrm_subscriptionoptinmessage)
- [msdyncrm_thankyoupagesource](#BKMK_msdyncrm_thankyoupagesource)
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

### <a name="BKMK_msdyncrm_bypassemaildeduplication"></a> msdyncrm_bypassemaildeduplication

|Property|Value|
|---|---|
|Description|**Bypass email deduplication (if this is turned on multiple emails can be send to one email address)**|
|DisplayName|**Bypass email deduplication**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_bypassemaildeduplication`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_msdyncrm_defaultmarketingsetting_msdyncrm_bypassemaildeduplication`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_consentconfirmationmessage"></a> msdyncrm_consentconfirmationmessage

|Property|Value|
|---|---|
|Description|**Select the confirmation message to send contacts requesting to increase their consent level.**|
|DisplayName|**Consent Confirmation Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_consentconfirmationmessage`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingemail|

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
|GlobalChoiceName|`msdyncrm_msdyncrm_defaultmarketingsetting_msdyncrm_default`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_DefaultCntntSettings"></a> msdyncrm_DefaultCntntSettings

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default content settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaultcntntsettings`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyncrm_contentsettings|

### <a name="BKMK_msdyncrm_defaultemailfromemail"></a> msdyncrm_defaultemailfromemail

|Property|Value|
|---|---|
|Description|**Provide marketing emails with default from email address. Especially in cases, when all marketers are sending marketing emails from a common default email.**|
|DisplayName|**Default from email for emails**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaultemailfromemail`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdyncrm_defaultemailfromname"></a> msdyncrm_defaultemailfromname

|Property|Value|
|---|---|
|Description|**Provide marketing emails with default from email address. Especially in cases, when all marketers are sending marketing emails from a common default email.**|
|DisplayName|**Default from name for emails**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaultemailfromname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdyncrm_defaultmarketingsettingId"></a> msdyncrm_defaultmarketingsettingId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Default settings ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaultmarketingsettingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_defaultmarketingthankyoupage"></a> msdyncrm_defaultmarketingthankyoupage

|Property|Value|
|---|---|
|Description|**Select a marketing page to show contacts after they confirm an increase of their consent level**|
|DisplayName|**Default redirect: Marketing page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaultmarketingthankyoupage`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingpage|

### <a name="BKMK_msdyncrm_defaultmarketingthankyoupagedoi"></a> msdyncrm_defaultmarketingthankyoupagedoi

|Property|Value|
|---|---|
|Description|**Select a marketing page to show contacts after they confirm a new subscription**|
|DisplayName|**Default redirect: Marketing page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaultmarketingthankyoupagedoi`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingpage|

### <a name="BKMK_msdyncrm_defaultmarketingthankyouurl"></a> msdyncrm_defaultmarketingthankyouurl

|Property|Value|
|---|---|
|Description|**Provide the Marketing Page with your default thank-you message. Contacts are redirected to that page after they click the confirm button in a confirmation-request message.**|
|DisplayName|**Thank-you url for consent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaultmarketingthankyouurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdyncrm_defaultmarketingthankyouurldoi"></a> msdyncrm_defaultmarketingthankyouurldoi

|Property|Value|
|---|---|
|Description|**Provide the url with your default thank-you message. Contacts are redirected to that page after they click the confirm button in a confirmation-request message for newsletter.**|
|DisplayName|**Thank-you url for subscriptions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaultmarketingthankyouurldoi`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdyncrm_DefaultSetupDomain"></a> msdyncrm_DefaultSetupDomain

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default sending domain**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaultsetupdomain`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_setupdomain|

### <a name="BKMK_msdyncrm_DefaultTestContact"></a> msdyncrm_DefaultTestContact

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaulttestcontact`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msdyncrm_defaulttimezone"></a> msdyncrm_defaulttimezone

|Property|Value|
|---|---|
|Description|**Default content settings value**|
|DisplayName|**Default time zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaulttimezone`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_msdyncrm_doubleoptincontentsettings"></a> msdyncrm_doubleoptincontentsettings

|Property|Value|
|---|---|
|Description|**Select the content settings to use for confirmation-request messages.**|
|DisplayName|**Content settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_doubleoptincontentsettings`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_contentsettings|

### <a name="BKMK_msdyncrm_enabledoubleoptin"></a> msdyncrm_enabledoubleoptin

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable double opt-In**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_enabledoubleoptin`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_defaultmarketingsetting_msdyncrm_enabledoubleoptin`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_EnableLitmusIntegration"></a> msdyncrm_EnableLitmusIntegration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable Litmus integration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_enablelitmusintegration`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_enablelitmus_optionset`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_msdyncrm_subscriptionoptinmessage"></a> msdyncrm_subscriptionoptinmessage

|Property|Value|
|---|---|
|Description|**Select the confirmation message to send contacts requesting to join a new mailing list.**|
|DisplayName|**Subscription opt-In message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_subscriptionoptinmessage`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingemail|

### <a name="BKMK_msdyncrm_thankyoupagesource"></a> msdyncrm_thankyoupagesource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Use marketing pages for thank you**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_thankyoupagesource`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdyncrm_defaultmarketingsetting_msdyncrm_thankyoupagesource`|

#### msdyncrm_thankyoupagesource Choices/Options

|Value|Label|
|---|---|
|100000000|**Yes**|
|100000001|**No**|

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
|Description|**Status of the default settings**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_defaultmarketingsetting_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the default settings**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_defaultmarketingsetting_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

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
|Description|**The time-zone code that was in use when the record was created**|
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
|Description|**Unique identifier for the business unit that owns the record**|
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
|Description|**Unique identifier for the team that owns the record**|
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

- [business_unit_msdyncrm_defaultmarketingsetting](#BKMK_business_unit_msdyncrm_defaultmarketingsetting)
- [lk_msdyncrm_defaultmarketingsetting_createdby](#BKMK_lk_msdyncrm_defaultmarketingsetting_createdby)
- [lk_msdyncrm_defaultmarketingsetting_createdonbehalfby](#BKMK_lk_msdyncrm_defaultmarketingsetting_createdonbehalfby)
- [lk_msdyncrm_defaultmarketingsetting_modifiedby](#BKMK_lk_msdyncrm_defaultmarketingsetting_modifiedby)
- [lk_msdyncrm_defaultmarketingsetting_modifiedonbehalfby](#BKMK_lk_msdyncrm_defaultmarketingsetting_modifiedonbehalfby)
- [msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact](#BKMK_msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact)
- [msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings](#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings)
- [msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings](#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings)
- [msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage](#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage)
- [msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage](#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage)
- [msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage](#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage)
- [msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi](#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi)
- [msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain](#BKMK_msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain)
- [owner_msdyncrm_defaultmarketingsetting](#BKMK_owner_msdyncrm_defaultmarketingsetting)
- [team_msdyncrm_defaultmarketingsetting](#BKMK_team_msdyncrm_defaultmarketingsetting)
- [user_msdyncrm_defaultmarketingsetting](#BKMK_user_msdyncrm_defaultmarketingsetting)

### <a name="BKMK_business_unit_msdyncrm_defaultmarketingsetting"></a> business_unit_msdyncrm_defaultmarketingsetting

One-To-Many Relationship: [businessunit business_unit_msdyncrm_defaultmarketingsetting](businessunit.md#BKMK_business_unit_msdyncrm_defaultmarketingsetting)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_defaultmarketingsetting_createdby"></a> lk_msdyncrm_defaultmarketingsetting_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_defaultmarketingsetting_createdby](systemuser.md#BKMK_lk_msdyncrm_defaultmarketingsetting_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_defaultmarketingsetting_createdonbehalfby"></a> lk_msdyncrm_defaultmarketingsetting_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_defaultmarketingsetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_defaultmarketingsetting_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_defaultmarketingsetting_modifiedby"></a> lk_msdyncrm_defaultmarketingsetting_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_defaultmarketingsetting_modifiedby](systemuser.md#BKMK_lk_msdyncrm_defaultmarketingsetting_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_defaultmarketingsetting_modifiedonbehalfby"></a> lk_msdyncrm_defaultmarketingsetting_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_defaultmarketingsetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_defaultmarketingsetting_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact"></a> msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact

One-To-Many Relationship: [contact msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact](contact.md#BKMK_msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyncrm_defaulttestcontact`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_DefaultTestContact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings"></a> msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings](msdyncrm_contentsettings.md#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_DefaultCntntSettings)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`msdyncrm_defaultcntntsettings`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_DefaultCntntSettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings"></a> msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings](msdyncrm_contentsettings.md#BKMK_msdyncrm_msdyncrm_contentsettings_msdyncrm_defaultmarketingsetting_doubleoptincontentsettings)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`msdyncrm_doubleoptincontentsettings`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_doubleoptincontentsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage"></a> msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage

One-To-Many Relationship: [msdyncrm_marketingemail msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage](msdyncrm_marketingemail.md#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_consentconfirmationmessage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemail`|
|ReferencedAttribute|`msdyncrm_marketingemailid`|
|ReferencingAttribute|`msdyncrm_consentconfirmationmessage`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_consentconfirmationmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage"></a> msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage

One-To-Many Relationship: [msdyncrm_marketingemail msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage](msdyncrm_marketingemail.md#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_defaultmarketingsetting_subscriptionoptinmessage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemail`|
|ReferencedAttribute|`msdyncrm_marketingemailid`|
|ReferencingAttribute|`msdyncrm_subscriptionoptinmessage`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_subscriptionoptinmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage"></a> msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage

One-To-Many Relationship: [msdyncrm_marketingpage msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage](msdyncrm_marketingpage.md#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingpage`|
|ReferencedAttribute|`msdyncrm_marketingpageid`|
|ReferencingAttribute|`msdyncrm_defaultmarketingthankyoupage`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_defaultmarketingthankyoupage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi"></a> msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi

One-To-Many Relationship: [msdyncrm_marketingpage msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi](msdyncrm_marketingpage.md#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingpage`|
|ReferencedAttribute|`msdyncrm_marketingpageid`|
|ReferencingAttribute|`msdyncrm_defaultmarketingthankyoupagedoi`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_defaultmarketingthankyoupagedoi`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain"></a> msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain

One-To-Many Relationship: [msdyncrm_setupdomain msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain](msdyncrm_setupdomain.md#BKMK_msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_setupdomain`|
|ReferencedAttribute|`msdyncrm_setupdomainid`|
|ReferencingAttribute|`msdyncrm_defaultsetupdomain`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_DefaultSetupDomain`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_defaultmarketingsetting"></a> owner_msdyncrm_defaultmarketingsetting

One-To-Many Relationship: [owner owner_msdyncrm_defaultmarketingsetting](owner.md#BKMK_owner_msdyncrm_defaultmarketingsetting)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_defaultmarketingsetting"></a> team_msdyncrm_defaultmarketingsetting

One-To-Many Relationship: [team team_msdyncrm_defaultmarketingsetting](team.md#BKMK_team_msdyncrm_defaultmarketingsetting)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_defaultmarketingsetting"></a> user_msdyncrm_defaultmarketingsetting

One-To-Many Relationship: [systemuser user_msdyncrm_defaultmarketingsetting](systemuser.md#BKMK_user_msdyncrm_defaultmarketingsetting)

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

- [msdyncrm_defaultmarketingsetting_AsyncOperations](#BKMK_msdyncrm_defaultmarketingsetting_AsyncOperations)
- [msdyncrm_defaultmarketingsetting_BulkDeleteFailures](#BKMK_msdyncrm_defaultmarketingsetting_BulkDeleteFailures)
- [msdyncrm_defaultmarketingsetting_MailboxTrackingFolders](#BKMK_msdyncrm_defaultmarketingsetting_MailboxTrackingFolders)
- [msdyncrm_defaultmarketingsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_defaultmarketingsetting_PrincipalObjectAttributeAccesses)
- [msdyncrm_defaultmarketingsetting_ProcessSession](#BKMK_msdyncrm_defaultmarketingsetting_ProcessSession)
- [msdyncrm_defaultmarketingsetting_SyncErrors](#BKMK_msdyncrm_defaultmarketingsetting_SyncErrors)

### <a name="BKMK_msdyncrm_defaultmarketingsetting_AsyncOperations"></a> msdyncrm_defaultmarketingsetting_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_defaultmarketingsetting_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_defaultmarketingsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_defaultmarketingsetting_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_defaultmarketingsetting_BulkDeleteFailures"></a> msdyncrm_defaultmarketingsetting_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_defaultmarketingsetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_defaultmarketingsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_defaultmarketingsetting_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_defaultmarketingsetting_MailboxTrackingFolders"></a> msdyncrm_defaultmarketingsetting_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_defaultmarketingsetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_defaultmarketingsetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_defaultmarketingsetting_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_defaultmarketingsetting_PrincipalObjectAttributeAccesses"></a> msdyncrm_defaultmarketingsetting_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_defaultmarketingsetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_defaultmarketingsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_defaultmarketingsetting_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_defaultmarketingsetting_ProcessSession"></a> msdyncrm_defaultmarketingsetting_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_defaultmarketingsetting_ProcessSession](processsession.md#BKMK_msdyncrm_defaultmarketingsetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_defaultmarketingsetting_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_defaultmarketingsetting_SyncErrors"></a> msdyncrm_defaultmarketingsetting_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_defaultmarketingsetting_SyncErrors](syncerror.md#BKMK_msdyncrm_defaultmarketingsetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_defaultmarketingsetting_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

