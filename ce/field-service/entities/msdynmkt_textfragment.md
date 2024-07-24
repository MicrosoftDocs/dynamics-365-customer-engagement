---
title: "Text fragment (msdynmkt_textfragment) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Text fragment (msdynmkt_textfragment) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Text fragment (msdynmkt_textfragment) table/entity reference



## Messages

The following table lists the messages for the Text fragment (msdynmkt_textfragment) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdynmkt_textfragments<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_textfragments(*msdynmkt_textfragmentid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_textfragments(*msdynmkt_textfragmentid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_textfragments<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdynmkt_textfragments(*msdynmkt_textfragmentid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_textfragments(*msdynmkt_textfragmentid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Text fragment (msdynmkt_textfragment) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Text fragment (msdynmkt_textfragment) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Text fragment** |
| **DisplayCollectionName** | **Text fragments** |
| **SchemaName** | `msdynmkt_textfragment` |
| **CollectionSchemaName** | `msdynmkt_textfragments` |
| **EntitySetName** | `msdynmkt_textfragments`|
| **LogicalName** | `msdynmkt_textfragment` |
| **LogicalCollectionName** | `msdynmkt_textfragments` |
| **PrimaryIdAttribute** | `msdynmkt_textfragmentid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdynmkt_checkedoutto](#BKMK_msdynmkt_checkedoutto)
- [msdynmkt_createdon](#BKMK_msdynmkt_createdon)
- [msdynmkt_fragmentcontent](#BKMK_msdynmkt_fragmentcontent)
- [msdynmkt_ischeckedouttome](#BKMK_msdynmkt_ischeckedouttome)
- [msdynmkt_modifiedon](#BKMK_msdynmkt_modifiedon)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_placeholders](#BKMK_msdynmkt_placeholders)
- [msdynmkt_textfragmentId](#BKMK_msdynmkt_textfragmentId)

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
|MaxLength|100|

### <a name="BKMK_msdynmkt_createdon"></a> msdynmkt_createdon

|Property|Value|
|---|---|
|Description||
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_fragmentcontent"></a> msdynmkt_fragmentcontent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Fragment Content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_fragmentcontent`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

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
|GlobalChoiceName|`msdynmkt_textfragment_msdynmkt_ischeckedouttome`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_modifiedon"></a> msdynmkt_modifiedon

|Property|Value|
|---|---|
|Description||
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_placeholders"></a> msdynmkt_placeholders

|Property|Value|
|---|---|
|Description||
|DisplayName|**Placeholders**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_placeholders`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

### <a name="BKMK_msdynmkt_textfragmentId"></a> msdynmkt_textfragmentId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Text fragment**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_textfragmentid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

