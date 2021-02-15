---
title: "Sample: Create a connection role (early bound)| MicrosoftDocs"
description: "The sample code demonstrates how to create a connection role that are used for accounts and contacts."
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
  - sample for creating connection roles, accounts and contacts
  - creating connection roles, sample
ms.assetid: d501cdfa-67b0-4e59-a05c-1817528971e1
caps.latest.revision: 14
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Create a connection role (early bound)

This sample shows how to create a connection role that can be used for accounts and contacts. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ConnectionRole).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample shows how to create a connection role that can be used for accounts and contacts.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. Defines some anonymous types to define the range of possible connection property values.
2. Creates a connection role for account and contact entity.
3. Creates a connection role object type code record for account and contact entity.

### Clean up

Display an option to delete the records in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]