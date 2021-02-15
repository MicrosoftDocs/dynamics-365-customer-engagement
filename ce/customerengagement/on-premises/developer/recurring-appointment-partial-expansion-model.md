---
title: "Recurring appointment partial expansion model (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The partial expansion model is an asynchronous job that runs at pre-specified intervals, defined at the organization level, and used to create recurring appointment instances."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 64842501-58f9-4132-9126-75c70dafa3b4
caps.latest.revision: 22
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Recurring appointment partial expansion model

[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] implements a partial expansion model to create recurring appointment instances in the database. The recurrence information, specified when you create a `RecurringAppointmentMaster` record, is used to create or synchronize individual instances in a phased manner. This controls the creation of a large number of appointment records in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] due to the creation or synchronization of recurring appointments that have a large or infinite (no end date) recurrence range.  

 The partial expansion model is an asynchronous job in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] that runs at pre-specified intervals, and is defined at the organization level using the `Organization.RecurrenceExpansionJobBatchInterval` attribute. Moreover, the instance expansion model depends on an organization-level parameter, for example, “N,” where “N” stands for the maximum number of instances that can be created synchronously. You can specify an appropriate value for this variable using the `Organization.RecurrenceExpansionSynchCreateMax` attribute. These properties are covered in detail in the [Parameters for the partial expansion job](#Parameter) section later.  

<a name="Scenario1"></a>   
## When the recurring appointment instances are less than or equal to “N”  
 If the number of instances to be generated because of the recurrence information is less than or equal to “N”, the actual number of instances are created synchronously from the effective start date of the appointment. Each instance is stored as an appointment record in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  

<a name="Scenario2"></a>   
## When the recurring appointment instances are more than “N”  
 For each recurring appointment created in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], an asynchronous expansion job is created. The instances of the recurring appointment are expanded in the following phases:  

1. **Synchronous expansion**: The first “N” instances of the recurring appointment are created synchronously from the effective start date. Each instance is stored as an appointment record with the `Appointment.InstanceTypeCode` attribute set to “2” (Recurring Instance). The expansion of the rest of the instances is passed on to an asynchronous job. The effective start date is the date from which the recurring appointment series has to be expanded.  

2. **Asynchronous expansion**: Asynchronous jobs handle the rest of the expansion job and periodically expand the instances according to the recurrence information. The asynchronous expansion occurs only until the future expansion window (`Organization.FutureExpansionWindow`). After that, a new asynchronous job is created that handles expansion until the next future expansion window. The asynchronous service periodically expands the instances and stores them as appointment records in the system.  

<a name="Parameter"></a>   
## Parameters for the partial expansion job  
 You must set appropriate values for these organization-level attributes in the `Organization` record for the expansion model to work as per your requirements. You must have the System Administrator role or appropriate privilege to do this. The following table provides information about these properties.  


|                    Attribute                     |                                                                                                                                                                                                                    Description                                                                                                                                                                                                                    |
|--------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|  Organization.RecurrenceExpansionSynchCreateMax  |                                                                                             This is the maximum number of appointment instances that is created at the time of creation or synchronization of a recurring appointment. You must specify an integer value that corresponds to the number of instances. This value corresponds to “N”.                                                                                              |
|         Organization.PastExpansionWindow         |    This is the maximum valid time period in the past up to which the recurring appointments can be expanded or synchronized with [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)]. You must specify an integer value that corresponds to the number of months.<br /><br /> The value of this attribute determines the past instance cutoff date for expanding or synchronizing the recurring appointment instances.    |
|        Organization.FutureExpansionWindow        | This is the maximum valid time period in the future up to which the recurring appointments can be expanded or synchronized with [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)]. You must specify an integer value that corresponds to the number of months.<br /><br /> The value of this attribute determines the future instance cutoff date for expanding or synchronizing the recurring appointment instances. |
| Organization.RecurrenceExpansionJobBatchInterval |                                                                                                                                                                               This is the frequency in seconds after which the partial expansion job is triggered.                                                                                                                                                                                |
|   Organization.RecurrenceExpansionJobBatchSize   |                                                                                                                                                                                  This is the number of instances expanded every time the asynchronous job runs.                                                                                                                                                                                   |

### See also  
 [Recurring Appointment Entities](recurring-appointment-entities.md)   
 [Create a Recurring Appointment Series, Instance or Exception](create-recurring-appointment-series-instance-exception.md)   
 [Delete or End a Recurring Appointment Series or Instance](delete-or-end-a-recurring-appointment-series-or-instance.md)   
 [Update a Recurring Appointment](update-recurring-appointment.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]