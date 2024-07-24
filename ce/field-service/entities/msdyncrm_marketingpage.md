---
title: "Marketing page (msdyncrm_marketingpage) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Marketing page (msdyncrm_marketingpage) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Marketing page (msdyncrm_marketingpage) table/entity reference



## Messages

The following table lists the messages for the Marketing page (msdyncrm_marketingpage) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_marketingpages(*msdyncrm_marketingpageid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_marketingpages<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingpages(*msdyncrm_marketingpageid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdyncrm_MarketingPageSynchronize`<br />Event: True |**msdyncrm_MarketingPageSynchronize action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingpages(*msdyncrm_marketingpageid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingpages<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingpages(*msdyncrm_marketingpageid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingpages(*msdyncrm_marketingpageid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingpages(*msdyncrm_marketingpageid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Marketing page (msdyncrm_marketingpage) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Marketing page (msdyncrm_marketingpage) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Marketing page** |
| **DisplayCollectionName** | **Marketing pages** |
| **SchemaName** | `msdyncrm_marketingpage` |
| **CollectionSchemaName** | `msdyncrm_marketingpages` |
| **EntitySetName** | `msdyncrm_marketingpages`|
| **LogicalName** | `msdyncrm_marketingpage` |
| **LogicalCollectionName** | `msdyncrm_marketingpages` |
| **PrimaryIdAttribute** | `msdyncrm_marketingpageid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_pagetemplateid](#BKMK_adx_pagetemplateid)
- [adx_parentwebpageid](#BKMK_adx_parentwebpageid)
- [adx_webpageid](#BKMK_adx_webpageid)
- [adx_websiteid](#BKMK_adx_websiteid)
- [adx_websitelanguageid](#BKMK_adx_websitelanguageid)
- [adx_webtemplateid](#BKMK_adx_webtemplateid)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_alloweddomains](#BKMK_msdyncrm_alloweddomains)
- [msdyncrm_Content](#BKMK_msdyncrm_Content)
- [msdyncrm_contenttype](#BKMK_msdyncrm_contenttype)
- [msdyncrm_forceportalless](#BKMK_msdyncrm_forceportalless)
- [msdyncrm_formpagemapping](#BKMK_msdyncrm_formpagemapping)
- [msdyncrm_full_page_url](#BKMK_msdyncrm_full_page_url)
- [msdyncrm_full_page_urls](#BKMK_msdyncrm_full_page_urls)
- [msdyncrm_iamlive](#BKMK_msdyncrm_iamlive)
- [msdyncrm_insights_placeholder](#BKMK_msdyncrm_insights_placeholder)
- [msdyncrm_lastgoinglivedate](#BKMK_msdyncrm_lastgoinglivedate)
- [msdyncrm_lastpublisheddate](#BKMK_msdyncrm_lastpublisheddate)
- [msdyncrm_lastpublishstate](#BKMK_msdyncrm_lastpublishstate)
- [msdyncrm_lastunpublisheddate](#BKMK_msdyncrm_lastunpublisheddate)
- [msdyncrm_marketingpageId](#BKMK_msdyncrm_marketingpageId)
- [msdyncrm_marketingpagetemplate](#BKMK_msdyncrm_marketingpagetemplate)
- [msdyncrm_marketingprovided](#BKMK_msdyncrm_marketingprovided)
- [msdyncrm_marketingwebsite](#BKMK_msdyncrm_marketingwebsite)
- [msdyncrm_markettype](#BKMK_msdyncrm_markettype)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_optimizedfor](#BKMK_msdyncrm_optimizedfor)
- [msdyncrm_partialurl](#BKMK_msdyncrm_partialurl)
- [msdyncrm_purpose](#BKMK_msdyncrm_purpose)
- [msdyncrm_remote_websiteid](#BKMK_msdyncrm_remote_websiteid)
- [msdyncrm_type](#BKMK_msdyncrm_type)
- [msdyncrm_visualstyle](#BKMK_msdyncrm_visualstyle)
- [msdyncrm_websitefilter_placeholder](#BKMK_msdyncrm_websitefilter_placeholder)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_pagetemplateid"></a> adx_pagetemplateid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_pagetemplateid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|72|

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

### <a name="BKMK_adx_webpageid"></a> adx_webpageid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_webpageid`|
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

### <a name="BKMK_adx_webtemplateid"></a> adx_webtemplateid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_webtemplateid`|
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

### <a name="BKMK_msdyncrm_alloweddomains"></a> msdyncrm_alloweddomains

|Property|Value|
|---|---|
|Description||
|DisplayName|**Known domains**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_alloweddomains`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyncrm_Content"></a> msdyncrm_Content

|Property|Value|
|---|---|
|Description||
|DisplayName|**Content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_content`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyncrm_contenttype"></a> msdyncrm_contenttype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Content type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contenttype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_contenttype`|

#### msdyncrm_contenttype Choices/Options

|Value|Label|
|---|---|
|0|**Structural**|
|1|**Product launch**|
|2|**Product information**|
|3|**Company background**|
|4|**Event information**|
|5|**Offers and discounts**|
|6|**Confirmation request**|

### <a name="BKMK_msdyncrm_forceportalless"></a> msdyncrm_forceportalless

|Property|Value|
|---|---|
|Description||
|DisplayName|**Force portal-less**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_forceportalless`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingpage_msdyncrm_forceportalless`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_formpagemapping"></a> msdyncrm_formpagemapping

|Property|Value|
|---|---|
|Description||
|DisplayName|**Form page mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_formpagemapping`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyncrm_full_page_url"></a> msdyncrm_full_page_url

|Property|Value|
|---|---|
|Description||
|DisplayName|**Full page URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_full_page_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_full_page_urls"></a> msdyncrm_full_page_urls

|Property|Value|
|---|---|
|Description||
|DisplayName|**Full page urls**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_full_page_urls`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyncrm_iamlive"></a> msdyncrm_iamlive

|Property|Value|
|---|---|
|Description|**flag to check that the page is live**|
|DisplayName|**flag to check that the page is live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_iamlive`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_iamlive`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_insights_placeholder"></a> msdyncrm_insights_placeholder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_insights_placeholder`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_lastgoinglivedate"></a> msdyncrm_lastgoinglivedate

|Property|Value|
|---|---|
|Description|**Date and time when the marketing page last tried going live**|
|DisplayName|**Last going live date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lastgoinglivedate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_lastpublisheddate"></a> msdyncrm_lastpublisheddate

|Property|Value|
|---|---|
|Description|**Date and time when the marketing page was last published**|
|DisplayName|**Last published date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lastpublisheddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_lastpublishstate"></a> msdyncrm_lastpublishstate

|Property|Value|
|---|---|
|Description|**State of last going live attempt**|
|DisplayName|**Last published state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lastpublishstate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_lastpublishstate`|

#### msdyncrm_lastpublishstate Choices/Options

|Value|Label|
|---|---|
|0|**Error**|
|1|**Success**|

### <a name="BKMK_msdyncrm_lastunpublisheddate"></a> msdyncrm_lastunpublisheddate

|Property|Value|
|---|---|
|Description|**Date and time when the marketing page was last unpublished**|
|DisplayName|**Last unpublished date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lastunpublisheddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_marketingpageId"></a> msdyncrm_marketingpageId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Marketing page**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingpageid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_marketingpagetemplate"></a> msdyncrm_marketingpagetemplate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing page template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingpagetemplate`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingpagetemplate|

### <a name="BKMK_msdyncrm_marketingprovided"></a> msdyncrm_marketingprovided

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing Provided**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingprovided`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingpage_msdyncrm_marketingprovided`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_marketingwebsite"></a> msdyncrm_marketingwebsite

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingwebsite`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyncrm_website|

### <a name="BKMK_msdyncrm_markettype"></a> msdyncrm_markettype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Market type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_markettype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_markettype`|

#### msdyncrm_markettype Choices/Options

|Value|Label|
|---|---|
|0|**Enterprise**|
|1|**Consumer**|
|2|**All**|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**Name of the marketing page**|
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

### <a name="BKMK_msdyncrm_optimizedfor"></a> msdyncrm_optimizedfor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Optimized for**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_optimizedfor`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_optimizedfor`|

#### msdyncrm_optimizedfor Choices/Options

|Value|Label|
|---|---|
|0|**Desktop**|
|1|**Tablet**|
|2|**Mobile**|

### <a name="BKMK_msdyncrm_partialurl"></a> msdyncrm_partialurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Partial URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_partialurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_purpose"></a> msdyncrm_purpose

|Property|Value|
|---|---|
|Description||
|DisplayName|**Purpose**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_purpose`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_purpose`|

#### msdyncrm_purpose Choices/Options

|Value|Label|
|---|---|
|0|**Contact capture**|
|1|**Newsletter subscription**|
|2|**Lead generation**|
|3|**Collateral download**|
|4|**Event registration**|
|5|**Event feedback**|
|6|**Structural**|
|7|**Double Opt-In, Email based confirmation**|

### <a name="BKMK_msdyncrm_remote_websiteid"></a> msdyncrm_remote_websiteid

|Property|Value|
|---|---|
|Description|**Unique ID for remote entity instances**|
|DisplayName|**Remote website ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_remote_websiteid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_type"></a> msdyncrm_type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_type`|

#### msdyncrm_type Choices/Options

|Value|Label|
|---|---|
|0|**Landing page**|
|1|**Subscription center**|
|2|**Forward to a friend**|
|3|**Event registration**|

### <a name="BKMK_msdyncrm_visualstyle"></a> msdyncrm_visualstyle

|Property|Value|
|---|---|
|Description||
|DisplayName|**Visual style**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_visualstyle`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_marketingpage_visualstyle`|

#### msdyncrm_visualstyle Choices/Options

|Value|Label|
|---|---|
|0|**Light**|
|1|**Dark**|
|2|**Colorful**|
|3|**Other**|

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
|Description|**Status of the marketing page**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingpage_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350000<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 192350004<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Marketing page status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingpage_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|192350000|Label: **Draft**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350000" tostatusid="192350006" /><allowedtransition sourcestatusid="192350000" tostatusid="192350004" /></allowedtransitions>`|
|192350001|Label: **Live**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350001" tostatusid="192350007" /><allowedtransition sourcestatusid="192350001" tostatusid="192350002" /><allowedtransition sourcestatusid="192350001" tostatusid="192350006" /><allowedtransition sourcestatusid="192350001" tostatusid="192350003" /><allowedtransition sourcestatusid="192350001" tostatusid="192350005" /></allowedtransitions>`|
|192350002|Label: **Stopped**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350002" tostatusid="192350004" /><allowedtransition sourcestatusid="192350002" tostatusid="192350006" /></allowedtransitions>`|
|192350003|Label: **Live, editable**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350003" tostatusid="192350001" /><allowedtransition sourcestatusid="192350003" tostatusid="192350006" /></allowedtransitions>`|
|192350004|Label: **Expired**<br />State:1<br />TransitionData: None|
|192350005|Label: **Error**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350005" tostatusid="192350006" /><allowedtransition sourcestatusid="192350005" tostatusid="192350007" /></allowedtransitions>`|
|192350006|Label: **Going live**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350006" tostatusid="192350001" /><allowedtransition sourcestatusid="192350006" tostatusid="192350005" /><allowedtransition sourcestatusid="192350006" tostatusid="192350007" /></allowedtransitions>`|
|192350007|Label: **Stopping...**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350007" tostatusid="192350002" /><allowedtransition sourcestatusid="192350007" tostatusid="192350005" /></allowedtransitions>`|

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
- [msdyncrm_formtosave](#BKMK_msdyncrm_formtosave)
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

### <a name="BKMK_msdyncrm_formtosave"></a> msdyncrm_formtosave

|Property|Value|
|---|---|
|Description|**Form to save**|
|DisplayName|**Form to save**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_formtosave`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingpage_formtosave`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

- [business_unit_msdyncrm_marketingpage](#BKMK_business_unit_msdyncrm_marketingpage)
- [lk_msdyncrm_marketingpage_createdby](#BKMK_lk_msdyncrm_marketingpage_createdby)
- [lk_msdyncrm_marketingpage_createdonbehalfby](#BKMK_lk_msdyncrm_marketingpage_createdonbehalfby)
- [lk_msdyncrm_marketingpage_modifiedby](#BKMK_lk_msdyncrm_marketingpage_modifiedby)
- [lk_msdyncrm_marketingpage_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingpage_modifiedonbehalfby)
- [msdyncrm_marketingpage_marketingpagetemplate](#BKMK_msdyncrm_marketingpage_marketingpagetemplate)
- [msdyncrm_msdyncrm_website_msdyncrm_marketingpage_marketingwebsite](#BKMK_msdyncrm_msdyncrm_website_msdyncrm_marketingpage_marketingwebsite)
- [owner_msdyncrm_marketingpage](#BKMK_owner_msdyncrm_marketingpage)
- [team_msdyncrm_marketingpage](#BKMK_team_msdyncrm_marketingpage)
- [user_msdyncrm_marketingpage](#BKMK_user_msdyncrm_marketingpage)

### <a name="BKMK_business_unit_msdyncrm_marketingpage"></a> business_unit_msdyncrm_marketingpage

One-To-Many Relationship: [businessunit business_unit_msdyncrm_marketingpage](businessunit.md#BKMK_business_unit_msdyncrm_marketingpage)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingpage_createdby"></a> lk_msdyncrm_marketingpage_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingpage_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingpage_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingpage_createdonbehalfby"></a> lk_msdyncrm_marketingpage_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingpage_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingpage_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingpage_modifiedby"></a> lk_msdyncrm_marketingpage_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingpage_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingpage_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingpage_modifiedonbehalfby"></a> lk_msdyncrm_marketingpage_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingpage_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingpage_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingpage_marketingpagetemplate"></a> msdyncrm_marketingpage_marketingpagetemplate

One-To-Many Relationship: [msdyncrm_marketingpagetemplate msdyncrm_marketingpage_marketingpagetemplate](msdyncrm_marketingpagetemplate.md#BKMK_msdyncrm_marketingpage_marketingpagetemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingpagetemplate`|
|ReferencedAttribute|`msdyncrm_marketingpagetemplateid`|
|ReferencingAttribute|`msdyncrm_marketingpagetemplate`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_marketingpagetemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_website_msdyncrm_marketingpage_marketingwebsite"></a> msdyncrm_msdyncrm_website_msdyncrm_marketingpage_marketingwebsite

One-To-Many Relationship: [msdyncrm_website msdyncrm_msdyncrm_website_msdyncrm_marketingpage_marketingwebsite](msdyncrm_website.md#BKMK_msdyncrm_msdyncrm_website_msdyncrm_marketingpage_marketingwebsite)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_website`|
|ReferencedAttribute|`msdyncrm_websiteid`|
|ReferencingAttribute|`msdyncrm_marketingwebsite`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_marketingwebsite`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_marketingpage"></a> owner_msdyncrm_marketingpage

One-To-Many Relationship: [owner owner_msdyncrm_marketingpage](owner.md#BKMK_owner_msdyncrm_marketingpage)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_marketingpage"></a> team_msdyncrm_marketingpage

One-To-Many Relationship: [team team_msdyncrm_marketingpage](team.md#BKMK_team_msdyncrm_marketingpage)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_marketingpage"></a> user_msdyncrm_marketingpage

One-To-Many Relationship: [systemuser user_msdyncrm_marketingpage](systemuser.md#BKMK_user_msdyncrm_marketingpage)

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

- [msdyncrm_marketingpage_Annotations](#BKMK_msdyncrm_marketingpage_Annotations)
- [msdyncrm_marketingpage_AsyncOperations](#BKMK_msdyncrm_marketingpage_AsyncOperations)
- [msdyncrm_marketingpage_BulkDeleteFailures](#BKMK_msdyncrm_marketingpage_BulkDeleteFailures)
- [msdyncrm_marketingpage_MailboxTrackingFolders](#BKMK_msdyncrm_marketingpage_MailboxTrackingFolders)
- [msdyncrm_marketingpage_marketingformsubmission](#BKMK_msdyncrm_marketingpage_marketingformsubmission)
- [msdyncrm_marketingpage_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingpage_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingpage_ProcessSession](#BKMK_msdyncrm_marketingpage_ProcessSession)
- [msdyncrm_marketingpage_SyncErrors](#BKMK_msdyncrm_marketingpage_SyncErrors)
- [msdyncrm_msdyncrm_marketingpage_contact_marketingpageid](#BKMK_msdyncrm_msdyncrm_marketingpage_contact_marketingpageid)
- [msdyncrm_msdyncrm_marketingpage_lead_marketingpageid](#BKMK_msdyncrm_msdyncrm_marketingpage_lead_marketingpageid)
- [msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage](#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage)
- [msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi](#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi)
- [msdyncrm_msdyncrm_marketingpage_msdyncrm_deprecatedpageactivity_marketingpageid](#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_deprecatedpageactivity_marketingpageid)
- [msdyncrm_msdyncrm_marketingpage_msdyncrm_formpage](#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_formpage)
- [msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin](#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin)
- [msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage](#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage)

### <a name="BKMK_msdyncrm_marketingpage_Annotations"></a> msdyncrm_marketingpage_Annotations

Many-To-One Relationship: [annotation msdyncrm_marketingpage_Annotations](annotation.md#BKMK_msdyncrm_marketingpage_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpage_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpage_AsyncOperations"></a> msdyncrm_marketingpage_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingpage_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingpage_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpage_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpage_BulkDeleteFailures"></a> msdyncrm_marketingpage_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingpage_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingpage_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpage_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpage_MailboxTrackingFolders"></a> msdyncrm_marketingpage_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingpage_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingpage_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpage_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpage_marketingformsubmission"></a> msdyncrm_marketingpage_marketingformsubmission

Many-To-One Relationship: [msdyncrm_marketingformsubmission msdyncrm_marketingpage_marketingformsubmission](msdyncrm_marketingformsubmission.md#BKMK_msdyncrm_marketingpage_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformsubmission`|
|ReferencingAttribute|`msdyncrm_marketingpageid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpage_marketingformsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpage_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingpage_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingpage_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingpage_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpage_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpage_ProcessSession"></a> msdyncrm_marketingpage_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingpage_ProcessSession](processsession.md#BKMK_msdyncrm_marketingpage_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpage_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpage_SyncErrors"></a> msdyncrm_marketingpage_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingpage_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingpage_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingpage_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_contact_marketingpageid"></a> msdyncrm_msdyncrm_marketingpage_contact_marketingpageid

Many-To-One Relationship: [contact msdyncrm_msdyncrm_marketingpage_contact_marketingpageid](contact.md#BKMK_msdyncrm_msdyncrm_marketingpage_contact_marketingpageid)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`msdyncrm_marketingpageid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingpage_contact_marketingpageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_lead_marketingpageid"></a> msdyncrm_msdyncrm_marketingpage_lead_marketingpageid

Many-To-One Relationship: [lead msdyncrm_msdyncrm_marketingpage_lead_marketingpageid](lead.md#BKMK_msdyncrm_msdyncrm_marketingpage_lead_marketingpageid)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`msdyncrm_marketingpageid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingpage_lead_marketingpageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage"></a> msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage

Many-To-One Relationship: [msdyncrm_defaultmarketingsetting msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage](msdyncrm_defaultmarketingsetting.md#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_defaultmarketingsetting`|
|ReferencingAttribute|`msdyncrm_defaultmarketingthankyoupage`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi"></a> msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi

Many-To-One Relationship: [msdyncrm_defaultmarketingsetting msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi](msdyncrm_defaultmarketingsetting.md#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_defaultmarketingsetting`|
|ReferencingAttribute|`msdyncrm_defaultmarketingthankyoupagedoi`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingpage_msdyncrm_defaultmarketingsetting_defaultmarketingthankyoupagedoi`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_deprecatedpageactivity_marketingpageid"></a> msdyncrm_msdyncrm_marketingpage_msdyncrm_deprecatedpageactivity_marketingpageid

Many-To-One Relationship: [msdyncrm_deprecatedpageactivity msdyncrm_msdyncrm_marketingpage_msdyncrm_deprecatedpageactivity_marketingpageid](msdyncrm_deprecatedpageactivity.md#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_deprecatedpageactivity_marketingpageid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_deprecatedpageactivity`|
|ReferencingAttribute|`msdyncrm_marketingpageid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingpage_msdyncrm_deprecatedpageactivity_marketingpageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_formpage"></a> msdyncrm_msdyncrm_marketingpage_msdyncrm_formpage

Many-To-One Relationship: [msdyncrm_formpage msdyncrm_msdyncrm_marketingpage_msdyncrm_formpage](msdyncrm_formpage.md#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_formpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_formpage`|
|ReferencingAttribute|`msdyncrm_marketingpageid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingpage_msdyncrm_formpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin"></a> msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin

Many-To-One Relationship: [msdyncrm_geopin msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin](msdyncrm_geopin.md#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_geopin`|
|ReferencingAttribute|`msdyncrm_marketingpagegeopinsid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage"></a> msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage

Many-To-One Relationship: [msdyncrm_marketingform msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage](msdyncrm_marketingform.md#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingform`|
|ReferencingAttribute|`msdyncrm_doubleoptinthankyoupage`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_marketingpage_msdyncrm_marketingform_doubleoptinthankyoupage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyncrm_customerjourney_msdyncrm_marketingpage](#BKMK_msdyncrm_customerjourney_msdyncrm_marketingpage)
- [msdyncrm_marketingpage_marketingemail](#BKMK_msdyncrm_marketingpage_marketingemail)
- [msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj](#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj)

### <a name="BKMK_msdyncrm_customerjourney_msdyncrm_marketingpage"></a> msdyncrm_customerjourney_msdyncrm_marketingpage

See [msdyncrm_customerjourney msdyncrm_customerjourney_msdyncrm_marketingpage Many-To-Many Relationship](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_msdyncrm_marketingpage)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_customerjourney_msdyncrm_marketingpage`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_customerjourney_msdyncrm_marketingpage`|
|IntersectAttribute|`msdyncrm_marketingpageid`|
|NavigationPropertyName|`msdyncrm_customerjourney_msdyncrm_marketingpage`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingpage_marketingemail"></a> msdyncrm_marketingpage_marketingemail

See [msdyncrm_marketingemail msdyncrm_marketingpage_marketingemail Many-To-Many Relationship](msdyncrm_marketingemail.md#BKMK_msdyncrm_marketingpage_marketingemail)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_marketingpage_marketingemail`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_marketingpage_marketingemail`|
|IntersectAttribute|`msdyncrm_marketingpageid`|
|NavigationPropertyName|`msdyncrm_marketingpage_marketingemail`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj"></a> msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj

See [msdyncrm_customerjourney msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj Many-To-Many Relationship](msdyncrm_customerjourney.md#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_msdyncrm_marketingpage_msdyncrm_custome`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj`|
|IntersectAttribute|`msdyncrm_marketingpageid`|
|NavigationPropertyName|`msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

