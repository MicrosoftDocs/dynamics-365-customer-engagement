---
title: Add facilities and equipment | Microsoft Docs
description: How to add facilities and equipment in Unified Interface-based Scheduling Service for Dynamics 365 Customer Service.
ms.date: 04/04/2020
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

# Add facilities and equipment resources

## Introduction

Facilities and equipment are resources you use to perform services for your customers. Facilities can be physical spaces like service bays or conference rooms, and equipment could be tools or other assets. Add these resources to Dynamics 365 Customer Service to ensure optimal services to your customers.

## Add facilities or resources

Before you begin, make sure you have the **System Administrator** security role or equivalent permissions in Microsoft Dynamics 365. 

1. Navigate to the Customer Service admin center or Customer Service Hub app, and perform the following steps:

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Service Scheduling** in **Operations**. The **Service Scheduling** page appears.
    1. In the **Facilities/Equipment** section, select **Manage**.
        
        The **Local Facilities/Equipment** view is displayed. You can switch between various system views using the drop-down list.  

   ### [Customer Service Hub](#tab/customerservicehub)

    1. In the site map, go to **Scheduling**.
    1. From the list of entity records, select **Facilities/Equipment** in **Scheduling**.
       
       The **Local Facilities/Equipment** view is displayed. You can switch between various system views using the drop-down list.

2. Select **New**.

3. Fill in the information as required:
  
    - **Name**: Enter the name of the facility or equipment you want to add for service scheduling.
  
    - **Business Unit**: Dynamics 365 Customer Service enters the business unit automatically. To select a different business unit, select the **Lookup** button, and then select the business unit from the list.

    - **Site**. Select the location where the facility or equipment is located.
  
     > [!Note]
     > Make sure the site and customer are in the same location. Resources for a given service activity should also be located at the same site. 

    - **Primary Email**: Enter the email address of the site manager or equipment manager. If there are any updates or cancellations related to the schedule, facilities, or equipment, notifications are sent to this email address. 

    - **Time Zone**: Select the appropriate time zone to determine availability for the facility or equipment. By default, this is set to the time zone you’ve selected in the **General** tab of the **Set Personal Options** page. More information: [Set personal options](../customerengagement/on-premises/basics/set-personal-options.md) 

    - **Description**: Add details about the facility or equipment, such as the numbers, size, make, or model.
  
3. When you're finished entering details, select **Save** or **Save & Close**.

   ![Save details.](media/uci-save-facility-equipment.png "Save the details you've entered")

4. Set up the work hour calendar.

   ![Calendar with working hours.](media/uci-workhour-calendar.png "Set up the workhour calendar")
   

### See also  

[Unified Interface-based service scheduling overview](uci-scheduling-overview.md)

[Create or edit a service](uci-create-edit-service.md)

[Schedule a service activity](uci-schedule-service-activity.md)

[Create resource groups](uci-create-resource-groups.md)

[Use sites to manage your service locations](uci-create-sites.md)

[Navigate the service calendar](uci-navigate-service-calendar.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
