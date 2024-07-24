---
title: "Marketing configuration (msdyncrm_marketingconfiguration) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Marketing configuration (msdyncrm_marketingconfiguration) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Marketing configuration (msdyncrm_marketingconfiguration) table/entity reference



## Messages

The following table lists the messages for the Marketing configuration (msdyncrm_marketingconfiguration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyncrm_marketingconfigurations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingconfigurations(*msdyncrm_marketingconfigurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingconfigurations(*msdyncrm_marketingconfigurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingconfigurations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingconfigurations(*msdyncrm_marketingconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingconfigurations(*msdyncrm_marketingconfigurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingconfigurations(*msdyncrm_marketingconfigurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Marketing configuration (msdyncrm_marketingconfiguration) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Marketing configuration (msdyncrm_marketingconfiguration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Marketing configuration** |
| **DisplayCollectionName** | **Marketing configurations** |
| **SchemaName** | `msdyncrm_marketingconfiguration` |
| **CollectionSchemaName** | `msdyncrm_marketingconfigurations` |
| **EntitySetName** | `msdyncrm_marketingconfigurations`|
| **LogicalName** | `msdyncrm_marketingconfiguration` |
| **LogicalCollectionName** | `msdyncrm_marketingconfigurations` |
| **PrimaryIdAttribute** | `msdyncrm_marketingconfigurationid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_configcacheexpirationdate](#BKMK_msdyncrm_configcacheexpirationdate)
- [msdyncrm_ConfigCacheExpirationPeriodInMs](#BKMK_msdyncrm_ConfigCacheExpirationPeriodInMs)
- [msdyncrm_default](#BKMK_msdyncrm_default)
- [msdyncrm_FirstTimeSetupUrl](#BKMK_msdyncrm_FirstTimeSetupUrl)
- [msdyncrm_httptimeout](#BKMK_msdyncrm_httptimeout)
- [msdyncrm_isemailtemplatesconsented](#BKMK_msdyncrm_isemailtemplatesconsented)
- [msdyncrm_IsInstallComplete](#BKMK_msdyncrm_IsInstallComplete)
- [msdyncrm_IsMarketingListAvailableInApp](#BKMK_msdyncrm_IsMarketingListAvailableInApp)
- [msdyncrm_marketingconfigurationId](#BKMK_msdyncrm_marketingconfigurationId)
- [msdyncrm_maxretryattempts](#BKMK_msdyncrm_maxretryattempts)
- [msdyncrm_MktSvcDiscoveryEndpointUrl](#BKMK_msdyncrm_MktSvcDiscoveryEndpointUrl)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_organization_config](#BKMK_msdyncrm_organization_config)
- [msdyncrm_realtimediscoveryendpointurl](#BKMK_msdyncrm_realtimediscoveryendpointurl)
- [msdyncrm_realtimetokenauthenticationresource](#BKMK_msdyncrm_realtimetokenauthenticationresource)
- [msdyncrm_realtimeusebasicauth](#BKMK_msdyncrm_realtimeusebasicauth)
- [msdyncrm_setupstatus](#BKMK_msdyncrm_setupstatus)
- [msdyncrm_tokenauthenticationresource](#BKMK_msdyncrm_tokenauthenticationresource)
- [msdyncrm_UseBasicAuth](#BKMK_msdyncrm_UseBasicAuth)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msdyncrm_configcacheexpirationdate"></a> msdyncrm_configcacheexpirationdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Config cache expiration date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_configcacheexpirationdate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_ConfigCacheExpirationPeriodInMs"></a> msdyncrm_ConfigCacheExpirationPeriodInMs

|Property|Value|
|---|---|
|Description||
|DisplayName|**Config cache expiration period (milliseconds)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_configcacheexpirationperiodinms`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_default"></a> msdyncrm_default

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_default`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingconfiguration_msdyncrm_default`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_FirstTimeSetupUrl"></a> msdyncrm_FirstTimeSetupUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing First Time Setup Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_firsttimesetupurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_httptimeout"></a> msdyncrm_httptimeout

|Property|Value|
|---|---|
|Description||
|DisplayName|**HTTP timeout (milliseconds)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_httptimeout`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|120000|
|MinValue|0|

### <a name="BKMK_msdyncrm_isemailtemplatesconsented"></a> msdyncrm_isemailtemplatesconsented

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Consent Given**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_isemailtemplatesconsented`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingconfiguration_msdyncrm_isemailtemplatesconsented`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_IsInstallComplete"></a> msdyncrm_IsInstallComplete

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is install complete**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_isinstallcomplete`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingconfiguration_msdyncrm_isinstallcomplete`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_IsMarketingListAvailableInApp"></a> msdyncrm_IsMarketingListAvailableInApp

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is marketing list available in the app**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_ismarketinglistavailableinapp`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingconfiguration_msdyncrm_ismarketinglistavailableinapp`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_marketingconfigurationId"></a> msdyncrm_marketingconfigurationId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Marketing configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingconfigurationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_maxretryattempts"></a> msdyncrm_maxretryattempts

|Property|Value|
|---|---|
|Description||
|DisplayName|**Maximum retry attempts**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_maxretryattempts`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|20|
|MinValue|0|

### <a name="BKMK_msdyncrm_MktSvcDiscoveryEndpointUrl"></a> msdyncrm_MktSvcDiscoveryEndpointUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing service discovery endpoint URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_mktsvcdiscoveryendpointurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the marketing configuration entity**|
|DisplayName|**Marketing configuration**|
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

### <a name="BKMK_msdyncrm_organization_config"></a> msdyncrm_organization_config

|Property|Value|
|---|---|
|Description|**The configuration JSON**|
|DisplayName|**Organization config**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_organization_config`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyncrm_realtimediscoveryendpointurl"></a> msdyncrm_realtimediscoveryendpointurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Service Discovery Endpoint Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_realtimediscoveryendpointurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_realtimetokenauthenticationresource"></a> msdyncrm_realtimetokenauthenticationresource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Token Authentication Resource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_realtimetokenauthenticationresource`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyncrm_realtimeusebasicauth"></a> msdyncrm_realtimeusebasicauth

|Property|Value|
|---|---|
|Description||
|DisplayName|**Use Basic Auth**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_realtimeusebasicauth`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingconfiguration_msdyncrm_realtimeusebasicauth`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_setupstatus"></a> msdyncrm_setupstatus

|Property|Value|
|---|---|
|Description|**The organization setup status json**|
|DisplayName|**Organization setup status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_setupstatus`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyncrm_tokenauthenticationresource"></a> msdyncrm_tokenauthenticationresource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Token authentication resource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_tokenauthenticationresource`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyncrm_UseBasicAuth"></a> msdyncrm_UseBasicAuth

|Property|Value|
|---|---|
|Description||
|DisplayName|**Use basic authentication**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_usebasicauth`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingconfiguration_msdyncrm_usebasicauth`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the marketing configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingconfiguration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Marketing configuration status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingconfiguration_statuscode`|

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
- [OrganizationId](#BKMK_OrganizationId)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique ID of the organization**|
|DisplayName|**Organization ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

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

- [lk_msdyncrm_marketingconfiguration_createdby](#BKMK_lk_msdyncrm_marketingconfiguration_createdby)
- [lk_msdyncrm_marketingconfiguration_createdonbehalfby](#BKMK_lk_msdyncrm_marketingconfiguration_createdonbehalfby)
- [lk_msdyncrm_marketingconfiguration_modifiedby](#BKMK_lk_msdyncrm_marketingconfiguration_modifiedby)
- [lk_msdyncrm_marketingconfiguration_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingconfiguration_modifiedonbehalfby)
- [organization_msdyncrm_marketingconfiguration](#BKMK_organization_msdyncrm_marketingconfiguration)

### <a name="BKMK_lk_msdyncrm_marketingconfiguration_createdby"></a> lk_msdyncrm_marketingconfiguration_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingconfiguration_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingconfiguration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingconfiguration_createdonbehalfby"></a> lk_msdyncrm_marketingconfiguration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingconfiguration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingconfiguration_modifiedby"></a> lk_msdyncrm_marketingconfiguration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingconfiguration_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingconfiguration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingconfiguration_modifiedonbehalfby"></a> lk_msdyncrm_marketingconfiguration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingconfiguration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyncrm_marketingconfiguration"></a> organization_msdyncrm_marketingconfiguration

One-To-Many Relationship: [organization organization_msdyncrm_marketingconfiguration](organization.md#BKMK_organization_msdyncrm_marketingconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyncrm_marketingconfiguration_AsyncOperations](#BKMK_msdyncrm_marketingconfiguration_AsyncOperations)
- [msdyncrm_marketingconfiguration_BulkDeleteFailures](#BKMK_msdyncrm_marketingconfiguration_BulkDeleteFailures)
- [msdyncrm_marketingconfiguration_DuplicateBaseRecord](#BKMK_msdyncrm_marketingconfiguration_DuplicateBaseRecord)
- [msdyncrm_marketingconfiguration_DuplicateMatchingRecord](#BKMK_msdyncrm_marketingconfiguration_DuplicateMatchingRecord)
- [msdyncrm_marketingconfiguration_MailboxTrackingFolders](#BKMK_msdyncrm_marketingconfiguration_MailboxTrackingFolders)
- [msdyncrm_marketingconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingconfiguration_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingconfiguration_ProcessSession](#BKMK_msdyncrm_marketingconfiguration_ProcessSession)
- [msdyncrm_marketingconfiguration_SyncErrors](#BKMK_msdyncrm_marketingconfiguration_SyncErrors)

### <a name="BKMK_msdyncrm_marketingconfiguration_AsyncOperations"></a> msdyncrm_marketingconfiguration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingconfiguration_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingconfiguration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingconfiguration_BulkDeleteFailures"></a> msdyncrm_marketingconfiguration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingconfiguration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingconfiguration_DuplicateBaseRecord"></a> msdyncrm_marketingconfiguration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_marketingconfiguration_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_marketingconfiguration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingconfiguration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingconfiguration_DuplicateMatchingRecord"></a> msdyncrm_marketingconfiguration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_marketingconfiguration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_marketingconfiguration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingconfiguration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingconfiguration_MailboxTrackingFolders"></a> msdyncrm_marketingconfiguration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingconfiguration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingconfiguration_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingconfiguration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingconfiguration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingconfiguration_ProcessSession"></a> msdyncrm_marketingconfiguration_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingconfiguration_ProcessSession](processsession.md#BKMK_msdyncrm_marketingconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingconfiguration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingconfiguration_SyncErrors"></a> msdyncrm_marketingconfiguration_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingconfiguration_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingconfiguration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

