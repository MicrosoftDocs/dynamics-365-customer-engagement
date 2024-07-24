---
title: "Web Page (Adx_webpage) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Web Page (Adx_webpage) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Web Page (Adx_webpage) table/entity reference

Web Page

## Messages

The following table lists the messages for the Web Page (Adx_webpage) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_webpages(*adx_webpageid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_webpages<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_webpages(*adx_webpageid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_webpages(*adx_webpageid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_webpages<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_webpages(*adx_webpageid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_webpages(*adx_webpageid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_webpages(*adx_webpageid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Web Page (Adx_webpage) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Web Page (Adx_webpage) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Web Page** |
| **DisplayCollectionName** | **Web Pages** |
| **SchemaName** | `Adx_webpage` |
| **CollectionSchemaName** | `Adx_webpages` |
| **EntitySetName** | `adx_webpages`|
| **LogicalName** | `adx_webpage` |
| **LogicalCollectionName** | `adx_webpages` |
| **PrimaryIdAttribute** | `adx_webpageid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_AllowOrigin](#BKMK_adx_AllowOrigin)
- [adx_authorid](#BKMK_adx_authorid)
- [adx_botconsumerid](#BKMK_adx_botconsumerid)
- [Adx_Category](#BKMK_Adx_Category)
- [Adx_Copy](#BKMK_Adx_Copy)
- [Adx_createdbyipaddress](#BKMK_Adx_createdbyipaddress)
- [Adx_createdbyusername](#BKMK_Adx_createdbyusername)
- [adx_customcss](#BKMK_adx_customcss)
- [adx_customjavascript](#BKMK_adx_customjavascript)
- [Adx_DisplayDate](#BKMK_Adx_DisplayDate)
- [Adx_DisplayOrder](#BKMK_Adx_DisplayOrder)
- [adx_EditorialComments](#BKMK_adx_EditorialComments)
- [adx_enablerating](#BKMK_adx_enablerating)
- [Adx_enabletracking](#BKMK_Adx_enabletracking)
- [adx_entityform](#BKMK_adx_entityform)
- [adx_entitylist](#BKMK_adx_entitylist)
- [adx_excludefromsearch](#BKMK_adx_excludefromsearch)
- [Adx_ExpirationDate](#BKMK_Adx_ExpirationDate)
- [adx_feedbackpolicy](#BKMK_adx_feedbackpolicy)
- [Adx_HiddenFromSitemap](#BKMK_Adx_HiddenFromSitemap)
- [adx_image](#BKMK_adx_image)
- [adx_imageurl](#BKMK_adx_imageurl)
- [adx_isOfflineCached](#BKMK_adx_isOfflineCached)
- [adx_isroot](#BKMK_adx_isroot)
- [adx_masterwebpageid](#BKMK_adx_masterwebpageid)
- [adx_meta_description](#BKMK_adx_meta_description)
- [Adx_ModifiedByIPAddress](#BKMK_Adx_ModifiedByIPAddress)
- [Adx_ModifiedByUsername](#BKMK_Adx_ModifiedByUsername)
- [Adx_name](#BKMK_Adx_name)
- [adx_navigation](#BKMK_adx_navigation)
- [adx_pagetemplateid](#BKMK_adx_pagetemplateid)
- [adx_parentpageid](#BKMK_adx_parentpageid)
- [Adx_PartialUrl](#BKMK_Adx_PartialUrl)
- [adx_publishingstateid](#BKMK_adx_publishingstateid)
- [Adx_ReleaseDate](#BKMK_Adx_ReleaseDate)
- [adx_rootwebpageid](#BKMK_adx_rootwebpageid)
- [adx_sharedpageconfiguration](#BKMK_adx_sharedpageconfiguration)
- [adx_subjectid](#BKMK_adx_subjectid)
- [Adx_Summary](#BKMK_Adx_Summary)
- [Adx_Title](#BKMK_Adx_Title)
- [adx_webform](#BKMK_adx_webform)
- [Adx_webpageId](#BKMK_Adx_webpageId)
- [adx_webpagelanguageid](#BKMK_adx_webpagelanguageid)
- [adx_websiteid](#BKMK_adx_websiteid)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_AllowOrigin"></a> adx_AllowOrigin

|Property|Value|
|---|---|
|Description|**Defines CORS header Access-Control-Allow-Origin for cross origin requests.**|
|DisplayName|**Allow Origin**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_alloworigin`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_adx_authorid"></a> adx_authorid

|Property|Value|
|---|---|
|Description|**Unique identifier for Contact associated with Web Page.**|
|DisplayName|**Author**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_authorid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_adx_botconsumerid"></a> adx_botconsumerid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Bot Consumer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_botconsumerid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_botconsumer|

### <a name="BKMK_Adx_Category"></a> Adx_Category

|Property|Value|
|---|---|
|Description||
|DisplayName|**Category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_category`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_webpage_adx_category`|

#### Adx_Category Choices/Options

|Value|Label|
|---|---|
|1|**News**|

### <a name="BKMK_Adx_Copy"></a> Adx_Copy

|Property|Value|
|---|---|
|Description||
|DisplayName|**Copy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_copy`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|655360|

### <a name="BKMK_Adx_createdbyipaddress"></a> Adx_createdbyipaddress

|Property|Value|
|---|---|
|Description||
|DisplayName|**Created By IP Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_createdbyipaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Adx_createdbyusername"></a> Adx_createdbyusername

|Property|Value|
|---|---|
|Description||
|DisplayName|**Created By Username**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_createdbyusername`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_customcss"></a> adx_customcss

|Property|Value|
|---|---|
|Description||
|DisplayName|**Custom CSS**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_customcss`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_adx_customjavascript"></a> adx_customjavascript

|Property|Value|
|---|---|
|Description||
|DisplayName|**Custom JavaScript**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_customjavascript`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_Adx_DisplayDate"></a> Adx_DisplayDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Display Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_displaydate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_Adx_DisplayOrder"></a> Adx_DisplayOrder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Display Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_displayorder`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_adx_EditorialComments"></a> adx_EditorialComments

|Property|Value|
|---|---|
|Description||
|DisplayName|**Editorial Comments**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_editorialcomments`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_adx_enablerating"></a> adx_enablerating

|Property|Value|
|---|---|
|Description|**Setting this value to 'Yes' will allow users to rate the web page.**|
|DisplayName|**Enable Ratings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_enablerating`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webpage_adx_enablerating`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Adx_enabletracking"></a> Adx_enabletracking

|Property|Value|
|---|---|
|Description|**Select whether to enable logging of users' downloads of this webpage.**|
|DisplayName|**Enable Tracking (deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_enabletracking`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webpage_adx_enabletracking`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_entityform"></a> adx_entityform

|Property|Value|
|---|---|
|Description|**Unique identifier for Entity Form associated with Web Page.**|
|DisplayName|**Basic Form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entityform`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_entityform|

### <a name="BKMK_adx_entitylist"></a> adx_entitylist

|Property|Value|
|---|---|
|Description|**Unique identifier for Entity List associated with Web Page.**|
|DisplayName|**List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entitylist`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_entitylist|

### <a name="BKMK_adx_excludefromsearch"></a> adx_excludefromsearch

|Property|Value|
|---|---|
|Description|**Shows whether the webpage is excluded from the portal search.**|
|DisplayName|**Exclude From Search**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_excludefromsearch`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webpage_adx_excludefromsearch`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Adx_ExpirationDate"></a> Adx_ExpirationDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Expiration Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_expirationdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_adx_feedbackpolicy"></a> adx_feedbackpolicy

|Property|Value|
|---|---|
|Description||
|DisplayName|**Comment Policy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_feedbackpolicy`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|756150000|
|GlobalChoiceName|`adx_webpage_adx_feedbackpolicy`|

#### adx_feedbackpolicy Choices/Options

|Value|Label|
|---|---|
|756150000|**Inherit**|
|756150001|**None**|
|756150002|**Open**|
|756150003|**Open to Authenticated Users**|
|756150004|**Moderated**|
|756150005|**Closed**|

### <a name="BKMK_Adx_HiddenFromSitemap"></a> Adx_HiddenFromSitemap

|Property|Value|
|---|---|
|Description||
|DisplayName|**Hidden From Sitemap**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_hiddenfromsitemap`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`adx_webpage_adx_hiddenfromsitemap`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_image"></a> adx_image

|Property|Value|
|---|---|
|Description|**Unique identifier for Web File associated with Web Page.**|
|DisplayName|**Image**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_image`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webfile|

### <a name="BKMK_adx_imageurl"></a> adx_imageurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Image URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_imageurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_adx_isOfflineCached"></a> adx_isOfflineCached

|Property|Value|
|---|---|
|Description|**Define whether to cache this page for PWA.**|
|DisplayName|**isOfflineCached**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_isofflinecached`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webpage_adx_isofflinecached`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_isroot"></a> adx_isroot

|Property|Value|
|---|---|
|Description|**Defines whether this is the "root" record of this translated group of Web Pages.**|
|DisplayName|**Is Root**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_isroot`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`adx_webpage_adx_isroot`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_masterwebpageid"></a> adx_masterwebpageid

|Property|Value|
|---|---|
|Description|**Unique identifier for Web Page associated with Web Page.**|
|DisplayName|**Master Web Page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_masterwebpageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webpage|

### <a name="BKMK_adx_meta_description"></a> adx_meta_description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_meta_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_Adx_ModifiedByIPAddress"></a> Adx_ModifiedByIPAddress

|Property|Value|
|---|---|
|Description||
|DisplayName|**Modified By IP Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_modifiedbyipaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Adx_ModifiedByUsername"></a> Adx_ModifiedByUsername

|Property|Value|
|---|---|
|Description||
|DisplayName|**Modified By Username**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_modifiedbyusername`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Adx_name"></a> Adx_name

|Property|Value|
|---|---|
|Description|**Shows the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_adx_navigation"></a> adx_navigation

|Property|Value|
|---|---|
|Description|**Unique identifier for Web Link Set associated with Web Page.**|
|DisplayName|**Navigation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_navigation`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_weblinkset|

### <a name="BKMK_adx_pagetemplateid"></a> adx_pagetemplateid

|Property|Value|
|---|---|
|Description|**Unique identifier for Page Template associated with Web Page.**|
|DisplayName|**Page Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_pagetemplateid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_pagetemplate|

### <a name="BKMK_adx_parentpageid"></a> adx_parentpageid

|Property|Value|
|---|---|
|Description|**Unique identifier for Web Page associated with Web Page.**|
|DisplayName|**Parent Page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_parentpageid`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|adx_webpage|

### <a name="BKMK_Adx_PartialUrl"></a> Adx_PartialUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Partial URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_partialurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_publishingstateid"></a> adx_publishingstateid

|Property|Value|
|---|---|
|Description|**Unique identifier for Publishing State associated with Web Page.**|
|DisplayName|**Publishing State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_publishingstateid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_publishingstate|

### <a name="BKMK_Adx_ReleaseDate"></a> Adx_ReleaseDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Release Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_releasedate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_adx_rootwebpageid"></a> adx_rootwebpageid

|Property|Value|
|---|---|
|Description|**Lookup to root WebPage.**|
|DisplayName|**Root Webpage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_rootwebpageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webpage|

### <a name="BKMK_adx_sharedpageconfiguration"></a> adx_sharedpageconfiguration

|Property|Value|
|---|---|
|Description|**Determines if the content page uses the root page configuration**|
|DisplayName|**Shared Page Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_sharedpageconfiguration`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`adx_webpage_adx_sharedpageconfiguration`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_subjectid"></a> adx_subjectid

|Property|Value|
|---|---|
|Description|**Unique identifier for Subject associated with Web Page.**|
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_subjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|subject|

### <a name="BKMK_Adx_Summary"></a> Adx_Summary

|Property|Value|
|---|---|
|Description||
|DisplayName|**Summary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_summary`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_Adx_Title"></a> Adx_Title

|Property|Value|
|---|---|
|Description||
|DisplayName|**Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_title`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|512|

### <a name="BKMK_adx_webform"></a> adx_webform

|Property|Value|
|---|---|
|Description|**Unique identifier for Multistep Form associated with Web Page.**|
|DisplayName|**Multistep Form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_webform`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webform|

### <a name="BKMK_Adx_webpageId"></a> Adx_webpageId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Web Page**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_webpageid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_webpagelanguageid"></a> adx_webpagelanguageid

|Property|Value|
|---|---|
|Description|**Language of this web page.**|
|DisplayName|**Webpage Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_webpagelanguageid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_websitelanguage|

### <a name="BKMK_adx_websiteid"></a> adx_websiteid

|Property|Value|
|---|---|
|Description|**Unique identifier for Website associated with Web Page.**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_websiteid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_website|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows when the record was migrated.**|
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
|Description|**Shows the owner ID.**|
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
|Description|**Status of the Web Page**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_webpage_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Web Page**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_webpage_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
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
|Description|**Shows the user who created the record.**|
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
|Description|**Shows when the record was created.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the user who updated the record.**|
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
|Description|**Shows when the record was updated.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
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

- [adx_adx_botconsumer_adx_webpage_botconsumerid](#BKMK_adx_adx_botconsumer_adx_webpage_botconsumerid)
- [adx_contact_webpage](#BKMK_adx_contact_webpage)
- [adx_pagetemplate_webpage](#BKMK_adx_pagetemplate_webpage)
- [adx_publishingstate_webpage](#BKMK_adx_publishingstate_webpage)
- [adx_subject_webpage](#BKMK_adx_subject_webpage)
- [adx_webfile_webpage_image](#BKMK_adx_webfile_webpage_image)
- [adx_webpage_entityform](#BKMK_adx_webpage_entityform)
- [adx_webpage_entitylist](#BKMK_adx_webpage_entitylist)
- [adx_webpage_masterwebpage](#BKMK_adx_webpage_masterwebpage-many-to-one)
- [adx_webpage_navigation_weblinkset](#BKMK_adx_webpage_navigation_weblinkset)
- [adx_webpage_webform](#BKMK_adx_webpage_webform)
- [adx_webpage_webpage](#BKMK_adx_webpage_webpage-many-to-one)
- [adx_webpage_webpage_rootwebpageid](#BKMK_adx_webpage_webpage_rootwebpageid-many-to-one)
- [adx_website_webpage](#BKMK_adx_website_webpage)
- [adx_websitelanguage_webpage_webpagelanguageid](#BKMK_adx_websitelanguage_webpage_webpagelanguageid)
- [business_unit_adx_webpage](#BKMK_business_unit_adx_webpage)
- [lk_adx_webpage_createdby](#BKMK_lk_adx_webpage_createdby)
- [lk_adx_webpage_createdonbehalfby](#BKMK_lk_adx_webpage_createdonbehalfby)
- [lk_adx_webpage_modifiedby](#BKMK_lk_adx_webpage_modifiedby)
- [lk_adx_webpage_modifiedonbehalfby](#BKMK_lk_adx_webpage_modifiedonbehalfby)
- [owner_adx_webpage](#BKMK_owner_adx_webpage)
- [team_adx_webpage](#BKMK_team_adx_webpage)
- [user_adx_webpage](#BKMK_user_adx_webpage)

### <a name="BKMK_adx_adx_botconsumer_adx_webpage_botconsumerid"></a> adx_adx_botconsumer_adx_webpage_botconsumerid

One-To-Many Relationship: [adx_botconsumer adx_adx_botconsumer_adx_webpage_botconsumerid](adx_botconsumer.md#BKMK_adx_adx_botconsumer_adx_webpage_botconsumerid)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_botconsumer`|
|ReferencedAttribute|`adx_botconsumerid`|
|ReferencingAttribute|`adx_botconsumerid`|
|ReferencingEntityNavigationPropertyName|`adx_botconsumerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_contact_webpage"></a> adx_contact_webpage

One-To-Many Relationship: [contact adx_contact_webpage](contact.md#BKMK_adx_contact_webpage)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`adx_authorid`|
|ReferencingEntityNavigationPropertyName|`adx_authorid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_pagetemplate_webpage"></a> adx_pagetemplate_webpage

One-To-Many Relationship: [adx_pagetemplate adx_pagetemplate_webpage](adx_pagetemplate.md#BKMK_adx_pagetemplate_webpage)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_pagetemplate`|
|ReferencedAttribute|`adx_pagetemplateid`|
|ReferencingAttribute|`adx_pagetemplateid`|
|ReferencingEntityNavigationPropertyName|`adx_pagetemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_publishingstate_webpage"></a> adx_publishingstate_webpage

One-To-Many Relationship: [adx_publishingstate adx_publishingstate_webpage](adx_publishingstate.md#BKMK_adx_publishingstate_webpage)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_publishingstate`|
|ReferencedAttribute|`adx_publishingstateid`|
|ReferencingAttribute|`adx_publishingstateid`|
|ReferencingEntityNavigationPropertyName|`adx_publishingstateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_subject_webpage"></a> adx_subject_webpage

One-To-Many Relationship: [subject adx_subject_webpage](subject.md#BKMK_adx_subject_webpage)

|Property|Value|
|---|---|
|ReferencedEntity|`subject`|
|ReferencedAttribute|`subjectid`|
|ReferencingAttribute|`adx_subjectid`|
|ReferencingEntityNavigationPropertyName|`adx_subjectid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webfile_webpage_image"></a> adx_webfile_webpage_image

One-To-Many Relationship: [adx_webfile adx_webfile_webpage_image](adx_webfile.md#BKMK_adx_webfile_webpage_image)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webfile`|
|ReferencedAttribute|`adx_webfileid`|
|ReferencingAttribute|`adx_image`|
|ReferencingEntityNavigationPropertyName|`adx_image`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_entityform"></a> adx_webpage_entityform

One-To-Many Relationship: [adx_entityform adx_webpage_entityform](adx_entityform.md#BKMK_adx_webpage_entityform)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_entityform`|
|ReferencedAttribute|`adx_entityformid`|
|ReferencingAttribute|`adx_entityform`|
|ReferencingEntityNavigationPropertyName|`adx_entityform`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_entitylist"></a> adx_webpage_entitylist

One-To-Many Relationship: [adx_entitylist adx_webpage_entitylist](adx_entitylist.md#BKMK_adx_webpage_entitylist)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_entitylist`|
|ReferencedAttribute|`adx_entitylistid`|
|ReferencingAttribute|`adx_entitylist`|
|ReferencingEntityNavigationPropertyName|`adx_entitylist`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_masterwebpage-many-to-one"></a> adx_webpage_masterwebpage

One-To-Many Relationship: [adx_webpage adx_webpage_masterwebpage](#BKMK_adx_webpage_masterwebpage-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`adx_masterwebpageid`|
|ReferencingEntityNavigationPropertyName|`adx_masterwebpageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_navigation_weblinkset"></a> adx_webpage_navigation_weblinkset

One-To-Many Relationship: [adx_weblinkset adx_webpage_navigation_weblinkset](adx_weblinkset.md#BKMK_adx_webpage_navigation_weblinkset)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_weblinkset`|
|ReferencedAttribute|`adx_weblinksetid`|
|ReferencingAttribute|`adx_navigation`|
|ReferencingEntityNavigationPropertyName|`adx_navigation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_webform"></a> adx_webpage_webform

One-To-Many Relationship: [adx_webform adx_webpage_webform](adx_webform.md#BKMK_adx_webpage_webform)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webform`|
|ReferencedAttribute|`adx_webformid`|
|ReferencingAttribute|`adx_webform`|
|ReferencingEntityNavigationPropertyName|`adx_webform`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_webpage-many-to-one"></a> adx_webpage_webpage

One-To-Many Relationship: [adx_webpage adx_webpage_webpage](#BKMK_adx_webpage_webpage-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`adx_parentpageid`|
|ReferencingEntityNavigationPropertyName|`adx_parentpageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_webpage_rootwebpageid-many-to-one"></a> adx_webpage_webpage_rootwebpageid

One-To-Many Relationship: [adx_webpage adx_webpage_webpage_rootwebpageid](#BKMK_adx_webpage_webpage_rootwebpageid-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`adx_rootwebpageid`|
|ReferencingEntityNavigationPropertyName|`adx_rootwebpageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_website_webpage"></a> adx_website_webpage

One-To-Many Relationship: [adx_website adx_website_webpage](adx_website.md#BKMK_adx_website_webpage)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencingEntityNavigationPropertyName|`adx_websiteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_adx_websitelanguage_webpage_webpagelanguageid"></a> adx_websitelanguage_webpage_webpagelanguageid

One-To-Many Relationship: [adx_websitelanguage adx_websitelanguage_webpage_webpagelanguageid](adx_websitelanguage.md#BKMK_adx_websitelanguage_webpage_webpagelanguageid)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_websitelanguage`|
|ReferencedAttribute|`adx_websitelanguageid`|
|ReferencingAttribute|`adx_webpagelanguageid`|
|ReferencingEntityNavigationPropertyName|`adx_webpagelanguageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_business_unit_adx_webpage"></a> business_unit_adx_webpage

One-To-Many Relationship: [businessunit business_unit_adx_webpage](businessunit.md#BKMK_business_unit_adx_webpage)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webpage_createdby"></a> lk_adx_webpage_createdby

One-To-Many Relationship: [systemuser lk_adx_webpage_createdby](systemuser.md#BKMK_lk_adx_webpage_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webpage_createdonbehalfby"></a> lk_adx_webpage_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_webpage_createdonbehalfby](systemuser.md#BKMK_lk_adx_webpage_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webpage_modifiedby"></a> lk_adx_webpage_modifiedby

One-To-Many Relationship: [systemuser lk_adx_webpage_modifiedby](systemuser.md#BKMK_lk_adx_webpage_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webpage_modifiedonbehalfby"></a> lk_adx_webpage_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_webpage_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_webpage_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_webpage"></a> owner_adx_webpage

One-To-Many Relationship: [owner owner_adx_webpage](owner.md#BKMK_owner_adx_webpage)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_webpage"></a> team_adx_webpage

One-To-Many Relationship: [team team_adx_webpage](team.md#BKMK_team_adx_webpage)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_webpage"></a> user_adx_webpage

One-To-Many Relationship: [systemuser user_adx_webpage](systemuser.md#BKMK_user_adx_webpage)

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

- [adx_entityform_redirectwebpage](#BKMK_adx_entityform_redirectwebpage)
- [adx_entitylist_webpageforcreate](#BKMK_adx_entitylist_webpageforcreate)
- [adx_entitylist_webpagefordetailsview](#BKMK_adx_entitylist_webpagefordetailsview)
- [adx_parentwebpage_shortcut](#BKMK_adx_parentwebpage_shortcut)
- [adx_webformstep_redirectwebpage](#BKMK_adx_webformstep_redirectwebpage)
- [adx_webpage_ActivityPointers](#BKMK_adx_webpage_ActivityPointers)
- [adx_webpage_ad](#BKMK_adx_webpage_ad)
- [adx_webpage_adx_alertsubscriptions](#BKMK_adx_webpage_adx_alertsubscriptions)
- [adx_webpage_adx_inviteredemptions](#BKMK_adx_webpage_adx_inviteredemptions)
- [adx_webpage_adx_portalcomments](#BKMK_adx_webpage_adx_portalcomments)
- [adx_webpage_Annotations](#BKMK_adx_webpage_Annotations)
- [adx_webpage_Appointments](#BKMK_adx_webpage_Appointments)
- [adx_webpage_AsyncOperations](#BKMK_adx_webpage_AsyncOperations)
- [adx_webpage_BulkDeleteFailures](#BKMK_adx_webpage_BulkDeleteFailures)
- [adx_webpage_chats](#BKMK_adx_webpage_chats)
- [adx_webpage_communityforum](#BKMK_adx_webpage_communityforum)
- [adx_webpage_connections1](#BKMK_adx_webpage_connections1)
- [adx_webpage_connections2](#BKMK_adx_webpage_connections2)
- [adx_webpage_Emails](#BKMK_adx_webpage_Emails)
- [adx_webpage_Faxes](#BKMK_adx_webpage_Faxes)
- [adx_webpage_Feedback](#BKMK_adx_webpage_Feedback)
- [adx_webpage_forumnotification](#BKMK_adx_webpage_forumnotification)
- [adx_webpage_Letters](#BKMK_adx_webpage_Letters)
- [adx_webpage_li_inmails](#BKMK_adx_webpage_li_inmails)
- [adx_webpage_li_messages](#BKMK_adx_webpage_li_messages)
- [adx_webpage_li_pointdrivepresentationvieweds](#BKMK_adx_webpage_li_pointdrivepresentationvieweds)
- [adx_webpage_MailboxTrackingFolders](#BKMK_adx_webpage_MailboxTrackingFolders)
- [adx_webpage_masterwebpage](#BKMK_adx_webpage_masterwebpage-one-to-many)
- [adx_webpage_msdyn_bookingalerts](#BKMK_adx_webpage_msdyn_bookingalerts)
- [adx_webpage_msdyn_copilottranscripts](#BKMK_adx_webpage_msdyn_copilottranscripts)
- [adx_webpage_msdyn_ocliveworkitems](#BKMK_adx_webpage_msdyn_ocliveworkitems)
- [adx_webpage_msdyn_ocoutboundmessages](#BKMK_adx_webpage_msdyn_ocoutboundmessages)
- [adx_webpage_msdyn_ocsessions](#BKMK_adx_webpage_msdyn_ocsessions)
- [adx_webpage_msdyn_ocvoicemails](#BKMK_adx_webpage_msdyn_ocvoicemails)
- [adx_webpage_msfp_alerts](#BKMK_adx_webpage_msfp_alerts)
- [adx_webpage_msfp_surveyinvites](#BKMK_adx_webpage_msfp_surveyinvites)
- [adx_webpage_msfp_surveyresponses](#BKMK_adx_webpage_msfp_surveyresponses)
- [adx_webpage_pagealert](#BKMK_adx_webpage_pagealert)
- [adx_webpage_pagenotification](#BKMK_adx_webpage_pagenotification)
- [adx_webpage_PhoneCalls](#BKMK_adx_webpage_PhoneCalls)
- [adx_webpage_PrincipalObjectAttributeAccesses](#BKMK_adx_webpage_PrincipalObjectAttributeAccesses)
- [adx_webpage_ProcessSession](#BKMK_adx_webpage_ProcessSession)
- [adx_webpage_RecurringAppointmentMasters](#BKMK_adx_webpage_RecurringAppointmentMasters)
- [adx_webpage_redirect](#BKMK_adx_webpage_redirect)
- [adx_webpage_ServiceAppointments](#BKMK_adx_webpage_ServiceAppointments)
- [adx_webpage_SharePointDocumentLocations](#BKMK_adx_webpage_SharePointDocumentLocations)
- [adx_webpage_shortcut](#BKMK_adx_webpage_shortcut)
- [adx_webpage_sitemarker](#BKMK_adx_webpage_sitemarker)
- [adx_webpage_SocialActivities](#BKMK_adx_webpage_SocialActivities)
- [adx_webpage_SyncErrors](#BKMK_adx_webpage_SyncErrors)
- [adx_webpage_Tasks](#BKMK_adx_webpage_Tasks)
- [adx_webpage_urlhistory](#BKMK_adx_webpage_urlhistory)
- [adx_webpage_webfile](#BKMK_adx_webpage_webfile)
- [adx_webpage_weblink](#BKMK_adx_webpage_weblink)
- [adx_webpage_webpage](#BKMK_adx_webpage_webpage-one-to-many)
- [adx_webpage_webpage_rootwebpageid](#BKMK_adx_webpage_webpage_rootwebpageid-one-to-many)
- [adx_webpage_webpageaccesscontrolrule](#BKMK_adx_webpage_webpageaccesscontrolrule)
- [adx_webpage_webpagehistory](#BKMK_adx_webpage_webpagehistory)
- [adx_webpage_webpagelog](#BKMK_adx_webpage_webpagelog)

### <a name="BKMK_adx_entityform_redirectwebpage"></a> adx_entityform_redirectwebpage

Many-To-One Relationship: [adx_entityform adx_entityform_redirectwebpage](adx_entityform.md#BKMK_adx_entityform_redirectwebpage)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_entityform`|
|ReferencingAttribute|`adx_redirectwebpage`|
|ReferencedEntityNavigationPropertyName|`adx_entityform_redirectwebpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitylist_webpageforcreate"></a> adx_entitylist_webpageforcreate

Many-To-One Relationship: [adx_entitylist adx_entitylist_webpageforcreate](adx_entitylist.md#BKMK_adx_entitylist_webpageforcreate)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_entitylist`|
|ReferencingAttribute|`adx_webpageforcreate`|
|ReferencedEntityNavigationPropertyName|`adx_entitylist_webpageforcreate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_entitylist_webpagefordetailsview"></a> adx_entitylist_webpagefordetailsview

Many-To-One Relationship: [adx_entitylist adx_entitylist_webpagefordetailsview](adx_entitylist.md#BKMK_adx_entitylist_webpagefordetailsview)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_entitylist`|
|ReferencingAttribute|`adx_webpagefordetailsview`|
|ReferencedEntityNavigationPropertyName|`adx_entitylist_webpagefordetailsview`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: List (Details View)<br />MenuId: null<br />Order: 100590<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_parentwebpage_shortcut"></a> adx_parentwebpage_shortcut

Many-To-One Relationship: [adx_shortcut adx_parentwebpage_shortcut](adx_shortcut.md#BKMK_adx_parentwebpage_shortcut)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_shortcut`|
|ReferencingAttribute|`adx_parentpage_webpageid`|
|ReferencedEntityNavigationPropertyName|`adx_parentwebpage_shortcut`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 101200<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_redirectwebpage"></a> adx_webformstep_redirectwebpage

Many-To-One Relationship: [adx_webformstep adx_webformstep_redirectwebpage](adx_webformstep.md#BKMK_adx_webformstep_redirectwebpage)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webformstep`|
|ReferencingAttribute|`adx_redirectwebpage`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_redirectwebpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_ActivityPointers"></a> adx_webpage_ActivityPointers

Many-To-One Relationship: [activitypointer adx_webpage_ActivityPointers](activitypointer.md#BKMK_adx_webpage_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_ad"></a> adx_webpage_ad

Many-To-One Relationship: [adx_ad adx_webpage_ad](adx_ad.md#BKMK_adx_webpage_ad)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_ad`|
|ReferencingAttribute|`adx_webpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_ad`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100200<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_adx_alertsubscriptions"></a> adx_webpage_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription adx_webpage_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_adx_webpage_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_adx_inviteredemptions"></a> adx_webpage_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption adx_webpage_adx_inviteredemptions](adx_inviteredemption.md#BKMK_adx_webpage_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_adx_portalcomments"></a> adx_webpage_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment adx_webpage_adx_portalcomments](adx_portalcomment.md#BKMK_adx_webpage_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_Annotations"></a> adx_webpage_Annotations

Many-To-One Relationship: [annotation adx_webpage_Annotations](annotation.md#BKMK_adx_webpage_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_Appointments"></a> adx_webpage_Appointments

Many-To-One Relationship: [appointment adx_webpage_Appointments](appointment.md#BKMK_adx_webpage_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_AsyncOperations"></a> adx_webpage_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_webpage_AsyncOperations](asyncoperation.md#BKMK_adx_webpage_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_BulkDeleteFailures"></a> adx_webpage_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_webpage_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_webpage_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_chats"></a> adx_webpage_chats

Many-To-One Relationship: [chat adx_webpage_chats](chat.md#BKMK_adx_webpage_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_communityforum"></a> adx_webpage_communityforum

Many-To-One Relationship: [adx_communityforum adx_webpage_communityforum](adx_communityforum.md#BKMK_adx_webpage_communityforum)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforum`|
|ReferencingAttribute|`adx_parentpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_communityforum`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100700<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_connections1"></a> adx_webpage_connections1

Many-To-One Relationship: [connection adx_webpage_connections1](connection.md#BKMK_adx_webpage_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_connections2"></a> adx_webpage_connections2

Many-To-One Relationship: [connection adx_webpage_connections2](connection.md#BKMK_adx_webpage_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_Emails"></a> adx_webpage_Emails

Many-To-One Relationship: [email adx_webpage_Emails](email.md#BKMK_adx_webpage_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_Faxes"></a> adx_webpage_Faxes

Many-To-One Relationship: [fax adx_webpage_Faxes](fax.md#BKMK_adx_webpage_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_Feedback"></a> adx_webpage_Feedback

Many-To-One Relationship: [feedback adx_webpage_Feedback](feedback.md#BKMK_adx_webpage_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_forumnotification"></a> adx_webpage_forumnotification

Many-To-One Relationship: [adx_forumnotification adx_webpage_forumnotification](adx_forumnotification.md#BKMK_adx_webpage_forumnotification)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_forumnotification`|
|ReferencingAttribute|`adx_forumparentpage`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_forumnotification`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_Letters"></a> adx_webpage_Letters

Many-To-One Relationship: [letter adx_webpage_Letters](letter.md#BKMK_adx_webpage_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_li_inmails"></a> adx_webpage_li_inmails

Many-To-One Relationship: [li_inmail adx_webpage_li_inmails](li_inmail.md#BKMK_adx_webpage_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_li_messages"></a> adx_webpage_li_messages

Many-To-One Relationship: [li_message adx_webpage_li_messages](li_message.md#BKMK_adx_webpage_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_li_pointdrivepresentationvieweds"></a> adx_webpage_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed adx_webpage_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_adx_webpage_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_MailboxTrackingFolders"></a> adx_webpage_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_webpage_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_webpage_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_masterwebpage-one-to-many"></a> adx_webpage_masterwebpage

Many-To-One Relationship: [adx_webpage adx_webpage_masterwebpage](#BKMK_adx_webpage_masterwebpage-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpage`|
|ReferencingAttribute|`adx_masterwebpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_masterwebpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Subscriber Web Pages<br />MenuId: null<br />Order: 101400<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_msdyn_bookingalerts"></a> adx_webpage_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert adx_webpage_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_adx_webpage_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_msdyn_copilottranscripts"></a> adx_webpage_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript adx_webpage_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_adx_webpage_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_msdyn_ocliveworkitems"></a> adx_webpage_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem adx_webpage_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_adx_webpage_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_msdyn_ocoutboundmessages"></a> adx_webpage_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage adx_webpage_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_adx_webpage_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_msdyn_ocsessions"></a> adx_webpage_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession adx_webpage_msdyn_ocsessions](msdyn_ocsession.md#BKMK_adx_webpage_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_msdyn_ocvoicemails"></a> adx_webpage_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail adx_webpage_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_adx_webpage_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_msfp_alerts"></a> adx_webpage_msfp_alerts

Many-To-One Relationship: [msfp_alert adx_webpage_msfp_alerts](msfp_alert.md#BKMK_adx_webpage_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_msfp_surveyinvites"></a> adx_webpage_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite adx_webpage_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_adx_webpage_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_msfp_surveyresponses"></a> adx_webpage_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse adx_webpage_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_adx_webpage_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_pagealert"></a> adx_webpage_pagealert

Many-To-One Relationship: [adx_pagealert adx_webpage_pagealert](adx_pagealert.md#BKMK_adx_webpage_pagealert)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagealert`|
|ReferencingAttribute|`adx_webpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_pagealert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100800<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_pagenotification"></a> adx_webpage_pagenotification

Many-To-One Relationship: [adx_pagenotification adx_webpage_pagenotification](adx_pagenotification.md#BKMK_adx_webpage_pagenotification)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagenotification`|
|ReferencingAttribute|`adx_webpage`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_pagenotification`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_PhoneCalls"></a> adx_webpage_PhoneCalls

Many-To-One Relationship: [phonecall adx_webpage_PhoneCalls](phonecall.md#BKMK_adx_webpage_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_PrincipalObjectAttributeAccesses"></a> adx_webpage_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_webpage_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_webpage_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_ProcessSession"></a> adx_webpage_ProcessSession

Many-To-One Relationship: [processsession adx_webpage_ProcessSession](processsession.md#BKMK_adx_webpage_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_RecurringAppointmentMasters"></a> adx_webpage_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster adx_webpage_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_adx_webpage_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_redirect"></a> adx_webpage_redirect

Many-To-One Relationship: [adx_redirect adx_webpage_redirect](adx_redirect.md#BKMK_adx_webpage_redirect)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_redirect`|
|ReferencingAttribute|`adx_webpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_redirect`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 101100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_ServiceAppointments"></a> adx_webpage_ServiceAppointments

Many-To-One Relationship: [serviceappointment adx_webpage_ServiceAppointments](serviceappointment.md#BKMK_adx_webpage_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_SharePointDocumentLocations"></a> adx_webpage_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation adx_webpage_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_adx_webpage_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_shortcut"></a> adx_webpage_shortcut

Many-To-One Relationship: [adx_shortcut adx_webpage_shortcut](adx_shortcut.md#BKMK_adx_webpage_shortcut)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_shortcut`|
|ReferencingAttribute|`adx_webpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_shortcut`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 101200<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_sitemarker"></a> adx_webpage_sitemarker

Many-To-One Relationship: [adx_sitemarker adx_webpage_sitemarker](adx_sitemarker.md#BKMK_adx_webpage_sitemarker)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_sitemarker`|
|ReferencingAttribute|`adx_pageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_sitemarker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100300<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_SocialActivities"></a> adx_webpage_SocialActivities

Many-To-One Relationship: [socialactivity adx_webpage_SocialActivities](socialactivity.md#BKMK_adx_webpage_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_SyncErrors"></a> adx_webpage_SyncErrors

Many-To-One Relationship: [syncerror adx_webpage_SyncErrors](syncerror.md#BKMK_adx_webpage_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_Tasks"></a> adx_webpage_Tasks

Many-To-One Relationship: [task adx_webpage_Tasks](task.md#BKMK_adx_webpage_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_urlhistory"></a> adx_webpage_urlhistory

Many-To-One Relationship: [adx_urlhistory adx_webpage_urlhistory](adx_urlhistory.md#BKMK_adx_webpage_urlhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_urlhistory`|
|ReferencingAttribute|`adx_webpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_urlhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 101500<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_webfile"></a> adx_webpage_webfile

Many-To-One Relationship: [adx_webfile adx_webpage_webfile](adx_webfile.md#BKMK_adx_webpage_webfile)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webfile`|
|ReferencingAttribute|`adx_parentpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_webfile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Child Files<br />MenuId: null<br />Order: 100100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_weblink"></a> adx_webpage_weblink

Many-To-One Relationship: [adx_weblink adx_webpage_weblink](adx_weblink.md#BKMK_adx_webpage_weblink)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_weblink`|
|ReferencingAttribute|`adx_pageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_weblink`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100400<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_webpage-one-to-many"></a> adx_webpage_webpage

Many-To-One Relationship: [adx_webpage adx_webpage_webpage](#BKMK_adx_webpage_webpage-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpage`|
|ReferencingAttribute|`adx_parentpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_webpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Child Pages<br />MenuId: null<br />Order: 100200<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_webpage_rootwebpageid-one-to-many"></a> adx_webpage_webpage_rootwebpageid

Many-To-One Relationship: [adx_webpage adx_webpage_webpage_rootwebpageid](#BKMK_adx_webpage_webpage_rootwebpageid-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpage`|
|ReferencingAttribute|`adx_rootwebpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_webpage_rootwebpageid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_webpageaccesscontrolrule"></a> adx_webpage_webpageaccesscontrolrule

Many-To-One Relationship: [adx_webpageaccesscontrolrule adx_webpage_webpageaccesscontrolrule](adx_webpageaccesscontrolrule.md#BKMK_adx_webpage_webpageaccesscontrolrule)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpageaccesscontrolrule`|
|ReferencingAttribute|`adx_webpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_webpageaccesscontrolrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Access Control Rules<br />MenuId: null<br />Order: 100100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_webpagehistory"></a> adx_webpage_webpagehistory

Many-To-One Relationship: [adx_webpagehistory adx_webpage_webpagehistory](adx_webpagehistory.md#BKMK_adx_webpage_webpagehistory)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpagehistory`|
|ReferencingAttribute|`adx_webpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_webpagehistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 101600<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_webpagelog"></a> adx_webpage_webpagelog

Many-To-One Relationship: [adx_webpagelog adx_webpage_webpagelog](adx_webpagelog.md#BKMK_adx_webpage_webpagelog)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpagelog`|
|ReferencingAttribute|`adx_webpageid`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_webpagelog`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 101700<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [adx_pagetag_webpage](#BKMK_adx_pagetag_webpage)
- [adx_webpage_tag](#BKMK_adx_webpage_tag)

### <a name="BKMK_adx_pagetag_webpage"></a> adx_pagetag_webpage

See [adx_pagetag adx_pagetag_webpage Many-To-Many Relationship](adx_pagetag.md#BKMK_adx_pagetag_webpage)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_pagetag_webpage`|
|IsCustomizable|True|
|SchemaName|`adx_pagetag_webpage`|
|IntersectAttribute|`adx_webpageid`|
|NavigationPropertyName|`adx_pagetag_webpage`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_tag"></a> adx_webpage_tag

See [adx_tag adx_webpage_tag Many-To-Many Relationship](adx_tag.md#BKMK_adx_webpage_tag)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_webpage_tag`|
|IsCustomizable|True|
|SchemaName|`adx_webpage_tag`|
|IntersectAttribute|`adx_webpageid`|
|NavigationPropertyName|`adx_webpage_tag`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

