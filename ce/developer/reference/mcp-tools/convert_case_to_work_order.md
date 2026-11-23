---
title: Convert a case to a work order (preview)
description: Create an Unscheduled Dynamics 365 Field Service work order from a Customer Service case after you review and confirm its values.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.service: dynamics-365-field-service
ms.custom: mcp-enabled-namespaces=field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Convert a case to a work order (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Create a Field Service work order from a Customer Service case after you review its proposed values. Use this step when the case needs an onsite service job.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Dynamics 365 Field Service must be installed, and the source must be a Customer Service case.
- Your security role must allow you to create work orders and read the case and related customer, incident type, work order type, price list, asset, and functional location information.
- Prepare and review the case-conversion form first. Choose an incident type with a default work order type, and supply a service account when that work order type requires one.

## Try prompts like

- Yes, create it.
- Create the work order with these values.
- Go ahead and create the work order for case CAS-01234.
- Yes, create another work order for this case.

Use these confirmations after reviewing the form. To start, ask to convert a case and review the proposed work order before approving it.

## What you can do

1. Check the source case and proposed incident type, work order type, service account, price list, asset, and functional location.
2. Change the incident type, service account, or functional location if needed. The work order type follows the selected incident type's default.
3. Expand **Populated fields** to check each value and its source. The summary draws on the case title, description, and recent notes. The service account is also used as the billing account.
4. Select **Create work order** or confirm in chat after review.
5. Check the new work order number and details. Select **Open work order** to view it in Dynamics 365 or **Open case** to return to the source case.

## Save and confirm changes

Confirmation creates a work order linked to the case with an **Unscheduled** status. It doesn't schedule a visit or assign a resource.

If the case already has a related work order, or the same work order name exists for the service account, review the duplicate warning before approving another. For an existing related work order, choose **Create another work order** to proceed or **Cancel** to stop.

If creation can't be confirmed, don't start another conversion. Keep the operation reference shown in the form and check Field Service for a work order linked to the case before trying again.

## Tips and limitations

- Missing or ambiguous required information must be resolved before creation.
- An incident type is always required. Service account requirements depend on the work order type.
- If no price list is configured, the form explains that the work order is created without one.
- After creation, find available booking slots as a separate task.

## Related information

- [Prepare a work order from a case](get_case_work_order_form.md)
- [View a work order](get_work_order.md)
- [Update a work order](update_work_order.md)
- [Find available booking slots](search_resource_availability.md)
