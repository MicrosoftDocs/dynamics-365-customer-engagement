---
title: "Sample: Convert a fax to a task| MicrosoftDocs"
description: "This sample shows how to create a task for a fax by using the IOrganizationService.Entity method"
ms.custom: 
ms.date: 01/07/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: f82fe3eb-1867-4edb-869d-58081f38d653
caps.latest.revision: 23
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---

# Sample: Convert a fax to a task

This sample shows how to convert a **Fax** to a **Task**. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ConvertFaxToTask).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `CreateRequiredRecords` method creates the sample data that is required for the sample. The `retrievedFax` method retrieves the fax. 
The `DeleteRequiredRecords` method gives an option to delete all the data that sample has created.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. The `WhoAmIRequest` method gets the current user details.
1. The `ActivityParty` method creates the activity party for sending and receiving fax.
1. The `Fax` method creates the fax required for the sample.

### Demonstrate

1. Retrieves all the fax id's that are created in [Setup](#setup).
2. Creates a task and verifies whether the task has been created.

### Clean up

Displays an option to delete all the data created in the sample. The deletion is optional in case you want to examine the data created by the sample. You can manually delete the data to achieve same results.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]