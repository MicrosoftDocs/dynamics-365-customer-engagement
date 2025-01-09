---
title: "Sample: Get report history limit | MicrosoftDocs"
description: "This sample shows how to get report history limit"
ms.custom:
ms.reviewer: pehecke

ms.suite:
ms.tgt_pltfrm:
ms.topic: sample
applies_to:
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 69763a0a-af67-48b8-adf2-470c1cdf6196
caps.latest.revision: 22
author: JimDaly
ms.author: nabuthuk
search.audienceType:
  - developer
---

# Get report history limit

This sample shows how to get report history limits using the [GetReportHistoryLimitRequest](/dotnet/api/microsoft.crm.sdk.messages.getreporthistorylimitrequest?view=dynamics-general-ce-9&preserve-view=true) message. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/CSharp/GetReportHistoryLimit).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `GetReportHistoryLimitRequest` message is intended to be used in a scenario where it contains data that is needed to retrieve the history limit for a report.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. The `QueryByAttribute` method queries for an existing report.
2. The `GetReportHistoryLimitRequest` method gets the history limit data.

### Clean up

No clean up is required for this sample.

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
