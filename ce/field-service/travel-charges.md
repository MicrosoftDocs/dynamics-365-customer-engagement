---
title: "Travel charges in Dynamics 365 Field Service"
description: Learn how to create apply travel charges in Dynamics 365 Field Service
ms.date: 12/07/2022
ms.reviewer: mhart
ms.topic: article
author: jshotts
ms.author: jasonshotts
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Travel charges in Dynamics 365 Field Service

Use travel charges to bill the cost of travel for the field technician to a customer.

The system adds a travel charge item as a work order product if a [service account (*not* billing account) has a travel charge type set](accounts.md). It's added after scheduling the work order and when the status of the generated booking changes.

## Specify the travel charge item

1. In **Field Service**, open the **Settings** area.
1. Go to **Field Service Settings**.
1. On the **Work Order / Booking** tab, choose or create a product in the **Travel Charge Item** field. This is the product that will be added as a work order product.

   :::image type="content" source="media/field-service-settings-travel-charge.png" alt-text="Screenshot of travel charge item in field service settings.":::

> [!NOTE]
> The unit amount of the work order product is the **Travel Charge** value provided on the entered in the [service account record](accounts.md). While the *unit amount price* of the travel charge is dictated by the price list, list price, and travel charge, the *quantity* for the travel charge work order product is based on the **Travel Charge Type** set for the service account.
> In cases of multiple bookings for a single work order, multiple travel charges will be added as work order products.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
