---
title: "Sample: Link custom attributes between series and instances| MicrosoftDocs"
description: "Sample demonstrates how to link a custom attribute that is created for a recurring appointment series (RecurringAppointmentMaster) with a custom attribute that is created for the Appointment instances. "
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
  - linking custom attributes between series and instances sample, schedule and appointment entities samples
  - sample for linking custom attributes between series and instances
  - schedule and appointment entities
ms.assetid: 4a82ca6c-70eb-4587-9e5e-8d077e935c3d
caps.latest.revision: 25
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Link custom attributes between series and instances

This sample shows how to link a custom attribute that is created for a recurring appointment series (`RecurringAppointmentMaster`) with a custom attribute that is created for the appointment instances (`Appointment`). You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/LinkAttributes).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this samples

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `CreateAttributeRequest` message is intended to be used in a scenario where it contains data that is needed to create custom attributes.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. The `StringAttributeMetadata` message creates custom string attributes for recurring appointment instance and appointment instance.
2. The `LinkedAttributeId` links the custom attribute to the appointment's custom attribute.

### Clean up

Display an option to delete the records that are created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]