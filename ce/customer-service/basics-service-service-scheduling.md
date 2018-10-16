---
title: Overview of Service Scheduling (Dynamics 365 for Customer Service) | MicrosoftDocs
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

## Understand the basics of scheduling services

Using Service Scheduling, you can plan and schedule service activities for your customers by bringing together all your resources. The following scenario helps explain this: 

Contoso bike repairs schedules repair services for their customers. To facilitate this process, Contoso needs to bring together the following information:

- The types of bike repair services they offer.
- Work hours during which they perform their services.
- The personnel and equipments they have, to perform those services. 
- Capacity and expert level for all personnel.
- Geographical locations where they offer their services.

In this case, Contoso bike repairs can benefit from the Service Scheduling feature of Dynamics 365 for Customer Service. They can quickly cater to their customers who are looking to use their repair services. With the various service scheduling entities, they can plan service activities for their customers considering by the availability of resources, facilities, and equipment.

## Access Service Scheduling in the Customer Service Hub
With the Customer Engagement apps version 9.1 release, Service Scheduling, built on Universal Resource Scheduling (URS), is available from the Customer Service Hub sitemap.

- On the sitemap icon ![Sitemap](media/sitemap-icon.png) , select **...** to go to **Service Scheduling** and access the entity record types

  ![access-service-scheduling](media/access-service-scheduling-csh.png)

[!INCLUDE[proc_more_information] [Avail the new Service Scheduling experience](enable-urs-service-scheduling.md#avail-the-new-service-scheduling-experience).

See [Understand Service Scheduling entities](#understand-service-scheduling-entities) to learn more about the entities in service scheduling.
  
## Understand Service Scheduling entities

Service Scheduling entities are grouped under the following logical groups:

**Scheduling**

- **Resources** </br>
   Anything that needs to be scheduled can be termed as **Resources**. This can be personnel, crews, service centers, company assets (equipment), accounts, or contacts. 

  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and set up bookable resources](resources-service-scheduling.md)

- **Resource Categories** </br>
   With Resource categories,  you can group your bookable resources by type. For example, you can create categories like technician, supervisor, subcontractor, vehicle, or equipment. 
 
   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and manage resource categories](resource-categories-service-scheduling.md)

- **Facilities/Equipment**  </br>
   Facilities and equipment are resources you’d use to perform services for your customers. Facilities can be physical spaces like service bays or conference rooms and equipment could be tools or other assets. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add facilities and equipments to schedule service](add-facilities-equipment-ss-csh.md)

- **Services**  </br>
   To make scheduling services quick and easy, it’s helpful to predefine the specifics of the services you’d provide to customers. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or edit a service](create-edit-service-csh.md)

- **Service Activities** </br>
   Create a service activity by finding the next time resources are available for a service. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule a service activity](schedule-service-activity-csh.md)

**Tools**

- **Schedule Board** </br>
   The Dynamics 365 schedule board provides an overview of resource availability and bookings you can make. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the schedule board to configure service activity](use-schedule-board-configure-service-activity.md)

**Settings**

- **Organizational Units** </br>
   Your company organizes its business by geography, function, or other areas. You can create organizational units that reflect your business. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and manage organizational units](create-org-units-cs-scheduling.md)

- **Business Closure** </br>
   Prevent scheduling resources on holidays and other non-working days by defining business closures. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set when your business is closed](set-when-business-closed-csh.md)


### See also    

[Understand the new Service Scheduling experience](enable-urs-service-scheduling.md)
    
[Service Scheduling FAQ](service-scheduling-faq.md) 
