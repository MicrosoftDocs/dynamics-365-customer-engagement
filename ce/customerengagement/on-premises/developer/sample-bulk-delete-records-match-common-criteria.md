---
title: "Sample: Bulk delete records that match common criteria| MicrosoftDocs"
description: "Sample demonstrates how to delete records, in bulk, that match common criteria."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 1e5fb8b0-5938-4af7-a21d-7365b27b6e1e
author: JimDaly
ms.author: nabuthuk
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - bulk deletion of records that match common criteria sample
  - sample for deleting related records in bulk
  - deleting data in bulk in Microsoft Dynamics CRM, sample for bulk deletion of records that match common criteria
  - deleting data in bulk in Microsoft Dynamics CRM, sample for deleting related records in bulk
  - deleting related records in bulk sample
  - sample for bulk deletion of records that match common criteria
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Bulk delete records that match common criteria

This sample shows how to delete records, in bulk, that match common criteria. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/BulkDeleteMatchCriteria).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `BulkDeleteRequest` message is intended to be used in a scenario where it contains data that is needed to create the bulk delete request.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Creates an sample account record.
3. Queries for a system user to send an email to, after the bulk delete operation completes.
4. The `BulkDeleteRequest` creates the bulk delete process and set the request properties.
5. The `InspectBulkDeleteOperation` method inspects and display the information about the created `BulkDeleteOperation`.
6. The `RetrieveBulkDeleteOperation` method retrieves the `BulkDeleteOperation`.

### Demonstrate

1. Checks whether the standard email templates are present.
1. The `PerformBulkDelete` method performs the main bulk delete operation.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]