---
title: "Sample: Quick start for Dynamics 365 Customer Engagement (on-premises) (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Dynamics 365 Customer Engagement (on-premises) and perform basic create, update, retrieve, and delete operations on an entity. "
ms.custom: 
ms.date: 01/29/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0f1b28e3-0db0-4150-9c3b-d65daf0fabc5
caps.latest.revision: 19
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Quick start for Dynamics 365 Customer Engagement

This sample shows you how to compile and run a program that creates an account record, retrieves the record, updates the record, and then prompts to see if you would like the record deleted. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/QuickStartForDynamics365).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample shows how to perform CRUD operation on an entity.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. The `WhoAMIRequest` method gets the current user's information.
2. The `Account` method creates a sample account record.

### Clean up

Display an option to delete the sample data created. The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.

### See also

[Tutorials for Learning About Dynamics 365 Customer Engagement Development apps](tutorials-resources-sdk.md)<br />
[Sample: Simplified Connection Quick Start using Dynamics 365 Customer Engagement (on-premises)](xrm-tooling/sample-simplified-connection-quick-start.md)<br />



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]