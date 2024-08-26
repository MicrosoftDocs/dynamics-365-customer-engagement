---
title: "Knowledge Base Record (KnowledgeBaseRecord) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Knowledge Base Record (KnowledgeBaseRecord) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Knowledge Base Record (KnowledgeBaseRecord) table/entity reference (Microsoft Dynamics 365 Field Service)

Metadata of knowledge base (KB) articles associated with Microsoft Dynamics 365 entities.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Knowledge Base Record (KnowledgeBaseRecord) table extends the [Microsoft Dynamics 365 Knowledge Base Record (KnowledgeBaseRecord) table](/dynamics365/developer/entities/knowledgebaserecord).




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


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyn_incidenttype_knowledgebaserecord](#BKMK_msdyn_incidenttype_knowledgebaserecord)
- [msdyn_workorder_knowledgebaserecord](#BKMK_msdyn_workorder_knowledgebaserecord)

### <a name="BKMK_msdyn_incidenttype_knowledgebaserecord"></a> msdyn_incidenttype_knowledgebaserecord

See [msdyn_incidenttype msdyn_incidenttype_knowledgebaserecord Many-To-Many Relationship](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_knowledgebaserecord)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_incidenttype_knowledgebaserec`|
|IsCustomizable|True|
|SchemaName|`msdyn_incidenttype_knowledgebaserecord`|
|IntersectAttribute|`knowledgebaserecordid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorder_knowledgebaserecord"></a> msdyn_workorder_knowledgebaserecord

See [msdyn_workorder msdyn_workorder_knowledgebaserecord Many-To-Many Relationship](msdyn_workorder.md#BKMK_msdyn_workorder_knowledgebaserecord)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_workorder_knowledgebaserecord`|
|IsCustomizable|True|
|SchemaName|`msdyn_workorder_knowledgebaserecord`|
|IntersectAttribute|`knowledgebaserecordid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.knowledgebaserecord?displayProperty=fullName>
