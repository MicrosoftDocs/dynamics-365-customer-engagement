---
title: "Sample: Bulk delete exported records | MicrosoftDocs"
description: "Sample demonstrates how to perform a bulk deletion of records that were previously exported by using the Export-to-Excel option."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: d5483d27-ee03-428f-ad70-2765765ae262
author: JimDaly
ms.author: nabuthuk
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - deleting data in bulk in Microsoft Dynamics CRM, sample for performing a bulk deletion of exported records
  - performing a bulk deletion of exported records sample
  - sample for performing a bulk deletion of exported records
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Bulk delete exported records

This sample shows how to perform a bulk deletion of records that were previously exported from Dataverse by using the **Export to Excel** option. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/BulkDeleteExported).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `BulkDeleteRequest` message is intended to be used in a scenario where it contains data that is needed to create the bulk delete request.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Query for a system user to send an email after bulk delete request operation completes.
3. The `BulkDeleteRequest` creates the bulk delete process and set the request properties.
4. The `CheckSuccess` method queries for the `BulkDeleteOperation` until it has been completed or until the designated time runs out. It then checks to see if the operation is complete.

### Demonstrate

The `PerformBulkDeleteBackup` method performs the main bulk delete operation on inactive opportunities and activities to remove them from the system.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]