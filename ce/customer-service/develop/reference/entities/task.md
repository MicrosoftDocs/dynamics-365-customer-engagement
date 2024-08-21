---
title: "Task table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Task table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Task table/entity reference

Generic activity representing work needed to be done.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Task table extends the [Microsoft Dataverse Task table](/power-apps/developer/data-platform/reference/entities/task).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/task#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalertstatus|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookingalertstatus_Tasks](#BKMK_msdyn_bookingalertstatus_Tasks)
- [msdyn_bookingrule_Tasks](#BKMK_msdyn_bookingrule_Tasks)
- [msdyn_resourceterritory_Tasks](#BKMK_msdyn_resourceterritory_Tasks)
- [msdyn_systemuserschedulersetting_Tasks](#BKMK_msdyn_systemuserschedulersetting_Tasks)
- [msdyn_timegroup_Tasks](#BKMK_msdyn_timegroup_Tasks)
- [msdyn_timegroupdetail_Tasks](#BKMK_msdyn_timegroupdetail_Tasks)

### <a name="BKMK_msdyn_bookingalertstatus_Tasks"></a> msdyn_bookingalertstatus_Tasks

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_Tasks](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_Tasks"></a> msdyn_bookingrule_Tasks

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_Tasks](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_Tasks"></a> msdyn_resourceterritory_Tasks

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_Tasks](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_Tasks"></a> msdyn_systemuserschedulersetting_Tasks

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_Tasks](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_Tasks"></a> msdyn_timegroup_Tasks

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_Tasks](msdyn_timegroup.md#BKMK_msdyn_timegroup_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_Tasks"></a> msdyn_timegroupdetail_Tasks

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_Tasks](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Tasks)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.task?displayProperty=fullName>
