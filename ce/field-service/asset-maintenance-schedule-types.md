---
title: Asset maintenance schedule types (preview)
description: Asset maintenance schedule types help you choose calendar, usage milestone, or sequential schedules for assets. Learn when to use each option.
ms.date: 10/28/2026
ms.topic: concept-article
author: jshotts
ms.author: jasonshotts
ms.reviewer: v-wendysmith
ms.custom: 
    - ai-gen-docs-bap
    - ai-seo-date: 09/28/2026
ai-usage: ai-assisted
---

# Asset maintenance schedule types (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Asset maintenance schedule types define how and when maintenance tasks are scheduled for assets. They help ensure that maintenance is performed at the right time, based on calendar dates, asset usage, or sequential service requirements. An asset can have one or more maintenance schedule types assigned to it, depending on its maintenance needs.

When deciding which maintenance schedule type to use, think about what triggers the maintenance. Consider the nature of the maintenance task, the asset's usage patterns, and any regulatory or manufacturer requirements. Choose the schedule type that best aligns with the timing and conditions under which the maintenance should occur.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Calendar recurrence

Use calendar recurrence for maintenance that follows a fixed calendar schedule. This type of schedule is ideal for tasks that you need to perform on specific dates or at regular intervals, such as weekly, monthly, or yearly maintenance activities.

Determine due dates based on the fixed calendar intervals defined in the schedule, such as every Thursday or the first day of each month. You want work orders to generate on a fixed schedule without waiting for previous work to complete.

**Why use calendar recurrence?** Regulatory inspections, safety checks, seasonal preparation, or routine preventive maintenance benefit from a fixed calendar schedule.

**Quick tip:** Do this task because the date arrived.

## Total life or usage milestone

Use total life or usage milestone schedules for maintenance based on the total life or total usage of the asset. This type of schedule is ideal for tasks that you need to perform after the asset reaches a certain usage threshold or age.

Determine due dates based on the asset's lifetime usage or age. For example, if you schedule a task for every 3,000 service meter units (SMU) or two years in service, calculate the due dates based on the asset reaching those milestones. You want work orders to generate on a fixed schedule without waiting for previous work to complete.

**Why use total life or usage milestone?** Major component replacements, rebuilds that occur at specific cumulative life milestones, or replacing parts at specific usage or age thresholds benefit from this type of schedule.

**Quick tip:** Do this task because the asset accumulated a certain amount of lifetime usage.

## Sequential service pattern

Use sequential service pattern schedules for maintenance intervals that repeat relative to the preceding service in a sequence. This type of schedule is ideal for tasks that you need to perform in a specific order, with each subsequent service occurring after a defined interval from the previous one.

Due dates are based on the completion of the preceding service and the defined interval for the subsequent service. For example, if a task is scheduled for every 500 SMU from the preceding service, the due date for the next service is calculated based on the asset reaching 500 SMU after the previous service. Work orders generate sequentially, with each new work order depending on the completion of the previous one.

**Why use sequential service pattern?** Maintenance tasks that you need to perform in a specific order and owner equipment manufacturer (OEM) maintenance recommendations benefit from this type of schedule.

**Quick tip:** Do this task because each service depends on the completion of the previous one.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
