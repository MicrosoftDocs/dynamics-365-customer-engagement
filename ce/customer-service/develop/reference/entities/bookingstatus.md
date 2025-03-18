---
title: "Booking Status (BookingStatus) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Booking Status (BookingStatus) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Booking Status (BookingStatus) table/entity reference (Microsoft Dynamics 365 Customer Service)

Allows creation of multiple sub statuses mapped to a booking status option.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Booking Status (BookingStatus) table extends the [Microsoft Dynamics 365 Booking Status (BookingStatus) table](/dynamics365/developer/reference/entities/bookingstatus).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_ImageUrl](#BKMK_msdyn_ImageUrl)
- [msdyn_OptimizationMethod](#BKMK_msdyn_OptimizationMethod)
- [msdyn_ServiceAppointmentStatus](#BKMK_msdyn_ServiceAppointmentStatus)
- [msdyn_StatusColor](#BKMK_msdyn_StatusColor)

### <a name="BKMK_msdyn_ImageUrl"></a> msdyn_ImageUrl

|Property|Value|
|---|---|
|Description|**The URL for a web resource image.**|
|DisplayName|**Image Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_imageurl`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_OptimizationMethod"></a> msdyn_OptimizationMethod

|Property|Value|
|---|---|
|Description|**Whether bookings with this status should be optimized, locked or ignored during optimization.**|
|DisplayName|**Optimization Method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optimizationmethod`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_bookingstatusoptimizationmethod`|

#### msdyn_OptimizationMethod Choices/Options

|Value|Label|
|---|---|
|192350000|**Optimize**|
|192350001|**Do Not Move**|
|192350002|**Ignore**|

### <a name="BKMK_msdyn_ServiceAppointmentStatus"></a> msdyn_ServiceAppointmentStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**ServiceAppointment Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_serviceappointmentstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_serviceappointmentstatus`|

#### msdyn_ServiceAppointmentStatus Choices/Options

|Value|Label|
|---|---|
|3|**Pending**|
|4|**Reserved**|
|6|**In Progress**|
|7|**Arrived**|
|8|**Completed**|
|9|**Canceled**|
|10|**No Show**|

### <a name="BKMK_msdyn_StatusColor"></a> msdyn_StatusColor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Status Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statuscolor`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|


## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_Description"></a> Description

Changes from [Description (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/bookingstatus#BKMK_Description)

|Property|Value|
|---|---|
|DisplayName|**Description**|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid](#BKMK_msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid)
- [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus)
- [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus)

### <a name="BKMK_msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid"></a> msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid

Many-To-One Relationship: [bookableresourcebookingheader msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid](bookableresourcebookingheader.md#BKMK_msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebookingheader`|
|ReferencingAttribute|`msdyn_bookingstatusid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_bookableresourcebookingheader_bookingstatusid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus"></a> msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus

Many-To-One Relationship: [msdyn_bookingsetupmetadata msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`msdyn_defaultbookingcanceledstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus"></a> msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus

Many-To-One Relationship: [msdyn_bookingsetupmetadata msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`msdyn_defaultbookingcommittedstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

