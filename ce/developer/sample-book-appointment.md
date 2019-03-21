---
title: "Sample: Book an appointment (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to book or schedule an appointment by using the BookRequest message."
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
  - sample for booking appointments
  - schedule and appointment entities
  - booking appointments sample, schedule and appointment entities samples
ms.assetid: 56e6a047-88dd-4f9b-b211-e5fc878595a9
caps.latest.revision: 17
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Book an appointment

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Schedule and Appointment](https://code.msdn.microsoft.com/Schedule-and-Appointment-93ed80c0). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to book or schedule an appointment by using the <xref:Microsoft.Crm.Sdk.Messages.BookRequest> message.  
  
## Example  
 [!code-csharp[ScheduleAndAppointment#BookAppointment](../snippets/csharp/CRMV8/scheduleandappointment/cs/bookappointment.cs#bookappointment)]  
  
### See also  
 [Sample Code for Schedule and Appointment Entities](sample-code-schedule-appointment-entities.md)   
 [Appointment Entities](appointment-entities.md)   
 [Sample: CrmServiceHelper Class](org-service/helper-code-serverconnection-class.md)   
 <xref:Microsoft.Crm.Sdk.Messages.BookRequest>   
 [Sample: Validate an Appointment](sample-validate-appointment.md)
