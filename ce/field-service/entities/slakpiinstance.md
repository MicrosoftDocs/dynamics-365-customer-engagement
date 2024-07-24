---
title: "SLA KPI Instance (SLAKPIInstance) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the SLA KPI Instance (SLAKPIInstance) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# SLA KPI Instance (SLAKPIInstance) table/entity reference

Service level agreement (SLA) key performance indicator (KPI) instance that is tracked for an individual case

> [!NOTE]
> The Microsoft Dynamics 365 Field Service SLA KPI Instance (SLAKPIInstance) table extends the [Microsoft Dataverse SLA KPI Instance (SLAKPIInstance) table](/power-apps/developer/data-platform/reference/entities/slakpiinstance).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_Regarding"></a> Regarding

Changes from [Regarding (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/slakpiinstance#BKMK_Regarding)

|Property|Value|
|---|---|
|Targets|incident|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_workorder_SLAKPIInstances](#BKMK_msdyn_workorder_SLAKPIInstances)
- [slakpiinstance_incident](#BKMK_slakpiinstance_incident)
- [slakpiinstance_invoice](#BKMK_slakpiinstance_invoice)
- [slakpiinstance_lead](#BKMK_slakpiinstance_lead)
- [slakpiinstance_opportunity](#BKMK_slakpiinstance_opportunity)
- [slakpiinstance_quote](#BKMK_slakpiinstance_quote)
- [slakpiinstance_salesorder](#BKMK_slakpiinstance_salesorder)
- [slakpiinstance_serviceappointment](#BKMK_slakpiinstance_serviceappointment)

### <a name="BKMK_msdyn_workorder_SLAKPIInstances"></a> msdyn_workorder_SLAKPIInstances

One-To-Many Relationship: [msdyn_workorder msdyn_workorder_SLAKPIInstances](msdyn_workorder.md#BKMK_msdyn_workorder_SLAKPIInstances)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_slakpiinstance_incident"></a> slakpiinstance_incident

One-To-Many Relationship: [incident slakpiinstance_incident](incident.md#BKMK_slakpiinstance_incident)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_slakpiinstance_invoice"></a> slakpiinstance_invoice

One-To-Many Relationship: [invoice slakpiinstance_invoice](invoice.md#BKMK_slakpiinstance_invoice)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_invoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_slakpiinstance_lead"></a> slakpiinstance_lead

One-To-Many Relationship: [lead slakpiinstance_lead](lead.md#BKMK_slakpiinstance_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_slakpiinstance_opportunity"></a> slakpiinstance_opportunity

One-To-Many Relationship: [opportunity slakpiinstance_opportunity](opportunity.md#BKMK_slakpiinstance_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_slakpiinstance_quote"></a> slakpiinstance_quote

One-To-Many Relationship: [quote slakpiinstance_quote](quote.md#BKMK_slakpiinstance_quote)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_slakpiinstance_salesorder"></a> slakpiinstance_salesorder

One-To-Many Relationship: [salesorder slakpiinstance_salesorder](salesorder.md#BKMK_slakpiinstance_salesorder)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_salesorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_slakpiinstance_serviceappointment"></a> slakpiinstance_serviceappointment

One-To-Many Relationship: [serviceappointment slakpiinstance_serviceappointment](serviceappointment.md#BKMK_slakpiinstance_serviceappointment)

|Property|Value|
|---|---|
|ReferencedEntity|`serviceappointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regarding`|
|ReferencingEntityNavigationPropertyName|`regarding_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi](#BKMK_msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi)
- [msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid](#BKMK_msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid)
- [slakpiinstance_incident_firstresponsebykpi](#BKMK_slakpiinstance_incident_firstresponsebykpi)
- [slakpiinstance_incident_resolvebykpi](#BKMK_slakpiinstance_incident_resolvebykpi)

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

### <a name="BKMK_slakpiinstance_incident_firstresponsebykpi"></a> slakpiinstance_incident_firstresponsebykpi

Many-To-One Relationship: [incident slakpiinstance_incident_firstresponsebykpi](incident.md#BKMK_slakpiinstance_incident_firstresponsebykpi)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`firstresponsebykpiid`|
|ReferencedEntityNavigationPropertyName|`slakpiinstance_incident_firstresponsebykpi`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_slakpiinstance_incident_resolvebykpi"></a> slakpiinstance_incident_resolvebykpi

Many-To-One Relationship: [incident slakpiinstance_incident_resolvebykpi](incident.md#BKMK_slakpiinstance_incident_resolvebykpi)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`resolvebykpiid`|
|ReferencedEntityNavigationPropertyName|`slakpiinstance_incident_resolvebykpi`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.slakpiinstance?displayProperty=fullName>
