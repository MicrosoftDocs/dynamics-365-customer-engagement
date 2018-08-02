---
title: "Calendar entities | MicrosoftDocs"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: aee14c98-38c7-4c47-850d-74ccc630735b
caps.latest.revision: 21
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Calendar entities

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

The calendar entity stores data for customer service calendars and holiday schedules in addition to business. Each calendar is set for a specific time zone.  
  
 A calendar describes the availability of a service or a resource. Calendars are related to `calendarrule` records, which include details about the duration, start and end times, and recurring patterns of events included in the calendar.  
  
 There are two types of calendar rules in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]:  
  
- **Root**: A calendar rule that contains an inner calendar or that has nested (leaf) rules. You can specify an inner calendar for a root calendar rule by using the `CalendarRule.InnerCalendarId` attribute. The attribute value of `CalendarRule.InnerCalendarId` of a root rule is the same as the attribute value of `CalendarRule.CalendarId` of its leaf rules.  
  
- **Leaf**: A calendar rule that doesn’t contain an inner calendar, and therefore, is the end of the "branch."  
  
  Calendar rules are ordered, or ranked, to describe their precedence, and rules can overlap. The nested rules expansion defines the time span, or extent, of a rule. You can use the `CalendarRule.ExtentCode` attribute to define how rule expansion overlap is handled, for example, whether both time span or extent of a rule are shown or if only one is included. These features provide for recurrence patterns, for example, different shift schedules for winter and summer months in a single service calendar.  
  
  A calendar can be a complex tree of rules and nested calendars that represent a high-level abstraction of the work schedule. The calendar entity supports the <xref:Microsoft.Crm.Sdk.Messages.ExpandCalendarRequest> message to convert to a simple view, which is an array of time blocks that determine availability over specific ranges.  
  
## In This Section  
 [Types of Calendars](types-calendars.md)  
  
 [Calendar Entity](entities/calendar.md)  
  
## Related Sections  
 [Appointment Entities](appointment-entities.md)  
  
 [Recurring Appointment Entities](recurring-appointment-entities.md)  
  
 [Resource Entities](resource-entities.md)  
  
 [Service Entity](service-entity.md)  
  
 [Sample Code for Schedule and Appointment Entities](sample-code-schedule-appointment-entities.md)
