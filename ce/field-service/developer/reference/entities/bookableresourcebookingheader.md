---
title: "Bookable Resource Booking Header (BookableResourceBookingHeader) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Bookable Resource Booking Header (BookableResourceBookingHeader) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Bookable Resource Booking Header (BookableResourceBookingHeader) table/entity reference (Microsoft Dynamics 365 Field Service)

Reservation entity representing the summary of the associated resource bookings.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Bookable Resource Booking Header (BookableResourceBookingHeader) table extends the [Microsoft Dynamics 365 Bookable Resource Booking Header (BookableResourceBookingHeader) table](/dynamics365/developer/reference/entities/bookableresourcebookingheader).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_bookableresourceid](#BKMK_msdyn_bookableresourceid)
- [msdyn_bookingstatusid](#BKMK_msdyn_bookingstatusid)
- [msdyn_BookingType](#BKMK_msdyn_BookingType)
- [msdyn_ResourceRequirement](#BKMK_msdyn_ResourceRequirement)

### <a name="BKMK_msdyn_bookableresourceid"></a> msdyn_bookableresourceid

|Property|Value|
|---|---|
|Description|**Bookable Resource**|
|DisplayName|**Bookable Resource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookableresourceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresource|

### <a name="BKMK_msdyn_bookingstatusid"></a> msdyn_bookingstatusid

|Property|Value|
|---|---|
|Description|**Booking Status**|
|DisplayName|**Booking Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingstatusid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookingstatus|

### <a name="BKMK_msdyn_BookingType"></a> msdyn_BookingType

|Property|Value|
|---|---|
|Description|**Select whether the booking is solid or liquid. Solid bookings are firm and cannot be changed whereas liquid bookings can be changed.**|
|DisplayName|**Booking Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_bookableresourcebookingheader_msdyn_bookingtype`|

#### msdyn_BookingType Choices/Options

|Value|Label|
|---|---|
|1|**Solid**|
|2|**Liquid**|

### <a name="BKMK_msdyn_ResourceRequirement"></a> msdyn_ResourceRequirement

|Property|Value|
|---|---|
|Description|**Resource Requirement**|
|DisplayName|**Resource Requirement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resourcerequirement`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_resourcerequirement|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid](#BKMK_msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid)
- [msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid](#BKMK_msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid)
- [msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement](#BKMK_msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement)

### <a name="BKMK_msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid"></a> msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid

One-To-Many Relationship: [bookableresource msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid](bookableresource.md#BKMK_msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`msdyn_bookableresourceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_bookableresourceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid"></a> msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid

One-To-Many Relationship: [bookingstatus msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid](bookingstatus.md#BKMK_msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid)

|Property|Value|
|---|---|
|ReferencedEntity|`bookingstatus`|
|ReferencedAttribute|`bookingstatusid`|
|ReferencingAttribute|`msdyn_bookingstatusid`|
|ReferencingEntityNavigationPropertyName|`msdyn_bookingstatusid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement"></a> msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_bookableresourcebookingheader_ResourceRequirement)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`msdyn_resourcerequirement`|
|ReferencingEntityNavigationPropertyName|`msdyn_ResourceRequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_bookableresourcebookingheader_msdyn_bookingalerts"></a> bookableresourcebookingheader_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert bookableresourcebookingheader_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_bookableresourcebookingheader_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresourcebookingheader_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

