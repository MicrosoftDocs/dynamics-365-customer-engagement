---
title: Set up resource categories for Service Scheduling (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to create and set up resource categories for service scheduling in Dynamics 365 Customer Service
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

# Create and manage resource categories 

With bookable resource categories, you can group your bookable resources by type. For example, you can create categories like technician, supervisor, subcontractor, vehicle, or equipment.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]: [Multi-resource scheduling with requirement groups](/dynamics365/customer-engagement/common-scheduler/multi-resource-scheduling-requirement-groups)

## Create a new resource category

Make sure that you have the required security role or equivalent permissions. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage security roles in service scheduling](manage-security-roles.md)

You can create a new resource category in the Customer Service admin center or Customer Service Hub app.

1. Go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

 
    1. In the site map, select **Service Scheduling** in **Operations**. The **Service Scheduling** page appears.
    2. In the **Resource categories** section, select **Manage**.
        
        The **Active Resource Categories** view is displayed. You can switch between various system views using the drop-down list.  

   ### [Customer Service Hub](#tab/customerservicehub)

    1. In the site map, go to **Scheduling**.
    2. From the list of entity records, select **Resource categories** in **Scheduling**.
       
       The **Active Resource Categories** view is displayed. You can switch between various system views using the drop-down list.

2. On the command bar, select **New** to create a new bookable resource category. 
3. In the **General** section:
 
   - Enter a **Name** and a **Description** for the resource category

4. Select **Save**. A new resource category is created and is activated by default. 

5. In the **Related** section, you can view and manage various resource category associations.

   ![resource categories.](media/resource_category_csh.png)

Similarly, you can create a new requirement resource category for requirements.

## Add resources to a resource category

To assign resources to a resource category:

1. In the **Related** section, go to **Resource Category Associations**.

2. Select **Add New Bookable Resource Category Association**. A resource category is populated. 

3. Add a resource to this resource category by selecting a resource in the **Resource** box. You can either lookup for an existing resource or create a new one.

### See also 
[Service Scheduling overview](basics-service-service-scheduling.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
