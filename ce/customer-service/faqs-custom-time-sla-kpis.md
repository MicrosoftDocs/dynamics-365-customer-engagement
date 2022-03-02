---
title: "FAQs about custom time calculation of SLA KPIs | MicrosoftDocs"
description: "Learn about the frequently asked questions (FAQs) on custom time calculation of SLA KPIs."
ms.date: 03/02/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
---

# FAQs about custom time calculation of SLA KPIs

## Overview
This topic contains the frequently asked questions (FAQs) that you as an administrator might have about the custom time calculation of service-level agreements (SLAs) key performance indicators (KPIs).

## When will be the custom action or plug-in be invoked?

It will be invoked whenever a new KPI instance need to be created. For example:

- Whenever a SLA is applied/Changed
- Whenever a SLA Item is applied/changed
- Whenever a SLA kpi instance record is Resumed after it was put into Pause

## How is the Pause Resume scenario different than normal KPI instance creation?
In pause and resume scenario, its 2 step process.
First the Custom Action will be invoked with requestType as "getElapsedTime". This will calculate the time elapsed between the case paused till case resumed.
Secondly the Custom Action will be invoked with requestType as "getEndTime". This will calculate the new WarningTime by adding the above elapsedTime to current warningTime (similar calculation for FailureTime)


## How to handle deployments and down time?
When the custom time calculation workflow is deactivated (during deployment or manually), it will create downtime for that SLA item. Please ensure that deployment is done during dark hours to impact any running cases or new cases.
To minimize the downtime, please bring SLAs in separate solution (avoid any other irrelevant changes as part of same solution)

## How to Override the StartTime for a KPI instance without creating and updating the custom field DateTime field?
You can override the startTime of KPI instance based on the custom logic, in this case you have to change the startTime parameter. (similar to previous example, where we override the calendarId).

```
// when case priority is changed and new KPI instance is getting created,  we want the KPI instance to start from UTC now instead of CreatedOn
        if ((int)(((OptionSetValue)(caseRecord.Attributes["priority"])).Value) == 1)
	{
            startTime = DateTime.UtcNow
	}

	// use OOB SLATimeCalculation Custom Action to do actual calculation_
	OrganizationRequest requestTimeCalculation = new OrganizationRequest("msdyn_SLATimeCalculation");
	requestTimeCalculation["startTime"] = startTime;
        ... rest code is same as previous examples
```

## How to Override the Warning or failure Duration for a KPI instance instead of honoring the values set in the SLA Item form?

You can override the Farning or Failure of KPI instance based on the custom logic, in this case you have to change the minutes parameter. (similar to previous example, where we override the calendarId or startTime).

```
// when case priority is changed and new KPI instance is getting created,  we want the KPI instance to have failure time as 1 hour.
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
> This value is similar to being setup in SLA ITEM. For e.g. if failure Durtion is 16 hours and daily working hours in calendar is 8 hours, then actual Failure time will be after 2 calendar days. (8 days daily * 2 working days=16 as failure duration).

## How to start the KPI from first working hours and then ignore the calendar hours?
You can override the final Failure time for a KPI instance based on the custom logic, in this case you have to find the first working hours and then add your failure duration.
For e.g. My daily working hours are 9AM-5PM in IST and failure Duration is 12 hours.
if case comes at 6 PM on 1st March 2022, i want the timer to start from 9 AM(first wokring hours) on 2nd March and then run for 12 hours(failure duration).
It should compute the Failure Duration as 9 AM+12=9 PM on 2nd march.

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

Step 2:  Add your failure Duration to first working hours.
        failureTime = firstWorkingHoursTime.AddMinutes(failureDuration);
```
[!INCLUDE[footer-include](../includes/footer-banner.md)]
