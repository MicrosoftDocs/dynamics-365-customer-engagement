---
title: Add a product line to a work order (preview)
description: Record a part on a Dynamics 365 Field Service work order as a used or estimated product line, with quantity, warehouse, and asset, directly in chat.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=field-service
ms.service: dynamics-365-field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Add a product line to a work order (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Add a part you used or plan to use to an existing work order. Record the quantity, billing quantity, and related warehouse or asset without opening the work order form.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Dynamics 365 Field Service must be installed.
- Your role must support creating work order products and updating related work orders and product inventory, with access to products, price lists, warehouses, bookable resources, Field Service settings, and currencies. Ask your administrator to check the required permissions if this action isn't offered.
- Linking a customer asset also requires access to that asset. Field-level security and Field Service business rules still apply.

## Try prompts like

- I used a compressor on this work order.
- Add 2 filters to this work order.
- Log part P-1001 as used, quantity 3.
- Add an estimated line for the replacement pump.
- Add 4 gaskets but only bill 2.

## What you can do

1. Identify the work order and name the product or its product number. Only active inventory and non-inventory products can be added.
2. Say whether the part was used or is only planned. Unless you say "planned" or "estimated," the new line is marked **Used**.
3. Give the quantity and, if different, the quantity to bill. Quantity defaults to 1; an explicit zero is kept.
4. Name a unit, warehouse, or customer asset if needed. The unit otherwise comes from the product. If several readable warehouses are available, choose one when asked; a single available warehouse is used automatically.
5. Review the text confirmation of the product, work order, status, and quantities.

For a used line, the quantity is actual usage and the quantity to bill defaults to the same amount. For an estimated line, the quantity is planned usage, and a quantity to bill is set only when you provide one.

## Data changes

This action creates one product line; it doesn't update an existing line.

If the product already has an estimated line, review it first. Choose to leave it, update it to record use, or explicitly create a separate line. Nothing is added until you choose.

If creation can't be confirmed, check the work order's current product lines before retrying. Don't automatically add a separate line.

## Tips and limitations

- An unrecognized or ambiguous product needs clarification; another product isn't substituted.
- No warehouse is set when none is available to you.
- Duplicate checks cover only lines you can read at that moment. Concurrent requests or other additions can still create duplicate estimated lines.
- To correct an existing line, ask to update it rather than add the part again.

## Related information

- [List work order products and services](list_work_order_lines.md)
- [Update a work order product](update_work_order_product.md)
- [View a work order](get_work_order.md)
