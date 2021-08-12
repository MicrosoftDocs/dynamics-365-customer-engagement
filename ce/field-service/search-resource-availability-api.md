---
title: "Search resource availability API in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to use an API to find eligible resources in Field Service. 
ms.date: 08/11/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-field-service
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Search resource availability API

Field service organizations always have work coming in that needs to be scheduled, either by a service agent on the phone or directly by the customer through their website. Booking creation is typically based on the resources available to the company and the requirements of the work.

////////****** EDITING NOTE: MAKE SURE TO GET VERSION NUMBERS *********///////

When using Dynamics 365 Field Service (vX) and Universal Resource Scheduling (vY) to schedule work, the `msdyn_SearchResourceAvailability` API can be used to retrieve all the eligible resources for the job, to allow for efficient scheduling of the work.

## Input parameters

| Name | Type | Description | Required | 
| --- | --- | --- | --- | 
| Version | String | The version number of the API identifies the version of the API that should be invoked. It follows the format of major.minor.patch. The request doesn't have to contain the complete version number. <p> <li> If only a major version is specified, it invokes the highest minor and patch version available for that major version. <li> If both major and minor versions are specified, it invokes the highest patch version available. <li> If all three parts of the version are mentioned, it will invoke the exact version of the API specified.</ul>| Yes | 
| IsWebApi | Boolean | Set this to _True_ in order to use the SA via the web API. | Yes |
| Requirement | Entity | This attribute specifies the resource requirement for which resource availability is being retrieved. This is expected to be a msdyn_resourcerequirement type entity. The requirement can be a pre-existing record from the database, or one created on the fly with the necessary constraints. The entity should contain all the specifics that are relevant for your search. The following some important attributes to populate: <ol> <li>**msdyn_fromdate** (_Datetime_): Requirement's from date in ISO format <li> **msdyn_todate** (_Datetime_): Requirement's to date in ISO format <li> **msdyn_remainingduration** (_Integer_): The remaining duration of the requirement in minutes <li> **msdyn_duration** (_Integer_): The total duration of the requirement in minutes | Yes |
| Settings | Entity | The [settings attribute](#settings-entity) helps to filter the retrieved resources further. Settings are specified as attributes in an entity bag. The type of entity does not matter, you can specify any entity logical name.  | Yes |
| ResourceSpecification | Entity | The [resourceSpecification attribute](#resource-specification-entity) is defined as attributes in an entity bag. The type of entity does not matter, you can specify any entity logical name. | No |

### Settings entity

| Name | Type | Description | Required | 
| --- | --- | --- | --- |
| ConsiderSlotsWithLessThanRequiredCapacity | Boolean | Set this to _True_ if a time slot with less than the required capacity (effort) should be considered when computing potential available time slots on the resource's calendar.
| ConsiderSlotsWithLessThanRequiredDuration | Boolean | Set this to _True_ if a time slot with less than the required duration should be considered when computing potential available time slots on the resource's calendar.
| ConsiderSlotsWithOverlappingBooking | Boolean | Set this to _True_ if a time slot with overlapping bookings should be considered when computing potential available time slots on the resource's calendar.
| ConsiderSlotsWithProposedBookings | Boolean | Set this to _True_ if a time slot with proposed bookings should be considered when computing potential available time slots on the resource's calendar.
| ConsiderTravelTime | Boolean | Set this to _True_ if travel time should be considered when computing potential time slots on the resource's calendar.
| MovePastStartDateToCurrentDate | Boolean | Set this to _True_ to move a start date in the past to the current date.
| UseRealTimeResourceLocation | Boolean | Set this to _True_ if the real-time location of resources should be used when computing potential time slots on the resource's calendar.
| SortOrder | Entity | The sort order can be specified using an entity collection. Each entity in the collection will represent one sort criteria. The type of entity does not matter, you can specify any entity logical name. The following are the attributes you need to populate: <ol> <li> **Name** (_String_): The sort criteria <li>**SortOrder** (_Integer_): The sort direction (0 for ascending and 1 for descending)
| MaxResourceTravelRadius | Entity | This attribute specifies the maximum This attribute can be defined in an Entity. The type of entity does not matter, you can specify any entity logical name. The following are the attributes you need to populate: <ol> <li> **Value** (_Decimal_): The radius <li> **Unit** (_Integer_): The distance unit. See msdyn_distance unit option set for possible values.
| MaxNumberOfResourcesToEvaluate | Integer | This attribute defines a limit on the number of resources that are considered for the request.

### Resource specification entity

| Name | Type | Description | Required |
| --- | --- | --- | --- |
| Resource Types | EntityCollection | This attribute specifies the resource type required for the requirement. It can be specified using an entity collection. Each entity in the collection will represent one bookable resource type. The type of entity does not matter, you can specify any entity logical name. This is the attribute required: <ol> <li> **Value** (_Integer_): The option set value that represents the resource type.  | No
| Preferred Resources | EntityCollection | This attribute specifies the resources preferred for the requirement. Preferred resources can be specified using an entity collection of bookable resource entities. Each entity in the collection will represent one preferred resource. This is the attribute required: <ol> <li> **Value** (_Guid_): The bookable resource ID of the preferred resource.
| Restricted Resources | EntityCollection | This attribute specifies the resources that should not be considered for the requirement. Restricted resources can be specified using an entity collection of bookable resource entities. Each entity in the collection will represent one restricted resource. This is the attribute required: <ol> <li> **Value** (_Guid_): The bookable resource ID of the restricted resource.
| Constraints | Entity | This attribute specifies the additional constraints that should be applied to the retrieval of available resources.
| RetrieveResourcesQueryId | 
| BookedResourceId | Guid | This attribute specifies the resource currently booked for the requirement.  

#### Constraints

Additional constraints can be specified through attributes in this entity. The type of entity does not matter, you can specify any entity logical name.

Review the ‘Retrieve Resources Query’ on the schedule board settings to identify which constraints might apply. By default, it includes the following:

| Name | Type | Description |
| --- | --- | --- | 
| Characteristics | EntityCollection | A collection of characteristic IDs that a qualified resource must have. |
| Roles | EntityCollection | A collection of role IDs that a qualified resource must have. |
| Territories | EntityCollection | 	A collection of territory IDs. A qualified resource must be assigned to one of the territories. |
| UnspecifiedTerritory | Boolean | In combination with the Territories constraint, specifies that a qualified must be assigned to one of the territories or no territory at all. |
| OrganizationalUnits | EntityCollection | A collection of organizational unit IDs. A qualified resource must be a member of one of the specified organizational units. |
| Teams | EntityCollection | A collection of team IDs. A qualified resource must belong to one of the teams (implies that the resource type is a system user).
| BusinessUnits | EntityCollection | A of collection of business unit IDs. A qualified resource must belong to one of the business units (Implies that the resource is a system user). |

## Output parameters

At the highest level, the output has the following four parameters. The results are represented in entity collections and entities. Responses may not include all the attributes described here as null value or not NA values are omitted from the response. Always check for the presence of an attribute before trying to access it.

| Name | Type | Description | Required | Default value |
| --- | --- | --- | --- | --- |
| Time Slots | EntityCollection | A collection of time slot results. See ###TimeSlotsEntity section for more details. |
| Resources | EntityCollection | A collection of resource results. Resources are represented as a collection of entities with the following attributes: <ol> <li> **BookableResource** (_Entity_): The bookable resource entity that is available for the requirement. <li> **TotalAvailableTime** (_Double_): The total available time for the resource to perform the requirement. |
| Related | Entity | Related resources represent resources and time slots of resources that are not directly qualified for the requested requirement but are related. For example, if a crew member qualifies for a requirement, then the other members of that crew would be related results. <ol> <li> **Timeslots** (*EntityCollection*): Time slots of related resources. The definition of time slots is the same as described in the [time slots section](#time-slots-entity). <li> **Resources** (*EntityCollection*): The related resources. The definition of resources is the same as described in the resources attribute definition above. |
| Exceptions | Entity | This attribute contains information about any exception that occurred and information about if and where the resource search was truncated. <ol> <li> **Message** (_String_): Exception message <li> **ResourcesTruncatedAt** (_Integer_): If the number of resources exceeded the retrieval limit; the number where the resources where truncated. |

### Time slots entity

| Name | Type | Description | Required | Default value |
| --- | --- | --- | --- | --- |
| ID | Guid | Unique identifier for the time slot | 
| Type | Integer | The type of time slot can be one of the following: <ul><li> **0**: Available <li> **1**: Scheduled <li> **2**: Off <li> **3**: Break |
| StartTime | Datetime | The start time of the time slot. If there is travel for the requirement, then this is the start time of travel. If not, this is the start time of the requirement. |
| Arrival Time | Datetime | The arrival time of the time slot. If there is travel for the requirement, then this is the start time of requirement, after travel has been completed. If not, it is the same as the start time of the time slot. |
| EndTime | Datetime | The end time of the time slot. |
| Effort | Integer | The effort or capacity of the resource to carry out the requirements. |
| Resource Requirement | EntityReference | The resource requirement for which time slots are being retrieved. |
| Potential | Boolean | A boolean value indicating if the time slot has potential to fulfill the requested requirement. |
| IsDuplicate | Boolean | A boolean value indicating if the time slot is a duplicate. |
| Allow Overlapping | Boolean | A boolean value indicating if overlapping is allowed. |
| Resource| Entity | The resource to which the time slot belongs. |
| Location| Entity | The location of the time slot. |
| Travel| Entity | The travel associated with the time slot. |
| Next| Entity  | The travel associated with the next time slot. |
| Availability| Entity | The detailed availability information for a time slot. This is used in connection with time groups. |
| TimeGroup| Entity | The details about a time group. |

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
| Characteristics |	EntityCollection|	The bookable resource characteristics. See **Time Slot Resource Characteristics** section for more details. |
| HasStartLocation |	Boolean|	A boolean value indicating if the resource has a start location. |
| HasEndLocation |	Boolean	|A boolean value indicating if the resource has an end location. |
| Email |	String	|The resource’s email address. |
| Phone |	String|	The resource’s phone number. |
| ImagePath |	String	|The path to the resource’s image. |
| CalendarId |	Guid	|The resource’s calendar ID. |
