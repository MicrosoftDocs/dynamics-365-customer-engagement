---
title: "Sample: Retrieve all charts attached to an entity (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to retrieve all the organization-owned visualizations attached to an entity by using the IOrganizationService.QueryBase) method. "
keywords:

ms.custom:
ms.topic: sample
applies_to:
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 4ee28c9c-4d78-47b1-911b-782527bcda45
author: JimDaly
ms.author: nabuthuk
ms.reviewer: pehecke
ms.suite:
ms.tgt_pltfrm:
caps.latest.revision: 28
topic-status: Drafting
search.audienceType:
  - developer
---

# Sample: Retrieve all charts attached to an entity

This sample shows how to retrieve all the organization-owned visualizations attached to an entity by using the [IOrganizationService.RetrieveMultiple](/dotnet/api/microsoft.xrm.sdk.iorganizationservice.retrievemultiple) method.

You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/CSharp/RetrieveChartsAttachedToEntity).

[!include[cc-sample-note](../includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](../includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `IOrganizationService` message is intended to be used in a scenario where it contains data that provides programmatic access to the metadata and data for an organization.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

The `newSavedQuery` method creates a query for retrieving all organization-owned visualizations that are attached to the account entity.

### Clean up

This sample creates no records. No cleanup is required.

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
