---
title: "Schedule and appointment entities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Overview of appointment-based service scheduling, including defining services, resources and work schedules, and service locations."
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
  - schedule and appointment entities, scheduling engines
  - optimizing scheduling, see 'schedule and appointment entities'
  - schedule and appointment entities, introduction
  - appointment entities, see 'schedule and appointment entities'
  - managing appointment-based services, see 'schedule and appointment entities'
  - schedule and appointment entities, managing appointment-based services
  - scheduling engines, see 'schedule and appointment entities'
  - schedule and appointment entities, message classes for appointments
  - schedule and appointment entities, optimizing scheduling
ms.assetid: 676e9f3f-e5a0-4251-aaea-27f396da8bf1
caps.latest.revision: 23
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Schedule and appointment entities

[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] provides capabilities to address appointment-based service scheduling. You can define services, resources and work schedules, and service locations. A scheduling engine manages booked appointments and service availability, and can be tuned to optimize scheduling to reduce costs and required resources.  
  
 The entity model for the scheduling engine includes a core set of entities: `Service`, `Resource`, `Calendar` and `Site`. Other entities describe resource requirements, constraints, calendar rules, and a schedule.  
  
 The following messages can be used for scheduling appointments, recurring appointments, and service appointments (service activity).  
  
|Message|Web API Operation|SDK Assembly|  
|-------------|-----------------|-----------------|  
|Creates an appointment, recurring appointment, or service appointment (service activity), and calls the scheduling engine to make sure that it is valid for all constraints without any scheduling conflicts.|<xref href="Microsoft.Dynamics.CRM.Book?text=Book Action" />|<xref:Microsoft.Crm.Sdk.Messages.BookRequest>|  
|Reschedules an appointment, recurring appointment, or service appointment (service activity), and calls the scheduling engine to make sure that it is valid for all constraints without any scheduling conflicts.|<xref href="Microsoft.Dynamics.CRM.Reschedule?text=Reschedule Action" />|<xref:Microsoft.Crm.Sdk.Messages.RescheduleRequest>|  
  
## In This Section  
 [Appointment Entities](appointment-entities.md)  
  
 [Recurring Appointment Entities](recurring-appointment-entities.md)  
  
 [Calendar Entities](calendar-entities.md)  
  
 [Resource Entities](resource-entities.md)  
  
 [Service Entity](service-entity.md)  
  
 [Sample Code for Recurring Appointments](sample-code-schedule-appointment-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]