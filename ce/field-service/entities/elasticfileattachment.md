---
title: "ElasticFileAttachment table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the ElasticFileAttachment table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# ElasticFileAttachment table/entity reference

Elastic File Attachment

> [!NOTE]
> The Microsoft Dynamics 365 Field Service ElasticFileAttachment table extends the [Microsoft Dataverse ElasticFileAttachment table](/power-apps/developer/data-platform/reference/entities/elasticfileattachment).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/elasticfileattachment#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_diagnosticsdata|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_diagnosticsdata_ElasticFileAttachments"></a> msdyn_diagnosticsdata_ElasticFileAttachments

One-To-Many Relationship: [msdyn_diagnosticsdata msdyn_diagnosticsdata_ElasticFileAttachments](msdyn_diagnosticsdata.md#BKMK_msdyn_diagnosticsdata_ElasticFileAttachments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_diagnosticsdata`|
|ReferencedAttribute|`msdyn_diagnosticsdataid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_diagnosticsdata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_ElasticFileAttachment_msdyn_diagnosticsdata_msdyn_data_binary"></a> ElasticFileAttachment_msdyn_diagnosticsdata_msdyn_data_binary

Many-To-One Relationship: [msdyn_diagnosticsdata ElasticFileAttachment_msdyn_diagnosticsdata_msdyn_data_binary](msdyn_diagnosticsdata.md#BKMK_ElasticFileAttachment_msdyn_diagnosticsdata_msdyn_data_binary)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_diagnosticsdata`|
|ReferencingAttribute|`msdyn_data_binary`|
|ReferencedEntityNavigationPropertyName|`ElasticFileAttachment_msdyn_diagnosticsdata_msdyn_data_binary`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.elasticfileattachment?displayProperty=fullName>
