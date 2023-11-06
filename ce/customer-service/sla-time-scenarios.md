---
title: SLA time calculation scenarios
description: Learn how time gets calculated for SLAs in various scenarios. 
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.collection:
ms.date: 11/06/2023
ms.custom: bap-template
---

# SLA time calculation scenarios

This article describes SLA time calculations, given that:

- Warning Time: 1 day (1*24 = 24 hours)
- Failure Time: 2 days (2*24 = 48 hours)

## SLA without any calendar

When you apply an SLA to a case but don't attach a calendar to the SLA, the time is calculated from the creation of the case.

In this example, time is calculated as follows:

- Case created on 06/14/2023 at 3:00 PM.
- Warning and failure times are set as 1 and 2 days, respectively.
- So, the warning time is 06/15/2023 3:00 PM and the failure time is 06/16/2023 3:00 PM.

## SLA with calendar

When you create an SLA with a calendar with working hours and working days of the week set, then the time calculation doesn't consider the non-working hours and days.

In this example, time is calculated as follows:

- Case created on 06/14/2023 at 3:00 PM.
- Warning and failure times are set as 1 and 2 days, respectively.
- Working hours are set as 8:00 AM to 5:00 PM.
- Working hours are calculated as 9 hours.
- Working days are set as Monday to Friday.
- Skips Saturday and Sunday.
- Warning time is 06/19/2023 12:00 noon and failure time is 06/22/2023 9:00 AM.

### Warning Time: 1 day (1*24 = 24 hours)

Here's how the warning time is calculated:

- Case created on 06/14/2023 at 3:00 PM
- 06/14/2023- 3:00 PM to 5:00 PM (2 hours) = 24-2 = 22 hours
- 06/15/2023- 8:00 AM to 5:00 PM (9 hours) = 22-9 = 13 hours
- 06/16/2023- 8:00 AM to 5:00 PM (9 hours) = 13-9 = 4 hours
- 06/17/2023- weekend (non-working day)
- 06/18/2023- weekend (non-working day)
- 06/19/2023- 8:00 AM to 12:00 noon (4 hours) = 4-4 = 0 hours

### Failure Time: 2 days (2*24 = 48 hours)

Here's how the failure time is calculated:

- Case created on 06/14/2023 at 3:00 PM.
- 06/14/2023- 3:00 PM to 5:00 PM (2 hours) = 48-2 = 46 hours
- 06/15/2023- 8:00 AM to 5:00 PM (9 hours) = 46-9 = 37 hours
- 06/16/2023- 8:00 AM to 5:00 PM (9 hours) = 37-9 = 28 hours
- 06/17/2023- weekend (non-working day)
- 06/18/2023- weekend (non-working day)
- 06/19/2023- 8:00 AM to 5:00 PM (9 hours) = 28-9 = 19 hours
- 06/20/2023- 8:00 AM to 5:00 PM (9 hours) = 19-9 = 10 hours
- 06/21/2023- 8:00 AM to 5:00 PM (9 hours) = 10-9 = 1 hour
- 06/22/2023- 8:00 AM to 9:00 AM (1 hour) = 1-1 = 0 hours

So, if you create a case on 06/14/2023 3:00 PM with warning and failure times set as 1 and 2 days respectively, then the warning time is 06/19/2023 12:00 noon, and the failure time is 06/22/2023 9:00 AM.

## SLA with calendar and break hours

When you create an SLA with a calendar and on that calendar you set working hours, break hours, and working days of the week, then the time calculation doesn't consider the non-working and break hours.

Time is calculated as follows:

- Case created on 06/14/2023 at 3:00 PM.
- Warning and failure times are set as 1 and 2 days, respectively.
- Working hours are set as 8:00 AM to 5:00 PM.
- Break is 1 hour between 1:00 PM to 2:00 PM.
- Working hours are calculated as 8 hours.
- Working days are set as Monday to Friday.
- Skips Saturday and Sunday.
- Warning time is 06/19/2023 3:00 PM and failure time is 06/22/2023 3:00 PM.

### Warning Time: 1 day (1*24 = 24 hours)

Here's how the warning time is calculated:

- Case created on 06/14/2023 at 3:00 PM
- 06/14/2023- 3:00 PM to 5:00 PM (2 hours) = 24-2 = 22 hours
- 06/15/2023- 8:00 AM to 1:00 PM (5 hours) = 22-5 = 17 hours
- 06/15/2023- 1:00 PM to 2:00 PM (1 hour) = break hour
- 06/15/2023- 2:00 PM to 5:00 PM (3 hours) = 17-3 =14 hours
- 06/16/2023- 8:00 AM to 1:00 PM (5 hours) = 14-5 = 9 hours
- 06/16/2023- 1:00 PM to 2:00 PM (1 hour) = break hours
- 06/16/2023- 2:00 PM to 5:00 PM (3 hours) = 9-3 = 6 hours
- 06/17/2023- weekend (non-working day)
- 06/18/2023- weekend (non-working day)
- 06/19/2023- 8:00 AM to 1:00 PM (5 hours) = 6-5 = 1 hour
- 06/19/2023- 1:00 PM to 2:00 PM (1 hour) = break hour
- 06/19/2023- 2:00 PM to 3:00 PM (1 hour) = 1-1 = 0

### Failure Time: 2 days (2*24 = 48 hours)

Here's how the failure time is calculated:

- Case created on 06/14/2023 at 3:00 PM
- 06/14/2023- 3:00 PM to 5:00 PM (2 hours) = 48-2 = 46 hours
- 06/15/2023- 8:00 AM to 1:00 PM (5 hours) = 46-5 = 41 hours
- 06/15/2023- 1:00 PM to 2:00 PM (1 hour) = break hour
- 06/15/2023- 2:00 PM to 5:00 PM (3 hours) = 41-3 = 38 hours
- 06/16/2023- 8:00 AM to 1:00 PM (5 hours) = 38-5 = 33 hours
- 06/16/2023- 1:00 PM to 2:00 PM (1 hour) = break hour
- 06/16/2023- 2:00 PM to 5:00 PM (3 hours) = 33-3 = 30 hours
- 06/17/2023- weekend (non-working day)
- 06/18/2023- weekend (non-working day)
- 06/19/2023- 8:00 AM to 1:00 PM (5 hours) = 30-5 = 25 hours
- 06/19/2023- 1:00 PM to 2:00 PM (1 hour) = break hour
- 06/19/2023- 2:00 PM to 5:00 PM (3 hours) = 25-3 = 22 hours
- 06/20/2023- 8:00 AM to 1:00 PM (5 hours) = 22-5 = 17 hours
- 06/20/2023- 1:00 PM to 2:00 PM (1 hour) = break hour
- 06/20/2023- 2:00 PM to 5:00 PM (3 hours) = 17-3 = 14 hours
- 06/21/2023- 8:00 AM to 1:00 PM (5 hours) = 14-5 = 9 hours
- 06/21/2023- 1:00 PM to 2:00 PM (1 hour) = break hour
- 06/21/2023- 2:00 PM to 5:00 PM (3 hours) = 9-3 = 6 hours
- 06/22/2023- 8:00 AM to 1:00 PM (5 hours) = 6-5 = 1 hour
- 06/22/2023- 1:00 PM to 2:00 PM (1 hour) = break hour
- 06/22/2023- 2:00 PM to 3:00 PM (1 hour) = 1-1 = 0 hours

So, if you create a case on 06/14/2023 3:00 PM with warning and failure times set as 1 and 2 days respectively, then the warning time is 06/19/2023 3:00 PM, and the failure time is 06/22/2023 3:00 PM.

## SLA with calendar and holiday calendar

When you create an SLA with a calendar and set working hours, working days of the week, and some days as holidays, then the non-working hours, non-working days, and holidays aren't considered.

Time is calculated as follows:

- Case created on 06/14/2023 at 3:00 PM.
- Warning and failure times are set as 1 and 2 days, respectively.
- Working hours are set as 8:00 AM to 5:00 PM.
- Working hours are calculated as 9 hours daily.
- Working days are set as Monday to Friday.
- Skips Saturday and Sunday.
- Skips holidays as per holiday calendar.
- Warning time will be 06/21/2023 12:00 noon and failure time will be 06/26/2023 9:00 AM.

### Warning Time: 1 day (1*24 = 24 hours)

Here's how the warning time is calculated:

- Case created on 06/14/2023 at 3:00 PM
- 06/14/2023- 3:00 PM to 5:00 PM (2 hours) = 24-2 = 22 hours
- 06/15/2023- 8:00 AM to 5:00 PM (9 hours) = 22-9 = 13 hours
- 06/16/2023- holiday (non-working day)
- 06/17/2023- weekend (non-working day)
- 06/18/2023- weekend (non-working day)
- 06/19/2023- holiday (non-working day)
- 06/20/2023- 8:00 AM to 5:00 PM (9 hours) = 13-9 = 4 hours
- 06/21/2023- 8:00 AM to 12:00 noon (4 hours) = 4-4 = 0 hours

### Failure Time: 2 days (2*24 = 48 hours)

Here's how the failure time is calculated:

- Case created on 06/14/2023 at 3:00 PM
- 06/14/2023- 3:00 PM to 5:00 PM (2 hours) = 48-2 = 46 hours
- 06/15/2023- 8:00 AM to 5:00 PM (9 hours) = 46-9 = 37 hours
- 06/16/2023- holiday (non-working day)
- 06/17/2023- weekend (non-working day)
- 06/18/2023- weekend (non-working day)
- 06/19/2023- holiday (non-working day)
- 06/20/2023- 8:00 AM to 5:00 PM (9 hours) = 37-9 = 28 hours
- 06/21/2023- 8:00 AM to 5:00 PM (9 hours) = 28-9 = 19 hours
- 06/22/2023- 8:00 AM to 5:00 PM (9 hours) = 19-9 = 10 hours
- 06/23/2023- 8:00 AM to 5:00 PM (9 hours) = 10-9 = 1 hour
- 06/24/2023- weekend (non-working day)
- 06/25/2023- weekend (non-working day)
- 06/26/2023- 8:00 AM to 9:00 AM (1 hour) = 1-1 = 0 hours

So, if you create a case on 06/14/2023 3:00 PM and warning and failure times are set as 1 and 2 days respectively, then the warning time is 06/21/2023 12:00 noon and the failure time is 06/26/2023 9:00 AM.

## Pause and hold scenario

When you create an SLA and then pause it for hours or days, the paused hours or days aren't considered in the SLA failure and warning times.

Time is calculated as follows:

- Case created on 06/14/2023 at 3:00 PM.
- Warning and failure times are set as 1 and 2 days, respectively.
- Working hours are set as 8:00 AM to 5:00 PM.
- It will calculate 9 hours daily as working hours.
- Working days are set as Monday to Friday.
- Skips Saturday and Sunday.
- Skips holidays as per the holiday calendar.
- Skips paused hours or days.
- Warning time is 06/21/2023 10:00 AM and failure time is 06/26/2023 4:00 PM.

### Warning Time: 1 day (1*24 = 24 hours)

Here's how the warning time is calculated:

- Case created on 06/13/2023 at 1:00 PM
- 06/13/2023- 1:00 PM to 5:00 PM (4 hours) = 24-4 = 20 hours
- 06/14/2023- 8:00 AM to 5:00 PM (9 hours) - Paused
- 06/15/2023- 8:00 AM to 5:00 PM (9 hours) = 20-9 = 11 hours
- 06/16/2023- holiday (non-working day)
- 06/17/2023- weekend (non-working day)
- 06/18/2023- weekend (non-working day)
- 06/19/2023- holiday (non-working day)
- 06/20/2023- 8:00 AM to 5:00 PM (9 hours) = 11-9 = 2 hours
- 06/21/2023- 8:00 AM to 10:00 AM (2 hours) = 2-2 = 0 hours

### Failure Time: 2 days (2*24 = 48 hours)

Here's how the failure time is calculated:

- Case was created on 06/13/2023 at 1:00 PM
- 06/13/2023- 1:00 PM to 5:00 PM (4 hours) = 48-4 = 44 hours
- 06/14/2023- 8:00 AM to 5:00 PM (9 hours) - Paused
- 06/15/2023- 8:00 AM to 5:00 PM (9 hours) = 44-9 = 35 hours
- 06/16/2023- holiday (non-working day)
- 06/17/2023- weekend (non-working day)
- 06/18/2023- weekend (non-working day)
- 06/19/2023- holiday (non-working day)
- 06/20/2023- 8:00 AM to 5:00 PM (9 hours) = 35-9 = 26 hours
- 06/21/2023- 8:00 AM to 5:00 PM (9 hours) = 26-9 = 17 hours
- 06/22/2023- 8:00 AM to 5:00 PM (9 hours) = 17-9 = 8 hours
- 06/23/2023- 8:00 AM to 5:00 PM (9 hours) - Paused
- 06/24/2023- weekend (non-working day)
- 06/25/2023- weekend (non-working day)
- 06/26/2023- 8:00 AM to 4:00 PM (8 hours) = 8-8 = 0 hours

So, if you create a case is on 06/14/2023 3:00 PM with warning and failure times set as 1 and 2 days respectively, then the warning time is 06/21/2023 10:00 AM and the failure time is 06/26/2023 4:00 PM.

## See Also

[Manage changes to customer service and holiday schedules of existing SLA KPIs](change-schedules.md#manage-changes-to-customer-service-and-holiday-schedules-of-existing-sla-kpis)  
[Create and manage holiday schedules](set-up-holiday-schedule.md#create-and-manage-holiday-schedules)
