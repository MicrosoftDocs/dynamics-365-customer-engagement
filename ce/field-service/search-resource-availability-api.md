---
title: "Search resource availability API in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to use an API to find eligible resources in Field Service. 
ms.date: 08/04/2022
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: ryanchen8
ms.author: chenryan
search.app: 
  - D365CE
  - D365FS
---

# Search resource availability API

Field service organizations always have work coming in that needs to be scheduled, either by a service agent on the phone or directly by the customer through their website. Booking creation is typically based on the resources available to the company and the requirements of the work.

When using Dynamics 365 Field Service v8.8.43.51 and Universal Resource Scheduling v3.12.46.21 to schedule work, the `msdyn_SearchResourceAvailability` API can be used to retrieve all the eligible resources for the job, to allow for efficient scheduling of the work. At the time of writing, v3 is the latest version of msdyn_SearchResourceAvailability and supports web API calls. 

## Input parameters

| Name | Type | Description | Required | Default
| --- | --- | --- | --- | --- |
| Version | String | The version number of the API identifies the version of the API that should be invoked. It follows the format of major.minor.patch. The request doesn't have to contain the complete version number. <p> <li> If only a major version is specified, it invokes the highest minor and patch version available for that major version. <li> If both major and minor versions are specified, it invokes the highest patch version available. <li> If all three parts of the version are mentioned, it will invoke the exact version of the API specified.</ul>| Yes | -N/A-
| IsWebApi | Boolean | Set this to _True_ in order to use the SA via the web API. | Yes | -N/A-
| Requirement | Entity | This attribute specifies the resource requirement for which resource availability is being retrieved. This is expected to be a msdyn_resourcerequirement type entity. The requirement can be a pre-existing record from the database, or one created on the fly with the necessary constraints. The entity should contain all the specifics that are relevant for your search. The `@odata.type` for this entity should be `Microsoft.Dynamics.CRM.msdyn_requirement`. The following some important attributes to populate: <ol> <li>**msdyn_fromdate** (_DateTime_): Requirement's from date in ISO format <li> **msdyn_todate** (_DateTime_): Requirement's to date in ISO format <li> **msdyn_remainingduration** (_Integer_): The remaining duration of the requirement in minutes <li> **msdyn_duration** (_Integer_): The total duration of the requirement in minutes | Yes | -N/A-
| [Settings](#settings-entity) | Entity | The settings attribute helps to filter the retrieved resources further. Settings are specified as attributes in an entity bag. The type of entity does not matter, you can specify any entity logical name.  | Yes | -N/A-
| [ResourceSpecification](#resource-specification-entity) | Entity | The `resourceSpecification` attribute is defined as attributes in an entity bag. The `@odata.type` for this entity should be `Microsoft.Dynamics.CRM.expando`. | No | None |

### Settings entity
  
The settings entity is not an entity that exists in the Dataverse; however, it's a collection of all the following attributes that helps the schedule assistant API filter results. Thus, the `@odata.type` for this entity should be `Microsoft.Dynamics.CRM.expando`.

| Name | Type | Description | Required | Default
| --- | --- | --- | --- | --- |
| ConsiderSlotsWithLessThanRequiredCapacity | Boolean | Set this to _True_ if a time slot with less than the required capacity (effort) should be considered when computing potential available time slots on the resource's calendar. | No | False
| ConsiderSlotsWithLessThanRequiredDuration | Boolean | Set this to _True_ if a time slot with less than the required duration should be considered when computing potential available time slots on the resource's calendar. | No | False
| ConsiderSlotsWithOverlappingBooking | Boolean | Set this to _True_ if a time slot with overlapping bookings should be considered when computing potential available time slots on the resource's calendar. | No | False
| ConsiderSlotsWithProposedBookings | Boolean | Set this to _True_ if a time slot with proposed bookings should be considered when computing potential available time slots on the resource's calendar. | No | False
| ConsiderAppointments | Boolean | Set this to _True_ for search resource availability API to respect existing Dataverse appointments as bookings on the resource, provided the [organization and resource level settings have been set](appointment-scheduling.md). Appointments with statuses _Busy_ or _Completed_ will be considered as unavailable for scheduling operations. | No | False
| ConsiderTravelTime | Boolean | Set this to _True_ if travel time should be considered when computing potential time slots on the resource's calendar. | No | True
| MovePastStartDateToCurrentDate | Boolean | Set this to _True_ to move a start date in the past to the current date. | No | False
| UseRealTimeResourceLocation | Boolean | Set this to _True_ if the real-time location of resources should be used when computing potential time slots on the resource's calendar. | No | False
| SortOrder | Entity | The sort order can be specified using an entity collection. Each entity in the collection will represent one sort criteria. The `@odata.type` for this entity should be `Microsoft.Dynamics.CRM.expando`. The following are the attributes you need to populate: <ol> <li> **Name** (_String_): The sort criteria <li>**SortOrder** (_Integer_): The sort direction (0 for ascending and 1 for descending) | No | None
| MaxResourceTravelRadius | Entity | This attribute specifies the maximum that can be defined in an entity. The `@odata.type` for this entity should be `Microsoft.Dynamics.CRM.expando`. The following are the attributes you need to populate: <ol> <li> **Value** (_Decimal_): The radius <li> **Unit** (_Integer_): The distance unit. See msdyn_distance unit option set for possible values. | No| 0 km. If that's the case, no resources will be returned for onsite requirements.
| MaxNumberOfResourcesToEvaluate | Integer | This attribute defines a limit on the number of resources that are considered for the request. | No | Resource Availability Retrieval Limit from schedulable entity definition

### Resource specification entity

| Name | Type | Description | Required | Default
| --- | --- | --- | --- | --- |
| ResourceTypes | EntityCollection | This attribute specifies the resource type required for the requirement. It can be specified using an entity collection. Each entity in the collection will represent one bookable resource type. The `@odata.type` for this entity should be `Microsoft.Dynamics.CRM.msdyn_resourceType`. This is the attribute required: <ol> <li> **Value** (_Integer_): The option set value that represents the resource type: <ul> <li> 1- Generic <li> 2- Contact <li> 3- User <li> 4- Equipment <li> 5- Account <li> 6- Crew <li> 7- Facility <li> 8- Pools | No | All resource types except crews
| PreferredResources | EntityCollection | This attribute specifies the resources preferred for the requirement. Adding resources to this entity collection ensures that they are at the top of the list of available resources. Even resources that are not a part of the entity collection will be on the list, but only after the preferred resources. | No | None
| RestrictedResources | EntityCollection | This attribute specifies the resources that should not be considered for the requirement. All time slots of this resource will be filtered out of the list of results from this API.  | No| None
| MustChooseFromResources | EntityCollection | This attribute specifies the only resources that can be on the list of available resources. It will filter out all the other results from the output list.
| Constraints | Entity | This attribute specifies the additional constraints that should be applied to the retrieval of available resources. | No| None
| RetrieveResourcesQueryId | Guid | The Id for the Retrieve Resources query. | No| The default Retrieve Resource Query Id.
| BookedResourceId | Guid | This attribute specifies the resource currently booked for the requirement. | No| None

> [!Note] 
> The **Preferred**/ **Restricted** / **MustChooseFrom** resources attributes can be specified using an entity collection of bookable resource entities. Each entity in the collection will represent one **Preferred** / **Restricted** / **MustChooseFrom** resource. This is the attribute required for them: <ol> <li> **Value** (_Guid_): The bookable resource ID of the **Preferred** / **Restricted** / **MustChooseFrom** resource. The `@odata.type` for this entity should be `Microsoft.Dynamics.CRM.msdyn_bookableresource`.
  
#### Constraints

Additional constraints can be specified through attributes in this entity. The type of entity does not matter, you can specify any entity logical name.

Review the ‘Retrieve Resources Query’ on the schedule board settings to identify which constraints might apply. By default, it includes the following:

| Name | Type | Description |
| --- | --- | --- | 
| Characteristics | EntityCollection | A collection of characteristic IDs that a qualified resource must have. |
| Roles | EntityCollection | A collection of role IDs that a qualified resource must have. |
| Territories | EntityCollection | 	A collection of territory IDs. A qualified resource must be assigned to one of the territories. |
| UnspecifiedTerritory | Boolean | In combination with the territories constraint, specifies that a qualified must be assigned to one of the territories or no territory at all. |
| OrganizationalUnits | EntityCollection | A collection of organizational unit IDs. A qualified resource must be a member of one of the specified organizational units. |
| Teams | EntityCollection | A collection of team IDs. A qualified resource must belong to one of the teams (implies that the resource type is a system user).
| BusinessUnits | EntityCollection | A of collection of business unit IDs. A qualified resource must belong to one of the business units (implies that the resource is a system user). |

## Output parameters

At the highest level, the output has the following four parameters. The results are represented in entity collections and entities. Responses may not include all the attributes described here as null value or not NA values are omitted from the response. Always check for the presence of an attribute before trying to access it.

| Name | Type | Description |
| --- | --- | --- | 
| TimeSlots | EntityCollection | A collection of time slot results. See (time slot entity)[#time-slots-entity] section for more details. |
| Resources | EntityCollection | A collection of resource results. Resources are represented as a collection of entities with the following attributes: <ol> <li> **BookableResource** (_Entity_): The bookable resource entity that is available for the requirement. <li> **TotalAvailableTime** (_Double_): The total available time for the resource to perform the requirement. |
| Related | Entity | Related resources represent resources and time slots of resources that are not directly qualified for the requested requirement but are related. For example, if a crew member qualifies for a requirement, then the other members of that crew would be related results. <ol> <li> **Timeslots** (*EntityCollection*): Time slots of related resources. The definition of time slots is the same as described in the [time slots section](#time-slots-entity). <li> **Resources** (*EntityCollection*): The related resources. The definition of resources is the same as described in the resources attribute definition above. |
| Exceptions | Entity | This attribute contains information about any exception that occurred and information about if and where the resource search was truncated. <ol> <li> **Message** (_String_): Exception message <li> **ResourcesTruncatedAt** (_Integer_): If the number of resources exceeded the retrieval limit; the number where the resources where truncated. |

### Time slots entity

| Name | Type | Description |
| --- | --- | --- |
| ID | Guid | Unique identifier for the time slot | 
| Type | Integer | The type of time slot can be one of the following: <ul><li> **0**: Available <li> **1**: Scheduled <li> **2**: Off <li> **3**: Break |
| StartTime | DateTime | The start time of the time slot. If there is travel for the requirement, then this is the start time of travel. If not, this is the start time of the requirement. |
| ArrivalTime | DateTime | The arrival time of the time slot. If there is travel for the requirement, then this is the start time of requirement, after travel has been completed. If not, it is the same as the start time of the time slot. |
| EndTime | DateTime | The end time of the time slot. |
| Effort | Integer | The effort or capacity of the resource to carry out the requirements. |
| ResourceRequirement | EntityReference | The resource requirement for which time slots are being retrieved. |
| Potential | Boolean | A boolean value indicating if the time slot has potential to fulfill the requested requirement. |
| IsDuplicate | Boolean | A boolean value indicating if the time slot is a duplicate. |
| AllowOverlapping | Boolean | A boolean value indicating if overlapping is allowed. |
| Resource| Entity | The resource to which the time slot belongs. See [time slot resource](#time-slot-resource) for more information.|
| Location| Entity | The location has three attributes: <ol> <li> **Location** (_Entity_): It has two attributes - <ul> <li> Latitude <li> Longitude </ul> <li> **WorkLocation** (_Integer_): It has three attributes - <ul> <li> Onsite <li> Facility <li> Location Agnostic </ul> <li> **LocationSourceSlot** (_Integer_): The source of location information has three attributes - <ul> <li> Common <li> Custom GPS entity <li> Mobile audit </ul> |
| Travel| Entity | This entity contains details of travel time and distance information for a time slot. The following are the attributes: <ol> <li> **Distance** (_Double_): The travel distance <li> **TravelTime** (_Double_):	The travel time in minutes. <li> **DistanceFromStartLocation** (_Double_): The distance from the resource’s start location. <li> **DistanceFromEndLocation**	(_Double_):	The distance from the resource’s end location. <li> **DistanceMethodSourceSlot**	(_Integer_): The source / calculation type of the distance values <ul> <li> Map Service <li> As the crow flies </ul> |
| Next| Entity  | This entity contains details about the travel time and distance to the next time slot booking. <ol> <li> **NextScheduleLocation**	(_Entity_): The location of the next booking. The entity has two attributes: <ul> <li>Latitude <li>Longitude </ul> <li> **NextScheduleTravelTime** (_Integer_):	The travel time to the next booking in minutes. |
| Availability| Entity | The detailed availability information for a time slot. This is used in connection with time groups. <ol> <li> **AvailableIntervals**	(_EntityCollection_):	A collection of available intervals. Each entity in this collection contains details about a time group interval. <ul> <li> **StartTime**	(_DateTime_):	The start time.<li> **ArrivalTime**	(_DateTime_):	The arrival time.<li> **EndTime**	(_DateTime_):	The end time.<li> **TimeGroupId**	(_DateTime_):	The time group id.<li> **TimeGroupDetailStartTime**	(_DateTime_):	The time group start time. <li> **TimeGroupDetailEndTime**	(_DateTime_):	The time group end time.</ul> <li> **TotalAvailableDuration**	(_Double_):	The total available duration in minutes. <li> **TotalAvailableTime** (_Double_): The total available time a resource has in a day (in minutes).|
| TimeGroup| Entity | The details about a time group. <ol> <li> **TimeGroupId**	(_Guid_):	The time group Id. <li> **TimeGroupDetail**	(_EntityReference_):	An entity reference to the time group detail. <li> **TimeGroupDetailStartTime**	(_DateTime_):	The time group detail start time. <li> **TimeGroupDetailEndTime**	(_DateTime_):	The time group detail end time.|

#### Time slot resource

| Name | Type |	Description |
| --- | --- | --- |
| Resource |	EntityReference|	An entity reference to the bookable resource. |
| ResourceGroup |	EntityReference	| An entity reference to the bookable resource group. |
| BusinessUnit |	EntityReference	| An entity reference to the business unit. |
| OrganizationalUnit |	EntityReference|	An entity reference to the organizational unit.
| ResourceType |Integer|	The resource type. See the **ResourceType** attribute on the **BookableResource** entity for possible values. |
| PoolId |	Guid|	The ID of the pool that the resource is a member of for the duration of the time slot. |
| CrewId |	Guid|	The ID of the crew that the resource is a member of for the duration of the time slot. |
| Characteristics |	EntityCollection|	The bookable resource characteristics. Each entity in the collection contains entities with characteristics and rating information. <ol> <li> **Characteristic**	(_EntityReference_):	An entity reference to the characteristic. <li> **RatingId**	(_Guid_)	The rating Id for the characteristic. <li> **RatingName**	(_String_):	The rating name. <li> **RatingValue**	(_Integer_):	The rating value. |
| HasStartLocation |	Boolean|	A boolean value indicating if the resource has a start location. |
| HasEndLocation |	Boolean	|A boolean value indicating if the resource has an end location. |
| Email |	String	|The resource’s email address. |
| Phone |	String|	The resource’s phone number. |
| ImagePath |	String	|The path to the resource’s image. |
| CalendarId |	Guid	|The resource’s calendar ID. |

## Examples
  
In this example, v3 of schedule assistant API which allows for web API calls is being used for a requirement of duration 60 minutes. Using the settings attribute, the results are being filtered down. Two resource types are being considered for the final results: 1 and 2 (in other words, generic and contact). 

```
{
  
    "Version": "3",
  
    "IsWebApi": true,
  
    "Requirement": {
  
        "msdyn_fromdate": "2021-07-14T00:00:00Z",
  
        "msdyn_todate": "2021-07-15T23:59:00Z",
  
        "msdyn_remainingduration": 60,
  
        "msdyn_duration": 60,
  
        "@odata.type": "Microsoft.Dynamics.CRM.msdyn_resourcerequirement"
  
    },
  
    "Settings": {
  
        "ConsiderSlotsWithProposedBookings": false,
  
        "MovePastStartDateToCurrentDate": true,
  
        "@odata.type": "Microsoft.Dynamics.CRM.expando"
  
    },
  
    "ResourceSpecification": {
  
        "@odata.type": "Microsoft.Dynamics.CRM.expando",
  
        "ResourceTypes@odata.type": "Collection(Microsoft.Dynamics.CRM.expando)",
  
        "ResourceTypes": [
  
            {
  
                "@odata.type": "Microsoft.Dynamics.CRM.expando",
  
                "value": "1"
  
            },
  
            {
                "@odata.type": "Microsoft.Dynamics.CRM.expando",
  
                "value": "2"
  
            }
  
        ],
  
        "Constraints": {
  
            "@odata.type": "Microsoft.Dynamics.CRM.expando",
  
            "Characteristics@odata.type": "Collection(Microsoft.Dynamics.CRM.expando)",
  
            "Characteristics": [
  
                {
  
                    "@odata.type": "Microsoft.Dynamics.CRM.expando",
  
                    "value": "67387f9f-12e2-ec11-bb43-000d3aed25f7"
  
                }
  
            ]
  
        }
  
    }
  
}
```
