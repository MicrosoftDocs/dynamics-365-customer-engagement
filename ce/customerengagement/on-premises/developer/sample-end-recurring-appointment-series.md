---
title: "Sample: End a recurring appointment series (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to end a recurring appointment series by using the DeleteOpenInstancesRequest message."
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
  - sample for ending a recurring appointment series
  - schedule and appointment entities
  - ending a recurring appointment series sample, schedule and appointment entities samples
ms.assetid: 914a0fde-42ad-4a56-8d2d-7d0166bb2d3f
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: End a recurring appointment series

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Schedules and Appointments](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/ScheduleAndAppointment). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 The following sample shows how to end a recurring appointment series by using the <xref:Microsoft.Crm.Sdk.Messages.DeleteOpenInstancesRequest> message.  
  
## Example  
 [!code-csharp[ScheduleAndAppointment#EndRecurringAppointmentSeries](../snippets/csharp/CRMV8/scheduleandappointment/cs/endrecurringappointmentseries.cs#endrecurringappointmentseries)]  
  
### See also  
 [Sample: CrmServiceHelper Class](https://code.msdn.microsoft.com/Sample-Quick-start-for-650dbcaa/sourcecode?fileId=182557&pathId=222952671)   
 [Delete or End a Recurring Appointment Series or Instance](delete-or-end-a-recurring-appointment-series-or-instance.md)   
 <xref:Microsoft.Crm.Sdk.Messages.DeleteOpenInstancesRequest>   
 [Sample Code for Recurring Appointments](sample-code-schedule-appointment-entities.md)   
 [Sample: Convert an Appointment to a Recurring Appointment](sample-convert-appointment-recurring-appointment.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>
