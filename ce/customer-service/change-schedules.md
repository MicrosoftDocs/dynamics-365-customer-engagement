---
title: "Impact of change in customer service or holiday schedule of SLA KPIs (Dynamics 365 Customer Service) | MicrosoftDocs"
description: "Learn how to manage business impact because of a change in customer service or holiday schedule in Dynamics 365 Customer Service."
ms.date: 03/07/2022
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

# Manage changes to customer service and holiday schedules of existing SLA KPIs

## Introduction

This topic describes how you can manage changes to the customer service and holiday schedules of your existing SLA KPIs.

## Understand time calculation of SLA KPIs

To manage changes to customer service and holiday schedules of your SLA KPIs, you must first understand how time calculation works for SLA KPIs. The time calculation for SLA KPIs depends on the Warning and Failure time, which are based on the customer service and holiday schedules associated with the SLA KPI instance.

Here is an example of a SLA KPI that describes how time calculation works. The conditions set for the SLA KPI are as follows:
- Defined working hours: 9 AM to 5 PM (8 hours daily)
- Failure duration: 12 hours
- Holiday calendar: The next day is marked as a holiday
- Case is created today at 10 AM

So, after time calculation, the failure duration will be the day after the next day at 14:00 (2 PM). The remaining working hours for the day are 5PM – 10AM = 7 hours, which leaves 5 hours for the next day (calculated as failure duration - hours consumed today). The next day gets skipped as it is a Holiday. So, the failure duration will be day after the next day: 9 AM + 5 hours= 14:00 (2 PM).

For more information on creating customer service schedules, see: [Create customer service schedule and define the work hours](create-customer-service-schedule-define-work-hours.md#create-customer-service-schedule-and-define-the-work-hours), 
and creating holiday schedules, see: [Create and manage holiday schedules](set-up-holiday-schedule.md#create-and-manage-holiday-schedules).

Apart from  Warning and Failure time calculation, SLA time calculation also involves calculating the Elapsed time, if there is a Pause and Resume scenario. The elapsed time is added to the final failure time to ignore the working hours spent during the Paused state.

## Scenarios and recommendations

Whenever any SLA KPI instance is created, the Warning and Failure time is created depending on the factors described in the [Understand time calculation of SLA KPIs](#understand-time-calculation-of-sla-kpis) section. So, a change in the calendar working hours doesn't impact the existing KPI instances.

However, you may have the following scenarios which affect the existing KPI instances:

- Pause or Resume
- Change in SLA 
- Change in the SLA item
- SLA KPI instance is reapplied after terminal state (in case of Recalculation on Terminal State)

In the above scenarios, the latest calendar information and values are re-calculated with the new customer service schedule and the holiday schedule. 

However, if you want to change the existing customer service and holiday schedule which is already in use in the existing SLA KPI instances, you can implement the recommendations provided in the following section.  

> [!NOTE]
> Please validate all the scenarios and the recommendations to ensure that all the conditions are met before applying the changes to your production environment.

## Scenarios

**Scenario 1:**

Conditions: 
- Only 1 SLA KPI is set as Default.
-	1 Calendar
-	Multiple SLA items
-	With or without a Pause and Resume scenario.
-	There is no need to update existing running KPI instances.

Recommendation:
 
- Don't modify the existing SLA and calendar. The earlier SLA can continue to remain in Active state on the production environment. Create a similar SLA with a new calendar and the same kind of SLA items.
- Activate the new SLA and set as Default. This will ensure that all the new cases are created with the new SLA and time calculation will be done with the new calendar information.

> [!NOTE]
> If you are not using a Default SLA, update your SLA condition to update the SLA ID in the Case entity accordingly. More information: [Apply SLAs on demand](define-service-level-agreements.md#apply-slas-on-demand).

**Scenario 2**

Conditions: 
- Multiple SLA
- Multiple calendars
- Multiple SLA items
- With or without a Pause and Resume scenario.
- No need to update existing running KPI instances.

Recommendation:

- Don't modify the existing SLAs and calendars. The earlier SLAs can continue to remain in Active state on the production org. Create similar SLAs with a new calendar and the same kind of SLA items. 
- Activate the new SLAs. This will ensure that all the new cases are created with the new SLA and time calculation will be done with the new calendar information.
- Update your SLA conditions to update the SLA ID in the case entity accordingly. More information: [Apply SLAs on demand<a name="apply-sla-on-demand"></a>](define-service-level-agreements.md#apply-slas-on-demand).

**Scenario 3**

Conditions: 
- Multiple SLA
- Multiple Calendars
- Multiple SLA items
- No Pause and Resume scenario
- Need to update existing running KPI instances.

Recommendation:

Modify the existing calendars. This will ensure that all the new cases are created with same SLA and time calculation is done with the new calendar information. However, the existing running KPI instances won't calculate the time based on the new calendar automatically. You will need to initiate an event for the KPI instance to pick the new calendar.

For example, introduce the Pause state and trigger a quick Pause and then Resume update on the case. This will trigger the KPI instance to pick the new calendar information. To initiate the Pause and Resume, you can either allow the end user to do this update on each case one by one or write a custom logic to run this update in dark hours.

For example, a flow can run in dark hours, with the following logic:
- Find the associated SLA from a calendar which needs to be updated.
- Find all the incidents which have same SLA ID field value as the above SLA. You can do this in batches to avoid running into scalability issues.
- Do a update on the case to put it in a Paused state.
- Do the next update on the case which puts it back into Resume.

> [!NOTE]
> This will be an intensive operation based on the SLA KPI instances and incidents in your environment.

More information: [Apply SLAs on demand<a name="apply-sla-on-demand"></a>](define-service-level-agreements.md#apply-slas-on-demand).

**Scenario 4**

Conditions: 
- Multiple SLA
- Multiple Calendars
- Multiple SLA items
- Has Pause and Resume scenario
- Need to update existing running KPI instances.

Recommendation:

This is a partially supported scenario and will cause unexpected results for those KPI instances which were put into Paused or Resumed state before the new calendar was applied.
As those instances might have calculated elapsed time during pause/resume with old calendars already, so the final calculation will be partly with old calendar and partly with new calendar.

### See also

[Create a customer service schedule and define the work hours](../customer-service/create-customer-service-schedule-define-work-hours.md)  

[Create and manage holiday schedules](set-up-holiday-schedule.md#create-and-manage-holiday-schedules)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
