---
title: Set up resource pay types
description: Learn how to set up resource pay types to track costs associated with resource bookings in Dynamics 365 Field Service.
ms.date: 06/12/2024
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
ms.custom: bap-template
---

# Set up resource pay types

You can use resource pay types to track your company's costs that are associated with a resource booking. When the status of a resource booking record is set to *Completed*, the system generates booking journal records based on the time that a field agent spent performing the work.

Depending on the resource booking statuses that the user applied to the resource booking while they completed the work, the system can create one booking journal record for each of the following journal types: *Travel*, *Working Hours*, *Break*, *Overtime*, and *Business Closure*.

To set up this functionality, create one resource pay type record for each journal type. Then assign the resource pay types that you created in the **Pay Types** section of the **Resources** page.

## Create a new resource pay type

1. In Dynamics 365 Field Service, select the **Resources** area.
1. Under **Resource**, select **Pay Types**.
1. On the **Active Resource Pay Types** page, select **New**.
1. For each journal type, create a pay type, and enter the following information for it: 

    - **Name**: Enter a name for the pay type.
    - **Hourly Markup**: Enter, as a percentage, the markup for the hourly rate amount that is specified on the resource record. This markup is applied when the costs that are associated with the resource booking are determined.

        For example, you create a pay type that is named *Overtime*. You assign an hourly markup of 150 percent to it and then associate it with **Overtime Pay Type** in **Field Service Settings**. In this case, when the system creates a booking journal for overtime, it sets the cost at 150 percent of the hourly rate of the resource who performed the work.

1. Select **Save**.

## Assign pay type scenarios

From the **Resource Pay Type** page, assign the resource pay types that you created to the different journal types. For each journal type, booking journals are created to calculate the cost of a resource booking, according to the following logic:

- **Work**: Time that the resource booking status is *In Progress* while the resource is within their scheduled work hours.
- **Overtime**: Time that is recorded outside the resource's normal working hours.
- **Travel**: Time that the resource booking status is *Traveling*.
- **Break**: Time that the resource booking status is *On Break*.
- **Business Closure**: Time that the resource records while the company is closed.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
