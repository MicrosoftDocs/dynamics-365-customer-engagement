---
title: "Sample: Create a connection (early bound)| MicrosoftDocs"
description: "The sample demonstrates how to create a connection between an account and a contact that have matching connection roles."
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
  - sample for creating connections, between accounts and contacts that have matching connection roles
  - creating connections between accounts and contacts that have matching connection roles, sample
ms.assetid: b638e13f-c1bc-400e-8122-217cc31d6850
caps.latest.revision: 15
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Create a connection (early bound)

This sample shows how to create a connection between an account and a contact entity that have matching connection roles. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ConnectionEarlyBound). 

[!include[cc-sample-note](includes/cc-sample-note.md)]
  
## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample shows how to create a connection between an account and a contact that have matching connection roles.  

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Creates a connection role for account and contact entity.
3. Creates a related connection role object type code for account and contact entity.
4. Associates the connection role with itself.

### Demonstrate

1. Creates a connection between account and contact entity. 
2. Assigns a connection role to a record.

### Clean up

Display an option to delete the records created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]