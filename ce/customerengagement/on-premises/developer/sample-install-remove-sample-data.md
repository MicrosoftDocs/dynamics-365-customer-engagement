---
title: "Sample: Install or remove sample data (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Sample code to install standard sample data for Customer Engagement (on-premises)."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: ab035539-7158-4efb-ad4c-86cb87eb2e0f
author: JimDaly
ms.author: nabuthuk
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 20
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Install or remove sample data

This sample shows how to install or uninstall the sample data for an organization by using the [InstallSampleDataRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.installsampledatarequest?view=dynamics-general-ce-9) message. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/InstallOrRemove).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `InstallSampleDataRequest` message is intended to be used in a scenario where it contains data that is needed to install the sample data.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.

### Demonstrate

1. Prompts users to install or remove sample data.
2. If the user opts to install sample data, the `InstallSampleDataRequest` message installs the sample data.
3. If the user opts to uninstall the sample data, the `UninstallSampleDataRequest` message removes the sample data.

### Clean up

Display an option to delete the records in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]