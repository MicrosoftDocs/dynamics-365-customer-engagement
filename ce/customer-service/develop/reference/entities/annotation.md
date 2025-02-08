---
title: "Note (Annotation) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Note (Annotation) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Note (Annotation) table/entity reference (Microsoft Dynamics 365 Customer Service)

Note that is attached to one or more objects, including other notes.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Note (Annotation) table extends the [Microsoft Dynamics 365 Note (Annotation) table](/dynamics365/developer/reference/entities/annotation).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/annotation#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_actual, msdyn_bookingalert, msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_organizationalunit, msdyn_priority, msdyn_requirementcharacteristic, msdyn_requirementresourcecategory, msdyn_requirementresourcepreference, msdyn_requirementstatus, msdyn_resourcerequirement, msdyn_resourcerequirementdetail, msdyn_resourceterritory, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail, msdyn_transactionorigin|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_actual_Annotations](#BKMK_msdyn_actual_Annotations)
- [msdyn_bookingalert_Annotations](#BKMK_msdyn_bookingalert_Annotations)
- [msdyn_bookingalertstatus_Annotations](#BKMK_msdyn_bookingalertstatus_Annotations)
- [msdyn_bookingrule_Annotations](#BKMK_msdyn_bookingrule_Annotations)
- [msdyn_organizationalunit_Annotations](#BKMK_msdyn_organizationalunit_Annotations)
- [msdyn_priority_Annotations](#BKMK_msdyn_priority_Annotations)
- [msdyn_requirementcharacteristic_Annotations](#BKMK_msdyn_requirementcharacteristic_Annotations)
- [msdyn_requirementresourcecategory_Annotations](#BKMK_msdyn_requirementresourcecategory_Annotations)
- [msdyn_requirementresourcepreference_Annotations](#BKMK_msdyn_requirementresourcepreference_Annotations)
- [msdyn_requirementstatus_Annotations](#BKMK_msdyn_requirementstatus_Annotations)
- [msdyn_resourcerequirement_Annotations](#BKMK_msdyn_resourcerequirement_Annotations)
- [msdyn_resourcerequirementdetail_Annotations](#BKMK_msdyn_resourcerequirementdetail_Annotations)
- [msdyn_resourceterritory_Annotations](#BKMK_msdyn_resourceterritory_Annotations)
- [msdyn_systemuserschedulersetting_Annotations](#BKMK_msdyn_systemuserschedulersetting_Annotations)
- [msdyn_timegroup_Annotations](#BKMK_msdyn_timegroup_Annotations)
- [msdyn_timegroupdetail_Annotations](#BKMK_msdyn_timegroupdetail_Annotations)
- [msdyn_transactionorigin_Annotations](#BKMK_msdyn_transactionorigin_Annotations)

### <a name="BKMK_msdyn_actual_Annotations"></a> msdyn_actual_Annotations

One-To-Many Relationship: [msdyn_actual msdyn_actual_Annotations](msdyn_actual.md#BKMK_msdyn_actual_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalert_Annotations"></a> msdyn_bookingalert_Annotations

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_Annotations](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingalertstatus_Annotations"></a> msdyn_bookingalertstatus_Annotations

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_Annotations](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_Annotations"></a> msdyn_bookingrule_Annotations

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_Annotations](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_organizationalunit_Annotations"></a> msdyn_organizationalunit_Annotations

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_Annotations](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_Annotations"></a> msdyn_priority_Annotations

One-To-Many Relationship: [msdyn_priority msdyn_priority_Annotations](msdyn_priority.md#BKMK_msdyn_priority_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_Annotations"></a> msdyn_requirementcharacteristic_Annotations

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_Annotations](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_Annotations"></a> msdyn_requirementresourcecategory_Annotations

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_Annotations](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_Annotations"></a> msdyn_requirementresourcepreference_Annotations

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_Annotations](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_requirementstatus_Annotations"></a> msdyn_requirementstatus_Annotations

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_Annotations](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourcerequirement_Annotations"></a> msdyn_resourcerequirement_Annotations

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_Annotations](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_Annotations"></a> msdyn_resourcerequirementdetail_Annotations

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_Annotations](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_Annotations"></a> msdyn_resourceterritory_Annotations

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_Annotations](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_Annotations"></a> msdyn_systemuserschedulersetting_Annotations

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_Annotations](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_Annotations"></a> msdyn_timegroup_Annotations

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_Annotations](msdyn_timegroup.md#BKMK_msdyn_timegroup_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_Annotations"></a> msdyn_timegroupdetail_Annotations

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_Annotations](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_transactionorigin_Annotations"></a> msdyn_transactionorigin_Annotations

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_Annotations](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.annotation?displayProperty=fullName>
