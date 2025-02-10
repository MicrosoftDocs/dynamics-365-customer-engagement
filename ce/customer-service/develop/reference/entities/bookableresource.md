---
title: "Bookable Resource (BookableResource) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Bookable Resource (BookableResource) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Bookable Resource (BookableResource) table/entity reference (Microsoft Dynamics 365 Customer Service)

Resource that has capacity which can be allocated to work.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Bookable Resource (BookableResource) table extends the [Microsoft Dynamics 365 Bookable Resource (BookableResource) table](/dynamics365/developer/reference/entities/bookableresource).


## Messages

The following table lists the messages for the Bookable Resource (BookableResource) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `msdyn_GetResourceBookingDetails`<br />Event: True |**msdyn_GetResourceBookingDetails action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_DeriveCapacity](#BKMK_msdyn_DeriveCapacity)
- [msdyn_DisplayOnScheduleAssistant](#BKMK_msdyn_DisplayOnScheduleAssistant)
- [msdyn_DisplayOnScheduleBoard](#BKMK_msdyn_DisplayOnScheduleBoard)
- [msdyn_EnableAppointments](#BKMK_msdyn_EnableAppointments)
- [msdyn_EnableOutlookSchedules](#BKMK_msdyn_EnableOutlookSchedules)
- [msdyn_EndLocation](#BKMK_msdyn_EndLocation)
- [msdyn_facilityequipmentid](#BKMK_msdyn_facilityequipmentid)
- [msdyn_GenericType](#BKMK_msdyn_GenericType)
- [msdyn_OptimalCrewSize](#BKMK_msdyn_OptimalCrewSize)
- [msdyn_organizationalunit](#BKMK_msdyn_organizationalunit)
- [msdyn_PoolType](#BKMK_msdyn_PoolType)
- [msdyn_PrimaryEMail](#BKMK_msdyn_PrimaryEMail)
- [msdyn_StartLocation](#BKMK_msdyn_StartLocation)
- [msdyn_targetutilization](#BKMK_msdyn_targetutilization)

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

### <a name="BKMK_msdyn_facilityequipmentid"></a> msdyn_facilityequipmentid

|Property|Value|
|---|---|
|Description|**Unique identifier for Facility Equipment**|
|DisplayName|**Facility Equipment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_facilityequipmentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|equipment|

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


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_equipment_bookableresource_FacilityEquipmentId](#BKMK_msdyn_equipment_bookableresource_FacilityEquipmentId)
- [msdyn_msdyn_organizationalunit_bookableresource_organizationalunit](#BKMK_msdyn_msdyn_organizationalunit_bookableresource_organizationalunit)

### <a name="BKMK_msdyn_equipment_bookableresource_FacilityEquipmentId"></a> msdyn_equipment_bookableresource_FacilityEquipmentId

One-To-Many Relationship: [equipment msdyn_equipment_bookableresource_FacilityEquipmentId](equipment.md#BKMK_msdyn_equipment_bookableresource_FacilityEquipmentId)

|Property|Value|
|---|---|
|ReferencedEntity|`equipment`|
|ReferencedAttribute|`equipmentid`|
|ReferencingAttribute|`msdyn_facilityequipmentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_facilityequipmentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

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


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookableresource_bookableresourcebooking_ResourceGroup](#BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup)
- [msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid](#BKMK_msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid)
- [msdyn_bookableresource_msdyn_actual_bookableresource](#BKMK_msdyn_bookableresource_msdyn_actual_bookableresource)
- [msdyn_bookableresource_msdyn_bookableresourceassociation_Resource1](#BKMK_msdyn_bookableresource_msdyn_bookableresourceassociation_Resource1)
- [msdyn_bookableresource_msdyn_bookableresourceassociation_Resource2](#BKMK_msdyn_bookableresource_msdyn_bookableresourceassociation_Resource2)
- [msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource](#BKMK_msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource)
- [msdyn_bookableresource_msdyn_resourceterritory_Resource](#BKMK_msdyn_bookableresource_msdyn_resourceterritory_Resource)
- [msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid](#BKMK_msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid)

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

### <a name="BKMK_msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid"></a> msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid

Many-To-One Relationship: [msdyn_workhourtemplate msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid](msdyn_workhourtemplate.md#BKMK_msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`msdyn_bookableresourceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

