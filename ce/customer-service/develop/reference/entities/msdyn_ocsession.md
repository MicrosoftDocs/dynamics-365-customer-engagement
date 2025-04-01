---
title: "Session (msdyn_ocsession) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Session (msdyn_ocsession) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Session (msdyn_ocsession) table/entity reference (Microsoft Dynamics 365 Customer Service)

Session for interacting with a customer

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Session (msdyn_ocsession) table extends the [Microsoft Dynamics 365 Session (msdyn_ocsession) table](/dynamics365/developer/reference/entities/msdyn_ocsession).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_ocsession#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_resourceterritory, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookingalertstatus_msdyn_ocsessions](#BKMK_msdyn_bookingalertstatus_msdyn_ocsessions)
- [msdyn_bookingrule_msdyn_ocsessions](#BKMK_msdyn_bookingrule_msdyn_ocsessions)
- [msdyn_resourceterritory_msdyn_ocsessions](#BKMK_msdyn_resourceterritory_msdyn_ocsessions)
- [msdyn_systemuserschedulersetting_msdyn_ocsessions](#BKMK_msdyn_systemuserschedulersetting_msdyn_ocsessions)
- [msdyn_timegroup_msdyn_ocsessions](#BKMK_msdyn_timegroup_msdyn_ocsessions)
- [msdyn_timegroupdetail_msdyn_ocsessions](#BKMK_msdyn_timegroupdetail_msdyn_ocsessions)

### <a name="BKMK_msdyn_bookingalertstatus_msdyn_ocsessions"></a> msdyn_bookingalertstatus_msdyn_ocsessions

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_msdyn_ocsessions](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_msdyn_ocsessions"></a> msdyn_bookingrule_msdyn_ocsessions

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_msdyn_ocsessions](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_msdyn_ocsessions"></a> msdyn_resourceterritory_msdyn_ocsessions

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_msdyn_ocsessions](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_msdyn_ocsessions"></a> msdyn_systemuserschedulersetting_msdyn_ocsessions

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_msdyn_ocsessions](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_msdyn_ocsessions"></a> msdyn_timegroup_msdyn_ocsessions

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_msdyn_ocsessions](msdyn_timegroup.md#BKMK_msdyn_timegroup_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_msdyn_ocsessions"></a> msdyn_timegroupdetail_msdyn_ocsessions

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_msdyn_ocsessions](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

