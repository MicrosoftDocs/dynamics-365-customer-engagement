---
title: Set up resource pay types
description: Learn how to set up resource pay types track costs associated with resource bookings in Dynamics 365 Field Service
ms.date: 07/28/2022

ms.topic: article
ms.author: jacoh
author: jasonccohen
---
# Set up resource pay types

Resource pay types can be used to track your company's costs associated with a resource booking. When the status of a resource booking record is set to "complete," the system generates booking journal records, according to the time that a field agent spent performing the work.  
  
 The system can create one booking journal record for each of the following journal types: travel, working hours, break, overtime, and business closure, depending on the various resource booking statuses that the user applied to the resource booking while completing the work.  
  
 To set up this functionality, create one resource pay type record for each journal type, and then assign the resource pay types that you created in the **Pay Types** section of the **Resources** page.  
  
## Create a new resource pay type  
  
1. From the main menu, go to **Resources** > **Resource**, and then choose **Pay Types**.  
  
1. On the **Active Resource Pay Types** screen, select **+New** in the upper left corner.  
  
1. **Name** the pay type.  
  
1. Assign an **Hourly Markup** percentage.  
  
     The **Hourly Markup** field  will be applied to the hourly rate amount specified on the resource record when determining the costs associated with the resource booking. For example, if you create a pay type called "Overtime" and assign it an hourly markup percentage of 150%, and then associate it with the **Overtype Pay Type** in **Field Service** settings, when the system creates a booking journal for overtime, it will set the cost at 150% of the hourly rate of the resource who performed the work  
  
## Assign pay type scenarios  
  
1. From the main menu, go to **Resources** > **Resource**, and then choose **Pay Types**.  
  
1. In the **Resource Pay Type** screen, assign the resource pay types that you created to the various journal types, and then select the **Save** button in the lower left corner.  
  
     Booking journals will be created to calculate the cost of a resource booking, for each of the journal types, according to the following logic:  
  
    - **Work**: Time the resource booking status is in progress while the resource is within their scheduled work hours.  
  
    - **Overtime**: Time recorded outside a resource's normal working hours.  
  
    - **Travel**: Time the resource booking status is "traveling."  
  
    - **Break**: Time the resource booking status is "on break."  
  
    - **Business Closure:** Time recorded by a resource when the company is closed.  
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]
