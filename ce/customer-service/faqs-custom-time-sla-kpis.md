---
title: "FAQs about custom time calculation of SLA KPIs | MicrosoftDocs"
description: "Learn about the frequently asked questions (FAQs) on custom time calculation of SLA KPIs."
ms.date: 03/14/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
---

# FAQs about custom time calculation of SLA KPIs

## Overview
This topic contains the frequently asked questions (FAQs) that you as an administrator might have about the custom time calculation of service-level agreements (SLAs) key performance indicators (KPIs).

## When will be the custom action or plug-in be initiated?

The custom action or plug-in will be initiated during the creation of a new KPI instance. Following are examples of KPI instances:
- Whenever a SLA is applied or changed.
- Whenever a SLA item is applied or changed.
- Whenever a SLA KPI instance record is **Resumed** from **Pause** status.

## How is the Pause Resume scenario different from a normal KPI instance creation?

Pause and Resume scenario includes the two following steps:

1. The Custom Action is initiated with requestType as "getElapsedTime". This calculates the time elapsed between the case paused till case resumed.
2. The Custom Action is initiated with requestType as "getEndTime". This calculates the new WarningTime by adding the above elapsedTime to the current warningTime (similar calculation for FailureTime).

## How can I handle deployments and downtime?

When the custom time calculation workflow is deactivated (during deployment or manually), it creates a downtime for the SLA item. Deployment is usually done during dark hours to avoid impacting any running cases or new cases. To minimize the downtime, create SLAs in separate solutions and avoid any other irrelevant changes as part of same solution.

## How can I override the `StartTime` for a KPI instance without creating and updating the custom DateTime field?

You can override the startTime of KPI instance based on the custom logic, whereby you have to change the `startTime` parameter.
```
  // when the case priority is modified and a new KPI instance is being created, the KPI instance needs to start from UTC instead of CreatedOn
        if ((int)(((OptionSetValue)(caseRecord.Attributes["priority"])).Value) == 1)
	{
            startTime = DateTime.UtcNow
	}

	// use OOB SLATimeCalculation Custom Action to do actual calculation_
	OrganizationRequest requestTimeCalculation = new OrganizationRequest("msdyn_SLATimeCalculation");
	requestTimeCalculation["startTime"] = startTime;
        ... rest code is same as previous examples
```

## How can I override the Warning or Dailure duration for a KPI instance instead of honoring the values set in the SLA Item form?

You can override the Warning or Failure of a KPI instance based on the custom logic, whereby you have to change the minutes parameter.

```
// when the case priority is modified and a new KPI instance is being created, the KPI instance must have failure time as 1 hour.
        if ((int)(((OptionSetValue)(caseRecord.Attributes["priority"])).Value) == 1)
	{
            newFailureTime = 60; // in minutes
	}

	// use OOB SLATimeCalculation Custom Action to do actual calculation_
	OrganizationRequest requestTimeCalculation = new OrganizationRequest("msdyn_SLATimeCalculation");
        requestTimeCalculation["minutes"] = newFailureTime;
        ... rest code is same as previous examples
```
> [!NOTE]
> This value is similar to being setup in SLA ITEM.
For example, if the failure duration is 16 hours and daily working hours in the calendar is 8 hours, then the actual Failure time will be after 2 calendar days. (8 days daily * 2 working days = 16 as failure duration).

## How to start the KPI from first working hours and then ignore the calendar hours?

You can override the final Failure time for a KPI instance based on the custom logic, whereby you have to find the first working hours and then add your failure duration.
For example, my daily working hours are 9AM-5PM in IST and failure Duration is 12 hours. If a case comes at 6 PM on 1st March 2022, I want the timer to start from 9 AM (first working hours) on 2nd March and then run for 12 hours (failure duration. It should compute the Failure Duration as 9 AM + 12 = 9 PM on 2nd March.

```
Step 1: Find the first working hours by passing minutes duration as 0.
        // when case priority is changed and new KPI instance is getting created,  we want the KPI instance to have failure time as 1 hour.
        if ((int)(((OptionSetValue)(caseRecord.Attributes["priority"])).Value) == 1)
	{
            firstWorkingHour= 0; // in minutes
	}

	// use OOB SLATimeCalculation Custom Action to do actual calculation_
	OrganizationRequest requestTimeCalculation = new OrganizationRequest("msdyn_SLATimeCalculation");
        requestTimeCalculation["minutes"] = firstWorkingHour;
        ... rest code is same as previous examples
        firstWorkingHoursTime= DateTime.SpecifyKind(DateTime.Parse((string)outputValue2), DateTimeKind.Utc);

Step 2:  Add your failure duration to first working hours.
        failureTime = firstWorkingHoursTime.AddMinutes(failureDuration);
```
[!INCLUDE[footer-include](../includes/footer-banner.md)]
