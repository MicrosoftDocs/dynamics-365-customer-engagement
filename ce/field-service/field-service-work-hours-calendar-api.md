---
title: "Edit Work Hour Calendar Using APIs | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 05/24/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
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


# Edit Work Hour Calendar Using APIs 

Organizations have the need to programmatically create, edit or delete work hours on the calendars of their resources. Calendars have working hours, time off, breaks that determine the availability of their resource to schedule work. 
<br> <br> Use the Save Calendar and Delete Calendar API to programmatically create, update and delete calendar rules for select entities.
- The Save Calendar API (msdyn_SaveCalendar) creates, or updates calendar records on a selected entity, based on the rules, dates, and patterns passed as the request.
- The Delete Calendar API(msdyn_DeleteCalendar) deletes a calendar record on a selected entity.
This is helpful for increasing flexibility to the working hours of entities such as Bookable Resources, Resource Requirement, Project and so on.
This document contains the details of the API contract and their usage with examples.

## Prerequisites

- Platform version 9.2.21055 or above with Field Service version 8.8.42.31.
- Usage of one of the following entities: [Bookable Resource](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/bookableresource?view=dynamics-ce-odata-9), [Resource Requirement](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/msdyn_resourcerequirement?view=dynamics-ce-odata-9), [Operating Hour](https://docs.microsoft.com/en-us/dynamics365/customer-service/developer/reference/entities/msdyn_operatinghour), [Work Hour Template](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/msdyn_workhourtemplate?view=dynamics-ce-odata-9), [System User](https://docs.microsoft.com/en-us/dynamics365/customer-service/developer/reference/entities/systemuser), [Project](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/msdyn_project?view=dynamics-ce-odata-9), Extended User Setting, [Equipment](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/equipment?view=dynamics-ce-odata-9).

## Work Hour Types
This API supports the CUD (Create Update Delete) operations of the following work hour types.

### Working Hours

These are the times during which an entity is available to perform work.
<br> Using this API, you can do the following to working hours-
-	Create/ Edit/ Delete a working hour occurrence.
-	Create/ Edit/ Delete a working hour daily recurrence.
-	Create/ Edit/ Delete a working hour weekly recurrence.
-	Create/ Edit/ Delete a working hour custom recurrence.
-	Create/ Edit/ Delete all-day working hours.
-	Create/ Edit/ Delete additional capacity on working hours.
-	Edit a working hour occurrence in a recurrence.
-	Edit “This and Following occurrences” in a recurrence.
-	Change a working hour occurrence to a recurrence.
-	Change the time zone of the calendar rule.

<br> Using this API, you _cannot_ do the following to working hours-
- Delete a single work hour occurence from a recurrence.
- Create occurrence that spans 24 hours but doesn't start and end at 12:00 am.
- Create/Edit/Delete an all-day recurrence.

### Non-Working Hour

These are the times during which the entity is unavailable to work due to an unspecified reason.
<br> Using this API, you can do the following to non-working hours-
-	Create/ Edit all-day non-working hours.
-	Create/ Edit non-working hour occurrence.
-	Change the time zone of the calendar rule.

<br> Using this API, you _cannot_ do the following to non-working hours-
- Create/Edit a non-working hour recurrence.

### Break
These are the times in a working day during which an entity is taking a break and is hence unavailable for work. Breaks cannot exist without working hours; they have to be adjacent to two working hours of a day. Breaks cannot overlap with working hours.  
<br> Using this API, you can do the following to breaks-
- Create/ Edit breaks on working hours.

<br> Using this API, you _cannot_ do the following to breaks-
- Delete a single break occurrence from a recurrence.


### Time Off 
These are the times during which an entity is unavailable to work due to a vacation. The reason for time off can be specified.
<br> Using this API, you can do the following to time off-
-	Create/ Edit time-off with a label.
-	Change the time zone of the calendar rule.

<br> Using this API, you _cannot_ do the following to time off-
- Create/Edit a time off hour recurrence.

### Business Closure
These are the times during which the business is closed. Every entity can be set to observe or ignore business closure times followed by the organization using the optional “ObserveClosure” key in the API contract. When they are set to observe them, the entity will be unavailable to work due to the holiday.

## Save Calendar Contract

### Request
The request contains only one attribute – `CalendarEventInfo` and this is of String type. It contains several other attributes that are all embedded in this string. 
>[!NOTE]
In this table below, _Type_ represents the format expected to make a successful request. However, it is all parsed as a single string.

**CalendarEventInfo**
| Name     | Type   | Required     | Description |
| :-------- | :--------- | :--------- | :- |
|  EntityLogicalName | String   | Yes   | This key describes the entity from which the API is being called. The calendar of this entity is to be created or edited. |
| CalendarId  | Guid | Yes| This key contains the calendar ID related to the entity described above. When any of these entities are created, a calendar record is also automatically created. This API is editing that calendar record by adding rules or editing existing rules.|
|RulesAndRecurrences	| RulesAndRecurrences	| Yes | This key contains multiple attributes as listed in the table below. |
| IsVaried	|Boolean	|No|	This key should be set to true for custom recurrence scenarios.|
|IsEdit|	Boolean|	No|	This key should be set to true for editing an existing rule(s).|
| TimeZoneCode|	Integer|	No|	This key takes an integer value corresponding to the time zone for the calendar rules. Please check the [TimeZoneCode](##TimeZoneCode) section below for the mapping. Default value – user's time zone.
| InnerCalendarDescription|	String|	No|	This key is only needed if the calendar rule is for Time Off. It should contain the reason for Time Off.| 
| ObserveClosure|	Boolean|	No|	This key is specific to recurrences. If it is set to true, the entity will observe business closure.|
|RecurrenceEndDate|	DateTime|	No|	This key is specific to recurrences. It contains the end date for the recurrence. Default value for occurrences – null. Default value for recurrences - 30th Dec 9999, 23:59:59 hours, UTC.|
|RecurrenceSplit|	Boolean|	No|	This key is specific to recurrences. It is set to true for editing “This and following occurrences” of a recurrence.|
|ResourceId	| Guid |	No|	This key contains the SystemUserId or ResourceId and is only to be passed when the entity associated with this call is a BookableResource of type SystemUser. This is necessary to check for OwnCalendar privileges in the ServiceManagement tab.

#### RulesAndRecurrences
|Name | Type | Required | Description |
| :-------- | :--------- | :--------- | :- |
|Rules| Rules |	Yes |	This key contains multiple attributes as listed in the table below.
|RecurrencePattern|	String|	No|	This key is specific to recurrences. We currently only support this pattern - `FREQ=DAILY;INTERVAL=1;BYDAY=SU,MO,TU,WE,TH,FR,SA`. `BYDAY` can be changed to include lesser days. However, `FREQ` and `INTERVAL` values cannot be changed.| 
|InnerCalendarId|	GUID|	No|	This is an edit specific key. If a rule is being edited, the InnerCalendarId needs to be passed here. |
|Action	|Integer|	No|	This is custom recurrence specific key. If a custom recurrence is being created or edited, one of the following enums should be entered: (1) Adding a day to the recurrence, (2)	Deleting a day from the recurrence, (3) Editing only the start/ end dates or times, or capacity (4) Editing anything apart from previous keys. Please read the [Custom Recurrence](##CustomRecurrence) section for more information on this.|

**Rules**
|Name	|Type|	Required|	Description|
| :-------- | :--------- | :--------- | :- |
|StartTime|	DateTime|	Yes|	This key contains a datetime entry of the [ISO format](https://en.wikipedia.org/wiki/ISO_8601). Eg. \"2021-05-15T12:00:00.000Z\". The time portion determines the start time of the work hour in the earlier specified time zone. The date portion determines the start date of the work hour. Here, 15th May 2021 is the date of the occurrence or the starting date of the recurrence. If the pattern was “BYDAY=TU,WE”, but 15th May (Saturday) is the date, the API will automatically create/edit rules for all Tuesdays and Wednesdays following 15th May. Each rule doesn’t have to have the date corresponding to the day. 
|EndTime|	DateTime|	Yes|	This contains a datetime entry following the [ISO format](https://en.wikipedia.org/wiki/ISO_8601). Eg. \"2021-05-15T12:00:00.000Z\".The time portion determines the end time of the work hour in the earlier specified time zone. The date portion *must* contain the same date as the date portion of the StartTime. The only exceptions are if it is (a) An All-Day occurrence. In this case the date portion should reflect the end date of the All-Day occurrence. (b) The occurrence ends at the end of the day. i.e 12 am of the following day.In this case, the date should be \"2021-05-16T00:00:00.000Z\". To specify the end date of the recurrence, please modify the “RecurrenceEndDate” attribute.
|WorkHourType	|Integer|	Yes	|This key contains an enum corresponding to one of the following options: (0) Working, (1)	Break, (2) Non-working, (3) Time Off |
| Effort |	Integer	| No |	This key determines the capacity of the entity. It must be whole numbers. Default value = 1

### Response
|Name |	Type|	Description|
|:--|:--|:--|
| InnerCalendarIds|	String |	An array of InnerCalendarIds Guids that are a result of the POST operation. |

## Delete Calendar Contract
### Request
|Name |	Type|	Required|	Description|
|:--|:--|:--|:--|
|EntityLogicalName|	String|	Yes	|This field describes the entity whose calendar rules are to be deleted.|
|InnerCalendarId|	Guid|	Yes|	This field describes the id of the InnerCalendarId that needs to be deleted. If there are multiple InnerCalendarIds associated with a single rule, any one ID is sufficient here. Please see this document to learn more about inner and outer calendars.
|CalendarId	|Guid	|Yes|	This field describes the CalendarId of the entity.
|IsVaried	|Bool	|No	|This field is recurrence specific and is set to yes if it is a custom recurrence rule being deleted.

### Response
|Name |	Type|	Description|
|:--|:--|:--|
|InnerCalendarIds|	String|	An array of InnerCalendarIds that are a result of the POST operation.


## Example Scenarios for API usage

Let’s walk through some real life scenarios that this API can be used for.

Bob and Tim are delivery truck drivers for Contoso Enterprises, Bellevue. Their dispatcher, Debbie, is responsible for making changes to their work hour calendars. She does that using Save and Delete calendar APIs.

> [!NOTE]
For each of the following example scenarios, the box with the blue text (first block) contains the request and the box with the green text (second block) contains the response.

### Create a working hour occurrence.
Bob is scheduled to drive around to deliver packages from 9:00 am to 5:00 pm on 15th May 2021. Debbie uses the msdyn_SaveCalendar API.

> <span style="color:blue"> {
 "CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-15T09:00:00.000Z\",\"EndTime\":\"2021-05-5T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}]}]}"
}</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\"9519e271-18b5-eb11-a81d-000d3afb1dba\"]"
}</span>


### Edit a working hour occurrence.
His schedule then changes to start from 10:00 am on 15th May 2021. Debbie uses the msdyn_SaveCalendar API.

> <span style="color:blue"> {
 "CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"EntityLogicalName\":\"bookableresource\",\"IsEdit\":\"true\",\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-15T10:00:00.000Z\",\"EndTime\":\"2021-05-15T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}], \"InnerCalendarId\":\"9519e271-18b5-eb11-a81d-000d3afb1dba\"}"
}</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\"9519e271-18b5-eb11-a81d-000d3afb1dba\"]"
}</span>


### Delete a working hour occurrence.
A family emergency comes up! Bob needs to cancel his entire day of work. Debbie uses the msdyn_DeleteCalendar API.
> <span style="color:blue"> {
 "CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"EntityLogicalName\":\"bookableresource\",\"InnerCalendarId\":\"9519e271-18b5-eb11-a81d-000d3afb1dba\"}"
}</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\"9519e271-18b5-eb11-a81d-000d3afb1dba\"]"
}</span>



### Create a working hour daily recurrence.
Starting 20th May 2021, Bob decides to work with Contoso all week from 8:00 am to 5:00 pm. He’s going to stop working here on 15th July 2021.

> <span style="color:blue"> {
 "CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RecurrenceEndDate\":\"2021-07-15T00:00:00.000Z\",\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-20T08:00:00.000Z\",\"EndTime\":\"2021-05-20T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=SU,MO,TU,WE,TH,FR,SA\"}]}"
}</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\"f5486570-41b5-eb11-a81d-000d3afb1dba\"]"
}</span>



### Edit a working hour daily recurrence with increased capacity.
Bob is getting burnt out due to all those hours of driving. Bob then decided to stop working all week on 15th June 2021. Until then he will continue the previously decided all week schedule. Debbie makes these changes using the msdyn_SaveCalendar API.

> <span style="color:blue"> {
 "CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RecurrenceEndDate\":\"2021-06-15T00:00:00.000Z\",\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-20T08:00:00.000Z\",\"EndTime\":\"2021-05-20T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"InnerCalendarId\":\"f5486570-41b5-eb11-a81d-000d3afb1dba\",\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY= SU,MO,TU,WE,TH,FR,SA\"}]}"
}</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\"f5486570-41b5-eb11-a81d-000d3afb1dba\"]"
}</span>


### Create a working hour weekly recurrence.
Starting from 16th June 2021, Bob will work from 8:00 am to 5:00 pm on Wednesdays and Fridays. He takes a break from 12:00 pm to 12:30 pm for lunch. Debbie uses the msdyn_SaveCalendar API. But oops, she makes a mistake and schedules the break from 12:00 pm to 1:00 pm.

> <span style="color:blue"> {
  "CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-06-16T08:00:00.000Z\",\"EndTime\":\"2021-06-16T12:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}, {\"StartTime\":\"2021-06-15T12:00:00.000Z\",\"EndTime\":\"2021-06-15T13:00:00.000Z\",\"Effort\":null,\"WorkHourType\":1}, {\"StartTime\":\"2021-06-15T13:00:00.000Z\",\"EndTime\":\"2021-06-15T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=WE,TH,FR\"}]}"
}</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\"c94adf3a-21b5-eb11-a81d-000d3afb1dba\"]"
}</span>


### Edit a break from a working hour weekly recurrence.
Debbie then corrects her mistake and changes the break to be from 12:00 pm to 12:30 pm using the msdyn_SaveCalendar API.

> <span style="color:blue"> {
  "CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"EntityLogicalName\":\"bookableresource\",\"IsEdit\":\"true\",\\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-06-15T08:00:00.000Z\",\"EndTime\":\"2021-06-15T12:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}, {\"StartTime\":\"2021-06-15T12:00:00.000Z\",\"EndTime\":\"2021-06-15T12:30:00.000Z\",\"Effort\":null,\"WorkHourType\":1}, {\"StartTime\":\"2021-06-15T12:30:00.000Z\",\"EndTime\":\"2021-06-15T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"InnerCalendarId\":\"c94adf3a-21b5-eb11-a81d-000d3afb1dba\",\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=WE,TH,FR\"}]}"
}</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\" c94adf3a-21b5-eb11-a81d-000d3afb1dba \"]"
}
</span>


### Create a working hour custom recurrence.
Tim works for Contoso on Mondays from 8:00 am to 5:00 pm and Wednesdays from 11:00 am to 3:00 pm. He started his role on 16th May 2021. Debbie uses the msdyn_SaveCalendar API to create his work hours.

> <span style="color:blue"> {
"CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"EntityLogicalName\":\"bookableresource\",\\"TimeZoneCode\":5,\"IsVaried\":true,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-16T08:00:00.000Z\",\"EndTime\":\"2021-05-16T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"Action\":1,\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=MO\"},{\"Rules\":[{\"StartTime\":\"2021-05-16T11:00:00.000Z\",\"EndTime\":\"2021-05-16T15:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"Action\":1,\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=WE\"}]}"
}
</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\"34d2210c-9fb6-eb11-a820-000d3afb1dba\", \"37d2210c-9fb6-eb11-a820-000d3afb1dba\"]"
}
</span>


### Edit a working hour custom recurrence.
This then changes: his work hours are now Wednesdays 5:00 pm to 8:00 pm and Thursday 10:00 am to 12:00 pm. Monday is removed from his schedule. Debbie uses the msdyn_SaveCalendar API to achieve this.

> <span style="color:blue"> {
"CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"EntityLogicalName\":\"bookableresource\",\\"TimeZoneCode\":5,\"IsVaried\":true,\"IsEdit\":true,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-16T08:00:00.000Z\",\"EndTime\":\"2021-05-16T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"Action\":1,\"InnerCalendarId\":\"34d2210c-9fb6-eb11-a820-000d3afb1dba\",\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=MO\"},{\"Rules\":[{\"StartTime\":\"2021-05-16T13:00:00.000Z\",\"EndTime\":\"2021-05-16T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"Action\":3,\"InnerCalendarId\":\"37d2210c-9fb6-eb11-a820-000d3afb1dba\",\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=WE\"}]}"
}
</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\"34d2210c-9fb6-eb11-a820-000d3afb1dba\", \"37d2210c-9fb6-eb11-a820-000d3afb1dba\"]"
}
</span>


### Edit a working hour occurrence in a recurrence.
On 26th May, Tim is only able to work from 5:00 pm to 7:00 pm. Debbie uses the msdyn_SaveCalendar API here.

> <span style="color:blue"> {
 "CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-26T017:00:00.000Z\",\"EndTime\":\"2021-05-26T19:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}]}, \"InnerCalendarId\":\"34d2210c-9fb6-eb11-a820-000d3afb1dba\"]}"
}</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\"34d2210c-9fb6-eb11-a820-000d3afb1dba\"]"
}</span>

### Delete a working hour custom recurrence.
> <span style="color:blue"> {
 "CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"EntityLogicalName\":\"bookableresource\",\"InnerCalendarId\":\"34d2210c-9fb6-eb11-a820-000d3afb1dba\",\"IsVaried\":true}"
}</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\"34d2210c-9fb6-eb11-a820-000d3afb1dba\"]"
}</span>



### Create a Time-Off
Tim will be taking 3 days off for a family vacation starting on 9th June 2021.

> <span style="color:blue"> {
 "CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"InnerCalendarDescription\":\"Family Vacation\"\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-06-15T00:00:00.000Z\",\"EndTime\":\"2021-06-17T00:00:00.000Z\",\"Effort\":1,\"WorkHourType\":3}]}]}"
}</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\"1141e271-18b5-eb11-a81d-000d3afb1dba\"]"
}</span>


### Create All-Day working hours.
Tim has a 72-hour shift starting 20th May 2021. Debbie uses the msdyn_SaveCalendar API to create his work hours.

> <span style="color:blue"> {
 "CalendarEventInfo": "{\"CalendarId\":\"2f2637c1-3576-4b22-9490-97c3ac7d2734\",\"EntityLogicalName\":\"bookableresource\",\\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-20T00:00:00.000Z\",\"EndTime\":\"2021-05-22T00:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}], \"InnerCalendarId\":\"9519e271-18b5-eb11-a81d-000d3afb1dba\"}]}"
}
</span>

> <span style="color:green">{
  "InnerCalendarIds": "[\"34d2210c-9fb6-eb11-a820-000d3afb1dba\", \"37d2210c-9fb6-eb11-a820-000d3afb1dba\", \"4bcc69b8-a2b6-eb11-a820-000d3afb1dba\"]"
}
</span>


## Troubleshooting and Errors

## Additional Notes
## TimeZoneCode

|Enum| TimeZone|
|--|--|
0                   | (GMT-12:00) International Date Line West
1                   | (GMT+13:00) Samoa
2                   | (GMT-10:00) Hawaii
3                   | (GMT-09:00) Alaska
4                   | (GMT-08:00) Pacific Time | (US &amp; Canada)
5                   | (GMT-08:00) Baja California
6                   | (GMT-11:00) Coordinated Universal Time-11
7                   | (GMT-10:00) Aleutian Islands
8                   | (GMT-09:30) Marquesas Islands
9                   | (GMT-09:00) Coordinated Universal Time-09
10                  | (GMT-07:00) Mountain Time | (US &amp; Canada)
11                  | (GMT-08:00) Coordinated Universal Time-08
12                  | (GMT-07:00) Chihuahua, La Paz, Mazatlan
15                  | (GMT-07:00) Arizona
20                  | (GMT-06:00) Central Time | (US &amp; Canada)
25                  | (GMT-06:00) Saskatchewan
29                  | (GMT-06:00) Guadalajara, Mexico City, Monterrey
33                  | (GMT-06:00) Central America
34                  | (GMT-06:00) Easter Island
35                  | (GMT-05:00) Eastern Time | (US &amp; Canada)
40                  | (GMT-05:00) Indiana | (East)
43                  | (GMT-05:00) Haiti
44                  | (GMT-05:00) Havana
45                  | (GMT-05:00) Bogota, Lima, Quito, Rio Branco
47                  | (GMT-04:00) Caracas
50                  | (GMT-04:00) Atlantic Time | (Canada)
51                  | (GMT-05:00) Turks and Caicos
55                  | (GMT-04:00) Georgetown, La Paz, San Juan
56                  | (GMT-04:00) Santiago
58                  | (GMT-04:00) Cuiaba
59                  | (GMT-04:00) Asuncion
60                  | (GMT-03:30) Newfoundland
65                  | (GMT-03:00) Brasilia
69                  | (GMT-03:00) Buenos Aires
70                  | (GMT-03:00) Cayenne, Fortaleza
71                  | (GMT-03:00) Salvador
72                  | (GMT-03:00) Saint Pierre and Miquelon
73                  | (GMT-03:00) Greenland
74                  | (GMT-03:00) Montevideo
75                  | (GMT-02:00) Mid-Atlantic
76                  | (GMT-02:00) Coordinated Universal Time-02
77                  | (GMT-03:00) Araguaina
80                  | (GMT-01:00) Azores
83                  | (GMT-01:00) Cabo Verde Is.
84                  | (GMT+01:00) Casablanca
85                  | (GMT+00:00) Dublin, Edinburgh, Lisbon, London
90                  | (GMT+00:00) Monrovia, Reykjavik    
92                  | (GMT) Coordinated Universal Time
95                  | (GMT+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague
100                 | (GMT+01:00) Sarajevo, Skopje, Warsaw, Zagreb
105                 | (GMT+01:00) Brussels, Copenhagen, Madrid, Paris
110                 | (GMT+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna
113                 | (GMT+01:00) West Central Africa
115                 | (GMT+02:00) Chisinau
120                 | (GMT+02:00) Cairo
125                 | (GMT+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius
129                 | (GMT+02:00) Amman
130                 | (GMT+02:00) Athens, Bucharest
131                 | (GMT+02:00) Beirut
133                 | (GMT+02:00) Damascus
134                 | (GMT+03:00) Istanbul
135                 | (GMT+02:00) Jerusalem
140                 | (GMT+02:00) Harare, Pretoria
141                 | (GMT+02:00) Windhoek
142                 | (GMT+02:00) Gaza, Hebron
145                 | (GMT+03:00) Moscow, St. Petersburg
150                 | (GMT+03:00) Kuwait, Riyadh
151                 | (GMT+03:00) Minsk
155                 | (GMT+03:00) Nairobi
158                 | (GMT+03:00) Baghdad
159                 | (GMT+02:00) Kaliningrad
160                 | (GMT+03:30) Tehran
165                 | (GMT+04:00) Abu Dhabi, Muscat
169                 | (GMT+04:00) Baku
170                 | (GMT+04:00) Yerevan
172                 | (GMT+04:00) Port Louis
173                 | (GMT+04:00) Tbilisi
174                 | (GMT+04:00) Izhevsk, Samara
175                 | (GMT+04:30) Kabul
176                 | (GMT+04:00) Astrakhan, Ulyanovsk
180                 | (GMT+05:00) Ekaterinburg
184                 | (GMT+05:00) Islamabad, Karachi
185                 | (GMT+05:00) Toshkent
190                 | (GMT+05:30) Chennai, Kolkata, Mumbai, New Delhi
193                 | (GMT+05:45) Kathmandu
195                 | (GMT+06:00) Astana
196                 | (GMT+06:00) Dhaka
197                 | (GMT+06:00) Omsk
200                 | (GMT+05:30) Sri Jayawardenepura
201                 | (GMT+07:00) Novosibirsk
203                 | (GMT+06:30) Yangon | (Rangoon)
205                 | (GMT+07:00) Bangkok, Hanoi, Jakarta
207                 | (GMT+07:00) Krasnoyarsk
208                 | (GMT+07:00) Barnaul, Gorno-Altaysk
209                 | (GMT+07:00) Hovd
210                 | (GMT+08:00) Beijing, Chongqing, Hong Kong, Urumqi
211                 | (GMT+07:00) Tomsk
215                 | (GMT+08:00) Kuala Lumpur, Singapore
220                 | (GMT+08:00) Taipei
225                 | (GMT+08:00) Perth
227                 | (GMT+08:00) Irkutsk
228                 | (GMT+08:00) Ulaanbaatar
229                 | (GMT+09:00) Pyongyang
230                 | (GMT+09:00) Seoul
231                 | (GMT+08:45) Eucla
235                 | (GMT+09:00) Osaka, Sapporo, Tokyo
240                 | (GMT+09:00) Yakutsk
241                 | (GMT+09:00) Chita
245                 | (GMT+09:30) Darwin
250                 | (GMT+09:30) Adelaide
255                 | (GMT+10:00) Canberra, Melbourne, Sydney
260                 | (GMT+10:00) Brisbane
265                 | (GMT+10:00) Hobart
270                 | (GMT+10:00) Vladivostok
274                 | (GMT+10:30) Lord Howe Island
275                 | (GMT+10:00) Guam, Port Moresby
276                 | (GMT+11:00) Bougainville Island
277                 | (GMT+11:00) Norfolk Island
278                 | (GMT+11:00) Sakhalin
279                 | (GMT+11:00) Chokurdakh
280                 | (GMT+11:00) Solomon Is., New Caledonia
281                 | (GMT+11:00) Magadan
284                 | (GMT+12:00) Coordinated Universal Time+12
285                 | (GMT+12:00) Fiji
290                 | (GMT+12:00) Auckland, Wellington
295                 | (GMT+12:00) Anadyr, Petropavlovsk-Kamchatsky
299                 | (GMT+12:45) Chatham Islands
300                 | (GMT+13:00) Nuku'alofa
301                 | (GMT-05:00) Chetumal
302                 | (UTC+02:00) Khartoum
303                 | (GMT-03:00) Punta Arenas
304                 | (GMT+04:00) Volgograd
305                 | (GMT-07:00) Yukon







## Custom Recurrence