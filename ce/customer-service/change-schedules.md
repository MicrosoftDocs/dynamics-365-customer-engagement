---
title: "Impact of change to customer service or holiday schedules of SLA KPIs (Dynamics 365 Customer Service) | MicrosoftDocs"
description: "Learn how to manage impact of a change to customer service or holiday schedules in Dynamics 365 Customer Service."
ms.date: 03/10/2022
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

To manage changes to customer service and holiday schedules of your SLA KPIs, you must first understand how time calculation works for SLA KPIs. The time calculation for SLA KPIs depends on the warning and failure time, and the customer service and holiday schedules associated with the SLA KPI Item.

Here is an example of a SLA KPI that describes how time calculation works. The configuration set for the SLA KPI are as follows:
- Defined working hours: 9 AM to 5 PM (8 hours daily)
- Failure duration: 12 hours
- Holiday calendar: The next day is marked as a holiday.
- Case is created today at 10 AM

So, after time calculation, the failure duration will be the day after the next day at 14:00 (2 PM). This is calculated by considering the remaining hours for the day, that is, 5PM – 10AM = 7 hours, which leaves 5 hours for the next day (calculated as failure duration - hours consumed today). The next day doesn't get calculated as it's a holiday. So, the failure duration will be day after the next day: 9 AM + 5 hours= 14:00 (2 PM).

For more information on creating customer service schedules, see: [Create customer service schedule and define the work hours](create-customer-service-schedule-define-work-hours.md#create-customer-service-schedule-and-define-the-work-hours), 
and creating holiday schedules, see: [Create and manage holiday schedules](set-up-holiday-schedule.md#create-and-manage-holiday-schedules).

Apart from  warning and failure time calculation, SLA time calculation also involves calculating the Elapsed time, if the SLA KPIs are paused and resumed. The elapsed time is added to the final failure time to ignore the working hours spent during the Paused state.

## Scenarios and recommendations

Whenever any SLA KPI instance is created, the warning and failure time is created depending on the factors described in the [Understand time calculation of SLA KPIs](#understand-time-calculation-of-sla-kpis) section. So, a change in the calendar working hours doesn't impact the existing KPI instances.

However, you may have the following scenarios which affect the existing KPI instances:

- Pause and Resume of the SLA KPI instance.
- Update of SLA on the target entity.
- Change in the SLA item.
- SLA KPI instance is reapplied after terminal state (in case of Recalculation on Terminal State).

In the above scenarios, the warning and the failure time of the SLA KPI are re-calculated with the new customer service schedule and the holiday schedule. However, if you want to change the existing customer service and holiday schedule which is already in use in the existing SLA KPI instances, you can implement the recommendations provided in the following section.  

> [!NOTE]
> Please validate all the scenarios and the recommendations to ensure that all the conditions are met before applying the changes to your production environment.

**Scenario 1:**

Conditions: 
- Only one SLA KPI is set as Default.
-	One calendar needs to be associated.
-	Multiple SLA items.
-	With or without a Pause and Resume scenario.
-	There is no need to update existing running KPI instances.

Recommendation:
 
1. Don't modify the existing SLA and calendar. The earlier SLA can continue to remain in Active state on the production environment. Create a similar SLA with a new calendar and the same kind of SLA items.
2. Activate the new SLA and set as Default. This will ensure that all the new cases are created with the new SLA and time calculation will be done with the new calendar information.

> [!NOTE]
> If you are not using a Default SLA, update your SLA condition to update the SLA ID in the Case entity accordingly. More information: [Apply SLAs on demand](define-service-level-agreements.md#apply-slas-on-demand).

**Scenario 2**

Conditions: 
- Multiple SLA
- Multiple calendars need to be associated.
- Multiple SLA items.
- With or without a Pause and Resume scenario.
- No need to update existing running KPI instances.

Recommendation:

1. Don't modify the existing SLAs and calendars. The earlier SLAs can continue to remain in Active state on the production org. Create similar SLAs with a new calendar and the same kind of SLA items.
2. Activate the new SLAs. This will ensure that all the new cases are created with the new SLA and time calculation will be done with the new calendar information.
3. Update your SLA conditions to update the SLA ID in the Case entity accordingly. More information: [Apply SLAs on demand<a name="apply-sla-on-demand"></a>](define-service-level-agreements.md#apply-slas-on-demand).

**Scenario 3**

Conditions: 
- Multiple SLA.
- Multiple Calendars.
- Multiple SLA items.
- No Pause and Resume scenario.
- Need to update existing running KPI instances.

Recommendation:

Modify the existing calendars. This will ensure that all the new cases are created with same SLA and time calculation is done with the new calendar information. However, the existing running KPI instances won't calculate the warning and failure time based on the new calendar automatically. You will need to initiate an event for the KPI instance to pick the new calendar.

For example, introduce the Pause state and trigger a quick Pause and then Resume update on the case. This will make the KPI instance pick the new calendar information. To initiate Pause and Resume, either agents can do a manual update on each case individually or you can implement a custom logic to update the case during the lowest activity hours.

For example, a flow can run during the lowest activity hours, with the following logic:
- Find the associated SLA from a calendar which needs to be updated.
- Find all the incidents which have same SLA ID field value as the above SLA. You can do this in batches to avoid running into scalability issues.
- Do an update on the case to put it to a Paused state.
- Do the next update on the case which puts it back to Resume.

> [!NOTE]
> This will be an intensive operation based on the SLA KPI instances and incidents in your environment.

More information: [Apply SLAs on demand<a name="apply-sla-on-demand"></a>](define-service-level-agreements.md#apply-slas-on-demand).

**Scenario 4**

Conditions: 
- Multiple SLA
- Multiple calendars need to be associated.
- Multiple SLA items.
- Has Pause and Resume scenario.
- Need to update existing running KPI instances.

Recommendation:

This is a complex scenario which can't be completely implemented. It might cause unexpected results for those KPI instances which were set to Paused or Resumed state before the new calendar was applied because the elapsed for such instances might have already been calculated during Paused or Resumed state with the old calendars. So, the final calculation might be partly with the old calendar and partly with new calendar.

### See also

[Create a customer service schedule and define the work hours](../customer-service/create-customer-service-schedule-define-work-hours.md)  

[Create and manage holiday schedules](set-up-holiday-schedule.md#create-and-manage-holiday-schedules)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
