---
title: Update a work order service task (preview)
description: Update the progress, status, inspection result, or other fields of one service task on a Field Service work order.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.service: dynamics-365-field-service
ms.custom: mcp-enabled-namespaces=field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Update a work order service task (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Update one step on a work order's checklist. Record progress, completion, an inspection result, or another task detail directly in chat.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Your security role must allow you to read and update work order service tasks.
- Field-level security, your organization's business rules, and Field Service inspection requirements still apply.
- Identify the work order and task you want to change. Use the task name shown on the work order.

## Try prompts like

- Mark the thermostat diagnosis task complete.
- Set the filter replacement task to 50 percent.
- Replace the description of the inspect unit task with: replaced worn belt.
- Set the inspection result on the pressure test task to Pass.
- The pressure test failed.

## What you can do

1. Name the task and its work order. If several tasks match, choose the correct one before continuing.
2. State the change, such as a completion percentage, status reason, inspection result, or another editable field. Setting progress to 100 percent marks the task complete.
3. Clarify any field, choice, or related record that matches more than one possibility.
4. Review the text result, which identifies the task and shows previous and new values. If the task already has the requested values, the reply says no change was needed.

Ask explicitly to replace a task description when that's what you intend. Replacement removes the previous description. A note, including a completion note, is different: ask for a field observation note preview to review and save instead.

## Save and confirm changes

Progress, status, and ordinary field updates apply directly. An inspection result other than Pass, such as Fail or Partial Success, requires a preview first. Nothing in that preview is saved until you approve the exact proposed change in a later message. A changed task or result needs a new review.

If someone else changed the task, review the latest values before trying again. This action updates one existing task; it doesn't create or delete tasks or directly update the work order, booking, parts, or notes.

## Tips and limitations

- If Field Service can't complete a task because its linked inspection isn't fully set up, finish the inspection in the Field Service app or ask an administrator to correct its inspection data.
- Earlier task lists don't refresh automatically. Ask to see the tasks again after an update.
- To record a task update together with a note, part usage, or booking status, describe the changes in one message to prepare a work progress plan.

## Related information

- [List work order service tasks](list_work_order_service_tasks.md)
- [Prepare a field observation note](format_field_observation.md)
- [Capture work progress](capture_work_progress.md)
- [View a work order](get_work_order.md)
