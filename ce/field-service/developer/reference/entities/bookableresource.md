---
title: "Bookable Resource (BookableResource) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Bookable Resource (BookableResource) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Bookable Resource (BookableResource) table/entity reference (Microsoft Dynamics 365 Field Service)

Resource that has capacity which can be allocated to work.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Bookable Resource (BookableResource) table extends the [Microsoft Dynamics 365 Bookable Resource (BookableResource) table](/dynamics365/developer/reference/entities/bookableresource).


## Messages

The following table lists the messages for the Bookable Resource (BookableResource) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `msdyn_GetResourceBookingDetails`<br />Event: True |**msdyn_GetResourceBookingDetails action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_BookingsToDrip](#BKMK_msdyn_BookingsToDrip)
- [msdyn_CrewStrategy](#BKMK_msdyn_CrewStrategy)
- [msdyn_DeriveCapacity](#BKMK_msdyn_DeriveCapacity)
- [msdyn_DisplayOnScheduleAssistant](#BKMK_msdyn_DisplayOnScheduleAssistant)
- [msdyn_DisplayOnScheduleBoard](#BKMK_msdyn_DisplayOnScheduleBoard)
- [msdyn_EnableAppointments](#BKMK_msdyn_EnableAppointments)
- [msdyn_EnabledForFieldServiceMobile](#BKMK_msdyn_EnabledForFieldServiceMobile)
- [msdyn_EnableDripScheduling](#BKMK_msdyn_EnableDripScheduling)
- [msdyn_EnableOutlookSchedules](#BKMK_msdyn_EnableOutlookSchedules)
- [msdyn_EndLocation](#BKMK_msdyn_EndLocation)
- [msdyn_GenericType](#BKMK_msdyn_GenericType)
- [msdyn_HourlyRate](#BKMK_msdyn_HourlyRate)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_locationtimestamp](#BKMK_msdyn_locationtimestamp)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_OptimalCrewSize](#BKMK_msdyn_OptimalCrewSize)
- [msdyn_organizationalunit](#BKMK_msdyn_organizationalunit)
- [msdyn_PoolType](#BKMK_msdyn_PoolType)
- [msdyn_PrimaryEMail](#BKMK_msdyn_PrimaryEMail)
- [msdyn_StartLocation](#BKMK_msdyn_StartLocation)
- [msdyn_targetutilization](#BKMK_msdyn_targetutilization)
- [msdyn_TimeOffApprovalRequired](#BKMK_msdyn_TimeOffApprovalRequired)
- [msdyn_Warehouse](#BKMK_msdyn_Warehouse)

### <a name="BKMK_msdyn_BookingsToDrip"></a> msdyn_BookingsToDrip

|Property|Value|
|---|---|
|Description|**(deprecated) The number of bookings to drip on the Mobile. This field is disabled/enabled based on Enable Drip Scheduling field**|
|DisplayName|**(deprecated) Bookings To Drip**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingstodrip`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|50|
|MinValue|1|

### <a name="BKMK_msdyn_CrewStrategy"></a> msdyn_CrewStrategy

|Property|Value|
|---|---|
|Description|**Crew Strategy**|
|DisplayName|**Crew Strategy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_crewstrategy`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_crewstrategy`|

#### msdyn_CrewStrategy Choices/Options

|Value|Label|
|---|---|
|192350000|**Cascade and Accept Cascade Completely \(Not Recommended\)**|
|192350001|**Crew Leader Management**|
|192350002|**Crew Member Self\-Management**|

### <a name="BKMK_msdyn_DeriveCapacity"></a> msdyn_DeriveCapacity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Derive Capacity From Group Members**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_derivecapacity`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookableresource_msdyn_derivecapacity`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DisplayOnScheduleAssistant"></a> msdyn_DisplayOnScheduleAssistant

|Property|Value|
|---|---|
|Description|**Specify if this resource should be enabled for availablity search.**|
|DisplayName|**Enable for Availability Search**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayonscheduleassistant`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookableresource_msdyn_displayonscheduleassistant`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DisplayOnScheduleBoard"></a> msdyn_DisplayOnScheduleBoard

|Property|Value|
|---|---|
|Description|**Specify if this resource should be displayed on the schedule board.**|
|DisplayName|**Display On Schedule Board**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayonscheduleboard`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookableresource_msdyn_displayonscheduleboard`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnableAppointments"></a> msdyn_EnableAppointments

|Property|Value|
|---|---|
|Description|**Enable appointments to display on the new schedule board and be considered in availability search for resources.**|
|DisplayName|**Include Appointments**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableappointments`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350001|
|GlobalChoiceName|`msdyn_enableappointmentsoption`|

#### msdyn_EnableAppointments Choices/Options

|Value|Label|
|---|---|
|192350000|**No**|
|192350001|**Yes**|

### <a name="BKMK_msdyn_EnabledForFieldServiceMobile"></a> msdyn_EnabledForFieldServiceMobile

|Property|Value|
|---|---|
|Description|**Set this field to Yes if this resource requires access to the legacy Field Service Mobile application.**|
|DisplayName|**Enable for Field Service Mobile (legacy Xamarin app)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enabledforfieldservicemobile`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookableresource_msdyn_enabledforfieldservicemobile`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnableDripScheduling"></a> msdyn_EnableDripScheduling

|Property|Value|
|---|---|
|Description|**Enables drip scheduling on the mobile app.**|
|DisplayName|**Enable Drip Scheduling**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enabledripscheduling`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookableresource_msdyn_enabledripscheduling`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnableOutlookSchedules"></a> msdyn_EnableOutlookSchedules

|Property|Value|
|---|---|
|Description|**This only applies when directly calling the API. It does not apply when the Book button is clicked on the Schedule Board or on any schedulable entity.**|
|DisplayName|**Include Outlook Free/Busy in Search Resource Availability API**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableoutlookschedules`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350001|
|GlobalChoiceName|`msdyn_enableappointmentsoption`|

#### msdyn_EnableOutlookSchedules Choices/Options

|Value|Label|
|---|---|
|192350000|**No**|
|192350001|**Yes**|

### <a name="BKMK_msdyn_EndLocation"></a> msdyn_EndLocation

|Property|Value|
|---|---|
|Description|**Shows the default ending location type when booking daily schedules for this resource.**|
|DisplayName|**End Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_endlocation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970002|
|GlobalChoiceName|`msdyn_workstartlocationtype`|

#### msdyn_EndLocation Choices/Options

|Value|Label|
|---|---|
|690970000|**Resource Address**|
|690970001|**Organizational Unit Address**|
|690970002|**Location Agnostic**|

### <a name="BKMK_msdyn_GenericType"></a> msdyn_GenericType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Generic Type (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_generictype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_generictype`|

#### msdyn_GenericType Choices/Options

|Value|Label|
|---|---|
|690970000|**Service Center**|

### <a name="BKMK_msdyn_HourlyRate"></a> msdyn_HourlyRate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Hourly Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hourlyrate`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

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

### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

|Property|Value|
|---|---|
|Description|**The location latitude.**|
|DisplayName|**Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_msdyn_locationtimestamp"></a> msdyn_locationtimestamp

|Property|Value|
|---|---|
|Description|**The location timestamp.**|
|DisplayName|**Location Timestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_locationtimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

|Property|Value|
|---|---|
|Description|**The location longitude.**|
|DisplayName|**Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_msdyn_OptimalCrewSize"></a> msdyn_OptimalCrewSize

|Property|Value|
|---|---|
|Description||
|DisplayName|**Optimal Crew Size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optimalcrewsize`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|9999|
|MinValue|0|

### <a name="BKMK_msdyn_organizationalunit"></a> msdyn_organizationalunit

|Property|Value|
|---|---|
|Description|**Organizational Unit that resource belong to**|
|DisplayName|**Organizational Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_organizationalunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_organizationalunit|

### <a name="BKMK_msdyn_PoolType"></a> msdyn_PoolType

|Property|Value|
|---|---|
|Description|**Select whether the pool is an account, contact, user, equipment or a facility of resources.**|
|DisplayName|**Pool Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pooltype`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_pooltype`|

#### msdyn_PoolType Choices/Options

|Value|Label|
|---|---|
|192350000|**Account**|
|192350001|**Contact**|
|192350002|**User**|
|192350003|**Equipment**|
|192350004|**Facility**|

### <a name="BKMK_msdyn_PrimaryEMail"></a> msdyn_PrimaryEMail

|Property|Value|
|---|---|
|Description||
|DisplayName|**Primary Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primaryemail`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_StartLocation"></a> msdyn_StartLocation

|Property|Value|
|---|---|
|Description|**Shows the default starting location type when booking daily schedules for this resource.**|
|DisplayName|**Start Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startlocation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970002|
|GlobalChoiceName|`msdyn_workstartlocationtype`|

#### msdyn_StartLocation Choices/Options

|Value|Label|
|---|---|
|690970000|**Resource Address**|
|690970001|**Organizational Unit Address**|
|690970002|**Location Agnostic**|

### <a name="BKMK_msdyn_targetutilization"></a> msdyn_targetutilization

|Property|Value|
|---|---|
|Description|**Shows the target utilization for the resource.**|
|DisplayName|**Target Utilization**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetutilization`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|1|

### <a name="BKMK_msdyn_TimeOffApprovalRequired"></a> msdyn_TimeOffApprovalRequired

|Property|Value|
|---|---|
|Description|**Specifies if approval required for Time Off Requests.**|
|DisplayName|**Time Off Approval Required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timeoffapprovalrequired`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookableresource_msdyn_timeoffapprovalrequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

|Property|Value|
|---|---|
|Description|**Default Warehouse for this resource.**|
|DisplayName|**Warehouse**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_warehouse`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_warehouse|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

### <a name="BKMK_msdyn_hourlyrate_Base"></a> msdyn_hourlyrate_Base

|Property|Value|
|---|---|
|Description|**Value of the Hourly Rate in base currency.**|
|DisplayName|**Hourly Rate (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hourlyrate_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_msdyn_organizationalunit_bookableresource_organizationalunit](#BKMK_msdyn_msdyn_organizationalunit_bookableresource_organizationalunit)
- [msdyn_msdyn_warehouse_bookableresource_Warehouse](#BKMK_msdyn_msdyn_warehouse_bookableresource_Warehouse)

### <a name="BKMK_msdyn_msdyn_organizationalunit_bookableresource_organizationalunit"></a> msdyn_msdyn_organizationalunit_bookableresource_organizationalunit

One-To-Many Relationship: [msdyn_organizationalunit msdyn_msdyn_organizationalunit_bookableresource_organizationalunit](msdyn_organizationalunit.md#BKMK_msdyn_msdyn_organizationalunit_bookableresource_organizationalunit)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`msdyn_organizationalunit`|
|ReferencingEntityNavigationPropertyName|`msdyn_OrganizationalUnit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_warehouse_bookableresource_Warehouse"></a> msdyn_msdyn_warehouse_bookableresource_Warehouse

One-To-Many Relationship: [msdyn_warehouse msdyn_msdyn_warehouse_bookableresource_Warehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_bookableresource_Warehouse)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`msdyn_warehouse`|
|ReferencingEntityNavigationPropertyName|`msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookableresource_account_PreferredResource](#BKMK_msdyn_bookableresource_account_PreferredResource)
- [msdyn_bookableresource_bookableresourcebooking_Crew](#BKMK_msdyn_bookableresource_bookableresourcebooking_Crew)
- [msdyn_bookableresource_bookableresourcebooking_ResourceGroup](#BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup)
- [msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid](#BKMK_msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid)
- [msdyn_bookableresource_msdyn_actual_bookableresource](#BKMK_msdyn_bookableresource_msdyn_actual_bookableresource)
- [msdyn_bookableresource_msdyn_agreementbookingdate_Resource](#BKMK_msdyn_bookableresource_msdyn_agreementbookingdate_Resource)
- [msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource](#BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource)
- [msdyn_bookableresource_msdyn_bookableresourceassociation_Resource1](#BKMK_msdyn_bookableresource_msdyn_bookableresourceassociation_Resource1)
- [msdyn_bookableresource_msdyn_bookableresourceassociation_Resource2](#BKMK_msdyn_bookableresource_msdyn_bookableresourceassociation_Resource2)
- [msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource](#BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource)
- [msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource](#BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource)
- [msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource](#BKMK_msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource)
- [msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource](#BKMK_msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource)
- [msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource](#BKMK_msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource)
- [msdyn_bookableresource_msdyn_resourceterritory_Resource](#BKMK_msdyn_bookableresource_msdyn_resourceterritory_Resource)
- [msdyn_bookableresource_msdyn_timeentry_bookableresource](#BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource)
- [msdyn_bookableresource_msdyn_timeoffrequest_Resource](#BKMK_msdyn_bookableresource_msdyn_timeoffrequest_Resource)
- [msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid](#BKMK_msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid)
- [msdyn_bookableresource_msdyn_workorder_PreferredResource](#BKMK_msdyn_bookableresource_msdyn_workorder_PreferredResource)
- [msdyn_bookableresource_msdyn_workorder_SupportContact](#BKMK_msdyn_bookableresource_msdyn_workorder_SupportContact)
- [msdyn_geofence_bookableresource](#BKMK_msdyn_geofence_bookableresource)

### <a name="BKMK_msdyn_bookableresource_account_PreferredResource"></a> msdyn_bookableresource_account_PreferredResource

Many-To-One Relationship: [account msdyn_bookableresource_account_PreferredResource](account.md#BKMK_msdyn_bookableresource_account_PreferredResource)

|Property|Value|
|---|---|
|ReferencingEntity|`account`|
|ReferencingAttribute|`msdyn_preferredresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_account_PreferredResource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_bookableresourcebooking_Crew"></a> msdyn_bookableresource_bookableresourcebooking_Crew

Many-To-One Relationship: [bookableresourcebooking msdyn_bookableresource_bookableresourcebooking_Crew](bookableresourcebooking.md#BKMK_msdyn_bookableresource_bookableresourcebooking_Crew)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`msdyn_crew`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_bookableresourcebooking_Crew`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup"></a> msdyn_bookableresource_bookableresourcebooking_ResourceGroup

Many-To-One Relationship: [bookableresourcebooking msdyn_bookableresource_bookableresourcebooking_ResourceGroup](bookableresourcebooking.md#BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`msdyn_resourcegroup`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_bookableresourcebooking_ResourceGroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid"></a> msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid

Many-To-One Relationship: [bookableresourcebookingheader msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid](bookableresourcebookingheader.md#BKMK_msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebookingheader`|
|ReferencingAttribute|`msdyn_bookableresourceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_actual_bookableresource"></a> msdyn_bookableresource_msdyn_actual_bookableresource

Many-To-One Relationship: [msdyn_actual msdyn_bookableresource_msdyn_actual_bookableresource](msdyn_actual.md#BKMK_msdyn_bookableresource_msdyn_actual_bookableresource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_bookableresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_actual_bookableresource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_agreementbookingdate_Resource"></a> msdyn_bookableresource_msdyn_agreementbookingdate_Resource

Many-To-One Relationship: [msdyn_agreementbookingdate msdyn_bookableresource_msdyn_agreementbookingdate_Resource](msdyn_agreementbookingdate.md#BKMK_msdyn_bookableresource_msdyn_agreementbookingdate_Resource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingdate`|
|ReferencingAttribute|`msdyn_resource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_agreementbookingdate_Resource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource"></a> msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource

Many-To-One Relationship: [msdyn_agreementbookingsetup msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource](msdyn_agreementbookingsetup.md#BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingsetup`|
|ReferencingAttribute|`msdyn_preferredresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_bookableresourceassociation_Resource1"></a> msdyn_bookableresource_msdyn_bookableresourceassociation_Resource1

Many-To-One Relationship: [msdyn_bookableresourceassociation msdyn_bookableresource_msdyn_bookableresourceassociation_Resource1](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresource_msdyn_bookableresourceassociation_Resource1)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`msdyn_resource1`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_bookableresourceassociation_Resource1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_bookableresourceassociation_Resource2"></a> msdyn_bookableresource_msdyn_bookableresourceassociation_Resource2

Many-To-One Relationship: [msdyn_bookableresourceassociation msdyn_bookableresource_msdyn_bookableresourceassociation_Resource2](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresource_msdyn_bookableresourceassociation_Resource2)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`msdyn_resource2`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_bookableresourceassociation_Resource2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource"></a> msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource

Many-To-One Relationship: [msdyn_inventoryadjustment msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource](msdyn_inventoryadjustment.md#BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustment`|
|ReferencingAttribute|`msdyn_adjustedbyresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource"></a> msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource

Many-To-One Relationship: [msdyn_inventoryadjustment msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource](msdyn_inventoryadjustment.md#BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustment`|
|ReferencingAttribute|`msdyn_requestedbyresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource"></a> msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource

Many-To-One Relationship: [msdyn_inventorytransfer msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource](msdyn_inventorytransfer.md#BKMK_msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventorytransfer`|
|ReferencingAttribute|`msdyn_transferredbyresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource"></a> msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource

Many-To-One Relationship: [msdyn_purchaseorder msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource](msdyn_purchaseorder.md#BKMK_msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`msdyn_requestedbyresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource"></a> msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource

Many-To-One Relationship: [msdyn_requirementresourcepreference msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource](msdyn_requirementresourcepreference.md#BKMK_msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`msdyn_bookableresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Resource Preferences<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_resourceterritory_Resource"></a> msdyn_bookableresource_msdyn_resourceterritory_Resource

Many-To-One Relationship: [msdyn_resourceterritory msdyn_bookableresource_msdyn_resourceterritory_Resource](msdyn_resourceterritory.md#BKMK_msdyn_bookableresource_msdyn_resourceterritory_Resource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`msdyn_resource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_resourceterritory_Resource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource"></a> msdyn_bookableresource_msdyn_timeentry_bookableresource

Many-To-One Relationship: [msdyn_timeentry msdyn_bookableresource_msdyn_timeentry_bookableresource](msdyn_timeentry.md#BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentry`|
|ReferencingAttribute|`msdyn_bookableresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_timeentry_bookableresource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_timeoffrequest_Resource"></a> msdyn_bookableresource_msdyn_timeoffrequest_Resource

Many-To-One Relationship: [msdyn_timeoffrequest msdyn_bookableresource_msdyn_timeoffrequest_Resource](msdyn_timeoffrequest.md#BKMK_msdyn_bookableresource_msdyn_timeoffrequest_Resource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeoffrequest`|
|ReferencingAttribute|`msdyn_resource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_timeoffrequest_Resource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid"></a> msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid

Many-To-One Relationship: [msdyn_workhourtemplate msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid](msdyn_workhourtemplate.md#BKMK_msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`msdyn_bookableresourceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_workorder_PreferredResource"></a> msdyn_bookableresource_msdyn_workorder_PreferredResource

Many-To-One Relationship: [msdyn_workorder msdyn_bookableresource_msdyn_workorder_PreferredResource](msdyn_workorder.md#BKMK_msdyn_bookableresource_msdyn_workorder_PreferredResource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_preferredresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_workorder_PreferredResource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookableresource_msdyn_workorder_SupportContact"></a> msdyn_bookableresource_msdyn_workorder_SupportContact

Many-To-One Relationship: [msdyn_workorder msdyn_bookableresource_msdyn_workorder_SupportContact](msdyn_workorder.md#BKMK_msdyn_bookableresource_msdyn_workorder_SupportContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_supportcontact`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_workorder_SupportContact`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_geofence_bookableresource"></a> msdyn_geofence_bookableresource

Many-To-One Relationship: [msdyn_geofence msdyn_geofence_bookableresource](msdyn_geofence.md#BKMK_msdyn_geofence_bookableresource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofence`|
|ReferencingAttribute|`msdyn_bookableresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_geofence_bookableresource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Bookable Resource<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

