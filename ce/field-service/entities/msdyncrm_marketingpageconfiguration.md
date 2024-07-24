---
title: "Landing page (msdyncrm_marketingpageconfiguration) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Landing page (msdyncrm_marketingpageconfiguration) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Landing page (msdyncrm_marketingpageconfiguration) table/entity reference



## Messages

The following table lists the messages for the Landing page (msdyncrm_marketingpageconfiguration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyncrm_marketingpageconfigurations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingpageconfigurations(*msdyncrm_marketingpageconfigurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingpageconfigurations(*msdyncrm_marketingpageconfigurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingpageconfigurations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingpageconfigurations(*msdyncrm_marketingpageconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingpageconfigurations(*msdyncrm_marketingpageconfigurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingpageconfigurations(*msdyncrm_marketingpageconfigurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Landing page (msdyncrm_marketingpageconfiguration) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Landing page (msdyncrm_marketingpageconfiguration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Landing page** |
| **DisplayCollectionName** | **Landing pages** |
| **SchemaName** | `msdyncrm_marketingpageconfiguration` |
| **CollectionSchemaName** | `msdyncrm_marketingpageconfigurations` |
| **EntitySetName** | `msdyncrm_marketingpageconfigurations`|
| **LogicalName** | `msdyncrm_marketingpageconfiguration` |
| **LogicalCollectionName** | `msdyncrm_marketingpageconfigurations` |
| **PrimaryIdAttribute** | `msdyncrm_marketingpageconfigurationid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_parentwebpageid](#BKMK_adx_parentwebpageid)
- [adx_websiteid](#BKMK_adx_websiteid)
- [adx_websitelanguageid](#BKMK_adx_websitelanguageid)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_allowsubmissiononlyforms](#BKMK_msdyncrm_allowsubmissiononlyforms)
- [msdyncrm_contactcampaignattribute](#BKMK_msdyncrm_contactcampaignattribute)
- [msdyncrm_contactemailattribute](#BKMK_msdyncrm_contactemailattribute)
- [msdyncrm_contactmarketingformattribute](#BKMK_msdyncrm_contactmarketingformattribute)
- [msdyncrm_contactmarketingpageattribute](#BKMK_msdyncrm_contactmarketingpageattribute)
- [msdyncrm_contactmatchingstrategy](#BKMK_msdyncrm_contactmatchingstrategy)
- [msdyncrm_default](#BKMK_msdyncrm_default)
- [msdyncrm_entityupdatebehavioronsubmit](#BKMK_msdyncrm_entityupdatebehavioronsubmit)
- [msdyncrm_insertprivacybanner](#BKMK_msdyncrm_insertprivacybanner)
- [msdyncrm_keepsuccessfulsubmissions](#BKMK_msdyncrm_keepsuccessfulsubmissions)
- [msdyncrm_leadcampaignattribute](#BKMK_msdyncrm_leadcampaignattribute)
- [msdyncrm_leadcontactattribute](#BKMK_msdyncrm_leadcontactattribute)
- [msdyncrm_leademailattribute](#BKMK_msdyncrm_leademailattribute)
- [msdyncrm_leadmarketingformattribute](#BKMK_msdyncrm_leadmarketingformattribute)
- [msdyncrm_leadmarketingpageattribute](#BKMK_msdyncrm_leadmarketingpageattribute)
- [msdyncrm_leadmatchingstrategy](#BKMK_msdyncrm_leadmatchingstrategy)
- [msdyncrm_marketingpageconfigurationId](#BKMK_msdyncrm_marketingpageconfigurationId)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_organizationtype](#BKMK_msdyncrm_organizationtype)
- [msdyncrm_organizationtype_lastrefresh](#BKMK_msdyncrm_organizationtype_lastrefresh)
- [msdyncrm_portalinstallationstatus](#BKMK_msdyncrm_portalinstallationstatus)
- [msdyncrm_portalintegrationtype](#BKMK_msdyncrm_portalintegrationtype)
- [msdyncrm_privacybannertext](#BKMK_msdyncrm_privacybannertext)
- [msdyncrm_privacypolicylinktext](#BKMK_msdyncrm_privacypolicylinktext)
- [msdyncrm_privacypolicylinkurl](#BKMK_msdyncrm_privacypolicylinkurl)
- [msdyncrm_websitefilter_placeholder](#BKMK_msdyncrm_websitefilter_placeholder)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_parentwebpageid"></a> adx_parentwebpageid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_parentwebpageid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|72|

### <a name="BKMK_adx_websiteid"></a> adx_websiteid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_websiteid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|72|

### <a name="BKMK_adx_websitelanguageid"></a> adx_websitelanguageid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_websitelanguageid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|72|

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

### <a name="BKMK_msdyncrm_allowsubmissiononlyforms"></a> msdyncrm_allowsubmissiononlyforms

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow form submissions without updating the contact or lead**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_allowsubmissiononlyforms`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingpageconfiguration_msdyncrm_allowsubmissiononlyforms`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_contactcampaignattribute"></a> msdyncrm_contactcampaignattribute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact source customer journey attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contactcampaignattribute`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_contactemailattribute"></a> msdyncrm_contactemailattribute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact email attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contactemailattribute`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_contactmarketingformattribute"></a> msdyncrm_contactmarketingformattribute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact form attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contactmarketingformattribute`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_contactmarketingpageattribute"></a> msdyncrm_contactmarketingpageattribute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact landing page attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contactmarketingpageattribute`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_contactmatchingstrategy"></a> msdyncrm_contactmatchingstrategy

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact form matching**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contactmatchingstrategy`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyncrm_matchingstrategy|

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
|GlobalChoiceName|`msdyncrm_marketingpageconfiguration_msdyncrm_default`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_entityupdatebehavioronsubmit"></a> msdyncrm_entityupdatebehavioronsubmit

|Property|Value|
|---|---|
|Description||
|DisplayName|**Update contacts/leads**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_entityupdatebehavioronsubmit`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_entityupdatebehavioronsubmit`|

#### msdyncrm_entityupdatebehavioronsubmit Choices/Options

|Value|Label|
|---|---|
|0|**Contacts and leads**|
|1|**Only contacts**|
|2|**Only leads**|
|3|**No update**|

### <a name="BKMK_msdyncrm_insertprivacybanner"></a> msdyncrm_insertprivacybanner

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insert privacy banner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_insertprivacybanner`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingpageconfiguration_msdyncrm_insertprivacybanner`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_keepsuccessfulsubmissions"></a> msdyncrm_keepsuccessfulsubmissions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_keepsuccessfulsubmissions`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingpageconfiguration_msdyncrm_keepsuccessfulsubmissions`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_leadcampaignattribute"></a> msdyncrm_leadcampaignattribute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead campaign attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadcampaignattribute`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_leadcontactattribute"></a> msdyncrm_leadcontactattribute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead contact attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadcontactattribute`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_leademailattribute"></a> msdyncrm_leademailattribute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead email attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leademailattribute`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_leadmarketingformattribute"></a> msdyncrm_leadmarketingformattribute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead form attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadmarketingformattribute`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_leadmarketingpageattribute"></a> msdyncrm_leadmarketingpageattribute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead landing page attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadmarketingpageattribute`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_leadmatchingstrategy"></a> msdyncrm_leadmatchingstrategy

|Property|Value|
|---|---|
|Description||
|DisplayName|**Lead form matching**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadmatchingstrategy`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyncrm_matchingstrategy|

### <a name="BKMK_msdyncrm_marketingpageconfigurationId"></a> msdyncrm_marketingpageconfigurationId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Landing page**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingpageconfigurationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**Name of the landing page**|
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

### <a name="BKMK_msdyncrm_organizationtype"></a> msdyncrm_organizationtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Organization type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_organizationtype`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_organizationtype_lastrefresh"></a> msdyncrm_organizationtype_lastrefresh

|Property|Value|
|---|---|
|Description||
|DisplayName|**lastrefreshtime**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_organizationtype_lastrefresh`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_portalinstallationstatus"></a> msdyncrm_portalinstallationstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Portal installation status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_portalinstallationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpageconfiguration_msdyncrm_portalinstallationstatus`|

#### msdyncrm_portalinstallationstatus Choices/Options

|Value|Label|
|---|---|
|1|**Not started**|
|2|**Started**|
|3|**Failed**|

### <a name="BKMK_msdyncrm_portalintegrationtype"></a> msdyncrm_portalintegrationtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Portal behavior**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_portalintegrationtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpageconfiguration_msdyncrm_portalintegrationtype`|

#### msdyncrm_portalintegrationtype Choices/Options

|Value|Label|
|---|---|
|1|**Force local hosting**|
|2|**Force portal hosting**|

### <a name="BKMK_msdyncrm_privacybannertext"></a> msdyncrm_privacybannertext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Privacy banner text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_privacybannertext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_privacypolicylinktext"></a> msdyncrm_privacypolicylinktext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Privacy policy link text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_privacypolicylinktext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyncrm_privacypolicylinkurl"></a> msdyncrm_privacypolicylinkurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Privacy policy link URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_privacypolicylinkurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_websitefilter_placeholder"></a> msdyncrm_websitefilter_placeholder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_websitefilter_placeholder`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

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
|Description|**Status of the landing page**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingpageconfiguration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**landing page status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingpageconfiguration_statuscode`|

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

- [lk_msdyncrm_marketingpageconfiguration_createdby](#BKMK_lk_msdyncrm_marketingpageconfiguration_createdby)
- [lk_msdyncrm_marketingpageconfiguration_createdonbehalfby](#BKMK_lk_msdyncrm_marketingpageconfiguration_createdonbehalfby)
- [lk_msdyncrm_marketingpageconfiguration_modifiedby](#BKMK_lk_msdyncrm_marketingpageconfiguration_modifiedby)
- [lk_msdyncrm_marketingpageconfiguration_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingpageconfiguration_modifiedonbehalfby)
- [msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy](#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy)
- [msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy](#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy)
- [organization_msdyncrm_marketingpageconfiguration](#BKMK_organization_msdyncrm_marketingpageconfiguration)

### <a name="BKMK_lk_msdyncrm_marketingpageconfiguration_createdby"></a> lk_msdyncrm_marketingpageconfiguration_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingpageconfiguration_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingpageconfiguration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingpageconfiguration_createdonbehalfby"></a> lk_msdyncrm_marketingpageconfiguration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingpageconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingpageconfiguration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingpageconfiguration_modifiedby"></a> lk_msdyncrm_marketingpageconfiguration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingpageconfiguration_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingpageconfiguration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingpageconfiguration_modifiedonbehalfby"></a> lk_msdyncrm_marketingpageconfiguration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingpageconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingpageconfiguration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy"></a> msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy

One-To-Many Relationship: [msdyncrm_matchingstrategy msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy](msdyncrm_matchingstrategy.md#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_matchingstrategy`|
|ReferencedAttribute|`msdyncrm_matchingstrategyid`|
|ReferencingAttribute|`msdyncrm_contactmatchingstrategy`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_contactmatchingstrategy`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy"></a> msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy

One-To-Many Relationship: [msdyncrm_matchingstrategy msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy](msdyncrm_matchingstrategy.md#BKMK_msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_matchingstrategy`|
|ReferencedAttribute|`msdyncrm_matchingstrategyid`|
|ReferencingAttribute|`msdyncrm_leadmatchingstrategy`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_leadmatchingstrategy`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyncrm_marketingpageconfiguration"></a> organization_msdyncrm_marketingpageconfiguration

One-To-Many Relationship: [organization organization_msdyncrm_marketingpageconfiguration](organization.md#BKMK_organization_msdyncrm_marketingpageconfiguration)

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

- [msdyncrm_marketingpageconfiguration_AsyncOperations](#BKMK_msdyncrm_marketingpageconfiguration_AsyncOperations)
- [msdyncrm_marketingpageconfiguration_BulkDeleteFailures](#BKMK_msdyncrm_marketingpageconfiguration_BulkDeleteFailures)
- [msdyncrm_marketingpageconfiguration_MailboxTrackingFolders](#BKMK_msdyncrm_marketingpageconfiguration_MailboxTrackingFolders)
- [msdyncrm_marketingpageconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingpageconfiguration_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingpageconfiguration_ProcessSession](#BKMK_msdyncrm_marketingpageconfiguration_ProcessSession)
- [msdyncrm_marketingpageconfiguration_SyncErrors](#BKMK_msdyncrm_marketingpageconfiguration_SyncErrors)

### <a name="BKMK_msdyncrm_marketingpageconfiguration_AsyncOperations"></a> msdyncrm_marketingpageconfiguration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingpageconfiguration_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingpageconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpageconfiguration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpageconfiguration_BulkDeleteFailures"></a> msdyncrm_marketingpageconfiguration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingpageconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingpageconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpageconfiguration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpageconfiguration_MailboxTrackingFolders"></a> msdyncrm_marketingpageconfiguration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingpageconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingpageconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpageconfiguration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpageconfiguration_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingpageconfiguration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingpageconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingpageconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpageconfiguration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpageconfiguration_ProcessSession"></a> msdyncrm_marketingpageconfiguration_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingpageconfiguration_ProcessSession](processsession.md#BKMK_msdyncrm_marketingpageconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpageconfiguration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpageconfiguration_SyncErrors"></a> msdyncrm_marketingpageconfiguration_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingpageconfiguration_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingpageconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpageconfiguration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

