---
title: Configure travel charges
description: Learn how to use travel charges in Dynamics 365 Field Service to bill for the cost of travel to a work site.
ms.date: 08/10/2026
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom:
 - ai-gen-docs-bap
 - ai-seo-date: 08/07/2026
ai-usage: ai-assisted
---

# Configure travel charges

Use travel charges to bill customers for the cost of travel to a work site. The system adds travel charges to a work order as a work order product. The system calculates the travel charge based on the travel charge type and travel charge set for the service account.

When a qualifying booking is complete, Field Service adds the product selected as the **Travel Charge Item** to the work order. The **Travel Charge** on the work order’s service account becomes the work order product’s per-unit price. The **Travel Charge Type** determines its quantity.

Field Service creates a separate travel charge item for each qualifying booking. Normal work order product pricing, discounts, and taxes apply afterward.

If there are multiple bookings for a single work order, the system adds multiple travel charge items as work order products.

## Specify the travel charge item

1. In Field Service, go to the **Settings** area and select the **Work Order / Booking** tab.

1. In the **Travel Charge Item** field, search for and select a product.

    If the product doesn't exist yet, select **New Product** to create it, and add the product as a travel charge item.

    :::image type="content" source="media/field-service-settings-travel-charge.png" alt-text="Screenshot of the Field Service Settings page with a travel charge item highlighted.":::

1. Select **Save**.

## Specify the travel charge type and travel charge

Set travel charges on the service account *not* a billing account. To specify the travel charge type and travel charge:

1. In Field Service, go to **Accounts** and select a service account.

1. Select the **Servicing** tab.

1. In the **Travel Charge Type** field, select one of the following options:

    - **Hourly**: The system calculates the travel charge based on the actual travel duration in minutes ÷ 60.
    - **Mileage**: The system calculates the travel charge based on miles traveled x price per mile.
    - **Fixed**: The system uses a fixed amount for the travel charge.

1. In the **Travel Charge** field, enter the amount to charge for travel.

    :::image type="content" source="media/account-travel-charges.png" alt-text="Screenshot of a service account's Servicing tab with travel charges highlighted.":::

1. Select **Save & Close**.

## Example

| Travel Charge Type | Travel Charge | Quantity  | Result |
|--------------------|---------------|-----------|--------|
| Hourly             | $60/hour      | 90 minutes| $90    |
| Mileage            | $0.50/mile    | 10 miles  | $5     |
| Fixed              | $100          | 1 time    | $100   |
| None               | $0            | 0         | $0     |


[!INCLUDE[footer-include](../includes/footer-banner.md)]