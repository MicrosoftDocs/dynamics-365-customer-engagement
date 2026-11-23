---
title: List work order products and services (preview)
description: View the product and service lines on a Dynamics 365 Field Service work order in grids, and record product quantities or mark parts used.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=field-service
ms.service: dynamics-365-field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# List work order products and services (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Review the parts, materials, and labor on a work order. Check what's estimated or used, then record product usage or quantity changes from the list when needed.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Dynamics 365 Field Service must be installed.
- Your security role must allow you to read the work order and its products and services. Editing product lines also requires permission to update them.
- Public views for work order products and services must be available. The default views are included with Field Service.

## Try prompts like

- List the products and services on this work order.
- What parts are on this job?
- Show only the product lines on this work order.
- What services were performed on this job?
- Which parts are still estimated?

## What you can do

1. Identify the work order, then ask for both sections or only products or services.
2. Review the service section first and the product section below it. Lines appear in work order sequence, with quantities or durations, units, and whether they're estimated or used.
3. Sort or filter each section to find the lines you need.
4. Mark an estimated product line as used when you've used that part. Expand a product line to edit its quantity or quantity to bill.
5. Refresh the list to check current values, or use full screen for more room.

The summary reports line counts and how many lines are marked used. An empty section says no lines were found. Your organization's views determine the available columns.

## Data changes

Listing, sorting, filtering, and refreshing don't change records. Marking a product used or saving a quantity edit updates that product line.

Editing a quantity in the grid doesn't automatically mark the part used. Review both its quantity and status when recording usage. The service section is read-only, and line status isn't directly editable as a field.

If a save can't be confirmed, refresh and check the line before trying again.

## Tips and limitations

- The list normally shows up to 50 lines per section. You can ask for more, up to 200 per section.
- A warning means more lines might exist than are shown. Don't treat a limited list as the complete work order.
- Ask an administrator to adjust the product or service view if different columns are needed.
- To add a part that isn't listed, ask to add a product line. To review checklist steps rather than billable lines, ask for service tasks.

## Related information

- [Update a work order product](update_work_order_product.md)
- [Add a product line to a work order](create_work_order_product.md)
- [List work order service tasks](list_work_order_service_tasks.md)
- [View a work order](get_work_order.md)
