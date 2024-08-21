---
title: "Insights (msdyn_datainsightsandanalyticsfeature) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Insights (msdyn_datainsightsandanalyticsfeature) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Insights (msdyn_datainsightsandanalyticsfeature) table/entity reference

Analytics and insights feature entity

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Insights (msdyn_datainsightsandanalyticsfeature) table extends the [Microsoft Dynamics 365 Insights (msdyn_datainsightsandanalyticsfeature) table](/dynamics365/developer/entities//msdyn_datainsightsandanalyticsfeature).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_dasfeature_dasfs_datainsightsandanalyticsfeatureid](#BKMK_msdyn_dasfeature_dasfs_datainsightsandanalyticsfeatureid)
- [msdyn_dasfeature_dasfspredictrs_datainsightsandanalyticsfeatureid](#BKMK_msdyn_dasfeature_dasfspredictrs_datainsightsandanalyticsfeatureid)
- [msdyn_dasfeature_dasfspredictwhd_datainsightsandanalyticsfeatureid](#BKMK_msdyn_dasfeature_dasfspredictwhd_datainsightsandanalyticsfeatureid)

### <a name="BKMK_msdyn_dasfeature_dasfs_datainsightsandanalyticsfeatureid"></a> msdyn_dasfeature_dasfs_datainsightsandanalyticsfeatureid

Many-To-One Relationship: [msdyn_dataanalyticsreport_fs msdyn_dasfeature_dasfs_datainsightsandanalyticsfeatureid](msdyn_dataanalyticsreport_fs.md#BKMK_msdyn_dasfeature_dasfs_datainsightsandanalyticsfeatureid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_fs`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dasfs_datainsightsandanalyticsfeatureid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dasfeature_dasfspredictrs_datainsightsandanalyticsfeatureid"></a> msdyn_dasfeature_dasfspredictrs_datainsightsandanalyticsfeatureid

Many-To-One Relationship: [msdyn_dataanalyticsreport_fspredictrs msdyn_dasfeature_dasfspredictrs_datainsightsandanalyticsfeatureid](msdyn_dataanalyticsreport_fspredictrs.md#BKMK_msdyn_dasfeature_dasfspredictrs_datainsightsandanalyticsfeatureid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_fspredictrs`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dasfspredictrs_datainsightsandanalyticsfeatureid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dasfeature_dasfspredictwhd_datainsightsandanalyticsfeatureid"></a> msdyn_dasfeature_dasfspredictwhd_datainsightsandanalyticsfeatureid

Many-To-One Relationship: [msdyn_dataanalyticsreport_fspredictwhd msdyn_dasfeature_dasfspredictwhd_datainsightsandanalyticsfeatureid](msdyn_dataanalyticsreport_fspredictwhd.md#BKMK_msdyn_dasfeature_dasfspredictwhd_datainsightsandanalyticsfeatureid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_fspredictwhd`|
|ReferencingAttribute|`msdyn_datainsightsandanalyticsfeatureid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dasfeature_dasfspredictwhd_datainsightsandanalyticsfeatureid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

