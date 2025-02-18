---
title: SLA time calculation scenarios
description: Learn how time is calculated for service-level agreements (SLAs) in various scenarios. 
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual 
ms.collection:
ms.date: 08/30/2024
ms.custom: bap-template
---

# SLA time calculation scenarios

This article describes how time is calculated for service-level agreements (SLAs) in various scenarios. In all the scenarios, calculations are based on the following settings:

- **Warning time**: 1 day (= 1 &times; 24 = 24 hours)
- **Failure time**: 2 days (= 2 &times; 24 = 48 hours)

> [!NOTE]
> In the **Time zone** field, select **User local** to get accurate time calculations for your time zone. If you select **Timezone independent**, times are calculated as Coordinated Universal Time, regardless of your time zone.

## SLA without any calendar

If you apply an SLA to a case but don't attach a calendar to the SLA, time is calculated from the creation of the case.

In this scenario, time is calculated as follows:

- The case is created at 3:00 on June 14, 2023.
- The warning time is set as 1 day, and the failure time is set as 2 days.
- Therefore, the warning time is 3:00 PM on June 15, 2023, and the failure time is 3:00 PM on June 16, 2023.

## SLA with a calendar

If you create an SLA that has a calendar where working hours and working days of the week are set, the time calculation doesn't consider nonworking hours and days.

In this scenario, time is calculated as follows:

- The case is created at 3:00 PM on June 14, 2023.
- The warning time is set as 1 day, and the failure time is set as 2 days.
- Working hours are set as 8:00 AM to 5:00 PM.
- Working hours are calculated as 9 hours daily.
- Working days are set as Monday through Friday.
- Saturdays and Sundays are skipped.
- Therefore, the warning time is 12:00 PM (noon) on June 19, 2023, and the failure time is 9:00 AM on June 22, 2023.

### Warning time

The calculation for the warning time of 1 day (= 1 &times; 24 = 24 hours) can be broken down as follows:

- June 14, 2023: 3:00 PM = Case creation
- June 14, 2023: 3:00 PM to 5:00 PM (2 hours) = 24 &minus; 2 = 22 hours
- June 15, 2023: 8:00 AM to 5:00 PM (9 hours) = 22 &minus; 9 = 13 hours
- June 16, 2023: 8:00 AM to 5:00 PM (9 hours) = 13 &minus; 9 = 4 hours
- June 17, 2023: Weekend (nonworking day)
- June 18, 2023: Weekend (nonworking day)
- June 19, 2023: 8:00 AM to 12:00 PM (4 hours) = 4 &minus; 4 = 0 hours

### Failure time

The calculation for the failure time of 2 days (= 2 &times; 24 = 48 hours) can be broken down as follows:

- June 14, 2023: 3:00 PM = Case creation
- June 14, 2023: 3:00 PM to 5:00 PM (2 hours) = 48 &minus; 2 = 46 hours
- June 15, 2023: 8:00 AM to 5:00 PM (9 hours) = 46 &minus; 9 = 37 hours
- June 16, 2023: 8:00 AM to 5:00 PM (9 hours) = 37 &minus; 9 = 28 hours
- June 17, 2023: Weekend (nonworking day)
- June 18, 2023: Weekend (nonworking day)
- June 19, 2023: 8:00 AM to 5:00 PM (9 hours) = 28 &minus; 9 = 19 hours
- June 20, 2023: 8:00 AM to 5:00 PM (9 hours) = 19 &minus; 9 = 10 hours
- June 21, 2023: 8:00 AM to 5:00 PM (9 hours) = 10 &minus; 9 = 1 hour
- June 22, 2023: 8:00 AM to 9:00 AM (1 hour) = 1 &minus; 1 = 0 hours

Therefore, if you create a case at 3:00 PM on June 14, 2023, and the warning and failure times are set as 1 and 2 days (respectively), the warning time is 12:00 PM (noon) on June 19, 2023, and the failure time is 9:00 AM on June 22, 2023.

## SLA with a calendar and break hours

If you create an SLA that has a calendar where working hours, working days of the week, and break hours are set, the time calculation doesn't consider nonworking hours, nonworking days, and break hours.

In this scenario, time is calculated as follows:

- The case is created at 3:00 PM on June 14, 2023.
- The warning time is set as 1 day, and the failure time is set as 2 days.
- Working hours are set as 8:00 AM to 5:00 PM.
- There is a one-hour break from 1:00 PM to 2:00 PM.
- Working hours are calculated as 8 hours daily.
- Working days are set as Monday through Friday.
- Saturdays and Sundays are skipped.
- Therefore, the warning time is 3:00 PM on June 19, 2023, and the failure time is 3:00 PM on June 22, 2023.

### Warning time

The calculation for the warning time of 1 day (= 1 &times; 24 = 24 hours) can be broken down as follows:

- June 14, 2023: 3:00 PM = Case creation
- June 14, 2023: 3:00 PM to 5:00 PM (2 hours) = 24 &minus; 2 = 22 hours
- June 15, 2023: 8:00 AM to 1:00 PM (5 hours) = 22 &minus; 5 = 17 hours
- June 15, 2023: 1:00 PM to 2:00 PM (1 hour) = Break hour
- June 15, 2023: 2:00 PM to 5:00 PM (3 hours) = 17 &minus; 3 = 14 hours
- June 16, 2023: 8:00 AM to 1:00 PM (5 hours) = 14 &minus; 5 = 9 hours
- June 16, 2023: 1:00 PM to 2:00 PM (1 hour) = Break hour
- June 16, 2023: 2:00 PM to 5:00 PM (3 hours) = 9 &minus; 3 = 6 hours
- June 17, 2023: Weekend (nonworking day)
- June 18, 2023: Weekend (nonworking day)
- June 19, 2023: 8:00 AM to 1:00 PM (5 hours) = 6 &minus; 5 = 1 hour
- June 19, 2023: 1:00 PM to 2:00 PM (1 hour) = Break hour
- June 19, 2023: 2:00 PM to 3:00 PM (1 hour) = 1 &minus; 1 = 0 hours

### Failure time

The calculation for the failure time of 2 days (= 2 &times; 24 = 48 hours) can be broken down as follows:

- June 14, 2023: 3:00 PM = Case creation
- June 14, 2023: 3:00 PM to 5:00 PM (2 hours) = 48 &minus; 2 = 46 hours
- June 15, 2023: 8:00 AM to 1:00 PM (5 hours) = 46 &minus; 5 = 41 hours
- June 15, 2023: 1:00 PM to 2:00 PM (1 hour) = Break hour
- June 15, 2023: 2:00 PM to 5:00 PM (3 hours) = 41 &minus; 3 = 38 hours
- June 16, 2023: 8:00 AM to 1:00 PM (5 hours) = 38 &minus; 5 = 33 hours
- June 16, 2023: 1:00 PM to 2:00 PM (1 hour) = Break hour
- June 16, 2023: 2:00 PM to 5:00 PM (3 hours) = 33 &minus; 3 = 30 hours
- June 17, 2023: Weekend (nonworking day)
- June 18, 2023: Weekend (nonworking day)
- June 19, 2023: 8:00 AM to 1:00 PM (5 hours) = 30 &minus; 5 = 25 hours
- June 19, 2023: 1:00 PM to 2:00 PM (1 hour) = Break hour
- June 19, 2023: 2:00 PM to 5:00 PM (3 hours) = 25 &minus; 3 = 22 hours
- June 20, 2023: 8:00 AM to 1:00 PM (5 hours) = 22 &minus; 5 = 17 hours
- June 20, 2023: 1:00 PM to 2:00 PM (1 hour) = Break hour
- June 20, 2023: 2:00 PM to 5:00 PM (3 hours) = 17 &minus; 3 = 14 hours
- June 21, 2023: 8:00 AM to 1:00 PM (5 hours) = 14 &minus; 5 = 9 hours
- June 21, 2023: 1:00 PM to 2:00 PM (1 hour) = Break hour
- June 21, 2023: 2:00 PM to 5:00 PM (3 hours) = 9 &minus; 3 = 6 hours
- June 22, 2023: 8:00 AM to 1:00 PM (5 hours) = 6 &minus; 5 = 1 hour
- June 22, 2023: 1:00 PM to 2:00 PM (1 hour) = Break hour
- June 22, 2023: 2:00 PM to 3:00 PM (1 hour) = 1 &minus; 1 = 0 hours

Therefore, if you create a case at 3:00 PM on June 14, 2023, and the warning and failure times are set as 1 and 2 days (respectively), the warning time is 3:00 PM on June 19, 2023, and the failure time is 3:00 PM on June 22, 2023.

## SLA with a calendar and a holiday calendar

If you create an SLA that has a calendar where working hours, working days of the week, and some holidays are set, the time calculation doesn't consider nonworking hours, nonworking days, and holidays.

In this scenario, time is calculated as follows:

- The case is created at 3:00 PM on June 14, 2023.
- The warning time is set as 1 day, and the failure time is set as 2 days.
- Working hours are set as 8:00 AM to 5:00 PM.
- Working hours are calculated as 9 hours daily.
- Working days are set as Monday through Friday.
- Saturdays and Sundays are skipped.
- Holidays per the holiday calendar are skipped.
- Therefore, the warning time is 12:00 PM (noon) on June 21, 2023, and the failure time is 9:00 AM on June 26, 2023.

### Warning time

The calculation for the warning time of 1 day (= 1 &times; 24 = 24 hours) can be broken down as follows:

- June 14, 2023: 3:00 PM = Case creation
- June 14, 2023: 3:00 PM to 5:00 PM (2 hours) = 24 &minus; 2 = 22 hours
- June 15, 2023: 8:00 AM to 5:00 PM (9 hours) = 22 &minus; 9 = 13 hours
- June 16, 2023: Holiday (nonworking day)
- June 17, 2023: Weekend (nonworking day)
- June 18, 2023: Weekend (nonworking day)
- June 19, 2023: Holiday (nonworking day)
- June 20, 2023: 8:00 AM to 5:00 PM (9 hours) = 13 &minus; 9 = 4 hours
- June 21, 2023: 8:00 AM to 12:00 PM (4 hours) = 4 &minus; 4 = 0 hours

### Failure time

The calculation for the failure time of 2 days (= 2 &times; 24 = 48 hours) can be broken down as follows:

- June 14, 2023: 3:00 PM = Case creation
- June 14, 2023: 3:00 PM to 5:00 PM (2 hours) = 48 &minus; 2 = 46 hours
- June 15, 2023: 8:00 AM to 5:00 PM (9 hours) = 46 &minus; 9 = 37 hours
- June 16, 2023: Holiday (nonworking day)
- June 17, 2023: Weekend (nonworking day)
- June 18, 2023: Weekend (nonworking day)
- June 19, 2023: Holiday (nonworking day)
- June 20, 2023: 8:00 AM to 5:00 PM (9 hours) = 37 &minus; 9 = 28 hours
- June 21, 2023: 8:00 AM to 5:00 PM (9 hours) = 28 &minus; 9 = 19 hours
- June 22, 2023: 8:00 AM to 5:00 PM (9 hours) = 19 &minus; 9 = 10 hours
- June 23, 2023: 8:00 AM to 5:00 PM (9 hours) = 10 &minus; 9 = 1 hour
- June 24, 2023: Weekend (nonworking day)
- June 25, 2023: Weekend (nonworking day)
- June 26, 2023: 8:00 AM to 9:00 AM (1 hour) = 1 &minus; 1 = 0 hours

Therefore, if you create a case at 3:00 PM on June 14, 2023, and the warning and failure times are set as 1 and 2 days (respectively), the warning time is 12:00 PM (noon) on June 21, 2023, and the failure time is 9:00 AM on June 26, 2023.

> [!NOTE]
> The transition to daylight saving time might fall on a holiday per the customer calendar that is used in the SLA Item. In this case, the SLA KPI Instance that is created before the holiday, and that has a failure time after the holiday, doesn't follow the daylight saving time transition. However, SLA KPI Instances that are created after the holiday follow the daylight saving time transition.

## Pause and hold scenario

If you create an SLA and then pause it for one or more hours or days, the time calculation doesn't consider the paused hours or days.

In this scenario, time is calculated as follows:

- The case is created at 1:00 PM on June 13, 2023.
- The warning time is set as 1 day, and the failure time is set as 2 days.
- Working hours are set as 8:00 AM to 5:00 PM.
- Working hours are calculated as 9 hours daily.
- Working days are set as Monday through Friday.
- Saturdays and Sundays are skipped.
- Holidays per the holiday calendar are skipped.
- Paused hours or days are skipped.
- Therefore, the warning time is 10:00 AM on June 21, 2023, and the failure time is 4:00 PM on June 26, 2023.

### Warning time

The calculation for the warning time of 1 day (= 1 &times; 24 = 24 hours) can be broken down as follows:

- June 13, 2023: 1:00 PM = Case creation
- June 13, 2023: 1:00 PM to 5:00 PM (4 hours) = 24 &minus; 4 = 20 hours
- June 14, 2023: 8:00 AM to 5:00 PM (9 hours) = Pause
- June 15, 2023: 8:00 AM to 5:00 PM (9 hours) = 20 &minus; 9 = 11 hours
- June 16, 2023: Holiday (nonworking day)
- June 17, 2023: Weekend (nonworking day)
- June 18, 2023: Weekend (nonworking day)
- June 19, 2023: Holiday (nonworking day)
- June 20, 2023: 8:00 AM to 5:00 PM (9 hours) = 11 &minus; 9 = 2 hours
- June 21, 2023: 8:00 AM to 10:00 AM (2 hours) = 2 &minus; 2 = 0 hours

### Failure time

The calculation for the failure time of 2 days (= 2 &times; 24 = 48 hours) can be broken down as follows:

- June 13, 2023: 1:00 PM = Case creation
- June 13, 2023: 1:00 PM to 5:00 PM (4 hours) = 48 &minus; 4 = 44 hours
- June 14, 2023: 8:00 AM to 5:00 PM (9 hours) = Pause
- June 15, 2023: 8:00 AM to 5:00 PM (9 hours) = 44 &minus; 9 = 35 hours
- June 16, 2023: Holiday (nonworking day)
- June 17, 2023: Weekend (nonworking day)
- June 18, 2023: Weekend (nonworking day)
- June 19, 2023: Holiday (nonworking day)
- June 20, 2023: 8:00 AM to 5:00 PM (9 hours) = 35 &minus; 9 = 26 hours
- June 21, 2023: 8:00 AM to 5:00 PM (9 hours) = 26 &minus; 9 = 17 hours
- June 22, 2023: 8:00 AM to 5:00 PM (9 hours) = 17 &minus; 9 = 8 hours
- June 23, 2023: 8:00 AM to 5:00 PM (9 hours) = Pause
- June 24, 2023: Weekend (nonworking day)
- June 25, 2023: Weekend (nonworking day)
- June 26, 2023: 8:00 AM to 4:00 PM (8 hours) = 8 &minus; 8 = 0 hours

Therefore, if you create a case at 1:00 PM on June 13, 2023, and the warning and failure times are set as 1 and 2 days (respectively), the warning time is 10:00 AM on June 21, 2023, and the failure time is 4:00 PM on June 26, 2023.

## Active duration

This section shows how the [active duration](../use/customer-service-hub-user-guide-case-sla.md#know-active-duration-and-elapsed-time-for-sla-kpi-instances) is calculated in different scenarios where the SLA is set for 30 minutes.

### Reopen or close scenario

- 12:00 AM: The case is created.
- 12:10 AM: The case is closed.
- 12:20 AM: The case is reopened.
- 12:30 AM: The SLA expires.

The active duration is 20 minutes, and the SLA expires at 12:30 AM. This duration is used because the SLA is set for 30 minutes and isn't affected when the case is reopened or closed.

### Pause or resume scenario

- 12:00 AM: The case is created.
- 12:10 AM: The case is paused.
- 12:20 AM: The case is resumed.
- 12:40 AM: The SLA expires.

The active duration is 30 minutes, and the SLA expires at 12:40 AM because the case was paused for 10 minutes. Although the SLA is set for 30 minutes, it's affected when the case is paused or resumed.

By default, when you use custom time calculation for SLA key performance indicators (KPIs), the active duration isn't calculated cumulatively. To make the calculation of active duration cumulative, you must create a custom time calculation plug-in. Learn more in [Enable custom time calculation of SLA KPIs](enable-sla-custom-time-calculation.md#enable-custom-time-calculation-of-sla-kpis-1).

### More scenarios

- If two SLA KPI Instances are created for two SLA Items that have the same SLA KPI, the pause and resume times of the first SLA KPI Instance isn't considered in the time calculation of the second SLA KPI Instance.

    For example, two SLA KPI Instances (SLA KPI Instance 1 and SLA KPI Instance 2) are created for two different SLA Items that have the same SLA KPI (SLA KPI 1). SLA KPI Instance 1 for SLA Item 1 is created on record Case 1, and then SLA KPI Instance 1 is paused and resumed with updates on Case 1.

    Because of the updates on Case 1, the conditions for SLA Item 2 are met, and SLA KPI Instance 2 is created for SLA Item 2. At this point, SLA KPI Instance 1 is canceled. Even though SLA Item 1 and SLA Item 2 share SLA KPI 1, the pause time of SLA KPI Instance 1 isn't carried forwarded to SLA KPI Instance 2.

- If the SLA Instance is created in the **Succeeded** or **Expired** state, active duration doesn't show any value.

    SLA KPI Instances are created in the **Succeeded** state if the success condition is met during the application of the SLA. However, if the SLA KPI Instance is created, and the failure time of the SLA KPI Instance is less than the one that was created on the SLA KPI Instance, it goes to the **Expired** state. In this type of scenario, the active duration doesn't show any value.

## Related information

[Warning and failure duration times are incorrect for the SLA](/troubleshoot/dynamics-365/customer-service/service-level-agreements/warning-failure-times-incorrect-sla)

[Manage changes to customer service and holiday schedules of existing SLA KPIs](../administer/change-schedules.md)

[Create and manage holiday schedules](../administer/set-up-holiday-schedule.md)
