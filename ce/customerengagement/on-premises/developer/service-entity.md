---
title: "Service entity (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The Service entity represents a service made available to a customer, with attributes that include the standard duration of the service, when the service is offered, and its required resources."
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
  - service entity, resource requirements; availability; and specifications
  - schedule and appointment entities, service entity
  - service entity, introduction
  - service entity
  - service entity, service booking
  - service entity, service engine
  - service booking, service entity
  - service entity, definition
  - resource requirements; availability; and specifications, service entity
ms.assetid: ed077e11-8af6-4f9b-a1f3-4feefeae1f4e
caps.latest.revision: 16
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Service entity

A service is work that is performed for a customer. The definition typically includes service attributes such as name, duration, granularity, calendar restrictions, and resource requirements. A `Service` entity represents a service made available to a customer, with attributes that include the standard duration of the service, when the service can be offered, and required resources, which is described by the `ResourceSpec` class.  
  
 For example, a dental cleaning service definition may include resource requirements for a hygienist, a dental cleaning chair, a patient, and a duration limit of 90 minutes. The definition may also include additional parameterized constraints that are evaluated during availability search. In this service definition, a constraint may be defined that the "patient" resource must have a valid insurance provider identification number. This constraint example uses a custom attribute added to the resource for the insurance provider identification number.  
  
 For each resource specification, there is an objective that ranks available resources from most suitable to least. For example, the busiest nurse, least busy doctor, or the cheapest resource.  
  
 To start using [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] service scheduling to manage your service delivery process, you must first create a model of your service business. To do this, you create a `Resource` record or an `Equipment` record for the people and equipment that you want to schedule and you create `Service` records for the services you offer. When you define the service, you can describe which resources are required for each service by using a series of resource specifications (`ResourceSpec`). Then, you can model the business rules that govern service availability into the system. These rules include things such as the working hours of the service delivery personnel, and any special restrictions on services. After this information is defined, the scheduling engine has what it must have to manage the service delivery schedule.  
  
 Service booking granularity determines the time interval on which availability is displayed to users. Typically, this is something like "every 15 minutes" or "every hour on the hour." Duration is the time that is required to perform the service.  
  
## In This Section  
 [Service Entity](entities/service.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]