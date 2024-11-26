---
title: Configure travel charges
description: Learn how to use travel charges in Dynamics 365 Field Service to bill for the cost of travel to a work site.
ms.date: 06/12/2024
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---

# Configure travel charges

Use travel charges to bill customers for the cost of travel to a work site.

Dynamics 365 Field Service adds a travel charge item as a work order product if a travel charge type is set for a [service account](accounts.md), *not* a billing account. The travel charge is added after the work order is scheduled and when the status of the generated booking changes.

The *unit amount* of the *Travel Charge Item* work order product is the value of the **travel charge** that is set for the service account. The price list, list price, and travel charge determine the *unit amount price* of the travel charge item. However, the *quantity* of the *Travel Charge Item* work order product is based on the **travel charge type** that is set for the service account.

If there are multiple bookings for a single work order, multiple travel charge items are added as work order products.

## Specify the travel charge item

1. In Field Service, select the **Settings** area.
1. Under **General**, select **Field Service Settings**.
1. On the **Work Order / Booking** tab, in the **Travel Charge Item** field, search for and select a product.

    If the product doesn't exist yet, select **New Product** to create it, and add the product as a travel charge item.

    :::image type="content" source="media/field-service-settings-travel-charge.svg" alt-text="Screenshot of the Field Service Settings page with a travel charge item highlighted.":::

1. Select **Save**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
