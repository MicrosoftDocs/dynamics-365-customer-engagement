---
title: SLA time calculation scenarios
description: Learn how time gets calculated for SLAs in various scenarios. 
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.collection:
ms.date: 08/22/2023
ms.custom: bap-template
---

# SLA time calculation scenarios

This article describes time calculations for SLA in the following scenarios, with the given that: 
Warning Time- 1 day (1*24= 24 hours)
Failure Time- 2 days (2*24= 48 hours)

## SLA without any calendar

When you apply SLA to a case and don't attach any calendar to that SLA, then time is calculated from the creation of that case.

Time calculation:

- Case created on 06/14/2023 3:00 PM
- Warning and failure time is set as 1 day and 2 days.
- Warning time will be 06/15/2023 3:00 PM and failure time will be 06/16/2023 3:00 PM.

## SLA with calendar

When we create SLA with calendar and on that calendar, we set our working hours as well as working days of the week then it will skip those non-working hours and days on the time calculation.

Time calculation:

- Case created on 06/14/2023 3:00 PM. 
- Warning and failure time is set as 1 day and 2 days.
- Working hours are set as 8:00 AM to 5:00 PM.
- It will calculate 9 hours daily as working hours.
- Working days are set as Monday to Friday.
- Will skip Saturday and Sunday.
- Warning time will be 06/19/2023 12:00 noon and failure time will be 06/22/2023 9:00 AM.

### Warning Time- 1 day (1*24= 24 hours)

Here's how the warning time got calculated:

- Case got created on 06/14/2023 at 3:00 PM
- 06/14/2023- 3:00 PM to 5:00 PM (2 hours) = 24-2= 22 hours
- 06/15/2023- 8:00 AM to 5:00 PM (9 hours) = 22-9= 13 hours
- 06/16/2023- 8:00 AM to 5:00 PM (9 hours) = 13-9= 4 hours
- 06/17/2023- Weekend (Non-working day)
- 06/18/2023- Weekend (Non-working day)
- 06/19/2023- 8:00 AM to 12:00 noon (4 hours) = 4-4= 0 hours

### Failure Time- 2 days (2*24= 48 hours)

Here's how the failure time got calculated:

- Case got created on 06/14/2023 at 3:00 PM
- 06/14/2023- 3:00 PM to 5:00 PM (2 hours) = 48-2= 46 hours
- 06/15/2023- 8:00 AM to 5:00 PM (9 hours) = 46-9= 37 hours
- 06/16/2023- 8:00 AM to 5:00 PM (9 hours) = 37-9= 28 hours
- 06/17/2023- Weekend (Non-working day)
- 06/18/2023- Weekend (Non-working day)
- 06/19/2023- 8:00 AM to 5:00 PM (9 hours) = 28-9= 19 hours
- 06/20/2023- 8:00 AM to 5:00 PM (9 hours) = 19-9= 10 hours
- 06/21/2023- 8:00 AM to 5:00 PM (9 hours) = 10-9= 1 hour
- 06/22/2023- 8:00 AM to 9:00 AM (1 hour) = 1-1= 0 hour

So, if a case is created on 06/14/2023 3:00 PM with warning and failure time as 1 day and 2 days respectively, then the warning time will be 06/19/2023 12:00 noon and failure time will be 06/22/2023 9:00 AM.
 
## SLA with calendar and break hours

When we create SLA with calendar and on that calendar, we set our working hours, break hours as well as working days of the week then it will skip those non-working hours and break hours on the time calculation.

Time calculation:

- Case created on 06/14/2023 3:00 PM
- Warning and failure time is set as 1 day and 2 days.
- Working hours are set as 8:00 AM to 5:00 PM.
- Break 1 hour between 1:00 PM to 2:00 PM
- It will calculate 8 hours daily as working hours.
- Working days are set as Monday to Friday.
- Will skip Saturday and Sunday.
- Warning time will be 06/19/2023 3:00 PM and failure time will be 06/22/2023 3:00 PM.

### Warning Time- 1 day (1*24= 24 hours)

Here's how the warning time got calculated:

- Case got created on 06/14/2023 at 3:00 PM
- 06/14/2023- 3:00 PM to 5:00 PM (2 hours) = 24-2= 22 hours
- 06/15/2023- 8:00 AM to 1:00 PM (5 hours) = 22-5= 17 hours
- 06/15/2023- 1:00 AM to 2:00 PM (1 hour) = Break hours
- 06/15/2023- 2:00 AM to 5:00 PM (3 hours) = 17-3=14 hours
- 06/16/2023- 8:00 AM to 1:00 PM (5 hours) = 14-5= 9 hours
- 06/16/2023- 1:00 AM to 2:00 PM (1 hour) = Break hours
- 06/16/2023- 2:00 AM to 5:00 PM (3 hours) = 9-3= 6 hours
- 06/17/2023- Weekend (Non-working day)
- 06/18/2023- Weekend (Non-working day)
- 06/19/2023- 8:00 AM to 1:00PM (5 hours) = 6-5= 1 hour
- 06/19/2023- - 1:00 AM to 2:00 PM (1 hour) = Break hours
- 06/19/2023- 2:00 AM to 3:00 PM (1 hour) = 1-1= 0

### Failure Time- 2 days (2*24= 48 hours)

Here's how the failure time got calculated:

- Case got created on 06/14/2023 at 3:00 PM
- 06/14/2023- 3:00 PM to 5:00 PM (2 hours) = 48-2= 46 hours
- 06/15/2023- 8:00 AM to 1:00 PM (5 hours) = 46-5= 41 hours
- 06/15/2023- 1:00 AM to 2:00 PM (1 hour) = Break hours
- 06/15/2023- 2:00 AM to 5:00 PM (3 hours) = 41-3=38 hours
- 06/16/2023- 8:00 AM to 1:00 PM (5 hours) = 38-5= 33 hours
- 06/16/2023- 1:00 AM to 2:00 PM (1 hour) = Break hours
- 06/16/2023- 2:00 AM to 5:00 PM (3 hours) = 33-3= 30 hours
- 06/17/2023- Weekend (Non-working day)
- 06/18/2023- Weekend (Non-working day)
- 06/19/2023- 8:00 AM to 1:00 PM (5 hours) = 30-5= 25 hours
- 06/19/2023- - 1:00 AM to 2:00 PM (1 hour) = Break hours
- 06/19/2023- 2:00 AM to 5:00 PM (3 hours) = 25-3= 22 hours
- 06/20/2023- 8:00 AM to 1:00 PM (5 hours) = 22-5= 17 hours
- 06/20/2023- 1:00 AM to 2:00 PM (1 hour) = Break hours
- 06/20/2023- 2:00 AM to 5:00 PM (3 hours) = 17-3= 14 hours
- 06/21/2023- 8:00 AM to 1:00 PM (5 hours) = 14-5= 9 hours
- 06/21/2023- 1:00 AM to 2:00 PM (1 hour) = Break hours
- 06/21/2023- 2:00 AM to 5:00 PM (3 hours) = 9-3= 6 hours
- 06/22/2023- 8:00 AM to 1:00 PM (5 hours) = 6-5= 1 hour
- 06/22/2023- 1:00 AM to 2:00 PM (1 hour) = Break hours
- 06/22/2023- 2:00 AM to 3:00 PM (1 hour) = 1-1= 0 hours

So, if a case is created on 06/14/2023 3:00 PM with warning and failure time as 1 day and 2 days respectively, then the warning time will be 06/19/2023 3:00 PM and failure time will be 06/22/2023 3:00 PM.

## SLA with calendar and holiday calendar

When we create SLA with calendar and on that calendar, we set our working hours as well as working days of the week then it will skip those non-working hours and days on the time calculation, and we added some days as holiday on the calendar then it will skip these days in calculation.

TIme calculation:
- Case created on 06/14/2023 3:00 PM
- warning and failure time is set as 1 day and 2 days.
- Working hours are set as 8:00 AM to 5:00 PM.
- It will calculate 9 hours daily as working hours. 
- Working days are set as Monday to Friday. 
- will skip Saturday and Sunday.
- will skip holidays as per Holiday calendar.
- warning time will be 06/21/2023 12:00 noon and failure time will be 06/26/2023 9:00 AM.

### Warning Time- 1 day (1*24= 24 hours)

Here's how the warning time got calculated:

- Case got created on 06/14/2023 at 3:00 PM
- 06/14/2023- 3:00 PM to 5:00 PM (2 hours) = 24-2= 22 hours
- 06/15/2023- 8:00 AM to 5:00 PM (9 hours) = 22-9= 13 hours
- 06/16/2023- Holiday (Non-working day)
- 06/17/2023- Weekend (Non-working day)
- 06/18/2023- Weekend (Non-working day)
- 06/19/2023- Holiday (Non-working day)
- 06/20/2023- 8:00 AM to 5:00 PM (9 hours) = 13-9= 4 hours
- 06/21/2023- 8:00 AM to 12:00 noon (4 hours) = 4-4= 0 hours

### Failure Time- 2 days (2*24= 48 hours)

Here's how the failure time got calculated:

- Case got created on 06/14/2023 at 3:00 PM
- 06/14/2023- 3:00 PM to 5:00 PM (2 hours) = 48-2= 46 hours
- 06/15/2023- 8:00 AM to 5:00 PM (9 hours) = 46-9= 37 hours
- 06/16/2023- Holiday (Non-working day)
- 06/17/2023- Weekend (Non-working day)
- 06/18/2023- Weekend (Non-working day)
- 06/19/2023- Holiday (Non-working day)
- 06/20/2023- 8:00 AM to 5:00 PM (9 hours) = 37-9= 28 hours
- 06/21/2023- 8:00 AM to 5:00 PM (9 hours) = 28-9= 19 hours
- 06/22/2023- 8:00 AM to 5:00 PM (9 hours) = 19-9= 10 hours
- 06/23/2023- 8:00 AM to 5:00 PM (9 hours) = 10-9= 1 hour
- 06/24/2023- Weekend (Non-working day)
- 06/25/2023- Weekend (Non-working day)
- 06/26/2023- 8:00 AM to 9:00 AM (1 hour) = 1-1= 0 hour

So, if a case is created on 06/14/2023 3:00 PM and warning and failure time is set as 1 day and 2 days respectively then warning time will be 06/21/2023 12:00 noon and failure time will be 06/26/2023 9:00 AM.

## Pause and hold scenario

When we create an SLA and then we pause that SLA for some hours/days then that pausing hours/days will not be calculated in the SLA failure and warning time.

Time calculation:

- Case created on 06/14/2023 3:00 PM
- warning and failure time is set as 1 day and 2 days.
- Working hours are set as 8:00 AM to 5:00 PM.
- It will calculate 9 hours daily as working hours. 
- Working days are set as Monday to Friday. 
- Will skip Saturday and Sunday.
- Will skip holidays as per Holiday calendar.
- Will skip paused hours/days.
- Warning time will be 06/21/2023 10:00 AM and failure time will be 06/26/2023 4:00 PM.

### Warning Time- 1 day (1*24= 24 hours)

- Case got created on 06/13/2023 at 1:00 PM
- 06/13/2023- 1:00 PM to 5:00 PM (4 hours) = 24-4= 20 hours
- 06/14/2023- 8:00 AM to 5:00 PM (9 hours)- Paused.
- 06/15/2023- 8:00 AM to 5:00 PM (9 hours) = 20-9= 11 hours
- 06/16/2023- Holiday (Non-working day)
- 06/17/2023- Weekend (Non-working day)
- 06/18/2023- Weekend (Non-working day)
- 06/19/2023- Holiday (Non-working day)
- 06/20/2023- 8:00 AM to 5:00 PM (9 hours) = 11-9= 2 hours
- 06/21/2023- 8:00 AM to 10:00 AM (2 hours) = 2-2= 0 hour

### Failure Time- 2 days (2*24= 48 hours)

- Case was created on 06/13/2023 at 1:00 PM
- 06/13/2023- 1:00 PM to 5:00 PM (4 hours) = 48-4= 44 hours
- 06/14/2023- 8:00 AM to 5:00 PM (9 hours) - Paused. 
- 06/15/2023- 8:00 AM to 5:00 PM (9 hours) = 44-9= 35 hours
- 06/16/2023- Holiday (Non-working day)
- 06/17/2023- Weekend (Non-working day)
- 06/18/2023- Weekend (Non-working day)
- 06/19/2023- Holiday (Non-working day)
- 06/20/2023- 8:00 AM to 5:00 PM (9 hours) = 35-9= 26 hours
- 06/21/2023- 8:00 AM to 5:00 PM (9 hours) = 26-9= 17 hours
- 06/22/2023- 8:00 AM to 5:00 PM (9 hours) = 17-9= 8 hours
- 06/23/2023- 8:00 AM to 5:00 PM (9 hours) = Paused
- 06/24/2023- Weekend (Non-working day)
- 06/25/2023- Weekend (Non-working day)
- 06/26/2023- 8:00 AM to 4:00 PM (8 hours) = 8-8= 0 hour

So, if a case is created on 06/14/2023 3:00 PM with warning and failure time as 1 day and 2 days respectively, then warning time will be 06/21/2023 10:00 AM and failure time will be 06/26/2023 4:00 PM.

## See Also

[Manage changes to customer service and holiday schedules of existing SLA KPIs](change-schedules.md#manage-changes-to-customer-service-and-holiday-schedules-of-existing-sla-kpis)  
[Create and manage holiday schedules](set-up-holiday-schedule.md#create-and-manage-holiday-schedules)
