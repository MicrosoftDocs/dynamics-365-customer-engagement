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

Avoid disruptions in service by making sure that your resources are scheduled optimally and efficiently. Using Service Scheduling, you can plan and schedule service activities for your customers by bringing together all your resources.

Service Scheduling, now built atop **Universal Resource Scheduling (URS)**, provides an efficient way to schedule resources for service activity. It considers the availability of employees, facilities, and equipment to plan schedules accordingly. It also helps customer service organizations with improved service quality by preventing over-scheduling.

With the Customer Engagement apps version 9.1 release, the new Service Scheduling is available from the Customer Service Hub sitemap.

## Service Scheduling scenario

The new experience lists the entities as follows, as compared to the legacy experience:

|Legacy Service Scheduling  |New Service Scheduling  |
|---------|---------|
|**Settings > Service Scheduling** </br> - Business Closure </br> - Services  </br> - Facilities/Equipment </br> - Resource Groups </br> - Sites  |   **Customer Service Hub sitemap >   Service Scheduling**  </br>  Scheduling </br> - Resources </br> - Facilities/Equipment </br> - Resource Categories   </br> - Service </br> - Service Activity </br> Tools </br> - Schedule Board </br> Settings </br> - Organizational Units </br> - Business Closures  |
|     |         |

- Sites are now Organizational Units.
- Resource Groups are now Resource Categories.
- You can now create all types of bookable resources using the **Resource** entity.

The difference between the legacy and the new experience can be explained with the help of the following scenario: 

Contoso bike repair schedules repair services for their customers. To facilitate this process, Contoso needs to bring together the following information:

- Geographical locations where they offer their services.
- The types of bike repair services they offer.
- Work hours during which they perform their services.
- The personnel and equipments they have, to perform those services. 
- Capacity and expert level for all personnel.


To facilitate this process, they compile the following inputs:

 - **Define sites or organizational units**  </br>
   Sites are the locations where Contoso will provide service to their customers. In this example, Contoso bike repair is the site for service.

   |Legacy Service Scheduling  |New Service Scheduling  |
   |---------|---------|
   |![sites](media/sites-cs.png)  |  ![organizational units](media/org-unit-csh.png)   |
   |[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use sites to manage your service locations (Customer Service app)](use-sites-manage-service-locations.md)     |  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and manage organizational units](create-org-units-cs-scheduling.md) |
   |   |         |  

- **Define resources**</br>
  Contoso defines the resources in the system. For example, two resources (contacts) Bert Hair and Gilda Moss are created. Similarly, two more resources (facility/equipment) are created, Bike repair workbench - 1 and Bike repair workbench - 2, which will be required to perform the service.

  |Legacy Service Scheduling  |New Service Scheduling  |
  |---------|---------|
  |![resources-cs](media/resources-cs.png)   |   ![resouces-csh](media/resources-csh.png)      |
  |[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or change a resource group (Customer Service app)](create-edit-resource-group.md)     | [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and set up bookable resources](resources-service-scheduling.md)  </br> |
  |   |         |


 - **Define work hours for the resource, resource group or facility/equipment** </br>
   The availability of the resources is defined in the work hours section. 

   |Service Scheduling  |
   |---------|---------|
   |   ![set-work-hours](media/set-work-hours-csh.png)     |
   | [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set work hours to define availability](set-work-hours-resource.md)|
   |   |         |
  
 - **Define resource groups** </br>
   The resources are aligned to the resource groups. For example, Bert Hair and Gilda Moss are grouped as Technicians and Bike repair workbench - 1 and Bike repair workbench - 2 are grouped as Workbenches.

   |Legacy Service Scheduling  |New Service Scheduling  |
   |---------|---------|
   |![resource-groups](media/res-group-cs.png)  |   ![resource group](media/res-groups-csh.png)     |
   |[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or change a resource group (Customer Service app)](create-edit-resource-group.md)     |  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and manage resource categories](resource-categories-service-scheduling.md)|
   |   |         |


- **Create a service record**  </br>
   Contoso now collates all the above inputs to create a bike repair service record for the customer. They also specify the resources/resource groups they will need for the service.

   |Legacy Service Scheduling  |New Service Scheduling  |
   |---------|---------|
   |![service-cs](media/service-cs.png)  |  ![service-csh](media/service-csh.png)   |
   |[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or edit a service (Customer Service app)](create-edit-service-cs-app.md)    |  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or edit a service in Service Scheduling](create-edit-service-csh.md) |
   |   |         | 

- **Book the service in the service calendar or schedule board**  </br>
  Contoso can now book the service for their customers in the service calendar or schedule board and mark it as either Open, Scheduled, or Completed as per its status.

   |Legacy Service Scheduling  |New Service Scheduling  |
   |---------|---------|
   |![service-calendar](media/service-calendar-cs.png) | ![schedule-board](media/schedule-board-csh.png)  |
   |[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Navigate the service calendar (Customer Service app)](navigate-service-calendar-cs-app.md)   |   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule a service activity](schedule-service-activity-csh.md) </br>    [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the schedule board to configure service activity](use-schedule-board-configure-service-activity.md)  |
   |   |         | 

## Set up the new Service Scheduling experience

Make sure that you have the Customer Service Manager, System Administrator, or System Customizer security role or equivalent permissions.

1. Check the Universal Resource Scheduling (URS) version

   For the new experience, you should have the latest version of URS installed on your system. Check the URS version. Go to **Settings** and select **Solutions** to see the current version of URS on your machine.

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule anything with Universal Resource Scheduling (Sales, Customer Service, Field Service, Project Service Automation)](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md).

      > [!NOTE]
      >  Consider that importing the service scheduling package will upgrade URS to the latest version. If Field Service or Project Service is already installed on your org with an older version of URS, then URS will also be upgraded. </br> The latest version of URS might not be compatible with the old versions of Field Service or Project Service.

2.  Get the Service Scheduling package

    Go to [Microsoft AppSource](https://appsource.microsoft.com/en-us/?src=dynamics365website&product=dynamics-365-business-central%3Bdynamics-365-for-customer-services%3Bdynamics-365-for-field-services%3Bdynamics-365-for-finance-and-operations%3Bdynamics-365-for-project-service-automation%3Bdynamics-365-for-sales) to access the Service Scheduling package. Search and opt for the package and fill the questionnaire. 

    You receive an email confirmation once the package is deployed for your org.

    > [!NOTE]
    > Service Scheduling deployment is similar to Field Service deployment. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Install and setup [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)]](../field-service/install-field-service.md).
  
3. Access Service Scheduling in the Customer Service Hub sitemap

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Access Service Scheduling in the Customer Service Hub](basics-service-service-scheduling.md#access-service-scheduling-in-the-customer-service-hub)

## Configure entity records in the new experience

You can configure all your entity records in the new experience manually from the user interface. Make sure that you have the Customer Service Manager, System Administrator, or System Customizer security role or equivalent permissions.

To follow the correct sequence, see [Service Scheduling scenario](#service-scheduling-scenario).

> [!NOTE]
> If you have been using the legacy service scheduling, you would still need to configure entity records in the new experience. </br> All entity records can be configured from the user interface except Service Activity.

### Migrate Service Activity
To migrate your Service Activities by running SDK code samples. See [Sample: Migrate Service Activity entity](migrate-service-activity-org-service.md) for more information.

## Access Service Scheduling in the Customer Service Hub
With the Customer Engagement apps version 9.1 release, Service Scheduling, built on Universal Resource Scheduling (URS), is available from the Customer Service Hub sitemap.

- On the sitemap icon ![Sitemap](media/sitemap-icon.png) , select **...** to go to **Service Scheduling** and access the entity record types

  ![access-service-scheduling](media/access-service-scheduling-csh.png)

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up the new Service Scheduling experience](enable-urs-service-scheduling.md#set-up-the-new-service-scheduling-experience)

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
    
[Service Scheduling FAQ](service-scheduling-faq.md) 
