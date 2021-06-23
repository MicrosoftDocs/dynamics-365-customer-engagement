---
title: "Sample: Retrieve email attachments for an email template (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to retrieve email attachments associated with an email template by using the IOrganizationService.QueryBase) method"
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
  - sample for retrieving email attachments associated with email templates, activity entities
  - activity entities samples, retrieving email attachments associated with email templates
ms.assetid: 4efd5301-9f7b-426d-b2f8-54c71ed04585
caps.latest.revision: 26
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Retrieve email attachments for an email template

This sample shows how to retrieve email attachments associated with an email template by using the [IOrganizationService.RetrieveMultiple](/dotnet/api/microsoft.xrm.sdk.iorganizationservice.retrievemultiple?view=dynamics-general-ce-9) method. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/RetrieveEmailAttach).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `IOrganizationService.RetrieveMultiple` method is intended to be used in a scenario where it retrieves a collection of records.


## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Creates a sample email template using the `Template` method.

### Demonstrate

The `QueryExpression` retrieves all the attachments.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]