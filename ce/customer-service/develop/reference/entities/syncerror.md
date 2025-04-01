---
title: "Sync Error (SyncError) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Sync Error (SyncError) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Sync Error (SyncError) table/entity reference (Microsoft Dynamics 365 Customer Service)

Failure reason and other detailed information for a record that failed to sync.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Sync Error (SyncError) table extends the [Microsoft Dynamics 365 Sync Error (SyncError) table](/dynamics365/developer/reference/entities/syncerror).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/syncerror#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_actual, msdyn_bookableresourceassociation, msdyn_bookingalert, msdyn_bookingalertstatus, msdyn_bookingchange, msdyn_bookingrule, msdyn_bookingsetupmetadata, msdyn_businessclosure, msdyn_clientextension, msdyn_configuration, msdyn_organizationalunit, msdyn_priority, msdyn_requirementchange, msdyn_requirementcharacteristic, msdyn_requirementdependency, msdyn_requirementgroup, msdyn_requirementorganizationunit, msdyn_requirementrelationship, msdyn_requirementresourcecategory, msdyn_requirementresourcepreference, msdyn_requirementstatus, msdyn_resourcerequirement, msdyn_resourcerequirementdetail, msdyn_resourceterritory, msdyn_scheduleboardsetting, msdyn_schedulingfeatureflag, msdyn_schedulingparameter, msdyn_schedulingscope, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail, msdyn_transactionorigin, msdyn_workhourtemplate|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_actual_SyncErrors](#BKMK_msdyn_actual_SyncErrors)
- [msdyn_bookableresourceassociation_SyncErrors](#BKMK_msdyn_bookableresourceassociation_SyncErrors)
- [msdyn_bookingalert_SyncErrors](#BKMK_msdyn_bookingalert_SyncErrors)
- [msdyn_bookingalertstatus_SyncErrors](#BKMK_msdyn_bookingalertstatus_SyncErrors)
- [msdyn_bookingchange_SyncErrors](#BKMK_msdyn_bookingchange_SyncErrors)
- [msdyn_bookingrule_SyncErrors](#BKMK_msdyn_bookingrule_SyncErrors)
- [msdyn_bookingsetupmetadata_SyncErrors](#BKMK_msdyn_bookingsetupmetadata_SyncErrors)
- [msdyn_businessclosure_SyncErrors](#BKMK_msdyn_businessclosure_SyncErrors)
- [msdyn_clientextension_SyncErrors](#BKMK_msdyn_clientextension_SyncErrors)
- [msdyn_configuration_SyncErrors](#BKMK_msdyn_configuration_SyncErrors)
- [msdyn_organizationalunit_SyncErrors](#BKMK_msdyn_organizationalunit_SyncErrors)
- [msdyn_priority_SyncErrors](#BKMK_msdyn_priority_SyncErrors)
- [msdyn_requirementchange_SyncErrors](#BKMK_msdyn_requirementchange_SyncErrors)
- [msdyn_requirementcharacteristic_SyncErrors](#BKMK_msdyn_requirementcharacteristic_SyncErrors)
- [msdyn_requirementdependency_SyncErrors](#BKMK_msdyn_requirementdependency_SyncErrors)
- [msdyn_requirementgroup_SyncErrors](#BKMK_msdyn_requirementgroup_SyncErrors)
- [msdyn_requirementorganizationunit_SyncErrors](#BKMK_msdyn_requirementorganizationunit_SyncErrors)
- [msdyn_requirementrelationship_SyncErrors](#BKMK_msdyn_requirementrelationship_SyncErrors)
- [msdyn_requirementresourcecategory_SyncErrors](#BKMK_msdyn_requirementresourcecategory_SyncErrors)
- [msdyn_requirementresourcepreference_SyncErrors](#BKMK_msdyn_requirementresourcepreference_SyncErrors)
- [msdyn_requirementstatus_SyncErrors](#BKMK_msdyn_requirementstatus_SyncErrors)
- [msdyn_resourcerequirement_SyncErrors](#BKMK_msdyn_resourcerequirement_SyncErrors)
- [msdyn_resourcerequirementdetail_SyncErrors](#BKMK_msdyn_resourcerequirementdetail_SyncErrors)
- [msdyn_resourceterritory_SyncErrors](#BKMK_msdyn_resourceterritory_SyncErrors)
- [msdyn_scheduleboardsetting_SyncErrors](#BKMK_msdyn_scheduleboardsetting_SyncErrors)
- [msdyn_schedulingfeatureflag_SyncErrors](#BKMK_msdyn_schedulingfeatureflag_SyncErrors)
- [msdyn_schedulingparameter_SyncErrors](#BKMK_msdyn_schedulingparameter_SyncErrors)
- [msdyn_schedulingscope_SyncErrors](#BKMK_msdyn_schedulingscope_SyncErrors)
- [msdyn_systemuserschedulersetting_SyncErrors](#BKMK_msdyn_systemuserschedulersetting_SyncErrors)
- [msdyn_timegroup_SyncErrors](#BKMK_msdyn_timegroup_SyncErrors)
- [msdyn_timegroupdetail_SyncErrors](#BKMK_msdyn_timegroupdetail_SyncErrors)
- [msdyn_transactionorigin_SyncErrors](#BKMK_msdyn_transactionorigin_SyncErrors)
- [msdyn_workhourtemplate_SyncErrors](#BKMK_msdyn_workhourtemplate_SyncErrors)

### <a name="BKMK_msdyn_actual_SyncErrors"></a> msdyn_actual_SyncErrors

One-To-Many Relationship: [msdyn_actual msdyn_actual_SyncErrors](msdyn_actual.md#BKMK_msdyn_actual_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_SyncErrors"></a> msdyn_bookableresourceassociation_SyncErrors

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_SyncErrors](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_SyncErrors"></a> msdyn_bookingalert_SyncErrors

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_SyncErrors](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_SyncErrors"></a> msdyn_bookingalertstatus_SyncErrors

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_SyncErrors](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_SyncErrors"></a> msdyn_bookingchange_SyncErrors

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_SyncErrors](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_SyncErrors"></a> msdyn_bookingrule_SyncErrors

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_SyncErrors](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_SyncErrors"></a> msdyn_bookingsetupmetadata_SyncErrors

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_SyncErrors](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_SyncErrors"></a> msdyn_businessclosure_SyncErrors

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_SyncErrors](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_SyncErrors"></a> msdyn_clientextension_SyncErrors

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_SyncErrors](msdyn_clientextension.md#BKMK_msdyn_clientextension_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_SyncErrors"></a> msdyn_configuration_SyncErrors

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_SyncErrors](msdyn_configuration.md#BKMK_msdyn_configuration_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_SyncErrors"></a> msdyn_organizationalunit_SyncErrors

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_SyncErrors](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_SyncErrors"></a> msdyn_priority_SyncErrors

One-To-Many Relationship: [msdyn_priority msdyn_priority_SyncErrors](msdyn_priority.md#BKMK_msdyn_priority_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_SyncErrors"></a> msdyn_requirementchange_SyncErrors

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_SyncErrors](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_SyncErrors"></a> msdyn_requirementcharacteristic_SyncErrors

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_SyncErrors](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_SyncErrors"></a> msdyn_requirementdependency_SyncErrors

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_SyncErrors](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_SyncErrors"></a> msdyn_requirementgroup_SyncErrors

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_SyncErrors](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_SyncErrors"></a> msdyn_requirementorganizationunit_SyncErrors

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_SyncErrors](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_SyncErrors"></a> msdyn_requirementrelationship_SyncErrors

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_SyncErrors](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_SyncErrors"></a> msdyn_requirementresourcecategory_SyncErrors

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_SyncErrors](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_SyncErrors"></a> msdyn_requirementresourcepreference_SyncErrors

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_SyncErrors](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_SyncErrors"></a> msdyn_requirementstatus_SyncErrors

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_SyncErrors](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_SyncErrors"></a> msdyn_resourcerequirement_SyncErrors

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_SyncErrors](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_SyncErrors"></a> msdyn_resourcerequirementdetail_SyncErrors

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_SyncErrors](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_SyncErrors"></a> msdyn_resourceterritory_SyncErrors

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_SyncErrors](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_SyncErrors"></a> msdyn_scheduleboardsetting_SyncErrors

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_SyncErrors](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_SyncErrors"></a> msdyn_schedulingfeatureflag_SyncErrors

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_SyncErrors](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_SyncErrors"></a> msdyn_schedulingparameter_SyncErrors

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_SyncErrors](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingscope_SyncErrors"></a> msdyn_schedulingscope_SyncErrors

One-To-Many Relationship: [msdyn_schedulingscope msdyn_schedulingscope_SyncErrors](msdyn_schedulingscope.md#BKMK_msdyn_schedulingscope_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingscope`|
|ReferencedAttribute|`msdyn_schedulingscopeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingscope`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_SyncErrors"></a> msdyn_systemuserschedulersetting_SyncErrors

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_SyncErrors](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_SyncErrors"></a> msdyn_timegroup_SyncErrors

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_SyncErrors](msdyn_timegroup.md#BKMK_msdyn_timegroup_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_SyncErrors"></a> msdyn_timegroupdetail_SyncErrors

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_SyncErrors](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_SyncErrors"></a> msdyn_transactionorigin_SyncErrors

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_SyncErrors](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_SyncErrors)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_SyncErrors"></a> msdyn_workhourtemplate_SyncErrors

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_SyncErrors](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_SyncErrors)

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
<xref:Microsoft.Dynamics.CRM.syncerror?displayProperty=fullName>
