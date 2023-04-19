---
title: Configure travel charges
description: Learn how to use travel charges in Dynamics 365 Field Service to bill for the cost of traveling to a worksite.
ms.date: 01/23/2023
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---

# Configure travel charges

Use travel charges to bill customers for the cost of traveling to the worksite.

Field Service adds a travel charge item as a work order product if a [service account](accounts.md), *not* a billing account, has a travel charge type set. It's added after the work order is scheduled and when the status of the generated booking changes.

The *unit amount* of the **Travel Charge Item** work order product is the value of the **Travel Charge** that's set for the service account. The *unit amount price* of the travel charge item is dictated by the price list, list price, and travel charge. However, the *quantity* of the **Travel Charge Item** work order product is based on the **Travel Charge Type** set for the service account.<!-- EDITOR'S NOTE: This is hard to follow. Can you provide an example and a screenshot? -->

In cases of multiple bookings for a single work order, multiple travel charge items will be added as work order products.

## Specify the travel charge item

1. In Field Service, select the **Settings** area. Under **General**, select **Field Service Settings**.

1. In the **Work Order / Booking** tab, search for and select a product in **Travel Charge Item**.
  
   If the product doesn't exist yet, select **New Product** to create it and add the product as a travel charge item.

   :::image type="content" source="media/field-service-settings-travel-charge.png" alt-text="Screenshot of the Field Service settings page, with a travel charge item highlighted.":::

1. Select **Save**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
