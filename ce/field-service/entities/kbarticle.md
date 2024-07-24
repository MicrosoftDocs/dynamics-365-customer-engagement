---
title: "Article (KbArticle) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Article (KbArticle) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Article (KbArticle) table/entity reference

Structured content that is part of the knowledge base.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Article (KbArticle) table extends the [Microsoft Dataverse Article (KbArticle) table](/power-apps/developer/data-platform/reference/entities/kbarticle).




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

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.kbarticle?displayProperty=fullName>
