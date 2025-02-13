---
title: "Mailbox Auto Tracking Folder (MailboxTrackingFolder) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Mailbox Auto Tracking Folder (MailboxTrackingFolder) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Mailbox Auto Tracking Folder (MailboxTrackingFolder) table/entity reference (Microsoft Dynamics 365 Customer Service)

Stores data about what folders for a mailbox are auto tracked

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Mailbox Auto Tracking Folder (MailboxTrackingFolder) table extends the [Microsoft Dynamics 365 Mailbox Auto Tracking Folder (MailboxTrackingFolder) table](/dynamics365/developer/reference/entities/mailboxtrackingfolder).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/mailboxtrackingfolder#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_actual, msdyn_bookableresourceassociation, msdyn_bookingalert, msdyn_bookingalertstatus, msdyn_bookingchange, msdyn_bookingrule, msdyn_bookingsetupmetadata, msdyn_businessclosure, msdyn_clientextension, msdyn_configuration, msdyn_organizationalunit, msdyn_priority, msdyn_requirementchange, msdyn_requirementcharacteristic, msdyn_requirementdependency, msdyn_requirementgroup, msdyn_requirementorganizationunit, msdyn_requirementrelationship, msdyn_requirementresourcecategory, msdyn_requirementresourcepreference, msdyn_requirementstatus, msdyn_resourcerequirement, msdyn_resourcerequirementdetail, msdyn_resourceterritory, msdyn_scheduleboardsetting, msdyn_schedulingfeatureflag, msdyn_schedulingparameter, msdyn_schedulingscope, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail, msdyn_transactionorigin, msdyn_workhourtemplate|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_actual_MailboxTrackingFolders](#BKMK_msdyn_actual_MailboxTrackingFolders)
- [msdyn_bookableresourceassociation_MailboxTrackingFolders](#BKMK_msdyn_bookableresourceassociation_MailboxTrackingFolders)
- [msdyn_bookingalert_MailboxTrackingFolders](#BKMK_msdyn_bookingalert_MailboxTrackingFolders)
- [msdyn_bookingalertstatus_MailboxTrackingFolders](#BKMK_msdyn_bookingalertstatus_MailboxTrackingFolders)
- [msdyn_bookingchange_MailboxTrackingFolders](#BKMK_msdyn_bookingchange_MailboxTrackingFolders)
- [msdyn_bookingrule_MailboxTrackingFolders](#BKMK_msdyn_bookingrule_MailboxTrackingFolders)
- [msdyn_bookingsetupmetadata_MailboxTrackingFolders](#BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders)
- [msdyn_businessclosure_MailboxTrackingFolders](#BKMK_msdyn_businessclosure_MailboxTrackingFolders)
- [msdyn_clientextension_MailboxTrackingFolders](#BKMK_msdyn_clientextension_MailboxTrackingFolders)
- [msdyn_configuration_MailboxTrackingFolders](#BKMK_msdyn_configuration_MailboxTrackingFolders)
- [msdyn_organizationalunit_MailboxTrackingFolders](#BKMK_msdyn_organizationalunit_MailboxTrackingFolders)
- [msdyn_priority_MailboxTrackingFolders](#BKMK_msdyn_priority_MailboxTrackingFolders)
- [msdyn_requirementchange_MailboxTrackingFolders](#BKMK_msdyn_requirementchange_MailboxTrackingFolders)
- [msdyn_requirementcharacteristic_MailboxTrackingFolders](#BKMK_msdyn_requirementcharacteristic_MailboxTrackingFolders)
- [msdyn_requirementdependency_MailboxTrackingFolders](#BKMK_msdyn_requirementdependency_MailboxTrackingFolders)
- [msdyn_requirementgroup_MailboxTrackingFolders](#BKMK_msdyn_requirementgroup_MailboxTrackingFolders)
- [msdyn_requirementorganizationunit_MailboxTrackingFolders](#BKMK_msdyn_requirementorganizationunit_MailboxTrackingFolders)
- [msdyn_requirementrelationship_MailboxTrackingFolders](#BKMK_msdyn_requirementrelationship_MailboxTrackingFolders)
- [msdyn_requirementresourcecategory_MailboxTrackingFolders](#BKMK_msdyn_requirementresourcecategory_MailboxTrackingFolders)
- [msdyn_requirementresourcepreference_MailboxTrackingFolders](#BKMK_msdyn_requirementresourcepreference_MailboxTrackingFolders)
- [msdyn_requirementstatus_MailboxTrackingFolders](#BKMK_msdyn_requirementstatus_MailboxTrackingFolders)
- [msdyn_resourcerequirement_MailboxTrackingFolders](#BKMK_msdyn_resourcerequirement_MailboxTrackingFolders)
- [msdyn_resourcerequirementdetail_MailboxTrackingFolders](#BKMK_msdyn_resourcerequirementdetail_MailboxTrackingFolders)
- [msdyn_resourceterritory_MailboxTrackingFolders](#BKMK_msdyn_resourceterritory_MailboxTrackingFolders)
- [msdyn_scheduleboardsetting_MailboxTrackingFolders](#BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders)
- [msdyn_schedulingfeatureflag_MailboxTrackingFolders](#BKMK_msdyn_schedulingfeatureflag_MailboxTrackingFolders)
- [msdyn_schedulingparameter_MailboxTrackingFolders](#BKMK_msdyn_schedulingparameter_MailboxTrackingFolders)
- [msdyn_schedulingscope_MailboxTrackingFolders](#BKMK_msdyn_schedulingscope_MailboxTrackingFolders)
- [msdyn_systemuserschedulersetting_MailboxTrackingFolders](#BKMK_msdyn_systemuserschedulersetting_MailboxTrackingFolders)
- [msdyn_timegroup_MailboxTrackingFolders](#BKMK_msdyn_timegroup_MailboxTrackingFolders)
- [msdyn_timegroupdetail_MailboxTrackingFolders](#BKMK_msdyn_timegroupdetail_MailboxTrackingFolders)
- [msdyn_transactionorigin_MailboxTrackingFolders](#BKMK_msdyn_transactionorigin_MailboxTrackingFolders)
- [msdyn_workhourtemplate_MailboxTrackingFolders](#BKMK_msdyn_workhourtemplate_MailboxTrackingFolders)

### <a name="BKMK_msdyn_actual_MailboxTrackingFolders"></a> msdyn_actual_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_actual msdyn_actual_MailboxTrackingFolders](msdyn_actual.md#BKMK_msdyn_actual_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_MailboxTrackingFolders"></a> msdyn_bookableresourceassociation_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_MailboxTrackingFolders](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_MailboxTrackingFolders"></a> msdyn_bookingalert_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_MailboxTrackingFolders](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_MailboxTrackingFolders"></a> msdyn_bookingalertstatus_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_MailboxTrackingFolders](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_MailboxTrackingFolders"></a> msdyn_bookingchange_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_MailboxTrackingFolders](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_MailboxTrackingFolders"></a> msdyn_bookingrule_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_MailboxTrackingFolders](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders"></a> msdyn_bookingsetupmetadata_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_MailboxTrackingFolders](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_MailboxTrackingFolders"></a> msdyn_businessclosure_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_MailboxTrackingFolders](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_MailboxTrackingFolders"></a> msdyn_clientextension_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_MailboxTrackingFolders](msdyn_clientextension.md#BKMK_msdyn_clientextension_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_MailboxTrackingFolders"></a> msdyn_configuration_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_MailboxTrackingFolders](msdyn_configuration.md#BKMK_msdyn_configuration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_MailboxTrackingFolders"></a> msdyn_organizationalunit_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_MailboxTrackingFolders](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_MailboxTrackingFolders"></a> msdyn_priority_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_priority msdyn_priority_MailboxTrackingFolders](msdyn_priority.md#BKMK_msdyn_priority_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_MailboxTrackingFolders"></a> msdyn_requirementchange_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_MailboxTrackingFolders](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_MailboxTrackingFolders"></a> msdyn_requirementcharacteristic_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_MailboxTrackingFolders](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_MailboxTrackingFolders"></a> msdyn_requirementdependency_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_MailboxTrackingFolders](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_MailboxTrackingFolders"></a> msdyn_requirementgroup_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_MailboxTrackingFolders](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_MailboxTrackingFolders"></a> msdyn_requirementorganizationunit_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_MailboxTrackingFolders](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_MailboxTrackingFolders"></a> msdyn_requirementrelationship_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_MailboxTrackingFolders](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_MailboxTrackingFolders"></a> msdyn_requirementresourcecategory_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_MailboxTrackingFolders](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_MailboxTrackingFolders"></a> msdyn_requirementresourcepreference_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_MailboxTrackingFolders](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_MailboxTrackingFolders"></a> msdyn_requirementstatus_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_MailboxTrackingFolders](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_MailboxTrackingFolders"></a> msdyn_resourcerequirement_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_MailboxTrackingFolders](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_MailboxTrackingFolders"></a> msdyn_resourcerequirementdetail_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_MailboxTrackingFolders](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_MailboxTrackingFolders"></a> msdyn_resourceterritory_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_MailboxTrackingFolders](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders"></a> msdyn_scheduleboardsetting_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_MailboxTrackingFolders](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_MailboxTrackingFolders"></a> msdyn_schedulingfeatureflag_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_MailboxTrackingFolders](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_MailboxTrackingFolders"></a> msdyn_schedulingparameter_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_MailboxTrackingFolders](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingscope_MailboxTrackingFolders"></a> msdyn_schedulingscope_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_schedulingscope msdyn_schedulingscope_MailboxTrackingFolders](msdyn_schedulingscope.md#BKMK_msdyn_schedulingscope_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingscope`|
|ReferencedAttribute|`msdyn_schedulingscopeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingscope`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_MailboxTrackingFolders"></a> msdyn_systemuserschedulersetting_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_MailboxTrackingFolders](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_MailboxTrackingFolders"></a> msdyn_timegroup_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_MailboxTrackingFolders](msdyn_timegroup.md#BKMK_msdyn_timegroup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_MailboxTrackingFolders"></a> msdyn_timegroupdetail_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_MailboxTrackingFolders](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_MailboxTrackingFolders"></a> msdyn_transactionorigin_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_MailboxTrackingFolders](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_MailboxTrackingFolders"></a> msdyn_workhourtemplate_MailboxTrackingFolders

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_MailboxTrackingFolders](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_MailboxTrackingFolders)

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
<xref:Microsoft.Dynamics.CRM.mailboxtrackingfolder?displayProperty=fullName>
