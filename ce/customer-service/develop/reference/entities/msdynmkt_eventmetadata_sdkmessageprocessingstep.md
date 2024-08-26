---
title: "Triggers To Sdk Message Processing Steps (msdynmkt_eventmetadata_sdkmessageprocessingstep) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Triggers To Sdk Message Processing Steps (msdynmkt_eventmetadata_sdkmessageprocessingstep) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Triggers To Sdk Message Processing Steps (msdynmkt_eventmetadata_sdkmessageprocessingstep) table/entity reference

Mapping between CJO Marketing Triggers and Sdk Message Processing Steps

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Triggers To Sdk Message Processing Steps (msdynmkt_eventmetadata_sdkmessageprocessingstep) table extends the [Microsoft Dynamics 365 Triggers To Sdk Message Processing Steps (msdynmkt_eventmetadata_sdkmessageprocessingstep) table](/dynamics365/developer/entities/msdynmkt_eventmetadata_sdkmessageprocessingstep).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdynmkt_sdkmessageprocessingstep_eventmetadata_sd"></a> msdynmkt_sdkmessageprocessingstep_eventmetadata_sd

One-To-Many Relationship: [sdkmessageprocessingstep msdynmkt_sdkmessageprocessingstep_eventmetadata_sd](sdkmessageprocessingstep.md#BKMK_msdynmkt_sdkmessageprocessingstep_eventmetadata_sd)

|Property|Value|
|---|---|
|ReferencedEntity|`sdkmessageprocessingstep`|
|ReferencedAttribute|`sdkmessageprocessingstepid`|
|ReferencingAttribute|`msdynmkt_sdkmessageprocessingstepid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_sdkmessageprocessingstepId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

