---
title: "Post Regarding (PostRegarding) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Post Regarding (PostRegarding) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Post Regarding (PostRegarding) table/entity reference (Microsoft Dynamics 365)

Represents which object an activity feed post is regarding. For internal use only.

> [!NOTE]
> The Microsoft Dynamics 365 Post Regarding (PostRegarding) table extends the [Microsoft Dataverse Post Regarding (PostRegarding) table](/power-apps/developer/data-platform/reference/entities/postregarding).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/postregarding#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|competitor, incident, lead, msdyn_salessuggestion, msdyn_swarm, opportunity|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [competitor_PostRegardings](#BKMK_competitor_PostRegardings)
- [incident_PostRegardings](#BKMK_incident_PostRegardings)
- [lead_PostRegardings](#BKMK_lead_PostRegardings)
- [msdyn_salessuggestion_PostRegardings](#BKMK_msdyn_salessuggestion_PostRegardings)
- [msdyn_swarm_PostRegardings](#BKMK_msdyn_swarm_PostRegardings)
- [opportunity_PostRegardings](#BKMK_opportunity_PostRegardings)

### <a name="BKMK_competitor_PostRegardings"></a> competitor_PostRegardings

One-To-Many Relationship: [competitor competitor_PostRegardings](competitor.md#BKMK_competitor_PostRegardings)

|Property|Value|
|---|---|
|ReferencedEntity|`competitor`|
|ReferencedAttribute|`competitorid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_competitor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_PostRegardings"></a> incident_PostRegardings

One-To-Many Relationship: [incident incident_PostRegardings](incident.md#BKMK_incident_PostRegardings)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_PostRegardings"></a> lead_PostRegardings

One-To-Many Relationship: [lead lead_PostRegardings](lead.md#BKMK_lead_PostRegardings)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salessuggestion_PostRegardings"></a> msdyn_salessuggestion_PostRegardings

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_PostRegardings](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_PostRegardings)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_swarm_PostRegardings"></a> msdyn_swarm_PostRegardings

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_PostRegardings](msdyn_swarm.md#BKMK_msdyn_swarm_PostRegardings)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_PostRegardings"></a> opportunity_PostRegardings

One-To-Many Relationship: [opportunity opportunity_PostRegardings](opportunity.md#BKMK_opportunity_PostRegardings)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.postregarding?displayProperty=fullName>
