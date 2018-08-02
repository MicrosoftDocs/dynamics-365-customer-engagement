---
title: "Set up resource pay types (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom:
  - dyn365-fieldservice
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
ms.assetid: 239b3f54-69dc-44c1-95be-154fc90df2e4
caps.latest.revision: 14
ms.author: krbjoran
manager: shellyha
---
# Set up resource pay types to track costs associated with resource bookings (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Resource pay types can be used to track your company's costs associated with a resource booking. When the status of a resource booking record is set to "complete," the system generates booking journal records, according to the time that a field agent spent performing the work.  
  
 The system can create one booking journal record for each of the following journal types: travel, working hours, break, overtime, and business closure, depending on the various resource booking statuses that the user applied to the resource booking while completing the work.  
  
 To set up this functionality, create one resource pay type record for each journal type, and then assign the resource pay types that you created in the **Resource Pay Types** section of the **Field Service Settings** page.  
  
<a name="BKMK_CreateNewResourcePayType"></a>   
## Create a new resource pay type  
  
1.  From the main menu, click **Field Service** > **Administration**, and then choose **Resource Pay Types**.  
  
2.  On the **Active Resource Pay Types** screen, click **+New** in the upper left corner.  
  
3. **Name** the pay type.  
  
4.  Assign an **Hourly Markup** percentage.  
  
     The **Hourly Markup** field  will be applied to the hourly rate amount specified on the resource record when determining the costs associated with the resource booking. For example, if you create a pay type called "Overtime" and assign it an hourly markup percentage of 150%, and then associate it with the **Overtype Pay Type** in **Field Service** settings, when the system creates a booking journal for overtime, it will set the cost at 150% of the hourly rate of the resource who performed the work  
  
<a name="BKMK_AssignPayTypeScenarios"></a>   
## Assign pay type scenarios  
  
1.  From the main menu, click **Field Service** > **Administration**, and then choose **Field Service Settings**.  
  
2.  In the **Resource Pay Type** section, assign the resource pay types that you created to the various journal types, and then click the **Save** button in the lower left corner.  
  
     Booking journals will be created to calculate the cost of a resource booking, for each of the journal types, according to the following logic:  
  
    - **Work**: Time the resource booking status is in progress while the resource is within their scheduled work hours.  
  
    - **Overtime**: Any time recorded outside a resource's normal working hours.  
  
    - **Travel**: Time the resource booking status is "traveling."  
  
    - **Break**: Time the resource booking status is "on break."  
  
    - **Business Closure:** Any time recorded by a resource when the company is closed.  
  
### See also    
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Set when your business is closed)](../customer-service/set-when-business-closed.md)   
 [Set up bookable resources](../field-service/set-up-bookable-resources.md)   
 [Set up bookable resource categories](../field-service/set-up-bookable-resource-categories.md)   
 [Set up characteristics](../field-service/set-up-characteristics.md)
 [User's Guide](../field-service/user-guide.md)
