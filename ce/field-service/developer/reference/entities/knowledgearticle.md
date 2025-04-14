---
title: "Knowledge Article (KnowledgeArticle) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Knowledge Article (KnowledgeArticle) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Knowledge Article (KnowledgeArticle) table/entity reference (Microsoft Dynamics 365 Field Service)

Organizational knowledge for internal and external use.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Knowledge Article (KnowledgeArticle) table extends the [Microsoft Dynamics 365 Knowledge Article (KnowledgeArticle) table](/dynamics365/developer/reference/entities/knowledgearticle).




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


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_incidenttype_knowledgearticle](#BKMK_msdyn_msdyn_incidenttype_knowledgearticle)
- [msdyn_msdyn_workorder_knowledgearticle](#BKMK_msdyn_msdyn_workorder_knowledgearticle)

### <a name="BKMK_msdyn_msdyn_incidenttype_knowledgearticle"></a> msdyn_msdyn_incidenttype_knowledgearticle

See [msdyn_incidenttype msdyn_msdyn_incidenttype_knowledgearticle Many-To-Many Relationship](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_knowledgearticle)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_incidenttype_knowledgearticle`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_incidenttype_knowledgearticle`|
|IntersectAttribute|`knowledgearticleid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_knowledgearticle"></a> msdyn_msdyn_workorder_knowledgearticle

See [msdyn_workorder msdyn_msdyn_workorder_knowledgearticle Many-To-Many Relationship](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_knowledgearticle)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_workorder_knowledgearticle`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_workorder_knowledgearticle`|
|IntersectAttribute|`knowledgearticleid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.knowledgearticle?displayProperty=fullName>
