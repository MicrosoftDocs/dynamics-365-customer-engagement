---
title: Schedule a service activity (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to schedule a service activity in Dynamics 365 for Customer Service
keywords: Schedule a service activity; Dynamics 365 for Customer Engagement; Customer Service
author: anjgupta
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.author: anjgup
manager: shujoshi
ms.date: 06/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 9b1ae6b1-8f46-47cc-b339-4e13a6ce9a8a
ms.custom: dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Schedule a service activity (Customer Service app)

[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Use this form to search for an available time for a service activity. You can either search for an open time using search criteria that, at a minimum, includes selecting a service, or you can define a more complex set of criteria. You can also create a service activity without checking for conflicts in the scheduled service. The service activity appears as a color block on the service calendar  
 
> [!NOTE]
> With the Customer Engagement apps version 9.1 release, the new Service Scheduling is now available in the Customer Service Hub sitemap. We recommend that you create service activities using the new experience. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule a service activity](schedule-service-activity-csh.md)

You can’t create a recurring service activity and it is recommended to create individual service activities as per requirement. 

> [!IMPORTANT]
> While creating a service activity, when you select resources manually and the system is unable to find a correct selection rule for the selected resources, you see the following error: </br>  </br>
Can’t determine the correct selection rule for one or more selected resources. </br> </br>
In that case, you can either reselect the resources from the selection rule or ignore the error and select Save. If you choose to save, 1 unit of capacity is depleted for the unresolved resources.

Use the following links to learn more about service scheduling using service activity:
 
[Navigate the service calendar](navigate-service-calendar-cs-app.md)<br/>
[Find the next available time before creating a service activity](../customer-service/find-next-available-time-before-create-service-activity-cs-app.md)<br/>
[Force an activity into a time slot](../customer-service/create-service-activity-without-checking-conflicts-cs-app.md) <br/>
[Create a selection rule to determine how resources are selected for service activities (Customer Service app)](create-simple-selection-rule.md)