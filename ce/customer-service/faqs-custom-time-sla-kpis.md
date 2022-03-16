---
title: "FAQs about custom time calculation of SLA KPIs | MicrosoftDocs"
description: "Learn about the frequently asked questions (FAQs) on custom time calculation of SLA KPIs."
ms.date: 03/16/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
---

# FAQs about custom time calculation of SLA KPIs

## Overview

This topic contains the frequently asked questions (FAQs) that you as an administrator might have about the custom time calculation of service-level agreements (SLAs) key performance indicators (KPIs).

## When will be the custom action or plug-in be initiated?

The custom action or plug-in will be initiated during the creation of a new SLA KPI instance, which also includes a SLA KPI, that has been resumed from a pause status.

## How is the pause resume scenario different from a SLA KPI instance creation?

Pause and resume scenario includes the following two steps:

1. The Custom Action is initiated with requestType as `getElapsedTime`. This calculates the time elapsed between the paused and resumed state of the SLA KPI.
2. The Custom Action is initiated with requestType as `getEndTime`. This calculates the new `WarningTime` by adding the above `elapsedTime` to the current `warningTime`. A similar calculation is also done for `FailureTime`.

## How can I override the `StartTime` for a SLA KPI instance without creating and updating the custom DateTime field?

You can override the startTime of a SLA KPI instance based on the custom logic, whereby you have to change the `startTime` parameter.
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

## How can I override the Warning or Failure duration for a KPI instance instead of the values defined in the SLA Item?

You can override the Warning or Failure of a SLA KPI instance based on the custom logic, whereby you must change the following parameter. Note that the value provided must be in minutes.

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


```

```
[!INCLUDE[footer-include](../includes/footer-banner.md)]
