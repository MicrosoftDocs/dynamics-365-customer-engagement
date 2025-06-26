---
title: Set up booking statuses
description: Learn how to set up booking statuses in Dynamics 365 Field Service.
ms.date: 06/20/2025
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

# Set up booking statuses

Booking statuses allow you to create multiple substatuses mapped to each of your booking statuses in order to more precisely define your company's unique business processes. On the schedule board, booking statuses show in alphabetical order and grouped by their parent status. To change the order, update the name accordingly.

1. In the Field Service application, change to the **Resources** area.

1. Under **Booking Settings**, select **Booking Statuses**.  
  
   :::image type="content" source="media/booking-status.png" alt-text="Screenshot of the list of booking statuses.":::
  
1. Select **New** on the **Active Booking Statuses** view.  
  
1. Enter a name.  
  
1. Select the **Common** tab and choose a custom **Status Color** value to display on the schedule board.  
  
1. Select the **Field Service** tab and map the new status to a parent status in the **Field Service Status** field.  

1. Select **Save & Close**.
  
> [!TIP]
> To set a default status for scheduled and canceled bookings, go to **Resources** > **Administration** > **Booking Setup Metadata Wizard**. Select **msdyn_workorder** and configure the default settings. Learn more in [Configure default settings](../field-service/configure-default-settings.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
