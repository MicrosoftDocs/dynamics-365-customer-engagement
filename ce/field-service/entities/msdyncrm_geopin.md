---
title: "Geo pin (msdyncrm_geopin) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Geo pin (msdyncrm_geopin) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Geo pin (msdyncrm_geopin) table/entity reference



## Messages

The following table lists the messages for the Geo pin (msdyncrm_geopin) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_geopins(*msdyncrm_geopinid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_geopins<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_geopins(*msdyncrm_geopinid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_geopins(*msdyncrm_geopinid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_geopins<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_geopins(*msdyncrm_geopinid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_geopins(*msdyncrm_geopinid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_geopins(*msdyncrm_geopinid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Geo pin (msdyncrm_geopin) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Geo pin (msdyncrm_geopin) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Geo pin** |
| **DisplayCollectionName** | **Geo pins** |
| **SchemaName** | `msdyncrm_geopin` |
| **CollectionSchemaName** | `msdyncrm_geopins` |
| **EntitySetName** | `msdyncrm_geopins`|
| **LogicalName** | `msdyncrm_geopin` |
| **LogicalCollectionName** | `msdyncrm_geopins` |
| **PrimaryIdAttribute** | `msdyncrm_geopinid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_CenterLatitude](#BKMK_msdyncrm_CenterLatitude)
- [msdyncrm_CenterLongitude](#BKMK_msdyncrm_CenterLongitude)
- [msdyncrm_City](#BKMK_msdyncrm_City)
- [msdyncrm_ContactGeoPinsId](#BKMK_msdyncrm_ContactGeoPinsId)
- [msdyncrm_Country](#BKMK_msdyncrm_Country)
- [msdyncrm_customerjourney](#BKMK_msdyncrm_customerjourney)
- [msdyncrm_geopinId](#BKMK_msdyncrm_geopinId)
- [msdyncrm_kpi_email_clicked_count](#BKMK_msdyncrm_kpi_email_clicked_count)
- [msdyncrm_kpi_email_opened_count](#BKMK_msdyncrm_kpi_email_opened_count)
- [msdyncrm_kpi_form_submitted_count](#BKMK_msdyncrm_kpi_form_submitted_count)
- [msdyncrm_kpi_redirect_link_clicked_count](#BKMK_msdyncrm_kpi_redirect_link_clicked_count)
- [msdyncrm_kpi_website_clicked_count](#BKMK_msdyncrm_kpi_website_clicked_count)
- [msdyncrm_kpi_website_visited_count](#BKMK_msdyncrm_kpi_website_visited_count)
- [msdyncrm_LeadGeoPinsId](#BKMK_msdyncrm_LeadGeoPinsId)
- [msdyncrm_MarketingEmailGeoPinsId](#BKMK_msdyncrm_MarketingEmailGeoPinsId)
- [msdyncrm_marketingformGeoPinsId](#BKMK_msdyncrm_marketingformGeoPinsId)
- [msdyncrm_MarketingPageGeoPinsId](#BKMK_msdyncrm_MarketingPageGeoPinsId)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_NorthwestLatitude](#BKMK_msdyncrm_NorthwestLatitude)
- [msdyncrm_NorthwestLongitude](#BKMK_msdyncrm_NorthwestLongitude)
- [msdyncrm_PostalCode](#BKMK_msdyncrm_PostalCode)
- [msdyncrm_RedirectURLGeoPinsId](#BKMK_msdyncrm_RedirectURLGeoPinsId)
- [msdyncrm_requestbuilderservice_mktgeopins](#BKMK_msdyncrm_requestbuilderservice_mktgeopins)
- [msdyncrm_resultparserservice_mktgeopins](#BKMK_msdyncrm_resultparserservice_mktgeopins)
- [msdyncrm_serverId_marketing](#BKMK_msdyncrm_serverId_marketing)
- [msdyncrm_SoutheastLatitude](#BKMK_msdyncrm_SoutheastLatitude)
- [msdyncrm_SoutheastLongitude](#BKMK_msdyncrm_SoutheastLongitude)
- [msdyncrm_State](#BKMK_msdyncrm_State)
- [msdyncrm_WebsiteGeoPinsId](#BKMK_msdyncrm_WebsiteGeoPinsId)
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

### <a name="BKMK_msdyncrm_CenterLatitude"></a> msdyncrm_CenterLatitude

|Property|Value|
|---|---|
|Description||
|DisplayName|**Center latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_centerlatitude`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_CenterLongitude"></a> msdyncrm_CenterLongitude

|Property|Value|
|---|---|
|Description||
|DisplayName|**Center longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_centerlongitude`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_City"></a> msdyncrm_City

|Property|Value|
|---|---|
|Description|**City**|
|DisplayName|**City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_ContactGeoPinsId"></a> msdyncrm_ContactGeoPinsId

|Property|Value|
|---|---|
|Description|**Unique ID for the contact associated with the Geo Pin**|
|DisplayName|**Contact geo pins**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contactgeopinsid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msdyncrm_Country"></a> msdyncrm_Country

|Property|Value|
|---|---|
|Description|**Country/Region**|
|DisplayName|**Country/Region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_customerjourney"></a> msdyncrm_customerjourney

|Property|Value|
|---|---|
|Description||
|DisplayName|**Customer Journey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_customerjourney`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_customerjourney|

### <a name="BKMK_msdyncrm_geopinId"></a> msdyncrm_geopinId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Geo pin**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_geopinid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_kpi_email_clicked_count"></a> msdyncrm_kpi_email_clicked_count

|Property|Value|
|---|---|
|Description||
|DisplayName|**KPI email clicked count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_kpi_email_clicked_count`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|0|

### <a name="BKMK_msdyncrm_kpi_email_opened_count"></a> msdyncrm_kpi_email_opened_count

|Property|Value|
|---|---|
|Description||
|DisplayName|**KPI email opened count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_kpi_email_opened_count`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|0|

### <a name="BKMK_msdyncrm_kpi_form_submitted_count"></a> msdyncrm_kpi_form_submitted_count

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_kpi_form_submitted_count`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|0|

### <a name="BKMK_msdyncrm_kpi_redirect_link_clicked_count"></a> msdyncrm_kpi_redirect_link_clicked_count

|Property|Value|
|---|---|
|Description||
|DisplayName|**KPI redirect link clicked count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_kpi_redirect_link_clicked_count`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|0|

### <a name="BKMK_msdyncrm_kpi_website_clicked_count"></a> msdyncrm_kpi_website_clicked_count

|Property|Value|
|---|---|
|Description||
|DisplayName|**KPI website clicked count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_kpi_website_clicked_count`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|0|

### <a name="BKMK_msdyncrm_kpi_website_visited_count"></a> msdyncrm_kpi_website_visited_count

|Property|Value|
|---|---|
|Description||
|DisplayName|**KPI website visited count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_kpi_website_visited_count`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|0|

### <a name="BKMK_msdyncrm_LeadGeoPinsId"></a> msdyncrm_LeadGeoPinsId

|Property|Value|
|---|---|
|Description|**Unique ID for the lead associated with the geo pin**|
|DisplayName|**Lead geo pins**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadgeopinsid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|lead|

### <a name="BKMK_msdyncrm_MarketingEmailGeoPinsId"></a> msdyncrm_MarketingEmailGeoPinsId

|Property|Value|
|---|---|
|Description|**Unique ID for the marketing email associated with the geo pin**|
|DisplayName|**Marketing email geo pins**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingemailgeopinsid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingemail|

### <a name="BKMK_msdyncrm_marketingformGeoPinsId"></a> msdyncrm_marketingformGeoPinsId

|Property|Value|
|---|---|
|Description|**Unique ID for the marketing form associated with the geo pin**|
|DisplayName|**Marketing form geo pins**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingformgeopinsid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingform|

### <a name="BKMK_msdyncrm_MarketingPageGeoPinsId"></a> msdyncrm_MarketingPageGeoPinsId

|Property|Value|
|---|---|
|Description|**Unique ID for the marketing page associated with the geo pin**|
|DisplayName|**Marketing page geo pins**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingpagegeopinsid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingpage|

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

### <a name="BKMK_msdyncrm_NorthwestLatitude"></a> msdyncrm_NorthwestLatitude

|Property|Value|
|---|---|
|Description||
|DisplayName|**Northwest latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_northwestlatitude`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_NorthwestLongitude"></a> msdyncrm_NorthwestLongitude

|Property|Value|
|---|---|
|Description||
|DisplayName|**Northwest longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_northwestlongitude`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_PostalCode"></a> msdyncrm_PostalCode

|Property|Value|
|---|---|
|Description|**Postal code**|
|DisplayName|**Postal code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_RedirectURLGeoPinsId"></a> msdyncrm_RedirectURLGeoPinsId

|Property|Value|
|---|---|
|Description|**Unique ID for the redirect URL associated with the geo pin**|
|DisplayName|**Redirect URL geo pins**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_redirecturlgeopinsid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_redirecturl|

### <a name="BKMK_msdyncrm_requestbuilderservice_mktgeopins"></a> msdyncrm_requestbuilderservice_mktgeopins

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing interactions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_requestbuilderservice_mktgeopins`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_resultparserservice_mktgeopins"></a> msdyncrm_resultparserservice_mktgeopins

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing interactions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_resultparserservice_mktgeopins`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_serverId_marketing"></a> msdyncrm_serverId_marketing

|Property|Value|
|---|---|
|Description||
|DisplayName|**serverId_marketing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_serverid_marketing`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_SoutheastLatitude"></a> msdyncrm_SoutheastLatitude

|Property|Value|
|---|---|
|Description||
|DisplayName|**Southeast latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_southeastlatitude`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_SoutheastLongitude"></a> msdyncrm_SoutheastLongitude

|Property|Value|
|---|---|
|Description||
|DisplayName|**Southeast longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_southeastlongitude`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|6|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_State"></a> msdyncrm_State

|Property|Value|
|---|---|
|Description|**State**|
|DisplayName|**State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_state`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_WebsiteGeoPinsId"></a> msdyncrm_WebsiteGeoPinsId

|Property|Value|
|---|---|
|Description|**Unique ID for the website associated with the geo pin**|
|DisplayName|**Website geo pins**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_websitegeopinsid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_website|

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
|Description|**Status of the geo pin**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_geopin_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Geo pin status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_geopin_statuscode`|

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

- [business_unit_msdyncrm_geopin](#BKMK_business_unit_msdyncrm_geopin)
- [lk_msdyncrm_geopin_createdby](#BKMK_lk_msdyncrm_geopin_createdby)
- [lk_msdyncrm_geopin_createdonbehalfby](#BKMK_lk_msdyncrm_geopin_createdonbehalfby)
- [lk_msdyncrm_geopin_modifiedby](#BKMK_lk_msdyncrm_geopin_modifiedby)
- [lk_msdyncrm_geopin_modifiedonbehalfby](#BKMK_lk_msdyncrm_geopin_modifiedonbehalfby)
- [msdyncrm_contact_msdyncrm_geopin](#BKMK_msdyncrm_contact_msdyncrm_geopin)
- [msdyncrm_lead_msdyncrm_geopin](#BKMK_msdyncrm_lead_msdyncrm_geopin)
- [msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney](#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney)
- [msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin](#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin)
- [msdyncrm_msdyncrm_marketingform_msdyncrm_geopin](#BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_geopin)
- [msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin](#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin)
- [msdyncrm_msdyncrm_redirecturl_msdyncrm_geopin](#BKMK_msdyncrm_msdyncrm_redirecturl_msdyncrm_geopin)
- [msdyncrm_msdyncrm_website_msdyncrm_geopin](#BKMK_msdyncrm_msdyncrm_website_msdyncrm_geopin)
- [owner_msdyncrm_geopin](#BKMK_owner_msdyncrm_geopin)
- [team_msdyncrm_geopin](#BKMK_team_msdyncrm_geopin)
- [user_msdyncrm_geopin](#BKMK_user_msdyncrm_geopin)

### <a name="BKMK_business_unit_msdyncrm_geopin"></a> business_unit_msdyncrm_geopin

One-To-Many Relationship: [businessunit business_unit_msdyncrm_geopin](businessunit.md#BKMK_business_unit_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_geopin_createdby"></a> lk_msdyncrm_geopin_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_geopin_createdby](systemuser.md#BKMK_lk_msdyncrm_geopin_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_geopin_createdonbehalfby"></a> lk_msdyncrm_geopin_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_geopin_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_geopin_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_geopin_modifiedby"></a> lk_msdyncrm_geopin_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_geopin_modifiedby](systemuser.md#BKMK_lk_msdyncrm_geopin_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_geopin_modifiedonbehalfby"></a> lk_msdyncrm_geopin_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_geopin_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_geopin_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_contact_msdyncrm_geopin"></a> msdyncrm_contact_msdyncrm_geopin

One-To-Many Relationship: [contact msdyncrm_contact_msdyncrm_geopin](contact.md#BKMK_msdyncrm_contact_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyncrm_contactgeopinsid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_ContactGeoPinsId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_lead_msdyncrm_geopin"></a> msdyncrm_lead_msdyncrm_geopin

One-To-Many Relationship: [lead msdyncrm_lead_msdyncrm_geopin](lead.md#BKMK_msdyncrm_lead_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyncrm_leadgeopinsid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_LeadGeoPinsId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney"></a> msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney](msdyncrm_customerjourney.md#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_geopin_customerJourney)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`msdyncrm_customerjourney`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_customerjourney`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin"></a> msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin

One-To-Many Relationship: [msdyncrm_marketingemail msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin](msdyncrm_marketingemail.md#BKMK_msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemail`|
|ReferencedAttribute|`msdyncrm_marketingemailid`|
|ReferencingAttribute|`msdyncrm_marketingemailgeopinsid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_MarketingEmailGeoPinsId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_geopin"></a> msdyncrm_msdyncrm_marketingform_msdyncrm_geopin

One-To-Many Relationship: [msdyncrm_marketingform msdyncrm_msdyncrm_marketingform_msdyncrm_geopin](msdyncrm_marketingform.md#BKMK_msdyncrm_msdyncrm_marketingform_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingform`|
|ReferencedAttribute|`msdyncrm_marketingformid`|
|ReferencingAttribute|`msdyncrm_marketingformgeopinsid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_marketingformGeoPinsId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin"></a> msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin

One-To-Many Relationship: [msdyncrm_marketingpage msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin](msdyncrm_marketingpage.md#BKMK_msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingpage`|
|ReferencedAttribute|`msdyncrm_marketingpageid`|
|ReferencingAttribute|`msdyncrm_marketingpagegeopinsid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_MarketingPageGeoPinsId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_redirecturl_msdyncrm_geopin"></a> msdyncrm_msdyncrm_redirecturl_msdyncrm_geopin

One-To-Many Relationship: [msdyncrm_redirecturl msdyncrm_msdyncrm_redirecturl_msdyncrm_geopin](msdyncrm_redirecturl.md#BKMK_msdyncrm_msdyncrm_redirecturl_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_redirecturl`|
|ReferencedAttribute|`msdyncrm_redirecturlid`|
|ReferencingAttribute|`msdyncrm_redirecturlgeopinsid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_RedirectURLGeoPinsId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_website_msdyncrm_geopin"></a> msdyncrm_msdyncrm_website_msdyncrm_geopin

One-To-Many Relationship: [msdyncrm_website msdyncrm_msdyncrm_website_msdyncrm_geopin](msdyncrm_website.md#BKMK_msdyncrm_msdyncrm_website_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_website`|
|ReferencedAttribute|`msdyncrm_websiteid`|
|ReferencingAttribute|`msdyncrm_websitegeopinsid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_WebsiteGeoPinsId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_geopin"></a> owner_msdyncrm_geopin

One-To-Many Relationship: [owner owner_msdyncrm_geopin](owner.md#BKMK_owner_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_geopin"></a> team_msdyncrm_geopin

One-To-Many Relationship: [team team_msdyncrm_geopin](team.md#BKMK_team_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_geopin"></a> user_msdyncrm_geopin

One-To-Many Relationship: [systemuser user_msdyncrm_geopin](systemuser.md#BKMK_user_msdyncrm_geopin)

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

- [msdyncrm_geopin_AsyncOperations](#BKMK_msdyncrm_geopin_AsyncOperations)
- [msdyncrm_geopin_BulkDeleteFailures](#BKMK_msdyncrm_geopin_BulkDeleteFailures)
- [msdyncrm_geopin_MailboxTrackingFolders](#BKMK_msdyncrm_geopin_MailboxTrackingFolders)
- [msdyncrm_geopin_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_geopin_PrincipalObjectAttributeAccesses)
- [msdyncrm_geopin_ProcessSession](#BKMK_msdyncrm_geopin_ProcessSession)
- [msdyncrm_geopin_SyncErrors](#BKMK_msdyncrm_geopin_SyncErrors)

### <a name="BKMK_msdyncrm_geopin_AsyncOperations"></a> msdyncrm_geopin_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_geopin_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_geopin_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_geopin_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_geopin_BulkDeleteFailures"></a> msdyncrm_geopin_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_geopin_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_geopin_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_geopin_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_geopin_MailboxTrackingFolders"></a> msdyncrm_geopin_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_geopin_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_geopin_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_geopin_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_geopin_PrincipalObjectAttributeAccesses"></a> msdyncrm_geopin_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_geopin_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_geopin_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_geopin_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_geopin_ProcessSession"></a> msdyncrm_geopin_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_geopin_ProcessSession](processsession.md#BKMK_msdyncrm_geopin_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_geopin_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_geopin_SyncErrors"></a> msdyncrm_geopin_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_geopin_SyncErrors](syncerror.md#BKMK_msdyncrm_geopin_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_geopin_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

