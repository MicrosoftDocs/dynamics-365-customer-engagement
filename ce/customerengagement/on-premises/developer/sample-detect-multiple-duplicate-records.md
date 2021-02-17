---
title: "Sample: Detect multiple duplicate records | MicrosoftDocs"
description: "Sample demonstrates how to detect and log multiple duplicate records for a specified entity type."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 5c83c1c2-25ef-480b-9195-6eabe9f6c4c7
author: JimDaly
ms.author: nabuthuk
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 13
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Detect multiple duplicate records

This sample shows how to detect and log multiple duplicate records for a specified entity type. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/DetectMultipleDuplicateRecords).


[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `BulkDetectDuplicatesRequest` message is intended to be used in a scenario that contains data that is needed to submit an asynchronous system job that detects and logs multiple duplicate records.
## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. The `CreateRequiredRecords` class creates some duplicate entity records for the sample.
1. The `DuplicateRule` method creates a duplicate detection rule.
1. The  `DuplicateRuleCondition` method creates a duplicate detection rule condition for detecting duplicate records.
1. The `PublishDuplicateRuleRequest` method publishes the duplicate detection rule.
1. The `PublishDuplicateRuleRequest` returns before the publish is completed, so we keep retrieving the async job state until it is `Completed`

### Demonstrate

The `BulkDetectDuplicatesRequest` method creates the BulkDetectDuplicatesRequest object

### Clean up

Display an option to delete the records created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]