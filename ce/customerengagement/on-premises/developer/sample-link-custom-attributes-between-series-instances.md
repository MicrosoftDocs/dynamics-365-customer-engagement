---
title: "Sample: Link custom attributes between series and instances (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Sample demonstrates how to link a custom attribute that is created for a recurring appointment series (RecurringAppointmentMaster) with a custom attribute that is created for the Appointment instances. "
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
  - linking custom attributes between series and instances sample, schedule and appointment entities samples
  - sample for linking custom attributes between series and instances
  - schedule and appointment entities
ms.assetid: 4a82ca6c-70eb-4587-9e5e-8d077e935c3d
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Link custom attributes between series and instances

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Schedules and Appointments](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/ScheduleAndAppointment).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to link a custom attribute that is created for a recurring appointment series (`RecurringAppointmentMaster`) with a custom attribute that is created for the appointment instances (`Appointment`).  
  
## Example  
 [!code-csharp[ScheduleAndAppointment#LinkCustomAttributesBetweenSeriesandInstances](../snippets/csharp/CRMV8/scheduleandappointment/cs/linkcustomattributesbetweenseriesandinstances.cs#linkcustomattributesbetweenseriesandinstances)]  
  
### See also  
    
 [Link Custom Attributes between Series and Instances](link-custom-attributes-recurring-master-appointment-entities.md)   
 [Sample Code for Recurring Appointments](sample-code-schedule-appointment-entities.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>
