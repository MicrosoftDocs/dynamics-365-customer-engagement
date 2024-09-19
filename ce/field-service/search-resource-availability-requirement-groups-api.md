---
title: Search for resource availability and create bookings for requirement groups
description: Learn how to use an API to find available resources and create bookings for requirement groups. 
ms.date: 09/19/2024
ms.topic: reference
author: mkelleher
ms.author: mkelleher
---

# Search for resource availability and create bookings for requirement groups

Use the *Search Resource Availability for Requirement Group API* and the *Create Requirement Group Bookings API* to book the resources that meet the needs you identify in your requirement groups.

- The [Search Resource Availability for Requirement Group API](#search-resource-availability-for-requirement-group-api) returns available time slots for resources when you search by using requirement groups.
- The [Create Requirement Group Bookings API](#create-requirement-group-bookings-api) uses the available time slots for resources to generate booking records for your requirement groups.

You pass the details of a requirement group in your API calls and retrieve a list of available resources and their open time slots. This list is helpful for self-scheduling scenarios where a user wants to view the availability of resources, or for portal scheduling scenarios where a customer wants to view resource availability from a website or app.

## Search Resource Availability for Requirement Group API

Use the following input and output parameters for the Search Resource Availability for Requirement Group (**msdyn_SearchResourceAvailabilityForRequirementGroup**) API.

### Parameters

| Name  | Type | Required  | Description  |
|-----------------|---|---|---|
|Version | String | Yes |The version number of the API. The version number identifies the version of the API that should be invoked. The version number is a semantic version number of the format major.minor.patch. The request doesn't have to contain the complete version number.|
|RequirementGroup | | Yes | An entity reference to the requirement group entity.|
|RequirementSpecification |Integer| No | If left null, respects the targeting requirement group duration by default.|
|Settings |`Entity<InputSettings>` |No | Sets the settings for the request.|

### Input

| Name  | Type | Required  | Description  |
|-------|---|---|---|
| ConsiderSlotsWithLessThanRequiredDuration | Boolean | No | Specifies if a time slot with less than the required remaining duration should be considered when computing potential time slots. It's false by default. |
| ConsiderSlotsWithOverlappingBooking | Boolean | No | Specifies if time slots with overlapping bookings should be considered when computing potential time slots. It's false by default. 
| ConsiderSlotsWithProposedBooking | Boolean | No | Specifies if time slots with proposed bookings should be considered when computing potential time slots. It's false by default. |
| MaxResourceTravelRadius | Distance | No | Specifies the maximum travel radius for resources when computing available time slots. |
| SortOrder | Integer | No | Specifies the requirement group order for the response. |
| PageSize |Integer | No | Numbers of item returned in a page. It's 20 by default. |
| PagingCookie | String | No | Paging cookie retrieved from previous searching result.|
| OrganizationUnits |List&#60;Guid&#62; | No | A collection of organization unit IDs. A qualified resource must be a member of one of the specified organization units. |
| MustChooseFromResources |List&#60;Guid&#62; | No | Evaluate and select results from resources in this list. |
| RequiredResources |List&#60;Guid&#62; | No | Evaluate all resources, filter the results based on this list. In general, use MustChooseFromResources instead for improved performance. |
| IgnoreTimeSlots | Boolean | No | Specifies if the returned time slots should be ignored. When true, list of time slots returned is empty. It's false by default. |
| ConsiderAppointments | Boolean | Set to True for search resource availability API to respect existing Dataverse appointments as bookings on the resource, provided the organization and resource level settings are set. Appointments with busy or completed statuses are considered as unavailable for scheduling operations. |

### Output

|Returns | Name(Type)  | Description |
|---|---|---|
|TimeSlots (List&#60;OutputTimeSlot&#62;)   |StartTime (DateTime) | The start time.|
|         |EndTime (DateTime)                    |The end time.|
|         |ArrivalTime (DateTime)                |The arrival time.|
|         |Travel(OutputTimeSlotTravel)<br><br>OutputTimeSlotTravel<br><ul><li>Distance (Double)<br><li>TravelTime (Double)<br><li>DistanceFromStartLocation (Double)<br><li>TravelTimeToEndLocation (Double)<br></ul>    |The time slot travel information. Is only present if the resource requirement contains values for latitude and longitude.|
|         |Effort (Double)                       |The effort/capacity.|
|         |IsDuplicate (Boolean)                 |A Boolean value indicating if the time slot is a duplicate.|
|         |Resource(OutputResource)<br><br>OutputResource<br><ul><li>Resource (BookableResource)<br><li>TotalAvailableTime (Double)<br></ul> |The Resource entity as explained in this article. |
|         |Location(OutputTimeSlotLocation)<br><br>OutputTimeSlotLocation:<br><ul><li>WorkLocation (Enum):<br><ul><li>Onsite (0)<br><li>Facility (1)<br><li>Location agnostic (2)</ul><br><li>LocationSourceSlot (Enum):<br><ul><li>Common (1)<br><li>Custom GPS entity (2)<br><li>Mobile audit (3)</ul> |The entity contains details about the location of a time slot. For more information, see TimeSlotLocation in this article. |
|         |TimeGroup(TimeSlotTimeGroup)<br><br>OutputTimeSlotTimeGroup:<br><ul><li>TimeGroupId (Guid)<br><li>TimeGroupDetail (EntityReference)<br><li>TimeGroupDetailStartTime (DateTime)<br><li>TimeGroupDetailEndTime (DateTime)</ul>  |The entity contains details about a time group. For more information, Refer to TimeSlotTimeGroup in this article. |
|         |AvailableIntervals (`List<<Guide>OutputTimeSlot>`)|A collection of available intervals.|
|Resources (List&#60;OutputResource&#62;)  |Resource (EntityReference)|An entity reference to the bookable resource.|
|         |BusinessUnit (EntityReference) |An entity reference to the bookable resource group.|
|         |OrganizationalUnit (EntityReference) |An entity reference to the organizational unit.|
|         |ResourceType (Int)                 |The resource type. Refer to the resourcetype attribute on the BookableResource entity for possible values.|
|         |PoolId (Guid)                      |The ID of the pool that the resource is a member of during the time slot.|
|         |CrewId (Guid)                      |The ID of the crew that the resource is a member of during the time slot.|
|         |Email (String)                     |The resource’s email address.|
|         |Phone (String)                     |The resource’s phone number.|
|         |ImagePath (String)                 |The path to the resource’s image.|
|Requirements (List&#60;OutputRequirements&#62;) |Requirement (EntityReference)   |An entity reference to the Resource Requirement record.|
|            |ConstraintBag (String)           |Requirement constraint in ufx bag(internal)|
|            |Resources (`List<<EntityReference>EntityReference>`)   |Entity reference list of resource that is available to the requirements.|
|ProposalResourceAssignmentSets (List&#60;OutputProposalResourceAssignmentSet&#62;) |IntervalStart (DateTime)|Start time for each proposal resource assignment set.|
|   |ProposalResourceAssignments (List&#60;OutputProposalResourceAssignments&#62;<br><br>OutputProposalResourceAssignments:<br><ul><li>RequirementId (Guid)<br><li>ResourceId (Guid)</ul> |List of Resources assigned to Requirement.|
|PagingInfos (OutputPagingInfo)  |MoreResults (Boolean)|If there are more results or not.|
|            |PagingCookie (String)|Paging cookie that can be used in the future search.|

### Example payload

```json
{
  "RequestName": "msdyn_SearchResourceAvailabilityForRequirementGroup",
  "Parameters": [
    {
      "Key": "Version",
      "Value": "1"
    },
    {
      "Key": "RequirementGroup",
      "Value": {
        "Id": "6927721a-0137-42be-8092-26995625a9d9",
        "LogicalName": "msdyn_requirementgroup",
        "Name": null,
        "KeyAttributes": [],
        "RowVersion": null
      }
    }
  ],
  "RequestId": null
}
```
### Example response

```json
{
  "ResponseName": "msdyn_SearchResourceAvailabilityForRequirementGroup",
  "Results": [
    {
      "Key": "TimeSlots",
      "Value": {....}
    },
    {
      "Key": "Requirements",
      "Value": {....}
    },
    {
      "Key": "ProposalResourceAssignmentSets",
      "Value": {....}
    },
    {
      "Key": "PagingInfos",
      "Value": {....}
    }]
}
```

## Create Requirement Group Bookings API

Use the following input and output parameters for the Create Requirement Group Bookings (**msdyn_CreateRequirementGroupBookings**) API.

### Parameters

|  Name   | Type  | Required | Description   |
|-----------------|-----------------|---|---------|
|Version | String | Yes | The version number of the API. The version number identifies the version of the API that should be invoked. The version number is a semantic version number of the format major.minor.patch. The request doesn't have to contain the complete version number.|
|RequirementGroup | EntityReference  |Yes | An entity reference to the requirement group entity, usually is a GUID, as shown in the following sample.|
|Start |DateTime | Yes | Start time of the Timeslot. |
|Duration | Integer | Yes  | The Duration of the Booking to be created.|
|ResourceAssignments | EntityCollection | Yes| It's an entity collection of the Resource Assignments that are to be made for the Bookings to be created. Look at the Resource Assignment entity table for more details |

**Resource Assignments**

|  Name   | Type  | Required | Description   |
|---------------------|-------------|---|---------|
|RequirementId | 	Guid|	Yes|	The resource requirement ID of the Requirement for which the booking record is to be created. |
|ResourceId  | Guid    | Yes | The bookable resource ID of the Resource for which you want to create the booking. |
| BookingStatusId  | Guid  | Yes | The booking status ID of the booking to be created. |
| Effort | Integer  |  No| The capacity of the Bookable Resource that this booking consumes.|
| TravelTime | Integer  | No| The travel time in minutes.|

### Output 

Returns `HandlerExecuted` that is of Boolean type.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]