---
title: Troubleshoot SLA issues in Customer Service | Microsoft Docs
description: Know about the SLA issues and how to troubleshoot them.
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 12/30
/2020
ms.topic: article
ms.service: dynamics-365-customerservice
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

# Troubleshoot service-Level agreement (SLA) issues in Customer Service

## Warn and fail duration times are incorrect for the SLA

Why do I see that some SLAs do not take into account daylight saving time for warn and fail duration?

### Reason

If your SLA was created in the web client that is now deprecated, the business schedule calendar does not support daylight saving time.

### Resolution

To use the daylight saving time functionality and many other new features, migrate your SLAs created in the web client to Unified Interface. More information: [Migrate automatic record creation rules and service-level agreements](migrate-automatic-record-creation-and-sla-agreements.md).

## SLA timer does not pause when its state is changed from InProgress to OnHold on a holiday

Once triggered, the SLA timer continues to run even when its state is changed from *InProgress* to *OnHold*. 

### Reason

When a holiday is configured, the status of the case is updated to *OnHold* to pause the case service level agreement (SLA). However, the pause functionality associated with the *OnHold* status doesn't function correctly. Therefore, the timer continues to run even on a holiday when it should be paused.

Due to this, it includes the holiday hours, non-working hours, and pause time (only business hours) while projecting the SLA warning time or failure time. 

### Resolution

This is an intended functionality. Your organization defines business hours while scheduling working days and holidays. SLA warning time and failure time adhere to those settings and are calculated based on the defined hours.

See the following scenarios to understand how the SLA *Warn* and *Failure* time is calculated:

- Create a case during non-working hours. Pause and resume the case before working hours start. Hold time between *Pause* and *Resume* will not be considered.
- Create a case during non-working hours. Pause and resume the case during working hours. Hold time will be considered and *Warn* and *Failure* time will be extended based on hold time.
- Create a case during working hours. Pause the case during working hours. Resume the case during non-working hours. Hold time will not be considered for *Warn* and *Failure* time.
- Create a case during working hours. Pause the case during non-working hours and resume it during working hours. *Warn* time and *Fail* time will be recalculated.


## SLA KPI status shows as canceled

### Scenario

When you update the target record such that “applicable when” condition is no more applicable, the status moves from active to resolved, and the SLA KPI status moves from the existing state (Inprogress/Succeeded/Expired) to the canceled state. Consider the following scenario in which you create an SLA with the following conditions and set it as the default SLA.
- asfalkfalsf
- flakflakfsl

1. Create a new case. Case status is set to active by default and SLA is applied.
2. Timer starts running. Set case type to problem.
3. SLA KPI instance status gets succeeded.
4. Resolve the case. Case status is set to resolved.

### Reason

The "applicable when" condition is no longer applicable.

### Workaround

Try not to define the "applicable when" condition on fields whose values change frequently.

## Executing success, warning, and failure actions multiple times

Updates are made to the target record such that those attributes are modified that are present in the applicable when of an SLA item in the applied SLA.

### Reason

Changing an attribute in a record that is in applicable when condition in the legacy SLA.

### Resolution

We recommend using those attributes in applicable when which are not changed frequently by customers.

Consider a scenario where you want to create a legacy SLA in which an SLA item has applicable when and success conditions, and set it as default.
  
1. Create a case with case type = question.
2. SLA timer gets started. Add *resolved* to case title to make the success condition true.
3. When SLA KPI instance is succeeded:
    * SLA KPI instance status is updated to succeeded and if there is any success action, that would be executed, for example, send email.
    * Update the case type to request.
    * SLA KPI Instance which is in succeeded status is reevaluated, since the  applicable when attribute (case type) is changed.
    * SLA KPI instance moves from succeeded to in progress. Since case title contains resolved and the success condition is true, it goes back from in progress to succeeded, thus executing the success action again.
4. When SLA KPI instance is nearing noncompliance:
    * Warning time has arrived and SLA KPI instance status is nearing noncompliance. If there is any warning action configured it is executed.
    * Update the case type to request.
    * The SLA KPI instance that is nearing noncompliance status is reevaluated since the applicable when attribute (case type) is changed.
    * SLA KPI instance moves from nearing noncompliance to in progress, and since warning time has already crossed, it goes back from in progress to nearing noncompliance, thus executing the warning action again.
5. When SLA KPI instance is noncompliant:
    * Failure time has arrived and SLA KPI instance status is noncompliant. If there is any failure action configured, it is executed.
    * Update the case type to request.
    * SLA KPI instance which is in noncompliant status is reevaluated, since the applicable when attribute (case type) is changed.
    * SLA KPI instance moves from noncompliant to in progress. Since warning and failure time has already crossed, it goes back from in progress to nearing noncompliance and then to noncompliance, thus executing the warning and failure actions again.
6. When SLA KPI instance status changes from terminal state (succeeded, expired, canceled) to active state (in progress, nearing non-compliance):
    * SLA KPI instance is in succeeded status.
    * Update case type: remove *resolved* from case title and change the case type from question to request (or from request to question).
    * The SLA KPI instance which is in succeeded status is reevaluated, since the applicable when attribute (case type) is changed.
    * SLA KPI instance moves from succeeded to in progress. Since case title does not contain resolved, it stays in in progress or moves to nearing noncomplince or noncompliance depending on the calculated warning and failure times.
      
## More help

[Track SLA details with Timer Control](customer-service-hub-user-guide-case-sla.md#track-sla-details-with-timer-control)

[Define Service Level Agreements (SLAs)](define-service-level-agreements.md)


