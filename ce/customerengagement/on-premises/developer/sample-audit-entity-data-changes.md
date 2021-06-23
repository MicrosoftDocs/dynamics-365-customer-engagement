---
title: "Sample: Audit entity data changes | MicrosoftDocs"
description: "Sample demonstrating how to audit entity data changes."
keywords: 
ms.date: 03/29/2019
ms.service: crm-online
ms.custom: audit
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: d30356c5-da29-4466-8356-ec3d1acad578
author: JimDaly
ms.author: nabuthuk
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - sample for audit entity data changes
  - auditing entity data changes in Microsoft Dynamics CRM, sample for audit entity data changes
  - sample for enabling and disabling auditing, on entities and their attributes
  - enabling and disabling auditing sample, on entities and their attributes
  - audit entity data changes sample
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Audit entity data changes

This sample shows how to enable and disable auditing on an entity and its attributes, retrieve the data change history of the audited entity, and delete the audit records. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/AuditEntityData).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `RetrieveRecordChangeHistoryRequest` message is intended to be used in a scenario where it contains data that is needed to retrieve the audit history for an entity.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Creates an sample account entity.

### Demonstrate

1. Gets the organization's ID from the system user record.
2. Enabling auditing on organization and also on the sample account entity.
3. The `RetrieveRecordChangeHistoryRequest` retrieves the audit history for the account entity and displays the result.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]