---
title: "Sample: Work with activity party records (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to work with activity party records"
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
  - sample for using activity party records, activity entities
  - activity entities samples, using activity party records
ms.assetid: 8053c3d9-227a-4617-b50f-727dd7afc3a0
caps.latest.revision: 12
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Work with activity party records

This sample code shows how to work with activity party records. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ActivityPartyRecords).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample creates some sample data, to work with activity party records. 

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. Creates three contact records which are required for this sample.


### Demonstrate

1. Retrieves the contact records that are created in the [Setup](#setup). 
2. Creates the activity party records for each contact.
3. Also creates Letter activity and set **From** and **To** fields to the respective Activity Party entities.

### Clean up

Display an option to delete the records created during [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]