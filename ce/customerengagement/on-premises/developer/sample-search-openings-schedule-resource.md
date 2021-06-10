---
title: "Sample: Search for openings to schedule a resource (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to find openings to schedule a resource by using the SearchRequest message."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - sample for scheduling resources
  - scheduling resources sample, schedule and appointment entities samples
  - schedule and appointment entities
ms.assetid: 4c6ac2c8-6765-4a65-b1e0-e05a8d335abe
caps.latest.revision: 23
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Search for openings to schedule a resource

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the Schedule and Appointment samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/ScheduleAndAppointment).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 The following code example shows how to find openings to schedule a resource by using the <xref:Microsoft.Crm.Sdk.Messages.SearchRequest> message.  
  
## Example  
 [!code-csharp[ScheduleAndAppointment#ScheduleResource](../snippets/csharp/CRMV8/scheduleandappointment/cs/scheduleresource.cs#scheduleresource)]  
  
### See also  
 [Sample Code for Schedule and Appointment Entities](sample-code-schedule-appointment-entities.md)   
 [Sample: Query the Working Hours of a User](sample-query-working-hours-user.md)   
 [Resource Entities](resource-entities.md)   
    
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages.SearchRequest>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]