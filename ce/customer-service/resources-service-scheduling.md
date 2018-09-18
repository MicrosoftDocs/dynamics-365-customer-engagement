---
title: Set up resources for service scheduling (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to create and set up resources for service scheduling in Dynamics 365 for Customer Service
keywords: Resources; Service scheduling; Dynamics 365; Customer Service; Universal Resource Scheduling (URS)
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: dyn365-customerservice
ms.assetid: 4353cb1d-fc4e-474f-9524-9b5add34246a
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Create and set up bookable resources

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

A resource in service scheduling is anything that needs to be scheduled. You can set up Generic, Contact, User, Equipment, Account, Crew, Facility or Pool as bookable resource.

## Create a new bookable resource record

Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.

1. In the Customer Service Hub sitemap, go to **Service Scheduling**.
2. From the list of entity records, select **Scheduling > Resources**.
   - The **Active Bookable Resources** view is displayed. You can switch between various system views using the drop-down.
   - Select **Show Chart** in the command bar to see the chart view.
   - Select any existing bookable resource to see additional options in the command bar
3. On the command bar, select **New** to create a new bookable resource. 
4. In the **General** section:
   - Select a **Resource Type**:

      - Generic:
      - Contact: Resources that aren't directly a part of your organization, but that you subcontract to
      - User: The resource is a member of your organization
      - Equipment: Company assest
      - Account:
      - Crew: Any collection of resources, for example, two or more workers, or a group
      - Facility:
      - Pool:
      
   - Look up and fill the name and the resource type field. You can also create a quickly create a new record

   - Select a **Time Zone**

   - Select **Save**

     **Resource Characteristics** and **Resource Categories**  sections are displayed.
    - In the **Resource Characteristics** section, select **...** and then select **Add New Bookable Resource Characteristics** to add characteristics.

      [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Specify skills for resources (Field Service)](../field-service/set-up-characteristics.md)
   
      - Use the tooltips to help fill in your information and then select **Save**
      - Look up and assign **Rating Value**. You can also create a new rating value
      - Assign the characteristic to a **Resource**

    - In the **Resource Categories** section, select **...** and then select **Add New Bookable Resource Category** to add a category.

5. In the **Scheduling** section:

    - Select the **Start Location** and the **End Location** to specify which location the resource will be at, when starting and ending work.
    - Select an **Organizational Unit** for the resource.
    - Select if the resource should be displayed on the schedule board.
    - Select if you want to enable the resource for availability search.

6. In the **Related** section, view and create all the common associations for the resource.


## Select resources for service  
 When you add a resource to a service, create a selection rule to determine how resources will be selected for service activities.  
  
 You can create a simple rule that selects resources from a list, or a compound rule that selects a combination of resources, or a complex tree of selection rules that selects from groups of equivalent resources.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a simple selection rule](../customer-service/create-simple-selection-rule.md)

## Add resources to existing services  
 You can add as many resources as you want, and they can be a mix of individual users, facilities, equipment, and teams. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up or change a service](../customer-service/create-edit-service.md)  

### See also

[Restrict a resource from performing a service](restrict-resource-from-performing-service.md)