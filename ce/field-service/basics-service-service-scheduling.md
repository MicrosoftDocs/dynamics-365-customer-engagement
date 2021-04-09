---
title: Overview of service and service scheduling (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know the basics of service and service scheduling in Dynamics 365 Customer Service
ms.date: 09/15/2017
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 7904d0f0-6295-4fec-a843-f1ee5267536b
author: lalexms
ms.author: laalexan
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
search.app: 
  - D365CE
  - D365FS
---

# Overview of service and service scheduling (Customer Service)

Avoid disruptions in service by making sure that your resources are scheduled optimally and efficiently. Learn the basics of getting started with managing services and service scheduling in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].  

> [!IMPORTANT]
> Service scheduling has been deprecated. For more information, see [Important changes coming](https://docs.microsoft.com/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).

## Understand the service terminology  
  
- **Service:** A type of work, such as a maintenance activity, performed for a customer by one or more resources. Services are schedulable activities.  
  
- **Resource:** Users, facilities or equipment, or teams that can be scheduled and have work schedules.  
  
- **Resource groups:** Groups of resources that can be scheduled interchangeably.  
  
- **Work hours:** The hours that a resource is available for scheduling.  
  
- **Site:** The location of a resource. Use sites to make sure that the customer and the resource are in the same location.  
  
- **Service activity:** A schedulable appointment to provide a service to a customer. A service activity uses one or more resources to perform a service at a specific time and place. An appointment is a schedulable activity that does not use services and does not require a resource with work hours.  
  
- **Scheduling rule:** A set of criteria that specifies which personnel, equipment, facilities, or resource groups are required to perform a service, or how to select these resources, based on parameters like quantity and capacity.  
  
## Select resources for service  
 When you add a resource to a service, create a selection rule to determine how resources will be selected for service activities.  
  
 You can create a simple rule that selects resources from a list, or a compound rule that selects a combination of resources, or a complex tree of selection rules that selects from groups of equivalent resources.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a simple selection rule](../field-service/create-simple-selection-rule.md)  
  
## Capacity vs. effort—understand the difference  
 You can set up services and resources in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to take into account different-sized facilities or the experience levels of your users when a service is scheduled. This is known as capacity scheduling. Capacity is a relative unit that you define. For example, you could define capacity in a bicycle repair shop as the number of bikes the shop has room to accommodate at the same time. If a repair bay has room for four bike-repair stations, the repair bay can accept four bikes for repair or inspection at the same time.  
  
 Capacity can also measure skill level. For example, a junior bike technician has the ability to perform one bike inspection per hour, and a senior technician has the ability to perform four bike inspections per hour. If two bikes must be inspected in one hour, it takes either two junior technicians, or one senior technician who can perform the inspections in half the time.  
  
 When you add effort required into the selection rule, every time a user searches for an available service activity time, the selection rules inspect the resources for capacity available. If the resource is scheduled, then that resource's capacity is reduced by the effort required for the service. This is repeated every time that a service is scheduled requiring that resource, until the capacity is exhausted.  
  
 Capacity is defined in the resource’s working hours. Effort required is defined in the service. You can think of capacity as "how much money you have" and effort required as "how much something costs."  
  
 For example, the repair bay has a capacity of four. A bike repair requires an effort of one and a tandem bike repair requires an effort of two. The first time the repair bay is selected, its capacity is reduced to three for that time. The next service activity scheduled is for a tandem bike. This reduces the repair bay's capacity by two. The repair bay has the capacity of one left, which means it could accept another bike repair, but not a tandem bike repair.  
  
## Add resources to existing services  
 You can add as many resources as you want, and they can be a mix of individual users, facilities, equipment, and teams. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up or change a service](../field-service/create-edit-service.md)  
  
## Use resource groups  
 Use resource groups to group users, facilities, and equipment as part of the selection rules for a service. You can add resources to a resource group from the service record. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or edit a resource group](../field-service/create-edit-resource-group.md)  
  
## Test your service  
 Before you start using a service, test it. Create a service activity with no criteria other than the service. You can use the results to confirm that the service is selecting correctly. The message bar will also display any problems with the search.  
  
1. Click **[!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]** > **Service** > **Service Calendar**.  
  
2. Click **Service Activity**. This bypasses the scheduling form.  
  
3. Select the service to test.  
  
4. Click **Find Available Times**.  
  
### See also    
 [Schedule a service activity](../customer-service/schedule-service-activity-cs-app.md)<br>

    
 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
