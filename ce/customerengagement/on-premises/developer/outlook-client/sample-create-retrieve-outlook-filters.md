---
title: "Sample: Create and retrieve Outlook filters (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
ms.custom: 
ms.date: 01/28/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 72fd6888-2e5d-47a2-a1d3-f391e4d9f086
caps.latest.revision: 21
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Create and retrieve Outlook filters

This sample shows how to retrieve filters for Microsoft Dynamics 365 for Outlook. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/CreartRetrieveOutlookFilters).

[!include[cc-sample-note](../includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](../includes/cc-how-to-run-PA-samples.md)]

## How this sample works

In order to simulate the scenario described above, the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. The `fetchXml` method creates asn retrieves offline filter. In your Outlook client, this will appear in System Filters tab under **File -> CRM -> Synchronize -> Outlook Filters**.
2. The `InstantiateFiltersRequest` method activates the selected offline templates for the current user.
3. The `ResetUserFilterRequest` method resets the current user's offline templates to the defaults.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.

### See also  
 [Extend Dynamics 365 for Outlook](../extend-customer-engagement-outlook.md)   
 [Sample: Use Outlook Methods](sample-outlook-methods.md)   
 [Offline and Outlook Filters and Templates](offline-outlook-filters-templates.md)   
 [SavedQuery Entity](../entities/savedquery.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]