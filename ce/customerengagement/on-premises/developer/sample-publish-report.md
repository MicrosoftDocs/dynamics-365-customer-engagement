---
title: "Sample: Publish reports | MicrosoftDocs"
description: "This sample shows how to publish a report"
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

# Publish reports

This sample shows how to publish a report by creating a **Report** record and the related records that make it visible. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/PublishReport).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## How this sample works

In order to simulate the scenario described above, the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. The `Report` method instantiates the report object.
2. The `ReportCategory` method sets the report category te report should belong to.
3. The `ReportEntity` method defines which entity this report uses.
4. The `ReportVisibility` method sets the report visibility.

### Clean up

No clean up is required for this sample.

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]