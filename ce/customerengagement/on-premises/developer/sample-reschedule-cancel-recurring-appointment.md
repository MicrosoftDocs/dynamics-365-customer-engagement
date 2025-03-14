---
title: "Sample: Reschedule and  cancel a recurring appointment (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to reschedule and cancel appointment instances in a recurring appointment series using the RescheduleRequest message."
ms.custom: 
ms.reviewer: pehecke

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: sample
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - rescheduling or canceling recurring appointments sample, schedule and appointment entities samples
  - sample for rescheduling or canceling recurring appointments
  - schedule and appointment entities
ms.assetid: cc070cb3-f1c0-4390-8d23-ba2b60101d59
caps.latest.revision: 25
author: JimDaly
ms.author: nabuthuk
search.audienceType: 
  - developer
---
# Sample: Reschedule and  cancel a recurring appointment

This sample demonstrates how to reschedule and cancel appointment instances in a recurring appointment series using the [RescheduleRequest](/dotnet/api/microsoft.crm.sdk.messages.reschedulerequest?view=dynamics-general-ce-9&preserve-view=true) message. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/CSharp/RecurringAppointment).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `RescheduleRequest` message is intended to be used in a scenario where it contains the data that is needed to reschedule an appointment, recurring appointment, or service appointment (service activity).

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org. 
2. Defines an anonymous type to define the possible recurrence pattern values and possible values for days of the week.
3. Defines an anonymous type to define tbe possible values for recurrence rule pattern end type.
4. The `RecurringAppointmentMaster` creates a new recurring appointment.

### Demonstrate

1. The `QueryExpression` message queries the individual appointment instance that falls on or after 10 days from today. Basically this will be the second instance in the recurring appointment series.
2. The `RescheduleRequest` message updates the schedule start and end dates of the appointment.
3. The `SetStateRequest` message cancels the last instance of the appointment. The status of this appointment instance is set to `canceled`. You can view this appointment instance under the `All Activities` view.

### Clean up

Display an option to delete the sample data created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
