---
title: "Appointment entities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Overview of the appointment entity, which represents a commitment over a time interval with start and end times and a duration."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0e1254fa-d7a1-42a5-840c-cd26162c1f48
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Appointment entities

An *appointment* is a commitment that represents a time interval with start and end times and duration. The schema name for this entity is `Appointment`.
A *service appointment* represents an appointment for service. The schema name for this entity is `ServiceAppointment`. A service appointment can be 
customized independently from other activities to accommodate the customer's business requirements for service delivery. Service appointments can block 
the availability of required resources and participate in resource availability searches and scheduling. A service appointment must have a corresponding 
service. It can be already bound with a set of resources specified by an activity party (`ActivityParty`) list.  
  
To create an appointment by making sure that the constraints are met, use the <xref:Microsoft.Crm.Sdk.Messages.BookRequest> message or the <xref:Microsoft.Crm.Sdk.Messages.RescheduleRequest> message. The scheduling engine stores the booked appointment and 
adjusts the free/busy information for the resource. You can create an appointment at a specific time for a specific service that uses a specific set of 
resources, ignoring all constraints, by using the<xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> method or <xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> message.  
  
Appointments can block the availability of the required resources. Appointments can be blocking, specified as part of the service definition or per 
appointment instance, for other appointments at the same interval.  
  
## In This Section  
 [Schedule and appointment entities](schedule-appointment-entities.md)  
  
 [Schedules in Dynamics 365 Customer Engagement](schedule-collections.md)  
  
 [Appointment Entity](entities/appointment.md)  
  
 [ServiceAppointment Entity](entities/serviceappointment.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]