---
title: "Sample: Query the working hours of multiple users (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "Sample demonstrates how to retrieve the working hours of multiple users by using the QueryMultipleSchedulesRequest message."
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
  - sample for querying the schedules of multiple users
  - schedule and appointment entities
  - querying the schedules of multiple users sample, schedule and appointment entities samples
ms.assetid: 68c9d5d9-ab69-4b6f-9f84-a1d5919d549e
caps.latest.revision: 26
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Query the working hours of multiple users

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Schedules and Appointments](https://code.msdn.microsoft.com/Schedule-and-Appointment-93ed80c0).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to retrieve the working hours of multiple users by using the <xref:Microsoft.Crm.Sdk.Messages.QueryMultipleSchedulesRequest> message.  
  
## Example  
 [!code-csharp[ScheduleAndAppointment#QueryWorkingHoursOfMultipleUsers](../snippets/csharp/CRMV8/scheduleandappointment/cs/queryworkinghoursofmultipleusers.cs#queryworkinghoursofmultipleusers)]  
  
### See also  
 [Schedules in Dynamics 365 for Customer Engagement apps](schedule-collections.md)   
 [Sample Code for Schedule and Appointment Entities](sample-code-schedule-appointment-entities.md)   
 [Sample: Book an Appointment](sample-book-appointment.md)   
 [Resource Entities](resource-entities.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages.QueryMultipleSchedulesRequest>   
 [Sample: CrmServiceHelper Class](org-service/helper-code-serverconnection-class.md)
