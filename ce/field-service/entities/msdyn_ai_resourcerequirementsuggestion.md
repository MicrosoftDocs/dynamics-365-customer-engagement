---
title: "ai_resourcerequirementsuggestion (msdyn_ai_resourcerequirementsuggestion) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the ai_resourcerequirementsuggestion (msdyn_ai_resourcerequirementsuggestion) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# ai_resourcerequirementsuggestion (msdyn_ai_resourcerequirementsuggestion) table/entity reference

entity with multiple factors for explaining predicted duration for each unscheduled requirement

## Messages

The following table lists the messages for the ai_resourcerequirementsuggestion (msdyn_ai_resourcerequirementsuggestion) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_ai_resourcerequirementsuggestions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ai_resourcerequirementsuggestions(*msdyn_ai_resourcerequirementsuggestionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ai_resourcerequirementsuggestions(*msdyn_ai_resourcerequirementsuggestionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ai_resourcerequirementsuggestions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdyn_ai_resourcerequirementsuggestions(*msdyn_ai_resourcerequirementsuggestionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ai_resourcerequirementsuggestions(*msdyn_ai_resourcerequirementsuggestionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the ai_resourcerequirementsuggestion (msdyn_ai_resourcerequirementsuggestion) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the ai_resourcerequirementsuggestion (msdyn_ai_resourcerequirementsuggestion) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **ai_resourcerequirementsuggestion** |
| **DisplayCollectionName** | **ai_resourcerequirementsuggestions** |
| **SchemaName** | `msdyn_ai_resourcerequirementsuggestion` |
| **CollectionSchemaName** | `msdyn_ai_resourcerequirementsuggestions` |
| **EntitySetName** | `msdyn_ai_resourcerequirementsuggestions`|
| **LogicalName** | `msdyn_ai_resourcerequirementsuggestion` |
| **LogicalCollectionName** | `msdyn_ai_resourcerequirementsuggestions` |
| **PrimaryIdAttribute** | `msdyn_ai_resourcerequirementsuggestionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_ai_resourcerequirementsuggestionId](#BKMK_msdyn_ai_resourcerequirementsuggestionId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_order](#BKMK_msdyn_order)
- [msdyn_referred_entity](#BKMK_msdyn_referred_entity)
- [msdyn_referredid](#BKMK_msdyn_referredid)
- [msdyn_resourcerequirementid](#BKMK_msdyn_resourcerequirementid)
- [msdyn_suggestion_factor](#BKMK_msdyn_suggestion_factor)
- [msdyn_suggestion_value](#BKMK_msdyn_suggestion_value)
- [msdyn_templateid](#BKMK_msdyn_templateid)

### <a name="BKMK_msdyn_ai_resourcerequirementsuggestionId"></a> msdyn_ai_resourcerequirementsuggestionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**ai_resourcerequirementsuggestion**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ai_resourcerequirementsuggestionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msdyn_order"></a> msdyn_order

|Property|Value|
|---|---|
|Description||
|DisplayName|**order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_order`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_referred_entity"></a> msdyn_referred_entity

|Property|Value|
|---|---|
|Description||
|DisplayName|**referred_entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_referred_entity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_referredid"></a> msdyn_referredid

|Property|Value|
|---|---|
|Description||
|DisplayName|**referredid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_referredid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_resourcerequirementid"></a> msdyn_resourcerequirementid

|Property|Value|
|---|---|
|Description||
|DisplayName|**resourcerequirementid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resourcerequirementid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_suggestion_factor"></a> msdyn_suggestion_factor

|Property|Value|
|---|---|
|Description||
|DisplayName|**suggestion_factor**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestion_factor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_suggestion_value"></a> msdyn_suggestion_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**suggestion_value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestion_value`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

