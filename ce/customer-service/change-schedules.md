---
title: "Impact of change in customer service or holiday schedule (Dynamics 365 Customer Service) | MicrosoftDocs"
description: "Learn how to resolve impact on business because of a change in customer service or holiday schedule in Dynamics 365 Customer Service."
ms.date: 03/04/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Impact of change in customer service or holiday schedule

## Introduction
AFter you have created Customer service schedule and holiday schedules. More information: ref to CS and HS topics. However, if there is a change to the CS and holiday schedules of the SLA because of certain reasons, the best practices that you can follow have been listed in this topic. 

## How does the time calculation of SLA work, using CS and Holiday schedule?


The Time Calculation in SLA refers to calculating the Warning time and failure time of SLA KPI instances. They are calculated based on the customer service schedule and the holiday schedule associated with the SLA KPI instance.
Example:
Working hours are 9AM - 5 PM (8 hours daily)
Holiday calendar has Tomorrow marked as holiday.
Failure Duration is 12 hours.
Case is created today on 10 AM.
So after time calculation, the failure duration will be day after tomorrow 14:00 (2 PM).
Logic: Today working hours 5PM – 10AM = 7 Hours, which leaves 5 hours for tomorrow (failure duration- hours consumed today)
Skip Tomorrow as its Holiday.
Day after Tomorrow : 9 AM + 5 hours= 14:00 (2 PM)

Apart from WarningTime and FailureTime calculation, SLA Time Calculation also involves calculating the elapsed time if there is a pause and resume scenario. It will add the elapsed time into final failure time to ignore the working hours spent during the Paused State.


## Impact of change to CS or Holiday schedule of the SLA

Whenever any SLA KPI instance is created, it will use the above information and creates Warning Time and Failure Time. So, changing the calendar working hours will not impact the existing KPI instances unless one of below events occurs
-Pause/Resume scenario
-SLA changed scenario
-SLA Item is changed
-SLA KPI instance is reapplied after terminal state (in case of Recalculation on Terminal State)

As in above scenarios, It will read the latest calendar information and values will be re-calculated with new customer service schedule and the holiday schedule.
If you want to change the existing customer service schedule which is already in use in the existing SLA KPI instances, you can follow the following suggestions.
Disclaimer: Please validate all business scenarios and use cases to ensure all the use-cases are met before applying the changes to production.

If you have any one of these scenarios, where a change occurs to the CS or holiday schedule because of the defined conditions, you can resolve it by applying the solutions that are provided below.
Note: Check your business scenarios to see whether they are falling under any one of these 4 categories or not.

## Scenarios

**Scenario 1:**
Only 1 SLA as Default
•	  1 Calendar
•	  multiple SLA items.
•	  No Pause and Resume scenario/ or with Pause & Resume state.
•	  No need to update existing running KPI instances.
•	Suggestion: Don't modify the existing SLA and calendar. let this old SLA in active state on the prod org. Create similar SLA with new calendar, and same kind of SLA items (conditions/actions).
Activate the new SLA and set as Default.
This will ensure that all the new Cases will be created with new SLA and time calculation will be done with new Calendar information.
•	Note: if you are not using Default SLA, please update your logic to update the slaid in Case entity accordingly. Please refer documentation for "Apply SLA on demand "

**Scenario 2**
•	  Multiple SLA
•	  Multiple Calendars
•	  multiple SLA items.
•	  No Pause and Resume scenario / or with Pause & Resume state.
•	  No need to update existing running KPI instances.
•	Suggestion:
Don't modify the existing SLAs and calendars. let this old SLAs in active state on the prod org as it is. Create similar SLAs with new calendars, and same kind of SLA items (conditions/actions). Activate the new SLAs .
This will ensure that all the new Cases will be created with new SLA and time calculation will be done with new Calendar information.
•	Please update your logic to update the slaid in Case entity accordingly. Please refer documentation for "Apply SLA on demand "

**Scenario 3**
•	  Multiple SLA
•	  Multiple Calendars
•	  Multiple SLA items.
•	  No Pause and Resume scenario
•	  Need to update existing running KPI instances.
•	Suggestion:
Modify the existing calendars. This will ensure that all the new Cases will be created with same SLA and time calculation will be done with new Calendar information.
But for existing running KPI instances will not consider new calendar automatically. So you have to simulate an event to allow the KPI instance to pick the new calendar.
For e.g. introduce the Pause state and trigger a quick Pause & then Resume update on the case. This will trigger the KPI instance to pick the new calendar information.
To simulate this Pause & Resume, either u can allow the end user to do this update on each case one by one or write a custom logic to run this update in dark hours.
For e.g. a flow can run in dark hours, which can have the following logic
•	  Find the associated SLA from a calendar which needs to be updated.
•	  Find all the incidents which have same slaid field value as above SLA (do in batches to avoid running into scalability issues)
•	  Do a update on the case which puts it into a Paused state
•	  Do next update on the case which puts it back into Resume
•	Note: This will be intensive operation based on the SLA KPI instances and incidents in your environment.
•	Please refer documentation for "Apply SLA on demand "

**Scenario 4**
•	  Multiple SLA
•	  Multiple Calendars
•	  Multiple SLA items.
•	  Has Pause and Resume scenario
•	  Need to update existing running KPI instances.
•	Suggestion: Partially supported scenario
This will cause unexpected results for those KPI instances which were put into Paused/Resumed state before new calendar was applied.
As those instances might have calculated elapsed time during pause/resume with old calendars already, so the final calculation will be partly with old calendar and partly with new calendar.




### See also

[Create a customer service schedule and define the work hours](../customer-service/create-customer-service-schedule-define-work-hours.md)  

[Create and manage holiday schedules](set-up-holiday-schedule.md#create-and-manage-holiday-schedules)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
