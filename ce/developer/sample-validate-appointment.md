---
title: "Sample: Validate an appointment (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to validate an appointment using the ValidateRequest message."
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
  - schedule and appointment entities
  - sample for validating appointments
  - validating appointments sample, schedule and appointment entities samples
ms.assetid: f88ba768-78f1-4fe8-9c72-59e72249f090
caps.latest.revision: 19
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Validate an appointment

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Schedules and Appointments](https://code.msdn.microsoft.com/Schedule-and-Appointment-93ed80c0). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to validate an appointment using the <xref:Microsoft.Crm.Sdk.Messages.ValidateRequest> message.  
  
## Example  
 [!code-csharp[ScheduleAndAppointment#Validate](../snippets/csharp/CRMV8/scheduleandappointment/cs/validate.cs#validate)]  
  
### See also  
 [Sample Code for Schedule and Appointment Entities](sample-code-schedule-appointment-entities.md)   
 [Sample: Create, Retrieve, Update, and Delete a Recurring Appointment](sample-create-retrieve-update-delete-recurring-appointment.md)   
 [Appointment Entities](appointment-entities.md)   
 [Sample: CrmServiceHelper Class](org-service/helper-code-serverconnection-class.md)   
 <xref:Microsoft.Crm.Sdk.Messages.ValidateRequest>
