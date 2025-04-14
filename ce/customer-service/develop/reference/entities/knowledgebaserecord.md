---
title: "Knowledge Base Record (KnowledgeBaseRecord) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Knowledge Base Record (KnowledgeBaseRecord) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Knowledge Base Record (KnowledgeBaseRecord) table/entity reference (Microsoft Dynamics 365 Customer Service)

Metadata of knowledge base (KB) articles associated with Microsoft Dynamics 365 entities.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Knowledge Base Record (KnowledgeBaseRecord) table extends the [Microsoft Dynamics 365 Knowledge Base Record (KnowledgeBaseRecord) table](/dynamics365/developer/reference/entities/knowledgebaserecord).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_knowledgebaserecord_msdyn_bookingalerts"></a> knowledgebaserecord_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert knowledgebaserecord_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_knowledgebaserecord_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.knowledgebaserecord?displayProperty=fullName>
