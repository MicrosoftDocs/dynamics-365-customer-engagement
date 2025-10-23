---
title: "Knowledge Article Suggestion Data Source (msdyn_knowledgearticlesuggestiondatasource) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Knowledge Article Suggestion Data Source (msdyn_knowledgearticlesuggestiondatasource) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Knowledge Article Suggestion Data Source (msdyn_knowledgearticlesuggestiondatasource) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Knowledge Article Suggestion Data Source (msdyn_knowledgearticlesuggestiondatasource) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_knowledgearticlesuggestiondatasources<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_knowledgearticlesuggestiondatasources(*msdyn_knowledgearticlesuggestiondatasourceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_knowledgearticlesuggestiondatasources(*msdyn_knowledgearticlesuggestiondatasourceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_knowledgearticlesuggestiondatasources<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_knowledgearticlesuggestiondatasources(*msdyn_knowledgearticlesuggestiondatasourceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_knowledgearticlesuggestiondatasources(*msdyn_knowledgearticlesuggestiondatasourceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Knowledge Article Suggestion Data Source (msdyn_knowledgearticlesuggestiondatasource) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Knowledge Article Suggestion Data Source** |
| **DisplayCollectionName** | **Knowledge Article Suggestion Data Sources** |
| **SchemaName** | `msdyn_knowledgearticlesuggestiondatasource` |
| **CollectionSchemaName** | `msdyn_knowledgearticlesuggestiondatasources` |
| **EntitySetName** | `msdyn_knowledgearticlesuggestiondatasources`|
| **LogicalName** | `msdyn_knowledgearticlesuggestiondatasource` |
| **LogicalCollectionName** | `msdyn_knowledgearticlesuggestiondatasources` |
| **PrimaryIdAttribute** | `msdyn_knowledgearticlesuggestiondatasourceid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_knowledgearticlesuggestiondatasourceId](#BKMK_msdyn_knowledgearticlesuggestiondatasourceId)
- [msdyn_name](#BKMK_msdyn_name)

### <a name="BKMK_msdyn_knowledgearticlesuggestiondatasourceId"></a> msdyn_knowledgearticlesuggestiondatasourceId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Knowledge Article Suggestion Data Source**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_knowledgearticlesuggestiondatasourceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description||
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|




### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

