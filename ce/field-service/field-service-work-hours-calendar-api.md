---
title: "Edit work hour calendars by using APIs in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to edit work order calendars in Field Service by using APIs. 
ms.date: 07/26/2023
ms.topic: article
author: ryanchen8
ms.author: chenryan
---

# Edit work hour calendars by using APIs

Organizations often need to programmatically create, edit, or delete work hours on the calendars of their resources. Calendars show working hours, time off, and breaks that determine the availability of a resource when work is being scheduled. Those resources must be scheduled in specific time zones, might or might not observe business closures, and can have variable capacity. For information about defining work hours in the Field Service app, go to [Add work hours to a bookable resource](/dynamics365/field-service/set-up-bookable-resources#add-work-hours).

In addition to using the Field Service app, you can use the following APIs to modify calendar rules for selected record types:

- The Save Calendar API (`msdyn_SaveCalendar`) creates or updates calendar records on a selected entity, based on the inputs passed as the request.
- The Delete Calendar API (`msdyn_DeleteCalendar`) deletes all [inner calendar rules](/dynamics365/customerengagement/on-premises/developer/calendar-entities) of a calendar on a selected entity, based on the inputs passed as the request.
- The Save/Delete Calendar API V2 (msdyn_SaveCalendar/msdyn_DeleteCalendar, pass flag UseV2) allows multiple work hour recurrences simultaneously by altering the logic for overlapping rules. For more information, see [What happens if there are overlapping rules?](#what-happens-if-there-are-overlapping-rules).

This topic contains details about each API's input (request) and output (response), and their usage, with examples.

## Prerequisites

- Platform version 9.2.21055 or above with Universal Resource Scheduling version 3.12.45.7.
- Usage of one of the following record types: 
  - Bookable resource (bookableresource)
  - Resource requirement (msdyn_resourcerequirement)
  - Work hour template (msdyn_workhourtemplate)
  - Project (msdyn_project)

## Calendar event types

When you create a calendar, you define how many times a [work hour type](#work-hour-types) will occur&mdash;once, all day, every week, or every day, or you can create a custom recurrence. For more information about these calendar events, go to the [examples later in this topic](#example-scenarios-for-api-usage).

### Occurrence

When a work hour type occurs only once in the entity's calendar, it's called an *occurrence*.

For example, consider a resource working from 5:00 AM to 10:00 AM on May 26, 2021. These APIs only support this type of occurrence, which starts and ends within the same day. For another example, consider a resource working from May 26, 2021 at 8:00 PM 10:00 AM on May 27, 2021. You can't create this occurrence by using just one call of the `msdyn_SaveCalendar` API; you need to make two calls instead. 

### All-day occurrence

When a work hour type occurs for one or more whole days, starting at midnight (12:00 AM) of the start date, it's an *all-day occurrence*. The maximum duration for an all-day occurrence is five years.

For example, a resource works all day from May 26, 2021 to the end of the day on May 30, 2021. This is an all-day occurrence that lasts five days.

### Weekly recurrence

When a work hour type occurs at the same time on selected days of every week, it's called a *weekly recurrence*.

For example, a resource works from 5:00 AM to 10:00 AM every Monday, Tuesday, and Wednesday.

### Daily recurrence

When a work hour type occurs at the same time every day, it's called a *daily recurrence*.

For example, a resource works from 5:00 AM to 10:00 AM every day of the week.

### Custom recurrence

When a work hour type occurs at certain times on certain days of the week, but the times are different on different days, you can create a *custom recurrence*.

For example, a resource works from 5:00 AM to 10:00 AM every Monday, and 12:00 PM to 3:00 PM every Wednesday.

## Work hour types

These APIs support create, update, and delete operations for the following work hour types:

- [Working hours](#working-hours)
- [Non-working hours](#non-working-hour)
- [Breaks](#break)
- [Time off](#time-off)
- [Business closure](#business-closure)

### Working hours

Working hours are times during which an entity is available to perform work.

Using these APIs, you can do the following:

-	Create, edit, or delete a working hour occurrence.
-	Create, edit, or delete a working hour daily recurrence.
-	Create, edit, or delete a working hour weekly recurrence.
-	Create, edit, or delete a working hour custom recurrence.
-	Create, edit, or delete all-day working hours.
-	Create or edit capacity on working hours.
-	Edit a single working hour occurrence in a recurrence.
-	Edit *This and Following occurrences* in a recurrence.
-	Change a working hour occurrence to a recurrence.
-	Change the time zone of the calendar rule.

Using this API, you can't do the following:

- Delete a single working hour occurrence from a recurrence.
- Create an occurrence that spans 24 hours but doesn't start and end at midnight (12:00 AM).
- Create, edit, or delete an all-day recurrence.

### Non-working hour

These are times during which the entity is unavailable to work due to an unspecified reason.

Using these APIs, you can do the following:

-	Create or edit all-day non-working hours.
-	Create or edit a non-working hour occurrence.
-	Change the time zone of the calendar rule.

Using these APIs, you can't do the following:

- Create or edit a non-working hour recurrence.

### Break

These are times in a working day during which an entity is taking a break and is unavailable for work. Breaks can't exist without working hours; they have to occur between two working hours in a day. Breaks can't overlap with working hours.  

Using these APIs, you can do the following:

- Create or edit breaks during working hours.

Using these APIs, you can't do the following:

- Delete only breaks from an occurrence or recurrence of working hours.


### Time off 

These are times during which an entity is unavailable to work due to a vacation. The reason for time off can be specified.

Using these APIs, you can do the following:

-	Create or edit time off with a label.
-	Change the time zone of the calendar rule.

Using these APIs, you can't do the following: 

- Create or edit a time-off hour recurrence.

### Business closure

You can [create business closure entities](/dynamics365/customer-service/set-when-business-closed-csh) that define the times the business will be closed. Using the `msdyn_SaveCalendar` API, you can set every entity to observe or ignore the organization's business closure times by using the optional [**ObserveClosure**](#calendareventinfo) key. When they're set to observe these closures, the entities will be unavailable for work.

## Save Calendar API

### Input

The request contains only one attribute&mdash;**CalendarEventInfo**, which is a **String** type. It contains several other attributes that are all embedded in this string.

> [!NOTE]
> In the following table, **Type** represents the format expected to make a successful request. However, the whole request is parsed as a single string.

#### CalendarEventInfo

| **Name**     | **Type**   | **Required**     | **Description** |
| :-------- | :--------- | :--------- | :----- |
|  EntityLogicalName | String   | Yes   | This key describes the entity from which the API is being called. The calendar of this entity is to be created or edited. |
| CalendarId  | GUID | Yes| This key contains the calendar ID related to the entity described above. When any of these entities are created, a calendar record is also automatically created. These APIs edit that calendar record by adding rules or editing existing rules.|
|RulesAndRecurrences	| RulesAndRecurrences	| Yes | This key is an array, and each element contains multiple attributes as listed in the table in the following section. The size of the array should be at least one.  |
| IsVaried	|Boolean	|No|	This key should be set to `true` for custom recurrence scenarios.|
|IsEdit|	Boolean|	No|	This key should be set to `true` for editing existing rules.|
| TimeZoneCode|	Integer|	No|	This key takes an integer value corresponding to the time zone for the calendar rules. For the mapping, go to [Time zone codes](#time-zone-codes), later in this topic. The default value is the user's time zone.
| InnerCalendarDescription|	String|	No|	This key is only needed if the calendar rule is for time off. It should contain the reason for the time off.| 
| ObserveClosure|	Boolean|	No|	This key is specific to recurrences. If it's set to `true`, the entity will observe business closure.|
|RecurrenceEndDate|	DateTime|	No|	This key is specific to recurrences. It contains the end date for the recurrence. If the timestamp is 08:00:00 or earlier, the recurrence end date is one day before the specified date. If the timestamp is 08:00:01 or later, the date is respected as-is. The default value for occurrences is null. The default value for recurrences is 30 Dec 9999, 23:59:59 hours, UTC<!--note from editor: Shouldn't this be in ISO 8601 format?-->.|
|RecurrenceSplit|	Boolean|	No|	This key is specific to recurrences. It's set to `true` for editing "This and following occurrences" of a recurrence.|
|ResourceId	| GUID |	No|	This key contains the **SystemUserId** or **ResourceId** and is only to be passed when the entity associated with this call is a bookable resource of type **SystemUser**. This is necessary to check for OwnCalendar privileges on the **Service Management** tab.|
|UseV2	| Flag |	No|	Passing this flag enables the V2 version of the work hour calendar, with an enhanced overlapping rules logic allowing for multiple recurrences. For more information, see [What happens if there are overlapping rules?](#what-happens-if-there-are-overlapping-rules).|

#### RulesAndRecurrences

|Name | Type | Required | Description |
| :-------- | :--------- | :--------- | :----- |
|Rules| Rules |	Yes |	This key is an array, and each element contains multiple attributes as listed in the table in the following section. The size of the array should be at least one. |
|RecurrencePattern|	String|	No|	This key is specific to recurrences. We currently only support this pattern: `FREQ=WEEKLY;INTERVAL=1;BYDAY=SU,MO,TU,WE,TH,FR,SA`. `BYDAY` can be changed to include fewer days; however, `FREQ` and `INTERVAL` can't be changed.| 
|InnerCalendarId|	GUID|	No|	This key is specific to editing. If a rule is being edited, the **InnerCalendarId** needs to be passed here. If an **InnerCalendarId** isn't passed, the API creates a new rule, even if the **IsEdit** key is set to true. |
|Action	|Integer|	No|	This key is specific to custom recurrences. If a custom recurrence is being created or edited, one of the following numbers should be entered:<ul><li>(1) Adding a day to the recurrence</li><li>(2)	Deleting a day from the recurrence</li><li>(3) Editing only the start or end dates or times, or editing capacity</li><li>(4) Editing anything other than the keys mentioned in (3)</li></ul>|

#### Rules

|Name	|Type|	Required|	Description|
| :-------- | :--------- | :--------- | :------ |
|StartTime|	DateTime|	Yes|	This key contains a datetime entry in [ISO format](https://en.wikipedia.org/wiki/ISO_8601). For example, `\"2021-05-15T12:00:00.000Z\"`. The time portion determines the start time of the work hour in the time zone specified earlier. The date portion determines the start date of the work hour. Here, May 15, 2021 is the date of the occurrence or the starting date of the recurrence. If the pattern was `BYDAY=TU,WE`, but May 15 (a Saturday) is the date, the API will automatically create or edit rules for all Tuesdays and Wednesdays following May 15. This is case where the rule doesn't have to have the date corresponding to the day. | 
|EndTime|	DateTime|	Yes|	This contains a datetime entry in [ISO format](https://en.wikipedia.org/wiki/ISO_8601). For example, `\"2021-05-15T12:00:00.000Z\"`. The time portion determines the end time of the work hour in the time zone specified earlier. The date portion *must* contain the same date as the date portion of the **StartTime**. The only exceptions are:<ul><li>If it's an all-day occurrence. In this case, the date portion should reflect the end date of the all-day occurrence.</li><li>The occurrence ends at the end of the day, that is, 12:00 AM of the following day. In this case, the date should be `\"2021-05-16T00:00:00.000Z\"`. To specify the end date of the recurrence, modify the **RecurrenceEndDate** attribute.</li></ul> |
|WorkHourType	|Integer|	Yes	|This key contains a number corresponding to one of the following options:<ul><li>(0) Working</li><li>(1) Break</li><li>(2) Non-working</li><li>(3) Time Off</li></ul>|
| Effort |	Integer	| No |	This key determines the capacity of the entity. It must be a whole number. The default value is 1. |

### Output

This POST API creates or modifies calendar rule records for the selected entity. It also gives the following output.

|**Name** |	**Type**|	**Description**|
|:--|:--|:--|
| InnerCalendarIds|	String |	An array of **InnerCalendarIds** GUIDs that are a result of the POST operation. |

## Delete Calendar API

### Input

|**Name** |	**Type**|	**Required**|	**Description**|
|:--|:--|:--|:--|
|EntityLogicalName|	String|	Yes	|This field describes the entity whose calendar rules are to be deleted.|
|InnerCalendarId|	GUID|	Yes|	This field describes the ID of the **InnerCalendarId** that needs to be deleted. If there are multiple **InnerCalendarIds** associated with a single rule, any one ID is sufficient here. More information about inner and outer calendars: [Calendar entities](/dynamics365/customerengagement/on-premises/developer/calendar-entities) |
|CalendarId	|GUID	|Yes|	This field describes the **CalendarId** of the entity. |
|IsVaried	|Boolean	|No	|This field is specific to recurrences, and is set to `yes` if a custom recurrence rule is being deleted. |
|UseV2	| Flag |	No|	Passing this flag enables the V2 version of the work hour calendar, with an enhanced overlapping rules logic allowing for multiple recurrences. For more information, see [What happens if there are overlapping rules?](#what-happens-if-there-are-overlapping-rules).|

### Output

This POST API deletes calendar rule records for the selected entity. Additionally, it gives the following output.

|Name |	Type|	Description|
|:--|:--|:--|
|InnerCalendarIds|	String|	An array of **InnerCalendarIds** GUIDs that are a result of the POST operation.|

## How to call the APIs

These APIs can be called by using the browser.

1. Open the browser and the org in which you need to make these calendar changes.
2. Open Developer Tools (select **Ctrl**+**Shift**+**I** in Microsoft Edge, select **F12** in Google Chrome).
3. In the console, enter the following function, after replacing [org-name] with org details (for example, `http://your_org.crm.dynamics.com`):

```
       function CalendarAction(action, data) {
           let req = new XMLHttpRequest();
           req.open("POST", "**[org-name]**/api/data/v9.0/" + action, true);
           req.setRequestHeader("OData-MaxVersion", "4.0");
           req.setRequestHeader("OData-Version", "4.0");
           req.setRequestHeader("Accept", "application/json");
           req.setRequestHeader("Content-Type", "application/json; charset=utf-8");
           req.setRequestHeader("Prefer", 'odata.include-annotations="*"');
           req.onreadystatechange = function () {
               if (this.readyState === 4) {
                   req.onreadystatechange = null;
                   if(this.status == 200) {
                       console.log(JSON.parse(this.response));
                   } else {
                       console.error(JSON.parse(this.response));
                   }
               }
           };
           req.send(JSON.stringify(data));
       }
```

4. After this function is defined, you can call it to create, edit, or delete calendars by using the APIs. Enter the following call:

```
       CalendarAction("msdyn_SaveCalendar", {"CalendarEventInfo":"{\"CalendarId\":\"df0857c4-50f5-4576-8e89-f236670ad2d5\",\"EntityLogicalName\":\"bookableresource\", \"TimeZoneCode\":92,\"StartDate\":\"2021-04-25T00:00:00.000Z\",\"IsVaried\":false,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-04-25T08:00:00.000Z\",\"EndTime\":\"2021-04-25T17:00:00.000Z\",\"Duration\":540,\"Effort\":1}]}]}"})
```

See the following section for examples of how to make different calls based on your needs. Replace the `action` of the function call in step 3 with `msdyn_SaveCalendar` or `msdyn_DeleteCalendar`, and replace `data` with the relevant `CalendarEventInfo`.

## Example scenarios for API usage

Let's walk through some scenarios that you can use these APIs for.

Bob and Tim are delivery truck drivers for Contoso Enterprises in Bellevue, Washington. Their dispatcher, Debbie, is responsible for making changes to their work hour calendars. Debbie makes these changes by using the `msdyn_SaveCalendar` and `msdyn_DeleteCalendar` APIs.

### Create a working hour occurrence.

Bob is scheduled to drive around to deliver packages from 9:00 AM to 5:00 PM on May 15, 2021. Debbie uses the `msdyn_SaveCalendar` API.

**Request**

```
> `{
 "CalendarEventInfo": "{\"CalendarId\":\"d33263c7-c16b-4e3e-a56a-20f7a66cafc1\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-15T09:00:00.000Z\",\"EndTime\":\"2021-05-15T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}]}]}"
}`
```

**Response**

```
>`{
  "InnerCalendarIds": "[\"f76cc333-cbbe-eb11-a81d-000d3a6e4359\"]"
}`
```

### Edit a working hour occurrence.

Bob's schedule then changes to start at 10:00 AM on May 15, 2021. Debbie uses the `msdyn_SaveCalendar` API.

**Request**

```
>  ` {
 "CalendarEventInfo": "{\"CalendarId\":\"d33263c7-c16b-4e3e-a56a-20f7a66cafc1\",\"EntityLogicalName\":\"bookableresource\",\"IsEdit\":\"true\",\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-15T10:00:00.000Z\",\"EndTime\":\"2021-05-15T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}], \"InnerCalendarId\":\"f76cc333-cbbe-eb11-a81d-000d3a6e4359\"}]}"
}`

```

**Response**

```
> ` {
  "InnerCalendarIds": "[\"f76cc333-cbbe-eb11-a81d-000d3a6e4359\"]"
} `
```

### Delete a working hour occurrence.

A family emergency comes up, and Bob needs to cancel an entire day of work. Debbie uses the `msdyn_DeleteCalendar` API.

**Request**

```
>  ` {
 "CalendarEventInfo": "{\"CalendarId\":\"d33263c7-c16b-4e3e-a56a-20f7a66cafc1\",\"EntityLogicalName\":\"bookableresource\",\"InnerCalendarId\":\"f76cc333-cbbe-eb11-a81d-000d3a6e4359\"}"
} `
```

**Response**

```
> ` {
  "InnerCalendarIds": "[\"f76cc333-cbbe-eb11-a81d-000d3a6e4359\"]"
} `
```


### Create a working hour daily recurrence

Starting May 20, 2021, Bob decides to work with Contoso all week from 8:00 AM to 5:00 PM, and will stop working there on July 15, 2021.

**Request**

```
> `  {
 "CalendarEventInfo": "{\"CalendarId\":\"d33263c7-c16b-4e3e-a56a-20f7a66cafc1\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RecurrenceEndDate\":\"2021-07-15T00:00:00.000Z\",\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-20T08:00:00.000Z\",\"EndTime\":\"2021-05-20T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=SU,MO,TU,WE,TH,FR,SA\"}]}"
} `
```

**Response**

```
> ` {
  "InnerCalendarIds": "[\"20f6cfa7-cfbe-eb11-a81d-000d3a6e4359\"]"
} `
```


### Edit a working hour daily recurrence with increased capacity

Bob decides to stop working for the entire week of June 15, 2021 to take a break. Until then, Bob will continue the all-week schedule as previously agreed to. Debbie makes these changes by using the `msdyn_SaveCalendar` API.

**Request**

```
> `  {
 "CalendarEventInfo": "{\"CalendarId\":\"d33263c7-c16b-4e3e-a56a-20f7a66cafc1\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RecurrenceEndDate\":\"2021-06-15T00:00:00.000Z\",\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-20T08:00:00.000Z\",\"EndTime\":\"2021-05-20T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"InnerCalendarId\":\"20f6cfa7-cfbe-eb11-a81d-000d3a6e4359\",\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=SU,MO,TU,WE,TH,FR,SA\"}]}"
} `
```


**Response**

```
> ` {
  "InnerCalendarIds": "[\"867a2461-cdbe-eb11-a81d-000d3a6e4359\"]"
} `
```

### Create a working hour weekly recurrence

Starting from June 16, 2021, Bob will work from 8:00 AM to 5:00 PM on Wednesdays and Fridays, and will take a break from 12:00 PM to 12:30 PM for lunch. Debbie uses the `msdyn_SaveCalendar` API, but makes a mistake, and schedules the break from 12:00 PM to 1:00 PM.

**Request**

```
>  ` {
  "CalendarEventInfo": "{\"CalendarId\":\"d33263c7-c16b-4e3e-a56a-20f7a66cafc1\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-06-16T08:00:00.000Z\",\"EndTime\":\"2021-06-16T12:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}, {\"StartTime\":\"2021-06-16T12:00:00.000Z\",\"EndTime\":\"2021-06-16T13:00:00.000Z\",\"Effort\":null,\"WorkHourType\":1}, {\"StartTime\":\"2021-06-16T13:00:00.000Z\",\"EndTime\":\"2021-06-16T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=WE,TH,FR\"}]}"
}`
```

**Response**

```
> ` {
  "InnerCalendarIds": "[\"1f894441-d0be-eb11-a81d-000d3a6e4359\"]"
} `
```

### Edit a break from a working hour weekly recurrence

Debbie then corrects the mistake and changes the break to occur from 12:00 PM to 12:30 PM by using the `msdyn_SaveCalendar` API.

**Request**

```
> `  {
  "CalendarEventInfo": "{\"CalendarId\":\"d33263c7-c16b-4e3e-a56a-20f7a66cafc1\",\"EntityLogicalName\":\"bookableresource\",\"IsEdit\":\"true\",\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-06-15T08:00:00.000Z\",\"EndTime\":\"2021-06-15T12:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}, {\"StartTime\":\"2021-06-15T12:00:00.000Z\",\"EndTime\":\"2021-06-15T12:30:00.000Z\",\"Effort\":null,\"WorkHourType\":1}, {\"StartTime\":\"2021-06-15T12:30:00.000Z\",\"EndTime\":\"2021-06-15T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"InnerCalendarId\":\"1f894441-d0be-eb11-a81d-000d3a6e4359\",\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=WE,TH,FR\"}]}"
} `
```

**Response**

```
>  `{
  "InnerCalendarIds": "[\"1f894441-d0be-eb11-a81d-000d3a6e4359\"]"
}`
```

### Create a working hour custom recurrence

Tim works for Contoso on Mondays from 8:00 AM to 5:00 PM, and Wednesdays from 11:00 AM to 3:00 PM. Tim started working fo Contoso on May 16, 2021. Debbie uses the `msdyn_SaveCalendar` API to create Tim's work hours.

**Request**

```
> `  {
"CalendarEventInfo": "{\"CalendarId\":\"a68245c9-ba2e-4496-9c18-3bee75fda396\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"IsVaried\":true,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-16T08:00:00.000Z\",\"EndTime\":\"2021-05-16T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"Action\":1,\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=MO\"},{\"Rules\":[{\"StartTime\":\"2021-05-16T11:00:00.000Z\",\"EndTime\":\"2021-05-16T15:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"Action\":1,\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=WE\"}]}"
}`
```

**Response**

```
> ` {
  "InnerCalendarIds": "[\"9fb8c199-d1be-eb11-a81d-000d3a6e4359\", \"a2b8c199-d1be-eb11-a81d-000d3a6e4359\"]"
}`
```


### Edit a working hour custom recurrence

Tim's schedule then changes to work hours from Wednesdays 5:00 PM to 8:00 PM, and Thursday 10:00 AM to 12:00 PM. Monday is removed from Tim's schedule. Debbie uses the `msdyn_SaveCalendar` API to achieve this.

**Request**

```
> ` {
"CalendarEventInfo": "{\"CalendarId\":\"a68245c9-ba2e-4496-9c18-3bee75fda396\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"IsVaried\":true,\"IsEdit\":true,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-16T08:00:00.000Z\",\"EndTime\":\"2021-05-16T17:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"Action\":2,\"InnerCalendarId\":\"9fb8c199-d1be-eb11-a81d-000d3a6e4359\",\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=MO\"},{\"Rules\":[{\"StartTime\":\"2021-05-16T17:00:00.000Z\",\"EndTime\":\"2021-05-16T20:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"Action\":3,\"InnerCalendarId\":\"a2b8c199-d1be-eb11-a81d-000d3a6e4359\",\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=WE\"}, {\"Rules\":[{\"StartTime\":\"2021-05-16T10:00:00.000Z\",\"EndTime\":\"2021-05-16T12:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}],\"Action\":1,\"InnerCalendarId\":null,\"RecurrencePattern\":\"FREQ=WEEKLY;INTERVAL=1;BYDAY=TH\"}]}"
}`
``` 

**Response**

```
> ` {
  "InnerCalendarIds": "[\"a2b8c199-d1be-eb11-a81d-000d3a6e4359\", \"942bda0f-d3be-eb11-a81d-000d3a6e4359\"]"
}`
```


### Edit a working hour occurrence in a recurrence

On May 26, 2021, Tim is only able to work from 1:00 PM to 7:00 PM. Debbie uses the `msdyn_SaveCalendar` API here.

**Request**

```
>  ` {
 "CalendarEventInfo": "{\"CalendarId\":\"a68245c9-ba2e-4496-9c18-3bee75fda396\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-26T13:00:00.000Z\",\"EndTime\":\"2021-05-26T19:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}], \"InnerCalendarId\":\"a2b8c199-d1be-eb11-a81d-000d3a6e4359\"}]}"
}`
```

**Response**

```
> ` {
  "InnerCalendarIds": "[\"a2b8c199-d1be-eb11-a81d-000d3a6e4359\"]"
} `
```


### Delete a working hour custom recurrence

Tim has decided to leave the company and has to delete their entire schedule. Debbie uses the `msdyn_DeleteCalendar` API here.

**Request**

```
>  ` {
 "CalendarEventInfo": "{\"CalendarId\":\"a68245c9-ba2e-4496-9c18-3bee75fda396\",\"EntityLogicalName\":\"bookableresource\",\"InnerCalendarId\":\"34d2210c-9fb6-eb11-a820-000d3afb1dba\",\"IsVaried\":true}"
} `
```

**Response**

```
> ` {
  "InnerCalendarIds": "[\"a2b8c199-d1be-eb11-a81d-000d3a6e4359\", \"942bda0f-d3be-eb11-a81d-000d3a6e4359\"]"
} `
```


### Create time off

Tim will be taking three days off for a family vacation starting on June 9, 2021.

**Request**

```
>  ` {
 "CalendarEventInfo": "{\"CalendarId\":\"a68245c9-ba2e-4496-9c18-3bee75fda396\",\"InnerCalendarDescription\":\"Family Vacation\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-06-15T00:00:00.000Z\",\"EndTime\":\"2021-06-17T00:00:00.000Z\",\"Effort\":1,\"WorkHourType\":3}]}]}"
} `
```

**Response**

```
> ` {
  "InnerCalendarIds": "[\"266c434e-d5be-eb11-a81d-000d3a6e4359\"]"
} `
```

### Create all-day working hours

Tim has a 72-hour shift starting May 20, 2021. Debbie uses the `msdyn_SaveCalendar` API to create Tim's work hours.

**Request**

```
> `{
 "CalendarEventInfo": "{\"CalendarId\":\"a68245c9-ba2e-4496-9c18-3bee75fda396\",\"EntityLogicalName\":\"bookableresource\",\"TimeZoneCode\":5,\"RulesAndRecurrences\":[{\"Rules\":[{\"StartTime\":\"2021-05-20T00:00:00.000Z\",\"EndTime\":\"2021-05-22T00:00:00.000Z\",\"Effort\":1,\"WorkHourType\":0}]}]}"
}`
``` 

**Response**

```
> ` {
  "InnerCalendarIds": "[\"6e160a8e-d5be-eb11-a81d-000d3a6e4359\"]"
}`
``` 

## FAQs

### I'm getting the error, "StartTime cannot be greater or equal to EndTime."

Make sure there are no overlaps in the time slots of the different calendar rules. Check the dates to make sure **StartTime** isn't later than **EndTime**. Also, verify that the times follow the 24-hour format. 

### Can the APIs be used to update the "Work Hour Templates" entity?

Yes, you can use this API to create and update work hour templates in addition to resource work hours.

**I'm getting the error, "There was an error deserializing the object of type Microsoft.Dynamics.UCICalendar.Plugins.SaveCalendarContract+CalendarEventInfo. The input source is not correctly formatted.**<br>
or<br>**Expecting state 'Element'.. Encountered 'Text' with name '', namespace ''."**

Make sure that the string is parsed correctly. There might be missing brackets, commas, or semicolons.

### I'm getting the error, "Invalid recurrence pattern. Please refer to the documentation for supported patterns."

We currently only support this pattern: `FREQ=DAILY;INTERVAL=1;BYDAY=SU,MO,TU,WE,TH,FR,SA`. `BYDAY` can be changed to include fewer days; however, `FREQ` and `INTERVAL` can't be changed. Make sure there are no spaces in the pattern.

### How do we get information of the CalendarId and the InnerCalendarId of the resource?

The `CalendarId` can be retrieved from resource attributes. Make this call to get this information: `[org-url]/api/data/v9.1/bookableresources([bookableresourceGUID])`. 

An example of the previous call would be `http://aurorav69662.aurorav69662dom.extest.microsoft.com/CITTest/api/data/v9.1/bookableresources(7bb0224b-6712-ec11-94f9-000d3a6d888e)`.

The `InnerCalendarId` can be retrieved from calendar attributes. Make this call to get this information: `[org-url]/api/data/v9.1/calendars([calendar-id-from-above-call])?$expand=calendar_calendar_rules`. 

An example of the previous call is `http://aurorav69662.aurorav69662dom.extest.microsoft.com/CITTest/api/data/v9.1/calendars(02481736-1b6a-4d49-9ebd-a5bd041c1c99)?$expand=calendar_calendar_rules`.

### What happens if there are overlapping rules?

There are a couple different ranks that rules fall under: 

- *Rank 1* - daily occurrence (working/non-working), and time off occurrence. 
- *Rank 0* - weekly recurrence (working/non-working). 
 
#### V2 overlapping rules (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

- The Rank 1 rules have a higher priority than Rank 0 rules. if there are two rules (one of each rank) on the same day, the daily occurrence or time-off occurrence will take the priority over the weekly recurrence.
- When there are multiple Rank 0 rules within the same date span:
  - If the times don't intersect, they will both remain on the calendar.
  - If the times intersect, the rule that was most recently created/modified will be the one that is considered for the resource’s calendar. All other intersecting rules in the date span are removed. In the event that some rank 0 rules have intersections on some dates but not on others, the rule will be spliced to retain the non-intersecting sections, while the intersecting portions will be removed.

Examples of V2 calendar behavior:

##### Example 1 - Repeating work hours: Overlapping dates with no overlapping days/times

For a given date span, a technician works morning, afternoon, or night shifts across different days.

1. Create a first repeating calendar rule for a given date range. For example: *Repeat Mon, Tue; 1.1-4.1; 8am-5pm ET*.

2. Create a second repeating calendar rule for an intersecting date range, while ensuring that the work hours do not intersect with the previous days or times. For example: *Repeat Wed, Thu; 1.1-4.1; 8am-5pm ET* or *Repeat Mon, Tue; 1.1-4.1; 5pm-8pm ET*.

Result: Both calendar rules remain and coexist alongside each other.

##### Example 2 - Repeating Work Hours: Some overlapping dates, with all overlapping days and second rule starts/ends before or after the first rule

A technician gets a new work schedule, which replaces some weeks of his old schedule. By contract he always works the same days every week.

1. Create a first repeating calendar rule for a given date range. For example: *Repeat Mon, Tue; 2.1-4.1; 8am-5pm ET*.

2. Create a second repeating calendar rule for an overlapping date range, where all days have overlapping work hours. Choose start/end dates for this new rule that are before or after the start/end date for the fist rule. For example: *Repeat Mon, Tue; 3.1-5.1; 1pm-8pm ET*.

Result: The first rule gets truncated to accommodate the start/end date of the second rule. For example: *Repeat Mon, Tue; 2.1-2.28; 8am-5pm ET* AND *Repeat Mon, Tue; 3.1-5.1; 1pm-8pm ET*.

##### Example 3 - Repeating Work Hours: All overlapping dates, with some overlapping days/times

The technician is a contract worker for a fixed 2-month period. They have agreed to take on additional work on some days. They want to shift the Tuesday work hours to an earlier/later time.

1. Create some repeating calendar rules for a given date range. For example: *Repeat Mon, Tue; 2.1-4.1; 8am-12pm ET* AND *Repeat Tue, Wed; 2.1-4.1, 1pm-5pm ET*.

2. Create a new repeating calendar rule for the same date range. Choose days/times that partially overlap with the original rules. For example: *Repeat Tue,Thurs ; 2.1-4.1; 10am-2pm ET*.

Result: The new rule overwrites the old where there are overlaps, and leaves the others unchanged. For example: *Repeat Mon; 2.1-4.1; 8am-12pm ET* AND *Repeat Wed; 2.1-4.1; 1pm-5pm ET* AND *Repeat Tue,Thurs ; 2.1-4.1; 10am-2pm ET*.

##### Example 4 - Repeating Work Hours: New rule dates contained within old rule, some overlapping days/times

A technician works 8am-5pm, Mon-Fri every week. Just for 2 weeks, they will be handling a special emergency project every Mon-Wed with different work hours 6am-6pm.

1. Create a first repeating calendar rule for a given date range. For example: *Repeat Mon,Tue,Wed,Thu,Fri; 1.1-No End Date; 8am-5pm ET*.

2. Create a second repeating calendar rule contained within the above date range, choose work hours that overlap on some days. For example: *Repeat Mon,Tue,Wed; 5.1-5.14; 6am-6pm ET*.

Result: The calendar should have 4 repeating rules by the end of this exercise:

- truncate the first rule to the start date of the second rule
- the 2nd calendar rule
- create a new rule similar to the first rule but with the dates of the second rule for the non-overlapping days
- truncate the 1st rule to start from the end date of the 2nd rule, with no end date

For example: *Repeat Mon,Tue,Wed,Thu,Fri; 1.1–4.30; 8am-5pm ET* AND *Repeat Mon,Tue,Wed; 5.1-5.14; 6am-6pm ET* AND *Repeat Thu,Fri, 5.1-5.14; 8am-5pm ET* AND *Repeat Mon,Tue,Wed,Thu,Fri; 5.15–No End Date; 8am-5pm ET*

##### Example 5 - Non-repeating work hours (occurrence, rank 1 rule)

A technician has a number of team cohesion days, which take precedence over all other work hour instances for the day.

1. Create a repeating calendar rule for a given date range. For example: *Repeat Mon,Tue,Wed,Thu,Fri; 1.1-No End Date; 8am-5pm ET*.

2. Create a non-repeating calendar rule contained within the above date range. Choose work hours that overlap on some days. For example: *Non-repeat; 6.21; 7am-1pm ET*.

Result: The calendar should have 1 non-repeating rule (occurrence) by the end of the exercise. The non-repeating rule will override the overlapping repeat event for the entire day.
For example: *Repeat Mon,Tue,Wed,Thu,Fri; 1.1-No End Date* except *6.21; non-repeat; 6.21; 7am-1pm ET*.

#### V1 overlapping rules

- The Rank 1 rules have a higher priority than Rank 0 rules. So if there were two rules (one of each rank) on the same day, the daily occurrence or time-off occurrence will take the priority over the weekly recurrence. 
- If there are two rules of the same rank, the rule that was most recently created/ modified will be the one that is considered for the resource's calendar. 
- Keep in mind that all-day occurrences are of Rank 1, so you may want to consider changing it to a weekly recurrence in order to be able to add occurrence work hours and have them be respected. 
- When a working hour exists and a time off occurrence is created overlapping it, the rules split in a way that ensures the time off is respected, and any remaining time as working hours will stay as is. For example, if there are working hours from 8 AM to 5 PM on September 21, and a time-off occurrence is added from 3 PM to 7 PM on September 21, this would be resolved as working hours as 8 PM to 3 PM and time off from 3 PM to 7 PM. However, if the rules were created in the opposite order (time off created first and then working hours were created) regardless of the timeslots, only the working hour would be reselected. The time off would be overridden. 

## Time zone codes

|Enum | Time zone |
|--|--|
0                   | (GMT-12:00) International Date Line West
1                   | (GMT+13:00) Samoa
2                   | (GMT-10:00) Hawaii
3                   | (GMT-09:00) Alaska
4                   | (GMT-08:00) Pacific Time (US &amp; Canada)
5                   | (GMT-08:00) Baja California
6                   | (GMT-11:00) Coordinated Universal Time-11
7                   | (GMT-10:00) Aleutian Islands
8                   | (GMT-09:30) Marquesas Islands
9                   | (GMT-09:00) Coordinated Universal Time-09
10                  | (GMT-07:00) Mountain Time (US &amp; Canada)
11                  | (GMT-08:00) Coordinated Universal Time-08
12                  | (GMT-07:00) Chihuahua, La Paz, Mazatlan
15                  | (GMT-07:00) Arizona
20                  | (GMT-06:00) Central Time (US &amp; Canada)
25                  | (GMT-06:00) Saskatchewan
29                  | (GMT-06:00) Guadalajara, Mexico City, Monterrey
33                  | (GMT-06:00) Central America
34                  | (GMT-06:00) Easter Island
35                  | (GMT-05:00) Eastern Time (US &amp; Canada)
40                  | (GMT-05:00) Indiana (East)
43                  | (GMT-05:00) Haiti
44                  | (GMT-05:00) Havana
45                  | (GMT-05:00) Bogota, Lima, Quito, Rio Branco
47                  | (GMT-04:00) Caracas
50                  | (GMT-04:00) Atlantic Time (Canada)
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
203                 | (GMT+06:30) Yangon (Rangoon)
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

