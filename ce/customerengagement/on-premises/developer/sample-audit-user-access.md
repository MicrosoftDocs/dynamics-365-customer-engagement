---
title: "Sample: Audit user access | MicrosoftDocs"
description: "Sample demonstrating the auditing of user access to records."
keywords: 
ms.date: 03/29/2019
ms.service: crm-online
ms.custom: audit
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: db508858-7386-44f3-9f91-29493e6fe2c4
author: JimDaly
ms.author: nabuthuk
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - auditing entity data changes in Microsoft Dynamics CRM, sample for auditing user access
  - sample for auditing user access
  - auditing user access sample
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Audit user access

This sample code shows how to audit user access. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/AuditUserAccess).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample first enables user access auditing with the logged on user's organization. Next, it creates and modifies an account entity so that audit records are genertated.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. Creates a new account entity and enables auditing on the new account entity.

### Demonstrate

1. Gets the organization's ID from the system user record and retrieves organization record.
2. Enables auditing on the organization, including auditing for user access.
3. Makes an update request to the account entity to be tracked by auditing.
4. set the organization and account auditing flags back to old values and retrieve them if they were actually changed.

### Clean up

Display an option to delete the records created during [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]