---
title: "Goal Metric (Metric) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Goal Metric (Metric) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Goal Metric (Metric) table/entity reference

Type of measurement for a goal, such as money amount or count.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Goal Metric (Metric) table extends the [Microsoft Dataverse Goal Metric (Metric) table](/power-apps/developer/data-platform/reference/entities/metric).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_metric_msdyn_forecastdefinition_metricid"></a> msdyn_metric_msdyn_forecastdefinition_metricid

Many-To-One Relationship: [msdyn_forecastdefinition msdyn_metric_msdyn_forecastdefinition_metricid](msdyn_forecastdefinition.md#BKMK_msdyn_metric_msdyn_forecastdefinition_metricid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastdefinition`|
|ReferencingAttribute|`msdyn_metricid`|
|ReferencedEntityNavigationPropertyName|`msdyn_metric_msdyn_forecastdefinition_metricid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.metric?displayProperty=fullName>
