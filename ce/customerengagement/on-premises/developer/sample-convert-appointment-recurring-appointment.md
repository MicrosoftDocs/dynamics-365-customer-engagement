---
title: "Sample: Convert an appointment to a recurring appointment (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to convert an appointment to a recurring appointment series by using the AddRecurrenceRequest message."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - schedule and appointment entities
  - sample for converting appointments to recurring appointments
  - converting appointments to recurring appointments sample, schedule and appointment entities samples
ms.assetid: 0b2a00b8-f970-4201-b10f-9ec13fa32afe
caps.latest.revision: 21
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Convert an appointment to a recurring appointment

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the Schedule and Appointment samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/ScheduleAndAppointment).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to convert an appointment to a recurring appointment series by using the <xref:Microsoft.Crm.Sdk.Messages.AddRecurrenceRequest> message.  
  
## Example  
 [!code-csharp[ScheduleAndAppointment#ConvertAnAppointmenttoRecurringAppointment](../snippets/csharp/CRMV8/scheduleandappointment/cs/convertanappointmenttorecurringappointment.cs#convertanappointmenttorecurringappointment)]  
  
### See also  
    
 [Convert an Appointment to a Recurring Appointment](create-recurring-appointment-series-instance-exception.md#bkmk_convert)   
 [Sample Code for Recurring Appointments](sample-code-schedule-appointment-entities.md)   
 [Sample: Link Custom Attributes between Series and Instances](sample-link-custom-attributes-between-series-instances.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AddRecurrenceRequest>
