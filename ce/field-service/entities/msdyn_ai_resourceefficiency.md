---
title: "ai_resourceefficiency (msdyn_ai_resourceefficiency) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the ai_resourceefficiency (msdyn_ai_resourceefficiency) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# ai_resourceefficiency (msdyn_ai_resourceefficiency) table/entity reference



## Messages

The following table lists the messages for the ai_resourceefficiency (msdyn_ai_resourceefficiency) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_ai_resourceefficiencies<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ai_resourceefficiencies(*msdyn_ai_resourceefficiencyid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ai_resourceefficiencies(*msdyn_ai_resourceefficiencyid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ai_resourceefficiencies<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdyn_ai_resourceefficiencies(*msdyn_ai_resourceefficiencyid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ai_resourceefficiencies(*msdyn_ai_resourceefficiencyid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the ai_resourceefficiency (msdyn_ai_resourceefficiency) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the ai_resourceefficiency (msdyn_ai_resourceefficiency) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **ai_resourceefficiency** |
| **DisplayCollectionName** | **ai_resourceefficiencies** |
| **SchemaName** | `msdyn_ai_resourceefficiency` |
| **CollectionSchemaName** | `msdyn_ai_resourceefficiencies` |
| **EntitySetName** | `msdyn_ai_resourceefficiencies`|
| **LogicalName** | `msdyn_ai_resourceefficiency` |
| **LogicalCollectionName** | `msdyn_ai_resourceefficiencies` |
| **PrimaryIdAttribute** | `msdyn_ai_resourceefficiencyid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_ai_resourceefficiencyId](#BKMK_msdyn_ai_resourceefficiencyId)
- [msdyn_bookableresourceid](#BKMK_msdyn_bookableresourceid)
- [msdyn_completed_bookings](#BKMK_msdyn_completed_bookings)
- [msdyn_confidence_score](#BKMK_msdyn_confidence_score)
- [msdyn_efficiency_score](#BKMK_msdyn_efficiency_score)
- [msdyn_efficiencyid](#BKMK_msdyn_efficiencyid)
- [msdyn_incidenttypeid](#BKMK_msdyn_incidenttypeid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_territoryid](#BKMK_msdyn_territoryid)
- [msdyn_time_range](#BKMK_msdyn_time_range)

### <a name="BKMK_msdyn_ai_resourceefficiencyId"></a> msdyn_ai_resourceefficiencyId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**ai_resourceefficiency**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ai_resourceefficiencyid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_bookableresourceid"></a> msdyn_bookableresourceid

|Property|Value|
|---|---|
|Description||
|DisplayName|**bookableresourceid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookableresourceid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_completed_bookings"></a> msdyn_completed_bookings

|Property|Value|
|---|---|
|Description||
|DisplayName|**completed_bookings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_completed_bookings`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_confidence_score"></a> msdyn_confidence_score

|Property|Value|
|---|---|
|Description||
|DisplayName|**confidence_score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_confidence_score`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|2147483647|
|MinValue|-2147483648|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_efficiency_score"></a> msdyn_efficiency_score

|Property|Value|
|---|---|
|Description||
|DisplayName|**efficiency_score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_efficiency_score`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|2147483647|
|MinValue|-2147483648|
|Precision|2|
|SourceTypeMask|0|

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

### <a name="BKMK_msdyn_incidenttypeid"></a> msdyn_incidenttypeid

|Property|Value|
|---|---|
|Description||
|DisplayName|**incidenttypeid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_incidenttypeid`|
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

### <a name="BKMK_msdyn_territoryid"></a> msdyn_territoryid

|Property|Value|
|---|---|
|Description||
|DisplayName|**territoryid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_territoryid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_time_range"></a> msdyn_time_range

|Property|Value|
|---|---|
|Description||
|DisplayName|**time_range**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_time_range`|
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

