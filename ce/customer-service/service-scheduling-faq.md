---
title: Service Scheduling Frequently Asked Questions (Dynamics 365 for Customer Service) | MicrosoftDocs
description: See some common questions about service scheduling and setting it up in Dynamics 365 for Customer Service
keywords: Service scheduling; Dynamics 365; Customer Service; Universal Resource Scheduling (URS); FAQ
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
ms.assetid: 4904013d-f0b1-4f74-895b-8f42dc179f73
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

#  Service Scheduling FAQ

Read this topic to find answers to some common questions regarding Service Scheduling, it's legacy and new experience, setup, and some key concepts.

## What are some key service terminologies?

- **Service:** A type of work, such as a maintenance activity, performed for a customer by one or more resources. Services are schedulable activities.  
  
- **Resource:** Personnel, facilities or equipment, or teams that can be scheduled and have work schedules.  
  
- **Resource category:** Groups of resources that can be scheduled interchangeably.  
 
- **Work hours:** The hours that a resource is available for scheduling.  
  
- **Organizational units:** The location of a resource. Use organizational units to make sure that the customer and the resource are in the same location.  
  
- **Service activity:** A schedulable activity to provide a service to a customer. A service activity uses one or more resources to perform a service at a specific time and place.  
  
- **Resource requirements:** A set of criteria that specifies which personnel, equipment, facilities, or resource categories are required to perform a service, or how to select these resources, based on parameters like quantity and capacity.  

## What is capacity and effort? What is the difference?
 You can set up services and resources in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to take into account different-sized facilities or the experience levels of your users when a service is scheduled. This is known as capacity scheduling. Capacity is a relative unit that you define. 

**For example**, you could define capacity in a bike repair shop as the number of bikes the shop has room to accommodate at the same time. If a repair bay has room for four bike-repair stations, the repair bay can accept four bikes for repair or inspection at the same time.  
  
 Capacity can also measure skill level. For example, a junior bike technician has the ability to perform one bike inspection per hour, and a senior technician has the ability to perform four bike inspections per hour. If two bikes must be inspected in one hour, it takes either two junior technicians, or one senior technician who can perform the inspections in half the time.  
  
 When you add effort required into the selection rule, every time a user searches for an available service activity time, the selection rules inspect the resources for capacity available. If the resource is scheduled, then that resource's capacity is reduced by the effort required for the service. This is repeated every time that a service is scheduled requiring that resource, until the capacity is exhausted.  
  
 Capacity is defined in the resource’s working hours. Effort required is defined in the service. You can think of capacity as "how much money you have" and effort required as "how much something costs."  
  
 **For example**, the repair bay has a capacity of four. A bike repair requires an effort of one and a tandem bike repair requires an effort of two. The first time the repair bay is selected, its capacity is reduced to three for that time. The next service activity scheduled is for a tandem bike. This reduces the repair bay's capacity by two. The repair bay has the capacity of one left, which means it could accept another bike repair, but not a tandem bike repair. 

### See also

[Service Scheduling Guide](basics-service-service-scheduling.md)


