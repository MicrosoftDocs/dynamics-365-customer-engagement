---
title: "Sample: Rollup records related to a specific record (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample demonstrates how to roll up opportunities by the parent account. "
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
  - related records sample, rolling up
  - rolling up records sample
ms.assetid: 59c8a58c-1add-4c29-915f-8aa0ae07f30c
caps.latest.revision: 16
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Rollup records related to a specific record

This sample shows how to roll up opportunities by the parent account. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/RollupSpecificRecords).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `RollupRequest` message is intended to be used in a scenario where it contains data that is needed to create a roll up request.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Creates sample account and opportunity records.

### Demonstrate

1. The `QueryExpression` queries the opportunities by parent account.
2. The `RollupRequest` creates the roll up request.

### Clean up

Display an option to delete the records in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]