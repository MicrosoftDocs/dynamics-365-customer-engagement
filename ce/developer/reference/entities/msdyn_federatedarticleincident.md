---
title: "Knowledge Federated Article Incident (msdyn_federatedarticleincident) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Knowledge Federated Article Incident (msdyn_federatedarticleincident) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Knowledge Federated Article Incident (msdyn_federatedarticleincident) table/entity reference (Microsoft Dynamics 365)



> [!NOTE]
> The Microsoft Dynamics 365 Knowledge Federated Article Incident (msdyn_federatedarticleincident) table extends the [Microsoft Dataverse Knowledge Federated Article Incident (msdyn_federatedarticleincident) table](/power-apps/developer/data-platform/reference/entities/msdyn_federatedarticleincident).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_msdyn_incidentid"></a> msdyn_incidentid

Changes from [msdyn_incidentid (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/msdyn_federatedarticleincident#BKMK_msdyn_incidentid)

|Property|Value|
|---|---|
|Targets|incident|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_incident_msdyn_federatedarticleincident_IncidentId"></a> msdyn_incident_msdyn_federatedarticleincident_IncidentId

One-To-Many Relationship: [incident msdyn_incident_msdyn_federatedarticleincident_IncidentId](incident.md#BKMK_msdyn_incident_msdyn_federatedarticleincident_IncidentId)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_incidentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_incidentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.msdyn_federatedarticleincident?displayProperty=fullName>
