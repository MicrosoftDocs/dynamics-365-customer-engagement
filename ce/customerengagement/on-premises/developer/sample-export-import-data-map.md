---
title: "Sample: Export and import a data map| MicrosoftDocs"
description: "Sample demonstrates how to create an import map, export it as XML-formatted data, import modified mappings, and create a new import map based on the imported mappings."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 66255050-1a19-4bd2-a839-3cc45e7947d8
author: JimDaly
ms.author: nabuthuk
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - sample for exporting and importing data maps
  - exporting and importing data maps sample
  - importing data in Microsoft Dynamics CRM, sample for exporting and importing data maps
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Export and import a data map

This sample shows how to create an import map (data map) in Dataverse, export it as an XML formatted data, import modified mappings, and create a new import map Dataverse based on the imported mappings. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ExportImportDataMap).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `BulkDeleteRequest` message is intended to be used in a scenario where it contains data that is needed to create the bulk delete request.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org. 
2. The `CreateImportMapping` method creates the import mapping record.
3. The `RetrieveMappingXML` method exports the mapping that is created.
4. The `ChangeMappingName` method parse the xml to change the name attribute.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]