---
title: Get the new service scheduling based on Universal Resource Scheduling | MicrosoftDocs
description: Understand how to get the new service scheduling based on Universal Resource Scheduling (URS) in Dynamics 365 for Customer Service
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
ms.assetid: 676f241d-6a95-490c-be27-db517389efb5
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Get the new Service Scheduling experience

Service scheduling is now built atop **Universal Resource Scheduling (URS)** to provide an efficient way to schedule service activity. It considers the availability of employees, facilities, and equipment to plan schedules accordingly. It also helps customer service organizations with improved service quality by preventing over-scheduling. This is done with the help of predictable workloads for employees, and reliable time estimates for customers and clients.

With the Customer Engagement apps version 9.1 release, the new Service Scheduling will be available in the Customer Service Hub sitemap.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Access Service Scheduling in the Customer Service Hub](basics-service-service-scheduling.md#access-service-scheduling-in-the-customer-service-hub)


> [!IMPORTANT]
> If you are a new customer who is using the Service Scheduling feature for the first time, see [Configure the new Service Scheduling experience](#configure-the-new-service-scheduling-experience) to know how you can get the new experience </br> </br> 
If you have been using the legacy Service Scheduling feature from Service Management, see [Configure the new Service Scheduling experience](#configure-the-new-service-scheduling-experience) to know how you can upgrade and configure the new experience.

## About the new Service Scheduling experience

The new experience lists the scheduling entities in the following manner, as compared to the legacy experience:

|Legacy Service Scheduling  |New Service Scheduling  |
|---------|---------|
|**Settings > Service Scheduling** </br> - Business Closure </br> - Services  </br> - Facilities/Equipment </br> - Resource Groups </br> - Sites  |   **Customer Service Hub sitemap >   Service Scheduling**  </br>  Scheduling </br> - Resources </br> - Facilities/Equipments </br> - Resource Categories   </br> - Service </br> - Service Activity </br> Tools </br> - Schedule Board </br> Settings </br> - Organizational Units </br> - Business Closures  |
|     |         |

The difference between the legacy and the new experience can be explained with the help of the following scenario:

Contoso bike repairs, a company that repairs bikes, schedules repair services for their customers. To facilitate this process, they compile the following inputs:

 - **Define sites or organizational units**  </br>
   Sites are the locations where Contoso will provide service to their customers. In this example, Contoso bike repair is the site for service.

   |Legacy Service Scheduling  |New Service Scheduling  |
   |---------|---------|
   |![sites](media/sites-cs.png)  |  ![organizational units](media/org-unit-csh.png)   |
   |[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use sites to manage your service locations (Customer Service app)](use-sites-manage-service-locations.md)     |  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and manage organizational units](create-org-units-cs-scheduling.md) |
   |   |         |  

- **Define resources**</br>
  Contoso defines the resources in the system. For example, two resources (contacts) Bert Hair and Gilda Moss are created. Similarly, two more resources (facility/equipment) Bike repair workbench - 1 and Bike repair workbench - 2, which will be required to perform the service.

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

## Configure the new Service Scheduling experience

Make sure that you have the Customer Service Manager, System Administrator, or System Customizer security role or equivalent permissions.

### Install or upgrade Universal Resource Scheduling (URS)

To enable or migrate to the new experience, you should have the latest version of URS installed on your system.

- Check the URS version. Go to **Settings** and select **Solutions** to see the current version of URS on your machine.
- Upgrade to the latest version of URS from <<here>>. Consider the following point before you upgrade to the latest version.

  -	Importing the Service scheduling package will upgrade URS to the latest version. If Field Service or Project Service is already installed on your org with an older URS version, then URS will be upgraded. 

    > [!NOTE]
    > The latest version of URS might not be compatible with the old versions of Field Service or Project Service.

### Get the Service Scheduling package

To avail the service scheduling pakcage, the administrator of your organization needs to fill and submit a form. 

### Enable Service Scheduling in the Customer Service Hub sitemap

After you have availed the service scheduling pakcage, navigate to the Customer Service Hub sitemap and select **Enable**.

## Configure the new Service Scheduling experience

You can configure all your entity records in the new service scheduling experience either from the user interface or by running SDK code samples.

### Configure from user interface

Create the new entities manually in the new user interface. Make sure that you have the Customer Service Manager, System Administrator, or System Customizer security role or equivalent permissions before performing the steps in sequence as given in the section [About the new Service Scheduling experience](#about-the-new-service-scheduling-experience).


> [!NOTE]
> All the entity records can be configured using the user interface except Service Activity. To migrate and configure Service Activity, see here.

### Configure using SDK code samples

To configure entities in the new interface using SDK code samples, see <link to sushant's doc>


### See also

[Service Scheduling overview](basics-service-service-scheduling.md)