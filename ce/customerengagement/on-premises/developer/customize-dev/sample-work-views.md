---
title: "Sample: Work with views (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to perform various actions on views. "
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
  - working with views sample
  - performing actions on views sample
  - sample for performing actions on views
  - customizing entity views in Microsoft Dynamics CRM sample, working with views
  - sample for working with views
ms.assetid: bb59d373-0d8c-48c0-86e4-bc7ff6d240ce
caps.latest.revision: 13
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Work with views

This sample shows how to perform various actions on views.  You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/WorkWithViews). 

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

1. The `layoutXml` method creates a layout for the view on the account entity.
2. The `fetchXml` method creates a view on the account entity.
3. The `SavedQuery` method saves the newly created view.

### Clean up

Display an option to delete the records created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.
 
  
### See also  
 [Customize Entity Views in Microsoft Dynamics 365 Customer Engagement](customize-entity-views.md)    
 [SavedQuery Entity](../entities/savedquery.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]