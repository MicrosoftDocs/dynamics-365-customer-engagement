---
title: "ai_resourceefficiencysuggestion (msdyn_ai_resourceefficiencysuggestion) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the ai_resourceefficiencysuggestion (msdyn_ai_resourceefficiencysuggestion) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# ai_resourceefficiencysuggestion (msdyn_ai_resourceefficiencysuggestion) table/entity reference

entity containing multiple suggestions for a given resource efficiency

## Messages

The following table lists the messages for the ai_resourceefficiencysuggestion (msdyn_ai_resourceefficiencysuggestion) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_ai_resourceefficiencysuggestions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ai_resourceefficiencysuggestions(*msdyn_ai_resourceefficiencysuggestionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ai_resourceefficiencysuggestions(*msdyn_ai_resourceefficiencysuggestionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ai_resourceefficiencysuggestions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdyn_ai_resourceefficiencysuggestions(*msdyn_ai_resourceefficiencysuggestionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ai_resourceefficiencysuggestions(*msdyn_ai_resourceefficiencysuggestionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the ai_resourceefficiencysuggestion (msdyn_ai_resourceefficiencysuggestion) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the ai_resourceefficiencysuggestion (msdyn_ai_resourceefficiencysuggestion) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **ai_resourceefficiencysuggestion** |
| **DisplayCollectionName** | **ai_resourceefficiencysuggestions** |
| **SchemaName** | `msdyn_ai_resourceefficiencysuggestion` |
| **CollectionSchemaName** | `msdyn_ai_resourceefficiencysuggestions` |
| **EntitySetName** | `msdyn_ai_resourceefficiencysuggestions`|
| **LogicalName** | `msdyn_ai_resourceefficiencysuggestion` |
| **LogicalCollectionName** | `msdyn_ai_resourceefficiencysuggestions` |
| **PrimaryIdAttribute** | `msdyn_ai_resourceefficiencysuggestionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_ai_resourceefficiencysuggestionId](#BKMK_msdyn_ai_resourceefficiencysuggestionId)
- [msdyn_efficiencyid](#BKMK_msdyn_efficiencyid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_templateid](#BKMK_msdyn_templateid)
- [msdyn_value1](#BKMK_msdyn_value1)
- [msdyn_value2](#BKMK_msdyn_value2)
- [msdyn_value3](#BKMK_msdyn_value3)
- [msdyn_value4](#BKMK_msdyn_value4)
- [msdyn_value5](#BKMK_msdyn_value5)
- [msdyn_value6](#BKMK_msdyn_value6)

### <a name="BKMK_msdyn_ai_resourceefficiencysuggestionId"></a> msdyn_ai_resourceefficiencysuggestionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**ai_resourceefficiencysuggestion**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ai_resourceefficiencysuggestionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_efficiencyid"></a> msdyn_efficiencyid

|Property|Value|
|---|---|
|Description||
|DisplayName|**efficiencyid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_efficiencyid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_templateid"></a> msdyn_templateid

|Property|Value|
|---|---|
|Description||
|DisplayName|**templateid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_templateid`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_value1"></a> msdyn_value1

|Property|Value|
|---|---|
|Description||
|DisplayName|**value1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_value1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_value2"></a> msdyn_value2

|Property|Value|
|---|---|
|Description||
|DisplayName|**value2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_value2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_value3"></a> msdyn_value3

|Property|Value|
|---|---|
|Description||
|DisplayName|**value3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_value3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_value4"></a> msdyn_value4

|Property|Value|
|---|---|
|Description||
|DisplayName|**value4**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_value4`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_value5"></a> msdyn_value5

|Property|Value|
|---|---|
|Description||
|DisplayName|**value5**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_value5`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_value6"></a> msdyn_value6

|Property|Value|
|---|---|
|Description||
|DisplayName|**value6**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_value6`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

