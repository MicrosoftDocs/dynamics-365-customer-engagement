---
title: "Set up booking rules (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: dyn365-fieldservice 
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: 87e2cafc-ead7-43b2-b62a-db3a2fc05380
caps.latest.revision: 13
ms.author: krbjoran
manager: shellyha
---
# Set up booking rules (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Booking rules in [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] allow a System Administrator to create warning or error messages that users see when creating or editing a resource booking record, based on custom conditions. For example, a booking rule could be created to warn a user when they attempt to book a work order to a resource on the schedule board that doesn't have the skills required for the job.  
  
 Set up booking rules to validate a booking when it is created or modified.  
  
1.  From the main menu, click **Field Service** > **Administration**, and then choose **Booking Rules**.  
  
2.  On the **Active Booking Rules** screen, click **+New** in the upper left corner.  
  
3.  Type a **Name** for the new booking rule.  
  
4.  Select a **Web Resource** that has been previously created by the System Administrator to contain the validation logic and warning text.  
  
5.  Enter the **Method Name**.  
  
6.  Click **Save**.  
  
### See also   
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Set up postal codes](../field-service/set-up-postal-codes.md)   
 [Set up territories](../field-service/set-up-territories.md)   
 [Set up booking statuses](../field-service/set-up-booking-statuses.md)   
 [Create and edit web resources](../customize/create-edit-web-resources.md)<br>
 [User's Guide](../field-service/user-guide.md)
