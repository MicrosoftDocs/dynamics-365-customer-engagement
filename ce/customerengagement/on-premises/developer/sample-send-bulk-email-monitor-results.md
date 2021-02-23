---
title: "Sample: Send bulk email and monitor results (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to send bulk email using the SendBulkMailRequest and monitor the results by retrieving records from the AsyncOperation entity"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 1caed83f-a80f-4abe-8f03-b1c79cc84051
caps.latest.revision: 14
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Send bulk email and monitor results

This sample shows how to send bulk email using the <xref:Microsoft.Crm.Sdk.Messages.SendBulkMailRequest> and monitor the results by retrieving records from the `AsyncOperation` entity. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/BulkEmail).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `SendBulkMailRequest` message is intended to be used in a scenario to send bulk emails.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org
1. The `Contact` method creates 2 contact records for this sample.

### Demonstrate

1. Gets the system user to use as the sender.
2. Set tacking id for the bulk email request.
3. Creates a query expression for the bulk operation to retrieve the contacts in the email list.
4. Set the regarding id and execute the bulk email request.
5. Retrieve the bulk email async operation and monitor it via polling.

### Clean up

Display an option to delete the records created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]