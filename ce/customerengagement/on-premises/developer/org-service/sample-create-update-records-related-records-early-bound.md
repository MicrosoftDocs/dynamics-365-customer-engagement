---
title: "Sample: Create and update records with related records (early bound) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to create and update a record and related records in one call by using the IOrganizationService.Entity) and IOrganizationService. Entity) methods"
keywords: 
ms.date: 01/08/2020
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 72eeafd8-8dd5-40af-9e3d-575534d60f61
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - sample for creating and updating records with related records (early bound)
  - early-bound class samples, creating and updating records with related records (early bound) sample
  - creating and updating records with related records (early bound) sample, early-bound class samples
  - samples for early-bound classes, creating and updating records with related records (early bound) sample
caps.latest.revision: 21
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Create and update records with related records (early bound)

This sample shows how to create and update a record and related records in one call by using the following methods:

- [IOrganizationService.Create](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.iorganizationservice.create?view=dynamics-general-ce-9)
- [IOrganizationService.Update](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.iorganizationservice.update?view=dynamics-general-ce-9)

You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/CreateUpdateRecordsWithRelatedRecords).

[!include[cc-sample-note](../includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](../includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `IOrganizationService` message is intended to be used in a scenario where it contains data that provides programmatic access to the metadata and data for an organization.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. The `Account` method creates a account record for which we will add letters. 
1. The `Relationship` method creates the reference between letter and account.

### Clean up

Display an option to delete the records created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]