---
title: "Manage the impact of changes to customer service or holiday schedules of SLA KPIs (Dynamics 365 Customer Service) | MicrosoftDocs"
description: "Learn how to manage the impact of a change to customer service or holiday schedules in Dynamics 365 Customer Service."
ms.date: 04/04/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Manage changes to customer service and holiday schedules of existing SLA KPIs

## Introduction

This topic describes how you can manage changes to the customer service and holiday schedules of your existing service-level agreements (SLA) key performance indicators (KPIs).

## Understand time calculation of SLA KPIs

To manage changes to the customer service and holiday schedules of your SLA KPIs, you must first understand how time calculation works for SLA KPIs. The time calculation for SLA KPIs depends on the warning and failure time, and the customer service and holiday schedules associated with the SLA KPI item. 

The following is an example of a SLA KPI that describes how time calculation works. The configurations set for the SLA KPI are as follows:
- Defined working hours: 9 AM to 5 PM (8 hours daily)
- Failure duration: 12 hours
- Holiday calendar: The next day is marked as a holiday.
- The case was created today at 10 AM.

So, after time calculation, the failure duration will be the day after the next day at 14:00 (2 PM). This is calculated by considering the remaining hours for the day; that is, 5 PM – 10 AM = 7 hours, which leaves 5 hours for the next day (calculated as failure duration – hours consumed today). The next day doesn't get calculated because it's a holiday. So, the failure duration will be the day after the next day: 9 AM + 5 hours = 14:00 (2 PM).

For more information about creating customer service schedules, go to: [Create customer service schedule and define the work hours](create-customer-service-schedule-define-work-hours.md#create-customer-service-schedule-and-define-the-work-hours). For more information about creating holiday schedules, go to: [Create and manage holiday schedules](set-up-holiday-schedule.md#create-and-manage-holiday-schedules).

Apart from warning and failure time calculation, SLA time calculation also involves calculating *elapsed time*, which is the period when the SLA KPIs are paused and resumed. To ignore the working hours spent while the SLA KPIs were in a paused state, elapsed time is used in calculating the final failure duration.

## Scenarios and recommendations

Whenever any SLA KPI instance is created, the warning and failure times are created, depending on the factors described in the [Understand time calculation of SLA KPIs](#understand-time-calculation-of-sla-kpis) section. A change in the calendar working hours won't affect the existing KPI instances.

However, you might have the following scenarios, which will affect the existing KPI instances:

- Pausing and resuming the SLA KPI instance.
- Updating the SLA on the target entity.
- A change in the SLA item.
- Reapplying the SLA KPI instance after the terminal state (in case of Recalculation on Terminal State).

In the above scenarios, the warning time and the failure time of the SLA KPIs are recalculated by using the new customer service schedule and the holiday schedule. However, if you want to change the existing customer service and holiday schedules that are already in use in the existing SLA KPI instances, you can implement the recommendations that are provided in the following section.  

> [!NOTE]
> Before applying the changes to your production environment, you must validate all the scenarios and the recommendations to ensure that all the conditions are met.

**Scenario 1:**

Conditions: 

- Only one SLA KPI is set as the default.
-	One calendar needs to be associated.
-	Multiple SLA items.
-	With or without a pause and resume scenario.
-	No need to update existing, running KPI instances.

Recommendation:
 
1. Don't modify the existing SLA and calendar. The existing SLA can continue to remain in an active state in the production environment. Create a similar SLA with a new calendar and the same kind of SLA items.

1. Activate the new SLA and set it as the default. This will ensure that all the new cases are created with the new SLA, and time calculation will be done with the new calendar information. If you aren't using a default SLA, update your SLA condition to update the SLA ID in the Case entity accordingly. More information: [Apply SLAs](apply-slas.md#apply-slas)

**Scenario 2**

Conditions: 

- Multiple SLAs
- Multiple calendars need to be associated.
- Multiple SLA items.
- With or without a pause and resume scenario.
- No need to update existing, running KPI instances.

Recommendation:

1. Don't modify the existing SLAs and calendars. The earlier SLAs can continue to remain in an active state in the production environment. Create similar SLAs with a new calendar and the same kind of SLA items.

1. Activate the new SLAs. This will ensure that all the new cases are created with the new SLA, and time calculation will be done with the new calendar information.

1. Update your SLA conditions to update the SLA ID in the Case entity accordingly. More information: [Apply SLAs](apply-slas.md#apply-slas)

**Scenario 3**

Conditions: 

- Multiple SLAs.
- Multiple calendars.
- Multiple SLA items.
- Doesn't include a pause and resume scenario.
- Need to update existing, running KPI instances.

Recommendation:

Modify the existing calendars. This will ensure that all the new cases are created with same SLA, and time calculation is done with the new calendar information. However, the existing running KPI instances won't calculate the warning and failure time based on the new calendar automatically. You'll need to initiate an event for the KPI instance to pick the new calendar.

For example, introduce the pause state and trigger a quick pause, and then resume the update on the case. This will make the KPI instance pick the new calendar information. To initiate a pause and resume, either agents can do a manual update on each case individually, or you can implement a custom logic to update the case during the lowest activity hours.

For example, a flow can run during the lowest activity hours with the following logic:

- Find the associated SLA from a calendar that needs to be updated.
- Find all the incidents which have the same SLA ID field value as the above SLA. You can do this in batches to avoid running into scalability issues.
- Do an update on the case to put it to a paused state.
- Do the next update on the case, which puts it back to Resume.

More information: [Apply SLAs](apply-slas.md#apply-slas)

**Scenario 4**

Conditions:
 
- Multiple SLAs
- Multiple calendars need to be associated.
- Multiple SLA items.
- Includes a pause and resume scenario.
- Need to update existing, running KPI instances.

Recommendation:

This is a complex scenario that can't be completely implemented. It might cause unexpected results for those KPI instances that were set to a paused or resumed state before the new calendar was applied, because the elapsed time for such instances might have already been calculated during the paused or resumed state by using the old calendars. So, the final calculation might be done partly with the old calendar and partly with the new calendar.

### See also

[Create a customer service schedule and define the work hours](../customer-service/create-customer-service-schedule-define-work-hours.md)  

[Create and manage holiday schedules](set-up-holiday-schedule.md#create-and-manage-holiday-schedules)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
