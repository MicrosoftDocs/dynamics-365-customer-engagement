---
title: "Sample: Download report definition | MicrosoftDocs"
description: "This sample shows how download report definition."
ms.custom: 
ms.date: 01/28/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 69763a0a-af67-48b8-adf2-470c1cdf6196
caps.latest.revision: 22
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---

# Download report definition

This sample shows how to download a report definition (.rdl) file by using the [DownloadReportDefinitionRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.downloadreportdefinitionrequest?view=dynamics-general-ce-9) message. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/DownloadReportDefinition).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `DownloadReportDefinitionRequest` message is intended to be used in a scenario where it contains the data that is needed to download a report definition.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. The `QueryByAttribute` method  queries for an existing report.
2. The `DownloadReportDefinitionRequest` method downloads  the report definition.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]