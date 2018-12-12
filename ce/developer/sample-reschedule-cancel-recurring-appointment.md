---
title: "Sample: Reschedule and  cancel a recurring appointment (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to reschedule and cancel appointment instances in a recurring appointment series using the RescheduleRequest message."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
helpviewer_keywords: 
  - rescheduling or canceling recurring appointments sample, schedule and appointment entities samples
  - sample for rescheduling or canceling recurring appointments
  - schedule and appointment entities
ms.assetid: cc070cb3-f1c0-4390-8d23-ba2b60101d59
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Reschedule and  cancel a recurring appointment

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Schedules and Appointments](https://code.msdn.microsoft.com/Schedule-and-Appointment-93ed80c0).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 The following code example demonstrates how to reschedule and cancel appointment instances in a recurring appointment series using the <xref:Microsoft.Crm.Sdk.Messages.RescheduleRequest> message.  
  
## Example  
 [!code-csharp[ScheduleAndAppointment#RescheduleandCancelRecurringAppointmentInstance](../snippets/csharp/CRMV8/scheduleandappointment/cs/rescheduleandcancelrecurringappointmentinstance.cs#rescheduleandcancelrecurringappointmentinstance)]  
  
### See also  
 [Recurring Appointment Entities](recurring-appointment-entities.md)   
 [Sample: CrmServiceHelper Class](org-service/helper-code-serverconnection-class.md)   
 [Sample Code for Recurring Appointments](sample-code-schedule-appointment-entities.md)   
 [Sample: End a Recurring Appointment Series](sample-end-recurring-appointment-series.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages.RescheduleRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>
