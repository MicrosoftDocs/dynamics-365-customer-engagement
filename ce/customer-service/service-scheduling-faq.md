---
title: Service Scheduling Frequently Asked Questions (Dynamics 365 Customer Service) | MicrosoftDocs
description: See some common questions about service scheduling and setting it up in Dynamics 365 Customer Service
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 11/20/2018
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
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

## What licenses do I need to enable service scheduling for my org?
 
The new scheduling experience is available to you if you have Dynamics 365 Customer Service Enterprise.

## Is the new scheduling experience automatically available with the next Dynamics 365 Customer Service upgrade?

Scheduling in the Customer Service Hub is a customer driven update. You need to avail and enable the new service scheduling package, which will also include Universal Resource Scheduling (URS) functionality. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up the new scheduling experience](basics-service-service-scheduling.md#set-up-the-new-service-scheduling-experience)

## What is the migration path to the new service scheduling, now powered by Universal Resource Scheduling (URS)? 

Currently, you need to configure all the service scheduling configuration data using the new interface. 

You can migrate existing service activities by running scripts as shown in [Sample: Migrate Service Activity entity](migrate-service-activity-org-service.md).

> [!NOTE]
> We are working towards an automated migration path in our future release. 

## Is manual selection of resources supported in a service activity in the new scheduling experience?
While creating a service activity, manual selection of resources is not supported in the new scheduling experience in the Customer Service Hub.


### See also

[Service Scheduling Guide](basics-service-service-scheduling.md)


