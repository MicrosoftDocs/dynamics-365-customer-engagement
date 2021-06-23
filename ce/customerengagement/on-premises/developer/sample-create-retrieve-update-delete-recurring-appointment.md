---
title: "Sample: Create, retrieve, update, and delete a recurring appointment | MicrosoftDocs"
description: "Sample demonstrates how to create, retrieve, update, and delete a recurring appointment series using four common methods."
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
  - sample for creating, retrieving, updating, and deleting recurring appointments
  - creating, retrieving, updating, and deleting recurring appointments sample, schedule and appointment entities samples
  - schedule and appointment entities
ms.assetid: e8ec9b76-e219-4c2f-9816-c6fdf6ed8b0b
caps.latest.revision: 27
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Create, retrieve, update, and delete a recurring appointment

This sample shows how to create, retrieve, update, and delete a recurring appointment series. This sample uses the following common methods:

- [IOrganizationService.Create](/dotnet/api/microsoft.xrm.sdk.iorganizationservice.create?view=dynamics-general-ce-9)
- [IOrganizationService.Retrieve](/dotnet/api/microsoft.xrm.sdk.iorganizationservice.retrieve?view=dynamics-general-ce-9)
- [IOrganizationService.Update](/dotnet/api/microsoft.xrm.sdk.iorganizationservice.update?view=dynamics-general-ce-9)
- [IOrganizationService.Delete](/dotnet/api/microsoft.xrm.sdk.iorganizationservice.delete?view=dynamics-general-ce-9)

You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/CRUDRecurringAppointment).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `IOrganizationService` message is intended to be used in a scenario where it contains data that provides programmatic access to the metadata and data for an organization.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. Define anonymous types to define the possible recurrence pattern values, possible values for days of the week and possible values for the recurrence rule pattern end type. 
1. The `RecurringAppointmentMaster` method creates a recurring appointment.
1. The `QueryExpression` method retrieves the newly created recurring appointment.
1. The `Update` method updates the subject, number of occurences to 5, appointment interval to 2 for the retrieved recurring appointment.


### Clean up

Display an option to delete the records created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]