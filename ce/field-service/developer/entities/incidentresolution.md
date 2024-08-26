---
title: "Case Resolution (IncidentResolution) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Case Resolution (IncidentResolution) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Case Resolution (IncidentResolution) table/entity reference

Special type of activity that includes description of the resolution, billing status, and the duration of the case.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Case Resolution (IncidentResolution) table extends the [Microsoft Dynamics 365 Case Resolution (IncidentResolution) table](/dynamics365/developer/entities/incidentresolution).




## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_incidentresolution_transactioncurrency_transactioncurrencyid"></a> incidentresolution_transactioncurrency_transactioncurrencyid

One-To-Many Relationship: [transactioncurrency incidentresolution_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_incidentresolution_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_incidentresolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

