---
title: Set up resource pay types
description: Learn how to set up resource pay types to track costs associated with resource bookings in Dynamics 365 Field Service.
ms.date: 07/24/2025
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
ms.custom: bap-template
---

# Set up resource pay types

You can use resource pay types to track your company's costs that are associated with a resource booking. When the status of a resource booking record is set to *Completed*, the system generates booking journal records based on the time that a field agent spent performing the work.

Based on the resource booking statuses applied during the work, the system can create one booking journal record for each of the following journal types. Each journal type helps calculate the cost of a resource booking using the following logic:

- **Work**: Time logged while the resource booking status is *In Progress* and the resource is working within their scheduled hours.
- **Overtime**: Time recorded outside the resource's normal working hours.
- **Business Closure**: Time logged when the company is officially closed.
- **Break**: Time recorded while the resource booking status is *On Break*.
- **Travel**: Time recorded while the resource booking status is *Traveling*.

## Create a new resource pay type

Create one resource pay type for each journal type.

1. In Dynamics 365 Field Service, select the **Resources** area.
1. Under **Resource**, select **Pay Types**, and then **New**.
1. For each journal type, create a pay type with the following information:

    - **Name**: Enter a name for the pay type.
    - **Hourly Markup**: Enter, as a percentage, the markup for the hourly rate amount that is specified on the resource record. This markup is applied when the costs that are associated with the resource booking are determined.

        For example, you create a pay type that is named *Overtime*. You assign an hourly markup of 150 percent to it and then associate it with **Overtime Pay Type** in **Field Service Settings**. In this case, when the system creates a booking journal for overtime, it sets the cost at 150 percent of the hourly rate of the resource who performed the work.

1. Select **Save**.

## Assign pay type scenarios

1. In Field Service, go to the **Settings** area and select the **Work Order / Booking** tab.

1. In the **Resource Pay Type** section, assign the resource pay types that you created to the different journal types.

1. Select **Save**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]