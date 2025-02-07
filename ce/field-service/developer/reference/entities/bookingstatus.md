---
title: "Booking Status (BookingStatus) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Booking Status (BookingStatus) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Booking Status (BookingStatus) table/entity reference (Microsoft Dynamics 365 Field Service)

Allows creation of multiple sub statuses mapped to a booking status option.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Booking Status (BookingStatus) table extends the [Microsoft Dynamics 365 Booking Status (BookingStatus) table](/dynamics365/developer/reference/entities/bookingstatus).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_FieldServiceStatus](#BKMK_msdyn_FieldServiceStatus)
- [msdyn_IconName](#BKMK_msdyn_IconName)
- [msdyn_ImageUrl](#BKMK_msdyn_ImageUrl)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_OptimizationMethod](#BKMK_msdyn_OptimizationMethod)
- [msdyn_StatusColor](#BKMK_msdyn_StatusColor)
- [msdyn_statuscompletesworkorder](#BKMK_msdyn_statuscompletesworkorder)

### <a name="BKMK_msdyn_FieldServiceStatus"></a> msdyn_FieldServiceStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Field Service Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fieldservicestatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_bookingsystemstatus`|

#### msdyn_FieldServiceStatus Choices/Options

|Value|Label|
|---|---|
|690970000|**Scheduled**|
|690970001|**Traveling**|
|690970002|**On Break**|
|690970003|**In Progress**|
|690970004|**Completed**|
|690970005|**Canceled**|

### <a name="BKMK_msdyn_IconName"></a> msdyn_IconName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Icon Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iconname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Internal Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internalflags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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

### <a name="BKMK_msdyn_statuscompletesworkorder"></a> msdyn_statuscompletesworkorder

|Property|Value|
|---|---|
|Description|**Booking assigned this booking status will be included in determining if the work order system status should be set to "completed"**|
|DisplayName|**Status Completes Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statuscompletesworkorder`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_fieldservicesetting_msdyn_statuscompletesworkorder`|
|DefaultValue|True|
|True Label|On|
|False Label|Off|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

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
- [msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus)
- [msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus](#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus)
- [msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus](#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus)
- [msdyn_bookingstatus_msdyn_timeentry_BookingStatus](#BKMK_msdyn_bookingstatus_msdyn_timeentry_BookingStatus)

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

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus"></a> msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus

Many-To-One Relationship: [msdyn_bookingtimestamp msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingtimestamp`|
|ReferencingAttribute|`msdyn_bookingstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_msdyn_bookingtimestamp_BookingStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus"></a> msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus

Many-To-One Relationship: [msdyn_fieldservicesetting msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus](msdyn_fieldservicesetting.md#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`msdyn_defaultcanceledbookingstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus"></a> msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus

Many-To-One Relationship: [msdyn_fieldservicesetting msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus](msdyn_fieldservicesetting.md#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`msdyn_defaultscheduledbookingstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_timeentry_BookingStatus"></a> msdyn_bookingstatus_msdyn_timeentry_BookingStatus

Many-To-One Relationship: [msdyn_timeentry msdyn_bookingstatus_msdyn_timeentry_BookingStatus](msdyn_timeentry.md#BKMK_msdyn_bookingstatus_msdyn_timeentry_BookingStatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentry`|
|ReferencingAttribute|`msdyn_bookingstatus`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingstatus_msdyn_timeentry_BookingStatus`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

