---
title: "Set up bookable resources (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/20/2019
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
author: krbjoran
ms.assetid: 7ed1712e-acd6-433b-bb78-22f8d58c5c61
caps.latest.revision: 14
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# Set up bookable resources (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

A bookable resource in Field Service is anything that needs to be scheduled. This most commonly includes people, equipment, and physical spaces (facilities).   

Each resource can have different attributes that distinguish it from each other including but not limited to:

- Characteristics (ex: Accounting)
- Categories (ex: Manager)
- Territories (ex: Seattle)
- Organizational Unit (ex: Manager)
- Location (ex: Location Agnostic)
- Resource Type (ex: User)

In this article let's explore creating a bookable resource and adding details to distinguish it from other resources. In addition, let's explore the most common details for setting up field technician resources for Field Service organizations.

## Create a bookable resource  
  
1.  From the Field Service main menu, click **Resources** > **Resources entity**. 

2.  On the **Active Bookable Resources** screen, click **New**.  


> [!div class="mx-imgBorder"]
> ![Screenshot navigating to Resources](media/resource-create-new-navigation.png)

> [!div class="mx-imgBorder"]
> ![Screenshot showing where to find the Active Bookable Resources grid](media/qs-1-img28.png)

    
3.  Select a **Resource Type**  
  
  Resource type is a classification of who or what the resource is and how the resource relates to your organization. 

   - **User**: Choose this option if the resource is a person and a member of your organization. This resource type must be chosen if the resource is a field technician who needs access to the Field Service Mobile app.
   - **Account** or **Contact**: Choose this option if the resource is not directly a part of your organization, but needs to be scheduled. A common example is subcontractors. In addition, this allows the scheduling framework to more easily apply to an organization's existing Dynamics system that may be using Accounts and Contacts to manage workers, partners, contractors before Field Service is purchased and implemented. 
  - **Equipment**: Choose this option if the resource is an equipment, tool, or machine that must be scheduled.
  - **Crew**: Choose this option as the first step to create a crew to assemble a group of resources where scheduling the crew resource will schedule all crew members. A typical example is two or more people or a person and a vehicle. The general process is to create a crew header resource with the resource type of crew and then add other resources of resource type user, account, or equipment as resource children to the crew header. For more information see the topic on [resource crews](resource-crews.md).
  - **Facility**: Choose this option if the resource is a physical space that needs to be scheduled such as a building or room. For more information see the topic on [facility scheduling](facility-scheduling.md).
  - **Pool**: Choose this option as the first step to create a pool to assemble a group of similar resources to manage capacity. Among other differences, a pool differs from a crew in that scheduling a pool does not schedule all pool members. For more information see the topic on [resource pools](resource-pools.md).   
  
     
  
  After selecting a resource type, a lookup field will appear to choose a related record when applicable. As an example, if User is selected, you will then need to select the related User record.


4.  **Name** Enter a name, this can be different from the name of the related user, account, or contact record. The name entered here will appear on the schedule board.
5.  **Time Zone** Select the time zone the resource is located in. This is considered in the schedule process.  
6.  **Enabled for Field Service Mobile** Set to **Yes** if the resource will need to use the Field Service Mobile app on his or her phone or tablet.
7. Choose the **Start Location** and the **End Location** to specify which location the resource will be at when starting and ending work.  
  
8.  Choose if the resource should be displayed on the schedule board and schedule assistant.  
  
9.  Set **Enable Drip Scheduling** to **Yes** or **No**.  This controls how many schedules will appear on the mobile app. If drip scheduling is disabled, all schedules will appear, based on your mobile settings.  
10. Type an **Hour Rate**.  This is the hourly pay that the resource should be paid by the company. 
  
11. Choose if time off needs to be approved or not.  
  
12. Select **Save**.  
  
13. In the **Characteristics** section, select **+Add Bookable Resource Characteristics record** to add characteristics. Learn more about this on the [setting up characteristics page](../field-service/set-up-characteristics.md).

For example, the resource in the following screenshot is a field techncian at your organization because the **Resource Type** is set to **User** and **Enabled for Field Service Mobile** is set to **Yes**.

> [!div class="mx-imgBorder"]
> ![Screenshot showing where to find the fields on the Bookable Resource form](media/qs-1-img29.png)

  
## Setting up field technician resources for field service organizations  
## Add work hours  
  
1.  Once the resource has been created:
    - In the classic interface, select the arrow next to the resource name, and choose **Work Hours**.
    - In the unified client interface, select **Show Working Hours** at the top of the form. 
  
2.  Click the **Set-Up** drop-down list and choose one of the following:  
  
    - **New Weekly Schedule**: Set an ongoing weekly schedule for the resource.  
  
    - **Work Schedule for One Day**: Set the hours the resource can be scheduled for on a particular day.  
  
    - **Time Off**: Set the dates and times the resources can't work.  
  
  
## Add characteristics  
  
1. From the resource name submenu,  click **Bookable Resource Characteristics**.  
  
2. Click **Add New Bookable Resource Characteristics**.  
  
3. Use the tooltips to help fill in information, and then click **Save**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up characteristics](../field-service/set-up-characteristics.md)  
  

## Add categories  

## Add resource territories  
  
1. From the resource name submenu, click **Resource Territories**.  
  
2. Click **Add New Resource Territory**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up territories](../field-service/set-up-territories.md)  
  
3. Use the tooltips to help fill in your information, and then click **Save & Close**.  


## Additional notes

- Only one resource record can be associated to a user record, however multiple resources can be associated to a single account or contact record. 


### See also   
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Set up bookable resource categories](../field-service/set-up-bookable-resource-categories.md)   
 [Set up characteristics](../field-service/set-up-characteristics.md)   
 [Set up resource pay types](../field-service/set-up-resource-pay-types.md)<br>
 [User's Guide](../field-service/user-guide.md) 
