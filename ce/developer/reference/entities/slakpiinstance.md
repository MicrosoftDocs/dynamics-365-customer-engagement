---
title: "SLA KPI Instance (SLAKPIInstance) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the SLA KPI Instance (SLAKPIInstance) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# SLA KPI Instance (SLAKPIInstance) table/entity reference (Microsoft Dynamics 365)

Service level agreement (SLA) key performance indicator (KPI) instance that is tracked for an individual case

> [!NOTE]
> The Microsoft Dynamics 365 SLA KPI Instance (SLAKPIInstance) table extends the [Microsoft Dataverse SLA KPI Instance (SLAKPIInstance) table](/power-apps/developer/data-platform/reference/entities/slakpiinstance).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_Regarding"></a> Regarding

Changes from [Regarding (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/slakpiinstance#BKMK_Regarding)

|Property|Value|
|---|---|
|Targets|incident|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [slakpiinstance_incident](#BKMK_slakpiinstance_incident)
- [slakpiinstance_invoice](#BKMK_slakpiinstance_invoice)
- [slakpiinstance_lead](#BKMK_slakpiinstance_lead)
- [slakpiinstance_opportunity](#BKMK_slakpiinstance_opportunity)
- [slakpiinstance_quote](#BKMK_slakpiinstance_quote)
- [slakpiinstance_salesorder](#BKMK_slakpiinstance_salesorder)
- [slakpiinstance_serviceappointment](#BKMK_slakpiinstance_serviceappointment)

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

- [slakpiinstance_incident_firstresponsebykpi](#BKMK_slakpiinstance_incident_firstresponsebykpi)
- [slakpiinstance_incident_resolvebykpi](#BKMK_slakpiinstance_incident_resolvebykpi)

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

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.slakpiinstance?displayProperty=fullName>
