---
title: "SLA KPI Instance (SLAKPIInstance) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the SLA KPI Instance (SLAKPIInstance) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# SLA KPI Instance (SLAKPIInstance) table/entity reference (Microsoft Dynamics 365 Field Service)

Service level agreement (SLA) key performance indicator (KPI) instance that is tracked for an individual case

> [!NOTE]
> The Microsoft Dynamics 365 Field Service SLA KPI Instance (SLAKPIInstance) table extends the [Microsoft Dynamics 365 SLA KPI Instance (SLAKPIInstance) table](/dynamics365/developer/reference/entities/slakpiinstance).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi](#BKMK_msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi)
- [msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid](#BKMK_msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid)

### <a name="BKMK_msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi"></a> msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi

Many-To-One Relationship: [msdyn_workorder msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi](msdyn_workorder.md#BKMK_msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_workorderarrivaltimekpiid`|
|ReferencedEntityNavigationPropertyName|`msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid"></a> msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid

Many-To-One Relationship: [msdyn_workorder msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid](msdyn_workorder.md#BKMK_msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_workorderresolutionkpiid`|
|ReferencedEntityNavigationPropertyName|`msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.slakpiinstance?displayProperty=fullName>
