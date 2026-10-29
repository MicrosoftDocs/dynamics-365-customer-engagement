---
title: Manage maintenance service events (preview)
description: Manage maintenance events with the Actions menu to skip, complete, link, or reset occurrences outside the standard work order flow.
ms.date: 10/28/2026
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.reviewer: v-wendysmith
ms.custom: 
    - ai-gen-docs-bap
    - ai-seo-date: 09/30/2026
ai-usage: ai-assisted
---

# Manage maintenance service events (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

View the service events of an asset's maintenance plan after they're [generated for an asset](asset-maintenance-review-maintenance-plan.md#generate-service-events). Use the **Actions** menu on a service event to make adjustments.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

The available actions depend on the service event's status, [maintenance schedule type](asset-maintenance-schedule-types.md), position in a sequence, and whether a work order is already linked.

| Action | When it's available | Result |
| --- | --- | --- |
| [Not needed](#mark-an-occurrence-as-not-needed) | An open **Forecasted** or **Due** service event with no linked work order and no earlier sequence item blocking it. For a **Sequential** service event, the current event and the next eligible projected event are eligible. | Marks the event **Skipped** and prevents work order generation. In a **Sequential** service event, skipping advances the sequence. The projected skip takes effect when the sequence reaches that event. |
| [Mark done](#mark-maintenance-as-done) | An open **Forecasted** or **Due** service event with no linked work order and no earlier sequence item blocking it. For a **Sequential** service event, the current event is eligible. | Records maintenance completed outside the generated work order flow and updates the maintenance schedule to the next event or next sequence step. |
| [Link completed work order](#link-a-completed-work-order) | An open **Forecasted** or **Due** service event with no  linked work order and an effective due date. for a **Sequential** service event, the current event is eligible. | Links the completed work order, marks the event completed, and updates the maintenance schedule to the next event or next sequence step. |
| [Replace linked work order](#replace-linked-work-order) | A completed service event with a linked work order. The replacement work order must be complete. For a **Sequential** service event, the event isn't the active event and must belong to the current sequence definition. | Replaces the linked work order with the new one without updating the next event. The previously linked work order isn't changed. |
| [Change due date](#change-due-date) | An open **Forecasted** or **Due** service event with no linked work order. For a **Sequential** service event, the current event is eligible. | Sets an override due date for the service event. |
| [Restore occurrence](#restore-occurrence) | A **Calendar** or **Total life or usage milestone** service event previously marked *Not needed* with an effective due date only if no later service activity is completed or linked to a work order. | Clears the skipped state and returns the service event to **Forecasted**. |
| [Reset sequence](#reset-sequence) | The most recent **Sequential** service event previously marked *Not needed* only if no later event has been completed or linked to a work order and no unresolved work from a previous sequence event prevents the reset. | Clears the skipped state and returns the service event to **Forecasted**. |

### Mark an occurrence as not needed

Select **Not needed** when the maintenance isn't required for this occurrence, and a work order doesn't need to generate.

Example: A maintenance schedule requires a filter inspection every three months. During the current inspection period, monitoring data shows that the filter is still clean and operating within specifications. Select **Not needed** to skip this occurrence. The next scheduled maintenance event remains in the sequence.

### Mark maintenance as done

Select **Mark done** when the service was completed outside the generated work order flow. Enter the date when service was completed and submit.

Example: A technician performs a scheduled equipment inspection during an onsite visit but doesn’t use a generated work order. Select **Mark done**, enter the completion date, and the system marks the service event as completed. The maintenance schedule then moves to the next event or sequence step only once.

### Link a completed work order

Select **Link completed work order** when the scheduled service event was completed through an existing work order, but that work order wasn’t originally linked to the event. The selected work order must have a completion date and a system status of *Completed* or *Posted*.

> [!IMPORTANT]
> Verify that you select the work order for the intended asset and maintenance activity.

Example: A technician completes a scheduled annual inspection using a manually created work order. The service event is still due because the work order wasn’t generated from the maintenance schedule. Select **Link completed work order** and choose the completed inspection work order. The system links the work order, marks the service event *Completed*, and updates the maintenance schedule to the next event or sequence step only once.

### Replace linked work order

Select **Replace linked work order** when a completed service event is linked to the wrong work order. The new work order must have a completion date and a system status of *Completed* or *Posted*.

Example: A completed annual inspection event is linked to work order WO-100, but the technician actually completed the inspection under WO-105. Select **Replace linked work order** and choose WO-105. The service event remains completed, the maintenance schedule doesn’t advance again, and WO-100 remains unchanged.

### Change due date

Select **Change due date** when a scheduled service event is still open, but the work needs to occur earlier or later than its calculated due date. Changing the date doesn’t complete, skip, or advance the maintenance schedule.

Example: A scheduled quarterly inspection is due on June 15, but the technician can only perform it on June 20. Select **Change due date**, enter June 20 as the new date, and submit. The system updates the detail with the new due date without affecting the completion status or the maintenance sequence.

### Restore occurrence

Select **Restore occurrence** to undo a **Not needed** action for a **Calendar recurrence** or **Total life or usage milestone** service event because the service is needed. Restoring it returns the event to *Forecasted* and its original scheduled date.

Example: A June inspection was skipped because the equipment was expected to be out of service. The equipment returns to operation earlier than planned, so the inspection is needed after all. Select **Restore occurrence** to return the June inspection to *Forecasted*, provided no later event is completed, linked to a work order, or otherwise finalized.

### Reset sequence

Select **Reset sequence** to undo a **Not needed** action for a **Sequential** service event because the service is needed. The event is returned to its original sequence.

Example: A sequence contains **Inspect equipment** → **Replace filter** → **Test operation**. You previously marked **Replace filter** as *Not needed*, so the sequence moves to **Test operation**. Later, you determine that the filter must be replaced. Select **Reset sequence** to return **Replace filter** to *Forecasted* and restore it as the current sequence event. You can reset the event only if no later sequence event is completed or linked to a work order and the system still has the saved sequence position.

### Understand unavailable actions

An unavailable action includes an explanation in the action panel. Common reasons include:

- The maintenance schedule type doesn't support the action.
- The detail already has a linked work order.
- The detail is completed, canceled, or skipped.
- An earlier service event in the maintenance sequence must be completed or closed first.
- Reset safety can't be confirmed or downstream committed work makes reset unsafe.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
