---
title: "Resource entities (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
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
  - resources, definition
  - resources, resource calendars
  - resource entities, introduction
  - resources, constraint-based resource groups
  - schedule and appointment entities, resource entities
  - resources, resource groups
  - resources
  - resources, resource specifications
  - resource entities, scheduling engines
ms.assetid: 1b5c3bca-66b8-4ff3-8f53-db1021bcf95c
caps.latest.revision: 16
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Resource entities

Resources represent the people, tools, rooms, or pieces of equipment that are used to deliver a service. Resources are collected into resource groups with similar attributes to make them easier to work with by adding the resources to a constraint based group (resource group).In [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], resources are categorized as Users or Facilities/Equipment.  
  
 A resource is an entity that can be scheduled. Examples of resources include employees, contacts, customers, knowledge workers, or physical assets like equipment. In the [!INCLUDE[cc-dyn365-ce-web-services](../includes/cc-dyn365-ce-web-services.md)], resources are represented by the system user (user) and equipment (facility/equipment) entities. As resources, these entities also have a site property that can affect scheduling.  
  
 A resource also has its own calendar that defines working hours and constraints. Upon creation, if a calendar is not specified for a resource, a calendar with 24 hours a day, seven days a week availability is created by default.  Resources support multiple concurrent appointments. This is supported by using the capacity set in the calendar rule for a calendar. A resource calendar describes not only when a resource is not available but also describes the resource effort available (capacity) and, optionally, the effort required (service cost). This is defined on a resource specification for services it supports. The resource specification is a required component of the service. It cannot be scheduled without specifying schedulable resources. These are evaluated by the scheduling engine when it is searching for resource availability for a particular appointment request. The resource is responsible for keeping its appointment book and responding to the scheduling engine only for existing commitments, calendar restrictions, and constraints.  
  
 A resource specification is an entity that chooses members in a group or team. It is also the link between a service and its resources and can be contained within a resource group to allow for nesting. For more information, see the diagram in [Working with Schedules and Appointments](schedule-appointment-entities.md). A resource specification defines the number and method for selecting resources within a group in addition to the effort required for a given service. Each service has exactly one resource specification but many services may share the same resource specification.  
  
 Resources can be grouped together to form a pool of available resource groups. Resource groups can contain user resources, equipment resources, teams and other resource groups, and enable the scheduling engine to select an available resource from a pool of resources. For example, one group could include all resources that have the skill of "Doctor." Another resource group could include all resources that have the skill of "Nurse." You can then define a resource specification that specifies one from the Doctors group and another that specifies two from the Nurses group. You can now define a new resource group called a "Surgery Crew," which includes these two resource specifications, one from Doctors and two from Nurses. A "Surgery" service can now refer to a resource specification that refers to this resource group. This is one example of how to quickly build a well-defined set of resource rules to participate in a service. A service may define requirements on the resource group as a whole, for example, any from the group, all from the group, or a subset.  
  
## Related Sections  
 [Sample Code for Schedule and Appointment Entities](sample-code-schedule-appointment-entities.md)  
  
 [Service Entity](service-entity.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]