---
title: "Sample: Query connections by a record (early bound) | MicrosoftDocs"
description: "The sample demonstrates how to query connections for a particular record after creating connections between a contact and two accounts."
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
  - sample for querying connections for a particular record
  - querying connections for a particular record, sample
ms.assetid: b1155815-cab2-459f-b363-2b337dcfb453
caps.latest.revision: 14
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Query connections by a record (early bound)

This sample shows how to query connections for a particular record. It creates connections between a contact and two accounts, and then searches for the contact’s connections. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/QueryByRecord).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample creates account and contact records and creates connection roles between them. The `QueryExpression` retrieves the connections for a particular record.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Defines some anonymous types to define the range of possible connection property values.
3. The `ConnectionRole` creates a connection role.
4. The `ConnectionRoleObjectType` creates a connection role object type code record for account entity. 
5. Creates few account and contact records for use in the connection.

### Demonstrate

The `QueryExpression` retrieves all the connections associated with the contact created in the sample.

### Clean up

Display an option to delete the records in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]