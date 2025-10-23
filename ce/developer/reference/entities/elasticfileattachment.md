---
title: "ElasticFileAttachment table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the ElasticFileAttachment table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# ElasticFileAttachment table/entity reference (Microsoft Dynamics 365)

Elastic File Attachment

> [!NOTE]
> The Microsoft Dynamics 365 ElasticFileAttachment table extends the [Microsoft Dataverse ElasticFileAttachment table](/power-apps/developer/data-platform/reference/entities/elasticfileattachment).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/elasticfileattachment#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_copilotevent|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_copilotevent_ElasticFileAttachments"></a> msdyn_copilotevent_ElasticFileAttachments

One-To-Many Relationship: [msdyn_copilotevent msdyn_copilotevent_ElasticFileAttachments](msdyn_copilotevent.md#BKMK_msdyn_copilotevent_ElasticFileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilotevent`|
|ReferencedAttribute|`msdyn_copiloteventid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_copilotevent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_ElasticFileAttachment_msdyn_copilotevent_msdyn_interactiondata"></a> ElasticFileAttachment_msdyn_copilotevent_msdyn_interactiondata

Many-To-One Relationship: [msdyn_copilotevent ElasticFileAttachment_msdyn_copilotevent_msdyn_interactiondata](msdyn_copilotevent.md#BKMK_ElasticFileAttachment_msdyn_copilotevent_msdyn_interactiondata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotevent`|
|ReferencingAttribute|`msdyn_interactiondata`|
|ReferencedEntityNavigationPropertyName|`ElasticFileAttachment_msdyn_copilotevent_msdyn_interactiondata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.elasticfileattachment?displayProperty=fullName>
