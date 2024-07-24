---
title: "ai_resourcerequirementpwhd (msdyn_ai_resourcerequirementpwhd) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the ai_resourcerequirementpwhd (msdyn_ai_resourcerequirementpwhd) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# ai_resourcerequirementpwhd (msdyn_ai_resourcerequirementpwhd) table/entity reference

entity with predicted duration for each unscheduled requirement

## Messages

The following table lists the messages for the ai_resourcerequirementpwhd (msdyn_ai_resourcerequirementpwhd) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyn_ai_resourcerequirementpwhds<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ai_resourcerequirementpwhds(*msdyn_ai_resourcerequirementpwhdid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ai_resourcerequirementpwhds(*msdyn_ai_resourcerequirementpwhdid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ai_resourcerequirementpwhds<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdyn_ai_resourcerequirementpwhds(*msdyn_ai_resourcerequirementpwhdid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ai_resourcerequirementpwhds(*msdyn_ai_resourcerequirementpwhdid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the ai_resourcerequirementpwhd (msdyn_ai_resourcerequirementpwhd) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the ai_resourcerequirementpwhd (msdyn_ai_resourcerequirementpwhd) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **ai_resourcerequirementpwhd** |
| **DisplayCollectionName** | **ai_resourcerequirementpwhds** |
| **SchemaName** | `msdyn_ai_resourcerequirementpwhd` |
| **CollectionSchemaName** | `msdyn_ai_resourcerequirementpwhds` |
| **EntitySetName** | `msdyn_ai_resourcerequirementpwhds`|
| **LogicalName** | `msdyn_ai_resourcerequirementpwhd` |
| **LogicalCollectionName** | `msdyn_ai_resourcerequirementpwhds` |
| **PrimaryIdAttribute** | `msdyn_ai_resourcerequirementpwhdid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_ai_resourcerequirementpwhdId](#BKMK_msdyn_ai_resourcerequirementpwhdId)
- [msdyn_confidence_score](#BKMK_msdyn_confidence_score)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_predicted_duration](#BKMK_msdyn_predicted_duration)
- [msdyn_resourcerequirementid](#BKMK_msdyn_resourcerequirementid)

### <a name="BKMK_msdyn_ai_resourcerequirementpwhdId"></a> msdyn_ai_resourcerequirementpwhdId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**ai_resourcerequirementpwhd**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ai_resourcerequirementpwhdid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msdyn_predicted_duration"></a> msdyn_predicted_duration

|Property|Value|
|---|---|
|Description||
|DisplayName|**predicted_duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_predicted_duration`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|2147483647|
|MinValue|-2147483648|
|Precision|2|
|SourceTypeMask|0|

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




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

