---
title: "Service Activity (ServiceAppointment) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Service Activity (ServiceAppointment) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Service Activity (ServiceAppointment) table/entity reference (Microsoft Dynamics 365 Customer Service)

Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Service Activity (ServiceAppointment) table extends the [Microsoft Dynamics 365 Service Activity (ServiceAppointment) table](/dynamics365/developer/reference/entities/serviceappointment).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdyn_OrganizationalUnitId"></a> msdyn_OrganizationalUnitId

|Property|Value|
|---|---|
|Description|**OrganizationalUnit ServiceAppointment Id**|
|DisplayName|**OrganizationalUnit ServiceAppointment Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_organizationalunitid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_organizationalunit|


## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/serviceappointment#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_resourceterritory, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookingalertstatus_ServiceAppointments](#BKMK_msdyn_bookingalertstatus_ServiceAppointments)
- [msdyn_bookingrule_ServiceAppointments](#BKMK_msdyn_bookingrule_ServiceAppointments)
- [msdyn_organizationalunit_serviceappointment](#BKMK_msdyn_organizationalunit_serviceappointment)
- [msdyn_resourceterritory_ServiceAppointments](#BKMK_msdyn_resourceterritory_ServiceAppointments)
- [msdyn_systemuserschedulersetting_ServiceAppointments](#BKMK_msdyn_systemuserschedulersetting_ServiceAppointments)
- [msdyn_timegroup_ServiceAppointments](#BKMK_msdyn_timegroup_ServiceAppointments)
- [msdyn_timegroupdetail_ServiceAppointments](#BKMK_msdyn_timegroupdetail_ServiceAppointments)

### <a name="BKMK_msdyn_bookingalertstatus_ServiceAppointments"></a> msdyn_bookingalertstatus_ServiceAppointments

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_ServiceAppointments](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_ServiceAppointments"></a> msdyn_bookingrule_ServiceAppointments

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_ServiceAppointments](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_organizationalunit_serviceappointment"></a> msdyn_organizationalunit_serviceappointment

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_serviceappointment](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_serviceappointment)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`msdyn_organizationalunitid`|
|ReferencingEntityNavigationPropertyName|`msdyn_OrganizationalUnitServiceAppointmentId_ServiceAppointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_ServiceAppointments"></a> msdyn_resourceterritory_ServiceAppointments

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_ServiceAppointments](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_ServiceAppointments"></a> msdyn_systemuserschedulersetting_ServiceAppointments

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_ServiceAppointments](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_ServiceAppointments"></a> msdyn_timegroup_ServiceAppointments

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_ServiceAppointments](msdyn_timegroup.md#BKMK_msdyn_timegroup_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_ServiceAppointments"></a> msdyn_timegroupdetail_ServiceAppointments

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_ServiceAppointments](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_serviceappointment_bookableresourcebooking_serviceappointment](#BKMK_msdyn_serviceappointment_bookableresourcebooking_serviceappointment)
- [msdyn_serviceappointment_msdyn_resourcerequirement_serviceappointment](#BKMK_msdyn_serviceappointment_msdyn_resourcerequirement_serviceappointment)

### <a name="BKMK_msdyn_serviceappointment_bookableresourcebooking_serviceappointment"></a> msdyn_serviceappointment_bookableresourcebooking_serviceappointment

Many-To-One Relationship: [bookableresourcebooking msdyn_serviceappointment_bookableresourcebooking_serviceappointment](bookableresourcebooking.md#BKMK_msdyn_serviceappointment_bookableresourcebooking_serviceappointment)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`msdyn_serviceappointment`|
|ReferencedEntityNavigationPropertyName|`msdyn_serviceappointment_bookableresourcebooking_serviceappointment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_serviceappointment_msdyn_resourcerequirement_serviceappointment"></a> msdyn_serviceappointment_msdyn_resourcerequirement_serviceappointment

Many-To-One Relationship: [msdyn_resourcerequirement msdyn_serviceappointment_msdyn_resourcerequirement_serviceappointment](msdyn_resourcerequirement.md#BKMK_msdyn_serviceappointment_msdyn_resourcerequirement_serviceappointment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`msdyn_serviceappointment`|
|ReferencedEntityNavigationPropertyName|`msdyn_serviceappointment_msdyn_resourcerequirement_serviceappointment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Requirements<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

