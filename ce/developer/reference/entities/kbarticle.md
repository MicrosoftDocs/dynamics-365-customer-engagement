---
title: "Article (KbArticle) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Article (KbArticle) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Article (KbArticle) table/entity reference (Microsoft Dynamics 365)

Structured content that is part of the knowledge base.

> [!NOTE]
> The Microsoft Dynamics 365 Article (KbArticle) table extends the [Microsoft Dataverse Article (KbArticle) table](/power-apps/developer/data-platform/reference/entities/kbarticle).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_kbarticle_incidents"></a> kbarticle_incidents

Many-To-One Relationship: [incident kbarticle_incidents](incident.md#BKMK_kbarticle_incidents)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`kbarticleid`|
|ReferencedEntityNavigationPropertyName|`kbarticle_incidents`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.kbarticle?displayProperty=fullName>
