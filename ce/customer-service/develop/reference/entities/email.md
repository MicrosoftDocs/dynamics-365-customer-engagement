---
title: "Email table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Email table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Email table/entity reference (Microsoft Dynamics 365 Customer Service)

Activity that is delivered using email protocols.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Email table extends the [Microsoft Dynamics 365 Email table](/dynamics365/developer/reference/entities/email).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_resourceterritory, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookingalertstatus_Emails](#BKMK_msdyn_bookingalertstatus_Emails)
- [msdyn_bookingrule_Emails](#BKMK_msdyn_bookingrule_Emails)
- [msdyn_resourceterritory_Emails](#BKMK_msdyn_resourceterritory_Emails)
- [msdyn_systemuserschedulersetting_Emails](#BKMK_msdyn_systemuserschedulersetting_Emails)
- [msdyn_timegroup_Emails](#BKMK_msdyn_timegroup_Emails)
- [msdyn_timegroupdetail_Emails](#BKMK_msdyn_timegroupdetail_Emails)

### <a name="BKMK_msdyn_bookingalertstatus_Emails"></a> msdyn_bookingalertstatus_Emails

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_Emails](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_Emails"></a> msdyn_bookingrule_Emails

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_Emails](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_Emails"></a> msdyn_resourceterritory_Emails

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_Emails](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_Emails"></a> msdyn_systemuserschedulersetting_Emails

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_Emails](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_Emails"></a> msdyn_timegroup_Emails

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_Emails](msdyn_timegroup.md#BKMK_msdyn_timegroup_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_Emails"></a> msdyn_timegroupdetail_Emails

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_Emails](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.email?displayProperty=fullName>
