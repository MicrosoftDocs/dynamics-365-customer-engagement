---
title: "Sample: Create a queue (early bound) | MicrosoftDocs"
decription: The sample code demonstrates how to create a simple queue and set the required attributes.
ms.custom: 
ms.date: 12/18/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - sample for creating queues (early bound) and setting required attributes
  - creating simple queues (early bound) and setting required attributes, sample
ms.assetid: 88018e90-23f6-460b-b641-e875008b8588
caps.latest.revision: 20
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Create a queue (early bound)

This sample shows how to create a simple queue and set the required attributes using the [IOrganizationService.Create](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.iorganizationservice.create?view=dynamics-general-ce-9) message.

You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/CreateQueue).

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

1. The `newQueue` method creates a queue instance and set its property values. 
2. The `IncomingEmailDeliveryMethods` defines the anonymous types to define the range of possible queue property values.

### Clean up

Display an option to delete the records created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]