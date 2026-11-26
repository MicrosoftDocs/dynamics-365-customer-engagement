---
title: Set up booking statuses
description: Learn how to set up booking statuses in Dynamics 365 Field Service.
ms.date: 06/19/2026
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

# Set up booking statuses

Use booking statuses to represent each stage of your business process in Dynamics 365 Field Service. Booking statuses appear in alphabetical order and are grouped by parent status on the schedule board. To change the display order, rename the status.

1. In Field Service, change to the **Resources** area.

1. Under **Booking Settings**, select **Booking Statuses**.  
  
   :::image type="content" source="media/booking-status.png" alt-text="Screenshot of the list of booking statuses.":::
  
1. Select **New** on the **Active Booking Statuses** view.  
  
1. Enter a name.  
  
1. Select the **Common** tab and choose a custom **Status Color** value to display on the schedule board.  
  
1. Select the **Field Service** tab and map the new status to a parent status in the **Field Service Status** field.  

1. Select **Save & Close**.
  
## Set default statuses for scheduled and canceled bookings

To set default statuses for scheduled and canceled bookings, follow these steps to complete the configuration.

1. Go to **Resources** > **Administration** > **Booking Setup Metadata Wizard**.

1. Select **msdyn_workorder** and configure the default settings.

1. Select **Save & Close**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
