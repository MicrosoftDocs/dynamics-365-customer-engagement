---
title: "Schedule collections (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Schedule is a logical collection of appointments that contains the availability and assignments of a given resource."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - schedule and appointment entities, querying a schedule
  - schedule and appointment entities, scheduling engine publishes changes
  - schedules, definition
  - schedules
  - querying a schedule, schedule and appointment entities
  - scheduling engine
  - schedules, introduction
ms.assetid: 4d908509-0508-4cbc-bbe6-322326597970
caps.latest.revision: 23
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Schedule collections

A *schedule* is a logical collection of appointments that contains the availability and assignments of a given resource. It is a logical collection of appointments with a scheduling interface. There is no schedule entity in the [!INCLUDE[cc-dyn365-ce-web-services](../includes/cc-dyn365-ce-web-services.md)]. Instead, the service, resource specification, user, and equipment entities support the scheduling engine when booking appointments and service appointments. By using schedule messages, you can look for free or busy information, search for appointments, and book a specific appointment for a service and a set of resources.  
  
 Appointments stored in schedules are related to the owner of the schedule. It is only possible to ask the schedule for free or busy times within a given time period. The result of the operation is a collection of time blocks (appointments) that correspond to available or reserved time. You can create a schedule that represents the availability of a set of resources or even a set of activities or some arbitrary subset of service availability. To retrieve a schedule collection, use the retrieve messages listed in the following table.  
  
 The scheduling engine must know when changes are made to several different entities in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. When changes are made, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] automatically schedules an asynchronous system job to publish the changes. This occurs five minutes after the change, whether the change occurs through the user interface or through Web service methods.  
  
## Supported messages  
 The following messages can be used with the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method to query a schedule.  
  
|Message|Description|  
|-------------|-----------------|  
|<xref:Microsoft.Crm.Sdk.Messages.QueryScheduleRequest>|Retrieves the content (existing commitments) of the schedule for a given entity. Use this message to search the specified resources for an available time slot that matches the specified parameters. The message is available on all schedulable entities.|  
|<xref:Microsoft.Crm.Sdk.Messages.QueryMultipleSchedulesRequest>|Searches multiple resources for an available time slot that matches the specified parameters.|  
|<xref:Microsoft.Crm.Sdk.Messages.SearchRequest>|Searches for available time slots and returns a set of available `Appointment` instances (as time blocks). The message is available on the `Resource` entity or the `Service` entity.|  
  
### See also  
 [Schedule and Appointment Entities](schedule-appointment-entities.md)   
 [Sample: Schedule a Resource](sample-search-openings-schedule-resource.md)   
 [Appointment Entities](appointment-entities.md)   
 [Appointment Entity](entities/appointment.md)   
 [Sample: Query the Schedule of a User](sample-query-working-hours-user.md)   
 [Sample: Query the Schedules of Multiple Users](sample-query-working-hours-multiple-users.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]