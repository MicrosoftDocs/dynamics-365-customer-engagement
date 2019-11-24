---
title: "Sample: Query the working hours of a user (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to retrieve the working hours of a user by using the QueryScheduleRequest message."
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
  - sample for querying user schedules
  - schedule and appointment entities
  - querying user schedules sample, schedule and appointment entities samples
ms.assetid: 06211393-b9aa-4c4d-9730-7ec51ec1bd3f
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Query the working hours of a user

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Schedules and Appointments](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/ScheduleAndAppointment).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to retrieve the working hours of a user by using the <xref:Microsoft.Crm.Sdk.Messages.QueryScheduleRequest> message.  
  
## Example  
 [!code-csharp[ScheduleAndAppointment#QueryWorkingHoursOfUser](../snippets/csharp/CRMV8/scheduleandappointment/cs/queryworkinghoursofuser.cs#queryworkinghoursofuser)]  
  
### See also  
 [Schedules in Dynamics 365 Customer Engagement](schedule-collections.md)   
 [Sample Code for Schedule and Appointment Entities](sample-code-schedule-appointment-entities.md)   
 [Sample: Query the Working Hours of Multiple Users](sample-query-working-hours-multiple-users.md)   
 [Resource Entities](resource-entities.md)   
    
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages.QueryScheduleRequest>
