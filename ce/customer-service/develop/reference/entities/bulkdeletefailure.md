---
title: "Bulk Delete Failure (BulkDeleteFailure) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Bulk Delete Failure (BulkDeleteFailure) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Bulk Delete Failure (BulkDeleteFailure) table/entity reference (Microsoft Dynamics 365 Customer Service)

Record that was not deleted during a bulk deletion job.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Bulk Delete Failure (BulkDeleteFailure) table extends the [Microsoft Dynamics 365 Bulk Delete Failure (BulkDeleteFailure) table](/dynamics365/developer/reference/entities/bulkdeletefailure).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/bulkdeletefailure#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_actual, msdyn_bookableresourceassociation, msdyn_bookingalert, msdyn_bookingalertstatus, msdyn_bookingchange, msdyn_bookingrule, msdyn_bookingsetupmetadata, msdyn_businessclosure, msdyn_clientextension, msdyn_configuration, msdyn_organizationalunit, msdyn_priority, msdyn_requirementchange, msdyn_requirementcharacteristic, msdyn_requirementdependency, msdyn_requirementgroup, msdyn_requirementorganizationunit, msdyn_requirementrelationship, msdyn_requirementresourcecategory, msdyn_requirementresourcepreference, msdyn_requirementstatus, msdyn_resourcerequirement, msdyn_resourcerequirementdetail, msdyn_resourceterritory, msdyn_scheduleboardsetting, msdyn_schedulingfeatureflag, msdyn_schedulingparameter, msdyn_schedulingscope, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail, msdyn_transactionorigin, msdyn_workhourtemplate|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_actual_BulkDeleteFailures](#BKMK_msdyn_actual_BulkDeleteFailures)
- [msdyn_bookableresourceassociation_BulkDeleteFailures](#BKMK_msdyn_bookableresourceassociation_BulkDeleteFailures)
- [msdyn_bookingalert_BulkDeleteFailures](#BKMK_msdyn_bookingalert_BulkDeleteFailures)
- [msdyn_bookingalertstatus_BulkDeleteFailures](#BKMK_msdyn_bookingalertstatus_BulkDeleteFailures)
- [msdyn_bookingchange_BulkDeleteFailures](#BKMK_msdyn_bookingchange_BulkDeleteFailures)
- [msdyn_bookingrule_BulkDeleteFailures](#BKMK_msdyn_bookingrule_BulkDeleteFailures)
- [msdyn_bookingsetupmetadata_BulkDeleteFailures](#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures)
- [msdyn_businessclosure_BulkDeleteFailures](#BKMK_msdyn_businessclosure_BulkDeleteFailures)
- [msdyn_clientextension_BulkDeleteFailures](#BKMK_msdyn_clientextension_BulkDeleteFailures)
- [msdyn_configuration_BulkDeleteFailures](#BKMK_msdyn_configuration_BulkDeleteFailures)
- [msdyn_organizationalunit_BulkDeleteFailures](#BKMK_msdyn_organizationalunit_BulkDeleteFailures)
- [msdyn_priority_BulkDeleteFailures](#BKMK_msdyn_priority_BulkDeleteFailures)
- [msdyn_requirementchange_BulkDeleteFailures](#BKMK_msdyn_requirementchange_BulkDeleteFailures)
- [msdyn_requirementcharacteristic_BulkDeleteFailures](#BKMK_msdyn_requirementcharacteristic_BulkDeleteFailures)
- [msdyn_requirementdependency_BulkDeleteFailures](#BKMK_msdyn_requirementdependency_BulkDeleteFailures)
- [msdyn_requirementgroup_BulkDeleteFailures](#BKMK_msdyn_requirementgroup_BulkDeleteFailures)
- [msdyn_requirementorganizationunit_BulkDeleteFailures](#BKMK_msdyn_requirementorganizationunit_BulkDeleteFailures)
- [msdyn_requirementrelationship_BulkDeleteFailures](#BKMK_msdyn_requirementrelationship_BulkDeleteFailures)
- [msdyn_requirementresourcecategory_BulkDeleteFailures](#BKMK_msdyn_requirementresourcecategory_BulkDeleteFailures)
- [msdyn_requirementresourcepreference_BulkDeleteFailures](#BKMK_msdyn_requirementresourcepreference_BulkDeleteFailures)
- [msdyn_requirementstatus_BulkDeleteFailures](#BKMK_msdyn_requirementstatus_BulkDeleteFailures)
- [msdyn_resourcerequirement_BulkDeleteFailures](#BKMK_msdyn_resourcerequirement_BulkDeleteFailures)
- [msdyn_resourcerequirementdetail_BulkDeleteFailures](#BKMK_msdyn_resourcerequirementdetail_BulkDeleteFailures)
- [msdyn_resourceterritory_BulkDeleteFailures](#BKMK_msdyn_resourceterritory_BulkDeleteFailures)
- [msdyn_scheduleboardsetting_BulkDeleteFailures](#BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures)
- [msdyn_schedulingfeatureflag_BulkDeleteFailures](#BKMK_msdyn_schedulingfeatureflag_BulkDeleteFailures)
- [msdyn_schedulingparameter_BulkDeleteFailures](#BKMK_msdyn_schedulingparameter_BulkDeleteFailures)
- [msdyn_schedulingscope_BulkDeleteFailures](#BKMK_msdyn_schedulingscope_BulkDeleteFailures)
- [msdyn_systemuserschedulersetting_BulkDeleteFailures](#BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures)
- [msdyn_timegroup_BulkDeleteFailures](#BKMK_msdyn_timegroup_BulkDeleteFailures)
- [msdyn_timegroupdetail_BulkDeleteFailures](#BKMK_msdyn_timegroupdetail_BulkDeleteFailures)
- [msdyn_transactionorigin_BulkDeleteFailures](#BKMK_msdyn_transactionorigin_BulkDeleteFailures)
- [msdyn_workhourtemplate_BulkDeleteFailures](#BKMK_msdyn_workhourtemplate_BulkDeleteFailures)

### <a name="BKMK_msdyn_actual_BulkDeleteFailures"></a> msdyn_actual_BulkDeleteFailures

One-To-Many Relationship: [msdyn_actual msdyn_actual_BulkDeleteFailures](msdyn_actual.md#BKMK_msdyn_actual_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_BulkDeleteFailures"></a> msdyn_bookableresourceassociation_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_BulkDeleteFailures](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_BulkDeleteFailures"></a> msdyn_bookingalert_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_BulkDeleteFailures](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_BulkDeleteFailures"></a> msdyn_bookingalertstatus_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_BulkDeleteFailures](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_BulkDeleteFailures"></a> msdyn_bookingchange_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_BulkDeleteFailures](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_BulkDeleteFailures"></a> msdyn_bookingrule_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_BulkDeleteFailures](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures"></a> msdyn_bookingsetupmetadata_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_BulkDeleteFailures](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_BulkDeleteFailures"></a> msdyn_businessclosure_BulkDeleteFailures

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_BulkDeleteFailures](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_BulkDeleteFailures"></a> msdyn_clientextension_BulkDeleteFailures

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_BulkDeleteFailures](msdyn_clientextension.md#BKMK_msdyn_clientextension_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_BulkDeleteFailures"></a> msdyn_configuration_BulkDeleteFailures

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_BulkDeleteFailures](msdyn_configuration.md#BKMK_msdyn_configuration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_BulkDeleteFailures"></a> msdyn_organizationalunit_BulkDeleteFailures

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_BulkDeleteFailures](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_BulkDeleteFailures"></a> msdyn_priority_BulkDeleteFailures

One-To-Many Relationship: [msdyn_priority msdyn_priority_BulkDeleteFailures](msdyn_priority.md#BKMK_msdyn_priority_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_BulkDeleteFailures"></a> msdyn_requirementchange_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_BulkDeleteFailures](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_BulkDeleteFailures"></a> msdyn_requirementcharacteristic_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_BulkDeleteFailures](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_BulkDeleteFailures"></a> msdyn_requirementdependency_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_BulkDeleteFailures](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_BulkDeleteFailures"></a> msdyn_requirementgroup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_BulkDeleteFailures](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_BulkDeleteFailures"></a> msdyn_requirementorganizationunit_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_BulkDeleteFailures](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_BulkDeleteFailures"></a> msdyn_requirementrelationship_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_BulkDeleteFailures](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_BulkDeleteFailures"></a> msdyn_requirementresourcecategory_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_BulkDeleteFailures](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_BulkDeleteFailures"></a> msdyn_requirementresourcepreference_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_BulkDeleteFailures](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_BulkDeleteFailures"></a> msdyn_requirementstatus_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_BulkDeleteFailures](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_BulkDeleteFailures"></a> msdyn_resourcerequirement_BulkDeleteFailures

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_BulkDeleteFailures](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_BulkDeleteFailures"></a> msdyn_resourcerequirementdetail_BulkDeleteFailures

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_BulkDeleteFailures](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_BulkDeleteFailures"></a> msdyn_resourceterritory_BulkDeleteFailures

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_BulkDeleteFailures](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures"></a> msdyn_scheduleboardsetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_BulkDeleteFailures](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_BulkDeleteFailures"></a> msdyn_schedulingfeatureflag_BulkDeleteFailures

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_BulkDeleteFailures](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_BulkDeleteFailures"></a> msdyn_schedulingparameter_BulkDeleteFailures

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_BulkDeleteFailures](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingscope_BulkDeleteFailures"></a> msdyn_schedulingscope_BulkDeleteFailures

One-To-Many Relationship: [msdyn_schedulingscope msdyn_schedulingscope_BulkDeleteFailures](msdyn_schedulingscope.md#BKMK_msdyn_schedulingscope_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingscope`|
|ReferencedAttribute|`msdyn_schedulingscopeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingscope`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures"></a> msdyn_systemuserschedulersetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_BulkDeleteFailures](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_BulkDeleteFailures"></a> msdyn_timegroup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_BulkDeleteFailures](msdyn_timegroup.md#BKMK_msdyn_timegroup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_BulkDeleteFailures"></a> msdyn_timegroupdetail_BulkDeleteFailures

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_BulkDeleteFailures](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_BulkDeleteFailures"></a> msdyn_transactionorigin_BulkDeleteFailures

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_BulkDeleteFailures](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_BulkDeleteFailures"></a> msdyn_workhourtemplate_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_BulkDeleteFailures](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.bulkdeletefailure?displayProperty=fullName>
