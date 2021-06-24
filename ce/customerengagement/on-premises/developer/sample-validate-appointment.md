---
title: "Sample: Validate an appointment (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to validate an appointment using the ValidateRequest message."
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
  - sample for validating appointments
  - validating appointments sample, schedule and appointment entities samples
ms.assetid: f88ba768-78f1-4fe8-9c72-59e72249f090
caps.latest.revision: 19
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Validate an appointment

This sample shows how to validate an appointment using the [ValidateRequest](/dotnet/api/microsoft.crm.sdk.messages.validaterequest?view=dynamics-general-ce-9) message. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ValidateAppointment).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `ValidateRequest` message is intended to be used in the scenario where it contains data that is needed to verify that an appointment or service appointment (service activity) has valid available resources for the activity, duration, and site, as appropriate.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Creates sample contact and activity party records.
3. Creates sample appointment.

### Demonstrate

1. Retrieves the appointment to be validated. 
2. The `ValidateRequest` message validates the appointment created in the Setup(#setup).

### Clean up

Display an option to delete the records in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]