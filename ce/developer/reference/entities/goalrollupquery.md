---
title: "Rollup Query (GoalRollupQuery) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Rollup Query (GoalRollupQuery) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Rollup Query (GoalRollupQuery) table/entity reference (Microsoft Dynamics 365)

Query that is used to filter the results of the goal rollup.

> [!NOTE]
> The Microsoft Dynamics 365 Rollup Query (GoalRollupQuery) table extends the [Microsoft Dataverse Rollup Query (GoalRollupQuery) table](/power-apps/developer/data-platform/reference/entities/goalrollupquery).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery"></a> msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery

Many-To-One Relationship: [msdyn_forecastdefinition msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery](msdyn_forecastdefinition.md#BKMK_msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastdefinition`|
|ReferencingAttribute|`msdyn_rollupquery`|
|ReferencedEntityNavigationPropertyName|`msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.goalrollupquery?displayProperty=fullName>
