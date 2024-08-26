---
title: "Copilot Transcript (msdyn_copilottranscript) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Copilot Transcript (msdyn_copilottranscript) table/entity with Microsoft Dynamics 365 Customer Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Copilot Transcript (msdyn_copilottranscript) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Copilot Transcript (msdyn_copilottranscript) table extends the [Microsoft Dynamics 365 Copilot Transcript (msdyn_copilottranscript) table](/dynamics365/developer/entities/msdyn_copilottranscript).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/entities/msdyn_copilottranscript#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalertstatus|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookingalertstatus_msdyn_copilottranscripts](#BKMK_msdyn_bookingalertstatus_msdyn_copilottranscripts)
- [msdyn_bookingrule_msdyn_copilottranscripts](#BKMK_msdyn_bookingrule_msdyn_copilottranscripts)
- [msdyn_copilottranscript_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_copilottranscript_transactioncurrency_transactioncurrencyid)
- [msdyn_resourceterritory_msdyn_copilottranscripts](#BKMK_msdyn_resourceterritory_msdyn_copilottranscripts)
- [msdyn_systemuserschedulersetting_msdyn_copilottranscripts](#BKMK_msdyn_systemuserschedulersetting_msdyn_copilottranscripts)
- [msdyn_timegroup_msdyn_copilottranscripts](#BKMK_msdyn_timegroup_msdyn_copilottranscripts)
- [msdyn_timegroupdetail_msdyn_copilottranscripts](#BKMK_msdyn_timegroupdetail_msdyn_copilottranscripts)

### <a name="BKMK_msdyn_bookingalertstatus_msdyn_copilottranscripts"></a> msdyn_bookingalertstatus_msdyn_copilottranscripts

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_msdyn_copilottranscripts](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_msdyn_copilottranscripts"></a> msdyn_bookingrule_msdyn_copilottranscripts

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_msdyn_copilottranscripts](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_copilottranscript_transactioncurrency_transactioncurrencyid"></a> msdyn_copilottranscript_transactioncurrency_transactioncurrencyid

One-To-Many Relationship: [transactioncurrency msdyn_copilottranscript_transactioncurrency_transactioncurrencyid](transactioncurrency.md#BKMK_msdyn_copilottranscript_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_msdyn_copilottranscripts"></a> msdyn_resourceterritory_msdyn_copilottranscripts

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_msdyn_copilottranscripts](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_msdyn_copilottranscripts"></a> msdyn_systemuserschedulersetting_msdyn_copilottranscripts

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_msdyn_copilottranscripts](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_msdyn_copilottranscripts"></a> msdyn_timegroup_msdyn_copilottranscripts

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_msdyn_copilottranscripts](msdyn_timegroup.md#BKMK_msdyn_timegroup_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_msdyn_copilottranscripts"></a> msdyn_timegroupdetail_msdyn_copilottranscripts

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_msdyn_copilottranscripts](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

