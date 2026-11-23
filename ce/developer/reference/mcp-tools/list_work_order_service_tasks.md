---
title: List work order service tasks (preview)
description: View the service tasks on a Dynamics 365 Field Service work order in an interactive grid, and mark tasks complete or edit them directly in chat.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=field-service
ms.service: dynamics-365-field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# List work order service tasks (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Review the checklist for a job and see what's finished. Update task progress from the list without opening the work order.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Your security role must allow you to read work order service tasks. Marking tasks or editing them also requires update permission.
- The default public view for work order service tasks must be available. Field Service includes the **Active Work Order Service Tasks** view.
- Task editing must be available in your environment; otherwise, the list is read-only.

## Try prompts like

- List the service tasks for this work order.
- Show the tasks on work order WO-00042.
- What's on the checklist for my Contoso Coffee job?
- Show me the steps for my next booking.
- Which tasks are left on this job?

## What you can do

1. Name the work order by its number, customer, or booking name among your current work. For a follow-up, refer to the work order already identified in the conversation.
2. Review the tasks in work order sequence and the progress bar showing how many are complete. Typical columns include task name, completion percentage, and estimated and actual duration.
3. Sort by a column or search the list to find a task.
4. Use the round button at the end of a row to mark a task complete or incomplete. This sets its completion percentage to 100 or back to 0.
5. Expand a row to edit available fields and save each change. Refresh afterward when you need the latest task list.

Use full screen where supported for more room. On narrow screens, search and column headings are hidden until you use the larger view.

## Data changes

Viewing, sorting, searching, and refreshing don't change records. Marking a task or saving an edit updates that task.

An inspection result other than Pass requires review and confirmation before it's saved. Review any preview rather than assuming the first request completed the change.

## Tips and limitations

- If several work orders match, choose the correct one before reviewing tasks.
- The list shows up to 50 tasks by default. Ask for more, up to 200. A warning means additional tasks might exist.
- Lists shown earlier are snapshots. Refresh after changing a task elsewhere.
- Some fields, including related-record selections, are read-only in the list. An administrator controls the columns through the default public view.

## Related information

- [Update a work order service task](update_work_order_service_task.md)
- [Capture work progress](capture_work_progress.md)
- [List work order products and services](list_work_order_lines.md)
- [View a work order](get_work_order.md)
