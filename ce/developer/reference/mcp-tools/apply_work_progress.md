---
title: Apply work progress (preview)
description: Apply the Dynamics 365 Field Service changes a technician reviewed and confirmed in a captured work progress plan.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.service: dynamics-365-field-service
ms.custom: mcp-enabled-namespaces=field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Apply work progress (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Save the job updates you've reviewed together in a work progress plan. Apply only the changes you want to keep, then check the result of each one.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Prepare and review a work progress plan in the same conversation, using your own account.
- Your environment must have the Field Service Agent solution installed.
- Your security role must allow you to manage change plans and make the job updates in the plan. Field-level security and your organization's business rules still apply.

## Try prompts like

- Yes, apply those changes.
- Confirm the selected changes.
- Go ahead and save the plan.
- Yes, confirm again.

These replies confirm a plan you've already seen. Including "confirm" in the message that first describes your work doesn't approve a plan that hasn't been reviewed.

## What you can do

1. Review the work order, affected records, and previous and proposed values.
2. Select the changes to keep. To correct the plan, describe the correction in chat instead of confirming.
3. Confirm the selected changes. Applying a plan usually requires two confirmations: the first prepares it, and the second applies it.
4. Review the results in the existing review card or text summary. Each change shows whether it was saved, wasn't needed, was skipped, or failed.

The plan can include notes, service task updates, parts used, work order details and completion, and your booking status. It doesn't create time entries or labor lines.

## Save and confirm changes

Your operational job records change only when you complete the confirmation that applies the plan. The first confirmation alone doesn't update them. If you wait too long before confirming again, you're asked to confirm again. An unapplied plan expires 10 minutes after it's created.

If an affected record changed since review, nothing is applied and you must review again. If a booking status could complete the work order when your plan excludes completion, review and correct the plan before confirming again.

Once application starts, some changes can succeed while others fail. Changes that depend on a failed change are skipped, but unrelated changes can still succeed. Saved changes aren't automatically undone, and there's no blanket rollback.

## Tips and limitations

- Check the result of every change before continuing to the next job.
- If a save can't be confirmed, inspect the affected records before trying again. Repeating an uncertain update can create duplicates, such as a second note.
- To stop before applying, say so or select **Cancel** in the review card. Stopping doesn't necessarily delete the stored plan.

## Related information

- [Capture work progress](capture_work_progress.md)
- [View a work order](get_work_order.md)
- [Update a work order service task](update_work_order_service_task.md)
- [Update a work order product](update_work_order_product.md)
