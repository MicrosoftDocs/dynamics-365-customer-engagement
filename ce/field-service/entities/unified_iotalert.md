---
title: "unified_iotalert (Deprecated) (unified_iotalert) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the unified_iotalert (Deprecated) (unified_iotalert) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# unified_iotalert (Deprecated) (unified_iotalert) table/entity reference

unified_iotalert (Deprecated)

## Messages

The following table lists the messages for the unified_iotalert (Deprecated) (unified_iotalert) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /unified_iotalerts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /unified_iotalerts(*unified_iotalertid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /unified_iotalerts(*unified_iotalertid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /unified_iotalerts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /unified_iotalerts(*unified_iotalertid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /unified_iotalerts(*unified_iotalertid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the unified_iotalert (Deprecated) (unified_iotalert) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the unified_iotalert (Deprecated) (unified_iotalert) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **unified_iotalert (Deprecated)** |
| **DisplayCollectionName** | **unified_iotalert (Deprecated)** |
| **SchemaName** | `unified_iotalert` |
| **CollectionSchemaName** | `unified_iotalerts` |
| **EntitySetName** | `unified_iotalerts`|
| **LogicalName** | `unified_iotalert` |
| **LogicalCollectionName** | `unified_iotalerts` |
| **PrimaryIdAttribute** | `unified_iotalertid` |
| **PrimaryNameAttribute** |`msdyn_unified_iotalert_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_iotalertid](#BKMK_msdyn_iotalertid)
- [msdyn_iotinsights_deviceid](#BKMK_msdyn_iotinsights_deviceid)
- [msdyn_iotinsights_keys](#BKMK_msdyn_iotinsights_keys)
- [msdyn_iotinsights_measurements](#BKMK_msdyn_iotinsights_measurements)
- [msdyn_iotinsights_ruleid](#BKMK_msdyn_iotinsights_ruleid)
- [msdyn_iotinsights_telemetry](#BKMK_msdyn_iotinsights_telemetry)
- [msdyn_unified_iotalert_name](#BKMK_msdyn_unified_iotalert_name)
- [msdyn_unified_iotalertId](#BKMK_msdyn_unified_iotalertId)
- [unified_iotalertId](#BKMK_unified_iotalertId)

### <a name="BKMK_msdyn_iotalertid"></a> msdyn_iotalertid

|Property|Value|
|---|---|
|Description|**msdyn_iotalertid**|
|DisplayName|**msdyn_iotalertid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iotalertid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_iotinsights_deviceid"></a> msdyn_iotinsights_deviceid

|Property|Value|
|---|---|
|Description|**iotinsights_deviceid**|
|DisplayName|**iotinsights_deviceid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iotinsights_deviceid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_iotinsights_keys"></a> msdyn_iotinsights_keys

|Property|Value|
|---|---|
|Description|**iotinsights_keys**|
|DisplayName|**iotinsights_keys**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iotinsights_keys`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_iotinsights_measurements"></a> msdyn_iotinsights_measurements

|Property|Value|
|---|---|
|Description|**iotinsights_measurements**|
|DisplayName|**iotinsights_measurements**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iotinsights_measurements`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_iotinsights_ruleid"></a> msdyn_iotinsights_ruleid

|Property|Value|
|---|---|
|Description|**iotinsights_ruleid**|
|DisplayName|**iotinsights_ruleid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iotinsights_ruleid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_iotinsights_telemetry"></a> msdyn_iotinsights_telemetry

|Property|Value|
|---|---|
|Description|**iotinsights_telemetry**|
|DisplayName|**iotinsights_telemetry**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iotinsights_telemetry`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_unified_iotalert_name"></a> msdyn_unified_iotalert_name

|Property|Value|
|---|---|
|Description|**Name (Generated)**|
|DisplayName|**Name (Generated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unified_iotalert_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|32|

### <a name="BKMK_msdyn_unified_iotalertId"></a> msdyn_unified_iotalertId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**unified_iotalert**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_unified_iotalertid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_unified_iotalertId"></a> unified_iotalertId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**unified_iotalert (Deprecated)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`unified_iotalertid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

