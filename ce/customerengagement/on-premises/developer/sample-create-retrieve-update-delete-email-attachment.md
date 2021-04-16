---
title: "Sample: Create, retrieve, update, and delete an email attachment| Microsoft Docs"
description: "This sample shows how to create, retrieve, update, and delete email attachments using methods such as IOrganizationService.Entity, IOrganizationService.ColumnSet, IOrganizationService.Entity, IOrganizationService.Guid"
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
  - sample for creating; retrieving; updating; and deleting email attachments, activity entities
  - activity entities samples, creating; retrieving; updating; and deleting email attachments
ms.assetid: 918c0b7e-2850-40c5-8333-5dad6d83b850
caps.latest.revision: 22
author: Nkrb
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Create, retrieve, update, and delete an email attachment

This sample shows how to create, retrieve, update, and delete email attachments using the following methods:

- [IOrganizationService.Create](/dotnet/api/microsoft.xrm.sdk.iorganizationservice.create?view=dynamics-general-ce-9)
- [IOrganizationService.Retrieve](/dotnet/api/microsoft.xrm.sdk.iorganizationservice.retrieve?view=dynamics-general-ce-9)
- [IOrganizationService.Update](/dotnet/api/microsoft.xrm.sdk.iorganizationservice.update?view=dynamics-general-ce-9)
- [IOrganizationService.Delete](/dotnet/api/microsoft.xrm.sdk.iorganizationservice.delete?view=dynamics-general-ce-9)

You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/CRUDEmailAttachments).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `IOrganizationService` message is intended to be used in a scenario that provides programmatic access to the metadata and data for an organization.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. The `Email` method creates email activity that is required for the sample.

### Demonstrate

1. The `ActivityMimeAttachment` method creates three email attachments. 
1. The `Retrieve` method retrieves an attachment including its ID, subject, filename, and body.
1. The `Update` method updates the filename of the existing attachment.


### Clean up

Display an option to delete the records created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]