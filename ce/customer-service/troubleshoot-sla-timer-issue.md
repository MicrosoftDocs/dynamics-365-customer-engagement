---
title: Troubleshoot SLA timer issue in Customer Service Hub app | Microsoft Docs
description: Know how to fix the issue where SLA Timer does not stop, when state is changed from OnHold to InProgress on a Holiday
author: anjgupta
ms.author: anjgup
manager: shujoshi
ms.date: 08/07/2018
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# SLA timer does not pause when its state is changed from InProgress to OnHold on a holiday

## Issue

Once triggered, the SLA timer continues to run even when its state is changed from *InProgress* to *OnHold*. 

When a holiday is configured, the status of the case is updated to *OnHold* to pause the case service level agreement (SLA). However, the pause functionality associated with the *OnHold* status doesn't function correctly. Therefore, the timer continues to run even on a holiday when it should be paused.

Due to this, it includes the holiday hours, non-working hours, and pause time (only business hours) while projecting the SLA warning time or failure time. 

## Resolution

This is an intended functionality. Your organization defines business hours while scheduling working days and holidays. SLA warning time and failure time adhere to those settings and are calculated based on the defined hours.

See the following scenarios to understand how the SLA *Warn* and *Failure* time is calculated:

- Create a case during non-working hours. Pause and resume the case before working hours start. Hold time between *Pause* and *Resume* will not be considered.
- Create a case during non-working hours. Pause and resume the case during working hours. Hold time will be considered and *Warn* and *Failure* time will be extended based on hold time.
- Create a case during working hours. Pause the case during working hours. Resume the case during non-working hours. Hold time will not be considered for *Warn* and *Failure* time.
- Create a case during working hours. Pause the case during non-working hours and resume it during working hours. *Warn* time and *Fail* time will be recalculated.

## More help

[Track SLA details with Timer Control](customer-service-hub-user-guide-case-sla.md#track-sla-details-with-timer-control)

[Define Service Level Agreements (SLAs)](define-service-level-agreements.md)


