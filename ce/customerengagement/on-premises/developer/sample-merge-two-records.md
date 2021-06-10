---
title: "Sample: Merge two records | MicrosoftDocs"
description: "The sample demonstrates how to merge two records. "
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
  - merging records sample
  - records, sample for merging
ms.assetid: 41f7666e-de15-4567-b856-d34440b743af
caps.latest.revision: 15
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Merge two records

This sample shows how to merge two record. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/MergeTwoRecords).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `MergeRequest` message is intended to be used in a scenario where it contains the data that’s needed to merge the information from two entity records of the same type.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. The `CreateRequiredRecords` method creates any entity records that this sample requires.

### Demonstrate

1. The `MergeRequest` method creates the request. 
2. The `Account` message creates another account to hold new data to merge into the entity.


### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]