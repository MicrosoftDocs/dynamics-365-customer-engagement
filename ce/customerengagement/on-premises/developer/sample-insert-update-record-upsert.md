---
title: "Sample: Insert or update a record using Upsert (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "This sample code shows how to insert or update records by using the Upsert message"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 5aac6430-5d98-4e50-94f9-c2f6ce5cee62
caps.latest.revision: 24
author: JimDaly
ms.author: nkrb
manager: kvivek
search.audienceType: 
  - developer

---

# Sample: Insert or update a record using Upsert

This sample code shows how to insert or update records by using the [UpsertRequest](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.upsertrequest?view=dynamics-general-ce-9) message. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/InsertRecordUsingUpsert).  

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `UpsertRequest` message is intended to be used in a scenario where it contains data that is needed to update or insert a record.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. Import a managed solution (UpsertSample_1_0_0_0_managed.zip) that creates a `sample_product` entity that has an alternate key named `sample_productcode`. Verify that the indexes to support the alternate key are active.

### Demonstrate

1. The `ProcessUpsert` method processes data in the `newsampleproduct.xml` to represent new products and creates 13 new records.
1. The second time when the `ProcessUpsert` method is called, it processes data in `updatedsampleproduct.xml` to represent updates to products previously created. 
1. The `UpsertRequest` method creates 6 updated records. 

### Clean up

Display an option to delete the managed solution created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]