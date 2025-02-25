---
title: "Follow (PostFollow) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Follow (PostFollow) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Follow (PostFollow) table/entity reference (Microsoft Dynamics 365)

Represents a user following the activity feed of an object.

> [!NOTE]
> The Microsoft Dynamics 365 Follow (PostFollow) table extends the [Microsoft Dataverse Follow (PostFollow) table](/power-apps/developer/data-platform/reference/entities/postfollow).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/postfollow#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|competitor, incident, lead, msdyn_salessuggestion, msdyn_swarm, opportunity|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [competitor_PostFollows](#BKMK_competitor_PostFollows)
- [incident_PostFollows](#BKMK_incident_PostFollows)
- [lead_PostFollows](#BKMK_lead_PostFollows)
- [msdyn_salessuggestion_PostFollows](#BKMK_msdyn_salessuggestion_PostFollows)
- [msdyn_swarm_PostFollows](#BKMK_msdyn_swarm_PostFollows)
- [opportunity_PostFollows](#BKMK_opportunity_PostFollows)

### <a name="BKMK_competitor_PostFollows"></a> competitor_PostFollows

One-To-Many Relationship: [competitor competitor_PostFollows](competitor.md#BKMK_competitor_PostFollows)

|Property|Value|
|---|---|
|ReferencedEntity|`competitor`|
|ReferencedAttribute|`competitorid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_competitor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_PostFollows"></a> incident_PostFollows

One-To-Many Relationship: [incident incident_PostFollows](incident.md#BKMK_incident_PostFollows)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_PostFollows"></a> lead_PostFollows

One-To-Many Relationship: [lead lead_PostFollows](lead.md#BKMK_lead_PostFollows)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salessuggestion_PostFollows"></a> msdyn_salessuggestion_PostFollows

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_PostFollows](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_PostFollows)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_swarm_PostFollows"></a> msdyn_swarm_PostFollows

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_PostFollows](msdyn_swarm.md#BKMK_msdyn_swarm_PostFollows)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_PostFollows"></a> opportunity_PostFollows

One-To-Many Relationship: [opportunity opportunity_PostFollows](opportunity.md#BKMK_opportunity_PostFollows)

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
<xref:Microsoft.Dynamics.CRM.postfollow?displayProperty=fullName>
