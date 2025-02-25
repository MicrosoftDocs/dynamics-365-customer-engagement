---
title: "System Job (AsyncOperation) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the System Job (AsyncOperation) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# System Job (AsyncOperation) table/entity reference (Microsoft Dynamics 365 Customer Service)

Process whose execution can proceed independently or in the background.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service System Job (AsyncOperation) table extends the [Microsoft Dynamics 365 System Job (AsyncOperation) table](/dynamics365/developer/reference/entities/asyncoperation).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/asyncoperation#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_actual, msdyn_bookableresourceassociation, msdyn_bookingalert, msdyn_bookingalertstatus, msdyn_bookingchange, msdyn_bookingrule, msdyn_bookingsetupmetadata, msdyn_businessclosure, msdyn_clientextension, msdyn_configuration, msdyn_organizationalunit, msdyn_priority, msdyn_requirementchange, msdyn_requirementcharacteristic, msdyn_requirementdependency, msdyn_requirementgroup, msdyn_requirementorganizationunit, msdyn_requirementrelationship, msdyn_requirementresourcecategory, msdyn_requirementresourcepreference, msdyn_requirementstatus, msdyn_resourcerequirement, msdyn_resourcerequirementdetail, msdyn_resourceterritory, msdyn_scheduleboardsetting, msdyn_schedulingfeatureflag, msdyn_schedulingparameter, msdyn_schedulingscope, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail, msdyn_transactionorigin, msdyn_workhourtemplate|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_actual_AsyncOperations](#BKMK_msdyn_actual_AsyncOperations)
- [msdyn_bookableresourceassociation_AsyncOperations](#BKMK_msdyn_bookableresourceassociation_AsyncOperations)
- [msdyn_bookingalert_AsyncOperations](#BKMK_msdyn_bookingalert_AsyncOperations)
- [msdyn_bookingalertstatus_AsyncOperations](#BKMK_msdyn_bookingalertstatus_AsyncOperations)
- [msdyn_bookingchange_AsyncOperations](#BKMK_msdyn_bookingchange_AsyncOperations)
- [msdyn_bookingrule_AsyncOperations](#BKMK_msdyn_bookingrule_AsyncOperations)
- [msdyn_bookingsetupmetadata_AsyncOperations](#BKMK_msdyn_bookingsetupmetadata_AsyncOperations)
- [msdyn_businessclosure_AsyncOperations](#BKMK_msdyn_businessclosure_AsyncOperations)
- [msdyn_clientextension_AsyncOperations](#BKMK_msdyn_clientextension_AsyncOperations)
- [msdyn_configuration_AsyncOperations](#BKMK_msdyn_configuration_AsyncOperations)
- [msdyn_organizationalunit_AsyncOperations](#BKMK_msdyn_organizationalunit_AsyncOperations)
- [msdyn_priority_AsyncOperations](#BKMK_msdyn_priority_AsyncOperations)
- [msdyn_requirementchange_AsyncOperations](#BKMK_msdyn_requirementchange_AsyncOperations)
- [msdyn_requirementcharacteristic_AsyncOperations](#BKMK_msdyn_requirementcharacteristic_AsyncOperations)
- [msdyn_requirementdependency_AsyncOperations](#BKMK_msdyn_requirementdependency_AsyncOperations)
- [msdyn_requirementgroup_AsyncOperations](#BKMK_msdyn_requirementgroup_AsyncOperations)
- [msdyn_requirementorganizationunit_AsyncOperations](#BKMK_msdyn_requirementorganizationunit_AsyncOperations)
- [msdyn_requirementrelationship_AsyncOperations](#BKMK_msdyn_requirementrelationship_AsyncOperations)
- [msdyn_requirementresourcecategory_AsyncOperations](#BKMK_msdyn_requirementresourcecategory_AsyncOperations)
- [msdyn_requirementresourcepreference_AsyncOperations](#BKMK_msdyn_requirementresourcepreference_AsyncOperations)
- [msdyn_requirementstatus_AsyncOperations](#BKMK_msdyn_requirementstatus_AsyncOperations)
- [msdyn_resourcerequirement_AsyncOperations](#BKMK_msdyn_resourcerequirement_AsyncOperations)
- [msdyn_resourcerequirementdetail_AsyncOperations](#BKMK_msdyn_resourcerequirementdetail_AsyncOperations)
- [msdyn_resourceterritory_AsyncOperations](#BKMK_msdyn_resourceterritory_AsyncOperations)
- [msdyn_scheduleboardsetting_AsyncOperations](#BKMK_msdyn_scheduleboardsetting_AsyncOperations)
- [msdyn_schedulingfeatureflag_AsyncOperations](#BKMK_msdyn_schedulingfeatureflag_AsyncOperations)
- [msdyn_schedulingparameter_AsyncOperations](#BKMK_msdyn_schedulingparameter_AsyncOperations)
- [msdyn_schedulingscope_AsyncOperations](#BKMK_msdyn_schedulingscope_AsyncOperations)
- [msdyn_systemuserschedulersetting_AsyncOperations](#BKMK_msdyn_systemuserschedulersetting_AsyncOperations)
- [msdyn_timegroup_AsyncOperations](#BKMK_msdyn_timegroup_AsyncOperations)
- [msdyn_timegroupdetail_AsyncOperations](#BKMK_msdyn_timegroupdetail_AsyncOperations)
- [msdyn_transactionorigin_AsyncOperations](#BKMK_msdyn_transactionorigin_AsyncOperations)
- [msdyn_workhourtemplate_AsyncOperations](#BKMK_msdyn_workhourtemplate_AsyncOperations)

### <a name="BKMK_msdyn_actual_AsyncOperations"></a> msdyn_actual_AsyncOperations

One-To-Many Relationship: [msdyn_actual msdyn_actual_AsyncOperations](msdyn_actual.md#BKMK_msdyn_actual_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_AsyncOperations"></a> msdyn_bookableresourceassociation_AsyncOperations

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_AsyncOperations](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_AsyncOperations"></a> msdyn_bookingalert_AsyncOperations

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_AsyncOperations](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_AsyncOperations"></a> msdyn_bookingalertstatus_AsyncOperations

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_AsyncOperations](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_AsyncOperations"></a> msdyn_bookingchange_AsyncOperations

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_AsyncOperations](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_AsyncOperations"></a> msdyn_bookingrule_AsyncOperations

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_AsyncOperations](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_AsyncOperations"></a> msdyn_bookingsetupmetadata_AsyncOperations

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_AsyncOperations](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_AsyncOperations"></a> msdyn_businessclosure_AsyncOperations

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_AsyncOperations](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_AsyncOperations"></a> msdyn_clientextension_AsyncOperations

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_AsyncOperations](msdyn_clientextension.md#BKMK_msdyn_clientextension_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_AsyncOperations"></a> msdyn_configuration_AsyncOperations

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_AsyncOperations](msdyn_configuration.md#BKMK_msdyn_configuration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_AsyncOperations"></a> msdyn_organizationalunit_AsyncOperations

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_AsyncOperations](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_AsyncOperations"></a> msdyn_priority_AsyncOperations

One-To-Many Relationship: [msdyn_priority msdyn_priority_AsyncOperations](msdyn_priority.md#BKMK_msdyn_priority_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_AsyncOperations"></a> msdyn_requirementchange_AsyncOperations

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_AsyncOperations](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_AsyncOperations"></a> msdyn_requirementcharacteristic_AsyncOperations

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_AsyncOperations](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_AsyncOperations"></a> msdyn_requirementdependency_AsyncOperations

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_AsyncOperations](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_AsyncOperations"></a> msdyn_requirementgroup_AsyncOperations

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_AsyncOperations](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_AsyncOperations"></a> msdyn_requirementorganizationunit_AsyncOperations

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_AsyncOperations](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_AsyncOperations"></a> msdyn_requirementrelationship_AsyncOperations

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_AsyncOperations](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_AsyncOperations"></a> msdyn_requirementresourcecategory_AsyncOperations

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_AsyncOperations](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_AsyncOperations"></a> msdyn_requirementresourcepreference_AsyncOperations

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_AsyncOperations](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_AsyncOperations"></a> msdyn_requirementstatus_AsyncOperations

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_AsyncOperations](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_AsyncOperations"></a> msdyn_resourcerequirement_AsyncOperations

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_AsyncOperations](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_AsyncOperations"></a> msdyn_resourcerequirementdetail_AsyncOperations

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_AsyncOperations](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_AsyncOperations"></a> msdyn_resourceterritory_AsyncOperations

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_AsyncOperations](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_AsyncOperations"></a> msdyn_scheduleboardsetting_AsyncOperations

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_AsyncOperations](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_AsyncOperations"></a> msdyn_schedulingfeatureflag_AsyncOperations

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_AsyncOperations](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_AsyncOperations"></a> msdyn_schedulingparameter_AsyncOperations

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_AsyncOperations](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingscope_AsyncOperations"></a> msdyn_schedulingscope_AsyncOperations

One-To-Many Relationship: [msdyn_schedulingscope msdyn_schedulingscope_AsyncOperations](msdyn_schedulingscope.md#BKMK_msdyn_schedulingscope_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingscope`|
|ReferencedAttribute|`msdyn_schedulingscopeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingscope`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_AsyncOperations"></a> msdyn_systemuserschedulersetting_AsyncOperations

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_AsyncOperations](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_AsyncOperations"></a> msdyn_timegroup_AsyncOperations

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_AsyncOperations](msdyn_timegroup.md#BKMK_msdyn_timegroup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_AsyncOperations"></a> msdyn_timegroupdetail_AsyncOperations

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_AsyncOperations](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_AsyncOperations"></a> msdyn_transactionorigin_AsyncOperations

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_AsyncOperations](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_AsyncOperations"></a> msdyn_workhourtemplate_AsyncOperations

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_AsyncOperations](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.asyncoperation?displayProperty=fullName>
