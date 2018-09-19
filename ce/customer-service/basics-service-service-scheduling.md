---
title: Overview of service and service scheduling (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know the basics of service and service scheduling in Dynamics 365 for Customer Service
keywords: Service scheduling; Dynamics 365; Customer Service; Universal Resource Scheduling (URS)
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
ms.assetid: 7904d0f0-6295-4fec-a843-f1ee5267536b
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Service Scheduling overview

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Avoid disruptions in service by making sure that your resources are scheduled optimally and efficiently. Learn the basics of getting started with managing services and service scheduling in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].  

Service Scheduling, now built atop **Universal Resource Scheduling (URS)**, provides an efficient way to schedule resources for service activity. It considers the availability of employees, facilities, and equipment to plan schedules accordingly. It also helps customer service organizations with improved service quality by preventing over-scheduling. This is done with the help of predictable workloads for employees, and reliable time estimates for customers and clients.

## What is Service Scheduling and how you can benefit from it

Using Service Scheduling, you can plan and schedule service activities for your customers by bringing together all your resources. This can be explained with the help of following scenario: 

Contoso bike repairs, a company that repairs bikes, schedules repair services for their customers. To facilitate this process, they need to bring together the following information:

- The types of bike repair services they offer
- Work hours during which they perform their services
- The personnel and equipments they have, to perform those services 
- Capacity and expert level for each personnel
- Sites, or geographical locations where they offer their services

In this case, Contoso bike repairs can benefit from the Service Scheduling feature of Dynamics 365 for Customer Service. They can quickly cater to their customers who are looking to avail their repair services. With the various service scheduling entities, they can plan service activities for their customers considering the availability of employees, facilities, and equipment.

## Access Service Scheduling in the Customer Service Hub

With the October'18 release, Service Scheduling built on Universal Resource Scheduling (URS) will be available in the Customer Service Hub. Upgrade and install to the latest update to avail the new service scheduling features.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable the new URS based Service Scheduling](enable-urs-service-scheduling.md)

You can access the new service scheduling from the Customer Service Hub sitemap in the following ways:

- On the sitemap icon ![Sitemap](media/sitemap-icon.png) , select **...** to go to **Service Scheduling** and access  the scheduling entity record types

See [Understand Service Scheduling entities](#understand-service-scheduling-entities) to know more about the entities in service scheduling.

## Know the service terminology  
  
- **Service:** A type of work, such as a maintenance activity, performed for a customer by one or more resources. Services are schedulable activities.  
  
- **Resource:** Users, facilities or equipment, or teams that can be scheduled and have work schedules.  
  
- **Resource groups:** Groups of resources that can be scheduled interchangeably.  
 
- **Work hours:** The hours that a resource is available for scheduling.  
  
- **Site:** The location of a resource. Use sites to make sure that the customer and the resource are in the same location.  
  
- **Service activity:** A schedulable appointment to provide a service to a customer. A service activity uses one or more resources to perform a service at a specific time and place. An appointment is a schedulable activity that does not use services and does not require a resource with work hours.  
  
- **Scheduling rule:** A set of criteria that specifies which personnel, equipment, facilities, or resource groups are required to perform a service, or how to select these resources, based on parameters like quantity and capacity.  
  
### Capacity vs. effort—understand the difference  
 You can set up services and resources in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to take into account different-sized facilities or the experience levels of your users when a service is scheduled. This is known as capacity scheduling. Capacity is a relative unit that you define. 

**For example**, you could define capacity in a bike repair shop as the number of bikes the shop has room to accommodate at the same time. If a repair bay has room for four bike-repair stations, the repair bay can accept four bikes for repair or inspection at the same time.  
  
 Capacity can also measure skill level. For example, a junior bike technician has the ability to perform one bike inspection per hour, and a senior technician has the ability to perform four bike inspections per hour. If two bikes must be inspected in one hour, it takes either two junior technicians, or one senior technician who can perform the inspections in half the time.  
  
 When you add effort required into the selection rule, every time a user searches for an available service activity time, the selection rules inspect the resources for capacity available. If the resource is scheduled, then that resource's capacity is reduced by the effort required for the service. This is repeated every time that a service is scheduled requiring that resource, until the capacity is exhausted.  
  
 Capacity is defined in the resource’s working hours. Effort required is defined in the service. You can think of capacity as "how much money you have" and effort required as "how much something costs."  
  
 **For example**, the repair bay has a capacity of four. A bike repair requires an effort of one and a tandem bike repair requires an effort of two. The first time the repair bay is selected, its capacity is reduced to three for that time. The next service activity scheduled is for a tandem bike. This reduces the repair bay's capacity by two. The repair bay has the capacity of one left, which means it could accept another bike repair, but not a tandem bike repair.  

## Understand Service Scheduling entities

Service Scheduling entities are grouped under the following logical groups:

**Scheduling**

- **Resources** </br>
   Anything that needs to be scheduled can be termed as **Resources**. This can be users, crews, service centers, company assets (equipment), accounts, or contacts. 

  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and set up bookable resources](resources-service-scheduling.md)

- **Resources Categories** </br>
   With Resource categories,  you can group your bookable resources by type. For example, you can create categories like technician, supervisor, subcontractor, vehicle, or equipment. 
 
   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and manage resource categories](resource-categories-service-scheduling.md)

- **Facility/Equipments**  </br>
   Facilities and equipment are resources you’d use to perform services for your customers. Facilities can be physical spaces like service bays or conference rooms and equipment could be tools or other assets. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add facilities and equipment for service scheduling](add-facilities-equipment-service-scheduling.md)

- **Services**  </br>
   To make scheduling services quick and easy, it’s helpful to predefine the specifics of the services you’d provide to customers. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or change a service](create-edit-service.md)

- **Service Activities** </br>
   Create a service activity by finding the next available time of resources for a service or simply without checking for conflicts. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule a service activity](schedule-service-activity.md)

**Tools**

- **Schedule Board** </br>
   The Dynamics 365 schedule board provides an overview of resource availability and bookings you can make. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure the schedule board for resource availability](../field-service/configure-schedule-board.md)

**Settings**

- **Organizational Units** </br>
   Your company probably organizes its consulting business by geography, function, or other areas. You can create organizational units that reflect your consulting business. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and manage organizational units](create-org-units-cs-scheduling.md)

- **Business Closure** </br>
   Prevent scheduling resources on holidays and other non-working days by defining business closures. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set when your business is closed](set-when-business-closed.md)


### See also    

[Get the new Service Scheduling experience](enable-urs-service-scheduling.md)
    
 
