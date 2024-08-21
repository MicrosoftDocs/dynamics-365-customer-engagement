---
title: "Knowledge Article (KnowledgeArticle) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Knowledge Article (KnowledgeArticle) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Knowledge Article (KnowledgeArticle) table/entity reference

Organizational knowledge for internal and external use.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Knowledge Article (KnowledgeArticle) table extends the [Microsoft Dataverse Knowledge Article (KnowledgeArticle) table](/power-apps/developer/data-platform/reference/entities/knowledgearticle).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_knowledgearticle_msdyn_bookingalerts"></a> knowledgearticle_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert knowledgearticle_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_knowledgearticle_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgearticle_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.knowledgearticle?displayProperty=fullName>
