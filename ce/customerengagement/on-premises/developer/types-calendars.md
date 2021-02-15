---
title: "Types of calendars (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 6f88c4ff-876e-4108-885f-98700436d461
caps.latest.revision: 11
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Types of calendars

The calendar entity was modified to support additional types of calendars in [!INCLUDE[pn_v6_online_ur1_shortest](../includes/pn-v6-online-ur1-shortest.md)] and [!INCLUDE[pn_crm_2015_service_pack_1_op_short](../includes/pn-crm-2015-service-pack-1-op-short.md)].  
  
## Calendar type  
 The `Type` Picklist attribute contains the following options:  
  
|Value|Label|Description|  
|-----------|-----------|-----------------|  
|0|Default|All calendars that are not customer service, holiday schedule, or inner calendars.|  
|1|Customer Service|Service calendars for customer service.|  
|2|Holiday Schedule|Holiday schedule calendars for customer service.|  
|-1|Inner Calendar type|Inner Calendars are used by other calendars to build a graph of time slots available for customer service or service scheduling to be performed.|  
  
### Customer service calendars  
 Customer service calendars exist to calculate performance against service level agreements (SLAs). SLAs are frequently based on key performance indicators (KPIs) based on time, such as duration for first response or a time limit before escalation. When these time limits are restricted to periods when customer service operations are open, calculations to enforce these agreements must include data from the customer service calendar.  
  
 Customer service calendars define regular weekly schedules. Events that don’t fall into those regular schedules are usually holidays. A customer service calendar can be associated with a holiday schedule to provide a complete description of the times when customer services are available.  
  
### Service scheduling calendars  
 Service scheduling uses the default calendar type. Business closure calendars can be defined and shared on service and resource entities. The scheduling engine makes sure that all appropriate calendar rules are considered for an appointment request.  
  
 In addition to free/busy times, you can define effort (required/available) constraints on the `CalendarRule` entity. These constraints are defined as the effort that is available from a resource to perform, deliver, or repeat a particular service at a given time. Similarly, each service defines the effort that is required from the required pool of resources to complete one unit of service for its specified duration. The scheduling engine automatically computes the appropriate time blocks for an appointment when the total effort that is required for a given service is less than or equal to the total available effort for all the required resources.  
  
### See also  
 [Calendar Entities](calendar-entities.md)   
 [Calendar Entity](entities/calendar.md)   
 <xref:Microsoft.Dynamics.CRM.calendarrule>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]