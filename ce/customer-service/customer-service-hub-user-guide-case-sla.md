---
title: "Track and manage SLAs in Customer Service Workspace | Microsoft Docs"
description: "Learn how to track and manage SLAs with the help of interactive dashboards in Customer Service Workspace for Dynamics 365 Customer Service."
ms.date: 06/15/2022
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

# Manage SLAs

You can track and manage SLAs in Customer Service Workspace.

## Track SLA details with Timer control

You or the agent working on the SLA-enabled entity record can see the SLA details.

### Timer control for SLA-enabled entities

If your administrator has enabled the configurations to  display the statuses of the configured SLA KPIs by using the SLA Timer control subgrid, you'll see the following details:

- The different status changes that the KPIs go through.
- When a KPI nears compliance or noncompliance, the time ticker changes to show the time in hours, minutes, and seconds, as applicable.
- The icons are updated for the different stages that the KPIs go through.
- The KPIs are refreshed at the interval that you specify at the time of configuration.

The statuses and their corresponding symbols are as follows.

| Symbol | Status |
|------|----------|
| :::image type="icon" source="media/slakpi-in-progress.ico"::: |In progress |
|:::image type="icon" source="media/slakpi-noncompliant.ico":::| Noncompliant |
|:::image type="icon" source="media/slakpi-nearing-noncompliance.ico":::| Nearing noncompliance |
|:::image type="icon" source="media/slakpi-paused.ico":::| Paused |
| :::image type="icon" source="media/slakpi-succeeded.ico":::| Succeeded |
| :::image type="icon" source="media/slakpi-canceled.ico":::|Canceled |
|||

A sample runtime view of the SLA Timer is as follows. The SLA KPIs aren't displayed in any particular order.

![Run time view of SLA timers.](media/sla-timer-runtime.png "Run time view of SLA timers")

For SLAs that are in the expired status, your administrator can configure the SLA timer to display the elapsed time. The timer will display the countdown using a negative value in the red color. Only those SLA timers that have been configured to show the negative time will display the negative countdown time.

:::image type="content" source="media/sla-negative-countdown-timer.png" alt-text="Display negative countdown for SLAs in expired or terminal status.":::

More information: [Enable elapsed timer for SLA items in terminal or expired status](add-timer-control-case-form-track-time-against-sla.md#enable-elapsed-time-for-sla-timers-in-expired-status)

### View the status of an SLA KPI Instance record

Based on the business hours, the timer displays the time remaining to meet the SLA or the elapsed time since the SLA failed. For example, if failure time is set to 5 days and business hours are 9:00 a.m. to 5:00 p.m., then you'll see 5 days on the timer. If failure time is set to 10 hours, then you'll see 1 day and 2 hours on the timer. Your system administrator or customizer can add a timer to the SLA-enabled entity form.

When an SLA is applied to an entity, a related SLA KPI Instance record is created for each SLA KPI that is tracked for that entity. The on-hold time is the time for which the case was set to a status that you defined as an On-Hold status in the System settings dialog box. 
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Service tab.](/power-platform/admin/system-settings-dialog-box-service-tab)

For example, when you put a case on hold, the status of the SLA KPI Instance is set to Paused. You can see the time for which a case was on hold and the last time the case was put on hold. These details aren't available on the case form by default, but your system customizer can add these fields on the case form for you.

When you resume a case, the status of the SLA KPI Instance record is updated. The following details are updated in the record if the SLA isn’t violated:

- Failure time
- Warning time
- Total time the case is on hold

If yu put the case on hold after the warning time, then the warning time isn’t updated when the case is resumed.
Similarly, the status of the SLA KPI instance is updated when the first response time on a case is:

- Nearing expiry
- Has expired
- Has succeeded

> [!NOTE]
>
> - The SLA timer continues to run after it is triggered or resumed. It includes the holiday hours, non-business hours, and pause time (only business hours) while projecting the SLA warning or failure time.  
> - The timer control auto-refreshes for **Pause** and **Resume** states to show the updated SLA. For all other states, you must refresh the page to view the refreshed SLA. Select **...** and select **Refresh** on the command bar to refresh the SLA timer control.

You can now also apply SLAs on demand. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Apply SLAs](apply-slas.md#apply-slas)

To learn more about adding a timer control to an SLA-enabled entity, see [Add a timer control for SLA-enabled entities](add-timer-control-case-form-track-time-against-sla.md).


### See also

[Use the Main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
