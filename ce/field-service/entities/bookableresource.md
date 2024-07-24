---
title: "Bookable Resource (BookableResource) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Bookable Resource (BookableResource) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Bookable Resource (BookableResource) table/entity reference

Resource that has capacity which can be allocated to work.

## Messages

The following table lists the messages for the Bookable Resource (BookableResource) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /bookableresources(*bookableresourceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /bookableresources<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /bookableresources(*bookableresourceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdyn_GetResourceBookingDetails`<br />Event: True |**msdyn_GetResourceBookingDetails action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /bookableresources(*bookableresourceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /bookableresources<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /bookableresources(*bookableresourceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /bookableresources(*bookableresourceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /bookableresources(*bookableresourceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Bookable Resource (BookableResource) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Bookable Resource** |
| **DisplayCollectionName** | **Bookable Resources** |
| **SchemaName** | `BookableResource` |
| **CollectionSchemaName** | `BookableResource` |
| **EntitySetName** | `bookableresources`|
| **LogicalName** | `bookableresource` |
| **LogicalCollectionName** | `bookableresources` |
| **PrimaryIdAttribute** | `bookableresourceid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AccountId](#BKMK_AccountId)
- [BookableResourceId](#BKMK_BookableResourceId)
- [CalendarId](#BKMK_CalendarId)
- [ContactId](#BKMK_ContactId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
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
- [msdyn_facilityequipmentid](#BKMK_msdyn_facilityequipmentid)
- [msdyn_GenericType](#BKMK_msdyn_GenericType)
- [msdyn_HourlyRate](#BKMK_msdyn_HourlyRate)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_locationtimestamp](#BKMK_msdyn_locationtimestamp)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_OptimalCrewSize](#BKMK_msdyn_OptimalCrewSize)
- [msdyn_OptimizeRoute](#BKMK_msdyn_OptimizeRoute)
- [msdyn_organizationalunit](#BKMK_msdyn_organizationalunit)
- [msdyn_PoolType](#BKMK_msdyn_PoolType)
- [msdyn_PrimaryEMail](#BKMK_msdyn_PrimaryEMail)
- [msdyn_resourcereasonnotscheduled](#BKMK_msdyn_resourcereasonnotscheduled)
- [msdyn_scheduleoutsideworkhours](#BKMK_msdyn_scheduleoutsideworkhours)
- [msdyn_StartLocation](#BKMK_msdyn_StartLocation)
- [msdyn_targetutilization](#BKMK_msdyn_targetutilization)
- [msdyn_TimeOffApprovalRequired](#BKMK_msdyn_TimeOffApprovalRequired)
- [msdyn_traveloutsideworkhourslimit](#BKMK_msdyn_traveloutsideworkhourslimit)
- [msdyn_Warehouse](#BKMK_msdyn_Warehouse)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ProcessId](#BKMK_ProcessId)
- [ResourceType](#BKMK_ResourceType)
- [StageId](#BKMK_StageId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZone](#BKMK_TimeZone)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TraversedPath](#BKMK_TraversedPath)
- [UserId](#BKMK_UserId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_AccountId"></a> AccountId

|Property|Value|
|---|---|
|Description|**Select the account that represents this resource.**|
|DisplayName|**Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`accountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_BookableResourceId"></a> BookableResourceId

|Property|Value|
|---|---|
|Description|**Unique identifier of the resource.**|
|DisplayName|**Bookable Resource**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`bookableresourceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_CalendarId"></a> CalendarId

|Property|Value|
|---|---|
|Description|**Specifies the working days and hours of the resource.**|
|DisplayName|**Calendar**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`calendarid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|calendar|

### <a name="BKMK_ContactId"></a> ContactId

|Property|Value|
|---|---|
|Description|**Select the contact that represents this resource.**|
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`contactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_BookingsToDrip"></a> msdyn_BookingsToDrip

|Property|Value|
|---|---|
|Description|**The number of bookings to drip on the Mobile . This field is disabled/enabled based on Enable Drip Scheduling field**|
|DisplayName|**Bookings To Drip**|
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
|192350000|**Cascade and Accept Cascade Completely (Not Recommended)**|
|192350001|**Crew Leader Management**|
|192350002|**Crew Member Self-Management**|

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

### <a name="BKMK_msdyn_OptimizeRoute"></a> msdyn_OptimizeRoute

|Property|Value|
|---|---|
|Description|**Indicates if a resource will be included in scheduling optimization.**|
|DisplayName|**Optimize Schedule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optimizeroute`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_bookableresource_msdyn_optimizeroute`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_msdyn_resourcereasonnotscheduled"></a> msdyn_resourcereasonnotscheduled

|Property|Value|
|---|---|
|Description|**Shows why this Bookable Resource is not scheduled by the resource scheduling optimization engine.**|
|DisplayName|**Reason Not Scheduled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resourcereasonnotscheduled`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_resourcereasonnotscheduled`|

#### msdyn_resourcereasonnotscheduled Choices/Options

|Value|Label|
|---|---|
|192350000|**None**|
|192350002|**Latitude Longitude Invalid**|
|192350004|**Start End Location Invalid**|
|192350005|**Organizational Unit Invalid**|
|192350006|**Organizational Unit Latitude Longitude Invalid**|
|192350007|**Resource is Location Agnostic**|
|192350008|**Optimization is not enabled for this resource**|

### <a name="BKMK_msdyn_scheduleoutsideworkhours"></a> msdyn_scheduleoutsideworkhours

|Property|Value|
|---|---|
|Description||
|DisplayName|**Schedule Outside Work Hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scheduleoutsideworkhours`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_allowscheduleoutsideworkhours`|

#### msdyn_scheduleoutsideworkhours Choices/Options

|Value|Label|
|---|---|
|192350000|**Allow Travel Before Work Hours**|
|192350001|**Allow Travel After Work Hours**|

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

### <a name="BKMK_msdyn_traveloutsideworkhourslimit"></a> msdyn_traveloutsideworkhourslimit

|Property|Value|
|---|---|
|Description|**Travel limit allowed outside work hours (in minutes)**|
|DisplayName|**Travel Limit (in minutes)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_traveloutsideworkhourslimit`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1440|
|MinValue|0|

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

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Type the name of the resource.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|---|---|
|Description|**Contains the id of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ResourceType"></a> ResourceType

|Property|Value|
|---|---|
|Description|**Select whether the resource is a user, equipment, contact, account, generic resource or a group of resources.**|
|DisplayName|**Resource Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resourcetype`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|3|
|GlobalChoiceName|`bookableresource_resourcetype`|

#### ResourceType Choices/Options

|Value|Label|
|---|---|
|1|**Generic**|
|2|**Contact**|
|3|**User**|
|4|**Equipment**|
|5|**Account**|
|6|**Crew**|
|7|**Facility**|
|8|**Pool**|

### <a name="BKMK_StageId"></a> StageId

|Property|Value|
|---|---|
|Description|**Contains the id of the stage where the entity is located.**|
|DisplayName|**(Deprecated) Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|---|---|
|Description|**Status of the Bookable Resource**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`bookableresource_statecode`|

#### StateCode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Bookable Resource**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`bookableresource_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZone"></a> TimeZone

|Property|Value|
|---|---|
|Description|**Specifies the timezone for the resource's working hours.**|
|DisplayName|**Time Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`timezone`|
|RequiredLevel|SystemRequired|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the BookableResource with respect to the base currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|---|---|
|Description|**A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.**|
|DisplayName|**(Deprecated) Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

### <a name="BKMK_UserId"></a> UserId

|Property|Value|
|---|---|
|Description|**Select the user who represents this resource.**|
|DisplayName|**User**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`userid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_hourlyrate_Base](#BKMK_msdyn_hourlyrate_Base)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the bookableresource with respect to the base currency.**|
|DisplayName|**ExchangeRate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [account_bookableresource_AccountId](#BKMK_account_bookableresource_AccountId)
- [business_unit_bookableresource](#BKMK_business_unit_bookableresource)
- [calendar_bookableresources](#BKMK_calendar_bookableresources)
- [contact_bookableresource_ContactId](#BKMK_contact_bookableresource_ContactId)
- [lk_bookableresource_createdby](#BKMK_lk_bookableresource_createdby)
- [lk_bookableresource_createdonbehalfby](#BKMK_lk_bookableresource_createdonbehalfby)
- [lk_bookableresource_modifiedby](#BKMK_lk_bookableresource_modifiedby)
- [lk_bookableresource_modifiedonbehalfby](#BKMK_lk_bookableresource_modifiedonbehalfby)
- [msdyn_equipment_bookableresource_FacilityEquipmentId](#BKMK_msdyn_equipment_bookableresource_FacilityEquipmentId)
- [msdyn_msdyn_organizationalunit_bookableresource_organizationalunit](#BKMK_msdyn_msdyn_organizationalunit_bookableresource_organizationalunit)
- [msdyn_msdyn_warehouse_bookableresource_Warehouse](#BKMK_msdyn_msdyn_warehouse_bookableresource_Warehouse)
- [owner_bookableresource](#BKMK_owner_bookableresource)
- [processstage_BookableResource](#BKMK_processstage_BookableResource)
- [systemuser_bookableresource_UserId](#BKMK_systemuser_bookableresource_UserId)
- [team_bookableresource](#BKMK_team_bookableresource)
- [TransactionCurrency_bookableresource](#BKMK_TransactionCurrency_bookableresource)
- [user_bookableresource](#BKMK_user_bookableresource)

### <a name="BKMK_account_bookableresource_AccountId"></a> account_bookableresource_AccountId

One-To-Many Relationship: [account account_bookableresource_AccountId](account.md#BKMK_account_bookableresource_AccountId)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`accountid`|
|ReferencingEntityNavigationPropertyName|`AccountId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_business_unit_bookableresource"></a> business_unit_bookableresource

One-To-Many Relationship: [businessunit business_unit_bookableresource](businessunit.md#BKMK_business_unit_bookableresource)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_calendar_bookableresources"></a> calendar_bookableresources

One-To-Many Relationship: [calendar calendar_bookableresources](calendar.md#BKMK_calendar_bookableresources)

|Property|Value|
|---|---|
|ReferencedEntity|`calendar`|
|ReferencedAttribute|`calendarid`|
|ReferencingAttribute|`calendarid`|
|ReferencingEntityNavigationPropertyName|`calendarid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contact_bookableresource_ContactId"></a> contact_bookableresource_ContactId

One-To-Many Relationship: [contact contact_bookableresource_ContactId](contact.md#BKMK_contact_bookableresource_ContactId)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`contactid`|
|ReferencingEntityNavigationPropertyName|`ContactId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_bookableresource_createdby"></a> lk_bookableresource_createdby

One-To-Many Relationship: [systemuser lk_bookableresource_createdby](systemuser.md#BKMK_lk_bookableresource_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_bookableresource_createdonbehalfby"></a> lk_bookableresource_createdonbehalfby

One-To-Many Relationship: [systemuser lk_bookableresource_createdonbehalfby](systemuser.md#BKMK_lk_bookableresource_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_bookableresource_modifiedby"></a> lk_bookableresource_modifiedby

One-To-Many Relationship: [systemuser lk_bookableresource_modifiedby](systemuser.md#BKMK_lk_bookableresource_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_bookableresource_modifiedonbehalfby"></a> lk_bookableresource_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_bookableresource_modifiedonbehalfby](systemuser.md#BKMK_lk_bookableresource_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfbyname`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

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

### <a name="BKMK_owner_bookableresource"></a> owner_bookableresource

One-To-Many Relationship: [owner owner_bookableresource](owner.md#BKMK_owner_bookableresource)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_BookableResource"></a> processstage_BookableResource

One-To-Many Relationship: [processstage processstage_BookableResource](processstage.md#BKMK_processstage_BookableResource)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_systemuser_bookableresource_UserId"></a> systemuser_bookableresource_UserId

One-To-Many Relationship: [systemuser systemuser_bookableresource_UserId](systemuser.md#BKMK_systemuser_bookableresource_UserId)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`userid`|
|ReferencingEntityNavigationPropertyName|`UserId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_bookableresource"></a> team_bookableresource

One-To-Many Relationship: [team team_bookableresource](team.md#BKMK_team_bookableresource)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_bookableresource"></a> TransactionCurrency_bookableresource

One-To-Many Relationship: [transactioncurrency TransactionCurrency_bookableresource](transactioncurrency.md#BKMK_TransactionCurrency_bookableresource)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_bookableresource"></a> user_bookableresource

One-To-Many Relationship: [systemuser user_bookableresource](systemuser.md#BKMK_user_bookableresource)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [bookableresource_Annotations](#BKMK_bookableresource_Annotations)
- [bookableresource_AsyncOperations](#BKMK_bookableresource_AsyncOperations)
- [bookableresource_bookableresourcebooking_Resource](#BKMK_bookableresource_bookableresourcebooking_Resource)
- [bookableresource_bookableresourcecategoryassn_Resource](#BKMK_bookableresource_bookableresourcecategoryassn_Resource)
- [bookableresource_bookableresourcecharacteristic_Resource](#BKMK_bookableresource_bookableresourcecharacteristic_Resource)
- [bookableresource_bookableresourcegroup_ChildResource](#BKMK_bookableresource_bookableresourcegroup_ChildResource)
- [bookableresource_bookableresourcegroup_ParentResource](#BKMK_bookableresource_bookableresourcegroup_ParentResource)
- [bookableresource_BulkDeleteFailures](#BKMK_bookableresource_BulkDeleteFailures)
- [bookableresource_DuplicateBaseRecord](#BKMK_bookableresource_DuplicateBaseRecord)
- [bookableresource_DuplicateMatchingRecord](#BKMK_bookableresource_DuplicateMatchingRecord)
- [bookableresource_MailboxTrackingFolders](#BKMK_bookableresource_MailboxTrackingFolders)
- [bookableresource_PrincipalObjectAttributeAccess](#BKMK_bookableresource_PrincipalObjectAttributeAccess)
- [bookableresource_ProcessSession](#BKMK_bookableresource_ProcessSession)
- [BookableResource_SyncErrors](#BKMK_BookableResource_SyncErrors)
- [msdyn_bookableresource_account_PreferredResource](#BKMK_msdyn_bookableresource_account_PreferredResource)
- [msdyn_bookableresource_bookableresourcebooking_Crew](#BKMK_msdyn_bookableresource_bookableresourcebooking_Crew)
- [msdyn_bookableresource_bookableresourcebooking_ResourceGroup](#BKMK_msdyn_bookableresource_bookableresourcebooking_ResourceGroup)
- [msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid](#BKMK_msdyn_bookableresource_bookableresourcebookingheader_bookableresourceid)
- [msdyn_bookableresource_msdyn_actual_bookableresource](#BKMK_msdyn_bookableresource_msdyn_actual_bookableresource)
- [msdyn_bookableresource_msdyn_agreementbookingdate_Resource](#BKMK_msdyn_bookableresource_msdyn_agreementbookingdate_Resource)
- [msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource](#BKMK_msdyn_bookableresource_msdyn_agreementbookingsetup_PreferredResource)
- [msdyn_bookableresource_msdyn_bookableresourceassociation_Resource1](#BKMK_msdyn_bookableresource_msdyn_bookableresourceassociation_Resource1)
- [msdyn_bookableresource_msdyn_bookableresourceassociation_Resource2](#BKMK_msdyn_bookableresource_msdyn_bookableresourceassociation_Resource2)
- [msdyn_bookableresource_msdyn_bookableresourcecapacityprofile](#BKMK_msdyn_bookableresource_msdyn_bookableresourcecapacityprofile)
- [msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource](#BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_AdjustedByResource)
- [msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource](#BKMK_msdyn_bookableresource_msdyn_inventoryadjustment_RequestedByResource)
- [msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource](#BKMK_msdyn_bookableresource_msdyn_inventorytransfer_TransferredByResource)
- [msdyn_bookableresource_msdyn_optimizationrequestresource_BookableResource](#BKMK_msdyn_bookableresource_msdyn_optimizationrequestresource_BookableResource)
- [msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource](#BKMK_msdyn_bookableresource_msdyn_purchaseorder_RequestedByResource)
- [msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource](#BKMK_msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource)
- [msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource](#BKMK_msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource)
- [msdyn_bookableresource_msdyn_resourceterritory_Resource](#BKMK_msdyn_bookableresource_msdyn_resourceterritory_Resource)
- [msdyn_bookableresource_msdyn_timeentry_bookableresource](#BKMK_msdyn_bookableresource_msdyn_timeentry_bookableresource)
- [msdyn_bookableresource_msdyn_timeoffrequest_Resource](#BKMK_msdyn_bookableresource_msdyn_timeoffrequest_Resource)
- [msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid](#BKMK_msdyn_bookableresource_msdyn_workhourtemplate_bookableresourceid)
- [msdyn_bookableresource_msdyn_workorder_PreferredResource](#BKMK_msdyn_bookableresource_msdyn_workorder_PreferredResource)
- [msdyn_bookableresource_msdyn_workorder_SupportContact](#BKMK_msdyn_bookableresource_msdyn_workorder_SupportContact)
- [msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource](#BKMK_msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource)
- [msdyn_geofence_bookableresource](#BKMK_msdyn_geofence_bookableresource)

### <a name="BKMK_bookableresource_Annotations"></a> bookableresource_Annotations

Many-To-One Relationship: [annotation bookableresource_Annotations](annotation.md#BKMK_bookableresource_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`bookableresource_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresource_AsyncOperations"></a> bookableresource_AsyncOperations

Many-To-One Relationship: [asyncoperation bookableresource_AsyncOperations](asyncoperation.md#BKMK_bookableresource_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresource_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresource_bookableresourcebooking_Resource"></a> bookableresource_bookableresourcebooking_Resource

Many-To-One Relationship: [bookableresourcebooking bookableresource_bookableresourcebooking_Resource](bookableresourcebooking.md#BKMK_bookableresource_bookableresourcebooking_Resource)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`resource`|
|ReferencedEntityNavigationPropertyName|`bookableresource_bookableresourcebooking_Resource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: null<br />ViewId: `9b2c044a-2553-43f0-a816-9ffe35475f85`|

### <a name="BKMK_bookableresource_bookableresourcecategoryassn_Resource"></a> bookableresource_bookableresourcecategoryassn_Resource

Many-To-One Relationship: [bookableresourcecategoryassn bookableresource_bookableresourcecategoryassn_Resource](bookableresourcecategoryassn.md#BKMK_bookableresource_bookableresourcecategoryassn_Resource)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecategoryassn`|
|ReferencingAttribute|`resource`|
|ReferencedEntityNavigationPropertyName|`bookableresource_bookableresourcecategoryassn_Resource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 30<br />QueryApi: null<br />ViewId: `23c06e71-0606-4ca5-8047-38ffc0006240`|

### <a name="BKMK_bookableresource_bookableresourcecharacteristic_Resource"></a> bookableresource_bookableresourcecharacteristic_Resource

Many-To-One Relationship: [bookableresourcecharacteristic bookableresource_bookableresourcecharacteristic_Resource](bookableresourcecharacteristic.md#BKMK_bookableresource_bookableresourcecharacteristic_Resource)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecharacteristic`|
|ReferencingAttribute|`resource`|
|ReferencedEntityNavigationPropertyName|`bookableresource_bookableresourcecharacteristic_Resource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 20<br />QueryApi: null<br />ViewId: `0b0e5358-7725-49c7-8772-76904de77703`|

### <a name="BKMK_bookableresource_bookableresourcegroup_ChildResource"></a> bookableresource_bookableresourcegroup_ChildResource

Many-To-One Relationship: [bookableresourcegroup bookableresource_bookableresourcegroup_ChildResource](bookableresourcegroup.md#BKMK_bookableresource_bookableresourcegroup_ChildResource)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcegroup`|
|ReferencingAttribute|`childresource`|
|ReferencedEntityNavigationPropertyName|`bookableresource_bookableresourcegroup_ChildResource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 50<br />QueryApi: null<br />ViewId: `efb3fdd1-bb79-45a6-b68a-3ed5a83ebd36`|

### <a name="BKMK_bookableresource_bookableresourcegroup_ParentResource"></a> bookableresource_bookableresourcegroup_ParentResource

Many-To-One Relationship: [bookableresourcegroup bookableresource_bookableresourcegroup_ParentResource](bookableresourcegroup.md#BKMK_bookableresource_bookableresourcegroup_ParentResource)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcegroup`|
|ReferencingAttribute|`parentresource`|
|ReferencedEntityNavigationPropertyName|`bookableresource_bookableresourcegroup_ParentResource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 40<br />QueryApi: null<br />ViewId: `efb3fdd1-bb79-45a6-b68a-3ed5a83ebd36`|

### <a name="BKMK_bookableresource_BulkDeleteFailures"></a> bookableresource_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure bookableresource_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookableresource_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresource_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresource_DuplicateBaseRecord"></a> bookableresource_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord bookableresource_DuplicateBaseRecord](duplicaterecord.md#BKMK_bookableresource_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`bookableresource_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresource_DuplicateMatchingRecord"></a> bookableresource_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord bookableresource_DuplicateMatchingRecord](duplicaterecord.md#BKMK_bookableresource_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`bookableresource_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresource_MailboxTrackingFolders"></a> bookableresource_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder bookableresource_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookableresource_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresource_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresource_PrincipalObjectAttributeAccess"></a> bookableresource_PrincipalObjectAttributeAccess

Many-To-One Relationship: [principalobjectattributeaccess bookableresource_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_bookableresource_PrincipalObjectAttributeAccess)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`bookableresource_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bookableresource_ProcessSession"></a> bookableresource_ProcessSession

Many-To-One Relationship: [processsession bookableresource_ProcessSession](processsession.md#BKMK_bookableresource_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`bookableresource_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_BookableResource_SyncErrors"></a> BookableResource_SyncErrors

Many-To-One Relationship: [syncerror BookableResource_SyncErrors](syncerror.md#BKMK_BookableResource_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`BookableResource_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

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

### <a name="BKMK_msdyn_bookableresource_msdyn_bookableresourcecapacityprofile"></a> msdyn_bookableresource_msdyn_bookableresourcecapacityprofile

Many-To-One Relationship: [msdyn_bookableresourcecapacityprofile msdyn_bookableresource_msdyn_bookableresourcecapacityprofile](msdyn_bookableresourcecapacityprofile.md#BKMK_msdyn_bookableresource_msdyn_bookableresourcecapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcecapacityprofile`|
|ReferencingAttribute|`msdyn_bookableresourceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_bookableresourcecapacityprofile`|
|IsCustomizable|`False`|
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

### <a name="BKMK_msdyn_bookableresource_msdyn_optimizationrequestresource_BookableResource"></a> msdyn_bookableresource_msdyn_optimizationrequestresource_BookableResource

Many-To-One Relationship: [msdyn_optimizationrequestresource msdyn_bookableresource_msdyn_optimizationrequestresource_BookableResource](msdyn_optimizationrequestresource.md#BKMK_msdyn_bookableresource_msdyn_optimizationrequestresource_BookableResource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequestresource`|
|ReferencingAttribute|`msdyn_bookableresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_optimizationrequestresource_BookableResource`|
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

### <a name="BKMK_msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource"></a> msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource

Many-To-One Relationship: [msdyn_quotebookingsetup msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource](msdyn_quotebookingsetup.md#BKMK_msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingsetup`|
|ReferencingAttribute|`msdyn_preferredresource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource`|
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

### <a name="BKMK_msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource"></a> msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource

Many-To-One Relationship: [msdyn_workorderresourcerestriction msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource](msdyn_workorderresourcerestriction.md#BKMK_msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresourcerestriction`|
|ReferencingAttribute|`msdyn_resource`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookableresource_msdyn_workorderresourcerestriction_Resource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

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

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

