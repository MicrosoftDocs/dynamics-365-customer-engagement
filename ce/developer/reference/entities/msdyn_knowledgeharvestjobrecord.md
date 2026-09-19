---
title: "Knowledge Harvest Job Record (msdyn_knowledgeharvestjobrecord) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Knowledge Harvest Job Record (msdyn_knowledgeharvestjobrecord) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Knowledge Harvest Job Record (msdyn_knowledgeharvestjobrecord) table/entity reference (Microsoft Dynamics 365)

Tracking entity record used to trigger the harvesting process for knowledge articles

> [!NOTE]
> The Microsoft Dynamics 365 Knowledge Harvest Job Record (msdyn_knowledgeharvestjobrecord) table extends the [Microsoft Dataverse Knowledge Harvest Job Record (msdyn_knowledgeharvestjobrecord) table](/power-apps/developer/data-platform/reference/entities/msdyn_knowledgeharvestjobrecord).


## Messages

The following table lists the messages for the Knowledge Harvest Job Record (msdyn_knowledgeharvestjobrecord) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_retrycount"></a> msdyn_retrycount

|Property|Value|
|---|---|
|Description|**Number of global retry attempts for this harvest job record.**|
|DisplayName|**Retry Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_retrycount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|




### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.msdyn_knowledgeharvestjobrecord?displayProperty=fullName>
