---
title: "Sample: Make a report available or unavailable to organization | MicrosoftDocs"
description: "This sample shows how make a report available or unavailable to an organization."
ms.custom: 
ms.date: 01/28/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 69763a0a-af67-48b8-adf2-470c1cdf6196
caps.latest.revision: 22
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---

# Make a report available or unavailable to organization

This sample shows how to make a report available or unavailable to an organization. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/MakeReportAvailableToOrganization).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## How this sample works

In order to simulate the scenario described above, the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. The `CreateRequiredRecords` method creates any entity records that this sample requires.

### Demonstrate

1. The `service.Retrieve` method retrieves existing personal report.
2. Set `IsPersonal` parameter to false.
3. The `service.Update` method makes the report available for the organization.
4. Set `IsPersonal` parameter to true. This makes the report unavailable for the organization.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]