---
title: "Video (msdynmkt_video) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Video (msdynmkt_video) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Video (msdynmkt_video) table/entity reference



## Messages

The following table lists the messages for the Video (msdynmkt_video) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdynmkt_videos<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_videos(*msdynmkt_videoid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_videos(*msdynmkt_videoid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_videos<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdynmkt_videos(*msdynmkt_videoid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_videos(*msdynmkt_videoid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Video (msdynmkt_video) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Video (msdynmkt_video) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Video** |
| **DisplayCollectionName** | **Videos** |
| **SchemaName** | `msdynmkt_video` |
| **CollectionSchemaName** | `msdynmkt_videos` |
| **EntitySetName** | `msdynmkt_videos`|
| **LogicalName** | `msdynmkt_video` |
| **LogicalCollectionName** | `msdynmkt_videos` |
| **PrimaryIdAttribute** | `msdynmkt_videoid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdynmkt_aitags](#BKMK_msdynmkt_aitags)
- [msdynmkt_binarymetadata](#BKMK_msdynmkt_binarymetadata)
- [msdynmkt_checkedoutto](#BKMK_msdynmkt_checkedoutto)
- [msdynmkt_checkedouttocriteria](#BKMK_msdynmkt_checkedouttocriteria)
- [msdynmkt_cmsid](#BKMK_msdynmkt_cmsid)
- [msdynmkt_cognitiveInformation](#BKMK_msdynmkt_cognitiveInformation)
- [msdynmkt_createddatetime](#BKMK_msdynmkt_createddatetime)
- [msdynmkt_ischeckedouttome](#BKMK_msdynmkt_ischeckedouttome)
- [msdynmkt_ispublished](#BKMK_msdynmkt_ispublished)
- [msdynmkt_keywords](#BKMK_msdynmkt_keywords)
- [msdynmkt_lastmodified](#BKMK_msdynmkt_lastmodified)
- [msdynmkt_lastmodifiedby](#BKMK_msdynmkt_lastmodifiedby)
- [msdynmkt_lastmodifieddatetime](#BKMK_msdynmkt_lastmodifieddatetime)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_previewurl](#BKMK_msdynmkt_previewurl)
- [msdynmkt_processingstatus](#BKMK_msdynmkt_processingstatus)
- [msdynmkt_publicUrl](#BKMK_msdynmkt_publicUrl)
- [msdynmkt_publishedby](#BKMK_msdynmkt_publishedby)
- [msdynmkt_publisheddatetime](#BKMK_msdynmkt_publisheddatetime)
- [msdynmkt_publishedversion](#BKMK_msdynmkt_publishedversion)
- [msdynmkt_state](#BKMK_msdynmkt_state)
- [msdynmkt_thumbnailUrl](#BKMK_msdynmkt_thumbnailUrl)
- [msdynmkt_type](#BKMK_msdynmkt_type)
- [msdynmkt_variantinfo](#BKMK_msdynmkt_variantinfo)
- [msdynmkt_version](#BKMK_msdynmkt_version)
- [msdynmkt_videoId](#BKMK_msdynmkt_videoId)

### <a name="BKMK_msdynmkt_aitags"></a> msdynmkt_aitags

|Property|Value|
|---|---|
|Description||
|DisplayName|**AI Tags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_aitags`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_binarymetadata"></a> msdynmkt_binarymetadata

|Property|Value|
|---|---|
|Description||
|DisplayName|**Binary Metadata**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_binarymetadata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdynmkt_checkedoutto"></a> msdynmkt_checkedoutto

|Property|Value|
|---|---|
|Description||
|DisplayName|**Checked Out To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_checkedoutto`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_checkedouttocriteria"></a> msdynmkt_checkedouttocriteria

|Property|Value|
|---|---|
|Description||
|DisplayName|**Checked Out To Criteria**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_checkedouttocriteria`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdynmkt_cmsid"></a> msdynmkt_cmsid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Cms Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_cmsid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_cognitiveInformation"></a> msdynmkt_cognitiveInformation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Cognitive Information**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_cognitiveinformation`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

### <a name="BKMK_msdynmkt_createddatetime"></a> msdynmkt_createddatetime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Created Date Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_createddatetime`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_ischeckedouttome"></a> msdynmkt_ischeckedouttome

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Checked Out To Me**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ischeckedouttome`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_video_msdynmkt_ischeckedouttome`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_ispublished"></a> msdynmkt_ispublished

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Published**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ispublished`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_video_msdynmkt_ispublished`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_keywords"></a> msdynmkt_keywords

|Property|Value|
|---|---|
|Description||
|DisplayName|**Keywords**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_keywords`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_lastmodified"></a> msdynmkt_lastmodified

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Modified**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lastmodified`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_lastmodifiedby"></a> msdynmkt_lastmodifiedby

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lastmodifiedby`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_lastmodifieddatetime"></a> msdynmkt_lastmodifieddatetime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Modified Date Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lastmodifieddatetime`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_previewurl"></a> msdynmkt_previewurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Preview Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_previewurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_processingstatus"></a> msdynmkt_processingstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Processing Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_processingstatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_publicUrl"></a> msdynmkt_publicUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Public Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_publicurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_publishedby"></a> msdynmkt_publishedby

|Property|Value|
|---|---|
|Description||
|DisplayName|**Published By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_publishedby`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_publisheddatetime"></a> msdynmkt_publisheddatetime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Published Date Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_publisheddatetime`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_publishedversion"></a> msdynmkt_publishedversion

|Property|Value|
|---|---|
|Description||
|DisplayName|**Published Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_publishedversion`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_state"></a> msdynmkt_state

|Property|Value|
|---|---|
|Description||
|DisplayName|**State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_state`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_thumbnailUrl"></a> msdynmkt_thumbnailUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Thumbnail Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_thumbnailurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_type"></a> msdynmkt_type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_type`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_variantinfo"></a> msdynmkt_variantinfo

|Property|Value|
|---|---|
|Description||
|DisplayName|**Variant Info**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_variantinfo`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdynmkt_version"></a> msdynmkt_version

|Property|Value|
|---|---|
|Description||
|DisplayName|**Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_version`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_videoId"></a> msdynmkt_videoId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Video**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_videoid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

