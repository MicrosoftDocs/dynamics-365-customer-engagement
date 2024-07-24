---
title: "Data Lake Folder (datalakefolder) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Data Lake Folder (datalakefolder) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Data Lake Folder (datalakefolder) table/entity reference

A folder is a place to store data in Azure Data Lake.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Data Lake Folder (datalakefolder) table extends the [Microsoft Dataverse Data Lake Folder (datalakefolder) table](/power-apps/developer/data-platform/reference/entities/datalakefolder).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdynmkt_segment_datalakefolder"></a> msdynmkt_segment_datalakefolder

Many-To-One Relationship: [msdynmkt_segment msdynmkt_segment_datalakefolder](msdynmkt_segment.md#BKMK_msdynmkt_segment_datalakefolder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segment`|
|ReferencingAttribute|`msdynmkt_datalakefolderid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segment_datalakefolder`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.datalakefolder?displayProperty=fullName>
