---
title: "Sample: Use Dynamics 365 for Outlook methods (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
ms.custom: 
ms.date: 01/28/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: b739acc8-d4b9-423e-983f-3e70e01ec37b
caps.latest.revision: 21
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---

# Sample: Use Dynamics 365 for Outlook methods

This sample shows how to use the methods available in the [Microsoft.Crm.Outlook.Sdk.dll](https://docs.microsoft.com/dotnet/api/microsoft.crm.outlook.sdk?view=dynamics-outlookclient-ce-9) assembly. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/UseOutlookMethods).

[!include[cc-sample-note](../includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](../includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `Microsoft.Crm.Outlook.sdk` assembly is used in a scenario where it contains types that provide programmatic interaction with Microsoft Dynamics 365 for Outlook and Microsoft Dynamics 365 for Microsoft Office Outlook with Offline Access.

## How this sample works

In order to simulate the scenario described above, the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. The `CrmOutlookService` method sets up the service.
2. The `CrmOutlookService.IsCrmClientOffline` method checks if the client is offline.
3. The `CrmOutlookService.GoOnline()` method takes the client to online. This method will automatically sync up with database, there is no need to call the `Sync()` method.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.
  
### See also  
 [Extend Dynamics 365 for Outlook](../extend-customer-engagement-outlook.md)   
 <xref:Microsoft.Crm.Outlook.Sdk.CrmOutlookService>   
 <xref:Microsoft.Crm.Outlook.Sdk.CrmOutlookService.GoOnline>   
 <xref:Microsoft.Crm.Outlook.Sdk.CrmOutlookService.GoOffline>


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]