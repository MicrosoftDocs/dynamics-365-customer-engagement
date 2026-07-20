---
title: Schedule work orders linked to projects and project tasks
description: Learn about scheduling a work order in Field Service that was created from a project or project taskin Project Operations.
ms.date: 06/30/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
---

# Schedule work orders linked to projects and project tasks

Scheduling work orders linked to projects and project tasks in Field Service uses the same processes as scheduling any other work order. However, consider some additional factors when scheduling work orders that are linked to projects or project tasks.

To help you identify work orders linked to projects and tasks:

- Add **Project** and **Project Task** to the **Work Orders** page in Field Service by using **Edit columns**.
- Use the **Project** tab at the bottom of the schedule board to view and manage work orders linked to projects and project tasks.

## Prerequisites

- You have a [Field Service dispatcher or administrator role](security-permissions.md#field-service-security-roles).
- For work orders linked to project tasks: A project manager created project tasks in the [work breakdown structure](/dynamics365/project-operations/project-management/create-wbs) in Project Operations.
- For work orders linked to project tasks: A [work order tied to a project task was created in Project Operations](/dynamics365/project-operations/field-service-integration/project-operations-integration-po-work-order-task).

## Schedule a work order linked to a project

Schedule a work order linked to a project like other work orders. Use the [schedule board](work-with-schedule-board.md) or [schedule assistant](schedule-assistant.md).

## Schedule a work order linked to a project task

When a project manager creates a work order from a project task in Project Operations, the work order appears in Field Service for scheduling and execution. The **Time Promised Start** and **Time Promised End** values come from the task’s planned start and end dates. If the project task dates change, the time promised dates update automatically as long as the work order is *Unscheduled* or *Scheduled*.

If you attempt to schedule a work order that conflicts with project constraints, one or more warnings appear. Common constraints that create warnings include:

- Scheduling a work order outside the project task data range.
- Scheduling a work order before a predecessor task is complete.
- Task dates change after a work order is scheduled.

:::image type="content" source="media/project-operations-integration-schedule-warnings.png" alt-text="Screenshot of Field Service work order showing schedule warnings.":::

Keep these constraints in mind when scheduling.

To schedule the work order, follow these steps:

1. Open the work order in Field Service.

1. Review the work order details.

1. Select the **Project Task Dependencies** tab to view predecessor and successor tasks. Change the **Predeccessor Project Tasks** view to **Successor Project Tasks** to toggle between both.

   :::image type="content" source="media/project-operations-integration-work-order-dependencies.png" alt-text="Screenshot of Field Service work order project task dependencies.":::

1. Use the [schedule board](work-with-schedule-board.md) or [schedule assistant](schedule-assistant.md).

To see how scheduling warnings and predecessor tasks are viewed in the Field Service mobile app, watch the following video.

:::image type="content" source="media/project-operations-integration-mobile-schedule.gif" alt-text="Gif of scheduling warnings and predecessor tasks in the mobile app.":::


[!INCLUDE[footer-include](../includes/footer-banner.md)]
