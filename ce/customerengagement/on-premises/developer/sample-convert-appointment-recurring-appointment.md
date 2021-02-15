---
title: "Sample: Convert an appointment to a recurring appointment (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to convert an appointment to a recurring appointment series by using the AddRecurrenceRequest message."
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
  - schedule and appointment entities
  - sample for converting appointments to recurring appointments
  - converting appointments to recurring appointments sample, schedule and appointment entities samples
ms.assetid: 0b2a00b8-f970-4201-b10f-9ec13fa32afe
caps.latest.revision: 21
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---

# Sample: Convert an appointment to a recurring appointment

This sample shows how to convert an appointment to a recurring appointment series using the [AddRecurrenceRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.addrecurrencerequest?view=dynamics-general-ce-9) message. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ConvertToRecurring).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `AddRecurrenceRequest` message is intended to be used in a scenario where it contains the data that is needed to add recurrence information to an existing appointment.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. Creates an sample appointment that is later converted into an recurring appointment.

### Demonstrate

1. Specifies the recurrence information that needs to be added to the appointment created in the [Setup](#setup).
2. Defines the anonymous types that define the possible recurrence pattern values and also possible values for days.
3. Defines the anonymous types that define the possible values for the recurrence rule pattern and type.
4. The `RecurringAppointmentMaster` specifies the recurrence information. 
5. The `AddRecurrence` message converts the created appointment into recurring appointment.

### Clean up

Display an option to delete the sample data created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the sample data to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]