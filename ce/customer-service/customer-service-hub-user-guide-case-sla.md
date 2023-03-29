---
title: Understand SLAs
description: Understand how to track and view SLAs with the help of interactive dashboards in Customer Service workspace for Dynamics 365 Customer Service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.date: 03/29/2023
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
  - bap-template
---

# Understand SLAs

Understand the various service-level agreements (SLA) KPIs and SLA KPI Instance record details, related to time.

## Understand SLA details with Timer control

You can see the SLA details on the SLA-enabled entity record.

### Timer control for SLA-enabled entities

If your administrator has enabled the configurations to display the statuses of the configured SLA KPIs by using the SLA Timer control subgrid, you'll see the following details:

- The different status changes that the KPIs go through.
- When a KPI nears compliance or noncompliance, the time ticker changes to show the time in hours, minutes, and seconds, as applicable.
- The icons are updated for the different stages that the KPIs go through.
- The KPIs are refreshed at the interval that you specify at the time of configuration.

The statuses and their corresponding symbols are as follows.

| Symbol | Status |
|------|----------|
| :::image type="icon" source="media/slakpi-in-progress.ico"::: | In progress |
|:::image type="icon" source="media/slakpi-noncompliant.ico":::| Noncompliant |
|:::image type="icon" source="media/slakpi-nearing-noncompliance.ico":::| Nearing noncompliance |
|:::image type="icon" source="media/slakpi-paused.ico":::| Paused |
| :::image type="icon" source="media/slakpi-succeeded.ico":::| Succeeded |
| :::image type="icon" source="media/slakpi-canceled.ico":::| Canceled |
|||

A sample runtime view of the SLA Timer is as follows. The SLA KPIs displayed aren't in any particular order.

![Runtime view of SLA Timers.](media/sla-timer-runtime.png "Runtime view of SLA Timers")

For SLAs that are in the expired status, your administrator can configure the SLA Timer to display the elapsed time. The timer will display the countdown using a negative value in the red color. Only those SLA Timers that have been configured to show the negative time will display the negative countdown time. More information: [Enable elapsed timer for SLA items in terminal or expired status](add-timer-control-case-form-track-time-against-sla.md#enable-elapsed-time-for-sla-timers-in-expired-status)

:::image type="content" source="media/sla-negative-countdown-timer.png" alt-text="Display negative countdown for SLAs in expired or terminal status.":::

## Know the status of an SLA KPI Instance record

Based on the business hours, the timer displays the time remaining to meet the SLA or the elapsed time since the SLA failed. For example, if failure time is set to 5 days and business hours are 9:00 AM to 5:00 PM, then you'll see 5 days on the timer. If failure time is set to 10 hours, then you'll see 1 day and 2 hours on the timer. Your system administrator or customizer can add a timer to the SLA-enabled entity form.

When an SLA is applied to an entity, a related SLA KPI Instance record is created for each SLA KPI that is tracked for that entity. The on-hold time is the time for which the case was set to a status that you defined as On-Hold in the System settings dialog box. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Service tab.](/power-platform/admin/system-settings-dialog-box-service-tab)

For example, when you put a case on hold, the status of the SLA KPI Instance is set to Paused. You can see the time for which a case was on hold and the last time the case was put on hold. These details aren't available on the case form by default but your system customizer can add these fields on the case form for you.

When you resume a case, the status of the SLA KPI Instance record is updated. The following details are updated in the record if the SLA isn’t violated:

- Failure time
- Warning time
- Total time the case is on hold

If you put the case on hold after the warning time, then the warning time isn’t updated when the case is resumed. Similarly, the status of the SLA KPI Instance is updated when the first response time on a case is:

- Nearing expiry
- Has expired
- Has succeeded

> [!NOTE]
> - The SLA Timer continues to run after it's triggered or resumed. It includes the holiday hours, non-business hours, and pause time (only business hours) while projecting the SLA warning or failure time.  
> - The timer control auto-refreshes for **Pause** and **Resume** states to show the updated SLA. For all other states, you must refresh the page to view the refreshed SLA. Select **...** and select **Refresh** on the command bar to refresh the SLA Timer control.

You can now also apply SLAs on demand. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Apply SLAs](apply-slas.md#apply-slas)

To learn more about adding a timer control to an SLA-enabled entity, go to [Add a timer control for SLA-enabled entities](add-timer-control-case-form-track-time-against-sla.md).

## Know active duration and elapsed time for SLA KPI Instances

Track the time taken by SLA KPI Instances to reach their terminal status during business hours to evaluate whether the SLAs are realistic and take decisions about resourcing and efficiency.

The **Active Duration (min)** and **Elapsed Time (min)** fields for an SLA KPI Instance help you derive the exact number of business hours that were spent. The **Active Duration (min)** field will show data only when the KPI is in a **Paused** or terminal state. **Elapsed Time (min)** will show data only when the KPI is in an **In progress** or terminal state. The final value will appear in the last KPI instance after the terminal state. The active duration and elapsed time data is shown in minutes.

Active duration calculation will be asynchronous by default.
You might need to refresh the views that have an **Active Duration (min)** field after any create or update operation. You may also need to review any customizations associated with the **Active Duration** attribute of the SLA KPI instance.

You can view the active duration and elapsed time on the **SLA** tab of the custom entity as well.

- **Active Duration (min)**: Displays the time for which the SLA KPI Instance was active.

- **Elapsed Time (min)**: Displays the time for which the SLA KPI Instance timer was paused.

Both **Active Duration (min)** and **Elapsed Time (min)** are calculated based on the current value of the business hours and calendars, similar to warning and failure time calculation. So, changing the calendar working hours might affect the calculation.

:::image type="content" source="media/active-elapsed-time.png" alt-text="View Active and Elapsed Time duration":::

> [!NOTE]
> The **Active Duration (min)** and **Elapsed Time (min)** data aren't applicable for legacy SLAs.

### See also

[Use the Main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
