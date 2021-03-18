---
title: "Sample: Query the working hours of a user (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to retrieve the working hours of a user by using the QueryScheduleRequest message."
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
  - sample for querying user schedules
  - schedule and appointment entities
  - querying user schedules sample, schedule and appointment entities samples
ms.assetid: 06211393-b9aa-4c4d-9730-7ec51ec1bd3f
caps.latest.revision: 25
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Query the working hours of a user

This sample shows how to retrieve the working hours of a user by using the [QueryScheduleRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.queryschedulerequest?view=dynamics-general-ce-9) message. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/QueryWorkingHours
).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `QueryScheduleRequest` message is intended to be used in a scenario where it contains data that is needed to search the specified resource for an available time block that matches specified parameters.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. The `WhoAMIRequest` message gets the current user's information.
2. The `QueryScheduleRequest` message retrieves the working hours of the current user.

### Clean up

Display an option to delete the sample data created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]