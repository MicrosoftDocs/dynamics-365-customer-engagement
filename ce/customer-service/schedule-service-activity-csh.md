---
title: Schedule a service activity in Service Scheduling (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to schedule a service activity in service scheduling in Dynamics 365 for Customer Service
keywords: Schedule a service activity; Dynamics 365; Customer Service; service scheduling
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 9b1ae6b1-8f46-47cc-b339-4e13a6ce9a8a
ms.custom: dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Schedule a service activity

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Use service activity to schedule service appointments by searching for an available time for a service activity. You can either search for an open time using search criteria that, at a minimum, include selecting a service, or you can define a more complex set of criteria. You can also create a service activity without checking for conflicts in the scheduled service. The service activity appears as a color block on the service calendar  
  
> [!NOTE]
> You can’t create a recurring service activity. Create individual service activities as needed.

## Create a service activity

Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.

1. In the Customer Service Hub sitemap, go to **Service Scheduling**.
2. From the list of entity records, select **Scheduling > Service Activity**.
   - The **My Service Activities** view is displayed. You can switch between various system views using the drop-down menu.
   - Select **Show Chart** in the command bar to see the chart view.
   - Select any existing service activity to see additional options in the command bar.
3. On the command bar, select **Service Activity** to create a new service activity.  

4. In the **Service Activity** section:
    - Enter the **Subject** of the service activity.
    - Select the type of service from the **Service** drop-down menu.
    - Select **Customers** to specify the customer who requested the activity.
    - Specify **Location** of the activity.
    - Select **Show Time As** either Requested or Tentative.
    - Provide the **Organizational Business Unit**.

5. Select **Save**.

6. In the **Details** section:

   - Look for records in the **Regarding** box to align a record. For example, this service activity can be regarding a case, knowledge article or more.
   - Provide **Category** and **Sub-category** for the activity.

7. In the **Bookable Resource Bookings** section:

   - Create a new bookable resource booking or add an exiting one.

     [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and set up bookable resources](resources-service-scheduling.md)

8. Select **Book** to schedule a service activity in the calendar.

    - The **Schedule Board** is displayed.
    - You can view the list of services and the associated resources.
    - In the **Create Resource Booking** panel, select the service start date and time and end date and time.
    - Select the **Booking Status** from the drop-down menu.
    - Select **Book** to schedule a service activity. Select **Book and Exit** to schedule and exit the Schedule Board.

      [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the schedule board to configure service activity](use-schedule-board-configure-service-activity.md)

Additionally,

- If the service activity has been completed by the resource, select **Mark Complete** from the command bar. 
- Select **Close Service Activity** to close a service activity.

  ![create service activity](media/create-service-activity.png)

### See also

[Use the schedule board to configure service activity](use-schedule-board-configure-service-activity.md)





