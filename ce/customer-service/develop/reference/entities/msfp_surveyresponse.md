---
title: "Customer Voice survey response (msfp_surveyresponse) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Customer Voice survey response (msfp_surveyresponse) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Customer Voice survey response (msfp_surveyresponse) table/entity reference (Microsoft Dynamics 365 Customer Service)

Response to a survey.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Customer Voice survey response (msfp_surveyresponse) table extends the [Microsoft Dynamics 365 Customer Voice survey response (msfp_surveyresponse) table](/dynamics365/developer/reference/entities/msfp_surveyresponse).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msfp_surveyresponse#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_resourceterritory, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookingalertstatus_msfp_surveyresponses](#BKMK_msdyn_bookingalertstatus_msfp_surveyresponses)
- [msdyn_bookingrule_msfp_surveyresponses](#BKMK_msdyn_bookingrule_msfp_surveyresponses)
- [msdyn_resourceterritory_msfp_surveyresponses](#BKMK_msdyn_resourceterritory_msfp_surveyresponses)
- [msdyn_systemuserschedulersetting_msfp_surveyresponses](#BKMK_msdyn_systemuserschedulersetting_msfp_surveyresponses)
- [msdyn_timegroup_msfp_surveyresponses](#BKMK_msdyn_timegroup_msfp_surveyresponses)
- [msdyn_timegroupdetail_msfp_surveyresponses](#BKMK_msdyn_timegroupdetail_msfp_surveyresponses)

### <a name="BKMK_msdyn_bookingalertstatus_msfp_surveyresponses"></a> msdyn_bookingalertstatus_msfp_surveyresponses

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_msfp_surveyresponses](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_msfp_surveyresponses"></a> msdyn_bookingrule_msfp_surveyresponses

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_msfp_surveyresponses](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_msfp_surveyresponses"></a> msdyn_resourceterritory_msfp_surveyresponses

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_msfp_surveyresponses](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_msfp_surveyresponses"></a> msdyn_systemuserschedulersetting_msfp_surveyresponses

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_msfp_surveyresponses](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_msfp_surveyresponses"></a> msdyn_timegroup_msfp_surveyresponses

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_msfp_surveyresponses](msdyn_timegroup.md#BKMK_msdyn_timegroup_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_msfp_surveyresponses"></a> msdyn_timegroupdetail_msfp_surveyresponses

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_msfp_surveyresponses](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.msfp_surveyresponse?displayProperty=fullName>
