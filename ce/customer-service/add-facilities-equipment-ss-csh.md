---
title: Add and create new facilities and equipment for Service Scheduling in Dynamics 365 Customer Service | MicrosoftDocs
description: Learn how to add and create facilities and equipment for service scheduling in Dynamics 365 Customer Service
ms.date: 04/04/2022
ms.topic: article
author: lalexms
ms.author: laalexan
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Add facilities and equipment to schedule service

## Introduction

Facilities and equipment are resources you use to perform services for your customers. Facilities could be physical spaces like service bays or conference rooms and equipment could be tools or other assets. Add these resources to Dynamics 365 Customer Service to ensure optimal services for your customers.  

## Create a new facility or equipment record

Make sure that you have the required security role or equivalent permissions. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage security roles in service scheduling](manage-security-roles.md)

You can create a new facility or equipment record in the Customer Service admin center or Omnichannel admin center app.

1. Go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Service Scheduling** in **Operations**. The **Service Scheduling** page appears.
    2. In the **Facilities & equipment** section, select **Manage**.
        
        The **Local Facilities/Equipment** view is displayed. You can switch between various system views using the dropdown list.  

   ### [Customer Service Hub](#tab/customerservicehub)

    1. In the site map, go to **Scheduling**.
    2. From the list of entity records, select **Facilities/Equipment** in **Scheduling**.
       
       The **Local Facilities/Equipment** view is displayed. You can switch between various system views using the dropdown list.
     
2. On the command bar, select **New** to create a new record. 
  
3.  In the **General** section, fill in the information as required:  
  
    - **Name**. Enter the name of the facility or equipment you want to add for scheduling.  
  
    - **Business Unit ID**. Enter a business unit ID. To choose an ID, select the **Lookup** button and then select from the list. You can also create a new business unit ID.
  
    - **Organizational Unit**. Select the location where the facility or equipment is located.
  
    - **Primary Email**. Enter the email address of the site manager or equipment manager. If there are any updates or cancellations related to the schedule, facilities, or equipment, notifications are sent to this email address.  
  
    - **Time Zone**. Select the appropriate time zone to determine availability for the facility or equipment. By default, this is set to the time zone you’ve selected in the **General** tab of the **Set Personal Options** dialog box. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set personal options](../customerengagement/on-premises/basics/set-personal-options.md)  
  
    - **Description**. Add details about the facility or equipment, such as the numbers, size, make, or model.  
  
4.  When you’re done, select **Save** or **Save and Close**.  

    ![facility and equipment.](media/facilities_equipment_1.png)
### See also

[Service Scheduling overview](basics-service-service-scheduling.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
