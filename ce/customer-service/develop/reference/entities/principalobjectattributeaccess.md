---
title: "Field Sharing (PrincipalObjectAttributeAccess) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Field Sharing (PrincipalObjectAttributeAccess) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Field Sharing (PrincipalObjectAttributeAccess) table/entity reference (Microsoft Dynamics 365 Customer Service)

Defines CRM security principals (users and teams) access rights to secured field for an entity instance.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Field Sharing (PrincipalObjectAttributeAccess) table extends the [Microsoft Dynamics 365 Field Sharing (PrincipalObjectAttributeAccess) table](/dynamics365/developer/reference/entities/principalobjectattributeaccess).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/principalobjectattributeaccess#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_actual, msdyn_bookableresourceassociation, msdyn_bookingalert, msdyn_bookingalertstatus, msdyn_bookingchange, msdyn_bookingrule, msdyn_bookingsetupmetadata, msdyn_businessclosure, msdyn_clientextension, msdyn_configuration, msdyn_organizationalunit, msdyn_priority, msdyn_requirementchange, msdyn_requirementcharacteristic, msdyn_requirementdependency, msdyn_requirementgroup, msdyn_requirementorganizationunit, msdyn_requirementrelationship, msdyn_requirementresourcecategory, msdyn_requirementresourcepreference, msdyn_requirementstatus, msdyn_resourcerequirement, msdyn_resourcerequirementdetail, msdyn_resourceterritory, msdyn_scheduleboardsetting, msdyn_schedulingfeatureflag, msdyn_schedulingparameter, msdyn_schedulingscope, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail, msdyn_transactionorigin, msdyn_workhourtemplate|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_actual_PrincipalObjectAttributeAccesses](#BKMK_msdyn_actual_PrincipalObjectAttributeAccesses)
- [msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses)
- [msdyn_bookingalert_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses)
- [msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses)
- [msdyn_bookingchange_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingchange_PrincipalObjectAttributeAccesses)
- [msdyn_bookingrule_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingrule_PrincipalObjectAttributeAccesses)
- [msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses)
- [msdyn_businessclosure_PrincipalObjectAttributeAccesses](#BKMK_msdyn_businessclosure_PrincipalObjectAttributeAccesses)
- [msdyn_clientextension_PrincipalObjectAttributeAccesses](#BKMK_msdyn_clientextension_PrincipalObjectAttributeAccesses)
- [msdyn_configuration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses)
- [msdyn_organizationalunit_PrincipalObjectAttributeAccesses](#BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses)
- [msdyn_priority_PrincipalObjectAttributeAccesses](#BKMK_msdyn_priority_PrincipalObjectAttributeAccesses)
- [msdyn_requirementchange_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementchange_PrincipalObjectAttributeAccesses)
- [msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses)
- [msdyn_requirementdependency_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementdependency_PrincipalObjectAttributeAccesses)
- [msdyn_requirementgroup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementgroup_PrincipalObjectAttributeAccesses)
- [msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses)
- [msdyn_requirementrelationship_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementrelationship_PrincipalObjectAttributeAccesses)
- [msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses)
- [msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses)
- [msdyn_requirementstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementstatus_PrincipalObjectAttributeAccesses)
- [msdyn_resourcerequirement_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcerequirement_PrincipalObjectAttributeAccesses)
- [msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses)
- [msdyn_resourceterritory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourceterritory_PrincipalObjectAttributeAccesses)
- [msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses)
- [msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses](#BKMK_msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses)
- [msdyn_schedulingparameter_PrincipalObjectAttributeAccesses](#BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses)
- [msdyn_schedulingscope_PrincipalObjectAttributeAccesses](#BKMK_msdyn_schedulingscope_PrincipalObjectAttributeAccesses)
- [msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses)
- [msdyn_timegroup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timegroup_PrincipalObjectAttributeAccesses)
- [msdyn_timegroupdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses)
- [msdyn_transactionorigin_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactionorigin_PrincipalObjectAttributeAccesses)
- [msdyn_workhourtemplate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workhourtemplate_PrincipalObjectAttributeAccesses)

### <a name="BKMK_msdyn_actual_PrincipalObjectAttributeAccesses"></a> msdyn_actual_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_actual msdyn_actual_PrincipalObjectAttributeAccesses](msdyn_actual.md#BKMK_msdyn_actual_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses"></a> msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses"></a> msdyn_bookingalert_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_PrincipalObjectAttributeAccesses](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses"></a> msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_PrincipalObjectAttributeAccesses"></a> msdyn_bookingchange_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_PrincipalObjectAttributeAccesses](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_PrincipalObjectAttributeAccesses"></a> msdyn_bookingrule_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_PrincipalObjectAttributeAccesses](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses"></a> msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_PrincipalObjectAttributeAccesses"></a> msdyn_businessclosure_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_PrincipalObjectAttributeAccesses](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_PrincipalObjectAttributeAccesses"></a> msdyn_clientextension_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_PrincipalObjectAttributeAccesses](msdyn_clientextension.md#BKMK_msdyn_clientextension_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses"></a> msdyn_configuration_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_PrincipalObjectAttributeAccesses](msdyn_configuration.md#BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses"></a> msdyn_organizationalunit_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_PrincipalObjectAttributeAccesses](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_PrincipalObjectAttributeAccesses"></a> msdyn_priority_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_priority msdyn_priority_PrincipalObjectAttributeAccesses](msdyn_priority.md#BKMK_msdyn_priority_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_PrincipalObjectAttributeAccesses"></a> msdyn_requirementchange_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_PrincipalObjectAttributeAccesses](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses"></a> msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_PrincipalObjectAttributeAccesses"></a> msdyn_requirementdependency_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_PrincipalObjectAttributeAccesses](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_PrincipalObjectAttributeAccesses"></a> msdyn_requirementgroup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_PrincipalObjectAttributeAccesses](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses"></a> msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_PrincipalObjectAttributeAccesses"></a> msdyn_requirementrelationship_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_PrincipalObjectAttributeAccesses](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses"></a> msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses"></a> msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_PrincipalObjectAttributeAccesses"></a> msdyn_requirementstatus_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_PrincipalObjectAttributeAccesses](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_PrincipalObjectAttributeAccesses"></a> msdyn_resourcerequirement_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_PrincipalObjectAttributeAccesses](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses"></a> msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_PrincipalObjectAttributeAccesses"></a> msdyn_resourceterritory_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_PrincipalObjectAttributeAccesses](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses"></a> msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses"></a> msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses"></a> msdyn_schedulingparameter_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_PrincipalObjectAttributeAccesses](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingscope_PrincipalObjectAttributeAccesses"></a> msdyn_schedulingscope_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_schedulingscope msdyn_schedulingscope_PrincipalObjectAttributeAccesses](msdyn_schedulingscope.md#BKMK_msdyn_schedulingscope_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingscope`|
|ReferencedAttribute|`msdyn_schedulingscopeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_schedulingscope`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses"></a> msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_PrincipalObjectAttributeAccesses"></a> msdyn_timegroup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_PrincipalObjectAttributeAccesses](msdyn_timegroup.md#BKMK_msdyn_timegroup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses"></a> msdyn_timegroupdetail_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_PrincipalObjectAttributeAccesses](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_PrincipalObjectAttributeAccesses"></a> msdyn_transactionorigin_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_PrincipalObjectAttributeAccesses](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_PrincipalObjectAttributeAccesses"></a> msdyn_workhourtemplate_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_PrincipalObjectAttributeAccesses](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.principalobjectattributeaccess?displayProperty=fullName>
