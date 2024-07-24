---
title: "Text message sender (msdynmkt_smsphonenumber) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Text message sender (msdynmkt_smsphonenumber) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Text message sender (msdynmkt_smsphonenumber) table/entity reference



## Messages

The following table lists the messages for the Text message sender (msdynmkt_smsphonenumber) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdynmkt_smsphonenumbers<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_smsphonenumbers(*msdynmkt_smsphonenumberid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_smsphonenumbers(*msdynmkt_smsphonenumberid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_smsphonenumbers<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdynmkt_smsphonenumbers(*msdynmkt_smsphonenumberid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_smsphonenumbers(*msdynmkt_smsphonenumberid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Text message sender (msdynmkt_smsphonenumber) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Text message sender (msdynmkt_smsphonenumber) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Text message sender** |
| **DisplayCollectionName** | **Text message senders** |
| **SchemaName** | `msdynmkt_smsphonenumber` |
| **CollectionSchemaName** | `msdynmkt_smsphonenumbers` |
| **EntitySetName** | `msdynmkt_smsphonenumbers`|
| **LogicalName** | `msdynmkt_smsphonenumber` |
| **LogicalCollectionName** | `msdynmkt_smsphonenumbers` |
| **PrimaryIdAttribute** | `msdynmkt_smsphonenumberid` |
| **PrimaryNameAttribute** |`msdynmkt_number` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdynmkt_number](#BKMK_msdynmkt_number)
- [msdynmkt_smsphonenumberId](#BKMK_msdynmkt_smsphonenumberId)
- [msdynmkt_status](#BKMK_msdynmkt_status)
- [msdynmkt_type](#BKMK_msdynmkt_type)

### <a name="BKMK_msdynmkt_number"></a> msdynmkt_number

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_number`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_smsphonenumberId"></a> msdynmkt_smsphonenumberId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Text message sender ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_smsphonenumberid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_status"></a> msdynmkt_status

|Property|Value|
|---|---|
|Description|**Status**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_status`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdynmkt_smsphonenumber_msdynmkt_status`|

#### msdynmkt_status Choices/Options

|Value|Label|
|---|---|
|192350000|**Pending**|
|192350001|**Active**|

### <a name="BKMK_msdynmkt_type"></a> msdynmkt_type

|Property|Value|
|---|---|
|Description|**The type of the custom entity.**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_type`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

