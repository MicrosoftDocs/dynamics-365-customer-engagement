---
title: Capture work progress (preview)
description: Describe completed work and review a plan of Dynamics 365 Field Service updates before applying changes to job records.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.service: dynamics-365-field-service
ms.custom: mcp-enabled-namespaces=field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Capture work progress (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Describe your work on a job in one message, then review the proposed updates together. Use a work progress plan during a visit or when you're ready to finish the job.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Your environment must have the Field Service Agent solution installed.
- Your security role must allow you to manage change plans and read and update the work orders, bookings, service tasks, and product lines involved, and create notes.
- Your role also needs access to the related accounts and configured work order and booking statuses. Field-level security and your organization's business rules still apply.

## Try prompts like

- Replaced the air filter, used two filters, and finished the inspection task on WO-00042.
- Add a note that the compressor is noisy and set my booking to traveling.
- Set the inspection task to 50 percent and note that I'm waiting on the customer.
- Actually, it was three filters, not two.
- Don't mark the job complete yet.

## What you can do

1. Identify the job by work order number, customer, or booking name, and describe what you did. One plan covers one work order.
2. Review the proposed changes in the card. Check the matched records, previous values, and new values. A plan can combine a note, service task progress or field changes, parts used and quantities, work order details or resolution, booking status, and work order status.
3. Answer questions about missing or unclear details, then select **Continue**. You can choose the work order when several match. Decline an individual question with **None of these** or **Don't record this** without stopping the rest of the plan.
4. Select or clear the checkbox for each change. Add, correct, or remove changes in chat while the plan is open.
5. When you're satisfied, confirm the selected changes, then select **Apply changes** when asked to confirm again. Check each result afterward.

Requests that can't be recorded here, such as time entries or labor lines, appear separately with alternatives. Anything you asked not to change is also shown separately.

## Save and confirm changes

Preparing or reviewing the plan stores a temporary plan in Dataverse. It doesn't update operational work orders, bookings, service tasks, products, or notes. Applying the reviewed changes is a separate step, usually with two confirmations. Your initial description, "all," or "I'm done" isn't confirmation.

An unapplied plan expires 10 minutes after creation. To stop without applying it, say so or select **Cancel**. This doesn't necessarily delete the stored plan.

Some changes can succeed while others fail. Dependent changes are skipped when their prerequisite fails; unrelated changes can continue. Successful changes aren't automatically undone. If a save can't be confirmed, check the affected record before retrying.

## Tips and limitations

- A plan holds up to 12 changes. Split a larger update into separate plans.
- Name each task or part you want changed. "Complete all tasks" doesn't automatically select every task; review the questions and identify each record.
- Start a new plan for a different work order.
- For a standalone note, use a field observation note preview instead.

## Related information

- [Apply work progress](apply_work_progress.md)
- [Prepare a field observation note](format_field_observation.md)
- [Update a work order](update_work_order.md)
- [List work order service tasks](list_work_order_service_tasks.md)
