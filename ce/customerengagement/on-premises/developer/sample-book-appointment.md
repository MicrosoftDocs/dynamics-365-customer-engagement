---
title: "Sample: Book an appointment | MicrosoftDocs"
description: "Sample demonstrates how to book or schedule an appointment by using the BookRequest message."
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
  - sample for booking appointments
  - schedule and appointment entities
  - booking appointments sample, schedule and appointment entities samples
ms.assetid: 56e6a047-88dd-4f9b-b211-e5fc878595a9
caps.latest.revision: 17
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Book an appointment

This sample shows how to book or schedule an appointment by using the [BookRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.bookrequest?view=dynamics-general-ce-9) message. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/BookAppointment).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `BookRequest` message is intended to be used in a scenario to book or schedule an appointment.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks the current version of the org.
1. Gets the current user information and creates the ActivityParty instance.

### Demonstrate

Creates the appointment instance using the [BookRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.bookrequest?view=dynamics-general-ce-9) message and verifies that the appointment has been scheduled or not.

### Clean up

Display an option to delete the records created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]