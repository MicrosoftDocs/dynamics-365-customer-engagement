---
title: "Sample: Import data using complex data map (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Sample demonstrates how to create new records with data import by using a complex data map."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 1ed89b35-a84d-488e-b58c-4ed6eb26018c
author: JimDaly
ms.author: nabuthuk
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - importing data in Microsoft Dynamics CRM, sample for importing data by using complex data maps
  - sample for importing data by using complex data maps
  - sample for creating new records in Microsoft Dynamics CRM by using data import
  - importing data in Microsoft Dynamics CRM, sample for creating new records in Microsoft Dynamics CRM by using data import
  - creating new records in Microsoft Dynamics CRM by using data import sample
  - importing data by using complex data maps sample
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Import data using complex data map

This sample shows how to create new records by using data import. The sample uses a complex data map. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ImportComplexDataMap).

>[!NOTE]
> The source data for this sample is contained in the following file `ImportComplexDataMap\import accounts.csv`.

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## How this sample works

In order to simulate the scenario described above, the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. The `ImportMap` method creates an import map.
1. The `ColumnMapping` method creates a column mapping for a `text` type field.
1. The `EntityReference` method relates the column mapping with the data map.
1. The `LookUpMapping` method creates a lookup mapping to the parent account.
1. The `ImportFile` method creates a import file.
1. The `GetHeaderColumnsImportFileRequest` method retrieves the header columns used in the import file.
1. The `ParseImportRequest` method parses the import file. 
1. The `RetrievedParsedDataImportFileRequest` method retrieves the data from the parse table.
1. The `TransformImportRequest` method transforms the import.


### Clean up

Display an option to delete the records created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]