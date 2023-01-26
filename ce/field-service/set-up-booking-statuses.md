---
title: "Set up booking statuses (Dynamics 365 Field Service) | MicrosoftDocs"
description: Learn how to set up booking statuses in Dynamics 365 Field Service.
ms.date: 08/11/2022
ms.reviewer: mhart

ms.topic: article
author: ryanchen8
ms.author: chenryan
search.app: 
  - D365CE
  - D365FS
---
# Set up booking statuses in Dynamics 365 Field Service

Booking statuses allow you to create multiple substatuses mapped to each of your booking statuses in order to more precisely define your company's unique business processes.  
  
1. From the main menu, go to **Resources** > **Booking Settings**, and then choose **Booking Statuses**.  
  
2. Select **+New** on the **Active Booking Statuses** screen.  
  
3. Fill in your information.  
  
   - Choose a custom **Status Color** value in the **Common** tab to specify which color the resource schedule time slot will be displayed on the schedule board.  
  
   - Map the new status to a parent status in the **Field Service** tab by choosing a value in the **Field Service Status** field.  
  
> [!TIP]
> You can also set a default status for scheduled and canceled bookings. Go to **Resources** > **Administration** > **Booking Setup Metadata Wizard**. Select **msdyn_workorder** and configure the default settings. For more information: [Configure default settings](../field-service/configure-default-settings.md)  
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]
