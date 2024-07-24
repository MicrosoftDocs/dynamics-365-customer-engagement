---
title: "Goal table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Goal table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Goal table/entity reference

Target objective for a user or a team for a specified time period.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Goal table extends the [Microsoft Dataverse Goal table](/power-apps/developer/data-platform/reference/entities/goal).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_goal_msdyn_forecastinstance"></a> msdyn_goal_msdyn_forecastinstance

Many-To-One Relationship: [msdyn_forecastinstance msdyn_goal_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_msdyn_goal_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastinstance`|
|ReferencingAttribute|`msdyn_matchinggoalid`|
|ReferencedEntityNavigationPropertyName|`msdyn_goal_msdyn_forecastinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.goal?displayProperty=fullName>
