---
title: "Fax table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Fax table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Fax table/entity reference (Microsoft Dynamics 365 Customer Service)

Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Fax table extends the [Microsoft Dynamics 365 Fax table](/dynamics365/developer/reference/entities/fax).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/fax#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_resourceterritory, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookingalertstatus_Faxes](#BKMK_msdyn_bookingalertstatus_Faxes)
- [msdyn_bookingrule_Faxes](#BKMK_msdyn_bookingrule_Faxes)
- [msdyn_resourceterritory_Faxes](#BKMK_msdyn_resourceterritory_Faxes)
- [msdyn_systemuserschedulersetting_Faxes](#BKMK_msdyn_systemuserschedulersetting_Faxes)
- [msdyn_timegroup_Faxes](#BKMK_msdyn_timegroup_Faxes)
- [msdyn_timegroupdetail_Faxes](#BKMK_msdyn_timegroupdetail_Faxes)

### <a name="BKMK_msdyn_bookingalertstatus_Faxes"></a> msdyn_bookingalertstatus_Faxes

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_Faxes](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_Faxes"></a> msdyn_bookingrule_Faxes

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_Faxes](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_Faxes"></a> msdyn_resourceterritory_Faxes

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_Faxes](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_Faxes"></a> msdyn_systemuserschedulersetting_Faxes

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_Faxes](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_Faxes"></a> msdyn_timegroup_Faxes

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_Faxes](msdyn_timegroup.md#BKMK_msdyn_timegroup_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_Faxes"></a> msdyn_timegroupdetail_Faxes

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_Faxes](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Faxes)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_fax`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.fax?displayProperty=fullName>
