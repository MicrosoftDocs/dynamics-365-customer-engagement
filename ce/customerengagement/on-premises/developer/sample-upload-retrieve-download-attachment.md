---
title: "Sample: Upload, retrieve, and download an attachment | Microsoft Docs"
description: "The sample demonstrates how to upload, retrieve, and download an attachment for an annotation using the IOrganizationService.Entity) and IOrganizationService.ColumnSet) methods. "
ms.custom: 
ms.date: 11/24/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - uploading; retrieving; and downloading attachments sample, sample for the annotation (note) entity
  - sample for uploading; retrieving; and downloading attachments, annotation (note) entity sample
ms.assetid: a231c619-7130-43f0-b3da-fd1a87545672
caps.latest.revision: 19
author: Nkrb
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Upload, retrieve, and download an attachment

This sample shows how to upload, retrieve, and download an attachment for an annotation using the [IOrganizationService.Create](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.iorganizationservice.create?view=dynamics-general-ce-9) and [IOrganizationService.Retrieve](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.iorganizationservice.retrieve?view=dynamics-general-ce-9) methods. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/URDAttachment).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `IOrganizationService` method is intended to be used in a scenario where it provides programmatic access to the metadata and data for an organization.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. The `Annotation` method instantiates an annotation object.
1. The `IOrganizationService` method creates and uploads the annotation object

### Clean up

Displays an option to delete all the data created in the sample. The deletion is optional in case you want to examine the data created by the sample. You can manually delete the data to achieve same results.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]