---
title: Update a work order product (preview)
description: Mark a Field Service work order product line used, record quantity used and quantity to bill, or edit other product line fields in chat.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=field-service
ms.service: dynamics-365-field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Update a work order product (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Record parts used and quantities to bill on an existing work order product line, or change line details such as its warehouse or unit price.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Dynamics 365 Field Service must be installed.
- Your security role must allow you to read and update work order products.
- You can change only fields you're allowed to read and update. Field-level security and Field Service business rules still apply.

## Try prompts like

- Mark the filter on this work order as used.
- I used 3 gaskets, not 2.
- I used 2 filters but only bill the customer for 1.
- Set the unit price on the compressor line to 432.
- Change the warehouse on this part to Van Stock.

## What you can do

1. Identify the work order and existing product line. Name the part as it appears on the work order, and choose the correct line if several match.
2. To record usage, ask to mark the part used and give the quantity. If you omit the quantity when marking it used, the estimated quantity becomes the quantity used.
3. State the billing quantity explicitly when it should differ, for example for warranty or goodwill work. You can also ask to keep the current billing quantity while changing usage.
4. To change other details, use the field labels shown in Dynamics 365. Field edits don't automatically mark an estimated part used or change quantities.
5. Review the text summary of previous and new values. Field Service calculates the line totals.

## Data changes

This action updates one existing product line. It doesn't add or delete lines or change services, tasks, or the work order header.

Usage and quantity updates normally mark the part **Used**. Say explicitly if you want to adjust quantities without marking an estimated part used. Quantity to bill follows changed usage when it was empty or matched the previous usage; an already different billing quantity is kept unless you request another value.

If the line changed since it was read, review its current values before trying again. If a save can't be confirmed, inspect the product line before repeating the update.

## Tips and limitations

- Request usage and billing changes separately from other field edits.
- Keeping an existing billing quantity requires that it already has a value. Otherwise, state the quantity to bill.
- For date and time changes, include the time zone.
- Inventory location, batch, serial number, and company values aren't saved by this update.
- If the part isn't on the work order, add it as a new product line instead.

## Related information

- [List work order products and services](list_work_order_lines.md)
- [Add a product line to a work order](create_work_order_product.md)
- [Capture work progress](capture_work_progress.md)
- [View a work order](get_work_order.md)
