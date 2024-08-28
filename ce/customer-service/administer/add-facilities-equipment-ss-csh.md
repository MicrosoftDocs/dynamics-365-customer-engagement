---
title: Add and create new facilities and equipment for Service Scheduling in Dynamics 365 Customer Service
description: Learn how to add and create facilities and equipment for service scheduling in Dynamics 365 Customer Service.
ms.date: 08/20/2024
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
  - evergreen
---

# Add facilities and equipment to schedule service

## Introduction

Facilities and equipment are resources you use to perform services for your customers. Facilities could be physical spaces like service bays or conference rooms and equipment could be tools or other assets. To ensure optimal services for your customers, add these resources to Dynamics 365 Customer Service.  

## Create a new facility or equipment record

Make sure that you have the required security role or equivalent permissions. 

Learn more in [Manage security roles in service scheduling](manage-security-roles.md).

You can create a new facility or equipment record in the Customer Service admin center app.

1. In the site map of Customer Service admin center, select **Service Scheduling** in **Operations**. The **Service Scheduling** page appears.
1. In the **Facilities & equipment** section, select **Manage**. The **Local Facilities/Equipment** view is displayed. You can switch between various system views using the dropdown list.


     
1. On the command bar, select **New** to create a new record. 
  
1.  In the **General** section, fill in the information as required:  
  
    - **Name**. Enter the name of the facility or equipment you want to add for scheduling.  
  
    - **Business Unit ID**. Enter a business unit ID. To choose an ID, select the **Lookup** button and then select from the list. You can also create a new business unit ID.
  
    - **Organizational Unit**. Select the location where the facility or equipment is located.
  
    - **Primary Email**. Enter the email address of the site manager or equipment manager. If there are any updates or cancellations related to the schedule, facilities, or equipment, notifications are sent to this email address.  
  
    - **Time Zone**. Select the appropriate time zone to determine availability for the facility or equipment. By default, the time zone is set to the one you selected in the **General** tab of the **Set Personal Options** dialog box. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Set personal options](../../customerengagement/on-premises/basics/set-personal-options.md)  
  
    - **Description**. Add details about the facility or equipment, such as the numbers, size, make, or model.  
  
1.  When you’re done, select **Save** or **Save and Close**.  

    ![facility and equipment.](../media/facilities_equipment_1.png)

### Related information

[Service Scheduling overview](basics-service-service-scheduling.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
